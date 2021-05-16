
namespace WindowsFormsApp3
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.btnOnaylanmamisUrun = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnOnaylanmamisBakiye = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOnaylanmamisUrun
            // 
            this.btnOnaylanmamisUrun.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnaylanmamisUrun.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOnaylanmamisUrun.ImageKey = "thumb-down.png";
            this.btnOnaylanmamisUrun.ImageList = this.ımageList1;
            this.btnOnaylanmamisUrun.Location = new System.Drawing.Point(32, 133);
            this.btnOnaylanmamisUrun.Name = "btnOnaylanmamisUrun";
            this.btnOnaylanmamisUrun.Size = new System.Drawing.Size(222, 133);
            this.btnOnaylanmamisUrun.TabIndex = 0;
            this.btnOnaylanmamisUrun.Text = "Onaylanmamış     Ürün";
            this.btnOnaylanmamisUrun.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOnaylanmamisUrun.UseVisualStyleBackColor = true;
            this.btnOnaylanmamisUrun.Click += new System.EventHandler(this.btnOnaylanmamisUrun_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "log-out.png");
            this.ımageList1.Images.SetKeyName(1, "thumb-down.png");
            // 
            // btnOnaylanmamisBakiye
            // 
            this.btnOnaylanmamisBakiye.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnaylanmamisBakiye.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOnaylanmamisBakiye.ImageKey = "thumb-down.png";
            this.btnOnaylanmamisBakiye.ImageList = this.ımageList1;
            this.btnOnaylanmamisBakiye.Location = new System.Drawing.Point(351, 133);
            this.btnOnaylanmamisBakiye.Name = "btnOnaylanmamisBakiye";
            this.btnOnaylanmamisBakiye.Size = new System.Drawing.Size(222, 133);
            this.btnOnaylanmamisBakiye.TabIndex = 1;
            this.btnOnaylanmamisBakiye.Text = "Onaylanmamış Bakiye";
            this.btnOnaylanmamisBakiye.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOnaylanmamisBakiye.UseVisualStyleBackColor = true;
            this.btnOnaylanmamisBakiye.Click += new System.EventHandler(this.btnOnaylanmamisBakiye_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCikis.ImageKey = "log-out.png";
            this.btnCikis.ImageList = this.ımageList1;
            this.btnCikis.Location = new System.Drawing.Point(447, 308);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(126, 90);
            this.btnCikis.TabIndex = 2;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(91, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(621, 52);
            this.panel2.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(224, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 28);
            this.label1.TabIndex = 29;
            this.label1.Text = "Admin İşlemleri";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 432);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnOnaylanmamisBakiye);
            this.Controls.Add(this.btnOnaylanmamisUrun);
            this.Controls.Add(this.panel2);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOnaylanmamisUrun;
        private System.Windows.Forms.Button btnOnaylanmamisBakiye;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList ımageList1;
    }
}