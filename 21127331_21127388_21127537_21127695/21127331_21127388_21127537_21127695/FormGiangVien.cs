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
    public partial class FormGiangVien : Form
    {
        private bool isShow;
        private string SDT_cu;
        private string diemth, diemqt, diemck, diemtk;
        public FormGiangVien()
        {
            InitializeComponent();
            pn_thongbao.Height = 0;
            thongbaotimer.Interval = 10;
            isShow = false;
            SDT_cu = txt_dienthoai_nv.Text;
            diemth = txt_diemth_dk.Text;
            diemqt = txt_diemqt_dk.Text;
            diemck = txt_diemck_dk.Text;
            diemtk = txt_diemtk_dk.Text;
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

        private void btn_luudiem_dk_Click(object sender, EventArgs e)
        {
            btn_chinhsua_dk.Visible = true;
            diemth = txt_diemth_dk.Text.Trim();
            diemqt = txt_diemqt_dk.Text.Trim();
            diemck = txt_diemck_dk.Text.Trim();
            diemtk = txt_diemtk_dk.Text.Trim();
            txt_diemth_dk.Enabled = false;
            txt_diemqt_dk.Enabled = false;
            txt_diemck_dk.Enabled = false;
            txt_diemtk_dk.Enabled = false;
            txt_diemth_dk.ReadOnly = true;
            txt_diemqt_dk.ReadOnly = true;
            txt_diemck_dk.ReadOnly = true;
            txt_diemtk_dk.ReadOnly = true;
            txt_diemth_dk.TabStop = false;
            txt_diemqt_dk.TabStop = false;
            txt_diemck_dk.TabStop = false;
            txt_diemtk_dk.TabStop = false;
            btn_luudiem_dk.Visible = false;
            btn_quayve_dk.Visible = false;
        }

        private void btn_chinhsua_dk_Click(object sender, EventArgs e)
        {
            btn_chinhsua_dk.Visible = false;
            txt_diemth_dk.Enabled = true;
            txt_diemqt_dk.Enabled = true;
            txt_diemck_dk.Enabled = true;
            txt_diemtk_dk.Enabled = true;
            txt_diemth_dk.ReadOnly = false;
            txt_diemqt_dk.ReadOnly = false;
            txt_diemck_dk.ReadOnly = false;
            txt_diemtk_dk.ReadOnly = false;
            txt_diemth_dk.TabStop = true;
            txt_diemqt_dk.TabStop = true;
            txt_diemck_dk.TabStop = true;
            txt_diemtk_dk.TabStop = true;
            txt_diemth_dk.SelectionStart = 0;
            txt_diemth_dk.SelectionLength = txt_diemth_dk.Text.Length;
            txt_diemth_dk.Focus();
            btn_luudiem_dk.Visible = true;
            btn_quayve_dk.Visible = true;
        }

        private void btn_quayve_dk_Click(object sender, EventArgs e)
        {
            btn_chinhsua_dk.Visible = true;
            txt_diemth_dk.Text = diemth;
            txt_diemqt_dk.Text = diemqt;
            txt_diemck_dk.Text = diemck;
            txt_diemtk_dk.Text = diemtk;
            txt_diemth_dk.Enabled = false;
            txt_diemqt_dk.Enabled = false;
            txt_diemck_dk.Enabled = false;
            txt_diemtk_dk.Enabled = false;
            txt_diemth_dk.ReadOnly = true;
            txt_diemqt_dk.ReadOnly = true;
            txt_diemck_dk.ReadOnly = true;
            txt_diemtk_dk.ReadOnly = true;
            txt_diemth_dk.TabStop = false;
            txt_diemqt_dk.TabStop = false;
            txt_diemck_dk.TabStop = false;
            txt_diemtk_dk.TabStop = false;
            btn_luudiem_dk.Visible = false;
            btn_quayve_dk.Visible = false;
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
