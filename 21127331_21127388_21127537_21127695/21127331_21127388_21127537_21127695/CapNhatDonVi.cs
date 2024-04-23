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
    public partial class CapNhatDonVi : Form
    {
        private OracleConnection conn = FormDangNhap.conn;

        public CapNhatDonVi()
        {
            InitializeComponent();
        }

        public void SetData(DataToPass data)
        {
            txt_madv.Text = data.Madv;
            txt_tendv.Text = data.Tendv;
            txt_truongdv.Text = data.Truongdv;

            new_txt_madv.Text = data.Madv;
            new_txt_tendv.Text = data.Tendv;
            new_txt_truongdv.Text = data.Truongdv;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = $"select * from OLS_ADMIN.uv_NhanVienCoBan_DONVI where MADV = '{new_txt_madv.Text}'";
                using (OracleCommand command = new OracleCommand(query, conn))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read() && new_txt_madv.Text != txt_madv.Text)
                        {
                            MessageBox.Show("MADV đã tồn tại");
                        }
                        else
                        {
                            string query2 = $"update OLS_ADMIN.uv_NhanVienCoBan_DONVI set MADV= '{new_txt_madv.Text}', TENDV= N'{new_txt_tendv.Text}', TRGDV= '{new_txt_truongdv.Text}' where MADV= '{txt_madv.Text}'";
                            Debug.WriteLine(query2);
                            using (OracleCommand cmd = new OracleCommand(query2, conn))
                            {
                                try
                                {
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Đổi thông tin đơn vị thành công");
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
