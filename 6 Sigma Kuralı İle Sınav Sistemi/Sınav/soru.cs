using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sınav
{
    public class soru
    {
        public string Govde { get; set; }
        public string dogruCevap { get; set; }
        public string yanliscevap1 { get; set; }
        public string yanliscevap2 { get; set; }
        public string yanliscevap3 { get; set; }
        public string yanliscevap4 { get; set; }
        public int SoruID { get; set; }
        private veritabanı Veritabanı;
        public soru()
        {
            veritabanı vt = new veritabanı();
            this.Veritabanı = vt;
        }
           
        public void soruvesecenekatama()
        {

            Veritabanı.Baglan.Open();
            Veritabanı.Cmd.CommandText = "SELECT * FROM dbo.SORULAR ORDER BY NEWID()";
            Veritabanı.Dr = Veritabanı.Cmd.ExecuteReader();
            if (Veritabanı.Dr.Read())
            {
                this.Govde = Veritabanı.Dr["Soru"].ToString();
                this.dogruCevap = Veritabanı.Dr["Cevap1"].ToString();
                this.yanliscevap1 = Veritabanı.Dr["Cevap2"].ToString();
                this.yanliscevap2 = Veritabanı.Dr["Cevap3"].ToString();
                this.yanliscevap3 = Veritabanı.Dr["Cevap4"].ToString();
                this.yanliscevap4 = Veritabanı.Dr["Cevap5"].ToString();
            }
            Veritabanı.Baglan.Close();
        }

    }
    
}
