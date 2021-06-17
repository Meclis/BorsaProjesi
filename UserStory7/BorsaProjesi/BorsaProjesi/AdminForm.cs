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
    public partial class AdminForm : Form
    {
        List<User> users;
        int UserIndex;
        public AdminForm(List<User> users2,int index)
        {
            InitializeComponent();
            users = users2;
            UserIndex = index;
        }

        private void btnOnaylanmamisUrun_Click(object sender, EventArgs e)
        {
            AcceptProduct acceptProduct = new AcceptProduct(users, UserIndex);
            acceptProduct.Show();
            this.Hide();
        }

        private void btnOnaylanmamisBakiye_Click(object sender, EventArgs e)
        {
            AcceptWallet acceptWallet = new AcceptWallet(users, UserIndex);
            acceptWallet.Show();
            this.Hide();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            LoginPanel loginPanel = new LoginPanel();
            loginPanel.Show();
            this.Hide();
        }
    }
}
