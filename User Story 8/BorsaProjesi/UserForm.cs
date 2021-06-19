using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BorsaProjesi
{
    public partial class UserForm : Form
    {
        List<User> users;
        int UserIndex;
        public UserForm(List<User> users2,int index)
        {
            InitializeComponent();
            users = users2;
            UserIndex = index;
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {

            AddProduct addProduct = new AddProduct(users, UserIndex);
            addProduct.Show();
            this.Hide();
            
        }

        private void btnBakiye_Click(object sender, EventArgs e)
        {
            Wallet wallet = new Wallet(users, UserIndex);
            wallet.Show();
            this.Hide();
            
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            BuyProduct buyProduct = new BuyProduct(users, UserIndex);
            buyProduct.Show();
            this.Hide();

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            LoginPanel loginPanel = new LoginPanel();
            loginPanel.Show();
            this.Hide();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            if(users[UserIndex].AliciYetki==true && users[UserIndex].SaticiYetki==false)
            {
                btnUrunEkle.Visible = false;
            }

            else if(users[UserIndex].AliciYetki == false && users[UserIndex].SaticiYetki == true)
            {
                btnBuy.Visible = false;
            }


        }

        private void btnRaporOlustur_Click(object sender, EventArgs e)
        {
            CreateReport createReport = new CreateReport(users,UserIndex);
            createReport.Show();
            this.Hide();
        }
    }
}
