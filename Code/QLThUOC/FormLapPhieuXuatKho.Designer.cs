namespace QLThUOC
{
    partial class FormLapPhieuXuatKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLapPhieuXuatKho));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.colSTT = new System.Windows.Forms.ColumnHeader();
            this.colMaPhieuXK = new System.Windows.Forms.ColumnHeader();
            this.colMaKH = new System.Windows.Forms.ColumnHeader();
            this.colMaKho = new System.Windows.Forms.ColumnHeader();
            this.colNgayXuat = new System.Windows.Forms.ColumnHeader();
            this.colMaNV = new System.Windows.Forms.ColumnHeader();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colCTSTT = new System.Windows.Forms.ColumnHeader();
            this.colCTMaPhieu = new System.Windows.Forms.ColumnHeader();
            this.colMaThuoc = new System.Windows.Forms.ColumnHeader();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TBoxCTMaPhieuXK = new System.Windows.Forms.TextBox();
            this.CBoxMaThuoc = new System.Windows.Forms.ComboBox();
            this.ButtonHuyBo = new System.Windows.Forms.Button();
            this.ButtonChon = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ItemThem = new XPExplorerBar.TaskItem();
            this.ItemThoat = new XPExplorerBar.TaskItem();
            this.ItemXoa = new XPExplorerBar.TaskItem();
            this.ItemLuu = new XPExplorerBar.TaskItem();
            this.DateTimePickerNgayXuatKho = new System.Windows.Forms.DateTimePicker();
            this.CBoxMaNV = new System.Windows.Forms.ComboBox();
            this.CBoxMaKho = new System.Windows.Forms.ComboBox();
            this.CBoxMaKH = new System.Windows.Forms.ComboBox();
            this.TBoxMaPhieuXK = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TextBoxSoLuong = new System.Windows.Forms.TextBox();
            this.colSoLuong = new System.Windows.Forms.ColumnHeader();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(788, 578);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu xuất kho";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.listView2);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(9, 354);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(773, 191);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Thông tin phiếu xuất kho";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSTT,
            this.colMaPhieuXK,
            this.colMaKH,
            this.colMaKho,
            this.colNgayXuat,
            this.colMaNV});
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(3, 18);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(767, 170);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // colSTT
            // 
            this.colSTT.Text = "STT";
            this.colSTT.Width = 58;
            // 
            // colMaPhieuXK
            // 
            this.colMaPhieuXK.Text = "Mã phiếu";
            this.colMaPhieuXK.Width = 88;
            // 
            // colMaKH
            // 
            this.colMaKH.Text = "Mã khách hàng";
            this.colMaKH.Width = 129;
            // 
            // colMaKho
            // 
            this.colMaKho.Text = "Mã kho";
            this.colMaKho.Width = 85;
            // 
            // colNgayXuat
            // 
            this.colNgayXuat.Text = "Ngày xuất";
            this.colNgayXuat.Width = 98;
            // 
            // colMaNV
            // 
            this.colMaNV.Text = "Mã nhân viên";
            this.colMaNV.Width = 118;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.listView1);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(6, 188);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(436, 160);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chi tiết xuất kho";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCTSTT,
            this.colCTMaPhieu,
            this.colMaThuoc,
            this.colSoLuong});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(3, 18);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(430, 139);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colCTSTT
            // 
            this.colCTSTT.Text = "STT";
            // 
            // colCTMaPhieu
            // 
            this.colCTMaPhieu.Text = "Mã phiếu";
            this.colCTMaPhieu.Width = 83;
            // 
            // colMaThuoc
            // 
            this.colMaThuoc.Text = "Mã thuốc";
            this.colMaThuoc.Width = 86;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TextBoxSoLuong);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.TBoxCTMaPhieuXK);
            this.groupBox3.Controls.Add(this.CBoxMaThuoc);
            this.groupBox3.Controls.Add(this.ButtonHuyBo);
            this.groupBox3.Controls.Add(this.ButtonChon);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(451, 188);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(325, 160);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết xuất kho";
            // 
            // TBoxCTMaPhieuXK
            // 
            this.TBoxCTMaPhieuXK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBoxCTMaPhieuXK.Location = new System.Drawing.Point(96, 19);
            this.TBoxCTMaPhieuXK.Name = "TBoxCTMaPhieuXK";
            this.TBoxCTMaPhieuXK.Size = new System.Drawing.Size(100, 20);
            this.TBoxCTMaPhieuXK.TabIndex = 21;
            // 
            // CBoxMaThuoc
            // 
            this.CBoxMaThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxMaThuoc.FormattingEnabled = true;
            this.CBoxMaThuoc.Location = new System.Drawing.Point(96, 44);
            this.CBoxMaThuoc.Name = "CBoxMaThuoc";
            this.CBoxMaThuoc.Size = new System.Drawing.Size(87, 21);
            this.CBoxMaThuoc.TabIndex = 3;
            // 
            // ButtonHuyBo
            // 
            this.ButtonHuyBo.Location = new System.Drawing.Point(131, 103);
            this.ButtonHuyBo.Name = "ButtonHuyBo";
            this.ButtonHuyBo.Size = new System.Drawing.Size(75, 23);
            this.ButtonHuyBo.TabIndex = 9;
            this.ButtonHuyBo.Text = "Hủy bỏ";
            this.ButtonHuyBo.UseVisualStyleBackColor = true;
            // 
            // ButtonChon
            // 
            this.ButtonChon.Location = new System.Drawing.Point(50, 103);
            this.ButtonChon.Name = "ButtonChon";
            this.ButtonChon.Size = new System.Drawing.Size(75, 23);
            this.ButtonChon.TabIndex = 8;
            this.ButtonChon.Text = "Chọn";
            this.ButtonChon.UseVisualStyleBackColor = true;
            this.ButtonChon.Click += new System.EventHandler(this.ButtonChon_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Mã thuốc:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã phiếu:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.DateTimePickerNgayXuatKho);
            this.groupBox2.Controls.Add(this.CBoxMaNV);
            this.groupBox2.Controls.Add(this.CBoxMaKho);
            this.groupBox2.Controls.Add(this.CBoxMaKH);
            this.groupBox2.Controls.Add(this.TBoxMaPhieuXK);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(642, 157);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin xuất kho";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ItemThem);
            this.groupBox4.Controls.Add(this.ItemThoat);
            this.groupBox4.Controls.Add(this.ItemXoa);
            this.groupBox4.Controls.Add(this.ItemLuu);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(9, 97);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(288, 51);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chức năng";
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
            this.ItemLuu.Click += new System.EventHandler(this.ItemLuu_Click);
            // 
            // DateTimePickerNgayXuatKho
            // 
            this.DateTimePickerNgayXuatKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePickerNgayXuatKho.Location = new System.Drawing.Point(412, 22);
            this.DateTimePickerNgayXuatKho.Name = "DateTimePickerNgayXuatKho";
            this.DateTimePickerNgayXuatKho.Size = new System.Drawing.Size(219, 20);
            this.DateTimePickerNgayXuatKho.TabIndex = 10;
            // 
            // CBoxMaNV
            // 
            this.CBoxMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxMaNV.FormattingEnabled = true;
            this.CBoxMaNV.Location = new System.Drawing.Point(391, 47);
            this.CBoxMaNV.Name = "CBoxMaNV";
            this.CBoxMaNV.Size = new System.Drawing.Size(87, 21);
            this.CBoxMaNV.TabIndex = 9;
            // 
            // CBoxMaKho
            // 
            this.CBoxMaKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxMaKho.FormattingEnabled = true;
            this.CBoxMaKho.Location = new System.Drawing.Point(125, 70);
            this.CBoxMaKho.Name = "CBoxMaKho";
            this.CBoxMaKho.Size = new System.Drawing.Size(87, 21);
            this.CBoxMaKho.TabIndex = 8;
            // 
            // CBoxMaKH
            // 
            this.CBoxMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxMaKH.FormattingEnabled = true;
            this.CBoxMaKH.Location = new System.Drawing.Point(125, 44);
            this.CBoxMaKH.Name = "CBoxMaKH";
            this.CBoxMaKH.Size = new System.Drawing.Size(87, 21);
            this.CBoxMaKH.TabIndex = 7;
            // 
            // TBoxMaPhieuXK
            // 
            this.TBoxMaPhieuXK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBoxMaPhieuXK.Location = new System.Drawing.Point(125, 19);
            this.TBoxMaPhieuXK.Name = "TBoxMaPhieuXK";
            this.TBoxMaPhieuXK.Size = new System.Drawing.Size(87, 20);
            this.TBoxMaPhieuXK.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(275, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã nhân viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã kho:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày xuất kho:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã khách hàng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "Số lượng:";
            // 
            // TextBoxSoLuong
            // 
            this.TextBoxSoLuong.Location = new System.Drawing.Point(96, 69);
            this.TextBoxSoLuong.Name = "TextBoxSoLuong";
            this.TextBoxSoLuong.Size = new System.Drawing.Size(100, 22);
            this.TextBoxSoLuong.TabIndex = 23;
            // 
            // colSoLuong
            // 
            this.colSoLuong.Text = "Số lượng";
            this.colSoLuong.Width = 97;
            // 
            // FormLapPhieuXuatKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 578);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormLapPhieuXuatKho";
            this.Text = "FormLapPhieuXuatKho";
            this.Load += new System.EventHandler(this.FormLapPhieuXuatKho_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBoxMaNV;
        private System.Windows.Forms.ComboBox CBoxMaKho;
        private System.Windows.Forms.ComboBox CBoxMaKH;
        private System.Windows.Forms.TextBox TBoxMaPhieuXK;
        private System.Windows.Forms.ComboBox CBoxMaThuoc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DateTimePickerNgayXuatKho;
        private System.Windows.Forms.GroupBox groupBox4;
        private XPExplorerBar.TaskItem ItemThem;
        private XPExplorerBar.TaskItem ItemThoat;
        private XPExplorerBar.TaskItem ItemXoa;
        private XPExplorerBar.TaskItem ItemLuu;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button ButtonHuyBo;
        private System.Windows.Forms.Button ButtonChon;
        private System.Windows.Forms.TextBox TBoxCTMaPhieuXK;
        private System.Windows.Forms.ColumnHeader colCTSTT;
        private System.Windows.Forms.ColumnHeader colCTMaPhieu;
        private System.Windows.Forms.ColumnHeader colMaThuoc;
        private System.Windows.Forms.ColumnHeader colSTT;
        private System.Windows.Forms.ColumnHeader colMaPhieuXK;
        private System.Windows.Forms.ColumnHeader colMaKH;
        private System.Windows.Forms.ColumnHeader colMaKho;
        private System.Windows.Forms.ColumnHeader colNgayXuat;
        private System.Windows.Forms.ColumnHeader colMaNV;
        private System.Windows.Forms.ColumnHeader colSoLuong;
        private System.Windows.Forms.TextBox TextBoxSoLuong;
        private System.Windows.Forms.Label label8;
    }
}