using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thuan.DTO
{
    public class CustomerDTO
    {
        public string makhachhang { get; set; }
        public string tenkhachhang { get; set; }
        public string sodienthoai { get; set; }
        public int sotienno { get; set; }
    }
}
