
namespace Magazin
{
    partial class Authorization
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
            RegisterLabel = new Label();
            buttonLogin = new Button();
            passField = new TextBox();
            pictureBox2 = new PictureBox();
            loginField = new TextBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            CloseButton = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(115, 201, 182);
            panel1.Controls.Add(RegisterLabel);
            panel1.Controls.Add(buttonLogin);
            panel1.Controls.Add(passField);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(loginField);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(679, 638);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // RegisterLabel
            // 
            RegisterLabel.AutoSize = true;
            RegisterLabel.Cursor = Cursors.Hand;
            RegisterLabel.Font = new Font("Times New Roman", 7.875F, FontStyle.Italic, GraphicsUnit.Point, 204);
            RegisterLabel.Location = new Point(264, 574);
            RegisterLabel.Name = "RegisterLabel";
            RegisterLabel.Size = new Size(170, 23);
            RegisterLabel.TabIndex = 6;
            RegisterLabel.Text = "Создать аккаунт";
            RegisterLabel.Click += RegisterLabel_Click;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.FromArgb(115, 134, 201);
            buttonLogin.Cursor = Cursors.Hand;
            buttonLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(70, 150, 176);
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonLogin.Location = new Point(274, 525);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(150, 46);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "Войти";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // passField
            // 
            passField.Font = new Font("Arial Narrow", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passField.Location = new Point(180, 293);
            passField.Name = "passField";
            passField.Size = new Size(418, 57);
            passField.TabIndex = 4;
            passField.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._lock;
            pictureBox2.Location = new Point(29, 293);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(79, 74);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // loginField
            // 
            loginField.Font = new Font("Arial Narrow", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginField.Location = new Point(180, 174);
            loginField.Multiline = true;
            loginField.Name = "loginField";
            loginField.Size = new Size(418, 74);
            loginField.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(29, 174);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(79, 74);
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
            panel2.Size = new Size(679, 153);
            panel2.TabIndex = 0;
            // 
            // CloseButton
            // 
            CloseButton.AutoSize = true;
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.Font = new Font("Segoe UI", 14F);
            CloseButton.Location = new Point(623, 9);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(44, 51);
            CloseButton.TabIndex = 1;
            CloseButton.Text = "X";
            CloseButton.Click += CloseButton_Click;
            CloseButton.MouseEnter += CloseButton_MouseEnter;
            CloseButton.MouseLeave += CloseButton_MouseLeave;
            // 
            // label1
            // 
            label1.Cursor = Cursors.Hand;
            label1.Dock = DockStyle.Fill;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Times New Roman", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(679, 153);
            label1.TabIndex = 0;
            label1.Text = "Авторизация";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // Authorization
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 638);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Authorization";
            Text = "Authorization";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label CloseButton;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox passField;
        private PictureBox pictureBox2;
        private TextBox loginField;
        private Button buttonLogin;
        private Label RegisterLabel;
    }
}