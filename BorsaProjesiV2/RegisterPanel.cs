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
    public partial class RegisterPanel : Form
    {
        public RegisterPanel()
        {
            InitializeComponent();
        }

        SqlConnect sqlConnect = new SqlConnect();
        private void btnKayit_Click(object sender, EventArgs e)
        {
       
            SqlCommand kayit = new SqlCommand("insert into KullaniciBilgileri (Ad,Soyad,KullaniciAdi,Sifre,KullaniciTcNo,KullaniciMail,Adres,Telefon) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", sqlConnect.Connection());
            kayit.Parameters.AddWithValue("@p1", txtAd.Text);
            kayit.Parameters.AddWithValue("@p2", txtSoyad.Text);
            kayit.Parameters.AddWithValue("@p3", txtKullaniciAdi.Text);
            kayit.Parameters.AddWithValue("@p4", txtSifre.Text);
            kayit.Parameters.AddWithValue("@p5", txtTC.Text);
            kayit.Parameters.AddWithValue("@p6", txtMail.Text);
            kayit.Parameters.AddWithValue("@p7", txtAdres.Text);
            kayit.Parameters.AddWithValue("@p8", txtTelefon.Text);
            kayit.ExecuteNonQuery();
            sqlConnect.Connection().Close();
            MessageBox.Show("Kayit isleminiz basariyla gerceklestirilmistir");
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

        }
    }
}
