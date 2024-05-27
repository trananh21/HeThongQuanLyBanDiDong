using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
            //string debugFolder = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            //string databaseFile = Path.Combine(debugFolder, "qlbdtdd.mdf");
            //string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={databaseFile};Integrated Security=True;Connect Timeout=30;";
            //return connectionString;

            string connectionString = $@"Data Source=.;Initial Catalog=qlbdtddver2;Integrated Security=True;";
            return connectionString;
        }
    }
}
