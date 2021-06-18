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
    public partial class BuyProduct : Form
    {
        List<User> users;
        int UserIndex;

        List<Product> products;
        ProductManager productManager = new ProductManager();

        List<Accounting> accountings;
        AccountingManager accountingManager = new AccountingManager();

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
            btnTalepOlustur.Visible = false;

            int sayac=0;

         
            List<string> eklenenUrn = new List<string>();

            for (int b = 0; b < products.Count; b++)
            {
                for (int c = b+1; c < products.Count; c++)
                {
                    if (products[b].UrunAdi==products[c].UrunAdi)
                    {
                        sayac++;

                    }
                  
                }

                if (sayac < 1)
                {
                    cmbUrunTipi.Items.Add(products[b].UrunAdi);
                }
                sayac = 0;
            }
          

        }


        int istenenUrunBirimiYedek;
        private void btnSatinAl_Click(object sender, EventArgs e)
        {
            accountings = accountingManager.GetList();
            int istenenUrunBirimi = Convert.ToInt32(txtUrunMiktar.Text);
           
            decimal kucukFiyat = 5000;
            int secilenUrunBirimi = 0;
            int a = 0, b = 0;
            int urunSahibiIndex;

            while (istenenUrunBirimi > 0)
            {
                b = 0;
                foreach (var product in products)
                {
                    if (products[b].UrunAdi == Convert.ToString(cmbUrunTipi.SelectedItem) && (products[b].UrunFiyati) < kucukFiyat && Convert.ToInt32(products[b].UrunBirimi) > 0)
                    {

                        kucukFiyat = products[b].UrunFiyati;
                        secilenUrunBirimi = Convert.ToInt32(products[b].UrunBirimi);
                        a = b;
                    }
                    b++;

                }



                urunSahibiIndex = Convert.ToInt32(products[a].UrunSahibiId)-1;
             

                if (users[UserIndex].GuncelBakiye>=Convert.ToDecimal(lblFiyat.Text))
                {
                   accountings[0].MuhasebeBakiye = accountings[0].MuhasebeBakiye + (Convert.ToDecimal(lblFiyat.Text) / 100);
                    MessageBox.Show("Test: "+ accountings[0].MuhasebeBakiye);
                    SqlCommand accountingWallet = new SqlCommand("update Muhasebe SET MuhasebeBakiye=@p1 where MuhasebeId=@p2",sqlConnect.Connection());
                    accountingWallet.Parameters.AddWithValue("@p1",Convert.ToString(accountings[0].MuhasebeBakiye));
                    accountingWallet.Parameters.AddWithValue("@p2", 1);
                    accountingWallet.ExecuteNonQuery();
                    sqlConnect.Connection().Close();
                   
                    users[UserIndex].GuncelBakiye =(users[UserIndex].GuncelBakiye) - Convert.ToDecimal(lblFiyat.Text)- (Convert.ToDecimal(lblFiyat.Text) / 100);
                    SqlCommand buyerWallet = new SqlCommand("update KullaniciBilgileri SET GuncelBakiye=@p1 where ıd=@p2", sqlConnect.Connection());
                    buyerWallet.Parameters.AddWithValue("@p1", Convert.ToString(users[UserIndex].GuncelBakiye));
                    buyerWallet.Parameters.AddWithValue("@p2", UserIndex + 1);
                    buyerWallet.ExecuteNonQuery();
                    sqlConnect.Connection().Close();
                   
                    

                    users[urunSahibiIndex].GuncelBakiye =(users[urunSahibiIndex].GuncelBakiye) + Convert.ToDecimal(lblFiyat.Text);
                    SqlCommand sellerWallet = new SqlCommand("update KullaniciBilgileri SET GuncelBakiye=@p1 where ıd=@p2", sqlConnect.Connection());
                    sellerWallet.Parameters.AddWithValue("@p1", Convert.ToString(users[urunSahibiIndex].GuncelBakiye));
                    sellerWallet.Parameters.AddWithValue("@p2", urunSahibiIndex + 1);
                    sellerWallet.ExecuteNonQuery();
                    sqlConnect.Connection().Close();

                   
                   

                    if (istenenUrunBirimi <= secilenUrunBirimi)
                    {

                        istenenUrunBirimiYedek = istenenUrunBirimi;
                        istenenUrunBirimi = istenenUrunBirimi - secilenUrunBirimi;
                        products[a].UrunBirimi=Convert.ToString(Convert.ToInt32(products[a].UrunBirimi) - istenenUrunBirimiYedek);
                 

                        SqlCommand buyProductUnit = new SqlCommand("update Urunler SET UrunBirimi=@p1 where UrunId=@p2", sqlConnect.Connection());

                        buyProductUnit.Parameters.AddWithValue("@p1", products[a].UrunBirimi);
                        buyProductUnit.Parameters.AddWithValue("@p2", products[a].UrunId);
                        buyProductUnit.ExecuteNonQuery();
                        sqlConnect.Connection().Close();
                       

                        SqlCommand gecmiseEkle = new SqlCommand("insert into SatinAlmaGecmisi (Tarih,UrunAdi,UrunAliciId,UrunFiyati,UrunBirimi,UrunId,UrunSaticiId) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", sqlConnect.Connection());
                        gecmiseEkle.Parameters.AddWithValue("@p1", DateTime.Now.ToShortDateString());
                        gecmiseEkle.Parameters.AddWithValue("@p2", products[a].UrunAdi);
                        gecmiseEkle.Parameters.AddWithValue("@p3", UserIndex + 1);
                        gecmiseEkle.Parameters.AddWithValue("@p4", Convert.ToString(kucukFiyat));
                        gecmiseEkle.Parameters.AddWithValue("@p5", istenenUrunBirimiYedek);
                        gecmiseEkle.Parameters.AddWithValue("@p6", products[a].UrunId);
                        gecmiseEkle.Parameters.AddWithValue("@p7", urunSahibiIndex + 1);
                        gecmiseEkle.ExecuteNonQuery();
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

                        SqlCommand gecmiseEkle = new SqlCommand("insert into SatinAlmaGecmisi (Tarih,UrunAdi,UrunAliciId,UrunFiyati,UrunBirimi,UrunId,UrunSaticiId) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", sqlConnect.Connection());
                        gecmiseEkle.Parameters.AddWithValue("@p1", DateTime.Now.ToShortDateString());
                        gecmiseEkle.Parameters.AddWithValue("@p2", products[a].UrunAdi);
                        gecmiseEkle.Parameters.AddWithValue("@p3", UserIndex + 1);
                        gecmiseEkle.Parameters.AddWithValue("@p4", Convert.ToString(kucukFiyat));
                        gecmiseEkle.Parameters.AddWithValue("@p5", istenenUrunBirimiYedek);
                        gecmiseEkle.Parameters.AddWithValue("@p6", products[a].UrunId);
                        gecmiseEkle.Parameters.AddWithValue("@p7", urunSahibiIndex + 1);
                        gecmiseEkle.ExecuteNonQuery();
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
    
        private void btnFiyatHesapla_Click(object sender, EventArgs e)
        {
            int[] listUrunBirimiYedek = new int[products.Count];
            int[] listUrunBirimiIndex = new int[products.Count];
            btnSatinAl.Visible = true;
            int istenenUrunBirimi = Convert.ToInt32(txtUrunMiktar.Text);
            decimal kucukFiyat = 5000;
            decimal toplamFiyat = 0;
            int secilenUrunBirimi = 0;
            int a = 0, b = 0, c=0;
            int istenenUrunBirimiYedek;
            
            decimal istenenBirimFiyat = Convert.ToDecimal(txtBirimFiyati.Text);
          


            while (istenenUrunBirimi>0)
            {
                b = 0;
                foreach (var product in products)
                {
                    if (products[b].UrunAdi == Convert.ToString(cmbUrunTipi.SelectedItem) && (products[b].UrunFiyati) < kucukFiyat && Convert.ToInt32(products[b].UrunBirimi) > 0)
                    {

                        kucukFiyat =products[b].UrunFiyati;
                        secilenUrunBirimi = Convert.ToInt32(products[b].UrunBirimi);
                        a = b;
                    }
                    b++;

                }


                if (kucukFiyat>istenenBirimFiyat)
                {
                    btnTalepOlustur.Visible = true;
                    btnSatinAl.Visible = false;
                    toplamFiyat = istenenBirimFiyat * Convert.ToDecimal(istenenUrunBirimi);
                    break;

                }

                else if(kucukFiyat<=istenenBirimFiyat)
                {
                    if (istenenUrunBirimi <= secilenUrunBirimi)
                    {
                        toplamFiyat = toplamFiyat + (Convert.ToDecimal(istenenUrunBirimi) * kucukFiyat);
                        istenenUrunBirimiYedek = istenenUrunBirimi; 
                        istenenUrunBirimi = istenenUrunBirimi - secilenUrunBirimi;
                        listUrunBirimiYedek[c] = Convert.ToInt32(products[a].UrunBirimi);
                        listUrunBirimiIndex[c] = a;
                        products[a].UrunBirimi = Convert.ToString(Convert.ToInt32(products[a].UrunBirimi) - istenenUrunBirimiYedek);
                        c++;
               
                        break;
                    }
                    else if (istenenUrunBirimi > secilenUrunBirimi)
                    {
                        toplamFiyat = toplamFiyat + (Convert.ToDecimal(secilenUrunBirimi) * kucukFiyat);
                        istenenUrunBirimi = istenenUrunBirimi - secilenUrunBirimi;
                        listUrunBirimiYedek[c] = Convert.ToInt32(products[a].UrunBirimi);
                        listUrunBirimiIndex[c] = a;
                        products[a].UrunBirimi = "0";
                        c++;

                    }

                    kucukFiyat = 5000;
                    

                }




               

            }
            for (int i = 0; i < c; i++)
            {
                products[listUrunBirimiIndex[i]].UrunBirimi = Convert.ToString(listUrunBirimiYedek[i]);
            }

            lblFiyat.Text = Convert.ToString(toplamFiyat);
            lblMuhasebeKomisyon.Text = Convert.ToString(toplamFiyat / 100);
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm(users, UserIndex);
            userForm.Show();
            this.Hide();
        }

        private void btnTalepOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand talepEkle = new SqlCommand("insert into TalepEdilenUrunler (TalepEdenId,UrunAdi,UrunFiyati,UrunBirimi) values (@p1,@p2,@p3,@p4)", sqlConnect.Connection());
            talepEkle.Parameters.AddWithValue("@p1",UserIndex+1);
            talepEkle.Parameters.AddWithValue("@p2", cmbUrunTipi.SelectedItem);
            talepEkle.Parameters.AddWithValue("@p3", Convert.ToString(txtBirimFiyati.Text));
            talepEkle.Parameters.AddWithValue("@p4", txtUrunMiktar.Text);
            talepEkle.ExecuteNonQuery();
            sqlConnect.Connection().Close();
            MessageBox.Show("Talebiniz başarıyla alınmıştır!");
            BuyProduct buyProduct = new BuyProduct(users,UserIndex);
            buyProduct.Show();
            this.Hide();


            



        }
    }
}
