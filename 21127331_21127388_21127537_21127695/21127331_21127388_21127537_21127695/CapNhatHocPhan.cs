using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static _21127331_21127388_21127537_21127695.GiaoVu;

namespace _21127331_21127388_21127537_21127695
{
    public partial class CapNhatHocPhan : Form
    {
        private OracleConnection conn = FormDangNhap.conn;
        public CapNhatHocPhan()
        {
            InitializeComponent();
        }

        public void SetData(DataToPass data)
        {
            txt_mahp.Text = data.Mahp;
            txt_tenhp.Text = data.Tenhp;
            txt_sotc_hp.Text = data.Sotinchihp;
            txt_stlt_hp.Text = data.Sotietlt;
            txt_stth_hp.Text = data.Sotietth;
            txt_svtd_hp.Text = data.Sosv;
            txt_madv_hp.Text = data.Madvhp;

            new_txt_mahp.Text = data.Mahp;
            new_txt_tenhp.Text = data.Tenhp;
            new_txt_sotc_hp.Text = data.Sotinchihp;
            new_txt_stlt_hp.Text = data.Sotietlt;
            new_txt_stth_hp.Text = data.Sotietth;
            new_txt_svtd_hp.Text = data.Sosv;
            new_txt_madv_hp.Text = data.Madvhp;
        }
            
        private void CapNhatHocPhan_Load(object sender, EventArgs e)
        {

        }

        private void lb_svtd_hp_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sotc = int.Parse(new_txt_sotc_hp.Text);
            int stlt = int.Parse(new_txt_stlt_hp.Text);
            int stth = int.Parse(new_txt_stth_hp.Text);
            int svtd = int.Parse(new_txt_svtd_hp.Text);

            try
            {
                string query = $"select * from OLS_ADMIN.uv_NhanVienCoBan_HOCPHAN where MAHP = '{new_txt_mahp.Text}'";
                using (OracleCommand command = new OracleCommand(query, conn))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read() && new_txt_mahp.Text != txt_mahp.Text)
                        {
                            MessageBox.Show("MAHP đã tồn tại");
                        }
                        else if (sotc < 0)
                        {
                            MessageBox.Show("Tín chỉ tích lũy phải lớn hơn 0");
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
                            string query1 = $"update OLS_ADMIN.uv_NhanVienCoBan_HOCPHAN" +
                                $"  set MAHP= '{new_txt_mahp.Text}', TENHP= :tenhp," +
                                $" SOTC= {sotc}, STLT= {stlt}," +
                                $" STTH= {stth}, SOSVTD= {svtd}," +
                                $" MADV= '{new_txt_madv_hp.Text}'" +
                                $" where MAHP= '{txt_mahp.Text}'";
                            Debug.WriteLine(query1);
                            using (OracleTransaction trans = conn.BeginTransaction())
                            {
                                using (OracleCommand cmd = new OracleCommand(query1, conn))
                                {
                                    try
                                    {
                                        cmd.Transaction = trans;
                                        cmd.Parameters.Add(":tenhp", OracleDbType.NVarchar2, new_txt_tenhp.Text, ParameterDirection.Input);
                                        cmd.ExecuteNonQuery();
                                        trans.Commit();
                                        MessageBox.Show("Đổi thông tin học phần thành công");
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
