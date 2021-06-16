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
    public partial class RegisterPanel : Form
    {
        public RegisterPanel()
        {
            InitializeComponent();
        }

        SqlConnect sqlConnect = new SqlConnect();
        private void btnKayit_Click(object sender, EventArgs e)
        {

            if (chckAlici.Checked == false && chckSatici.Checked == false)
            {
                MessageBox.Show("Yetki türü boş olmamalıdır!");
                RegisterPanel registerPanel = new RegisterPanel();
                registerPanel.Show();
                this.Hide();
            }

            SqlCommand kayit = new SqlCommand("insert into KullaniciBilgileri (Ad,Soyad,KullaniciAdi,Sifre,KullaniciTcNo,KullaniciMail,Adres,Telefon,GuncelBakiye,YeniBakiye,AliciYetki,SaticiYetki) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12)", sqlConnect.Connection());
            kayit.Parameters.AddWithValue("@p1", txtAd.Text);
            kayit.Parameters.AddWithValue("@p2", txtSoyad.Text);
            kayit.Parameters.AddWithValue("@p3", txtKullaniciAdi.Text);
            kayit.Parameters.AddWithValue("@p4", txtSifre.Text);
            kayit.Parameters.AddWithValue("@p5", txtTC.Text);
            kayit.Parameters.AddWithValue("@p6", txtMail.Text);
            kayit.Parameters.AddWithValue("@p7", txtAdres.Text);
            kayit.Parameters.AddWithValue("@p8", txtTelefon.Text);
            kayit.Parameters.AddWithValue("@p9",0);
            kayit.Parameters.AddWithValue("@p10", 0);
            kayit.Parameters.AddWithValue("@p11",chckAlici.Checked);
            kayit.Parameters.AddWithValue("@p12",chckSatici.Checked);

            kayit.ExecuteNonQuery();
            sqlConnect.Connection().Close();
            MessageBox.Show("Kayit isleminiz basariyla gerceklestirilmistir");
            LoginPanel form1 = new LoginPanel();
            form1.Show();
            this.Hide();

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            LoginPanel loginPanel = new LoginPanel();
            loginPanel.Show();
            this.Hide();
        }

       
    }
}
