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
    public partial class FormTaoUser : Form
    {
        public static OracleConnection curConn = FormDangNhap.conn;
        private FormQuanLy lastForm;
        public FormTaoUser(FormQuanLy lastForm)
        {
            InitializeComponent();
            this.lastForm = lastForm;
        }

        private void btn_taouser_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_taouser_xacnhan_Click(object sender, EventArgs e)
        {
            if (tb_taouser_username.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng điền TÊN USER !");
                return;
            }
            if (tb_taouser_password.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập MẬT KHẨU !");
                return;
            }


            try
            {
                using (OracleCommand cmd = new OracleCommand())
                {
                    cmd.Connection = curConn;

                    cmd.CommandText = "alter session set \"_oracle_script\" = true";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = $"create user {tb_taouser_username.Text} identified by {tb_taouser_password.Text}";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "alter session set \"_oracle_script\" = false";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = $"grant create session to {tb_taouser_username.Text}";
                    cmd.ExecuteNonQuery();


                }

                MessageBox.Show("Tạo user thành công");
                lastForm.SearchAndReloadUser("");
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
