using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace _21127331_21127388_21127537_21127695
{
    public partial class Form_TruongDonVi_ThemPC : Form
    {
        private OracleConnection conn = FormDangNhap.conn;
        
        public Form_TruongDonVi_ThemPC()
        {
            InitializeComponent();
            Load_MAGV_IntoComboBox();
            SearchAndReloadDSPCHP();

            dtgv_KHMO_hp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btn_QuayLaiPC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ThemPC_Click(object sender, EventArgs e)
        {
            if (cb_manv_pc.SelectedItem.ToString() != "")
            {
                string query = $"insert into OLS_ADMIN.UV_TruongDonVi_PHANCONG_1(MAGV, MAHP, HK, NAM, MACT) " +
                    $"values ('{cb_manv_pc.SelectedItem}', '{txt_mahp_pc.Text}', {txt_hocki_pc.Text}, {txt_nam_pc.Text}, '{txt_mact_pc.Text}')";
                OracleTransaction transaction = null;
                try
                {
                    transaction = conn.BeginTransaction();
                    OracleCommand cmd = new OracleCommand(query, conn);
                    cmd.Transaction = transaction;
                    cmd.ExecuteNonQuery();
                    transaction.Commit();

                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);

                }
                transaction.Dispose();
            }
        }

        private void SearchAndReloadDSPCHP()
        {
            try
            {
                string query = "select * from OLS_ADMIN.uv_TruongDonVi_KHMO";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {

                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dtgv_KHMO_hp.DataSource = dataTable;
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Load_MAGV_IntoComboBox()
        {
            try
            {
                string query = "select * from OLS_ADMIN.uv_TruongDonVi_NHANSU";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        cb_manv_pc.Items.Clear();
                        while (reader.Read())
                        {
                            cb_manv_pc.Items.Add(reader["MANV"].ToString());
                        }
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtgv_phancong_hp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgv_KHMO_hp.Rows[e.RowIndex];
                txt_mahp_pc.Text = row.Cells["MAHP"].Value.ToString();
                txt_hocki_pc.Text = row.Cells["HK"].Value.ToString();
                txt_nam_pc.Text = row.Cells["NAM"].Value.ToString();
                txt_mact_pc.Text = row.Cells["MACT"].Value.ToString();
            }
        }
    }
}
