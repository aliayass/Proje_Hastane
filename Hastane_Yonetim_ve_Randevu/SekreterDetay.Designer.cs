namespace Hastane_Yonetim_ve_Randevu
{
    partial class SekreterDetay
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBox_Duyurular = new System.Windows.Forms.RichTextBox();
            this.button_Olustur = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_AdSoyad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_TCNO = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.maskedTextBox_tarih = new System.Windows.Forms.MaskedTextBox();
            this.comboBox_doktor = new System.Windows.Forms.ComboBox();
            this.maskedTextBox_saat = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_TcNO = new System.Windows.Forms.MaskedTextBox();
            this.comboBox_brans = new System.Windows.Forms.ComboBox();
            this.checkBox_Durum = new System.Windows.Forms.CheckBox();
            this.button_Kaydet = new System.Windows.Forms.Button();
            this.button_Guncelle = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView_Branslar = new System.Windows.Forms.DataGridView();
            this.dataGridView_Doktorlar = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button_DoktorPaneli = new System.Windows.Forms.Button();
            this.button_BransPaneli = new System.Windows.Forms.Button();
            this.button_Randevu = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Branslar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Doktorlar)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBox_Duyurular);
            this.groupBox2.Controls.Add(this.button_Olustur);
            this.groupBox2.Location = new System.Drawing.Point(12, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 261);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duyuru Oluştur";
            // 
            // richTextBox_Duyurular
            // 
            this.richTextBox_Duyurular.BackColor = System.Drawing.Color.White;
            this.richTextBox_Duyurular.Location = new System.Drawing.Point(6, 29);
            this.richTextBox_Duyurular.Name = "richTextBox_Duyurular";
            this.richTextBox_Duyurular.Size = new System.Drawing.Size(226, 179);
            this.richTextBox_Duyurular.TabIndex = 4;
            this.richTextBox_Duyurular.Text = "";
            // 
            // button_Olustur
            // 
            this.button_Olustur.BackColor = System.Drawing.Color.Plum;
            this.button_Olustur.Location = new System.Drawing.Point(37, 214);
            this.button_Olustur.Name = "button_Olustur";
            this.button_Olustur.Size = new System.Drawing.Size(184, 35);
            this.button_Olustur.TabIndex = 0;
            this.button_Olustur.Text = "Oluştur";
            this.button_Olustur.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_Guncelle);
            this.groupBox3.Controls.Add(this.button_Kaydet);
            this.groupBox3.Controls.Add(this.checkBox_Durum);
            this.groupBox3.Controls.Add(this.comboBox_brans);
            this.groupBox3.Controls.Add(this.maskedTextBox_TcNO);
            this.groupBox3.Controls.Add(this.maskedTextBox_saat);
            this.groupBox3.Controls.Add(this.comboBox_doktor);
            this.groupBox3.Controls.Add(this.maskedTextBox_tarih);
            this.groupBox3.Controls.Add(this.textBox_id);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(256, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(259, 376);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Paneli";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(22, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Saat:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(11, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Branş:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(18, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Tarih:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(39, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "İD:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_AdSoyad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label_TCNO);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 109);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sekreter Bilgi";
            // 
            // label_AdSoyad
            // 
            this.label_AdSoyad.AutoSize = true;
            this.label_AdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_AdSoyad.Location = new System.Drawing.Point(123, 74);
            this.label_AdSoyad.Name = "label_AdSoyad";
            this.label_AdSoyad.Size = new System.Drawing.Size(80, 20);
            this.label_AdSoyad.TabIndex = 27;
            this.label_AdSoyad.Text = "Ad Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(14, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Ad Soyad:";
            // 
            // label_TCNO
            // 
            this.label_TCNO.AutoSize = true;
            this.label_TCNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_TCNO.Location = new System.Drawing.Point(123, 41);
            this.label_TCNO.Name = "label_TCNO";
            this.label_TCNO.Size = new System.Drawing.Size(81, 20);
            this.label_TCNO.TabIndex = 25;
            this.label_TCNO.Text = "00000000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(33, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "TC NO:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(6, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Doktor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(4, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "TC. No:";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(76, 34);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(125, 30);
            this.textBox_id.TabIndex = 32;
            // 
            // maskedTextBox_tarih
            // 
            this.maskedTextBox_tarih.Location = new System.Drawing.Point(76, 70);
            this.maskedTextBox_tarih.Mask = "00/00/0000";
            this.maskedTextBox_tarih.Name = "maskedTextBox_tarih";
            this.maskedTextBox_tarih.Size = new System.Drawing.Size(125, 30);
            this.maskedTextBox_tarih.TabIndex = 33;
            this.maskedTextBox_tarih.ValidatingType = typeof(System.DateTime);
            // 
            // comboBox_doktor
            // 
            this.comboBox_doktor.FormattingEnabled = true;
            this.comboBox_doktor.Location = new System.Drawing.Point(76, 144);
            this.comboBox_doktor.Name = "comboBox_doktor";
            this.comboBox_doktor.Size = new System.Drawing.Size(125, 33);
            this.comboBox_doktor.TabIndex = 34;
            // 
            // maskedTextBox_saat
            // 
            this.maskedTextBox_saat.Location = new System.Drawing.Point(76, 108);
            this.maskedTextBox_saat.Mask = "00:00";
            this.maskedTextBox_saat.Name = "maskedTextBox_saat";
            this.maskedTextBox_saat.Size = new System.Drawing.Size(125, 30);
            this.maskedTextBox_saat.TabIndex = 35;
            this.maskedTextBox_saat.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox_TcNO
            // 
            this.maskedTextBox_TcNO.Location = new System.Drawing.Point(76, 222);
            this.maskedTextBox_TcNO.Mask = "00000000000";
            this.maskedTextBox_TcNO.Name = "maskedTextBox_TcNO";
            this.maskedTextBox_TcNO.Size = new System.Drawing.Size(125, 30);
            this.maskedTextBox_TcNO.TabIndex = 36;
            this.maskedTextBox_TcNO.ValidatingType = typeof(System.DateTime);
            // 
            // comboBox_brans
            // 
            this.comboBox_brans.FormattingEnabled = true;
            this.comboBox_brans.Location = new System.Drawing.Point(76, 183);
            this.comboBox_brans.Name = "comboBox_brans";
            this.comboBox_brans.Size = new System.Drawing.Size(125, 33);
            this.comboBox_brans.TabIndex = 37;
            // 
            // checkBox_Durum
            // 
            this.checkBox_Durum.AutoSize = true;
            this.checkBox_Durum.Location = new System.Drawing.Point(76, 263);
            this.checkBox_Durum.Name = "checkBox_Durum";
            this.checkBox_Durum.Size = new System.Drawing.Size(92, 29);
            this.checkBox_Durum.TabIndex = 38;
            this.checkBox_Durum.Text = "Durum";
            this.checkBox_Durum.UseVisualStyleBackColor = true;
            // 
            // button_Kaydet
            // 
            this.button_Kaydet.BackColor = System.Drawing.Color.Plum;
            this.button_Kaydet.Location = new System.Drawing.Point(26, 289);
            this.button_Kaydet.Name = "button_Kaydet";
            this.button_Kaydet.Size = new System.Drawing.Size(184, 35);
            this.button_Kaydet.TabIndex = 39;
            this.button_Kaydet.Text = "Kaydet";
            this.button_Kaydet.UseVisualStyleBackColor = false;
            // 
            // button_Guncelle
            // 
            this.button_Guncelle.BackColor = System.Drawing.Color.Plum;
            this.button_Guncelle.Location = new System.Drawing.Point(26, 329);
            this.button_Guncelle.Name = "button_Guncelle";
            this.button_Guncelle.Size = new System.Drawing.Size(184, 35);
            this.button_Guncelle.TabIndex = 40;
            this.button_Guncelle.Text = "Güncelle";
            this.button_Guncelle.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView_Branslar);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(521, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(314, 226);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Branşlar";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView_Doktorlar);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox5.Location = new System.Drawing.Point(524, 244);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(314, 234);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doktorlar";
            // 
            // dataGridView_Branslar
            // 
            this.dataGridView_Branslar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Branslar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Branslar.Location = new System.Drawing.Point(3, 26);
            this.dataGridView_Branslar.Name = "dataGridView_Branslar";
            this.dataGridView_Branslar.RowHeadersWidth = 51;
            this.dataGridView_Branslar.RowTemplate.Height = 24;
            this.dataGridView_Branslar.Size = new System.Drawing.Size(308, 197);
            this.dataGridView_Branslar.TabIndex = 0;
            // 
            // dataGridView_Doktorlar
            // 
            this.dataGridView_Doktorlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Doktorlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Doktorlar.Location = new System.Drawing.Point(3, 26);
            this.dataGridView_Doktorlar.Name = "dataGridView_Doktorlar";
            this.dataGridView_Doktorlar.RowHeadersWidth = 51;
            this.dataGridView_Doktorlar.RowTemplate.Height = 24;
            this.dataGridView_Doktorlar.Size = new System.Drawing.Size(308, 205);
            this.dataGridView_Doktorlar.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button_Randevu);
            this.groupBox6.Controls.Add(this.button_BransPaneli);
            this.groupBox6.Controls.Add(this.button_DoktorPaneli);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox6.Location = new System.Drawing.Point(12, 394);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(503, 84);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Hızlı Erişim";
            // 
            // button_DoktorPaneli
            // 
            this.button_DoktorPaneli.BackColor = System.Drawing.Color.Plum;
            this.button_DoktorPaneli.Location = new System.Drawing.Point(18, 29);
            this.button_DoktorPaneli.Name = "button_DoktorPaneli";
            this.button_DoktorPaneli.Size = new System.Drawing.Size(146, 35);
            this.button_DoktorPaneli.TabIndex = 40;
            this.button_DoktorPaneli.Text = "Doktor Paneli";
            this.button_DoktorPaneli.UseVisualStyleBackColor = false;
            // 
            // button_BransPaneli
            // 
            this.button_BransPaneli.BackColor = System.Drawing.Color.Plum;
            this.button_BransPaneli.Location = new System.Drawing.Point(170, 29);
            this.button_BransPaneli.Name = "button_BransPaneli";
            this.button_BransPaneli.Size = new System.Drawing.Size(162, 35);
            this.button_BransPaneli.TabIndex = 41;
            this.button_BransPaneli.Text = "Branş Paneli";
            this.button_BransPaneli.UseVisualStyleBackColor = false;
            // 
            // button_Randevu
            // 
            this.button_Randevu.BackColor = System.Drawing.Color.Plum;
            this.button_Randevu.Location = new System.Drawing.Point(338, 29);
            this.button_Randevu.Name = "button_Randevu";
            this.button_Randevu.Size = new System.Drawing.Size(150, 35);
            this.button_Randevu.TabIndex = 42;
            this.button_Randevu.Text = "Randevu Listesi";
            this.button_Randevu.UseVisualStyleBackColor = false;
            // 
            // SekreterDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(848, 482);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SekreterDetay";
            this.Text = "SekreterDetay";
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Branslar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Doktorlar)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox richTextBox_Duyurular;
        private System.Windows.Forms.Button button_Olustur;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_AdSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_TCNO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_doktor;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_tarih;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_Kaydet;
        private System.Windows.Forms.CheckBox checkBox_Durum;
        private System.Windows.Forms.ComboBox comboBox_brans;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_TcNO;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_saat;
        private System.Windows.Forms.Button button_Guncelle;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView_Branslar;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView_Doktorlar;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button_Randevu;
        private System.Windows.Forms.Button button_BransPaneli;
        private System.Windows.Forms.Button button_DoktorPaneli;
    }
}