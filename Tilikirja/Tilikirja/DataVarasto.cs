using System;
using System.IO;
using System.Data;

namespace Tilikirja
{
    internal class DataVarasto
    {
        
        private DataSet dsData;
       

        public DataVarasto()
        {
            DataSet dsData = new DataSet();
            if(File.Exists(Muuttujat.strDataTiedosto))
            {
                dsData.ReadXml(Muuttujat.strDataTiedosto);
            }else
            {
                dsData.Tables
            }
        }

        
    
    }
}