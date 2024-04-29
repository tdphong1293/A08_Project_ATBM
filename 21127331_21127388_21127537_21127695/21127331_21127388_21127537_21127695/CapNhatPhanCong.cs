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
using static _21127331_21127388_21127537_21127695.GiaoVu;

namespace _21127331_21127388_21127537_21127695
{
    public partial class CapNhatPhanCong : Form
    {
        private OracleConnection conn = FormDangNhap.conn;
        public CapNhatPhanCong()
        {
            InitializeComponent();
        }

        public void SetData(DataToPass data)
        {
            magv.Text = data.Pc_magv;
            mahp.Text = data.Pc_mahp;
            nam.Text = data.Pc_nam;
            hki.Text = data.Pc_hk;
            mact.Text = data.Pc_mact;
            oldmagv.Text = data.Pc_magv;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int hk = int.Parse(hki.Text);
            int namm = int.Parse(nam.Text);
            try
            {
                string query = $"select * from OLS_ADMIN.uv_GiaoVu_PHANCONG WHERE MAGV= '{magv.Text}' AND MAHP = '{mahp.Text}' AND HK= {hk} AND NAM= {namm} AND MACT = '{mact.Text}'";
                using (OracleCommand command = new OracleCommand(query, conn))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read() && oldmagv.Text != magv.Text)
                        {
                            MessageBox.Show("Phân công đã tồn tại");
                        }
                        else
                        {
                            string query1 = $"update OLS_ADMIN.uv_GiaoVu_PHANCONG" +
                                $"  set MAGV = '{magv.Text}' WHERE MAHP = '{mahp.Text}' AND HK= {hk} AND NAM = {namm} AND MACT = '{mact.Text}'";
                            Debug.WriteLine(query1);
                            using (OracleTransaction trans = conn.BeginTransaction())
                            {
                                using (OracleCommand cmd = new OracleCommand(query1, conn))
                                {
                                    try
                                    {
                                        cmd.Transaction = trans;
                                        cmd.ExecuteNonQuery();
                                        trans.Commit();
                                        MessageBox.Show("Chỉnh sửa phân công thành công");
                                        this.Close();
                                    }

                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                        return;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
