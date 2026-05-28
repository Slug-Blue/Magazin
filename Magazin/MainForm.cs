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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
    }
}
