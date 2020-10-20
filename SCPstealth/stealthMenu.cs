using Guna.UI2.WinForms;
using Memory;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace SCPstealth
{
    public partial class stealthMenu : Form
    {

        BackgroundWorker backgroundWorker;

        infoBoxMenu infoBox = new infoBoxMenu();

        public stealthMenu()
        {
            InitializeComponent();

            backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += new DoWorkEventHandler(backgroundWorker_DoWork);
            backgroundWorker.RunWorkerAsync();
        }

        public Mem MemLib = new Mem();
        public bool loaded = false;

        private string noProccessFound = "We haven't found the game process.";

        public void checkGameProccess()
        {
            int gameProcId = MemLib.GetProcIdFromName("SCPSL");

            if (gameProcId == 0)
            {
                loaded = false;
                this.ProcessFoundText.FillColor = Color.FromArgb(200, 20, 0);
                this.ProcessFoundText.FillColor2 = Color.FromArgb(255, 50, 0);
                this.ProcessFoundText.HoverState.FillColor = Color.FromArgb(200, 20, 0);
                this.ProcessFoundText.HoverState.FillColor2 = Color.FromArgb(255, 50, 0);

                this.ProcessFoundCheckbox.Checked = false;
                this.ProcessFoundCheckbox.UncheckedState.FillColor = Color.FromArgb(255, 60, 0);

                this.InjectESPCheck.Checked = false;
                this.noRecoilCheck.Checked = false;
            }
            else
            {
                loaded = true;
                this.ProcessFoundText.FillColor = Color.FromArgb(0, 200, 0);
                this.ProcessFoundText.FillColor2 = Color.FromArgb(0, 150, 0);
                this.ProcessFoundText.HoverState.FillColor = Color.FromArgb(0, 200, 0);
                this.ProcessFoundText.HoverState.FillColor2 = Color.FromArgb(0, 150, 0);

                this.ProcessFoundCheckbox.Checked = true;
                this.ProcessFoundCheckbox.CheckedState.FillColor = Color.FromArgb(0, 200, 0);

                MemLib.OpenProcess("SCPSL");
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (!loaded)
            {
                infoBox.ShowDialog();
                return;
            }
            if (noRecoilCheck.Checked)
            {
                noRecoilCheck.Checked = false;
            }
            else
            {
                noRecoilCheck.Checked = true;
            }
        }

        private void guna2GradientButton1_Click_1(object sender, EventArgs e)
        {
            if (noRecoilCheck.Checked)
            {
                noRecoilCheck.Checked = false;
            }
            else
            {
                noRecoilCheck.Checked = true;
            }
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ProcessFoundCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (ProcessFoundCheckbox.Checked)
            {
                ProcessFoundCheckbox.Checked = false;
            }
            else
            {
                ProcessFoundCheckbox.Checked = true;
            }
        }

        private void ProcessFoundText_Click(object sender, EventArgs e)
        {
            checkGameProccess();
        }

        private void noRecoilCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (noRecoilCheck.Checked)
            {
                MemLib.WriteMemory("SCPSL.exe+0x2944A0", "bytes", "???");
            }

        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true) //infinite loop
            {

                checkGameProccess();

                Thread.Sleep(1000);

            }


        }

        private void ESPInject_Click(object sender, EventArgs e)
        {
            if (!loaded) {
                MessageBox.Show(noProccessFound);
                return;
            }
            if (InjectESPCheck.Checked)
            {
                InjectESPCheck.Checked = false;
            }
            else
            {
                InjectESPCheck.Checked = true;
            }
        }

        private void InjectESPCheck_CheckedChanged(object sender, EventArgs e)
        {
            string GetDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            if (!loaded)
            {
                return;
            }
            MessageBox.Show(GetDirectory + "/SCP-Internal-il2cpp.dll");
            //MemLib.InjectDll(GetDirectory + "/SCP-Internal-il2cpp.dll");
        }
    }
}
