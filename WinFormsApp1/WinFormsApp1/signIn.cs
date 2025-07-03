using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class signIn : Form
    {
        public signIn()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
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
        modify Modify = new modify();
        private void button1_Click(object sender, EventArgs e)
        {
            Person tempPerson;
            string userName = userNameTB.Text;
            string password = passwordTB.Text;
            if (userName.Trim() == "")
            {
                MessageBox.Show("Bạn chưa điền tên đăng nhập !", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button2.Visible = true;
            }
            else if (password.Trim() == "")
            {
                MessageBox.Show("Bạn chưa điền mật khẩu !","Lỗi đăng nhập", MessageBoxButtons.OK,MessageBoxIcon.Information);
                button2.Visible = true;
            }
            else
            {
                string query = "Select * from Person where Mã_Nhân_Viên = '" + userName + "' and Mật_khẩu = '" + password + "'";
                tempPerson = Modify.person(query);
                if (tempPerson.MaNV != null)
                {
                    if (!tempPerson.MaNV.Equals("") && userName.Equals(tempPerson.MaNV) && password.Equals(tempPerson.MatKhau))
                    {
                        mainPage temp = new mainPage(tempPerson);
                        temp.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu của bạn không chính xác !", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        button2.Visible = true;
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu của bạn không chính xác !", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    button2.Visible = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            forgotPassword forgotPassword = new forgotPassword();
            forgotPassword.ShowDialog();
        }

        private void signIn_Load(object sender, EventArgs e)
        {
            offAnimation();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            passwordTB.UseSystemPasswordChar = true;
            pictureBox6.Visible = false;
            pictureBox4.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            passwordTB.UseSystemPasswordChar = false;
            pictureBox6.Visible = true;
            pictureBox4.Visible = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void userNameTB_MouseHover(object sender, EventArgs e)
        {
            tkPTB.Visible = true;
            mkPTB.Visible = false;
            sTkPTB.Visible = false;
            sMkPTB.Visible = true;

        }
        private void offAnimation()
        {
            tkPTB.Visible = false;
            mkPTB.Visible = false;
            sTkPTB.Visible = true;
            sMkPTB.Visible = true;
        }

        private void passwordTB_Enter(object sender, EventArgs e)
        {
            tkPTB.Visible = false;
            mkPTB.Visible = true;
            sTkPTB.Visible = true;
            sMkPTB.Visible = false;
        }

        private void userNameTB_Leave(object sender, EventArgs e)
        {
            offAnimation();
        }

        private void passwordTB_Leave(object sender, EventArgs e)
        {
            offAnimation();
        }

        private void mkPTB_Click(object sender, EventArgs e)
        {

        }
    }
}
