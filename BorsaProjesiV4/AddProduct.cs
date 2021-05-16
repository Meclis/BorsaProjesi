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

        SqlConnect sql=new SqlConnect();
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
            komut.Parameters.AddWithValue("@p2", txtUrunAdi.Text);
            komut.Parameters.AddWithValue("@p3", txtUrunBirimi.Text);
            komut.Parameters.AddWithValue("@p4", txtUrunFiyati.Text);
            komut.Parameters.AddWithValue("@p5", false);
            komut.ExecuteNonQuery();
            sql.Connection().Close();
            MessageBox.Show("Ürün ekleme işleminiz başarıyla gerçekleşti");
            AddProduct addProduct = new AddProduct(users,index2);
            addProduct.Show();
            this.Hide();


        }
    }
}
