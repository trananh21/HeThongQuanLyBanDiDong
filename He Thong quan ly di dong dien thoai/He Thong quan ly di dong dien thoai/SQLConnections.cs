using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace He_Thong_quan_ly_di_dong_dien_thoai
{
    public class SQLConnections
    {
        public static string KetnoiSQL()
        {
            return (@"Data Source=.\SQLExpress02;Initial Catalog=qlbdtdd;Integrated Security=True;");
        }
    }
}
