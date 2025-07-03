namespace WinFormsApp1
{
    partial class ManagePerson
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            cboNhom = new ComboBox();
            label13 = new Label();
            cboPhanLoai = new ComboBox();
            label12 = new Label();
            button2 = new Button();
            cboTinhTrang = new ComboBox();
            txtMatKhau = new TextBox();
            txtGioiTinh = new TextBox();
            txtNgaySinh = new TextBox();
            txtEmail = new TextBox();
            txtTen = new TextBox();
            txtSDT = new TextBox();
            txtHo = new TextBox();
            label9 = new Label();
            cboPhanQuyen = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            button3 = new Button();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            cboBoPhan = new ComboBox();
            label10 = new Label();
            label11 = new Label();
            txtMaNhanVien = new TextBox();
            button4 = new Button();
            button5 = new Button();
            panel1 = new Panel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Window;
            groupBox1.Controls.Add(cboNhom);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(cboPhanLoai);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(cboTinhTrang);
            groupBox1.Controls.Add(txtMatKhau);
            groupBox1.Controls.Add(txtGioiTinh);
            groupBox1.Controls.Add(txtNgaySinh);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtTen);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(txtHo);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(cboPhanQuyen);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(153, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1129, 147);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập thông tin user";
            // 
            // cboNhom
            // 
            cboNhom.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNhom.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cboNhom.FormattingEnabled = true;
            cboNhom.Location = new Point(856, 71);
            cboNhom.Name = "cboNhom";
            cboNhom.Size = new Size(125, 26);
            cboNhom.TabIndex = 23;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(785, 73);
            label13.Name = "label13";
            label13.Size = new Size(53, 20);
            label13.TabIndex = 22;
            label13.Text = "Nhóm";
            // 
            // cboPhanLoai
            // 
            cboPhanLoai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPhanLoai.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cboPhanLoai.FormattingEnabled = true;
            cboPhanLoai.Items.AddRange(new object[] { "Bán thời gian", "Toàn thời gian", "Thử việc" });
            cboPhanLoai.Location = new Point(856, 105);
            cboPhanLoai.Name = "cboPhanLoai";
            cboPhanLoai.Size = new Size(125, 26);
            cboPhanLoai.TabIndex = 21;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(785, 108);
            label12.Name = "label12";
            label12.Size = new Size(73, 20);
            label12.TabIndex = 20;
            label12.Text = "Phân loại";
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(1029, 94);
            button2.Name = "button2";
            button2.Size = new Size(94, 39);
            button2.TabIndex = 19;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // cboTinhTrang
            // 
            cboTinhTrang.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTinhTrang.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cboTinhTrang.FormattingEnabled = true;
            cboTinhTrang.Items.AddRange(new object[] { "On", "Off" });
            cboTinhTrang.Location = new Point(617, 71);
            cboTinhTrang.Name = "cboTinhTrang";
            cboTinhTrang.Size = new Size(125, 26);
            cboTinhTrang.TabIndex = 17;
            // 
            // txtMatKhau
            // 
            txtMatKhau.BackColor = SystemColors.Window;
            txtMatKhau.BorderStyle = BorderStyle.FixedSingle;
            txtMatKhau.Location = new Point(617, 36);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(125, 26);
            txtMatKhau.TabIndex = 16;
            // 
            // txtGioiTinh
            // 
            txtGioiTinh.BorderStyle = BorderStyle.FixedSingle;
            txtGioiTinh.Location = new Point(321, 107);
            txtGioiTinh.Name = "txtGioiTinh";
            txtGioiTinh.Size = new Size(151, 26);
            txtGioiTinh.TabIndex = 15;
            // 
            // txtNgaySinh
            // 
            txtNgaySinh.BorderStyle = BorderStyle.FixedSingle;
            txtNgaySinh.Location = new Point(321, 72);
            txtNgaySinh.Name = "txtNgaySinh";
            txtNgaySinh.Size = new Size(151, 26);
            txtNgaySinh.TabIndex = 14;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(321, 36);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(151, 26);
            txtEmail.TabIndex = 13;
            // 
            // txtTen
            // 
            txtTen.BorderStyle = BorderStyle.FixedSingle;
            txtTen.Location = new Point(72, 72);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(125, 26);
            txtTen.TabIndex = 12;
            // 
            // txtSDT
            // 
            txtSDT.BorderStyle = BorderStyle.FixedSingle;
            txtSDT.Location = new Point(72, 107);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(125, 26);
            txtSDT.TabIndex = 11;
            // 
            // txtHo
            // 
            txtHo.BorderStyle = BorderStyle.FixedSingle;
            txtHo.Location = new Point(72, 33);
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(125, 26);
            txtHo.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(511, 110);
            label9.Name = "label9";
            label9.Size = new Size(91, 20);
            label9.TabIndex = 9;
            label9.Text = "Phân quyền";
            // 
            // cboPhanQuyen
            // 
            cboPhanQuyen.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPhanQuyen.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cboPhanQuyen.FormattingEnabled = true;
            cboPhanQuyen.Items.AddRange(new object[] { "CEO", "Leader", "Manager", "Staff" });
            cboPhanQuyen.Location = new Point(617, 103);
            cboPhanQuyen.Name = "cboPhanQuyen";
            cboPhanQuyen.Size = new Size(125, 26);
            cboPhanQuyen.TabIndex = 8;
            cboPhanQuyen.SelectedIndexChanged += cboPhanQuyen_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(511, 72);
            label8.Name = "label8";
            label8.Size = new Size(82, 20);
            label8.TabIndex = 7;
            label8.Text = "Tình trạng";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(511, 42);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 6;
            label7.Text = "Mật khẩu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(236, 110);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 5;
            label6.Text = "Giới tính";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(236, 72);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 4;
            label5.Text = "Ngày sinh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(236, 36);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(20, 110);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 2;
            label3.Text = "SĐT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(20, 75);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(19, 36);
            label1.Name = "label1";
            label1.Size = new Size(29, 20);
            label1.TabIndex = 0;
            label1.Text = "Họ";
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(193, 196);
            button1.Name = "button1";
            button1.Size = new Size(94, 39);
            button1.TabIndex = 1;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(342, 196);
            button3.Name = "button3";
            button3.Size = new Size(94, 39);
            button3.TabIndex = 3;
            button3.Text = "Sửa";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = SystemColors.Window;
            groupBox2.Location = new Point(153, 260);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1129, 342);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin user";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1123, 316);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // cboBoPhan
            // 
            cboBoPhan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBoPhan.FormattingEnabled = true;
            cboBoPhan.Items.AddRange(new object[] { "CEO", "Hành chính Nhân Sự & Dịch vụ Cư Dân", "Tài chính Kế toán", "Vệ Sinh", "An Ninh", "Kỹ Thuật Bảo Trì", "Xây Dựng" });
            cboBoPhan.Location = new Point(770, 226);
            cboBoPhan.Name = "cboBoPhan";
            cboBoPhan.Size = new Size(289, 26);
            cboBoPhan.TabIndex = 9;
            cboBoPhan.SelectedIndexChanged += cboBoPhan_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(32, 33, 36);
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.Window;
            label10.Location = new Point(664, 231);
            label10.Name = "label10";
            label10.Size = new Size(67, 20);
            label10.TabIndex = 18;
            label10.Text = "Bộ phận";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(32, 33, 36);
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.Window;
            label11.Location = new Point(664, 201);
            label11.Name = "label11";
            label11.Size = new Size(103, 20);
            label11.TabIndex = 18;
            label11.Text = "Mã nhân viên";
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.BackColor = SystemColors.ScrollBar;
            txtMaNhanVien.BorderStyle = BorderStyle.FixedSingle;
            txtMaNhanVien.Location = new Point(770, 196);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new Size(125, 26);
            txtMaNhanVien.TabIndex = 18;
            // 
            // button4
            // 
            button4.BackColor = Color.Black;
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(493, 196);
            button4.Name = "button4";
            button4.Size = new Size(94, 39);
            button4.TabIndex = 19;
            button4.Text = "Xóa";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Black;
            button5.ForeColor = SystemColors.Control;
            button5.Location = new Point(1129, 608);
            button5.Name = "button5";
            button5.Size = new Size(147, 39);
            button5.TabIndex = 20;
            button5.Text = "Tạo nhân viên";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(txtMaNhanVien);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(cboBoPhan);
            panel1.Controls.Add(label10);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(75, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1289, 659);
            panel1.TabIndex = 21;
            // 
            // ManagePerson
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 33, 36);
            ClientSize = new Size(1364, 659);
            Controls.Add(panel1);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "ManagePerson";
            Text = "ManagePerson";
            Load += ManagePerson_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtSDT;
        private TextBox txtHo;
        private Label label9;
        private ComboBox cboPhanQuyen;
        private TextBox txtMatKhau;
        private TextBox txtGioiTinh;
        private TextBox txtNgaySinh;
        private TextBox txtEmail;
        private TextBox txtTen;
        private Button button1;
        private Button button3;
        private GroupBox groupBox2;
        private ComboBox cboTinhTrang;
        private ComboBox cboBoPhan;
        private Label label10;
        private Label label11;
        private TextBox txtMaNhanVien;
        private Button button2;
        private Button button4;
        private ComboBox cboPhanLoai;
        private Label label12;
        private ComboBox cboNhom;
        private Label label13;
        private Button button5;
        private DataGridView dataGridView1;
        private Panel panel1;
    }
}