using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace _21127331_21127388_21127537_21127695
{
    public partial class FormChinhSuaRole : Form
    {
        public static OracleConnection curConn = FormDangNhap.conn;
        public FormChinhSuaRole()
        {
            InitializeComponent();
        }

        private void btn_chinhsuarole_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_chinhsuarole_xacnhan_Click(object sender, EventArgs e)
        {
            if (tb_chinhsuarole_rolename.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng điền TÊN ROLE !");
                return;
            }

            try
            {
                using (OracleCommand cmd = new OracleCommand())
                {
                    cmd.Connection = curConn;

                    if (string.IsNullOrEmpty(tb_chinhsuarole_password.Text))
                    {
                        cmd.CommandText = $"alter role {tb_chinhsuarole_rolename.Text} not identified";
                    }
                    else
                    {
                        cmd.CommandText = $"alter role {tb_chinhsuarole_rolename.Text} identified by {tb_chinhsuarole_password.Text}";
                    }
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Đổi mật khẩu role thành công");
                this.Close();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
