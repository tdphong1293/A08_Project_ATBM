using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _21127331_21127388_21127537_21127695
{
    public partial class FormCapRole : Form
    {
        public static OracleConnection curConn = FormDangNhap.conn;
        private DataTable blankDataTable = new DataTable();
        public FormCapRole()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = checkBox1.Checked ? $"grant {textBox2.Text} to {tb_grantee.Text} with admin option" : $"grant {textBox2.Text} to {tb_grantee.Text}";
            string user_query = $"select u.username, rp.granted_role, rp.admin_option from dba_users u join dba_role_privs rp on u.username = rp.grantee where UPPER(u.USERNAME) = UPPER('{tb_grantee.Text}')";
            string role_query = $"select r.role, rp.granted_role, rp.admin_option from dba_roles r join dba_role_privs rp on r.role = rp.grantee where UPPER(r.ROLE) = UPPER('{tb_grantee.Text}')";

            try
            {
                using (OracleCommand command = new OracleCommand(query, curConn))
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Cấp Role thành công");
                    textBox2.Text = "";
                    command.CommandText = user_query;
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            DataTable resultTable = new DataTable();
                            resultTable.Load(reader);
                            dataGridView1.DataSource = resultTable;
                        }
                    }

                    command.CommandText = role_query;
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            DataTable resultTable = new DataTable();
                            resultTable.Load(reader);
                            dataGridView1.DataSource = resultTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void tb_grantee_TextChanged(object sender, EventArgs e)
        {
            string user_query = $"select u.username, rp.granted_role, rp.admin_option from dba_users u join dba_role_privs rp on u.username = rp.grantee where UPPER(u.USERNAME) = UPPER('{tb_grantee.Text}')";
            string role_query = $"select r.role, rp.granted_role, rp.admin_option from dba_roles r join dba_role_privs rp on r.role = rp.grantee where UPPER(r.ROLE) = UPPER('{tb_grantee.Text}')";

            try
            {
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = curConn;
                    command.CommandText = user_query;
                    if(dataGridView1.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = blankDataTable;
                        button1.Enabled = false;
                    }

                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            DataTable resultTable = new DataTable();
                            resultTable.Load(reader);
                            dataGridView1.DataSource = resultTable;
                        }
                    }

                    command.CommandText = role_query;
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            DataTable resultTable = new DataTable();
                            resultTable.Load(reader);
                            dataGridView1.DataSource = resultTable;
                        }
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string grantee = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string role = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string msg = $"Bạn có chắc muốn thu hồi role {role} của {grantee} không?";
            DialogResult dr = MessageBox.Show(msg, "Revoke Role", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    string query = $"REVOKE {role} FROM {grantee}";
                    string user_query = $"select u.username, rp.granted_role, rp.admin_option from dba_users u join dba_role_privs rp on u.username = rp.grantee where UPPER(u.USERNAME) = UPPER('{tb_grantee.Text}')";
                    string role_query = $"select r.role, rp.granted_role, rp.admin_option from dba_roles r join dba_role_privs rp on r.role = rp.grantee where UPPER(r.ROLE) = UPPER('{tb_grantee.Text}')";
                    try
                    {
                        using (OracleCommand command = new OracleCommand(query, curConn))
                        {
                            command.ExecuteNonQuery();
                            MessageBox.Show("Thu hồi role thành công");
                            textBox2.Text = ""; 
                            command.CommandText = user_query;

                            if(dataGridView1.Rows.Count > 0)
                            {
                                dataGridView1.DataSource = blankDataTable;
                                button1.Enabled = false;
                            }

                            using (OracleDataReader reader = command.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    DataTable resultTable = new DataTable();
                                    resultTable.Load(reader);
                                    dataGridView1.DataSource = resultTable;
                                }
                            }

                            command.CommandText = role_query;
                            using (OracleDataReader reader = command.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    DataTable resultTable = new DataTable();
                                    resultTable.Load(reader);
                                    dataGridView1.DataSource = resultTable;
                                }
                            }
                        }

                    }
                    catch(OracleException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                button1.Enabled = true;
            }
        }
    }
}
