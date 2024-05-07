using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace He_Thong_quan_ly_di_dong_dien_thoai.Model
{
    public interface iCustomerReponsitory
    {
        void AddCustomer(CustomerModel model);
        void EditCustomer(CustomerModel spModel);
        void RemoveCustomer(int id);
        IEnumerable<CustomerModel> GetAllCustomer();
        IEnumerable<CustomerModel> GetByValueCustomer(string value); // Searchs
    }
}
