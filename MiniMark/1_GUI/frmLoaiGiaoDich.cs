using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using MiniMark.General;
using MiniMark.Bussiness;
using MiniMark.Controller;

namespace MiniMark
{
    public partial class frmLoaiGiaoDich : Office2007Form
    {
        LoaiGiaoDichCtrl m_LoaiGiaoDichCtrl = new LoaiGiaoDichCtrl();
        QuyDinh m_QuyDinh = new QuyDinh();
        public frmLoaiGiaoDich()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmLoaiGiaoDich_Load(object sender, EventArgs e)
        {
            m_LoaiGiaoDichCtrl.HienThi(DGVDMLoaiGiaoDich, BindingNavigatorDMLoaiGiaoDich);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (DGVDMLoaiGiaoDich.RowCount == 0)
                BindingNavigatorDMLoaiGiaoDich.Enabled = true;
            DataRow m_Row = m_LoaiGiaoDichCtrl.ThemDongMoi();
            m_Row["MaLoaiGiaoDich"] = "LGD" + m_QuyDinh.LaySTT(DGVDMLoaiGiaoDich.Rows.Count + 1);
            m_Row["TenLoaiGiaoDich"] = "";
            m_LoaiGiaoDichCtrl.ThemMoi(m_Row);
            BindingNavigatorDMLoaiGiaoDich.BindingSource.MoveLast();
        }

        public Boolean KiemTraTruocKhiLuu(String str)
        {
            foreach (DataGridViewRow row in DGVDMLoaiGiaoDich.Rows)
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
            if (KiemTraTruocKhiLuu("colMaLoaiGiaoDich") == true &&
                KiemTraTruocKhiLuu("colTenGiaoDich") == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_LoaiGiaoDichCtrl.LuuLoaiGiaoDich();
            }
            else
            {
                MessageBoxEx.Show("Giá trị của ô không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (DGVDMLoaiGiaoDich.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;

            else
                if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BindingNavigatorDMLoaiGiaoDich.BindingSource.RemoveCurrent();
                }
        }

        private void bindingNavigatorCloseItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}