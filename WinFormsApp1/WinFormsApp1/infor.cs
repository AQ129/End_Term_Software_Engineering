using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class infor : Form
    {
        int i = 1;
        public infor()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkInfo(1);
        }


        private void pictureBox9_Click(object sender, EventArgs e)
        {
            i++;
            if (i > 5)
            {
                i = 1;
            }
            checkInfo(i);
        }

        private void checkInfo(int i)
        {
            if (i == 1)
            {
                PTB1.Visible = true;
                PTB2.Visible = false;
                PTB3.Visible = false;
                PTB4.Visible = false;
                PTB5.Visible = false;
                name.Text = "Họ Tên: Nguyễn Văn Anh Quân";
                mssv.Text = "Mã số sinh viên: 52100924";
                cv.Text = "Chức vụ: Coder,\n\tDesigner, Tester";
            }
            else if (i == 2)
            {
                PTB1.Visible = false;
                PTB2.Visible = true;
                PTB3.Visible = false;
                PTB4.Visible = false;
                PTB5.Visible = false;
                name.Text = "Họ Tên: Đống Thạc Nhân";
                mssv.Text = "Mã số sinh viên: 52100914";
                cv.Text = "Chức vụ: Coder,\n\tDesigner, Tester";
            }
            else if (i == 3)
            {
                PTB1.Visible = false;
                PTB2.Visible = false;
                PTB3.Visible = true;
                PTB4.Visible = false;
                PTB5.Visible = false;
                name.Text = "Họ Tên: Vũ Xuân Cảnh";
                mssv.Text = "Mã số sinh viên: 52200135";
                cv.Text = "Chức vụ: Coder, Designer";
            }
            else if (i == 4)
            {
                PTB1.Visible = false;
                PTB2.Visible = false;
                PTB3.Visible = false;
                PTB4.Visible = true;
                PTB5.Visible = false;
                name.Text = "Họ Tên: Mai Thị Ánh Như";
                mssv.Text = "Mã số sinh viên: 52200052";
                cv.Text = "Chức vụ: Project Manager";
            }
            else
            {
                PTB1.Visible = false;
                PTB2.Visible = false;
                PTB3.Visible = false;
                PTB4.Visible = false;
                PTB5.Visible = true;
                name.Text = "Họ Tên: Huỳnh Thị Trà My";
                mssv.Text = "Mã số sinh viên: 52100704";
                cv.Text = "Chức vụ: Business Analyst";
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            i--;
            if (i < 1)
            {
                i = 5;
            }
            checkInfo(i);
        }
    }
}
