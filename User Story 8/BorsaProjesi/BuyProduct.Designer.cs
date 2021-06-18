
namespace BorsaProjesi
{
    partial class BuyProduct
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyProduct));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSatinAl = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtUrunMiktar = new System.Windows.Forms.TextBox();
            this.lblUrunMiktari = new System.Windows.Forms.Label();
            this.lblUrunFiyat = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.btnFiyatHesapla = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.lblUrunTipi = new System.Windows.Forms.Label();
            this.cmbUrunTipi = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUrunSatinAlma = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUyari = new System.Windows.Forms.Label();
            this.lblBirimFiyat = new System.Windows.Forms.Label();
            this.txtBirimFiyati = new System.Windows.Forms.TextBox();
            this.btnTalepOlustur = new System.Windows.Forms.Button();
            this.lblKomisyon = new System.Windows.Forms.Label();
            this.lblMuhasebeKomisyon = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1003, 288);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnSatinAl
            // 
            this.btnSatinAl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSatinAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnSatinAl.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSatinAl.ImageKey = "payment-method.png";
            this.btnSatinAl.ImageList = this.ımageList1;
            this.btnSatinAl.Location = new System.Drawing.Point(343, 437);
            this.btnSatinAl.Name = "btnSatinAl";
            this.btnSatinAl.Size = new System.Drawing.Size(144, 100);
            this.btnSatinAl.TabIndex = 1;
            this.btnSatinAl.Text = "Satın Al";
            this.btnSatinAl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSatinAl.UseVisualStyleBackColor = false;
            this.btnSatinAl.Click += new System.EventHandler(this.btnSatinAl_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "payment-method.png");
            this.ımageList1.Images.SetKeyName(1, "calculator.png");
            this.ımageList1.Images.SetKeyName(2, "left-arrow.png");
            this.ımageList1.Images.SetKeyName(3, "request.png");
            // 
            // txtUrunMiktar
            // 
            this.txtUrunMiktar.Location = new System.Drawing.Point(185, 417);
            this.txtUrunMiktar.Name = "txtUrunMiktar";
            this.txtUrunMiktar.Size = new System.Drawing.Size(119, 22);
            this.txtUrunMiktar.TabIndex = 2;
            // 
            // lblUrunMiktari
            // 
            this.lblUrunMiktari.AutoSize = true;
            this.lblUrunMiktari.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblUrunMiktari.Location = new System.Drawing.Point(22, 419);
            this.lblUrunMiktari.Name = "lblUrunMiktari";
            this.lblUrunMiktari.Size = new System.Drawing.Size(138, 20);
            this.lblUrunMiktari.TabIndex = 4;
            this.lblUrunMiktari.Text = "Ürünün Miktarı:";
            // 
            // lblUrunFiyat
            // 
            this.lblUrunFiyat.AutoSize = true;
            this.lblUrunFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblUrunFiyat.Location = new System.Drawing.Point(22, 506);
            this.lblUrunFiyat.Name = "lblUrunFiyat";
            this.lblUrunFiyat.Size = new System.Drawing.Size(127, 20);
            this.lblUrunFiyat.TabIndex = 5;
            this.lblUrunFiyat.Text = "Ürünün Fiyatı:";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(209, 506);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(0, 17);
            this.lblFiyat.TabIndex = 6;
            // 
            // btnFiyatHesapla
            // 
            this.btnFiyatHesapla.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnFiyatHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnFiyatHesapla.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFiyatHesapla.ImageKey = "calculator.png";
            this.btnFiyatHesapla.ImageList = this.ımageList1;
            this.btnFiyatHesapla.Location = new System.Drawing.Point(682, 438);
            this.btnFiyatHesapla.Name = "btnFiyatHesapla";
            this.btnFiyatHesapla.Size = new System.Drawing.Size(144, 99);
            this.btnFiyatHesapla.TabIndex = 7;
            this.btnFiyatHesapla.Text = "Hesapla";
            this.btnFiyatHesapla.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFiyatHesapla.UseVisualStyleBackColor = false;
            this.btnFiyatHesapla.Click += new System.EventHandler(this.btnFiyatHesapla_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnGeri.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGeri.ImageKey = "left-arrow.png";
            this.btnGeri.ImageList = this.ımageList1;
            this.btnGeri.Location = new System.Drawing.Point(847, 438);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(144, 99);
            this.btnGeri.TabIndex = 8;
            this.btnGeri.Text = "Geri";
            this.btnGeri.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // lblUrunTipi
            // 
            this.lblUrunTipi.AutoSize = true;
            this.lblUrunTipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunTipi.Location = new System.Drawing.Point(22, 370);
            this.lblUrunTipi.Name = "lblUrunTipi";
            this.lblUrunTipi.Size = new System.Drawing.Size(112, 20);
            this.lblUrunTipi.TabIndex = 9;
            this.lblUrunTipi.Text = "Ürünün Tipi:";
            // 
            // cmbUrunTipi
            // 
            this.cmbUrunTipi.FormattingEnabled = true;
            this.cmbUrunTipi.Location = new System.Drawing.Point(183, 363);
            this.cmbUrunTipi.Name = "cmbUrunTipi";
            this.cmbUrunTipi.Size = new System.Drawing.Size(121, 24);
            this.cmbUrunTipi.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Location = new System.Drawing.Point(26, 393);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(276, 10);
            this.panel2.TabIndex = 31;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.lblUrunSatinAlma);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 48);
            this.panel1.TabIndex = 32;
            // 
            // lblUrunSatinAlma
            // 
            this.lblUrunSatinAlma.AutoSize = true;
            this.lblUrunSatinAlma.BackColor = System.Drawing.Color.DarkOrange;
            this.lblUrunSatinAlma.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunSatinAlma.Location = new System.Drawing.Point(391, 10);
            this.lblUrunSatinAlma.Name = "lblUrunSatinAlma";
            this.lblUrunSatinAlma.Size = new System.Drawing.Size(307, 29);
            this.lblUrunSatinAlma.TabIndex = 33;
            this.lblUrunSatinAlma.Text = "Ürün Satın Alma İşlemleri";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(290, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblUyari
            // 
            this.lblUyari.AutoSize = true;
            this.lblUyari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUyari.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblUyari.Location = new System.Drawing.Point(340, 404);
            this.lblUyari.Name = "lblUyari";
            this.lblUyari.Size = new System.Drawing.Size(527, 18);
            this.lblUyari.TabIndex = 33;
            this.lblUyari.Text = "Uyarı: Hesaplama yapmadan satın alma işlemi gerçekleştiremezsiniz.";
            // 
            // lblBirimFiyat
            // 
            this.lblBirimFiyat.AutoSize = true;
            this.lblBirimFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblBirimFiyat.Location = new System.Drawing.Point(22, 464);
            this.lblBirimFiyat.Name = "lblBirimFiyat";
            this.lblBirimFiyat.Size = new System.Drawing.Size(112, 20);
            this.lblBirimFiyat.TabIndex = 34;
            this.lblBirimFiyat.Text = "Birim Fiyatı:";
            // 
            // txtBirimFiyati
            // 
            this.txtBirimFiyati.Location = new System.Drawing.Point(183, 462);
            this.txtBirimFiyati.Name = "txtBirimFiyati";
            this.txtBirimFiyati.Size = new System.Drawing.Size(119, 22);
            this.txtBirimFiyati.TabIndex = 35;
            // 
            // btnTalepOlustur
            // 
            this.btnTalepOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnTalepOlustur.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTalepOlustur.ImageKey = "request.png";
            this.btnTalepOlustur.ImageList = this.ımageList1;
            this.btnTalepOlustur.Location = new System.Drawing.Point(514, 435);
            this.btnTalepOlustur.Name = "btnTalepOlustur";
            this.btnTalepOlustur.Size = new System.Drawing.Size(144, 102);
            this.btnTalepOlustur.TabIndex = 36;
            this.btnTalepOlustur.Text = "Talep Oluştur";
            this.btnTalepOlustur.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTalepOlustur.UseVisualStyleBackColor = true;
            this.btnTalepOlustur.Click += new System.EventHandler(this.btnTalepOlustur_Click);
            // 
            // lblKomisyon
            // 
            this.lblKomisyon.AutoSize = true;
            this.lblKomisyon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblKomisyon.Location = new System.Drawing.Point(24, 541);
            this.lblKomisyon.Name = "lblKomisyon";
            this.lblKomisyon.Size = new System.Drawing.Size(197, 20);
            this.lblKomisyon.TabIndex = 37;
            this.lblKomisyon.Text = "Muhasebe Komisyonu:";
            // 
            // lblMuhasebeKomisyon
            // 
            this.lblMuhasebeKomisyon.AutoSize = true;
            this.lblMuhasebeKomisyon.Location = new System.Drawing.Point(302, 541);
            this.lblMuhasebeKomisyon.Name = "lblMuhasebeKomisyon";
            this.lblMuhasebeKomisyon.Size = new System.Drawing.Size(0, 17);
            this.lblMuhasebeKomisyon.TabIndex = 38;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkOrange;
            this.panel3.Location = new System.Drawing.Point(28, 442);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(276, 10);
            this.panel3.TabIndex = 32;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkOrange;
            this.panel4.Location = new System.Drawing.Point(28, 484);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(276, 10);
            this.panel4.TabIndex = 32;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkOrange;
            this.panel5.Location = new System.Drawing.Point(28, 527);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(276, 10);
            this.panel5.TabIndex = 39;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkOrange;
            this.panel6.Location = new System.Drawing.Point(28, 564);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(276, 10);
            this.panel6.TabIndex = 40;
            // 
            // BuyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 586);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblMuhasebeKomisyon);
            this.Controls.Add(this.lblKomisyon);
            this.Controls.Add(this.btnTalepOlustur);
            this.Controls.Add(this.txtBirimFiyati);
            this.Controls.Add(this.lblBirimFiyat);
            this.Controls.Add(this.lblUyari);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cmbUrunTipi);
            this.Controls.Add(this.lblUrunTipi);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnFiyatHesapla);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.lblUrunFiyat);
            this.Controls.Add(this.lblUrunMiktari);
            this.Controls.Add(this.txtUrunMiktar);
            this.Controls.Add(this.btnSatinAl);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BuyProduct";
            this.Text = "BuyProduct";
            this.Load += new System.EventHandler(this.BuyProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSatinAl;
        private System.Windows.Forms.TextBox txtUrunMiktar;
        private System.Windows.Forms.Label lblUrunMiktari;
        private System.Windows.Forms.Label lblUrunFiyat;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Button btnFiyatHesapla;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Label lblUrunTipi;
        private System.Windows.Forms.ComboBox cmbUrunTipi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label lblUrunSatinAlma;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUyari;
        private System.Windows.Forms.Label lblBirimFiyat;
        private System.Windows.Forms.TextBox txtBirimFiyati;
        private System.Windows.Forms.Button btnTalepOlustur;
        private System.Windows.Forms.Label lblKomisyon;
        private System.Windows.Forms.Label lblMuhasebeKomisyon;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
    }
}