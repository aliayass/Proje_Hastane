namespace Hastane_Yonetim_ve_Randevu
{
    partial class FrmGirisler
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGirisler));
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_SekreterGirisi = new System.Windows.Forms.Button();
            this.button_DoktorGirisi = new System.Windows.Forms.Button();
            this.button_HastaGirisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 40.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(1, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(409, 65);
            this.label4.TabIndex = 7;
            this.label4.Text = "AYAS HOSPİTAL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::Hastane_Yonetim_ve_Randevu.Properties.Resources.heart_heartbeat;
            this.pictureBox1.Location = new System.Drawing.Point(416, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(396, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // button_SekreterGirisi
            // 
            this.button_SekreterGirisi.BackgroundImage = global::Hastane_Yonetim_ve_Randevu.Properties.Resources.png_clipart_administrative_assistant_virtual_assistant_secretary_office_administrative_professionals_week_others_miscellaneous_company_thumbnail;
            this.button_SekreterGirisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_SekreterGirisi.Location = new System.Drawing.Point(571, 104);
            this.button_SekreterGirisi.Name = "button_SekreterGirisi";
            this.button_SekreterGirisi.Size = new System.Drawing.Size(241, 280);
            this.button_SekreterGirisi.TabIndex = 2;
            this.button_SekreterGirisi.UseVisualStyleBackColor = true;
            this.button_SekreterGirisi.Click += new System.EventHandler(this.button_SekreterGirisi_Click);
            // 
            // button_DoktorGirisi
            // 
            this.button_DoktorGirisi.BackgroundImage = global::Hastane_Yonetim_ve_Randevu.Properties.Resources.images__1_;
            this.button_DoktorGirisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_DoktorGirisi.Location = new System.Drawing.Point(281, 104);
            this.button_DoktorGirisi.Name = "button_DoktorGirisi";
            this.button_DoktorGirisi.Size = new System.Drawing.Size(230, 280);
            this.button_DoktorGirisi.TabIndex = 1;
            this.button_DoktorGirisi.UseVisualStyleBackColor = true;
            this.button_DoktorGirisi.Click += new System.EventHandler(this.button_DoktorGirisi_Click);
            // 
            // button_HastaGirisi
            // 
            this.button_HastaGirisi.BackgroundImage = global::Hastane_Yonetim_ve_Randevu.Properties.Resources.images__3_;
            this.button_HastaGirisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_HastaGirisi.Location = new System.Drawing.Point(-2, 104);
            this.button_HastaGirisi.Name = "button_HastaGirisi";
            this.button_HastaGirisi.Size = new System.Drawing.Size(227, 280);
            this.button_HastaGirisi.TabIndex = 0;
            this.button_HastaGirisi.UseVisualStyleBackColor = true;
            this.button_HastaGirisi.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmGirisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(809, 386);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_SekreterGirisi);
            this.Controls.Add(this.button_DoktorGirisi);
            this.Controls.Add(this.button_HastaGirisi);
            this.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmGirisler";
            this.Text = "Ayas Hospital";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_HastaGirisi;
        private System.Windows.Forms.Button button_DoktorGirisi;
        private System.Windows.Forms.Button button_SekreterGirisi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}

