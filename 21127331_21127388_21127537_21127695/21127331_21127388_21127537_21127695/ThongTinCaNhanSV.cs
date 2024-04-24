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
    public partial class ThongTinCaNhanSV : Form
    {
        private OracleConnection conn = FormDangNhap.conn;
        public ThongTinCaNhanSV()
        {
            InitializeComponent();
            thongtin_sinhvien();

        }
        private void thongtin_sinhvien()
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
                            mssv.Text = reader["MASV"].ToString();
                            hoten.Text = reader["HOTEN"].ToString();
                            phai.Text = reader["PHAI"].ToString();
                            ngaysinh.Text = DateTime.Parse(reader["NGSINH"].ToString()).ToString("dd/MM/yyyy");
                            diachi.Text = reader["DCHI"].ToString();
                            sdt.Text = reader["DT"].ToString();
                            mact.Text = reader["MACT"].ToString();
                            manganh.Text = reader["MANGANH"].ToString();
                            sotctl.Text = reader["SOTCTL"].ToString();
                            dtbtl.Text = reader["DTBTL"].ToString();
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
            DoiSDT_SV doisdt_sv = new DoiSDT_SV();
            doisdt_sv.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DoiDiaChi_SV doidiachi_sv = new DoiDiaChi_SV();
            doidiachi_sv.ShowDialog();
        }
    }
}
