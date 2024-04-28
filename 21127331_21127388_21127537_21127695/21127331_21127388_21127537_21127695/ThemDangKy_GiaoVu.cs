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
using static _21127331_21127388_21127537_21127695.GiaoVu;

namespace _21127331_21127388_21127537_21127695
{
    public partial class ThemDangKy_GiaoVu : Form
    {
        private OracleConnection conn = FormDangNhap.conn;
        private Timer searchdk;
        public ThemDangKy_GiaoVu()
        {
            InitializeComponent();

            dtgdk.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            searchdk = new Timer();
            searchdk.Interval = 1000;
            searchdk.Tick += searchdk_Tick;
            SearchAndFill_DangKy("");
        }

        public void SetData(DataToPass data)
        {
            txt_dk_masv.Text = data.Masv;
            txt_dk_mact.Text = data.Mact;
        }

        private void dtgdk_mahp_TextChanged(object sender, EventArgs e)
        {
            searchdk.Stop();
            searchdk.Start();
        }

        private void searchdk_Tick(object sender, EventArgs e)
        {
            searchdk.Stop();
            SearchAndFill_DangKy(dtgdk_mahp.Text);
        }

        private void dtgdk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgdk.Rows[e.RowIndex];
                txt_dk_magv.Text = row.Cells["MAGV"].Value.ToString();
                txt_dk_mahp.Text = row.Cells["MAHP"].Value.ToString();
                txt_dk_hki.Text = row.Cells["HK"].Value.ToString();
                txt_dk_nam.Text = row.Cells["NAM"].Value.ToString();
                txt_dk_mact.Text = row.Cells["MACT"].Value.ToString();
            }
            else
            {
                txt_dk_magv.Text = "";
                txt_dk_mahp.Text = "";
                txt_dk_hki.Text = "";
                txt_dk_nam.Text = "";
            }
        }

        private void SearchAndFill_DangKy(string mahp)
        {
            int thang = DateTime.Now.Month;
            int hki;
            if (1 <= thang && thang <= 4) hki = 1;
            else if (5 <= thang && thang <= 8) hki = 2;
            else hki = 3;
            try
            {
                string query = $"select * from OLS_ADMIN.uv_GiaoVu_PHANCONG where HK={hki} AND MACT= '{GiaoVu.mact}'";

                if (!string.IsNullOrEmpty(mahp) && mahp.Trim() != "")
                {
                    query += " AND MAHP= :mahp";
                }

                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    if (!string.IsNullOrEmpty(mahp) && mahp.Trim() != "")
                    {
                        cmd.Parameters.Add(":mahp", mahp);
                    }

                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dtgdk.DataSource = dataTable;
                        dtgdk.Columns["MAGV"].Visible = false;
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int hki = Int32.Parse(txt_dk_hki.Text);
            int nam = Int32.Parse(txt_dk_nam.Text);
            string query = $"insert into OLS_ADMIN.uv_GiaoVu_DANGKY values ('{txt_dk_masv.Text}', '{txt_dk_magv.Text}', '{txt_dk_mahp.Text}', {hki}, {nam}, '{txt_dk_mact.Text}', NULL, NULL, NULL, NULL)";
            using (OracleCommand cmd = new OracleCommand(query, conn))
            {
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm đăng ký thành công");
                    this.Close();
                    SearchAndFill_DangKy("");
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
