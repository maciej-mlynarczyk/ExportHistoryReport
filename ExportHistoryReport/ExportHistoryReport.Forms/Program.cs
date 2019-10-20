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
            UnityHelper.Container.RegisterSingleton<IExportRepository, ExportRepository>();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Report());
        }
    }
}
