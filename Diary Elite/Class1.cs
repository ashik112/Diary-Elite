using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using diary.UI;

namespace diary.UI
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
            //Application.Run(new SignUp());
            Application.Run(new LoginFrame());
            //   Application.Run(new ForgetPassword());
            // Application.Run(new DiaryFrame());
            //Application.Exit();
        }
    }
}
