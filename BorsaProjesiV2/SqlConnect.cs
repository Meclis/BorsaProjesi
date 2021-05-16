using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
    class SqlConnect
    {
        public SqlConnection Connection()
        {
            SqlConnection sql = new SqlConnection("Data Source=LAPTOP-Q3V1DGN9\\SQLEXPRESS;Initial Catalog=YazilimYapimi;Integrated Security=True");
            sql.Open();
            return sql;
        }
    }
}
