using System;
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
    public partial class WorkManagement : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        public WorkManagement()
        {
            InitializeComponent();
        }
        public void showCBOMaCanHo()
        {
            using (SqlConnection conn = connection.GetConnection())
            {
                conn.Open();
                string query = "SELECT distinct Mã_căn_hộ FROM Yêu_cầu_dịch_vụ";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cboMaCanHo.DataSource = dt;
                cboMaCanHo.DisplayMember = "Mã_căn_hộ";
            }
        }

        public void showYCDV()
        {
            using (SqlConnection conn = connection.GetConnection())
            {
                conn.Open();
                string query = "EXECUTE showYCDV @Mã_căn_hộ";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Mã_căn_hộ", cboMaCanHo.Text);
                    using (SqlDataAdapter ap = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        ap.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
        }

        public void showCBOMaNhanVien()
        {
            using (SqlConnection conn = connection.GetConnection())
            {
                conn.Open();
                string query = "SELECT distinct Mã_nhân_viên FROM Giải_quyết";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cboMaNhanVien.DataSource = dt;
                cboMaNhanVien.DisplayMember = "Mã_nhân_viên";
            }
        }

        public void showDSCongViec()
        {
            using (SqlConnection conn = connection.GetConnection())
            {
                conn.Open();
                string query = "EXECUTE showDSCongViec @Mã_nhân_viên";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Mã_nhân_viên", cboMaNhanVien.Text);
                    using (SqlDataAdapter ap = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        ap.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
        }

        public void showCongViec()
        {
            using (SqlConnection conn = connection.GetConnection())
            {
                conn.Open();
                string query = "Select * from Công_việc";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter ap = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        ap.Fill(dt);
                        dataGridView2.DataSource = dt;
                    }
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            conn = connection.GetConnection();
            showCBOMaCanHo();
            showCBOMaNhanVien();
            showCongViec();

            txtMaCongViec.ReadOnly = true;

        }

        private void cboMaCanHo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaCanHo.SelectedIndex != -1)
            {
                cboMaNhanVien.SelectedIndexChanged -= cboMaNhanVien_SelectedIndexChanged; // Tạm thời tắt sự kiện SelectedIndexChanged của cboMaNhanVien
                cboMaNhanVien.SelectedIndex = -1; // Đặt lại lựa chọn của cboMaNhanVien về trạng thái không chọn
                cboMaNhanVien.SelectedIndexChanged += cboMaNhanVien_SelectedIndexChanged; // Bật lại sự kiện SelectedIndexChanged của cboMaNhanVien
                showYCDV(); // Hiển thị thông tin yêu cầu dịch vụ khi chọn mã căn hộ
            }
        }

        private void cboMaNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaNhanVien.SelectedIndex != -1)
            {
                cboMaCanHo.SelectedIndexChanged -= cboMaCanHo_SelectedIndexChanged; // Tạm thời tắt sự kiện SelectedIndexChanged của cboMaCanHo
                cboMaCanHo.SelectedIndex = -1; // Đặt lại lựa chọn của cboMaCanHo về trạng thái không chọn
                cboMaCanHo.SelectedIndexChanged += cboMaCanHo_SelectedIndexChanged; // Bật lại sự kiện SelectedIndexChanged của cboMaCanHo
                showDSCongViec(); // Hiển thị thông tin công việc khi chọn mã nhân viên
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = e.RowIndex;
            txtMaCongViec.Text = dataGridView2.Rows[i].Cells["Mã_công_việc"].Value.ToString();
            dtNgayHetHan.Text = dataGridView2.Rows[i].Cells["Ngày_hết_hạn"].Value.ToString();
            txtNoiDung.Text = dataGridView2.Rows[i].Cells["Nội_dung_công_việc"].Value.ToString();
            cboCongKhaiBP.Text = dataGridView2.Rows[i].Cells["Công_khai_BP"].Value.ToString();
            cboCongKhaiTCT.Text = dataGridView2.Rows[i].Cells["Công_khai_TCT"].Value.ToString();
            cboTinhTrang.Text = dataGridView2.Rows[i].Cells["Tình_trạng"].Value.ToString();
            dtNgayBatDau.Text = dataGridView2.Rows[i].Cells["Ngày_bắt_đầu"].Value.ToString();
            cboMucDoUuTien.Text = dataGridView2.Rows[i].Cells["Mức_độ_ưu_tiên"].Value.ToString();
            cboTieuDe.Text = dataGridView2.Rows[i].Cells["Tiêu_đề"].Value.ToString();
            cboGiaHan.Text = dataGridView2.Rows[i].Cells["Gia_hạn"].Value.ToString();
            dtNgayHoanThanh.Text = dataGridView2.Rows[i].Cells["Ngày_hoàn_thành"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNoiDung.Text) ||
                string.IsNullOrWhiteSpace(cboCongKhaiBP.Text) ||
                string.IsNullOrWhiteSpace(cboCongKhaiTCT.Text) ||
                string.IsNullOrWhiteSpace(cboTinhTrang.Text) ||
                string.IsNullOrWhiteSpace(cboMucDoUuTien.Text) ||
                string.IsNullOrWhiteSpace(cboTieuDe.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                conn = connection.GetConnection();
                conn.Open();
                string query = "EXECUTE InsertCông_việc @Ngày_hết_hạn, @Nội_dung_công_việc, @Công_khai_BP, @Công_khai_TCT, @Tình_trạng, @Ngày_bắt_đầu, @Mức_độ_ưu_tiên, @Tiêu_đề, @Gia_hạn, @Ngày_hoàn_thành";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Ngày_hết_hạn", dtNgayHetHan.Text);
                cmd.Parameters.AddWithValue("@Nội_dung_công_việc", txtNoiDung.Text);
                cmd.Parameters.AddWithValue("@Công_khai_BP", cboCongKhaiBP.Text);
                cmd.Parameters.AddWithValue("@Công_khai_TCT", cboCongKhaiTCT.Text);
                cmd.Parameters.AddWithValue("@Tình_trạng", cboTinhTrang.Text);
                cmd.Parameters.AddWithValue("@Ngày_bắt_đầu", dtNgayBatDau.Text);
                cmd.Parameters.AddWithValue("@Mức_độ_ưu_tiên", cboMucDoUuTien.Text);
                cmd.Parameters.AddWithValue("@Tiêu_đề", cboTieuDe.Text);
                cmd.Parameters.AddWithValue("@Gia_hạn", cboGiaHan.Text);
                cmd.Parameters.AddWithValue("@Ngày_hoàn_thành", dtNgayHoanThanh.Text);
                cmd.ExecuteNonQuery();
                showCongViec();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtMaCongViec.Text = "";
            dtNgayHetHan.Text = "";
            txtNoiDung.Text = "";
            cboCongKhaiBP.Text = "";
            cboCongKhaiTCT.Text = "";
            cboTinhTrang.Text = "";
            dtNgayBatDau.Text = "";
            cboMucDoUuTien.Text = "";
            cboTieuDe.Text = "";
            cboGiaHan.Text = "";
            dtNgayHoanThanh.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                conn = connection.GetConnection();
                conn.Open();
                string query = "Delete from Công_việc where  Mã_công_việc = '" + txtMaCongViec.Text + "'";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                showCongViec();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể xóa do ràng buộc khóa ngoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn = connection.GetConnection();
            conn.Open();
            string query = "Update Công_việc set Ngày_hết_hạn = @Ngày_hết_hạn, Nội_dung_công_việc = @Nội_dung_công_việc, Công_khai_BP = @Công_khai_BP, Công_khai_TCT =  @Công_khai_TCT, Tình_trạng = @Tình_trạng, Ngày_bắt_đầu = @Ngày_bắt_đầu, Mức_độ_ưu_tiên = @Mức_độ_ưu_tiên, Tiêu_đề = @Tiêu_đề, Gia_hạn = @Gia_hạn, Ngày_hoàn_thành = @Ngày_hoàn_thành where  Mã_công_việc = '" + txtMaCongViec.Text + "'";
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Ngày_hết_hạn", dtNgayHetHan.Text);
            cmd.Parameters.AddWithValue("@Nội_dung_công_việc", txtNoiDung.Text);
            cmd.Parameters.AddWithValue("@Công_khai_BP", cboCongKhaiBP.Text);
            cmd.Parameters.AddWithValue("@Công_khai_TCT", cboCongKhaiTCT.Text);
            cmd.Parameters.AddWithValue("@Tình_trạng", cboTinhTrang.Text);
            cmd.Parameters.AddWithValue("@Ngày_bắt_đầu", dtNgayBatDau.Text);
            cmd.Parameters.AddWithValue("@Mức_độ_ưu_tiên", cboMucDoUuTien.Text);
            cmd.Parameters.AddWithValue("@Tiêu_đề", cboTieuDe.Text);
            cmd.Parameters.AddWithValue("@Gia_hạn", cboGiaHan.Text);
            cmd.Parameters.AddWithValue("@Ngày_hoàn_thành", dtNgayHoanThanh.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            showCongViec();
        }
    }
}
