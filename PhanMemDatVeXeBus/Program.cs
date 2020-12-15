using System;
using System.Windows.Forms;

namespace PhanMemDatVeXeBus
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            GlobalConfig.Init();
            Application.Run(new DashboardForm());
            //Application.Run(new GuestRegisterForm());
            //GlobalConfig.Destroy();
        }
    }
}
