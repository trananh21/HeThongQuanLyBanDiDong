using He_Thong_quan_ly_di_dong_dien_thoai._Repositories;
using He_Thong_quan_ly_di_dong_dien_thoai.Model;
using He_Thong_quan_ly_di_dong_dien_thoai.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace He_Thong_quan_ly_di_dong_dien_thoai.Presenter
{
    public class MainPresenter
    {
        private iMainView mainView;
        private readonly string sqlConnectionString;

        public MainPresenter(iMainView mainView, string sqlConnectionString)
        {
            this.mainView = mainView;
            this.sqlConnectionString = sqlConnectionString;
            this.mainView.ShowSPView += ShowSPsView;
            this.mainView.ShowCustomersView += ShowCussView;
        }

        private void ShowCussView(object sender, EventArgs e)
        {
            iCustomerView view = (iCustomerView)customerView.GetInstance((Dashboard)mainView);
            iCustomerReponsitory repository = new customerRepository(sqlConnectionString);
            new CustomerPresenter(view, repository);
        }

        private void ShowSPsView(object sender, EventArgs e)
        {
            iSPView view = productView.GetInstance((Dashboard)mainView);
            iSPRepository repository = new SpRepository(sqlConnectionString);
            new ProductPresenter(view, repository);
        }



    }
}
