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
    public partial class ThemKHMO : Form
    {
        private OracleConnection conn = FormDangNhap.conn;
        public ThemKHMO()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int hki = int.Parse(new_txt_khmo_hki.Text);
            try
            {
                string query = $"select * from OLS_ADMIN.uv_NhanVienCoBan_KHMO where MAHP = '{new_txt_khmo_mahp.Text}' AND HK={hki} AND NAM= '{new_txt_khmo_nam.Text}' AND MACT= '{new_txt_khmo_mact.Text}'";
                using (OracleCommand command = new OracleCommand(query, conn))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            MessageBox.Show("Kế hoạch mở đã tồn tại");
                        }
                        else
                        {
                            string query1 = $"insert into OLS_ADMIN.uv_NhanVienCoBan_KHMO (MAHP, HK, NAM, MACT) values" +
                                $" ('{new_txt_khmo_mahp.Text}', {hki}, '{new_txt_khmo_nam.Text}', '{new_txt_khmo_mact.Text}')";
                            using (OracleCommand cmd = new OracleCommand(query1, conn))
                            {
                                try
                                {
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Thêm kế hoạch mở thành công");
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
