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
            //Artık onaylanmış ürünleri çekmek istersen UrunOnay=1 yap.
            SqlDataAdapter da = new SqlDataAdapter("select *from Urunler where UrunOnay=0",sql.Connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        int secilen;
        private void btnOnayla_Click(object sender, EventArgs e)
        {
            secilen = dataGridView1.SelectedCells[0].RowIndex;

            SqlCommand komutEkle = new SqlCommand("Update Urunler SET UrunOnay=@p1 where UrunId=@p2",sql.Connection());
            komutEkle.Parameters.AddWithValue("@p1", true);
            komutEkle.Parameters.AddWithValue("@p2", dataGridView1.Rows[secilen].Cells[4].Value.ToString());
            komutEkle.ExecuteNonQuery();
            sql.Connection().Close();
            MessageBox.Show("Ürün onaylama işlemi başarıyla gerçekleştirildi!");


            AcceptProduct acceptProduct = new AcceptProduct();
            acceptProduct.Show();
            this.Hide();




        }
    }
}
