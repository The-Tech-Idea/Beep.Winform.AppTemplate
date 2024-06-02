using Microsoft.Extensions.Hosting;
using TheTechIdea.Beep.Container;

namespace BeepWinFormsApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
         

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            HostApplicationBuilder builder = Host.CreateApplicationBuilder();
            // Register Beep Services
            BeepProgram.RegisterServices(builder);
            // Register Other Services here

            using IHost host = builder.Build();

            // Retreiving Services and Configuring them
            BeepProgram.InitializeAndConfigureServices(host);

            BeepProgram.RegisterGlobalKeyHandler();

            // Start the Application
             BeepProgram.StartLoadingDataThenShowMainForm(new string[3] { "BeepEnterprize", "TheTechIdea", "Beep" });
          
            BeepSharedFunctions.beepService = BeepProgram.beepService;
            BeepSharedFunctions.CreateConnectionForSqlite();
            BeepSharedFunctions.CreateConnectionForXls();
            BeepSharedFunctions.CreateConnectionForCSV();
            Application.Run(new MainForm(BeepProgram.beepService));
            // Dispose Services
            BeepProgram.DisposeServices(host.Services);
        }
    }
}