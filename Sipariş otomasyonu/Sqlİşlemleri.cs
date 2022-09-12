using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Sipariş_otomasyonu
{
    public class Sqlİşlemleri
    {
        public static SqlConnection connection = new SqlConnection("Data Source=DESKTOP-SUPB5RF;Initial Catalog=Data;Integrated Security=True");
        public static void CheckConnection(SqlConnection connection)
        {
            if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
    }
}
