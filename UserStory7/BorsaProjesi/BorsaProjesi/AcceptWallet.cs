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
    public partial class AcceptWallet : Form
    {
        List<User> users;
        int userIndex;
        SqlConnect sqlConnect = new SqlConnect();
        public AcceptWallet(List<User> users2,int index)
        {
            InitializeComponent();
            users = users2;
            userIndex = index;
        }

        decimal eklenecekBakiye;
        private void btnOnayla_Click(object sender, EventArgs e)
        {

            

            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            int UserIndex = Convert.ToInt32(dataGridView1.Rows[secilen].Cells[0].Value.ToString())-1;
           

            XmlDocument xmlVerisi = new XmlDocument();
            xmlVerisi.Load("http://www.tcmb.gov.tr/kurlar/today.xml");

            decimal dolar = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexBuying", "USD")).InnerText.Replace('.', ','));
            decimal euro = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexBuying", "EUR")).InnerText.Replace('.', ','));
            decimal sterlin = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexBuying", "GBP")).InnerText.Replace('.', ','));


            if (dataGridView1.Rows[secilen].Cells[13].Value.ToString() == "ABD DOLARI")
            {
                
                eklenecekBakiye =(Convert.ToDecimal(dataGridView1.Rows[secilen].Cells[10].Value.ToString())-Convert.ToDecimal(dataGridView1.Rows[secilen].Cells[9].Value.ToString()))* dolar;
                eklenecekBakiye = Math.Truncate(100 * eklenecekBakiye) / 100;
                MessageBox.Show("Test: " + eklenecekBakiye);
                users[UserIndex].YeniBakiye = (users[UserIndex].GuncelBakiye) + eklenecekBakiye;
                MessageBox.Show("Test 2: " + users[UserIndex].YeniBakiye);
            }

            else if (dataGridView1.Rows[secilen].Cells[13].Value.ToString() == "EURO")
            {
                
                eklenecekBakiye = (Convert.ToDecimal(dataGridView1.Rows[secilen].Cells[10].Value.ToString()) - Convert.ToDecimal(dataGridView1.Rows[secilen].Cells[9].Value.ToString())) * euro;
                eklenecekBakiye = Math.Truncate(100 * eklenecekBakiye) / 100;
                MessageBox.Show("Test: " + eklenecekBakiye);
                users[UserIndex].YeniBakiye = (users[UserIndex].GuncelBakiye) + eklenecekBakiye;
                MessageBox.Show("Test 2: " + users[UserIndex].YeniBakiye);
            }


            else if (dataGridView1.Rows[secilen].Cells[13].Value.ToString() == "İNGİLİZ STERLİNİ")
            {
               
                eklenecekBakiye = (Convert.ToDecimal(dataGridView1.Rows[secilen].Cells[10].Value.ToString()) - Convert.ToDecimal(dataGridView1.Rows[secilen].Cells[9].Value.ToString())) * sterlin;
                eklenecekBakiye = Math.Truncate(100 * eklenecekBakiye) / 100;
                MessageBox.Show("Test: " + eklenecekBakiye);
                users[UserIndex].YeniBakiye = (users[UserIndex].GuncelBakiye) + sterlin;
                MessageBox.Show("Test 2: " + users[UserIndex].YeniBakiye);
            }

            SqlCommand bakiyeOnayla = new SqlCommand("Update KullaniciBilgileri SET GuncelBakiye=@p1,YeniBakiye=@p2 where ıd=@p3", sqlConnect.Connection());
            bakiyeOnayla.Parameters.AddWithValue("@p1",Convert.ToString(Convert.ToDecimal(dataGridView1.Rows[secilen].Cells[10].Value.ToString()) + eklenecekBakiye));
            bakiyeOnayla.Parameters.AddWithValue("@p2", 0);
            bakiyeOnayla.Parameters.AddWithValue("@p3", dataGridView1.Rows[secilen].Cells[0].Value.ToString());
            bakiyeOnayla.ExecuteNonQuery();
            MessageBox.Show("Bakiye onaylama işlemi başarılı!");
            sqlConnect.Connection().Close();

            users[userIndex].GuncelBakiye = users[userIndex].YeniBakiye;
            users[userIndex].YeniBakiye = 0;

            AcceptWallet acceptWallet = new AcceptWallet(users, userIndex);
            acceptWallet.Show();
            this.Hide();



        }

        
        private void AcceptWallet_Load(object sender, EventArgs e)
        {
            DataTable walletTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select *from KullaniciBilgileri where YeniBakiye!='0' ", sqlConnect.Connection());
            dataAdapter.Fill(walletTable);
            dataGridView1.DataSource = walletTable;

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm(users, userIndex);
            adminForm.Show();
            this.Hide();
        }
    }
}
