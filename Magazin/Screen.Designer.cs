namespace Magazin
{
    partial class Screen
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
            panel2 = new Panel();
            qustionButton = new Label();
            productButton = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            label2 = new Label();
            userNameField = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(115, 201, 182);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1314, 730);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(115, 177, 201);
            panel2.Controls.Add(userNameField);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(qustionButton);
            panel2.Controls.Add(productButton);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1314, 148);
            panel2.TabIndex = 0;
            // 
            // qustionButton
            // 
            qustionButton.AutoSize = true;
            qustionButton.Cursor = Cursors.Hand;
            qustionButton.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            qustionButton.Location = new Point(96, 9);
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
            productButton.Location = new Point(177, 9);
            productButton.Name = "productButton";
            productButton.Size = new Size(201, 26);
            productButton.TabIndex = 2;
            productButton.Text = "Категори товаров";
            // 
            // label1
            // 
            label1.Cursor = Cursors.Hand;
            label1.Dock = DockStyle.Fill;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Times New Roman", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1314, 148);
            label1.TabIndex = 0;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(1185, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(129, 123);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(115, 177, 201);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 598);
            panel3.Name = "panel3";
            panel3.Size = new Size(1314, 132);
            panel3.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(177, 94);
            label2.Name = "label2";
            label2.Size = new Size(82, 32);
            label2.TabIndex = 5;
            label2.Text = "Поиск";
            // 
            // userNameField
            // 
            userNameField.Font = new Font("Arial Narrow", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            userNameField.Location = new Point(315, 94);
            userNameField.Multiline = true;
            userNameField.Name = "userNameField";
            userNameField.Size = new Size(663, 41);
            userNameField.TabIndex = 7;
            // 
            // Screen
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1314, 730);
            Controls.Add(panel1);
            Name = "Screen";
            Text = "Screen";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label qustionButton;
        private Label productButton;
        private Label label1;
        private Panel panel3;
        private Label label2;
        private PictureBox pictureBox1;
        private TextBox userNameField;
    }
}