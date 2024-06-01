using DataManagementModels.DriversConfigurations;
using TheTechIdea;
using TheTechIdea.Beep;
using TheTechIdea.Beep.Container.Services;
using TheTechIdea.Beep.DataBase;
using TheTechIdea.Beep.FileManager;
using TheTechIdea.Beep.MVVM.ViewModels;
using TheTechIdea.Util;

namespace BeepWinFormsApp
{
    public static class BeepSharedFunctions
    {
        public  static SQLiteDataSource Sqlite_SampleDB;
        public static TxtXlsCSVFileSource XlsFile;
        public static CSVDataSource CSVFile;
        public static IBeepService beepService;

        
        public static ConnectionDriversConfig GetConnectionDriversConfig(DataSourceType type)
        {
            // Get the list of connection drivers
            return beepService.DMEEditor.ConfigEditor.DataDriversClasses.FirstOrDefault(p => p.DatasourceType == type);

        }
        public static void CloseConnections()
        {
            if (Sqlite_SampleDB != null)
            {
                Sqlite_SampleDB.Closeconnection();
            }
            if (XlsFile != null)
            {
                XlsFile.Closeconnection();
            }
            if (CSVFile != null)
            {
                CSVFile.Closeconnection();
            }
          
        }
        public static bool CreateConnectionForSqlite()
        {
            CloseConnections();
            // Get the connection drivers configuration
            ConnectionDriversConfig config = GetConnectionDriversConfig(DataSourceType.SqlLite);
            // Create a new connection configuration
            ConnectionProperties connectionProperties = new ConnectionProperties
            {
                ConnectionString = "Data Source=./Beep/dbfiles/northwind.db",
                ConnectionName = "northwind.db",
                DriverName = config.PackageName,
                DriverVersion = config.version,
                DatabaseType = DataSourceType.SqlLite,
                Category = DatasourceCategory.RDBMS

            };
            // add to the list of connections
            beepService.Config_editor.AddDataConnection(connectionProperties);
            // Create the connection
            Sqlite_SampleDB = (SQLiteDataSource?)beepService.DMEEditor.GetDataSource("northwind.db");
            // Open the connection
            Sqlite_SampleDB.Openconnection();

            if (Sqlite_SampleDB.ConnectionStatus == System.Data.ConnectionState.Open)
            {
               
                return true;
            }
            else
            {
                MessageBox.Show("Connection Failed");
                return false;
            }
        }
        public static bool CreateConnectionForXls()
        {
            CloseConnections();
            // Get the connection drivers configuration
            ConnectionDriversConfig config = GetConnectionDriversConfig(DataSourceType.Xls);
            // Create a new connection configuration
            ConnectionProperties connectionProperties = new ConnectionProperties
            {
                
                FileName= "country.xls",
                FilePath= "./dbfiles",
                ConnectionName = "country.xls",
                DriverName = config.PackageName,
                DriverVersion = config.version,
                DatabaseType = DataSourceType.Xls,
                Ext="xls",
                Category = DatasourceCategory.FILE
                

            };
            // add to the list of connections
            beepService.Config_editor.AddDataConnection(connectionProperties);
            // Create the connection
            XlsFile = (TxtXlsCSVFileSource?)beepService.DMEEditor.GetDataSource("country.xls");
            // Open the connection
            XlsFile.Openconnection();

            if (XlsFile.ConnectionStatus == System.Data.ConnectionState.Open)
            {
              
                return true;
            }
            else
            {
                MessageBox.Show("Connection Failed");
                return false;
            }
        }
        public static bool CreateConnectionForCSV()
        {
            CloseConnections();
            // Get the connection drivers configuration
            ConnectionDriversConfig config = GetConnectionDriversConfig(DataSourceType.CSV);
            // Create a new connection configuration
            ConnectionProperties connectionProperties = new ConnectionProperties
            {
                
                FileName = "iris.csv",
                FilePath = "./dbfiles",
                ConnectionName = "iris.csv",
                DriverName = config.PackageName,
                DriverVersion = config.version,
                DatabaseType = DataSourceType.CSV,
                Ext="csv",
                Category = DatasourceCategory.FILE

            };
            // add to the list of connections
            beepService.Config_editor.AddDataConnection(connectionProperties);
            // Create the connection
            CSVFile = (CSVDataSource?)beepService.DMEEditor.GetDataSource("iris.csv");
            // Open the connection
            CSVFile.Openconnection();

            if (CSVFile.ConnectionStatus == System.Data.ConnectionState.Open)
            {
              
                return true;
            }
            else
            {
                MessageBox.Show("Connection Failed");
                return false;
            }
        }

        public static IErrorsInfo MoveEntity(string src,string dest,string entityname,Progress<PassedArgs> progress)
        {
            beepService.DMEEditor.ErrorObject=new   ErrorsInfo();
             IDataSource source = beepService.DMEEditor.GetDataSource(src);
            IDataSource destination = beepService.DMEEditor.GetDataSource(dest);
         
            if(source==null || destination == null)
            {
                beepService.DMEEditor.AddLogMessage("Beep","Source or Destination not found", DateTime.Now, 0, "", Errors.Failed);
                return beepService.DMEEditor.ErrorObject;
            }
            if (destination.DatasourceType == DataSourceType.CSV || destination.DatasourceType == DataSourceType.Xls)
            {
                beepService.DMEEditor.AddLogMessage("Beep", "Destination is not a database", DateTime.Now, 0, "", Errors.Failed);
                return beepService.DMEEditor.ErrorObject;
            }
            source.Openconnection();
            destination.Openconnection();
            if(source.ConnectionStatus== System.Data.ConnectionState.Open && destination.ConnectionStatus == System.Data.ConnectionState.Open)
            {
                 EntityStructure srcentity= source.GetEntityStructure(entityname,true);
                 EntityStructure destentity = destination.GetEntityStructure(entityname, true);
                 if(srcentity!=null && destentity != null)
                {
                    try
                    {
                        bool er = true;
                        var data = source.GetEntity(entityname, null);
                        if(destination.CheckEntityExist(entityname) == false)
                        {
                          er=  destination.CreateEntityAs(srcentity);
        
                        }
                        if (er)
                        {
                            destination.UpdateEntities(entityname, data, progress);
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        beepService.DMEEditor.AddLogMessage("Beep",$" Error {ex.Message}", DateTime.Now, 0, "", Errors.Failed);
                        return beepService.DMEEditor.ErrorObject;
                    }
                  
                }else
                {
                    beepService.DMEEditor.AddLogMessage("Beep", "Entity not found", DateTime.Now, 0, "", Errors.Failed);
                    return beepService.DMEEditor.ErrorObject;
                }
            }
            else
            {
                beepService.DMEEditor.AddLogMessage("Beep", "Connection failed", DateTime.Now, 0, "", Errors.Failed);
                return beepService.DMEEditor.ErrorObject;
            }
            return beepService.DMEEditor.ErrorObject;
        }
    }
}
