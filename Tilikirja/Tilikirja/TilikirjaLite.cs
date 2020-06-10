using System;

namespace Tilikirja
{
    class TilikirjaLite
    {
        static void Main(string[] args)
        {
            Kayttoliittyma clKayttoliittyma = new Kayttoliittyma();
            clKayttoliittyma.Initialize();
            clKayttoliittyma.Suorita();
        }
    }
}
