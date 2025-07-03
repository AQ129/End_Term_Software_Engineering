using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class ManagePerson : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;
        DataSet ds;
        SqlDataAdapter ap;
        int i = 0;
        public ManagePerson()
        {
            InitializeComponent();
        }

        private void ManagePerson_Load(object sender, EventArgs e)
        {
            conn = connection.GetConnection();
            showPerson();
            showCBOBoPhan();

            cboBoPhan.SelectedIndex = -1;
            txtMaNhanVien.ReadOnly = true;
            cboNhom.Visible = false;
            label13.Visible = false;
        }

        public void showPerson()
        {
            using (SqlConnection conn = connection.GetConnection())
            {
                conn.Open();
                string query = "Select * from Person";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter ap = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        ap.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
        }

        public void showCBOBoPhan()
        {
            conn = connection.GetConnection();
            conn.Open();
            string query = "Select Tên_bộ_phận from Bộ_phận";
            cmd = new SqlCommand(query, conn);
            ap = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ap.Fill(ds);
            cboBoPhan.DataSource = ds.Tables[0];
            cboBoPhan.DisplayMember = "Tên_bộ_phận";
        }

        public void showCBONhom()
        {
            conn = connection.GetConnection();
            conn.Open();
            string query = "select Mã_nhóm from Nhóm join Bộ_phận on Nhóm.Mã_bộ_phận = Bộ_phận.Mã_bộ_phận where Bộ_phận.Tên_bộ_phận = @Tên_bộ_phận";
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Tên_bộ_phận", cboBoPhan.Text);
            ap = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ap.Fill(ds);
            cboNhom.DataSource = ds.Tables[0];
            cboNhom.DisplayMember = "Mã_nhóm";
        }

        private bool IsEmailExists(string email)
        {
            conn = connection.GetConnection();
            conn.Open();
            string query = "SELECT COUNT(*) FROM Person WHERE Email = @Email";
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Email", email);
            int count = (int)cmd.ExecuteScalar();
            return count > 0;
        }

        private string GenerateRandomPassword()
        {
            Random random = new Random();
            int randomNumber = random.Next(1000000);
            string randomPassword = randomNumber.ToString("D6");
            return randomPassword;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHo.Text) ||
                string.IsNullOrWhiteSpace(txtTen.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtGioiTinh.Text) ||
                string.IsNullOrWhiteSpace(cboTinhTrang.Text) ||
                string.IsNullOrWhiteSpace(cboPhanQuyen.Text) ||
                string.IsNullOrWhiteSpace(cboBoPhan.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (IsEmailExists(txtEmail.Text))
            {
                MessageBox.Show("Email đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string matkhau = string.IsNullOrWhiteSpace(txtMatKhau.Text) ? GenerateRandomPassword() : txtMatKhau.Text;

                using (conn = connection.GetConnection())
                {
                    conn.Open();
                    string query = "EXECUTE insertPerson @Ho, @Ten, @SĐT, @Email, @Ngày_sinh, @Giới_tính, @Mật_khẩu, @Tình_trạng, @Phân_quyền, @Bộ_phận_desc";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Ho", txtHo.Text);
                        cmd.Parameters.AddWithValue("@Ten", txtTen.Text);
                        cmd.Parameters.AddWithValue("@SĐT", txtSDT.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@Ngày_sinh", txtNgaySinh.Text);
                        cmd.Parameters.AddWithValue("@Giới_tính", txtGioiTinh.Text);
                        cmd.Parameters.AddWithValue("@Mật_khẩu", matkhau);
                        cmd.Parameters.AddWithValue("@Tình_trạng", cboTinhTrang.Text);
                        cmd.Parameters.AddWithValue("@Phân_quyền", cboPhanQuyen.Text);
                        cmd.Parameters.AddWithValue("@Bộ_phận_desc", cboBoPhan.Text);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
                showPerson();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            conn = connection.GetConnection();
            conn.Open();
            string query = "Update Person set Ho = @Ho, Ten = @Ten, SĐT = @SĐT, Email = @Email, Ngày_sinh = @Ngày_sinh, Giới_tính = @Giới_tính, Mật_khẩu = @Mật_khẩu, Tình_trạng = @Tình_trạng, Phân_quyền = @Phân_quyền where Mã_nhân_viên = '" + txtMaNhanVien.Text + "'";
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Ho", txtHo.Text);
            cmd.Parameters.AddWithValue("@Ten", txtTen.Text);
            cmd.Parameters.AddWithValue("@SĐT", txtSDT.Text);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@Ngày_sinh", txtNgaySinh.Text);
            cmd.Parameters.AddWithValue("@Giới_tính", txtGioiTinh.Text);
            cmd.Parameters.AddWithValue("@Mật_khẩu", txtMatKhau.Text);
            cmd.Parameters.AddWithValue("@Tình_trạng", cboTinhTrang.Text);
            cmd.Parameters.AddWithValue("@Phân_quyền", cboPhanQuyen.Text);
            cmd.ExecuteNonQuery();
            showPerson();
            MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtHo.Text = "";
            txtTen.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
            txtNgaySinh.Text = "";
            txtGioiTinh.Text = "";
            txtMatKhau.Text = "";
            cboTinhTrang.SelectedIndex = -1;
            cboPhanQuyen.SelectedIndex = -1;
            cboBoPhan.SelectedIndex = -1;
            cboPhanLoai.SelectedIndex = -1;
            cboNhom.SelectedIndex = -1;
            txtMaNhanVien.Text = "";
            cboPhanQuyen.Text = "";
            txtMaNhanVien.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                conn = connection.GetConnection();
                conn.Open();
                string query = "Delete from Person where  Mã_nhân_viên = '" + txtMaNhanVien.Text + "'";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                showPerson();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể xóa do ràng buộc khóa ngoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cboPhanQuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPhanQuyen.Text == "Staff" || cboPhanQuyen.Text == "Leader")
            {
                cboPhanLoai.Enabled = true;
                cboNhom.Enabled = true;
                showCBONhom();
                cboNhom.Visible = true;
                label13.Visible = true;
            }
            else
            {
                cboNhom.Visible = false;
                label13.Visible = false;
            }
        }

        private void cboBoPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPhanQuyen.Text == "Staff")
            {
                showCBONhom();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                conn = connection.GetConnection();
                conn.Open();
                if (cboPhanQuyen.Text == "Staff")
                {
                    string query1 = "execute insertNhanVien @Phân_loại, @Mã_nhân_viên, @Mã_nhóm";
                    cmd = new SqlCommand(query1, conn);
                    cmd.Parameters.AddWithValue("@Phân_loại", cboPhanLoai.Text);
                    cmd.Parameters.AddWithValue("@Mã_nhân_viên", txtMaNhanVien.Text);
                    cmd.Parameters.AddWithValue("@Mã_nhóm", cboNhom.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (cboPhanQuyen.Text == "Leader")
                {
                    string query2 = "execute insertTruongNhom @Mã_nhân_viên, @Mã_nhóm";
                    using (SqlCommand cmd2 = new SqlCommand(query2, conn))
                    {
                        cmd2.Parameters.AddWithValue("@Mã_nhân_viên", txtMaNhanVien.Text);
                        cmd2.Parameters.AddWithValue("@Mã_nhóm", cboNhom.Text);
                        cmd2.ExecuteNonQuery();
                    }
                    MessageBox.Show("Thêm Leader thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (cboPhanQuyen.Text == "Manager")
                {
                    string query3 = "execute insertQuanLy @Mã_nhân_viên, @Mã_bộ_phận";
                    // Tạo một command mới cho mỗi câu lệnh SQL
                    using (SqlCommand cmd3 = new SqlCommand(query3, conn))
                    {
                        cmd3.Parameters.AddWithValue("@Mã_nhân_viên", txtMaNhanVien.Text);
                        cmd3.Parameters.AddWithValue("@Mã_bộ_phận", cboBoPhan.Text);
                        cmd3.ExecuteNonQuery();
                    }
                    MessageBox.Show("Thêm Manager thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (cboPhanQuyen.Text == "CEO")
                {
                    string query4 = "execute insertCEO @Mã_nhân_viên";
                    // Tạo một command mới cho mỗi câu lệnh SQL
                    using (SqlCommand cmd4 = new SqlCommand(query4, conn))
                    {
                        cmd4.Parameters.AddWithValue("@Mã_nhân_viên", txtMaNhanVien.Text);
                        cmd4.ExecuteNonQuery();
                    }
                    MessageBox.Show("Thêm CEO thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nhân viên đã được tạo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = e.RowIndex;
            if (i >= 0)
            {
                txtHo.Text = dataGridView1.Rows[i].Cells["Ho"].Value.ToString();
                txtTen.Text = dataGridView1.Rows[i].Cells["Ten"].Value.ToString();
                txtSDT.Text = dataGridView1.Rows[i].Cells["SĐT"].Value.ToString();
                txtEmail.Text = dataGridView1.Rows[i].Cells["Email"].Value.ToString();
                txtNgaySinh.Text = dataGridView1.Rows[i].Cells["Ngày_sinh"].Value.ToString();
                txtGioiTinh.Text = dataGridView1.Rows[i].Cells["Giới_tính"].Value.ToString();
                txtMatKhau.Text = dataGridView1.Rows[i].Cells["Mật_khẩu"].Value.ToString();
                cboTinhTrang.Text = dataGridView1.Rows[i].Cells["Tình_trạng"].Value.ToString();
                cboPhanQuyen.Text = dataGridView1.Rows[i].Cells["Phân_quyền"].Value.ToString();
                txtMaNhanVien.Text = dataGridView1.Rows[i].Cells["Mã_nhân_viên"].Value.ToString();
            }
        }
    }
}
