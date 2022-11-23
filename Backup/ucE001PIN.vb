Option Explicit On 

Imports System.Windows.Forms
Imports rnsCadDataProj.nsMods


Namespace nsUserCtls

    Public Class ucE001PIN

        Inherits System.Windows.Forms.UserControl

#Region " Windows Form Designer generated code "

        Public Sub New()
            MyBase.New()

            'This call is required by the Windows Form Designer.
            InitializeComponent()

            'Add any initialization after the InitializeComponent() call

        End Sub

        'UserControl overrides dispose to clean up the component list.
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Not (components Is Nothing) Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
        Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
        Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
        Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
        Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
        Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
        Friend WithEvents cmnuE001PIN As System.Windows.Forms.ContextMenu
        Friend WithEvents miE001UpdateDs As System.Windows.Forms.MenuItem
        Friend WithEvents miE001PINAddNew As System.Windows.Forms.MenuItem
        Friend WithEvents miEP0102PNI_hlp As System.Windows.Forms.MenuItem
        Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
        Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.cmnuE001PIN = New System.Windows.Forms.ContextMenu
            Me.miE001PINAddNew = New System.Windows.Forms.MenuItem
            Me.miE001UpdateDs = New System.Windows.Forms.MenuItem
            Me.miEP0102PNI_hlp = New System.Windows.Forms.MenuItem
            Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
            Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
            Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
            Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
            Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
            Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter
            Me.DataGrid1 = New System.Windows.Forms.DataGrid
            Me.Splitter1 = New System.Windows.Forms.Splitter
            Me.Panel1 = New System.Windows.Forms.Panel
            Me.TextBox1 = New System.Windows.Forms.TextBox
            CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'cmnuE001PIN
            '
            Me.cmnuE001PIN.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miE001PINAddNew, Me.miE001UpdateDs, Me.miEP0102PNI_hlp})
            '
            'miE001PINAddNew
            '
            Me.miE001PINAddNew.Index = 0
            Me.miE001PINAddNew.Text = "Add New Proj"
            '
            'miE001UpdateDs
            '
            Me.miE001UpdateDs.Index = 1
            Me.miE001UpdateDs.Text = "Update E001PIN Datasource"
            '
            'miEP0102PNI_hlp
            '
            Me.miEP0102PNI_hlp.Index = 2
            Me.miEP0102PNI_hlp.Text = "EP 01-02 Product Introduction Notice Help"
            '
            'OleDbSelectCommand1
            '
            Me.OleDbSelectCommand1.CommandText = "SELECT Engineer, EngineerDate, EngineeringManager, EngineeringManagerDate, ProdIn" & _
            "trNoticeNumID, Product, ProjectClassification, ProjectDepartment, ProjectIs, Pro" & _
            "jectNumber, ProjectTitle, ProjectType, PurposeOfProject, SpecifyOtherProjectClas" & _
            "sification FROM E001ProductIntroductionNotice"
            Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
            '
            'OleDbConnection1
            '
            Me.OleDbConnection1.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database L" & _
            "ocking Mode=1;Data Source=""C:\Gary\NetCad2006\Database\DBTest.mdb"";Jet OLEDB:Eng" & _
            "ine Type=5;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLE" & _
            "DB:SFP=False;persist security info=False;Extended Properties=;Mode=Share Deny No" & _
            "ne;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Create System Database=False;Jet O" & _
            "LEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair" & _
            "=False;User ID=Admin;Jet OLEDB:Global Bulk Transactions=1"
            '
            'OleDbInsertCommand1
            '
            Me.OleDbInsertCommand1.CommandText = "INSERT INTO E001ProductIntroductionNotice(Engineer, EngineerDate, EngineeringMana" & _
            "ger, EngineeringManagerDate, Product, ProjectClassification, ProjectDepartment, " & _
            "ProjectIs, ProjectNumber, ProjectTitle, ProjectType, PurposeOfProject, SpecifyOt" & _
            "herProjectClassification) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"
            Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
            Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Engineer", System.Data.OleDb.OleDbType.VarWChar, 50, "Engineer"))
            Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("EngineerDate", System.Data.OleDb.OleDbType.DBDate, 0, "EngineerDate"))
            Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("EngineeringManager", System.Data.OleDb.OleDbType.VarWChar, 50, "EngineeringManager"))
            Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("EngineeringManagerDate", System.Data.OleDb.OleDbType.DBDate, 0, "EngineeringManagerDate"))
            Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Product", System.Data.OleDb.OleDbType.VarWChar, 50, "Product"))
            Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ProjectClassification", System.Data.OleDb.OleDbType.VarWChar, 50, "ProjectClassification"))
            Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ProjectDepartment", System.Data.OleDb.OleDbType.VarWChar, 50, "ProjectDepartment"))
            Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ProjectIs", System.Data.OleDb.OleDbType.VarWChar, 50, "ProjectIs"))
            Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ProjectNumber", System.Data.OleDb.OleDbType.VarWChar, 50, "ProjectNumber"))
            Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ProjectTitle", System.Data.OleDb.OleDbType.VarWChar, 0, "ProjectTitle"))
            Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ProjectType", System.Data.OleDb.OleDbType.VarWChar, 50, "ProjectType"))
            Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("PurposeOfProject", System.Data.OleDb.OleDbType.VarWChar, 0, "PurposeOfProject"))
            Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("SpecifyOtherProjectClassification", System.Data.OleDb.OleDbType.VarWChar, 0, "SpecifyOtherProjectClassification"))
            '
            'OleDbUpdateCommand1
            '
            Me.OleDbUpdateCommand1.CommandText = "UPDATE E001ProductIntroductionNotice SET Engineer = ?, EngineerDate = ?, Engineer" & _
            "ingManager = ?, EngineeringManagerDate = ?, Product = ?, ProjectClassification =" & _
            " ?, ProjectDepartment = ?, ProjectIs = ?, ProjectNumber = ?, ProjectTitle = ?, P" & _
            "rojectType = ?, PurposeOfProject = ?, SpecifyOtherProjectClassification = ? WHER" & _
            "E (ProdIntrNoticeNumID = ?) AND (Engineer = ? OR ? IS NULL AND Engineer IS NULL)" & _
            " AND (EngineerDate = ? OR ? IS NULL AND EngineerDate IS NULL) AND (EngineeringMa" & _
            "nager = ? OR ? IS NULL AND EngineeringManager IS NULL) AND (EngineeringManagerDa" & _
            "te = ? OR ? IS NULL AND EngineeringManagerDate IS NULL) AND (Product = ? OR ? IS" & _
            " NULL AND Product IS NULL) AND (ProjectClassification = ? OR ? IS NULL AND Proje" & _
            "ctClassification IS NULL) AND (ProjectDepartment = ? OR ? IS NULL AND ProjectDep" & _
            "artment IS NULL) AND (ProjectIs = ? OR ? IS NULL AND ProjectIs IS NULL) AND (Pro" & _
            "jectNumber = ? OR ? IS NULL AND ProjectNumber IS NULL) AND (ProjectType = ? OR ?" & _
            " IS NULL AND ProjectType IS NULL)"
            Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Engineer", System.Data.OleDb.OleDbType.VarWChar, 50, "Engineer"))
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("EngineerDate", System.Data.OleDb.OleDbType.DBDate, 0, "EngineerDate"))
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("EngineeringManager", System.Data.OleDb.OleDbType.VarWChar, 50, "EngineeringManager"))
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("EngineeringManagerDate", System.Data.OleDb.OleDbType.DBDate, 0, "EngineeringManagerDate"))
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Product", System.Data.OleDb.OleDbType.VarWChar, 50, "Product"))
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ProjectClassification", System.Data.OleDb.OleDbType.VarWChar, 50, "ProjectClassification"))
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ProjectDepartment", System.Data.OleDb.OleDbType.VarWChar, 50, "ProjectDepartment"))
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ProjectIs", System.Data.OleDb.OleDbType.VarWChar, 50, "ProjectIs"))
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ProjectNumber", System.Data.OleDb.OleDbType.VarWChar, 50, "ProjectNumber"))
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ProjectTitle", System.Data.OleDb.OleDbType.VarWChar, 0, "ProjectTitle"))
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ProjectType", System.Data.OleDb.OleDbType.VarWChar, 50, "ProjectType"))
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("PurposeOfProject", System.Data.OleDb.OleDbType.VarWChar, 0, "PurposeOfProject"))
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("SpecifyOtherProjectClassification", System.Data.OleDb.OleDbType.VarWChar, 0, "SpecifyOtherProjectClassification"))
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProdIntrNoticeNumID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProdIntrNoticeNumID", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Engineer", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Engineer1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineerDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineerDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineerDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineerDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringManager", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringManager", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringManager1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringManager", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringManagerDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringManagerDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringManagerDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringManagerDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Product", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Product", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Product1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Product", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProjectClassification", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectClassification", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProjectClassification1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectClassification", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProjectDepartment", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectDepartment", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProjectDepartment1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectDepartment", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProjectIs", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectIs", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProjectIs1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectIs", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProjectNumber", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProjectNumber1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProjectType", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectType", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProjectType1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectType", System.Data.DataRowVersion.Original, Nothing))
            '
            'OleDbDeleteCommand1
            '
            Me.OleDbDeleteCommand1.CommandText = "DELETE FROM E001ProductIntroductionNotice WHERE (ProdIntrNoticeNumID = ?) AND (En" & _
            "gineer = ? OR ? IS NULL AND Engineer IS NULL) AND (EngineerDate = ? OR ? IS NULL" & _
            " AND EngineerDate IS NULL) AND (EngineeringManager = ? OR ? IS NULL AND Engineer" & _
            "ingManager IS NULL) AND (EngineeringManagerDate = ? OR ? IS NULL AND Engineering" & _
            "ManagerDate IS NULL) AND (Product = ? OR ? IS NULL AND Product IS NULL) AND (Pro" & _
            "jectClassification = ? OR ? IS NULL AND ProjectClassification IS NULL) AND (Proj" & _
            "ectDepartment = ? OR ? IS NULL AND ProjectDepartment IS NULL) AND (ProjectIs = ?" & _
            " OR ? IS NULL AND ProjectIs IS NULL) AND (ProjectNumber = ? OR ? IS NULL AND Pro" & _
            "jectNumber IS NULL) AND (ProjectType = ? OR ? IS NULL AND ProjectType IS NULL)"
            Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
            Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProdIntrNoticeNumID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProdIntrNoticeNumID", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Engineer", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Engineer1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineerDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineerDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineerDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineerDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringManager", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringManager", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringManager1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringManager", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringManagerDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringManagerDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringManagerDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringManagerDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Product", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Product", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Product1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Product", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProjectClassification", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectClassification", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProjectClassification1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectClassification", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProjectDepartment", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectDepartment", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProjectDepartment1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectDepartment", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProjectIs", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectIs", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProjectIs1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectIs", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProjectNumber", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProjectNumber1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProjectType", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectType", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProjectType1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectType", System.Data.DataRowVersion.Original, Nothing))
            '
            'OleDbDataAdapter1
            '
            Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
            Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
            Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
            Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "E001ProductIntroductionNotice", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Engineer", "Engineer"), New System.Data.Common.DataColumnMapping("EngineerDate", "EngineerDate"), New System.Data.Common.DataColumnMapping("EngineeringManager", "EngineeringManager"), New System.Data.Common.DataColumnMapping("EngineeringManagerDate", "EngineeringManagerDate"), New System.Data.Common.DataColumnMapping("ProdIntrNoticeNumID", "ProdIntrNoticeNumID"), New System.Data.Common.DataColumnMapping("Product", "Product"), New System.Data.Common.DataColumnMapping("ProjectClassification", "ProjectClassification"), New System.Data.Common.DataColumnMapping("ProjectDepartment", "ProjectDepartment"), New System.Data.Common.DataColumnMapping("ProjectIs", "ProjectIs"), New System.Data.Common.DataColumnMapping("ProjectNumber", "ProjectNumber"), New System.Data.Common.DataColumnMapping("ProjectTitle", "ProjectTitle"), New System.Data.Common.DataColumnMapping("ProjectType", "ProjectType"), New System.Data.Common.DataColumnMapping("PurposeOfProject", "PurposeOfProject"), New System.Data.Common.DataColumnMapping("SpecifyOtherProjectClassification", "SpecifyOtherProjectClassification")})})
            Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
            '
            'DataGrid1
            '
            Me.DataGrid1.ContextMenu = Me.cmnuE001PIN
            Me.DataGrid1.DataMember = ""
            Me.DataGrid1.Dock = System.Windows.Forms.DockStyle.Top
            Me.DataGrid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
            Me.DataGrid1.Location = New System.Drawing.Point(0, 0)
            Me.DataGrid1.Name = "DataGrid1"
            Me.DataGrid1.PreferredColumnWidth = 125
            Me.DataGrid1.Size = New System.Drawing.Size(688, 248)
            Me.DataGrid1.TabIndex = 0
            '
            'Splitter1
            '
            Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Splitter1.Location = New System.Drawing.Point(0, 248)
            Me.Splitter1.Name = "Splitter1"
            Me.Splitter1.Size = New System.Drawing.Size(688, 3)
            Me.Splitter1.TabIndex = 1
            Me.Splitter1.TabStop = False
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.TextBox1)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel1.Location = New System.Drawing.Point(0, 251)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(688, 85)
            Me.Panel1.TabIndex = 2
            '
            'TextBox1
            '
            Me.TextBox1.Location = New System.Drawing.Point(16, 24)
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.Size = New System.Drawing.Size(400, 20)
            Me.TextBox1.TabIndex = 0
            Me.TextBox1.Text = "TextBox1"
            '
            'ucE001PIN
            '
            Me.Controls.Add(Me.Panel1)
            Me.Controls.Add(Me.Splitter1)
            Me.Controls.Add(Me.DataGrid1)
            Me.Name = "ucE001PIN"
            Me.Size = New System.Drawing.Size(688, 336)
            CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

