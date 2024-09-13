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
    public partial class FrmHastaKayit : Form
    {
        public FrmHastaKayit()
        {
            InitializeComponent();
        }
       SqlBaglantisi bgl = new SqlBaglantisi();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Hastalar (HastaAd,HastaSoyad,HastaTC,HastaTelefon,HastaSifre,HastaCinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textbox_Ad.Text);
            komut.Parameters.AddWithValue("@p2", textbox_Soyad.Text);
            komut.Parameters.AddWithValue("@p3", maskedTextBox_TC_NO.Text);
            komut.Parameters.AddWithValue("@p4", maskedTextBox_TEL_NO.Text);
            komut.Parameters.AddWithValue("@p5", textBox_Sifre.Text);
            komut.Parameters.AddWithValue("@p6", comboBox_Cinisyet.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kaydınız gerçekleşmiştir, Şifreniz:" + textBox_Sifre.Text,"Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            
        }
    }
}
