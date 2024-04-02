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
using System.Timers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography.X509Certificates;

namespace _21127331_21127388_21127537_21127695
{
    public partial class FormQuanLy : Form
    {
        public static OracleConnection curConn = FormDangNhap.conn;
        public static System.Timers.Timer UserTimer, RoleTimer, GranteeTimer;
        public static string lastSearchUser, lastSearchRole, lastSearchGrantee;
        public string msg, grantee, owner_name, tab_view_name, privilege;
        public FormQuanLy()
        {

            InitializeComponent();
            dtgv_column_privs.SelectionChanged += dtgv_column_privs_SelectionChanged;
            dtgv_table_privs.SelectionChanged += dtgv_table_privs_SelectionChanged;
            UserTimer = new System.Timers.Timer();
            UserTimer.Interval = 500; // Set the delay time (500 milliseconds in this case)
            UserTimer.Elapsed += OnTimedEvent1;

            RoleTimer = new System.Timers.Timer();
            RoleTimer.Interval = 500; // Set the delay time (500 milliseconds in this case)
            RoleTimer.Elapsed += OnTimedEvent2;

            GranteeTimer = new System.Timers.Timer();
            GranteeTimer.Interval = 500; // Set the delay time (500 milliseconds in this case)
            GranteeTimer.Elapsed += OnTimedEvent3;

            SearchAndReloadUser("");
            SearchAndReloadRole("");
            SearchAndReloadGrantee("");
            SearchAndReloadColumn("");

            dgv_role.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv_user.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgv_table_privs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_column_privs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void grant_revoke_change(string name)
        {
            tb_grantee.Text = name;
        }

        private void tb_user_TextChanged(object sender, EventArgs e)
        {
            // Reset the timer whenever the text changes
            UserTimer.Stop();
            UserTimer.Start();
        }

        private void tb_role_TextChanged(object sender, EventArgs e)
        {
            // Reset the timer whenever the text changes
            RoleTimer.Stop();
            RoleTimer.Start();
        }

        private void tb_grantee_TextChanged(object sender, EventArgs e)
        {
            // Reset the timer whenever the text changes
            GranteeTimer.Stop();
            GranteeTimer.Start();
        }

        private void OnTimedEvent1(Object source, ElapsedEventArgs e)
        {
            UserTimer.Stop();
            if (lastSearchUser != tb_user.Text)
            {
                lastSearchUser = tb_user.Text;
                this.Invoke(new Action(() => SearchAndReloadUser(lastSearchUser)));
            }
        }

        private void OnTimedEvent2(Object source, ElapsedEventArgs e)
        {
            RoleTimer.Stop();
            if (lastSearchRole != tb_role.Text)
            {
                lastSearchRole = tb_role.Text;
                this.Invoke(new Action(() => SearchAndReloadRole(lastSearchRole)));
            }
        }

        private void OnTimedEvent3(Object source, ElapsedEventArgs e)
        {
            GranteeTimer.Stop();
            if (lastSearchGrantee != tb_grantee.Text)
            {
                lastSearchGrantee = tb_grantee.Text;
                this.Invoke(new Action(() => SearchAndReloadGrantee(lastSearchGrantee)));
                this.Invoke(new Action(() => SearchAndReloadColumn(lastSearchGrantee)));
            }
        }

        public void SearchAndReloadGrantee(string searchText)
        {
            string query = string.IsNullOrEmpty(searchText) ? "select * from (select * from DBA_TAB_PRIVS where ROWNUM <= 200)" : $"select * from DBA_TAB_PRIVS where UPPER(Grantee) like UPPER('%{searchText}%')";
            ReloadData(query, dtgv_table_privs);
        }

        public void SearchAndReloadColumn(string searchText)
        {
            string query = string.IsNullOrEmpty(searchText) ? "select * from DBA_COL_PRIVS where ROWNUM <= 200" : $"select * from DBA_COL_PRIVS where UPPER(Grantee) like UPPER('%{searchText}%')";
            ReloadData(query, dtgv_column_privs);
        }

        public void SearchAndReloadUser(string searchText)
        {
            // Perform the search and reload the DataGridView1
            string query = string.IsNullOrEmpty(searchText) ? "select * from DBA_USERS" : $"select * from DBA_USERS where UPPER(USERNAME) like UPPER('%{searchText}%')";
            ReloadData(query, dgv_user);
        }

        private void btn_taouser_Click(object sender, EventArgs e)
        {
            FormTaoUser formTaoUser = new FormTaoUser(this);
            formTaoUser.ShowDialog();   
        }

        private void btn_xoauser_Click(object sender, EventArgs e)
        {
            FormXoaUser formXoaUser = new FormXoaUser(this);
            formXoaUser.ShowDialog();
        }

        private void btn_chinhsuauser_Click(object sender, EventArgs e)
        {
            FormChinhSuaUser formChinhSuaUser = new FormChinhSuaUser();
            formChinhSuaUser.ShowDialog();
        }

        private void btn_taorole_Click(object sender, EventArgs e)
        {
            FormTaoRole formTaoRole = new FormTaoRole(this);
            formTaoRole.ShowDialog();
        }

        private void btn_CapQuyenUserRole_Click(object sender, EventArgs e)
        {
            FormCapQuyen formcapquyen = new FormCapQuyen(this);
            formcapquyen.ShowDialog();
        }

        private void btn_RevokeUserRole_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(msg, "Revoke Privilege", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    string query = $"REVOKE {privilege} ON {owner_name}.{tab_view_name} FROM {grantee}";
                    using (OracleCommand command = new OracleCommand(query, curConn))
                    {
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("Thu hồi quyền thành công");
                    SearchAndReloadColumn(grantee);
                    SearchAndReloadGrantee(grantee);
                    tb_grantee.Text = grantee;
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCapRole formCapRole = new FormCapRole();
            formCapRole.Show();
        }

     
        private void btn_xoarole_Click(object sender, EventArgs e)
        {
            FormXoaRole formXoaRole = new FormXoaRole(this);
            formXoaRole.ShowDialog();
        }

        private void btn_chinhsuarole_Click(object sender, EventArgs e)
        {
            FormChinhSuaRole formChinhSuaRole = new FormChinhSuaRole();
            formChinhSuaRole.ShowDialog();
        }

        public void SearchAndReloadRole(string searchText)
        {
            // Perform the search and reload the DataGridView2
            string query = string.IsNullOrEmpty(searchText) ? "select * from DBA_ROLES" : $"select * from DBA_ROLES where UPPER(ROLE) like UPPER('%{searchText}%')";
            ReloadData(query, dgv_role);
        }

        private void ReloadData(string query, DataGridView dataGridView)
        {
            using (OracleCommand command = new OracleCommand(query, curConn))
            {
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    DataTable resultTable = new DataTable();
                    resultTable.Load(reader);
                    dataGridView.DataSource = resultTable;
                }
            }
        }

        private void dtgv_table_privs_SelectionChanged(object sender, EventArgs e)
        {
            // Check if any row is selected
            if (dtgv_table_privs.SelectedRows.Count > 0)
            {
                btn_RevokeUserRole.Enabled = true;
                DataGridViewRow selectedRow = dtgv_table_privs.SelectedRows[0];
                grantee = selectedRow.Cells[0].Value.ToString();
                owner_name = selectedRow.Cells[1].Value.ToString();
                tab_view_name = selectedRow.Cells[2].Value.ToString();
                privilege = selectedRow.Cells[4].Value.ToString();
                msg = $"Bạn có chắc muốn hủy quyền {privilege} trên {tab_view_name} của {grantee} không?";
            }
        }
        private void dtgv_column_privs_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgv_column_privs.SelectedRows.Count > 0)
            {
                btn_RevokeUserRole.Enabled = true;
                DataGridViewRow selectedRow = dtgv_column_privs.SelectedRows[0];
                grantee = selectedRow.Cells[0].Value.ToString();
                owner_name = selectedRow.Cells[1].Value.ToString();
                tab_view_name = selectedRow.Cells[2].Value.ToString();
                privilege = selectedRow.Cells[5].Value.ToString();
                msg = $"Bạn có chắc muốn hủy quyền {privilege} trên {tab_view_name} của {grantee} không?";
            }
        }

    }
}