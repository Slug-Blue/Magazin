using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Magazin
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            this.passField.AutoSize = false;
            this.passField.Size = new Size(this.passField.Size.Width, 74);

            this.passField2.AutoSize = false;
            this.passField2.Size = new Size(this.passField2.Size.Width, 74);

            userNameField.Text = "Введите имя";
            userNameField.ForeColor = Color.Gray;

            userSurnameField.Text = "Введите фамилию";
            userSurnameField.ForeColor = Color.Gray;

            loginField.Text = "Введите логин";
            loginField.ForeColor = Color.Gray;

            passField.Text = "Введите пароль";
            passField.ForeColor = Color.Gray;

            passField2.Text = "Повторите пароль";
            passField2.ForeColor = Color.Gray;

            PhoneField.Text = "Номер '79119191111'";
            PhoneField.ForeColor = Color.Gray;

            if (passField.Text == "Введите пароль")
            {
                passField.UseSystemPasswordChar = false;
            }

            if (passField2.Text == "Повторите пароль")
            {
                passField2.UseSystemPasswordChar = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point LastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void userNameField_Enter(object sender, EventArgs e)
        {
            if (userNameField.Text == "Введите имя")
            {
                userNameField.Text = "";
                userNameField.ForeColor = Color.Black;
            }
        }

        private void userNameField_Leave(object sender, EventArgs e)
        {
            if (userNameField.Text == "")
            {
                userNameField.Text = "Введите имя";
                userNameField.ForeColor = Color.Gray;
            }
        }

        private void userSurnameField_Enter(object sender, EventArgs e)
        {
            if (userSurnameField.Text == "Введите фамилию")
            {
                userSurnameField.Text = "";
                userSurnameField.ForeColor = Color.Black;
            }
        }

        private void userSurnameField_Leave(object sender, EventArgs e)
        {
            if (userSurnameField.Text == "")
            {
                userSurnameField.Text = "Введите фамилию";
                userSurnameField.ForeColor = Color.Gray;
            }
        }

        private void loginField_Enter(object sender, EventArgs e)
        {
            if (loginField.Text == "Введите логин")
            {
                loginField.Text = "";
                loginField.ForeColor = Color.Black;
            }
        }

        private void loginField_Leave(object sender, EventArgs e)
        {
            if (loginField.Text == "")
            {
                loginField.Text = "Введите логин";
                loginField.ForeColor = Color.Gray;
            }
        }

        private void passField_Enter(object sender, EventArgs e)
        {
            if (passField.Text == "Введите пароль")
            {
                passField.UseSystemPasswordChar = true;
                passField.Text = "";
                passField.ForeColor = Color.Black;
                //fffffffff
            }
        }

        private void passField_Leave(object sender, EventArgs e)
        {
            if (passField.Text == "")
            {
                passField.UseSystemPasswordChar = false;
                passField.Text = "Введите пароль";
                passField.ForeColor = Color.Gray;
            }
        }

        private void CloseButton_MouseMove(object sender, MouseEventArgs e)
        {
            CloseButton.BackColor = Color.FromArgb(42, 108, 125);
            CloseButton.ForeColor = Color.FromArgb(160, 232, 250);
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.BackColor = Color.FromArgb(115, 177, 201);
            CloseButton.ForeColor = Color.Black;

        }

        private void eyeBox_MouseMove(object sender, MouseEventArgs e)
        {
            eyeBox.BackColor = Color.FromArgb(95, 156, 142);
            passField.UseSystemPasswordChar = false;
            passField2.UseSystemPasswordChar = false;
        }

        private void eyeBox_MouseLeave(object sender, EventArgs e)
        {
            eyeBox.BackColor = Color.FromArgb(115, 201, 139);
            if (passField.Text != "Введите пароль")
                passField.UseSystemPasswordChar = true;
            if (passField2.Text != "Повторите пароль")
                passField2.UseSystemPasswordChar = true;
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (CheckRobot.Text == "Вы не робот")
            {
                string phoneNumber = PhoneField.Text.Trim();
                string pattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[!@#$%^&*()\-_+=]).+$";
                string PhoneNumberRegexPattern = @"^79\d{9}$";

                if (userNameField.Text == "Введите имя")
                {
                    MessageBox.Show("Введите имя");
                    return;
                }
                if (loginField.Text == "Введите логин")
                {
                    MessageBox.Show("Введите логин");
                    return;
                }
                if (loginField.TextLength <= 5)
                {
                    MessageBox.Show("Слишком короткий логин");
                    return;
                }
                if (userSurnameField.Text == "Введите фамилию")
                {
                    MessageBox.Show("Введите фамилию");
                    return;
                }
                if (passField.Text == "Введите пароль")
                {
                    MessageBox.Show("Введите пароль");
                    return;
                }
                if (passField.TextLength <= 5)
                {
                    MessageBox.Show("Слишком короткий пароль");
                    return;
                }
                if (!Regex.IsMatch(passField.Text, pattern))
                {
                    MessageBox.Show("Пароль должен содержать заглавные буквы, строчные буквы, цифры и спецсимволы.");
                    return;
                }
                if (passField.Text != passField2.Text)
                {
                    MessageBox.Show("Неверное повторен пароль");
                    return;
                }
                                if (PhoneField.Text == "Номер '79119191111'")
                {
                    MessageBox.Show("Номер '79119191111'");
                    return;
                }
                if (!Regex.IsMatch(phoneNumber, PhoneNumberRegexPattern))
                {
                    MessageBox.Show("Неправильный номер телефона");
                    return;
                }


                if (UserExists())
                    return;

                DB db = new DB();
                MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`, `address`, `PhoneNumber`, `name`, `surname`) VALUES (@login, @password, 'NULL', @phonenumber, @name, @surname);", db.getConnection());

                command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginField.Text;
                command.Parameters.Add("@password", MySqlDbType.VarChar).Value = passField.Text;
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = userNameField.Text;
                command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = userSurnameField.Text;
                command.Parameters.Add("@phonenumber", MySqlDbType.VarChar).Value = PhoneField.Text;

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    this.Hide();
                    MainForm mainform = new MainForm();
                    mainform.Show();
                    MessageBox.Show("Аккайнт был создан");
                }
                else
                    MessageBox.Show("Аккайнт не был создан");

                db.closeConnection();
            }
            else
                MessageBox.Show("Нажмите на кнопку для потверждение того, что вы не робот");

        }

        public Boolean UserExists()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `PhoneNumber` = @phonenumber", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginField.Text;
            command.Parameters.Add("@phonenumber", MySqlDbType.VarChar).Value = PhoneField.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Данный логин занят");
                return true;
            }
            else
                return false;
        }

        private void AuthorizationLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Authorization authorizationForm = new Authorization();
            authorizationForm.Show();
        }

        private void CheckRobot_MouseMove(object sender, MouseEventArgs e)
        {
            if (CheckRobot.Text != "Вы не робот")
                expectationsField.BackColor = Color.White;
        }

        private void CheckRobot_MouseLeave(object sender, EventArgs e)
        {
            expectationsField.BackColor = Color.FromArgb(115, 201, 182);
        }

        private void expectationsField_Click(object sender, EventArgs e)
        {
            expectationsField.Image = Properties.Resources.Okay;
            CheckRobot.Text = "Вы не робот";
        }

        private void PhoneField_TextChanged(object sender, EventArgs e)
        {
            if (PhoneField.Text != "Номер '79119191111'")
                ExphoneField.Image = Properties.Resources.yesphone;
        }

        private void PhoneField_Enter(object sender, EventArgs e)
        {
            if (PhoneField.Text == "Номер '79119191111'")
            {
                PhoneField.UseSystemPasswordChar = true;
                PhoneField.Text = "";
                PhoneField.ForeColor = Color.Black;
            }
        }

        private void PhoneField_Leave(object sender, EventArgs e)
        {
            if (PhoneField.Text == "")
            {
                PhoneField.UseSystemPasswordChar = false;
                PhoneField.Text = "Номер '79119191111'";
                PhoneField.ForeColor = Color.Gray;
            }
        }

        private void passField_TextChanged(object sender, EventArgs e)
        {

        }

        private void passField2_MouseEnter(object sender, EventArgs e)
        {
            if (passField2.Text == "Повторите пароль")
            {
                passField2.UseSystemPasswordChar = true;
                passField2.Text = "";
                passField2.ForeColor = Color.Black;

            }
        }

        private void passField2_MouseLeave(object sender, EventArgs e)
        {
            if (passField2.Text == "")
            {
                passField2.UseSystemPasswordChar = false;
                passField2.Text = "Повторите пароль";
                passField2.ForeColor = Color.Gray;
            }
        }
    }
}
