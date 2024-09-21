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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }
        public string tc;
        public string adSoyad; 

        SqlBaglantisi bgl = new SqlBaglantisi();
        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            label_TCNO.Text = tc;
            //ad soyad çekme
            SqlCommand komut = new SqlCommand("Select HastaAd,HastaSoyad From Tbl_Hastalar where HastaTC = '"+ tc +"'",bgl.baglanti());
         //   komut.Parameters.AddWithValue("@p1", tc);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label_AdSoyad.Text = dr[0] + " " + dr[1]; 
            }
            bgl.baglanti().Close();

            //randevu geçmişi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where HastaTC = '" + tc +"'", bgl.baglanti());
            da.Fill(dt);
            dataGridView_Gecmis.DataSource = dt;
            bgl.baglanti().Close();

            //branşları çekme
            SqlCommand komut2 = new SqlCommand("Select BransAd from Tbl_Branslar",bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            
            while (dr2.Read()) 
            { 
            comboBox_Brans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

            
        }

        private void comboBox_Doktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Randevular where RandevuBrans='"+comboBox_Brans.Text+"'and RandevuDoktor='"+comboBox_Doktor.Text+"'",bgl.baglanti());
            da.Fill(dt);
            dataGridView_Aktif.DataSource = dt;   
        }

        private void comboBox_Brans_SelectedIndexChanged(object sender, EventArgs e)
        {
            //doktor çekme
            comboBox_Doktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar Where DoktorBrans=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", comboBox_Brans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                comboBox_Doktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void link_BilgiDüzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBigiDüzenle fr = new FrmBigiDüzenle();
            fr.TC = label_TCNO.Text;
            fr.Show();

        }

       

        private void button_RandevuAl_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Randevular Set RandevuDurum=1,HastaTC=@p1,HastaSikayet=@p2 where Randevuid=@p3",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",label_TCNO.Text);
            komut.Parameters.AddWithValue("@p2",richTextBox_Sikayet.Text);
            komut.Parameters.AddWithValue("@p3",textBox_id.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu alındı");
        }

        private void dataGridView_Aktif_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView_Aktif.SelectedCells[0].RowIndex;
            textBox_id.Text = dataGridView_Aktif.Rows[secilen].Cells[0].Value.ToString();

        }
    }
}
