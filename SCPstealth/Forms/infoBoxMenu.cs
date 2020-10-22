using Guna.UI2.WinForms;
using Memory;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace SCPstealth
{
    public partial class infoBoxMenu : Form
    {
        public infoBoxMenu()
        {
            InitializeComponent();
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space || e.KeyCode == Keys.Back)
            {
                this.Close();
            }
        }

        private void infoBoxMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
