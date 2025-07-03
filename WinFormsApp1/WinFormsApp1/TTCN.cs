using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinFormsApp1
{
    public partial class TTCN : Form
    {
        private Person user;
        bool sex;
        Image oldImage;

        public TTCN(Person user)
        {
            this.user = user;
            InitializeComponent();
            birthDay.Format = DateTimePickerFormat.Short;

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Huy.Visible = true;
            Luu.Visible = true;
            sdt.Enabled = true;
            email.Enabled = true;
            name.Enabled = true;
            Female.Enabled = true;
            Male.Enabled = true;
            birthDay.Enabled = true;
        }

        private void offAnimationPTB()
        {
            namePTB.Visible = false;
            emailPTB.Visible = false;
            phonePTB.Visible = false;
            birthdayPTB.Visible = false;
            idPTB.Visible = false;
            teamPTB.Visible = false;
            groupPTB.Visible = false;
            sexPTB.Visible = false;
            sNamePTB.Visible = true;
            sEmailPTB.Visible = true;
            sPhonePTB.Visible = true;
            sBirthdayPTB.Visible = true;
            sIdPTB.Visible = true;
            sTeamPTB.Visible = true;
            sGroupPTB.Visible = true;
            sSexPTB.Visible = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Luu_Click(object sender, EventArgs e)
        {
            check_mail checkMail = new check_mail();
            if (sdt.Text.Trim() == "" || email.Text.Trim() == "" || name.Text.Trim() == "")
            {
                MessageBox.Show("Số điện thoại, email, tên không được để trống!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load(user);
            }
            else if (checkMail.ValidateUsingRegex(email) == false)
            {
                MessageBox.Show("Email không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load(user);
            }
            else
            {
                Huy.Visible = false;
                Luu.Visible = false;
                sdt.Enabled = false;
                email.Enabled = false;
                name.Enabled = false;
                Female.Enabled = false;
                Male.Enabled = false;
                birthDay.Enabled = false;
                string[] arrayName = name.Text.Split(' ');
                string ho = arrayName[0];
                string ten = "";
                string selectedDate = birthDay.Value.ToString("dd/MM/yyyy");

                for (int i = 1; i < arrayName.Length; i++)
                {
                    ten += arrayName[i];
                    if (i != arrayName.Length - 1)
                    {
                        ten += " ";
                    }
                }
                string query;
                if (sex == true)
                {
                    query = "Update Person Set email ='" + email.Text + "', [SĐT] = '" + sdt.Text + "', [Giới_tính] = N'Nam', Ho = N'" + ho + "',[Ngày_sinh] = Convert(DateTime, '" + selectedDate + "',103), Ten = N'" + ten + "' where Mã_nhân_viên = '" + user.MaNV + "';";
                }
                else
                {
                    query = "Update Person Set email ='" + email.Text + "', [SĐT] = '" + sdt.Text + "', [Giới_tính] = N'Nữ', Ho = N'" + ho + "', Ten = N'" + ten + "',[Ngày_sinh] = Convert(DateTime, '" + selectedDate + "',103) where Mã_nhân_viên = '" + user.MaNV + "';";
                }
                modify modify = new modify();
                modify.Command(query);
                query = "Select * from Person where Mã_nhân_viên = '" + user.MaNV + "';";
                user = modify.person(query);
                load(user);
            }
        }



        private void Huy_Click(object sender, EventArgs e)
        {

            Huy.Visible = false;
            Luu.Visible = false;
            sdt.Enabled = false;
            email.Enabled = false;
            name.Enabled = false;
            Female.Enabled = false;
            Male.Enabled = false;
            birthDay.Enabled = false;
            load(user);
            offAnimationPTB();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void load(Person user)
        {
            maBP.ReadOnly = false;
            maNV.ReadOnly = false;
            maNhom.ReadOnly = false;
            chucVu.ReadOnly = false;
            sdt.Text = user.Sdt;
            name.Text = user.Ho + " " + user.Ten;
            email.Text = user.Email;
            birthDay.Value = user.NgaySinh;
            maNV.Text = user.MaNV;
            maBP.Text = user.TenBP;
            maNhom.Text = user.TenNhom;
            chucVu.Text = user.ChucVu;
            if (user.PhanLoai.Equals("Toàn thời gian"))
            {
                toanTG.BackColor = Color.Yellow;
                banTG.BackColor = Color.White;
                thuViec.BackColor = Color.White;
            }
            else if (user.PhanLoai.Equals("Bán thời gian"))
            {
                banTG.BackColor = Color.Yellow;
                toanTG.BackColor = Color.White;
                thuViec.BackColor = Color.White;
            }
            else
            {
                thuViec.BackColor = Color.Yellow;
                toanTG.BackColor = Color.White;
                banTG.BackColor = Color.White;
            }
            if (user.GioiTinh.Equals("Nam"))
            {
                Male.BackColor = Color.FromArgb(61, 133, 198);
                Female.BackColor = Color.White;
                sex = true;
                if (user.HinhAnh == null)
                {
                    malePTB.Visible = true;
                    femalePTB.Visible = false;
                    anhNV.Visible = false;
                }
                else
                {
                    malePTB.Visible = false;
                    femalePTB.Visible = false;
                    anhNV.Visible = true;
                    MemoryStream memory = new MemoryStream(user.HinhAnh);
                    anhNV.Image = Image.FromStream(memory);
                }
            }
            else if (user.GioiTinh.Equals("Nữ"))
            {
                Female.BackColor = Color.FromArgb(166, 77, 121);
                Male.BackColor = Color.White;
                sex = false;
                if (user.HinhAnh == null)
                {
                    malePTB.Visible = false;
                    femalePTB.Visible = true;
                    anhNV.Visible = false;
                }
                else
                {
                    malePTB.Visible = false;
                    femalePTB.Visible = false;
                    anhNV.Visible = true;
                    MemoryStream memory = new MemoryStream(user.HinhAnh);
                    anhNV.Image = Image.FromStream(memory);
                }
            }
            maBP.ReadOnly = true;
            maNV.ReadOnly = true;
            maNhom.ReadOnly = true;
            chucVu.ReadOnly = true;
            chonAnh.Visible = false;
            xoaAnh.Visible = false;
            luuAnh.Visible = false;
            luuAnh.Enabled = false;
            huyDoiAnh.Visible = false;
        }

        private void TTCN_Load(object sender, EventArgs e)
        {
            load(user);
            offAnimationPTB();
            chonAnh.Visible = false;
            xoaAnh.Visible = false;
            luuAnh.Visible = false;
            luuAnh.Enabled = false;
            huyDoiAnh.Visible = false;
        }

        private void Male_Click(object sender, EventArgs e)
        {
            Male.BackColor = Color.FromArgb(61, 133, 198);
            Female.BackColor = Color.White;
            sex = true;
            if (user.HinhAnh == null)
            {
                malePTB.Visible = true;
                femalePTB.Visible = false;
                anhNV.Visible = false;
            }
            else
            {
                malePTB.Visible = false;
                femalePTB.Visible = false;
                anhNV.Visible = true;
            }
        }

        private void Female_Click(object sender, EventArgs e)
        {
            Female.BackColor = Color.FromArgb(166, 77, 121);
            Male.BackColor = Color.White;
            sex = false;
            if (user.HinhAnh == null)
            {
                malePTB.Visible = false;
                femalePTB.Visible = true;
                anhNV.Visible = false;
            }
            else
            {
                malePTB.Visible = false;
                femalePTB.Visible = false;
                anhNV.Visible = true;
            }
        }

        private void name_Enter(object sender, EventArgs e)
        {
            if (Luu.Visible)
            {
                namePTB.Visible = true;
                sNamePTB.Visible = false;
            }
        }

        private void name_Leave(object sender, EventArgs e)
        {
            if (Luu.Visible)
            {
                namePTB.Visible = false;
                sNamePTB.Visible = true;
            }
        }

        private void email_Enter(object sender, EventArgs e)
        {
            if (Luu.Visible)
            {
                emailPTB.Visible = true;
                sEmailPTB.Visible = false;
            }
        }

        private void email_Leave(object sender, EventArgs e)
        {
            if (Luu.Visible)
            {
                emailPTB.Visible = false;
                sEmailPTB.Visible = true;
            }
        }

        private void sdt_TextChanged(object sender, EventArgs e)
        {
        }

        private void sdt_Enter(object sender, EventArgs e)
        {
            if (Luu.Visible)
            {
                phonePTB.Visible = true;
                sPhonePTB.Visible = false;
            }
        }

        private void sdt_Leave(object sender, EventArgs e)
        {
            if (Luu.Visible)
            {
                phonePTB.Visible = true;
                sPhonePTB.Visible = false;
            }
        }

        private void birthDay_Enter(object sender, EventArgs e)
        {
            if (Luu.Visible)
            {
                birthdayPTB.Visible = true;
                sBirthdayPTB.Visible = false;
            }
        }

        private void birthDay_Leave(object sender, EventArgs e)
        {
            if (Luu.Visible)
            {
                birthdayPTB.Visible = false;
                sBirthdayPTB.Visible = true;
            }
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            if (Luu.Visible)
            {
                sexPTB.Visible = true;
                sSexPTB.Visible = false;
            }
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            if (Luu.Visible)
            {
                sexPTB.Visible = false;
                sSexPTB.Visible = true;
            }
        }

        private void maNV_MouseHover(object sender, EventArgs e)
        {
            if (Luu.Visible)
            {
                idPTB.Visible = true;
                sIdPTB.Visible = false;
            }
        }

        private void maNV_MouseLeave(object sender, EventArgs e)
        {
            if (Luu.Visible)
            {
                idPTB.Visible = false;
                sIdPTB.Visible = true;
            }
        }

        private void maNhom_MouseHover(object sender, EventArgs e)
        {
            if (Luu.Visible)
            {
                teamPTB.Visible = true;
                sTeamPTB.Visible = false;
            }
        }

        private void maNhom_MouseLeave(object sender, EventArgs e)
        {
            if (Luu.Visible)
            {
                teamPTB.Visible = false;
                sTeamPTB.Visible = true;
            }
        }

        private void maBP_MouseHover(object sender, EventArgs e)
        {
            if (Luu.Visible)
            {
                groupPTB.Visible = true;
                sGroupPTB.Visible = false;
            }
        }

        private void maBP_MouseLeave(object sender, EventArgs e)
        {
            if (Luu.Visible)
            {
                groupPTB.Visible = false;
                sGroupPTB.Visible = true;
            }
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            if (Luu.Visible)
            {
                typePTB.Visible = true;
                sTypePTB.Visible = false;
            }
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            if (Luu.Visible)
            {
                typePTB.Visible = false;
                sTypePTB.Visible = true;
            }
        }

        private void chucVu_MouseHover(object sender, EventArgs e)
        {
            if (Luu.Visible)
            {
                chucVuPTB.Visible = true;
                sChucVuPTB.Visible = false;
            }
        }

        private void chucVu_MouseLeave(object sender, EventArgs e)
        {
            if (Luu.Visible)
            {
                chucVuPTB.Visible = false;
                sChucVuPTB.Visible = true;
            }
        }

        private void chonAnh_MouseHover(object sender, EventArgs e)
        {
            Button temp = (Button)sender;
            temp.BackColor = Color.FromArgb(67, 65, 72);
        }

        private void chonAnh_MouseLeave(object sender, EventArgs e)
        {
            Button temp = (Button)sender;
            temp.BackColor = Color.White;
        }

        private void changePicBtn_Click(object sender, EventArgs e)
        {
            chonAnh.Visible = true;
            xoaAnh.Visible = true;
            luuAnh.Visible = true;
            luuAnh.Enabled = false;
            huyDoiAnh.Visible = true;
        }

        private void huyDoiAnh_Click(object sender, EventArgs e)
        {
            anhNV.Image = oldImage;
            load(user);
        }

        private void xoaAnh_Click(object sender, EventArgs e)
        {
            string query = "Update Person Set hình_ảnh = null where Mã_nhân_viên = '" + user.MaNV + "';";
            modify m = new modify();
            m.Command(query);
            query = "Select * from Person where Mã_nhân_viên = '" + user.MaNV + "';";
            user = m.person(query);
            anhNV.Image = null;
            load(user);
        }

        private void chonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Chọn ảnh";
            open.Filter = "Image Files(*.gif; *.jpg; *.jpeg; *.bmp; *.wmf; *.png)| *.gif; *.jpg; *.jpeg; *.bmp; *.wmf; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                anhNV.ImageLocation = open.FileName;
            }
            oldImage = anhNV.Image;
            checkAvatar.Start();
            femalePTB.Visible = false;
            malePTB.Visible = false;
            anhNV.Visible = true;
        }

        private byte[] imgToByte(PictureBox anhNhanVien)
        {
            MemoryStream memory = new MemoryStream();
            anhNhanVien.Image.Save(memory, anhNhanVien.Image.RawFormat);
            return memory.ToArray();
        }

        private void luuAnh_Click(object sender, EventArgs e)
        {
            modify m = new modify();
            string query = "Update Person Set hình_ảnh = @Anh where Mã_nhân_viên = '" + user.MaNV + "';";
            try
            {
                m.CommandAnh(query, imgToByte(anhNV));
                query = "Select * from Person where Mã_nhân_viên = '" + user.MaNV + "';";
                user = m.person(query);
                load(user);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu ảnh" + ex.Message);
            }
            checkAvatar.Stop();
        }

        private void checkAvatar_Tick(object sender, EventArgs e)
        {
            if (anhNV.Image != null)
            {
                luuAnh.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            changePass change = new changePass(user);
            change.FormBorderStyle = FormBorderStyle.None;
            change.ShowDialog();
        }
    }
}
