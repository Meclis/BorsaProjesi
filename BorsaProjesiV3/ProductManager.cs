using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
    public class ProductManager:IProductService
    {
        List<Product> products=new List<Product>();
        
        SqlConnection con;
        SqlCommand cmd;

        public ProductManager()
        {
            con = new SqlConnection("Data Source=LAPTOP-Q3V1DGN9\\SQLEXPRESS;Initial Catalog=YazilimYapimi;Integrated Security=True");
        }
        

        public List<Product> GetList()
        {
            string sql = "Select *from Urunler";
            con.Open();
            cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                Product product = new Product();
                product.UrunSahibiId = Convert.ToString(dr[0]);
                product.UrunAdi= Convert.ToString(dr[1]);
                product.UrunBirimi= Convert.ToString(dr[2]);
                product.UrunFiyati= Convert.ToString(dr[3]);
                product.UrunId= Convert.ToString(dr[4]);
                products.Add(product);

            }
            con.Close();
            return products;
        }
    }
}
