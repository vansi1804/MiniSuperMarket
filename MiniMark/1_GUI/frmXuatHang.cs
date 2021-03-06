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
    public partial class frmXuatHang : Office2007Form
    {
        QuyDinh m_QuyDinh = new QuyDinh();
        XuatHangCtrl m_XuatHangCtrl = new XuatHangCtrl();
        MatHangCtrl m_MatHangCtrl = new MatHangCtrl();
        LoaiTienCtrl m_LoaiTienCtrl = new LoaiTienCtrl();
        LoaiGiaoDichCtrl m_LoaiGiaoDichCtrl = new LoaiGiaoDichCtrl();
        KhachHangCtrl m_KhachHangCtrl = new KhachHangCtrl();
        NhanVienCtrl m_NhanVienCtrl = new NhanVienCtrl();
        public frmXuatHang()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmXuatHang_Load(object sender, EventArgs e)
        {
            m_LoaiTienCtrl.HienThiComboBox(cmbLoaiTienGui);
            m_LoaiTienCtrl.HienThiDataGridViewComboBoxColumn(colLoaiTien);
            m_LoaiGiaoDichCtrl.HienThiComboBox(cmbLoaiGiaoDich);
            m_LoaiGiaoDichCtrl.HienThiDataGridViewComboBoxColumn(colLoaiGD);
            m_KhachHangCtrl.HienThiComboBox(cmbTenKH);
            m_KhachHangCtrl.HienThiDataGridViewComboBoxColumn(colTenKH);
            m_NhanVienCtrl.HienThiComboBox(cmbTenNV);
            m_NhanVienCtrl.HienThiDataGridViewComboBoxColumn(colTenNV);
            m_MatHangCtrl.HienThiComboBox(cmbTenMH);
            m_MatHangCtrl.HienThiDataGridViewComboBoxColumn(colTenMH);
            m_XuatHangCtrl.HienThi(DGVXuatHang, BindingNavigatorXuatHang, txtMaPhieu, dtNgayXuat, txtSoLuong, txtGiaBan, txtThanhTien, cmbTenMH, cmbTenKH, cmbTenNV, cmbLoaiGiaoDich, cmbLoaiTienGui);
        }

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            m_LoaiTienCtrl.HienThiComboBox(cmbLoaiTienGui);
            m_LoaiTienCtrl.HienThiDataGridViewComboBoxColumn(colLoaiTien);
            m_LoaiGiaoDichCtrl.HienThiComboBox(cmbLoaiGiaoDich);
            m_LoaiGiaoDichCtrl.HienThiDataGridViewComboBoxColumn(colLoaiGD);
            m_KhachHangCtrl.HienThiComboBox(cmbTenKH);
            m_KhachHangCtrl.HienThiDataGridViewComboBoxColumn(colTenKH);
            m_NhanVienCtrl.HienThiComboBox(cmbTenNV);
            m_NhanVienCtrl.HienThiDataGridViewComboBoxColumn(colTenNV);
            m_MatHangCtrl.HienThiComboBox(cmbTenMH);
            m_MatHangCtrl.HienThiDataGridViewComboBoxColumn(colTenMH);
            m_XuatHangCtrl.HienThi(DGVXuatHang, BindingNavigatorXuatHang,txtMaPhieu, dtNgayXuat, txtSoLuong, txtGiaBan, txtThanhTien, cmbTenMH, cmbTenKH, cmbTenNV, cmbLoaiGiaoDich, cmbLoaiTienGui);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (DGVXuatHang.RowCount == 0)
                BindingNavigatorXuatHang.Enabled = true;
            DataRow m_Row = m_XuatHangCtrl.ThemDongMoi();
            m_Row["MaPhieu"] = "XH" + m_QuyDinh.LaySTT(DGVXuatHang.Rows.Count + 1);
            m_Row["MaMH"] = "";
            m_Row["MaKH"] = "";
            m_Row["MaNV"] = "";
            m_Row["NgayXuat"] = DateTime.Today;
            m_Row["SoLuong"] = 0;
            m_Row["GiaBan"] = 0;
            m_Row["ThanhTien"] = 0;
            m_Row["MaLoaiGiaoDich"] = "";
            m_Row["MaLoaiTien"] = "";

            m_XuatHangCtrl.ThemMoi(m_Row);
            BindingNavigatorXuatHang.BindingSource.MoveLast();
        }
        public Boolean KiemTraTruocKhiLuu(String str)
        {
            foreach (DataGridViewRow row in DGVXuatHang.Rows)
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
            if (   KiemTraTruocKhiLuu("colMaPhieu") == true &&
                   KiemTraTruocKhiLuu("colTenMH") == true &&
                   KiemTraTruocKhiLuu("colTenKH") == true &&
                   KiemTraTruocKhiLuu("colTenNV") == true &&
                   KiemTraTruocKhiLuu("colGiaBan") == true &&
                   KiemTraTruocKhiLuu("colThanhTien") == true &&
                   KiemTraTruocKhiLuu("colLoaiTien") == true &&
                   KiemTraTruocKhiLuu("colLoaiGD") == true &&
                   KiemTraTruocKhiLuu("colNgayXuat") == true &&
                   KiemTraTruocKhiLuu("colSoLuong") == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_XuatHangCtrl.LuuXuatHang();
            }
            else
            {
                MessageBoxEx.Show("Giá trị ô không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (DGVXuatHang.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;

            else
                if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BindingNavigatorXuatHang.BindingSource.RemoveCurrent();
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

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiNhanVien();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtGiaBan.Text = "0";
            txtSoLuong.Text = "0";
            txtThanhTien.Text = "0";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (DGVXuatHang.RowCount == 0)
                BindingNavigatorXuatHang.Enabled = true;
            DataRow m_Row = m_XuatHangCtrl.ThemDongMoi();
            m_Row["MaPhieu"] = "XH" + m_QuyDinh.LaySTT(DGVXuatHang.Rows.Count + 1);
            m_Row["MaMH"] = "";
            m_Row["MaKH"] = "";
            m_Row["MaNV"] = "";
            m_Row["NgayXuat"] = DateTime.Today;
            m_Row["SoLuong"] = 0;
            m_Row["GiaBan"] = 0;
            m_Row["ThanhTien"] = 0;
            m_Row["MaLoaiGiaoDich"] = "";
            m_Row["MaLoaiTien"] = "";
            m_XuatHangCtrl.ThemMoi(m_Row);
            BindingNavigatorXuatHang.BindingSource.MoveLast();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtGiaBan.Text != "" && txtSoLuong.Text != "" && txtThanhTien.Text != "" && cmbTenMH.SelectedValue != null && cmbTenKH.SelectedValue != null && cmbTenNV.SelectedValue != null && dtNgayXuat.Value != null && cmbLoaiTienGui.SelectedValue != null && cmbLoaiGiaoDich.SelectedValue != null)
            {
                m_XuatHangCtrl.LuuXuatHang(txtMaPhieu.Text, cmbTenMH.SelectedValue.ToString(), cmbTenKH.SelectedValue.ToString(), cmbTenNV.SelectedValue.ToString(), Convert.ToInt64(txtSoLuong.Text), Convert.ToInt64(txtGiaBan.Text), Convert.ToInt64(txtThanhTien.Text), dtNgayXuat.Value, cmbLoaiTienGui.SelectedValue.ToString(), cmbLoaiGiaoDich.SelectedValue.ToString());
                m_XuatHangCtrl.HienThi(DGVXuatHang, BindingNavigatorXuatHang, txtMaPhieu, dtNgayXuat, txtSoLuong, txtGiaBan, txtThanhTien, cmbTenMH, cmbTenKH, cmbTenNV, cmbLoaiGiaoDich, cmbLoaiTienGui);
                MessageBoxEx.Show("Đã lưu thành công!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBoxEx.Show("Phải nhập đầy đủ dữ liệu để thêm đơn xuất hàng", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            m_XuatHangCtrl.SuaXuatHang(txtMaPhieu.Text, cmbTenMH.SelectedValue.ToString(), cmbTenKH.SelectedValue.ToString(), cmbTenNV.SelectedValue.ToString(), Convert.ToInt64(txtSoLuong.Text), Convert.ToInt64(txtGiaBan.Text), Convert.ToInt64(txtThanhTien.Text), dtNgayXuat.Value, cmbLoaiTienGui.SelectedValue.ToString(), cmbLoaiGiaoDich.SelectedValue.ToString());
            m_XuatHangCtrl.HienThi(DGVXuatHang, BindingNavigatorXuatHang, txtMaPhieu, dtNgayXuat, txtSoLuong, txtGiaBan, txtThanhTien, cmbTenMH, cmbTenKH, cmbTenNV, cmbLoaiGiaoDich, cmbLoaiTienGui);
            MessageBoxEx.Show("Đã sửa thành công!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBoxEx.Show("Bạn có chắc chắn xóa đặt hàng này không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                m_XuatHangCtrl.XoaXuatHang(txtMaPhieu.Text, cmbTenMH.SelectedValue.ToString(), cmbTenKH.SelectedValue.ToString(), cmbTenNV.SelectedValue.ToString());
                m_XuatHangCtrl.HienThi(DGVXuatHang, BindingNavigatorXuatHang, txtMaPhieu, dtNgayXuat, txtSoLuong, txtGiaBan, txtThanhTien, cmbTenMH, cmbTenKH, cmbTenNV, cmbLoaiGiaoDich, cmbLoaiTienGui);
            }
        }
        
    }
}