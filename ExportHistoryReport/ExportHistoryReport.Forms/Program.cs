using ExportHistoryReport.BusinessLayer;
using ExportHistoryReport.DataLayer;
using System;
using System.Windows.Forms;
using Unity;

namespace ExportHistoryReport.Forms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ConfigureUnity();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Report());
        }

        /// <summary>
        /// Configures the unity.
        /// </summary>
        static void ConfigureUnity()
        {
            UnityHelper.Container.RegisterSingleton<IExportRepository, ExportRepository>();
        }
    }
}
