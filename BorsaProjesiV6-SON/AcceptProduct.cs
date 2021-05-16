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
        int UserIndex;

        public AcceptProduct(List<User> users2,int index)
        {
            InitializeComponent();
            users = users2;
            UserIndex = index;
        }

        SqlConnect sqlConnect = new SqlConnect();
        private void AcceptProduct_Load(object sender, EventArgs e)
        {
            DataTable productTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select *from Urunler where UrunOnay=0",sqlConnect.Connection());
            dataAdapter.Fill(productTable);
            dataGridView1.DataSource = productTable;
        }

       
        private void btnOnayla_Click(object sender, EventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            SqlCommand komutUrunOnayla = new SqlCommand("Update Urunler SET UrunOnay=@p1,EskiUrunBirimi=@p2,EskiUrunFiyati=@p3 where UrunId=@p4",sqlConnect.Connection());
            komutUrunOnayla.Parameters.AddWithValue("@p1", true);
            komutUrunOnayla.Parameters.AddWithValue("@p2", 0);
            komutUrunOnayla.Parameters.AddWithValue("@p3", 0);
            komutUrunOnayla.Parameters.AddWithValue("@p4", dataGridView1.Rows[secilen].Cells[4].Value.ToString());
            komutUrunOnayla.ExecuteNonQuery();
            sqlConnect.Connection().Close();
            MessageBox.Show("Ürün onaylama işlemi başarıyla gerçekleştirildi!");


            AcceptProduct acceptProduct = new AcceptProduct(users, UserIndex);
            acceptProduct.Show();
            this.Hide();




        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm(users, UserIndex);
            adminForm.Show();
            this.Hide();

        }
    }
}
