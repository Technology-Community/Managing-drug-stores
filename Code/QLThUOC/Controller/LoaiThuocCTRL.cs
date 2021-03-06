using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QLThUOC.DataLayer;

namespace QLThUOC.Controller
{
    public class LoaiThuocCTRL
    {
        LoaiThuocDATA data = new LoaiThuocDATA();
        public void HienThiLoaiThuoc(TextBox txtMaLoaiThuoc,TextBox txtTenLoai,TextBox txtHeSoLuong,DataGridView dg, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = data.LayDSLoaiThuoc();
            dg.DataSource = bs;
            bn.BindingSource = bs;
            txtMaLoaiThuoc.DataBindings.Add("Text", bs, "MALOAITHUOC");
            txtTenLoai.DataBindings.Add("Text", bs, "TENLOAI");
            txtHeSoLuong.DataBindings.Add("Text", bs, "HESOLUONG");
            
        }
        public DataGridViewComboBoxColumn LoadComboBoxMaLoaiThuoc()
        {
            DataGridViewComboBoxColumn cb = new DataGridViewComboBoxColumn();
            cb.DataSource = data.LayDSLoaiThuoc();
            cb.DisplayMember = "TENLOAI";
            cb.ValueMember = "MALOAITHUOC";
            cb.HeaderText = "Tên loại thuốc";
            cb.DataPropertyName = "MALOAITHUOC";
            return cb;
        }
        public void HienThiComboBoxMaLoaiThuoc(ComboBox cmd)
        {
            LoaiThuocDATA dataLoaiThuoc = new LoaiThuocDATA();
            cmd.DataSource = dataLoaiThuoc.LayDSLoaiThuoc();
            cmd.DisplayMember = "TENLOAI";
            cmd.ValueMember = "MALOAITHUOC";
            cmd.SelectedValue = "MALOAITHUOC";
        }
        public void Update()
        {
            data.Update();
        }
    }
}
