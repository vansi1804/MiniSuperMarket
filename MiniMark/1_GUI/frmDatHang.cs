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
    public partial class frmDatHang : Office2007Form
    {
        QuyDinh m_QuyDinh = new QuyDinh();
        DatHangCtrl m_DatHangCtrl = new DatHangCtrl();
        MatHangCtrl m_MatHangCtrl = new MatHangCtrl();
        LoaiTienCtrl m_LoaiTienCtrl = new LoaiTienCtrl();
        LoaiGiaoDichCtrl m_LoaiGiaoDichCtrl = new LoaiGiaoDichCtrl();
        KhachHangCtrl m_KhachHangCtrl = new KhachHangCtrl();
        public frmDatHang()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmDatHang_Load(object sender, EventArgs e)
        {
            m_LoaiTienCtrl.HienThiComboBox(cmbLoaiTienGui);
            m_LoaiTienCtrl.HienThiDataGridViewComboBoxColumn(colLoaiTien);
            m_LoaiGiaoDichCtrl.HienThiComboBox(cmbLoaiGiaoDich);
            m_LoaiGiaoDichCtrl.HienThiDataGridViewComboBoxColumn(colLoaiGD);
            m_KhachHangCtrl.HienThiComboBox(cmbTenKH);
            m_KhachHangCtrl.HienThiDataGridViewComboBoxColumn(colTenKH);
            m_MatHangCtrl.HienThiComboBox(cmbTenMH);
            m_MatHangCtrl.HienThiDataGridViewComboBoxColumn(colTenMH);
            m_DatHangCtrl.HienThi(DGVDatHang, BindingNavigatorDatHang, txtMaPhieu, dtNgayDat, txtSoLuong, txtGiaBan, txtThanhTien, txtGhiChu, cbThanhToan, cmbTenMH, cmbTenKH, cmbLoaiGiaoDich, cmbLoaiTienGui);
        }

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            m_LoaiTienCtrl.HienThiComboBox(cmbLoaiTienGui);
            m_LoaiTienCtrl.HienThiDataGridViewComboBoxColumn(colLoaiTien);
            m_LoaiGiaoDichCtrl.HienThiComboBox(cmbLoaiGiaoDich);
            m_LoaiGiaoDichCtrl.HienThiDataGridViewComboBoxColumn(colLoaiGD);
            m_KhachHangCtrl.HienThiComboBox(cmbTenKH);
            m_KhachHangCtrl.HienThiDataGridViewComboBoxColumn(colTenKH);
            m_MatHangCtrl.HienThiComboBox(cmbTenMH);
            m_MatHangCtrl.HienThiDataGridViewComboBoxColumn(colTenMH);
            m_DatHangCtrl.HienThi(DGVDatHang, BindingNavigatorDatHang, txtMaPhieu, dtNgayDat, txtSoLuong, txtGiaBan, txtThanhTien, txtGhiChu, cbThanhToan, cmbTenMH, cmbTenKH, cmbLoaiGiaoDich, cmbLoaiTienGui);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

            if (DGVDatHang.RowCount == 0)
                BindingNavigatorDatHang.Enabled = true;
            DataRow m_Row = m_DatHangCtrl.ThemDongMoi();
            m_Row["MaPhieu"] = "DH" + m_QuyDinh.LaySTT(DGVDatHang.Rows.Count + 1);
            m_Row["MaMH"] = "";
            m_Row["MaKH"] = "";
            m_Row["NgayDat"] = DateTime.Today;
            m_Row["SoLuong"] = 0;
            m_Row["GiaBan"] = 0;
            m_Row["ThanhTien"] = 0;
            m_Row["MaLoaiGiaoDich"] = "";
            m_Row["MaLoaiTien"] = "";
            m_Row["GhiChu"] = "";
            m_Row["ThanhToan"] = false;

            m_DatHangCtrl.ThemMoi(m_Row);
            BindingNavigatorDatHang.BindingSource.MoveLast();
        }
        public Boolean KiemTraTruocKhiLuu(String str)
        {
            foreach (DataGridViewRow row in DGVDatHang.Rows)
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
            if (KiemTraTruocKhiLuu("colMaPhieu") == true &&
                    KiemTraTruocKhiLuu("colTenMH") == true &&
                    KiemTraTruocKhiLuu("colTenKH") == true &&
                    KiemTraTruocKhiLuu("colGiaBan") == true &&
                    KiemTraTruocKhiLuu("colThanhTien") == true &&
                    KiemTraTruocKhiLuu("colLoaiTien") == true &&
                    KiemTraTruocKhiLuu("colLoaiGD") == true &&
                    KiemTraTruocKhiLuu("colNgayDat") == true &&
                    KiemTraTruocKhiLuu("colSoLuong") == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_DatHangCtrl.LuuDatHang();
            }
            else
            {
                MessageBoxEx.Show("Giá trị ô không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (DGVDatHang.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;

            else
                if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BindingNavigatorDatHang.BindingSource.RemoveCurrent();
                }
        }

        private void bindingNavigatorCloseItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemMH_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiMatHang();
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiKhachHang();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtGhiChu.Text = "";
            txtGiaBan.Text = "0";
            txtSoLuong.Text = "0";
            txtThanhTien.Text = "0";
            cbThanhToan.Checked = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (DGVDatHang.RowCount == 0)
                BindingNavigatorDatHang.Enabled = true;
            DataRow m_Row = m_DatHangCtrl.ThemDongMoi();
            m_Row["MaPhieu"] = "DH" + m_QuyDinh.LaySTT(DGVDatHang.Rows.Count + 1);
            m_Row["MaMH"] = "";
            m_Row["MaKH"] = "";
            m_Row["NgayDat"] = DateTime.Today;
            m_Row["SoLuong"] = 0;
            m_Row["GiaBan"] = 0;
            m_Row["ThanhTien"] = 0;
            m_Row["MaLoaiGiaoDich"] = "";
            m_Row["MaLoaiTien"] = "";
            m_Row["GhiChu"] = "";
            m_Row["ThanhToan"] = false;

            m_DatHangCtrl.ThemMoi(m_Row);
            BindingNavigatorDatHang.BindingSource.MoveLast();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtGiaBan.Text != "" && txtSoLuong.Text != "" && txtThanhTien.Text != "" && cmbTenMH.SelectedValue != null && cmbTenKH.SelectedValue != null && dtNgayDat.Value != null && cmbLoaiTienGui.SelectedValue != null && cmbLoaiGiaoDich.SelectedValue != null)
            {
                bool thanhtoan = false;
                if (cbThanhToan.Checked == true)
                {
                    thanhtoan = true;
                }
                else
                {
                    thanhtoan = false;
                }
                m_DatHangCtrl.LuuDatHang(txtMaPhieu.Text, cmbTenMH.SelectedValue.ToString(), cmbTenKH.SelectedValue.ToString(), Convert.ToInt64(txtSoLuong.Text), Convert.ToInt64(txtGiaBan.Text), Convert.ToInt64(txtThanhTien.Text), dtNgayDat.Value, thanhtoan, cmbLoaiTienGui.SelectedValue.ToString(), cmbLoaiGiaoDich.SelectedValue.ToString(), txtGhiChu.Text);
                m_DatHangCtrl.HienThi(DGVDatHang, BindingNavigatorDatHang, txtMaPhieu, dtNgayDat, txtSoLuong, txtGiaBan, txtThanhTien, txtGhiChu, cbThanhToan, cmbTenMH, cmbTenKH, cmbLoaiGiaoDich, cmbLoaiTienGui);
                MessageBoxEx.Show("Đã lưu thành công!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBoxEx.Show("Phải nhập đầy đủ dữ liệu để thêm đơn đặt hàng", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            bool thanhtoan = false;
            if (cbThanhToan.Checked == true)
            {
                thanhtoan = true;
            }
            else
            {
                thanhtoan = false;
            }
            try
            {
                m_DatHangCtrl.SuaDatHang(txtMaPhieu.Text, cmbTenMH.SelectedValue.ToString(), cmbTenKH.SelectedValue.ToString(), Convert.ToInt64(txtSoLuong.Text), Convert.ToInt64(txtGiaBan.Text), Convert.ToInt64(txtThanhTien.Text), dtNgayDat.Value, thanhtoan, cmbLoaiTienGui.SelectedValue.ToString(), cmbLoaiGiaoDich.SelectedValue.ToString(), txtGhiChu.Text);
                m_DatHangCtrl.HienThi(DGVDatHang, BindingNavigatorDatHang, txtMaPhieu, dtNgayDat, txtSoLuong, txtGiaBan, txtThanhTien, txtGhiChu, cbThanhToan, cmbTenMH, cmbTenKH, cmbLoaiGiaoDich, cmbLoaiTienGui);
                MessageBoxEx.Show("Đã sửa thành công!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBoxEx.Show("Sửa thất bại!", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw;
            }
            
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBoxEx.Show("Bạn có chắc chắn xóa đặt hàng này không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                m_DatHangCtrl.XoaDatHang(txtMaPhieu.Text, cmbTenMH.SelectedValue.ToString(), cmbTenKH.SelectedValue.ToString());
                m_DatHangCtrl.HienThi(DGVDatHang, BindingNavigatorDatHang, txtMaPhieu, dtNgayDat, txtSoLuong, txtGiaBan, txtThanhTien, txtGhiChu, cbThanhToan, cmbTenMH, cmbTenKH, cmbLoaiGiaoDich, cmbLoaiTienGui);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}