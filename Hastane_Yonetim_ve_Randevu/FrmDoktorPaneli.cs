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
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();

        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            //branşları çekme
            SqlCommand komut2 = new SqlCommand("Select BransAd from Tbl_Branslar",bgl.baglanti());
            SqlDataReader dr1 = komut2.ExecuteReader();
            while (dr1.Read())
            {
                comboBox_Brans.Items.Add(dr1[0]);
            }
            bgl.baglanti().Close();

            //doktor listesi
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select * From Tbl_Doktorlar ", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
            bgl.baglanti().Close();

        }

        private void button_Ekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Doktorlar (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTC,DoktorSifre) values (@p1,@p2,@p3,@p4,@p5)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",textBox_Ad.Text);
            komut.Parameters.AddWithValue("@p2", textBox_Soyad.Text);
            komut.Parameters.AddWithValue("@p3", comboBox_Brans.Text);
            komut.Parameters.AddWithValue("@p4", maskedTextBox_TC.Text);
            komut.Parameters.AddWithValue("@p5", textBox_Sifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Yeni Doktor eklendi");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox_Ad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBox_Soyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString(); 
            comboBox_Brans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            maskedTextBox_TC.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            textBox_Sifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from Tbl_Doktorlar where DoktorTC=@s1", bgl.baglanti());
            komut.Parameters.AddWithValue("@s1", maskedTextBox_TC.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt silindi");
        }

        private void button_Guncelle_Click(object sender, EventArgs e)
        {
          //  SqlCommand komut = new SqlCommand("update from Tbl_Doktorlar where DoktorTC");
        }
    }
}
