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
    public partial class ThemDonVi : Form
    {
        private OracleConnection conn = FormDangNhap.conn;
        public ThemDonVi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = $"select * from OLS_ADMIN.uv_NhanVienCoBan_DONVI where MADV = '{txt_madv.Text}'";
                using (OracleCommand command = new OracleCommand(query, conn))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            MessageBox.Show("MADV đã tồn tại");
                        }
                        else
                        {
                            string query1 = $"insert into OLS_ADMIN.uv_NhanVienCoBan_DONVI (MADV, TENDV, TRGDV) values" +
                                $" ('{txt_madv.Text}', :tendv," +
                                $" '{txt_truongdv.Text}')"; 
                            using (OracleCommand cmd = new OracleCommand(query1, conn))
                            {
                                try
                                {
                                    cmd.Parameters.Add(":tendv", OracleDbType.NVarchar2, txt_tendv.Text, ParameterDirection.Input);
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Thêm đơn vị thành công");
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
