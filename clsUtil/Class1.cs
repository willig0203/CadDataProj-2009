using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Diagnostics;
using System.DirectoryServices;

//using Microsoft.Web.Administration;

using System.Windows.Forms;
using System.IO;


//using IWshRuntimeLibrary;

using TaskScheduler;


namespace clsUtil
{
    public class Class1
    {

        //public void GetSites(string serverName)
        //{
        //    using (System.ServerManager serverManager = new ServerManager()) //OpenRemote()
        //    {
        //        var sites = serverManager.Sites;
        //        foreach (Site site in sites)
        //        {
        //            Console.WriteLine(site.Name); // This will return the WebSite name 
        //        }

        //    }
        //}


        //public void GetSites(string serverName)
        //{
        //    //List Nodes = new List();
        //    //CustomTreeNode tnResult = new CustomTreeNode();
        //    try
        //    {
        //        DirectoryEntry w3svc = new DirectoryEntry("IIS://" + serverName + "/w3svc");
        //        foreach (DirectoryEntry entry in w3svc.Children)
        //        {
        //            if (entry.SchemaClassName == "IIsWebServer")
        //            {
        //                string s = entry.Properties["ServerComment"].Value.ToString();

        //                //CustomTreeNode Site = new CustomTreeNode(entry.Properties["ServerComment"].Value.ToString());
        //                //this.ServerLoadStart(entry.Properties["ServerComment"].Value.ToString()); 
        //                //Site.CurrentEntry = entry;
        //                //Site.ImageIndex = 1;
        //                //Site.SelectedImageIndex = 1;
        //                //Site = GetVirtualDirectories(entry, Site);
        //                //Site.ImageIndex = 0;
        //                //Site.SelectedImageIndex = 0;
        //                //Nodes.Add(Site);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        string msg = ex.Message;
        //    }
        //    //return Nodes;
        //}
        //private CustomTreeNode GetVirtualDirectories(DirectoryEntry site, CustomTreeNode Parent)
        //{
        //    string VirDirSchemaName = "IIsWebVirtualDir";
        //    DirectoryEntry folderRoot = site.Children.Find("Root", VirDirSchemaName);
        //    foreach (DirectoryEntry deChild in folderRoot.Children)
        //    {
        //        CustomTreeNode tnFolder = new CustomTreeNode(deChild.Name);
        //        this.VirtualDirectoryStart(deChild.Name);
        //        tnFolder.ImageIndex = 0;
        //        tnFolder.SelectedImageIndex = 0;
        //        tnFolder.CurrentEntry = deChild;
        //        tnFolder.ImageIndex = 1;
        //        tnFolder.SelectedImageIndex = 1;
        //        Parent.Nodes.Add(tnFolder);
        //    }
        //    return Parent;
        //}



         
        //private DirectoryEntry _iisServer = null;  
        //private DirectoryEntry iisServer 
        //{     
        //    get     
        //    {     
        //        if (_iisServer == null)   
        //        {        
        //            string path = string.Format("IIS://{0}/W3SVC/1", serverName);   
        //            _iisServer = new DirectoryEntry(path);   
        //        }     
        //        return _iisServer; 
        //    }   
        //}   
        
        //private IDictionary<string, DirectoryEntry> _virtualDirectories = null;   
        //private IDictionary<string, DirectoryEntry> virtualDirectories  
        //{      
        //    get     
        //    {     
        //        if (_virtualDirectories == null)       
        //        {           
        //            _virtualDirectories = new Dictionary<string, DirectoryEntry>();  
        //            DirectoryEntry folderRoot = iisServer.Children.Find("Root", VirDirSchemaName);     
                    
        //            foreach (DirectoryEntry virtualDirectory in folderRoot.Children)         
        //            {            
        //                _virtualDirectories.Add(virtualDirectory.Name, virtualDirectory);         
        //            }       
        //        }     
        //        return _virtualDirectories;     
        //    }   
        //} 



