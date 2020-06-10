using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

namespace RistiNolla
{
    internal class Game
    {
        private int[,] aiRuudukko;
        public Game()
        {
            aiRuudukko = new int[3, 3] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
        }
        internal void playGame()
        {
            int iKierros = 0;
            bool bLoppu = false;
            do
            {
                GUIRuudukko();
                bLoppu = TeeValinta(iKierros);
                if(!bLoppu)
                    GUIRuudukko();
                iKierros++;
            } while (!bLoppu);

        }

        private bool TeeValinta(int iKierros)
        {
            Console.WriteLine("Anna x ja y (00-22)");
            string strVastaus = Console.ReadLine();
            int iX = default;
            int iY = default;
            bool bOkX = int.TryParse(strVastaus[0].ToString(), out iX);
            bool bOkY = int.TryParse(strVastaus[1].ToString(), out iY);
            if (bOkX && bOkY && -1 < iX && -1 < iY && 3 > iX && 3 > iY)
            {
                
                aiRuudukko[iX, iY] = 1+iKierros%2;
                bOkX = Voititko(iX, iY);
            }
            return bOkX;
        }

        private bool Voititko(int inX, int inY)
        {
            bool bLoppu = true;

            if ((aiRuudukko[0, inY] == aiRuudukko[1, inY] && aiRuudukko[1, inY] == aiRuudukko[2, inY])
              || (aiRuudukko[inX, 1] == aiRuudukko[inX, 0] && aiRuudukko[inX, 1] == aiRuudukko[inX, 2])
              || (aiRuudukko[1, 1] == aiRuudukko[0, 0] && aiRuudukko[1, 1] == aiRuudukko[2, 2])
              || (aiRuudukko[1, 1] == aiRuudukko[2, 0] && aiRuudukko[1, 1] == aiRuudukko[0, 2]))
            {
                GUIRuudukko();
                Console.WriteLine("Hurraa. Voitit");
                return bLoppu;
            }

            //Ei voittoa, onko tyhjää
            for (int y = 0; y < 3; y++)
            {
                for (int x = 0; x < 3; x++)
                {
                    if (aiRuudukko[x, y].Equals(0))
                    {
                        bLoppu = false;
                        break;
                    }
                }
                if (!bLoppu) 
                    break;
            }
            if (bLoppu)
            {
                GUIRuudukko();
                Console.WriteLine("Tasapeli");
                return bLoppu;
            }
            return bLoppu;
        }

        private void GUIRuudukko()
        {
            Console.Clear();
            for (int y = 0; y < 3; y++)
            {
                for (int x = 0; x < 3; x++)
                {

                    switch (aiRuudukko[x, y])
                    {
                        case 1:
                            Console.Write("X");
                            break;
                        case 2:
                            Console.Write("C");
                            break;
                        default:
                            Console.Write(".");
                            break;
                    }
                    if (x < 2)
                        Console.Write("|");
                }//for y
                if (y < 2)
                    Console.Write("\n-+-+-\n");
            }//for x
            Console.WriteLine();
        }
    }
}