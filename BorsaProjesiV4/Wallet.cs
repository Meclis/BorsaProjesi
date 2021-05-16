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
    public partial class Wallet : Form
    {
        List<User> users;
        int index;
        SqlConnect sql = new SqlConnect();
        public Wallet(List<User> users2,int index2)
        {
            InitializeComponent();
            users = users2;
            index = index2;
           

        }

        private void Wallet_Load(object sender, EventArgs e)
        {
            
            lblBakiye.Text = Convert.ToString(users[index].GuncelBakiye);

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            
            users[index].YeniBakiye =Convert.ToString(Convert.ToInt32(users[index].GuncelBakiye)+Convert.ToInt32(txtPara.Text));
            SqlCommand bakiyeGuncelle = new SqlCommand("Update KullaniciBilgileri set YeniBakiye=@p1 where ıd=@p2",sql.Connection());
            bakiyeGuncelle.Parameters.AddWithValue("@p1", users[index].YeniBakiye);
            bakiyeGuncelle.Parameters.AddWithValue("@p2",Convert.ToString(index+1));
            bakiyeGuncelle.ExecuteNonQuery();
            sql.Connection().Close();

            Wallet wallet = new Wallet(users,index);
            wallet.Show();
            this.Hide();

        }
    }
}
