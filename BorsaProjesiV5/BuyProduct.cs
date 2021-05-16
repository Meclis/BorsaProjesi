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
    public partial class BuyProduct : Form
    {
        List<User> users;
        int index;
        List<Product> products;
        ProductManager productManager = new ProductManager();

        SqlConnect sql = new SqlConnect();
        public BuyProduct(List<User> users2,int index2)
        {
            InitializeComponent();
            users = users2;
            index = index2;
        }

        private void BuyProduct_Load(object sender, EventArgs e)
        {
            products = productManager.GetList();
            DataTable listProduct = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select *from Urunler where UrunOnay!=0 and UrunSahibiId!=@p1",sql.Connection());
            dataAdapter.SelectCommand.Parameters.AddWithValue("@p1", index + 1);
            dataAdapter.Fill(listProduct);
            dataGridView1.DataSource = listProduct;

            int i = 0, k = 0;

            string eklenenUrun="";

            foreach (var product in products)
            {
            
                foreach (var prdct in products)
                {
                    if(products[i].UrunAdi==products[k].UrunAdi)
                    {

                            if (eklenenUrun != products[i].UrunAdi)
                            {
                                cmbUrunTipi.Items.Add(products[i].UrunAdi);
                                eklenenUrun = products[i].UrunAdi;
                           
                            }

                    }
                    k++;   
                }
                i++;
                k = 0;
            }





        }

        int secilen;
        private void btnSatinAl_Click(object sender, EventArgs e)
        {




            //secilen= dataGridView1.SelectedCells[0].RowIndex;
            //if (Convert.ToInt32(dataGridView1.Rows[secilen].Cells[3].Value.ToString())*Convert.ToInt32(txtUrunMiktar.Text)<=Convert.ToInt32(users[index].GuncelBakiye))
            //{
            //    if(Convert.ToInt32(txtUrunMiktar.Text)<Convert.ToInt32(dataGridView1.Rows[secilen].Cells[2].Value.ToString()))
            //    {
            //        int fiyat = Convert.ToInt32(dataGridView1.Rows[secilen].Cells[3].Value.ToString()) * Convert.ToInt32(txtUrunMiktar.Text);
            //        users[index].GuncelBakiye = Convert.ToString(Convert.ToInt32(users[index].GuncelBakiye) - fiyat);
            //        SqlCommand buyerWallet = new SqlCommand("update KullaniciBilgileri SET GuncelBakiye=@p1 where ıd=@p2", sql.Connection());
            //        buyerWallet.Parameters.AddWithValue("@p1", users[index].GuncelBakiye);
            //        buyerWallet.Parameters.AddWithValue("@p2", index + 1);
            //        buyerWallet.ExecuteNonQuery();
            //        sql.Connection().Close();

            //        int sellerId =Convert.ToInt32(dataGridView1.Rows[secilen].Cells[0].Value.ToString());
            //        users[sellerId-1].GuncelBakiye= Convert.ToString(Convert.ToInt32(users[sellerId-1].GuncelBakiye) + fiyat);
            //        SqlCommand sellerWallet = new SqlCommand("update KullaniciBilgileri SET GuncelBakiye=@p1 where ıd=@p2", sql.Connection());
            //        sellerWallet.Parameters.AddWithValue("@p1", users[sellerId-1].GuncelBakiye);
            //        sellerWallet.Parameters.AddWithValue("@p2", sellerId);
            //        sellerWallet.ExecuteNonQuery();
            //        sql.Connection().Close();


            //        int productId= Convert.ToInt32(dataGridView1.Rows[secilen].Cells[4].Value.ToString());
            //        SqlCommand buyProductUnit = new SqlCommand("update Urunler SET UrunBirimi=@p1 where UrunId=@p2", sql.Connection());
            //        products[productId-1].UrunBirimi=Convert.ToString(Convert.ToInt32(products[productId - 1].UrunBirimi) -Convert.ToInt32(txtUrunMiktar.Text));
            //        buyProductUnit.Parameters.AddWithValue("@p1", products[productId - 1].UrunBirimi);
            //        buyProductUnit.Parameters.AddWithValue("@p2", dataGridView1.Rows[secilen].Cells[4].Value.ToString());
            //        buyProductUnit.ExecuteNonQuery();
            //        sql.Connection().Close();
            //        MessageBox.Show("Satın alma işlemi başarıyla gerçekleştirilmiştir!");



            //    }
                
               
            //}



        }

        private void btnFiyatHesapla_Click(object sender, EventArgs e)
        {
            int istenenUrunBirimi = Convert.ToInt32(txtUrunMiktar.Text);
            int kucukFiyat = 5000;
            int toplamFiyat = 0;
            int secilenUrunBirimi = 0;
            int a = 0, b = 0;

            while (istenenUrunBirimi>0)
            {
                b = 0;
                foreach (var product in products)
                {
                    if (products[b].UrunAdi == Convert.ToString(cmbUrunTipi.SelectedItem) && Convert.ToInt32(products[b].UrunFiyati) < kucukFiyat && Convert.ToInt32(products[b].UrunBirimi) > 0)
                    {

                        kucukFiyat = Convert.ToInt32(products[b].UrunFiyati);
                        secilenUrunBirimi = Convert.ToInt32(products[b].UrunBirimi);
                        a = b;
                    }
                    b++;

                }

                if (istenenUrunBirimi <= secilenUrunBirimi)
                {
                    toplamFiyat = toplamFiyat+(istenenUrunBirimi*kucukFiyat);
                    istenenUrunBirimi = istenenUrunBirimi - secilenUrunBirimi;
                    products[a].UrunBirimi= Convert.ToString(Convert.ToInt32(products[a].UrunBirimi) - istenenUrunBirimi);

                    break;

                }
                else if (istenenUrunBirimi > secilenUrunBirimi)
                {
                    toplamFiyat = toplamFiyat + (secilenUrunBirimi * kucukFiyat);
                    istenenUrunBirimi = istenenUrunBirimi - secilenUrunBirimi;
                    products[a].UrunBirimi = "0";
                   

                }

                kucukFiyat = 5000;
            }



            lblFiyat.Text = Convert.ToString(toplamFiyat);
           
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm(users, index);
            userForm.Show();
            this.Hide();
        }
    }
}
