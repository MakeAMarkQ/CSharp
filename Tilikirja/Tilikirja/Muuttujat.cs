using System;
using System.Collections.Generic;
//using System.Data;

namespace Tilikirja
{
    struct ValikkoElementti
    {
        string strValikkoteksti;
        char cKirjain;
    }
    static class Muuttujat
    {
        #region muuttujat
        private static string _strDataTiedosto;
        private static string _strDataTiedostoEdellinen;
        private static string _strIntParseError;
        private static string _strKieli;
        private static string _strNimi;
        private static string _strValintapyyntö;
        private static List<string> _lstAloitusValikko;
        private static List<string> _lstHelppiTeksti;
        #endregion
        #region parametrit
        public static string strDataTiedosto { set { _strDataTiedosto = value; } get { return _strDataTiedosto; } }
        public static string strDataTiedostoEdellinen { set { _strDataTiedostoEdellinen = value; } get { return _strDataTiedostoEdellinen; } }
        public static string strIntParseError { set { _strIntParseError = value; } get { return _strIntParseError; } }
        public static string strKieli { set { _strKieli = value; } get { return _strKieli; } }
        public static string strNimi { set { _strNimi = value; } get { return _strNimi; } }
        public static string strValintapyyntö { set { _strNimi = value; } get { return _strNimi; } }
        public static List<string> lstAloitusValikko { set { _lstAloitusValikko = value; } get { return _lstAloitusValikko; } }
        public static List<string> lstHelppiTeksti { set { _lstAloitusValikko = value; } get { return _lstAloitusValikko; } }
        #endregion
        #region funktiot
        static Muuttujat()
        {
            lstAloitusValikko = new List<string>();
            strKieli = "fi-FI";
            AsetaSuomi();
        }
        internal static void VaihdaKieli(string inKieli)
        {
            strKieli = inKieli;
        }
        static void AsetaSuomi()
        {
            string strVuosi = DateTime.Now.Year.ToString();
            string strEdellinenVuosi = (DateTime.Now.Year-1).ToString();
            strNimi = "Tilikirja - Lite";
            strDataTiedosto = "Tilikirja"+ strVuosi + ".XML";
            strDataTiedostoEdellinen = "Tilikirja" + strEdellinenVuosi + ".XML";
            //First letter any language is COMMAND
            lstAloitusValikko.Add("0 - Poistu");
            lstAloitusValikko.Add("1 - Talleta");
            lstAloitusValikko.Add("2 - Varmista");
            lstAloitusValikko.Add("3 - Ohjeet");
            lstAloitusValikko.Add("4 - Asetukset");
            lstAloitusValikko.Add("5 - Raportit");
            lstAloitusValikko.Add("6 - Lisää tapahtumia");

            strValintapyyntö = "Anna valintasi välitä 0-6";

            strIntParseError = "{0}:n muuttaminen luvuksi epäonnistui, paina Enteriä.";
            lstHelppiTeksti.Add("0 - Poistu\nTällä komennolla poistutaan ohjelmasta");
            lstHelppiTeksti.Add("1 - Talleta\nTällä komennolla talletetaan tiedot tietokantaan");
            lstHelppiTeksti.Add("2 - Varmista\nTällä komennolla tehdään tietokannasta varmuuskappale");
            lstHelppiTeksti.Add("3 - Ohjeet\nEhkei tätä tarvitse selittää");
            lstHelppiTeksti.Add("4 - Asetukset\nEri muuttujien antamispaikka");
            lstHelppiTeksti.Add("5 - Raportit\nTällä saa pää- ja päiväraportit");
            lstHelppiTeksti.Add("6 - Lisää tapahtumia\nTällä täytetään tapahtumat");

        }
        #endregion
    }
}