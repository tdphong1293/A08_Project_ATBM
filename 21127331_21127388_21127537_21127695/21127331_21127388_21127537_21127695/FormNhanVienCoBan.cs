using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21127331_21127388_21127537_21127695
{
    public partial class FormNhanVienCoBan : Form
    {
        private bool isShow;
        private string SDT_cu;
        private OracleConnection conn = FormDangNhap.conn;
        private Timer searchsv;
        private Timer searchdv;
        private Timer searchhp;
        private Timer searchkhmo;
        public FormNhanVienCoBan()
        {
            InitializeComponent();
            pn_thongbao.Height = 0;
            thongbaotimer.Interval = 10;
            isShow = false;
            Load_thongtincanhan();
            SDT_cu = txt_dienthoai_nv.Text;
            LoadData_ThongBao();
            dtgv_thongbao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_thongbao.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgv_sinhvien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgv_khmo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_hocphan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgv_donvi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            searchsv = new Timer();
            searchsv.Interval = 1000;
            searchsv.Tick += searchsv_Tick;
            SearchAndFill_SinhVien("");
            searchdv = new Timer();
            searchdv.Interval = 1000;
            searchdv.Tick += searchdv_Tick;
            SearchAndFill_DonVi("");
            searchhp = new Timer();
            searchhp.Interval = 1000;
            searchhp.Tick += searchhp_Tick;
            SearchAndFill_HocPhan("");
            searchkhmo = new Timer();
            searchkhmo.Interval = 1000;
            searchkhmo.Tick += searchkhmo_Tick;
            SearchAndFill_KHMO("");
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

        private void btn_chinhsua_nv_Click(object sender, EventArgs e)
        {
            btn_chinhsua_nv.Visible = false;
            txt_dienthoai_nv.Enabled = true;
            txt_dienthoai_nv.ReadOnly = false;
            txt_dienthoai_nv.TabStop = true;
            txt_dienthoai_nv.SelectionStart = 0;
            txt_dienthoai_nv.SelectionLength = txt_dienthoai_nv.Text.Length;
            txt_dienthoai_nv.Focus();
            btn_luudt_nv.Visible = true;
            btn_quayve_nv.Visible = true;
        }

        private void btn_quayve_nv_Click(object sender, EventArgs e)
        {
            btn_chinhsua_nv.Visible = true;
            txt_dienthoai_nv.Text = SDT_cu;
            txt_dienthoai_nv.Enabled = false;
            txt_dienthoai_nv.ReadOnly = true;
            txt_dienthoai_nv.TabStop = false;
            btn_luudt_nv.Visible = false;
            btn_quayve_nv.Visible = false;
        }

        private void btn_luudt_nv_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_dienthoai_nv.Text))
            {
                MessageBox.Show("Số điện thoại không được để trống");
            }
            else
            {
                try
                {
                    string query = "update OLS_ADMIN.uv_NhanVienCoBan_NHANSU set DT = :sdt";
                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(":sdt", txt_dienthoai_nv.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (OracleException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                SDT_cu = txt_dienthoai_nv.Text;
                btn_chinhsua_nv.Visible = true;
                txt_dienthoai_nv.Enabled = false;
                txt_dienthoai_nv.ReadOnly = true;
                txt_dienthoai_nv.TabStop = false;
                btn_luudt_nv.Visible = false;
                btn_quayve_nv.Visible = false;
            }
        }

        private void Load_thongtincanhan()
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
                            txt_manv.Text = reader["MANV"].ToString();
                            txt_hoten_nv.Text = reader["HOTEN"].ToString();
                            txt_gioitinh_nv.Text = reader["PHAI"].ToString();
                            txt_ngaysinh_nv.Text = DateTime.Parse(reader["NGSINH"].ToString()).ToString("dd/MM/yyyy");
                            txt_phucap_nv.Text = reader["PHUCAP"].ToString();
                            txt_vaitro_nv.Text = reader["VAITRO"].ToString();
                            txt_madv_nv.Text = reader["MADV"].ToString();
                            txt_dienthoai_nv.Text = reader["DT"].ToString();
                        }
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
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

        private void txt_timkiemsinhvien_TextChanged(object sender, EventArgs e)
        {
            searchsv.Stop();
            searchsv.Start();
        }

        private void searchsv_Tick(object sender, EventArgs e)
        {
            searchsv.Stop();
            SearchAndFill_SinhVien(txt_timkiemsinhvien.Text);
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
                        dtgv_sinhvien.DataSource = dataTable;
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtgv_sinhvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgv_sinhvien.Rows[e.RowIndex];
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
                statuslabel_sinhvien.Text = "Đã chọn sinh viên " + txt_masv.Text;
            }
            else
            {
                statuslabel_sinhvien.Text = "Chưa chọn sinh viên nào";
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

        private void txt_timkiem_dv_TextChanged(object sender, EventArgs e)
        {
            searchdv.Stop();
            searchdv.Start();
        }

        private void searchdv_Tick(object sender, EventArgs e)
        {
            searchdv.Stop();
            SearchAndFill_DonVi(txt_timkiem_dv.Text);
        }

        private void SearchAndFill_DonVi(string searchtext)
        {
            try
            {
                string query;
                if (string.IsNullOrEmpty(searchtext))
                    query = "select * from OLS_ADMIN.uv_NhanVienCoBan_DONVI";
                else
                    query = "select * from OLS_ADMIN.uv_NhanVienCoBan_DONVI where UPPER(TENDV) like UPPER(:unicodetext) or MADV = :searchtext";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add(":unicodetext", OracleDbType.NVarchar2, "%" + searchtext + "%", ParameterDirection.Input);
                    cmd.Parameters.Add(":searchtext", searchtext);
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dtgv_donvi.DataSource = dataTable;
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_timkiem_hp_TextChanged(object sender, EventArgs e)
        {
            searchhp.Stop();
            searchhp.Start();
        }

        private void searchhp_Tick(object sender, EventArgs e)
        {
            searchhp.Stop();
            SearchAndFill_HocPhan(txt_timkiem_hp.Text);
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
                        dtgv_hocphan.DataSource = dataTable;
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtgv_hocphan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgv_hocphan.Rows[e.RowIndex];
                txt_mahp.Text = row.Cells["MAHP"].Value.ToString();
                txt_tenhp.Text = row.Cells["TENHP"].Value.ToString();
                txt_sotc_hp.Text = row.Cells["SOTC"].Value.ToString();
                txt_stlt_hp.Text = row.Cells["STLT"].Value.ToString();
                txt_stth_hp.Text = row.Cells["STTH"].Value.ToString();
                txt_svtd_hp.Text = row.Cells["SOSVTD"].Value.ToString();
                txt_madv_hp.Text = row.Cells["MADV"].Value.ToString();
                statuslabel_hocphan.Text = "Đã chọn học phần " + txt_mahp.Text;
            }
            else
            {
                statuslabel_hocphan.Text = "Chưa chọn học phần nào";
                txt_mahp.Text = "";
                txt_tenhp.Text = "";
                txt_sotc_hp.Text = "";
                txt_stlt_hp.Text = "";
                txt_stth_hp.Text = "";
                txt_svtd_hp.Text = "";
                txt_madv_hp.Text = "";
            }
        }

        private void txt_timkiem_khmo_TextChanged(object sender, EventArgs e)
        {
            searchkhmo.Stop();
            searchkhmo.Start();
        }

        private void searchkhmo_Tick(object sender, EventArgs e)
        {
            searchkhmo.Stop();
            SearchAndFill_KHMO(txt_timkiem_khmo.Text);
        }

        private void SearchAndFill_KHMO(string searchtext)
        {
            try
            {
                string query;
                if (string.IsNullOrEmpty(searchtext))
                    query = "select * from OLS_ADMIN.uv_NhanVienCoBan_KHMO";
                else
                    query = "select * from OLS_ADMIN.uv_NhanVienCoBan_KHMO where \"MA HOC PHAN\" = :searchtext";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add(":searchtext", searchtext);
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dtgv_khmo.DataSource = dataTable;
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            conn.Close();
            this.Hide();
            FormDangNhap formDN = new FormDangNhap();
            formDN.ShowDialog();
            this.Close();
        }
    }
}
