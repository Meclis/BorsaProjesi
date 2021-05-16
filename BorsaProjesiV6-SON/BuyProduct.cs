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
        int UserIndex;

        List<Product> products;
        ProductManager productManager = new ProductManager();

        SqlConnect sqlConnect = new SqlConnect();

        public BuyProduct(List<User> users2,int index)
        {
            InitializeComponent();
            users = users2;
            UserIndex = index;
        }

        private void BuyProduct_Load(object sender, EventArgs e)
        {
            products = productManager.GetList();
            DataTable listProduct = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select *from Urunler where UrunOnay!=0 and UrunSahibiId!=@p1 and UrunBirimi!=0", sqlConnect.Connection());
            dataAdapter.SelectCommand.Parameters.AddWithValue("@p1", UserIndex + 1);
            dataAdapter.Fill(listProduct);
            dataGridView1.DataSource = listProduct;

            btnSatinAl.Visible = false;

            int i = 0, k = 0;

            string eklenenUrun="";

            foreach (var product in products)
            {
            
                foreach (var product2 in products)
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
        
        private void btnSatinAl_Click(object sender, EventArgs e)
        {
            
            int istenenUrunBirimi = Convert.ToInt32(txtUrunMiktar.Text);
            int istenenUrunBirimiYedek;
            int kucukFiyat = 5000;
            int secilenUrunBirimi = 0;
            int a = 0, b = 0;
            int urunSahibiIndex;

            while (istenenUrunBirimi > 0)
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



                urunSahibiIndex = Convert.ToInt32(products[a].UrunSahibiId)-1;

                if (Convert.ToInt32(users[UserIndex].GuncelBakiye)>=Convert.ToInt32(lblFiyat.Text))
                {
                    users[UserIndex].GuncelBakiye = Convert.ToString(Convert.ToInt32(users[UserIndex].GuncelBakiye) - Convert.ToInt32(lblFiyat.Text));
                    SqlCommand buyerWallet = new SqlCommand("update KullaniciBilgileri SET GuncelBakiye=@p1 where ıd=@p2", sqlConnect.Connection());
                    buyerWallet.Parameters.AddWithValue("@p1", users[UserIndex].GuncelBakiye);
                    buyerWallet.Parameters.AddWithValue("@p2", UserIndex + 1);
                    buyerWallet.ExecuteNonQuery();
                    sqlConnect.Connection().Close();
                   

                    users[urunSahibiIndex].GuncelBakiye = Convert.ToString(Convert.ToInt32(users[urunSahibiIndex].GuncelBakiye) + Convert.ToInt32(lblFiyat.Text));
                    SqlCommand sellerWallet = new SqlCommand("update KullaniciBilgileri SET GuncelBakiye=@p1 where ıd=@p2", sqlConnect.Connection());
                    sellerWallet.Parameters.AddWithValue("@p1", users[urunSahibiIndex].GuncelBakiye);
                    sellerWallet.Parameters.AddWithValue("@p2", urunSahibiIndex + 1);
                    sellerWallet.ExecuteNonQuery();
                    sqlConnect.Connection().Close();

                   

                    if (istenenUrunBirimi <= secilenUrunBirimi)
                    {

                        istenenUrunBirimiYedek = istenenUrunBirimi;
                        istenenUrunBirimi = istenenUrunBirimi - secilenUrunBirimi;
                        products[a].UrunBirimi = Convert.ToString(Convert.ToInt32(products[a].UrunBirimi) - istenenUrunBirimiYedek);

                        SqlCommand buyProductUnit = new SqlCommand("update Urunler SET UrunBirimi=@p1 where UrunId=@p2", sqlConnect.Connection());

                        buyProductUnit.Parameters.AddWithValue("@p1", products[a].UrunBirimi);
                        buyProductUnit.Parameters.AddWithValue("@p2", products[a].UrunId);
                        buyProductUnit.ExecuteNonQuery();
                        sqlConnect.Connection().Close();
                    

                        break;

                    }
                    else if (istenenUrunBirimi > secilenUrunBirimi)
                    {
                        istenenUrunBirimi = istenenUrunBirimi - secilenUrunBirimi;
                        products[a].UrunBirimi = "0";

                        SqlCommand buyProductUnit = new SqlCommand("update Urunler SET UrunBirimi=@p1 where UrunId=@p2", sqlConnect.Connection());

                        buyProductUnit.Parameters.AddWithValue("@p1", products[a].UrunBirimi);
                        buyProductUnit.Parameters.AddWithValue("@p2", products[a].UrunId);
                        buyProductUnit.ExecuteNonQuery();
                        sqlConnect.Connection().Close();
                    }

                    kucukFiyat = 5000;

                }
                else
                {
                    MessageBox.Show("Yeterli Bakiyeniz bulunmamaktadır!");
                    BuyProduct buyProduct = new BuyProduct(users, UserIndex);
                    buyProduct.Show();
                    this.Hide();
                    break;

                }

               
            }
            BuyProduct buyProduct1 = new BuyProduct(users, UserIndex);
            buyProduct1.Show();
            this.Hide();

        }

        int listUrunBirimiYedek;
        private void btnFiyatHesapla_Click(object sender, EventArgs e)
        {
            btnSatinAl.Visible = true;
            int istenenUrunBirimi = Convert.ToInt32(txtUrunMiktar.Text);
            int kucukFiyat = 5000;
            int toplamFiyat = 0;
            int secilenUrunBirimi = 0;
            int a = 0, b = 0;
            int istenenUrunBirimiYedek;
            


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
              
                listUrunBirimiYedek = Convert.ToInt32(products[a].UrunBirimi);
                

                if (istenenUrunBirimi <= secilenUrunBirimi)
                {
                    toplamFiyat = toplamFiyat+(istenenUrunBirimi*kucukFiyat);
                    istenenUrunBirimiYedek = istenenUrunBirimi;
                    istenenUrunBirimi = istenenUrunBirimi - secilenUrunBirimi;
                    products[a].UrunBirimi= Convert.ToString(Convert.ToInt32(products[a].UrunBirimi) - istenenUrunBirimiYedek);
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
            products[a].UrunBirimi = Convert.ToString(listUrunBirimiYedek);
           
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm(users, UserIndex);
            userForm.Show();
            this.Hide();
        }
    }
}
