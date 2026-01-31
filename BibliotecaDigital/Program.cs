
using Biblioteca_Digital.DataAcess;
using Forms;

namespace BibliotecaDigital
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            GlobalConfig.InitializeConnections(DatabaseType.Sql);
            Application.Run(new FormMenuPrincipal());
        }
    }
}