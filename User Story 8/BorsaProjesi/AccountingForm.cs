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
    public partial class AccountingForm : Form
    {
        List<Accounting> accountings;
        int accountinIndex;

        public AccountingForm(List<Accounting> accountings2,int index)
        {
            InitializeComponent();
            accountings = accountings2;
            accountinIndex = index;
        }

        private void AccountingForm_Load(object sender, EventArgs e)
        {
            lblBakiye.Text = Convert.ToString(accountings[accountinIndex].MuhasebeBakiye);
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            LoginPanel loginPanel = new LoginPanel();
            loginPanel.Show();
            this.Hide();
        }
    }
}
