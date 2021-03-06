using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenshotSaver
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
            try
            {
                var applicationContext = new CustomApplicationContext();
                Application.Run(applicationContext);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Screenshoter Terminated Unexpectedly",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
