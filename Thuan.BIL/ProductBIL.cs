using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thuan.BIL
{
    public class CustomerDTO
    {
        CustomerDTO dal = new CustomerDTO();
            public List<CustomerDAO> ReadCustomer()
            {
                List<CustomerBEL> lstCus = dal.ReadCustomer();
                return lstCus;
            }
            public void NewCustomer(CustomerDAO cus)
            {
                dal.NewCustomer(cus);
            }
            public void DeleteCustomer(CustomerDAO cus)
            {
                dal.DeleteCustomer(cus);
            }
            public void EditCustomer(CustomerDAO cus)
            {
                dal.EditCustomer(cus);
            }
        
    }
}
