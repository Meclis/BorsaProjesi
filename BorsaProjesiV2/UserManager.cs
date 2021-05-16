using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
   
    public class UserManager:IUserService
    {
        List<User> users=new List<User>();

        SqlConnection con;
        SqlCommand cmd;

        public UserManager()
        {
            con = new SqlConnection("Data Source=LAPTOP-Q3V1DGN9\\SQLEXPRESS;Initial Catalog=YazilimYapimi;Integrated Security=True");
        }
        

        //public List<User> GetUserList()
        //{
        //    string sql = "Select *from KullaniciBilgileri";
        //    con.Open();
        //    cmd = new SqlCommand(sql, con);
        //    SqlDataReader dr = cmd.ExecuteReader();

        //    while (dr.Read())
        //    {

        //        User user = new User();
        //        user.userId = Convert.ToString(dr[0]);
        //        user.Ad = Convert.ToString(dr[1]);
        //        user.Soyad = Convert.ToString(dr[2]);
        //        user.KullaniciAdi = Convert.ToString(dr[3]);
        //        user.Sifre= Convert.ToString(dr[4]);
        //        user.TcNo = Convert.ToString(dr[5]);
        //        user.MailAdresi = Convert.ToString(dr[6]);
        //        user.Adres = Convert.ToString(dr[7]);
        //        user.TelefonNo = Convert.ToString(dr[8]);
                
        //        users.Add(user);
        //    }
        //    con.Close();
        //    return users;
        //}

        public string kullaniciKontrol(int index)
        {
           return users[index].KullaniciAdi;
          
        }
        
        public string sifreKontrol(int index)
        {
            return users[index].Sifre;
        }

        public string IdKontrol(int index)
        {
            return users[index].userId;
        }

        public List<User> GetList()
        {
            string sql = "Select *from KullaniciBilgileri";
            con.Open();
            cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                User user = new User();
                user.userId = Convert.ToString(dr[0]);
                user.Ad = Convert.ToString(dr[1]);
                user.Soyad = Convert.ToString(dr[2]);
                user.KullaniciAdi = Convert.ToString(dr[3]);
                user.Sifre = Convert.ToString(dr[4]);
                user.TcNo = Convert.ToString(dr[5]);
                user.MailAdresi = Convert.ToString(dr[6]);
                user.Adres = Convert.ToString(dr[7]);
                user.TelefonNo = Convert.ToString(dr[8]);

                users.Add(user);
            }
            con.Close();
            return users;
        }
    }
}
