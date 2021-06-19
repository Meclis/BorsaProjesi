using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BorsaProjesi
{
    public class AccountingManager : IAccountingService
    {

        List<Accounting> accountings = new List<Accounting>();
        SqlConnection con;
        SqlCommand cmd;

        public AccountingManager()
        {
            con = new SqlConnection("Data Source=LAPTOP-Q3V1DGN9\\SQLEXPRESS;Initial Catalog=YazilimYapimi;Integrated Security=True");
        }


        public List<Accounting> GetList()
        {
            string sql = "select *from Muhasebe";
            con.Open();
            cmd = new SqlCommand(sql,con);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                Accounting accounting = new Accounting();
                accounting.MuhasebeId = Convert.ToInt32(dr[0]);
                accounting.MuhasebeAdi = Convert.ToString(dr[1]);
                accounting.KullaniciAdi = Convert.ToString(dr[2]);
                accounting.Sifre = Convert.ToString(dr[3]);
                accounting.MuhasebeBakiye = Convert.ToDecimal(dr[4]);
                accountings.Add(accounting);
            }
            con.Close();
            return accountings;
        }
    }
}
