using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thuan.DAO
{
    public class CustomerDAO : DBConnection
    {
      
        
            public System.Collections.Generic.List<CustomerDAO> ReadCustomer()
            {
                SqlConnection conn = CreateConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from Customer", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                List<CustomerDAO> lstCus = new List<CustomerDAO>();
                while (reader.Read())
                {
                CustomerDAO cus = new CustomerDAO();
                    cus.Id = int.Parse(reader["id"].ToString());
                    cus.Name = reader["name"].ToString();
                    lstCus.Add(cus);
                }
                conn.Close();
                return lstCus;
            }
            public void DeleteCustomer(CustomerDAO cus)
            {
                SqlConnection conn = CreateConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand("delete  from Customer where id=@id", conn);
                cmd.Parameters.Add(new SqlParameter("@id", cus.Id));
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            public void NewCustomer(CustomerDAO cus)
            {
                SqlConnection conn = CreateConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into Customer values(@id,@name)", conn);
                cmd.Parameters.Add(new SqlParameter("@id", cus.Id));
                cmd.Parameters.Add(new SqlParameter("@name", cus.Name));
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            public void EditCustomer(CustomerDAO cus)
            {
                SqlConnection conn = CreateConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand("update customer set Name= @name where id =@id", conn);
                cmd.Parameters.Add(new SqlParameter("@id", cus.Id));
                cmd.Parameters.Add(new SqlParameter("@name", cus.Name));
                cmd.ExecuteNonQuery();
                conn.Close();


                /*SqlConnection conn = CreateConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand("update customer set name=@name where id=@id", conn);
                cmd.Parameters.Add(new SqlParameter("@id", cus.Id));
                cmd.Parameters.Add(new SqlParameter("@name", cus.Name));
                cmd.ExecuteNonQuery();
                conn.Close();*/

            }
        
    }
}
