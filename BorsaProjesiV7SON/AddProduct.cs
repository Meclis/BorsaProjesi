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
    public partial class AddProduct : Form
    {
        List<User> users;
        int index2;
        internal static string urunIndex;

        SqlConnect sql=new SqlConnect();
        List<Product> products;

        ProductManager productManager = new ProductManager();
        public AddProduct(List<User> users2,int index)
        {
            InitializeComponent();
            users = users2;
            index2 = index;
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Urunler (UrunSahibiId,UrunAdi,UrunBirimi,UrunFiyati,UrunOnay) values (@p1,@p2,@p3,@p4,@p5)", sql.Connection());
            komut.Parameters.AddWithValue("@p1", index2+1);
            komut.Parameters.AddWithValue("@p2", cmbUrunTipi.SelectedItem);
            komut.Parameters.AddWithValue("@p3", txtUrunBirimi.Text);
            komut.Parameters.AddWithValue("@p4", txtUrunFiyati.Text);
            komut.Parameters.AddWithValue("@p5", false);
            komut.ExecuteNonQuery();
            sql.Connection().Close();
            MessageBox.Show("Ürün ekleme işleminiz admin onayı sonrasında başarıyla gerçekleşecektir!");
            AddProduct addProduct = new AddProduct(users,index2);
            addProduct.Show();
            this.Hide();


        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            products = productManager.GetList();
            
            DataTable productTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select *from Urunler where UrunSahibiId=@p1",sql.Connection());
            dataAdapter.SelectCommand.Parameters.AddWithValue("@p1", index2 + 1);
            dataAdapter.Fill(productTable);
            dataGridView1.DataSource = productTable;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            products[Convert.ToInt32(urunIndex) - 1].EskiUrunFiyati = products[Convert.ToInt32(urunIndex) - 1].UrunFiyati;
            products[Convert.ToInt32(urunIndex) - 1].UrunFiyati = txtGuncelUrunFiyati.Text;

            products[Convert.ToInt32(urunIndex) - 1].EskiUrunBirimi = products[Convert.ToInt32(urunIndex) - 1].UrunBirimi;
            products[Convert.ToInt32(urunIndex) - 1].UrunBirimi = txtGuncelUrunBirimi.Text;

            SqlCommand urunGuncelle = new SqlCommand("Update Urunler set UrunBirimi=@p1,UrunFiyati=@p2,UrunOnay=@p3,EskiUrunFiyati=@p4,EskiUrunBirimi=@p5",sql.Connection());
           
            urunGuncelle.Parameters.AddWithValue("@p1", txtGuncelUrunBirimi.Text);
            urunGuncelle.Parameters.AddWithValue("@p2", txtGuncelUrunFiyati.Text);
            urunGuncelle.Parameters.AddWithValue("@p3", false);
            urunGuncelle.Parameters.AddWithValue("@p4", products[Convert.ToInt32(urunIndex) - 1].EskiUrunFiyati);
            urunGuncelle.Parameters.AddWithValue("@p5", products[Convert.ToInt32(urunIndex) - 1].EskiUrunBirimi);

            urunGuncelle.ExecuteNonQuery();
            MessageBox.Show("Ürün güncelleme işleminiz admin onayından sonra başarıyla gerçekleştirilecektir!");

            

            AddProduct addProduct = new AddProduct(users,index2);
            addProduct.Show();
            this.Hide();


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int secilen=dataGridView1.SelectedCells[0].RowIndex;
            txtGuncelUrunBirimi.Text= dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtGuncelUrunFiyati.Text= dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            urunIndex = dataGridView1.Rows[secilen].Cells[4].Value.ToString();

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm(users,index2);
            userForm.Show();
            this.Hide();

        }
    }
}
