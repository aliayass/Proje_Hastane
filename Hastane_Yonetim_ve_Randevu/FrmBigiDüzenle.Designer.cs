namespace Hastane_Yonetim_ve_Randevu
{
    partial class FrmBigiDüzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBigiDüzenle));
            this.button_guncelle = new System.Windows.Forms.Button();
            this.comboBox_Cinisyet = new System.Windows.Forms.ComboBox();
            this.textbox_Ad = new System.Windows.Forms.TextBox();
            this.maskedTextBox_TEL_NO = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textbox_Soyad = new System.Windows.Forms.TextBox();
            this.maskedTextBox_TC_NO = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Sifre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_guncelle
            // 
            this.button_guncelle.BackColor = System.Drawing.Color.Red;
            this.button_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_guncelle.Location = new System.Drawing.Point(182, 307);
            this.button_guncelle.Name = "button_guncelle";
            this.button_guncelle.Size = new System.Drawing.Size(168, 51);
            this.button_guncelle.TabIndex = 8;
            this.button_guncelle.Text = "Güncelle";
            this.button_guncelle.UseVisualStyleBackColor = false;
            this.button_guncelle.Click += new System.EventHandler(this.button_guncelle_Click);
            // 
            // comboBox_Cinisyet
            // 
            this.comboBox_Cinisyet.FormattingEnabled = true;
            this.comboBox_Cinisyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.comboBox_Cinisyet.Location = new System.Drawing.Point(181, 227);
            this.comboBox_Cinisyet.Name = "comboBox_Cinisyet";
            this.comboBox_Cinisyet.Size = new System.Drawing.Size(169, 33);
            this.comboBox_Cinisyet.TabIndex = 6;
            // 
            // textbox_Ad
            // 
            this.textbox_Ad.Location = new System.Drawing.Point(181, 63);
            this.textbox_Ad.Name = "textbox_Ad";
            this.textbox_Ad.Size = new System.Drawing.Size(169, 30);
            this.textbox_Ad.TabIndex = 1;
            // 
            // maskedTextBox_TEL_NO
            // 
            this.maskedTextBox_TEL_NO.Location = new System.Drawing.Point(181, 188);
            this.maskedTextBox_TEL_NO.Mask = "(999) 000-0000";
            this.maskedTextBox_TEL_NO.Name = "maskedTextBox_TEL_NO";
            this.maskedTextBox_TEL_NO.Size = new System.Drawing.Size(169, 30);
            this.maskedTextBox_TEL_NO.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(86, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 25);
            this.label5.TabIndex = 30;
            this.label5.Text = "Cinsiyet:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(61, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 25);
            this.label6.TabIndex = 29;
            this.label6.Text = "Telefon No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(105, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(137, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "Ad:";
            // 
            // textbox_Soyad
            // 
            this.textbox_Soyad.Location = new System.Drawing.Point(181, 106);
            this.textbox_Soyad.Name = "textbox_Soyad";
            this.textbox_Soyad.Size = new System.Drawing.Size(169, 30);
            this.textbox_Soyad.TabIndex = 2;
            // 
            // maskedTextBox_TC_NO
            // 
            this.maskedTextBox_TC_NO.Location = new System.Drawing.Point(181, 151);
            this.maskedTextBox_TC_NO.Mask = "00000000000";
            this.maskedTextBox_TC_NO.Name = "maskedTextBox_TC_NO";
            this.maskedTextBox_TC_NO.Size = new System.Drawing.Size(169, 30);
            this.maskedTextBox_TC_NO.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(105, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(47, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "TC Kimlik No:";
            // 
            // textBox_Sifre
            // 
            this.textBox_Sifre.Location = new System.Drawing.Point(182, 269);
            this.textBox_Sifre.Name = "textBox_Sifre";
            this.textBox_Sifre.Size = new System.Drawing.Size(168, 30);
            this.textBox_Sifre.TabIndex = 7;
            // 
            // FrmBigiDüzenle
            // 
            this.AcceptButton = this.button_guncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(446, 406);
            this.Controls.Add(this.button_guncelle);
            this.Controls.Add(this.comboBox_Cinisyet);
            this.Controls.Add(this.textbox_Ad);
            this.Controls.Add(this.maskedTextBox_TEL_NO);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textbox_Soyad);
            this.Controls.Add(this.maskedTextBox_TC_NO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Sifre);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmBigiDüzenle";
            this.Text = "Bigi Düzenle";
            this.Load += new System.EventHandler(this.FrmBigiDüzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_guncelle;
        private System.Windows.Forms.ComboBox comboBox_Cinisyet;
        private System.Windows.Forms.TextBox textbox_Ad;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_TEL_NO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textbox_Soyad;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_TC_NO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Sifre;
    }
}