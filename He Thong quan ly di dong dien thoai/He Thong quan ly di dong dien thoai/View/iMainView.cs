using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace He_Thong_quan_ly_di_dong_dien_thoai.View
{
    public interface iMainView
    {
        event EventHandler ShowSPView;
        event EventHandler ShowOnwerView;
        event EventHandler ShowVetsView;

        event EventHandler ShowCustomerView;
        event EventHandler ShowAdminView;
        event EventHandler ShowCustomersView;
    }
}
