
namespace WindowsFormsApp3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.btnFiyatHesapla = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbUrunTipi = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(839, 260);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnSatinAl
            // 
            this.btnSatinAl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSatinAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnSatinAl.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSatinAl.ImageKey = "payment-method.png";
            this.btnSatinAl.ImageList = this.ımageList1;
            this.btnSatinAl.Location = new System.Drawing.Point(356, 417);
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
            // 
            // txtUrunMiktar
            // 
            this.txtUrunMiktar.Location = new System.Drawing.Point(167, 408);
            this.txtUrunMiktar.Name = "txtUrunMiktar";
            this.txtUrunMiktar.Size = new System.Drawing.Size(119, 22);
            this.txtUrunMiktar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(22, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ürünün Miktarı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(20, 461);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ürünün Fiyatı:";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(129, 375);
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
            this.btnFiyatHesapla.Location = new System.Drawing.Point(533, 418);
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
            this.btnGeri.Location = new System.Drawing.Point(707, 418);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(144, 99);
            this.btnGeri.TabIndex = 8;
            this.btnGeri.Text = "Geri";
            this.btnGeri.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(22, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ürünün Tipi:";
            // 
            // cmbUrunTipi
            // 
            this.cmbUrunTipi.FormattingEnabled = true;
            this.cmbUrunTipi.Location = new System.Drawing.Point(167, 345);
            this.cmbUrunTipi.Name = "cmbUrunTipi";
            this.cmbUrunTipi.Size = new System.Drawing.Size(121, 24);
            this.cmbUrunTipi.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Location = new System.Drawing.Point(26, 375);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(262, 10);
            this.panel2.TabIndex = 31;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 39);
            this.panel1.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkOrange;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(294, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(307, 29);
            this.label4.TabIndex = 33;
            this.label4.Text = "Ürün Satın Alma İşlemleri";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(223, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkOrange;
            this.panel3.Location = new System.Drawing.Point(26, 483);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(262, 10);
            this.panel3.TabIndex = 32;
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "shopping-cart.png");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(352, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(506, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Uyarı: Hesaplama yapmadan satın alma işlemi gerçekleştiremezsiniz.";
            // 
            // BuyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 544);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cmbUrunTipi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnFiyatHesapla);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Button btnFiyatHesapla;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbUrunTipi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
    }
}