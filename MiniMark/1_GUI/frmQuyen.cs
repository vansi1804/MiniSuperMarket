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
    public partial class frmQuyen : Office2007Form
    {
        QuyenCtrl m_QuyenCtrl = new QuyenCtrl();
        public frmQuyen()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmQuyen_Load(object sender, EventArgs e)
        {

            m_QuyenCtrl.HienThi(DGVQuyen, BindingNavigatorQuyen);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (DGVQuyen.RowCount == 0)
                BindingNavigatorQuyen.Enabled = true;
            DataRow m_Row = m_QuyenCtrl.ThemDongMoi();
            m_Row["MaQuyen"] = "";
            m_Row["TenQuyen"] = "";
            m_QuyenCtrl.ThemMoi(m_Row);
            BindingNavigatorQuyen.BindingSource.MoveLast();
        }

        public Boolean KiemTraTruocKhiLuu(String str)
        {
            foreach (DataGridViewRow row in DGVQuyen.Rows)
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
            m_QuyenCtrl.LuuQuyen();
            MessageBoxEx.Show("Đã lưu thành công!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (DGVQuyen.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;

            else
                if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BindingNavigatorQuyen.BindingSource.RemoveCurrent();
                }
        }

        private void bindingNavigatorCloseItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}