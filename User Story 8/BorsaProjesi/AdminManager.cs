﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BorsaProjesi
{
    
    class AdminManager:IAdminService
    {
        List<Admin> admins= new List<Admin>();
        SqlConnection con;
        SqlCommand cmd;
        
        public AdminManager()
        {
            con = new SqlConnection("Data Source=LAPTOP-Q3V1DGN9\\SQLEXPRESS;Initial Catalog=YazilimYapimi;Integrated Security=True");
        }

        public List<Admin> GetList()
        {
            string sql = "Select *from Admin";
            con.Open();
            cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Admin admin = new Admin();
                admin.AdminTcNo = Convert.ToString(dr[0]);
                admin.AdminSifre = Convert.ToString(dr[1]);
                admins.Add(admin);
            }

            con.Close();
            return admins;
        }

    }
}
