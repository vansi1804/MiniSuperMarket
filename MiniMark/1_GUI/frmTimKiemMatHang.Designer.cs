namespace MiniMark
{
    partial class frmTimKiemMatHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimKiemMatHang));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGVMatHang = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.BindingNavigatorMatHang = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorCloseItem = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnSearch = new DevComponents.DotNetBar.ButtonX();
            this.cbTenMH = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cbMaMH = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.txtTimKiem = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.colMaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNCC = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colNgayNhap = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoaiTien = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colLoaiGD = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigatorMatHang)).BeginInit();
            this.BindingNavigatorMatHang.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVMatHang
            // 
            this.DGVMatHang.AllowUserToAddRows = false;
            this.DGVMatHang.AllowUserToDeleteRows = false;
            this.DGVMatHang.AllowUserToResizeRows = false;
            this.DGVMatHang.BackgroundColor = System.Drawing.Color.Silver;
            this.DGVMatHang.ColumnHeadersHeight = 34;
            this.DGVMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVMatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaMH,
            this.colTenMH,
            this.colMaNCC,
            this.colTenNCC,
            this.colNgayNhap,
            this.colSoLuong,
            this.colDonGia,
            this.colGiaBan,
            this.colLoaiTien,
            this.colLoaiGD});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVMatHang.DefaultCellStyle = dataGridViewCellStyle5;
            this.DGVMatHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVMatHang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.DGVMatHang.Location = new System.Drawing.Point(0, 412);
            this.DGVMatHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DGVMatHang.Name = "DGVMatHang";
            this.DGVMatHang.ReadOnly = true;
            this.DGVMatHang.RowHeadersWidth = 62;
            this.DGVMatHang.Size = new System.Drawing.Size(1424, 218);
            this.DGVMatHang.TabIndex = 15;
            // 
            // BindingNavigatorMatHang
            // 
            this.BindingNavigatorMatHang.AddNewItem = null;
            this.BindingNavigatorMatHang.AutoSize = false;
            this.BindingNavigatorMatHang.CountItem = this.bindingNavigatorCountItem;
            this.BindingNavigatorMatHang.DeleteItem = null;
            this.BindingNavigatorMatHang.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.BindingNavigatorMatHang.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorCloseItem,
            this.btnRefresh});
            this.BindingNavigatorMatHang.Location = new System.Drawing.Point(0, 347);
            this.BindingNavigatorMatHang.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.BindingNavigatorMatHang.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.BindingNavigatorMatHang.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.BindingNavigatorMatHang.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.BindingNavigatorMatHang.Name = "BindingNavigatorMatHang";
            this.BindingNavigatorMatHang.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.BindingNavigatorMatHang.PositionItem = this.bindingNavigatorPositionItem;
            this.BindingNavigatorMatHang.Size = new System.Drawing.Size(1424, 65);
            this.BindingNavigatorMatHang.TabIndex = 14;
            this.BindingNavigatorMatHang.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 60);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 60);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 60);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 65);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(73, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 65);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 60);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 60);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 65);
            // 
            // bindingNavigatorCloseItem
            // 
            this.bindingNavigatorCloseItem.Image = global::MiniMark.Properties.Resources.Exit;
            this.bindingNavigatorCloseItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorCloseItem.Name = "bindingNavigatorCloseItem";
            this.bindingNavigatorCloseItem.Size = new System.Drawing.Size(61, 60);
            this.bindingNavigatorCloseItem.Text = "Thoát";
            this.bindingNavigatorCloseItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bindingNavigatorCloseItem.Click += new System.EventHandler(this.bindingNavigatorCloseItem_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::MiniMark.Properties.Resources.Refresh;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(85, 60);
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1424, 347);
            this.panel2.TabIndex = 13;
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.btnSearch);
            this.groupPanel2.Controls.Add(this.cbTenMH);
            this.groupPanel2.Controls.Add(this.cbMaMH);
            this.groupPanel2.Controls.Add(this.txtTimKiem);
            this.groupPanel2.Controls.Add(this.labelX9);
            this.groupPanel2.Location = new System.Drawing.Point(4, 9);
            this.groupPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(1660, 358);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.Class = "";
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.Class = "";
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.Class = "";
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 3;
            this.groupPanel2.Text = "Tìm kiếm thông tin";
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = global::MiniMark.Properties.Resources.Search;
            this.btnSearch.Location = new System.Drawing.Point(1155, 255);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(172, 46);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbTenMH
            // 
            this.cbTenMH.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.cbTenMH.BackgroundStyle.Class = "";
            this.cbTenMH.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbTenMH.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.cbTenMH.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTenMH.Location = new System.Drawing.Point(486, 185);
            this.cbTenMH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbTenMH.Name = "cbTenMH";
            this.cbTenMH.Size = new System.Drawing.Size(392, 38);
            this.cbTenMH.TabIndex = 10;
            this.cbTenMH.Text = "Tìm theo tên mặt hàng";
            // 
            // cbMaMH
            // 
            this.cbMaMH.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.cbMaMH.BackgroundStyle.Class = "";
            this.cbMaMH.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbMaMH.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.cbMaMH.Checked = true;
            this.cbMaMH.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMaMH.CheckValue = "Y";
            this.cbMaMH.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaMH.Location = new System.Drawing.Point(486, 135);
            this.cbMaMH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbMaMH.Name = "cbMaMH";
            this.cbMaMH.Size = new System.Drawing.Size(363, 40);
            this.cbMaMH.TabIndex = 9;
            this.cbMaMH.Text = "Tìm theo mã mặt hàng";
            // 
            // txtTimKiem
            // 
            // 
            // 
            // 
            this.txtTimKiem.Border.Class = "TextBoxBorder";
            this.txtTimKiem.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTimKiem.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(486, 69);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(630, 42);
            this.txtTimKiem.TabIndex = 7;
            this.txtTimKiem.WatermarkText = "Nhập thông tin cần tìm";
            // 
            // labelX9
            // 
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.Class = "";
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX9.Location = new System.Drawing.Point(162, 5);
            this.labelX9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(267, 35);
            this.labelX9.TabIndex = 8;
            this.labelX9.Text = "Nhập thông tin cần tìm";
            // 
            // colMaMH
            // 
            this.colMaMH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colMaMH.DataPropertyName = "MaMH";
            this.colMaMH.HeaderText = "Mã mặt hàng";
            this.colMaMH.MinimumWidth = 100;
            this.colMaMH.Name = "colMaMH";
            this.colMaMH.ReadOnly = true;
            this.colMaMH.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colMaMH.Width = 138;
            // 
            // colTenMH
            // 
            this.colTenMH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenMH.DataPropertyName = "TenMH";
            this.colTenMH.HeaderText = "Tên mặt hàng";
            this.colTenMH.MinimumWidth = 150;
            this.colTenMH.Name = "colTenMH";
            this.colTenMH.ReadOnly = true;
            this.colTenMH.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colMaNCC
            // 
            this.colMaNCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colMaNCC.DataPropertyName = "MaNCC";
            this.colMaNCC.HeaderText = "Mã nhà cung cấp";
            this.colMaNCC.MinimumWidth = 150;
            this.colMaNCC.Name = "colMaNCC";
            this.colMaNCC.ReadOnly = true;
            this.colMaNCC.Width = 167;
            // 
            // colTenNCC
            // 
            this.colTenNCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colTenNCC.DataPropertyName = "TenNCC";
            this.colTenNCC.HeaderText = "Tên nhà cung cấp";
            this.colTenNCC.MinimumWidth = 150;
            this.colTenNCC.Name = "colTenNCC";
            this.colTenNCC.ReadOnly = true;
            this.colTenNCC.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTenNCC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colTenNCC.Width = 172;
            // 
            // colNgayNhap
            // 
            this.colNgayNhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            // 
            // 
            // 
            this.colNgayNhap.BackgroundStyle.Class = "DataGridViewDateTimeBorder";
            this.colNgayNhap.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colNgayNhap.DataPropertyName = "NgayNhap";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "dd/mm/yy";
            this.colNgayNhap.DefaultCellStyle = dataGridViewCellStyle1;
            this.colNgayNhap.HeaderText = "Ngày nhập hàng";
            this.colNgayNhap.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Center;
            this.colNgayNhap.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.colNgayNhap.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.colNgayNhap.MinimumWidth = 120;
            // 
            // 
            // 
            this.colNgayNhap.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.colNgayNhap.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.colNgayNhap.MonthCalendar.BackgroundStyle.Class = "";
            this.colNgayNhap.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.colNgayNhap.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.colNgayNhap.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colNgayNhap.MonthCalendar.DisplayMonth = new System.DateTime(2011, 11, 1, 0, 0, 0, 0);
            this.colNgayNhap.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.colNgayNhap.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.colNgayNhap.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.colNgayNhap.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colNgayNhap.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.colNgayNhap.Name = "colNgayNhap";
            this.colNgayNhap.ReadOnly = true;
            this.colNgayNhap.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colNgayNhap.Width = 161;
            // 
            // colSoLuong
            // 
            this.colSoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colSoLuong.DataPropertyName = "SoLuong";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colSoLuong.DefaultCellStyle = dataGridViewCellStyle2;
            this.colSoLuong.HeaderText = "Số Lượng";
            this.colSoLuong.MinimumWidth = 80;
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.ReadOnly = true;
            this.colSoLuong.Width = 114;
            // 
            // colDonGia
            // 
            this.colDonGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colDonGia.DataPropertyName = "DonGia";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colDonGia.DefaultCellStyle = dataGridViewCellStyle3;
            this.colDonGia.HeaderText = "Đơn giá";
            this.colDonGia.MinimumWidth = 80;
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.ReadOnly = true;
            // 
            // colGiaBan
            // 
            this.colGiaBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colGiaBan.DataPropertyName = "GiaBan";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colGiaBan.DefaultCellStyle = dataGridViewCellStyle4;
            this.colGiaBan.HeaderText = "Giá bán";
            this.colGiaBan.MinimumWidth = 80;
            this.colGiaBan.Name = "colGiaBan";
            this.colGiaBan.ReadOnly = true;
            this.colGiaBan.Width = 101;
            // 
            // colLoaiTien
            // 
            this.colLoaiTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colLoaiTien.DataPropertyName = "MaLoaiTien";
            this.colLoaiTien.HeaderText = "Loại tiền";
            this.colLoaiTien.MinimumWidth = 80;
            this.colLoaiTien.Name = "colLoaiTien";
            this.colLoaiTien.ReadOnly = true;
            this.colLoaiTien.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colLoaiTien.Width = 105;
            // 
            // colLoaiGD
            // 
            this.colLoaiGD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colLoaiGD.DataPropertyName = "MaLoaiGiaoDich";
            this.colLoaiGD.HeaderText = "Loại giao dịch";
            this.colLoaiGD.MinimumWidth = 120;
            this.colLoaiGD.Name = "colLoaiGD";
            this.colLoaiGD.ReadOnly = true;
            this.colLoaiGD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colLoaiGD.Width = 142;
            // 
            // frmTimKiemMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 630);
            this.Controls.Add(this.DGVMatHang);
            this.Controls.Add(this.BindingNavigatorMatHang);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTimKiemMatHang";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TÌM KIẾM MẶT HÀNG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTimKiemMatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVMatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigatorMatHang)).EndInit();
            this.BindingNavigatorMatHang.ResumeLayout(false);
            this.BindingNavigatorMatHang.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX DGVMatHang;
        private System.Windows.Forms.BindingNavigator BindingNavigatorMatHang;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorCloseItem;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.ButtonX btnSearch;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbTenMH;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbMaMH;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTimKiem;
        private DevComponents.DotNetBar.LabelX labelX9;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNCC;
        private System.Windows.Forms.DataGridViewComboBoxColumn colTenNCC;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn colNgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaBan;
        private System.Windows.Forms.DataGridViewComboBoxColumn colLoaiTien;
        private System.Windows.Forms.DataGridViewComboBoxColumn colLoaiGD;
    }
}