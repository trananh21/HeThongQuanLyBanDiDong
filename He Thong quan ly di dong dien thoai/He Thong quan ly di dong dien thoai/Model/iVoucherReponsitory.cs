using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace He_Thong_quan_ly_di_dong_dien_thoai.Model
{
    public interface iVoucherReponsitory
    {
        void CreateVoucherNew(VoucherModel model);
        void ChangeVoucher(VoucherModel vModel);
        void RemoveVoucher(string id);
        IEnumerable<VoucherModel> GetAllVoucher();
        IEnumerable<VoucherModel> GetByValueVoucher(string value); // Searchs
    }
}
