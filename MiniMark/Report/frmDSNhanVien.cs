using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//using Microsoft.Reporting.WinForms;
using DevComponents.DotNetBar;
using MiniMark.General;
using MiniMark.Bussiness;
using MiniMark.Controller;


namespace MiniMark.Report
{
    public partial class frmDSNhanVien : Office2007Form
    {
        public frmDSNhanVien()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmDSNhanVien_Load(object sender, EventArgs e)
        {
            //IList<NhanVienInfo> ketqua = NhanVienCtrl.LayDsNhanVien();

            //IList<ReportParameter> param = new List<ReportParameter>();
            //param.Add(new ReportParameter("Ngay", DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year));
            //this.ReportViewerDanhSachNhanVien.LocalReport.SetParameters(param);

            //this.NhanVienInfoBindingSource.DataSource = ketqua;

            //this.ReportViewerDanhSachNhanVien.RefreshReport();
        }
    }
}