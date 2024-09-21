namespace Hastane_Yonetim_ve_Randevu
{
    partial class FrmHastaDetay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaDetay));
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_AdSoyad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_TCNO = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.link_BilgiDüzenle = new System.Windows.Forms.LinkLabel();
            this.button_RandevuAl = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox_Sikayet = new System.Windows.Forms.RichTextBox();
            this.comboBox_Doktor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_Brans = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView_Gecmis = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView_Aktif = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Gecmis)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Aktif)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(22, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "TC NO:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_AdSoyad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label_TCNO);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(238, 102);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişi Bilgi";
            // 
            // label_AdSoyad
            // 
            this.label_AdSoyad.AutoSize = true;
            this.label_AdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_AdSoyad.Location = new System.Drawing.Point(89, 56);
            this.label_AdSoyad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_AdSoyad.Name = "label_AdSoyad";
            this.label_AdSoyad.Size = new System.Drawing.Size(69, 17);
            this.label_AdSoyad.TabIndex = 23;
            this.label_AdSoyad.Text = "Ad Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Ad Soyad:";
            // 
            // label_TCNO
            // 
            this.label_TCNO.AutoSize = true;
            this.label_TCNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_TCNO.Location = new System.Drawing.Point(89, 29);
            this.label_TCNO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_TCNO.Name = "label_TCNO";
            this.label_TCNO.Size = new System.Drawing.Size(72, 17);
            this.label_TCNO.TabIndex = 21;
            this.label_TCNO.Text = "00000000";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_id);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.link_BilgiDüzenle);
            this.groupBox2.Controls.Add(this.button_RandevuAl);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.richTextBox_Sikayet);
            this.groupBox2.Controls.Add(this.comboBox_Doktor);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.comboBox_Brans);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(9, 117);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(238, 279);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Paneli";
            // 
            // textBox_id
            // 
            this.textBox_id.Enabled = false;
            this.textBox_id.Location = new System.Drawing.Point(67, 30);
            this.textBox_id.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(135, 26);
            this.textBox_id.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(42, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "İd:";
            // 
            // link_BilgiDüzenle
            // 
            this.link_BilgiDüzenle.AutoSize = true;
            this.link_BilgiDüzenle.ForeColor = System.Drawing.Color.Black;
            this.link_BilgiDüzenle.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.link_BilgiDüzenle.Location = new System.Drawing.Point(12, 248);
            this.link_BilgiDüzenle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.link_BilgiDüzenle.Name = "link_BilgiDüzenle";
            this.link_BilgiDüzenle.Size = new System.Drawing.Size(137, 20);
            this.link_BilgiDüzenle.TabIndex = 2;
            this.link_BilgiDüzenle.TabStop = true;
            this.link_BilgiDüzenle.Text = "Bilgilerimi Düzenle";
            this.link_BilgiDüzenle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_BilgiDüzenle_LinkClicked);
            // 
            // button_RandevuAl
            // 
            this.button_RandevuAl.BackColor = System.Drawing.Color.SlateBlue;
            this.button_RandevuAl.Location = new System.Drawing.Point(68, 199);
            this.button_RandevuAl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_RandevuAl.Name = "button_RandevuAl";
            this.button_RandevuAl.Size = new System.Drawing.Size(134, 32);
            this.button_RandevuAl.TabIndex = 28;
            this.button_RandevuAl.Text = "Randevu Al";
            this.button_RandevuAl.UseVisualStyleBackColor = false;
            this.button_RandevuAl.Click += new System.EventHandler(this.button_RandevuAl_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(13, 115);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Şikayet:";
            // 
            // richTextBox_Sikayet
            // 
            this.richTextBox_Sikayet.Location = new System.Drawing.Point(68, 115);
            this.richTextBox_Sikayet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox_Sikayet.Name = "richTextBox_Sikayet";
            this.richTextBox_Sikayet.Size = new System.Drawing.Size(134, 79);
            this.richTextBox_Sikayet.TabIndex = 24;
            this.richTextBox_Sikayet.Text = "";
            // 
            // comboBox_Doktor
            // 
            this.comboBox_Doktor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_Doktor.FormattingEnabled = true;
            this.comboBox_Doktor.Location = new System.Drawing.Point(68, 87);
            this.comboBox_Doktor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_Doktor.Name = "comboBox_Doktor";
            this.comboBox_Doktor.Size = new System.Drawing.Size(134, 25);
            this.comboBox_Doktor.TabIndex = 26;
            this.comboBox_Doktor.SelectedIndexChanged += new System.EventHandler(this.comboBox_Doktor_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(14, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Doktor:";
            // 
            // comboBox_Brans
            // 
            this.comboBox_Brans.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_Brans.FormattingEnabled = true;
            this.comboBox_Brans.Location = new System.Drawing.Point(67, 59);
            this.comboBox_Brans.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_Brans.Name = "comboBox_Brans";
            this.comboBox_Brans.Size = new System.Drawing.Size(134, 25);
            this.comboBox_Brans.TabIndex = 24;
            this.comboBox_Brans.SelectedIndexChanged += new System.EventHandler(this.comboBox_Brans_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(17, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Branş:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView_Gecmis);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(260, 10);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(742, 209);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Geçmişi";
            // 
            // dataGridView_Gecmis
            // 
            this.dataGridView_Gecmis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Gecmis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Gecmis.Location = new System.Drawing.Point(2, 21);
            this.dataGridView_Gecmis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView_Gecmis.Name = "dataGridView_Gecmis";
            this.dataGridView_Gecmis.RowHeadersWidth = 51;
            this.dataGridView_Gecmis.RowTemplate.Height = 24;
            this.dataGridView_Gecmis.Size = new System.Drawing.Size(738, 186);
            this.dataGridView_Gecmis.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView_Aktif);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(260, 223);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(742, 172);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Aktif Randevular";
            // 
            // dataGridView_Aktif
            // 
            this.dataGridView_Aktif.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Aktif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Aktif.Location = new System.Drawing.Point(2, 21);
            this.dataGridView_Aktif.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView_Aktif.Name = "dataGridView_Aktif";
            this.dataGridView_Aktif.RowHeadersWidth = 51;
            this.dataGridView_Aktif.RowTemplate.Height = 24;
            this.dataGridView_Aktif.Size = new System.Drawing.Size(738, 149);
            this.dataGridView_Aktif.TabIndex = 1;
            this.dataGridView_Aktif.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Aktif_CellClick);
            // 
            // FrmHastaDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(1006, 401);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHastaDetay";
            this.Text = "Hasta Detay";
            this.Load += new System.EventHandler(this.FrmHastaDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Gecmis)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Aktif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_TCNO;
        private System.Windows.Forms.Label label_AdSoyad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox_Brans;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_RandevuAl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox_Sikayet;
        private System.Windows.Forms.ComboBox comboBox_Doktor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView_Gecmis;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView_Aktif;
        private System.Windows.Forms.LinkLabel link_BilgiDüzenle;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label6;
    }
}