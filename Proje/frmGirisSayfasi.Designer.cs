namespace Proje
{
    partial class Giriş_Sayfası
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giriş_Sayfası));
            this.mudurGiris = new System.Windows.Forms.Button();
            this.sifreText = new System.Windows.Forms.TextBox();
            this.yoneticiGiris = new System.Windows.Forms.Button();
            this.kullanıcıAdText = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mudurGiris
            // 
            this.mudurGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mudurGiris.Location = new System.Drawing.Point(936, 348);
            this.mudurGiris.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mudurGiris.Name = "mudurGiris";
            this.mudurGiris.Size = new System.Drawing.Size(100, 34);
            this.mudurGiris.TabIndex = 8;
            this.mudurGiris.Text = "Müdür";
            this.mudurGiris.UseVisualStyleBackColor = false;
            this.mudurGiris.Click += new System.EventHandler(this.mudurGiris_Click);
            // 
            // sifreText
            // 
            this.sifreText.Location = new System.Drawing.Point(797, 303);
            this.sifreText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sifreText.Multiline = true;
            this.sifreText.Name = "sifreText";
            this.sifreText.Size = new System.Drawing.Size(239, 29);
            this.sifreText.TabIndex = 7;
            this.sifreText.Text = "Şifre";
            // 
            // yoneticiGiris
            // 
            this.yoneticiGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.yoneticiGiris.Location = new System.Drawing.Point(797, 348);
            this.yoneticiGiris.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yoneticiGiris.Name = "yoneticiGiris";
            this.yoneticiGiris.Size = new System.Drawing.Size(100, 34);
            this.yoneticiGiris.TabIndex = 6;
            this.yoneticiGiris.Text = "Yönetici";
            this.yoneticiGiris.UseVisualStyleBackColor = false;
            this.yoneticiGiris.Click += new System.EventHandler(this.yoneticiGiris_Click);
            // 
            // kullanıcıAdText
            // 
            this.kullanıcıAdText.Location = new System.Drawing.Point(797, 260);
            this.kullanıcıAdText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kullanıcıAdText.Multiline = true;
            this.kullanıcıAdText.Name = "kullanıcıAdText";
            this.kullanıcıAdText.Size = new System.Drawing.Size(239, 29);
            this.kullanıcıAdText.TabIndex = 5;
            this.kullanıcıAdText.Text = "Kullanıcı Adı";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(698, 586);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Giriş_Sayfası
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1143, 634);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mudurGiris);
            this.Controls.Add(this.sifreText);
            this.Controls.Add(this.yoneticiGiris);
            this.Controls.Add(this.kullanıcıAdText);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Giriş_Sayfası";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş_Sayfası";
            this.Load += new System.EventHandler(this.Giriş_Sayfası_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mudurGiris;
        private System.Windows.Forms.TextBox sifreText;
        private System.Windows.Forms.Button yoneticiGiris;
        private System.Windows.Forms.TextBox kullanıcıAdText;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}