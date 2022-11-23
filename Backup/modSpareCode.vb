Module modSpareCode


iomDoc.setProperty("owned_by_id", "30B991F927274FA3829655F50C99472E")

Dim EDdocRes As IOM.Item = iomDoc.apply() 

Dim str As String = EDdocRes.getItemByIndex(0).getID()  'Not empty. InnovatorServer modifies Document item and returns the updated one with id attribute populated.

Dim relItm As IOM.Item = inn.newItem("ECN Affected Item", "add")

Dim affItm As IOM.Item = inn.newItem("Affected Item", "add") 

affItm.setProperty("new_item_id", str) 'Setup Superseding Number property. Its name is "new_item_id". It may be found during view/edit "Affected Item" ItemType.

relItm.setRelatedItem(affItm)

iomECN.addRelationship(relItm)

Next 
 
 


''''''''''''''''
'I don't know how iomDoc is generated, but i guess it is an instance of IOM Item class.
'If you see id in the xml of iomDoc, then you may extract id directly from the XmlDocument like

  str = iomDoc.dom.selectSingleNode("xpath_to_the_element").getAttribute("id")

'Another my guess - iomDoc contains a collection of items. Then id may be extracted like

  str = iomDoc.getItemByIndex(some_index_may_be_zero_for_example).getID()

'SamsAn.

'''''''''''''''
'Hi.

'The affected item list may be added in the one query using the parent ECN in a way like below:

Dim iomECN As Item = inn.newItem("ECN", "add")
Dim i As Integer
For i = 0 To affectedItemsList.Count - 1

  Dim relItm As IOM.Item = inn.newItem("ECN Affected Item", "add")

  Dim affItm As IOM.Item = inn.newItem("Affected Item", "add")

  affItm.setProperty("affected_id", str)

  relItm.setRelatedItem(affItm)

  iomECN.addRelationship(relItm)

Next i
iomECN.apply()

''''''''''''

#Region "Inbasket"

        Public Sub InnovatorInBasket()
            LoadConfig() ' connection parameters stored in a XML Config file
            Dim InnovatorPrompt As InnovatorInterface = New InnovatorInterface
            InnovatorPrompt.Username.Text = vUsername
            InnovatorPrompt.Password.Text = vPassword
            InnovatorPrompt.Server.Text = vServer
            InnovatorPrompt.Database.Text = vDatabase
            InnovatorPrompt.Files.Visible = False
            InnovatorPrompt.ShowDialog()
            Me.Close()
            If InnovatorPrompt.DialogResult = Windows.Forms.DialogResult.Cancel Then
                Return
            End If

            ' And here,  we should write the new updated values out to the INI file
            vUsername = InnovatorPrompt.Username.Text
            vPassword = InnovatorPrompt.Password.Text
            vServer = InnovatorPrompt.Server.Text
            vDatabase = InnovatorPrompt.Database.Text
            vFiles = InnovatorPrompt.Files.Checked
            SaveConfig()

            MyConnection = New HttpServerConnection
            MyConnection.innovator_server_url = vServer + "/Server/InnovatorServer.aspx"
            MyConnection.http_username = vUsername
            MyConnection.http_password = ConvertPasswordToMD5(vPassword)
            MyConnection.http_database = vDatabase
            MyInnovator = New Innovator(MyConnection)

            ' run a quick query to get the user's default Vault information
            '  it' a good idea to test the username/password and url 
            ' here,  before we do any other work
            Dim ConnectTest As Item = MyInnovator.newItem("User", "get")
            ConnectTest.setAttribute("select", "default_vault")
            ConnectTest.setProperty("login_name", vUsername)
            Dim ConnectTestResult As Item
            ConnectTestResult = ConnectTest.apply()
            If ConnectTestResult.isError() Then
                MsgBox("Error: " & ConnectTestResult.getErrorDetail(), , "Publish2Innovator")
                MyConnection.Logout()
                Return
            End If

            ' run a  query to Load the InBasket
            Dim InDom As System.Xml.XmlDocument = New System.Xml.XmlDocument
            Dim OutDom As System.Xml.XmlDocument = New System.Xml.XmlDocument
            InDom.LoadXml("<params><inBasketViewMode>Active</inBasketViewMode><workflowTasks>1</workflowTasks><projectTasks>1</projectTasks><actionTasks>1</actionTasks></params>")
            MyConnection.CallAction("getAssignedTasks", InDom, OutDom)
            Xml = OutDom.InnerText

            ' create the dialog.   Windows and VS are providing just the empty form,  we are filling it
            ' with TB, grid, fields etc dynamically.
            InBasketDialog = New InnovatorInBasket

            TB = New Aras.Client.Controls.Toolbar
            TB.Location = New Point(0, 0)
            TB.Width = InBasketDialog.DisplayRectangle.Size.Width - 5
            TB.Height = 30
            InBasketDialog.Controls.Add(TB)

            Grid = New Aras.Client.Controls.GridContainer
            Grid.Location = New Point(0, 30)
            Grid.Height = InBasketDialog.DisplayRectangle.Size.Height - 30
            Grid.Width = InBasketDialog.DisplayRectangle.Size.Width - 5

            InBasketDialog.Controls.Add(Grid)

            AddHandler TB.Load, AddressOf TBStart
            AddHandler TB.ButtonClick, AddressOf TBClick
            AddHandler Grid.GridStart, AddressOf GridStart
            AddHandler Grid.GridDoubleClick, AddressOf GridDoubleClick
            AddHandler InBasketDialog.Resize, AddressOf ResizeControls
            InBasketDialog.ShowDialog()

        End Sub




#End Region


'''''''''''''''
  'Dim mydwf As String : Dim i As Short
                'Dim iomDoc As IOM.Item
                'For i = 0 To File2.Items.Count - 1
                'iomDoc = addDocToInnovator(mydwf)
                'mydwf = FolderName & "\" & File2.Items(i)
                ''FileCopy(mydwf, transmittalFldr & "\" & File2.Items(i))
                'addFilesToInnovator(FolderName, File2.Items(i), iomDoc)
                'iomDoc.setProperty("name", "The Name")
                'iomDoc.setProperty("description", "The Desc")
                'Dim EDdocRes As IOM.Item = iomDoc.apply()
                'If EDdocRes.isError Then Console.WriteLine(EDdocRes.getErrorDetail)
                'Next i

                ' transmittal
                ' If chkbxAddCadFiles.Checked Then
                'File3.Path = transmittalFldr : File3.Refresh()
                'Dim iomDoc2 As IOM.Item = addDocToInnovator("DRN-" & drnID & "-Cad Files")
                '' Check if These Files Exist or will have duplicates.
                'Dim myFile As String : Dim cnt As Short
                'For cnt = 0 To File3.Items.Count - 1
                'myFile = transmittalFldr & "\" & File3.Items(cnt)
                'addFilesToInnovator(transmittalFldr & "\", File3.Items(cnt), iomDoc2)
                'Next cnt
                'iomDoc2.setProperty("name", "The Name")
                'iomDoc2.setProperty("description", "The Desc")
                'Dim EDdocRes2 As IOM.Item = iomDoc2.apply()
                'If EDdocRes2.isError Then Console.WriteLine(EDdocRes2.getErrorDetail)
                'End If

                conn.Logout()
                '
                'Dim cnt2 As Integer
                'For cnt2 = 0 To File3.Items.Count - 1
                '    Kill(transmittalFldr & "\" & File3.Items(cnt2))
                'Next cnt2


''''''''''''''''''''

#Region "releaseFilesToInnovator"

        Private Sub btnTransmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransmit.Click
            If Not dvE044DRN Is Nothing Then
                Dim transInfo2 As TransmittalInfo2 : Dim transOper2 As New TransmittalOperation2
                transInfo2 = transOper2.getTransmittalInfoInterface()
                transInfo2.destinationRoot = transmittalFldr
                'transInfo2.organizedFolder = True
                'transInfo2.relativePath = True
                'transInfo2.preserveSubdirs = True
                transInfo2.plotConfigFilePath = "C:\Gary\Plotters"
                transInfo2.plotStyleTablePath = "C:\Gary\Plot Styles"

                Dim transFile As TransmittalFile2 : Dim addFilRetVal As AddFileReturnVal : Dim fil As String
                For Each fil In OpenFileNames
                    addFilRetVal = transOper2.addDrawingFile(fil, transFile)
                Next

                Dim transGraphIntface As TransmittalFilesGraph2
                transGraphIntface = transOper2.getTransmittalGraphInterface()
                Dim transReport As String = transOper2.getTransmittalReport()
                CreateTextFile(transmittalFldr & "\Report.txt", transReport)
                transOper2.createTransmittalPackage()
                mkDrnTransReport()

                '
                ConnToInnovator()

                ' dwfs
                Dim iomDoc As IOM.Item = addDocToInnovator("DRN-" & drnID & "-Doc Files")
                ' Check if These Files Exist or will have duplicates.
                Dim mydwf As String : Dim i As Short
                For i = 0 To File2.Items.Count - 1
                    mydwf = FolderName & "\" & File2.Items(i)
                    'FileCopy(mydwf, transmittalFldr & "\" & File2.Items(i))
                    addFilesToInnovator(FolderName, File2.Items(i), iomDoc)
                Next i
                iomDoc.setProperty("name", "The Name")
                iomDoc.setProperty("description", "The Desc")
                Dim EDdocRes As IOM.Item = iomDoc.apply()
                If EDdocRes.isError Then Console.WriteLine(EDdocRes.getErrorDetail)

                ' transmittal
                If chkbxAddCadFiles.Checked Then
                    File3.Path = transmittalFldr : File3.Refresh()
                    Dim iomDoc2 As IOM.Item = addDocToInnovator("DRN-" & drnID & "-Cad Files")
                    ' Check if These Files Exist or will have duplicates.
                    Dim myFile As String : Dim cnt As Short
                    For cnt = 0 To File3.Items.Count - 1
                        myFile = transmittalFldr & "\" & File3.Items(cnt)
                        addFilesToInnovator(transmittalFldr & "\", File3.Items(cnt), iomDoc2)
                    Next cnt
                    iomDoc2.setProperty("name", "The Name")
                    iomDoc2.setProperty("description", "The Desc")
                    Dim EDdocRes2 As IOM.Item = iomDoc2.apply()
                    If EDdocRes2.isError Then Console.WriteLine(EDdocRes.getErrorDetail)
                End If

                conn.Logout()
                '
                Dim cnt2 As Integer
                For cnt2 = 0 To File3.Items.Count - 1
                    Kill(transmittalFldr & "\" & File3.Items(cnt2))
                Next cnt2

            Else
                MessageBox.Show("Select A Document Release Notice.")
            End If
        End Sub

        Public Function addDocToInnovator(ByVal itmNum As String) As IOM.Item

            Dim docItm As IOM.Item = inn.newItem("Document", "add")
            docItm.setProperty("item_number", itmNum)

            Dim docRes As IOM.Item = docItm.apply()
            If docRes.isError Then Console.WriteLine(docRes.getErrorDetail)

            Dim EDdocItm As IOM.Item = inn.newItem("Document", "edit")
            EDdocItm.setAttribute("where", "[DOCUMENT].ITEM_NUMBER='" & itmNum & "' and [DOCUMENT].IS_CURRENT='1'")

            Return EDdocItm

        End Function

        Public Sub addFilesToInnovator(ByVal fldrName As String, ByVal filName As String, ByVal docItm As IOM.Item)

            Dim fileItm As IOM.Item = inn.newItem("File", "add")
            Dim fileLocatedRel As IOM.Item = inn.newItem("Located", "add")

            fileItm.setProperty("filename", filName)
            fileItm.setProperty("actual_filename", FolderName & "\" & filName)
            fileItm.setProperty("checkedout_path", FolderName)
            fileItm.attachPhysicalFile(FolderName & "\" & filName, vDefaultVault)
            Dim Res As IOM.Item = fileItm.apply()
            If Res.isError Then Console.WriteLine(Res.getErrorDetail)

            Dim fileItm2 As IOM.Item = inn.getItemByKeyedName("File", filName)
            Dim relItm As IOM.Item = inn.newItem("Document File", "add")
            relItm.setRelatedItem(fileItm2)

            docItm.addRelationship(relItm)

        End Sub

        Dim vDefaultVault As String
        Dim conn As IOM.HttpServerConnection
        Dim inn As IOM.Innovator

        Public Sub ConnToInnovator()
            conn = New IOM.HttpServerConnection
            conn.innovator_server_url = "http://10.12.19.57/InnovatorServer/Server/InnovatorServer.aspx"
            conn.http_username = "admin"
            conn.http_password = IOM.Innovator.ScalcMD5("innovator")
            conn.http_database = "InnovatorSolutions"

            inn = New IOM.Innovator(conn)

            Dim ConnectTest As IOM.Item = inn.newItem("User", "get")
            ConnectTest.setAttribute("select", "default_vault")
            ConnectTest.setProperty("login_name", "admin")
            Dim ConnectTestResult As IOM.Item
            ConnectTestResult = ConnectTest.apply()
            If ConnectTestResult.isError() Then
                MsgBox("Error: " & ConnectTestResult.getErrorDetail(), , "Publish2Innovator")
                conn.Logout()
                Return
            End If
            vDefaultVault = ConnectTestResult.getProperty("default_vault")
        End Sub

        Public Sub CreateTextFile(ByVal FileName As String, ByVal TextToAdd As String)
            Dim file As New System.IO.StreamWriter(FileName)
            file.Write(TextToAdd) : file.Close()
        End Sub

#End Region


''''''''''''''''''''

'select row with right click
 Private miHitRow As Integer

   Private Sub dbgEquipment_MouseUp(ByVal sender As Object, _
     ByVal e As System.Windows.Forms.MouseEventArgs) _
     Handles dbgEquipment.MouseUp

      If e.Button = MouseButtons.Right Then
         If hti.Type = DataGrid.HitTestType.RowHeader Then
            miHitRow = SelectCkBoxRow(Me.dbgEquipment, e)
         End If
      End If
   End Sub
 

'This function determines the clicked row from the x and y points in the DataGrid where the mouse was clicked.  It creates a Point object and uses it to determine the hit row using the DataGrid.HitTestInfo object.  It then uses the derived row to select the clicked row.

   Public Overloads Function SelectCkBoxRow(ByRef dbg As DataGrid, _
      ByVal e As System.Windows.Forms.MouseEventArgs) As Integer
      Dim retval As Integer

      Try
         Dim pt = New Point(e.X, e.Y)
         Dim hti As DataGrid.HitTestInfo = dbg.HitTest(pt)

         dbg.Select(hti.Row)
         Return hti.Row
      Catch ex As System.Exception
      End Try
   End Function
 





'''''''''''''''''''''

'''''''

Dim pntCenter As Point2d = vwPort.ViewCenter()
Dim pntWindow1 As New Point3d(pntCenter.X - vwPort.Width / 2, pntCenter.Y - vwPort.Height / 2, 0)
Dim pntWindow2 As New Point3d(pntCenter.X + vwPort.Width / 2, pntCenter.Y + vwPort.Height / 2, 0)

Dim Command As Editor = acadApp.DocumentManager.MdiActiveDocument.Editor
Dim presSelection As PromptSelectionResult

presSelection = Command.SelectCrossingWindow(pntWindow1, pntWindow2)



