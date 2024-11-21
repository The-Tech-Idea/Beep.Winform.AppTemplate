using System;
using System.Collections.Generic;

using TheTechIdea;
using TheTechIdea.Beep.Vis.Modules;
using TheTechIdea.Beep.Container.Services;
using TheTechIdea.Beep.DataBase;
using TheTechIdea.Beep.FileManager;
using TheTechIdea.Beep.MVVM.ViewModels;
using TheTechIdea.Beep.Workflow;
using TheTechIdea.Beep.Utilities;
namespace BeepWinFormsApp
{
    public partial class MainForm : Form
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
        public MainForm(IBeepService bservice)
        {
            InitializeComponent();
            beepService=bservice;
            this.CreateinmemoryDBbutton.Click += CreateinmemoryDBbutton_Click;
            this.CreateLocalDBbutton.Click += CreateLocalDBbutton_Click;
            this.MoveDatabutton.Click += MoveDatabutton_Click;
            this.GridViewbutton.Click += GridViewbutton_Click;
            this.GenerateEntitiesPOCObutton.Click += GenerateEntitiesPOCObutton_Click;
        }

        private void GenerateEntitiesPOCObutton_Click(object? sender, EventArgs e)
        {
            GenerateEntitiesPOCO generateEntitiesPOCO=new GenerateEntitiesPOCO(beepService);
            generateEntitiesPOCO.ShowDialog();
        }

        private void CreateinmemoryDBbutton_Click(object? sender, EventArgs e)
        {
             CreateInMemoryDB createInMemoryDB = new CreateInMemoryDB(beepService);
            createInMemoryDB.Show();
        }

        private void CreateLocalDBbutton_Click(object? sender, EventArgs e)
        {
            CreateLocalDatabase createLocalDatabase = new CreateLocalDatabase(beepService);
            createLocalDatabase.Show();
        }

        private void MoveDatabutton_Click(object? sender, EventArgs e)
        {
            MovingData movingData = new MovingData(beepService);
            movingData.Show();
        }

        private void GridViewbutton_Click(object? sender, EventArgs e)
        {
           GridDataView gridDataView = new GridDataView(beepService);
            gridDataView.Show();
        }
    }
}
