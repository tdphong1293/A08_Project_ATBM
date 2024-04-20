using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21127331_21127388_21127537_21127695
{
    public partial class FormTruongDonVi : Form
    {
        private string SDT_cu = "";
        public FormTruongDonVi()
        {
            InitializeComponent();
            SDT_cu = txt_dienthoai_tdv.Text;
        }

        private void btn_thongbao_Click(object sender, EventArgs e)
        {
            dtgv_thongbao.Visible = !dtgv_thongbao.Visible;
            pn_thongbao.Visible = !pn_thongbao.Visible;
        }

        private void btn_ChinhSua_Click(object sender, EventArgs e)
        {
            btn_ChinhSua.Visible = false;
            txt_dienthoai_tdv.Enabled = true;
            txt_dienthoai_tdv.ReadOnly = false;
            txt_dienthoai_tdv.SelectionStart = 0;
            txt_dienthoai_tdv.SelectionLength = txt_dienthoai_tdv.Text.Length;
            txt_dienthoai_tdv.Focus();
            btn_luudt.Visible = true;
            btn_QuayVe.Visible = true;
        }

        private void btn_QuayVe_Click(object sender, EventArgs e)
        {
            btn_ChinhSua.Visible = true;
            txt_dienthoai_tdv.Text = SDT_cu;
            txt_dienthoai_tdv.Enabled = false;
            txt_dienthoai_tdv.ReadOnly = true;
            btn_luudt.Visible = false;
            btn_QuayVe.Visible = false;
        }

        private void btn_luudt_Click(object sender, EventArgs e)
        {
            btn_ChinhSua.Visible = true;
            SDT_cu = txt_dienthoai_tdv.Text;
            txt_dienthoai_tdv.Enabled = false;
            txt_dienthoai_tdv.ReadOnly = true;
            btn_luudt.Visible = false;
            btn_QuayVe.Visible = false;
        }

        
    }
}
