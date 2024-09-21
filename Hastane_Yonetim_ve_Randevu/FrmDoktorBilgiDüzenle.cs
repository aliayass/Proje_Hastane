using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Hastane_Yonetim_ve_Randevu
{
    public partial class FrmDrBilgiDüzenle : Form
    {
        public FrmDrBilgiDüzenle()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        public string TC;
        private void FrmDrBilgiDüzenle_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from Tbl_Doktorlar where DoktorTC='"+TC+"' ", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                textBox_ad.Text = dr[1].ToString();
                textBox_soyad.Text = dr[2].ToString();
                comboBox_brans.Text = dr[3].ToString();
                textBox_sifre.Text = dr[5].ToString();
            }
            bgl.baglanti().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_Doktorlar set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p4 where DoktorTC='"+TC+"'",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBox_ad.Text);
            komut.Parameters.AddWithValue("@p2", textBox_soyad.Text);
            komut.Parameters.AddWithValue("@p3", comboBox_brans.Text);
            komut.Parameters.AddWithValue("@p4",textBox_sifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz güncellendi");
        }
    }
}
