using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21127331_21127388_21127537_21127695
{
    public partial class SDT : Form
    {
        private OracleConnection conn = FormDangNhap.conn;
        string ID;
        public SDT(string ID)
        {
            InitializeComponent();
            GetSDT(ID);
            this.ID = ID;
        }
        
        void GetSDT(string ID)
        {
            try
            {
                string query = "select DT from OLS_ADMIN.uv_NhanVienCoBan_NHANSU where MANV = '" + ID + "'";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                          label2.Text = reader["DT"].ToString();
                        }
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
          
      

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "update OLS_ADMIN.uv_NhanVienCoBan_NHANSU set DT='" + textBox1.Text + "' where MANV = '" + ID + "'";
            OracleTransaction transaction = null;
            try
            {

                transaction = conn.BeginTransaction();

                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.Transaction = transaction;


                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected != 0)
                {
                    MessageBox.Show("Da cap nhat");
                }
                transaction.Commit();
                transaction.Dispose();

            }
            catch (OracleException ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
        }
    }
}
