
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
            this.btnOnaylanmamisUrun = new System.Windows.Forms.Button();
            this.btnOnaylanmamisBakiye = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOnaylanmamisUrun
            // 
            this.btnOnaylanmamisUrun.Location = new System.Drawing.Point(67, 104);
            this.btnOnaylanmamisUrun.Name = "btnOnaylanmamisUrun";
            this.btnOnaylanmamisUrun.Size = new System.Drawing.Size(222, 133);
            this.btnOnaylanmamisUrun.TabIndex = 0;
            this.btnOnaylanmamisUrun.Text = "Onaylanmamış Ürün";
            this.btnOnaylanmamisUrun.UseVisualStyleBackColor = true;
            this.btnOnaylanmamisUrun.Click += new System.EventHandler(this.btnOnaylanmamisUrun_Click);
            // 
            // btnOnaylanmamisBakiye
            // 
            this.btnOnaylanmamisBakiye.Location = new System.Drawing.Point(334, 104);
            this.btnOnaylanmamisBakiye.Name = "btnOnaylanmamisBakiye";
            this.btnOnaylanmamisBakiye.Size = new System.Drawing.Size(222, 133);
            this.btnOnaylanmamisBakiye.TabIndex = 1;
            this.btnOnaylanmamisBakiye.Text = "Onaylanmamış Bakiye";
            this.btnOnaylanmamisBakiye.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 406);
            this.Controls.Add(this.btnOnaylanmamisBakiye);
            this.Controls.Add(this.btnOnaylanmamisUrun);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOnaylanmamisUrun;
        private System.Windows.Forms.Button btnOnaylanmamisBakiye;
    }
}