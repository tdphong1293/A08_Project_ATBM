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
            listhocphan();
        }

        void listhocphan()
        {
            try
            {
                string query = "select DISTINCT MAHP from OLS_ADMIN.uv_NhanVienCoban_HOCPHAN";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        new_txt_khmo_mahp.Items.Clear();
                        while (reader.Read())
                        {
                            string mahp = reader["MAHP"].ToString();
                            new_txt_khmo_mahp.Items.Add(mahp);
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
            int hki = int.Parse(new_txt_khmo_hki.Text);
            int nam = int.Parse(new_txt_khmo_nam.Text);
            try
            {
                string query = $"select * from OLS_ADMIN.uv_NhanVienCoBan_KHMO where \"MA HOC PHAN\" = '{new_txt_khmo_mahp.Text}' AND \"HOC KY\"={hki} AND NAM= {nam} AND \"MA CHUONG TRINH\"= '{new_txt_khmo_mact.Text}'";
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
                            string query1 = $"insert into OLS_ADMIN.uv_NhanVienCoBan_KHMO values" +
                                $" ('{new_txt_khmo_mahp.Text}', {hki}, {nam}, '{new_txt_khmo_mact.Text}')";
                            using (OracleTransaction trans = conn.BeginTransaction())
                            {
                                using (OracleCommand cmd = new OracleCommand(query1, conn))
                                {
                                    try
                                    {
                                        cmd.Transaction = trans;
                                        cmd.ExecuteNonQuery();
                                        trans.Commit();
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
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
