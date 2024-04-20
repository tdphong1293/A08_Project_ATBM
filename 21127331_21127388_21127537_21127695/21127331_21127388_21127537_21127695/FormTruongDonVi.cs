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
        public FormTruongDonVi()
        {
            InitializeComponent();
        }

        private void btn_thongbao_Click(object sender, EventArgs e)
        {
            dtgv_thongbao.Visible = !dtgv_thongbao.Visible;
            pn_thongbao.Visible = !pn_thongbao.Visible;
        }
    }
}
