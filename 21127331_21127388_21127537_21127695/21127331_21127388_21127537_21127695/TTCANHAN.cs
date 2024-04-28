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
    public partial class TTCANHAN : Form
    {
        private OracleConnection conn = FormDangNhap.conn;
        string ID;
        public TTCANHAN(string ID)
        {
            this.ID = ID;
            InitializeComponent();
            Load_thongtincanhan(ID);
            
        }
        private void Load_thongtincanhan(string ID)
        {
            try
            {
                string query = "select * from OLS_ADMIN.uv_NhanVienCoBan_NHANSU where MANV = '"+ID+"'";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            label2.Text = reader["MANV"].ToString();
                            label4.Text = reader["HOTEN"].ToString();
                            label6.Text = reader["PHAI"].ToString();
                            label14.Text = DateTime.Parse(reader["NGSINH"].ToString()).ToString("dd/MM/yyyy");
                            label8.Text = reader["PHUCAP"].ToString();
                            label12.Text = reader["MADV"].ToString();
                            label10.Text = reader["DT"].ToString();
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
            SDT sdt = new SDT(ID);
            sdt.ShowDialog();

        }
    }
}
