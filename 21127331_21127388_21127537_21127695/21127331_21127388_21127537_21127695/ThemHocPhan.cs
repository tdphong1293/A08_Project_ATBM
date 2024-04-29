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
    public partial class ThemHocPhan : Form
    {
        private OracleConnection conn = FormDangNhap.conn;
        public ThemHocPhan()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int sotc = int.Parse(txt_sotc_hp.Text);
            int stlt = int.Parse(txt_stlt_hp.Text);
            int stth = int.Parse(txt_stth_hp.Text);
            int svtd = int.Parse(txt_svtd_hp.Text);

            try
            {
                string query = $"select * from OLS_ADMIN.uv_NhanVienCoBan_HOCPHAN where MAHP = '{txt_mahp.Text}'";
                using (OracleCommand command = new OracleCommand(query, conn))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            MessageBox.Show("MAHP đã tồn tại");
                        }
                        else if (sotc < 0)
                        {
                            MessageBox.Show("Số tín chỉ phải lớn hơn 0");
                        }
                        else if (stlt < 0)
                        {
                            MessageBox.Show("Số tiết lí thuyết phải lớn hơn 0");
                        }
                        else if (stth < 0)
                        {
                            MessageBox.Show("Số tiết thực hành phải lớn hơn 0");
                        }
                        else if (svtd < 0)
                        {
                            MessageBox.Show("Số sinh viên tối đa phải lớn hơn 0");
                        }
                        else
                        {
                            string query1 = $"insert into OLS_ADMIN.uv_NhanVienCoBan_HOCPHAN (MAHP, TENHP, SOTC, STLT, STTH, SOSVTD, MADV) values" +
                                $" ('{txt_mahp.Text}', :tenhp," +
                                $" {sotc}, {stlt}," +
                                $" {stth}, {svtd}," +
                                $" '{txt_madv_hp.Text}')";
                            using (OracleTransaction trans = conn.BeginTransaction())
                            {
                                using (OracleCommand cmd = new OracleCommand(query1, conn))
                                {
                                    try
                                    {
                                        cmd.Transaction = trans;
                                        cmd.Parameters.Add(":tenhp", OracleDbType.NVarchar2, txt_tenhp.Text, ParameterDirection.Input);
                                        cmd.ExecuteNonQuery();
                                        trans.Commit();
                                        MessageBox.Show("Thêm học phần thành công");
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
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
