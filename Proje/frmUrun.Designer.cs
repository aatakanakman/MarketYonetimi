namespace Proje
{
    partial class frmUrun
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.ekleBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.txtTedarikci = new System.Windows.Forms.TextBox();
            this.txtSektör = new System.Windows.Forms.TextBox();
            this.txtTedarikci_id = new System.Windows.Forms.TextBox();
            this.silBtn = new System.Windows.Forms.Button();
            this.guncelleBtn = new System.Windows.Forms.Button();
            this.indirimBtn = new System.Windows.Forms.Button();
            this.indirimZamaniLbl = new System.Windows.Forms.Label();
            this.zamanLbl = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.yntcIndirim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(465, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(699, 320);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ürün Ad";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(201, 15);
            this.txtAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(162, 30);
            this.txtAd.TabIndex = 3;
            // 
            // ekleBtn
            // 
            this.ekleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ekleBtn.Location = new System.Drawing.Point(269, 359);
            this.ekleBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ekleBtn.Name = "ekleBtn";
            this.ekleBtn.Size = new System.Drawing.Size(94, 34);
            this.ekleBtn.TabIndex = 4;
            this.ekleBtn.Text = "Ekle";
            this.ekleBtn.UseVisualStyleBackColor = false;
            this.ekleBtn.Click += new System.EventHandler(this.ekleBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ürün Fiyatı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 245);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tedarikçi İD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 181);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tedarikçi Ad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 121);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ürün Stoğu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(127, 311);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Sektör";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(201, 67);
            this.txtFiyat.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(162, 30);
            this.txtFiyat.TabIndex = 10;
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(201, 121);
            this.txtStok.Margin = new System.Windows.Forms.Padding(4);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(162, 30);
            this.txtStok.TabIndex = 11;
            // 
            // txtTedarikci
            // 
            this.txtTedarikci.Location = new System.Drawing.Point(201, 181);
            this.txtTedarikci.Margin = new System.Windows.Forms.Padding(4);
            this.txtTedarikci.Name = "txtTedarikci";
            this.txtTedarikci.Size = new System.Drawing.Size(162, 30);
            this.txtTedarikci.TabIndex = 12;
            // 
            // txtSektör
            // 
            this.txtSektör.Location = new System.Drawing.Point(201, 305);
            this.txtSektör.Margin = new System.Windows.Forms.Padding(4);
            this.txtSektör.Name = "txtSektör";
            this.txtSektör.Size = new System.Drawing.Size(162, 30);
            this.txtSektör.TabIndex = 14;
            // 
            // txtTedarikci_id
            // 
            this.txtTedarikci_id.Location = new System.Drawing.Point(201, 245);
            this.txtTedarikci_id.Margin = new System.Windows.Forms.Padding(4);
            this.txtTedarikci_id.Name = "txtTedarikci_id";
            this.txtTedarikci_id.Size = new System.Drawing.Size(162, 30);
            this.txtTedarikci_id.TabIndex = 13;
            // 
            // silBtn
            // 
            this.silBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.silBtn.Location = new System.Drawing.Point(269, 410);
            this.silBtn.Margin = new System.Windows.Forms.Padding(4);
            this.silBtn.Name = "silBtn";
            this.silBtn.Size = new System.Drawing.Size(94, 34);
            this.silBtn.TabIndex = 15;
            this.silBtn.Text = "Sil";
            this.silBtn.UseVisualStyleBackColor = false;
            this.silBtn.Click += new System.EventHandler(this.silBtn_Click);
            // 
            // guncelleBtn
            // 
            this.guncelleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.guncelleBtn.Location = new System.Drawing.Point(269, 461);
            this.guncelleBtn.Margin = new System.Windows.Forms.Padding(4);
            this.guncelleBtn.Name = "guncelleBtn";
            this.guncelleBtn.Size = new System.Drawing.Size(94, 34);
            this.guncelleBtn.TabIndex = 16;
            this.guncelleBtn.Text = "Güncelle";
            this.guncelleBtn.UseVisualStyleBackColor = false;
            this.guncelleBtn.Click += new System.EventHandler(this.guncelleBtn_Click);
            // 
            // indirimBtn
            // 
            this.indirimBtn.BackColor = System.Drawing.Color.Aqua;
            this.indirimBtn.Location = new System.Drawing.Point(523, 392);
            this.indirimBtn.Margin = new System.Windows.Forms.Padding(4);
            this.indirimBtn.Name = "indirimBtn";
            this.indirimBtn.Size = new System.Drawing.Size(94, 34);
            this.indirimBtn.TabIndex = 19;
            this.indirimBtn.Text = "Göster";
            this.indirimBtn.UseVisualStyleBackColor = false;
            this.indirimBtn.Click += new System.EventHandler(this.indirimBtn_Click);
            // 
            // indirimZamaniLbl
            // 
            this.indirimZamaniLbl.AutoSize = true;
            this.indirimZamaniLbl.Location = new System.Drawing.Point(465, 364);
            this.indirimZamaniLbl.Name = "indirimZamaniLbl";
            this.indirimZamaniLbl.Size = new System.Drawing.Size(153, 24);
            this.indirimZamaniLbl.TabIndex = 20;
            this.indirimZamaniLbl.Text = "Müdür Son İndirim:";
            // 
            // zamanLbl
            // 
            this.zamanLbl.AutoSize = true;
            this.zamanLbl.Location = new System.Drawing.Point(575, 563);
            this.zamanLbl.Name = "zamanLbl";
            this.zamanLbl.Size = new System.Drawing.Size(0, 24);
            this.zamanLbl.TabIndex = 21;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(624, 359);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(540, 184);
            this.dataGridView2.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(456, 445);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 24);
            this.label7.TabIndex = 24;
            this.label7.Text = "Yönetici Son İndirim:";
            // 
            // yntcIndirim
            // 
            this.yntcIndirim.BackColor = System.Drawing.Color.Aqua;
            this.yntcIndirim.Location = new System.Drawing.Point(524, 482);
            this.yntcIndirim.Margin = new System.Windows.Forms.Padding(4);
            this.yntcIndirim.Name = "yntcIndirim";
            this.yntcIndirim.Size = new System.Drawing.Size(94, 34);
            this.yntcIndirim.TabIndex = 25;
            this.yntcIndirim.Text = "Göster";
            this.yntcIndirim.UseVisualStyleBackColor = false;
            this.yntcIndirim.Click += new System.EventHandler(this.yntcIndirim_Click);
            // 
            // frmUrun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1190, 606);
            this.Controls.Add(this.yntcIndirim);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.zamanLbl);
            this.Controls.Add(this.indirimZamaniLbl);
            this.Controls.Add(this.indirimBtn);
            this.Controls.Add(this.guncelleBtn);
            this.Controls.Add(this.silBtn);
            this.Controls.Add(this.txtSektör);
            this.Controls.Add(this.txtTedarikci_id);
            this.Controls.Add(this.txtTedarikci);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ekleBtn);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUrun";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.frmUrun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Button ekleBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.TextBox txtTedarikci;
        private System.Windows.Forms.TextBox txtSektör;
        private System.Windows.Forms.TextBox txtTedarikci_id;
        private System.Windows.Forms.Button silBtn;
        private System.Windows.Forms.Button guncelleBtn;
        private System.Windows.Forms.Button indirimBtn;
        private System.Windows.Forms.Label indirimZamaniLbl;
        private System.Windows.Forms.Label zamanLbl;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button yntcIndirim;
    }
}