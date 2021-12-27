using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Thuan.DAO
{
    public class DBConnection
    {
        public DBConnection()
        {
        }
        public SqlConnection CreateConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-R0IAVP4\\SQLEXPRESS2012;  Initial Catalog=QLBH; User Id=sa; Password=sa1105";
            return conn;
        }
    }
}
