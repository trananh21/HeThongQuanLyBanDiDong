using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using He_Thong_quan_ly_di_dong_dien_thoai._Repositories;
using He_Thong_quan_ly_di_dong_dien_thoai.Model;
using He_Thong_quan_ly_di_dong_dien_thoai.Presenter;
using He_Thong_quan_ly_di_dong_dien_thoai.View;
using System.Configuration;
namespace He_Thong_quan_ly_di_dong_dien_thoai
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            iMainView view = new form1();
            new MainPresenter(view, sqlConnectionString);
            //Application.Run(new Dashboard("", repository));
            Application.Run((Form)view);

        }
    }
}
