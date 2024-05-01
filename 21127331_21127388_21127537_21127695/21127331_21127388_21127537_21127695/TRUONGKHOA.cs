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
    public partial class TRUONGKHOA : Form
    {
        private OracleConnection conn = FormDangNhap.conn;
        string hk, nam, mahp, magv, mact;
        string oldmanv, oldmahp, oldhk, oldnam, oldmact;
        string ID;
        bool show;
        public TRUONGKHOA(string ID)
        {
     
        InitializeComponent();
            label2.Text = ID;
            this.ID = ID;
            dataGridView10.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SearchAndFill_SinhVien("");
            SearchAndFill_DonVi("");
            SearchAndFill_HocPhan("");
            SearchAndFill_KHMO("");
            SearchAndFill_PhanCong("");
            SearchAndFill_DangKy("","","");
            SearchAndFill_PhanCong_TK("");
            SearchAndFill_NhanSu("");
            comboBox8.Items.Add("DANGKY");
            comboBox8.Items.Add("DONVI");
            comboBox8.Items.Add("HOCPHAN");
            comboBox8.Items.Add("KHMO");
            comboBox8.Items.Add("NHANSU");
            comboBox8.Items.Add("PHANCONG");
            comboBox8.Items.Add("SINHVIEN");
            comboBox6.Items.Add("1");
            comboBox6.Items.Add("2");
            comboBox6.Items.Add("3");
            comboBox7.Items.Add("CLC");
            comboBox7.Items.Add("CQ");
            comboBox7.Items.Add("CTTT");
            comboBox7.Items.Add("VP");
            comboBox4.Items.Add("Nam");
            comboBox4.Items.Add("Nữ");
            comboBox3.Items.Add("Nhân viên cơ bản");
            comboBox3.Items.Add("Giảng viên");
            comboBox3.Items.Add("Trưởng khoa");
            comboBox3.Items.Add("Trưởng đơn vị");
            comboBox3.Items.Add("Giáo vụ");
            dataGridView7.CellContentClick += dataGridView7_CellContentClick;
            dataGridView9.CellContentClick += dataGridView9_CellContentClick;
            dataGridView6.CellContentClick += dataGridView6_CellContentClick;
          
        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchAndFill_SinhVien(string searchtext)
        {
            try
            {
                string query;
                if (string.IsNullOrEmpty(searchtext))
                    query = "select * from OLS_ADMIN.uv_NhanVienCoBan_SINHVIEN";
                else
                    query = "select * from OLS_ADMIN.uv_NhanVienCoBan_SINHVIEN where UPPER(HOTEN) like  UPPER(:unicodetext) or MASV = :searchtext";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add(":unicodetext", OracleDbType.NVarchar2, "%" + searchtext + "%", ParameterDirection.Input);
                    cmd.Parameters.Add(":searchtext", searchtext);
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SearchAndFill_DonVi(string searchtext)
        {
            try
            {
                string query;
                if (string.IsNullOrEmpty(searchtext))
                    query = "select * from OLS_ADMIN.uv_NhanVienCoBan_DONVI";
                else
                    query = "select * from OLS_ADMIN.uv_NhanVienCoBan_DONVI where UPPER(TENDV) like UPPER(:unicodetext) or MADV = :searchtext";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add(":unicodetext", OracleDbType.NVarchar2, "%" + searchtext + "%", ParameterDirection.Input);
                    cmd.Parameters.Add(":searchtext", searchtext);
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dataGridView2.DataSource = dataTable;
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SearchAndFill_HocPhan(string searchtext)
        {
            try
            {
                string query;
                if (string.IsNullOrEmpty(searchtext))
                    query = "select * from OLS_ADMIN.uv_NhanVienCoBan_HOCPHAN";
                else
                    query = "select * from OLS_ADMIN.uv_NhanVienCoBan_HOCPHAN where UPPER(TENHP) like UPPER(:unicodetext) or MAHP = :searchtext";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add(":unicodetext", OracleDbType.NVarchar2, "%" + searchtext + "%", ParameterDirection.Input);
                    cmd.Parameters.Add(":searchtext", searchtext);
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dataGridView3.DataSource = dataTable;
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SearchAndFill_NhanSu(string searchtext)
        {
            try
            {
                string query;
                if (string.IsNullOrEmpty(searchtext))
                    query = "select * from OLS_ADMIN.uv_Truongkhoa_nhansu";
                else
                    query = "select * from OLS_ADMIN.uv_truongkhoa_nhansu where UPPER(HOTEN) like UPPER(:unicodetext) or DT = :searchtext";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add(":unicodetext", OracleDbType.NVarchar2, "%" + searchtext + "%", ParameterDirection.Input);
                    cmd.Parameters.Add(":searchtext", searchtext);
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dataGridView9.DataSource = dataTable;
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SearchAndFill_KHMO(string searchtext)
        {
            try
            {
                string query;
                if (string.IsNullOrEmpty(searchtext))
                    query = "select * from OLS_ADMIN.uv_NhanVienCoBan_KHMO";
                else
                    query = "select * from OLS_ADMIN.uv_NhanVienCoBan_KHMO where MAHP = :searchtext";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add(":searchtext", searchtext);
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dataGridView4.DataSource = dataTable;
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SearchAndFill_PhanCong(string searchtext)
        {
            try
            {
                string query;
                if (string.IsNullOrEmpty(searchtext))
                    query = "select * from OLS_ADMIN.uv_GiangVien_PHANCONG";
                else
                    query = "select * from OLS_ADMIN.uv_GiangVien_PHANCONG where \"MA HOC PHAN\" = :searchtext";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add(":searchtext", searchtext);
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dataGridView5.DataSource = dataTable;
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SearchAndFill_PhanCong_TK(string searchtext)
        {
            try
            {
                string query;
               // if (string.IsNullOrEmpty(searchtext))
                    query = "select * from OLS_ADMIN.uv_TRUONGKHOA_PHANCONG";
               // else
               // query = "select * from OLS_ADMIN.uv_TRUONGKHOA_PHANCONG where \"MA HOC PHAN\" = :searchtext";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add(":searchtext", searchtext);
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dataGridView7.DataSource = dataTable;
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SearchAndFill_DangKy(string year, string sem, string code)
        {
            try
            {
                string query;
                if (string.IsNullOrEmpty(code))
                    query = "select * from OLS_ADMIN.uv_GiangVien_DANGKY";
                else
                    query = "select * from OLS_ADMIN.uv_GiangVien_DANGKY where NAM = :year or MAHP = :code or HK = :sem";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add(":year", year);
                    cmd.Parameters.Add(":code", code);
                    cmd.Parameters.Add(":sem", sem);
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dataGridView6.DataSource = dataTable;
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

        }

        private void tabPage9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                DataGridViewRow row = dataGridView7.Rows[e.RowIndex];
                textBox7.Text = row.Cells["MAGV"].Value.ToString();
                textBox8.Text = row.Cells["MAHP"].Value.ToString();
                comboBox6.Text = row.Cells["HK"].Value.ToString();
                textBox9.Text = row.Cells["NAM"].Value.ToString();
                comboBox7.Text = row.Cells["MACT"].Value.ToString();
                oldmanv = textBox7.Text;
                oldmahp = textBox8.Text;
                oldhk = comboBox6.Text;
                oldnam = textBox9.Text;
                oldmact = comboBox7.Text;
            }
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            string table="";
            switch (comboBox8.Text)
            {
                case "DANGKY":
                    table = "uv_giaovu_dangky";
                    break;
                case "DONVI":
                    table = "uv_nhanviencoban_donvi";
                    break;
                case "HOCPHAN":
                    table = "uv_nhanviencoban_hocphan";
                    break;
                case "KHMO":
                    table = "uv_nhanviencoban_khmo";
                    break;
                case "NHANSU":
                    table = "uv_truongkhoa_nhansu";
                    break;
                case "PHANCONG":
                    table = "uv_truongkhoa_phancong";
                    break;
                case "SINHVIEN":
                    table = "uv_nhanviencoban_sinhvien";
                    break;
              
            }
            string query = "select * from OLS_ADMIN." + table;
            using (OracleCommand cmd = new OracleCommand(query, conn))
            {
                using (OracleDataReader reader = cmd.ExecuteReader())
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    dataGridView8.DataSource = dataTable;
                }
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            SearchAndFill_DangKy(textBox6.Text, comboBox2.Text, comboBox1.Text);
        }

       

       

        private void button4_Click(object sender, EventArgs e)
        {
            string query = "insert into OLS_ADMIN.uv_TRUONGKHOA_PHANCONG values ('"+textBox7.Text+"', '"+textBox8.Text+"', '"+comboBox6.Text+"', "+textBox9.Text+", '"+comboBox7.Text+"')";
            OracleTransaction transaction = null;
            try
            {

                transaction = conn.BeginTransaction();

                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.Transaction = transaction;


                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected == 0)
                {
                    MessageBox.Show("No rows updated. Check the MANV value.");
                }
                else
                {
                    MessageBox.Show($"{rowsAffected} row(s) updated.");
                }
                transaction.Commit();
                

            }
            catch (OracleException ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
            transaction.Dispose();
            SearchAndFill_PhanCong_TK("");
        }


        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e) 
        {
            
            string query = "update OLS_ADMIN.uv_TRUONGKHOA_PHANCONG set HK="+comboBox6.Text+" , NAM="+textBox9.Text+" , MACT='"+comboBox7.Text+"' where MAGV='"+oldmanv+"' and MAHP='"+oldmahp+"' and HK="+oldhk+" and NAM ='"+oldnam+"' and MACT='"+oldmact+"'";
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
            SearchAndFill_PhanCong_TK("");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "delete from OLS_ADMIN.uv_TRUONGKHOA_PHANCONG where MAGV='"+textBox7.Text+"' and MAHP='"+textBox8.Text+"' and HK="+comboBox6.Text+" and NAM="+textBox9.Text+" and MACT='"+comboBox7.Text+"'";
            OracleTransaction transaction = null;
            MessageBox.Show(query);
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
            SearchAndFill_PhanCong_TK("");
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            SearchAndFill_SinhVien(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            SearchAndFill_DonVi(textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            SearchAndFill_HocPhan(textBox3.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            SearchAndFill_KHMO(textBox4.Text);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            SearchAndFill_PhanCong(textBox5.Text);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchAndFill_DangKy(textBox6.Text, comboBox2.Text, comboBox1.Text);
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SearchAndFill_DangKy(textBox6.Text, comboBox2.Text, comboBox1.Text);
        }

        private void tabPage11_Click(object sender, EventArgs e)
        {

        }


        private void LoadData_ThongBao()
        {
            try
            {
                string query = "select NoiDung from OLS_ADMIN.THONGBAO order by NgayTao desc";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dataGridView10.DataSource = dataTable;
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_thongbao_Click(object sender, EventArgs e)
        {
            show = !show;
            if (show)
            {
                LoadData_ThongBao();
                dataGridView10.Visible = true;
            }
            else
            {
                dataGridView10.Visible = false;
            }
        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView6.Rows[e.RowIndex];
                txt_masv_dk.Text = row.Cells["MASV"].Value.ToString();
                mahp = row.Cells["MAHP"].Value.ToString();
                hk = row.Cells["HK"].Value.ToString();
                nam = row.Cells["NAM"].Value.ToString();
                mact= row.Cells["MACT"].Value.ToString();
                textBox14.Text = row.Cells["DIEMTH"].Value.ToString();
                textBox17.Text = row.Cells["DIEMQT"].Value.ToString();
                textBox16.Text = row.Cells["DIEMCK"].Value.ToString();
                textBox18.Text = row.Cells["DIEMTK"].Value.ToString();
            }
        }

        private void dataGridView9_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
                DataGridViewRow row = dataGridView9.Rows[e.RowIndex];
                textBox11.Text = row.Cells["MANV"].Value.ToString();
                textBox12.Text = row.Cells["HOTEN"].Value.ToString();
                comboBox4.Text = row.Cells["PHAI"].Value.ToString();
                textBox10.Text = row.Cells["NGSINH"].Value.ToString();
                textBox13.Text = row.Cells["PHUCAP"].Value.ToString();
                sdt.Text = row.Cells["DT"].Value.ToString();
                comboBox3.Text = row.Cells["VAITRO"].Value.ToString();
                textBox15.Text = row.Cells["MADV"].Value.ToString();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string query = "insert into  OLS_ADMIN.uv_TRUONGKHOA_NHANSU VALUES (:MANV, :HOTEN, :PHAI, to_date(:NGAYSINH,'DD.MM.YYYY'), :PHUCAP, '"+ sdt.Text +"', :VAITRO, :DV)";
            using (OracleCommand cmd = new OracleCommand(query, conn))
                try
            {
                cmd.Parameters.Add(":MANV", textBox11.Text);
                cmd.Parameters.Add(":HOTEN", textBox12.Text);
                cmd.Parameters.Add(":PHAI", comboBox4.Text);
                cmd.Parameters.Add(":NGAYSINH", textBox10.Text);
                cmd.Parameters.Add(":PHUCAP", textBox13.Text);
                cmd.Parameters.Add(":VAITRO", comboBox3.Text);
               
                cmd.Parameters.Add(":DV", textBox15.Text);
                cmd.ExecuteNonQuery();
                }
                catch (OracleException ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string query = "update OLS_ADMIN.uv_TRUONGKHOA_NHANSU set HOTEN='"+textBox12.Text+"' , PHAI='"+comboBox4.Text+"', NGSINH=to_date('"+textBox10.Text+"','DD.MM.YYYY') , PHUCAP='"+textBox13.Text+"' , VAITRO='"+comboBox3.Text+"' , MADV='"+textBox15.Text+"' , DT='"+sdt.Text+"' where MANV='"+textBox11.Text+"'";
            OracleTransaction transaction = null;
            try
            {
          
                transaction = conn.BeginTransaction();

                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.Transaction = transaction;

                cmd.Parameters.Add(":MANV", textBox11.Text);
                cmd.Parameters.Add(":HOTEN", textBox12.Text);
                cmd.Parameters.Add(":PHAI", comboBox4.Text);
                cmd.Parameters.Add(":NGAYSINH", textBox10.Text);
                cmd.Parameters.Add(":PHUCAP", textBox13.Text);
                cmd.Parameters.Add(":SDT", sdt.Text);
                cmd.Parameters.Add(":VAITRO", comboBox3.Text);
                cmd.Parameters.Add(":DV", textBox15.Text);
                cmd.ExecuteNonQuery();
                transaction.Commit();
                transaction.Dispose();
                SearchAndFill_NhanSu("");

            }
            catch (OracleException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
             
            }
            
         
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string query = "delete from OLS_ADMIN.uv_TRUONGKHOA_NHANSU where manv='"+textBox11.Text+"'";
            OracleTransaction transaction = null;
            try
            {

                transaction = conn.BeginTransaction();

                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.Transaction = transaction;   
                cmd.ExecuteNonQuery();
                transaction.Commit();
                transaction.Dispose();
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
            SearchAndFill_NhanSu("");
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            TTCANHAN tt = new TTCANHAN(ID);
            tt.Show();
        }

        private void tabPage8_Click(object sender, EventArgs e)
        {

        }
       // string query = "update OLS_ADMIN.uv_GiangVien_DANGKY set DIEMTH = "+textBox14.Text+" , DIEMQT = "+textBox17.Text+" , DIEMCK = "+textBox16.Text+" , DIEMTK = "+textBox18.Text+" where MASV = '"+txt_masv_dk.Text+"' , MAHP = '"+mahp+"' , HK="+hk+"  , NAM="+nam+"  , MACT='"+mact+"'";
        private void btn_luudiem_dk_Click(object sender, EventArgs e)
        {
            string query = "update OLS_ADMIN.uv_GiangVien_DANGKY set DIEMTH = " + textBox14.Text + " , DIEMQT = " + textBox17.Text + " , DIEMCK = " + textBox16.Text + " , DIEMTK = " + textBox18.Text + " where MASV = '" + txt_masv_dk.Text + "' and MAHP = '" + mahp + "' and HK=" + hk + "  and NAM=" + nam + "  and MACT='" + mact + "'";

            OracleTransaction transaction = null;
            try
            {

                transaction = conn.BeginTransaction();

                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.Transaction = transaction;
                MessageBox.Show(query);
                cmd.ExecuteNonQuery();
                
                transaction.Commit();
                transaction.Dispose();

            }
            catch (OracleException ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
            SearchAndFill_DangKy(textBox6.Text, comboBox2.Text, comboBox1.Text);
        }
    }
}
