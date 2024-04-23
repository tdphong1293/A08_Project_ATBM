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
    public partial class ThongTinCaNhan : Form
    {
        private OracleConnection conn = FormDangNhap.conn;
        public ThongTinCaNhan()
        {
            InitializeComponent();
            thongtin_giaovu();
        }

        private void thongtin_giaovu()
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
                            manv.Text = reader["MANV"].ToString();
                            hoten.Text = reader["HOTEN"].ToString();
                            phai.Text = reader["PHAI"].ToString();
                            ngaysinh.Text = DateTime.Parse(reader["NGSINH"].ToString()).ToString("dd/MM/yyyy");
                            phucap.Text = reader["PHUCAP"].ToString();
                            sdt.Text = reader["DT"].ToString();
                            vaitro.Text = reader["VAITRO"].ToString();
                            madv.Text = reader["MADV"].ToString();
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

        }

        private void ThongTinCaNhan_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DoiSDT doisdt = new DoiSDT();
            doisdt.ShowDialog();
        }
    }
}