#End Region


        Private Sub ucE001PIN_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

            If SqlDaComp.DataSet11.E001ProductIntroductionNotice.Count = 0 Then
                SqlDaComp.SqlConn.ConnectionString = words
                SqlDaComp.DaE001ProdIntro.Fill(SqlDaComp.DataSet11.E001ProductIntroductionNotice)
            End If
            DataGrid1.DataSource = SqlDaComp.DataSet11.E001ProductIntroductionNotice
            'ComboBox1.DataSource = SqlDaComp.DataSet11.E001ProductIntroductionNotice

        End Sub

        Private Sub miE001PINAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miE001PINAddNew.Click
            SqlDaComp.DataSet11.E001ProductIntroductionNotice.Clear()
            SqlDaComp.DaE001ProdIntro.Fill(SqlDaComp.DataSet11.E001ProductIntroductionNotice)
            Dim MyNewRow As DataRow ': Dim classResponse As MsgBoxResult
            MyNewRow = SqlDaComp.DataSet11.E001ProductIntroductionNotice.NewRow

            MyNewRow("ProjectNumber") = "?"
            MyNewRow("Engineer") = UCase(SystemInformation.UserName)
            MyNewRow("EngineerDate") = UCase(Format(Now, "MMM/dd/yy").ToString)
            MyNewRow("EngineeringManager") = UCase(SystemInformation.UserName)
            MyNewRow("EngineeringManagerDate") = UCase(Format(Now, "MMM/dd/yy").ToString)
            MyNewRow("Product") = "?"
            MyNewRow("ProjectTitle") = "?"
            MyNewRow("ProjectIs") = "?"
            MyNewRow("ProjectClassification") = "?"
            MyNewRow("SpecifyOtherProjectClassification") = "?"
            MyNewRow("ProjectDepartment") = "?"
            MyNewRow("ProjectType") = "?"
            MyNewRow("PurposeOfProject") = "?"


            SqlDaComp.DataSet11.E001ProductIntroductionNotice.Rows.Add(MyNewRow)
            Try : SqlDaComp.DaE001ProdIntro.Update(SqlDaComp.DataSet11.E001ProductIntroductionNotice)
            Catch dbcx As DBConcurrencyException
                'createMessage(dbcx,  "E044DocumentReleaseNotice")
            Catch ex As Exception
                MessageBox.Show("Update Failed", ex.GetType().ToString())
                MessageBox.Show(MyNewRow.RowError)
            End Try
            ' ecoID = MyNewRow.Item(11).ToString
            SqlDaComp.DataSet11.E001ProductIntroductionNotice.Clear()
            SqlDaComp.DaE001ProdIntro.Fill(SqlDaComp.DataSet11.E001ProductIntroductionNotice)

        End Sub

        Private Sub miE001UpdateDs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miE001UpdateDs.Click

            Try : SqlDaComp.DaE001ProdIntro.Update(SqlDaComp.DataSet11.E001ProductIntroductionNotice)
            Catch dbcx As DBConcurrencyException
                MessageBox.Show(dbcx.ToString)
                'createMessage(dbcx, "E037EngineeringChange")
            Catch ex As Exception
                MessageBox.Show("Update Failed", ex.GetType().ToString())
            End Try

        End Sub

        Private Sub miEP0102PNI_hlp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miEP0102PNI_hlp.Click
            Dim HelpFileName As String = pathStrToHandBook & "01 Product Design and Development.dwg"
            HlpDwg(HelpFileName, "EP-01-02 Product Introduction (1)", rOnly)
        End Sub

        Private Sub DataGrid1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGrid1.DoubleClick
            pinID = DataGrid1.Item(DataGrid1.CurrentRowIndex, 13)
            TextBox1.Text = pinID & "  " & DataGrid1.Item(DataGrid1.CurrentRowIndex, 6)

        End Sub

    End Class

End Namespace
