using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing;

namespace Hastane_Yonetim_ve_Randevu
{
    internal class SqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source = ayas\\SQLEXPRESS; Initial Catalog = Hastane; Integrated Security = True; TrustServerCertificate = True");
            baglan.Open();
            return baglan;
        }
    }
}