   //     public string GetSiteIdFromSiteName(String ServerName, String WebsiteName)
   //     {
   //         ConnectionOptions options = SetUpAuthorization();
   //         ManagementScope scope = new ManagementScope(string.Format(@"\\\\{0}\\root\\cimv2", ServerName), options); 
   //         scope.Connect(); 
   //         ObjectQuery OQuery = new ObjectQuery(@"SELECT * FROM IIsSetting");
   //         ManagementObjectSearcher WebSiteFinder = new ManagementObjectSearcher(scope, OQuery);
   //         ArrayList WebSiteListArray = new ArrayList(); 
   //         ManagementObjectCollection WebSitesCollection = WebSiteFinder.Get();

   //         String extrctedSiteId = ".";

   //         String WebSiteName = String.Empty;
   //         foreach (ManagementObject WebSite in WebSitesCollection)
   //         { 
   //             WebSiteName = WebSite.Properties["Name"].Value.ToString(); 
   //             WebsiteName = WebSiteName.Replace("W3SVC/", "");
   //             extrctedSiteId = WebsiteName.Substring(0, WebsiteName.IndexOf('/'));
   //             break; 
   //         }
   //         return extrctedSiteId; 
   //     } 

   //public ConnectionOptions SetUpAuthorization() 
   //{       
   //    ConnectionOptions options = new ConnectionOptions();  
   //    //options.Authentication = AuthenticationLevel.Connect;    
   //    //may need to set Packetprivacy enum   
   //    options.Authentication = AuthenticationLevel.PacketPrivacy;   
   //    options.EnablePrivileges = true;    
   //    options.Impersonation = ImpersonationLevel.Impersonate;  
   //    return options; 
   //}  



        //public ArrayList DomainExists(string domain)
        //{
        //    ArrayList arrEL = new ArrayList();
        //    try
        //    {
        //        DirectoryEntry iis = new DirectoryEntry("IIS://" + domain + "/w3svc/1/root");
        //        foreach (DirectoryEntry site in iis.Children)
        //        {
        //            if (site.SchemaClassName == "IIsWebServer")
        //            {
        //                if (domain.Equals(site.Properties["ServerComment"].Value.ToString()))
        //                {
        //                    return arrEL;
        //                }
        //            }
        //        }

        //        return arrEL;
        //    }
        //    catch (Exception ex)
        //    {
        //        return arrEL;
        //    }
        //}











        public class evntLog
        {
            public string Name { get; set; }
            //public string TABLE_NAME { get; set; }
            //public string ServiceType { get; set; }
            //public string State { get; set; }
            //public string StartMode { get; set; }
            //public string StartName { get; set; }
        }
        public ArrayList getEL()
        {
            ArrayList arrEL = new ArrayList();

            EventLog[] remoteEventLogs;
            // Gets logs on the local computer, gives remote computer name to get the logs on the remote computer.
            remoteEventLogs = EventLog.GetEventLogs("DFHLSCASQL01"); //System.Environment.MachineName);
            //Console.WriteLine("Number of logs on computer: " + remoteEventLogs.Length);

            for (int i = 0; i < remoteEventLogs.Length; i++)
            {
                evntLog clsEvntLog = new evntLog();

                clsEvntLog.Name = remoteEventLogs[i].Log;
                arrEL.Add(clsEvntLog);
            }


            return arrEL;

        }









