using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21127331_21127388_21127537_21127695
{

    public partial class FormCapQuyen : Form
    {
        public static OracleConnection curConn = FormDangNhap.conn;
        private FormQuanLy lastForm;
        private List<string> owner_name = new List<string>();
        private List<string> tab_view_name = new List<string>();

        public FormCapQuyen(FormQuanLy lastForm)
        {
            InitializeComponent();
            this.lastForm = lastForm;

            comboBox1.DisplayMember = "Text";
            comboBox1.ValueMember = "Value";
            comboBox1.Items.Add(new { Text = "SELECT", Value = "SELECT" });
            comboBox1.Items.Add(new { Text = "UPDATE", Value = "UPDATE" });
            comboBox1.Items.Add(new { Text = "DELETE", Value = "DELETE" });
            comboBox1.Items.Add(new { Text = "INSERT", Value = "INSERT" });
            label3.Text = "Không tồn tại";
            init();
        }

        private void init()
        {
            string tab_query = "SELECT owner, table_name FROM all_tables where OWNER not in ('SYS', 'OUTLN', 'SYSTEM', 'ORDDATA', 'AUDSYS', 'DBSNMP', 'GSMADMIN_INTERNAL',\r\n    'APPQOSSYS', 'XDB', 'WMSYS', 'OJVMSYS', 'CTXSYS', 'MDSYS', 'OLAPSYS', 'LBACSYS', 'DVSYS', 'ORDSYS', 'DBSFWUSER')";
            string view_query = "SELECT owner, view_name FROM all_views where OWNER not in ('SYS', 'OUTLN', 'SYSTEM', 'ORDDATA', 'AUDSYS', 'DBSNMP', 'GSMADMIN_INTERNAL',\r\n    'APPQOSSYS', 'XDB', 'WMSYS', 'OJVMSYS', 'CTXSYS', 'MDSYS', 'OLAPSYS', 'LBACSYS', 'DVSYS', 'ORDSYS', 'DBSFWUSER')";
            try
            {
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = curConn;
                    command.CommandText = tab_query;
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBox2.Items.Add(reader.GetString(1));
                            owner_name.Add(reader.GetString(0));
                            tab_view_name.Add(reader.GetString(1));
                        }
                    }

                    command.CommandText = view_query;
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBox2.Items.Add(reader.GetString(1));
                            owner_name.Add(reader.GetString(0));
                            tab_view_name.Add(reader.GetString(1));
                        }
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

         private void init2(){
            string query = $"SELECT column_name FROM DBA_TAB_COLUMNS WHERE table_name = '{comboBox2.Text}'";
            using (OracleCommand command = new OracleCommand(query, curConn))
            {
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        checkedListBox1.Items.Add(reader.GetString(0));
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            string query = $"select * from DBA_USERS where UPPER(USERNAME) = UPPER('{text}')";
            string query2 = $"select * from DBA_ROLES where UPPER(ROLE) = UPPER('{text}')";
            try
            {
                using (OracleCommand command = new OracleCommand(query, curConn))
                {
                    command.Connection = curConn;
                    command.CommandText = query;
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            label3.Text = "User tồn tại";
                            checkBox1.Enabled = true;
                            comboBox1.Enabled = true;
                            comboBox2.Enabled = true;
                            return;
                        }
                        else
                        {
                            label3.Text = "Không tồn tại";
                            checkBox1.Enabled = false;
                            comboBox1.Enabled = false;
                            comboBox2.Enabled = false;
                        }
                    }

                    command.CommandText = query2;
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            label3.Text = "Role tồn tại";
                            checkBox1.Enabled = true;
                            comboBox1.Enabled = true;
                            comboBox2.Enabled = true;
                            return;
                        }
                        else
                        {
                            label3.Text = "Không tồn tại";
                            checkBox1.Enabled = false;
                            comboBox1.Enabled = false;
                            comboBox2.Enabled = false;
                        }
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            if ((comboBox1.Text == "UPDATE" || comboBox1.Text == "SELECT") && comboBox2.SelectedIndex != -1)
            {
                init2();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count > 0)
            {
                string all_column = "";
                for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
                {
                    if (i == 0)
                        all_column += checkedListBox1.CheckedItems[i];
                    else 
                        all_column += ", " + checkedListBox1.CheckedItems[i];
                }

                if (comboBox1.Text == "SELECT")
                {
                    string grant_privs = $"grant select on {owner_name[comboBox2.SelectedIndex]}.{comboBox2.Text} to C##ADMIN";
                    string query = $"CREATE OR REPLACE VIEW C##ADMIN.{textBox1.Text}_{comboBox1.Text}_{comboBox2.Text} AS SELECT {all_column} FROM {owner_name[comboBox2.SelectedIndex]}.{comboBox2.Text}";
                    string grant = checkBox1.Checked ? $"GRANT {comboBox1.Text} ON C##ADMIN.{textBox1.Text}_{comboBox1.Text}_{comboBox2.Text} TO {textBox1.Text} WITH GRANT OPTION" : $"GRANT {comboBox1.Text} ON C##ADMIN.{textBox1.Text}_{comboBox1.Text}_{comboBox2.Text} TO {textBox1.Text}";
                    try
                    {
                        using (OracleCommand command1 = new OracleCommand())
                        {
                            command1.Connection = curConn;
                            command1.CommandText = grant_privs;
                            command1.ExecuteNonQuery();

                            command1.CommandText = query;
                            command1.ExecuteNonQuery();

                            command1.CommandText = grant;
                            command1.ExecuteNonQuery();
                        }
                        MessageBox.Show("Cấp quyền thành công");
                        lastForm.SearchAndReloadGrantee(textBox1.Text);
                        lastForm.SearchAndReloadColumn(textBox1.Text);
                        lastForm.grant_revoke_change(textBox1.Text);
                        this.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }
                else 
                {
                    string query = checkBox1.Checked ? $"GRANT {comboBox1.Text}({all_column}) ON {owner_name[comboBox2.SelectedIndex]}.{comboBox2.Text} TO {textBox1.Text} WITH GRANT OPTION" : $"GRANT {comboBox1.Text}({all_column}) ON {owner_name[comboBox2.SelectedIndex]}.{comboBox2.Text} TO {textBox1.Text}";
                    try
                    {
                        using (OracleCommand command = new OracleCommand(query, curConn))
                        {
                            command.ExecuteNonQuery();
                        }
                        MessageBox.Show("Cấp quyền thành công");
                        lastForm.SearchAndReloadGrantee(textBox1.Text);
                        lastForm.SearchAndReloadColumn(textBox1.Text);
                        lastForm.grant_revoke_change(textBox1.Text);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }
            }
            else
            {
                string query = checkBox1.Checked ? $"GRANT {comboBox1.Text} ON {owner_name[comboBox2.SelectedIndex]}.{comboBox2.Text} TO {textBox1.Text} WITH GRANT OPTION" : $"GRANT {comboBox1.Text} ON {owner_name[comboBox2.SelectedIndex]}.{comboBox2.Text} TO {textBox1.Text}";
                try
                {
                    using (OracleCommand command = new OracleCommand(query, curConn))
                    {
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("Cấp quyền thành công");
                    lastForm.SearchAndReloadGrantee(textBox1.Text);
                    lastForm.SearchAndReloadColumn(textBox1.Text);
                    lastForm.grant_revoke_change(textBox1.Text);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }

        private void btn_capquyen_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            if ((comboBox1.Text == "UPDATE" || comboBox1.Text == "SELECT") && comboBox2.SelectedIndex != -1)
            {
                init2();
            }
        }
    }
}
