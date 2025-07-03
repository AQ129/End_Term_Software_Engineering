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
    public partial class changePass : Form
    {
        Person person;
        public changePass(Person temp)
        {
            person = temp;
            InitializeComponent();
        }

        private void oldPassTB_Enter(object sender, EventArgs e)
        {
            oldPass.Visible = true;
            sOldPass.Visible = false;
        }

        private void oldPassTB_Leave(object sender, EventArgs e)
        {
            oldPass.Visible = false;
            sOldPass.Visible = true;
        }

        private void newPassTB_Enter(object sender, EventArgs e)
        {
            newPass.Visible = true;
            sNewPass.Visible = false;
        }

        private void newPassTB_Leave(object sender, EventArgs e)
        {
            newPass.Visible = false;
            sNewPass.Visible = true;
        }

        private void rNewPassTB_Enter(object sender, EventArgs e)
        {
            rMkPTB.Visible = true;
            sRMkPTB.Visible = false;
        }

        private void rNewPassTB_Leave(object sender, EventArgs e)
        {
            rMkPTB.Visible = false;
            sRMkPTB.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            oldPassTB.UseSystemPasswordChar = true;
            pictureBox10.Visible = false;
            pictureBox11.Visible = true;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            oldPassTB.UseSystemPasswordChar = false;
            pictureBox10.Visible = true;
            pictureBox11.Visible = false;
        }

        private void changePass_Load(object sender, EventArgs e)
        {
            pictureBox11.Visible = false;
            pictureBox7.Visible = false;
            pictureBox4.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            newPassTB.UseSystemPasswordChar = true;
            pictureBox2.Visible = false;
            pictureBox7.Visible = true;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            newPassTB.UseSystemPasswordChar = false;
            pictureBox2.Visible = true;
            pictureBox7.Visible = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            rNewPassTB.UseSystemPasswordChar = true;
            pictureBox6.Visible = false;
            pictureBox4.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            rNewPassTB.UseSystemPasswordChar = false;
            pictureBox6.Visible = true;
            pictureBox4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (oldPassTB.Text == "")
            {
                MessageBox.Show("Bạn chưa điền mật khẩu cũ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (newPassTB.Text == "")
            {
                MessageBox.Show("Bạn chưa điền mật khẩu mới!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rNewPassTB.Text == "")
            {
                MessageBox.Show("Bạn chưa điền lại mật khẩu mới!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!oldPassTB.Text.Equals(person.MatKhau))
            {
                MessageBox.Show("Mật khẩu cũ không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (newPassTB.Text.Equals(oldPassTB.Text))
            {
                MessageBox.Show("Mật khẩu mới giống với mật khẩu cũ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!newPassTB.Text.Equals(rNewPassTB.Text))
            {
                MessageBox.Show("Nhập lại mật khẩu mới không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                modify modify = new modify();
                string query = "Update Person Set Mật_khẩu = '" + newPassTB.Text + "' Where Mã_nhân_viên = '" + person.MaNV + "'";
                modify.Command(query);
                MessageBox.Show("Mật khẩu đã được thay đổi!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

