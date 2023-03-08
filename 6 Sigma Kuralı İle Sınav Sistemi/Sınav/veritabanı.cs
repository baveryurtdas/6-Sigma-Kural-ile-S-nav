using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Sınav
{
    public class veritabanı
    {
        public SqlConnection Baglan { get; set; }
        public SqlCommand Cmd { get; set; }
        public SqlDataReader Dr { get; set; }
        public veritabanı()
        {
            this.Baglan = new SqlConnection("Data Source=DESKTOP-19P5K9M;Initial Catalog=yazilimyapimi;Integrated Security=True");
            this.Cmd = new SqlCommand();
            
            this.Cmd.Connection = Baglan;
            
        }
    }
}
