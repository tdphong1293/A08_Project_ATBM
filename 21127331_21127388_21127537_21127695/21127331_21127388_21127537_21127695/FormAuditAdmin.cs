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
    public partial class FormAuditAdmin : Form
    {
        private OracleConnection conn = FormDangNhap.conn;
        private Timer searchSTDAUD, searchFGAAUD;

        public FormAuditAdmin()
        {
            InitializeComponent();
            searchSTDAUD = new Timer();
            searchSTDAUD.Interval = 500;
            searchSTDAUD.Tick += searchSTDAUD_Tick;
            searchFGAAUD = new Timer();
            searchFGAAUD.Interval = 500;
            searchFGAAUD.Tick += searchFGAAUD_Tick;
        }

        private void txt_timkiem_stdaud_TextChanged(object sender, EventArgs e)
        {
            searchSTDAUD.Stop();
            searchSTDAUD.Start();
        }

        private void SearchAndFillSTDAUD(string searchtext)
        {
            try
            {
                string query;
                if (string.IsNullOrEmpty(searchtext))
                    query = "select USERNAME, OWNER, OBJ_NAME, ACTION, ACTION_NAME, TO_CHAR(EXTENDED_TIMESTAMP, 'DD/MM/YYYY HH24:MI:SS') AS \"EXTENDED_TIMESTAMP\" from DBA_AUDIT_TRAIL WHERE OWNER = 'OLS_ADMIN' AND (ACTION_NAME IN ('SELECT', 'INSERT', 'UPDATE', 'DELETE'))";
                else
                    query = "select USERNAME, OWNER, OBJ_NAME, ACTION, ACTION_NAME, TO_CHAR(EXTENDED_TIMESTAMP, 'DD/MM/YYYY HH24:MI:SS') AS \"EXTENDED_TIMESTAMP\" from DBA_AUDIT_TRAIL WHERE OWNER = OLS_ADMIN' AND (ACTION_NAME IN ('SELECT', 'INSERT', 'UPDATE', 'DELETE')) AND UPPER(USERNAME) LIKE UPPER(:searchtext)";

                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add(":searchtext", "%" + searchtext + "%");
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dtgv_stdaud.DataSource = dataTable;
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void searchSTDAUD_Tick(object sender, EventArgs e)
        {
            searchSTDAUD.Stop();
            SearchAndFillSTDAUD(txt_time_stdaud.Text);
        }

        private void dtgv_stdaud_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgv_stdaud.Rows[e.RowIndex];
                txt_username_stdaud.Text = row.Cells["USERNAME"].Value.ToString();
                txt_owner_stdaud.Text = row.Cells["OWNER"].Value.ToString();
                txt_object_stdaud.Text = row.Cells["OBJ_NAME"].Value.ToString();
                txt_action_code_stdaud.Text = row.Cells["ACTION"].Value.ToString();
                txt_action_name_stdaud.Text = row.Cells["ACTION_NAME"].Value.ToString();
                txt_time_stdaud.Text = row.Cells["EXTENDED_TIMESTAMP"].Value.ToString();
                statuslabel_stdaud.Text = "Đã chọn truy vết " + txt_action_name_stdaud.Text +
                    " được thực hiện bởi " + txt_username_stdaud.Text;
            }
            else
            {
                statuslabel_stdaud.Text = "Chưa chọn truy vết nào";
                txt_username_stdaud.Text = "";
                txt_owner_stdaud.Text = "";
                txt_object_stdaud.Text = "";
                txt_action_code_stdaud.Text = "";
                txt_action_name_stdaud.Text = "";
                txt_time_stdaud.Text = "";
                statuslabel_stdaud.Text = "";
            }
        }

        private void txt_timkiem_fgaaud_TextChanged(object sender, EventArgs e)
        {
            searchFGAAUD.Stop();
            searchFGAAUD.Start();
        }

        private void SearchAndFillFGAAUD(string searchtext)
        {
            try
            {
                string query;
                if (string.IsNullOrEmpty(searchtext))
                    query = "select USERNAME, OWNER, OBJ_NAME, ACTION, ACTION_NAME, TO_CHAR(EXTENDED_TIMESTAMP, 'DD/MM/YYYY HH24:MI:SS') AS \"EXTENDED_TIMESTAMP\", SQL_TEXT from DBA_FGA_AUDIT_TRAIL WHERE OWNER = 'OLS_ADMIN' AND (ACTION_NAME IN ('SELECT', 'INSERT', 'UPDATE', 'DELETE'))";
                else
                    query = "select USERNAME, OWNER, OBJ_NAME, ACTION, ACTION_NAME, TO_CHAR(EXTENDED_TIMESTAMP, 'DD/MM/YYYY HH24:MI:SS') AS \"EXTENDED_TIMESTAMP\", SQL_TEXT from DBA_FGA_AUDIT_TRAIL WHERE OWNER = OLS_ADMIN' AND (ACTION_NAME IN ('SELECT', 'INSERT', 'UPDATE', 'DELETE')) AND UPPER(USERNAME) LIKE UPPER(:searchtext)";

                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add(":searchtext", "%" + searchtext + "%");
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dtgv_fgaaud.DataSource = dataTable;
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void searchFGAAUD_Tick(object sender, EventArgs e)
        {
            searchFGAAUD.Stop();
            SearchAndFillFGAAUD(txt_time_fgaaud.Text);
        }

        private void dtgv_fgaaud_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgv_fgaaud.Rows[e.RowIndex];
                txt_username_stdaud.Text = row.Cells["USERNAME"].Value.ToString();
                txt_owner_stdaud.Text = row.Cells["OWNER"].Value.ToString();
                txt_object_stdaud.Text = row.Cells["OBJ_NAME"].Value.ToString();
                txt_action_code_stdaud.Text = row.Cells["ACTION"].Value.ToString();
                txt_action_name_stdaud.Text = row.Cells["ACTION_NAME"].Value.ToString();
                txt_time_stdaud.Text = row.Cells["EXTENDED_TIMESTAMP"].Value.ToString();
                txt_command_fgaaud.Text = row.Cells["SQL_TEXT"].Value.ToString();
                statuslabel_stdaud.Text = "Đã chọn truy vết " + txt_action_name_stdaud.Text +
                    " được thực hiện bởi " + txt_username_stdaud.Text;
            }
            else
            {
                statuslabel_stdaud.Text = "Chưa chọn truy vết nào";
                txt_username_stdaud.Text = "";
                txt_owner_stdaud.Text = "";
                txt_object_stdaud.Text = "";
                txt_action_code_stdaud.Text = "";
                txt_action_name_stdaud.Text = "";
                txt_time_stdaud.Text = "";
                txt_command_fgaaud.Text = "";
                statuslabel_stdaud.Text = "";
            }
        }
    }
}
