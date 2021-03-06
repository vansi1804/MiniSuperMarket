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
    public partial class frmKhachHang : Office2007Form
    {
        KhachHangCtrl m_KhachHangCtrl = new KhachHangCtrl();
        QuyDinh m_QuyDinh = new QuyDinh();
        public frmKhachHang()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            m_KhachHangCtrl.HienThi(DGVKhachHang, BindingNavigatorKhachHang, txtMaKH, txtHoTen, txtDiaChi, txtDienThoai);
        }

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            m_KhachHangCtrl.HienThi(DGVKhachHang, BindingNavigatorKhachHang, txtMaKH, txtHoTen, txtDiaChi, txtDienThoai);
        }

        public Boolean KiemTraTruocKhiLuu(String str)
        {
            foreach (DataGridViewRow row in DGVKhachHang.Rows)
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

            if (KiemTraTruocKhiLuu("colMaKH") == true &&
                KiemTraTruocKhiLuu("colDiaChi") == true &&
                 KiemTraTruocKhiLuu("colHoTen") == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_KhachHangCtrl.LuuKhachHang();
            }
            else
            {
                MessageBoxEx.Show("Giá trị ô không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (DGVKhachHang.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;

            else
                if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BindingNavigatorKhachHang.BindingSource.RemoveCurrent();
                }
        }

        private void bindingNavigatorCloseItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (DGVKhachHang.RowCount == 0)
                BindingNavigatorKhachHang.Enabled = true;
            DataRow m_Row = m_KhachHangCtrl.ThemDongMoi();
            m_Row["MaKH"] = "KH" + m_QuyDinh.LaySTT(DGVKhachHang.Rows.Count + 1); ;
            m_Row["HoTen"] = "";
            m_Row["DiaChi"] = "";
            m_Row["DienThoai"] = "";
            m_KhachHangCtrl.ThemMoi(m_Row);
            BindingNavigatorKhachHang.BindingSource.MoveLast();
        }
        #region Tìm kiếm khách hàng
        private void btnSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TimKiemKhachHang();
            }
        }

        void TimKiemKhachHang()
        {
            try
            {
                if (cbMaKH.Checked == true)
                {
                    m_KhachHangCtrl.TimKiemTheoMa(txtTimKiem.Text);
                }
                else
                {
                    m_KhachHangCtrl.TimKiemTheoTen(txtTimKiem.Text);
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
                TimKiemKhachHang();
            }
        }
        #endregion

        private void buttonSave_Click(object sender, EventArgs e)
        {
            m_KhachHangCtrl.LuuKhachHang(txtMaKH.Text, txtHoTen.Text, txtDiaChi.Text, txtDienThoai.Text);
            m_KhachHangCtrl.HienThi(DGVKhachHang, BindingNavigatorKhachHang, txtMaKH, txtHoTen, txtDiaChi, txtDienThoai);
        }
    }
}