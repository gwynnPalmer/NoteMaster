namespace NoteMaster
{
    using System;
    using System.Windows.Forms;
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
            NoteService.SetDbLocation();
            Application.Run(new NoteMasterMain());
        }

        //TODO: Add IWritableOptions.
    }
}