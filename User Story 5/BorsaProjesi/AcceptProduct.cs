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

namespace BorsaProjesi
{
    public partial class AcceptProduct : Form
    {
        List<User> users;
        int UserIndex;
        List<DemandedProduct> demandedProducts;
        DemandedProductManager demandedProductManager = new DemandedProductManager();
        List<Product> products;
        ProductManager productManager = new ProductManager();
        public AcceptProduct(List<User> users2, int index)
        {
            InitializeComponent();
            users = users2;
            UserIndex = index;
        }

        SqlConnect sqlConnect = new SqlConnect();
        private void AcceptProduct_Load(object sender, EventArgs e)
        {
            DataTable productTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select *from Urunler where UrunOnay=0", sqlConnect.Connection());
            dataAdapter.Fill(productTable);
            dataGridView1.DataSource = productTable;
        }


        private void btnOnayla_Click(object sender, EventArgs e)
        {
            demandedProducts = demandedProductManager.GetList();

            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            int urunId = Convert.ToInt32(dataGridView1.Rows[secilen].Cells[4].Value.ToString());
            SqlCommand komutUrunOnayla = new SqlCommand("Update Urunler SET UrunOnay=@p1,EskiUrunBirimi=@p2,EskiUrunFiyati=@p3 where UrunId=@p4", sqlConnect.Connection());
            komutUrunOnayla.Parameters.AddWithValue("@p1", true);
            komutUrunOnayla.Parameters.AddWithValue("@p2", 0);
            komutUrunOnayla.Parameters.AddWithValue("@p3", 0);
            komutUrunOnayla.Parameters.AddWithValue("@p4", urunId);
            komutUrunOnayla.ExecuteNonQuery();
            sqlConnect.Connection().Close();
            MessageBox.Show("Ürün onaylama işlemi başarıyla gerçekleştirildi!");

            products = productManager.GetList();
            int secilenUrunBirimi = Convert.ToInt32(dataGridView1.Rows[secilen].Cells[2].Value.ToString());
            int secilenUrunFiyati = Convert.ToInt32(dataGridView1.Rows[secilen].Cells[3].Value.ToString());
            int toplamFiyat;
            int urunSahibiIndex = Convert.ToInt32(dataGridView1.Rows[secilen].Cells[0].Value.ToString());
            string UrunAdi = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            int a = Convert.ToInt32(dataGridView1.Rows[secilen].Cells[4].Value.ToString())-1;
   

            foreach (var demanded in demandedProducts)
            {

                MessageBox.Show(demanded.TalepEdenId+" "+demanded.UrunAdi);
                if (Convert.ToInt32(demanded.UrunFiyati) >=secilenUrunFiyati && demanded.UrunAdi == UrunAdi && Convert.ToInt32(demanded.UrunBirimi) <= secilenUrunBirimi)
                {

                    toplamFiyat = Convert.ToInt32(demanded.UrunBirimi)*secilenUrunFiyati;
                  
                    if (Convert.ToInt32(users[Convert.ToInt32(demanded.TalepEdenId) - 1].GuncelBakiye) >= toplamFiyat)
                    {
                      
                        users[Convert.ToInt32(demanded.TalepEdenId) - 1].GuncelBakiye = Convert.ToString(Convert.ToInt32(users[Convert.ToInt32(demanded.TalepEdenId) - 1].GuncelBakiye) - Convert.ToInt32(toplamFiyat));
                        SqlCommand buyerWallet = new SqlCommand("update KullaniciBilgileri SET GuncelBakiye=@p1 where ıd=@p2", sqlConnect.Connection());
                        buyerWallet.Parameters.AddWithValue("@p1", users[Convert.ToInt32(demanded.TalepEdenId) - 1].GuncelBakiye);
                        buyerWallet.Parameters.AddWithValue("@p2", demanded.TalepEdenId);
                        buyerWallet.ExecuteNonQuery();
                        sqlConnect.Connection().Close();

                      
                        users[urunSahibiIndex-1].GuncelBakiye = Convert.ToString(Convert.ToInt32(users[urunSahibiIndex-1].GuncelBakiye) + Convert.ToInt32(toplamFiyat));

                        SqlCommand sellerWallet = new SqlCommand("update KullaniciBilgileri SET GuncelBakiye=@p1 where ıd=@p2", sqlConnect.Connection());
                    
                        sellerWallet.Parameters.AddWithValue("@p1", users[urunSahibiIndex-1].GuncelBakiye);
                        sellerWallet.Parameters.AddWithValue("@p2", urunSahibiIndex);
                        sellerWallet.ExecuteNonQuery();
                        sqlConnect.Connection().Close();
                        int demandedUrunBirimiYedek;

                        if (Convert.ToInt32(demanded.UrunBirimi) <= secilenUrunBirimi)
                        {

                            demandedUrunBirimiYedek = Convert.ToInt32(demanded.UrunBirimi);
                            demanded.UrunBirimi = Convert.ToString(Convert.ToInt32(demanded.UrunBirimi) - Convert.ToInt32(secilenUrunBirimi));
                            
                            products[a].UrunBirimi = Convert.ToString(Convert.ToInt32(products[a].UrunBirimi) - demandedUrunBirimiYedek);
                            SqlCommand buyProductUnit = new SqlCommand("update Urunler SET UrunBirimi=@p1 where UrunId=@p2", sqlConnect.Connection());

                            buyProductUnit.Parameters.AddWithValue("@p1", products[a].UrunBirimi);
                            
                            buyProductUnit.Parameters.AddWithValue("@p2", products[a].UrunId);
                            buyProductUnit.ExecuteNonQuery();
                            sqlConnect.Connection().Close();

                           
                            if (Convert.ToInt32(demanded.UrunBirimi) <0)
                            {
                                demanded.UrunBirimi ="0";
                            }

              
                            SqlCommand urunGuncelle = new SqlCommand("update TalepEdilenUrunler SET UrunBirimi=@p1 where TalepEdilenUrunId=@p2",sqlConnect.Connection());
                            urunGuncelle.Parameters.AddWithValue("@p1",demanded.UrunBirimi);
                            urunGuncelle.Parameters.AddWithValue("@p2", demanded.TalepEdilenUrunId);
                            urunGuncelle.ExecuteNonQuery();
                            sqlConnect.Connection().Close();
                            break;

                        }
                    }
                    else
                    {
                    
                        break;

                    }


                }



            }


          

        }



        private void btnGeri_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm(users, UserIndex);
            adminForm.Show();
            this.Hide();

        }

    }
}

    