        public class DB
        {
            public string TABLE_QUALIFIER { get; set; }
            public string TABLE_NAME { get; set; }
            //public string ServiceType { get; set; }
            //public string State { get; set; }
            //public string StartMode { get; set; }
            //public string StartName { get; set; }
        }
        public ArrayList getDB(string server)
        {
            ArrayList arrDB = new ArrayList();


//sp_databases
//sp_tables
//sp_columns



            SqlConnection conn = null;
            SqlDataReader rdr = null;           

            try
            {

                conn = new SqlConnection("Data Source="+server+";Initial Catalog=master;Integrated Security=True");
                conn.Open();

                // 1. create a command object identifying the stored procedure
                SqlCommand cmd = new SqlCommand("sp_databases", conn);
              
                cmd.CommandType = CommandType.StoredProcedure;
               
                rdr = cmd.ExecuteReader();
                               
                while (rdr.Read())
                {
                    //Console.WriteLine(rdr["DATABASE_NAME"].ToString() + rdr["DATABASE_SIZE"].ToString());

                    SqlConnection conn2 = new SqlConnection("Data Source=" + server + ";Initial Catalog=" + rdr["DATABASE_NAME"].ToString() + ";Integrated Security=True");
                    conn2.Open();

                    // 1. create a command object identifying the stored procedure
                    SqlCommand cmd2 = new SqlCommand("sp_tables", conn2);

                    cmd2.CommandType = CommandType.StoredProcedure;
                    //cmd2.Parameters.Add("@table_type", "'TABLE'");
                    
                    SqlDataReader rdr2 = cmd2.ExecuteReader();

                    while (rdr2.Read())
                    {
                        DB clsDB = new DB();

                        
                        if (rdr2["TABLE_TYPE"].ToString() == "TABLE")
                        {
                            string tn = rdr2["TABLE_QUALIFIER"].ToString();

                            if (tn != "Document Control" &
                                tn != "EmployeeTraining" &
                                tn != "Soft2_ShiftNotes" &
                                tn != "Soft3_ShiftNotes" &
                                tn != "InfinityQS" &
                                tn != "FactorySuiteSample" &
                                tn != "Holding" &
                                tn != "InfinityQs" &
                                tn != "InfinityQsTest" &
                                tn != "master" &
                                tn != "model" &
                                tn != "msdb" &
                                tn != "ReportServer" &
                                tn != "ReportServerTempDB" &
                                tn != "Runtime" &
                                tn != "SuiteVoyager" &
                                tn != "tempdb" &
                                tn != "WWALMDB" )                                
                            {
                                clsDB.TABLE_QUALIFIER = rdr2["TABLE_QUALIFIER"].ToString();
                                clsDB.TABLE_NAME = rdr2["TABLE_NAME"].ToString();

                                arrDB.Add(clsDB);
                            }
                        }

                    }
                    
                }
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
                if (rdr != null)
                {
                    rdr.Close();
                }
            }




            //System.Data.SqlClient.SqlConnection SqlCon = new System.Data.SqlClient.SqlConnection("Data Source=DFHLSCASQL01;Initial Catalog=master;uid=oalogin;pwd=oalogin1");
            //SqlCon.Open(); 
            //System.Data.SqlClient.SqlCommand SqlCom = new System.Data.SqlClient.SqlCommand(); 
            //SqlCom.Connection = SqlCon;
            //SqlCom.CommandType = CommandType.StoredProcedure; 
            //SqlCom.CommandText = "sp_databases";
            //System.Data.SqlClient.SqlDataReader SqlDR;
            //SqlDR = SqlCom.ExecuteReader();
          
            //while (SqlDR.Read())
            //{ 
            //    MessageBox.Show(SqlDR.GetString(0));
            //}

           // DataTable dt = new DataTable();

           // string strConn = "Data Source=DFHLSCASQL01;Initial Catalog=master;Integrated Security=True";
            //SqlConnection cn = new SqlConnection(strConn);
            ////cn.Open();
            ////DataTable dt = cn.GetSchema("Tables");
            ////cn.Close();
            
            ////SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Information_Schema.Tables where Table_Type = 'BASE TABLE'", cn);

            //SqlDataAdapter da = new SqlDataAdapter("SELECT name FROM sysobjects WHERE xtype = 'U'", cn);
            //DataTable dt = new DataTable();
            //da.Fill(dt);

            ////public DataTable GetOleDbSchemaTable(Guid schId, object[] restrictions)
            ////Each value in the Object array corresponds to a DataColumn in the resulting DataTable.
            ////The Restrictions array for the member should have the following structure:
            ////      {TABLE_CATALOG, TABLE_SCHEMA, TABLE_NAME, TABLE_TYPE}
            ////When you pass values in the restriction array, include the 'null' keyword for array 
            ////elements that do not contain values.
            ////For E.g.: You can use the following code to retrieve just the columns from the Customers table:

            //string strConnOleDb = "Data Source=DFHLSCASQL01;Initial Catalog=Plant_MoistureMeter;Integrated Security=True";
            //OleDbConnection con = new OleDbConnection(strConnOleDb);
            //con.Open();
            //object[] objArrRestrict;
            //objArrRestrict = new object[] { null, null, "Customers", null };
            //DataTable tbl;
            //tbl = con.GetOleDbSchemaTable(OleDbSchemaGuid.Columns, objArrRestrict);


            ////select just TABLE in the Object array of restrictions.
            ////Remove TABLE and insert Null to see tables, views, and other objects.
            //objArrRestrict = new object[] { null, null, null, "TABLE" };
            //DataTable schemaTbl;
            //schemaTbl = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, objArrRestrict);
            //// Display the table name from each row in the schema
            //foreach (DataRow row in schemaTbl.Rows)
            //{
            //    //   listBox.Items.Add(row["TABLE_NAME"]);
            //}


            //objArrRestrict = new object[] { null, null, "Customers", null };
            //DataTable schemaCols;
            //schemaCols = con.GetOleDbSchemaTable(OleDbSchemaGuid.Columns, objArrRestrict);
            ////List the schema info for the selected table
            //foreach (DataRow row2 in schemaCols.Rows)
            //{
            //    //   listBox.Items.Add(row2["COLUMN_NAME"]);
            //}
            
          //  return dt;
 
            return arrDB;
        }


