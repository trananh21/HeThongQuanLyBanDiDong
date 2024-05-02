using System;

namespace He_Thong_quan_ly_di_dong_dien_thoai.View
{
    internal class EditProductEventArgs : EventArgs
    {
        private long productId;

        public EditProductEventArgs(long productId)
        {
            this.productId = productId;
        }
    }
}