using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace He_Thong_quan_ly_di_dong_dien_thoai.View
{
    public partial class voucherView : Form, iVoucherView
    {

        private string _message;
        private bool _isSuccessful;
        private iVoucherView _view;
        private bool _isEdit;

        public voucherView()
        {
            InitializeComponent();
            LienKetVaNangCaoLuotXem();
            tabControlVoucher.TabPages.Remove(tabVoucher);
        }

        public string idVoucherView { get => txtMaKhuyenMai.Text; set => txtMaKhuyenMai.Text = value; }
        public string nameVoucherView { get => txtTenKhuyenMai.Text; set => txtTenKhuyenMai.Text = value; }
        public string descriptionVoucherView { get => txtMoTaVoucher.Text; set => txtMoTaVoucher.Text = value; }
        public DateTime dateStartView { get => DateStart.Value; set => DateStart.Value = value; }
        public DateTime dateEndView { get => DateEnd.Value; set => DateEnd.Value = value; }
        public string TimKiem { get => txtSearchVoucher.Text; set => txtSearchVoucher.Text = value; }
        public bool isEdit { get => _isEdit; set => _isEdit = value; }
        public bool isSuccessful { get => _isSuccessful; set => _isSuccessful = value; }
        public string Message { get => _message; set => _message = value; }

        public event EventHandler SearchVoucher;
        public event EventHandler AddNewVoucher;
        public event EventHandler EditVoucher;
        public event EventHandler DeletetVoucher;
        public event EventHandler SaveVoucher;
        public event EventHandler CancelVoucher;


        private static voucherView instance; 
        public static voucherView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new voucherView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }

        public void SetVoucherBindingSource(BindingSource voucherList)
        {
            dgvVoucher.DataSource = voucherList;
        }

        private void LienKetVaNangCaoLuotXem()
        {
            // Search product
            btnSearch.Click += delegate { SearchVoucher?.Invoke(this, EventArgs.Empty); };
            txtSearchVoucher.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchVoucher?.Invoke(this, EventArgs.Empty);
                }
            };

            // Add new product
            btnCreateVoucher.Click += delegate
            {
                AddNewVoucher?.Invoke(this, EventArgs.Empty);
                tabControlVoucher.TabPages.Remove(tabAllVoucher);
                tabControlVoucher.TabPages.Add(tabVoucher);
                tabControlVoucher.SelectedTab = tabVoucher; // Chọn tabPageProductDetail để hiển thị
                tabVoucher.Text = "Tạo khuyến mãi mới";
            };

            // Edit product
            btnEditVoucher.Click += delegate
            {
                EditVoucher?.Invoke(this, EventArgs.Empty);
                tabControlVoucher.TabPages.Remove(tabAllVoucher);
                tabControlVoucher.TabPages.Add(tabVoucher);
                tabControlVoucher.SelectedTab = tabVoucher; 
                tabVoucher.Text = "Thay đổi thông tin khuyến mãi";
            };
            // Save changes product
            btnSaveVoucher.Click += delegate
            {
                SaveVoucher?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    tabControlVoucher.TabPages.Remove(tabAllVoucher);
                    tabControlVoucher.TabPages.Add(tabAllVoucher);
                    tabControlVoucher.SelectedTab = tabAllVoucher; // Chọn tabPageProductList để hiển thị
                }
                MessageBox.Show(Message);
            };

            // Cancel product
            btnCancelVoucher.Click += delegate
            {
                CancelVoucher?.Invoke(this, EventArgs.Empty);
                tabControlVoucher.TabPages.Remove(tabVoucher);
                tabControlVoucher.TabPages.Add(tabAllVoucher);
                tabControlVoucher.SelectedTab = tabAllVoucher; // Chọn tabPageProductList để hiển thị
            };
            // Delete product
            btnDelVoucher.Click += delegate
            {
                var result = MessageBox.Show("Bạn chắc chắn muốn xoá khuyến mãi này chứ ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeletetVoucher?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
        }

        private void dgvVoucher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0) // Chắc chắn rằng người dùng đã chọn một hàng hợp lệ
            {
                DataGridViewRow row = dgvVoucher.Rows[e.RowIndex];
                txtMaKhuyenMai.Text = row.Cells[0].Value.ToString();
                txtTenKhuyenMai.Text = row.Cells[1].Value.ToString();
                txtMoTaVoucher.Text = row.Cells[2].Value.ToString();
                DateStart.Value = DateTime.Parse(row.Cells[3].Value.ToString());
                DateEnd.Value = DateTime.Parse(row.Cells[4].Value.ToString());

            }
        }

        private void txtSearchVoucher_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (dgvVoucher.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvVoucher.SelectedRows[0];
                string maKhuyenMai = selectedRow.Cells[0].Value.ToString(); 
                Clipboard.SetText(maKhuyenMai);
                MessageBox.Show("Mã Khuyến Mãi đã được sao chép!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để sao chép Mã Khuyến Mãi.");
            }
        }
    }
}
