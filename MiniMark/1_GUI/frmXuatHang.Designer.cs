namespace MiniMark
{
    partial class frmXuatHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXuatHang));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGVXuatHang = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.BindingNavigatorXuatHang = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorRefreshItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCloseItem = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtMaPhieu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.cmbTenNV = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnThemNV = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtThanhTien = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnThemMH = new DevComponents.DotNetBar.ButtonX();
            this.cmbTenMH = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnDel = new DevComponents.DotNetBar.ButtonX();
            this.btnSua = new DevComponents.DotNetBar.ButtonX();
            this.btnLuu = new DevComponents.DotNetBar.ButtonX();
            this.btnNhapLai = new DevComponents.DotNetBar.ButtonX();
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
            this.btnHuy = new DevComponents.DotNetBar.ButtonX();
            this.dtNgayXuat = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.cmbLoaiTienGui = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.cmbLoaiGiaoDich = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtGiaBan = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtSoLuong = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.cmbTenKH = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnThemKH = new DevComponents.DotNetBar.ButtonX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.colMaPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenMH = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colTenKH = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colTenNV = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colNgayXuat = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoaiTien = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colLoaiGD = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVXuatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigatorXuatHang)).BeginInit();
            this.BindingNavigatorXuatHang.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayXuat)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVXuatHang
            // 
            this.DGVXuatHang.AllowUserToAddRows = false;
            this.DGVXuatHang.AllowUserToDeleteRows = false;
            this.DGVXuatHang.AllowUserToResizeRows = false;
            this.DGVXuatHang.BackgroundColor = System.Drawing.Color.Silver;
            this.DGVXuatHang.ColumnHeadersHeight = 34;
            this.DGVXuatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVXuatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaPhieu,
            this.colTenMH,
            this.colTenKH,
            this.colTenNV,
            this.colNgayXuat,
            this.colSoLuong,
            this.colGiaBan,
            this.colThanhTien,
            this.colLoaiTien,
            this.colLoaiGD});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVXuatHang.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGVXuatHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVXuatHang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.DGVXuatHang.Location = new System.Drawing.Point(0, 308);
            this.DGVXuatHang.Name = "DGVXuatHang";
            this.DGVXuatHang.ReadOnly = true;
            this.DGVXuatHang.RowHeadersWidth = 62;
            this.DGVXuatHang.Size = new System.Drawing.Size(1502, 366);
            this.DGVXuatHang.TabIndex = 18;
            // 
            // BindingNavigatorXuatHang
            // 
            this.BindingNavigatorXuatHang.AddNewItem = null;
            this.BindingNavigatorXuatHang.AutoSize = false;
            this.BindingNavigatorXuatHang.CountItem = this.bindingNavigatorCountItem;
            this.BindingNavigatorXuatHang.DeleteItem = null;
            this.BindingNavigatorXuatHang.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.BindingNavigatorXuatHang.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorRefreshItem,
            this.bindingNavigatorDeleteItem,
            this.bindingNavigatorSaveItem,
            this.bindingNavigatorCloseItem});
            this.BindingNavigatorXuatHang.Location = new System.Drawing.Point(0, 243);
            this.BindingNavigatorXuatHang.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.BindingNavigatorXuatHang.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.BindingNavigatorXuatHang.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.BindingNavigatorXuatHang.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.BindingNavigatorXuatHang.Name = "BindingNavigatorXuatHang";
            this.BindingNavigatorXuatHang.PositionItem = this.bindingNavigatorPositionItem;
            this.BindingNavigatorXuatHang.Size = new System.Drawing.Size(1502, 65);
            this.BindingNavigatorXuatHang.TabIndex = 17;
            this.BindingNavigatorXuatHang.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
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
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = global::MiniMark.Properties.Resources.Add;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(60, 60);
            this.bindingNavigatorAddNewItem.Text = "Thêm";
            this.bindingNavigatorAddNewItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorRefreshItem
            // 
            this.bindingNavigatorRefreshItem.Image = global::MiniMark.Properties.Resources.Refresh;
            this.bindingNavigatorRefreshItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorRefreshItem.Name = "bindingNavigatorRefreshItem";
            this.bindingNavigatorRefreshItem.Size = new System.Drawing.Size(86, 60);
            this.bindingNavigatorRefreshItem.Text = "Làm tươi";
            this.bindingNavigatorRefreshItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bindingNavigatorRefreshItem.Click += new System.EventHandler(this.bindingNavigatorRefreshItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(47, 60);
            this.bindingNavigatorDeleteItem.Text = "Xóa";
            this.bindingNavigatorDeleteItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorSaveItem
            // 
            this.bindingNavigatorSaveItem.Image = global::MiniMark.Properties.Resources.save;
            this.bindingNavigatorSaveItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorSaveItem.Name = "bindingNavigatorSaveItem";
            this.bindingNavigatorSaveItem.Size = new System.Drawing.Size(45, 60);
            this.bindingNavigatorSaveItem.Text = "Lưu";
            this.bindingNavigatorSaveItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bindingNavigatorSaveItem.Click += new System.EventHandler(this.bindingNavigatorSaveItem_Click);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.groupPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1502, 243);
            this.panel2.TabIndex = 16;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.txtMaPhieu);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.cmbTenNV);
            this.groupPanel1.Controls.Add(this.btnThemNV);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.txtThanhTien);
            this.groupPanel1.Controls.Add(this.btnThemMH);
            this.groupPanel1.Controls.Add(this.cmbTenMH);
            this.groupPanel1.Controls.Add(this.btnDel);
            this.groupPanel1.Controls.Add(this.btnSua);
            this.groupPanel1.Controls.Add(this.btnLuu);
            this.groupPanel1.Controls.Add(this.btnNhapLai);
            this.groupPanel1.Controls.Add(this.btnThem);
            this.groupPanel1.Controls.Add(this.btnHuy);
            this.groupPanel1.Controls.Add(this.dtNgayXuat);
            this.groupPanel1.Controls.Add(this.labelX12);
            this.groupPanel1.Controls.Add(this.labelX8);
            this.groupPanel1.Controls.Add(this.cmbLoaiTienGui);
            this.groupPanel1.Controls.Add(this.labelX7);
            this.groupPanel1.Controls.Add(this.labelX11);
            this.groupPanel1.Controls.Add(this.cmbLoaiGiaoDich);
            this.groupPanel1.Controls.Add(this.txtGiaBan);
            this.groupPanel1.Controls.Add(this.txtSoLuong);
            this.groupPanel1.Controls.Add(this.labelX6);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.cmbTenKH);
            this.groupPanel1.Controls.Add(this.btnThemKH);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Location = new System.Drawing.Point(3, 10);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1222, 233);
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
            this.groupPanel1.TabIndex = 2;
            this.groupPanel1.Text = "Khung nhập liệu";
            // 
            // txtMaPhieu
            // 
            // 
            // 
            // 
            this.txtMaPhieu.Border.Class = "TextBoxBorder";
            this.txtMaPhieu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaPhieu.Location = new System.Drawing.Point(135, 8);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.ReadOnly = true;
            this.txtMaPhieu.Size = new System.Drawing.Size(85, 36);
            this.txtMaPhieu.TabIndex = 95;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(15, 8);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(61, 20);
            this.labelX2.TabIndex = 94;
            this.labelX2.Text = "Mã Phiếu:";
            // 
            // cmbTenNV
            // 
            this.cmbTenNV.DisplayMember = "Text";
            this.cmbTenNV.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTenNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTenNV.FormattingEnabled = true;
            this.cmbTenNV.ItemHeight = 14;
            this.cmbTenNV.Location = new System.Drawing.Point(135, 119);
            this.cmbTenNV.Name = "cmbTenNV";
            this.cmbTenNV.Size = new System.Drawing.Size(297, 20);
            this.cmbTenNV.TabIndex = 92;
            // 
            // btnThemNV
            // 
            this.btnThemNV.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemNV.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemNV.Image = global::MiniMark.Properties.Resources.Add;
            this.btnThemNV.Location = new System.Drawing.Point(438, 119);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(26, 20);
            this.btnThemNV.TabIndex = 93;
            this.btnThemNV.Tooltip = "Thêm nhà cung cấp";
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(15, 119);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(114, 20);
            this.labelX1.TabIndex = 91;
            this.labelX1.Text = "Nhân Viên Xuất Hàng:";
            // 
            // txtThanhTien
            // 
            // 
            // 
            // 
            this.txtThanhTien.Border.Class = "TextBoxBorder";
            this.txtThanhTien.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtThanhTien.Location = new System.Drawing.Point(642, 81);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(146, 36);
            this.txtThanhTien.TabIndex = 87;
            // 
            // btnThemMH
            // 
            this.btnThemMH.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemMH.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemMH.Image = global::MiniMark.Properties.Resources.Add;
            this.btnThemMH.Location = new System.Drawing.Point(438, 46);
            this.btnThemMH.Name = "btnThemMH";
            this.btnThemMH.Size = new System.Drawing.Size(26, 20);
            this.btnThemMH.TabIndex = 85;
            this.btnThemMH.Tooltip = "Thêm nhà cung cấp";
            this.btnThemMH.Click += new System.EventHandler(this.btnThemMH_Click);
            // 
            // cmbTenMH
            // 
            this.cmbTenMH.DisplayMember = "Text";
            this.cmbTenMH.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTenMH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTenMH.FormattingEnabled = true;
            this.cmbTenMH.ItemHeight = 14;
            this.cmbTenMH.Location = new System.Drawing.Point(135, 46);
            this.cmbTenMH.Name = "cmbTenMH";
            this.cmbTenMH.Size = new System.Drawing.Size(297, 20);
            this.cmbTenMH.TabIndex = 82;
            // 
            // btnDel
            // 
            this.btnDel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Image = global::MiniMark.Properties.Resources.Delete;
            this.btnDel.Location = new System.Drawing.Point(779, 163);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(77, 28);
            this.btnDel.TabIndex = 81;
            this.btnDel.Text = "Xóa";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSua
            // 
            this.btnSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = global::MiniMark.Properties.Resources.NhapLai;
            this.btnSua.Location = new System.Drawing.Point(610, 163);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(77, 28);
            this.btnSua.TabIndex = 80;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLuu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = global::MiniMark.Properties.Resources.save;
            this.btnLuu.Location = new System.Drawing.Point(438, 163);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(72, 28);
            this.btnLuu.TabIndex = 79;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNhapLai.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNhapLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapLai.Image = global::MiniMark.Properties.Resources.NhapLai;
            this.btnNhapLai.Location = new System.Drawing.Point(256, 163);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(77, 28);
            this.btnNhapLai.TabIndex = 77;
            this.btnNhapLai.Text = "Nhập lại";
            this.btnNhapLai.Click += new System.EventHandler(this.btnNhapLai_Click);
            // 
            // btnThem
            // 
            this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::MiniMark.Properties.Resources.Add;
            this.btnThem.Location = new System.Drawing.Point(86, 163);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(72, 28);
            this.btnThem.TabIndex = 76;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Image = global::MiniMark.Properties.Resources.Exit;
            this.btnHuy.Location = new System.Drawing.Point(973, 163);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(82, 28);
            this.btnHuy.TabIndex = 78;
            this.btnHuy.Text = "Thoát";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // dtNgayXuat
            // 
            // 
            // 
            // 
            this.dtNgayXuat.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtNgayXuat.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtNgayXuat.ButtonDropDown.Visible = true;
            this.dtNgayXuat.CustomFormat = "dd/MM/yyyy";
            this.dtNgayXuat.IsPopupCalendarOpen = false;
            this.dtNgayXuat.Location = new System.Drawing.Point(957, 79);
            // 
            // 
            // 
            this.dtNgayXuat.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtNgayXuat.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtNgayXuat.MonthCalendar.BackgroundStyle.Class = "";
            this.dtNgayXuat.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtNgayXuat.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtNgayXuat.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtNgayXuat.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtNgayXuat.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtNgayXuat.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtNgayXuat.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtNgayXuat.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtNgayXuat.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dtNgayXuat.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtNgayXuat.MonthCalendar.DisplayMonth = new System.DateTime(2007, 3, 1, 0, 0, 0, 0);
            this.dtNgayXuat.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtNgayXuat.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtNgayXuat.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtNgayXuat.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtNgayXuat.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtNgayXuat.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dtNgayXuat.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtNgayXuat.MonthCalendar.TodayButtonVisible = true;
            this.dtNgayXuat.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtNgayXuat.Name = "dtNgayXuat";
            this.dtNgayXuat.Size = new System.Drawing.Size(188, 26);
            this.dtNgayXuat.TabIndex = 7;
            // 
            // labelX12
            // 
            this.labelX12.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.Class = "";
            this.labelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX12.Location = new System.Drawing.Point(860, 80);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(91, 19);
            this.labelX12.TabIndex = 0;
            this.labelX12.Text = "Ngày Xuất Hàng:";
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.Class = "";
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(573, 80);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(63, 20);
            this.labelX8.TabIndex = 0;
            this.labelX8.Text = "Thành Tiền:";
            // 
            // cmbLoaiTienGui
            // 
            this.cmbLoaiTienGui.DisplayMember = "Text";
            this.cmbLoaiTienGui.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLoaiTienGui.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbLoaiTienGui.FormattingEnabled = true;
            this.cmbLoaiTienGui.ItemHeight = 14;
            this.cmbLoaiTienGui.Location = new System.Drawing.Point(644, 119);
            this.cmbLoaiTienGui.Name = "cmbLoaiTienGui";
            this.cmbLoaiTienGui.Size = new System.Drawing.Size(144, 20);
            this.cmbLoaiTienGui.TabIndex = 8;
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.Class = "";
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(575, 119);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(56, 20);
            this.labelX7.TabIndex = 0;
            this.labelX7.Text = "Loại Tiền:";
            // 
            // labelX11
            // 
            this.labelX11.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.Class = "";
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Location = new System.Drawing.Point(860, 119);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(80, 20);
            this.labelX11.TabIndex = 0;
            this.labelX11.Text = "Loại Giao Dịch:";
            // 
            // cmbLoaiGiaoDich
            // 
            this.cmbLoaiGiaoDich.DisplayMember = "Text";
            this.cmbLoaiGiaoDich.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLoaiGiaoDich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbLoaiGiaoDich.FormattingEnabled = true;
            this.cmbLoaiGiaoDich.ItemHeight = 14;
            this.cmbLoaiGiaoDich.Location = new System.Drawing.Point(957, 119);
            this.cmbLoaiGiaoDich.Name = "cmbLoaiGiaoDich";
            this.cmbLoaiGiaoDich.Size = new System.Drawing.Size(188, 20);
            this.cmbLoaiGiaoDich.TabIndex = 9;
            // 
            // txtGiaBan
            // 
            // 
            // 
            // 
            this.txtGiaBan.Border.Class = "TextBoxBorder";
            this.txtGiaBan.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtGiaBan.Location = new System.Drawing.Point(957, 45);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(188, 36);
            this.txtGiaBan.TabIndex = 4;
            // 
            // txtSoLuong
            // 
            // 
            // 
            // 
            this.txtSoLuong.Border.Class = "TextBoxBorder";
            this.txtSoLuong.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSoLuong.Location = new System.Drawing.Point(643, 46);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(145, 36);
            this.txtSoLuong.TabIndex = 3;
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(860, 45);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(48, 20);
            this.labelX6.TabIndex = 0;
            this.labelX6.Text = "Giá Bán:";
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(575, 46);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(61, 20);
            this.labelX5.TabIndex = 0;
            this.labelX5.Text = "Số Lượng:";
            // 
            // cmbTenKH
            // 
            this.cmbTenKH.DisplayMember = "Text";
            this.cmbTenKH.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTenKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTenKH.FormattingEnabled = true;
            this.cmbTenKH.ItemHeight = 14;
            this.cmbTenKH.Location = new System.Drawing.Point(135, 81);
            this.cmbTenKH.Name = "cmbTenKH";
            this.cmbTenKH.Size = new System.Drawing.Size(297, 20);
            this.cmbTenKH.TabIndex = 6;
            // 
            // btnThemKH
            // 
            this.btnThemKH.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemKH.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemKH.Image = global::MiniMark.Properties.Resources.Add;
            this.btnThemKH.Location = new System.Drawing.Point(438, 81);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(26, 20);
            this.btnThemKH.TabIndex = 60;
            this.btnThemKH.Tooltip = "Thêm nhà cung cấp";
            this.btnThemKH.Click += new System.EventHandler(this.btnThemKH_Click);
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(15, 81);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(105, 20);
            this.labelX4.TabIndex = 0;
            this.labelX4.Text = "Tên Khách Hàng:";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(15, 46);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(82, 23);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "Tên Mặt Hàng:";
            // 
            // colMaPhieu
            // 
            this.colMaPhieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colMaPhieu.DataPropertyName = "MaPhieu";
            this.colMaPhieu.HeaderText = "Mã Phiếu";
            this.colMaPhieu.MinimumWidth = 100;
            this.colMaPhieu.Name = "colMaPhieu";
            this.colMaPhieu.ReadOnly = true;
            this.colMaPhieu.Width = 111;
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
            this.colTenMH.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colTenKH
            // 
            this.colTenKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colTenKH.DataPropertyName = "TenKH";
            this.colTenKH.HeaderText = "Tên khách hàng";
            this.colTenKH.MinimumWidth = 150;
            this.colTenKH.Name = "colTenKH";
            this.colTenKH.ReadOnly = true;
            this.colTenKH.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTenKH.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colTenKH.Width = 159;
            // 
            // colTenNV
            // 
            this.colTenNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colTenNV.DataPropertyName = "TenNV";
            this.colTenNV.HeaderText = "Nhân viên xuất hàng";
            this.colTenNV.MinimumWidth = 150;
            this.colTenNV.Name = "colTenNV";
            this.colTenNV.ReadOnly = true;
            this.colTenNV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTenNV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colTenNV.Width = 189;
            // 
            // colNgayXuat
            // 
            this.colNgayXuat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            // 
            // 
            // 
            this.colNgayXuat.BackgroundStyle.Class = "DataGridViewDateTimeBorder";
            this.colNgayXuat.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colNgayXuat.DataPropertyName = "NgayXuat";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "dd/mm/yy";
            this.colNgayXuat.DefaultCellStyle = dataGridViewCellStyle1;
            this.colNgayXuat.HeaderText = "Ngày xuất hàng";
            this.colNgayXuat.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Center;
            this.colNgayXuat.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.colNgayXuat.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.colNgayXuat.MinimumWidth = 120;
            // 
            // 
            // 
            this.colNgayXuat.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.colNgayXuat.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.colNgayXuat.MonthCalendar.BackgroundStyle.Class = "";
            this.colNgayXuat.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.colNgayXuat.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.colNgayXuat.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colNgayXuat.MonthCalendar.DisplayMonth = new System.DateTime(2011, 11, 1, 0, 0, 0, 0);
            this.colNgayXuat.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.colNgayXuat.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.colNgayXuat.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.colNgayXuat.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colNgayXuat.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.colNgayXuat.Name = "colNgayXuat";
            this.colNgayXuat.ReadOnly = true;
            this.colNgayXuat.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colNgayXuat.Width = 155;
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
            // colGiaBan
            // 
            this.colGiaBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colGiaBan.DataPropertyName = "GiaBan";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colGiaBan.DefaultCellStyle = dataGridViewCellStyle3;
            this.colGiaBan.HeaderText = "Giá bán";
            this.colGiaBan.MinimumWidth = 100;
            this.colGiaBan.Name = "colGiaBan";
            this.colGiaBan.ReadOnly = true;
            this.colGiaBan.Width = 101;
            // 
            // colThanhTien
            // 
            this.colThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colThanhTien.DefaultCellStyle = dataGridViewCellStyle4;
            this.colThanhTien.HeaderText = "Thành Tiền";
            this.colThanhTien.MinimumWidth = 130;
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.ReadOnly = true;
            this.colThanhTien.Width = 130;
            // 
            // colLoaiTien
            // 
            this.colLoaiTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colLoaiTien.DataPropertyName = "MaLoaiTien";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colLoaiTien.DefaultCellStyle = dataGridViewCellStyle5;
            this.colLoaiTien.HeaderText = "Loại tiền";
            this.colLoaiTien.MinimumWidth = 80;
            this.colLoaiTien.Name = "colLoaiTien";
            this.colLoaiTien.ReadOnly = true;
            this.colLoaiTien.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colLoaiTien.Width = 80;
            // 
            // colLoaiGD
            // 
            this.colLoaiGD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colLoaiGD.DataPropertyName = "MaLoaiGiaoDich";
            this.colLoaiGD.HeaderText = "Loại giao dịch";
            this.colLoaiGD.MinimumWidth = 120;
            this.colLoaiGD.Name = "colLoaiGD";
            this.colLoaiGD.ReadOnly = true;
            this.colLoaiGD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colLoaiGD.Width = 120;
            // 
            // frmXuatHang
            // 
            this.ClientSize = new System.Drawing.Size(1502, 674);
            this.Controls.Add(this.DGVXuatHang);
            this.Controls.Add(this.BindingNavigatorXuatHang);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmXuatHang";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XUẤT HÀNG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmXuatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVXuatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigatorXuatHang)).EndInit();
            this.BindingNavigatorXuatHang.ResumeLayout(false);
            this.BindingNavigatorXuatHang.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayXuat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX DGVXuatHang;
        private System.Windows.Forms.BindingNavigator BindingNavigatorXuatHang;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorRefreshItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorCloseItem;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtThanhTien;
        private DevComponents.DotNetBar.ButtonX btnThemMH;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbTenMH;
        private DevComponents.DotNetBar.ButtonX btnDel;
        private DevComponents.DotNetBar.ButtonX btnSua;
        private DevComponents.DotNetBar.ButtonX btnLuu;
        private DevComponents.DotNetBar.ButtonX btnNhapLai;
        private DevComponents.DotNetBar.ButtonX btnThem;
        private DevComponents.DotNetBar.ButtonX btnHuy;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtNgayXuat;
        private DevComponents.DotNetBar.LabelX labelX12;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbLoaiTienGui;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbLoaiGiaoDich;
        private DevComponents.DotNetBar.Controls.TextBoxX txtGiaBan;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSoLuong;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbTenKH;
        private DevComponents.DotNetBar.ButtonX btnThemKH;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbTenNV;
        private DevComponents.DotNetBar.ButtonX btnThemNV;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaPhieu;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPhieu;
        private System.Windows.Forms.DataGridViewComboBoxColumn colTenMH;
        private System.Windows.Forms.DataGridViewComboBoxColumn colTenKH;
        private System.Windows.Forms.DataGridViewComboBoxColumn colTenNV;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn colNgayXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
        private System.Windows.Forms.DataGridViewComboBoxColumn colLoaiTien;
        private System.Windows.Forms.DataGridViewComboBoxColumn colLoaiGD;
    }
}