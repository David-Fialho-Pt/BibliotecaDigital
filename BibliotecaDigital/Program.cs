
using Biblioteca_Digital.DataAcess;
using Forms;

namespace BibliotecaDigital
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            GlobalConfig.InitializeConnections();

            Application.Run(new FormMenuPrincipal());
        }
    }
}