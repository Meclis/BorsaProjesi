using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BorsaProjesi
{
    public class DemandedProductManager:IDemandedProductService
    {
        List<DemandedProduct> demandedProducts = new List<DemandedProduct>();
        SqlConnection con;
        SqlCommand cmd;

        public DemandedProductManager()
        {
            con = new SqlConnection("Data Source=LAPTOP-Q3V1DGN9\\SQLEXPRESS;Initial Catalog=YazilimYapimi;Integrated Security=True");
        }
        public List<DemandedProduct> GetList()
        {
            string sql = "Select *from TalepEdilenUrunler";
            con.Open();
            cmd = new SqlCommand(sql,con);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                DemandedProduct demandedProduct = new DemandedProduct();
                demandedProduct.TalepEdenId = Convert.ToString(dr[0]);
                demandedProduct.UrunAdi = Convert.ToString(dr[1]);
                demandedProduct.UrunFiyati = Convert.ToString(dr[2]);
                demandedProduct.UrunBirimi = Convert.ToString(dr[3]);
                demandedProduct.TalepEdilenUrunId = Convert.ToString(dr[4]);
                demandedProducts.Add(demandedProduct);

            }
            con.Close();
            return demandedProducts;
        }
    }
}
