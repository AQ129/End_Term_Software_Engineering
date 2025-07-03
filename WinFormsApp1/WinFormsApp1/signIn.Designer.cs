namespace WinFormsApp1
{
    partial class signIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signIn));
            passwordTB = new TextBox();
            mkPTB = new PictureBox();
            tkPTB = new PictureBox();
            button1 = new Button();
            pictureBox6 = new PictureBox();
            pictureBox4 = new PictureBox();
            userNameTB = new TextBox();
            panel2 = new Panel();
            sMkPTB = new PictureBox();
            sTkPTB = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button2 = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            Close = new Button();
            button5 = new Button();
            pictureBox5 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)mkPTB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tkPTB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sMkPTB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sTkPTB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // passwordTB
            // 
            passwordTB.Cursor = Cursors.Hand;
            passwordTB.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTB.Location = new Point(71, 148);
            passwordTB.Multiline = true;
            passwordTB.Name = "passwordTB";
            passwordTB.PasswordChar = '*';
            passwordTB.PlaceholderText = "Mật khẩu";
            passwordTB.Size = new Size(320, 50);
            passwordTB.TabIndex = 24;
            passwordTB.TextChanged += textBox2_TextChanged;
            passwordTB.Enter += passwordTB_Enter;
            passwordTB.Leave += passwordTB_Leave;
            // 
            // mkPTB
            // 
            mkPTB.BackColor = Color.FromArgb(205, 206, 210);
            mkPTB.BackgroundImageLayout = ImageLayout.Stretch;
            mkPTB.Image = (Image)resources.GetObject("mkPTB.Image");
            mkPTB.Location = new Point(15, 148);
            mkPTB.Name = "mkPTB";
            mkPTB.Size = new Size(50, 50);
            mkPTB.SizeMode = PictureBoxSizeMode.Zoom;
            mkPTB.TabIndex = 23;
            mkPTB.TabStop = false;
            mkPTB.Click += mkPTB_Click;
            // 
            // tkPTB
            // 
            tkPTB.BackColor = Color.FromArgb(205, 206, 210);
            tkPTB.BackgroundImageLayout = ImageLayout.Stretch;
            tkPTB.Image = (Image)resources.GetObject("tkPTB.Image");
            tkPTB.Location = new Point(15, 82);
            tkPTB.Name = "tkPTB";
            tkPTB.Size = new Size(50, 50);
            tkPTB.SizeMode = PictureBoxSizeMode.Zoom;
            tkPTB.TabIndex = 21;
            tkPTB.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(251, 244);
            button1.Name = "button1";
            button1.Size = new Size(140, 45);
            button1.TabIndex = 19;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.FromArgb(205, 206, 210);
            pictureBox6.BackgroundImage = (Image)resources.GetObject("pictureBox6.BackgroundImage");
            pictureBox6.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox6.Cursor = Cursors.Hand;
            pictureBox6.Location = new Point(356, 204);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(35, 35);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 27;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(205, 206, 210);
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Location = new Point(356, 204);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(35, 35);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 28;
            pictureBox4.TabStop = false;
            pictureBox4.Visible = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // userNameTB
            // 
            userNameTB.Cursor = Cursors.Hand;
            userNameTB.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            userNameTB.Location = new Point(71, 82);
            userNameTB.Multiline = true;
            userNameTB.Name = "userNameTB";
            userNameTB.PlaceholderText = "Tài khoản";
            userNameTB.Size = new Size(320, 50);
            userNameTB.TabIndex = 22;
            userNameTB.TextChanged += textBox2_TextChanged;
            userNameTB.Enter += userNameTB_MouseHover;
            userNameTB.Leave += userNameTB_Leave;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(205, 206, 210);
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.Controls.Add(sMkPTB);
            panel2.Controls.Add(sTkPTB);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(tkPTB);
            panel2.Controls.Add(userNameTB);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(pictureBox6);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(passwordTB);
            panel2.Controls.Add(mkPTB);
            panel2.Location = new Point(145, 85);
            panel2.Name = "panel2";
            panel2.Size = new Size(410, 300);
            panel2.TabIndex = 30;
            panel2.Paint += panel2_Paint_1;
            // 
            // sMkPTB
            // 
            sMkPTB.BackColor = Color.FromArgb(205, 206, 210);
            sMkPTB.BackgroundImage = (Image)resources.GetObject("sMkPTB.BackgroundImage");
            sMkPTB.BackgroundImageLayout = ImageLayout.Zoom;
            sMkPTB.Location = new Point(15, 148);
            sMkPTB.Name = "sMkPTB";
            sMkPTB.Size = new Size(50, 50);
            sMkPTB.SizeMode = PictureBoxSizeMode.Zoom;
            sMkPTB.TabIndex = 32;
            sMkPTB.TabStop = false;
            // 
            // sTkPTB
            // 
            sTkPTB.BackColor = Color.FromArgb(205, 206, 210);
            sTkPTB.BackgroundImage = (Image)resources.GetObject("sTkPTB.BackgroundImage");
            sTkPTB.BackgroundImageLayout = ImageLayout.Zoom;
            sTkPTB.Location = new Point(15, 82);
            sTkPTB.Name = "sTkPTB";
            sTkPTB.Size = new Size(50, 50);
            sTkPTB.SizeMode = PictureBoxSizeMode.Zoom;
            sTkPTB.TabIndex = 31;
            sTkPTB.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 25.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LimeGreen;
            label1.Location = new Point(88, 22);
            label1.Name = "label1";
            label1.Size = new Size(280, 51);
            label1.TabIndex = 29;
            label1.Text = "ĐĂNG NHẬP";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Brown;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(15, 245);
            button2.MaximumSize = new Size(150, 50);
            button2.MinimumSize = new Size(135, 40);
            button2.Name = "button2";
            button2.Size = new Size(140, 45);
            button2.TabIndex = 19;
            button2.Text = "Quên mật khẩu";
            button2.UseVisualStyleBackColor = false;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Close
            // 
            Close.AccessibleRole = AccessibleRole.TitleBar;
            Close.BackColor = Color.FromArgb(23, 24, 29);
            Close.BackgroundImage = (Image)resources.GetObject("Close.BackgroundImage");
            Close.BackgroundImageLayout = ImageLayout.Stretch;
            Close.Cursor = Cursors.Hand;
            Close.Dock = DockStyle.Right;
            Close.FlatStyle = FlatStyle.Popup;
            Close.ForeColor = Color.Cornsilk;
            Close.Location = new Point(642, 0);
            Close.Name = "Close";
            Close.Size = new Size(40, 40);
            Close.TabIndex = 20;
            Close.UseVisualStyleBackColor = false;
            Close.Click += Close_Click;
            Close.MouseLeave += mouseLeave;
            Close.MouseHover += mouseOver;
            // 
            // button5
            // 
            button5.AccessibleRole = AccessibleRole.TitleBar;
            button5.BackColor = Color.FromArgb(23, 24, 29);
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.Cursor = Cursors.Hand;
            button5.Dock = DockStyle.Right;
            button5.FlatStyle = FlatStyle.Popup;
            button5.ForeColor = Color.Cornsilk;
            button5.Location = new Point(602, 0);
            button5.Name = "button5";
            button5.Size = new Size(40, 40);
            button5.TabIndex = 23;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            button5.MouseLeave += mouseLeave;
            button5.MouseHover += mouseOver;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox5.Dock = DockStyle.Left;
            pictureBox5.Location = new Point(0, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(50, 40);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 24;
            pictureBox5.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(23, 24, 29);
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(Close);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(682, 40);
            panel1.TabIndex = 31;
            panel1.Paint += panel1_Paint;
            panel1.MouseMove += panelMouseDown;
            // 
            // signIn
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 33, 36);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(682, 453);
            Controls.Add(panel1);
            Controls.Add(panel2);
            DoubleBuffered = true;
            MaximumSize = new Size(700, 500);
            MinimumSize = new Size(700, 500);
            Name = "signIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "signIn";
            Load += signIn_Load;
            ((System.ComponentModel.ISupportInitialize)mkPTB).EndInit();
            ((System.ComponentModel.ISupportInitialize)tkPTB).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sMkPTB).EndInit();
            ((System.ComponentModel.ISupportInitialize)sTkPTB).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TextBox passwordTB;
        private PictureBox mkPTB;
        private PictureBox tkPTB;
        private Button button1;
        private PictureBox pictureBox6;
        private PictureBox pictureBox4;
        private TextBox userNameTB;
        private Panel panel2;
        private Button button2;
        private ContextMenuStrip contextMenuStrip1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button Close;
        private Button button5;
        private PictureBox pictureBox5;
        private Panel panel1;
        private PictureBox sTkPTB;
        private PictureBox sMkPTB;
    }
}