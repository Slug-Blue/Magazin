using Equipment_rental;
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

namespace Magazin
{
    public partial class Authorization : Form
    {
        // Настройки ограничений и капчи
        private const int MaxCaptchaAttempts = 2;
        private const int LockoutSeconds = 25;

        private string _captchaCode = "";
        private int _failedCaptchaAttempts;
        private DateTime _lockoutUntil = DateTime.MinValue;
        private readonly System.Windows.Forms.Timer _lockoutTimer;

        // Единый исправленный конструктор класса Authorization
        public Authorization()
        {
            InitializeComponent();

            // Настройка размеров поля пароля
            this.passField.AutoSize = false;
            this.passField.Size = new Size(this.passField.Size.Width, 74);

            // Настройка таймера блокировки
            _lockoutTimer = new System.Windows.Forms.Timer { Interval = 1000 };
            _lockoutTimer.Tick += LockoutTimer_Tick;

            // Начальное состояние поля капчи
            capcha.Text = "Введите капчу";
            capcha.ForeColor = Color.Gray;

            // Генерация первой капчи при запуске формы
            RefreshCaptcha();
        }

        // Метод генерации и обновления картинки капчи
        private void RefreshCaptcha()
        {
            _captchaCode = CaptchaGenerator.GenerateCode();

            var oldImage = pictureCapcha.Image;

            pictureCapcha.Image = CaptchaGenerator.CreateImage(
                _captchaCode,
                pictureCapcha.Width,
                pictureCapcha.Height);

            oldImage?.Dispose();

            capcha.Text = "";
            capcha.ForeColor = Color.Black;
        }

        // Кнопка закрытия приложения
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.BackColor = Color.FromArgb(42, 108, 125);
            CloseButton.ForeColor = Color.FromArgb(160, 232, 250);
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.BackColor = Color.FromArgb(115, 177, 201);
            CloseButton.ForeColor = Color.Black;
        }

        // Перетаскивание формы мышкой за панель
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

        // Логика авторизации пользователя
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // 1. Проверяем временную блокировку
            if (IsLockedOut())
            {
                MessageBox.Show($"Вход заблокирован. Повторите через {GetLockoutRemainingSeconds()} сек.");
                return;
            }

            // 2. Проверяем, заполнено ли поле капчи (ИСПРАВЛЕНО: IsNullOrEmpty)
            if (capcha.Text == "Введите капчу" || string.IsNullOrEmpty(capcha.Text))
            {
                MessageBox.Show("Введите текст с картинки");
                return;
            }

            // 3. Проверяем правильность ввода капчи (регистронезависимо)
            if (!string.Equals(capcha.Text.Trim(), _captchaCode, StringComparison.OrdinalIgnoreCase))
            {
                _failedCaptchaAttempts++;
                MessageBox.Show("Неверная капча, повторите попытку");
                RefreshCaptcha();

                if (_failedCaptchaAttempts >= MaxCaptchaAttempts)
                    StartLockout();
                return;
            }

            // Если капча пройдена, сбрасываем счетчик ошибок капчи
            _failedCaptchaAttempts = 0;

            // 4. Проверка логина и пароля в базе данных
            String loginUser = loginField.Text;
            String passUser = passField.Text;

            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `password` = @uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                MainForm mainform = new MainForm();
                mainform.Show();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
                RefreshCaptcha(); // Меняем капчу при неудачной попытке входа
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        // Переход на форму регистрации
        private void RegisterLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        // Эффект подсказки (Placeholder) для текстового поля капчи
        private void capcha_Enter(object sender, EventArgs e)
        {
            if (capcha.Text == "Введите капчу")
            {
                capcha.Text = "";
                capcha.ForeColor = Color.Black;
            }
        }

        private void capcha_Leave(object sender, EventArgs e)
        {
            if (capcha.Text == "")
            {
                capcha.Text = "Введите капчу";
                capcha.ForeColor = Color.Gray;
            }
        }

        // Обновление капчи вручную по клику на кнопку/картинку обновления
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (IsLockedOut())
            {
                MessageBox.Show($"Вход заблокирован. Повторите через {GetLockoutRemainingSeconds()} сек.");
                return;
            }
            RefreshCaptcha();
        }

        // --- ДОБАВЛЕННЫЕ МЕТОДЫ ДЛЯ СИСТЕМЫ БЛОКИРОВКИ ВХОДА ---

        private void StartLockout()
        {
            _lockoutUntil = DateTime.Now.AddSeconds(LockoutSeconds);
            _failedCaptchaAttempts = 0;
            SetLoginControlsEnabled(false);
            buttonLogin.Text = $"Заблокировано ({LockoutSeconds} с)";
            _lockoutTimer.Start();
            MessageBox.Show($"Слишком много неверных попыток. Вход заблокирован на {LockoutSeconds} секунд.");
        }

        private void LockoutTimer_Tick(object sender, EventArgs e)
        {
            int remaining = GetLockoutRemainingSeconds();
            if (remaining <= 0)
            {
                EndLockout();
                return;
            }
            buttonLogin.Text = $"Заблокировано ({remaining} с)";
        }

        private void EndLockout()
        {
            _lockoutTimer.Stop();
            _lockoutUntil = DateTime.MinValue;
            SetLoginControlsEnabled(true);
            buttonLogin.Text = "Войти";
            RefreshCaptcha();
        }

        private bool IsLockedOut() => DateTime.Now < _lockoutUntil;

        private int GetLockoutRemainingSeconds() =>
            Math.Max(0, (int)Math.Ceiling((_lockoutUntil - DateTime.Now).TotalSeconds));

        private void SetLoginControlsEnabled(bool enabled)
        {
            buttonLogin.Enabled = enabled;
            loginField.Enabled = enabled;
            passField.Enabled = enabled;
            capcha.Enabled = enabled;
            pictureBox5.Enabled = enabled;
        }

        // Освобождение системных ресурсов при уничтожении формы
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _lockoutTimer?.Stop();
            _lockoutTimer?.Dispose();
            pictureCapcha.Image?.Dispose();
            base.OnFormClosed(e);
        }
    }
}