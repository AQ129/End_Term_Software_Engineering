namespace WinFormsApp1
{
    partial class WorkManagement
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button4 = new Button();
            groupBox1 = new GroupBox();
            dataGridView2 = new DataGridView();
            button3 = new Button();
            button1 = new Button();
            groupBox3 = new GroupBox();
            dtNgayHoanThanh = new DateTimePicker();
            cboGiaHan = new ComboBox();
            button2 = new Button();
            cboTieuDe = new ComboBox();
            cboMucDoUuTien = new ComboBox();
            dtNgayBatDau = new DateTimePicker();
            cboTinhTrang = new ComboBox();
            cboCongKhaiTCT = new ComboBox();
            cboCongKhaiBP = new ComboBox();
            txtNoiDung = new TextBox();
            txtMaCongViec = new TextBox();
            dtNgayHetHan = new DateTimePicker();
            label15 = new Label();
            label14 = new Label();
            label1 = new Label();
            label2 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label12 = new Label();
            label13 = new Label();
            tabPage2 = new TabPage();
            cboMaNhanVien = new ComboBox();
            cboMaCanHo = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox3.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Right;
            tabControl1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(236, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1128, 659);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(32, 33, 36);
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Location = new Point(4, 27);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1120, 628);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Quản lý công việc";
            // 
            // button4
            // 
            button4.BackColor = Color.Black;
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(336, 189);
            button4.Name = "button4";
            button4.Size = new Size(94, 39);
            button4.TabIndex = 28;
            button4.Text = "Xóa";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView2);
            groupBox1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(-4, 253);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1129, 345);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin công việc";
            // 
            // dataGridView2
            // 
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView2.BackgroundColor = SystemColors.Window;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.GridColor = SystemColors.WindowText;
            dataGridView2.Location = new Point(3, 22);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(1123, 320);
            dataGridView2.TabIndex = 1;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(185, 189);
            button3.Name = "button3";
            button3.Size = new Size(94, 39);
            button3.TabIndex = 22;
            button3.Text = "Sửa";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(36, 189);
            button1.Name = "button1";
            button1.Size = new Size(94, 39);
            button1.TabIndex = 21;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.Window;
            groupBox3.Controls.Add(dtNgayHoanThanh);
            groupBox3.Controls.Add(cboGiaHan);
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(cboTieuDe);
            groupBox3.Controls.Add(cboMucDoUuTien);
            groupBox3.Controls.Add(dtNgayBatDau);
            groupBox3.Controls.Add(cboTinhTrang);
            groupBox3.Controls.Add(cboCongKhaiTCT);
            groupBox3.Controls.Add(cboCongKhaiBP);
            groupBox3.Controls.Add(txtNoiDung);
            groupBox3.Controls.Add(txtMaCongViec);
            groupBox3.Controls.Add(dtNgayHetHan);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label13);
            groupBox3.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(-4, 6);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1128, 170);
            groupBox3.TabIndex = 20;
            groupBox3.TabStop = false;
            groupBox3.Text = "Nhập thông tin công việc";
            // 
            // dtNgayHoanThanh
            // 
            dtNgayHoanThanh.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtNgayHoanThanh.Format = DateTimePickerFormat.Custom;
            dtNgayHoanThanh.Location = new Point(967, 72);
            dtNgayHoanThanh.MinDate = new DateTime(2024, 4, 28, 0, 0, 0, 0);
            dtNgayHoanThanh.Name = "dtNgayHoanThanh";
            dtNgayHoanThanh.Size = new Size(129, 26);
            dtNgayHoanThanh.TabIndex = 30;
            // 
            // cboGiaHan
            // 
            cboGiaHan.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cboGiaHan.FormattingEnabled = true;
            cboGiaHan.Items.AddRange(new object[] { "Có", "Không" });
            cboGiaHan.Location = new Point(967, 34);
            cboGiaHan.Name = "cboGiaHan";
            cboGiaHan.Size = new Size(129, 26);
            cboGiaHan.TabIndex = 29;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(1002, 121);
            button2.Name = "button2";
            button2.Size = new Size(94, 39);
            button2.TabIndex = 19;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // cboTieuDe
            // 
            cboTieuDe.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cboTieuDe.FormattingEnabled = true;
            cboTieuDe.Items.AddRange(new object[] { "An Ninh", "Hành chính Nhân sự & Dịch vụ Cư Dân", "CEO", "Kỹ Thuật Bảo Trì", "Tài chính Kế toán", "Vệ Sinh", "Xây Dựng" });
            cboTieuDe.Location = new Point(653, 113);
            cboTieuDe.Name = "cboTieuDe";
            cboTieuDe.Size = new Size(129, 26);
            cboTieuDe.TabIndex = 28;
            // 
            // cboMucDoUuTien
            // 
            cboMucDoUuTien.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cboMucDoUuTien.FormattingEnabled = true;
            cboMucDoUuTien.Items.AddRange(new object[] { "1", "2", "3" });
            cboMucDoUuTien.Location = new Point(737, 75);
            cboMucDoUuTien.Name = "cboMucDoUuTien";
            cboMucDoUuTien.Size = new Size(45, 26);
            cboMucDoUuTien.TabIndex = 27;
            // 
            // dtNgayBatDau
            // 
            dtNgayBatDau.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtNgayBatDau.Format = DateTimePickerFormat.Custom;
            dtNgayBatDau.Location = new Point(653, 31);
            dtNgayBatDau.MinDate = new DateTime(2024, 4, 28, 0, 0, 0, 0);
            dtNgayBatDau.Name = "dtNgayBatDau";
            dtNgayBatDau.Size = new Size(129, 26);
            dtNgayBatDau.TabIndex = 26;
            // 
            // cboTinhTrang
            // 
            cboTinhTrang.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cboTinhTrang.FormattingEnabled = true;
            cboTinhTrang.Items.AddRange(new object[] { "Hoàn thành", "Chưa hoàn thành" });
            cboTinhTrang.Location = new Point(360, 121);
            cboTinhTrang.Name = "cboTinhTrang";
            cboTinhTrang.Size = new Size(132, 26);
            cboTinhTrang.TabIndex = 25;
            // 
            // cboCongKhaiTCT
            // 
            cboCongKhaiTCT.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cboCongKhaiTCT.FormattingEnabled = true;
            cboCongKhaiTCT.Items.AddRange(new object[] { "0", "1" });
            cboCongKhaiTCT.Location = new Point(447, 72);
            cboCongKhaiTCT.Name = "cboCongKhaiTCT";
            cboCongKhaiTCT.Size = new Size(45, 26);
            cboCongKhaiTCT.TabIndex = 24;
            // 
            // cboCongKhaiBP
            // 
            cboCongKhaiBP.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cboCongKhaiBP.FormattingEnabled = true;
            cboCongKhaiBP.Items.AddRange(new object[] { "0", "1" });
            cboCongKhaiBP.Location = new Point(447, 30);
            cboCongKhaiBP.Name = "cboCongKhaiBP";
            cboCongKhaiBP.Size = new Size(45, 26);
            cboCongKhaiBP.TabIndex = 23;
            // 
            // txtNoiDung
            // 
            txtNoiDung.BorderStyle = BorderStyle.FixedSingle;
            txtNoiDung.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNoiDung.Location = new Point(120, 121);
            txtNoiDung.Multiline = true;
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.Size = new Size(131, 26);
            txtNoiDung.TabIndex = 22;
            txtNoiDung.TextAlign = HorizontalAlignment.Center;
            // 
            // txtMaCongViec
            // 
            txtMaCongViec.BackColor = SystemColors.ScrollBar;
            txtMaCongViec.BorderStyle = BorderStyle.FixedSingle;
            txtMaCongViec.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaCongViec.Location = new Point(120, 31);
            txtMaCongViec.Name = "txtMaCongViec";
            txtMaCongViec.Size = new Size(131, 26);
            txtMaCongViec.TabIndex = 21;
            txtMaCongViec.TextAlign = HorizontalAlignment.Center;
            // 
            // dtNgayHetHan
            // 
            dtNgayHetHan.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtNgayHetHan.Format = DateTimePickerFormat.Custom;
            dtNgayHetHan.Location = new Point(122, 72);
            dtNgayHetHan.MinDate = new DateTime(2024, 4, 28, 0, 0, 0, 0);
            dtNgayHetHan.Name = "dtNgayHetHan";
            dtNgayHetHan.Size = new Size(129, 26);
            dtNgayHetHan.TabIndex = 20;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(820, 75);
            label15.Name = "label15";
            label15.Size = new Size(133, 18);
            label15.TabIndex = 19;
            label15.Text = "Ngày hoàn thành";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(820, 36);
            label14.Name = "label14";
            label14.Size = new Size(64, 18);
            label14.TabIndex = 18;
            label14.Text = "Gia hạn";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(526, 121);
            label1.Name = "label1";
            label1.Size = new Size(62, 18);
            label1.TabIndex = 9;
            label1.Text = "Tiêu đề";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(526, 75);
            label2.Name = "label2";
            label2.Size = new Size(117, 18);
            label2.TabIndex = 7;
            label2.Text = "Mức độ ưu tiên";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(526, 36);
            label7.Name = "label7";
            label7.Size = new Size(106, 18);
            label7.TabIndex = 6;
            label7.Text = "Ngày bắt đầu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(275, 121);
            label6.Name = "label6";
            label6.Size = new Size(84, 18);
            label6.TabIndex = 5;
            label6.Text = "Tình trạng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(275, 75);
            label5.Name = "label5";
            label5.Size = new Size(113, 18);
            label5.TabIndex = 4;
            label5.Text = "Công khai TCT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(275, 36);
            label4.Name = "label4";
            label4.Size = new Size(105, 18);
            label4.TabIndex = 3;
            label4.Text = "Công khai BP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(10, 121);
            label3.Name = "label3";
            label3.Size = new Size(74, 18);
            label3.TabIndex = 2;
            label3.Text = "Nội dung";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(10, 75);
            label12.Name = "label12";
            label12.Size = new Size(106, 18);
            label12.TabIndex = 1;
            label12.Text = "Ngày hết hạn";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(10, 36);
            label13.Name = "label13";
            label13.Size = new Size(104, 18);
            label13.TabIndex = 0;
            label13.Text = "Mã công việc";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(32, 33, 36);
            tabPage2.Controls.Add(cboMaNhanVien);
            tabPage2.Controls.Add(cboMaCanHo);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Location = new Point(4, 27);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1120, 628);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Quản lý yêu cầu dịch vụ";
            // 
            // cboMaNhanVien
            // 
            cboMaNhanVien.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMaNhanVien.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboMaNhanVien.FormattingEnabled = true;
            cboMaNhanVien.Items.AddRange(new object[] { "Admin", "Manager", "Employee" });
            cboMaNhanVien.Location = new Point(231, 113);
            cboMaNhanVien.Name = "cboMaNhanVien";
            cboMaNhanVien.Size = new Size(125, 32);
            cboMaNhanVien.TabIndex = 28;
            cboMaNhanVien.SelectedIndexChanged += cboMaNhanVien_SelectedIndexChanged;
            // 
            // cboMaCanHo
            // 
            cboMaCanHo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMaCanHo.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboMaCanHo.FormattingEnabled = true;
            cboMaCanHo.Items.AddRange(new object[] { "Active", "Negative" });
            cboMaCanHo.Location = new Point(231, 32);
            cboMaCanHo.Name = "cboMaCanHo";
            cboMaCanHo.Size = new Size(125, 32);
            cboMaCanHo.TabIndex = 27;
            cboMaCanHo.SelectedIndexChanged += cboMaCanHo_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.Window;
            label9.Location = new Point(56, 117);
            label9.Name = "label9";
            label9.Size = new Size(146, 24);
            label9.TabIndex = 26;
            label9.Text = "Mã nhân viên";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.Window;
            label8.Location = new Point(56, 36);
            label8.Name = "label8";
            label8.Size = new Size(113, 24);
            label8.TabIndex = 25;
            label8.Text = "Mã căn hộ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = SystemColors.Window;
            groupBox2.Location = new Point(6, 244);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1129, 354);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin yêu cầu dịch vụ";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.Window;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = SystemColors.WindowText;
            dataGridView1.Location = new Point(3, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1123, 329);
            dataGridView1.TabIndex = 0;
            // 
            // WorkManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 33, 36);
            ClientSize = new Size(1364, 659);
            Controls.Add(tabControl1);
            Name = "WorkManagement";
            Text = "Form2";
            Load += Form2_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox2;
        private Label label8;
        private Label label9;
        private ComboBox cboMaCanHo;
        private ComboBox cboMaNhanVien;
        private DataGridView dataGridView1;
        private Button button4;
        private GroupBox groupBox1;
        private Button button3;
        private Button button1;
        private GroupBox groupBox3;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label12;
        private Label label13;
        private DateTimePicker dtNgayHetHan;
        private Label label15;
        private Label label14;
        private TextBox txtMaCongViec;
        private ComboBox cboTinhTrang;
        private ComboBox cboCongKhaiTCT;
        private ComboBox cboCongKhaiBP;
        private TextBox txtNoiDung;
        private DateTimePicker dtNgayHoanThanh;
        private ComboBox cboGiaHan;
        private ComboBox cboTieuDe;
        private ComboBox cboMucDoUuTien;
        private DateTimePicker dtNgayBatDau;
        private DataGridView dataGridView2;
    }
}