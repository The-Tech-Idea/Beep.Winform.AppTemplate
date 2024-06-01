using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheTechIdea.Beep.Container.Services;
using TheTechIdea.Beep.MVVM.ViewModels.BeepConfig;
using TheTechIdea.Util;

namespace BeepWinFormsApp
{
    public partial class CreateLocalDatabase : Form
    {
        private IBeepService beepService;

        public CreateLocalDatabase(IBeepService service)
        {
            beepService = service;
            InitializeComponent();
            ViewModel = new DataConnectionViewModel(beepService.DMEEditor, beepService.vis);
            listBox1.DataSource = ViewModel.DataConnections;
            listBox1.DisplayMember = "ConnectionName";
            listBox1.ValueMember = "GuidID";
            ViewModel.SelectedCategoryItem = DatasourceCategory.RDBMS;
            EmbeddedDatabaseTypecomboBox.DataSource = ViewModel.EmbeddedDatabaseTypes;
            EmbeddedDatabaseTypecomboBox.DisplayMember = "classHandler";
            EmbeddedDatabaseTypecomboBox.ValueMember = "GuidID";
            this.databaseTextBox.DataBindings.Add("Text", ViewModel, "DatabaseName", true, DataSourceUpdateMode.OnPropertyChanged);
            this.EmbeddedDatabaseTypecomboBox.DataBindings.Add("SelectedItem", ViewModel, "SelectedEmbeddedDatabaseType", true, DataSourceUpdateMode.OnPropertyChanged);
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
                    ViewModel.InstallFolderPath= "./dbfiles";
                    ViewModel.CreateLocalConnectionUsingPath();
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

    }
}
