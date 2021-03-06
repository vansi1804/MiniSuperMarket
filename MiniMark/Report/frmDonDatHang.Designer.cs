namespace MiniMark.Report
{
    partial class frmDonDatHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
         //   Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DatHangInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnThoat = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnTruyXuat = new DevComponents.DotNetBar.ButtonX();
            this.cmbMaPhieu = new DevComponents.DotNetBar.Controls.ComboBoxEx();
        //    this.ReportViewerDonDatHang = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.DatHangInfoBindingSource)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.btnThoat);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.btnTruyXuat);
            this.groupPanel1.Controls.Add(this.cmbMaPhieu);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(845, 105);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.Class = "";
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.Class = "";
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.Class = "";
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 1;
            this.groupPanel1.Text = "Khung nhập liệu";
            // 
            // btnThoat
            // 
            this.btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = global::MiniMark.Properties.Resources.Exit;
            this.btnThoat.Location = new System.Drawing.Point(422, 27);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(86, 23);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(9, 30);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(67, 20);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "Mã Phiếu : ";
            // 
            // btnTruyXuat
            // 
            this.btnTruyXuat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTruyXuat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTruyXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTruyXuat.Image = global::MiniMark.Properties.Resources.Search;
            this.btnTruyXuat.Location = new System.Drawing.Point(307, 27);
            this.btnTruyXuat.Name = "btnTruyXuat";
            this.btnTruyXuat.Size = new System.Drawing.Size(86, 23);
            this.btnTruyXuat.TabIndex = 1;
            this.btnTruyXuat.Text = "Truy xuất";
            this.btnTruyXuat.Click += new System.EventHandler(this.btnTruyXuat_Click);
            // 
            // cmbMaPhieu
            // 
            this.cmbMaPhieu.DisplayMember = "Text";
            this.cmbMaPhieu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMaPhieu.FormattingEnabled = true;
            this.cmbMaPhieu.ItemHeight = 14;
            this.cmbMaPhieu.Location = new System.Drawing.Point(104, 30);
            this.cmbMaPhieu.Name = "cmbMaPhieu";
            this.cmbMaPhieu.Size = new System.Drawing.Size(168, 20);
            this.cmbMaPhieu.TabIndex = 0;
            // 
            // ReportViewerDonDatHang
            // 
            //this.ReportViewerDonDatHang.Dock = System.Windows.Forms.DockStyle.Fill;
            //reportDataSource1.Name = "DatHangInfo";
            //reportDataSource1.Value = this.DatHangInfoBindingSource;
            //this.ReportViewerDonDatHang.LocalReport.DataSources.Add(reportDataSource1);
            //this.ReportViewerDonDatHang.LocalReport.ReportEmbeddedResource = "MiniMark.Report.rptDonDatHang.rdlc";
            //this.ReportViewerDonDatHang.Location = new System.Drawing.Point(0, 105);
            //this.ReportViewerDonDatHang.Name = "ReportViewerDonDatHang";
            //this.ReportViewerDonDatHang.Size = new System.Drawing.Size(845, 343);
            //this.ReportViewerDonDatHang.TabIndex = 2;
            // 
            // frmDonDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 448);
          //  this.Controls.Add(this.ReportViewerDonDatHang);
            this.Controls.Add(this.groupPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmDonDatHang";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐƠN ĐẶT HÀNG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDonDatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatHangInfoBindingSource)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ButtonX btnThoat;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnTruyXuat;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbMaPhieu;
       // private Microsoft.Reporting.WinForms.ReportViewer ReportViewerDonDatHang;
        private System.Windows.Forms.BindingSource DatHangInfoBindingSource;

    }
}