        public class svc
        {
            public string Description { get; set; }
            public string PathName { get; set; }
            public string ServiceType { get; set; }
            public string State { get; set; }
            public string StartMode { get; set; }
            public string StartName { get; set; }
        }
        public ArrayList getSvc()
        {
            ArrayList arrServices = new ArrayList();

            //ManagementClass mcServices = new ManagementClass("Win32_Service");

            //foreach (ManagementObject moService in mcServices.GetInstances())
            //{
            //    if (moService.GetPropertyValue("StartName") == "")
            //    {
            //        svc clsSvc = new svc();

            //        clsSvc.Description = moService.GetPropertyValue("Description").ToString();

            //        clsSvc.PathName = "Path: " + moService.GetPropertyValue("PathName");

            //        clsSvc.PathName = clsSvc.PathName.Replace("\\", "/");

            //        clsSvc.ServiceType = moService.GetPropertyValue("ServiceType");

            //        clsSvc.State = moService.GetPropertyValue("State");

            //        clsSvc.StartMode = moService.GetPropertyValue("StartMode");

            //        clsSvc.StartName = moService.GetPropertyValue("StartName");

            //        arrServices.Add(clsSvc);
            //    }
            //}


            // Make a connection to a remote computer.
            // Replace the "FullComputerName" section of the
            // string "\\\\FullComputerName\\root\\cimv2" with
            // the full computer name or IP address of the
            // remote computer.
            ManagementScope scope = new ManagementScope("\\\\dfhlscasql01\\root\\cimv2");
            scope.Connect();

            // Use this code if you are connecting with a 
            // different user name and password:
            //
            // ManagementScope scope = 
            //    new ManagementScope(
            //        "\\\\FullComputerName\\root\\cimv2", options);
            // scope.Connect();

            //Query system for Operating System information
            ObjectQuery query = new ObjectQuery(
                "SELECT * FROM Win32_Service");
            ManagementObjectSearcher searcher =
                new ManagementObjectSearcher(scope, query);

            ManagementObjectCollection queryCollection = searcher.Get();
            foreach (ManagementObject moService in queryCollection)
            {
                string s = moService.GetPropertyValue("StartName").ToString();


                PropertyDataCollection pdc = moService.Properties;

                foreach (PropertyData pd in pdc)
                {
                }

                if (s.Contains("lscasvcreportprofile"))
                {
                    svc clsSvc = new svc();

                    if (moService.GetPropertyValue("Description") != null)
                        clsSvc.Description = moService.GetPropertyValue("Description").ToString();
                    else
                        clsSvc.Description = ".";

                    clsSvc.PathName = moService.GetPropertyValue("PathName").ToString().Replace("\\", "/");

                    clsSvc.ServiceType = moService.GetPropertyValue("ServiceType").ToString();

                    clsSvc.State = moService.GetPropertyValue("State").ToString();

                    clsSvc.StartMode = moService.GetPropertyValue("StartMode").ToString();

                    clsSvc.StartName = moService.GetPropertyValue("StartName").ToString().Replace("\\", "/"); ;

                    arrServices.Add(clsSvc);
                }
            }

            return arrServices;

        }




