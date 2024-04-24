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
    public partial class SinhVien : Form
    {
        private OracleConnection conn = FormDangNhap.conn;
        private Timer searchhp;
        private Timer searchkhmo;
        private Timer searchkqhp;
        public SinhVien()
        {
            InitializeComponent();
            ten_sinhvien();

            dtghp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            searchhp = new Timer();
            searchhp.Interval = 1000;
            searchhp.Tick += searchhp_Tick;
            SearchAndFill_HocPhan("");

            text_khmo_nam.SelectedItem = "2024";
            dtgkhmo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            searchkhmo = new Timer();
            searchkhmo.Interval = 1000;
            searchkhmo.Tick += searchkhmo_Tick;
            SearchAndFill_KHMo("", "");

            kq_hp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            searchkqhp = new Timer();
            searchkqhp.Interval = 1000;
            searchkqhp.Tick += searchkqhp_Tick;
            SearchAndFill_KetQuaHocPhan("");
        }

        private void ten_sinhvien()
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
                            label2.Text = reader["HOTEN"].ToString();
                        }
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ThongTinCaNhanSV ttcnsv = new ThongTinCaNhanSV();
            ttcnsv.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Close();
            this.Hide();
            FormDangNhap formDN = new FormDangNhap();
            formDN.ShowDialog();
            this.Close();
        }

        private void text_hp_TextChanged(object sender, EventArgs e)
        {
            searchhp.Stop();
            searchhp.Start();
        }

        private void searchhp_Tick(object sender, EventArgs e)
        {
            searchhp.Stop();
            SearchAndFill_HocPhan(text_hp.Text);
        }

        private void SearchAndFill_HocPhan(string searchtext)
        {
            try
            {
                string query;
                if (string.IsNullOrEmpty(searchtext))
                    query = "select * from OLS_ADMIN.HOCPHAN";
                else
                    query = "select * from OLS_ADMIN.HOCPHAN where UPPER(TENHP) like UPPER(:unicodetext) or MAHP = :searchtext";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add(":unicodetext", OracleDbType.NVarchar2, "%" + searchtext + "%", ParameterDirection.Input);
                    cmd.Parameters.Add(":searchtext", searchtext);
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dtghp.DataSource = dataTable;
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtghp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtghp.Rows[e.RowIndex];
                txt_mahp.Text = row.Cells["MAHP"].Value.ToString();
                txt_tenhp.Text = row.Cells["TENHP"].Value.ToString();
                txt_sotc_hp.Text = row.Cells["SOTC"].Value.ToString();
                txt_stlt_hp.Text = row.Cells["STLT"].Value.ToString();
                txt_stth_hp.Text = row.Cells["STTH"].Value.ToString();
                txt_svtd_hp.Text = row.Cells["SOSVTD"].Value.ToString();
                txt_madv_hp.Text = row.Cells["MADV"].Value.ToString();
            }
            else
            {
                txt_mahp.Text = "";
                txt_tenhp.Text = "";
                txt_sotc_hp.Text = "";
                txt_stlt_hp.Text = "";
                txt_stth_hp.Text = "";
                txt_svtd_hp.Text = "";
                txt_madv_hp.Text = "";
            }
        }

        private void text_khmo_mahp_TextChanged(object sender, EventArgs e)
        {
            searchkhmo.Stop();
            searchkhmo.Start();
        }
        private void text_khmo_hki_TextChanged(object sender, EventArgs e)
        {
            searchkhmo.Stop();
            searchkhmo.Start();
        }

        private void searchkhmo_Tick(object sender, EventArgs e)
        {
            searchkhmo.Stop();
            SearchAndFill_KHMo(text_khmo_mahp.Text, text_khmo_hki.Text);
        }

        private void SearchAndFill_KHMo(string mahp, string hki)
        {
            try
            {
                string query;
                if ((string.IsNullOrEmpty(mahp) && string.IsNullOrEmpty(hki)) || (mahp == " "))
                    query = "select * from OLS_ADMIN.KHMO";

                else if (string.IsNullOrEmpty(hki))
                    query = "select * from OLS_ADMIN.KHMO where MAHP= :mahp";

                else if (string.IsNullOrEmpty(mahp))
                {
                    int hk = int.Parse(hki);
                    query = $"select * from OLS_ADMIN.KHMO where HK= {hk}";
                }
                else
                {
                    int hk = int.Parse(hki);
                    query = $"select * from OLS_ADMIN.KHMO where MAHP= :mahp and HK= {hk}";
                }
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add(":mahp", mahp);
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dtgkhmo.DataSource = dataTable;
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtgkhmo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgkhmo.Rows[e.RowIndex];
                txt_khmo_mahp.Text = row.Cells["MAHP"].Value.ToString();
                txt_khmo_hki.Text = row.Cells["HK"].Value.ToString();
                txt_khmo_nam.Text = row.Cells["NAM"].Value.ToString();
                txt_khmo_mact.Text = row.Cells["MACT"].Value.ToString();
            }
            else
            {
                txt_khmo_mahp.Text = "";
                txt_khmo_hki.Text = "";
                txt_khmo_nam.Text = "";
                txt_khmo_mact.Text = "";
            }
        }

        private void kq_hki_TextChanged(object sender, EventArgs e)
        {
            searchkqhp.Stop();
            searchkqhp.Start();
        }

        private void searchkqhp_Tick(object sender, EventArgs e)
        {
            searchkqhp.Stop();
            SearchAndFill_KetQuaHocPhan(kq_hki.Text);
        }

        private void SearchAndFill_KetQuaHocPhan(string searchtext)
        {
            try
            {
                string query;
                if (string.IsNullOrEmpty(searchtext))
                {
                    query = "select * from OLS_ADMIN.DANGKY";
                }
                    
                else
                {
                    int hki = Int32.Parse(searchtext);
                    query = $"select * from OLS_ADMIN.DANGKY where HK = {hki}";
                }                        
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        kq_hp.DataSource = dataTable;
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void kq_hp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = kq_hp.Rows[e.RowIndex];
                txt_diemth.Text = row.Cells["DIEMTH"].Value.ToString();
                txt_diemqt.Text = row.Cells["DIEMQT"].Value.ToString();
                txt_diemck.Text = row.Cells["DIEMCK"].Value.ToString();
                txt_diemtk.Text = row.Cells["DIEMTK"].Value.ToString();
            }
            else
            {
                txt_diemth.Text = "";
                txt_diemqt.Text = "";
                txt_diemck.Text = "";
                txt_diemtk.Text = "";
            }
        }
    }
}
