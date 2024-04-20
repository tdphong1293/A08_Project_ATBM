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
    public partial class FormNhanVienCoBan : Form
    {
        private bool isShow;
        private string SDT_cu;
        public FormNhanVienCoBan()
        {
            InitializeComponent();
            pn_thongbao.Height = 0;
            thongbaotimer.Interval = 10;
            isShow = false;
            SDT_cu = txt_dienthoai_nv.Text;
        }

        private void btn_thongbao_Click(object sender, EventArgs e)
        {
            isShow = !isShow;
            thongbaotimer.Start();
        }

        private void thongbaotimer_Tick(object sender, EventArgs e)
        {
            if (isShow && pn_thongbao.Height < 350)
            {
                pn_thongbao.Height += 50;
            }
            else if (!isShow && pn_thongbao.Height > 0)
            {
                pn_thongbao.Height -= 50;
            }

            if (pn_thongbao.Height <= 0 || pn_thongbao.Height >= 350)
            {
                thongbaotimer.Stop();
            }
        }

        private void btn_chinhsua_nv_Click(object sender, EventArgs e)
        {
            btn_chinhsua_nv.Visible = false;
            txt_dienthoai_nv.Enabled = true;
            txt_dienthoai_nv.ReadOnly = false;
            txt_dienthoai_nv.TabStop = true;
            txt_dienthoai_nv.SelectionStart = 0;
            txt_dienthoai_nv.SelectionLength = txt_dienthoai_nv.Text.Length;
            txt_dienthoai_nv.Focus();
            btn_luudt_nv.Visible = true;
            btn_quayve_nv.Visible = true;
        }

        private void btn_quayve_nv_Click(object sender, EventArgs e)
        {
            btn_chinhsua_nv.Visible = true;
            SDT_cu = txt_dienthoai_nv.Text;
            txt_dienthoai_nv.Enabled = false;
            txt_dienthoai_nv.ReadOnly = true;
            txt_dienthoai_nv.TabStop = false;
            btn_luudt_nv.Visible = false;
            btn_quayve_nv.Visible = false;
        }

        private void btn_luudt_nv_Click(object sender, EventArgs e)
        {
            btn_chinhsua_nv.Visible = true;
            txt_dienthoai_nv.Text = SDT_cu;
            txt_dienthoai_nv.Enabled = false;
            txt_dienthoai_nv.ReadOnly = true;
            txt_dienthoai_nv.TabStop = false;
            btn_luudt_nv.Visible = false;
            btn_quayve_nv.Visible = false;
        }
    }
}
