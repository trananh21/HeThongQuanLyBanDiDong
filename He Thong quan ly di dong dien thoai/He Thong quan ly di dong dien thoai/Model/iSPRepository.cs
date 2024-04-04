using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    Dependency Inversion Principle (DIP) là một trong năm nguyên tắc của SOLID, 
    một nguyên tắc thiết kế phần mềm quan trọng. Nguyên tắc này được định nghĩa bởi Robert C. Martin, 
    còn được gọi là "Uncle Bob".

    Nguyên tắc Dependency Inversion khẳng định rằng:

    Các module cấp cao không nên phụ thuộc vào các module cấp thấp. Cả hai nên phụ thuộc vào abstraction.
    Abstraction không nên phụ thuộc vào chi tiết. Chi tiết nên phụ thuộc vào abstraction.
    Nói một cách đơn giản, DIP khuyến khích việc sử dụng abstraction (abstractions) 
    để giảm bớt sự phụ thuộc giữa các thành phần trong hệ thống.

    Ví dụ, thay vì một module cấp cao trực tiếp gọi các phương thức của một module cấp thấp, 
    chúng ta sẽ sử dụng một interface hoặc abstract class chung để định nghĩa các hành vi, 
    và các module cấp cao sẽ phụ thuộc vào abstraction này. Điều này giúp 
    tạo ra sự linh hoạt, giảm bớt sự ràng buộc và tạo điều kiện thuận lợi cho việc thay đổi 
    và mở rộng trong hệ thống.
*/

// Nguyên tắc DIP 
namespace He_Thong_quan_ly_di_dong_dien_thoai.Model
{
    public interface iSPRepository
    {
        void ThemThongTin(SPModel model);
        void SuaThongTin(SPModel spModel);
        void XoaThongTin(int id);
        IEnumerable<SPModel> GetAll();
        IEnumerable<SPModel> GetByValue(string value); // Searchs
    }
}
