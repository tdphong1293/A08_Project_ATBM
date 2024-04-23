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
    public partial class DoiSDT : Form
    {
        private OracleConnection conn = FormDangNhap.conn;
        public DoiSDT()
        {
            InitializeComponent();
            doisdt();
        }

        private void doisdt()
        {
            try
            {
                string query = "select * from OLS_ADMIN.uv_NhanVienCoBan_NHANSU";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            label2.Text = reader["DT"].ToString();
                        }
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = $"update OLS_ADMIN.uv_NhanVienCoBan_NHANSU set DT = '{textBox1.Text}'";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thay đổi số điện thoại thành công");
                        this.Hide();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
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
