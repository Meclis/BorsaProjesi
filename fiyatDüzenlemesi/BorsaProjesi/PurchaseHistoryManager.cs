using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BorsaProjesi
{
    class PurchaseHistoryManager : IPurchaseProductService
    {
        List<PurchaseHistory> purchaseHistories = new List<PurchaseHistory>();
        SqlConnection con;
        SqlCommand cmd;

        public PurchaseHistoryManager()
        {
            con = new SqlConnection("Data Source=LAPTOP-Q3V1DGN9\\SQLEXPRESS;Initial Catalog=YazilimYapimi;Integrated Security=True");
        }

        public List<PurchaseHistory> GetList()
        {
            string sql = "Select *from SatinAlmaGecmisi";
            con.Open();
            cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                PurchaseHistory purchaseHistory = new PurchaseHistory();
                purchaseHistory.Tarih = Convert.ToDateTime(dr[0]);
                purchaseHistory.UrunAdi = Convert.ToString(dr[1]);
                purchaseHistory.UrunAliciId= Convert.ToString(dr[2]);
                purchaseHistory.UrunFiyati= Convert.ToString(dr[3]);
                purchaseHistory.UrunBirimi= Convert.ToString(dr[4]);
                purchaseHistory.UrunId= Convert.ToString(dr[5]);
                purchaseHistory.UrunSatanId= Convert.ToString(dr[6]);
                purchaseHistories.Add(purchaseHistory);
            }
            con.Close();
            return purchaseHistories;
        }
    }

       
}


