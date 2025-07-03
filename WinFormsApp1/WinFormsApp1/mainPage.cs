using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp1
{
    public partial class mainPage : Form
    {
        private Person user;
        private Button currentBtn;
        private Form currentChildForm;

        public mainPage(Person temp)
        {
            InitializeComponent();
            this.user = temp;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            tittleBtn.Visible = false;
            home.Visible = true;
            menu.BringToFront();
        }

        private void activateBtn(object senderBtn)
        {
            if (senderBtn != null)
            {
                disableBtn();
                currentBtn = (Button)senderBtn;
                tittleBtn.Visible = true;
                home.Visible = false;
                tittleBtn.Text = currentBtn.Text;
                tittleBtn.Image = currentBtn.Image;
                currentBtn.BackColor = Color.FromArgb(140, 139, 147);
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
            }
        }

        private void disableBtn()
        {
            if (currentBtn != null)
            {
                tittleBtn.Visible = false;
                home.Visible = true;
                currentBtn.TextAlign = ContentAlignment.MiddleRight;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                if (currentBtn.AccessibleRole == AccessibleRole.MenuBar)
                {
                    currentBtn.BackColor = Color.FromArgb(32, 33, 36);
                }
                else
                {
                    currentBtn.BackColor = Color.FromArgb(23, 24, 29);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            activateBtn(sender);
            OpenChildForm(new TTCN(user));
        }

        bool menuExpand = true;
        bool workExpand = false;
        bool statistical = false;
        private void workbroadTransition_Tick(object sender, EventArgs e)
        {
            if (workExpand == false)
            {
                workBroad.Height += 5;
                if (workBroad.Height >= 210)
                {
                    workbroadTransition.Stop();
                    workExpand = true;
                }
            }
            else
            {
                workBroad.Height -= 5;
                if (workBroad.Height <= 75)
                {
                    workbroadTransition.Stop();
                    workExpand = false;
                }
            }
        }

        private void menuTransition_Tick_1(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menu.Width += 5;
                if (menu.Width >= 255)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menu.Width -= 5;
                if (menu.Width <= 80)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            workbroadTransition.Start();
        }

        private void mainPage_Load(object sender, EventArgs e)
        {
            avatarChange(user);
            luckPTB.Visible = false;
            calenderPTB.Visible = false;
            if (user.ChucVu.Equals("Nhân viên") || user.ChucVu.Equals("Trưởng nhóm"))
            {
                workBroad.Visible = false;
                statisticalBroad.Visible = false;
            }
            else if (user.ChucVu.Equals("Quản lý"))
            {
                statisticalBroad.Visible = false;
                congViecBTN.Visible = false;

            }
            else if (user.ChucVu.Equals("CEO"))
            {
                congViecBTN.Visible = false;
            }
            label1.Text = "Chào " + user.Ho + " " + user.Ten + "\nChúc bạn có một ngày làm việc hiệu quả";

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            activateBtn(sender);
            OpenChildForm(new guiEmail());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            statisticalTransition.Start();
        }

        private void statisticalTransition_Tick(object sender, EventArgs e)
        {
            if (statistical == false)
            {
                statisticalBroad.Height += 5;
                if (statisticalBroad.Height >= 280)
                {
                    statisticalTransition.Stop();
                    statistical = true;
                }
            }
            else
            {
                statisticalBroad.Height -= 5;
                if (statisticalBroad.Height <= 70)
                {
                    statisticalTransition.Stop();
                    statistical = false;
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void workBroad_Paint(object sender, PaintEventArgs e)
        {
        }

        private void CDbtn_Click(object sender, EventArgs e)
        {
            activateBtn(sender);
        }

        private void TTVUDbtn_Click(object sender, EventArgs e)
        {
            activateBtn(sender);
            OpenChildForm(new infor());
        }

        private void PBbtn_Click(object sender, EventArgs e)
        {
            activateBtn(sender);
            OpenChildForm(new ManagePerson());
        }

        private void TCTbtn_Click(object sender, EventArgs e)
        {
            activateBtn(sender);
            WorkManagement temp = new WorkManagement();
            OpenChildForm(temp);
        }

        private void CVbtn_Click(object sender, EventArgs e)
        {
            activateBtn(sender);
            OpenChildForm(new congviec());
        }

        private void HQLVbtn_Click(object sender, EventArgs e)
        {
            activateBtn(sender);
            OpenChildForm(new nhanvien());
        }

        private void DLDVCDbtn_Click(object sender, EventArgs e)
        {
            activateBtn(sender);
            OpenChildForm(new cudan());
        }

        private void statisticalBroad_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menu_Paint_1(object sender, PaintEventArgs e)
        {

        }
        private void mouseOver(object sender, EventArgs e)
        {
            Button temp = (Button)sender;
            if (temp != currentBtn)
            {
                if (temp.AccessibleRole != AccessibleRole.TitleBar)
                {
                    temp.BackColor = Color.FromArgb(94, 147, 64);
                }
                else if (temp.Name != "Close")
                {
                    temp.BackColor = Color.FromArgb(67, 65, 72);
                }
                else
                {
                    temp.BackColor = Color.Red;
                }
            }
        }

        private void mouseLeave(object sender, EventArgs e)
        {
            Button temp = (Button)sender;
            if (temp != currentBtn)
            {
                if (temp.AccessibleRole == AccessibleRole.MenuBar)
                {
                    temp.BackColor = Color.FromArgb(32, 33, 36);
                }
                else
                {
                    temp.BackColor = Color.FromArgb(23, 24, 29);
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Noti notiForm = new Noti(user);
            Point iconBottom = new Point(pictureBox3.Right, pictureBox3.Bottom);
            Point screenPoint = pictureBox3.Parent.PointToScreen(iconBottom);
            int newX = screenPoint.X - notiForm.Width;
            notiForm.Location = new Point(newX, screenPoint.Y);
            notiForm.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            disableBtn();
            if (currentChildForm != null)
            {
                if (currentChildForm.Name.Equals("TTCN"))
                {
                    modify modify = new modify();
                    string query = "Select * from Person where Mã_Nhân_Viên = '" + user.MaNV + "'";
                    user = modify.person(query);
                    avatarChange(user);
                }
                currentChildForm.Close();
                currentBtn = null;
            }
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

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            childForm.BackColor = Color.FromArgb(32, 33, 36);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void menu_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Day_Click(object sender, EventArgs e)
        {

        }

        private void Time_Click(object sender, EventArgs e)
        {

        }


        private void clock_Tick(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToLongTimeString();
            Day.Text = DateTime.Now.ToLongDateString();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            clock.Start();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            signIn newSignIn = new signIn();
            newSignIn.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void avatarChange(Person user)
        {
            if (user.HinhAnh != null)
            {
                avatar.Visible = true;
                avatarFemale.Visible = false;
                avatarMale.Visible = false;
                MemoryStream memory = new MemoryStream(user.HinhAnh);
                avatar.Image = Image.FromStream(memory);
            }
            else if (user.GioiTinh.Equals("Nam"))
            {
                avatar.Visible = false;
                avatarFemale.Visible = false;
                avatarMale.Visible = true;
            }
            else
            {
                avatar.Visible = false;
                avatarFemale.Visible = true;
                avatarMale.Visible = false;
            }
        }

        private void panel4_MouseHover(object sender, EventArgs e)
        {
            calenderPTB.Visible = true;
            sCalenderPTB.Visible = false;
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            calenderPTB.Visible = false;
            sCalenderPTB.Visible = true;
        }

        private void panel5_MouseHover(object sender, EventArgs e)
        {
            luckPTB.Visible = true;
            sLuckPTB.Visible = false;
        }

        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            luckPTB.Visible = false;
            sLuckPTB.Visible = true;
        }

        private void congViec_Click(object sender, EventArgs e)
        {
            activateBtn(sender);
            OpenChildForm(new XemCongViec(user));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            activateBtn(sender);
            OpenChildForm(new XemCongViec(user));
        }
    }
}
