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
        List<User> users;
        int index;

        public AcceptProduct(List<User> users2,int index2)
        {
            InitializeComponent();
            users = users2;
            index = index2;
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

       
        private void btnOnayla_Click(object sender, EventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            SqlCommand komutEkle = new SqlCommand("Update Urunler SET UrunOnay=@p1,EskiUrunBirimi=@p2,EskiUrunFiyati=@p3 where UrunId=@p4",sql.Connection());
            komutEkle.Parameters.AddWithValue("@p1", true);
            komutEkle.Parameters.AddWithValue("@p2", 0);
            komutEkle.Parameters.AddWithValue("@p3", 0);
            komutEkle.Parameters.AddWithValue("@p4", dataGridView1.Rows[secilen].Cells[4].Value.ToString());
            komutEkle.ExecuteNonQuery();
            sql.Connection().Close();
            MessageBox.Show("Ürün onaylama işlemi başarıyla gerçekleştirildi!");


            AcceptProduct acceptProduct = new AcceptProduct(users,index);
            acceptProduct.Show();
            this.Hide();




        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm(users,index);
            adminForm.Show();
            this.Hide();

        }
    }
}
