
namespace WindowsFormsApp3
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
            this.yazilimYapimiDataSet1 = new WindowsFormsApp3.YazilimYapimiDataSet1();
            this.yazilimYapimiDataSet11 = new WindowsFormsApp3.YazilimYapimiDataSet1();
            this.yazilimYapimiDataSet11BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnOnayla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.yazilimYapimiDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazilimYapimiDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazilimYapimiDataSet11BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(25, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(465, 285);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnOnayla
            // 
            this.btnOnayla.Location = new System.Drawing.Point(463, 338);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(145, 55);
            this.btnOnayla.TabIndex = 1;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // AcceptProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AcceptProduct";
            this.Text = "AcceptProduct";
            this.Load += new System.EventHandler(this.AcceptProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yazilimYapimiDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazilimYapimiDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazilimYapimiDataSet11BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WindowsFormsApp3.YazilimYapimiDataSet1 yazilimYapimiDataSet1;
        private YazilimYapimiDataSet1 yazilimYapimiDataSet11;
        private System.Windows.Forms.BindingSource yazilimYapimiDataSet11BindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnOnayla;
    }
}