using System;
using System.Windows.Forms;

namespace SCPstealth
{
    static class MainModule
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new stealthMenu());

        }
    }
}
