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
        private Timer searchdk;
        private bool isShow;
        public SinhVien()
        {
            InitializeComponent();
            pn_thongbao.Height = 0;
            thongbaotimer.Interval = 10;
            isShow = false;
            LoadData_ThongBao();
            ten_sinhvien();

            dtgv_thongbao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dtghp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

            kq_hp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            searchkqhp = new Timer();
            searchkqhp.Interval = 1000;
            searchkqhp.Tick += searchkqhp_Tick;
            SearchAndFill_KetQuaHocPhan("");

            dtgdk.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            searchdk = new Timer();
            searchdk.Interval = 1000;
            searchdk.Tick += searchdk_Tick;
            SearchAndFill_DangKy("");

            dtgmo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            HocPhanDangKy();
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
                        kq_hp.Columns["MAGV"].Visible = false;
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

        private void text_dk_mahp_TextChanged(object sender, EventArgs e)
        {
            searchdk.Stop();
            searchdk.Start();
        }

        private void searchdk_Tick(object sender, EventArgs e)
        {
            searchdk.Stop();
            SearchAndFill_DangKy(text_dk_mahp.Text);
        }

        private void SearchAndFill_DangKy(string searchtext)
        {
            int thang = DateTime.Now.Month;
            int hki;
            if (1 <= thang && thang <= 4) hki = 1;
            else if (5 <= thang && thang <= 9) hki = 2;
            else hki = 3;
            try
            {
                string query;
                if (string.IsNullOrEmpty(searchtext))
                    query = $"select * from OLS_ADMIN.KHMO WHERE HK= {hki}" +
                        $" and not exists (select mahp, hk, nam, mact from OLS_ADMIN.DANGKY where" +
                        $" mahp= OLS_ADMIN.KHMO.mahp and hk = OLS_ADMIN.KHMO.hk and nam = OLS_ADMIN.KHMO.nam)";
                else
                    query = $"select * from OLS_ADMIN.KHMO where HK= {hki}" +
                        $" and not exists (select mahp, hk, nam, mact from OLS_ADMIN.DANGKY where" +
                        $" mahp= OLS_ADMIN.KHMO.mahp and hk = OLS_ADMIN.KHMO.hk and nam = OLS_ADMIN.KHMO.nam) AND MAHP= :searchtext";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add(":searchtext", searchtext);
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dtgdk.DataSource = dataTable;
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void HocPhanDangKy()
        {
            int thang = DateTime.Now.Month;
            int hki;
            if (1 <= thang && thang <= 4) hki = 1;
            else if (5 <= thang && thang <= 9) hki = 2;
            else hki = 3;
            try
            {
                string query;
                query = $"select * from OLS_ADMIN.DANGKY WHERE HK= {hki}";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dtgmo.DataSource = dataTable;
                        dtgmo.Columns["MAGV"].Visible = false;
                        dtgmo.Columns["MASV"].Visible = false;
                        dtgmo.Columns["DIEMTH"].Visible = false;
                        dtgmo.Columns["DIEMQT"].Visible = false;
                        dtgmo.Columns["DIEMCK"].Visible = false;
                        dtgmo.Columns["DIEMTK"].Visible = false;
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtgdk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgdk.Rows[e.RowIndex];
                txt_pc_mahp.Text = row.Cells["MAHP"].Value.ToString();
                txt_pc_hki.Text = row.Cells["HK"].Value.ToString();
                txt_pc_nam.Text = row.Cells["NAM"].Value.ToString();
                txt_pc_mact.Text = row.Cells["MACT"].Value.ToString();
            }   
            else
            {
                txt_pc_mahp.Text = "";
                txt_pc_hki.Text = "";
                txt_pc_nam.Text = "";
                txt_pc_mact.Text = "";
            }
        }

        private void dtgmo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgmo.Rows[e.RowIndex];
                txt_pc_mahp.Text = row.Cells["MAHP"].Value.ToString();
                txt_pc_hki.Text = row.Cells["HK"].Value.ToString();
                txt_pc_nam.Text = row.Cells["NAM"].Value.ToString();
                txt_pc_mact.Text = row.Cells["MACT"].Value.ToString();
                txt_pc_magv.Text = row.Cells["MAGV"].Value.ToString();
            }
            else
            {
                txt_pc_mahp.Text = "";
                txt_pc_hki.Text = "";
                txt_pc_nam.Text = "";
                txt_pc_mact.Text = "";
                txt_pc_magv.Text = "";
            }
        }

        private void kq_hp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            int hki = Int32.Parse(txt_pc_hki.Text);
            int namm = Int32.Parse(txt_pc_nam.Text);
            string query = $"INSERT INTO OLS_ADMIN.DANGKY (MASV, MAGV, MAHP, HK, NAM, MACT, DIEMTH, DIEMQT, DIEMCK, DIEMTK)" +
                $" VALUES ('{FormDangNhap.usernameUser}', '{combo_magv.Text}', '{txt_pc_mahp.Text}', {hki}, {namm}, '{txt_pc_mact.Text}', NULL, NULL, NULL, NULL)";
            using (OracleCommand cmd = new OracleCommand(query, conn))
            {
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm đăng ký thành công");
                    HocPhanDangKy();
                    SearchAndFill_DangKy("");
                }

                catch (Exception ex)
                {
                    if(ex.Message == "ORA-02291: integrity constraint (OLS_ADMIN.FK_DANGKY_PHANCONG) violated - parent key not found")
                    {
                        string txt = $"Học phần không phải do giáo viên {combo_magv.Text} phụ trách";
                        MessageBox.Show(txt);
                        return;
                    }
                    else {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                    
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int hki = Int32.Parse(txt_pc_hki.Text);
            int namm = Int32.Parse(txt_pc_nam.Text);
            string query = $"DELETE FROM OLS_ADMIN.DANGKY " +
                $" WHERE MASV= '{FormDangNhap.usernameUser}' AND MAGV= '{txt_pc_magv.Text}' AND MAHP = '{txt_pc_mahp.Text}' AND HK= {hki} AND NAM= {namm} AND MACT= '{txt_pc_mact.Text}'";
            using (OracleCommand cmd = new OracleCommand(query, conn))
            {
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa đăng ký thành công");
                    HocPhanDangKy();
                    SearchAndFill_DangKy("");
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }

        private void btn_thongbao_Click(object sender, EventArgs e)
        {
            isShow = !isShow;
            thongbaotimer.Start();
        }

        private void thongbaotimer_Tick(object sender, EventArgs e)
        {
            if (isShow && pn_thongbao.Height < 350)
            {
                pn_thongbao.Height += 50;
            }
            else if (!isShow && pn_thongbao.Height > 0)
            {
                pn_thongbao.Height -= 50;
            }

            if (pn_thongbao.Height <= 0 || pn_thongbao.Height >= 350)
            {
                thongbaotimer.Stop();
            }
        }

        private void LoadData_ThongBao()
        {
            try
            {
                string query = "select NoiDung from OLS_ADMIN.THONGBAO order by NgayTao desc";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dtgv_thongbao.DataSource = dataTable;
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
