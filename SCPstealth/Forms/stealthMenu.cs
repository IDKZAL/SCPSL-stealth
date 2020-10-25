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
        Cheat cheat = new Cheat();

        public stealthMenu()
        {
            InitializeComponent();

            backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += new DoWorkEventHandler(backgroundWorker_DoWork);
            backgroundWorker.RunWorkerAsync();
            cheat.Injected += () => {/* backgroundWorker.CancelAsync()*/};
            
        }

        public Mem mem = new Mem();
        public bool openedProcess = false;

        private const string noProccessFound = "We haven't found the game process.";

        public void checkGameProccess()
        {
            int gameProcId = mem.GetProcIdFromName("SCPSL");

            if (gameProcId == 0)
            {
                openedProcess = false;
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
                openedProcess = mem.OpenProcess("SCPSL");
                this.ProcessFoundText.FillColor = Color.FromArgb(0, 200, 0);
                this.ProcessFoundText.FillColor2 = Color.FromArgb(0, 150, 0);
                this.ProcessFoundText.HoverState.FillColor = Color.FromArgb(0, 200, 0);
                this.ProcessFoundText.HoverState.FillColor2 = Color.FromArgb(0, 150, 0);

                this.ProcessFoundCheckbox.Checked = openedProcess;
                this.ProcessFoundCheckbox.CheckedState.FillColor = Color.FromArgb(0, 200, 0);

                
                if (openedProcess && !cheat.IsInjected)
                    cheat.Inject(gameProcId);
                    
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            cheat.UnhookEverything();
            this.Close();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (!openedProcess)
            {
                infoBox.ShowDialog();
                return;
            }
            noRecoilCheck.Checked = !noRecoilCheck.Checked;
        }

        private void guna2GradientButton1_Click_1(object sender, EventArgs e)
        {
            noRecoilCheck.Checked = !noRecoilCheck.Checked;
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ProcessFoundCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            ProcessFoundCheckbox.Checked = !ProcessFoundCheckbox.Checked;
        }

        private void ProcessFoundText_Click(object sender, EventArgs e)
        {
            checkGameProccess();
        }

        private void noRecoilCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (noRecoilCheck.Checked)
                cheat.HookRecoil(0);
            else
                cheat.UnhookRecoil();
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
            if (!openedProcess) {
                MessageBox.Show(noProccessFound);
                return;
            }
            InjectESPCheck.Checked = !InjectESPCheck.Checked;
        }

        private void InjectESPCheck_CheckedChanged(object sender, EventArgs e)
        {
            string GetDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            if (!openedProcess)
            {
                return;
            }
            MessageBox.Show(GetDirectory + "/SCP-Internal-il2cpp.dll");
            //MemLib.InjectDll(GetDirectory + "/SCP-Internal-il2cpp.dll");
        }
    }
}
