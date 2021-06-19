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
using System.Xml;

namespace BorsaProjesi
{
    public partial class Wallet : Form
    {
        List<User> users;
        int UserIndex;
        SqlConnect sqlConnect = new SqlConnect();
        public Wallet(List<User> users2,int index)
        {
            InitializeComponent();
            users = users2;
            UserIndex = index;
           

        }
      
        private void Wallet_Load(object sender, EventArgs e)
        {
            
            lblBakiye.Text = Convert.ToString(users[UserIndex].GuncelBakiye);
            dataGridView1.DataSource = source();
            

        }

    

        public DataTable source()
        {
            DataTable dovizTablosu = new DataTable();
            DataRow dataRow;
            dovizTablosu.Columns.Add(new DataColumn("Adı", typeof(string)));
            dovizTablosu.Columns.Add(new DataColumn("Kod", typeof(string)));
            dovizTablosu.Columns.Add(new DataColumn("Döviz Alış", typeof(string)));
            dovizTablosu.Columns.Add(new DataColumn("Döviz Satış", typeof(string)));
           
            XmlTextReader rdr = new XmlTextReader("https://www.tcmb.gov.tr/kurlar/today.xml");
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(rdr);

            XmlNode tarih = xmlDocument.SelectSingleNode("/Tarih_Date/@Tarih");
            XmlNodeList myList = xmlDocument.SelectNodes("/Tarih_Date/Currency");
            XmlNodeList adi = xmlDocument.SelectNodes("/Tarih_Date/Currency/Isim");
            XmlNodeList kod= xmlDocument.SelectNodes("/Tarih_Date/Currency/@Kod");
            XmlNodeList doviz_alis= xmlDocument.SelectNodes("/Tarih_Date/Currency/ForexBuying");
            XmlNodeList doviz_satis= xmlDocument.SelectNodes("/Tarih_Date/Currency/ForexSelling");



            //dataGridView1.CaptionText = tarih.InnerText.ToString() + " tarihli merkez bankası kur bilgileri";
            for (int i = 0; i <12; i++)
            {
                dataRow = dovizTablosu.NewRow();
                dataRow[0] = adi.Item(i).InnerText.ToString();
                dataRow[1] = kod.Item(i).InnerText.ToString();
                dataRow[2] = doviz_alis.Item(i).InnerText.ToString();
                dataRow[3] = doviz_satis.Item(i).InnerText.ToString();
                dovizTablosu.Rows.Add(dataRow);
            }

            return dovizTablosu;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            
            users[UserIndex].YeniBakiye =(users[UserIndex].GuncelBakiye)+Convert.ToDecimal(txtPara.Text);
            SqlCommand bakiyeGuncelle = new SqlCommand("Update KullaniciBilgileri set YeniBakiye=@p1,ParaBirimi=@p2 where ıd=@p3", sqlConnect.Connection());
            bakiyeGuncelle.Parameters.AddWithValue("@p1", Convert.ToString(users[UserIndex].YeniBakiye));
            bakiyeGuncelle.Parameters.AddWithValue("@p2",cmbDovizTipi.SelectedItem);
            bakiyeGuncelle.Parameters.AddWithValue("@p3",Convert.ToString(UserIndex + 1));
            bakiyeGuncelle.ExecuteNonQuery();
            sqlConnect.Connection().Close();

            Wallet wallet = new Wallet(users, UserIndex);
            wallet.Show();
            this.Hide();

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm(users, UserIndex);
            userForm.Show();
            this.Hide();
        }

    }
}
