using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Hastane_Yonetim_ve_Randevu
{
    public partial class FormDoktorDetay : Form
    {
        public FormDoktorDetay()
        {
            InitializeComponent();
        }
        public string TC;
        SqlBaglantisi bgl = new SqlBaglantisi();

        private void button_Duyurular_Click(object sender, EventArgs e)
        {
            Duyurular frm = new Duyurular();
            frm.Show();
        }

        private void FormDoktorDetay_Load(object sender, EventArgs e)
        {
            label_TCNO.Text = TC;
            //ad soyad çekme
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorTC = '" + TC + "'", bgl.baglanti());
            //   komut.Parameters.AddWithValue("@p1", tc);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label_AdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //randevular
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Randevular where RandevuDoktor='"+label_AdSoyad.Text +"'" ,bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
           
        }

        private void button_BilgiDüzenle_Click(object sender, EventArgs e)
        {
            FrmDrBilgiDüzenle frm = new FrmDrBilgiDüzenle();
            frm.TC = TC;
            frm.Show();
            
        }

        private void button_Cıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
