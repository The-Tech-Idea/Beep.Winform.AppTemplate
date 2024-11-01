 using DataManagementModels.DriversConfigurations;
using TheTechIdea;
using TheTechIdea.Beep.Vis.Modules;
using TheTechIdea.Beep.Container.Services;
using TheTechIdea.Beep.DataBase;
using TheTechIdea.Beep.FileManager;
using TheTechIdea.Beep.MVVM.ViewModels;
using TheTechIdea.Beep.Workflow;
using TheTechIdea.Util;
using Beep.InMemory.Logic;
using TheTechIdea.Beep.MVVM.ViewModels.BeepConfig;
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
            ViewModel = new DataConnectionViewModel(beepService.DMEEditor, beepService.vis);
            listBox1.DataSource = ViewModel.DataConnections;
            listBox1.DisplayMember = "ConnectionName";
            listBox1.ValueMember = "GuidID";
            ViewModel.SelectedCategoryItem = DatasourceCategory.INMEMORY;
            EmbeddedDatabaseTypecomboBox.DataSource = ViewModel.InMemoryDatabaseTypes;
            EmbeddedDatabaseTypecomboBox.DisplayMember = "classHandler";
            EmbeddedDatabaseTypecomboBox.ValueMember = "GuidID";
            this.databaseTextBox.DataBindings.Add("Text", ViewModel, "DatabaseName", true, DataSourceUpdateMode.OnPropertyChanged);
            this.EmbeddedDatabaseTypecomboBox.DataBindings.Add("SelectedItem", ViewModel, "SelectedinMemoryDatabaseType", true, DataSourceUpdateMode.OnPropertyChanged);
            this.CreateDBbutton.Click += CreateDBbutton_Click;
        }
        public DataConnectionViewModel ViewModel { get; set; }
        public ConnectionProperties cn { get; set; }

        private void CreateDBbutton_Click(object sender, EventArgs e)
        {
            ErrorsInfo ErrorObject = new ErrorsInfo();
            try

            {

                if (!beepService.DMEEditor.ConfigEditor.DataConnectionExist(databaseTextBox.Text))
                {
                    this.ValidateChildren();
                    ViewModel.InstallFolderPath = "./dbfiles";
                    ViewModel.CreateInMemoryConnection();
                    if (ViewModel.IsCreated)
                    {

                        beepService.DMEEditor.AddLogMessage("Beep", $"Database Created Successfully", DateTime.Now, -1, null, Errors.Ok);
                        MessageBox.Show("Database Created Successfully", "Beep");
                    }
                    else
                    {
                        beepService.DMEEditor.AddLogMessage("Beep", $"Error creating Database", DateTime.Now, -1, null, Errors.Failed);
                        MessageBox.Show("Error creating Database", "Beep");
                    }

                }
                else
                {
                    beepService.DMEEditor.AddLogMessage("Beep", $"Database Already Exist by this name please try another name ", DateTime.Now, -1, null, Errors.Failed);
                    MessageBox.Show("Database Already Exist by this name please try another name ", "Beep");
                }




            }
            catch (Exception ex)
            {

                ErrorObject.Flag = Errors.Failed;
                string errmsg = "Error creating Database";
                MessageBox.Show(errmsg, "Beep");
                ErrorObject.Message = $"{errmsg}:{ex.Message}";
                //Logger.WriteLog($" {errmsg} :{ex.Message}");
                beepService.DMEEditor.AddLogMessage("Beep", $"Error creating Local DB - {ex.Message}", DateTime.Now, -1, null, Errors.Failed);
            }
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
