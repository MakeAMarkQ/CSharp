using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCDCompare
{
    public partial class Frm_PcdCompare : Form
    {
        private DataSet DSCompare=new DataSet();
        DataView DV_Compare = new DataView();
        private DataTable DTCompare = null;
        private String XMLfile = "\\Measured.xml";
        private String StrPolku = "";
        public Frm_PcdCompare()
        {
            InitializeComponent();
        }
        private void ReadList()
        {
            DV_Compare = new DataView(DSCompare.Tables[0]);
            DataTable dt = DV_Compare.ToTable(true, "FN");
            //DataRow[] result = DTCompare.rowf;
            List<string> ls = dt.AsEnumerable().Select(x => x[0].ToString()).ToList();

            foreach (string e in ls)
                ChkLstBx_PcdC.Items.Add(e);
            DataTable dz = DV_Compare.ToTable(true, "Z");
            List<int> lz = (from row in dz.AsEnumerable() select Convert.ToInt32(row["Z"])).ToList();
            TckBr_Z.Maximum = lz.Max();
            TckBr_Z.Minimum = lz.Min();
            TckBr_Z.Value = TckBr_Z.Maximum;
            DataTable dx = DV_Compare.ToTable(true, "X");


            List<int> lx = (from row in dx.AsEnumerable() select Convert.ToInt32(row["X"])).ToList();
            //List<string> lx = dx.AsEnumerable().Select(x => x[0].ToString()).ToList();
            //int xMx;
            TckBr_X.Maximum = lx.Max();
            //int xMn
            TckBr_X.Minimum = lx.Min();
            DataTable dy = DV_Compare.ToTable(true, "y");
            //DataRow[] result = DTCompare.rowf;
            //List<string> ly = dy.AsEnumerable().Select(x => x[0].ToString()).ToList();
            List<int> ly = (from row in dy.AsEnumerable() select Convert.ToInt32(row["Y"])).ToList();
            TckBr_Y.Maximum = ly.Max();
            TckBr_Y.Minimum = ly.Min();
            object eka = new object();
            EventArgs toka = new EventArgs();
            TckBr_X_ValueChanged(eka, toka);

            TckBr_Y_ValueChanged(eka, toka);

            //ChkLstBx_PcdC
        }
        private void TSBtn_Path_Click(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
            // Show the FolderBrowserDialog
            string[] filePaths=null;
            var FBD = new FolderBrowserDialog();
            FBD.SelectedPath=@"F:\kelikello";
            DialogResult result = FBD.ShowDialog();
            if (result == DialogResult.OK)
            {
                StrPolku = FBD.SelectedPath;

                if (File.Exists(FBD.SelectedPath + XMLfile))
                {
                    DSCompare.ReadXml(StrPolku + XMLfile);

                }
                else
                {
                    DTCompare = new DataTable("Paikat");
                    DTCompare.Columns.Add("X", typeof(int));
                    DTCompare.Columns.Add("Y", typeof(int));
                    DTCompare.Columns.Add("Z", typeof(int));
                    DTCompare.Columns.Add("FN", typeof(string));
                    //Tiedostojen luku
                    String strPath = "*.pcd";
                    filePaths = Directory.GetFiles(FBD.SelectedPath, strPath);
                }
            }
            //no xml file
            if (filePaths != null)
            {
                foreach (String strFile in filePaths)
                {
                    String[] strLines = File.ReadAllLines(strFile);
                    bool bAscii = false;
                    foreach (String strLine in strLines)
                    {
                        if(true== bAscii)
                        {
                            String[] strVals = strLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                            int X;
                            if (Int32.TryParse(strVals[0], out X))
                            {
                                int y;
                                if (Int32.TryParse(strVals[1], out y))
                                {
                                    int z;
                                    if (Int32.TryParse(strVals[2], out z))
                                    {
                                        DTCompare.Rows.Add(X, y, z, strFile);
                                    }
                                }
                            }
                            else
                            {
                                //Console.WriteLine("String could not be parsed.");
                            }
                        }//if(true== bAscii)
                        if ("DATA ASCII" == strLine)
                            bAscii = true;
                    }//foreach (String strLine in strLines)
                    SSabel_PCDCompare.Text = strFile;
                    SStrp_PcdCompare.Refresh();
                    //Console.WriteLine(strFile + " OK");
                }
                DSCompare.Tables.Add(DTCompare);
                DSCompare.WriteXml(StrPolku + XMLfile);

            }
            SSabel_PCDCompare.Text = "All ok.";
            ReadList();
            Cursor.Current = Cursors.Default;
            //Console.WriteLine("Al ok.");
        }//TSBtn_Path_Click

        private void TckBr_X_ValueChanged(object sender, EventArgs e)
        {
            int my = TckBr_Y.Maximum - TckBr_Y.Minimum;
            int mz = TckBr_Z.Maximum - TckBr_Z.Minimum;
            Bitmap yzKuva = new Bitmap(my, mz);
            DV_Compare.Sort = "Y";
            DV_Compare.RowFilter = "X = "+TckBr_X.Value;
            DataTable dy = DV_Compare.ToTable(true, "Y");
            List<int> ly = (from row in dy.AsEnumerable() select Convert.ToInt32(row["Y"])).ToList();
            ly.Sort();
            for (int j=0;j< DV_Compare.Count;j++)
            {
                int Y = int.Parse(DV_Compare[j]["Y"].ToString()) - TckBr_Y.Minimum;
                int Z = TckBr_Z.Maximum - int.Parse(DV_Compare[j]["Z"].ToString());
                for(int yz=0;yz<Z;yz++)
                    yzKuva.SetPixel(Y, yz, Color.Black);
            }
            PicBx_X.Image = yzKuva;
        }

        private void TckBr_Y_ValueChanged(object sender, EventArgs e)
        {
            int mx = TckBr_X.Maximum - TckBr_X.Minimum;
            int mz = TckBr_Z.Maximum - TckBr_Z.Minimum;
            Bitmap xzKuva = new Bitmap(mx, mz);
            DV_Compare.Sort = "Y";
            DV_Compare.RowFilter = "Y = " + TckBr_Y.Value;
            DataTable dy = DV_Compare.ToTable(true, "X");
            List<int> ly = (from row in dy.AsEnumerable() select Convert.ToInt32(row["X"])).ToList();
            for (int j = 0; j < DV_Compare.Count; j++)
            {
                int X = int.Parse(DV_Compare[j]["X"].ToString()) - TckBr_X.Minimum;
                int Z = TckBr_Z.Maximum - int.Parse(DV_Compare[j]["Z"].ToString());
                for (int yz = 0; yz < Z; yz++)
                    xzKuva.SetPixel(X, yz, Color.Black);
            }
            PicBx_Y.Image = xzKuva;
        }
    }
}
