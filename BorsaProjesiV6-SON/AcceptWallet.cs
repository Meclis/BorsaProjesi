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

        
        private void btnOnayla_Click(object sender, EventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            SqlCommand bakiyeOnayla = new SqlCommand("Update KullaniciBilgileri SET GuncelBakiye=@p1,YeniBakiye=@p2 where ıd=@p3", sqlConnect.Connection());
            bakiyeOnayla.Parameters.AddWithValue("@p1",users[userIndex].YeniBakiye);
            bakiyeOnayla.Parameters.AddWithValue("@p2", 0);
            bakiyeOnayla.Parameters.AddWithValue("@p3", userIndex + 1);
            bakiyeOnayla.ExecuteNonQuery();
            MessageBox.Show("Bakiye onaylama işlemi başarılı!");
            sqlConnect.Connection().Close();

            users[userIndex].GuncelBakiye = users[userIndex].YeniBakiye;
            users[userIndex].YeniBakiye = "0";

            AcceptWallet acceptWallet = new AcceptWallet(users, userIndex);
            acceptWallet.Show();
            this.Hide();



        }

        
        private void AcceptWallet_Load(object sender, EventArgs e)
        {
            DataTable walletTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select *from KullaniciBilgileri where YeniBakiye!=0", sqlConnect.Connection());
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
