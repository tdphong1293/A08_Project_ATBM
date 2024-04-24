using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace _21127331_21127388_21127537_21127695
{
    public partial class FormTruongDonVi : Form
    {
        private OracleConnection conn = FormDangNhap.conn;
        private string SDT_cu;
        private string diemth, diemqt, diemck, diemtk;
        public static System.Timers.Timer searchSV_Timer, searchDV_Timer, searchHP_Timer, searchKHMO_Timer, searchPCHP_Timer, searchPCGV_Timer;

        public FormTruongDonVi()
        {
            InitializeComponent();
            SDT_cu = txt_dienthoai_nv.Text;
            diemth = txt_diemth_dk.Text;
            diemqt = txt_diemqt_dk.Text;
            diemck = txt_diemck_dk.Text;
            diemtk = txt_diemtk_dk.Text;
            Load_thongtincanhan();

            SearchAndReloadDSSV("");
            SearchAndReloadDSDV("");
            SearchAndReloadDSHP("");
            SearchAndReloadDSKHMO("");
            SearchAndReloadDSPCHP("");
            SearchAndReloadDSPCGV("");

            searchSV_Timer = new System.Timers.Timer();
            searchSV_Timer.Interval = 500; // Set the delay time (500 milliseconds in this case)
            searchSV_Timer.Elapsed += searchSV_Event;

            searchDV_Timer = new System.Timers.Timer();
            searchDV_Timer.Interval = 500; // Set the delay time (500 milliseconds in this case)
            searchDV_Timer.Elapsed += searchDV_Event;

            searchHP_Timer = new System.Timers.Timer();
            searchHP_Timer.Interval = 500; // Set the delay time (500 milliseconds in this case)
            searchHP_Timer.Elapsed += searchHP_Event;

            searchKHMO_Timer = new System.Timers.Timer();
            searchKHMO_Timer.Interval = 500; // Set the delay time (500 milliseconds in this case)
            searchKHMO_Timer.Elapsed += searchKHMO_Event;

            searchPCHP_Timer = new System.Timers.Timer();
            searchPCHP_Timer.Interval = 500; // Set the delay time (500 milliseconds in this case)
            searchPCHP_Timer.Elapsed += searchPCHP_Event;

            searchPCGV_Timer = new System.Timers.Timer();
            searchPCGV_Timer.Interval = 500; // Set the delay time (500 milliseconds in this case)
            searchPCGV_Timer.Elapsed += searchPCGV_Event;


            dtgv_DSSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgv_donvi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_hocphan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgv_khmo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_phancong_HP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_phancong_GV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void tb_TimKiemMSSV_TextChanged(object sender, EventArgs e)
        {
            searchSV_Timer.Stop();
            searchSV_Timer.Start();
        }

        private void txt_timkiem_dv_TextChanged(object sender, EventArgs e)
        {
            searchDV_Timer.Stop();
            searchDV_Timer.Start();
        }

        private void txt_timkiem_hp_TextChanged(object sender, EventArgs e)
        {
            searchHP_Timer.Stop();
            searchHP_Timer.Start();
        }

        private void txt_timkiem_khmo_TextChanged(object sender, EventArgs e)
        {
            searchKHMO_Timer.Stop();
            searchKHMO_Timer.Start();
        }

        private void txt_timkiem_pchp_TextChanged(object sender, EventArgs e)
        {
            searchPCHP_Timer.Stop();
            searchPCHP_Timer.Start();
        }

        private void txt_timkiem_pcgv_TextChanged(object sender, EventArgs e)
        {
            searchPCGV_Timer.Stop();
            searchPCGV_Timer.Start();
        }

        private void searchSV_Event(Object source, ElapsedEventArgs e)
        {
            searchSV_Timer.Stop();
            this.Invoke(new Action(() => SearchAndReloadDSSV(tb_TimKiemMSSV.Text)));
        }

        private void searchDV_Event(Object source, ElapsedEventArgs e)
        {
            searchDV_Timer.Stop();
            this.Invoke(new Action(() => SearchAndReloadDSDV(txt_timkiem_dv.Text)));
        }

        private void searchHP_Event(Object source, ElapsedEventArgs e)
        {
            searchHP_Timer.Stop();
            this.Invoke(new Action(() => SearchAndReloadDSHP(txt_timkiem_hp.Text)));
        }

        private void searchKHMO_Event(Object source, ElapsedEventArgs e)
        {
            searchKHMO_Timer.Stop();
            this.Invoke(new Action(() => SearchAndReloadDSKHMO(txt_timkiem_khmo.Text)));
        }

        private void searchPCHP_Event(Object source, ElapsedEventArgs e)
        {
            searchPCHP_Timer.Stop();
            this.Invoke(new Action(() => SearchAndReloadDSPCHP(txt_timkiem_pchp.Text)));
        }

        private void searchPCGV_Event(Object source, ElapsedEventArgs e)
        {
            searchPCGV_Timer.Stop();
            this.Invoke(new Action(() => SearchAndReloadDSPCGV(txt_timkiem_pcgv.Text)));
        }

        private void SearchAndReloadDSSV(string searchText)
        {
            try
            {
                string query;
                if (string.IsNullOrEmpty(searchText))
                {
                    query = "select * from OLS_ADMIN.uv_NhanVienCoBan_SINHVIEN";
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
                else
                    query = "select * from OLS_ADMIN.uv_NhanVienCoBan_SINHVIEN where UPPER(HOTEN) like  UPPER(:unicodeText) or MASV = UPPER(:searchText)";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add(":unicodeText", OracleDbType.NVarchar2, "%" + searchText + "%", ParameterDirection.Input);
                    cmd.Parameters.Add(":searchText", searchText);
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dtgv_DSSinhVien.DataSource = dataTable;
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SearchAndReloadDSDV(string searchText)
        {
            try
            {
                string query;
                if (string.IsNullOrEmpty(searchText))
                    query = "select * from OLS_ADMIN.uv_TruongDonVi_DONVI";
                else
                    query = "select * from OLS_ADMIN.uv_TruongDonVi_DONVI where UPPER(TENDV) like UPPER(:unicodeText) or MADV = UPPER(:searchText)";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add(":unicodeText", OracleDbType.NVarchar2, "%" + searchText + "%", ParameterDirection.Input);
                    cmd.Parameters.Add(":searchText", searchText);
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

        private void SearchAndReloadDSHP(string searchText)
        {
            try
            {
                string query;
                if (string.IsNullOrEmpty(searchText))
                {
                    query = "select * from OLS_ADMIN.uv_NhanVienCoBan_HOCPHAN";
                    statuslabel_hocphan.Text = "Chưa chọn học phần nào";
                    txt_mahp.Text = "";
                    txt_tenhp.Text = "";
                    txt_sotc_hp.Text = "";
                    txt_stlt_hp.Text = "";
                    txt_stth_hp.Text = "";
                    txt_svtd_hp.Text = "";
                    txt_madv_hp.Text = "";
                }    
                else
                    query = "select * from OLS_ADMIN.uv_NhanVienCoBan_HOCPHAN where UPPER(TENHP) like UPPER(:unicodeText) or MAHP = UPPER(:searchText)";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add(":unicodeText", OracleDbType.NVarchar2, "%" + searchText + "%", ParameterDirection.Input);
                    cmd.Parameters.Add(":searchText", searchText);
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

        private void SearchAndReloadDSKHMO(string searchText)
        {
            try
            {
                string query;
                if (string.IsNullOrEmpty(searchText))
                    query = "select * from OLS_ADMIN.uv_NhanVienCoBan_KHMO";
                else
                    query = "select * from OLS_ADMIN.uv_NhanVienCoBan_KHMO where \"MA HOC PHAN\" = UPPER(:searchText)";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add(":searchText", searchText);
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

        private void SearchAndReloadDSPCHP(string searchText)
        {
            try
            {
                string query;
                if (string.IsNullOrEmpty(searchText))
                {
                    query = "select * from OLS_ADMIN.uv_TruongDonVi_PHANCONG_1";
                    statuslabel_phancong.Text = "Chưa chọn phân công nào";
                    txt_magv_pc.Text = "";
                    txt_mahp_pc.Text = "";
                    txt_hocki_pc.Text = "";
                    txt_nam_pc.Text = "";
                    txt_mact_pc.Text = "";

                    btn_CapNhatPC.Enabled = false;
                    btn_XoaPC.Enabled = false;
                }    
                else
                    query = "select * from OLS_ADMIN.uv_TruongDonVi_PHANCONG_1 where MAHP = UPPER(:searchMAHP) or MAGV = UPPER(:searchMAGV)";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add(":searchMAHP", searchText);
                    cmd.Parameters.Add(":searchMAGV", searchText);

                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dtgv_phancong_HP.DataSource = dataTable;
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SearchAndReloadDSPCGV(string searchText)
        {
            try
            {
                string query;
                if (string.IsNullOrEmpty(searchText))
                {
                    query = "select * from OLS_ADMIN.uv_TruongDonVi_PHANCONG_2";
                    statuslabel_phancong.Text = "Chưa chọn phân công nào";
                    txt_magv_pc.Text = "";
                    txt_mahp_pc.Text = "";
                    txt_hocki_pc.Text = "";
                    txt_nam_pc.Text = "";
                    txt_mact_pc.Text = "";

                    btn_CapNhatPC.Enabled = false;
                    btn_XoaPC.Enabled = false;
                }
                else
                    query = "select * from OLS_ADMIN.uv_TruongDonVi_PHANCONG_2 where MAHP = UPPER(:searchMAHP) or MAGV = UPPER(:searchMAGV)";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add(":searchMAHP", searchText);
                    cmd.Parameters.Add(":searchMAGV", searchText);

                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dtgv_phancong_GV.DataSource = dataTable;
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtgv_DSSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgv_DSSinhVien.Rows[e.RowIndex];
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

        private void dtgv_donvi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgv_donvi.Rows[e.RowIndex];
                tb_MaDV.Text = row.Cells["MADV"].Value.ToString();
                tb_TenDV.Text = row.Cells["TENDV"].Value.ToString();
                tb_MaTDV.Text = row.Cells["TRGDV"].Value.ToString();
                tb_TenTDV.Text = row.Cells["HOTEN"].Value.ToString();
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

        private void dtgv_phancong_HP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_CapNhatPC.Enabled = true;
            btn_XoaPC.Enabled = true;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgv_phancong_HP.Rows[e.RowIndex];
                txt_magv_pc.Text = row.Cells["MAGV"].Value.ToString();
                txt_mahp_pc.Text = row.Cells["MAHP"].Value.ToString();
                txt_hocki_pc.Text = row.Cells["HK"].Value.ToString();
                txt_nam_pc.Text = DateTime.Parse(row.Cells["NAM"].Value.ToString()).ToString("yyyy");
                txt_mact_pc.Text = row.Cells["MACT"].Value.ToString();
                statuslabel_phancong.Text = "Đã chọn học phần " + txt_mahp_pc.Text + " được phân công cho " + txt_magv_pc.Text +
                    ". Học kì " + txt_hocki_pc.Text + ", Năm " + txt_nam_pc.Text + ". Chương trình " + txt_mact_pc.Text;
            }
            else
            {
                statuslabel_phancong.Text = "Chưa chọn phân công nào";
                txt_magv_pc.Text = "";
                txt_mahp_pc.Text = "";
                txt_hocki_pc.Text = "";
                txt_nam_pc.Text = "";
                txt_mact_pc.Text = "";
            }
        }

        private void dtgv_phancong_GV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_CapNhatPC.Enabled = false;
            btn_XoaPC.Enabled = false;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgv_phancong_GV.Rows[e.RowIndex];
                txt_magv_pc.Text = row.Cells["MAGV"].Value.ToString();
                txt_mahp_pc.Text = row.Cells["MAHP"].Value.ToString();
                txt_hocki_pc.Text = row.Cells["HK"].Value.ToString();
                txt_nam_pc.Text = DateTime.Parse(row.Cells["NAM"].Value.ToString()).ToString("yyyy");
                txt_mact_pc.Text = row.Cells["MACT"].Value.ToString();
                statuslabel_phancong.Text = "Đã chọn học phần " + txt_mahp_pc.Text + " được phân công cho " + txt_magv_pc.Text +
                    ". Học kì " + txt_hocki_pc.Text + ", Năm " + txt_nam_pc.Text + ". Chương trình " + txt_mact_pc.Text;
            }
            else
            {
                statuslabel_phancong.Text = "Chưa chọn phân công nào";
                txt_magv_pc.Text = "";
                txt_mahp_pc.Text = "";
                txt_hocki_pc.Text = "";
                txt_nam_pc.Text = "";
                txt_mact_pc.Text = "";
            }
        }


        private void btn_thongbao_Click(object sender, EventArgs e)
        {
            dtgv_thongbao.Visible = !dtgv_thongbao.Visible;
            pn_thongbao.Visible = !pn_thongbao.Visible;
        }

        private void btn_ChinhSua_Click(object sender, EventArgs e)
        {
            btn_ChinhSua.Visible = false;
            txt_dienthoai_nv.Enabled = true;
            txt_dienthoai_nv.ReadOnly = false;
            txt_dienthoai_nv.SelectionStart = 0;
            txt_dienthoai_nv.SelectionLength = txt_dienthoai_nv.Text.Length;
            txt_dienthoai_nv.Focus();
            btn_luudt.Visible = true;
            btn_QuayVe.Visible = true;
        }

        

        private void btn_quayve_dk_Click(object sender, EventArgs e)
        {
            btn_chinhsua_dk.Visible = true;
            txt_diemth_dk.Text = diemth;
            txt_diemqt_dk.Text = diemqt;
            txt_diemck_dk.Text = diemck;
            txt_diemtk_dk.Text = diemtk;
            txt_diemth_dk.Enabled = false;
            txt_diemqt_dk.Enabled = false;
            txt_diemck_dk.Enabled = false;
            txt_diemtk_dk.Enabled = false;
            txt_diemth_dk.ReadOnly = true;
            txt_diemqt_dk.ReadOnly = true;
            txt_diemck_dk.ReadOnly = true;
            txt_diemtk_dk.ReadOnly = true;
            txt_diemth_dk.TabStop = false;
            txt_diemqt_dk.TabStop = false;
            txt_diemck_dk.TabStop = false;
            txt_diemtk_dk.TabStop = false;
            btn_luudiem_dk.Visible = false;
            btn_quayve_dk.Visible = false;
        }

        

        private void btn_chinhsua_dk_Click(object sender, EventArgs e)
        {
            btn_chinhsua_dk.Visible = false;
            txt_diemth_dk.Enabled = true;
            txt_diemqt_dk.Enabled = true;
            txt_diemck_dk.Enabled = true;
            txt_diemtk_dk.Enabled = true;
            txt_diemth_dk.ReadOnly = false;
            txt_diemqt_dk.ReadOnly = false;
            txt_diemck_dk.ReadOnly = false;
            txt_diemtk_dk.ReadOnly = false;
            txt_diemth_dk.TabStop = true;
            txt_diemqt_dk.TabStop = true;
            txt_diemck_dk.TabStop = true;
            txt_diemtk_dk.TabStop = true;
            txt_diemth_dk.SelectionStart = 0;
            txt_diemth_dk.SelectionLength = txt_diemth_dk.Text.Length;
            txt_diemth_dk.Focus();
            btn_luudiem_dk.Visible = true;
            btn_quayve_dk.Visible = true;
        }

        

        private void btn_luudiem_dk_Click(object sender, EventArgs e)
        {
            btn_chinhsua_dk.Visible = true;
            diemth = txt_diemth_dk.Text.Trim();
            diemqt = txt_diemqt_dk.Text.Trim();
            diemck = txt_diemck_dk.Text.Trim();
            diemtk = txt_diemtk_dk.Text.Trim();
            txt_diemth_dk.Enabled = false;
            txt_diemqt_dk.Enabled = false;
            txt_diemck_dk.Enabled = false;
            txt_diemtk_dk.Enabled = false;
            txt_diemth_dk.ReadOnly = true;
            txt_diemqt_dk.ReadOnly = true;
            txt_diemck_dk.ReadOnly = true;
            txt_diemtk_dk.ReadOnly = true;
            txt_diemth_dk.TabStop = false;
            txt_diemqt_dk.TabStop = false;
            txt_diemck_dk.TabStop = false;
            txt_diemtk_dk.TabStop = false;
            btn_luudiem_dk.Visible = false;
            btn_quayve_dk.Visible = false;
        }

        

        private void btn_QuayVe_Click(object sender, EventArgs e)
        {
            btn_ChinhSua.Visible = true;
            txt_dienthoai_nv.Text = SDT_cu;
            txt_dienthoai_nv.Enabled = false;
            txt_dienthoai_nv.ReadOnly = true;
            btn_luudt.Visible = false;
            btn_QuayVe.Visible = false;
        }


        private void btn_luudt_Click(object sender, EventArgs e)
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

                btn_ChinhSua.Visible = true;
                SDT_cu = txt_dienthoai_nv.Text;
                txt_dienthoai_nv.Enabled = false;
                txt_dienthoai_nv.ReadOnly = true;
                btn_luudt.Visible = false;
                btn_QuayVe.Visible = false;

            }    
        }

        

        private void btn_ThemPC_Click(object sender, EventArgs e)
        {
            Form_TruongDonVi_ThemPC form_TruongDonVi_ThemPC = new Form_TruongDonVi_ThemPC();
            form_TruongDonVi_ThemPC.ShowDialog();
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
