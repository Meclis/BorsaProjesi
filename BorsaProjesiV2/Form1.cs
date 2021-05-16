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
    public partial class Form1 : Form
    {

        public Form1()
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

            int i = 0;

            foreach (var admin in admins)
            {
                if(txtKullaniciAdi.Text==adminManager.adminTcKontrol(i) && txtSifre.Text==adminManager.adminSifreKontrol(i))
                {
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                    this.Hide();
                }
                i++;
            }

            i = 0;
            foreach (var user in users)
            {
                if (txtKullaniciAdi.Text == userManager.kullaniciKontrol(i) && txtSifre.Text==userManager.sifreKontrol(i))
                {
                    UserForm userForm = new UserForm(users,i);
                    userForm.Show();
                    this.Hide();
                }
                i++;
                   
            }

        }


   
        private void Form1_Load(object sender, EventArgs e)
        {

           




        }
    }
}
