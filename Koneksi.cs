using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AppKasir
{
    class Koneksi
    {
        public SqlConnection GetConn()
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = "Data Source=DESKTOP-S58UUFN; Initial Catalog=DB_APPKASIR; Integrated Security=true";
            return Conn;
        }
    }
}
