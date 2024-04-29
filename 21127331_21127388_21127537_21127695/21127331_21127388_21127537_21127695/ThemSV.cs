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

namespace _21127331_21127388_21127537_21127695
{
    public partial class ThemSV : Form
    {
        private OracleConnection conn = FormDangNhap.conn;
        public ThemSV()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tctl = int.Parse(txt_tctl_sv.Text);
            float dtbtl = float.Parse(txt_dtbtl_sv.Text);

            try
            {
                string query = $"select * from OLS_ADMIN.uv_NhanVienCoBan_SINHVIEN where MASV = '{txt_masv.Text}'";
                using (OracleCommand command = new OracleCommand(query, conn))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
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
                            string query1 = $"insert into OLS_ADMIN.uv_NhanVienCoBan_SINHVIEN (MASV, HOTEN, PHAI, NGSINH, DCHI, DT, MACT, MANGANH, SOTCTL, DTBTL) values" +
                                $" ('{txt_masv.Text}', :hoten," +
                                $" :gioitinh, TO_DATE('{txt_ngaysinh_sv.Text}', 'DD-MM-YY')," +
                                $" :diachi, '{txt_dienthoai_sv.Text}'," +
                                $" '{txt_mact_sv.Text}', '{txt_manganh_sv.Text}'," +
                                $" {tctl}, {dtbtl})";
                            using (OracleCommand cmd = new OracleCommand(query1, conn))
                            {
                                try
                                {
                                    cmd.Parameters.Add(":hoten", OracleDbType.NVarchar2, txt_hoten_sv.Text, ParameterDirection.Input);
                                    cmd.Parameters.Add(":gioitinh", OracleDbType.NVarchar2, txt_gioitinh_sv.Text, ParameterDirection.Input);
                                    cmd.Parameters.Add(":diachi", OracleDbType.NVarchar2, txt_diachi_sv.Text, ParameterDirection.Input);

                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Thêm sinh viên thành công");
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
