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
using System.Diagnostics;

namespace MiniMark
{
    public partial class frmPhanNhomNguoiDung : Office2007Form
    {
        PhanNhomNguoiDungCtrl m_PhanNhomNguoiDungCtrl = new PhanNhomNguoiDungCtrl();
        NhanVienCtrl m_NhanVienCtrl = new NhanVienCtrl();
        NhomNguoiDungCtrl m_NhomNguoiDungCtrl = new NhomNguoiDungCtrl();
        public frmPhanNhomNguoiDung()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmPhanNhomNguoiDung_Load(object sender, EventArgs e)
        {
            m_NhanVienCtrl.HienThiDataGridViewComboBoxColumn(colMaNV);
            m_NhomNguoiDungCtrl.HienThiDataGridViewComboBoxColumn(colMaNhomNguoiDung);
            m_PhanNhomNguoiDungCtrl.HienThi(DGVPhanNhomNguoiDung, BindingNavigatorPhanNhomNguoiDung);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (DGVPhanNhomNguoiDung.RowCount == 0)
                BindingNavigatorPhanNhomNguoiDung.Enabled = true;
            DataRow m_Row = m_PhanNhomNguoiDungCtrl.ThemDongMoi();
            m_Row["MaNV"] = "";
            m_Row["MaNhomNguoiDung"] = "";
            m_PhanNhomNguoiDungCtrl.ThemPhanNhomNguoiDung(m_Row);
            BindingNavigatorPhanNhomNguoiDung.BindingSource.MoveLast();

        }
        public Boolean KiemTraTruocKhiLuu(String str)
        {
            foreach (DataGridViewRow row in DGVPhanNhomNguoiDung.Rows)
            {
                if (row.Cells[str].Value != null)
                {
                    String m_Str = row.Cells[str].Value.ToString();
                    if (m_Str == "")
                    {
                        MessageBoxEx.Show("Giá trị của ô không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
                bindingNavigatorPositionItem.Focus();
            m_PhanNhomNguoiDungCtrl.LuuPhanNhomNguoiDung();
            MessageBoxEx.Show("Đã lưu thành công!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (DGVPhanNhomNguoiDung.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;

            else
                if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BindingNavigatorPhanNhomNguoiDung.BindingSource.RemoveCurrent();
                }
        }

        private void bindingNavigatorCloseItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}