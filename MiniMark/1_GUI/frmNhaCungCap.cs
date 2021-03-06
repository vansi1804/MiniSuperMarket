using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using MiniMark.Controller;
using MiniMark.DataLayer;
using MiniMark.General;

namespace MiniMark
{
    public partial class frmNhaCungCap : Office2007Form
    {
        QuyDinh m_QuyDinh = new QuyDinh();
        NhaCungCapCtrl m_NhaCungCapCtrl = new NhaCungCapCtrl();
        public frmNhaCungCap()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            m_NhaCungCapCtrl.HienThi(DGVNhaCungCap, BindingNavigatorNhaCungCap, txtMaNCC, txtTenNhaCC, txtEmail, txtDiaChi, txtFax, txtGhiChu, txtDienThoai);
        }

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            m_NhaCungCapCtrl.HienThi(DGVNhaCungCap, BindingNavigatorNhaCungCap, txtMaNCC, txtTenNhaCC, txtEmail, txtDiaChi, txtFax, txtGhiChu, txtDienThoai);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (DGVNhaCungCap.RowCount == 0)
                BindingNavigatorNhaCungCap.Enabled = true;
            DataRow m_Row = m_NhaCungCapCtrl.ThemDongMoi();
            m_Row["MaNCC"] = "NCC" + m_QuyDinh.LaySTT(DGVNhaCungCap.Rows.Count + 1);
            m_Row["TenNCC"] = "";
            m_Row["DiaChi"] = "";
            m_Row["Email"] = "";
            m_Row["Fax"] = "";
            m_Row["DienThoai"] = "";
            m_Row["GhiChu"] = "";

            m_NhaCungCapCtrl.ThemMoi(m_Row);
            BindingNavigatorNhaCungCap.BindingSource.MoveLast();
        }
        public Boolean KiemTraTruocKhiLuu(String str)
        {
            foreach (DataGridViewRow row in DGVNhaCungCap.Rows)
            {
                if (row.Cells[str].Value != null)
                {
                    String m_Str = row.Cells[str].Value.ToString();
                    if (m_Str == "")
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (KiemTraTruocKhiLuu("colMaNCC") == true &&
                    KiemTraTruocKhiLuu("colTenNCC") == true &&
                    KiemTraTruocKhiLuu("colDiaChi") == true &&
                    KiemTraTruocKhiLuu("colDienThoai") == true &&
                    KiemTraTruocKhiLuu("colFax") == true &&
                    KiemTraTruocKhiLuu("colEmail") == true)
                    bindingNavigatorPositionItem.Focus();
                m_NhaCungCapCtrl.LuuNhaCungCap();
            }
            catch
            {
                MessageBoxEx.Show("Giá trị ô không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (DGVNhaCungCap.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;

            else
                if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BindingNavigatorNhaCungCap.BindingSource.RemoveCurrent();
                }
        }

        private void bindingNavigatorCloseItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiMatHang();
        }

        #region Tìm kiếm nhà cung cấp
        private void btnSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TimKiemNhaCungCap();
            }
        }

        void TimKiemNhaCungCap()
        {
            try
            {
                if (cbMaNCC.Checked == true)
                {
                    m_NhaCungCapCtrl.TimKiemTheoMa(txtTimKiem.Text);
                }
                else if (cbTenNCC.Checked == true)
                {
                    m_NhaCungCapCtrl.TiemKiemTheoTen(txtTimKiem.Text);
                }
            }
            catch
            {
                MessageBoxEx.Show("Không thể tìm thấy Giá trị cần tìm!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                MessageBoxEx.Show("Giá trị tìm rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                TimKiemNhaCungCap();
            }
        }
        #endregion

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if ( txtTenNhaCC.Text != "" && txtDienThoai.Text != "" && txtFax.Text != "" && txtEmail.Text != "" && txtDiaChi.Text != "")
            {
            m_NhaCungCapCtrl.LuuNhaCungCap(txtMaNCC.Text, txtTenNhaCC.Text, txtDienThoai.Text, txtFax.Text, txtEmail.Text, txtDiaChi.Text, txtGhiChu.Text);
            m_NhaCungCapCtrl.HienThi(DGVNhaCungCap, BindingNavigatorNhaCungCap, txtMaNCC, txtTenNhaCC, txtEmail, txtDiaChi, txtFax, txtGhiChu, txtDienThoai);
            MessageBoxEx.Show("Đã lưu thành công!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBoxEx.Show("Phải nhập đầy đủ dữ liệu để thêm nhà cung cấp", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            if (DGVNhaCungCap.RowCount == 0)
                BindingNavigatorNhaCungCap.Enabled = true;
            DataRow m_Row = m_NhaCungCapCtrl.ThemDongMoi();
            m_Row["MaNCC"] = "NCC" + m_QuyDinh.LaySTT(DGVNhaCungCap.Rows.Count + 1);
            m_Row["TenNCC"] = "";
            m_Row["DiaChi"] = "";
            m_Row["Email"] = "";
            m_Row["Fax"] = "";
            m_Row["DienThoai"] = "";
            m_Row["GhiChu"] = "";
            m_NhaCungCapCtrl.ThemMoi(m_Row);
            BindingNavigatorNhaCungCap.BindingSource.MoveLast();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
             m_NhaCungCapCtrl.SuaNhaCungCap(txtMaNCC.Text, txtTenNhaCC.Text, txtDienThoai.Text, txtFax.Text, txtEmail.Text, txtDiaChi.Text, txtGhiChu.Text);
            m_NhaCungCapCtrl.HienThi(DGVNhaCungCap, BindingNavigatorNhaCungCap, txtMaNCC, txtTenNhaCC, txtEmail, txtDiaChi, txtFax, txtGhiChu, txtDienThoai);
            MessageBoxEx.Show("Đã sửa thành công!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBoxEx.Show("Bạn có chắc chắn xóa nhà cung cấp này không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                m_NhaCungCapCtrl.XoaNhaCungCap(txtMaNCC.Text);
                m_NhaCungCapCtrl.HienThi(DGVNhaCungCap, BindingNavigatorNhaCungCap, txtMaNCC, txtTenNhaCC, txtEmail, txtDiaChi, txtFax, txtGhiChu, txtDienThoai);
            }
        }

    }
}