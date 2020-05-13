using System;

namespace EventApp
{
    public delegate void ViestiKahva(string Viesti, int koko);
    public class Merkkari
    {
        // 2) use delegate in this class as event handler
        public event ViestiKahva viestini;
        public void ViestinLähetys(string viesti)
        {
            // event can also be fired directly from broadcaster!
            viestini?.Invoke(viesti, viestini.GetInvocationList().Length);
        }
    }
    public class Kyyläjä
    {
        string nimi;
        Kyyläjä() { }
        public Kyyläjä(string uusinimi) { nimi = uusinimi; }
        public void Tilaa(Merkkari arg)
        {
            arg.viestini += this.kasitteleViesti;
        }
        public void Pura(Merkkari arg)
        {
            arg.viestini -= this.kasitteleViesti;
        }
        void kasitteleViesti(string viesti, int koko)
        {
            Console.WriteLine($"{nimi} vastaanotti {viesti}n ja jakoi {koko} ihmiselle.");
        }
        public void LähetäViesti(Merkkari arg, string message)
        {
            arg.ViestinLähetys(message);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Merkkari merirosvo = new Merkkari();
            Kyyläjä kyyla1 = new Kyyläjä("kyyla1");
            Kyyläjä kyyla2 = new Kyyläjä("kyyla2");
            Kyyläjä kyyla3 = new Kyyläjä("kyyla2");
            Kyyläjä kyyla4 = new Kyyläjä("kyyla2");
            kyyla1.Tilaa(merirosvo);
            kyyla1.LähetäViesti(merirosvo, "Terve");
            kyyla2.Tilaa(merirosvo);
            kyyla3.Tilaa(merirosvo);
            kyyla4.Tilaa(merirosvo);
            kyyla2.LähetäViesti(merirosvo, "Stau");
            Console.ReadLine();
        }
    }
    
}
 