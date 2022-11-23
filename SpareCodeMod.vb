Module SpareCodeMod

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
using System;

using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.ApplicationServices;
using AcadApp = Autodesk.AutoCAD.ApplicationServices.Application;
using System.Reflection;


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
			using( DocumentLock docLock = ed.Document.LockDocument() )
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
						using (Transaction tr = db.TransactionManager.StartTransaction())
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
			using( Transaction tr = db.TransactionManager.StartTransaction() )
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
using(Transaction trans=tm.StartTransaction())
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
