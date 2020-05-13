using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Meidän nimemme?");
            String strNimenne = Console.ReadLine();
            Console.WriteLine("Minä olen <"+ strNimenne + ">");
            Console.WriteLine("Ikämme?");
            String strIka = Console.ReadLine();
            Console.WriteLine("Minä olen <" + strIka + "> vuotias");
            Console.ReadLine();
        }
    }
}
