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

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            
            users[UserIndex].YeniBakiye =Convert.ToString(Convert.ToInt32(users[UserIndex].GuncelBakiye)+Convert.ToInt32(txtPara.Text));
            SqlCommand bakiyeGuncelle = new SqlCommand("Update KullaniciBilgileri set YeniBakiye=@p1 where ıd=@p2", sqlConnect.Connection());
            bakiyeGuncelle.Parameters.AddWithValue("@p1", users[UserIndex].YeniBakiye);
            bakiyeGuncelle.Parameters.AddWithValue("@p2",Convert.ToString(UserIndex + 1));
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
