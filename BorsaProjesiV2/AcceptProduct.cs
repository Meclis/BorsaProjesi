using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
    public partial class AcceptProduct : Form
    {
        public AcceptProduct()
        {
            InitializeComponent();
        }

        SqlConnect sql = new SqlConnect();
        private void AcceptProduct_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select *from OnaylanmamisUrun",sql.Connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }





        int secilen;
        private void btnOnayla_Click(object sender, EventArgs e)
        {
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            //Adminin onayıyla seçilen ürünün ürünler tablosuna eklenmesi.
            SqlCommand komutEkle = new SqlCommand("insert into Urunler (UrunSahibiId,UrunAdi,UrunBirimi,UrunFiyati,UrunId) values (@p1,@p2,@p3,@p4,@p5)",sql.Connection());
            komutEkle.Parameters.AddWithValue("@p1", dataGridView1.Rows[secilen].Cells[0].Value.ToString());
            komutEkle.Parameters.AddWithValue("@p2", dataGridView1.Rows[secilen].Cells[1].Value.ToString());
            komutEkle.Parameters.AddWithValue("@p3", dataGridView1.Rows[secilen].Cells[2].Value.ToString());
            komutEkle.Parameters.AddWithValue("@p4", dataGridView1.Rows[secilen].Cells[3].Value.ToString());
            komutEkle.Parameters.AddWithValue("@p5", dataGridView1.Rows[secilen].Cells[4].Value.ToString());
            komutEkle.ExecuteNonQuery();
            sql.Connection().Close();
            MessageBox.Show("Ürün onaylama işlemi başarıyla gerçekleştirildi!");


            //Onaylanan ürünün onaylanmamış ürün tablosundan silinmesi.
            SqlCommand komutSil = new SqlCommand("Delete From OnaylanmamisUrun Where UrunId=@a1", sql.Connection());
            komutSil.Parameters.AddWithValue("@a1", dataGridView1.Rows[secilen].Cells[4].Value.ToString());
            komutSil.ExecuteNonQuery();
            sql.Connection().Close();

            AcceptProduct acceptProduct = new AcceptProduct();
            acceptProduct.Show();
            this.Hide();




        }
    }
}
