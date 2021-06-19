
namespace BorsaProjesi
{
    partial class Wallet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wallet));
            this.lblParaEkle = new System.Windows.Forms.Label();
            this.txtPara = new System.Windows.Forms.TextBox();
            this.lblBakiyeniz = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnGeri = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCuzdan = new System.Windows.Forms.Label();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.cmbDovizTipi = new System.Windows.Forms.ComboBox();
            this.lblDoviz = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblParaEkle
            // 
            this.lblParaEkle.AutoSize = true;
            this.lblParaEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblParaEkle.Location = new System.Drawing.Point(12, 81);
            this.lblParaEkle.Name = "lblParaEkle";
            this.lblParaEkle.Size = new System.Drawing.Size(105, 24);
            this.lblParaEkle.TabIndex = 1;
            this.lblParaEkle.Text = "Para Ekle:";
            // 
            // txtPara
            // 
            this.txtPara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPara.Location = new System.Drawing.Point(140, 76);
            this.txtPara.Name = "txtPara";
            this.txtPara.Size = new System.Drawing.Size(100, 27);
            this.txtPara.TabIndex = 2;
            // 
            // lblBakiyeniz
            // 
            this.lblBakiyeniz.AutoSize = true;
            this.lblBakiyeniz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblBakiyeniz.Location = new System.Drawing.Point(12, 156);
            this.lblBakiyeniz.Name = "lblBakiyeniz";
            this.lblBakiyeniz.Size = new System.Drawing.Size(104, 24);
            this.lblBakiyeniz.TabIndex = 3;
            this.lblBakiyeniz.Text = "Bakiyeniz:";
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEkle.ImageKey = "plus.png";
            this.btnEkle.ImageList = this.ımageList1;
            this.btnEkle.Location = new System.Drawing.Point(27, 261);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(131, 106);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "plus.png");
            this.ımageList1.Images.SetKeyName(1, "left-arrow.png");
            // 
            // btnGeri
            // 
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnGeri.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGeri.ImageKey = "left-arrow.png";
            this.btnGeri.ImageList = this.ımageList1;
            this.btnGeri.Location = new System.Drawing.Point(188, 261);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(131, 106);
            this.btnGeri.TabIndex = 6;
            this.btnGeri.Text = "Geri";
            this.btnGeri.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Location = new System.Drawing.Point(16, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 10);
            this.panel2.TabIndex = 32;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Location = new System.Drawing.Point(16, 182);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 10);
            this.panel1.TabIndex = 33;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkOrange;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.lblCuzdan);
            this.panel3.Location = new System.Drawing.Point(1, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(465, 46);
            this.panel3.TabIndex = 34;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(100, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lblCuzdan
            // 
            this.lblCuzdan.AutoSize = true;
            this.lblCuzdan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCuzdan.Location = new System.Drawing.Point(218, 0);
            this.lblCuzdan.Name = "lblCuzdan";
            this.lblCuzdan.Size = new System.Drawing.Size(100, 29);
            this.lblCuzdan.TabIndex = 0;
            this.lblCuzdan.Text = "Cüzdan";
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBakiye.Location = new System.Drawing.Point(137, 156);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(0, 20);
            this.lblBakiye.TabIndex = 35;
            // 
            // cmbDovizTipi
            // 
            this.cmbDovizTipi.FormattingEnabled = true;
            this.cmbDovizTipi.Items.AddRange(new object[] {
            "TÜRK LİRASI",
            "ABD DOLARI",
            "EURO",
            "İNGİLİZ STERLİNİ"});
            this.cmbDovizTipi.Location = new System.Drawing.Point(119, 210);
            this.cmbDovizTipi.Name = "cmbDovizTipi";
            this.cmbDovizTipi.Size = new System.Drawing.Size(121, 24);
            this.cmbDovizTipi.TabIndex = 37;
            // 
            // lblDoviz
            // 
            this.lblDoviz.AutoSize = true;
            this.lblDoviz.Location = new System.Drawing.Point(13, 213);
            this.lblDoviz.Name = "lblDoviz";
            this.lblDoviz.Size = new System.Drawing.Size(74, 17);
            this.lblDoviz.TabIndex = 39;
            this.lblDoviz.Text = "Döviz Tipi:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(481, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(628, 333);
            this.dataGridView1.TabIndex = 40;
            // 
            // Wallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 373);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblDoviz);
            this.Controls.Add(this.cmbDovizTipi);
            this.Controls.Add(this.lblBakiye);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lblBakiyeniz);
            this.Controls.Add(this.txtPara);
            this.Controls.Add(this.lblParaEkle);
            this.Name = "Wallet";
            this.Text = "Wallet";
            this.Load += new System.EventHandler(this.Wallet_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblParaEkle;
        private System.Windows.Forms.TextBox txtPara;
        private System.Windows.Forms.Label lblBakiyeniz;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblCuzdan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.ComboBox cmbDovizTipi;
        private System.Windows.Forms.Label lblDoviz;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}