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
            tb_dangnhap_taikhoan.Text = "TRGDV0001";
            tb_dangnhap_matkhau.Text = "TRGDV0001";
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
                else if (cb_dangnhap_vaitro.Text == "ADMIN")
                {
                    conn.ConnectionString = @"DATA SOURCE = localhost:1521/XE; USER ID=" + usernameUser + ";PASSWORD=" + passUser;
                    conn.Open();
                    FormQuanLy formQuanLy = new FormQuanLy();
                    this.Hide();
                    formQuanLy.ShowDialog();
                    this.Close();
                }
                else
                {
                    conn.ConnectionString = @"DATA SOURCE = localhost:1521/A08_ProjectATBM; USER ID=" + usernameUser + ";PASSWORD=" + passUser;
                    conn.Open();
                    if (cb_dangnhap_vaitro.Text == "Sinh viên")
                    {
                        conn.Close();
                    }
                    else if (cb_dangnhap_vaitro.Text == "Nhân viên cơ bản")
                    {
                        FormNhanVienCoBan formNhanVienCoBan = new FormNhanVienCoBan();
                        this.Hide();
                        formNhanVienCoBan.ShowDialog();
                        this.Close();
                    }
                    else if (cb_dangnhap_vaitro.Text == "Giảng viên")
                    {
                        FormGiangVien formGiangVien = new FormGiangVien();
                        this.Hide();
                        formGiangVien.ShowDialog();
                        this.Close();
                    }
                    else if (cb_dangnhap_vaitro.Text == "Giáo vụ")
                    {
                        conn.Close();
                    }
                    else if (cb_dangnhap_vaitro.Text == "Trưởng đơn vị")
                    {
                        FormTruongDonVi formTruongDonVi = new FormTruongDonVi();
                        this.Hide();
                        formTruongDonVi.ShowDialog();
                        this.Close();
                    }
                    else if (cb_dangnhap_vaitro.Text == "Trưởng khoa")
                    {
                        conn.Close();
                    }
                    else
                    {
                        MessageBox.Show("Không tồn tại vai trò " + cb_dangnhap_vaitro.Text);
                        conn.Close();
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
                return;
            }
        }
    }
}
