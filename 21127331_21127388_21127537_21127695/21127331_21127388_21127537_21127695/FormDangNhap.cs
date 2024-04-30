using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
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
        //public static int res_AuditProcedure;
        public static bool flag_audit;
        public static bool flag_fgaaudit;


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
                    using (OracleCommand command = conn.CreateCommand())
                    {
                        // Thiết lập loại command là stored procedure
                        try
                        {

                            command.CommandText = "sp_GetStateAudit";
                            command.CommandType = System.Data.CommandType.StoredProcedure;

                            // Tạo parameter cho stored procedure
                            OracleParameter p_result = new OracleParameter();
                            p_result.ParameterName = "p_result";
                            p_result.OracleDbType = OracleDbType.Int32;
                            p_result.Direction = System.Data.ParameterDirection.Output;
                            command.Parameters.Add(p_result);


                            // Thực thi command
                            command.ExecuteNonQuery();


                            // Lấy giá trị trả về từ parameter
                            if (p_result.Value.ToString() == "1")
                                flag_audit = true;
                            else if (p_result.Value.ToString() == "0")
                                flag_audit = false;

                        }
                        catch (Exception ex)
                        {
                            // Xử lý các ngoại lệ nếu có
                            Console.WriteLine("Error executing stored procedure: " + ex.Message);
                        }
                    }

                    if (cb_dangnhap_vaitro.Text == "Sinh viên")
                    {
                        SinhVien sv = new SinhVien();
                        this.Hide();
                        sv.ShowDialog();
                        this.Close();
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
                        GiaoVu giaovu = new GiaoVu();
                        this.Hide();
                        giaovu.ShowDialog();
                        this.Close();
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
                        TRUONGKHOA tRUONGKHOA = new TRUONGKHOA(usernameUser);
                        this.Hide();
                        tRUONGKHOA.ShowDialog();
                        this.Close();
                    }
                    else if (cb_dangnhap_vaitro.Text == "AUDIT_ADMIN")
                    {
                        FormAuditAdmin formAuditAdmin = new FormAuditAdmin(flag_audit, flag_fgaaudit);
                        this.Hide();
                        formAuditAdmin.ShowDialog();
                        this.Close();
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
