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
            iSPView view = new productView();
            iSPRepository repository = new SpRepository(sqlConnectionString);
            new ProductPresenter(view, repository);
            //Application.Run(new form1());
            Application.Run((Form)view);
        }
    }
}
