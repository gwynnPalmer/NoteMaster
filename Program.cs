namespace NoteMaster
{
    using System;
    using System.Windows.Forms;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using Microsoft.Extensions.Options;
    using NoteMaster.Services;
    using NoteMaster.UI.Forms;

    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            NoteService.SetFileLocation();
            RunNoteMaster();
        }

        public static void RunNoteMaster()
        {
            Application.Run(new NoteMasterMain());
        }

        //TODO: Add IWritableOptions.
    }
}