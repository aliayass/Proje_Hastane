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
    public partial class FrmBigiDüzenle : Form
    {
        public FrmBigiDüzenle()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        public string TC;


        private void FrmBigiDüzenle_Load(object sender, EventArgs e)
        {
            maskedTextBox_TC_NO.Text =TC;
            SqlCommand komut = new SqlCommand("Select * from Tbl_Hastalar where HastaTC='"+TC+"' ", bgl.baglanti());
            SqlDataReader dataReader = komut.ExecuteReader();
            while (dataReader.Read())
            {
                textbox_Ad.Text = (string)dataReader[1];
                textbox_Soyad.Text = (string)dataReader[2];
                maskedTextBox_TEL_NO.Text = (string)dataReader[4];
                textBox_Sifre.Text = (string)dataReader[5];
                comboBox_Cinisyet.Text = (string)dataReader[6];
            }
            bgl.baglanti().Close();
        }

        private void button_guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update Tbl_Hastalar set HastaAd=@p1,HastaSoyad=@p2,HastaTelefon=@p3,HastaSifre=@p4,HastaCinsiyet=@p5 where HastaTC=@p6", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1",textbox_Ad.Text);
            komut2.Parameters.AddWithValue("@p2", textbox_Soyad.Text);
            komut2.Parameters.AddWithValue("@p3", maskedTextBox_TEL_NO.Text);
            komut2.Parameters.AddWithValue("@p4", textBox_Sifre.Text);
            komut2.Parameters.AddWithValue("@p5", comboBox_Cinisyet.Text);
            komut2.Parameters.AddWithValue("@p6",  maskedTextBox_TC_NO.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz güncellendi.");
        }
    }
}
