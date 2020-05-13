using Microsoft.VisualBasic.CompilerServices;
using System;
//Tee number guessing game, jossa kone arpoo salaisen luvun välillä 1 ja 100.
//Pelaaja arvaa numeron ja kone vastaa jollain seuraavista tavoista:
//   "Se on isompi kuin arvaus"
//  "Se on pienempi kuin arvaus"
//   "Polttaa kun tulee lähelle (eli ero salaiseen lukuun on 5 tai pienempi)!"
//  "Onnistui! Peli vei sinulta X vuoroa!"
//    Bonustehtävä lisää vielä pelin loputtua toiminta:                  
//   "Uusi peli K/E?"*/
namespace NumberGueeingGame
{
    class Program
    {

        static void Main(string[] args)
        {
            //Initialise Random
            Random rand = new Random();
            //Repeat if K/k not pressed
            Boolean bLopeta = false;
            while(!bLopeta)
            {
                //What to do
                TulostaOhje();
                int iArvauksia = 0;
                // randomise one number from 1-100
                int iArvottu = rand.Next(101);
                Boolean bOikein = false;
                //Start to guessing
                Console.WriteLine("Luku arvottu, anna arvaus");
                do
                {
                    bOikein = Arvaus(iArvottu);
                    iArvauksia++;
                } while (!bOikein);
                //Right answer, do you want new
                Console.WriteLine($"Onnistui! Peli vei sinulta {iArvauksia} vuoroa!");
                Console.WriteLine("Uusi peli K/E?");
                String strJatka=Console.ReadLine();
                //Stop if K pressed, capital dependency removed 
                bLopeta = (strJatka.ToUpper() != "K") ? true : false;
            }

        }
        //The real game part, returns true if right quess given.
        private static bool Arvaus(int iInArvottu)
        {
            //Take the quess, and make it to int (Microsoft.VisualBasic.CompilerServices)
            String strArvaus =Console.ReadLine();
            //make guess string  to int (Microsoft.VisualBasic.CompilerServices)
            int iArvaus = IntegerType.FromString(strArvaus);
            //int iArvaus = Convert.ToInt32(strArvaus);
            //int iArvaus = int.Parse(strArvaus); //Worst choise
            //Boolean bOk=int.TryParse(strArvaus, out int iArvaus)
            //Differens in absolute value
            int iEro = Math.Abs(iInArvottu - iArvaus);
            //Hit return TRUE, near, bigger and smaller returns false.
            if(0==iEro)
            {
                return true;
            }
            else if(5>=iEro)
            {
                Console.WriteLine("Polttaa kun tulee lähelle.");
            }
            else if(iArvaus>iInArvottu)
            {
                Console.WriteLine($"Se on pienempi kuin {iArvaus}.");
            }
            else
            {
                Console.WriteLine($"Se on isompi kuin {iArvaus}.");
            }
            return false;
        }
        
        // Print the quide of program, 
        private static void TulostaOhje()
        {
            Console.WriteLine("Arpon salaisen luvun välillä 1 ja 100.");
            Console.WriteLine("Arvaa numeron ja vastaan,");
            Console.WriteLine("Se on isompi kuin arvaus.");
            Console.WriteLine("Se on pienempi kuin arvaus.");
            Console.WriteLine("Polttaa kun tulee lähelle.(Luku +-5 numeron sisällä)");
            Console.WriteLine("Onnistui! Peli vei sinulta X vuoroa!");
        }
    }
}
