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
        public static System.Timers.Timer searchMSSV_Timer;

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

            searchMSSV_Timer = new System.Timers.Timer();
            searchMSSV_Timer.Interval = 500; // Set the delay time (500 milliseconds in this case)
            searchMSSV_Timer.Elapsed += searchMSSV_Event;



            dtgv_DSSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void tb_TimKiemMSSV_TextChanged(object sender, EventArgs e)
        {
            searchMSSV_Timer.Stop();
            searchMSSV_Timer.Start();
        }

        private void searchMSSV_Event(Object source, ElapsedEventArgs e)
        {
            searchMSSV_Timer.Stop();
            this.Invoke(new Action(() => SearchAndReloadDSSV(tb_TimKiemMSSV.Text)));
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
                    query = $"select * from OLS_ADMIN.uv_NhanVienCoBan_SINHVIEN where MASV like '%{searchText}%'";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
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
