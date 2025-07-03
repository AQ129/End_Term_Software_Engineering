using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;
using System.Net.Mail;
using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class forgotPassword : Form
    {
        public forgotPassword()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void forgotPassword_Load(object sender, EventArgs e)
        {
            emailPTB.Visible = false;
            sEmailPTB.Visible = true;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            check_mail temp = new check_mail();
            if (temp.ValidateUsingRegex(email) == true)
            {
                string query = "Select Mật_khẩu from Person where Email = '" + email.Text + "'";
                modify Modify = new modify();
                string password = Modify.getPassword(query);
                if (password == "")
                {
                    MessageBox.Show("Email của bạn chưa được đăng ký tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    ProgressEmail progress = new ProgressEmail();
                    progress.Show();
                    try
                    {
                        await Task.Run(() =>
                        {
                            var fromAddress = new MailAddress("nppanhquan129@gmail.com");
                            var toAddress = new MailAddress(email.ToString());
                            const string frompass = "snnolqzqaascpxtc";
                            const string subject = "Thông tin tài khoản";
                            string body = "Mật khẩu của bạn là : " + password;
                            var smtp = new SmtpClient
                            {
                                Host = "smtp.gmail.com",
                                Port = 587,
                                EnableSsl = true,
                                DeliveryMethod = SmtpDeliveryMethod.Network,
                                UseDefaultCredentials = false,
                                Credentials = new NetworkCredential(fromAddress.Address, frompass),
                                Timeout = 200000
                            };
                            using (var message = new MailMessage(fromAddress, toAddress)
                            {
                                Subject = subject,
                                Body = body
                            })
                            {
                                smtp.Send(message);
                            }
                        });
                        progress.finish();
                        MessageBox.Show("Email đã được gửi đi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        progress.Close();
                    }
                    catch (Exception ex)
                    {
                        progress.finish();
                        MessageBox.Show(ex.Message + " !");
                        progress.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Email của bạn không đúng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mouseOver(object sender, EventArgs e)
        {
            Button temp = (Button)sender;
            if (temp.Name != "Close")
            {
                temp.BackColor = Color.FromArgb(67, 65, 72);
            }
            else
            {
                temp.BackColor = Color.Red;
            }
        }

        private void mouseLeave(object sender, EventArgs e)
        {
            Button temp = (Button)sender;
            temp.BackColor = Color.FromArgb(23, 24, 29);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelMouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

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

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
