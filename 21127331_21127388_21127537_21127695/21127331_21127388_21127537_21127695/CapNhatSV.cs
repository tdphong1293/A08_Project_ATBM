using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static _21127331_21127388_21127537_21127695.GiaoVu;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace _21127331_21127388_21127537_21127695
{
    public partial class CapNhatSV : Form
    {
        private OracleConnection conn = FormDangNhap.conn;
        public CapNhatSV()
        {
            InitializeComponent();
        }
        public void SetData(DataToPass data)
        {
            txt_masv.Text = data.Masv;
            txt_hoten_sv.Text = data.Hoten;
            txt_gioitinh_sv.Text = data.Gioitinh;
            txt_ngaysinh_sv.Text = data.Ngaysinh;
            txt_diachi_sv.Text = data.Diachi;
            txt_dienthoai_sv.Text = data.Sdt;
            txt_mact_sv.Text = data.Mact;
            txt_manganh_sv.Text = data.Manganh;
            txt_tctl_sv.Text = data.Sotinchi;
            txt_dtbtl_sv.Text = data.Diemtrungbinh;

            new_txt_masv.Text = data.Masv;
            new_txt_hoten_sv.Text = data.Hoten;
            new_txt_gioitinh_sv.Text = data.Gioitinh;
            new_txt_ngaysinh_sv.Text = data.Ngaysinh;
            new_txt_diachi_sv.Text = data.Diachi;
            new_txt_dienthoai_sv.Text = data.Sdt;
            new_txt_mact_sv.Text = data.Mact;
            new_txt_manganh_sv.Text = data.Manganh;
            new_txt_tctl_sv.Text = data.Sotinchi;
            new_txt_dtbtl_sv.Text = data.Diemtrungbinh;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tctl = int.Parse(new_txt_tctl_sv.Text);
            float dtbtl = float.Parse(new_txt_dtbtl_sv.Text);

            try
            {
                string query = $"select * from OLS_ADMIN.uv_NhanVienCoBan_SINHVIEN where MASV = '{new_txt_masv.Text}'";
                using (OracleCommand command = new OracleCommand(query, conn))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read() && new_txt_masv.Text != txt_masv.Text)
                        {
                            MessageBox.Show("MSSV đã tồn tại");
                        }
                        else if (tctl < 0)
                        {
                            MessageBox.Show("Tín chỉ tích lũy phải lớn hơn 0");
                        }
                        else if (dtbtl < 0)
                        {
                            MessageBox.Show("Điểm trung bình tích lũy phải lớn hơn 0");
                        }
                        else
                        {
                            string query1 = $"update OLS_ADMIN.uv_NhanVienCoBan_SINHVIEN" +
                                $"  set MASV= '{new_txt_masv.Text}', HOTEN= N'{new_txt_hoten_sv.Text}'," +
                                $" PHAI= N'{new_txt_gioitinh_sv.Text}', NGSINH= TO_DATE('{new_txt_ngaysinh_sv.Text}', 'DD-MM-YY')," +
                                $" DCHI= N'{new_txt_diachi_sv.Text}', DT= '{new_txt_dienthoai_sv.Text}'," +
                                $" MACT= '{new_txt_mact_sv.Text}', MANGANH= '{new_txt_manganh_sv.Text}'," +
                                $" SOTCTL= {tctl}, DTBTL= {dtbtl}" +
                                $" where MASV= '{txt_masv.Text}'";
                            using (OracleCommand cmd = new OracleCommand(query1, conn))
                            {
                                try
                                {
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Đổi thông tin sinh viên thành công");
                                    this.Close();
                                }

                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                    return;
                                }
                            }
                        }
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}
