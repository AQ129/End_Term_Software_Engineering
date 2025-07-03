using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class XemCongViec : Form
    {
        private Person user;
        public XemCongViec(Person user)
        {
            this.user = user;
            InitializeComponent();
            showCVNhom(user);
        }
        private void showCVNhom(Person user)
        {
            using (SqlConnection conn = connection.GetConnection())
            {
                conn.Open();
                string query = "Select CV.Mã_công_việc as Mã,CV.Tiêu_đề,CV.Nội_dung_công_việc,CV.Tình_trạng,CV.Ngày_hết_hạn,CV.Mức_độ_ưu_tiên as Ưu_tiên,CV.Ngày_bắt_đầu as Ngày_giao FROM Công_việc CV INNER JOIN Phân_công_cho_Nhóm PCN ON CV.Mã_công_việc = PCN.Mã_công_việc AND PCN.Mã_nhóm = @MaNhom ORDER BY CV.Ngày_bắt_đầu DESC";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaNhom", user.MaNhom);
                    using (SqlDataAdapter ap = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        ap.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
        }
        private void showCVbophan(Person user)
        {
            using (SqlConnection conn = connection.GetConnection())
            {
                conn.Open();
                string query = "Select CV.Mã_công_việc as Mã,CV.Tiêu_đề,CV.Nội_dung_công_việc,CV.Tình_trạng,CV.Ngày_hết_hạn,CV.Mức_độ_ưu_tiên as Ưu_tiên,CV.Ngày_bắt_đầu as Ngày_giao FROM Công_việc CV INNER JOIN Phân_công_cho_BP BP ON CV.Mã_công_việc = BP.Mã_công_việc AND BP.Mã_bộ_phận = @MaBP ORDER BY CV.Ngày_bắt_đầu DESC";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaBP", user.MaBP);
                    using (SqlDataAdapter ap = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        ap.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
        }

        private void showCVcongty(Person user)
        {
            using (SqlConnection conn = connection.GetConnection())
            {
                conn.Open();
                string query = "Select Mã_công_việc as Mã,Tiêu_đề,Nội_dung_công_việc,Tình_trạng,Ngày_hết_hạn,Mức_độ_ưu_tiên as Ưu_tiên,Ngày_bắt_đầu as Ngày_giao FROM Công_việc WHERE Công_khai_TCT = 1 ORDER BY Ngày_bắt_đầu DESC";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter ap = new SqlDataAdapter(cmd))
                    {
                        cmd.Parameters.AddWithValue("@MaBP", user.MaBP);
                        DataTable dt = new DataTable();
                        ap.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
        }
        private void XemCongViec_Load(object sender, EventArgs e)
        {
            label2.Text = "Nhóm: " + user.MaNhom;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showCVNhom(user);
            label2.Text = "Nhóm: " + user.MaNhom;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showCVbophan(user);
            label2.Text = "Bộ phận: " + user.MaBP;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showCVcongty(user);
            label2.Text = "Công ty";
        }

        private void LoadDataIntoComboBox(Person user)
        {
            string query = @"
                SELECT DISTINCT CV.Mã_công_việc
                FROM Công_việc CV
                JOIN Phân_công_cho_BP BP ON CV.Mã_công_việc = BP.Mã_công_việc WHERE BP.Mã_bộ_phận = @MaBP";

            using (SqlConnection conn = connection.GetConnection())
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                try
                {
                    conn.Open();
                    command.Parameters.AddWithValue("@MaBP", user.MaBP);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("");
                        while (reader.Read())
                        {
                            comboBox1.Items.Add(reader["Mã_công_việc"].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                // Code to execute when the first tab is selected
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                LoadDataIntoComboBox(user);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Bạn cần nhập thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime ngayCapNhat = DateTime.Now.Date;
            string maCongViec = comboBox1.SelectedItem.ToString();
            string maNhanVien = user.MaNV;
            string tinhTrang = comboBox3.SelectedItem.ToString();
            int hoan = comboBox2.Text == "Có" ? 1 : 0;
            float doanhThu = float.Parse(textBox4.Text);

            if (!float.TryParse(textBox4.Text, out doanhThu))
            {
                MessageBox.Show("Doanh thu phải nhập số!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string query = "";
            if (MaCongViecExists(maCongViec))
            {
                query = @"
                UPDATE Giải_quyết 
                SET Ngày_cập_nhật = @NgayCapNhat, Mã_nhân_viên = @MaNhanVien, Tình_trạng = @TinhTrang, Hoãn = @Hoan, Doanh_thu = @DoanhThu 
                WHERE Mã_công_việc = @MaCongViec";
            }
            else
            {
                query = @"
                INSERT INTO Giải_quyết (Ngày_cập_nhật, Mã_công_việc, Mã_nhân_viên, Tình_trạng, Hoãn, Doanh_thu)
                VALUES (@NgayCapNhat, @MaCongViec, @MaNhanVien, @TinhTrang, @Hoan, @DoanhThu)";
            }

            using (SqlConnection conn = connection.GetConnection())
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@NgayCapNhat", ngayCapNhat);
                command.Parameters.AddWithValue("@MaCongViec", maCongViec);
                command.Parameters.AddWithValue("@MaNhanVien", maNhanVien);
                command.Parameters.AddWithValue("@TinhTrang", tinhTrang);
                command.Parameters.AddWithValue("@Hoan", hoan);
                command.Parameters.AddWithValue("@DoanhThu", doanhThu);

                try
                {
                    conn.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (MaCongViecExists(maCongViec))
                        MessageBox.Show("Dữ liệu dã được cập nhật!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Dữ liệu dã được lưu!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            CVChange(tinhTrang, ngayCapNhat, maCongViec);
        }
        private bool MaCongViecExists(string maCongViec)
        {
            string query = "SELECT COUNT(*) FROM Giải_quyết WHERE Mã_công_việc = @MaCongViec";
            using (SqlConnection conn = connection.GetConnection())
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@MaCongViec", maCongViec);
                conn.Open();
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }
        private void CVChange(string tinhTrang, DateTime ngayCapNhat, string maCongViec)
        {
            string query = "";
            if (tinhTrang == "Hoàn thành")
            {
                query = @"
                    UPDATE Công_việc
                    SET Tình_trạng = @TinhTrang, Ngày_hoàn_thành = @ngayCapNhat
                    WHERE Mã_công_việc = @MaCongViec";
                using (SqlConnection conn = connection.GetConnection())
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@NgayCapNhat", ngayCapNhat);
                    command.Parameters.AddWithValue("@TinhTrang", tinhTrang);
                    command.Parameters.AddWithValue("@MaCongViec", maCongViec);
                    try
                    {
                        conn.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
