
namespace BorsaProjesi
{
    partial class AcceptProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcceptProduct));
            this.yazilimYapimiDataSet1 = new BorsaProjesi.YazilimYapimiDataSet1();
            this.yazilimYapimiDataSet11 = new BorsaProjesi.YazilimYapimiDataSet1();
            this.yazilimYapimiDataSet11BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnGeri = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUrunOnaylama = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.yazilimYapimiDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazilimYapimiDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazilimYapimiDataSet11BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // yazilimYapimiDataSet1
            // 
            this.yazilimYapimiDataSet1.DataSetName = "YazilimYapimiDataSet1";
            this.yazilimYapimiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yazilimYapimiDataSet11
            // 
            this.yazilimYapimiDataSet11.DataSetName = "YazilimYapimiDataSet1";
            this.yazilimYapimiDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yazilimYapimiDataSet11BindingSource
            // 
            this.yazilimYapimiDataSet11BindingSource.DataSource = this.yazilimYapimiDataSet11;
            this.yazilimYapimiDataSet11BindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(799, 324);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnOnayla
            // 
            this.btnOnayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnOnayla.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOnayla.ImageKey = "maps-and-flags.png";
            this.btnOnayla.ImageList = this.ımageList1;
            this.btnOnayla.Location = new System.Drawing.Point(497, 412);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(110, 97);
            this.btnOnayla.TabIndex = 1;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "maps-and-flags.png");
            this.ımageList1.Images.SetKeyName(1, "left-arrow.png");
            // 
            // btnGeri
            // 
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnGeri.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGeri.ImageKey = "left-arrow.png";
            this.btnGeri.ImageList = this.ımageList1;
            this.btnGeri.Location = new System.Drawing.Point(645, 412);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(97, 97);
            this.btnGeri.TabIndex = 2;
            this.btnGeri.Text = "Geri";
            this.btnGeri.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblUrunOnaylama);
            this.panel1.Location = new System.Drawing.Point(-1, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 50);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(219, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblUrunOnaylama
            // 
            this.lblUrunOnaylama.AutoSize = true;
            this.lblUrunOnaylama.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunOnaylama.Location = new System.Drawing.Point(325, 12);
            this.lblUrunOnaylama.Name = "lblUrunOnaylama";
            this.lblUrunOnaylama.Size = new System.Drawing.Size(191, 29);
            this.lblUrunOnaylama.TabIndex = 0;
            this.lblUrunOnaylama.Text = "Ürün Onaylama";
            // 
            // AcceptProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 521);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AcceptProduct";
            this.Text = "AcceptProduct";
            this.Load += new System.EventHandler(this.AcceptProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yazilimYapimiDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazilimYapimiDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazilimYapimiDataSet11BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BorsaProjesi.YazilimYapimiDataSet1 yazilimYapimiDataSet1;
        private YazilimYapimiDataSet1 yazilimYapimiDataSet11;
        private System.Windows.Forms.BindingSource yazilimYapimiDataSet11BindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUrunOnaylama;
    }
}