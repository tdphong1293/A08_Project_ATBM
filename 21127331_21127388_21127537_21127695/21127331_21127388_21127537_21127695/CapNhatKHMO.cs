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
    public partial class CapNhatKHMO : Form
    {
        private OracleConnection conn = FormDangNhap.conn;
        public CapNhatKHMO()
        {
            InitializeComponent();
        }

        public void SetData(DataToPass data)
        {
            txt_khmo_mahp.Text = data.Khmo_mahp;
            txt_khmo_hki.Text = data.Khmo_hki;
            txt_khmo_nam.Text = data.Khmo_nam;
            txt_khmo_mact.Text = data.Khmo_mact;

            new_txt_khmo_mahp.Text = data.Khmo_mahp;
            new_txt_khmo_hki.Text = data.Khmo_hki;
            new_txt_khmo_nam.Text = data.Khmo_nam;
            new_txt_khmo_mact.Text = data.Khmo_mact;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int hki = int.Parse(new_txt_khmo_hki.Text);
            int hki_cu = int.Parse(txt_khmo_hki.Text);
            try
            {
                string query = $"select * from OLS_ADMIN.uv_NhanVienCoBan_KHMO where \"MA HOC PHAN\" = '{new_txt_khmo_mahp.Text}'";
                using (OracleCommand command = new OracleCommand(query, conn))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read() && new_txt_khmo_mahp.Text != txt_khmo_mahp.Text)
                        {
                            MessageBox.Show("MAHP đã tồn tại");
                        }
                        else
                        {
                            int namcu = Int32.Parse(txt_khmo_nam.Text);
                            int nammoi = Int32.Parse(new_txt_khmo_nam.Text);
                            string query1 = $"update OLS_ADMIN.uv_NhanVienCoBan_KHMO" +
                                $"  set \"MA HOC PHAN\"= '{new_txt_khmo_mahp.Text}', \"HOC KY\"= {hki}," +
                                $" NAM={nammoi}, \"MA CHUONG TRINH\"= '{new_txt_khmo_mact.Text}'" +
                                $" where \"MA HOC PHAN\"= '{txt_khmo_mahp.Text}' AND \"HOC KY\"= {hki_cu} AND NAM={nammoi} AND \"MA CHUONG TRINH\" = '{txt_khmo_mact.Text}'";
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
                                        MessageBox.Show("Đổi thông tin kế hoạch mở thành công");
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
