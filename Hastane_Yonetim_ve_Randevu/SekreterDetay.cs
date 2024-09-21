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
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }
        public string TC;
        SqlBaglantisi bgl = new SqlBaglantisi();

        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            label_TCNO.Text = TC;

            SqlCommand komut = new SqlCommand("select SekreterAdSoyad from Tbl_Sekreterler where SekreterTC='"+TC+"'",bgl.baglanti()); 
            SqlDataReader dr1 = komut.ExecuteReader();
            while (dr1.Read())
            {
                label_AdSoyad.Text = (string)dr1[0];
            }
            bgl.baglanti().Close();
            
            //branş listesi görüntüle
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Branslar",bgl.baglanti());
            da.Fill(dt1);
            dataGridView_Branslar.DataSource = dt1;
            bgl.baglanti().Close();
            
            //doktor listesi çekme
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (DoktorAd + ' ' + DoktorSoyad) as 'Doktorlar' ,DoktorBrans From Tbl_Doktorlar ", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView_Doktorlar.DataSource = dt2;
            bgl.baglanti().Close();

            //branşları çekme
            SqlCommand komut2 = new SqlCommand("Select BransAd from Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                comboBox_brans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

            //doktor çekme
            SqlCommand komut3 = new SqlCommand("Select (DoktorAd +' '+ DoktorSoyad) From Tbl_Doktorlar" ,bgl.baglanti());
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                comboBox_doktor.Items.Add(dr3[0]);
            }
            bgl.baglanti().Close();
        }

        private void button_Kaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutKaydet = new SqlCommand("insert into Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values (@r1,@r2,@r3,@r4)",bgl.baglanti());
            komutKaydet.Parameters.AddWithValue("@r1", maskedTextBox_tarih.Text);
            komutKaydet.Parameters.AddWithValue("@r2",maskedTextBox_saat.Text);
            komutKaydet.Parameters.AddWithValue("@r3", comboBox_brans.Text);
            komutKaydet.Parameters.AddWithValue("@r4", comboBox_doktor.Text);
            komutKaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("randevu oluşturuldu");
        }

        private void comboBox_brans_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_doktor.Items.Clear();

            SqlCommand komut = new SqlCommand("Select DoktorAd ,DoktorSoyad From Tbl_Doktorlar where DoktorBrans=@b1", bgl.baglanti());
            komut.Parameters.AddWithValue("@b1", comboBox_brans.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox_doktor.Items.Add(dr[0]+" "+ dr[1]);
            }
        }

        private void button_Olustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Duyurular (duyuru) values (@d1)",bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", richTextBox_Duyurular.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru oluşturuldu.");
        }

        private void button_DoktorPaneli_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli frm = new FrmDoktorPaneli();
            frm.Show();
           
        }

       

        private void button_BransPaneli_Click(object sender, EventArgs e)
        {
            FrmBrans frm = new FrmBrans();
            frm.Show();

        }

        private void button_Randevu_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi frm = new FrmRandevuListesi();
            frm.Show();
        }
    }
}