'''''''''''
/// 
/// Inserts an external drawing with or without attributes as a 
block into the current drawing.
/// Redefines current block if it already exists.
/// 
/// null-terminated string that specifies 
the name [of] the input file.
///boolean, if true inserts into current 
paperspace, otherwise inserts into modelspace.
///3Dpoint object, insertion point for 
block.
public static void insertBlock(string fileName, bool PaperSpace, 
Point3d location)
{
Document doc = Application.DocumentManager.MdiActiveDocument;
// If file doesnt exist, bail
if (!File.Exists(fileName))
return;
// Create a block definition name
//the block def name will be same as file name minus path & 
extension
string insert = fileName;
//remove path
int pos = 0;
pos = insert.LastIndexOf("\\");
insert = insert.Remove(0, pos + 1);
//remove extension
int len;
len = insert.Length;
if (insert.ToUpper().Contains(".DWG"))
insert = insert.Remove(len - 4, 4);

[using] (Database db = new Database(false, false))
{
// Read the external drawing file into our temporary 
database
db.ReadDwgFile(fileName, FileShare.Read, true, null);
[using] (Transaction t = 
doc.TransactionManager.StartTransaction())
{
//get the block table
BlockTable bt = 
(BlockTable)t.GetObject(doc.Database.BlockTableId, OpenMode.ForWrite);
//get the (x)space table record
BlockTableRecord btr;
if (PaperSpace)
btr = 
(BlockTableRecord)t.GetObject(bt[BlockTableRecord.PaperSpace], 
OpenMode.ForWrite);
else
btr = 
(BlockTableRecord)t.GetObject(bt[BlockTableRecord.ModelSpace], 
OpenMode.ForWrite);
//if the block already exists in the database, redefine 
the definition
//and update all the references
if (bt.Has(insert))
{
ObjectId idBTR = doc.Database.Insert(insert, db, 
true);
foreach (ObjectId objId in btr)
{
// For each object in the block table record, 
cast it to a block reference
DBObject dbObj = t.GetObject(objId, 
OpenMode.ForWrite);
BlockReference blkRef = dbObj as 
BlockReference;
string blkName = "";
if (blkRef != null)
{
// If it is a block reference, first check 
its name to see if its the one we want
BlockTableRecord blkDef = 
(BlockTableRecord)t.GetObject(blkRef.BlockTableRecord, OpenMode.ForWrite);
blkName = blkDef.Name.ToString();
if (blkName == insert)
{
blkRef.RecordGraphicsModified(true); 
// As per Bobby Jones
//when openmode above was "read" the 
RecordGraphicsModified didnt work
}
}
}
}
// Else, create a new definition and insert a new 
reference.
else
{
ObjectId idBTR = doc.Database.Insert(insert, db, 
true);
// Now create a new block reference
BlockReference bref = new BlockReference(location, 
idBTR);
//Add the block reference to the model space
btr.AppendEntity(bref);
//let the transaction know
t.TransactionManager.AddNewlyCreatedDBObject(bref, 
true);
//copy attributes from defintion to reference
Entity ent;
BlockTableRecord newbtr = 
(BlockTableRecord)t.GetObject(idBTR, OpenMode.ForWrite);
foreach (ObjectId id in newbtr)
{
ent = (Entity)t.GetObject(id, 
OpenMode.ForWrite);
if (ent is AttributeDefinition)
{
AttributeDefinition attDef = new 
AttributeDefinition();
AttributeReference attRef = new 
AttributeReference();
attDef = (AttributeDefinition)ent;
attRef.SetAttributeFromBlock(attDef, 
bref.BlockTransform);
bref.AttributeCollection.AppendAttribute(attRef);
t.TransactionManager.AddNewlyCreatedDBObject(attRef, 
true);
}
}
}
t.Commit();
}//end [using] transaction t
}//end [using] database
} 




'''''''''''plot example from book
AcPlPlotEngine* pEngine = NULL;
if(Acad::eOk==AcPlPlotFactory::createPublishEngine(pEngine))
{
    // Here is the progress dialog for the current plot process...
    AcPlPlotProgressDialog *pPlotProgDlg=acplCreatePlotProgressDialog(acedGetAcadFrame().m_hWnd,false,1);

    pPlotProgDlg.setPlotMsgString(AcPlPlotProgressDialog::PlotMSGIndex::kDialogTitle, "Plot API Progress");
    pPlotProgDlg.setPlotMsgString(AcPlPlotProgressDialog::PlotMSGIndex::kCancelJobBtnMsg, "Cancel Job");
    pPlotProgDlg.setPlotMsgString(AcPlPlotProgressDialog::PlotMSGIndex::kCancelSheetBtnMsg, "Cancel Sheet");
    pPlotProgDlg.setPlotMsgString(AcPlPlotProgressDialog::PlotMSGIndex::kSheetSetProgressCaption, "Job Progress");
    pPlotProgDlg.setPlotMsgString(AcPlPlotProgressDialog::PlotMSGIndex::kSheetProgressCaption, "Sheet Progress");

    pPlotProgDlg.setPlotProgressRange(0,100);
    pPlotProgDlg.onBeginPlot();
    pPlotProgDlg.setIsVisible(true);

    es = pEngine.beginPlot(pPlotProgDlg);

    AcPlPlotPageInfo pageInfo;
    // Used to describe how the plot is to be made.
    AcPlPlotInfo plotInfo; 

    // First, set the layout to the specified layout 
    // (which is the current layout in this sample).
    plotInfo.setLayout(layoutId);// This is required.

    // Now, override the layout settings with the plot settings 
    // we have been populating.
    plotInfo.setOverrideSettings(pPlotSettings);

    // We need to validate these settings.
    AcPlPlotInfoValidator validator;
    validator.setMediaMatchingPolicy(AcPlPlotInfoValidator::MatchingPolicy::kMatchEnabled);
    es = validator.validate(plotInfo);

    // Begin document.  The version we call is dependent 
    // on the plot-to-file status.
    const char *szDocName=acDocManager.curDocument().fileName();
    if(m_bPlotToFile)
        es = pEngine.beginDocument(plotInfo, szDocName, NULL, 1, true, m_csFilename);
    else
        es = pEngine.beginDocument(plotInfo, szDocName);

    // Follow through sending commands to the engine, 
    // and notifications to the progress dialog.
    pPlotProgDlg.onBeginSheet();
    pPlotProgDlg.setSheetProgressRange(0, 100);
    pPlotProgDlg.setSheetProgressPos(0);

    es = pEngine.beginPage(pageInfo, plotInfo, true);    	

    es = pEngine.beginGenerateGraphics();
    es = pEngine.endGenerateGraphics();

    es = pEngine.endPage();

    pPlotProgDlg.setSheetProgressPos(100);
    pPlotProgDlg.onEndSheet();
    pPlotProgDlg.setPlotProgressPos(100);
    es = pEngine.endDocument();
    es = pEngine.endPlot();

    // Destroy the engine 
    pEngine.destroy();
    pEngine = NULL;
    // and the progress dialog.
    pPlotProgDlg.destroy();

else
    // Ensure the engine is not already busy...
    AfxMessageBox("Plot Engine is Busy...");
}


