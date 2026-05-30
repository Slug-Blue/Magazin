namespace Magazin
{
    partial class MainForm
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
            label2 = new Label();
            panel3 = new Panel();
            centralButton = new Button();
            panel2 = new Panel();
            registerButton = new Label();
            qustionButton = new Label();
            productButton = new Label();
            CloseButton = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(115, 201, 182);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(centralButton);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1279, 715);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.Desktop;
            label2.Location = new Point(527, 188);
            label2.Name = "label2";
            label2.Size = new Size(249, 59);
            label2.TabIndex = 3;
            label2.Text = "Покупайте";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(115, 177, 201);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 583);
            panel3.Name = "panel3";
            panel3.Size = new Size(1279, 132);
            panel3.TabIndex = 2;
            // 
            // centralButton
            // 
            centralButton.BackColor = Color.FromArgb(115, 177, 201);
            centralButton.Cursor = Cursors.Hand;
            centralButton.Font = new Font("Times New Roman", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            centralButton.Location = new Point(364, 375);
            centralButton.Name = "centralButton";
            centralButton.Size = new Size(578, 94);
            centralButton.TabIndex = 1;
            centralButton.Text = "Войти для покупки оборудования";
            centralButton.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(115, 177, 201);
            panel2.Controls.Add(registerButton);
            panel2.Controls.Add(qustionButton);
            panel2.Controls.Add(productButton);
            panel2.Controls.Add(CloseButton);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1279, 82);
            panel2.TabIndex = 0;
            // 
            // registerButton
            // 
            registerButton.AutoSize = true;
            registerButton.Cursor = Cursors.Hand;
            registerButton.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            registerButton.Location = new Point(1066, 19);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(151, 26);
            registerButton.TabIndex = 4;
            registerButton.Text = "Регистрация";
            registerButton.Click += registerButton_Click;
            // 
            // qustionButton
            // 
            qustionButton.AutoSize = true;
            qustionButton.Cursor = Cursors.Hand;
            qustionButton.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            qustionButton.Location = new Point(999, 19);
            qustionButton.Name = "qustionButton";
            qustionButton.Size = new Size(61, 26);
            qustionButton.TabIndex = 3;
            qustionButton.Text = "FAQ";
            // 
            // productButton
            // 
            productButton.AutoSize = true;
            productButton.Cursor = Cursors.Hand;
            productButton.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            productButton.Location = new Point(899, 19);
            productButton.Name = "productButton";
            productButton.Size = new Size(94, 26);
            productButton.TabIndex = 2;
            productButton.Text = "Товары";
            // 
            // CloseButton
            // 
            CloseButton.AutoSize = true;
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.Font = new Font("Segoe UI", 14F);
            CloseButton.Location = new Point(1223, 9);
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
            label1.Size = new Size(1279, 82);
            label1.TabIndex = 0;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.FromArgb(115, 134, 201);
            label3.Location = new Point(416, 237);
            label3.Name = "label3";
            label3.Size = new Size(477, 71);
            label3.TabIndex = 4;
            label3.Text = "Выгодно технику";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(573, 308);
            label4.Name = "label4";
            label4.Size = new Size(143, 32);
            label4.TabIndex = 5;
            label4.Text = "В два клика";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(509, 340);
            label5.Name = "label5";
            label5.Size = new Size(285, 32);
            label5.TabIndex = 6;
            label5.Text = "с гарантией и доставкой";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1279, 715);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label CloseButton;
        private Label label1;
        private Label productButton;
        private Label qustionButton;
        private Label registerButton;
        private Panel panel3;
        private Button centralButton;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label5;
    }
}