        //        string serviceName = "aspnet_state";
        //        SelectQuery query = new System.Management.SelectQuery(string.Format(     "select name, startname from Win32_Service where name = '{0}'", serviceName));
        //        using (ManagementObjectSearcher searcher =     new System.Management.ManagementObjectSearcher(query))
        //    { 
        //        foreach (ManagementObject service in searcher.Get())  
        //    {      
        //        Console.WriteLine(string.Format(             "Name: {0} - Logon : {1} ", service["Name"], service["startname"]));
        //    }
        //} 







        public class dir
        {
            public string appDir { get; set; }
            //public string accName { get; set; }
            //public string appName { get; set; }
            //public string appTrigger { get; set; }
        }
        public ArrayList GetDirs()
        {
            ArrayList al = new ArrayList();

            //string[] filePaths = Directory.GetFiles(@"\\DFHLSCASQL01\e$", "*.*", SearchOption.AllDirectories);

            string[] filePaths = Directory.GetDirectories(@"\\DFHLSCASQL01\c$\Cambria Reports", "*.*", SearchOption.AllDirectories);

            foreach (string f in filePaths)
            {
                //using (StreamReader sr = new StreamReader(f))
                //{
                dir clsDir = new dir();

                //    while (sr.Peek() >= 0)
                //    {
                //        //MessageBox.Show( sr.ReadLine());
                //        string s = sr.ReadLine();

                //        if (s.StartsWith("URL"))
                //            clsShCt.args = s;
                //    }

                //    clsShCt.link = System.IO.Path.GetFileName(f);

                clsDir.appDir = f.Replace("\\", "/"); ;
                al.Add(clsDir);

                //}
            }


            filePaths = Directory.GetDirectories(@"\\DFHLSCASQL01\c$\Cambria Reports Web", "*.*", SearchOption.AllDirectories);

            foreach (string f in filePaths)
            {
                string dir = Path.GetFileName(f);

                if (!dir.StartsWith("_") & !dir.StartsWith("aspnet_") & !f.Contains("bin") & !f.Contains("Application Files") & !f.Contains("aspnet_client")
                    & !f.Contains("Images") & !f.Contains("App_Data") & !f.Contains("Reports Bak"))
                {

                    //using (StreamReader sr = new StreamReader(f))
                    //{
                    dir clsDir = new dir();

                    //    while (sr.Peek() >= 0)
                    //    {
                    //        //MessageBox.Show( sr.ReadLine());
                    //        string s = sr.ReadLine();

                    //        if (s.StartsWith("URL"))
                    //            clsShCt.args = s;
                    //    }

                    //    clsShCt.link = System.IO.Path.GetFileName(f);

                    clsDir.appDir = f.Replace("\\", "/"); ;
                    al.Add(clsDir);

                    //}

                }
            }

            //filePaths = Directory.GetDirectories(@"\\DFHLSCAAPPL08\e$\Cambria Reports", "*.*", SearchOption.AllDirectories);

            //foreach (string f in filePaths)
            //{
            //    string dir = Path.GetFileName(f);

            //    if (!dir.StartsWith("_") & !dir.StartsWith("aspnet_") & !dir.Contains("bin") & !f.Contains("Application Files"))
            //    {
            //        dir clsDir = new dir();

            //        clsDir.appDir = f.Replace("\\", "/"); ;
            //        al.Add(clsDir);

            //    }
            //}

            filePaths = Directory.GetDirectories(@"\\DFHLSCAAPPL08\e$\Cambria Reports Web", "*.*", SearchOption.AllDirectories);

            foreach (string f in filePaths)
            {
                string dir = Path.GetFileName(f);

                if (!dir.StartsWith("_") & !dir.StartsWith("aspnet_") & !dir.Contains("bin") & !f.Contains("Application Files") & !f.Contains("aspnet_client")
                    & !f.Contains("Images") & !f.Contains("App_Data"))
                {
                    dir clsDir = new dir();

                    clsDir.appDir = f.Replace("\\", "/"); ;
                    al.Add(clsDir);

                }
            }

            //filePaths = Directory.GetDirectories(@"\\DFHLSCADEV01\e$\Cambria Reports", "*.*", SearchOption.AllDirectories);

            //foreach (string f in filePaths)
            //{
            //    string dir = Path.GetFileName(f);

            //    if (!dir.StartsWith("_") & !dir.StartsWith("aspnet_") & !dir.Contains("bin") & !f.Contains("Application Files"))
            //    {
            //        dir clsDir = new dir();

            //        clsDir.appDir = f.Replace("\\", "/"); ;
            //        al.Add(clsDir);

            //    }
            //}

            filePaths = Directory.GetDirectories(@"\\DFHLSCADEV01\e$\Cambria Reports Web", "*.*", SearchOption.AllDirectories);

            foreach (string f in filePaths)
            {
                string dir = Path.GetFileName(f);

               if (!dir.StartsWith("_") & !dir.StartsWith("aspnet_") & !dir.Contains("bin") & !f.Contains("Application Files") & !f.Contains("aspnet_client")
                    & !f.Contains("Images") & !f.Contains("App_Data"))
               {
                    dir clsDir = new dir();

                    clsDir.appDir = f.Replace("\\", "/"); ;
                    al.Add(clsDir);

                }
            }

            filePaths = Directory.GetDirectories(@"\\dfhlscaappl07\c$\Inetpub\wwwroot", "*.*", SearchOption.AllDirectories);

            foreach (string f in filePaths)
            {
                string dir = Path.GetFileName(f);

                if (!dir.StartsWith("_") & !f.Contains("aspnet_") & !dir.Contains("bin") & !f.Contains("Application Files") & !f.Contains("AFWeb") & !f.Contains("images"))
                {
                    dir clsDir = new dir();

                    clsDir.appDir = f.Replace("\\", "/"); ;
                    al.Add(clsDir);

                }
            }

            //TODO: e drive of sql?

            return al; // not found
        }





