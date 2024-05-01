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
        private bool flag_audit;
        private bool flag_fga_audit;
        private FormDangNhap fDN;


        public FormAuditAdmin(bool flag_audit, bool flag_fga_audit)
        {
            InitializeComponent();
            searchSTDAUD = new Timer();
            searchSTDAUD.Interval = 500;
            searchSTDAUD.Tick += searchSTDAUD_Tick;
            searchFGAAUD = new Timer();
            searchFGAAUD.Interval = 500;
            searchFGAAUD.Tick += searchFGAAUD_Tick;

            SearchAndFillSTDAUD("");
            SearchAndFillFGAAUD("");

            this.flag_audit = flag_audit;
            this.flag_fga_audit = flag_fga_audit;
            State_Audit();
            MessageBox.Show(flag_audit.ToString());
            
            dtgv_stdaud.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgv_fgaaud.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        
        private void State_Audit()
        {
            if (flag_audit)
            {
                btn_audit.Text = "Tắt";
                btn_audit.BackColor = Color.Red;
                btn_audit.ForeColor = Color.White;
            }
            else
            {
                btn_audit.Text = "Kích hoạt";
                btn_audit.BackColor = Color.Lime;
                btn_audit.ForeColor = Color.Black;
            }    
        }

        private void ExecuteProcedure(string procedureName)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = procedureName;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
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
                    query = "select USERNAME, OWNER, OBJ_NAME, ACTION, ACTION_NAME, TO_CHAR(EXTENDED_TIMESTAMP, 'DD/MM/YYYY HH24:MI:SS') AS \"EXTENDED_TIMESTAMP\" from DBA_AUDIT_TRAIL WHERE OWNER = 'OLS_ADMIN' AND (ACTION_NAME IN ('SELECT', 'INSERT', 'UPDATE', 'DELETE')) ORDER BY TIMESTAMP desc";
                else
                    query = "select USERNAME, OWNER, OBJ_NAME, ACTION, ACTION_NAME, TO_CHAR(EXTENDED_TIMESTAMP, 'DD/MM/YYYY HH24:MI:SS') AS \"EXTENDED_TIMESTAMP\" from DBA_AUDIT_TRAIL WHERE OWNER = 'OLS_ADMIN' AND (ACTION_NAME IN ('SELECT', 'INSERT', 'UPDATE', 'DELETE')) AND UPPER(USERNAME) LIKE UPPER(:searchtext) ORDER BY TIMESTAMP desc";

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
            SearchAndFillSTDAUD(txt_timkiem_stdaud.Text);
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
                {
                    query = "select DB_USER, OBJECT_SCHEMA, OBJECT_NAME, POLICY_NAME, SQL_TEXT, SQL_BIND, STATEMENT_TYPE, TO_CHAR(EXTENDED_TIMESTAMP, 'DD/MM/YYYY HH24:MI:SS') AS \"EXTENDED_TIMESTAMP\" from DBA_FGA_AUDIT_TRAIL WHERE OBJECT_SCHEMA = 'OLS_ADMIN' AND (STATEMENT_TYPE IN ('SELECT', 'INSERT', 'UPDATE', 'DELETE')) ORDER BY TIMESTAMP desc";
                    statuslabel_fgaaud.Text = "Chưa chọn truy vết nào";
                    txt_username_fgaaud.Text = "";
                    txt_owner_fgaaud.Text = "";
                    txt_object_fgaaud.Text = "";
                    txt_policy_fgaaud.Text = "";
                    tb_statementtype.Text = "";
                    txt_timestamp_fgaaud.Text = "";
                    txt_sqltext_fgaaud.Text = "";
                    txt_sqlbind_fgaaud.Text = "";
                }    
                else
                    query = "select DB_USER, OBJECT_SCHEMA, OBJECT_NAME, POLICY_NAME, SQL_TEXT, SQL_BIND, STATEMENT_TYPE, TO_CHAR(EXTENDED_TIMESTAMP, 'DD/MM/YYYY HH24:MI:SS') AS \"EXTENDED_TIMESTAMP\" from DBA_FGA_AUDIT_TRAIL WHERE OBJECT_SCHEMA = 'OLS_ADMIN' AND (STATEMENT_TYPE IN ('SELECT', 'INSERT', 'UPDATE', 'DELETE')) AND UPPER(DB_USER) LIKE UPPER(:searchtext) ORDER BY TIMESTAMP desc";

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
            SearchAndFillFGAAUD(txt_timkiem_fgaaud.Text);
        }

        

        private void dtgv_fgaaud_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgv_fgaaud.Rows[e.RowIndex];
                txt_username_fgaaud.Text = row.Cells["DB_USER"].Value.ToString();
                txt_owner_fgaaud.Text = row.Cells["OBJECT_SCHEMA"].Value.ToString();
                txt_object_fgaaud.Text = row.Cells["OBJECT_NAME"].Value.ToString();
                txt_policy_fgaaud.Text = row.Cells["POLICY_NAME"].Value.ToString();
                tb_statementtype.Text = row.Cells["STATEMENT_TYPE"].Value.ToString();
                txt_timestamp_fgaaud.Text = row.Cells["EXTENDED_TIMESTAMP"].Value.ToString();
                txt_sqltext_fgaaud.Text = row.Cells["SQL_TEXT"].Value.ToString();
                txt_sqlbind_fgaaud.Text = row.Cells["SQL_BIND"].Value.ToString();

                statuslabel_fgaaud.Text = "Đã chọn truy vết " + tb_statementtype.Text +
                    " được thực hiện bởi " + txt_username_fgaaud.Text;
            }
            else
            {
                statuslabel_fgaaud.Text = "Chưa chọn truy vết nào";
                txt_username_fgaaud.Text = "";
                txt_owner_fgaaud.Text = "";
                txt_object_fgaaud.Text = "";
                txt_policy_fgaaud.Text = "";
                tb_statementtype.Text = "";
                txt_timestamp_fgaaud.Text = "";
                txt_sqltext_fgaaud.Text = "";
                txt_sqlbind_fgaaud.Text = "";
            }
        }

        private void btn_audit_Click(object sender, EventArgs e)
        {
            if(flag_audit)
            {
                ExecuteProcedure("sp_Disable_Audit_UserNV");
                //ExecuteProcedure("sp_Disable_Audit_UserSV");
                
                btn_audit.Text = "Kích hoạt";
                btn_audit.BackColor = Color.Lime;
                btn_audit.ForeColor = Color.Black;
                flag_audit = true;
                
            }
            else
            {
                ExecuteProcedure("sp_Enable_Audit_UserNV");
                //ExecuteProcedure("sp_Enable_Audit_UserSV");
                btn_audit.Text = "Tắt";
                btn_audit.BackColor = Color.Red;
                btn_audit.ForeColor = Color.White;
                flag_audit = false;
            }    
        }

        private void btn_fgaaudit_Click(object sender, EventArgs e)
        {
            if (flag_fga_audit)
            {
                btn_audit.Text = "Đang tắt";
                btn_audit.BackColor = Color.Red;
                btn_audit.ForeColor = Color.White;
                flag_fga_audit = false;
            }
            else
            {
                btn_audit.Text = "Đang kích hoạt";
                btn_audit.BackColor = Color.Lime;
                btn_audit.ForeColor = Color.Black;
                flag_fga_audit = true;
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
