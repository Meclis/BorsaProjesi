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
        int index;
        SqlConnect sql = new SqlConnect();
        public AcceptWallet(List<User> users2,int index2)
        {
            InitializeComponent();
            users = users2;
            index = index2;
        }

        int secilen;
        private void btnOnayla_Click(object sender, EventArgs e)
        {
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            SqlCommand bakiyeOnayla = new SqlCommand("Update KullaniciBilgileri SET GuncelBakiye=@p1,YeniBakiye=@p2 where ıd=@p3",sql.Connection());
            bakiyeOnayla.Parameters.AddWithValue("@p1",users[index].YeniBakiye);
            bakiyeOnayla.Parameters.AddWithValue("@p2", 0);
            bakiyeOnayla.Parameters.AddWithValue("@p3", index + 1);
            bakiyeOnayla.ExecuteNonQuery();
            MessageBox.Show("Bakiye onaylama işlemi başarılı!");
            sql.Connection().Close();

            users[index].GuncelBakiye = users[index].YeniBakiye;
            users[index].YeniBakiye = "0";

            AcceptWallet acceptWallet = new AcceptWallet(users,index);
            acceptWallet.Show();
            this.Hide();



        }

        
        private void AcceptWallet_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select *from KullaniciBilgileri where YeniBakiye!=0", sql.Connection());
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }
    }
}
