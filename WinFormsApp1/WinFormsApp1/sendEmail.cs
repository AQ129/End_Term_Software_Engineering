using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.IO;
using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class guiEmail : Form
    {
        Attachment attach = null;
        string query;
        public guiEmail()
        {
            InitializeComponent();
        }
        modify modify = new modify();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guiEmail_Load(object sender, EventArgs e)
        {
            loadData();
            emailPTB.Visible = false;
            idPTB.Visible = false;
            contentPTB.Visible = false;
            phonePTB.Visible = false;
            namePTB.Visible = false;
            tablePTB.Visible = false;
            resetPTB.Visible = false;
            listEmailPTB.Visible = false;


        }

        public void loadData()
        {
            query = "SELECT Email, Ho + ' ' + Ten AS Họ_Tên, Mã_nhân_viên, SĐT " +
                    "FROM Person " +
                    "WHERE Email LIKE '%" + email.Text + "%' " +
                    "AND SĐT LIKE '%" + phone.Text + "%' " +
                    "AND Mã_nhân_viên LIKE '%" + maNhanVien.Text + "%' " +
                    "AND Ho +' '+ Ten LIKE N'%" + name.Text + "%'";

            try
            {
                staff.DataSource = modify.table(query);
                staff.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối data" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reload_Click(object sender, EventArgs e)
        {
            email.Text = "";
            phone.Text = "";
            name.Text = "";
            name.Text = "";
        }

        private void maNhanVien_TextChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void staff_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void staff_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < staff.Rows.Count)
            {
                DataGridViewRow selectedRow = staff.Rows[e.RowIndex];
                string email = selectedRow.Cells["Email"].Value.ToString();
                if (!email.Equals(""))
                {
                    emailTB.Text += email + ", ";
                }
            }
        }

        private async Task guiE(string to, string title, string message, Attachment file = null)
        {
            ProgressEmail progress = new ProgressEmail();
            progress.Show();
            await Task.Run(() =>
            {
                MailMessage mess = new MailMessage("nppanhquan129@gmail.com", to, title, message);
                if (file != null)
                {
                    mess.Attachments.Add(file);
                }
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential("nppanhquan129@gmail.com", "snnolqzqaascpxtc");
                client.Send(mess);
            });
            progress.finish();
            MessageBox.Show("Email đã được gửi đi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            progress.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileTB.Text = openFileDialog.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                FileInfo fileInfo = new FileInfo(fileTB.Text);
                attach = new Attachment(fileTB.Text);
            }
            catch (Exception ex) { }
            string strEmail = emailTB.Text;
            string[] arrEmail = strEmail.Split(',');
            if (arrEmail.Length > 1)
            {
                if (titleTB.Text.Equals(""))
                {
                    MessageBox.Show("Bạn chưa điền tiêu đề cho email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (messTB.Text.Equals(""))
                {
                    MessageBox.Show("Bạn chưa điền tin nhắn cho email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    for (int i = 0; i < arrEmail.Length - 1; i++)
                    {
                        if(fileTB.Text != "")
                        {
                            guiE(arrEmail[i], titleTB.Text, messTB.Text, attach);
                        }
                        else
                        {
                            guiE(arrEmail[i], titleTB.Text, messTB.Text);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void maNhanVien_Enter(object sender, EventArgs e)
        {
            idPTB.Visible = true;
            sIdPTB.Visible = false;
        }

        private void maNhanVien_Leave(object sender, EventArgs e)
        {
            idPTB.Visible = false;
            sIdPTB.Visible = true;
        }

        private void phone_Enter(object sender, EventArgs e)
        {
            phonePTB.Visible = true;
            sPhonePTB.Visible = false;
        }

        private void phone_Leave(object sender, EventArgs e)
        {
            phonePTB.Visible = false;
            sPhonePTB.Visible = true;
        }

        private void name_Enter(object sender, EventArgs e)
        {
            namePTB.Visible = true;
            sNamePTB.Visible = false;
        }

        private void name_Leave(object sender, EventArgs e)
        {
            namePTB.Visible = false;
            sNamePTB.Visible = true;
        }

        private void email_Enter(object sender, EventArgs e)
        {
            emailPTB.Visible = true;
            sEmailPTB.Visible = false;
        }

        private void email_Leave(object sender, EventArgs e)
        {
            emailPTB.Visible = false;
            sEmailPTB.Visible = true;
        }

        private void staff_MouseHover(object sender, EventArgs e)
        {
            tablePTB.Visible = true;
            sTablePTB.Visible = false;
        }

        private void staff_MouseLeave(object sender, EventArgs e)
        {
            tablePTB.Visible = false;
            sTablePTB.Visible = true;
        }

        private void reload_MouseHover(object sender, EventArgs e)
        {
            resetPTB.Visible = true;
            sResetPTB.Visible = false;
        }

        private void reload_MouseLeave(object sender, EventArgs e)
        {
            resetPTB.Visible = false;
            sResetPTB.Visible = true;
        }

        private void emailTB_MouseHover(object sender, EventArgs e)
        {
            listEmailPTB.Visible = true;
            sListEmailPTB.Visible = false;
        }

        private void emailTB_MouseLeave(object sender, EventArgs e)
        {
            listEmailPTB.Visible = false;
            sListEmailPTB.Visible = true;
        }

        private void fileTB_MouseHover(object sender, EventArgs e)
        {
            contentPTB.Visible = true;
            sContentPTB.Visible = false;
        }

        private void fileTB_MouseLeave(object sender, EventArgs e)
        {
            contentPTB.Visible = false;
            sContentPTB.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            emailTB.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            titleTB.Clear();
            fileTB.Clear();
            messTB.Clear();
        }
    }
}
