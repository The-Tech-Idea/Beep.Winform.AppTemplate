using DataManagementModels.DriversConfigurations;
using TheTechIdea;
using Beep.Vis.Module;
using TheTechIdea.Beep.Container.Services;
using TheTechIdea.Beep.DataBase;
using TheTechIdea.Beep.FileManager;
using TheTechIdea.Beep.MVVM.ViewModels;
using TheTechIdea.Beep.Workflow;
using TheTechIdea.Util;
using System.Xml.Linq;

namespace BeepWinFormsApp
{
    public partial class GenerateEntitiesPOCO : Form
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

        public GenerateEntitiesPOCO(IBeepService bservice)
        {
            beepService = bservice;
            InitializeComponent();
            foreach (var item in beepService.Config_editor.DataConnections)

            {
                DataSourcescomboBox.Items.Add(item.ConnectionName);

            }
            this.Getbutton.Click += Getbutton_Click;
            this.FormClosing += GridDataView_FormClosing;
            this.DataSourcescomboBox.SelectedIndexChanged += DataSourcescomboBox_SelectedIndexChanged;
        }

        private void Getbutton_Click(object? sender, EventArgs e)
        {
            if (EntitiescomboBox.SelectedItem != null) {
                string entittyname = EntitiescomboBox.SelectedItem.ToString();
                if (BeepSharedFunctions.SourceDataSource.ConnectionStatus == System.Data.ConnectionState.Open)
                {
                    EntityStructure structure=BeepSharedFunctions.SourceDataSource.GetEntityStructure(entittyname, true);
                    if (structure != null)
                    {
                        string ent=beepService.DMEEditor.classCreator.CreatEntityClass(structure, "", "", beepService.BeepDirectory+"\\Beep\\Entities" );
                        if (ent != null) { 
                            LogtextBox.Text = ent;
                        }

                    }

            }
                else
                {
                    beepService.DMEEditor.AddLogMessage("Beep", $"Error Opening Connection", DateTime.Now, -1, null, Errors.Failed);
                }
            }
           
        }

        private void DataSourcescomboBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            EntitiescomboBox.Text = "";
            EntitiescomboBox.Items.Clear();
           
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
    }
}
