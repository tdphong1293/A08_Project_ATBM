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
    public partial class FormTaoRole : Form
    {
        public static OracleConnection curConn = FormDangNhap.conn;
        private FormQuanLy lastForm;
        public FormTaoRole(FormQuanLy lastForm)
        {
            InitializeComponent();
            this.lastForm = lastForm;
        }

        private void btn_taorole_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_taorole_xacnhan_Click(object sender, EventArgs e)
        {
            if (tb_taorole_rolename.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng điền TÊN ROLE !");
                return;
            }

            try
            {
                using (OracleCommand cmd = new OracleCommand())
                {
                    cmd.Connection = curConn;
                    cmd.CommandText = "alter session set \"_oracle_script\" = true";
                    cmd.ExecuteNonQuery();

                    if (string.IsNullOrEmpty(tb_taorole_password.Text))
                    {
                        cmd.CommandText = $"create role {tb_taorole_rolename.Text}";
                    }
                    else
                    {
                        cmd.CommandText = $"create role {tb_taorole_rolename.Text} identified by {tb_taorole_password.Text}";
                    }
                    
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "alter session set \"_oracle_script\" = false";
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Tạo role thành công");
                lastForm.SearchAndReloadRole("");
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
