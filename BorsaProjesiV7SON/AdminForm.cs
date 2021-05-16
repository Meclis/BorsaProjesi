using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class AdminForm : Form
    {
        List<User> users;
        int index;
        public AdminForm(List<User> users2,int index2)
        {
            InitializeComponent();
            users = users2;
            index = index2;
        }

        private void btnOnaylanmamisUrun_Click(object sender, EventArgs e)
        {
            AcceptProduct acceptProduct = new AcceptProduct(users,index);
            acceptProduct.Show();
            this.Hide();
        }

        private void btnOnaylanmamisBakiye_Click(object sender, EventArgs e)
        {
            AcceptWallet acceptWallet = new AcceptWallet(users,index);
            acceptWallet.Show();
            this.Hide();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