        public class shCt
        {
            public string args { get; set; }
            public string link { get; set; }
        }
        public ArrayList GetShortcuts()
        {
            string[] filePaths = Directory.GetFiles(@"L:\Old Drive\Desktop\Desktop\Reports\", "*.url", SearchOption.TopDirectoryOnly);

            ArrayList al = new ArrayList();

            foreach (string f in filePaths)
            {
                using (StreamReader sr = new StreamReader(f))
                {
                    shCt clsShCt = new shCt();

                    while (sr.Peek() >= 0)
                    {
                        //MessageBox.Show( sr.ReadLine());
                        string s = sr.ReadLine();

                        if (s.StartsWith("URL"))
                            clsShCt.args = s;
                    }

                    clsShCt.link = Path.GetFileName(f);
                    al.Add(clsShCt);

                }
            }

            return al; // not found
        }




        public class tsk
        {
            public string appWorkDir { get; set; }
            public string accName { get; set; }
            public string appName { get; set; }
            public string appTrigger { get; set; }
        }
        public ArrayList GetTasks()
        {
            ArrayList al = new ArrayList();

            ScheduledTasks st = new ScheduledTasks(@"\\DFHLSCASQL01");

            string[] taskNames = st.GetTaskNames();

            foreach (string name in taskNames)
            {
                tsk clsTsk = new tsk();

                Task t = st.OpenTask(name);
                //Console.WriteLine("  " + t.ToString());
                //t.Close();

                clsTsk.appName = System.IO.Path.GetFileName(t.ApplicationName);
                clsTsk.accName = t.AccountName.Replace("\\", "/");
                clsTsk.appWorkDir = t.WorkingDirectory.Replace("\\", "/");
                clsTsk.appTrigger = t.Triggers[0].ToString();

                al.Add(clsTsk);
                t.Close();
            }

            // Dispose the ScheduledTasks object to release COM resources.
            st.Dispose();

            return al; // not found
        }










    }
}
