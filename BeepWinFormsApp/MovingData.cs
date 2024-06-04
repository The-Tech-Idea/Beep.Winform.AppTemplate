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
    public partial class MovingData : Form
    {
        private IBeepService beepService;



        public MovingData(IBeepService bservice)
        {
            beepService = bservice;
            InitializeComponent();
            // Getting  Connection if Saved 
            // If not saved create a new connection using
            // beepService.DMEEditor.ConfigEditor.SaveDataconnectionsValues();
            BeepSharedFunctions.beepService = beepService;
            foreach (var item in beepService.Config_editor.DataConnections.Where(p => p.Category == DatasourceCategory.FILE))

            {
                SourceDataSourcescomboBox.Items.Add(item.ConnectionName);

            }
            foreach (var item in beepService.Config_editor.DataConnections.Where(p => p.Category != DatasourceCategory.FILE))

            {
                DestinationDataSourcecomboBox1.Items.Add(item.ConnectionName);

            }
            //SourceDataSourcescomboBox.Items.Add("country.xls");
            //SourceDataSourcescomboBox.Items.Add("Iris.csv");
            //DestinationDataSourcecomboBox1.Items.Add("northwind.db");




            SourceDataSourcescomboBox.SelectedIndexChanged += SourceDataSourcescomboBox_SelectedIndexChanged;
            DestinationDataSourcecomboBox1.SelectedIndexChanged += DestinationDataSourcecomboBox1_SelectedIndexChanged;
            this.copybutton.Click += Copybutton_Click;
            this.deletebutton.Click += Deletebutton_Click;
        }

        private void Deletebutton_Click(object? sender, EventArgs e)
        {
            if (DestinationDataSourcecomboBox1 != null)
            {
                if (DestEntitiescomboBox.SelectedItem != null)
                {
                    BeepSharedFunctions.DestinationDataSource = BeepSharedFunctions.beepService.DMEEditor.GetDataSource(DestinationDataSourcecomboBox1.SelectedItem.ToString());
                    if (BeepSharedFunctions.DestinationDataSource != null)
                    {
                        BeepSharedFunctions.DestinationDataSource.Openconnection();
                        if (BeepSharedFunctions.DestinationDataSource.ConnectionStatus == System.Data.ConnectionState.Open)
                        {
                            beepService.DMEEditor.ErrorObject = BeepSharedFunctions.DestinationDataSource.ExecuteSql($"Drop Table {DestEntitiescomboBox.SelectedItem}");
                            if (beepService.DMEEditor.ErrorObject.Flag == Errors.Ok)
                            {
                                BeepSharedFunctions.DestinationDataSource.GetEntitesList();
                                LogtextBox.AppendText($"Table {DestEntitiescomboBox.SelectedItem} Deleted" + Environment.NewLine);
                                LogtextBox.SelectionStart = LogtextBox.Text.Length;
                                LogtextBox.ScrollToCaret();
                                DestEntitiescomboBox.Items.Clear();
                                GetDestEntities();

                            }
                            else
                            {
                                LogtextBox.AppendText($"Error Deleting Table {DestEntitiescomboBox.SelectedItem} : {beepService.DMEEditor.ErrorObject.Message}" + Environment.NewLine);
                                LogtextBox.SelectionStart = LogtextBox.Text.Length;
                                LogtextBox.ScrollToCaret();
                            }
                        }


                    }

                }
            }
        }

        private void Copybutton_Click(object? sender, EventArgs e)
        {
            if (SourceEntitiescomboBox.SelectedItem == null || DestinationDataSourcecomboBox1.SelectedItem == null)
            {
                return;
            }
            // check if selected entity exists in the destination
            if (DestEntitiescomboBox.Items.Contains(SourceEntitiescomboBox.SelectedItem))
            {
                return;
            }
            progressBar1.Value = 1;
            progressBar1.Step = 1;
            progressBar1.Maximum = 1;
            var progress = new Progress<PassedArgs>(percent =>
            {
                progressBar1.CustomText = percent.ParameterInt1 + " out of " + percent.ParameterInt2;

                if (percent.ParameterInt2 > 0)
                {
                    progressBar1.Maximum = percent.ParameterInt2;

                }
                if (percent.ParameterInt1 > progressBar1.Maximum)
                {
                    progressBar1.Maximum = percent.ParameterInt1;
                }

                progressBar1.Value = percent.ParameterInt1;
                if (!string.IsNullOrEmpty(percent.Messege))
                {
                    this.LogtextBox.BeginInvoke(new Action(() =>
                    {
                        this.LogtextBox.AppendText($"{percent.Messege}" + Environment.NewLine);
                        LogtextBox.SelectionStart = LogtextBox.Text.Length;
                        LogtextBox.ScrollToCaret();
                    }));

                }


            });
            string source = SourceDataSourcescomboBox.SelectedItem.ToString();
            string dest = DestinationDataSourcecomboBox1.SelectedItem.ToString();
            string entity = SourceEntitiescomboBox.SelectedItem.ToString();
            var retval = Task.Run(() => BeepSharedFunctions.MoveEntity(source, dest, entity, progress));
            if (retval.Result.Flag == Errors.Ok)
            {
                LogtextBox.AppendText($"Entity {entity} Copied to {dest}" + Environment.NewLine);
                LogtextBox.SelectionStart = LogtextBox.Text.Length;
                LogtextBox.ScrollToCaret();
                DestEntitiescomboBox.Items.Clear();
                GetDestEntities();
            }
            else
            {
                LogtextBox.AppendText($"Error Copying Entity {entity} to {dest} : {retval.Result.Message}" + Environment.NewLine);
                LogtextBox.SelectionStart = LogtextBox.Text.Length;
                LogtextBox.ScrollToCaret();
            }



        }

        private void DestinationDataSourcecomboBox1_SelectedIndexChanged(object? sender, EventArgs e)
        {
            GetDestinationDataSourceFromCombobox(DestinationDataSourcecomboBox1.SelectedItem.ToString());
            DestEntitiescomboBox.Items.Clear();
            GetDestEntities();
        }

        private void SourceDataSourcescomboBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (SourceDataSourcescomboBox.SelectedItem != null)
            {
                GetDataSourceFromCombobox(SourceDataSourcescomboBox.SelectedItem.ToString());
                SourceEntitiescomboBox.Items.Clear();
                GetSourceEntities();

            }
       
        }
        private void GetDataSourceFromCombobox(string dsname)
        {

            BeepSharedFunctions.SourceDataSource = BeepSharedFunctions.beepService.DMEEditor.GetDataSource(dsname);
            if (BeepSharedFunctions.SourceDataSource != null)
            {
                BeepSharedFunctions.SourceDataSource.Openconnection();
            }




        }
        private void GetDestinationDataSourceFromCombobox(string dsname)
        {

            BeepSharedFunctions.DestinationDataSource = BeepSharedFunctions.beepService.DMEEditor.GetDataSource(dsname);
            if (BeepSharedFunctions.DestinationDataSource != null)
            {
                BeepSharedFunctions.DestinationDataSource.Openconnection();
            }



        }
        private void GetSourceEntities()
        {
            // Get the list of entities
            SourceEntitiescomboBox.Items.Clear();
            List<string> strings = new List<string>();
            if (SourceDataSourcescomboBox.SelectedItem != null)
            {
                switch (SourceDataSourcescomboBox.SelectedItem.ToString())
                {
                  
                   
                    default:
                        if (BeepSharedFunctions.SourceDataSource != null)
                        {
                            if (BeepSharedFunctions.SourceDataSource.ConnectionStatus == System.Data.ConnectionState.Open)
                            {
                                strings = BeepSharedFunctions.SourceDataSource.GetEntitesList();
                            }

                        }
                        break;
                }

                // Add the entities to the combobox
                SourceEntitiescomboBox.Items.Clear();
                foreach (string item in strings)
                {
                    SourceEntitiescomboBox.Items.Add(item);
                }
            }

        }
        private void GetDestEntities()
        {
            // Get the list of entities
            DestEntitiescomboBox.Items.Clear();
            List<string> strings = new List<string>();
            if (DestinationDataSourcecomboBox1.SelectedItem != null)
            {
                switch (DestinationDataSourcecomboBox1.SelectedItem.ToString())
                {
                    default:
                        if (BeepSharedFunctions.DestinationDataSource != null)
                        {
                            BeepSharedFunctions.DestinationDataSource.Openconnection();
                            if (BeepSharedFunctions.DestinationDataSource.ConnectionStatus == System.Data.ConnectionState.Open)
                            {
                                strings = BeepSharedFunctions.DestinationDataSource.GetEntitesList();
                            }

                        }
                        break;
                }

                // Add the entities to the combobox
                DestEntitiescomboBox.Items.Clear();
                foreach (string item in strings)
                {
                    DestEntitiescomboBox.Items.Add(item);
                }
            }

        }
    }
}
