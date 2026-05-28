namespace Magazin
{
    partial class RegisterForm
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
            panel1 = new Panel();
            ExphoneField = new PictureBox();
            PhoneField = new TextBox();
            CheckRobot = new Label();
            expectationsField = new PictureBox();
            AuthorizationLabel = new Label();
            eyeBox = new PictureBox();
            userSurnameField = new TextBox();
            userNameField = new TextBox();
            buttonRegister = new Button();
            passField = new TextBox();
            pictureBox2 = new PictureBox();
            loginField = new TextBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            CloseButton = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ExphoneField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)expectationsField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eyeBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(115, 201, 182);
            panel1.Controls.Add(ExphoneField);
            panel1.Controls.Add(PhoneField);
            panel1.Controls.Add(CheckRobot);
            panel1.Controls.Add(expectationsField);
            panel1.Controls.Add(AuthorizationLabel);
            panel1.Controls.Add(eyeBox);
            panel1.Controls.Add(userSurnameField);
            panel1.Controls.Add(userNameField);
            panel1.Controls.Add(buttonRegister);
            panel1.Controls.Add(passField);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(loginField);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 849);
            panel1.TabIndex = 1;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // ExphoneField
            // 
            ExphoneField.Image = Properties.Resources.notphone;
            ExphoneField.Location = new Point(24, 545);
            ExphoneField.Name = "ExphoneField";
            ExphoneField.Size = new Size(79, 79);
            ExphoneField.SizeMode = PictureBoxSizeMode.StretchImage;
            ExphoneField.TabIndex = 13;
            ExphoneField.TabStop = false;
            // 
            // PhoneField
            // 
            PhoneField.Font = new Font("Arial Narrow", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PhoneField.Location = new Point(172, 545);
            PhoneField.Multiline = true;
            PhoneField.Name = "PhoneField";
            PhoneField.Size = new Size(418, 74);
            PhoneField.TabIndex = 12;
            PhoneField.TextChanged += PhoneField_TextChanged;
            PhoneField.Enter += PhoneField_Enter;
            PhoneField.Leave += PhoneField_Leave;
            // 
            // CheckRobot
            // 
            CheckRobot.AutoSize = true;
            CheckRobot.Cursor = Cursors.Help;
            CheckRobot.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CheckRobot.Location = new Point(152, 665);
            CheckRobot.Name = "CheckRobot";
            CheckRobot.Size = new Size(197, 36);
            CheckRobot.TabIndex = 11;
            CheckRobot.Text = "Вы не робот?";
            CheckRobot.MouseLeave += CheckRobot_MouseLeave;
            CheckRobot.MouseMove += CheckRobot_MouseMove;
            // 
            // expectationsField
            // 
            expectationsField.Cursor = Cursors.Hand;
            expectationsField.Image = Properties.Resources.expectations;
            expectationsField.Location = new Point(24, 640);
            expectationsField.Name = "expectationsField";
            expectationsField.Size = new Size(78, 78);
            expectationsField.SizeMode = PictureBoxSizeMode.StretchImage;
            expectationsField.TabIndex = 10;
            expectationsField.TabStop = false;
            expectationsField.Click += expectationsField_Click;
            // 
            // AuthorizationLabel
            // 
            AuthorizationLabel.AutoSize = true;
            AuthorizationLabel.Cursor = Cursors.Hand;
            AuthorizationLabel.Location = new Point(311, 795);
            AuthorizationLabel.Name = "AuthorizationLabel";
            AuthorizationLabel.Size = new Size(177, 32);
            AuthorizationLabel.TabIndex = 9;
            AuthorizationLabel.Text = "Войти в аккаут";
            AuthorizationLabel.Click += AuthorizationLabel_Click;
            // 
            // eyeBox
            // 
            eyeBox.BackColor = Color.FromArgb(115, 201, 139);
            eyeBox.Image = Properties.Resources.eye;
            eyeBox.Location = new Point(632, 459);
            eyeBox.Name = "eyeBox";
            eyeBox.Size = new Size(40, 40);
            eyeBox.SizeMode = PictureBoxSizeMode.StretchImage;
            eyeBox.TabIndex = 8;
            eyeBox.TabStop = false;
            eyeBox.MouseLeave += eyeBox_MouseLeave;
            eyeBox.MouseMove += eyeBox_MouseMove;
            // 
            // userSurnameField
            // 
            userSurnameField.Font = new Font("Arial Narrow", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            userSurnameField.Location = new Point(172, 222);
            userSurnameField.Multiline = true;
            userSurnameField.Name = "userSurnameField";
            userSurnameField.Size = new Size(418, 74);
            userSurnameField.TabIndex = 7;
            userSurnameField.Enter += userSurnameField_Enter;
            userSurnameField.Leave += userSurnameField_Leave;
            // 
            // userNameField
            // 
            userNameField.Font = new Font("Arial Narrow", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            userNameField.Location = new Point(172, 127);
            userNameField.Multiline = true;
            userNameField.Name = "userNameField";
            userNameField.Size = new Size(418, 74);
            userNameField.TabIndex = 6;
            userNameField.Enter += userNameField_Enter;
            userNameField.Leave += userNameField_Leave;
            // 
            // buttonRegister
            // 
            buttonRegister.BackColor = Color.FromArgb(115, 134, 201);
            buttonRegister.Cursor = Cursors.Hand;
            buttonRegister.FlatAppearance.MouseDownBackColor = Color.FromArgb(70, 150, 176);
            buttonRegister.FlatStyle = FlatStyle.Flat;
            buttonRegister.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonRegister.Location = new Point(260, 734);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(264, 58);
            buttonRegister.TabIndex = 5;
            buttonRegister.Text = "Зарегистрироваться";
            buttonRegister.UseVisualStyleBackColor = false;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // passField
            // 
            passField.Font = new Font("Arial Narrow", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passField.Location = new Point(172, 442);
            passField.Name = "passField";
            passField.Size = new Size(418, 57);
            passField.TabIndex = 4;
            passField.UseSystemPasswordChar = true;
            passField.Enter += passField_Enter;
            passField.Leave += passField_Leave;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._lock;
            pictureBox2.Location = new Point(21, 442);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(79, 79);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // loginField
            // 
            loginField.Font = new Font("Arial Narrow", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginField.Location = new Point(172, 327);
            loginField.Multiline = true;
            loginField.Name = "loginField";
            loginField.Size = new Size(418, 74);
            loginField.TabIndex = 2;
            loginField.Enter += loginField_Enter;
            loginField.Leave += loginField_Leave;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(21, 327);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(79, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(115, 177, 201);
            panel2.Controls.Add(CloseButton);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 104);
            panel2.TabIndex = 0;
            // 
            // CloseButton
            // 
            CloseButton.AutoSize = true;
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.Font = new Font("Segoe UI", 14F);
            CloseButton.Location = new Point(744, 9);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(44, 51);
            CloseButton.TabIndex = 1;
            CloseButton.Text = "X";
            CloseButton.Click += CloseButton_Click;
            CloseButton.MouseLeave += CloseButton_MouseLeave;
            CloseButton.MouseMove += CloseButton_MouseMove;
            // 
            // label1
            // 
            label1.Cursor = Cursors.Hand;
            label1.Dock = DockStyle.Fill;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Times New Roman", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(800, 104);
            label1.TabIndex = 0;
            label1.Text = "Регистрация";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 849);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            Text = "RegisterForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ExphoneField).EndInit();
            ((System.ComponentModel.ISupportInitialize)expectationsField).EndInit();
            ((System.ComponentModel.ISupportInitialize)eyeBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonRegister;
        private TextBox passField;
        private PictureBox pictureBox2;
        private TextBox loginField;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label CloseButton;
        private Label label1;
        private TextBox userSurnameField;
        private TextBox userNameField;
        private PictureBox eyeBox;
        private Label AuthorizationLabel;
        private Label CheckRobot;
        private PictureBox expectationsField;
        private PictureBox ExphoneField;
        private TextBox PhoneField;
    }
}