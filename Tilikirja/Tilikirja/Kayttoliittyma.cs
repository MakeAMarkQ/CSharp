using System;

namespace Tilikirja
{
    internal class Kayttoliittyma
    {
        private bool bAjossa;
        DataVarasto clData;

        public Kayttoliittyma()
        {
            bAjossa = true;
            clData = new DataVarasto();
        }
        internal void Suorita()
        {
            do
            {
                Console.Clear();
                Console.WriteLine(Muuttujat.strNimi);
                Muuttujat.lstAloitusValikko.ForEach(a => { Console.WriteLine(a); });
                Console.WriteLine(Muuttujat.strValintapyyntö);
                string strValinta= Console.ReadLine();
                
                bAjossa = TarkistaJatketaanko(strValinta);
                
            } while (bAjossa);
        }

        private bool TarkistaJatketaanko(string inValinta)
        {
            int iValinta;
            bool bOk = int.TryParse(inValinta, out iValinta);
            if (!bOk)
            {
                Console.WriteLine(Muuttujat.strIntParseError,
                               inValinta ?? "<null>");
                Console.ReadLine();
                return !bOk;
            }
            switch (iValinta)
                {
                case 0: //End WILL BE COMING
                    bOk= false;
                    break;
                case 1: //Save
                    GuiTalletaMuutokset();
                    break;
                case 2: //Backup
                    GuiVarmistaTietokanta();
                    break;
                case 3: //Help
                    GuiApu();
                    break;
                case 4: //Settings
                    GuiAsetukset();
                    break;
                case 5: //Reports
                    GuiNaytaRaportit();
                    break;
                case 6: //Insert event
                    GuiLisaaTapahtuma();
                    break;
            }
            return bOk;
        }

        private bool GuiLisaaTapahtuma()
        {

            return true; 
        }

        private bool GuiNaytaRaportit()
        {
            return true;
        }

        private bool GuiAsetukset()
        {
            return true;
        }

        private bool GuiApu()
        {
            Muuttujat.lstHelppiTeksti.ForEach(a => { Console.WriteLine(a); });
            return true;
        }

        private bool GuiVarmistaTietokanta()
        {
            return true;
        }

        private bool GuiTalletaMuutokset()
        {
            return true;
        }

        internal void Initialize()
        {
            GuiTervehdys();
        }

        private void GuiTervehdys()
        {
            Console.WriteLine(Muuttujat.strNimi);
            
        }


    }
}