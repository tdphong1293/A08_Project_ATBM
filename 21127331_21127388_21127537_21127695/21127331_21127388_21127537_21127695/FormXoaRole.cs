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
    public partial class FormXoaRole : Form
    {
        public static OracleConnection curConn = FormDangNhap.conn;
        private FormQuanLy lastForm;

        public FormXoaRole(FormQuanLy lastForm)
        {
            InitializeComponent();
            this.lastForm = lastForm;
        }

        private void btn_xoarole_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_xoarole_xacnhan_Click(object sender, EventArgs e)
        {
            if (tb_xoarole_rolename.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng điền TÊN ROLE !");
                return;
            }


            try
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắc muốn xóa?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    using (OracleCommand cmd = new OracleCommand())
                    {
                        cmd.Connection = curConn;

                        cmd.CommandText = "alter session set \"_oracle_script\" = true";
                        cmd.ExecuteNonQuery();

                        cmd.CommandText = $"drop role {tb_xoarole_rolename.Text}";
                        cmd.ExecuteNonQuery();

                        cmd.CommandText = "alter session set \"_oracle_script\" = false";
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Xóa role thành công");
                    lastForm.SearchAndReloadRole("");
                    this.Close();
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            
        }
    }
}
