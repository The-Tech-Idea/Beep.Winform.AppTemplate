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
    public partial class GridDataView : Form
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

        public GridDataView(IBeepService bservice)
        {
            beepService = bservice;
            InitializeComponent();
            // Setup Grid
            beepGrid1.SetConfig(beepService.DMEEditor, beepService.lg, beepService.util, new string[] { }, beepService.DMEEditor.Passedarguments, beepService.DMEEditor.ErrorObject);
            // Setup Crud View

            // Getting  Connection if Saved 
            // If not saved create a new connection using
            // beepService.DMEEditor.ConfigEditor.SaveDataconnectionsValues();
            BeepSharedFunctions.beepService = beepService;
            foreach (var item in beepService.Config_editor.DataConnections)

            {
                DataSourcescomboBox.Items.Add(item.ConnectionName);

            }
            // if not found create a new connection

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
            this.ThemecomboBox.Items.Add("EarthyTheme");
            this.ThemecomboBox.Items.Add("DarkTheme");
            this.ThemecomboBox.Items.Add("LightTheme");
            this.ThemecomboBox.Items.Add("AutumnTheme");
            this.ThemecomboBox.Items.Add("CandyTheme");

            this.ThemecomboBox.Items.Add("ForestTheme");
            this.ThemecomboBox.Items.Add("HighlightTheme");
            this.ThemecomboBox.Items.Add("OceanTheme");
            this.ThemecomboBox.Items.Add("RetroTheme");
            this.ThemecomboBox.Items.Add("RoyalTheme");
            this.ThemecomboBox.Items.Add("SunsetTheme");
            this.ThemecomboBox.Items.Add("WinterTheme");
            this.ThemecomboBox.Items.Add("ZenTheme");



            this.ThemecomboBox.SelectedIndexChanged += ThemecomboBox_SelectedIndexChanged;
        }

        private void ThemecomboBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            // Set the theme
            // Get theme from the combobox
            switch (ThemecomboBox.SelectedItem.ToString())
            {
                case "EarthyTheme":
                    this.beepGrid1.Theme = BeepThemes.EarthyTheme;
                    break;
                case "DarkTheme":
                    this.beepGrid1.Theme = BeepThemes.DarkTheme;
                    break;
                case "LightTheme":
                    this.beepGrid1.Theme = BeepThemes.LightTheme;
                    break;
                case "AutumnTheme":
                    this.beepGrid1.Theme = BeepThemes.AutumnTheme;
                    break;
                case "CandyTheme":
                    this.beepGrid1.Theme = BeepThemes.CandyTheme;
                    break;
                case "ForestTheme":
                    this.beepGrid1.Theme = BeepThemes.ForestTheme;
                    break;
                case "HighlightTheme":
                    this.beepGrid1.Theme = BeepThemes.HighlightTheme;
                    break;
                case "OceanTheme":
                    this.beepGrid1.Theme = BeepThemes.OceanTheme;
                    break;
                case "RetroTheme":
                    this.beepGrid1.Theme = BeepThemes.RetroTheme;
                    break;
                case "RoyalTheme":
                    this.beepGrid1.Theme = BeepThemes.RoyalTheme;
                    break;
                case "SunsetTheme":
                    this.beepGrid1.Theme = BeepThemes.SunsetTheme;
                    break;
                case "WinterTheme":
                    this.beepGrid1.Theme = BeepThemes.WinterTheme;
                    break;
                case "ZenTheme":
                    this.beepGrid1.Theme = BeepThemes.ZenTheme;
                    break;
            }

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
