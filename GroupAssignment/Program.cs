using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformPetStore;

namespace GroupAssignment
{
    static class Program
    {
        public static IConfiguration Configuration;
        public static bool isLogin = false;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json",
            optional: true, reloadOnChange: true);
            Configuration = builder.Build();


            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frmLogin frm = new frmLogin();
            Application.Run(frm);
            isLogin = frm.isLogin;
            if (isLogin)
            {
                frmMain frmMain = new frmMain();
                Application.Run(frmMain);
            }
        }
    }
}
