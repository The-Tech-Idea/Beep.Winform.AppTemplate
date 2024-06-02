using DataManagementModels.DriversConfigurations;
using TheTechIdea;
using Beep.Vis.Module;
using TheTechIdea.Beep.Container.Services;
using TheTechIdea.Beep.DataBase;
using TheTechIdea.Beep.FileManager;
using TheTechIdea.Beep.MVVM.ViewModels;
using TheTechIdea.Beep.Workflow;
using TheTechIdea.Util;
using Beep.InMemory.Logic;
namespace BeepWinFormsApp
{
    public partial class CreateInMemoryDB : Form
    {
        private IBeepService beepService;


        // Always use the constructor to pass the IBeepService
        // This is the only way to get the IBeepService
        // The IBeepService is the main service that provides access to all the services
        // and the DMEEditor which is the main editor
        // and the Logger
        // and the Util
        // and the Config_editor
        // and the VisManager
        // and the DataSources
        // and the DataDrivers

        public CreateInMemoryDB(IBeepService bservice)
        {
            beepService = bservice;
            InitializeComponent();
           
        }
        public void Create()
        {
            ConnectionProperties conn = BeepInMemoryManager.CreateInMemoryDB(beepService.DMEEditor, beepService.vis);
            if (beepService.DMEEditor.ErrorObject.Flag == Errors.Ok)
            {
                if (conn != null)
                {
                }

            }
        }
    }
}
