using DataManagementModels.DriversConfigurations;
using TheTechIdea;
using TheTechIdea.Beep.Vis.Modules;
using TheTechIdea.Beep.Container.Services;
using TheTechIdea.Beep.DataBase;
using TheTechIdea.Beep.FileManager;
using TheTechIdea.Beep.MVVM.ViewModels;
using TheTechIdea.Beep.Workflow;
using TheTechIdea.Util;
using System.Xml.Linq;

namespace BeepWinFormsApp
{
    public partial class UnitofWork : Form
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
        
        public UnitofWork(IBeepService bservice)
        {
            beepService = bservice;
            InitializeComponent();
            // Setup Grid
            beepGrid1.SetConfig(beepService.DMEEditor, beepService.lg, beepService.util, new string[] { }, beepService.DMEEditor.Passedarguments, beepService.DMEEditor.ErrorObject);

            // Setup Crud View
            this.Getbutton.Click += Getbutton_Click;
            // Add Events
            // Called when Save button is clicked
            beepGrid1.BindingNavigator.SaveCalled += BeepbindingNavigator1_SaveCalled;
            // Called when Search button is clicked
            beepGrid1.BindingNavigator.ShowSearch += BeepbindingNavigator1_ShowSearch;
            // Called when New Record button is clicked
            beepGrid1.BindingNavigator.NewRecordCreated += BeepbindingNavigator1_NewRecordCreated;
            // Called when Edit button is clicked
            beepGrid1.BindingNavigator.EditCalled += BeepbindingNavigator1_EditCalled;
            this.FormClosing += GridDataView_FormClosing;
            this.DataSourcescomboBox.SelectedIndexChanged += DataSourcescomboBox_SelectedIndexChanged;
            this.beepGrid1.Theme = BeepThemes.EarthyTheme;
            // Add Themes to the combobox
        }
        private void DataSourcescomboBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            EntitiescomboBox.Text = "";
            EntitiescomboBox.Items.Clear();
            this.beepGrid1.DataSource = null;
            GetDataSourceFromCombobox();
            GetEntities();
        }

        private void GetDataSourceFromCombobox()
        {
            if (DataSourcescomboBox.SelectedItem != null)
            {

                BeepSharedFunctions.SourceDataSource = BeepSharedFunctions.beepService.DMEEditor.GetDataSource(DataSourcescomboBox.SelectedItem.ToString());
                if (BeepSharedFunctions.SourceDataSource != null)
                {
                    BeepSharedFunctions.SourceDataSource.Openconnection();
                }
                if (BeepSharedFunctions.SourceDataSource.ConnectionStatus == System.Data.ConnectionState.Open)
                {
                    GetEntities();
                }
                else
                {
                    beepService.DMEEditor.AddLogMessage("Beep", $"Error Opening Connection", DateTime.Now, -1, null, Errors.Failed);
                }


            }
        }
        private void GridDataView_FormClosing(object? sender, FormClosingEventArgs e)
        {
            // Close the connection
            BeepSharedFunctions.CloseConnections();
            BeepSharedFunctions.SourceDataSource.Closeconnection();
            // Dispose the connection

        }

        private void Getbutton_Click(object? sender, EventArgs e)
        {
            object data = null;
            EntityStructure Structure = new EntityStructure();
            if (EntitiescomboBox.SelectedItem != null)
            {
                string entityname = EntitiescomboBox.SelectedItem.ToString();

                data = BeepSharedFunctions.SourceDataSource.GetEntity(entityname, null);
                Structure = BeepSharedFunctions.SourceDataSource.GetEntityStructure(entityname, true);
                this.beepGrid1.ResetData(data, Structure);

            }
        }
        #region "Grid Events"
        private void BeepbindingNavigator1_EditCalled(object? sender, BindingSource e)
        {

        }

        private void BeepbindingNavigator1_NewRecordCreated(object? sender, BindingSource e)
        {

        }

        private void BeepbindingNavigator1_ShowSearch(object? sender, BindingSource e)
        {

        }

        private void BeepbindingNavigator1_SaveCalled(object? sender, BindingSource e)
        {

        }

        #endregion
        #region "DataConnection Methdods"
        private void GetEntities()
        {
            // Get the list of entities
            EntitiescomboBox.Items.Clear();
            List<string> strings = new List<string>();


            if (BeepSharedFunctions.SourceDataSource != null)
            {
                BeepSharedFunctions.SourceDataSource.Openconnection();
                if (BeepSharedFunctions.SourceDataSource.ConnectionStatus == System.Data.ConnectionState.Open)
                {
                    strings = BeepSharedFunctions.SourceDataSource.GetEntitesList();
                }


                // Add the entities to the combobox
                EntitiescomboBox.Items.Clear();
                foreach (string item in strings)
                {
                    EntitiescomboBox.Items.Add(item);
                }
            }



        }
    
        #endregion
    }
}
