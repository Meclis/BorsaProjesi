
namespace BorsaProjesi
{
    partial class AccountingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountingForm));
            this.lblMuhasebeBakiye = new System.Windows.Forms.Label();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnCek = new System.Windows.Forms.Button();
            this.lblTl = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMuhasebeBakiye
            // 
            this.lblMuhasebeBakiye.AutoSize = true;
            this.lblMuhasebeBakiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMuhasebeBakiye.Location = new System.Drawing.Point(3, 35);
            this.lblMuhasebeBakiye.Name = "lblMuhasebeBakiye";
            this.lblMuhasebeBakiye.Size = new System.Drawing.Size(207, 25);
            this.lblMuhasebeBakiye.TabIndex = 0;
            this.lblMuhasebeBakiye.Text = "Muhasebe Bakiyesi:";
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.Location = new System.Drawing.Point(273, 35);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(0, 17);
            this.lblBakiye.TabIndex = 1;
            // 
            // btnGeri
            // 
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnGeri.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGeri.ImageKey = "left-arrow.png";
            this.btnGeri.ImageList = this.ımageList1;
            this.btnGeri.Location = new System.Drawing.Point(298, 172);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(119, 103);
            this.btnGeri.TabIndex = 2;
            this.btnGeri.Text = "Geri";
            this.btnGeri.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "left-arrow.png");
            this.ımageList1.Images.SetKeyName(1, "atm.png");
            // 
            // btnCek
            // 
            this.btnCek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnCek.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCek.ImageKey = "atm.png";
            this.btnCek.ImageList = this.ımageList1;
            this.btnCek.Location = new System.Drawing.Point(42, 172);
            this.btnCek.Name = "btnCek";
            this.btnCek.Size = new System.Drawing.Size(119, 103);
            this.btnCek.TabIndex = 3;
            this.btnCek.Text = "Çek";
            this.btnCek.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCek.UseVisualStyleBackColor = true;
            // 
            // lblTl
            // 
            this.lblTl.AutoSize = true;
            this.lblTl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTl.Location = new System.Drawing.Point(360, 35);
            this.lblTl.Name = "lblTl";
            this.lblTl.Size = new System.Drawing.Size(38, 25);
            this.lblTl.TabIndex = 4;
            this.lblTl.Text = "TL";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkOrange;
            this.panel6.Controls.Add(this.panel2);
            this.panel6.Controls.Add(this.lblTl);
            this.panel6.Controls.Add(this.lblBakiye);
            this.panel6.Controls.Add(this.lblMuhasebeBakiye);
            this.panel6.Location = new System.Drawing.Point(2, 63);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(462, 89);
            this.panel6.TabIndex = 34;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Location = new System.Drawing.Point(8, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(390, 10);
            this.panel2.TabIndex = 34;
            // 
            // AccountingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 304);
            this.Controls.Add(this.btnCek);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.panel6);
            this.Name = "AccountingForm";
            this.Text = "AccountingForm";
            this.Load += new System.EventHandler(this.AccountingForm_Load);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMuhasebeBakiye;
        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnCek;
        private System.Windows.Forms.Label lblTl;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ImageList ımageList1;
    }
}