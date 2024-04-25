using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace _21127331_21127388_21127537_21127695
{
    public partial class GiaoVu : Form
    {
        private OracleConnection conn = FormDangNhap.conn;
        private Timer searchsv;
        private Timer searchdonvi;
        private Timer searchhp;
        private Timer searchkhmo;
        private Timer searchphancong;
        public GiaoVu()
        {
            InitializeComponent();
            ten_giaovu();

            dtgsv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; ;
            searchsv = new Timer();
            searchsv.Interval = 1000;
            searchsv.Tick += searchsv_Tick;
            SearchAndFill_SinhVien("");

            dtgdv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgdv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            searchdonvi = new Timer();
            searchdonvi.Interval = 1000;
            searchdonvi.Tick += searchdonvi_Tick;
            SearchAndFill_DonVi("");

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

            dtgphancong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            searchphancong = new Timer();
            searchphancong.Interval = 1000;
            searchphancong.Tick += searchphancong_Tick;
            SearchAndFill_PhanCong("", "", "");
            chinhsua_pc.Enabled = false;
        }

        private void ten_giaovu()
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

        private void text_sv_TextChanged(object sender, EventArgs e)
        {
            searchsv.Stop();
            searchsv.Start();
        }

        private void searchsv_Tick(object sender, EventArgs e)
        {
            searchsv.Stop();
            SearchAndFill_SinhVien(text_sv.Text);
        }

        private void SearchAndFill_SinhVien(string searchtext)
        {
            try
            {
                string query;
                if (string.IsNullOrEmpty(searchtext))
                    query = "select * from OLS_ADMIN.uv_NhanVienCoBan_SINHVIEN";
                else
                    query = "select * from OLS_ADMIN.uv_NhanVienCoBan_SINHVIEN where UPPER(HOTEN) like  UPPER(:unicodetext) or MASV = :searchtext";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add(":unicodetext", OracleDbType.NVarchar2, "%" + searchtext + "%", ParameterDirection.Input);
                    cmd.Parameters.Add(":searchtext", searchtext);
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dtgsv.DataSource = dataTable;
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtgsv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgsv.Rows[e.RowIndex];
                txt_masv.Text = row.Cells["MASV"].Value.ToString();
                txt_hoten_sv.Text = row.Cells["HOTEN"].Value.ToString();
                txt_gioitinh_sv.Text = row.Cells["PHAI"].Value.ToString();
                txt_ngaysinh_sv.Text = DateTime.Parse(row.Cells["NGSINH"].Value.ToString()).ToString("dd/MM/yyyy");
                txt_dienthoai_sv.Text = row.Cells["DT"].Value.ToString();
                txt_tctl_sv.Text = row.Cells["SOTCTL"].Value.ToString();
                txt_dtbtl_sv.Text = float.Parse(row.Cells["DTBTL"].Value.ToString()).ToString("F2");
                txt_diachi_sv.Text = row.Cells["DCHI"].Value.ToString();
                txt_mact_sv.Text = row.Cells["MACT"].Value.ToString();
                txt_manganh_sv.Text = row.Cells["MANGANH"].Value.ToString();
            }
            else
            {
                txt_masv.Text = "";
                txt_hoten_sv.Text = "";
                txt_gioitinh_sv.Text = "";
                txt_ngaysinh_sv.Text = "";
                txt_mact_sv.Text = "";
                txt_manganh_sv.Text = "";
                txt_diachi_sv.Text = "";
                txt_dienthoai_sv.Text = "";
                txt_tctl_sv.Text = "";
                txt_dtbtl_sv.Text = "";
            }
        }

        private void text_donvi_TextChanged(object sender, EventArgs e)
        {
            searchdonvi.Stop();
            searchdonvi.Start();
        }

        private void searchdonvi_Tick(object sender, EventArgs e)
        {
            searchdonvi.Stop();
            SearchAndFill_DonVi(text_donvi.Text);
        }

        private void SearchAndFill_DonVi(string searchtext)
        {
            try
            {
                string query;
                if (string.IsNullOrEmpty(searchtext))
                    query = "select * from OLS_ADMIN.uv_NhanVienCoBan_DONVI";
                else
                    query = "select * from OLS_ADMIN.uv_NhanVienCoBan_DONVI where UPPER(TENDV) like  UPPER(:unicodetext) or MADV = :searchtext";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add(":unicodetext", OracleDbType.NVarchar2, "%" + searchtext + "%", ParameterDirection.Input);
                    cmd.Parameters.Add(":searchtext", searchtext);
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dtgdv.DataSource = dataTable;
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtgdv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgdv.Rows[e.RowIndex];
                txt_madv.Text = row.Cells["MADV"].Value.ToString();
                txt_tendv.Text = row.Cells["TENDV"].Value.ToString();
                txt_truongdv.Text = row.Cells["TRGDV"].Value.ToString();
            }
            else
            {
                txt_madv.Text = "";
                txt_tendv.Text = "";
                txt_truongdv.Text = "";
            }
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
                    query = "select * from OLS_ADMIN.uv_NhanVienCoBan_HOCPHAN";
                else
                    query = "select * from OLS_ADMIN.uv_NhanVienCoBan_HOCPHAN where UPPER(TENHP) like UPPER(:unicodetext) or MAHP = :searchtext";
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
                    query = "select * from OLS_ADMIN.uv_NhanVienCoBan_KHMO";
                
                else if (string.IsNullOrEmpty(hki))
                    query = "select * from OLS_ADMIN.uv_NhanVienCoBan_KHMO where \"MA HOC PHAN\"= :mahp";

                else if (string.IsNullOrEmpty(mahp))
                {
                    int hk = int.Parse(hki);
                    query = $"select * from OLS_ADMIN.uv_NhanVienCoBan_KHMO where \"HOC KY\"= {hk}";
                }
                else
                {
                    int hk = int.Parse(hki);
                    query = $"select * from OLS_ADMIN.uv_NhanVienCoBan_KHMO where \"MA HOC PHAN\"= :mahp and \"HOC KY\"= {hk}";
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
                txt_khmo_mahp.Text = row.Cells["MA HOC PHAN"].Value.ToString();
                txt_khmo_hki.Text = row.Cells["HOC KY"].Value.ToString();
                txt_khmo_nam.Text = row.Cells["NAM"].Value.ToString();
                txt_khmo_mact.Text = row.Cells["MA CHUONG TRINH"].Value.ToString();
            }
            else
            {
                txt_khmo_mahp.Text = "";
                txt_khmo_hki.Text = "";
                txt_khmo_nam.Text = "";
                txt_khmo_mact.Text = "";
            }
        }

        private void phancong_mahp_TextChanged(object sender, EventArgs e)
        {
            searchphancong.Stop();
            searchphancong.Start();
        }

        private void phancong_magv_TextChanged(object sender, EventArgs e)
        {
            searchphancong.Stop();
            searchphancong.Start();
        }

        private void phancong_hki_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchphancong.Stop();
            searchphancong.Start();
        }

        private void searchphancong_Tick(object sender, EventArgs e)
        {
            searchphancong.Stop();
            SearchAndFill_PhanCong(phancong_mahp.Text, phancong_hki.Text, phancong_magv.Text);
        }

        private void SearchAndFill_PhanCong(string mahp, string hki, string magv)
        {
            try
            {
                string query = "select * from OLS_ADMIN.uv_GiaoVu_PHANCONG where 1=1";

                if (!string.IsNullOrEmpty(mahp) && mahp.Trim() != "")
                {
                    query += " AND MAHP = :mahp";
                }

                if (!string.IsNullOrEmpty(hki) && hki.Trim() != "")
                {
                    int hk = Int32.Parse(hki);
                    query += " AND HK = :hk";
                }

                if (!string.IsNullOrEmpty(magv) && magv.Trim() != "")
                {
                    query += " AND MAGV = :magv";
                }

                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    if (!string.IsNullOrEmpty(mahp) && mahp.Trim() != "")
                    {
                        cmd.Parameters.Add(":mahp", mahp);
                    }

                    if (!string.IsNullOrEmpty(hki) && hki.Trim() != "")
                    {
                        int hk = Int32.Parse(hki);
                        cmd.Parameters.Add(":hk", hk);
                    }

                    if (!string.IsNullOrEmpty(magv) && magv.Trim() != "")
                    {
                        cmd.Parameters.Add(":magv", magv);
                    }

                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dtgphancong.DataSource = dataTable;
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtgphancong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string mahp = "";
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgphancong.Rows[e.RowIndex];
                txt_pc_magv.Text = row.Cells["MAGV"].Value.ToString();
                txt_pc_mahp.Text = row.Cells["MAHP"].Value.ToString();
                txt_pc_hki.Text = row.Cells["HK"].Value.ToString();
                txt_pc_nam.Text = row.Cells["NAM"].Value.ToString();
                txt_pc_mact.Text = row.Cells["MACT"].Value.ToString();

                mahp = row.Cells["MAHP"].Value.ToString(); 
            }
            else
            {
                txt_khmo_mahp.Text = "";
                txt_khmo_hki.Text = "";
                txt_khmo_nam.Text = "";
                txt_khmo_mact.Text = "";
            }

            string query = $"select * from OLS_ADMIN.uv_NhanVienCoban_HOCPHAN where MAHP = '{mahp}' AND MADV= 'VPK'";
            using (OracleCommand command = new OracleCommand(query, conn))
            {
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        chinhsua_pc.Enabled = true;
                    }
                    else chinhsua_pc.Enabled = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Close();
            this.Hide();
            FormDangNhap formDN = new FormDangNhap();
            formDN.ShowDialog();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ThongTinCaNhan ttcn_giaovu = new ThongTinCaNhan();
            ttcn_giaovu.ShowDialog();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lb_masv_Click(object sender, EventArgs e)
        {

        }

        private void txt_masv_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_hoten_sv_Click(object sender, EventArgs e)
        {

        }

        private void txt_hoten_sv_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_gioitinh_sv_Click(object sender, EventArgs e)
        {

        }

        private void txt_gioitinh_sv_TextChanged(object sender, EventArgs e)
        {

        }

        public class DataToPass
        {
            public string Masv { get; set; }
            public string Hoten { get; set; }
            public string Gioitinh { get; set; }
            public string Ngaysinh { get; set; }
            public string Diachi { get; set; }
            public string Sdt { get; set; }
            public string Mact { get; set; }
            public string Manganh { get; set; }
            public string Sotinchi { get; set; }
            public string Diemtrungbinh { get; set; }

            public string Madv { get; set; }
            public string Tendv { get; set; }
            public string Truongdv { get; set; }

            public string Mahp { get; set; }
            public string Tenhp { get; set; }
            public string Sotinchihp { get; set; }
            public string Sotietlt { get; set; }
            public string Sotietth { get; set; }
            public string Sosv { get; set; }
            public string Madvhp { get; set; }

            public string Khmo_mahp { get; set; }
            public string Khmo_hki { get; set; }
            public string Khmo_nam { get; set; }
            public string Khmo_mact { get; set; }

            public string Pc_magv { get; set; }
            public string Pc_mahp { get; set; }
            public string Pc_hk { get; set; }
            public string Pc_nam { get; set; }
            public string Pc_mact { get; set; }
            public string Pc_oldmagv { get; set; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CapNhatSV capnhatsv = new CapNhatSV();
            DataToPass data = new DataToPass();
            data.Masv = txt_masv.Text;
            data.Hoten = txt_hoten_sv.Text;
            data.Gioitinh = txt_gioitinh_sv.Text;
            data.Ngaysinh = txt_ngaysinh_sv.Text;
            data.Diachi = txt_diachi_sv.Text;
            data.Sdt = txt_dienthoai_sv.Text;
            data.Mact = txt_mact_sv.Text;
            data.Manganh = txt_manganh_sv.Text;
            data.Sotinchi = txt_tctl_sv.Text;
            data.Diemtrungbinh = txt_dtbtl_sv.Text;

            capnhatsv.SetData(data);
            capnhatsv.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThemSV themsv = new ThemSV();
            themsv.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CapNhatDonVi capnhatdv = new CapNhatDonVi();
            DataToPass data = new DataToPass();
            data.Madv = txt_madv.Text;
            data.Tendv = txt_tendv.Text;
            data.Truongdv = txt_truongdv.Text;

            capnhatdv.SetData(data);
            capnhatdv.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ThemDonVi themdv = new ThemDonVi();
            themdv.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CapNhatHocPhan capnhathp = new CapNhatHocPhan();
            DataToPass data = new DataToPass();
            data.Mahp = txt_mahp.Text;
            data.Tenhp = txt_tenhp.Text;
            data.Sotinchihp = txt_sotc_hp.Text;
            data.Sotietlt = txt_stlt_hp.Text;
            data.Sotietth = txt_stth_hp.Text;
            data.Sosv = txt_svtd_hp.Text;
            data.Madvhp = txt_madv_hp.Text;

            capnhathp.SetData(data);
            capnhathp.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ThemHocPhan themhp = new ThemHocPhan();
            themhp.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CapNhatKHMO capnhatkhmo = new CapNhatKHMO();
            DataToPass data = new DataToPass();
            data.Khmo_mahp = txt_khmo_mahp.Text;
            data.Khmo_hki = txt_khmo_hki.Text;
            data.Khmo_nam = txt_khmo_nam.Text;
            data.Khmo_mact = txt_khmo_mact.Text;

            capnhatkhmo.SetData(data);
            capnhatkhmo.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ThemKHMO themkhmo = new ThemKHMO();
            themkhmo.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            CapNhatPhanCong capnhatpc = new CapNhatPhanCong();
            DataToPass data = new DataToPass();
            data.Pc_magv = txt_pc_magv.Text;
            data.Pc_oldmagv = txt_pc_magv.Text;
            data.Pc_mahp = txt_pc_mahp.Text;
            data.Pc_hk = txt_pc_hki.Text;
            data.Pc_nam = txt_pc_nam.Text;
            data.Pc_mact = txt_pc_mact.Text;

            capnhatpc.SetData(data);
            capnhatpc.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }
    }
}