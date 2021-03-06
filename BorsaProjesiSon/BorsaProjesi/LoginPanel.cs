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

    public partial class LoginPanel : Form
    {

        public LoginPanel()
        {
            InitializeComponent();
           

        }

        private void lnkUyeOl(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterPanel registerPanel = new RegisterPanel();
            registerPanel.Show();
            this.Hide();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            UserManager userManager = new UserManager();
            List<User> users = new List<User>();
            users = userManager.GetList();


            AdminManager adminManager = new AdminManager();
            List<Admin> admins = new List<Admin>();
            admins = adminManager.GetList();

            AccountingManager accountingManager = new AccountingManager();
            List<Accounting> accountings = new List<Accounting>();
            accountings = accountingManager.GetList();

            int i = 0;

            foreach (var admin in admins)
            {
                if(txtKullaniciAdi.Text==admin.AdminTcNo && txtSifre.Text==admin.AdminSifre)
                {
                    AdminForm adminForm = new AdminForm(users,i);
                    adminForm.Show();
                    this.Hide();
                }
                i++;
            }

            i = 0;
            foreach (var user in users)
            {
                if (txtKullaniciAdi.Text == user.KullaniciAdi && txtSifre.Text==user.Sifre)
                {
                    UserForm userForm = new UserForm(users,i);
                    userForm.Show();
                    this.Hide();
                }
                i++;
                   
            }

            i = 0;
            foreach (var account in accountings)
            {
                if (txtKullaniciAdi.Text == account.KullaniciAdi && txtSifre.Text == account.Sifre)
                {
                    AccountingForm accountingForm = new AccountingForm(accountings,i);
                    accountingForm.Show();
                    this.Hide();
                }
                i++;

            }

        }

   
    }
}
