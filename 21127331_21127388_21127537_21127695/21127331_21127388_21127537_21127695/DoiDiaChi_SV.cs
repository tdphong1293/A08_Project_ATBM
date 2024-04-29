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
    public partial class DoiDiaChi_SV : Form
    {
        private OracleConnection conn = FormDangNhap.conn;

        public DoiDiaChi_SV()
        {
            InitializeComponent();
            doidiachi_sv();
        }
        private void doidiachi_sv()
        {
            try
            {
                string query = "select * from OLS_ADMIN.SINHVIEN";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            label2.Text = reader["DCHI"].ToString();
                        }
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = $"update OLS_ADMIN.SINHVIEN set DCHI = :diachi";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    try
                    {
                        cmd.Parameters.Add(":diachi", OracleDbType.NVarchar2, textBox1.Text, ParameterDirection.Input);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thay đổi địa chỉ thành công");
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
