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
    public partial class FormXoaUser : Form
    {
        private FormQuanLy lastForm;
        public static OracleConnection curConn = FormDangNhap.conn;

        public FormXoaUser(FormQuanLy lastForm)
        {
            InitializeComponent();
            this.lastForm = lastForm;
        }

        private void btn_xoauser_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_xoauser_xacnhan_Click(object sender, EventArgs e)
        {
            if (tb_xoauser_username.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng điền TÊN USER !");
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

                        cmd.CommandText = $"drop user {tb_xoauser_username.Text}";
                        cmd.ExecuteNonQuery();

                        cmd.CommandText = "alter session set \"_oracle_script\" = false";
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Xóa user thành công");
                    lastForm.SearchAndReloadUser("");
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
