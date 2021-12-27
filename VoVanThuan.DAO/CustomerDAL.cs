using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoVanThuan.BLL;

namespace VoVanThuan.DAO
{
    public class CustomerDAL : DBConnection
    {
        public List<CustomerBEL> ReadCustomer()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from QLBH", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<CustomerBEL> lstCus = new List<CustomerBEL>();
     
            while (reader.Read())
            {
                CustomerBEL cus = new CustomerBEL();
                cus.makhachhang = int.Parse(reader["makhachhang"].ToString());
                cus.tenkhachhang = reader["tenkhachhang"].ToString();
                cus.sodienthoai = int.Parse(reader["sodienthoai"].ToString());
                cus.sotienno = decimal.Parse(reader["sotienno"].ToString());
                lstCus.Add(cus);
            }
            conn.Close();
            return lstCus;
        }
        public void EditCustomer(CustomerBEL cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("update QLBH set name = @tenkhachhang,id_area=@id_area where id=@makhachhang ", conn);
            cmd.Parameters.Add(new SqlParameter("@makhachhang", cus.makhachhang));
            cmd.Parameters.Add(new SqlParameter("@tenkhachhang", cus.tenkhachhang));
            cmd.Parameters.Add(new SqlParameter("@sodienthoai", cus.sodienthoai));
            cmd.Parameters.Add(new SqlParameter("@sotienno", cus.sotienno));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void DeleteCustomer(CustomerBEL cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from QLBH where id=@makhachhang ", conn);
            cmd.Parameters.Add(new SqlParameter("@makhachhang", cus.makhachhang);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void NewCustomer(CustomerBEL cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into QLBH values(@makhachhang,@tenkhachhang,@sodienthoai,@sotienno) ", conn);
            cmd.Parameters.Add(new SqlParameter("@makhachhang", cus.makhachhang));
            cmd.Parameters.Add(new SqlParameter("@tenkhachhang", cus.tenkhachhang));
            cmd.Parameters.Add(new SqlParameter("@sodienthoai", cus.sodienthoai));
            cmd.Parameters.Add(new SqlParameter("@sotienno", cus.sotienno));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
