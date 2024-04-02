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
using Oracle.ManagedDataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace _21127331_21127388_21127537_21127695
{
    public partial class FormDangNhap : Form
    {
        public static OracleConnection conn = new OracleConnection();
        public static String usernameUser;
        public static String passUser;
        public static String roleUser;
            
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            if (tb_dangnhap_taikhoan.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng điền TÊN ĐĂNG NHẬP !");
                return;
            }
            if (tb_dangnhap_matkhau.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập MẬT KHẨU !");
                return;
            }
            if (cb_dangnhap_vaitro.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn VAI TRÒ !");
                return;
            }

            try
            {
                usernameUser = tb_dangnhap_taikhoan.Text;
                passUser = tb_dangnhap_matkhau.Text;
                roleUser = cb_dangnhap_vaitro.Text;


                if (cb_dangnhap_vaitro.Text == "SYSDBA")
                    conn.ConnectionString = @"DATA SOURCE = localhost:1521/XE;DBA Privilege=SYSDBA; USER ID=" + usernameUser + ";PASSWORD=" + passUser;
                else
                    conn.ConnectionString = @"DATA SOURCE = localhost:1521/XE; USER ID=" + usernameUser + ";PASSWORD=" + passUser;
                
                conn.Open();

                FormQuanLy formQuanLy = new FormQuanLy();
                this.Hide();
                formQuanLy.ShowDialog();
                this.Close();

                //conn.Close();

            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