''''''''''''''''


'' new plot example

public void test() {
MessageBox.Show("Starting Plot");
String ConfigInfoName = "";
foreach (Autodesk.AutoCAD.PlottingServices.PlotConfigInfo inf in Autodesk.AutoCAD.PlottingServices.PlotConfigManager.Devices)
{
if (inf.DeviceName.Equals("DWG To PDF.pc3"))
{
MessageBox.Show("found the right device");
ConfigInfoName = inf.DeviceName;

}

}
Autodesk.AutoCAD.PlottingServices.PlotConfig pConfig = Autodesk.AutoCAD.PlottingServices.PlotConfigManager.SetCurrentConfig(ConfigInfoName);


Autodesk.AutoCAD.PlottingServices.PlotInfo pInfo = new Autodesk.AutoCAD.PlottingServices.PlotInfo();
Autodesk.AutoCAD.DatabaseServices.LayoutManager lMan = Autodesk.AutoCAD.DatabaseServices.LayoutManager.Current;
pInfo.Layout = lMan.GetLayoutId(lMan.CurrentLayout); 
pInfo.DeviceOverride = pConfig;

Autodesk.AutoCAD.DatabaseServices.PlotSettings pSettings = new Autodesk.AutoCAD.DatabaseServices.PlotSettings(true);
Autodesk.AutoCAD.DatabaseServices.PlotSettingsValidator pSValidator = Autodesk.AutoCAD.DatabaseServices.PlotSettingsValidator.Current;

Autodesk.AutoCAD.PlottingServices.PlotInfoValidator validator = new Autodesk.AutoCAD.PlottingServices.PlotInfoValidator(); 
validator.Validate(pInfo);
Autodesk.AutoCAD.PlottingServices.PlotProgressDialog pProgDialog = new Autodesk.AutoCAD.PlottingServices.PlotProgressDialog(false,1,true);
pProgDialog.set_PlotMsgString(Autodesk.AutoCAD.PlottingServices.PlotMessageIndex.DialogTitle,"Plotting...");
pProgDialog.set_PlotMsgString(Autodesk.AutoCAD.PlottingServices.PlotMessageIndex.CancelJobButtonMessage,"Cancel Plot");
pProgDialog.set_PlotMsgString(Autodesk.AutoCAD.PlottingServices.PlotMessageIndex.CancelSheetButtonMessage,"Cancel Sheet");
pProgDialog.set_PlotMsgString(Autodesk.AutoCAD.PlottingServices.PlotMessageIndex.SheetSetProgressCaption,"Plot Progree");
pProgDialog.set_PlotMsgString(Autodesk.AutoCAD.PlottingServices.PlotMessageIndex.SheetProgressCaption,"Sheet Progress");
pProgDialog.LowerPlotProgressRange = 0;
pProgDialog.UpperPlotProgressRange = 100;
//pProgDialog.OnBeginPlot();
pProgDialog.IsVisible = true;
Autodesk.AutoCAD.PlottingServices.PlotPageInfo pPInfo = new Autodesk.AutoCAD.PlottingServices.PlotPageInfo();

Object parms = null;
Autodesk.AutoCAD.PlottingServices.PlotEngine pEngine = Autodesk.AutoCAD.PlottingServices.PlotFactory.CreatePublishEngine();
pEngine.BeginPlot(pProgDialog,parms);
pEngine.BeginDocument(pInfo, "c:\\house7.dwg", parms, 1, true, "c:\\Mike_out.pdf");
pEngine.BeginPage(pPInfo, pInfo, true, parms);
pEngine.BeginGenerateGraphics(parms);
pEngine.EndGenerateGraphics(parms);
pEngine.EndPage(parms);
pEngine.EndDocument(parms);
pEngine.EndPlot(parms);
pEngine.Destroy();
pEngine = null;
pProgDialog.Destroy();   

 


''''''''''''''''''''''''''''''

'In any browser (for example: Internet Explorer) type: ms-help://MS.VSCC.v80/dv_vscccommon/local/CollectionManager.htm
'Select ObjectARX Reference For .NET and Update VSCC 
 

 


'''''''''''''''''''''''''''''''''''' batch plotting that does not work
       ''''''''''''''''


        Public Sub CurrLayoutDWF() ' will not do model tab
            BatchDWF()
        End Sub ' does not work ????????

        Public Sub BatchDWF()
            Try
                _cancel = False
                maximizeDrawingWindow()
                sourceDir()
                exportDir()
                incModelSpace()
                layoutInfo()
                _pubInfo.incLayers = reqYesNo(PROMPT_INC_LAYERS)
                _pubInfo.incPlotStamp = reqYesNo(PROMPT_INC_PLOTSTAMP)
                beginLogFile()
                turnOffBackgroundPublish()
                publishAllFilesRecurse(_pubInfo.inputDir)
                restoreBackgroundPublish()
                endLogFile()
            Catch _ex As System.Exception
                _ed.WriteMessage("" & Microsoft.VisualBasic.Chr(10) & "Error occured: " & Microsoft.VisualBasic.Chr(10) & "" + _ex.ToString)
            End Try
        End Sub

        Private Sub publishAllFilesRecurse(ByVal _sourceDir As String)
            If _cancel Then
                Return
            End If
            Try
                Dim mainDir As DirectoryInfo = New DirectoryInfo(_sourceDir)
                For Each fi As System.IO.FileInfo In mainDir.GetFiles(_pubInfo.filePattern)
                    _fileInfo.dwgFile = fi.FullName
                    _fileInfo.fileNameWithoutExtention = Path.GetFileNameWithoutExtension(_fileInfo.dwgFile)
                    publishFile()
                Next
                If _pubInfo.incSubDirs Then
                    Dim items As FileSystemInfo() = mainDir.GetFileSystemInfos
                    For Each item As FileSystemInfo In items
                        If TypeOf item Is DirectoryInfo Then
                            publishAllFilesRecurse(CType(item, DirectoryInfo).FullName)
                        End If
                    Next
                End If
            Catch _ex As System.Exception
                Throw _ex
            End Try
        End Sub

        Private Sub publishFile()
            If _cancel Then
                Return
            End If
            Try
                setDefaults()
                logEntry(DateTime.Now.ToString + " File: " + _fileInfo.dwgFile + "" & Microsoft.VisualBasic.Chr(10) & "")
                createDSD()
                publish()
                If _deleteDSD Then
                    cleanup()
                End If
            Catch _ex As System.Exception
                Select Case _ex.Message
                    Case "eBadDwgHeader", "eDwgObjectImproperlyRead"
                        logEntry(E_MSG_FILEREADERROR)
                        ' break 
                    Case "eUnsupportedFileFormat"
                        logEntry(E_MSG_UNSUPPORTEDFILE)
                        ' break 
                    Case "eDwgNeedsRecovery"
                        logEntry(E_MSG_FILE_NEEDS_RECOVERY)
                        ' break 
                    Case "eSecErrorDecryptingData"
                        logEntry(E_MSG_PWD)
                        ' break 
                    Case Else
                        logEntry(E_MSG_GENERIC)
                        logEntry(" " + _ex.ToString + "" & Microsoft.VisualBasic.Chr(10) & "" & Microsoft.VisualBasic.Chr(10) & "")
                        ' break 
                End Select
                _fileInfo.publish = False
                cleanup()
            End Try
        End Sub

        Private Sub incModelSpace()
            If _cancel Then
                Return
            End If
            Dim _dwgExists As Boolean = False
            Try
                _pubInfo.incModelSpace = reqYesNo(PROMPT_INCMS)
                If _pubInfo.incModelSpace Then
                    If reqYesNo(PROMPT_MSPAGE_SETUP) Then
                        Do
                            _pubInfo.modelPageSetupDWG = reqPageSetupInfo(PROMPT_PAGE_SETUP_DWG)
                            If File.Exists(_pubInfo.modelPageSetupDWG) Then
                                _dwgExists = True
                            Else
                                _ed.WriteMessage(E_MSG_FILENOTFOUND)
                            End If
                        Loop While Not _dwgExists
                        _pubInfo.modelPageSetupName = reqPageSetupInfo(PROMPT_PAGE_SETUP_NAME)
                    End If
                    _pubInfo.pubModelAs3D = reqYesNo(PROMPT_MS3D)
                End If
            Catch _ex As System.Exception
                Throw _ex
            End Try
        End Sub

        Private Sub layoutInfo()
            If _cancel Then
                Return
            End If
            Dim _dwgExists As Boolean = False
            If reqYesNo(PROMPT_PSPAGE_SETUP) Then
                Do
                    _pubInfo.layoutPageSetupDWG = reqPageSetupInfo(PROMPT_PAGE_SETUP_DWG)
                    If File.Exists(_pubInfo.layoutPageSetupDWG) Then
                        _dwgExists = True
                    Else
                        _ed.WriteMessage(E_MSG_FILENOTFOUND)
                    End If
                Loop While Not _dwgExists
                _pubInfo.layoutPageSetupName = reqPageSetupInfo(PROMPT_PAGE_SETUP_NAME)
            End If
        End Sub

        Private Sub exportDir()
            If _cancel Then
                Return
            End If
            Dim _prStr As PromptStringOptions = New PromptStringOptions(PROMPT_OUTDIR)
            Dim _prRes As PromptResult
            Dim dirExists As Boolean
            Try
                Do
                    dirExists = True
                    _prRes = _ed.GetString(_prStr)
                    If _prRes.Status = PromptStatus.Cancel Then
                        _cancel = True
                        Return
                    End If
                    _pubInfo.outputDir = _prRes.StringResult.ToString
                    If Not (_pubInfo.outputDir.Substring(_pubInfo.outputDir.Length - 1, 1) = "\") Then
                        _pubInfo.outputDir = _pubInfo.outputDir + "\"
                    End If
                    _pubInfo.logFile = _pubInfo.outputDir + FN_LOGFILE
                    If Not Directory.Exists(_pubInfo.outputDir) Then
                        _ed.WriteMessage(E_MSG_NODIRFOUND)
                        dirExists = False
                    End If
                Loop While Not dirExists
            Catch _ex As System.Exception
                Throw _ex
            End Try
        End Sub

        Private Sub sourceDir()
            If _cancel Then
                Return
            End If
            Dim _prStr As PromptStringOptions = New PromptStringOptions(PROMPT_SOURCEDIR)
            Dim _prRes As PromptResult
            Dim dirExists As Boolean
            Try
                Do
                    dirExists = True
                    _prRes = _ed.GetString(_prStr)
                    If _prRes.Status = PromptStatus.Cancel Then
                        _cancel = True
                        Return
                    End If
                    _pubInfo.inputDir = _prRes.StringResult.ToString
                    If Not (_pubInfo.inputDir.Substring(_pubInfo.inputDir.Length - 1, 1) = "\") Then
                        _pubInfo.inputDir = _pubInfo.inputDir + "\"
                    End If
                    If Not Directory.Exists(_pubInfo.inputDir) Then
                        _ed.WriteMessage(E_MSG_NODIRFOUND)
                        dirExists = False
                    Else
                        reqFilePattern()
                        _pubInfo.incSubDirs = reqYesNo(PROMPT_SUBDIR)
                    End If
                Loop While Not dirExists
            Catch _ex As System.Exception
                Throw _ex
            End Try
        End Sub

        Private Sub publish_old()
            Dim doc As Document = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument
            Try : Dim name As String = Replace(_fileInfo.dsdFileName, "\", "/")

                doc.SendStringToExecute("(command " & Chr(34) & "-publish" & Chr(34) & " " & Chr(34) & name & Chr(34) & ")" & vbCr, True, False, True)

                'doc.SendStringToExecute("-publish" & Chr(34) & " " & Chr(34) & name & Chr(34) & ")" & vbCr, False, False, True)

                ' Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument = doc

            Catch ex As Exception
                MessageBox.Show(ex.ToString)
                Throw (ex)
            End Try

        End Sub

        Private Sub publish()
            Try
                If _fileInfo.publish Then
                    logEntry(LF_NSEC + _fileInfo.numOfSections + "" & Microsoft.VisualBasic.Chr(10) & "")
                    Dim _publisher As New Publisher
                    _publisher = Autodesk.AutoCAD.ApplicationServices.Application.Publisher

                    Dim _plotDlog As PlotProgressDialog = New Autodesk.AutoCAD.PlottingServices.PlotProgressDialog(True, _fileInfo.numOfSections, True)




                    ' this does not work
                    _publisher.PublishDsd(_fileInfo.dsdFileName, _plotDlog)

                    Dim eBpsea As BeginPublishingSheetEventArgs
                    _publisher.FireBeginPublishingSheet(eBpsea)

                    Dim ePsea As PublishSheetEventArgs
                    _publisher.FireBeginSheet(ePsea)

                    Dim ePeea As PublishEntityEventArgs
                    _publisher.FireBeginEntity(ePeea)

                    Dim Fee As Autodesk.AutoCAD.Publishing.PublishEntityEventArgs
                    _publisher.FireEndEntity(Fee)

                    Dim Psea As PublishSheetEventArgs
                    _publisher.FireEndSheet(Psea)


                    ' _publisher.FireEndPublish()





                    _plotDlog.Destroy()
                Else
                    logEntry(LF_NO_SEC_FOUND)
                End If
            Catch _ex As System.Exception
                Throw _ex
            End Try
        End Sub

        Private Sub createDSD()
            Dim _dsd As DsdData = New DsdData
            Try
                Dim _dsdEntCol As DsdEntryCollection = New DsdEntryCollection
                _dsdEntCol = createDsdEntryCollection()
                If _dsdEntCol.Count <= 0 Then
                    _fileInfo.publish = False
                    Return
                End If
                _fileInfo.numOfSections = _dsdEntCol.Count
                _fileInfo.publish = True

                '_dsd.SetDsdEntryCollection(sortDSDCollection(_dsdEntCol))
                _dsd.SetDsdEntryCollection(_dsdEntCol)

                _dsd.SetUnrecognizedData("PwdProtectPublishedDWF", "FALSE")
                _dsd.SetUnrecognizedData("PromptForPwd", "FALSE")
                _dsd.SheetType = SheetType.MultiDwf
                _dsd.NoOfCopies = 1
                If _pubInfo.incPlotStamp Then
                    _dsd.PlotStampOn = True
                Else
                    _dsd.PlotStampOn = False
                End If
                'not a member   _dsd.Dwf3dOptions.GroupByXrefHierarchy = False
                'not a member   _dsd.Dwf3dOptions.PublishWithMaterials = True
                _dsd.DestinationName = _fileInfo.dwfFile
                _dsd.IsHomogeneous = False
                _dsd.LogFilePath = _pubInfo.outputDir + FN_PUBLOG
                _fileInfo.dsdFileName = Path.ChangeExtension(Path.GetFullPath(_fileInfo.dwfFile), ".dsd")
                postProcessDSD(_dsd)
                _dsd.Dispose()
                _dsdEntCol.Dispose()
            Catch _ex As System.Exception
                _dsd.Dispose()
                Throw _ex
            End Try
        End Sub

        Private Function createDsdEntryCollection() As DsdEntryCollection
            Dim _db As Database = New Database
            Dim _dsdEntCol As DsdEntryCollection = New DsdEntryCollection
            Dim _dsdEntry As DsdEntry = New DsdEntry
            Dim _pt2d As Point2d = New Point2d(0, 0)
            ' Using 
            Dim _tr As Transaction = _db.TransactionManager.StartTransaction
            Try
                Dim _layoutMgr As LayoutManager = LayoutManager.Current
                Dim _layoutObj As Layout
                Dim _layoutDict As DBDictionary
                Try
                    _db.ReadDwgFile(_fileInfo.dwgFile, System.IO.FileShare.Read, False, "")
                    ' Using 
                    _layoutDict = CType(_tr.GetObject(_db.LayoutDictionaryId, OpenMode.ForRead), DBDictionary)
                    Try
                        For Each _layoutEntry As DictionaryEntry In _layoutDict
                            ' Using 
                            _layoutObj = CType(_tr.GetObject(CType((_layoutEntry.Value), ObjectId), OpenMode.ForRead), Layout)
                            Try
                                'If Not _layoutObj.PlotPaperSize.IsEqualTo(_pt2d) Then
                                If Not _layoutObj.PlotPaperSize.X = _pt2d.X Then 'And _layoutObj.PlotPaperSize.Y = _pt2d.Y Then
                                    _dsdEntry.DwgName = _fileInfo.dwgFile
                                    If _layoutObj.ModelType AndAlso _pubInfo.incModelSpace Then

                                        ' Using 
                                        ' Dim vsTr As Transaction = _db.TransactionManager.StartTransaction
                                        ' Try
                                        ' Try
                                        'Dim vsDictId As ObjectId = _db.VisualStyleDictionaryId
                                        '  Dim vsDict As DBDictionary = CType(vsTr.GetObject(vsDictId, OpenMode.ForRead), DBDictionary)
                                        '  _fileInfo.pubMod3D = False
                                        '  For Each entry As DictionaryEntry In vsDict
                                        'Dim vs As DBVisualStyle = CType(vsTr.GetObject(CType(entry.Value, ObjectId), OpenMode.ForRead), DBVisualStyle)
                                        'If (vs.Description = "Transparent" OrElse vs.Description = "*") AndAlso _pubInfo.pubModelAs3D Then
                                        '_fileInfo.pubMod3D = True
                                        'End If
                                        'Next
                                        'vsTr.Abort()
                                        'vsTr.Dispose()
                                        'vsDict.Dispose()
                                        'Catch _ex As System.Exception
                                        '   vsTr.Abort()
                                        '  vsTr.Dispose()
                                        ' Throw _ex
                                        'Finally
                                        '   If Not vsTr.IsDisposed Then
                                        '  vsTr.Abort()
                                        '  vsTr.Dispose()
                                        'End If
                                        '   End Try
                                        '  Finally
                                        '     CType(vsTr, IDisposable).Dispose()
                                        '    End Try


                                        _dsdEntry.Layout = _layoutObj.LayoutName.ToString
                                        _dsdEntry.Title = _fileInfo.fileNameWithoutExtention + "-" + _layoutObj.LayoutName.ToString
                                        _dsdEntry.Nps = _layoutObj.TabOrder.ToString
                                        _dsdEntCol.Add(_dsdEntry)
                                        logEntry(LF_LAYOUT_ADDED + _layoutObj.LayoutName.ToString + "" & Microsoft.VisualBasic.Chr(10) & "")
                                    Else
                                        _dsdEntry.Layout = _layoutObj.LayoutName.ToString
                                        _dsdEntry.Title = _fileInfo.fileNameWithoutExtention + "-" + _layoutObj.LayoutName.ToString
                                        _dsdEntry.Nps = _layoutObj.TabOrder.ToString
                                        _dsdEntCol.Add(_dsdEntry)
                                        logEntry(LF_LAYOUT_ADDED + _layoutObj.LayoutName.ToString + "" & Microsoft.VisualBasic.Chr(10) & "")
                                    End If
                                Else
                                    logEntry(LF_LAYOUT_NOT_INIT + _layoutObj.LayoutName.ToString + "" & Microsoft.VisualBasic.Chr(10) & "")
                                End If
                            Finally
                                ' could not find variable declaration 
                                ' TODO : Dispose object 
                            End Try
                        Next
                    Finally
                        ' could not find variable declaration 
                        ' TODO : Dispose object 
                    End Try
                    _tr.Abort()
                    _tr.Dispose()
                    _db.Dispose()
                Catch _ex As System.Exception
                    _tr.Abort()
                    _tr.Dispose()
                    _db.Dispose()
                    Throw _ex
                Finally
                    If Not _tr.IsDisposed Then
                        _tr.Abort()
                        _tr.Dispose()
                        _db.Dispose()
                    End If
                End Try
            Finally
                CType(_tr, IDisposable).Dispose()
            End Try
            Return _dsdEntCol
        End Function

        Private Function sortDSDCollection(ByVal _dsdEntCol As DsdEntryCollection) As DsdEntryCollection
            Dim _sortedCol As DsdEntryCollection = New DsdEntryCollection
            Dim _iUnsortedEnt As Integer
            Dim _iSortedEnt As Integer
            Dim _iCount As Integer
            Dim _unSorted As Boolean = True
            If _dsdEntCol.Count = 0 Then
                Return _dsdEntCol
            End If
            While _unSorted
                For Each _UnsortedEntry As DsdEntry In _dsdEntCol
                    _iCount = -1
                    If _sortedCol.Count = 0 Then
                        _sortedCol.Add(_UnsortedEntry)
                    Else
                        _iUnsortedEnt = Int32.Parse(_UnsortedEntry.Nps)
                        For Each _sortedEntry As DsdEntry In _sortedCol
                            System.Math.Min(System.Threading.Interlocked.Increment(_iCount), _iCount - 1)
                            _iSortedEnt = Int32.Parse(_sortedEntry.Nps)
                            If _iUnsortedEnt < _iSortedEnt Then
                                _sortedCol.Insert(_iCount, _UnsortedEntry)
                                ' break 
                            Else
                                If _sortedCol.Count - 1 = _iCount Then
                                    If _iUnsortedEnt = _iSortedEnt Then
                                        _unSorted = False
                                    Else
                                        _sortedCol.Add(_UnsortedEntry)
                                    End If
                                End If
                            End If
                        Next
                    End If
                Next
            End While
            Return _sortedCol
        End Function

        Private Sub postProcessDSD(ByVal _dsd As DsdData)
            Dim _str As String
            Dim _newStr As String
            Dim _processingModel As Boolean = False
            Dim _processedHas3DDWF As Boolean = False
            Dim _processedModelPageSetup As Boolean = False
            Try
                If Not Directory.Exists(Path.GetDirectoryName(_fileInfo.dsdFileName)) Then
                    Directory.CreateDirectory(Path.GetDirectoryName(_fileInfo.dsdFileName))
                End If
                _dsd.WriteDsd(_pubInfo.outputDir + "tmp.dsd")
                _dsd.Dispose()
                Dim objFSRead As Stream = File.OpenRead(_pubInfo.outputDir + "tmp.dsd")
                Dim objSR As StreamReader = New StreamReader(objFSRead)
                Dim _fsNewDsd As FileStream = New FileStream(_fileInfo.dsdFileName, FileMode.Create)
                Dim _swNewDsd As StreamWriter = New StreamWriter(_fsNewDsd)


                '  While Not objSR.EndOfStream

                Do
                    _str = objSR.ReadLine

                    Dim myAL As New ArrayList : myAL.Add(_str)

                    If myAL.Contains("Layout=Model") Then
                        _processingModel = True
                    End If
                    If myAL.Contains("Has3DDWF") Then
                        _newStr = "Has3DDWF=0"
                        If _processingModel Then
                            _processedHas3DDWF = True
                            If _fileInfo.pubMod3D Then
                                _newStr = "Has3DDWF=1"
                            End If
                        End If
                    Else
                        If myAL.Contains("Setup=") Then
                            _newStr = "Setup="
                            If _processingModel Then
                                _processedModelPageSetup = True
                                If Not (_pubInfo.modelPageSetupName Is Nothing) Then
                                    _newStr = "Setup=" + _pubInfo.modelPageSetupName + "|" + _pubInfo.modelPageSetupDWG
                                End If
                            Else
                                If Not (_pubInfo.layoutPageSetupName Is Nothing) Then
                                    _newStr = "Setup=" + _pubInfo.layoutPageSetupName + "|" + _pubInfo.layoutPageSetupDWG
                                End If
                            End If
                        Else
                            If myAL.Contains("OriginalSheetPath") Then
                                _newStr = "OriginalSheetPath=" + _fileInfo.dwgFile
                            Else
                                If myAL.Contains("OUT") Then
                                    _newStr = "OUT=" + _pubInfo.outputDir
                                Else
                                    If myAL.Contains("IncludeLayer") Then
                                        If _pubInfo.incLayers Then
                                            _newStr = "IncludeLayer=TRUE"
                                        Else
                                            _newStr = "IncludeLayer=FALSE"
                                        End If
                                    Else
                                        If myAL.Contains("PromptForDwfName") Then
                                            _newStr = "PromptForDwfName=FALSE"
                                        Else
                                            If myAL.Contains("LogFilePath") Then
                                                _newStr = "LogFilePath=" + _pubInfo.outputDir + FN_PUBLOG
                                            Else
                                                _newStr = _str
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                    If _processedHas3DDWF AndAlso _processedModelPageSetup Then
                        _processingModel = False
                    End If
                    _swNewDsd.WriteLine(_newStr)

                Loop Until _str Is Nothing

                'End While

                objFSRead.Close()
                If File.Exists(_pubInfo.outputDir + "tmp.dsd") Then
                    File.Delete(_pubInfo.outputDir + "tmp.dsd")
                End If
                _swNewDsd.Close()
                ' protected  _swNewDsd.Dispose()
                _fsNewDsd.Close()
                ' protected  _fsNewDsd.Dispose()
            Catch _ex As System.Exception
                Throw _ex
            End Try
        End Sub

        Private Sub beginLogFile()
            If _cancel Then
                Return
            End If
            If File.Exists(_pubInfo.logFile) Then
                File.Delete(_pubInfo.logFile)
            End If
            Dim _fs As FileStream = New FileStream(_pubInfo.logFile, FileMode.Append)
            Dim _sw As StreamWriter = New StreamWriter(_fs)
            _sw.WriteLine(LF_STARTAT + DateTime.Now.ToString + "" & Microsoft.VisualBasic.Chr(10) & "")
            _sw.WriteLine(PROMPT_SOURCEDIR + _pubInfo.inputDir + "" & Microsoft.VisualBasic.Chr(10) & "")
            _sw.WriteLine(LF_FILE_PATTERN + _pubInfo.filePattern + "" & Microsoft.VisualBasic.Chr(10) & "")
            _sw.WriteLine(LF_INC_SUB_DIR + _pubInfo.incSubDirs.ToString + "" & Microsoft.VisualBasic.Chr(10) & "")
            _sw.WriteLine(PROMPT_OUTDIR + _pubInfo.outputDir + "" & Microsoft.VisualBasic.Chr(10) & "")
            _sw.WriteLine(LF_INC_MS_LAYOUTS + _pubInfo.incModelSpace.ToString + "" & Microsoft.VisualBasic.Chr(10) & "")
            If _pubInfo.incModelSpace Then
                If Not (_pubInfo.modelPageSetupName Is Nothing) Then
                    _sw.WriteLine(LF_PAGE_SETUP_DWG + _pubInfo.modelPageSetupDWG + "" & Microsoft.VisualBasic.Chr(10) & "")
                    _sw.WriteLine(LF_PAGE_SETUP_NAME + _pubInfo.modelPageSetupName + "" & Microsoft.VisualBasic.Chr(10) & "")
                End If
                _sw.WriteLine(LF_MS3D + _pubInfo.pubModelAs3D.ToString + "" & Microsoft.VisualBasic.Chr(10) & "")
            End If
            If Not (_pubInfo.layoutPageSetupName Is Nothing) Then
                _sw.WriteLine(LF_PAGE_SETUP_DWG + _pubInfo.layoutPageSetupDWG + "" & Microsoft.VisualBasic.Chr(10) & "")
                _sw.WriteLine(LF_PAGE_SETUP_NAME + _pubInfo.layoutPageSetupName + "" & Microsoft.VisualBasic.Chr(10) & "")
            End If
            _sw.WriteLine(LF_INC_LAYERS + _pubInfo.incLayers.ToString + "" & Microsoft.VisualBasic.Chr(10) & "")
            _sw.WriteLine(LF_INC_PLOTSTAMP + _pubInfo.incPlotStamp.ToString + "" & Microsoft.VisualBasic.Chr(10) & "")
            _sw.WriteLine("" & Microsoft.VisualBasic.Chr(10) & "")
            _sw.Close()
            ' _sw.Dispose()
            _fs.Close()
            ' _fs.Dispose()
        End Sub

        Private Sub logEntry(ByVal _str As String)
            Try
                Dim _fs As FileStream = New FileStream(_pubInfo.logFile, FileMode.Append)
                Dim _sw As StreamWriter = New StreamWriter(_fs)
                _sw.WriteLine(_str)
                _sw.Close()
                '  _sw.Dispose()
                _fs.Close()
                '  _fs.Dispose()
            Catch _ex As System.Exception
                Throw _ex
            End Try
        End Sub

        Private Sub endLogFile()
            logEntry(LF_ENDAT + DateTime.Now.ToString + "" & Microsoft.VisualBasic.Chr(10) & "")
        End Sub

        Dim _ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor

        Private Function reqYesNo(ByVal _prompt As String) As Boolean
            If _cancel Then
                Return False
            End If
            Try
                Dim _prStr As PromptStringOptions = New PromptStringOptions("" & Microsoft.VisualBasic.Chr(10) & "" + _prompt)
                Dim _prRes As PromptResult = _ed.GetString(_prStr)
                If _prRes.Status = PromptStatus.Cancel Then
                    _cancel = True
                    Return False
                End If
                Dim _res As String = _prRes.StringResult.ToString.ToLower
                If _res.Length = 0 OrElse _res.Substring(0, 1) = "y" Then
                    Return True
                Else
                    If _res.Substring(0, 1) = "n" Then
                        Return False
                    Else
                        _ed.WriteMessage(E_MSG_INVALID)
                        reqYesNo(_prompt)
                        Return False
                    End If
                End If
            Catch _ex As System.Exception
                Throw _ex
            End Try
        End Function

        Private Function reqPageSetupInfo(ByVal _prompt As String) As String
            If _cancel Then
                Return ""
            End If
            Try
                Dim _prStr As PromptStringOptions = New PromptStringOptions("" & Microsoft.VisualBasic.Chr(10) & "" + _prompt)
                Dim _prRes As PromptResult
                Dim _res As String
                Do
                    _prRes = _ed.GetString(_prStr)
                    If _prRes.Status = PromptStatus.Cancel Then
                        _cancel = True
                        Return ""
                    End If
                    _res = _prRes.StringResult.ToString.ToLower
                    If _res.Length = 0 Then
                        _ed.WriteMessage(E_MSG_INVALID)
                    End If
                Loop While _res.Length = 0
                Return _prRes.StringResult.ToString
            Catch _ex As System.Exception
                Throw _ex
            End Try
        End Function

        Private Sub reqFilePattern()
            If _cancel Then
                Return
            End If
            Try
                Dim _prStr As PromptStringOptions = New PromptStringOptions(PROMPT_FILE_PATTERN)
                Dim _prRes As PromptResult
                Dim _res As String
                _prRes = _ed.GetString(_prStr)
                If _prRes.Status = PromptStatus.Cancel Then
                    _cancel = True
                    Return
                End If
                _res = _prRes.StringResult.ToString.ToLower
                If _res.Length = 0 Then
                    _pubInfo.filePattern = "*.dwg"
                Else
                    _pubInfo.filePattern = _prRes.StringResult.ToString
                End If
            Catch _ex As System.Exception
                Throw _ex
            End Try
        End Sub

        Private Sub setDefaults()
            If _cancel Then
                Return
            End If
            Try
                _fileInfo.publish = False
                _fileInfo.numOfSections = 0
                Dim s As String = _fileInfo.dwgFile.Substring(_pubInfo.inputDir.Length, _fileInfo.dwgFile.Length - _pubInfo.inputDir.Length)
                s = _pubInfo.outputDir + s
                _fileInfo.dwfFile = s.Substring(0, s.Length - 4) + ".dwf"
            Catch _ex As System.Exception
                Throw _ex
            End Try
        End Sub

        Private Sub cleanup()
            If _cancel Then
                Return
            End If
            Try
                If File.Exists(_fileInfo.dsdFileName) Then
                    File.Delete(_fileInfo.dsdFileName)
                End If
                If File.Exists(_pubInfo.outputDir + "tmp.dsd") Then
                    File.Delete(_pubInfo.outputDir + "tmp.dsd")
                End If
            Catch _ex As System.Exception
                Throw _ex
            End Try
        End Sub

        Private Sub turnOffBackgroundPublish()
            Try
                Dim _obj As Object = Autodesk.AutoCAD.ApplicationServices.Application.GetSystemVariable("BACKGROUNDPLOT")
                _origBGPublish = System.Convert.ToInt16(_obj)
                Autodesk.AutoCAD.ApplicationServices.Application.SetSystemVariable("BACKGROUNDPLOT", 0)
            Catch _ex As System.Exception
                Throw _ex
            End Try
        End Sub

        Private Sub restoreBackgroundPublish()
            Try
                Autodesk.AutoCAD.ApplicationServices.Application.SetSystemVariable("BACKGROUNDPLOT", _origBGPublish)
            Catch _ex As System.Exception
                Throw _ex
            End Try
        End Sub

        Private Sub maximizeDrawingWindow()
            If _cancel Then
                Return
            End If
            Dim dwg As Document = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument
            dwg.Window.WindowState = FormWindowState.Maximized
        End Sub


        Private _cancel As Boolean
        Private _origBGPublish As Integer
        Private _pubInfo As publishInfo = New publishInfo
        Private _fileInfo As FileInfo = New FileInfo
        Private _deleteDSD As Boolean = True

        Structure publishInfo
            Public inputDir As String
            Public outputDir As String
            Public incSubDirs As Boolean
            Public filePattern As String
            Public incModelSpace As Boolean
            Public pubModelAs3D As Boolean
            Public incPlotStamp As Boolean
            Public incLayers As Boolean
            Public modelPageSetupName As String
            Public modelPageSetupDWG As String
            Public layoutPageSetupName As String
            Public layoutPageSetupDWG As String
            Public logFile As String
        End Structure

        Structure fileInfo
            Public dwgFile As String
            Public dwfFile As String
            Public fileNameWithoutExtention As String
            Public dsdFileName As String
            Public numOfSections As Integer
            Public pubMod3D As Boolean
            Public publish As Boolean
        End Structure

        Const PROMPT_SOURCEDIR As String = "Source directory: "
        Const PROMPT_FILE_PATTERN As String = "File Name Pattern <*.dwg>: "
        Const PROMPT_SUBDIR As String = "Include sub-directories? <yes>: "
        Const PROMPT_OUTDIR As String = "Output directory: "
        Const PROMPT_INCMS As String = "Include Model space layouts? <yes>: "
        Const PROMPT_MSPAGE_SETUP As String = "Apply page setup to model space? <yes>: "
        Const PROMPT_PAGE_SETUP_DWG As String = "Enter the drawing file that contains the page setup: "
        Const PROMPT_PAGE_SETUP_NAME As String = "Enter the name of the page setup: "
        Const PROMPT_MS3D As String = "Publish models in 3D? <yes>: "
        Const PROMPT_PSPAGE_SETUP As String = "Apply page setup to Layouts? <yes>:"
        Const PROMPT_INC_LAYERS As String = "Include Layer Information? <yes>: "
        Const PROMPT_INC_PLOTSTAMP As String = "Include Plot Stamp? <yes>: "
        Const E_MSG_NODIRFOUND As String = "Directory does not exist" & Microsoft.VisualBasic.Chr(10) & ""
        Const E_MSG_INVALID As String = "Invalid response" & Microsoft.VisualBasic.Chr(10) & ""
        Const E_MSG_FILENOTFOUND As String = "File Not found."
        Const E_MSG_FILEREADERROR As String = " ERROR: File read error, file not published" & Microsoft.VisualBasic.Chr(10) & ""
        Const E_MSG_UNSUPPORTEDFILE As String = " ERROR: Unsupported file format, file not published" & Microsoft.VisualBasic.Chr(10) & ""
        Const E_MSG_FILE_NEEDS_RECOVERY As String = " ERROR: Dwg Needs Recovery, file not published" & Microsoft.VisualBasic.Chr(10) & ""
        Const E_MSG_GENERIC As String = " ERROR: file processing error has occurred" & Microsoft.VisualBasic.Chr(10) & ""
        Const E_MSG_PWD As String = " ERROR: Password protected DWG, BatchDWF does not support password protected"
        Const FN_LOGFILE As String = "batchdwf.log"
        Const FN_PUBLOG As String = "publish.log"
        Const LF_NSEC As String = " Sections to publish: "
        Const LF_NO_SEC_FOUND As String = " No valid sections found to publish" & Microsoft.VisualBasic.Chr(10) & ""
        Const LF_LAYOUT_ADDED As String = " Layout added: "
        Const LF_LAYOUT_NOT_INIT As String = " Layout not initialized: "
        Const LF_STARTAT As String = "Log started at: "
        Const LF_FILE_PATTERN As String = " File Name Pattern: "
        Const LF_INC_SUB_DIR As String = " Include sub-directories: "
        Const LF_INC_MS_LAYOUTS As String = " Include Model space layouts: "
        Const LF_PAGE_SETUP_DWG As String = " Page Setup DWG: "
        Const LF_PAGE_SETUP_NAME As String = " Page Setup name: "
        Const LF_MS3D As String = " Publish models in 3D: "
        Const LF_INC_LAYERS As String = " Include Layer Information: "
        Const LF_INC_PLOTSTAMP As String = " Include Plot Stamp: "
        Const LF_ENDAT As String = "" & Microsoft.VisualBasic.Chr(10) & "" & Microsoft.VisualBasic.Chr(10) & "" & Microsoft.VisualBasic.Chr(10) & "BatchDWF completed at: "



''''''''''''''''''''''''''''''''''''

        '<assembly: ExtensionApplication(GetType(NET.MyApp))> 
        'Namespace Publishing 

        Public Class MyApp
            ' Implements IExtensionApplication
            Public Shared m_PublishEvents As PublishEvents = Nothing

            Public Sub Terminate()
                If Not (m_PublishEvents Is Nothing) Then
                    m_PublishEvents = Nothing
                End If
            End Sub

            Public Sub Initialize()
                m_PublishEvents = New PublishEvents
            End Sub
        End Class

        Public Class PublishEvents
            Private Shared m_pb As Publisher = Nothing
            Private m_bDone As Boolean

            Public Sub New()
                m_bDone = False
                m_pb = Autodesk.AutoCAD.ApplicationServices.Application.Publisher
                DoAddHndlr()
            End Sub

            Public Sub DoAddHndlr()
                If m_bDone = False Then
                    m_bDone = True
                Else
                    Return
                End If
                Try
                    m_pb = Autodesk.AutoCAD.ApplicationServices.Application.Publisher
                    AddHandler m_pb.AboutToBeginBackgroundPublishing, AddressOf callback_AboutToBeginBackgroundPublishingEventHandler
                    AddHandler m_pb.AboutToBeginPublishing, AddressOf callback_AboutToBeginPublishingEventHandler
                    AddHandler m_pb.AboutToEndPublishing, AddressOf callback_AboutToEndPublishingEventHandler
                    AddHandler m_pb.AboutToMoveFile, AddressOf callback_AboutToMoveFileHandler
                    AddHandler m_pb.BeginAggregation, AddressOf callback_BeginAggregationEventHandler
                    AddHandler m_pb.BeginEntity, AddressOf callback_BeginEntityEventHandler
                    AddHandler m_pb.BeginPublishingSheet, AddressOf callback_BeginPublishingSheetEventHandler
                    AddHandler m_pb.BeginSheet, AddressOf callback_BeginSheetEventHandler
                    AddHandler m_pb.CancelledOrFailedPublishing, AddressOf callback_CancelledOrFailedPublishingEventHandler
                    AddHandler m_pb.EndEntity, AddressOf callback_EndEntityEventHandler
                    AddHandler m_pb.EndPublish, AddressOf callback_EndPublishEventHandler
                    AddHandler m_pb.EndSheet, AddressOf callback_EndSheetEventHandler
                Catch ex As System.Exception
                    MyPrint(String.Format("" & Microsoft.VisualBasic.Chr(9) & "error = {0}", ex.Message))
                End Try
            End Sub

            Public Sub Undo()
                If m_pb Is Nothing OrElse m_bDone = False Then
                    Return
                End If
                Try
                    RemoveHandler m_pb.AboutToBeginBackgroundPublishing, AddressOf callback_AboutToBeginBackgroundPublishingEventHandler
                    RemoveHandler m_pb.AboutToBeginPublishing, AddressOf callback_AboutToBeginPublishingEventHandler
                    RemoveHandler m_pb.AboutToEndPublishing, AddressOf callback_AboutToEndPublishingEventHandler
                    RemoveHandler m_pb.AboutToMoveFile, AddressOf callback_AboutToMoveFileHandler
                    RemoveHandler m_pb.BeginAggregation, AddressOf callback_BeginAggregationEventHandler
                    RemoveHandler m_pb.BeginEntity, AddressOf callback_BeginEntityEventHandler
                    RemoveHandler m_pb.BeginPublishingSheet, AddressOf callback_BeginPublishingSheetEventHandler
                    RemoveHandler m_pb.BeginSheet, AddressOf callback_BeginSheetEventHandler
                    RemoveHandler m_pb.CancelledOrFailedPublishing, AddressOf callback_CancelledOrFailedPublishingEventHandler
                    RemoveHandler m_pb.EndEntity, AddressOf callback_EndEntityEventHandler
                    RemoveHandler m_pb.EndPublish, AddressOf callback_EndPublishEventHandler
                    RemoveHandler m_pb.EndSheet, AddressOf callback_EndSheetEventHandler
                    m_pb = Nothing
                Catch ex As System.Exception
                    MyPrint(String.Format("" & Microsoft.VisualBasic.Chr(9) & "error = {0}", ex.Message))
                End Try
                m_bDone = False
            End Sub

            Private Sub callback_AboutToBeginBackgroundPublishingEventHandler(ByVal sender As Object, ByVal e As AboutToBeginBackgroundPublishingEventArgs)
                MyPrint("AboutToBeginBackgroundPublishingEventHandler")
                Dim dsdData As Autodesk.AutoCAD.PlottingServices.DsdData = e.DsdData
                MyPrint(String.Format("" & Microsoft.VisualBasic.Chr(9) & "PlotStampOn = {0}", dsdData.PlotStampOn))
            End Sub

            Private Sub callback_AboutToBeginPublishingEventHandler(ByVal sender As Object, ByVal e As AboutToBeginPublishingEventArgs)
                MyPrint("AboutToBeginPublishingEventHandler")
                MyPrint(String.Format("" & Microsoft.VisualBasic.Chr(9) & "get_JobWillPublishInBackground = {0}", e.JobWillPublishInBackground))
                Dim dsdData As Autodesk.AutoCAD.PlottingServices.DsdData = e.DsdData
                MyPrint(String.Format("" & Microsoft.VisualBasic.Chr(9) & "PlotStampOn = {0}", dsdData.PlotStampOn))
            End Sub

            Private Sub callback_AboutToEndPublishingEventHandler(ByVal sender As Object, ByVal e As PublishEventArgs)
                MyPrint("AboutToEndPublishingEventHandler")
                MyPrint(String.Format("" & Microsoft.VisualBasic.Chr(9) & "get_DwfFileName = {0}", e.DwfFileName))
                MyPrint(String.Format("" & Microsoft.VisualBasic.Chr(9) & "get_IsMultiSheetDwf = {0}", e.IsMultiSheetDwf))
                MyPrint(String.Format("" & Microsoft.VisualBasic.Chr(9) & "get_TemporaryDwfFileName = {0}", e.TemporaryDwfFileName))
            End Sub

            Private Sub callback_AboutToMoveFileHandler(ByVal sender As Object, ByVal e As PublishEventArgs)
                MyPrint("AboutToMoveFileHandler")
                MyPrint(String.Format("" & Microsoft.VisualBasic.Chr(9) & "get_DwfFileName = {0}", e.DwfFileName))
                MyPrint(String.Format("" & Microsoft.VisualBasic.Chr(9) & "get_IsMultiSheetDwf = {0}", e.IsMultiSheetDwf))
                MyPrint(String.Format("" & Microsoft.VisualBasic.Chr(9) & "get_TemporaryDwfFileName = {0}", e.TemporaryDwfFileName))
            End Sub

            Private Sub callback_BeginAggregationEventHandler(ByVal sender As Object, ByVal e As BeginAggregationEventArgs)
                MyPrint("BeginAggregationEventHandler")
                e.PlotLogger.LogMessage("From my BeginAggregationEventHandler EVENT!!")
            End Sub

            Private Sub callback_BeginEntityEventHandler(ByVal sender As Object, ByVal e As PublishEntityEventArgs)
                MyPrint("BeginEntityEventHandler")
                MyPrint(String.Format("" & Microsoft.VisualBasic.Chr(9) & "get_UniqueEntityId() = {0}", e.UniqueEntityId))
            End Sub

            Private Sub callback_BeginPublishingSheetEventHandler(ByVal sender As Object, ByVal e As BeginPublishingSheetEventArgs)
                MyPrint("BeginPublishingSheetEventHandler")
                MyPrint(String.Format("" & Microsoft.VisualBasic.Chr(9) & "DwgName = {0}", e.DsdEntry.DwgName))
                e.PlotLogger.LogMessage("From my BeginPublishingSheetEventHandler EVENT!!")
            End Sub

            Private Sub callback_BeginSheetEventHandler(ByVal sender As Object, ByVal e As PublishSheetEventArgs)
                MyPrint("BeginSheetEventHandler")
                MyPrint(String.Format("" & Microsoft.VisualBasic.Chr(9) & "get_CanonicalMediaName = {0}", e.CanonicalMediaName))
                MyPrint(String.Format("" & Microsoft.VisualBasic.Chr(9) & "get_Configuration = {0}", e.Configuration))
                MyPrint(String.Format("" & Microsoft.VisualBasic.Chr(9) & "get_DrawingScale = {0}", e.DrawingScale.ToString))
                MyPrint(String.Format("" & Microsoft.VisualBasic.Chr(9) & "get_PlotLayoutId = {0}", e.PlotLayoutId.ToString))
                e.PlotLogger.LogMessage("From my BeginSheetEventHandler EVENT!!")
            End Sub

            Private Sub callback_CancelledOrFailedPublishingEventHandler(ByVal sender As Object, ByVal e As PublishEventArgs)
                MyPrint("CancelledOrFailedPublishingEventHandler")
                MyPrint(String.Format("" & Microsoft.VisualBasic.Chr(9) & "get_DwfFileName = {0}", e.DwfFileName))
                MyPrint(String.Format("" & Microsoft.VisualBasic.Chr(9) & "get_IsMultiSheetDwf = {0}", e.IsMultiSheetDwf))
                MyPrint(String.Format("" & Microsoft.VisualBasic.Chr(9) & "get_TemporaryDwfFileName = {0}", e.TemporaryDwfFileName))
            End Sub

            Private Sub callback_EndEntityEventHandler(ByVal sender As Object, ByVal e As PublishEntityEventArgs)
                MyPrint("EndEntityEventHandler")
                MyPrint(String.Format("" & Microsoft.VisualBasic.Chr(9) & "get_UniqueEntityId() = {0}", e.UniqueEntityId))
            End Sub

            Private Sub callback_EndPublishEventHandler(ByVal sender As Object, ByVal e As PublishEventArgs)
                MyPrint("EndPublishEventHandler")
                MyPrint(String.Format("" & Microsoft.VisualBasic.Chr(9) & "get_DwfFileName = {0}", e.DwfFileName))
                MyPrint(String.Format("" & Microsoft.VisualBasic.Chr(9) & "get_IsMultiSheetDwf = {0}", e.IsMultiSheetDwf))
                MyPrint(String.Format("" & Microsoft.VisualBasic.Chr(9) & "get_TemporaryDwfFileName = {0}", e.TemporaryDwfFileName))
            End Sub

            Private Sub callback_EndSheetEventHandler(ByVal sender As Object, ByVal e As PublishSheetEventArgs)
                MyPrint("EndSheetEventHandler")
            End Sub

            Private Sub MyPrint(ByVal s As String)
                Dim strLogFileName As String = "c:\test.log"
                Dim tw As System.IO.TextWriter = System.IO.File.AppendText(strLogFileName)
                tw.WriteLine(s)
                tw.Close()
            End Sub
        End Class
        '       End Namespace




''''''''''''''''''''''

  Private Sub SetTextStylesBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetTextStylesBtn.Click
        '  If AcadAppConnected() = False Then AcadAppConnected()
        '  If ActiveDocFound() = False Then ActiveDocFound()
        '  Dim textStyle1 As AutoCAD.AcadTextStyle
        '  Dim newFontFile As String
        '  Try
        '  AcadApp.ActiveDocument.ActiveTextStyle = AcadApp.ActiveDocument.TextStyles.Item("Standard")
        '  textStyle1 = AcadApp.ActiveDocument.ActiveTextStyle
        '  newFontFile = "simplex.shx"
        '  textStyle1.fontFile = newFontFile
        '  MsgBox("The FontFile for " & textStyle1.Name & " is " & textStyle1.fontFile, MsgBoxStyle.Information, "FontFile Example")
        '  AcadApp.ActiveDocument.Regen(AutoCAD.AcRegenType.acAllViewports)
        '  Catch ex As Exception
        '      MessageBox.Show(ex.ToString)
        '      End Try
    End Sub

    Private Sub LoadLinetypesBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadLinetypesBtn.Click
        '  If AcadAppConnected() = False Then AcadAppConnected()
        '  If ActiveDocFound() = False Then ActiveDocFound()
        '  Dim linetypeColl As AutoCAD.AcadLineTypes
        '  Dim entry As AutoCAD.AcadLineType
        '  Dim MSG As String
        '  'Try
        '  On Error Resume Next
        '  AcadApp.ActiveDocument.Linetypes.Load("Hidden", "acad.lin")
        '  AcadApp.ActiveDocument.Linetypes.Load("Hidden2", "acad.lin")
        '  AcadApp.ActiveDocument.Linetypes.Load("Hiddenx2", "acad.lin")
        '  AcadApp.ActiveDocument.Linetypes.Load("Center", "acad.lin")
        '  AcadApp.ActiveDocument.Linetypes.Load("Center2", "acad.lin")
        '  AcadApp.ActiveDocument.Linetypes.Load("Centerx2", "acad.lin")
        '  AcadApp.ActiveDocument.Linetypes.Load("Phantom", "acad.lin")
        '  AcadApp.ActiveDocument.Linetypes.Load("Phantom2", "acad.lin")
        '  AcadApp.ActiveDocument.Linetypes.Load("Phantomx2", "acad.lin")
        '  linetypeColl = AcadApp.ActiveDocument.Linetypes
        '  For Each entry In linetypeColl
        '  MSG = MSG & entry.Name & vbCrLf
        '  Next entry
        '  MsgBox("The linetypes available in this drawing are:" & vbCrLf & MSG, MsgBoxStyle.Information, "Linetypes Example")
        '  ' Catch ex As Exception
        '  '     MessageBox.Show(ex.ToString)
        ' End Try

    End Sub

   
    Private Sub InsertFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertFile.Click
        '   If AcadAppConnected() = False Then AcadAppConnected()
        '   If ActiveDocFound() = False Then ActiveDocFound()
        '   Dim i As Short
        '   If AcadAppConnected() Then
        '   AppActivate(AcadApp.Caption)
        '   Else
        '       MsgBox("CAN'T START AUTOCAD")
        '   End If
        '   Try
        '   RetPoint = AcadApp.ActiveDocument.Utility.GetPoint(, "Enter A Point")
        '   Dim blockRefObj As AutoCAD.AcadBlockReference
        '   blockRefObj = InsertMyBlock(blockRefObj, String.Concat(CurrentPathLabel.Text, "\", ListBox1.SelectedItems(i).ToString))
        '   blockRefObj.Update()
        '   Catch ex As Exception
        '       MessageBox.Show(ex.ToString)
        '       End Try
    End Sub

    Private Sub CmdOpenFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOpenFile.Click
        '   If AcadAppConnected() = False Then AcadAppConnected()
        '   If ActiveDocFound() = False Then ActiveDocFound()
        '   Dim i As Short
        '   Try
        '   AcadApp.Documents.Open(String.Concat(CurrentPathLabel.Text, "\", ListBox1.SelectedItems(i).ToString))
        '   Catch ex As Exception
        '       MessageBox.Show(ex.ToString)
        '       End Try

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim mydwg As String
        Dim i As Short
        For i = 0 To ListBox1.SelectedItems.Count - 1
            mydwg = String.Concat(CurrentPathLabel.Text, "\", ListBox1.SelectedItems(i).ToString)
            Try
                AxAvViewX1.src = mydwg
                If AxAvViewX1.src <> "" Then AxAvViewX1.ZoomExtents()
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try

        Next i
    End Sub

    Private Sub CmdNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdNext.Click
        If ListBox1.SelectedIndex < ListBox1.Items.Count - 1 Then
            ListBox1.SelectedIndex = ListBox1.SelectedIndex + 1
            CmdNext.Focus()
        End If
    End Sub

    Private Sub CmdPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPrevious.Click
        If ListBox1.SelectedIndex > 0 Then
            ListBox1.SelectedIndex = ListBox1.SelectedIndex - 1
            CmdPrevious.Focus()
        End If

    End Sub

    Private Sub ChkGrayBackGround_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkGrayBackGround.CheckedChanged
        ChkBlackBackGround.CheckState = System.Windows.Forms.CheckState.Unchecked
        If ChkGrayBackGround.CheckState = 1 Then
            Try
                AxAvViewX1.BackgroundColor = CStr(QBColor(8))
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
            ChkBlackBackGround.CheckState = System.Windows.Forms.CheckState.Unchecked
        Else
            Try
                AxAvViewX1.BackgroundColor = CStr(QBColor(15))
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub ChkBlackBackGround_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkBlackBackGround.CheckedChanged
        ChkGrayBackGround.CheckState = System.Windows.Forms.CheckState.Unchecked
        If ChkBlackBackGround.CheckState = 1 Then
            Try
                AxAvViewX1.BackgroundColor = CStr(QBColor(0))
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
            ChkGrayBackGround.CheckState = System.Windows.Forms.CheckState.Unchecked
        Else
            Try
                AxAvViewX1.BackgroundColor = CStr(QBColor(15))
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try

        End If
    End Sub



''''''''''''''''''''

 Dim ConfigInfoName As String = ""
            Dim inf As Autodesk.AutoCAD.PlottingServices.PlotConfigInfo
            For Each inf In Autodesk.AutoCAD.PlottingServices.PlotConfigManager.Devices
                If inf.DeviceName.Equals("DWF6 ePlot.pc3") Then
                    ' MessageBox.Show("found the right device")
                    ConfigInfoName = inf.DeviceName
                End If
            Next

            Dim pConfig As Autodesk.AutoCAD.PlottingServices.PlotConfig = _
                       Autodesk.AutoCAD.PlottingServices.PlotConfigManager.SetCurrentConfig(ConfigInfoName)

            Dim NamePgSetUps As System.Collections.Specialized.StringCollection
            Dim NamePgSetUpsPath As System.Collections.Specialized.StringCollection

            Dim Doc As Autodesk.AutoCAD.ApplicationServices.Document
            Dim fileNameWoutExt As String
            fileNameWoutExt = Doc.Name.Replace(".dwg", "")
            fileNameWoutExt = Doc.Name.Replace(".DWG", "") ' Should upper case this and then strip it

            ' ' dsd for layout
            Dim oLayMan As LayoutManager = LayoutManager.Current
            Dim cLoutName As String = oLayMan.CurrentLayout
            Dim cLoutID As ObjectId = oLayMan.GetLayoutId(cLoutName)
            Dim db As Database = HostApplicationServices.WorkingDatabase
            Dim trans As Transaction = db.TransactionManager.StartTransaction()
            Dim lOut As Layout = trans.GetObject(cLoutID, OpenMode.ForWrite)

            Dim DsdEntry As New DsdEntry
            Dim dsdEntCol As DsdEntryCollection
            DsdEntry.Layout = lOut.LayoutName.ToString
            DsdEntry.Title = fileNameWoutExt + "-" + lOut.LayoutName.ToString
            DsdEntry.Nps = lOut.TabOrder.ToString
            dsdEntCol.Add(DsdEntry)
            'logEntry(LF_LAYOUT_ADDED + lOut.LayoutName.ToString + "" & Microsoft.VisualBasic.Chr(10) & "")




            '  Dim dsdDa As New DsdData
            '  dsdDa.ReadDsd("C:\Gary\Cad Files\Test1.dsd")

            ' Dim dsdEntCol As DsdEntryCollection
            ' dsdEntCol = dsdDa.GetDsdEntryCollection()

            ' Dim DiaRes As OptionsDialogResult

            '           Dim Publshr As New Publisher
            'DiaRes = Publshr.ShowDwfOptionsDialog(dsdDa, pConfig, "Title ???")


            'Publshr.ShowPublishDialog(dsdDa, pConfig, NamePgSetUps, NamePgSetUpsPath, "Title ???", "Btn Text")
            'Publshr.PublishSelectedLayouts(True)
            '            Publshr.PublishExecute(dsdDa, pConfig)







''''''''''''''''''''


'You should write a program to deploy your program.
'Thats what i did. I wrote a console application, and then sent a link in an email to everyone in my company. When they clicked it, it copied the necessary files, and then wrote the correct values to the registry...... 
'Here is the program.

Sub InitialRegistryEditor()
Dim AppKey As RegistryKey = Nothing
Dim CommandKey As RegistryKey = Nothing
Dim VersionKey As RegistryKey = Nothing
Dim TempVal As Object = Nothing

Try
Console.WriteLine(vbCrLf + "LDD Registry Editor. Created by Mark Pendergraft" + vbCrLf + "Attempting to access the registry...." + vbCrLf)

'If this key doesn't exist, they don't have AutoCAD 2006 - Version Specific as far as i know!!!
If Not My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Autodesk\AutoCAD\R16 .2\ACAD-4008:409", "AcadLocation", Nothing) Is Nothing Then
My.Computer.Registry.LocalMachine.GetAccessControl()
'Get the key, seeing that it exists
AppKey = My.Computer.Registry.LocalMachine.CreateSubKey("SOFTWARE\Autodesk\AutoCAD\R16.2 \ACAD-4008:409\Applications\MRPTools")
'let the user know whats happening
Console.WriteLine("Successfuly Created " + AppKey.ToString)
'These are the values you will have to write (for 2006)
AppKey.SetValue("DESCRIPTION", "MRPTools", RegistryValueKind.String)
'this is where the dll file resides on your machine
AppKey.SetValue("LOADER", "C:\Program Files\Autodesk Land Desktop 2006\NET\MRPTools.dll", RegistryValueKind.String)
AppKey.SetValue("LOADCTRLS", 2, RegistryValueKind.DWord)
AppKey.SetValue("MANAGED", 1, RegistryValueKind.DWord)
CommandKey = AppKey.CreateSubKey("COMMAND")
Console.WriteLine("Successfully Created " + CommandKey.ToString)
'this is a public sub inside MRPTools.dll, You will have to set it to a Public sub residing in your program.
CommandKey.SetValue("LM", "LSMan", RegistryValueKind.String)
Else
Console.WriteLine("The Key does not exist on your machine.")
Console.WriteLine("Please speak to your IT Professional to determine the issue.")
Console.WriteLine("Exiting....")
Exit Sub
End If
Catch ex As Exception
Console.WriteLine(ex.Message)
Console.WriteLine(vbCrLf + "Press Any Key to Continue...")
Console.ReadKey()
End Try
End Sub






'''''''''''''''''''
	
MessageBox.Show("Starting Plot")
Dim ConfigInfoName As String =  "" 
Dim inf As Autodesk.AutoCAD.PlottingServices.PlotConfigInfo
For Each inf In Autodesk.AutoCAD.PlottingServices.PlotConfigManager.Devices
If inf.DeviceName.Equals("DWG To PDF.pc3") Then
MessageBox.Show("found the right device")
ConfigInfoName = inf.DeviceName
 
End If
 
Next
Dim pConfig As Autodesk.AutoCAD.PlottingServices.PlotConfig =  Autodesk.AutoCAD.PlottingServices.PlotConfigManager.SetCurrentConfig(ConfigInfo Name) 
 
 
Dim pInfo As Autodesk.AutoCAD.PlottingServices.PlotInfo =  New Autodesk.AutoCAD.PlottingServices.PlotInfo() 
Dim lMan As Autodesk.AutoCAD.DatabaseServices.LayoutManager =  Autodesk.AutoCAD.DatabaseServices.LayoutManager.Current 
pInfo.Layout = lMan.GetLayoutId(lMan.CurrentLayout) 
pInfo.DeviceOverride = pConfig
 
Dim pSettings As Autodesk.AutoCAD.DatabaseServices.PlotSettings =  New Autodesk.AutoCAD.DatabaseServices.PlotSettings(True) 
Dim pSValidator As Autodesk.AutoCAD.DatabaseServices.PlotSettingsValidator =  Autodesk.AutoCAD.DatabaseServices.PlotSettingsValidator.Current 
 
Dim validator As Autodesk.AutoCAD.PlottingServices.PlotInfoValidator =  New Autodesk.AutoCAD.PlottingServices.PlotInfoValidator() 
validator.Validate(pInfo)
Dim pProgDialog As Autodesk.AutoCAD.PlottingServices.PlotProgressDialog =  New Autodesk.AutoCAD.PlottingServices.PlotProgressDialog(False,1,True) 
pProgDialog.set_PlotMsgString(Autodesk.AutoCAD.PlottingServices.PlotMessageInde x.DialogTitle,"Plotting...")
pProgDialog.set_PlotMsgString(Autodesk.AutoCAD.PlottingServices.PlotMessageInde x.CancelJobButtonMessage,"Cancel Plot")
pProgDialog.set_PlotMsgString(Autodesk.AutoCAD.PlottingServices.PlotMessageInde x.CancelSheetButtonMessage,"Cancel Sheet")
pProgDialog.set_PlotMsgString(Autodesk.AutoCAD.PlottingServices.PlotMessageInde x.SheetSetProgressCaption,"Plot Progree")
pProgDialog.set_PlotMsgString(Autodesk.AutoCAD.PlottingServices.PlotMessageInde x.SheetProgressCaption,"Sheet Progress")
pProgDialog.LowerPlotProgressRange = 0
pProgDialog.UpperPlotProgressRange = 100
'pProgDialog.OnBeginPlot();
pProgDialog.IsVisible = True
Dim pPInfo As Autodesk.AutoCAD.PlottingServices.PlotPageInfo =  New Autodesk.AutoCAD.PlottingServices.PlotPageInfo() 
 
Dim parms As Object =  Nothing 
Dim pEngine As Autodesk.AutoCAD.PlottingServices.PlotEngine =  Autodesk.AutoCAD.PlottingServices.PlotFactory.CreatePublishEngine() 
pEngine.BeginPlot(pProgDialog,parms)
pEngine.BeginDocument(pInfo, "c:\\house7.dwg", parms, 1, True, "c:\\Mike_out.pdf")
pEngine.BeginPage(pPInfo, pInfo, True, parms)
pEngine.BeginGenerateGraphics(parms)
pEngine.EndGenerateGraphics(parms)
pEngine.EndPage(parms)
pEngine.EndDocument(parms)
pEngine.EndPlot(parms)
pEngine.Destroy()
pEngine = Nothing
pProgDialog.Destroy()






'''''''''''''''''''''
public void test() {
MessageBox.Show("Starting Plot");
String ConfigInfoName = "";
foreach (Autodesk.AutoCAD.PlottingServices.PlotConfigInfo inf in Autodesk.AutoCAD.PlottingServices.PlotConfigManager.Devices)
{
if (inf.DeviceName.Equals("DWG To PDF.pc3"))
{
MessageBox.Show("found the right device");
ConfigInfoName = inf.DeviceName;

}

}
Autodesk.AutoCAD.PlottingServices.PlotConfig pConfig = Autodesk.AutoCAD.PlottingServices.PlotConfigManager.SetCurrentConfig(ConfigInfo Name);


Autodesk.AutoCAD.PlottingServices.PlotInfo pInfo = new Autodesk.AutoCAD.PlottingServices.PlotInfo();
Autodesk.AutoCAD.DatabaseServices.LayoutManager lMan = Autodesk.AutoCAD.DatabaseServices.LayoutManager.Current;
pInfo.Layout = lMan.GetLayoutId(lMan.CurrentLayout); 
pInfo.DeviceOverride = pConfig;

Autodesk.AutoCAD.DatabaseServices.PlotSettings pSettings = new Autodesk.AutoCAD.DatabaseServices.PlotSettings(true);
Autodesk.AutoCAD.DatabaseServices.PlotSettingsValidator pSValidator = Autodesk.AutoCAD.DatabaseServices.PlotSettingsValidator.Current;

Autodesk.AutoCAD.PlottingServices.PlotInfoValidator validator = new Autodesk.AutoCAD.PlottingServices.PlotInfoValidator(); 
validator.Validate(pInfo);
Autodesk.AutoCAD.PlottingServices.PlotProgressDialog pProgDialog = new Autodesk.AutoCAD.PlottingServices.PlotProgressDialog(false,1,true);
pProgDialog.set_PlotMsgString(Autodesk.AutoCAD.PlottingServices.PlotMessageInde x.DialogTitle,"Plotting...");
pProgDialog.set_PlotMsgString(Autodesk.AutoCAD.PlottingServices.PlotMessageInde x.CancelJobButtonMessage,"Cancel Plot");
pProgDialog.set_PlotMsgString(Autodesk.AutoCAD.PlottingServices.PlotMessageInde x.CancelSheetButtonMessage,"Cancel Sheet");
pProgDialog.set_PlotMsgString(Autodesk.AutoCAD.PlottingServices.PlotMessageInde x.SheetSetProgressCaption,"Plot Progree");
pProgDialog.set_PlotMsgString(Autodesk.AutoCAD.PlottingServices.PlotMessageInde x.SheetProgressCaption,"Sheet Progress");
pProgDialog.LowerPlotProgressRange = 0;
pProgDialog.UpperPlotProgressRange = 100;
//pProgDialog.OnBeginPlot();
pProgDialog.IsVisible = true;
Autodesk.AutoCAD.PlottingServices.PlotPageInfo pPInfo = new Autodesk.AutoCAD.PlottingServices.PlotPageInfo();

Object parms = null;
Autodesk.AutoCAD.PlottingServices.PlotEngine pEngine = Autodesk.AutoCAD.PlottingServices.PlotFactory.CreatePublishEngine();
pEngine.BeginPlot(pProgDialog,parms);
pEngine.BeginDocument(pInfo, "c:\\house7.dwg", parms, 1, true, "c:\\Mike_out.pdf");
pEngine.BeginPage(pPInfo, pInfo, true, parms);
pEngine.BeginGenerateGraphics(parms);
pEngine.EndGenerateGraphics(parms);
pEngine.EndPage(parms);
pEngine.EndDocument(parms);
pEngine.EndPlot(parms);
pEngine.Destroy();
pEngine = null;
pProgDialog.Destroy(); 
''''''''''''''''''



''''''''''''''

public class Testinsert
{
[CommandMethod("testinsert")]
static public void DoIt()
{
Document doc = 
Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveD ocument;
//Editor ed = doc.Editor;
//PromptResult res = ed.GetString("Give me a file to insert");
//if (res.Status != PromptStatus.OK)
// return;
//string fname = res.StringResult;
string fname = @"E:\My Documents\??\plan-NA.dwg";
if ( ! File.Exists(fname))
fname = HostApplicationServices.Current.FindFile(fname, 
doc.Database, FindFileHint.Default);
[using] (Database db = new Database(false, false))
{
//read drawing
db.ReadDwgFile(fname, FileShare.Read, true, null);
[using] (Transaction t =
doc.TransactionManager.StartTransaction())
{
//insert it as a new block
ObjectId idBTR = doc.Database.Insert("N_spot", db, 
false);
//create a ref to the block
BlockTable bt = 
(BlockTable)t.GetObject(doc.Database.BlockTableId, OpenMode.ForRead);
BlockTableRecord btr = 
(BlockTableRecord)t.GetObject(bt[BlockTableRecord.ModelSpace], 
OpenMode.ForWrite);
[using] (BlockReference bref = new 
BlockReference(Point3d.Origin, idBTR))
{
btr.AppendEntity(bref);
t.AddNewlyCreatedDBObject(bref, true);
}
t.Commit();
}
}

}
} 




''''''
Private Sub MakeDataView()
   Dim dv As DataView
   dv = New DataView
   With dv
      .Table = DataSet1.Tables("Suppliers")
      .AllowDelete = True
      .AllowEdit = True
      .AllowNew = True
      .RowFilter = "City = 'Berlin'"
      .RowStateFilter = DataViewRowState.ModifiedCurrent
      .Sort = "CompanyName DESC"
   End With
   
   ' Simple bind to a TextBox control
   Text1.DataBindings.Add("Text", dv, "CompanyName")
End Sub



''''''''''''''''''''

   Private Sub miTransToItmMstr_Click_01(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles miTransToItmMstr.Click
            If daComp.DataSet11.E024ItemMasterInput.Count = 0 Then
                Dim file As New System.IO.StreamReader("C:\DataLinks" & "\DBTest.txt")
                Dim words As String = file.ReadToEnd() : file.Close()
                daComp.OleDbConn.ConnectionString = words
                daComp.daE024ItemMasterInput.Fill(daComp.DataSet11.E024ItemMasterInput)
            End If

            Dim MyNewRow As DataRow : Dim MyRow As DataRowView : Dim c As Integer : Dim Cc As Integer
            Dim E024ItmMstrDV As DataView = New DataView(daComp.DataSet11.E024ItemMasterInput)
            'E024ItmMstrDV.RowFilter = "EngineeringPartNumber = '*'"
            E024ItmMstrDV.RowStateFilter = DataViewRowState.CurrentRows
            E024ItmMstrDV.Sort = "EngineeringPartNumber" ' , EngineeringDashNumber, EngineeringRevisionCode"
            Dim fStr As String  'Dim rStr As String
            Dim AddResponse As MsgBoxResult : Dim UpdateResponse As MsgBoxResult
            Dim foundRows() As DataRowView : Dim str As String
            For c = 0 To (dvE044DRN.Count - 1)
                MyRow = dvE044DRN.Item(c) : str = MyRow.Item(1)
                str = str.Replace(".dwg", "") : str = str.Replace(".DWG", "") ' Should upper case this and then strip it
                fStr = str & " - " & MyRow.Item(2) ' name and layout
                'rStr = MyRow.Item(4).ToString ' rev
                Try : foundRows = E024ItmMstrDV.FindRows(New Object() {fStr}) '{fStr, rStr}
                    If foundRows.Length = 0 Then
                        AddResponse = MessageBox.Show("No match found. Press Ok To Add To Item Master", "Caption", MsgBoxStyle.OKCancel)
                        If AddResponse = MsgBoxResult.OK Then
                            If ecoID = Nothing Then
                                chdlg.rbNewDoc.Enabled = True
                                chdlg.rbNewDoc.Checked = True
                                NewE037ECO(drnID)
                            End If
                            str = MyRow.Item(1) : str = str.Replace(".dwg", "") : str = str.Replace(".DWG", "")
                            MyNewRow = daComp.DataSet11.E024ItemMasterInput.NewRow
                            MyNewRow("EngineeringPartNumber") = str & " - " & MyRow.Item(2)
                            MyNewRow("EngineeringDashNumber") = "00"
                            MyNewRow("EngineeringDescription") = "Get From Titleblock"
                            MyNewRow("EngineeringEngineeringChangeNumberAndDate") = ecoID & " - " & UCase(Format(Now, "MMM/dd/yy").ToString)
                            MyNewRow("EngineeringRevisionCode") = MyRow.Item(4) 'rev
                            daComp.DataSet11.E024ItemMasterInput.Rows.Add(MyNewRow)
                        End If
                    Else

                        If ecoID = Nothing Then
                            MessageBox.Show("Found Match - Make New ECO", "Caption")
                            chdlg.rbNewDoc.Enabled = False : NewE037ECO(drnID)
                        End If


                        Dim myDRV As DataRowView



                        For Each myDRV In foundRows

                            UpdateResponse = MessageBox.Show("Update This Record " & myDRV("EngineeringPartNumber") & " - " & myDRV("EngineeringDashNumber") & " - " & myDRV("EngineeringRevisionCode") & vbCrLf _
                                                   & "With This One          " & str & " - " & MyRow.Item(2) & " - " & myDRV("EngineeringDashNumber") & " - " & MyRow.Item(4), "Caption", MessageBoxButtons.OKCancel)

                            'increment dash number and revision while adding new record
                            If UpdateResponse = MsgBoxResult.OK And chdlg.ChngType = "Non-Interchangeable" Then
                                str = MyRow.Item(1) : str = str.Replace(".dwg", "") : str = str.Replace(".DWG", "")
                                MyNewRow = daComp.DataSet11.E024ItemMasterInput.NewRow
                                MyNewRow("EngineeringPartNumber") = str & " - " & MyRow.Item(2)
                                MyNewRow("EngineeringDashNumber") = Format(myDRV("EngineeringDashNumber") + 1, "00").ToString
                                MyNewRow("EngineeringDescription") = "Get From Titleblock"
                                MyNewRow("EngineeringEngineeringChangeNumberAndDate") = ecoID & " - " & UCase(Format(Now, "MMM/dd/yy").ToString)
                                MyNewRow("EngineeringRevisionCode") = MyRow.Item(4) 'rev
                                daComp.DataSet11.E024ItemMasterInput.Rows.Add(MyNewRow)

                                'myDRV("EngineeringDashNumber") = Format(myDRV("EngineeringDashNumber") + 1, "00").ToString
                                'myDRV("EngineeringDescription") = "Get From Titleblock"
                                'myDRV("EngineeringRevisionCode") = MyRow.Item(4) 'rev
                            End If
                            'if change is interchangeable must add new master item with incremented revision+
                            'if bom assembly item ???
                            If UpdateResponse = MsgBoxResult.OK And chdlg.ChngType = "Interchangeable" Then
                                str = MyRow.Item(1) : str = str.Replace(".dwg", "") : str = str.Replace(".DWG", "")
                                MyNewRow = daComp.DataSet11.E024ItemMasterInput.NewRow
                                MyNewRow("EngineeringPartNumber") = str & " - " & MyRow.Item(2)
                                MyNewRow("EngineeringDashNumber") = "00"
                                MyNewRow("EngineeringDescription") = "Get From Titleblock"
                                MyNewRow("EngineeringEngineeringChangeNumberAndDate") = ecoID & " - " & UCase(Format(Now, "MMM/dd/yy").ToString)
                                MyNewRow("EngineeringRevisionCode") = MyRow.Item(4) 'rev
                                daComp.DataSet11.E024ItemMasterInput.Rows.Add(MyNewRow)

                                'myDRV("EngineeringDescription") = "Get From Titleblock"
                                'myDRV("EngineeringRevisionCode") = MyRow.Item(4) 'rev
                            End If
                            'increment revision only
                            If UpdateResponse = MsgBoxResult.OK And chdlg.ChngType = "Documentation Only" Then
                                str = MyRow.Item(1) : str = str.Replace(".dwg", "") : str = str.Replace(".DWG", "")
                                MyNewRow = daComp.DataSet11.E024ItemMasterInput.NewRow
                                MyNewRow("EngineeringPartNumber") = str & " - " & MyRow.Item(2)
                                MyNewRow("EngineeringDashNumber") = "00"
                                MyNewRow("EngineeringDescription") = "Get From Titleblock"
                                MyNewRow("EngineeringEngineeringChangeNumberAndDate") = ecoID & " - " & UCase(Format(Now, "MMM/dd/yy").ToString)
                                MyNewRow("EngineeringRevisionCode") = MyRow.Item(4) 'rev
                                daComp.DataSet11.E024ItemMasterInput.Rows.Add(MyNewRow)

                                ' myDRV("EngineeringDescription") = "Get From Titleblock"
                                ' myDRV("EngineeringRevisionCode") = MyRow.Item(4) 'rev
                            End If
                        Next


                    End If
                Catch ex As Exception : MessageBox.Show(ex.ToString) : End Try
            Next
            If UpdateResponse = MsgBoxResult.OK Or AddResponse = MsgBoxResult.OK Then
                ecoID = Nothing

                Dim frm As frmMain = Me.FindForm()
                frm.TabControl1.SelectedTab = frm.tpE037ECO

                If daComp.OleDbConn.ConnectionString.ToString = "" Then
                    Dim file As New System.IO.StreamReader("C:\DataLinks" & "\DBTest.txt")
                    Dim words As String = file.ReadToEnd() : file.Close()
                    daComp.OleDbConn.ConnectionString = words
                End If
                '  Dim dtMod As System.Data.DataTable = daComp.DataSet11.E024ItemMasterInput.GetChanges
                'if changes don't exist dt mod will = nothing and no db con ex will hapen
                Try : daComp.daE024ItemMasterInput.Update(daComp.DataSet11.E024ItemMasterInput)
                Catch dbcx As DBConcurrencyException
                    MessageBox.Show(dbcx.ToString) '   createMessage(dbcx, dtMod)
                Catch ex As Exception
                    MessageBox.Show("Update Failed", ex.GetType().ToString()) : MessageBox.Show(ex.ToString)
                End Try
                daComp.DataSet11.E024ItemMasterInput.Clear()
                daComp.daE024ItemMasterInput.Fill(daComp.DataSet11.E024ItemMasterInput)
            End If
        End Sub



''''''''''''''''''''
'udls
Friend WithEvents oConnection As New cConnection("MyDataLink.udl")
m_cnAuthors.ConnectionString = oConnection.GetSQLConnectionString()

'Create an empty text file
Dim fs As New System.IO.FileStream(strFileName, System.IO.FileMode.CreateNew)
fs.Close()

'Call Data Link App and write information to it
Dim psiProcess As New ProcessStartInfo
psiProcess.FileName = strFileName
Dim pProcess As Process = Process.Start(psiProcess)
pProcess.WaitForInputIdle()
pProcess.WaitForExit()
pProcess.Close()

'read from
For Each strString In strArray

            If strString.IndexOf("Provider") > -1 Then
                strProvider = strString.Substring(strString.IndexOf("Provider"))
            End If

            If strString.IndexOf("Password") > -1 Then
                m_strPassword = strString
            End If
            ...
            ...
            ...
            
Next







'''''''''''''''''''
<= VB.NET 2003:

Function FileInUse(ByVal FN As String) As Boolean
Dim fs As IO.FileStream = Nothing
Try
fs = IO.File.Open(FN, IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.None)
Return False
Catch ex As IO.IOException
Return True
Finally
If Not fs Is Nothing Then
fs.Close()
End If
End Try
End Function



''''''''''''''
Private Sub myWatcher_Changed(ByVal sender As System.Object, _
   ByVal e As System.IO.FileSystemEventArgs) Handles myWatcher.Changed
   Me.Label1.Text = "Changes made to: " & e.FullPath
End Sub


Private Sub myWatcher_Created(ByVal sender As System.Object, _
   ByVal e As System.IO.FileSystemEventArgs) Handles myWatcher.Created
   Me.Label2.Text = "The file: " & e.FullPath & _
      " has been added to your directory"
End Sub

''''''
Public Class Watcher
    
    Public Shared Sub Main()
        Dim args() As String = System.Environment.GetCommandLineArgs()
        ' If a directory is not specified, exit the program.
        If args.Length <> 2 Then
            ' Display the proper way to call the program.
            Console.WriteLine("Usage: Watcher.exe (directory)")
            Return
        End If
        
        ' Create a new FileSystemWatcher and set its properties.
        Dim watcher As New FileSystemWatcher()
        watcher.Path = args(1)
        ' Watch for changes in LastAccess and LastWrite times, and
        ' the renaming of files or directories. 
        watcher.NotifyFilter = (NotifyFilters.LastAccess Or NotifyFilters.LastWrite Or NotifyFilters.FileName Or NotifyFilters.DirectoryName)
        ' Only watch text files.
        watcher.Filter = "*.txt"
        
        ' Add event handlers.
        AddHandler watcher.Changed, AddressOf OnChanged
        AddHandler watcher.Created, AddressOf OnChanged
        AddHandler watcher.Deleted, AddressOf OnChanged
        AddHandler watcher.Renamed, AddressOf OnRenamed
        
        ' Begin watching.
        watcher.EnableRaisingEvents = True
        
        ' Wait for the user to quit the program.
        Console.WriteLine("Press 'q' to quit the sample.")
        While Chr(Console.Read()) <> "q"c
        End While
    End Sub
     
    ' Define the event handlers.
    Private Shared Sub OnChanged(source As Object, e As FileSystemEventArgs)
        ' Specify what is done when a file is changed, created, or deleted.
        Console.WriteLine("File: " & e.FullPath & " " & e.ChangeType)
    End Sub    
    
    Private Shared Sub OnRenamed(source As Object, e As RenamedEventArgs)
        ' Specify what is done when a file is renamed.
        Console.WriteLine("File: {0} renamed to {1}", e.OldFullPath, e.FullPath)
    End Sub
    
End Class









''''''''''''''''''''''''
...Dim groupId As ObjectId = dbDic.Value
...Dim code As Next
Dim can As also
Dim useful As be
you:
    Do While 
        ' Return ArrayList of ObjectId for all groups
        '
    Loop
    
        
        Public Shared Sub GetGroupNames()
            Dim ed As Editor = Application.DocumentManager.MdiActiveDocument.Editor
            Dim db As Database = HostApplicationServices.WorkingDatabase
            Dim trans As Transaction = db.TransactionManager.StartTransaction
            Try 
                Dim lt As DBDictionary = CType(trans.GetObject(db.GroupDictionaryId, OpenMode.ForRead),DBDictionary)
                For Each ide As DictionaryEntry In lt
                    Dim ltr As Group = CType(trans.GetObject(CType(ide.Value,ObjectId), OpenMode.ForRead),Group)
                    ed.WriteMessage(""& vbLf&"Group Name: {0}", ltr.Name)
                Next
                trans.Commit
            Finally
                trans.Dispose
            End Try
        End Sub
        
        '
        Private Shared Function GetAllGroupsIds() As ArrayList
            Dim ids As ArrayList = New ArrayList
            Dim db As Database = HostApplicationServices.WorkingDatabase
            Dim trans As Transaction = db.TransactionManager.StartTransaction
            Try 
                Dim lt As DBDictionary = CType(trans.GetObject(db.GroupDictionaryId, OpenMode.ForRead),DBDictionary)
                For Each ide As DictionaryEntry In lt
                    ids.Add(ide.Value)
                Next
                trans.Commit
            Finally
                trans.Dispose
            End Try
            Return ids
        End Function
        
        '
        ' Print names of all groups of selected entity
        '
        <CommandMethod("PrintGroupNamesOfEntity")>  _
        Public Shared Sub PrintGroupNamesOfEntity()
            Dim ed As Editor = Application.DocumentManager.MdiActiveDocument.Editor
            Dim db As Database = HostApplicationServices.WorkingDatabase
            Dim trans As Transaction = db.TransactionManager.StartTransaction
            Try 
                Dim groupIds As ArrayList = GetAllGroupsIds
                If (groupIds.Count = 0) Then
                    ed.WriteMessage(""& vbLf&"Drawing has not any group!")
                    Return
                End If
                Dim entres As PromptEntityResult = ed.GetEntity(""& vbLf&"Select entity: ")
                If (entres.Status = PromptStatus.OK) Then
                    Dim en As Entity = CType(trans.GetObject(entres.ObjectId, OpenMode.ForRead),Entity)
                    For Each id As ObjectId In groupIds
                        If en.HasPersistentReactor(id) Then
                            Dim gr As Group = CType(trans.GetObject(id, OpenMode.ForRead),Group)
                            ed.WriteMessage(""& vbLf&"Group Name: {0}", gr.Name)
                        End If
                    Next
                End If
                trans.Commit
            Finally
                trans.Dispose
            End Try
        End Sub
     







''''''''''''''''' 2007 
 Public Shared Sub GetEntGrps()
        Dim ed As Editor = Application.DocumentManager.MdiActiveDocument.Editor
        Dim db As Database = HostApplicationServices.WorkingDatabase
        Dim trans As Transaction = db.TransactionManager.StartTransaction
        Try 
            Dim entres As PromptEntityResult = ed.GetEntity(""& vbLf&"Select entity: ")
            If (entres.Status = PromptStatus.OK) Then
                Dim en As Entity = CType(trans.GetObject(entres.ObjectId, OpenMode.ForRead),Entity)
                Dim col As ObjectIdCollection = en.GetPersistentReactorIds
                If (Not (col) Is Nothing) Then
                    For Each id As ObjectId In col
                        Dim obj As DBObject = CType(trans.GetObject(id, OpenMode.ForRead),DBObject)
                        If (obj = Group) Then
                            Dim gr As Group = CType(obj,Group)
                            ed.WriteMessage(""& vbLf&"Group Name: {0}", gr.Name)
                        End If
                    Next
                End If
            End If
            trans.Commit
        Finally
            trans.Dispose
        End Try
    End Sub



''''groups
'Here you go: public class GroupCreator { [CommandMethod("mygroup")] public void DoIt() 
'{ Editor ed = Application.DocumentManager.MdiActiveDocument.Editor; PromptSelectionResult res = ed.GetSelection(); 
'if (res.Status != PromptStatus.OK) return; Database db = Application.DocumentManager.MdiActiveDocument.Database; '
'using (Transaction t = db.TransactionManager.StartTransaction()) 
' DBDictionary groupDict = (DBDictionary)t.GetObject(db.GroupDictionaryId,OpenMode.ForWrite); 
'//create group using (Group gr = new Group("This is Mikko's example group",true)) '
'{ groupDict.SetAt("Mikko",gr); t.AddNewlyCreatedDBObject(gr,true); '
'ObjectId[] ids = res.Value.GetObjectIds(); for (int i=0;i); } t.Commit(); } } } '



'''''''''''''''''''''''''''
Const connString = "server=localhost;database=northwind;uid=sa;pwd="
    Public connCustSvc As SqlClient.SqlConnection
    Public daCustomer As SqlClient.SqlDataAdapter
    Public cbCustomer As SqlClient.SqlCommandBuilder
    Public daOrders As SqlClient.SqlDataAdapter
    Public cbOrders As SqlClient.SqlCommandBuilder
    Public daOrderDetail As SqlClient.SqlDataAdapter
    Public cbOrderDetail As SqlClient.SqlCommandBuilder
    Public dsAllData As DataSet
    Public Sub Main()
        connCustSvc = New SqlClient.SqlConnection(connString)
        daCustomer = New SqlClient.SqlDataAdapter("SELECT * FROM
                         Customer", connCustSvc)
        cbCustomer = New SqlClient.SqlCommandBuilder(daCustomer)
        daOrders = New SqlClient.SqlDataAdapter("SELECT * FROM Orders", 
                       connCustSvc)
        cbOrders = New SqlClient.SqlCommandBuilder(daOrders)
        daOrderDetail = New SqlClient.SqlDataAdapter("SELECT * FROM 
                            OrderDetail", connCustSvc)
        cbOrderDetail = New SqlClient.SqlCommandBuilder(daOrderDetail)
        dsAllData = New DataSet()
        daCustomer.MissingSchemaAction = MissingSchemaAction.AddWithKey
        daCustomer.Fill(dsAllData, "Customer")
        daOrders.MissingSchemaAction = MissingSchemaAction.AddWithKey
        daOrders.Fill(dsAllData, "Orders")
        dsAllData.Tables("Orders").Columns("Total").DefaultValue = 0
        daOrderDetail.MissingSchemaAction = 
            MissingSchemaAction.AddWithKey
        daOrderDetail.Fill(dsAllData, "OrderDetail")
        Application.Run(New frmCustomerMaintenance())
    End Sub


--------------------------------------------------------------------------------

Figure 3 New Order with Detail Records
Private Sub CreateOrder()
    Dim dr As DataRow
    dr = dsAllData.Tables("Orders").NewRow
    With dr
        .Item("DateOrdered") = Now
        .Item("CustomerID") = 1
        .Item("ShipToAddress") = "123 Main"
        .Item("ShipToCity") = "Kansas City"
        .Item("ShipToState") = "MO"
        .Item("ShipToZip") = "12345"
    End With
    dsAllData.Tables("Orders").Rows.Add(dr)
    AddOrderDetail(dr.Item("ID"), 1, 1, 9.99)
    AddOrderDetail(dr.Item("ID"), 2, 2, 4.99)
    daOrders.Update(dsAllData.Tables("Orders"))
    daOrderDetail.Update(dsAllData.Tables("OrderDetail"))
End Sub

Private Sub AddOrderDetail(ByVal OrderID As Integer, _ 
    ByVal ProductID As Integer, ByVal Quantity As Integer, _
    ByVal Price As Single)

    Dim dr As DataRow
    dr = dsAllData.Tables("OrderDetail").NewRow
    With dr
        .Item("OrderID") = OrderID
        .Item("ProductID") = ProductID
        .Item("Quantity") = Quantity
        .Item("Price") = Price
    End With
    dsAllData.Tables("OrderDetail").Rows.Add(dr)
End Sub


--------------------------------------------------------------------------------

Figure 5 Updating the Total Column
CREATE TRIGGER trg_UpdateOrderTotal ON [dbo].[OrderDetail] 
FOR INSERT, UPDATE, DELETE 
AS
DECLARE @OrderID int
SELECT @OrderID=OrderID FROM Inserted
IF @OrderID IS NULL
    SELECT @OrderID=OrderID FROM Deleted
UPDATE Orders
SET Total=
    (
    SELECT Sum(Price*Quantity)
    FROM OrderDetail
    WHERE OrderID=@OrderID
    )
WHERE ID=@OrderID


--------------------------------------------------------------------------------

Figure 7 Catching the Concurrency Exception
Try
  daCustomer.Update(dsAllData.Tables("Customer"))
Catch dbcEx As Data.DBConcurrencyException
  Dim dResult As DialogResult
  dResult = MessageBox.Show(messageString, _
    "Data Concurrency Exception Occurred", _
    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error, _
    MessageBoxDefaultButton.Button1, _           
    MessageBoxOptions.DefaultDesktopOnly)
  If dResult = DialogResult.Yes Then
    'Two options: Fill the whole table, or just refresh the row
    'daCustomer.Fill(dsAllData.Tables("Customer"))
    UpdateRow("Customer", dbcEx.Row.Item("ID"))
  ElseIf dResult = DialogResult.No Then
    'Save a copy of the new row
    Dim drCopy As DataRow, drCurrent As DataRow
    drCopy = dsAllData.Tables("Customer").NewRow()
    Dim dc As DataColumn
    drCurrent = dsAllData.Tables("Customer").Rows.Find(dbcEx.Row.Item("ID"))
    For Each dc In drCurrent.Table.Columns
      If dc.ReadOnly = False Then _
        drCopy.Item(dc.ColumnName) = drCurrent.Item(dc.ColumnName)
    Next

    'Get the current values from the database
    UpdateRow("Customer", dbcEx.Row.Item("ID"))

    'Now restore the values entered by the user and save again
    For Each dc In drCurrent.Table.Columns
      If dc.ReadOnly = False Then _
        drCurrent.Item(dc.ColumnName) = drCopy.Item(dc.ColumnName)
    Next

    daCustomer.Update(dsAllData.Tables("Customer"))
  End If
End Try


--------------------------------------------------------------------------------

Figure 9 UpdateRow Routine Updates Cached DataRow
Private Sub UpdateRow(ByVal TableName As String, ByVal ID As Integer)
  'Get a reference to the specified row
  Dim dr As DataRow = dsAllData.Tables(TableName).Rows.Find(ID)

   'Create a Command update to pull the new underlying data
  Dim cmd As New SqlClient.SqlCommand("SELECT * FROM " & TableName & _
   " WHERE ID=" & ID.ToString(), connCustSvc)

  'Open the connection and create the DataReader
  connCustSvc.Open()
  Dim rdr As SqlClient.SqlDataReader = cmd.ExecuteReader()
  rdr.Read()

  'Copy the new data from the database to the DataRow
  Dim dc As DataColumn
  For Each dc In dr.Table.Columns
    If dc.ReadOnly = False Then _
     dr.Item(dc.ColumnName) = rdr.Item(dc.ColumnName)
  Next

  'Accept changes in the DataRow
  dr.AcceptChanges()
  connCustSvc.Close()
End Sub












'''''''''''''''''''''''''''' another jig
Imports System
 
Imports Autodesk.AutoCAD.Runtime
Imports Autodesk.AutoCAD.EditorInput
Imports Autodesk.AutoCAD.Geometry
Imports Autodesk.AutoCAD.DatabaseServices
Imports Autodesk.AutoCAD.GraphicsInterface
Imports Autodesk.AutoCAD.ApplicationServices
 
Public Class JigLine
    Inherits DrawJig
 
#Region "private member fields"
 
    Private gptIns As Point3d
 
    Private pAngle As Double
    Private cAngle As Double
    Private _StartPoint As New Point3d(0, 0, 0)
    Private _OldEndPoint As Point3d
    Private _NewEndPoint As Point3d
 
    Private _entityToDrag As Entity
 
    Public Sub New()
 
    End Sub
 
#End Region
 
#Region "property"
 
    Public Property entityToDrag() As Entity
        Get
            Return _entityToDrag
        End Get
        Set(ByVal Value As Entity)
            _entityToDrag = Value
        End Set
    End Property
 
    Public Property Angle() As Double
        Get
            Return cAngle
        End Get
        Set(ByVal Value As Double)
            cAngle = Value
        End Set
    End Property
 
    Public Property Startpoint() As Point3d
        Get
            Return _StartPoint
        End Get
        Set(ByVal Value As Point3d)
            _StartPoint = Value
        End Set
    End Property
 
#End Region
 
#Region "JigLine"
 
    "JigLine")> _
    Public Function StartJig()
 
        Dim EndPoint As Point3d
        pAngle = Math.PI / 3.5
        EndPoint = New Point3d(_StartPoint.X + Math.Cos(pAngle) * 10, _
          _StartPoint.Y + Math.Sin(pAngle) * 10, 0)
        _OldEndPoint = EndPoint
 
        _entityToDrag = New Line(_StartPoint, EndPoint)
 
        Application.DocumentManager.MdiActiveDocument.Editor.Drag(Me)
 
    End Function
 
#End Region
 
#Region "Drag"
 
    Public Function Drag()
        ' 
        If _entityToDrag Is Nothing Then
            Throw New Exception("JigLine.Drag._entityToDrag")
        End If
 
        Application.DocumentManager.MdiActiveDocument.Editor.Drag(Me)
    End Function
 
#End Region
 
#Region "Sample"
 
    Protected Overrides Function Sampler(ByVal prompts As JigPrompts) As SamplerStatus
 
        Dim jigOpts As JigPromptOptions = New JigPromptOptions
        jigOpts.Message = "\n Select End Point: "
        jigOpts.BasePoint = _StartPoint
        jigOpts.UseBasePoint = True
 
        Dim rot As PromptPointResult = prompts.AcquirePoint(jigOpts)
        If rot.Status = PromptStatus.None Then
            Return SamplerStatus.OK
        End If
 
        _NewEndPoint = rot.Value
        If Not _NewEndPoint.Equals(_StartPoint) Then
 
            If CursorHasMoved() Then
                ' rotate
                Dim scale As Double = _StartPoint.DistanceTo(_NewEndPoint) / 10
 
                entityToDrag.TransformBy(Matrix3d.Scaling(scale, _StartPoint))
 
                _OldEndPoint = _NewEndPoint
 
                Return SamplerStatus.OK
            Else
                Return SamplerStatus.NoChange
            End If
        End If
 
    End Function
 
#End Region
 
#Region "WorldDraw"
 
    Protected Overrides Function WorldDraw(ByVal draw As WorldDraw) As Boolean
 
        draw.Geometry.Draw(entityToDrag)
        Return True
 
    End Function
 
#End Region
 
#Region "CursorHasMoved "
 
    Private Function CursorHasMoved() As Boolean
 
        Dim myTolerance As Tolerance = New Tolerance(0.001, 0.01)
 
        Return Not (_OldEndPoint.Equals(_NewEndPoint))
 
    End Function
 
#End Region
 
End Class
 




''''''''''''''''''''''''
Example : There is no "Move" method, but this shows how to do it. 

Dim fromPt As Point3d
Dim toPt As Point3d
Dim ptRes As PromptPointResult

ptRes = editor.GetPoint("Pick a from point")
If ptRes.Status <> PromptStatus.OK Then Return
fromPt = ptRes.Value

ptRes = editor.GetPoint("Pick a to point")
If ptRes.Status <> PromptStatus.OK Then Return
toPt = ptRes.Value

Dim moveVec As New Vector3d(toPt.X - fromPt.X, toPt.Y - fromPt.Y, toPt.Z - fromPt.Z)
Dim moveMat As Matrix3d = Matrix3d.Displacement(moveVec)
ent.TransformBy(ent.Ecs.PostMultiplyBy(moveMat))




'''''''''''''''''''''''' jig
[using] System;

[using] Autodesk.AutoCAD.DatabaseServices;
[using] Autodesk.AutoCAD.Runtime;
[using] Autodesk.AutoCAD.Geometry;
[using] Autodesk.AutoCAD.EditorInput;
[using] Autodesk.AutoCAD.ApplicationServices;
[using] AcadApp = Autodesk.AutoCAD.ApplicationServices.Application;
[using] System.Reflection;


namespace CaddZone.AutoCAD.Samples.EditorInput
{
	public class InsertJig : EntityJig
	{
		public InsertJig(ObjectId BlockId, Point3d Position, Vector3d Normal)
			: base(new BlockReference(Position, BlockId))
		{
			BlockReference.Normal = Normal;
			position = Position;
		}

		protected override SamplerStatus Sampler(JigPrompts prompts)
		{
			JigPromptOptions jigOpts = new JigPromptOptions();
			jigOpts.UserInputControls = UserInputControls.Accept3dCoordinates;
			jigOpts.Message = "\nInsertion point: ";
			PromptPointResult res = prompts.AcquirePoint(jigOpts);
			Point3d curPoint = res.Value;
			if( position.DistanceTo(curPoint) > 1.0e-4 )
				position = curPoint;
			else
				return SamplerStatus.NoChange;

			if(res.Status == PromptStatus.Cancel)
				return SamplerStatus.Cancel;
			else
				return SamplerStatus.OK;
		}

		protected override bool Update()
		{
			try
			{
				if( this.BlockReference.Position.DistanceTo(position) > 1.0e-4 )
				{
					this.BlockReference.Position = position;
					return true;
				}
			}
			catch(System.Exception)
			{
			}
			return false;
		}

		public BlockReference BlockReference
		{
			get
			{
				return base.Entity as BlockReference;
			}
		}

		Point3d position;

	}

	// Test InsertJig from command line

	public class Class1
	{
		private Class1()
		{
		}

		[CommandMethod("DragInsertDemo")]
		public static void DragInsertDemo()
		{
			Database db = AcadApp.DocumentManager.MdiActiveDocument.Database;
			Editor ed = AcadApp.DocumentManager.MdiActiveDocument.Editor;
			Vector3d Normal = db.Ucsxdir.CrossProduct(db.Ucsydir);
			PromptStringOptions opts = new PromptStringOptions("\nBlock name: ");
			opts.AllowSpaces = true;
			[using]( DocumentLock docLock = ed.Document.LockDocument() )
			{
				PromptResult res = ed.GetString(opts);
				if( res.Status == PromptStatus.OK && res.StringResult.Trim() != string.Empty )
				{
					ObjectId block = GetBlockId(db, res.StringResult);
					if( block.IsNull )
					{
						ed.WriteMessage("\nBlock {0} not found.", res.StringResult);
						return;
					}
					InsertJig jig = new InsertJig(block, Point3d.Origin, Normal.GetNormal());
					res = ed.Drag(jig);
					if( res.Status == PromptStatus.OK )
					{
						[using] (Transaction tr = db.TransactionManager.StartTransaction())
						{
							BlockTable bt = (BlockTable) tr.GetObject(db.BlockTableId,OpenMode.ForRead,false);
							BlockTableRecord btr = (BlockTableRecord) tr.GetObject(bt[BlockTableRecord.ModelSpace],OpenMode.ForWrite,false);
							btr.AppendEntity(jig.BlockReference);
							tr.AddNewlyCreatedDBObject(jig.BlockReference,true);
							tr.Commit();
						}
					}
				}
			}
		}

		private static ObjectId GetBlockId(Database db, string Name)
		{
			ObjectId id = ObjectId.Null;
			[using]( Transaction tr = db.TransactionManager.StartTransaction() )
			{
				BlockTable blocks = (BlockTable) tr.GetObject(db.BlockTableId, OpenMode.ForRead);
				if( blocks.Has(Name) )
				{
					id = blocks[Name];
					if( id.IsErased )
					{
						foreach(ObjectId btrId in blocks)
						{
							if( ! id.IsErased )
							{
								BlockTableRecord rec = (BlockTableRecord) tr.GetObject(btrId, OpenMode.ForRead);
								if( string.Compare(rec.Name, Name, true) == 0 )
								{
									id = btrId;
									break;
								}
							}
						}
					}
				}
			}
			return id;
		}
	}

}






'orient a block
''''''''''''''''''''''
Point3d origin = new Point3d(0, 0, 0);
Matrix3d m = new Matrix3d();
Vector3d oldX = new Vector3d(1, 0, 0);
Vector3d oldY = new Vector3d(0, 1, 0);
Vector3d oldZ = new Vector3d(0, 0, 1);
m.SetToAlignCoordinateSystem(origin, oldX, oldY, oldZ, NewLocation, xVector,
yVector, 
xVector.CrossProduct(yVector));
bref.TransformBy(m);


''''''''''''''''''''
 Public Shared Sub test()
            ' Put your command code here
            Dim pt1 As Point3d = New Point3d(0, 0, 0)
            Dim pt2 As Point3d = New Point3d(10, 10, 0)
            Dim pt3 As Point3d = New Point3d(10, 20, 0)
            Dim cirArc As CircularArc3d = New CircularArc3d(pt1, pt2, pt3)
            Dim arc As Arc = New Arc(cirArc.Center, cirArc.Radius, cirArc.StartAngle, cirArc.EndAngle)
            Dim db As Database = Application.DocumentManager.MdiActiveDocument.Database
            Dim tm As DBTransMan = db.TransactionManager
            Dim trans As Transaction = tm.StartTransaction
            Dim bt As BlockTable = CType(tm.GetObject(db.BlockTableId, OpenMode.ForRead), BlockTable)
            Dim btr As BlockTableRecord = CType(tm.GetObject(bt(BlockTableRecord.ModelSpace), OpenMode.For, Write), BlockTableRecord)
            btr.AppendEntity(arc)
            tm.AddNewlyCreatedDBObject(arc, True)
            trans.Commit()
        End Sub

        Private Function convertArc2Arc(ByVal arc As CircularArc3d) As Arc
            Dim refVec As Vector3d = arc.ReferenceVector
            Dim plane As Plane = New Plane(arc.Center, arc.Normal)
            Dim ang As Double = refVec.AngleOnPlane(plane)
            Return New Arc(arc.Center, arc.Normal, arc.Radius, (arc.StartAngle + ang), (arc.EndAngle + ang))
        End Function
'''''''''''

static public void test() // This method can have any name
{
// Put your command code here
Point3d pt1=new Point3d(0,0,0);
Point3d pt2=new Point3d(10,10,0);
Point3d pt3=new Point3d(10,20,0);
CircularArc3d cirArc=new circularArc3d(pt1,pt2,pt3);
Arc arc=new Arc(cirArc.Center,cirArc.Radius,cirArc.StartAngle,cirArc.EndAngle);
Database db=Application.DocumentManager.MdiActiveDocument.Database;
DBTransMan tm=db.TransactionManager;
[using](Transaction trans=tm.StartTransaction())
{
BlockTable bt=(BlockTable)tm.GetObject(db.BlockTableId,OpenMode.ForRead);
BlockTableRecord btr=(BlockTableRecord)tm.GetObject(bt[BlockTableRecord.ModelSpace],OpenMode.For Write);
btr.AppendEntity(arc);
tm.AddNewlyCreatedDBObject(arc,true);
trans.Commit();
}
} 

''''
Arc convertArc2Arc( CircularArc3d arc )

{

Vector3d refVec = arc.ReferenceVector;

Plane plane = new Plane(arc.Center, arc.Normal);

double ang = refVec.AngleOnPlane(plane);

return new Arc(arc.Center, arc.Normal, arc.Radius,arc.StartAngle + ang, 
arc.EndAngle + ang );

}





''''''''''''''''''''''

            ' add multiple items to e024master item list
            Dim c As Integer
            Dim myRow As DataRow
            Dim response As System.Windows.Forms.DialogResult
            Dim cnt As Integer = DataSet14.E024ItemMasterInput.Count()

            For c = 0 To cnt - 1
                If dgE024ItmMstr.IsSelected(c) Then
                    myRow = DataSet14.E025BillofMaterialInputSubTable.NewRow()
                    Try
                        myRow("BillofMaterialInputNumber") = dgE025BOM.Item(c, 4) 'no val at 13 ???
                        myRow("ComponentPartNumber") = dgE024ItmMstr(c, 6)  '6 is col component part number
                    Catch ex As Exception
                        MessageBox.Show(ex.ToString)
                    End Try
                    DataSet14.E025BillofMaterialInputSubTable.Rows.Add(myRow)
                End If
            Next

            response = MessageBox.Show("Update Datasource ?", "Update Datasource ?", MessageBoxButtons.YesNo)
            Select Case response
                Case System.Windows.Forms.DialogResult.Yes
                    Try : daE025BillofMaterialInputSubTable.Update(DataSet14.E025BillofMaterialInputSubTable)
                    Catch dbcx As DBConcurrencyException
                        'createMessage(dbcx, "E024ItemMasterInput")
                    Catch ex As Exception
                        MessageBox.Show("Update Failed", ex.GetType().ToString())
                    End Try
                    DataSet14.Tables("E025BillofMaterialInputSubTable").Clear()
                    daE025BillofMaterialInputSubTable.Fill(DataSet14)
                Case Else
            End Select

''''''''''''''''''''''''



                                                    'MyNewRow = DataSet14.E044ReleasedDocuments.NewRow()
                                                    ''If BlkRefObj.IsDynamicBlock = True Then
                                                    ''ListBox3.Items.Add(BlkRefObj.DynamicBlockReferencePropertyCollection.Item(0).Value).ToString()
                                                    ''MyNewRow("ControlStamp") = BlkRefObj.DynamicBlockReferencePropertyCollection.Item(0).Value.ToString
                                                    ''End If
                                                    'MyNewRow("FileName") = split(split.Length - 1)
                                                    'MyNewRow("Layout") = lDicdEnt.Key
                                                    'MyNewRow("TitleBlock") = BlkName
                                                    'MyNewRow("RevisionBlock") = "Find Me"
                                                    '' must make new E044DRN or use current
                                                    'MyNewRow("DocumentReleaseNoticeNumber") = dgE044DRN.Item(dgE044DRN.CurrentRowIndex, 1)
                                                    'DataSet14.E044ReleasedDocuments.Rows.Add(MyNewRow)

                                                    'MyNewRow = Nothing : MyNewRow = DataSet14.E046SubTable.NewRow()
                                                    'MyNewRow("DocumentNumber") = 0
                                                    'MyNewRow("Revision") = "Find Me"
                                                    'MyNewRow("Description") = split(split.Length - 1) & " - " & lOut.LayoutName
                                                    'MyNewRow("SheetsQty") = 1
                                                    'MyNewRow("NumberofCopies") = 1
                                                    '' must make new E046CRN or use current
                                                    'MyNewRow("CopyRequestNumber") = dgE046CopyRequest.Item(dgE046CopyRequest.CurrentRowIndex, 0)
                                                    'DataSet14.E046SubTable.Rows.Add(MyNewRow)

                                                    ' fill the bom or the master items ?
                                                    'MyNewRow = Nothing : MyNewRow = DataSet14.E025BillofMaterialInputSubTable.NewRow()
                                                    'MyNewRow("QuantityPer") = 0
                                                    'MyNewRow("BOMItemNumber") = 0
                                                    'MyNewRow("ComponentPartNumber") = split(split.Length - 1) & " - " & lDicdEnt.Key
                                                    ' must make new E025bom or use current
                                                    'MyNewRow("BillofMaterialInputNumber") = DataGrid1.Item(DataGrid1.CurrentRowIndex, 4)
                                                    'DataSet14.E025BillofMaterialInputSubTable.Rows.Add(MyNewRow)








Private Sub daE025BillofMaterialInputSubTable_RowUpdated(ByVal sender As Object, ByVal e As System.Data.OleDb.OleDbRowUpdatedEventArgs) Handles daE025BillofMaterialInputSubTable.RowUpdated
            If e.Status = UpdateStatus.ErrorsOccurred Then
                e.Row.RowError = e.Errors.Message
                ' Add code to reconcile the error.
            End If
        End Sub

''''''''''''''''''''''
 Private Sub PrintRowErrs(ByVal myDataSet As DataSet)
            Dim myRow As DataRow
            Dim myTable As System.data.DataTable
            For Each myTable In myDataSet.Tables
                For Each myRow In myTable.Rows
                    If myRow.HasErrors Then
                        'Console.WriteLine(myRow.RowError)
                        myRow.ClearErrors()
                    End If
                Next
            Next
        End Sub
        Private Sub UpdateDataSet(ByVal myDataSet As DataSet)
            ' Check for changes with the HasChanges method first.
            If Not myDataSet.HasChanges(DataRowState.Modified) Then Exit Sub
            ' Create temporary DataSet variable.
            Dim xDataSet As DataSet
            ' GetChanges for modified rows only.
            xDataSet = myDataSet.GetChanges(DataRowState.Modified)
            ' Check the DataSet for errors.
            If xDataSet.HasErrors Then
                ' Insert code to resolve errors.
                PrintRowErrs(xDataSet)
                xDataSet.AcceptChanges()
            End If
            ' After fixing errors, update the data source with the DataAdapter 
            ' used to create the DataSet.
            daE025BillofMaterialInputSubTable.Update(xDataSet, "E025BillofMaterialInputSubTable")
        End Sub
''''''''''''''''''''''''

    Public Sub RunSqlTransaction(ByVal myConnString As String)
        Dim myConnection As New SqlConnection(myConnString)
        myConnection.Open()

        Dim myCommand As SqlCommand = myConnection.CreateCommand()
        Dim myTrans As SqlTransaction

        ' Start a local transaction
        myTrans = myConnection.BeginTransaction(IsolationLevel.ReadCommitted)
        ' Must assign both transaction object and connection
        ' to Command object for a pending local transaction
        myCommand.Connection = myConnection
        myCommand.Transaction = myTrans

        Try
            myCommand.CommandText = "Insert into Region (RegionID, RegionDescription) VALUES (100, 'Description')"
            myCommand.ExecuteNonQuery()
            myCommand.CommandText = "Insert into Region (RegionID, RegionDescription) VALUES (101, 'Description')"
            myCommand.ExecuteNonQuery()
            myTrans.Commit()
            Console.WriteLine("Both records are written to database.")
        Catch e As Exception
            Try
                myTrans.Rollback()
            Catch ex As SqlException
                If Not myTrans.Connection Is Nothing Then
                    Console.WriteLine("An exception of type " & ex.GetType().ToString() & _
                                      " was encountered while attempting to roll back the transaction.")
                End If
            End Try

            Console.WriteLine("An exception of type " & e.GetType().ToString() & _
                            "was encountered while inserting the data.")
            Console.WriteLine("Neither record was written to database.")
        Finally
            myConnection.Close()
        End Try
    End Sub 'RunSqlTransaction



    ''''''''''''''''''''''''''

    'Dim dodlg As New DoForm
    'Dim OpID As String = ""
    'Private Function mkNew()
    ' Dim MyNewRow As DataRow : Dim classResponse As MsgBoxResult
    ' MyNewRow = DataSet14.E037EngineeringChange.NewRow
    ' MyNewRow("AffectedDocuments") = DataGrid5.Item(DataGrid5.CurrentRowIndex, 1) 'e044DrN num
    ' MyNewRow("Originator") = UCase(SystemInformation.UserName)
    ' MyNewRow("OriginatorDate") = UCase(Format(Now, "MMM/dd/yy").ToString)
    ' MyNewRow("OriginatorDepartment") = "CAD"
    '   dodlg.ShowDialog()
    ' MyNewRow("ClassofChange") = chdlg.ChngType
    ' DataSet14.E037EngineeringChange.Rows.Add(MyNewRow)
    ' Try : daE037EngChng.Update(DataSet14.E037EngineeringChange) : Catch ex As Exception : MessageBox.Show(ex.ToString)
    ' End Try
    ' ecoID = MyNewRow.Item(11).ToString
    'End Function






    ''''''''''''
    'Try
    'oNewPlotSetting.PlotSettingsName = "AutoCAD PostScript File Writer.pc3"
    'With oPlotSettingsValidator
    '.SetStdScale(oNewPlotSetting, 1)
    '.SetUseStandardScale(oNewPlotSetting, True)
    '.SetStdScaleType(oNewPlotSetting, StdScaleType.StdScale1To1)
    '.SetPlotRotation(oNewPlotSetting, PlotRotation.Degrees000)
    '.SetPlotPaperUnits(oNewPlotSetting, PlotPaperUnit.Inches)
    '   Dim oWindow As New Autodesk.AutoCAD.DatabaseServices.Extents2d(0, 0, 34, 22)
    '.SetPlotType(oNewPlotSetting, Autodesk.AutoCAD.DatabaseServices.PlotType.Window)
    'oWindow = Nothing
    '.SetPlotWindowArea(oNewPlotSetting, oWindow)
    '.SetPlotOrigin(oNewPlotSetting, ac2dOriginPoint)
    '.SetPlotCentered(oNewPlotSetting, True)
    '.SetPlotOrigin(oNewPlotSetting, ac2dOriginPoint)
    '.SetZoomToPaperOnUpdate(oNewPlotSetting, True)
    '.SetCanonicalMediaName(oNewPlotSetting, MyBase.CananicalPaperSize)
    '.SetCurrentStyleSheet(oNewPlotSetting, "monochrome.ctb")
    'End With
    'Catch ex As Exception
    'End TryIf my_Layout.LayoutName <> "Model" Then
    '   Dim oNewPlotSetting As New PlotSettings(False) ' False Paperspace, True ModelSpace
    'Try
    'oNewPlotSetting.PlotSettingsName = PDFDeviceName ' looking for .pc3 file name
    'oNewPlotSetting.PlotSettingsName = "AutoCAD PostScript File Writer.pc3"
    'oNewPlotSetting.PlotSettingsName = "Test this"
    'oNewPlotSetting.AddToPlotSettingsDictionary(oAcadDB)
    'With oPlotSettingsValidator
    '.SetPlotConfigurationName(oNewPlotSetting, PDFDeviceName, MyBase.FormatSize)
    '.SetStdScale(oNewPlotSetting, 1)
    '.SetUseStandardScale(oNewPlotSetting, True)
    '.SetStdScaleType(oNewPlotSetting, StdScaleType.StdScale1To1)
    '.SetPlotRotation(oNewPlotSetting, PlotRotation.Degrees000)
    '.SetPlotPaperUnits(oNewPlotSetting, PlotPaperUnit.Inches)
    'Dim oWindow As New Autodesk.AutoCAD.DatabaseServices.Extents2d(ac2dOriginPoint.X, ac2dOriginPoint.Y, ac2dURPoint.X, ac2dURPoint.Y)
    '    Dim oWindow As New Autodesk.AutoCAD.DatabaseServices.Extents2d(0, 0, 34, 22)
    '.SetPlotType(oNewPlotSetting, Autodesk.AutoCAD.DatabaseServices.PlotType.Window)
    'oWindow = Nothing
    '.SetPlotWindowArea(oNewPlotSetting, oWindow)
    '.SetPlotOrigin(oNewPlotSetting, ac2dOriginPoint)
    '.SetPlotCentered(oNewPlotSetting, True)
    '.SetPlotOrigin(oNewPlotSetting, ac2dOriginPoint)
    '.SetZoomToPaperOnUpdate(oNewPlotSetting, True)
    '.SetCanonicalMediaName(oNewPlotSetting, MyBase.CananicalPaperSize)
    '.SetCurrentStyleSheet(oNewPlotSetting, "monochrome.ctb")
    'End With

    'Catch ex As Exception
    'End Try


    'The "SetPlotType" line will work with "Layout" but it will not work with "Window"

    'oAcadTR = oAcadTM.StartTransaction
    'PSPlotSettings = CType(oAcadTR.GetObject(PSObjectID, OpenMode.ForWrite, False, False), PlotSettings)
    'Try
    'With oPSVal
    '.SetPlotConfigurationName(PSPlotSettings, "AutoCAD PostScript File Writer.pc3", MyBase.CananicalPaperSize)
    '.RefreshLists(PSPlotSettings)
    '.SetDefaultPlotConfig(PSPlotSettings)
    '.SetStdScale(PSPlotSettings, 1)
    '.SetUseStandardScale(PSPlotSettings, True)
    '.SetStdScaleType(PSPlotSettings, StdScaleType.StdScale1To1)
    '.SetPlotRotation(PSPlotSettings, PlotRotation.Degrees000)
    'Dim oWindow As New Autodesk.AutoCAD.DatabaseServices.Extents2d(myInsPoint.X, myInsPoint.Y, myInsPoint.X + MyBase.FormatWidth, myInsPoint.Y + MyBase.FormatHeight)

    '.SetPlotPaperUnits(PSPlotSettings, PlotPaperUnit.Inches)
    '.SetPlotWindowArea(PSPlotSettings, oWindow)
    '.SetPlotType(PSPlotSettings, Autodesk.AutoCAD.DatabaseServices.PlotType.Window)
    'Dim oCusScale As New Autodesk.AutoCAD.DatabaseServices.CustomScale(1.0, 1.0)
    '.SetCustomPrintScale(PSPlotSettings, oCusScale)

    '.SetPlotCentered(PSPlotSettings, True)
    '.SetZoomToPaperOnUpdate(PSPlotSettings, True)
    '.SetCanonicalMediaName(PSPlotSettings, MyBase.CananicalPaperSize)
    '.SetCurrentStyleSheet(PSPlotSettings, "monochrome.ctb")
    'End With
    'oAcadTR.Commit()
    'Catch ex As Exception
    'End Try






    '''''''
    'Private WithEvents helpLabel As System.Windows.Forms.Label
    ' Help Label
    'Me.helpLabel = New System.Windows.Forms.Label
    'Me.helpLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    'Me.helpLabel.Location = New System.Drawing.Point(8, 80)
    'Me.helpLabel.Size = New System.Drawing.Size(272, 72)
    'Me.helpLabel.Text = "Click on any control to give it focus, and then " & _
    '"press F1 to display help for that" + " control.  Alternately, you can " & _
    '"click the help button at the top of the dialog and then click on a control."

    'Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    'Me.HelpButton = True
    'Me.MaximizeBox = False
    'Me.MinimizeBox = False
    'Me.Text = "Help Event Demonstration"

    '''''
    'Private Sub textBox_HelpRequested(ByVal sender As Object, ByVal hlpevent As System.Windows.Forms.HelpEventArgs) Handles DataGrid1.HelpRequested ', cityTextBox.HelpRequested
    ' This event is raised when the F1 key is pressed or the
    ' Help cursor is clicked on any of the address fields.
    ' The Help text for the field is in the control's
    ' Tag property. It is retrieved and displayed in the label.
    'Dim requestingControl As Control = CType(sender, Control)
    'helpLabel.Text = CStr(requestingControl.Tag)
    'hlpevent.Handled = True
    'End Sub

    ''''''''''''''''''''''''
    'Private Shared Sub Row_Changed(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
    'Console.WriteLine("Row_Changed Event: name={0}; action={1}", _
    '   e.Row("name"), e.Action)
    ' MessageBox.Show("Row_Changed Event: name={0}; action={1}", e.Row("name"), e.Action)
    'End Sub
    'Private Shared Sub DataTableRowChanged()
    'Dim custTable As System.Data.DataTable = New System.Data.DataTable("Customers")
    ' add columns
    'custTable.Columns.Add("id", Type.GetType("System.Int32"))
    'custTable.Columns.Add("name", Type.GetType("System.String"))
    'custTable.Columns.Add("address", Type.GetType("System.String"))
    ' set PrimaryKey
    'custTable.Columns("id").Unique = True
    'custTable.PrimaryKey = New System.Data.DataColumn() {custTable.Columns("id")}
    ' add a RowChanged event handler for the table.
    'AddHandler custTable.RowChanged, New DataRowChangeEventHandler(AddressOf Row_Changed)
    ' add ten rows
    'Dim id As Integer
    'For id = 1 To 10
    'custTable.Rows.Add( _
    'New Object() {id, String.Format("customer{0}", id), String.Format("address{0}", id)})
    'Next
    'custTable.AcceptChanges() 'causes error string not formated correctly
    ' change the name column in all the rows
    'Dim row As DataRow
    'For Each row In custTable.Rows
    'row("name") = String.Format("vip{0}", row("id"))
    'Next
    'End Sub
    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    'DataTableRowChanged()
    'End Sub
    '''''''''''''''''''''''''''''

    ''''

    'Dim transMan As Autodesk.AutoCAD.ApplicationServices.TransactionManager = db.TransactionManager
    'transMan.FlushGraphics()

    '''''''''
    'Dim flDepMan As FileDependencyManager = db.FileDependencyManager
    'flDepMan.IteratorInitialize("Acad:Ref", False, False, False)
    'MessageBox.Show(flDepMan.IteratorNext().ToString)



    ''''''''''''''
    'Re: Regen layer
    'Reference AcMgdInternal.dll, and then use:
    'Autodesk.AutoCAD.Internal.LayerUtilities.RegenLayers(
    'ObjectId[] layers, int regenPending);
    'The first parameter is an array contianing the ObjectId's 
    'of the LayerTableRecords for the layers to be regenerated.
    'For the second parameter, pass the result of this
    'static property on the same class:
    'Autodesk.AutoCAD.Internal.LayerUtilties.RegenPending;

    '''''''''''''''''''''''''''''''

    'Application.DocumentManager.MdiActiveDocument.Editor.WriteMessage(vbNewLine + "Hello World!" + vbNewLine)



    ''''''''''''''''''
    'Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument = Doc

    ''''''''''''''''''
    'Try
    '       DataSet14.Relations.Add("E025SubTable", _
    '       DataSet14.Tables("E025SubTable").Columns("ComponentPartNumber"), _
    '       DataSet14.Tables("E024ItemMasterInput").Columns("EngineeringPartNumber"))
    'Catch ex As Exception
    'MessageBox.Show(ex.ToString)
    'End Try



    '''''''''''''''
    'skip hidden columns
    'Dim colm As System.Data.DataColumn
    'For Each colm In dv.Table.Columns
    'If colm.ColumnMapping = MappingType.Hidden Then
    'MessageBox.Show("Hidden Column = " & colm.ColumnName)
    'End If
    'Next

    ''''''''

    '''''
    'Dim DocMan As Autodesk.AutoCAD.ApplicationServices.DocumentCollection


    ''''''''''''''''''
    'Get the name of a picked block

    ' Dim blkEnt As PromptEntityOptions = New PromptEntityOptions("Select Attribute ...")
    ' Dim blkEntRes As PromptEntityResult = ed.GetEntity(blkEnt)
    ' If blkEntRes.Status <> PromptStatus.OK Then
    'Me.Show()
    '  Return
    ' End If
    ' Dim Bent As Entity = trans.GetObject(blkEntRes.ObjectId, OpenMode.ForRead)
    ' If TypeOf Bent Is BlockReference Then
    'MessageBox.Show("Is Block")
    ' Dim blkRef As BlockReference = trans.GetObject(blkEntRes.ObjectId, OpenMode.ForRead)
    ' Dim br As BlockTableRecord = CType(trans.GetObject(blkRef.BlockTableRecord, OpenMode.ForRead, False), BlockTableRecord)
    ' MessageBox.Show("Block Name " & br.Name())

    '''''''''''

    ' MessageBox.Show("BlockID " & (att.BlockId).ToString())
    'this block table record indicates model and paper space

    ''''''''''''''''''
    'Dim strExpr As String
    'Dim strSort As String
    'strExpr = "BillofMaterialInputNumber = '" & DataGrid1.Item(DataGrid1.CurrentRowIndex, 4) & "'"
    'strSort = "BOMItemNumber DESC"
    'Dim foundRows As DataRow() = _
    'DataSet14.Tables("BillOfMaterials01").Select(strExpr, strSort, DataViewRowState.ModifiedCurrent)

    'DataGrid2.DataSource = foundRows











    ''''''''''''''''''''
    '   ObjectARX generally reports errors through return values.
    '   .NET uses exceptions
    '  Dim text As MText
    ' Dim bt As BlockTable
    'Dim btr As BlockTableRecord
    'Dim db As Database = HostApplicationServices.WorkingDatabase
    'Dim trans As Transaction
    'trans = db.TransactionManager.StartTransaction()
    'Try
    ' bt = trans.GetObject(db.BlockTableId, OpenMode.ForRead)
    ' btr = trans.GetObject(bt(btr.ModelSpace), OpenMode.ForWrite)
    '   Create new mtext and set text
    'Try
    'text = New MText
    'text.Contents = "Hello World!!"

    '   Append entity to model space
    'btr.AppendEntity(text)
    'trans.AddNewlyCreatedDBObject(text, True)
    'Finally
    'ensure that the mtext is diposed even if we throw
    'if we don't throw this does nothing
    '   text.Dispose()
    ' End Try
    ' trans.Commit()
    ' Finally '   Finally code is invoked whether there's an error or not
    'trans.Dispose()
    'End Try


End Module
