namespace WinFormsApp1
{
    partial class TTCN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TTCN));
            phonePTB = new PictureBox();
            sdt = new TextBox();
            sdtTittle = new Label();
            emailPTB = new PictureBox();
            email = new TextBox();
            emailTittle = new Label();
            label3 = new Label();
            namePTB = new PictureBox();
            birthdayPTB = new PictureBox();
            name = new TextBox();
            gt = new Label();
            sexPTB = new PictureBox();
            fullName = new Label();
            Male = new Button();
            changePicBtn = new Button();
            Female = new Button();
            birthDay = new DateTimePicker();
            malePTB = new PictureBox();
            panel1 = new Panel();
            huyDoiAnh = new Button();
            luuAnh = new Button();
            xoaAnh = new Button();
            chonAnh = new Button();
            anhNV = new PictureBox();
            sChucVuPTB = new PictureBox();
            label5 = new Label();
            chucVuPTB = new PictureBox();
            chucVu = new TextBox();
            sTypePTB = new PictureBox();
            label4 = new Label();
            typePTB = new PictureBox();
            banTG = new Button();
            toanTG = new Button();
            thuViec = new Button();
            sGroupPTB = new PictureBox();
            sTeamPTB = new PictureBox();
            sIdPTB = new PictureBox();
            sBirthdayPTB = new PictureBox();
            sSexPTB = new PictureBox();
            sPhonePTB = new PictureBox();
            sEmailPTB = new PictureBox();
            sNamePTB = new PictureBox();
            id = new Label();
            idPTB = new PictureBox();
            maNV = new TextBox();
            femalePTB = new PictureBox();
            button2 = new Button();
            Huy = new Button();
            Luu = new Button();
            button1 = new Button();
            label2 = new Label();
            groupPTB = new PictureBox();
            maBP = new TextBox();
            label1 = new Label();
            teamPTB = new PictureBox();
            maNhom = new TextBox();
            checkAvatar = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)phonePTB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emailPTB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)namePTB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)birthdayPTB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sexPTB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)malePTB).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)anhNV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sChucVuPTB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chucVuPTB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sTypePTB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)typePTB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sGroupPTB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sTeamPTB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sIdPTB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sBirthdayPTB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sSexPTB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sPhonePTB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sEmailPTB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sNamePTB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)idPTB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)femalePTB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupPTB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)teamPTB).BeginInit();
            SuspendLayout();
            // 
            // phonePTB
            // 
            phonePTB.Anchor = AnchorStyles.None;
            phonePTB.Image = (Image)resources.GetObject("phonePTB.Image");
            phonePTB.Location = new Point(862, 570);
            phonePTB.Name = "phonePTB";
            phonePTB.Size = new Size(55, 55);
            phonePTB.SizeMode = PictureBoxSizeMode.Zoom;
            phonePTB.TabIndex = 12;
            phonePTB.TabStop = false;
            // 
            // sdt
            // 
            sdt.Anchor = AnchorStyles.None;
            sdt.Cursor = Cursors.Hand;
            sdt.Enabled = false;
            sdt.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sdt.Location = new Point(862, 631);
            sdt.Multiline = true;
            sdt.Name = "sdt";
            sdt.PlaceholderText = "Số điện thoại";
            sdt.Size = new Size(270, 31);
            sdt.TabIndex = 11;
            sdt.TextChanged += sdt_TextChanged;
            sdt.Enter += sdt_Enter;
            sdt.Leave += sdt_Leave;
            // 
            // sdtTittle
            // 
            sdtTittle.Anchor = AnchorStyles.None;
            sdtTittle.AutoSize = true;
            sdtTittle.BackColor = Color.FromArgb(64, 57, 36);
            sdtTittle.Font = new Font("Tahoma", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            sdtTittle.ForeColor = Color.White;
            sdtTittle.ImageAlign = ContentAlignment.MiddleLeft;
            sdtTittle.Location = new Point(923, 588);
            sdtTittle.Name = "sdtTittle";
            sdtTittle.Size = new Size(165, 28);
            sdtTittle.TabIndex = 10;
            sdtTittle.Text = "Số điện thoại";
            // 
            // emailPTB
            // 
            emailPTB.Anchor = AnchorStyles.None;
            emailPTB.Image = (Image)resources.GetObject("emailPTB.Image");
            emailPTB.Location = new Point(862, 465);
            emailPTB.Name = "emailPTB";
            emailPTB.Size = new Size(55, 55);
            emailPTB.SizeMode = PictureBoxSizeMode.Zoom;
            emailPTB.TabIndex = 9;
            emailPTB.TabStop = false;
            // 
            // email
            // 
            email.Anchor = AnchorStyles.None;
            email.Cursor = Cursors.Hand;
            email.Enabled = false;
            email.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            email.Location = new Point(862, 526);
            email.Multiline = true;
            email.Name = "email";
            email.PlaceholderText = "Email";
            email.Size = new Size(270, 31);
            email.TabIndex = 8;
            email.TextChanged += textBox2_TextChanged;
            email.Enter += email_Enter;
            email.Leave += email_Leave;
            // 
            // emailTittle
            // 
            emailTittle.Anchor = AnchorStyles.None;
            emailTittle.AutoSize = true;
            emailTittle.BackColor = Color.FromArgb(64, 57, 36);
            emailTittle.Font = new Font("Tahoma", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            emailTittle.ForeColor = Color.White;
            emailTittle.ImageAlign = ContentAlignment.MiddleLeft;
            emailTittle.Location = new Point(923, 480);
            emailTittle.Name = "emailTittle";
            emailTittle.Size = new Size(76, 28);
            emailTittle.TabIndex = 7;
            emailTittle.Text = "Email";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(64, 57, 36);
            label3.Font = new Font("Tahoma", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(607, 588);
            label3.Name = "label3";
            label3.Size = new Size(127, 28);
            label3.TabIndex = 16;
            label3.Text = "Ngày sinh";
            // 
            // namePTB
            // 
            namePTB.Anchor = AnchorStyles.None;
            namePTB.BackgroundImageLayout = ImageLayout.Zoom;
            namePTB.Image = (Image)resources.GetObject("namePTB.Image");
            namePTB.Location = new Point(862, 359);
            namePTB.Name = "namePTB";
            namePTB.Size = new Size(55, 55);
            namePTB.SizeMode = PictureBoxSizeMode.Zoom;
            namePTB.TabIndex = 6;
            namePTB.TabStop = false;
            // 
            // birthdayPTB
            // 
            birthdayPTB.Anchor = AnchorStyles.None;
            birthdayPTB.Image = (Image)resources.GetObject("birthdayPTB.Image");
            birthdayPTB.Location = new Point(546, 570);
            birthdayPTB.Name = "birthdayPTB";
            birthdayPTB.Size = new Size(55, 55);
            birthdayPTB.SizeMode = PictureBoxSizeMode.Zoom;
            birthdayPTB.TabIndex = 18;
            birthdayPTB.TabStop = false;
            // 
            // name
            // 
            name.Anchor = AnchorStyles.None;
            name.Cursor = Cursors.Hand;
            name.Enabled = false;
            name.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            name.Location = new Point(862, 420);
            name.Multiline = true;
            name.Name = "name";
            name.PlaceholderText = "Họ và tên";
            name.Size = new Size(270, 31);
            name.TabIndex = 5;
            name.Enter += name_Enter;
            name.Leave += name_Leave;
            // 
            // gt
            // 
            gt.Anchor = AnchorStyles.None;
            gt.AutoSize = true;
            gt.BackColor = Color.FromArgb(64, 57, 36);
            gt.Font = new Font("Tahoma", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            gt.ForeColor = Color.White;
            gt.ImageAlign = ContentAlignment.MiddleLeft;
            gt.Location = new Point(607, 377);
            gt.Name = "gt";
            gt.Size = new Size(111, 28);
            gt.TabIndex = 19;
            gt.Text = "Giới tính";
            // 
            // sexPTB
            // 
            sexPTB.Anchor = AnchorStyles.None;
            sexPTB.Image = (Image)resources.GetObject("sexPTB.Image");
            sexPTB.Location = new Point(546, 359);
            sexPTB.Name = "sexPTB";
            sexPTB.Size = new Size(55, 55);
            sexPTB.SizeMode = PictureBoxSizeMode.Zoom;
            sexPTB.TabIndex = 21;
            sexPTB.TabStop = false;
            // 
            // fullName
            // 
            fullName.Anchor = AnchorStyles.None;
            fullName.AutoSize = true;
            fullName.BackColor = Color.FromArgb(64, 57, 36);
            fullName.FlatStyle = FlatStyle.Popup;
            fullName.Font = new Font("Tahoma", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            fullName.ForeColor = Color.White;
            fullName.ImageAlign = ContentAlignment.MiddleLeft;
            fullName.Location = new Point(923, 377);
            fullName.Name = "fullName";
            fullName.Size = new Size(124, 28);
            fullName.TabIndex = 3;
            fullName.Text = "Họ và tên";
            // 
            // Male
            // 
            Male.Anchor = AnchorStyles.None;
            Male.BackColor = Color.White;
            Male.Cursor = Cursors.Hand;
            Male.Enabled = false;
            Male.FlatStyle = FlatStyle.Flat;
            Male.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Male.Image = (Image)resources.GetObject("Male.Image");
            Male.ImageAlign = ContentAlignment.MiddleLeft;
            Male.Location = new Point(546, 416);
            Male.Name = "Male";
            Male.Size = new Size(172, 68);
            Male.TabIndex = 22;
            Male.Text = "       Nam";
            Male.UseVisualStyleBackColor = false;
            Male.Click += Male_Click;
            Male.MouseLeave += panel1_MouseLeave;
            Male.MouseHover += panel1_MouseHover;
            // 
            // changePicBtn
            // 
            changePicBtn.Anchor = AnchorStyles.None;
            changePicBtn.BackColor = Color.FromArgb(64, 57, 36);
            changePicBtn.Cursor = Cursors.Hand;
            changePicBtn.FlatStyle = FlatStyle.Flat;
            changePicBtn.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            changePicBtn.ForeColor = Color.White;
            changePicBtn.Image = (Image)resources.GetObject("changePicBtn.Image");
            changePicBtn.ImageAlign = ContentAlignment.MiddleLeft;
            changePicBtn.Location = new Point(862, 29);
            changePicBtn.Name = "changePicBtn";
            changePicBtn.Size = new Size(170, 40);
            changePicBtn.TabIndex = 3;
            changePicBtn.Text = "Thay đổi ảnh";
            changePicBtn.TextAlign = ContentAlignment.MiddleRight;
            changePicBtn.UseVisualStyleBackColor = false;
            changePicBtn.Click += changePicBtn_Click;
            // 
            // Female
            // 
            Female.Anchor = AnchorStyles.None;
            Female.BackColor = Color.White;
            Female.Cursor = Cursors.Hand;
            Female.Enabled = false;
            Female.FlatStyle = FlatStyle.Flat;
            Female.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            Female.Image = (Image)resources.GetObject("Female.Image");
            Female.ImageAlign = ContentAlignment.MiddleLeft;
            Female.Location = new Point(624, 490);
            Female.Name = "Female";
            Female.Size = new Size(172, 68);
            Female.TabIndex = 23;
            Female.Text = "     Nữ";
            Female.UseVisualStyleBackColor = false;
            Female.Click += Female_Click;
            Female.MouseLeave += panel1_MouseLeave;
            Female.MouseHover += panel1_MouseHover;
            // 
            // birthDay
            // 
            birthDay.Anchor = AnchorStyles.None;
            birthDay.Cursor = Cursors.Hand;
            birthDay.Enabled = false;
            birthDay.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            birthDay.Location = new Point(546, 631);
            birthDay.Name = "birthDay";
            birthDay.Size = new Size(250, 32);
            birthDay.TabIndex = 27;
            birthDay.Enter += birthDay_Enter;
            birthDay.Leave += birthDay_Leave;
            // 
            // malePTB
            // 
            malePTB.Anchor = AnchorStyles.None;
            malePTB.Image = (Image)resources.GetObject("malePTB.Image");
            malePTB.Location = new Point(546, 29);
            malePTB.Name = "malePTB";
            malePTB.Size = new Size(250, 250);
            malePTB.SizeMode = PictureBoxSizeMode.Zoom;
            malePTB.TabIndex = 0;
            malePTB.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(32, 33, 36);
            panel1.Controls.Add(huyDoiAnh);
            panel1.Controls.Add(luuAnh);
            panel1.Controls.Add(xoaAnh);
            panel1.Controls.Add(chonAnh);
            panel1.Controls.Add(anhNV);
            panel1.Controls.Add(sChucVuPTB);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(chucVuPTB);
            panel1.Controls.Add(chucVu);
            panel1.Controls.Add(sTypePTB);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(typePTB);
            panel1.Controls.Add(banTG);
            panel1.Controls.Add(toanTG);
            panel1.Controls.Add(thuViec);
            panel1.Controls.Add(sGroupPTB);
            panel1.Controls.Add(sTeamPTB);
            panel1.Controls.Add(sIdPTB);
            panel1.Controls.Add(sBirthdayPTB);
            panel1.Controls.Add(sSexPTB);
            panel1.Controls.Add(sPhonePTB);
            panel1.Controls.Add(sEmailPTB);
            panel1.Controls.Add(sNamePTB);
            panel1.Controls.Add(id);
            panel1.Controls.Add(idPTB);
            panel1.Controls.Add(maNV);
            panel1.Controls.Add(femalePTB);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(Huy);
            panel1.Controls.Add(Luu);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(groupPTB);
            panel1.Controls.Add(maBP);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(teamPTB);
            panel1.Controls.Add(maNhom);
            panel1.Controls.Add(malePTB);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(birthDay);
            panel1.Controls.Add(namePTB);
            panel1.Controls.Add(phonePTB);
            panel1.Controls.Add(emailTittle);
            panel1.Controls.Add(Female);
            panel1.Controls.Add(birthdayPTB);
            panel1.Controls.Add(sdt);
            panel1.Controls.Add(email);
            panel1.Controls.Add(changePicBtn);
            panel1.Controls.Add(name);
            panel1.Controls.Add(Male);
            panel1.Controls.Add(gt);
            panel1.Controls.Add(sdtTittle);
            panel1.Controls.Add(emailPTB);
            panel1.Controls.Add(fullName);
            panel1.Controls.Add(sexPTB);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(150, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1232, 706);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint_1;
            panel1.MouseLeave += button4_MouseLeave;
            panel1.MouseHover += button4_MouseHover;
            // 
            // huyDoiAnh
            // 
            huyDoiAnh.BackColor = Color.Firebrick;
            huyDoiAnh.FlatStyle = FlatStyle.Flat;
            huyDoiAnh.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            huyDoiAnh.ForeColor = Color.White;
            huyDoiAnh.Location = new Point(982, 111);
            huyDoiAnh.Name = "huyDoiAnh";
            huyDoiAnh.Size = new Size(110, 30);
            huyDoiAnh.TabIndex = 69;
            huyDoiAnh.Text = "Hủy";
            huyDoiAnh.UseVisualStyleBackColor = false;
            huyDoiAnh.Click += huyDoiAnh_Click;
            // 
            // luuAnh
            // 
            luuAnh.BackColor = Color.DarkGreen;
            luuAnh.FlatStyle = FlatStyle.Flat;
            luuAnh.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            luuAnh.ForeColor = Color.White;
            luuAnh.Location = new Point(862, 111);
            luuAnh.Name = "luuAnh";
            luuAnh.Size = new Size(110, 30);
            luuAnh.TabIndex = 68;
            luuAnh.Text = "Lưu";
            luuAnh.UseVisualStyleBackColor = false;
            luuAnh.Click += luuAnh_Click;
            // 
            // xoaAnh
            // 
            xoaAnh.BackColor = Color.White;
            xoaAnh.FlatStyle = FlatStyle.Flat;
            xoaAnh.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            xoaAnh.Location = new Point(982, 75);
            xoaAnh.Name = "xoaAnh";
            xoaAnh.Size = new Size(110, 30);
            xoaAnh.TabIndex = 67;
            xoaAnh.Text = "Xóa ảnh";
            xoaAnh.UseVisualStyleBackColor = false;
            xoaAnh.Click += xoaAnh_Click;
            xoaAnh.MouseLeave += chonAnh_MouseLeave;
            xoaAnh.MouseHover += chonAnh_MouseHover;
            // 
            // chonAnh
            // 
            chonAnh.BackColor = Color.White;
            chonAnh.FlatStyle = FlatStyle.Flat;
            chonAnh.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            chonAnh.Location = new Point(862, 75);
            chonAnh.Name = "chonAnh";
            chonAnh.Size = new Size(110, 30);
            chonAnh.TabIndex = 66;
            chonAnh.Text = "Chọn ảnh";
            chonAnh.UseVisualStyleBackColor = false;
            chonAnh.Click += chonAnh_Click;
            chonAnh.MouseLeave += chonAnh_MouseLeave;
            chonAnh.MouseHover += chonAnh_MouseHover;
            // 
            // anhNV
            // 
            anhNV.Location = new Point(546, 29);
            anhNV.Name = "anhNV";
            anhNV.Size = new Size(250, 250);
            anhNV.SizeMode = PictureBoxSizeMode.Zoom;
            anhNV.TabIndex = 65;
            anhNV.TabStop = false;
            // 
            // sChucVuPTB
            // 
            sChucVuPTB.Anchor = AnchorStyles.None;
            sChucVuPTB.BackgroundImage = (Image)resources.GetObject("sChucVuPTB.BackgroundImage");
            sChucVuPTB.BackgroundImageLayout = ImageLayout.Zoom;
            sChucVuPTB.Location = new Point(236, 255);
            sChucVuPTB.Name = "sChucVuPTB";
            sChucVuPTB.Size = new Size(55, 55);
            sChucVuPTB.SizeMode = PictureBoxSizeMode.Zoom;
            sChucVuPTB.TabIndex = 64;
            sChucVuPTB.TabStop = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(64, 57, 36);
            label5.Font = new Font("Tahoma", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.ImageAlign = ContentAlignment.MiddleLeft;
            label5.Location = new Point(297, 271);
            label5.Name = "label5";
            label5.Size = new Size(106, 28);
            label5.TabIndex = 61;
            label5.Text = "Chức vụ";
            // 
            // chucVuPTB
            // 
            chucVuPTB.Anchor = AnchorStyles.None;
            chucVuPTB.Image = (Image)resources.GetObject("chucVuPTB.Image");
            chucVuPTB.Location = new Point(236, 255);
            chucVuPTB.Name = "chucVuPTB";
            chucVuPTB.Size = new Size(55, 55);
            chucVuPTB.SizeMode = PictureBoxSizeMode.Zoom;
            chucVuPTB.TabIndex = 63;
            chucVuPTB.TabStop = false;
            // 
            // chucVu
            // 
            chucVu.Anchor = AnchorStyles.None;
            chucVu.Cursor = Cursors.Hand;
            chucVu.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chucVu.Location = new Point(236, 316);
            chucVu.Multiline = true;
            chucVu.Name = "chucVu";
            chucVu.PlaceholderText = "Chức vụ";
            chucVu.Size = new Size(230, 31);
            chucVu.TabIndex = 62;
            chucVu.MouseLeave += chucVu_MouseLeave;
            chucVu.MouseHover += chucVu_MouseHover;
            // 
            // sTypePTB
            // 
            sTypePTB.Anchor = AnchorStyles.None;
            sTypePTB.BackgroundImage = (Image)resources.GetObject("sTypePTB.BackgroundImage");
            sTypePTB.BackgroundImageLayout = ImageLayout.Zoom;
            sTypePTB.Location = new Point(236, 29);
            sTypePTB.Name = "sTypePTB";
            sTypePTB.Size = new Size(55, 55);
            sTypePTB.SizeMode = PictureBoxSizeMode.Zoom;
            sTypePTB.TabIndex = 60;
            sTypePTB.TabStop = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(64, 57, 36);
            label4.Font = new Font("Tahoma", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.Location = new Point(297, 45);
            label4.Name = "label4";
            label4.Size = new Size(120, 28);
            label4.TabIndex = 58;
            label4.Text = "Phân loại";
            // 
            // typePTB
            // 
            typePTB.Anchor = AnchorStyles.None;
            typePTB.Image = (Image)resources.GetObject("typePTB.Image");
            typePTB.Location = new Point(236, 29);
            typePTB.Name = "typePTB";
            typePTB.Size = new Size(55, 55);
            typePTB.SizeMode = PictureBoxSizeMode.Zoom;
            typePTB.TabIndex = 59;
            typePTB.TabStop = false;
            // 
            // banTG
            // 
            banTG.BackColor = Color.White;
            banTG.FlatStyle = FlatStyle.Flat;
            banTG.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            banTG.Location = new Point(279, 136);
            banTG.Name = "banTG";
            banTG.Size = new Size(150, 40);
            banTG.TabIndex = 57;
            banTG.Text = "Bán thời gian";
            banTG.UseVisualStyleBackColor = false;
            banTG.MouseLeave += button4_MouseLeave;
            banTG.MouseHover += button4_MouseHover;
            // 
            // toanTG
            // 
            toanTG.BackColor = Color.White;
            toanTG.FlatStyle = FlatStyle.Flat;
            toanTG.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            toanTG.Location = new Point(236, 90);
            toanTG.Name = "toanTG";
            toanTG.Size = new Size(150, 40);
            toanTG.TabIndex = 56;
            toanTG.Text = "Toàn thời gian";
            toanTG.UseVisualStyleBackColor = false;
            toanTG.MouseLeave += button4_MouseLeave;
            toanTG.MouseHover += button4_MouseHover;
            // 
            // thuViec
            // 
            thuViec.BackColor = Color.White;
            thuViec.FlatStyle = FlatStyle.Flat;
            thuViec.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            thuViec.Location = new Point(316, 182);
            thuViec.Name = "thuViec";
            thuViec.Size = new Size(150, 40);
            thuViec.TabIndex = 55;
            thuViec.Text = "Thử việc";
            thuViec.UseVisualStyleBackColor = false;
            thuViec.MouseLeave += button4_MouseLeave;
            thuViec.MouseHover += button4_MouseHover;
            // 
            // sGroupPTB
            // 
            sGroupPTB.Anchor = AnchorStyles.None;
            sGroupPTB.BackgroundImage = (Image)resources.GetObject("sGroupPTB.BackgroundImage");
            sGroupPTB.BackgroundImageLayout = ImageLayout.Zoom;
            sGroupPTB.Location = new Point(236, 570);
            sGroupPTB.Name = "sGroupPTB";
            sGroupPTB.Size = new Size(55, 55);
            sGroupPTB.SizeMode = PictureBoxSizeMode.Zoom;
            sGroupPTB.TabIndex = 54;
            sGroupPTB.TabStop = false;
            // 
            // sTeamPTB
            // 
            sTeamPTB.Anchor = AnchorStyles.None;
            sTeamPTB.BackgroundImage = (Image)resources.GetObject("sTeamPTB.BackgroundImage");
            sTeamPTB.BackgroundImageLayout = ImageLayout.Zoom;
            sTeamPTB.Location = new Point(236, 465);
            sTeamPTB.Name = "sTeamPTB";
            sTeamPTB.Size = new Size(55, 55);
            sTeamPTB.SizeMode = PictureBoxSizeMode.Zoom;
            sTeamPTB.TabIndex = 53;
            sTeamPTB.TabStop = false;
            // 
            // sIdPTB
            // 
            sIdPTB.Anchor = AnchorStyles.None;
            sIdPTB.BackgroundImage = (Image)resources.GetObject("sIdPTB.BackgroundImage");
            sIdPTB.BackgroundImageLayout = ImageLayout.Zoom;
            sIdPTB.Location = new Point(236, 359);
            sIdPTB.Name = "sIdPTB";
            sIdPTB.Size = new Size(55, 55);
            sIdPTB.SizeMode = PictureBoxSizeMode.Zoom;
            sIdPTB.TabIndex = 52;
            sIdPTB.TabStop = false;
            // 
            // sBirthdayPTB
            // 
            sBirthdayPTB.Anchor = AnchorStyles.None;
            sBirthdayPTB.BackgroundImage = (Image)resources.GetObject("sBirthdayPTB.BackgroundImage");
            sBirthdayPTB.BackgroundImageLayout = ImageLayout.Zoom;
            sBirthdayPTB.Location = new Point(546, 570);
            sBirthdayPTB.Name = "sBirthdayPTB";
            sBirthdayPTB.Size = new Size(55, 55);
            sBirthdayPTB.SizeMode = PictureBoxSizeMode.Zoom;
            sBirthdayPTB.TabIndex = 51;
            sBirthdayPTB.TabStop = false;
            // 
            // sSexPTB
            // 
            sSexPTB.Anchor = AnchorStyles.None;
            sSexPTB.BackgroundImage = (Image)resources.GetObject("sSexPTB.BackgroundImage");
            sSexPTB.BackgroundImageLayout = ImageLayout.Zoom;
            sSexPTB.Location = new Point(546, 359);
            sSexPTB.Name = "sSexPTB";
            sSexPTB.Size = new Size(55, 55);
            sSexPTB.SizeMode = PictureBoxSizeMode.Zoom;
            sSexPTB.TabIndex = 50;
            sSexPTB.TabStop = false;
            // 
            // sPhonePTB
            // 
            sPhonePTB.Anchor = AnchorStyles.None;
            sPhonePTB.BackgroundImage = (Image)resources.GetObject("sPhonePTB.BackgroundImage");
            sPhonePTB.BackgroundImageLayout = ImageLayout.Zoom;
            sPhonePTB.Location = new Point(862, 570);
            sPhonePTB.Name = "sPhonePTB";
            sPhonePTB.Size = new Size(55, 55);
            sPhonePTB.SizeMode = PictureBoxSizeMode.Zoom;
            sPhonePTB.TabIndex = 49;
            sPhonePTB.TabStop = false;
            // 
            // sEmailPTB
            // 
            sEmailPTB.Anchor = AnchorStyles.None;
            sEmailPTB.BackgroundImage = (Image)resources.GetObject("sEmailPTB.BackgroundImage");
            sEmailPTB.BackgroundImageLayout = ImageLayout.Zoom;
            sEmailPTB.Location = new Point(862, 465);
            sEmailPTB.Name = "sEmailPTB";
            sEmailPTB.Size = new Size(55, 55);
            sEmailPTB.SizeMode = PictureBoxSizeMode.Zoom;
            sEmailPTB.TabIndex = 48;
            sEmailPTB.TabStop = false;
            // 
            // sNamePTB
            // 
            sNamePTB.Anchor = AnchorStyles.None;
            sNamePTB.BackgroundImage = (Image)resources.GetObject("sNamePTB.BackgroundImage");
            sNamePTB.BackgroundImageLayout = ImageLayout.Zoom;
            sNamePTB.Location = new Point(862, 359);
            sNamePTB.Name = "sNamePTB";
            sNamePTB.Size = new Size(55, 55);
            sNamePTB.SizeMode = PictureBoxSizeMode.Zoom;
            sNamePTB.TabIndex = 47;
            sNamePTB.TabStop = false;
            // 
            // id
            // 
            id.Anchor = AnchorStyles.None;
            id.AutoSize = true;
            id.BackColor = Color.FromArgb(64, 57, 36);
            id.Font = new Font("Tahoma", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            id.ForeColor = Color.White;
            id.ImageAlign = ContentAlignment.MiddleLeft;
            id.Location = new Point(297, 375);
            id.Name = "id";
            id.Size = new Size(169, 28);
            id.TabIndex = 13;
            id.Text = "Mã nhân viên";
            // 
            // idPTB
            // 
            idPTB.Anchor = AnchorStyles.None;
            idPTB.Image = (Image)resources.GetObject("idPTB.Image");
            idPTB.Location = new Point(236, 359);
            idPTB.Name = "idPTB";
            idPTB.Size = new Size(55, 55);
            idPTB.SizeMode = PictureBoxSizeMode.Zoom;
            idPTB.TabIndex = 15;
            idPTB.TabStop = false;
            // 
            // maNV
            // 
            maNV.Anchor = AnchorStyles.None;
            maNV.Cursor = Cursors.Hand;
            maNV.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            maNV.Location = new Point(236, 420);
            maNV.Multiline = true;
            maNV.Name = "maNV";
            maNV.PlaceholderText = "Mã nhân viên";
            maNV.Size = new Size(230, 31);
            maNV.TabIndex = 14;
            maNV.TextChanged += textBox4_TextChanged;
            maNV.MouseLeave += maNV_MouseLeave;
            maNV.MouseHover += maNV_MouseHover;
            // 
            // femalePTB
            // 
            femalePTB.Anchor = AnchorStyles.None;
            femalePTB.Enabled = false;
            femalePTB.Image = (Image)resources.GetObject("femalePTB.Image");
            femalePTB.Location = new Point(546, 29);
            femalePTB.Name = "femalePTB";
            femalePTB.Size = new Size(250, 250);
            femalePTB.SizeMode = PictureBoxSizeMode.Zoom;
            femalePTB.TabIndex = 46;
            femalePTB.TabStop = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.FromArgb(64, 57, 36);
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(862, 159);
            button2.Name = "button2";
            button2.Size = new Size(170, 40);
            button2.TabIndex = 37;
            button2.Text = "   Đổi mật khẩu";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Huy
            // 
            Huy.Anchor = AnchorStyles.None;
            Huy.BackColor = Color.Firebrick;
            Huy.Cursor = Cursors.Hand;
            Huy.FlatStyle = FlatStyle.Flat;
            Huy.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Huy.ForeColor = Color.White;
            Huy.Location = new Point(998, 270);
            Huy.Name = "Huy";
            Huy.Size = new Size(94, 40);
            Huy.TabIndex = 36;
            Huy.Text = "Hủy";
            Huy.UseVisualStyleBackColor = false;
            Huy.Visible = false;
            Huy.Click += Huy_Click;
            // 
            // Luu
            // 
            Luu.Anchor = AnchorStyles.None;
            Luu.BackColor = Color.DarkGreen;
            Luu.Cursor = Cursors.Hand;
            Luu.FlatStyle = FlatStyle.Flat;
            Luu.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Luu.ForeColor = Color.White;
            Luu.Location = new Point(862, 270);
            Luu.Name = "Luu";
            Luu.Size = new Size(94, 40);
            Luu.TabIndex = 35;
            Luu.Text = "Lưa";
            Luu.UseVisualStyleBackColor = false;
            Luu.Visible = false;
            Luu.Click += Luu_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(64, 57, 36);
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(862, 224);
            button1.Name = "button1";
            button1.Size = new Size(230, 40);
            button1.TabIndex = 34;
            button1.Text = "Chỉnh sửa thông tin";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(64, 57, 36);
            label2.Font = new Font("Tahoma", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(297, 586);
            label2.Name = "label2";
            label2.Size = new Size(156, 28);
            label2.TabIndex = 31;
            label2.Text = "Tên bộ phận";
            // 
            // groupPTB
            // 
            groupPTB.Anchor = AnchorStyles.None;
            groupPTB.Image = (Image)resources.GetObject("groupPTB.Image");
            groupPTB.Location = new Point(236, 570);
            groupPTB.Name = "groupPTB";
            groupPTB.Size = new Size(55, 55);
            groupPTB.SizeMode = PictureBoxSizeMode.Zoom;
            groupPTB.TabIndex = 33;
            groupPTB.TabStop = false;
            // 
            // maBP
            // 
            maBP.Anchor = AnchorStyles.None;
            maBP.Cursor = Cursors.Hand;
            maBP.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            maBP.Location = new Point(236, 631);
            maBP.Multiline = true;
            maBP.Name = "maBP";
            maBP.PlaceholderText = "Mã bộ phận";
            maBP.Size = new Size(230, 31);
            maBP.TabIndex = 32;
            maBP.MouseLeave += maBP_MouseLeave;
            maBP.MouseHover += maBP_MouseHover;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(64, 57, 36);
            label1.Font = new Font("Tahoma", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(297, 481);
            label1.Name = "label1";
            label1.Size = new Size(131, 28);
            label1.TabIndex = 2;
            label1.Text = "Tên Nhóm";
            // 
            // teamPTB
            // 
            teamPTB.Anchor = AnchorStyles.None;
            teamPTB.Image = (Image)resources.GetObject("teamPTB.Image");
            teamPTB.Location = new Point(236, 465);
            teamPTB.Name = "teamPTB";
            teamPTB.Size = new Size(55, 55);
            teamPTB.SizeMode = PictureBoxSizeMode.Zoom;
            teamPTB.TabIndex = 30;
            teamPTB.TabStop = false;
            // 
            // maNhom
            // 
            maNhom.Anchor = AnchorStyles.None;
            maNhom.Cursor = Cursors.Hand;
            maNhom.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            maNhom.Location = new Point(236, 526);
            maNhom.Multiline = true;
            maNhom.Name = "maNhom";
            maNhom.PlaceholderText = "Mã nhóm";
            maNhom.Size = new Size(230, 31);
            maNhom.TabIndex = 29;
            maNhom.MouseLeave += maNhom_MouseLeave;
            maNhom.MouseHover += maNhom_MouseHover;
            // 
            // checkAvatar
            // 
            checkAvatar.Interval = 10;
            checkAvatar.Tick += checkAvatar_Tick;
            // 
            // TTCN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(32, 33, 36);
            ClientSize = new Size(1382, 706);
            Controls.Add(panel1);
            Cursor = Cursors.Hand;
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "TTCN";
            Text = "TTCN";
            Load += TTCN_Load;
            ((System.ComponentModel.ISupportInitialize)phonePTB).EndInit();
            ((System.ComponentModel.ISupportInitialize)emailPTB).EndInit();
            ((System.ComponentModel.ISupportInitialize)namePTB).EndInit();
            ((System.ComponentModel.ISupportInitialize)birthdayPTB).EndInit();
            ((System.ComponentModel.ISupportInitialize)sexPTB).EndInit();
            ((System.ComponentModel.ISupportInitialize)malePTB).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)anhNV).EndInit();
            ((System.ComponentModel.ISupportInitialize)sChucVuPTB).EndInit();
            ((System.ComponentModel.ISupportInitialize)chucVuPTB).EndInit();
            ((System.ComponentModel.ISupportInitialize)sTypePTB).EndInit();
            ((System.ComponentModel.ISupportInitialize)typePTB).EndInit();
            ((System.ComponentModel.ISupportInitialize)sGroupPTB).EndInit();
            ((System.ComponentModel.ISupportInitialize)sTeamPTB).EndInit();
            ((System.ComponentModel.ISupportInitialize)sIdPTB).EndInit();
            ((System.ComponentModel.ISupportInitialize)sBirthdayPTB).EndInit();
            ((System.ComponentModel.ISupportInitialize)sSexPTB).EndInit();
            ((System.ComponentModel.ISupportInitialize)sPhonePTB).EndInit();
            ((System.ComponentModel.ISupportInitialize)sEmailPTB).EndInit();
            ((System.ComponentModel.ISupportInitialize)sNamePTB).EndInit();
            ((System.ComponentModel.ISupportInitialize)idPTB).EndInit();
            ((System.ComponentModel.ISupportInitialize)femalePTB).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupPTB).EndInit();
            ((System.ComponentModel.ISupportInitialize)teamPTB).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox phonePTB;
        private TextBox sdt;
        private Label sdtTittle;
        private PictureBox emailPTB;
        private TextBox email;
        private Label emailTittle;
        private Label label3;
        private PictureBox namePTB;
        private PictureBox birthdayPTB;
        private TextBox name;
        private Label gt;
        private PictureBox sexPTB;
        private Label fullName;
        private Button Male;
        private Button changePicBtn;
        private Button Female;
        private DateTimePicker birthDay;
        private PictureBox malePTB;
        private Panel panel1;
        private Label label1;
        private PictureBox teamPTB;
        private TextBox maNhom;
        private Label label2;
        private PictureBox groupPTB;
        private TextBox maBP;
        private Button button1;
        private Button Huy;
        private Button Luu;
        private Button button2;
        private PictureBox femalePTB;
        private Label id;
        private PictureBox idPTB;
        private TextBox maNV;
        private PictureBox sNamePTB;
        private PictureBox sSexPTB;
        private PictureBox sPhonePTB;
        private PictureBox sEmailPTB;
        private PictureBox sGroupPTB;
        private PictureBox sTeamPTB;
        private PictureBox sIdPTB;
        private PictureBox sBirthdayPTB;
        private PictureBox sTypePTB;
        private Label label4;
        private PictureBox typePTB;
        private Button banTG;
        private Button toanTG;
        private Button thuViec;
        private PictureBox sChucVuPTB;
        private Label label5;
        private PictureBox chucVuPTB;
        private TextBox chucVu;
        private Button luuAnh;
        private Button xoaAnh;
        private Button chonAnh;
        private PictureBox anhNV;
        private Button huyDoiAnh;
        private System.Windows.Forms.Timer checkAvatar;
    }
}