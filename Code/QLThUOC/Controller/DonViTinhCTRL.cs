using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QLThUOC.DataLayer;

namespace QLThUOC.Controller
{
    public class DonViTinhCTRL
    {
        DonViTinhDATA data = new DonViTinhDATA();
        public void HienThiDonViTinh(TextBox txtMaDVT,TextBox txtTenDVT,DataGridView dg, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = data.LayDSDonViTinh();
            dg.DataSource = bs;
            bn.BindingSource = bs;
            txtMaDVT.DataBindings.Add("Text", bs, "MADVT");
            txtTenDVT.DataBindings.Add("Text", bs, "TENDVT");
        }
        public DataGridViewComboBoxColumn LoadComboBoxMaDVT()
        {
            DataGridViewComboBoxColumn cb = new DataGridViewComboBoxColumn();
            cb.DataSource = data.LayDSDonViTinh();
            cb.DisplayMember = "TENDVT";
            cb.ValueMember = "MADVT";
            cb.HeaderText = "Tên đơn vị tính";
            cb.DataPropertyName = "MADVT";
            return cb;
        }
        public void HienThiComboBoxMaDVT(ComboBox cmd)
        {
            DonViTinhDATA dataDVT = new DonViTinhDATA();
            cmd.DataSource = dataDVT.LayDSDonViTinh();
            cmd.DisplayMember = "TENDVT";
            cmd.ValueMember = "MADVT";
            cmd.SelectedValue = "MADVT";
        }
        public void Update()
        {
            data.Update();
        }
    }
}
