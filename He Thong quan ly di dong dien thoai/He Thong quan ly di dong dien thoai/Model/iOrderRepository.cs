using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace He_Thong_quan_ly_di_dong_dien_thoai.Model
{
    public interface iOrderRepository
    {
        void AddOrder(OrderModel model);
        void EditOrder(OrderModel orderModel);
        void RemoveOrder(int id);
        IEnumerable<OrderModel> GetAllOrder();
        IEnumerable<OrderModel> GetByValueOrder(string value); // Searchs
    }
}
