namespace Hastane_Yonetim_ve_Randevu
{
    partial class FormDoktorDetay
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label_AdSoyad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_TCNO = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView_RandevuListesi = new System.Windows.Forms.DataGridView();
            this.richTextBox_RandevuDetay = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button_BilgiDüzenle = new System.Windows.Forms.Button();
            this.button_Cıkıs = new System.Windows.Forms.Button();
            this.button_Duyurular = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RandevuListesi)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox1.Size = new System.Drawing.Size(303, 109);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doktor Bilgi";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBox_RandevuDetay);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(12, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 184);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Detay";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView_RandevuListesi);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(321, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(587, 423);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Listesi";
            // 
            // dataGridView_RandevuListesi
            // 
            this.dataGridView_RandevuListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_RandevuListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_RandevuListesi.Location = new System.Drawing.Point(3, 26);
            this.dataGridView_RandevuListesi.Name = "dataGridView_RandevuListesi";
            this.dataGridView_RandevuListesi.RowHeadersWidth = 51;
            this.dataGridView_RandevuListesi.RowTemplate.Height = 24;
            this.dataGridView_RandevuListesi.Size = new System.Drawing.Size(581, 394);
            this.dataGridView_RandevuListesi.TabIndex = 28;
            // 
            // richTextBox_RandevuDetay
            // 
            this.richTextBox_RandevuDetay.Location = new System.Drawing.Point(6, 29);
            this.richTextBox_RandevuDetay.Name = "richTextBox_RandevuDetay";
            this.richTextBox_RandevuDetay.Size = new System.Drawing.Size(290, 149);
            this.richTextBox_RandevuDetay.TabIndex = 3;
            this.richTextBox_RandevuDetay.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button_Duyurular);
            this.groupBox4.Controls.Add(this.button_Cıkıs);
            this.groupBox4.Controls.Add(this.button_BilgiDüzenle);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(12, 317);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(303, 118);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hızlı Erişim";
            // 
            // button_BilgiDüzenle
            // 
            this.button_BilgiDüzenle.BackColor = System.Drawing.Color.LightGreen;
            this.button_BilgiDüzenle.Location = new System.Drawing.Point(6, 29);
            this.button_BilgiDüzenle.Name = "button_BilgiDüzenle";
            this.button_BilgiDüzenle.Size = new System.Drawing.Size(142, 32);
            this.button_BilgiDüzenle.TabIndex = 29;
            this.button_BilgiDüzenle.Text = "Bilgi Düzenle";
            this.button_BilgiDüzenle.UseVisualStyleBackColor = false;
            // 
            // button_Cıkıs
            // 
            this.button_Cıkıs.BackColor = System.Drawing.Color.LightGreen;
            this.button_Cıkıs.Location = new System.Drawing.Point(6, 67);
            this.button_Cıkıs.Name = "button_Cıkıs";
            this.button_Cıkıs.Size = new System.Drawing.Size(290, 32);
            this.button_Cıkıs.TabIndex = 30;
            this.button_Cıkıs.Text = "Çıkış";
            this.button_Cıkıs.UseVisualStyleBackColor = false;
            // 
            // button_Duyurular
            // 
            this.button_Duyurular.BackColor = System.Drawing.Color.LightGreen;
            this.button_Duyurular.Location = new System.Drawing.Point(154, 29);
            this.button_Duyurular.Name = "button_Duyurular";
            this.button_Duyurular.Size = new System.Drawing.Size(142, 32);
            this.button_Duyurular.TabIndex = 32;
            this.button_Duyurular.Text = "Duyurular";
            this.button_Duyurular.UseVisualStyleBackColor = false;
            // 
            // FormDoktorDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(920, 437);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormDoktorDetay";
            this.Text = "FormDoktorDetay";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RandevuListesi)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label_AdSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_TCNO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView_RandevuListesi;
        private System.Windows.Forms.RichTextBox richTextBox_RandevuDetay;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button_Duyurular;
        private System.Windows.Forms.Button button_Cıkıs;
        private System.Windows.Forms.Button button_BilgiDüzenle;
    }
}