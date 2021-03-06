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
    public partial class frmTimKiemNhanVien : Office2007Form
    {
        NhanVienCtrl m_NhanVienCtrl = new NhanVienCtrl();
        QuayGiaoDichCtrl m_QuayGiaoDihCtrl = new QuayGiaoDichCtrl();
        public frmTimKiemNhanVien()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        public void LoadData()
        {
            txtTimKiem.Text = "";
            m_QuayGiaoDihCtrl.HienThiDataGridViewComboBoxColumn(colMaQuayGD);
            m_NhanVienCtrl.HienThi(DGVNhanVien, BindingNavigatorNhanVien);
        }
        private void frmTimKiemNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void bindingNavigatorCloseItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Tim Kiem nhan vien
        private void btnSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TimKiemNhanVien();
            }
        }

        void TimKiemNhanVien()
        {
            try
            {
                if (cbMaNV.Checked == true)
                {
                    m_NhanVienCtrl.TimKiemTheoMa(txtTimKiem.Text);
                }
                else if (cbHoTen.Checked == true)
                {
                    m_NhanVienCtrl.TiemKiemTheoTen(txtTimKiem.Text);
                }
            }
            catch
            {
                MessageBoxEx.Show("Không thể tìm thấy Giá trị cần tìm!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                MessageBoxEx.Show("Giá trị tìm rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                TimKiemNhanVien();
            }
        }

        #endregion

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}