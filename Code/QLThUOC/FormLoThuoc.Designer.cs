namespace QLThUOC
{
    partial class FormLoThuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoThuoc));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ItemThem = new XPExplorerBar.TaskItem();
            this.ItemThoat = new XPExplorerBar.TaskItem();
            this.ItemXoa = new XPExplorerBar.TaskItem();
            this.ItemLuu = new XPExplorerBar.TaskItem();
            this.DateTimePickerNgayHetHan = new System.Windows.Forms.DateTimePicker();
            this.DateTimePickerNgaySanXuat = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColMaLo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTenLo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNgaySanXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNgayHetHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.TBoxThanhTien = new System.Windows.Forms.TextBox();
            this.CBoxMaThuoc = new System.Windows.Forms.ComboBox();
            this.TBoxSoLuong = new System.Windows.Forms.TextBox();
            this.TBoxTenLo = new System.Windows.Forms.TextBox();
            this.TBoxMaLo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.DateTimePickerNgayHetHan);
            this.groupBox1.Controls.Add(this.DateTimePickerNgaySanXuat);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.TBoxThanhTien);
            this.groupBox1.Controls.Add(this.CBoxMaThuoc);
            this.groupBox1.Controls.Add(this.TBoxSoLuong);
            this.groupBox1.Controls.Add(this.TBoxTenLo);
            this.groupBox1.Controls.Add(this.TBoxMaLo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 478);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lô thuốc";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ItemThem);
            this.groupBox3.Controls.Add(this.ItemThoat);
            this.groupBox3.Controls.Add(this.ItemXoa);
            this.groupBox3.Controls.Add(this.ItemLuu);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(15, 200);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(288, 51);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // ItemThem
            // 
            this.ItemThem.BackColor = System.Drawing.Color.Transparent;
            this.ItemThem.Image = ((System.Drawing.Image)(resources.GetObject("ItemThem.Image")));
            this.ItemThem.Location = new System.Drawing.Point(134, 21);
            this.ItemThem.Name = "ItemThem";
            this.ItemThem.Size = new System.Drawing.Size(78, 16);
            this.ItemThem.TabIndex = 3;
            this.ItemThem.Text = "Thêm";
            this.ItemThem.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ItemThem.UseVisualStyleBackColor = false;
            // 
            // ItemThoat
            // 
            this.ItemThoat.BackColor = System.Drawing.Color.Transparent;
            this.ItemThoat.Image = ((System.Drawing.Image)(resources.GetObject("ItemThoat.Image")));
            this.ItemThoat.Location = new System.Drawing.Point(209, 21);
            this.ItemThoat.Name = "ItemThoat";
            this.ItemThoat.Size = new System.Drawing.Size(69, 16);
            this.ItemThoat.TabIndex = 2;
            this.ItemThoat.Text = "Thoát";
            this.ItemThoat.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ItemThoat.UseVisualStyleBackColor = false;
            this.ItemThoat.Click += new System.EventHandler(this.ItemThoat_Click);
            // 
            // ItemXoa
            // 
            this.ItemXoa.BackColor = System.Drawing.Color.Transparent;
            this.ItemXoa.Image = ((System.Drawing.Image)(resources.GetObject("ItemXoa.Image")));
            this.ItemXoa.Location = new System.Drawing.Point(71, 21);
            this.ItemXoa.Name = "ItemXoa";
            this.ItemXoa.Size = new System.Drawing.Size(58, 16);
            this.ItemXoa.TabIndex = 1;
            this.ItemXoa.Text = "Xóa";
            this.ItemXoa.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ItemXoa.UseVisualStyleBackColor = false;
            // 
            // ItemLuu
            // 
            this.ItemLuu.BackColor = System.Drawing.Color.Transparent;
            this.ItemLuu.Image = ((System.Drawing.Image)(resources.GetObject("ItemLuu.Image")));
            this.ItemLuu.Location = new System.Drawing.Point(6, 21);
            this.ItemLuu.Name = "ItemLuu";
            this.ItemLuu.Size = new System.Drawing.Size(59, 16);
            this.ItemLuu.TabIndex = 0;
            this.ItemLuu.Text = "Lưu";
            this.ItemLuu.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ItemLuu.UseVisualStyleBackColor = false;
            // 
            // DateTimePickerNgayHetHan
            // 
            this.DateTimePickerNgayHetHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePickerNgayHetHan.Location = new System.Drawing.Point(124, 100);
            this.DateTimePickerNgayHetHan.Name = "DateTimePickerNgayHetHan";
            this.DateTimePickerNgayHetHan.Size = new System.Drawing.Size(219, 20);
            this.DateTimePickerNgayHetHan.TabIndex = 17;
            // 
            // DateTimePickerNgaySanXuat
            // 
            this.DateTimePickerNgaySanXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePickerNgaySanXuat.Location = new System.Drawing.Point(124, 74);
            this.DateTimePickerNgaySanXuat.Name = "DateTimePickerNgaySanXuat";
            this.DateTimePickerNgaySanXuat.Size = new System.Drawing.Size(219, 20);
            this.DateTimePickerNgaySanXuat.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(15, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(559, 218);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dữ liệu";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.bindingNavigator1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 197);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColMaLo,
            this.ColTenLo,
            this.ColNgaySanXuat,
            this.ColNgayHetHan,
            this.ColSoLuong,
            this.ColThanhTien});
            this.dataGridView1.Location = new System.Drawing.Point(3, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(547, 166);
            this.dataGridView1.TabIndex = 1;
            // 
            // ColMaLo
            // 
            this.ColMaLo.DataPropertyName = "MALO";
            this.ColMaLo.HeaderText = "Mã lô";
            this.ColMaLo.Name = "ColMaLo";
            // 
            // ColTenLo
            // 
            this.ColTenLo.DataPropertyName = "TENLO";
            this.ColTenLo.HeaderText = "Tên lô";
            this.ColTenLo.Name = "ColTenLo";
            // 
            // ColNgaySanXuat
            // 
            this.ColNgaySanXuat.DataPropertyName = "NGAYSX";
            this.ColNgaySanXuat.HeaderText = "Ngày sản xuất";
            this.ColNgaySanXuat.Name = "ColNgaySanXuat";
            // 
            // ColNgayHetHan
            // 
            this.ColNgayHetHan.DataPropertyName = "NGAYHH";
            this.ColNgayHetHan.HeaderText = "Ngày hết hạn";
            this.ColNgayHetHan.Name = "ColNgayHetHan";
            // 
            // ColSoLuong
            // 
            this.ColSoLuong.DataPropertyName = "SOLUONG";
            this.ColSoLuong.HeaderText = "Số lượng";
            this.ColSoLuong.Name = "ColSoLuong";
            // 
            // ColThanhTien
            // 
            this.ColThanhTien.DataPropertyName = "THANHTIEN";
            this.ColThanhTien.HeaderText = "Thành tiền";
            this.ColThanhTien.Name = "ColThanhTien";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem,
            this.toolStripButtonSave});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(553, 25);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.Image = global::QLThUOC.Properties.Resources.save;
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(50, 22);
            this.toolStripButtonSave.Text = "save";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // TBoxThanhTien
            // 
            this.TBoxThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBoxThanhTien.Location = new System.Drawing.Point(124, 174);
            this.TBoxThanhTien.Name = "TBoxThanhTien";
            this.TBoxThanhTien.Size = new System.Drawing.Size(109, 20);
            this.TBoxThanhTien.TabIndex = 13;
            // 
            // CBoxMaThuoc
            // 
            this.CBoxMaThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxMaThuoc.FormattingEnabled = true;
            this.CBoxMaThuoc.Location = new System.Drawing.Point(124, 147);
            this.CBoxMaThuoc.Name = "CBoxMaThuoc";
            this.CBoxMaThuoc.Size = new System.Drawing.Size(82, 21);
            this.CBoxMaThuoc.TabIndex = 12;
            // 
            // TBoxSoLuong
            // 
            this.TBoxSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBoxSoLuong.Location = new System.Drawing.Point(124, 122);
            this.TBoxSoLuong.Name = "TBoxSoLuong";
            this.TBoxSoLuong.Size = new System.Drawing.Size(55, 20);
            this.TBoxSoLuong.TabIndex = 11;
            // 
            // TBoxTenLo
            // 
            this.TBoxTenLo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBoxTenLo.Location = new System.Drawing.Point(124, 45);
            this.TBoxTenLo.Name = "TBoxTenLo";
            this.TBoxTenLo.Size = new System.Drawing.Size(362, 20);
            this.TBoxTenLo.TabIndex = 8;
            // 
            // TBoxMaLo
            // 
            this.TBoxMaLo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBoxMaLo.Location = new System.Drawing.Point(124, 18);
            this.TBoxMaLo.Name = "TBoxMaLo";
            this.TBoxMaLo.Size = new System.Drawing.Size(88, 20);
            this.TBoxMaLo.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Thành tiền:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mã thuốc:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số lượng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày hết hạn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày sản xuất: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên lô:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã lô:";
            // 
            // FormLoThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 478);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormLoThuoc";
            this.Text = "FormLoThuoc";
            this.Load += new System.EventHandler(this.FormLoThuoc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBoxTenLo;
        private System.Windows.Forms.TextBox TBoxMaLo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TBoxThanhTien;
        private System.Windows.Forms.ComboBox CBoxMaThuoc;
        private System.Windows.Forms.TextBox TBoxSoLuong;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaLo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTenLo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNgaySanXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNgayHetHan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColThanhTien;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.DateTimePicker DateTimePickerNgayHetHan;
        private System.Windows.Forms.DateTimePicker DateTimePickerNgaySanXuat;
        private System.Windows.Forms.GroupBox groupBox3;
        private XPExplorerBar.TaskItem ItemThem;
        private XPExplorerBar.TaskItem ItemThoat;
        private XPExplorerBar.TaskItem ItemXoa;
        private XPExplorerBar.TaskItem ItemLuu;
    }
}