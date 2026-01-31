
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
            GlobalConfig.InitializeConnections(DatabaseType.Txt);
            Application.Run(new FormMenuPrincipal());
        }
    }
}