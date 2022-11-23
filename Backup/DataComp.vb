Namespace nsDataComp



    Public Class DataComp
        Inherits System.ComponentModel.Component

#Region " Component Designer generated code "

        Public Sub New(ByVal Container As System.ComponentModel.IContainer)
            MyClass.New()

            'Required for Windows.Forms Class Composition Designer support
            Container.Add(Me)
        End Sub

        Public Sub New()
            MyBase.New()

            'This call is required by the Component Designer.
            InitializeComponent()

            'Add any initialization after the InitializeComponent() call

        End Sub

        'Component overrides dispose to clean up the component list.
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Not (components Is Nothing) Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Required by the Component Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Component Designer
        'It can be modified using the Component Designer.
        'Do not modify it using the code editor.
        Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
        Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
        Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
        Friend WithEvents OleDbDeleteCommand2 As System.Data.OleDb.OleDbCommand
        Friend WithEvents daE046CopyRequest As System.Data.OleDb.OleDbDataAdapter
        Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
        Friend WithEvents OleDbUpdateCommand2 As System.Data.OleDb.OleDbCommand
        Friend WithEvents daE046SubTable As System.Data.OleDb.OleDbDataAdapter
        Friend WithEvents OleDbInsertCommand2 As System.Data.OleDb.OleDbCommand
        Friend WithEvents OleDbSelectCommand2 As System.Data.OleDb.OleDbCommand
        Friend WithEvents daE044ReleasedDocuments As System.Data.OleDb.OleDbDataAdapter
        Friend WithEvents OleDbDeleteCommand5 As System.Data.OleDb.OleDbCommand
        Friend WithEvents OleDbInsertCommand6 As System.Data.OleDb.OleDbCommand
        Friend WithEvents OleDbSelectCommand7 As System.Data.OleDb.OleDbCommand
        Friend WithEvents OleDbUpdateCommand5 As System.Data.OleDb.OleDbCommand
        Friend WithEvents daE044DocumentReleaseNotice As System.Data.OleDb.OleDbDataAdapter
        Friend WithEvents OleDbDeleteCommand4 As System.Data.OleDb.OleDbCommand
        Friend WithEvents OleDbInsertCommand5 As System.Data.OleDb.OleDbCommand
        Friend WithEvents OleDbSelectCommand6 As System.Data.OleDb.OleDbCommand
        Friend WithEvents OleDbUpdateCommand4 As System.Data.OleDb.OleDbCommand
        Friend WithEvents daE025BillofMaterialInputSubTable As System.Data.OleDb.OleDbDataAdapter
        Friend WithEvents OleDbDeleteCommand10 As System.Data.OleDb.OleDbCommand
        Friend WithEvents OleDbInsertCommand10 As System.Data.OleDb.OleDbCommand
        Friend WithEvents OleDbSelectCommand10 As System.Data.OleDb.OleDbCommand
        Friend WithEvents OleDbUpdateCommand10 As System.Data.OleDb.OleDbCommand
        Friend WithEvents daE024ItemMasterInput As System.Data.OleDb.OleDbDataAdapter
        Friend WithEvents OleDbDeleteCommand3 As System.Data.OleDb.OleDbCommand
        Friend WithEvents OleDbInsertCommand3 As System.Data.OleDb.OleDbCommand
        Friend WithEvents OleDbSelectCommand3 As System.Data.OleDb.OleDbCommand
        Friend WithEvents OleDbUpdateCommand3 As System.Data.OleDb.OleDbCommand
        Friend WithEvents daE025BillofMaterialInput As System.Data.OleDb.OleDbDataAdapter
        Friend WithEvents OleDbCommand1 As System.Data.OleDb.OleDbCommand
        Friend WithEvents OleDbCommand2 As System.Data.OleDb.OleDbCommand
        Friend WithEvents OleDbCommand3 As System.Data.OleDb.OleDbCommand
        Friend WithEvents OleDbCommand4 As System.Data.OleDb.OleDbCommand
        Friend WithEvents OleDbCommand5 As System.Data.OleDb.OleDbCommand
        Friend WithEvents OleDbCommand6 As System.Data.OleDb.OleDbCommand
        Friend WithEvents OleDbCommand7 As System.Data.OleDb.OleDbCommand
        Friend WithEvents OleDbCommand8 As System.Data.OleDb.OleDbCommand
        Friend WithEvents OleDbCommand9 As System.Data.OleDb.OleDbCommand
        Friend WithEvents OleDbCommand10 As System.Data.OleDb.OleDbCommand
        Friend WithEvents OleDbInsertCommand4 As System.Data.OleDb.OleDbCommand
        Friend WithEvents OleDbCommand11 As System.Data.OleDb.OleDbCommand
        Friend WithEvents OleDbCommand12 As System.Data.OleDb.OleDbCommand
        Friend WithEvents OleDbCommand13 As System.Data.OleDb.OleDbCommand
        Friend WithEvents daE003AsBlt As System.Data.OleDb.OleDbDataAdapter
        Friend WithEvents OleDbCommand14 As System.Data.OleDb.OleDbCommand
        Friend WithEvents OleDbCommand15 As System.Data.OleDb.OleDbCommand
        Friend WithEvents daE003AsBltSubTbl As System.Data.OleDb.OleDbDataAdapter
        Friend WithEvents OleDbSelectCommand4 As System.Data.OleDb.OleDbCommand
        Friend WithEvents daE002CBDSubTbl As System.Data.OleDb.OleDbDataAdapter
        Friend WithEvents OleDbCommand16 As System.Data.OleDb.OleDbCommand
        Friend WithEvents OleDbCommand17 As System.Data.OleDb.OleDbCommand
        Friend WithEvents OleDbCommand18 As System.Data.OleDb.OleDbCommand
        Friend WithEvents daE002CBD As System.Data.OleDb.OleDbDataAdapter
        Friend WithEvents DataSet11 As rnsCadDataProj.DataSet1
        Friend WithEvents OleDbSelectCommand8 As System.Data.OleDb.OleDbCommand
        Friend WithEvents OleDbInsertCommand8 As System.Data.OleDb.OleDbCommand
        Friend WithEvents OleDbUpdateCommand7 As System.Data.OleDb.OleDbCommand
        Friend WithEvents OleDbDeleteCommand7 As System.Data.OleDb.OleDbCommand
        Friend WithEvents daE037EngChng As System.Data.OleDb.OleDbDataAdapter
        Friend WithEvents OleDbSelectCommand5 As System.Data.OleDb.OleDbCommand
        Friend WithEvents OleDbInsertCommand7 As System.Data.OleDb.OleDbCommand
        Friend WithEvents OleDbUpdateCommand6 As System.Data.OleDb.OleDbCommand
        Friend WithEvents OleDbDeleteCommand6 As System.Data.OleDb.OleDbCommand
        Friend WithEvents daTrackingBlockNames As System.Data.OleDb.OleDbDataAdapter
        Friend WithEvents OleDbConn As System.Data.OleDb.OleDbConnection
        Friend WithEvents daE001ProdIntroNotice As System.Data.OleDb.OleDbDataAdapter
        Friend WithEvents OleDbSelectCommand12 As System.Data.OleDb.OleDbCommand
        Friend WithEvents OleDbInsertCommand12 As System.Data.OleDb.OleDbCommand
        Friend WithEvents OleDbUpdateCommand11 As System.Data.OleDb.OleDbCommand
        Friend WithEvents OleDbDeleteCommand11 As System.Data.OleDb.OleDbCommand
        Friend WithEvents daE045EngChPrtNumInput As System.Data.OleDb.OleDbDataAdapter
        Friend WithEvents daE045SubTable As System.Data.OleDb.OleDbDataAdapter
        Friend WithEvents OleDbSelectCommand9 As System.Data.OleDb.OleDbCommand
        Friend WithEvents OleDbInsertCommand9 As System.Data.OleDb.OleDbCommand
        Friend WithEvents OleDbUpdateCommand8 As System.Data.OleDb.OleDbCommand
        Friend WithEvents OleDbDeleteCommand8 As System.Data.OleDb.OleDbCommand
        Friend WithEvents OleDbSelectCommand11 As System.Data.OleDb.OleDbCommand
        Friend WithEvents OleDbInsertCommand11 As System.Data.OleDb.OleDbCommand
        Friend WithEvents OleDbUpdateCommand9 As System.Data.OleDb.OleDbCommand
        Friend WithEvents OleDbDeleteCommand9 As System.Data.OleDb.OleDbCommand
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
            Me.OleDbConn = New System.Data.OleDb.OleDbConnection
            Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
            Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
            Me.OleDbDeleteCommand2 = New System.Data.OleDb.OleDbCommand
            Me.daE046CopyRequest = New System.Data.OleDb.OleDbDataAdapter
            Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
            Me.OleDbUpdateCommand2 = New System.Data.OleDb.OleDbCommand
            Me.daE046SubTable = New System.Data.OleDb.OleDbDataAdapter
            Me.OleDbInsertCommand2 = New System.Data.OleDb.OleDbCommand
            Me.OleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand
            Me.daE044ReleasedDocuments = New System.Data.OleDb.OleDbDataAdapter
            Me.OleDbDeleteCommand5 = New System.Data.OleDb.OleDbCommand
            Me.OleDbInsertCommand6 = New System.Data.OleDb.OleDbCommand
            Me.OleDbSelectCommand7 = New System.Data.OleDb.OleDbCommand
            Me.OleDbUpdateCommand5 = New System.Data.OleDb.OleDbCommand
            Me.daE044DocumentReleaseNotice = New System.Data.OleDb.OleDbDataAdapter
            Me.OleDbDeleteCommand4 = New System.Data.OleDb.OleDbCommand
            Me.OleDbInsertCommand5 = New System.Data.OleDb.OleDbCommand
            Me.OleDbSelectCommand6 = New System.Data.OleDb.OleDbCommand
            Me.OleDbUpdateCommand4 = New System.Data.OleDb.OleDbCommand
            Me.daE025BillofMaterialInputSubTable = New System.Data.OleDb.OleDbDataAdapter
            Me.OleDbDeleteCommand10 = New System.Data.OleDb.OleDbCommand
            Me.OleDbInsertCommand10 = New System.Data.OleDb.OleDbCommand
            Me.OleDbSelectCommand10 = New System.Data.OleDb.OleDbCommand
            Me.OleDbUpdateCommand10 = New System.Data.OleDb.OleDbCommand
            Me.daE024ItemMasterInput = New System.Data.OleDb.OleDbDataAdapter
            Me.OleDbDeleteCommand3 = New System.Data.OleDb.OleDbCommand
            Me.OleDbInsertCommand3 = New System.Data.OleDb.OleDbCommand
            Me.OleDbSelectCommand3 = New System.Data.OleDb.OleDbCommand
            Me.OleDbUpdateCommand3 = New System.Data.OleDb.OleDbCommand
            Me.daE025BillofMaterialInput = New System.Data.OleDb.OleDbDataAdapter
            Me.OleDbCommand1 = New System.Data.OleDb.OleDbCommand
            Me.OleDbCommand2 = New System.Data.OleDb.OleDbCommand
            Me.OleDbCommand3 = New System.Data.OleDb.OleDbCommand
            Me.OleDbCommand4 = New System.Data.OleDb.OleDbCommand
            Me.OleDbCommand5 = New System.Data.OleDb.OleDbCommand
            Me.OleDbCommand6 = New System.Data.OleDb.OleDbCommand
            Me.OleDbCommand7 = New System.Data.OleDb.OleDbCommand
            Me.OleDbCommand8 = New System.Data.OleDb.OleDbCommand
            Me.OleDbCommand9 = New System.Data.OleDb.OleDbCommand
            Me.OleDbCommand10 = New System.Data.OleDb.OleDbCommand
            Me.OleDbInsertCommand4 = New System.Data.OleDb.OleDbCommand
            Me.OleDbCommand11 = New System.Data.OleDb.OleDbCommand
            Me.OleDbCommand12 = New System.Data.OleDb.OleDbCommand
            Me.OleDbCommand13 = New System.Data.OleDb.OleDbCommand
            Me.daE003AsBlt = New System.Data.OleDb.OleDbDataAdapter
            Me.OleDbCommand14 = New System.Data.OleDb.OleDbCommand
            Me.OleDbCommand15 = New System.Data.OleDb.OleDbCommand
            Me.daE003AsBltSubTbl = New System.Data.OleDb.OleDbDataAdapter
            Me.OleDbSelectCommand4 = New System.Data.OleDb.OleDbCommand
            Me.daE002CBDSubTbl = New System.Data.OleDb.OleDbDataAdapter
            Me.OleDbCommand16 = New System.Data.OleDb.OleDbCommand
            Me.OleDbCommand17 = New System.Data.OleDb.OleDbCommand
            Me.OleDbCommand18 = New System.Data.OleDb.OleDbCommand
            Me.daE002CBD = New System.Data.OleDb.OleDbDataAdapter
            Me.DataSet11 = New rnsCadDataProj.DataSet1
            Me.OleDbSelectCommand8 = New System.Data.OleDb.OleDbCommand
            Me.OleDbInsertCommand8 = New System.Data.OleDb.OleDbCommand
            Me.OleDbUpdateCommand7 = New System.Data.OleDb.OleDbCommand
            Me.OleDbDeleteCommand7 = New System.Data.OleDb.OleDbCommand
            Me.daE037EngChng = New System.Data.OleDb.OleDbDataAdapter
            Me.OleDbSelectCommand5 = New System.Data.OleDb.OleDbCommand
            Me.OleDbInsertCommand7 = New System.Data.OleDb.OleDbCommand
            Me.OleDbUpdateCommand6 = New System.Data.OleDb.OleDbCommand
            Me.OleDbDeleteCommand6 = New System.Data.OleDb.OleDbCommand
            Me.daTrackingBlockNames = New System.Data.OleDb.OleDbDataAdapter
            Me.daE001ProdIntroNotice = New System.Data.OleDb.OleDbDataAdapter
            Me.OleDbDeleteCommand11 = New System.Data.OleDb.OleDbCommand
            Me.OleDbInsertCommand12 = New System.Data.OleDb.OleDbCommand
            Me.OleDbSelectCommand12 = New System.Data.OleDb.OleDbCommand
            Me.OleDbUpdateCommand11 = New System.Data.OleDb.OleDbCommand
            Me.daE045EngChPrtNumInput = New System.Data.OleDb.OleDbDataAdapter
            Me.OleDbDeleteCommand8 = New System.Data.OleDb.OleDbCommand
            Me.OleDbInsertCommand9 = New System.Data.OleDb.OleDbCommand
            Me.OleDbSelectCommand9 = New System.Data.OleDb.OleDbCommand
            Me.OleDbUpdateCommand8 = New System.Data.OleDb.OleDbCommand
            Me.daE045SubTable = New System.Data.OleDb.OleDbDataAdapter
            Me.OleDbDeleteCommand9 = New System.Data.OleDb.OleDbCommand
            Me.OleDbInsertCommand11 = New System.Data.OleDb.OleDbCommand
            Me.OleDbSelectCommand11 = New System.Data.OleDb.OleDbCommand
            Me.OleDbUpdateCommand9 = New System.Data.OleDb.OleDbCommand
            CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            'OleDbSelectCommand1
            '
            Me.OleDbSelectCommand1.CommandText = "SELECT CopyRequestNumber, CRDate, DateRequired, DepartmentNumber, Mail, PickUp FR" & _
            "OM E046CopyRequest ORDER BY CopyRequestNumber DESC"
            Me.OleDbSelectCommand1.Connection = Me.OleDbConn
            '
            'OleDbConn
            '
            Me.OleDbConn.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database L" & _
            "ocking Mode=1;Data Source=""C:\NetCad2006\Database\DBTest.mdb"";Mode=Share Deny No" & _
            "ne;Jet OLEDB:Engine Type=5;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System d" & _
            "atabase=;Jet OLEDB:SFP=False;persist security info=False;Extended Properties=;Je" & _
            "t OLEDB:Compact Without Replica Repair=False;Jet OLEDB:Encrypt Database=False;Je" & _
            "t OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=Fals" & _
            "e;User ID=Admin;Jet OLEDB:Global Bulk Transactions=1"
            '
            'OleDbUpdateCommand1
            '
            Me.OleDbUpdateCommand1.CommandText = "UPDATE E046CopyRequest SET CRDate = ?, DateRequired = ?, DepartmentNumber = ?, Ma" & _
            "il = ?, PickUp = ? WHERE (CopyRequestNumber = ?) AND (CRDate = ? OR ? IS NULL AN" & _
            "D CRDate IS NULL) AND (DateRequired = ? OR ? IS NULL AND DateRequired IS NULL) A" & _
            "ND (DepartmentNumber = ? OR ? IS NULL AND DepartmentNumber IS NULL) AND (Mail = " & _
            "?) AND (PickUp = ?)"
            Me.OleDbUpdateCommand1.Connection = Me.OleDbConn
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CRDate", System.Data.OleDb.OleDbType.DBDate, 0, "CRDate"))
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("DateRequired", System.Data.OleDb.OleDbType.DBDate, 0, "DateRequired"))
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("DepartmentNumber", System.Data.OleDb.OleDbType.VarWChar, 50, "DepartmentNumber"))
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Mail", System.Data.OleDb.OleDbType.Boolean, 2, "Mail"))
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("PickUp", System.Data.OleDb.OleDbType.Boolean, 2, "PickUp"))
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CopyRequestNumber", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CopyRequestNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CRDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CRDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CRDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CRDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DateRequired", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateRequired", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DateRequired1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateRequired", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DepartmentNumber", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DepartmentNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DepartmentNumber1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DepartmentNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Mail", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mail", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PickUp", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PickUp", System.Data.DataRowVersion.Original, Nothing))
            '
            'OleDbDeleteCommand1
            '
            Me.OleDbDeleteCommand1.CommandText = "DELETE FROM E046CopyRequest WHERE (CopyRequestNumber = ?) AND (CRDate = ? OR ? IS" & _
            " NULL AND CRDate IS NULL) AND (DateRequired = ? OR ? IS NULL AND DateRequired IS" & _
            " NULL) AND (DepartmentNumber = ? OR ? IS NULL AND DepartmentNumber IS NULL) AND " & _
            "(Mail = ?) AND (PickUp = ?)"
            Me.OleDbDeleteCommand1.Connection = Me.OleDbConn
            Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CopyRequestNumber", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CopyRequestNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CRDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CRDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CRDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CRDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DateRequired", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateRequired", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DateRequired1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateRequired", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DepartmentNumber", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DepartmentNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DepartmentNumber1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DepartmentNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Mail", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mail", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PickUp", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PickUp", System.Data.DataRowVersion.Original, Nothing))
            '
            'OleDbDeleteCommand2
            '
            Me.OleDbDeleteCommand2.CommandText = "DELETE FROM E046SubTable WHERE (DocumentNumberID = ?) AND (CopyRequestNumber = ? " & _
            "OR ? IS NULL AND CopyRequestNumber IS NULL) AND (Description = ? OR ? IS NULL AN" & _
            "D Description IS NULL) AND (DocumentNumber = ? OR ? IS NULL AND DocumentNumber I" & _
            "S NULL) AND (NumberofCopies = ? OR ? IS NULL AND NumberofCopies IS NULL) AND (Re" & _
            "vision = ? OR ? IS NULL AND Revision IS NULL) AND (SheetsQty = ? OR ? IS NULL AN" & _
            "D SheetsQty IS NULL)"
            Me.OleDbDeleteCommand2.Connection = Me.OleDbConn
            Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DocumentNumberID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DocumentNumberID", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CopyRequestNumber", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CopyRequestNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CopyRequestNumber1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CopyRequestNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Description", System.Data.OleDb.OleDbType.VarWChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Description", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Description1", System.Data.OleDb.OleDbType.VarWChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Description", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DocumentNumber", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DocumentNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DocumentNumber1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DocumentNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NumberofCopies", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumberofCopies", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NumberofCopies1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumberofCopies", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Revision", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Revision", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Revision1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Revision", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SheetsQty", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SheetsQty", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SheetsQty1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SheetsQty", System.Data.DataRowVersion.Original, Nothing))
            '
            'daE046CopyRequest
            '
            Me.daE046CopyRequest.DeleteCommand = Me.OleDbDeleteCommand1
            Me.daE046CopyRequest.InsertCommand = Me.OleDbInsertCommand1
            Me.daE046CopyRequest.SelectCommand = Me.OleDbSelectCommand1
            Me.daE046CopyRequest.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "E046CopyRequest", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CopyRequestNumber", "CopyRequestNumber"), New System.Data.Common.DataColumnMapping("CRDate", "CRDate"), New System.Data.Common.DataColumnMapping("DateRequired", "DateRequired"), New System.Data.Common.DataColumnMapping("DepartmentNumber", "DepartmentNumber"), New System.Data.Common.DataColumnMapping("Mail", "Mail"), New System.Data.Common.DataColumnMapping("PickUp", "PickUp")})})
            Me.daE046CopyRequest.UpdateCommand = Me.OleDbUpdateCommand1
            '
            'OleDbInsertCommand1
            '
            Me.OleDbInsertCommand1.CommandText = "INSERT INTO E046CopyRequest(CRDate, DateRequired, DepartmentNumber, Mail, PickUp)" & _
            " VALUES (?, ?, ?, ?, ?)"
            Me.OleDbInsertCommand1.Connection = Me.OleDbConn
            Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CRDate", System.Data.OleDb.OleDbType.DBDate, 0, "CRDate"))
            Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("DateRequired", System.Data.OleDb.OleDbType.DBDate, 0, "DateRequired"))
            Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("DepartmentNumber", System.Data.OleDb.OleDbType.VarWChar, 50, "DepartmentNumber"))
            Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Mail", System.Data.OleDb.OleDbType.Boolean, 2, "Mail"))
            Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("PickUp", System.Data.OleDb.OleDbType.Boolean, 2, "PickUp"))
            '
            'OleDbUpdateCommand2
            '
            Me.OleDbUpdateCommand2.CommandText = "UPDATE E046SubTable SET CopyRequestNumber = ?, Description = ?, DocumentNumber = " & _
            "?, NumberofCopies = ?, Revision = ?, SheetsQty = ? WHERE (DocumentNumberID = ?) " & _
            "AND (CopyRequestNumber = ? OR ? IS NULL AND CopyRequestNumber IS NULL) AND (Desc" & _
            "ription = ? OR ? IS NULL AND Description IS NULL) AND (DocumentNumber = ? OR ? I" & _
            "S NULL AND DocumentNumber IS NULL) AND (NumberofCopies = ? OR ? IS NULL AND Numb" & _
            "erofCopies IS NULL) AND (Revision = ? OR ? IS NULL AND Revision IS NULL) AND (Sh" & _
            "eetsQty = ? OR ? IS NULL AND SheetsQty IS NULL)"
            Me.OleDbUpdateCommand2.Connection = Me.OleDbConn
            Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("CopyRequestNumber", System.Data.OleDb.OleDbType.Integer, 0, "CopyRequestNumber"))
            Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.VarWChar, 250, "Description"))
            Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("DocumentNumber", System.Data.OleDb.OleDbType.Integer, 0, "DocumentNumber"))
            Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("NumberofCopies", System.Data.OleDb.OleDbType.Integer, 0, "NumberofCopies"))
            Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Revision", System.Data.OleDb.OleDbType.VarWChar, 50, "Revision"))
            Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("SheetsQty", System.Data.OleDb.OleDbType.Integer, 0, "SheetsQty"))
            Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DocumentNumberID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DocumentNumberID", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CopyRequestNumber", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CopyRequestNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CopyRequestNumber1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CopyRequestNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Description", System.Data.OleDb.OleDbType.VarWChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Description", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Description1", System.Data.OleDb.OleDbType.VarWChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Description", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DocumentNumber", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DocumentNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DocumentNumber1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DocumentNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NumberofCopies", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumberofCopies", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NumberofCopies1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumberofCopies", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Revision", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Revision", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Revision1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Revision", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SheetsQty", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SheetsQty", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SheetsQty1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SheetsQty", System.Data.DataRowVersion.Original, Nothing))
            '
            'daE046SubTable
            '
            Me.daE046SubTable.DeleteCommand = Me.OleDbDeleteCommand2
            Me.daE046SubTable.InsertCommand = Me.OleDbInsertCommand2
            Me.daE046SubTable.SelectCommand = Me.OleDbSelectCommand2
            Me.daE046SubTable.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "E046SubTable", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CopyRequestNumber", "CopyRequestNumber"), New System.Data.Common.DataColumnMapping("Description", "Description"), New System.Data.Common.DataColumnMapping("DocumentNumber", "DocumentNumber"), New System.Data.Common.DataColumnMapping("DocumentNumberID", "DocumentNumberID"), New System.Data.Common.DataColumnMapping("NumberofCopies", "NumberofCopies"), New System.Data.Common.DataColumnMapping("Revision", "Revision"), New System.Data.Common.DataColumnMapping("SheetsQty", "SheetsQty")})})
            Me.daE046SubTable.UpdateCommand = Me.OleDbUpdateCommand2
            '
            'OleDbInsertCommand2
            '
            Me.OleDbInsertCommand2.CommandText = "INSERT INTO E046SubTable(CopyRequestNumber, Description, DocumentNumber, Numberof" & _
            "Copies, Revision, SheetsQty) VALUES (?, ?, ?, ?, ?, ?)"
            Me.OleDbInsertCommand2.Connection = Me.OleDbConn
            Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("CopyRequestNumber", System.Data.OleDb.OleDbType.Integer, 0, "CopyRequestNumber"))
            Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.VarWChar, 250, "Description"))
            Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("DocumentNumber", System.Data.OleDb.OleDbType.Integer, 0, "DocumentNumber"))
            Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("NumberofCopies", System.Data.OleDb.OleDbType.Integer, 0, "NumberofCopies"))
            Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Revision", System.Data.OleDb.OleDbType.VarWChar, 50, "Revision"))
            Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("SheetsQty", System.Data.OleDb.OleDbType.Integer, 0, "SheetsQty"))
            '
            'OleDbSelectCommand2
            '
            Me.OleDbSelectCommand2.CommandText = "SELECT CopyRequestNumber, Description, DocumentNumber, DocumentNumberID, Numberof" & _
            "Copies, Revision, SheetsQty FROM E046SubTable"
            Me.OleDbSelectCommand2.Connection = Me.OleDbConn
            '
            'daE044ReleasedDocuments
            '
            Me.daE044ReleasedDocuments.DeleteCommand = Me.OleDbDeleteCommand5
            Me.daE044ReleasedDocuments.InsertCommand = Me.OleDbInsertCommand6
            Me.daE044ReleasedDocuments.SelectCommand = Me.OleDbSelectCommand7
            Me.daE044ReleasedDocuments.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "E044ReleasedDocuments", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ControlStamp", "ControlStamp"), New System.Data.Common.DataColumnMapping("DocumentNumberID", "DocumentNumberID"), New System.Data.Common.DataColumnMapping("DocumentReleaseNoticeNumber", "DocumentReleaseNoticeNumber"), New System.Data.Common.DataColumnMapping("FileName", "FileName"), New System.Data.Common.DataColumnMapping("Layout", "Layout"), New System.Data.Common.DataColumnMapping("RevisionBlock", "RevisionBlock"), New System.Data.Common.DataColumnMapping("TitleBlock", "TitleBlock")})})
            Me.daE044ReleasedDocuments.UpdateCommand = Me.OleDbUpdateCommand5
            '
            'OleDbDeleteCommand5
            '
            Me.OleDbDeleteCommand5.CommandText = "DELETE FROM E044ReleasedDocuments WHERE (DocumentNumberID = ?) AND (ControlStamp " & _
            "= ? OR ? IS NULL AND ControlStamp IS NULL) AND (DocumentReleaseNoticeNumber = ? " & _
            "OR ? IS NULL AND DocumentReleaseNoticeNumber IS NULL) AND (FileName = ? OR ? IS " & _
            "NULL AND FileName IS NULL) AND (Layout = ? OR ? IS NULL AND Layout IS NULL) AND " & _
            "(RevisionBlock = ? OR ? IS NULL AND RevisionBlock IS NULL) AND (TitleBlock = ? O" & _
            "R ? IS NULL AND TitleBlock IS NULL)"
            Me.OleDbDeleteCommand5.Connection = Me.OleDbConn
            Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DocumentNumberID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DocumentNumberID", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ControlStamp", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ControlStamp", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ControlStamp1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ControlStamp", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DocumentReleaseNoticeNumber", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DocumentReleaseNoticeNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DocumentReleaseNoticeNumber1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DocumentReleaseNoticeNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_FileName", System.Data.OleDb.OleDbType.VarWChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FileName", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_FileName1", System.Data.OleDb.OleDbType.VarWChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FileName", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Layout", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Layout", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Layout1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Layout", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RevisionBlock", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RevisionBlock", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RevisionBlock1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RevisionBlock", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TitleBlock", System.Data.OleDb.OleDbType.VarWChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TitleBlock", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TitleBlock1", System.Data.OleDb.OleDbType.VarWChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TitleBlock", System.Data.DataRowVersion.Original, Nothing))
            '
            'OleDbInsertCommand6
            '
            Me.OleDbInsertCommand6.CommandText = "INSERT INTO E044ReleasedDocuments(ControlStamp, DocumentReleaseNoticeNumber, File" & _
            "Name, Layout, RevisionBlock, TitleBlock) VALUES (?, ?, ?, ?, ?, ?)"
            Me.OleDbInsertCommand6.Connection = Me.OleDbConn
            Me.OleDbInsertCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("ControlStamp", System.Data.OleDb.OleDbType.VarWChar, 50, "ControlStamp"))
            Me.OleDbInsertCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("DocumentReleaseNoticeNumber", System.Data.OleDb.OleDbType.Integer, 0, "DocumentReleaseNoticeNumber"))
            Me.OleDbInsertCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("FileName", System.Data.OleDb.OleDbType.VarWChar, 250, "FileName"))
            Me.OleDbInsertCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Layout", System.Data.OleDb.OleDbType.VarWChar, 50, "Layout"))
            Me.OleDbInsertCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("RevisionBlock", System.Data.OleDb.OleDbType.VarWChar, 50, "RevisionBlock"))
            Me.OleDbInsertCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("TitleBlock", System.Data.OleDb.OleDbType.VarWChar, 250, "TitleBlock"))
            '
            'OleDbSelectCommand7
            '
            Me.OleDbSelectCommand7.CommandText = "SELECT ControlStamp, FileName, Layout, TitleBlock, RevisionBlock, DocumentNumberI" & _
            "D, DocumentReleaseNoticeNumber FROM E044ReleasedDocuments"
            Me.OleDbSelectCommand7.Connection = Me.OleDbConn
            '
            'OleDbUpdateCommand5
            '
            Me.OleDbUpdateCommand5.CommandText = "UPDATE E044ReleasedDocuments SET ControlStamp = ?, DocumentReleaseNoticeNumber = " & _
            "?, FileName = ?, Layout = ?, RevisionBlock = ?, TitleBlock = ? WHERE (DocumentNu" & _
            "mberID = ?) AND (ControlStamp = ? OR ? IS NULL AND ControlStamp IS NULL) AND (Do" & _
            "cumentReleaseNoticeNumber = ? OR ? IS NULL AND DocumentReleaseNoticeNumber IS NU" & _
            "LL) AND (FileName = ? OR ? IS NULL AND FileName IS NULL) AND (Layout = ? OR ? IS" & _
            " NULL AND Layout IS NULL) AND (RevisionBlock = ? OR ? IS NULL AND RevisionBlock " & _
            "IS NULL) AND (TitleBlock = ? OR ? IS NULL AND TitleBlock IS NULL)"
            Me.OleDbUpdateCommand5.Connection = Me.OleDbConn
            Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("ControlStamp", System.Data.OleDb.OleDbType.VarWChar, 50, "ControlStamp"))
            Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("DocumentReleaseNoticeNumber", System.Data.OleDb.OleDbType.Integer, 0, "DocumentReleaseNoticeNumber"))
            Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("FileName", System.Data.OleDb.OleDbType.VarWChar, 250, "FileName"))
            Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Layout", System.Data.OleDb.OleDbType.VarWChar, 50, "Layout"))
            Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("RevisionBlock", System.Data.OleDb.OleDbType.VarWChar, 50, "RevisionBlock"))
            Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("TitleBlock", System.Data.OleDb.OleDbType.VarWChar, 250, "TitleBlock"))
            Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DocumentNumberID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DocumentNumberID", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ControlStamp", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ControlStamp", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ControlStamp1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ControlStamp", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DocumentReleaseNoticeNumber", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DocumentReleaseNoticeNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DocumentReleaseNoticeNumber1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DocumentReleaseNoticeNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_FileName", System.Data.OleDb.OleDbType.VarWChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FileName", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_FileName1", System.Data.OleDb.OleDbType.VarWChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FileName", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Layout", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Layout", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Layout1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Layout", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RevisionBlock", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RevisionBlock", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RevisionBlock1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RevisionBlock", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TitleBlock", System.Data.OleDb.OleDbType.VarWChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TitleBlock", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TitleBlock1", System.Data.OleDb.OleDbType.VarWChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TitleBlock", System.Data.DataRowVersion.Original, Nothing))
            '
            'daE044DocumentReleaseNotice
            '
            Me.daE044DocumentReleaseNotice.DeleteCommand = Me.OleDbDeleteCommand4
            Me.daE044DocumentReleaseNotice.InsertCommand = Me.OleDbInsertCommand5
            Me.daE044DocumentReleaseNotice.SelectCommand = Me.OleDbSelectCommand6
            Me.daE044DocumentReleaseNotice.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "E044DocumentReleaseNotice", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("DocumentControl", "DocumentControl"), New System.Data.Common.DataColumnMapping("DocumentReleaseNoticeNumberID", "DocumentReleaseNoticeNumberID"), New System.Data.Common.DataColumnMapping("DocumentReleasePhase", "DocumentReleasePhase"), New System.Data.Common.DataColumnMapping("Engineer", "Engineer"), New System.Data.Common.DataColumnMapping("EngineerDate", "EngineerDate"), New System.Data.Common.DataColumnMapping("EngineeringManager", "EngineeringManager"), New System.Data.Common.DataColumnMapping("EngineeringManagerDate", "EngineeringManagerDate"), New System.Data.Common.DataColumnMapping("Priority", "Priority"), New System.Data.Common.DataColumnMapping("ReleaseDate", "ReleaseDate")})})
            Me.daE044DocumentReleaseNotice.UpdateCommand = Me.OleDbUpdateCommand4
            '
            'OleDbDeleteCommand4
            '
            Me.OleDbDeleteCommand4.CommandText = "DELETE FROM E044DocumentReleaseNotice WHERE (DocumentReleaseNoticeNumberID = ?) A" & _
            "ND (DocumentControl = ? OR ? IS NULL AND DocumentControl IS NULL) AND (DocumentR" & _
            "eleasePhase = ? OR ? IS NULL AND DocumentReleasePhase IS NULL) AND (Engineer = ?" & _
            " OR ? IS NULL AND Engineer IS NULL) AND (EngineerDate = ? OR ? IS NULL AND Engin" & _
            "eerDate IS NULL) AND (EngineeringManager = ? OR ? IS NULL AND EngineeringManager" & _
            " IS NULL) AND (EngineeringManagerDate = ? OR ? IS NULL AND EngineeringManagerDat" & _
            "e IS NULL) AND (Priority = ? OR ? IS NULL AND Priority IS NULL) AND (ReleaseDate" & _
            " = ? OR ? IS NULL AND ReleaseDate IS NULL)"
            Me.OleDbDeleteCommand4.Connection = Me.OleDbConn
            Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DocumentReleaseNoticeNumberID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DocumentReleaseNoticeNumberID", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DocumentControl", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DocumentControl", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DocumentControl1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DocumentControl", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DocumentReleasePhase", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DocumentReleasePhase", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DocumentReleasePhase1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DocumentReleasePhase", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Engineer", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Engineer1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineerDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineerDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineerDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineerDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringManager", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringManager", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringManager1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringManager", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringManagerDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringManagerDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringManagerDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringManagerDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Priority", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Priority", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Priority1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Priority", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ReleaseDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReleaseDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ReleaseDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReleaseDate", System.Data.DataRowVersion.Original, Nothing))
            '
            'OleDbInsertCommand5
            '
            Me.OleDbInsertCommand5.CommandText = "INSERT INTO E044DocumentReleaseNotice(DocumentControl, DocumentReleasePhase, Engi" & _
            "neer, EngineerDate, EngineeringManager, EngineeringManagerDate, Priority, Releas" & _
            "eDate) VALUES (?, ?, ?, ?, ?, ?, ?, ?)"
            Me.OleDbInsertCommand5.Connection = Me.OleDbConn
            Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("DocumentControl", System.Data.OleDb.OleDbType.VarWChar, 50, "DocumentControl"))
            Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("DocumentReleasePhase", System.Data.OleDb.OleDbType.VarWChar, 50, "DocumentReleasePhase"))
            Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Engineer", System.Data.OleDb.OleDbType.VarWChar, 50, "Engineer"))
            Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("EngineerDate", System.Data.OleDb.OleDbType.DBDate, 0, "EngineerDate"))
            Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("EngineeringManager", System.Data.OleDb.OleDbType.VarWChar, 50, "EngineeringManager"))
            Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("EngineeringManagerDate", System.Data.OleDb.OleDbType.DBDate, 0, "EngineeringManagerDate"))
            Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Priority", System.Data.OleDb.OleDbType.VarWChar, 50, "Priority"))
            Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("ReleaseDate", System.Data.OleDb.OleDbType.DBDate, 0, "ReleaseDate"))
            '
            'OleDbSelectCommand6
            '
            Me.OleDbSelectCommand6.CommandText = "SELECT DocumentControl, DocumentReleaseNoticeNumberID, DocumentReleasePhase, Engi" & _
            "neer, EngineerDate, EngineeringManager, EngineeringManagerDate, Priority, Releas" & _
            "eDate FROM E044DocumentReleaseNotice ORDER BY DocumentReleaseNoticeNumberID DESC" & _
            ""
            Me.OleDbSelectCommand6.Connection = Me.OleDbConn
            '
            'OleDbUpdateCommand4
            '
            Me.OleDbUpdateCommand4.CommandText = "UPDATE E044DocumentReleaseNotice SET DocumentControl = ?, DocumentReleasePhase = " & _
            "?, Engineer = ?, EngineerDate = ?, EngineeringManager = ?, EngineeringManagerDat" & _
            "e = ?, Priority = ?, ReleaseDate = ? WHERE (DocumentReleaseNoticeNumberID = ?) A" & _
            "ND (DocumentControl = ? OR ? IS NULL AND DocumentControl IS NULL) AND (DocumentR" & _
            "eleasePhase = ? OR ? IS NULL AND DocumentReleasePhase IS NULL) AND (Engineer = ?" & _
            " OR ? IS NULL AND Engineer IS NULL) AND (EngineerDate = ? OR ? IS NULL AND Engin" & _
            "eerDate IS NULL) AND (EngineeringManager = ? OR ? IS NULL AND EngineeringManager" & _
            " IS NULL) AND (EngineeringManagerDate = ? OR ? IS NULL AND EngineeringManagerDat" & _
            "e IS NULL) AND (Priority = ? OR ? IS NULL AND Priority IS NULL) AND (ReleaseDate" & _
            " = ? OR ? IS NULL AND ReleaseDate IS NULL)"
            Me.OleDbUpdateCommand4.Connection = Me.OleDbConn
            Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("DocumentControl", System.Data.OleDb.OleDbType.VarWChar, 50, "DocumentControl"))
            Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("DocumentReleasePhase", System.Data.OleDb.OleDbType.VarWChar, 50, "DocumentReleasePhase"))
            Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Engineer", System.Data.OleDb.OleDbType.VarWChar, 50, "Engineer"))
            Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("EngineerDate", System.Data.OleDb.OleDbType.DBDate, 0, "EngineerDate"))
            Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("EngineeringManager", System.Data.OleDb.OleDbType.VarWChar, 50, "EngineeringManager"))
            Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("EngineeringManagerDate", System.Data.OleDb.OleDbType.DBDate, 0, "EngineeringManagerDate"))
            Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Priority", System.Data.OleDb.OleDbType.VarWChar, 50, "Priority"))
            Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("ReleaseDate", System.Data.OleDb.OleDbType.DBDate, 0, "ReleaseDate"))
            Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DocumentReleaseNoticeNumberID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DocumentReleaseNoticeNumberID", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DocumentControl", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DocumentControl", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DocumentControl1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DocumentControl", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DocumentReleasePhase", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DocumentReleasePhase", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DocumentReleasePhase1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DocumentReleasePhase", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Engineer", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Engineer1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineerDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineerDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineerDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineerDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringManager", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringManager", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringManager1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringManager", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringManagerDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringManagerDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringManagerDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringManagerDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Priority", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Priority", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Priority1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Priority", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ReleaseDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReleaseDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ReleaseDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReleaseDate", System.Data.DataRowVersion.Original, Nothing))
            '
            'daE025BillofMaterialInputSubTable
            '
            Me.daE025BillofMaterialInputSubTable.DeleteCommand = Me.OleDbDeleteCommand10
            Me.daE025BillofMaterialInputSubTable.InsertCommand = Me.OleDbInsertCommand10
            Me.daE025BillofMaterialInputSubTable.SelectCommand = Me.OleDbSelectCommand10
            Me.daE025BillofMaterialInputSubTable.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "E025BillofMaterialInputSubTable", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("BillofMaterialInputNumber", "BillofMaterialInputNumber"), New System.Data.Common.DataColumnMapping("BOMItemNumber", "BOMItemNumber"), New System.Data.Common.DataColumnMapping("ComponentPartNumber", "ComponentPartNumber"), New System.Data.Common.DataColumnMapping("DeletetoOperatorSequenceNumber", "DeletetoOperatorSequenceNumber"), New System.Data.Common.DataColumnMapping("EffectivityCloseDate", "EffectivityCloseDate"), New System.Data.Common.DataColumnMapping("EffectivityCloseSerialNumber", "EffectivityCloseSerialNumber"), New System.Data.Common.DataColumnMapping("EffectivityStartDate", "EffectivityStartDate"), New System.Data.Common.DataColumnMapping("EffectivityStartSerialNumber", "EffectivityStartSerialNumber"), New System.Data.Common.DataColumnMapping("IssuingStoresAccount", "IssuingStoresAccount"), New System.Data.Common.DataColumnMapping("ItemNumber", "ItemNumber"), New System.Data.Common.DataColumnMapping("KitLeadTimeOffset", "KitLeadTimeOffset"), New System.Data.Common.DataColumnMapping("QuantityPer", "QuantityPer")})})
            Me.daE025BillofMaterialInputSubTable.UpdateCommand = Me.OleDbUpdateCommand10
            '
            'OleDbDeleteCommand10
            '
            Me.OleDbDeleteCommand10.CommandText = "DELETE FROM E025BillofMaterialInputSubTable WHERE (ItemNumber = ?) AND (BOMItemNu" & _
            "mber = ? OR ? IS NULL AND BOMItemNumber IS NULL) AND (BillofMaterialInputNumber " & _
            "= ? OR ? IS NULL AND BillofMaterialInputNumber IS NULL) AND (ComponentPartNumber" & _
            " = ? OR ? IS NULL AND ComponentPartNumber IS NULL) AND (DeletetoOperatorSequence" & _
            "Number = ? OR ? IS NULL AND DeletetoOperatorSequenceNumber IS NULL) AND (Effecti" & _
            "vityCloseDate = ? OR ? IS NULL AND EffectivityCloseDate IS NULL) AND (Effectivit" & _
            "yCloseSerialNumber = ? OR ? IS NULL AND EffectivityCloseSerialNumber IS NULL) AN" & _
            "D (EffectivityStartDate = ? OR ? IS NULL AND EffectivityStartDate IS NULL) AND (" & _
            "EffectivityStartSerialNumber = ? OR ? IS NULL AND EffectivityStartSerialNumber I" & _
            "S NULL) AND (IssuingStoresAccount = ? OR ? IS NULL AND IssuingStoresAccount IS N" & _
            "ULL) AND (KitLeadTimeOffset = ? OR ? IS NULL AND KitLeadTimeOffset IS NULL) AND " & _
            "(QuantityPer = ? OR ? IS NULL AND QuantityPer IS NULL)"
            Me.OleDbDeleteCommand10.Connection = Me.OleDbConn
            Me.OleDbDeleteCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ItemNumber", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ItemNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BOMItemNumber", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BOMItemNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BOMItemNumber1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BOMItemNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BillofMaterialInputNumber", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BillofMaterialInputNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BillofMaterialInputNumber1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BillofMaterialInputNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ComponentPartNumber", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ComponentPartNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ComponentPartNumber1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ComponentPartNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DeletetoOperatorSequenceNumber", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DeletetoOperatorSequenceNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DeletetoOperatorSequenceNumber1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DeletetoOperatorSequenceNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EffectivityCloseDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EffectivityCloseDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EffectivityCloseDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EffectivityCloseDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EffectivityCloseSerialNumber", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EffectivityCloseSerialNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EffectivityCloseSerialNumber1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EffectivityCloseSerialNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EffectivityStartDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EffectivityStartDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EffectivityStartDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EffectivityStartDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EffectivityStartSerialNumber", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EffectivityStartSerialNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EffectivityStartSerialNumber1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EffectivityStartSerialNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IssuingStoresAccount", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IssuingStoresAccount", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IssuingStoresAccount1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IssuingStoresAccount", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_KitLeadTimeOffset", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "KitLeadTimeOffset", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_KitLeadTimeOffset1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "KitLeadTimeOffset", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_QuantityPer", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "QuantityPer", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_QuantityPer1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "QuantityPer", System.Data.DataRowVersion.Original, Nothing))
            '
            'OleDbInsertCommand10
            '
            Me.OleDbInsertCommand10.CommandText = "INSERT INTO E025BillofMaterialInputSubTable(BillofMaterialInputNumber, BOMItemNum" & _
            "ber, ComponentPartNumber, DeletetoOperatorSequenceNumber, EffectivityCloseDate, " & _
            "EffectivityCloseSerialNumber, EffectivityStartDate, EffectivityStartSerialNumber" & _
            ", IssuingStoresAccount, KitLeadTimeOffset, QuantityPer) VALUES (?, ?, ?, ?, ?, ?" & _
            ", ?, ?, ?, ?, ?)"
            Me.OleDbInsertCommand10.Connection = Me.OleDbConn
            Me.OleDbInsertCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("BillofMaterialInputNumber", System.Data.OleDb.OleDbType.Integer, 0, "BillofMaterialInputNumber"))
            Me.OleDbInsertCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("BOMItemNumber", System.Data.OleDb.OleDbType.Integer, 0, "BOMItemNumber"))
            Me.OleDbInsertCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("ComponentPartNumber", System.Data.OleDb.OleDbType.VarWChar, 50, "ComponentPartNumber"))
            Me.OleDbInsertCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("DeletetoOperatorSequenceNumber", System.Data.OleDb.OleDbType.VarWChar, 50, "DeletetoOperatorSequenceNumber"))
            Me.OleDbInsertCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("EffectivityCloseDate", System.Data.OleDb.OleDbType.DBDate, 0, "EffectivityCloseDate"))
            Me.OleDbInsertCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("EffectivityCloseSerialNumber", System.Data.OleDb.OleDbType.VarWChar, 50, "EffectivityCloseSerialNumber"))
            Me.OleDbInsertCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("EffectivityStartDate", System.Data.OleDb.OleDbType.DBDate, 0, "EffectivityStartDate"))
            Me.OleDbInsertCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("EffectivityStartSerialNumber", System.Data.OleDb.OleDbType.VarWChar, 50, "EffectivityStartSerialNumber"))
            Me.OleDbInsertCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("IssuingStoresAccount", System.Data.OleDb.OleDbType.VarWChar, 50, "IssuingStoresAccount"))
            Me.OleDbInsertCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("KitLeadTimeOffset", System.Data.OleDb.OleDbType.VarWChar, 50, "KitLeadTimeOffset"))
            Me.OleDbInsertCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("QuantityPer", System.Data.OleDb.OleDbType.VarWChar, 50, "QuantityPer"))
            '
            'OleDbSelectCommand10
            '
            Me.OleDbSelectCommand10.CommandText = "SELECT E025BillofMaterialInputSubTable.BillofMaterialInputNumber, E025BillofMater" & _
            "ialInputSubTable.BOMItemNumber, E025BillofMaterialInputSubTable.ComponentPartNum" & _
            "ber, E025BillofMaterialInputSubTable.DeletetoOperatorSequenceNumber, E025BillofM" & _
            "aterialInputSubTable.EffectivityCloseDate, E025BillofMaterialInputSubTable.Effec" & _
            "tivityCloseSerialNumber, E025BillofMaterialInputSubTable.EffectivityStartDate, E" & _
            "025BillofMaterialInputSubTable.EffectivityStartSerialNumber, E025BillofMaterialI" & _
            "nputSubTable.IssuingStoresAccount, E025BillofMaterialInputSubTable.ItemNumber, E" & _
            "025BillofMaterialInputSubTable.KitLeadTimeOffset, E025BillofMaterialInputSubTabl" & _
            "e.QuantityPer, E024ItemMasterInput.EngineeringDescription, E024ItemMasterInput.E" & _
            "ngineeringPartNumber FROM (E025BillofMaterialInputSubTable LEFT OUTER JOIN E024I" & _
            "temMasterInput ON E025BillofMaterialInputSubTable.ComponentPartNumber = E024Item" & _
            "MasterInput.EngineeringPartNumber)"
            Me.OleDbSelectCommand10.Connection = Me.OleDbConn
            '
            'OleDbUpdateCommand10
            '
            Me.OleDbUpdateCommand10.CommandText = "UPDATE E025BillofMaterialInputSubTable SET BillofMaterialInputNumber = ?, BOMItem" & _
            "Number = ?, ComponentPartNumber = ?, DeletetoOperatorSequenceNumber = ?, Effecti" & _
            "vityCloseDate = ?, EffectivityCloseSerialNumber = ?, EffectivityStartDate = ?, E" & _
            "ffectivityStartSerialNumber = ?, IssuingStoresAccount = ?, KitLeadTimeOffset = ?" & _
            ", QuantityPer = ? WHERE (ItemNumber = ?) AND (BOMItemNumber = ? OR ? IS NULL AND" & _
            " BOMItemNumber IS NULL) AND (BillofMaterialInputNumber = ? OR ? IS NULL AND Bill" & _
            "ofMaterialInputNumber IS NULL) AND (ComponentPartNumber = ? OR ? IS NULL AND Com" & _
            "ponentPartNumber IS NULL) AND (DeletetoOperatorSequenceNumber = ? OR ? IS NULL A" & _
            "ND DeletetoOperatorSequenceNumber IS NULL) AND (EffectivityCloseDate = ? OR ? IS" & _
            " NULL AND EffectivityCloseDate IS NULL) AND (EffectivityCloseSerialNumber = ? OR" & _
            " ? IS NULL AND EffectivityCloseSerialNumber IS NULL) AND (EffectivityStartDate =" & _
            " ? OR ? IS NULL AND EffectivityStartDate IS NULL) AND (EffectivityStartSerialNum" & _
            "ber = ? OR ? IS NULL AND EffectivityStartSerialNumber IS NULL) AND (IssuingStore" & _
            "sAccount = ? OR ? IS NULL AND IssuingStoresAccount IS NULL) AND (KitLeadTimeOffs" & _
            "et = ? OR ? IS NULL AND KitLeadTimeOffset IS NULL) AND (QuantityPer = ? OR ? IS " & _
            "NULL AND QuantityPer IS NULL)"
            Me.OleDbUpdateCommand10.Connection = Me.OleDbConn
            Me.OleDbUpdateCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("BillofMaterialInputNumber", System.Data.OleDb.OleDbType.Integer, 0, "BillofMaterialInputNumber"))
            Me.OleDbUpdateCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("BOMItemNumber", System.Data.OleDb.OleDbType.Integer, 0, "BOMItemNumber"))
            Me.OleDbUpdateCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("ComponentPartNumber", System.Data.OleDb.OleDbType.VarWChar, 50, "ComponentPartNumber"))
            Me.OleDbUpdateCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("DeletetoOperatorSequenceNumber", System.Data.OleDb.OleDbType.VarWChar, 50, "DeletetoOperatorSequenceNumber"))
            Me.OleDbUpdateCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("EffectivityCloseDate", System.Data.OleDb.OleDbType.DBDate, 0, "EffectivityCloseDate"))
            Me.OleDbUpdateCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("EffectivityCloseSerialNumber", System.Data.OleDb.OleDbType.VarWChar, 50, "EffectivityCloseSerialNumber"))
            Me.OleDbUpdateCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("EffectivityStartDate", System.Data.OleDb.OleDbType.DBDate, 0, "EffectivityStartDate"))
            Me.OleDbUpdateCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("EffectivityStartSerialNumber", System.Data.OleDb.OleDbType.VarWChar, 50, "EffectivityStartSerialNumber"))
            Me.OleDbUpdateCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("IssuingStoresAccount", System.Data.OleDb.OleDbType.VarWChar, 50, "IssuingStoresAccount"))
            Me.OleDbUpdateCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("KitLeadTimeOffset", System.Data.OleDb.OleDbType.VarWChar, 50, "KitLeadTimeOffset"))
            Me.OleDbUpdateCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("QuantityPer", System.Data.OleDb.OleDbType.VarWChar, 50, "QuantityPer"))
            Me.OleDbUpdateCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ItemNumber", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ItemNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BOMItemNumber", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BOMItemNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BOMItemNumber1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BOMItemNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BillofMaterialInputNumber", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BillofMaterialInputNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BillofMaterialInputNumber1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BillofMaterialInputNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ComponentPartNumber", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ComponentPartNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ComponentPartNumber1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ComponentPartNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DeletetoOperatorSequenceNumber", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DeletetoOperatorSequenceNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DeletetoOperatorSequenceNumber1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DeletetoOperatorSequenceNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EffectivityCloseDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EffectivityCloseDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EffectivityCloseDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EffectivityCloseDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EffectivityCloseSerialNumber", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EffectivityCloseSerialNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EffectivityCloseSerialNumber1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EffectivityCloseSerialNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EffectivityStartDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EffectivityStartDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EffectivityStartDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EffectivityStartDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EffectivityStartSerialNumber", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EffectivityStartSerialNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EffectivityStartSerialNumber1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EffectivityStartSerialNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IssuingStoresAccount", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IssuingStoresAccount", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IssuingStoresAccount1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IssuingStoresAccount", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_KitLeadTimeOffset", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "KitLeadTimeOffset", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_KitLeadTimeOffset1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "KitLeadTimeOffset", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_QuantityPer", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "QuantityPer", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_QuantityPer1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "QuantityPer", System.Data.DataRowVersion.Original, Nothing))
            '
            'daE024ItemMasterInput
            '
            Me.daE024ItemMasterInput.DeleteCommand = Me.OleDbDeleteCommand3
            Me.daE024ItemMasterInput.InsertCommand = Me.OleDbInsertCommand3
            Me.daE024ItemMasterInput.SelectCommand = Me.OleDbSelectCommand3
            Me.daE024ItemMasterInput.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "E024ItemMasterInput", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("AccountingLaborHours", "AccountingLaborHours"), New System.Data.Common.DataColumnMapping("AccountingMaterialCost", "AccountingMaterialCost"), New System.Data.Common.DataColumnMapping("AccountingVendorCost", "AccountingVendorCost"), New System.Data.Common.DataColumnMapping("EngineeringDashNumber", "EngineeringDashNumber"), New System.Data.Common.DataColumnMapping("EngineeringDescription", "EngineeringDescription"), New System.Data.Common.DataColumnMapping("EngineeringEngineeringChangeNumberAndDate", "EngineeringEngineeringChangeNumberAndDate"), New System.Data.Common.DataColumnMapping("EngineeringPartNumber", "EngineeringPartNumber"), New System.Data.Common.DataColumnMapping("EngineeringProductCode", "EngineeringProductCode"), New System.Data.Common.DataColumnMapping("EngineeringRevisionCode", "EngineeringRevisionCode"), New System.Data.Common.DataColumnMapping("EngineeringUnitofMeasure", "EngineeringUnitofMeasure"), New System.Data.Common.DataColumnMapping("InventoryControlABCCode", "InventoryControlABCCode"), New System.Data.Common.DataColumnMapping("InventoryControlOrderQuantity", "InventoryControlOrderQuantity"), New System.Data.Common.DataColumnMapping("InventoryControlPlanningCode", "InventoryControlPlanningCode"), New System.Data.Common.DataColumnMapping("InventoryControlSourceCode", "InventoryControlSourceCode"), New System.Data.Common.DataColumnMapping("InventoryControlSpareCode", "InventoryControlSpareCode"), New System.Data.Common.DataColumnMapping("ItemMasterInputNumber", "ItemMasterInputNumber"), New System.Data.Common.DataColumnMapping("ProductionControlForcastedUsage", "ProductionControlForcastedUsage"), New System.Data.Common.DataColumnMapping("ProductionControlManufacturingLeadTime", "ProductionControlManufacturingLeadTime"), New System.Data.Common.DataColumnMapping("ProductionControlShrinkageFactor", "ProductionControlShrinkageFactor"), New System.Data.Common.DataColumnMapping("ProductionControlYieldPercent", "ProductionControlYieldPercent"), New System.Data.Common.DataColumnMapping("PurchasingBuyerCode", "PurchasingBuyerCode"), New System.Data.Common.DataColumnMapping("PurchasingCommodityCode", "PurchasingCommodityCode"), New System.Data.Common.DataColumnMapping("PurchasingPurchasingLeadTime", "PurchasingPurchasingLeadTime"), New System.Data.Common.DataColumnMapping("SignatureDateEngineering", "SignatureDateEngineering"), New System.Data.Common.DataColumnMapping("SignatureDateManufacturing", "SignatureDateManufacturing"), New System.Data.Common.DataColumnMapping("SignatureDatePurchasing", "SignatureDatePurchasing"), New System.Data.Common.DataColumnMapping("SignatureDateQuality", "SignatureDateQuality"), New System.Data.Common.DataColumnMapping("SignatureEngineering", "SignatureEngineering"), New System.Data.Common.DataColumnMapping("SignatureManufacturing", "SignatureManufacturing"), New System.Data.Common.DataColumnMapping("SignaturePurchasing", "SignaturePurchasing"), New System.Data.Common.DataColumnMapping("SignatureQuality", "SignatureQuality")})})
            Me.daE024ItemMasterInput.UpdateCommand = Me.OleDbUpdateCommand3
            '
            'OleDbDeleteCommand3
            '
            Me.OleDbDeleteCommand3.CommandText = "DELETE FROM E024ItemMasterInput WHERE (ItemMasterInputNumber = ?) AND (Accounting" & _
            "LaborHours = ? OR ? IS NULL AND AccountingLaborHours IS NULL) AND (AccountingMat" & _
            "erialCost = ? OR ? IS NULL AND AccountingMaterialCost IS NULL) AND (AccountingVe" & _
            "ndorCost = ? OR ? IS NULL AND AccountingVendorCost IS NULL) AND (EngineeringDash" & _
            "Number = ? OR ? IS NULL AND EngineeringDashNumber IS NULL) AND (EngineeringDescr" & _
            "iption = ? OR ? IS NULL AND EngineeringDescription IS NULL) AND (EngineeringEngi" & _
            "neeringChangeNumberAndDate = ? OR ? IS NULL AND EngineeringEngineeringChangeNumb" & _
            "erAndDate IS NULL) AND (EngineeringPartNumber = ? OR ? IS NULL AND EngineeringPa" & _
            "rtNumber IS NULL) AND (EngineeringProductCode = ? OR ? IS NULL AND EngineeringPr" & _
            "oductCode IS NULL) AND (EngineeringRevisionCode = ? OR ? IS NULL AND Engineering" & _
            "RevisionCode IS NULL) AND (EngineeringUnitofMeasure = ? OR ? IS NULL AND Enginee" & _
            "ringUnitofMeasure IS NULL) AND (InventoryControlABCCode = ? OR ? IS NULL AND Inv" & _
            "entoryControlABCCode IS NULL) AND (InventoryControlOrderQuantity = ? OR ? IS NUL" & _
            "L AND InventoryControlOrderQuantity IS NULL) AND (InventoryControlPlanningCode =" & _
            " ? OR ? IS NULL AND InventoryControlPlanningCode IS NULL) AND (InventoryControlS" & _
            "ourceCode = ? OR ? IS NULL AND InventoryControlSourceCode IS NULL) AND (Inventor" & _
            "yControlSpareCode = ? OR ? IS NULL AND InventoryControlSpareCode IS NULL) AND (P" & _
            "roductionControlForcastedUsage = ? OR ? IS NULL AND ProductionControlForcastedUs" & _
            "age IS NULL) AND (ProductionControlManufacturingLeadTime = ? OR ? IS NULL AND Pr" & _
            "oductionControlManufacturingLeadTime IS NULL) AND (ProductionControlShrinkageFac" & _
            "tor = ? OR ? IS NULL AND ProductionControlShrinkageFactor IS NULL) AND (Producti" & _
            "onControlYieldPercent = ? OR ? IS NULL AND ProductionControlYieldPercent IS NULL" & _
            ") AND (PurchasingBuyerCode = ? OR ? IS NULL AND PurchasingBuyerCode IS NULL) AND" & _
            " (PurchasingCommodityCode = ? OR ? IS NULL AND PurchasingCommodityCode IS NULL) " & _
            "AND (PurchasingPurchasingLeadTime = ? OR ? IS NULL AND PurchasingPurchasingLeadT" & _
            "ime IS NULL) AND (SignatureDateEngineering = ? OR ? IS NULL AND SignatureDateEng" & _
            "ineering IS NULL) AND (SignatureDateManufacturing = ? OR ? IS NULL AND Signature" & _
            "DateManufacturing IS NULL) AND (SignatureDatePurchasing = ? OR ? IS NULL AND Sig" & _
            "natureDatePurchasing IS NULL) AND (SignatureDateQuality = ? OR ? IS NULL AND Sig" & _
            "natureDateQuality IS NULL) AND (SignatureEngineering = ? OR ? IS NULL AND Signat" & _
            "ureEngineering IS NULL) AND (SignatureManufacturing = ? OR ? IS NULL AND Signatu" & _
            "reManufacturing IS NULL) AND (SignaturePurchasing = ? OR ? IS NULL AND Signature" & _
            "Purchasing IS NULL) AND (SignatureQuality = ? OR ? IS NULL AND SignatureQuality " & _
            "IS NULL)"
            Me.OleDbDeleteCommand3.Connection = Me.OleDbConn
            Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ItemMasterInputNumber", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ItemMasterInputNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AccountingLaborHours", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AccountingLaborHours", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AccountingLaborHours1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AccountingLaborHours", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AccountingMaterialCost", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AccountingMaterialCost", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AccountingMaterialCost1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AccountingMaterialCost", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AccountingVendorCost", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AccountingVendorCost", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AccountingVendorCost1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AccountingVendorCost", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringDashNumber", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringDashNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringDashNumber1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringDashNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringDescription", System.Data.OleDb.OleDbType.VarWChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringDescription", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringDescription1", System.Data.OleDb.OleDbType.VarWChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringDescription", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringEngineeringChangeNumberAndDate", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringEngineeringChangeNumberAndDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringEngineeringChangeNumberAndDate1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringEngineeringChangeNumberAndDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringPartNumber", System.Data.OleDb.OleDbType.VarWChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringPartNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringPartNumber1", System.Data.OleDb.OleDbType.VarWChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringPartNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringProductCode", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringProductCode", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringProductCode1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringProductCode", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringRevisionCode", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringRevisionCode", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringRevisionCode1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringRevisionCode", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringUnitofMeasure", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringUnitofMeasure", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringUnitofMeasure1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringUnitofMeasure", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_InventoryControlABCCode", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "InventoryControlABCCode", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_InventoryControlABCCode1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "InventoryControlABCCode", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_InventoryControlOrderQuantity", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "InventoryControlOrderQuantity", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_InventoryControlOrderQuantity1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "InventoryControlOrderQuantity", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_InventoryControlPlanningCode", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "InventoryControlPlanningCode", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_InventoryControlPlanningCode1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "InventoryControlPlanningCode", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_InventoryControlSourceCode", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "InventoryControlSourceCode", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_InventoryControlSourceCode1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "InventoryControlSourceCode", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_InventoryControlSpareCode", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "InventoryControlSpareCode", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_InventoryControlSpareCode1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "InventoryControlSpareCode", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProductionControlForcastedUsage", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProductionControlForcastedUsage", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProductionControlForcastedUsage1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProductionControlForcastedUsage", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProductionControlManufacturingLeadTime", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProductionControlManufacturingLeadTime", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProductionControlManufacturingLeadTime1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProductionControlManufacturingLeadTime", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProductionControlShrinkageFactor", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProductionControlShrinkageFactor", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProductionControlShrinkageFactor1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProductionControlShrinkageFactor", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProductionControlYieldPercent", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProductionControlYieldPercent", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProductionControlYieldPercent1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProductionControlYieldPercent", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PurchasingBuyerCode", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PurchasingBuyerCode", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PurchasingBuyerCode1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PurchasingBuyerCode", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PurchasingCommodityCode", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PurchasingCommodityCode", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PurchasingCommodityCode1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PurchasingCommodityCode", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PurchasingPurchasingLeadTime", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PurchasingPurchasingLeadTime", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PurchasingPurchasingLeadTime1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PurchasingPurchasingLeadTime", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SignatureDateEngineering", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SignatureDateEngineering", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SignatureDateEngineering1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SignatureDateEngineering", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SignatureDateManufacturing", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SignatureDateManufacturing", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SignatureDateManufacturing1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SignatureDateManufacturing", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SignatureDatePurchasing", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SignatureDatePurchasing", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SignatureDatePurchasing1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SignatureDatePurchasing", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SignatureDateQuality", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SignatureDateQuality", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SignatureDateQuality1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SignatureDateQuality", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SignatureEngineering", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SignatureEngineering", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SignatureEngineering1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SignatureEngineering", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SignatureManufacturing", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SignatureManufacturing", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SignatureManufacturing1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SignatureManufacturing", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SignaturePurchasing", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SignaturePurchasing", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SignaturePurchasing1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SignaturePurchasing", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SignatureQuality", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SignatureQuality", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SignatureQuality1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SignatureQuality", System.Data.DataRowVersion.Original, Nothing))
            '
            'OleDbInsertCommand3
            '
            Me.OleDbInsertCommand3.CommandText = "INSERT INTO E024ItemMasterInput(AccountingLaborHours, AccountingMaterialCost, Acc" & _
            "ountingVendorCost, EngineeringDashNumber, EngineeringDescription, EngineeringEng" & _
            "ineeringChangeNumberAndDate, EngineeringPartNumber, EngineeringProductCode, Engi" & _
            "neeringRevisionCode, EngineeringUnitofMeasure, InventoryControlABCCode, Inventor" & _
            "yControlOrderQuantity, InventoryControlPlanningCode, InventoryControlSourceCode," & _
            " InventoryControlSpareCode, ProductionControlForcastedUsage, ProductionControlMa" & _
            "nufacturingLeadTime, ProductionControlShrinkageFactor, ProductionControlYieldPer" & _
            "cent, PurchasingBuyerCode, PurchasingCommodityCode, PurchasingPurchasingLeadTime" & _
            ", SignatureDateEngineering, SignatureDateManufacturing, SignatureDatePurchasing," & _
            " SignatureDateQuality, SignatureEngineering, SignatureManufacturing, SignaturePu" & _
            "rchasing, SignatureQuality) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?," & _
            " ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"
            Me.OleDbInsertCommand3.Connection = Me.OleDbConn
            Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("AccountingLaborHours", System.Data.OleDb.OleDbType.Integer, 0, "AccountingLaborHours"))
            Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("AccountingMaterialCost", System.Data.OleDb.OleDbType.Currency, 0, "AccountingMaterialCost"))
            Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("AccountingVendorCost", System.Data.OleDb.OleDbType.Currency, 0, "AccountingVendorCost"))
            Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("EngineeringDashNumber", System.Data.OleDb.OleDbType.VarWChar, 5, "EngineeringDashNumber"))
            Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("EngineeringDescription", System.Data.OleDb.OleDbType.VarWChar, 250, "EngineeringDescription"))
            Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("EngineeringEngineeringChangeNumberAndDate", System.Data.OleDb.OleDbType.VarWChar, 50, "EngineeringEngineeringChangeNumberAndDate"))
            Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("EngineeringPartNumber", System.Data.OleDb.OleDbType.VarWChar, 250, "EngineeringPartNumber"))
            Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("EngineeringProductCode", System.Data.OleDb.OleDbType.VarWChar, 50, "EngineeringProductCode"))
            Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("EngineeringRevisionCode", System.Data.OleDb.OleDbType.VarWChar, 50, "EngineeringRevisionCode"))
            Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("EngineeringUnitofMeasure", System.Data.OleDb.OleDbType.VarWChar, 50, "EngineeringUnitofMeasure"))
            Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("InventoryControlABCCode", System.Data.OleDb.OleDbType.VarWChar, 50, "InventoryControlABCCode"))
            Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("InventoryControlOrderQuantity", System.Data.OleDb.OleDbType.VarWChar, 50, "InventoryControlOrderQuantity"))
            Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("InventoryControlPlanningCode", System.Data.OleDb.OleDbType.VarWChar, 50, "InventoryControlPlanningCode"))
            Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("InventoryControlSourceCode", System.Data.OleDb.OleDbType.VarWChar, 50, "InventoryControlSourceCode"))
            Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("InventoryControlSpareCode", System.Data.OleDb.OleDbType.VarWChar, 50, "InventoryControlSpareCode"))
            Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("ProductionControlForcastedUsage", System.Data.OleDb.OleDbType.VarWChar, 50, "ProductionControlForcastedUsage"))
            Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("ProductionControlManufacturingLeadTime", System.Data.OleDb.OleDbType.VarWChar, 50, "ProductionControlManufacturingLeadTime"))
            Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("ProductionControlShrinkageFactor", System.Data.OleDb.OleDbType.VarWChar, 50, "ProductionControlShrinkageFactor"))
            Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("ProductionControlYieldPercent", System.Data.OleDb.OleDbType.VarWChar, 50, "ProductionControlYieldPercent"))
            Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("PurchasingBuyerCode", System.Data.OleDb.OleDbType.VarWChar, 50, "PurchasingBuyerCode"))
            Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("PurchasingCommodityCode", System.Data.OleDb.OleDbType.VarWChar, 50, "PurchasingCommodityCode"))
            Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("PurchasingPurchasingLeadTime", System.Data.OleDb.OleDbType.VarWChar, 50, "PurchasingPurchasingLeadTime"))
            Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("SignatureDateEngineering", System.Data.OleDb.OleDbType.DBDate, 0, "SignatureDateEngineering"))
            Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("SignatureDateManufacturing", System.Data.OleDb.OleDbType.DBDate, 0, "SignatureDateManufacturing"))
            Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("SignatureDatePurchasing", System.Data.OleDb.OleDbType.DBDate, 0, "SignatureDatePurchasing"))
            Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("SignatureDateQuality", System.Data.OleDb.OleDbType.DBDate, 0, "SignatureDateQuality"))
            Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("SignatureEngineering", System.Data.OleDb.OleDbType.VarWChar, 50, "SignatureEngineering"))
            Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("SignatureManufacturing", System.Data.OleDb.OleDbType.VarWChar, 50, "SignatureManufacturing"))
            Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("SignaturePurchasing", System.Data.OleDb.OleDbType.VarWChar, 50, "SignaturePurchasing"))
            Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("SignatureQuality", System.Data.OleDb.OleDbType.VarWChar, 50, "SignatureQuality"))
            '
            'OleDbSelectCommand3
            '
            Me.OleDbSelectCommand3.CommandText = "SELECT AccountingLaborHours, AccountingMaterialCost, AccountingVendorCost, Engine" & _
            "eringDashNumber, EngineeringDescription, EngineeringEngineeringChangeNumberAndDa" & _
            "te, EngineeringPartNumber, EngineeringProductCode, EngineeringRevisionCode, Engi" & _
            "neeringUnitofMeasure, InventoryControlABCCode, InventoryControlOrderQuantity, In" & _
            "ventoryControlPlanningCode, InventoryControlSourceCode, InventoryControlSpareCod" & _
            "e, ItemMasterInputNumber, ProductionControlForcastedUsage, ProductionControlManu" & _
            "facturingLeadTime, ProductionControlShrinkageFactor, ProductionControlYieldPerce" & _
            "nt, PurchasingBuyerCode, PurchasingCommodityCode, PurchasingPurchasingLeadTime, " & _
            "SignatureDateEngineering, SignatureDateManufacturing, SignatureDatePurchasing, S" & _
            "ignatureDateQuality, SignatureEngineering, SignatureManufacturing, SignaturePurc" & _
            "hasing, SignatureQuality FROM E024ItemMasterInput ORDER BY EngineeringEngineerin" & _
            "gChangeNumberAndDate DESC, EngineeringPartNumber"
            Me.OleDbSelectCommand3.Connection = Me.OleDbConn
            '
            'OleDbUpdateCommand3
            '
            Me.OleDbUpdateCommand3.CommandText = "UPDATE E024ItemMasterInput SET AccountingLaborHours = ?, AccountingMaterialCost =" & _
            " ?, AccountingVendorCost = ?, EngineeringDashNumber = ?, EngineeringDescription " & _
            "= ?, EngineeringEngineeringChangeNumberAndDate = ?, EngineeringPartNumber = ?, E" & _
            "ngineeringProductCode = ?, EngineeringRevisionCode = ?, EngineeringUnitofMeasure" & _
            " = ?, InventoryControlABCCode = ?, InventoryControlOrderQuantity = ?, InventoryC" & _
            "ontrolPlanningCode = ?, InventoryControlSourceCode = ?, InventoryControlSpareCod" & _
            "e = ?, ProductionControlForcastedUsage = ?, ProductionControlManufacturingLeadTi" & _
            "me = ?, ProductionControlShrinkageFactor = ?, ProductionControlYieldPercent = ?," & _
            " PurchasingBuyerCode = ?, PurchasingCommodityCode = ?, PurchasingPurchasingLeadT" & _
            "ime = ?, SignatureDateEngineering = ?, SignatureDateManufacturing = ?, Signature" & _
            "DatePurchasing = ?, SignatureDateQuality = ?, SignatureEngineering = ?, Signatur" & _
            "eManufacturing = ?, SignaturePurchasing = ?, SignatureQuality = ? WHERE (ItemMas" & _
            "terInputNumber = ?) AND (AccountingLaborHours = ? OR ? IS NULL AND AccountingLab" & _
            "orHours IS NULL) AND (AccountingMaterialCost = ? OR ? IS NULL AND AccountingMate" & _
            "rialCost IS NULL) AND (AccountingVendorCost = ? OR ? IS NULL AND AccountingVendo" & _
            "rCost IS NULL) AND (EngineeringDashNumber = ? OR ? IS NULL AND EngineeringDashNu" & _
            "mber IS NULL) AND (EngineeringDescription = ? OR ? IS NULL AND EngineeringDescri" & _
            "ption IS NULL) AND (EngineeringEngineeringChangeNumberAndDate = ? OR ? IS NULL A" & _
            "ND EngineeringEngineeringChangeNumberAndDate IS NULL) AND (EngineeringPartNumber" & _
            " = ? OR ? IS NULL AND EngineeringPartNumber IS NULL) AND (EngineeringProductCode" & _
            " = ? OR ? IS NULL AND EngineeringProductCode IS NULL) AND (EngineeringRevisionCo" & _
            "de = ? OR ? IS NULL AND EngineeringRevisionCode IS NULL) AND (EngineeringUnitofM" & _
            "easure = ? OR ? IS NULL AND EngineeringUnitofMeasure IS NULL) AND (InventoryCont" & _
            "rolABCCode = ? OR ? IS NULL AND InventoryControlABCCode IS NULL) AND (InventoryC" & _
            "ontrolOrderQuantity = ? OR ? IS NULL AND InventoryControlOrderQuantity IS NULL) " & _
            "AND (InventoryControlPlanningCode = ? OR ? IS NULL AND InventoryControlPlanningC" & _
            "ode IS NULL) AND (InventoryControlSourceCode = ? OR ? IS NULL AND InventoryContr" & _
            "olSourceCode IS NULL) AND (InventoryControlSpareCode = ? OR ? IS NULL AND Invent" & _
            "oryControlSpareCode IS NULL) AND (ProductionControlForcastedUsage = ? OR ? IS NU" & _
            "LL AND ProductionControlForcastedUsage IS NULL) AND (ProductionControlManufactur" & _
            "ingLeadTime = ? OR ? IS NULL AND ProductionControlManufacturingLeadTime IS NULL)" & _
            " AND (ProductionControlShrinkageFactor = ? OR ? IS NULL AND ProductionControlShr" & _
            "inkageFactor IS NULL) AND (ProductionControlYieldPercent = ? OR ? IS NULL AND Pr" & _
            "oductionControlYieldPercent IS NULL) AND (PurchasingBuyerCode = ? OR ? IS NULL A" & _
            "ND PurchasingBuyerCode IS NULL) AND (PurchasingCommodityCode = ? OR ? IS NULL AN" & _
            "D PurchasingCommodityCode IS NULL) AND (PurchasingPurchasingLeadTime = ? OR ? IS" & _
            " NULL AND PurchasingPurchasingLeadTime IS NULL) AND (SignatureDateEngineering = " & _
            "? OR ? IS NULL AND SignatureDateEngineering IS NULL) AND (SignatureDateManufactu" & _
            "ring = ? OR ? IS NULL AND SignatureDateManufacturing IS NULL) AND (SignatureDate" & _
            "Purchasing = ? OR ? IS NULL AND SignatureDatePurchasing IS NULL) AND (SignatureD" & _
            "ateQuality = ? OR ? IS NULL AND SignatureDateQuality IS NULL) AND (SignatureEngi" & _
            "neering = ? OR ? IS NULL AND SignatureEngineering IS NULL) AND (SignatureManufac" & _
            "turing = ? OR ? IS NULL AND SignatureManufacturing IS NULL) AND (SignaturePurcha" & _
            "sing = ? OR ? IS NULL AND SignaturePurchasing IS NULL) AND (SignatureQuality = ?" & _
            " OR ? IS NULL AND SignatureQuality IS NULL)"
            Me.OleDbUpdateCommand3.Connection = Me.OleDbConn
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("AccountingLaborHours", System.Data.OleDb.OleDbType.Integer, 0, "AccountingLaborHours"))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("AccountingMaterialCost", System.Data.OleDb.OleDbType.Currency, 0, "AccountingMaterialCost"))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("AccountingVendorCost", System.Data.OleDb.OleDbType.Currency, 0, "AccountingVendorCost"))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("EngineeringDashNumber", System.Data.OleDb.OleDbType.VarWChar, 5, "EngineeringDashNumber"))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("EngineeringDescription", System.Data.OleDb.OleDbType.VarWChar, 250, "EngineeringDescription"))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("EngineeringEngineeringChangeNumberAndDate", System.Data.OleDb.OleDbType.VarWChar, 50, "EngineeringEngineeringChangeNumberAndDate"))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("EngineeringPartNumber", System.Data.OleDb.OleDbType.VarWChar, 250, "EngineeringPartNumber"))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("EngineeringProductCode", System.Data.OleDb.OleDbType.VarWChar, 50, "EngineeringProductCode"))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("EngineeringRevisionCode", System.Data.OleDb.OleDbType.VarWChar, 50, "EngineeringRevisionCode"))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("EngineeringUnitofMeasure", System.Data.OleDb.OleDbType.VarWChar, 50, "EngineeringUnitofMeasure"))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("InventoryControlABCCode", System.Data.OleDb.OleDbType.VarWChar, 50, "InventoryControlABCCode"))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("InventoryControlOrderQuantity", System.Data.OleDb.OleDbType.VarWChar, 50, "InventoryControlOrderQuantity"))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("InventoryControlPlanningCode", System.Data.OleDb.OleDbType.VarWChar, 50, "InventoryControlPlanningCode"))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("InventoryControlSourceCode", System.Data.OleDb.OleDbType.VarWChar, 50, "InventoryControlSourceCode"))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("InventoryControlSpareCode", System.Data.OleDb.OleDbType.VarWChar, 50, "InventoryControlSpareCode"))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("ProductionControlForcastedUsage", System.Data.OleDb.OleDbType.VarWChar, 50, "ProductionControlForcastedUsage"))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("ProductionControlManufacturingLeadTime", System.Data.OleDb.OleDbType.VarWChar, 50, "ProductionControlManufacturingLeadTime"))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("ProductionControlShrinkageFactor", System.Data.OleDb.OleDbType.VarWChar, 50, "ProductionControlShrinkageFactor"))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("ProductionControlYieldPercent", System.Data.OleDb.OleDbType.VarWChar, 50, "ProductionControlYieldPercent"))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("PurchasingBuyerCode", System.Data.OleDb.OleDbType.VarWChar, 50, "PurchasingBuyerCode"))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("PurchasingCommodityCode", System.Data.OleDb.OleDbType.VarWChar, 50, "PurchasingCommodityCode"))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("PurchasingPurchasingLeadTime", System.Data.OleDb.OleDbType.VarWChar, 50, "PurchasingPurchasingLeadTime"))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("SignatureDateEngineering", System.Data.OleDb.OleDbType.DBDate, 0, "SignatureDateEngineering"))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("SignatureDateManufacturing", System.Data.OleDb.OleDbType.DBDate, 0, "SignatureDateManufacturing"))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("SignatureDatePurchasing", System.Data.OleDb.OleDbType.DBDate, 0, "SignatureDatePurchasing"))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("SignatureDateQuality", System.Data.OleDb.OleDbType.DBDate, 0, "SignatureDateQuality"))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("SignatureEngineering", System.Data.OleDb.OleDbType.VarWChar, 50, "SignatureEngineering"))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("SignatureManufacturing", System.Data.OleDb.OleDbType.VarWChar, 50, "SignatureManufacturing"))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("SignaturePurchasing", System.Data.OleDb.OleDbType.VarWChar, 50, "SignaturePurchasing"))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("SignatureQuality", System.Data.OleDb.OleDbType.VarWChar, 50, "SignatureQuality"))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ItemMasterInputNumber", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ItemMasterInputNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AccountingLaborHours", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AccountingLaborHours", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AccountingLaborHours1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AccountingLaborHours", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AccountingMaterialCost", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AccountingMaterialCost", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AccountingMaterialCost1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AccountingMaterialCost", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AccountingVendorCost", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AccountingVendorCost", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AccountingVendorCost1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AccountingVendorCost", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringDashNumber", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringDashNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringDashNumber1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringDashNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringDescription", System.Data.OleDb.OleDbType.VarWChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringDescription", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringDescription1", System.Data.OleDb.OleDbType.VarWChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringDescription", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringEngineeringChangeNumberAndDate", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringEngineeringChangeNumberAndDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringEngineeringChangeNumberAndDate1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringEngineeringChangeNumberAndDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringPartNumber", System.Data.OleDb.OleDbType.VarWChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringPartNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringPartNumber1", System.Data.OleDb.OleDbType.VarWChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringPartNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringProductCode", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringProductCode", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringProductCode1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringProductCode", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringRevisionCode", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringRevisionCode", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringRevisionCode1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringRevisionCode", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringUnitofMeasure", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringUnitofMeasure", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringUnitofMeasure1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringUnitofMeasure", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_InventoryControlABCCode", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "InventoryControlABCCode", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_InventoryControlABCCode1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "InventoryControlABCCode", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_InventoryControlOrderQuantity", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "InventoryControlOrderQuantity", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_InventoryControlOrderQuantity1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "InventoryControlOrderQuantity", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_InventoryControlPlanningCode", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "InventoryControlPlanningCode", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_InventoryControlPlanningCode1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "InventoryControlPlanningCode", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_InventoryControlSourceCode", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "InventoryControlSourceCode", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_InventoryControlSourceCode1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "InventoryControlSourceCode", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_InventoryControlSpareCode", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "InventoryControlSpareCode", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_InventoryControlSpareCode1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "InventoryControlSpareCode", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProductionControlForcastedUsage", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProductionControlForcastedUsage", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProductionControlForcastedUsage1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProductionControlForcastedUsage", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProductionControlManufacturingLeadTime", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProductionControlManufacturingLeadTime", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProductionControlManufacturingLeadTime1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProductionControlManufacturingLeadTime", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProductionControlShrinkageFactor", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProductionControlShrinkageFactor", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProductionControlShrinkageFactor1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProductionControlShrinkageFactor", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProductionControlYieldPercent", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProductionControlYieldPercent", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProductionControlYieldPercent1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProductionControlYieldPercent", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PurchasingBuyerCode", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PurchasingBuyerCode", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PurchasingBuyerCode1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PurchasingBuyerCode", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PurchasingCommodityCode", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PurchasingCommodityCode", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PurchasingCommodityCode1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PurchasingCommodityCode", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PurchasingPurchasingLeadTime", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PurchasingPurchasingLeadTime", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PurchasingPurchasingLeadTime1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PurchasingPurchasingLeadTime", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SignatureDateEngineering", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SignatureDateEngineering", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SignatureDateEngineering1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SignatureDateEngineering", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SignatureDateManufacturing", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SignatureDateManufacturing", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SignatureDateManufacturing1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SignatureDateManufacturing", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SignatureDatePurchasing", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SignatureDatePurchasing", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SignatureDatePurchasing1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SignatureDatePurchasing", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SignatureDateQuality", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SignatureDateQuality", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SignatureDateQuality1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SignatureDateQuality", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SignatureEngineering", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SignatureEngineering", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SignatureEngineering1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SignatureEngineering", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SignatureManufacturing", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SignatureManufacturing", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SignatureManufacturing1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SignatureManufacturing", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SignaturePurchasing", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SignaturePurchasing", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SignaturePurchasing1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SignaturePurchasing", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SignatureQuality", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SignatureQuality", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SignatureQuality1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SignatureQuality", System.Data.DataRowVersion.Original, Nothing))
            '
            'daE025BillofMaterialInput
            '
            Me.daE025BillofMaterialInput.DeleteCommand = Me.OleDbCommand1
            Me.daE025BillofMaterialInput.InsertCommand = Me.OleDbCommand2
            Me.daE025BillofMaterialInput.SelectCommand = Me.OleDbCommand3
            Me.daE025BillofMaterialInput.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "E025BillofMaterialInput", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("AuthorizationsEngineering", "AuthorizationsEngineering"), New System.Data.Common.DataColumnMapping("AuthorizationsEngineeringDate", "AuthorizationsEngineeringDate"), New System.Data.Common.DataColumnMapping("AuthorizationsManufacturing", "AuthorizationsManufacturing"), New System.Data.Common.DataColumnMapping("AuthorizationsManufacturingDate", "AuthorizationsManufacturingDate"), New System.Data.Common.DataColumnMapping("BillofMaterialInputNumber", "BillofMaterialInputNumber"), New System.Data.Common.DataColumnMapping("DataEntryCode", "DataEntryCode"), New System.Data.Common.DataColumnMapping("NextHigherAssembly", "NextHigherAssembly"), New System.Data.Common.DataColumnMapping("Originator", "Originator"), New System.Data.Common.DataColumnMapping("OriginatorDate", "OriginatorDate"), New System.Data.Common.DataColumnMapping("ParentAassemblyName", "ParentAassemblyName"), New System.Data.Common.DataColumnMapping("ParentPartNumber", "ParentPartNumber"), New System.Data.Common.DataColumnMapping("PartNumber", "PartNumber")})})
            Me.daE025BillofMaterialInput.UpdateCommand = Me.OleDbCommand4
            '
            'OleDbCommand1
            '
            Me.OleDbCommand1.CommandText = "DELETE FROM E025BillofMaterialInput WHERE (BillofMaterialInputNumber = ?) AND (Au" & _
            "thorizationsEngineering = ? OR ? IS NULL AND AuthorizationsEngineering IS NULL) " & _
            "AND (AuthorizationsEngineeringDate = ? OR ? IS NULL AND AuthorizationsEngineerin" & _
            "gDate IS NULL) AND (AuthorizationsManufacturing = ? OR ? IS NULL AND Authorizati" & _
            "onsManufacturing IS NULL) AND (AuthorizationsManufacturingDate = ? OR ? IS NULL " & _
            "AND AuthorizationsManufacturingDate IS NULL) AND (DataEntryCode = ? OR ? IS NULL" & _
            " AND DataEntryCode IS NULL) AND (NextHigherAssembly = ? OR ? IS NULL AND NextHig" & _
            "herAssembly IS NULL) AND (Originator = ? OR ? IS NULL AND Originator IS NULL) AN" & _
            "D (OriginatorDate = ? OR ? IS NULL AND OriginatorDate IS NULL) AND (ParentAassem" & _
            "blyName = ? OR ? IS NULL AND ParentAassemblyName IS NULL) AND (ParentPartNumber " & _
            "= ? OR ? IS NULL AND ParentPartNumber IS NULL) AND (PartNumber = ? OR ? IS NULL " & _
            "AND PartNumber IS NULL)"
            Me.OleDbCommand1.Connection = Me.OleDbConn
            Me.OleDbCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BillofMaterialInputNumber", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BillofMaterialInputNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AuthorizationsEngineering", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AuthorizationsEngineering", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AuthorizationsEngineering1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AuthorizationsEngineering", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AuthorizationsEngineeringDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AuthorizationsEngineeringDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AuthorizationsEngineeringDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AuthorizationsEngineeringDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AuthorizationsManufacturing", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AuthorizationsManufacturing", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AuthorizationsManufacturing1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AuthorizationsManufacturing", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AuthorizationsManufacturingDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AuthorizationsManufacturingDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AuthorizationsManufacturingDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AuthorizationsManufacturingDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DataEntryCode", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DataEntryCode", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DataEntryCode1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DataEntryCode", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NextHigherAssembly", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NextHigherAssembly", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NextHigherAssembly1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NextHigherAssembly", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Originator", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Originator", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Originator1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Originator", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OriginatorDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OriginatorDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OriginatorDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OriginatorDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ParentAassemblyName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ParentAassemblyName", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ParentAassemblyName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ParentAassemblyName", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ParentPartNumber", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ParentPartNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ParentPartNumber1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ParentPartNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PartNumber", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PartNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PartNumber1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PartNumber", System.Data.DataRowVersion.Original, Nothing))
            '
            'OleDbCommand2
            '
            Me.OleDbCommand2.CommandText = "INSERT INTO E025BillofMaterialInput(AuthorizationsEngineering, AuthorizationsEngi" & _
            "neeringDate, AuthorizationsManufacturing, AuthorizationsManufacturingDate, DataE" & _
            "ntryCode, NextHigherAssembly, Originator, OriginatorDate, ParentAassemblyName, P" & _
            "arentPartNumber, PartNumber) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"
            Me.OleDbCommand2.Connection = Me.OleDbConn
            Me.OleDbCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("AuthorizationsEngineering", System.Data.OleDb.OleDbType.VarWChar, 50, "AuthorizationsEngineering"))
            Me.OleDbCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("AuthorizationsEngineeringDate", System.Data.OleDb.OleDbType.DBDate, 0, "AuthorizationsEngineeringDate"))
            Me.OleDbCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("AuthorizationsManufacturing", System.Data.OleDb.OleDbType.VarWChar, 50, "AuthorizationsManufacturing"))
            Me.OleDbCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("AuthorizationsManufacturingDate", System.Data.OleDb.OleDbType.DBDate, 0, "AuthorizationsManufacturingDate"))
            Me.OleDbCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("DataEntryCode", System.Data.OleDb.OleDbType.VarWChar, 50, "DataEntryCode"))
            Me.OleDbCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("NextHigherAssembly", System.Data.OleDb.OleDbType.VarWChar, 50, "NextHigherAssembly"))
            Me.OleDbCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Originator", System.Data.OleDb.OleDbType.VarWChar, 50, "Originator"))
            Me.OleDbCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("OriginatorDate", System.Data.OleDb.OleDbType.DBDate, 0, "OriginatorDate"))
            Me.OleDbCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("ParentAassemblyName", System.Data.OleDb.OleDbType.VarWChar, 50, "ParentAassemblyName"))
            Me.OleDbCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("ParentPartNumber", System.Data.OleDb.OleDbType.VarWChar, 50, "ParentPartNumber"))
            Me.OleDbCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("PartNumber", System.Data.OleDb.OleDbType.VarWChar, 50, "PartNumber"))
            '
            'OleDbCommand3
            '
            Me.OleDbCommand3.CommandText = "SELECT AuthorizationsEngineering, AuthorizationsEngineeringDate, AuthorizationsMa" & _
            "nufacturing, AuthorizationsManufacturingDate, BillofMaterialInputNumber, DataEnt" & _
            "ryCode, NextHigherAssembly, Originator, OriginatorDate, ParentAassemblyName, Par" & _
            "entPartNumber, PartNumber FROM E025BillofMaterialInput ORDER BY BillofMaterialIn" & _
            "putNumber DESC"
            Me.OleDbCommand3.Connection = Me.OleDbConn
            '
            'OleDbCommand4
            '
            Me.OleDbCommand4.CommandText = "UPDATE E025BillofMaterialInput SET AuthorizationsEngineering = ?, AuthorizationsE" & _
            "ngineeringDate = ?, AuthorizationsManufacturing = ?, AuthorizationsManufacturing" & _
            "Date = ?, DataEntryCode = ?, NextHigherAssembly = ?, Originator = ?, OriginatorD" & _
            "ate = ?, ParentAassemblyName = ?, ParentPartNumber = ?, PartNumber = ? WHERE (Bi" & _
            "llofMaterialInputNumber = ?) AND (AuthorizationsEngineering = ? OR ? IS NULL AND" & _
            " AuthorizationsEngineering IS NULL) AND (AuthorizationsEngineeringDate = ? OR ? " & _
            "IS NULL AND AuthorizationsEngineeringDate IS NULL) AND (AuthorizationsManufactur" & _
            "ing = ? OR ? IS NULL AND AuthorizationsManufacturing IS NULL) AND (Authorization" & _
            "sManufacturingDate = ? OR ? IS NULL AND AuthorizationsManufacturingDate IS NULL)" & _
            " AND (DataEntryCode = ? OR ? IS NULL AND DataEntryCode IS NULL) AND (NextHigherA" & _
            "ssembly = ? OR ? IS NULL AND NextHigherAssembly IS NULL) AND (Originator = ? OR " & _
            "? IS NULL AND Originator IS NULL) AND (OriginatorDate = ? OR ? IS NULL AND Origi" & _
            "natorDate IS NULL) AND (ParentAassemblyName = ? OR ? IS NULL AND ParentAassembly" & _
            "Name IS NULL) AND (ParentPartNumber = ? OR ? IS NULL AND ParentPartNumber IS NUL" & _
            "L) AND (PartNumber = ? OR ? IS NULL AND PartNumber IS NULL)"
            Me.OleDbCommand4.Connection = Me.OleDbConn
            Me.OleDbCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("AuthorizationsEngineering", System.Data.OleDb.OleDbType.VarWChar, 50, "AuthorizationsEngineering"))
            Me.OleDbCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("AuthorizationsEngineeringDate", System.Data.OleDb.OleDbType.DBDate, 0, "AuthorizationsEngineeringDate"))
            Me.OleDbCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("AuthorizationsManufacturing", System.Data.OleDb.OleDbType.VarWChar, 50, "AuthorizationsManufacturing"))
            Me.OleDbCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("AuthorizationsManufacturingDate", System.Data.OleDb.OleDbType.DBDate, 0, "AuthorizationsManufacturingDate"))
            Me.OleDbCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("DataEntryCode", System.Data.OleDb.OleDbType.VarWChar, 50, "DataEntryCode"))
            Me.OleDbCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("NextHigherAssembly", System.Data.OleDb.OleDbType.VarWChar, 50, "NextHigherAssembly"))
            Me.OleDbCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Originator", System.Data.OleDb.OleDbType.VarWChar, 50, "Originator"))
            Me.OleDbCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("OriginatorDate", System.Data.OleDb.OleDbType.DBDate, 0, "OriginatorDate"))
            Me.OleDbCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("ParentAassemblyName", System.Data.OleDb.OleDbType.VarWChar, 50, "ParentAassemblyName"))
            Me.OleDbCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("ParentPartNumber", System.Data.OleDb.OleDbType.VarWChar, 50, "ParentPartNumber"))
            Me.OleDbCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("PartNumber", System.Data.OleDb.OleDbType.VarWChar, 50, "PartNumber"))
            Me.OleDbCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BillofMaterialInputNumber", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BillofMaterialInputNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AuthorizationsEngineering", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AuthorizationsEngineering", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AuthorizationsEngineering1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AuthorizationsEngineering", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AuthorizationsEngineeringDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AuthorizationsEngineeringDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AuthorizationsEngineeringDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AuthorizationsEngineeringDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AuthorizationsManufacturing", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AuthorizationsManufacturing", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AuthorizationsManufacturing1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AuthorizationsManufacturing", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AuthorizationsManufacturingDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AuthorizationsManufacturingDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AuthorizationsManufacturingDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AuthorizationsManufacturingDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DataEntryCode", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DataEntryCode", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DataEntryCode1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DataEntryCode", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NextHigherAssembly", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NextHigherAssembly", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NextHigherAssembly1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NextHigherAssembly", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Originator", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Originator", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Originator1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Originator", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OriginatorDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OriginatorDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OriginatorDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OriginatorDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ParentAassemblyName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ParentAassemblyName", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ParentAassemblyName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ParentAassemblyName", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ParentPartNumber", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ParentPartNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ParentPartNumber1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ParentPartNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PartNumber", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PartNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PartNumber1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PartNumber", System.Data.DataRowVersion.Original, Nothing))
            '
            'OleDbCommand5
            '
            Me.OleDbCommand5.CommandText = "UPDATE E003AsBuiltConfigurationRecord SET ABCRDate = ?, ABCRNumber = ?, ABCRRevis" & _
            "ion = ?, Engineer = ?, EngineerDate = ?, Manufacturing = ?, ManufacturingDate = " & _
            "? WHERE (ABCRNumber = ?) AND (ABCRDate = ? OR ? IS NULL AND ABCRDate IS NULL) AN" & _
            "D (ABCRRevision = ? OR ? IS NULL AND ABCRRevision IS NULL) AND (Engineer = ? OR " & _
            "? IS NULL AND Engineer IS NULL) AND (EngineerDate = ? OR ? IS NULL AND EngineerD" & _
            "ate IS NULL) AND (Manufacturing = ? OR ? IS NULL AND Manufacturing IS NULL) AND " & _
            "(ManufacturingDate = ? OR ? IS NULL AND ManufacturingDate IS NULL)"
            Me.OleDbCommand5.Connection = Me.OleDbConn
            Me.OleDbCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("ABCRDate", System.Data.OleDb.OleDbType.DBDate, 0, "ABCRDate"))
            Me.OleDbCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("ABCRNumber", System.Data.OleDb.OleDbType.VarWChar, 50, "ABCRNumber"))
            Me.OleDbCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("ABCRRevision", System.Data.OleDb.OleDbType.VarWChar, 50, "ABCRRevision"))
            Me.OleDbCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Engineer", System.Data.OleDb.OleDbType.VarWChar, 50, "Engineer"))
            Me.OleDbCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("EngineerDate", System.Data.OleDb.OleDbType.DBDate, 0, "EngineerDate"))
            Me.OleDbCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Manufacturing", System.Data.OleDb.OleDbType.VarWChar, 50, "Manufacturing"))
            Me.OleDbCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("ManufacturingDate", System.Data.OleDb.OleDbType.DBDate, 0, "ManufacturingDate"))
            Me.OleDbCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ABCRNumber", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ABCRNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ABCRDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ABCRDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ABCRDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ABCRDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ABCRRevision", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ABCRRevision", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ABCRRevision1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ABCRRevision", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Engineer", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Engineer1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineerDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineerDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineerDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineerDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Manufacturing", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Manufacturing", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Manufacturing1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Manufacturing", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ManufacturingDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ManufacturingDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ManufacturingDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ManufacturingDate", System.Data.DataRowVersion.Original, Nothing))
            '
            'OleDbCommand6
            '
            Me.OleDbCommand6.CommandText = "SELECT CBDNumber, CDBDate, CDBRevision, Customer, CustomerDate, Engineer, Enginee" & _
            "rDate FROM E002ConfigurationBaselineDocument"
            Me.OleDbCommand6.Connection = Me.OleDbConn
            '
            'OleDbCommand7
            '
            Me.OleDbCommand7.CommandText = "INSERT INTO E002ConfigurationBaselineDocument(CDBDate, CDBRevision, Customer, Cus" & _
            "tomerDate, Engineer, EngineerDate) VALUES (?, ?, ?, ?, ?, ?)"
            Me.OleDbCommand7.Connection = Me.OleDbConn
            Me.OleDbCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("CDBDate", System.Data.OleDb.OleDbType.DBDate, 0, "CDBDate"))
            Me.OleDbCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("CDBRevision", System.Data.OleDb.OleDbType.VarWChar, 50, "CDBRevision"))
            Me.OleDbCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Customer", System.Data.OleDb.OleDbType.VarWChar, 50, "Customer"))
            Me.OleDbCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("CustomerDate", System.Data.OleDb.OleDbType.DBDate, 0, "CustomerDate"))
            Me.OleDbCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Engineer", System.Data.OleDb.OleDbType.VarWChar, 50, "Engineer"))
            Me.OleDbCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("EngineerDate", System.Data.OleDb.OleDbType.DBDate, 0, "EngineerDate"))
            '
            'OleDbCommand8
            '
            Me.OleDbCommand8.CommandText = "UPDATE E002ConfigurationBaselineDocument SET CDBDate = ?, CDBRevision = ?, Custom" & _
            "er = ?, CustomerDate = ?, Engineer = ?, EngineerDate = ? WHERE (CBDNumber = ?) A" & _
            "ND (CDBDate = ? OR ? IS NULL AND CDBDate IS NULL) AND (CDBRevision = ? OR ? IS N" & _
            "ULL AND CDBRevision IS NULL) AND (Customer = ? OR ? IS NULL AND Customer IS NULL" & _
            ") AND (CustomerDate = ? OR ? IS NULL AND CustomerDate IS NULL) AND (Engineer = ?" & _
            " OR ? IS NULL AND Engineer IS NULL) AND (EngineerDate = ? OR ? IS NULL AND Engin" & _
            "eerDate IS NULL)"
            Me.OleDbCommand8.Connection = Me.OleDbConn
            Me.OleDbCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("CDBDate", System.Data.OleDb.OleDbType.DBDate, 0, "CDBDate"))
            Me.OleDbCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("CDBRevision", System.Data.OleDb.OleDbType.VarWChar, 50, "CDBRevision"))
            Me.OleDbCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("Customer", System.Data.OleDb.OleDbType.VarWChar, 50, "Customer"))
            Me.OleDbCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("CustomerDate", System.Data.OleDb.OleDbType.DBDate, 0, "CustomerDate"))
            Me.OleDbCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("Engineer", System.Data.OleDb.OleDbType.VarWChar, 50, "Engineer"))
            Me.OleDbCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("EngineerDate", System.Data.OleDb.OleDbType.DBDate, 0, "EngineerDate"))
            Me.OleDbCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CBDNumber", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CBDNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CDBDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CDBDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CDBDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CDBDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CDBRevision", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CDBRevision", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CDBRevision1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CDBRevision", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Customer", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Customer", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Customer1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Customer", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CustomerDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CustomerDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CustomerDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CustomerDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Engineer", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Engineer1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineerDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineerDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineerDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineerDate", System.Data.DataRowVersion.Original, Nothing))
            '
            'OleDbCommand9
            '
            Me.OleDbCommand9.CommandText = "SELECT CBDNumber, CBDRecId, Description, DocumentNumber, EngineeringChangeNumber," & _
            " IndentNumber, Quantity, Revision, TraceabilityCode FROM E002CBDSubTable"
            Me.OleDbCommand9.Connection = Me.OleDbConn
            '
            'OleDbCommand10
            '
            Me.OleDbCommand10.CommandText = "DELETE FROM E003AsBuiltConfigurationRecord WHERE (ABCRNumber = ?) AND (ABCRDate =" & _
            " ? OR ? IS NULL AND ABCRDate IS NULL) AND (ABCRRevision = ? OR ? IS NULL AND ABC" & _
            "RRevision IS NULL) AND (Engineer = ? OR ? IS NULL AND Engineer IS NULL) AND (Eng" & _
            "ineerDate = ? OR ? IS NULL AND EngineerDate IS NULL) AND (Manufacturing = ? OR ?" & _
            " IS NULL AND Manufacturing IS NULL) AND (ManufacturingDate = ? OR ? IS NULL AND " & _
            "ManufacturingDate IS NULL)"
            Me.OleDbCommand10.Connection = Me.OleDbConn
            Me.OleDbCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ABCRNumber", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ABCRNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ABCRDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ABCRDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ABCRDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ABCRDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ABCRRevision", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ABCRRevision", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ABCRRevision1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ABCRRevision", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Engineer", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Engineer1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineerDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineerDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineerDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineerDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Manufacturing", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Manufacturing", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Manufacturing1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Manufacturing", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ManufacturingDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ManufacturingDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ManufacturingDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ManufacturingDate", System.Data.DataRowVersion.Original, Nothing))
            '
            'OleDbInsertCommand4
            '
            Me.OleDbInsertCommand4.CommandText = "INSERT INTO E003AsBltSubTbl(ABCRNumber, AsDesignedAsBuiltDifferences, Description" & _
            ", DocumentNumber, EngineeringChangeNumber, IndentNumber, Quantity, SerialNumber)" & _
            " VALUES (?, ?, ?, ?, ?, ?, ?, ?)"
            Me.OleDbInsertCommand4.Connection = Me.OleDbConn
            Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("ABCRNumber", System.Data.OleDb.OleDbType.VarWChar, 50, "ABCRNumber"))
            Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("AsDesignedAsBuiltDifferences", System.Data.OleDb.OleDbType.VarWChar, 50, "AsDesignedAsBuiltDifferences"))
            Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.VarWChar, 50, "Description"))
            Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("DocumentNumber", System.Data.OleDb.OleDbType.VarWChar, 50, "DocumentNumber"))
            Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("EngineeringChangeNumber", System.Data.OleDb.OleDbType.VarWChar, 50, "EngineeringChangeNumber"))
            Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("IndentNumber", System.Data.OleDb.OleDbType.VarWChar, 50, "IndentNumber"))
            Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Quantity", System.Data.OleDb.OleDbType.VarWChar, 50, "Quantity"))
            Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("SerialNumber", System.Data.OleDb.OleDbType.VarWChar, 50, "SerialNumber"))
            '
            'OleDbCommand11
            '
            Me.OleDbCommand11.CommandText = "DELETE FROM E003AsBltSubTbl WHERE (ABCRecId = ?) AND (ABCRNumber = ? OR ? IS NULL" & _
            " AND ABCRNumber IS NULL) AND (AsDesignedAsBuiltDifferences = ? OR ? IS NULL AND " & _
            "AsDesignedAsBuiltDifferences IS NULL) AND (Description = ? OR ? IS NULL AND Desc" & _
            "ription IS NULL) AND (DocumentNumber = ? OR ? IS NULL AND DocumentNumber IS NULL" & _
            ") AND (EngineeringChangeNumber = ? OR ? IS NULL AND EngineeringChangeNumber IS N" & _
            "ULL) AND (IndentNumber = ? OR ? IS NULL AND IndentNumber IS NULL) AND (Quantity " & _
            "= ? OR ? IS NULL AND Quantity IS NULL) AND (SerialNumber = ? OR ? IS NULL AND Se" & _
            "rialNumber IS NULL)"
            Me.OleDbCommand11.Connection = Me.OleDbConn
            Me.OleDbCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ABCRecId", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ABCRecId", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ABCRNumber", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ABCRNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ABCRNumber1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ABCRNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AsDesignedAsBuiltDifferences", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AsDesignedAsBuiltDifferences", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AsDesignedAsBuiltDifferences1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AsDesignedAsBuiltDifferences", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Description", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Description", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Description1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Description", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DocumentNumber", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DocumentNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DocumentNumber1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DocumentNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringChangeNumber", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringChangeNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringChangeNumber1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringChangeNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IndentNumber", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IndentNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IndentNumber1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IndentNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Quantity", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Quantity", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Quantity1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Quantity", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SerialNumber", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SerialNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SerialNumber1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SerialNumber", System.Data.DataRowVersion.Original, Nothing))
            '
            'OleDbCommand12
            '
            Me.OleDbCommand12.CommandText = "UPDATE E003AsBltSubTbl SET ABCRNumber = ?, AsDesignedAsBuiltDifferences = ?, Desc" & _
            "ription = ?, DocumentNumber = ?, EngineeringChangeNumber = ?, IndentNumber = ?, " & _
            "Quantity = ?, SerialNumber = ? WHERE (ABCRecId = ?) AND (ABCRNumber = ? OR ? IS " & _
            "NULL AND ABCRNumber IS NULL) AND (AsDesignedAsBuiltDifferences = ? OR ? IS NULL " & _
            "AND AsDesignedAsBuiltDifferences IS NULL) AND (Description = ? OR ? IS NULL AND " & _
            "Description IS NULL) AND (DocumentNumber = ? OR ? IS NULL AND DocumentNumber IS " & _
            "NULL) AND (EngineeringChangeNumber = ? OR ? IS NULL AND EngineeringChangeNumber " & _
            "IS NULL) AND (IndentNumber = ? OR ? IS NULL AND IndentNumber IS NULL) AND (Quant" & _
            "ity = ? OR ? IS NULL AND Quantity IS NULL) AND (SerialNumber = ? OR ? IS NULL AN" & _
            "D SerialNumber IS NULL)"
            Me.OleDbCommand12.Connection = Me.OleDbConn
            Me.OleDbCommand12.Parameters.Add(New System.Data.OleDb.OleDbParameter("ABCRNumber", System.Data.OleDb.OleDbType.VarWChar, 50, "ABCRNumber"))
            Me.OleDbCommand12.Parameters.Add(New System.Data.OleDb.OleDbParameter("AsDesignedAsBuiltDifferences", System.Data.OleDb.OleDbType.VarWChar, 50, "AsDesignedAsBuiltDifferences"))
            Me.OleDbCommand12.Parameters.Add(New System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.VarWChar, 50, "Description"))
            Me.OleDbCommand12.Parameters.Add(New System.Data.OleDb.OleDbParameter("DocumentNumber", System.Data.OleDb.OleDbType.VarWChar, 50, "DocumentNumber"))
            Me.OleDbCommand12.Parameters.Add(New System.Data.OleDb.OleDbParameter("EngineeringChangeNumber", System.Data.OleDb.OleDbType.VarWChar, 50, "EngineeringChangeNumber"))
            Me.OleDbCommand12.Parameters.Add(New System.Data.OleDb.OleDbParameter("IndentNumber", System.Data.OleDb.OleDbType.VarWChar, 50, "IndentNumber"))
            Me.OleDbCommand12.Parameters.Add(New System.Data.OleDb.OleDbParameter("Quantity", System.Data.OleDb.OleDbType.VarWChar, 50, "Quantity"))
            Me.OleDbCommand12.Parameters.Add(New System.Data.OleDb.OleDbParameter("SerialNumber", System.Data.OleDb.OleDbType.VarWChar, 50, "SerialNumber"))
            Me.OleDbCommand12.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ABCRecId", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ABCRecId", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand12.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ABCRNumber", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ABCRNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand12.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ABCRNumber1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ABCRNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand12.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AsDesignedAsBuiltDifferences", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AsDesignedAsBuiltDifferences", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand12.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AsDesignedAsBuiltDifferences1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AsDesignedAsBuiltDifferences", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand12.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Description", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Description", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand12.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Description1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Description", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand12.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DocumentNumber", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DocumentNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand12.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DocumentNumber1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DocumentNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand12.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringChangeNumber", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringChangeNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand12.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringChangeNumber1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringChangeNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand12.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IndentNumber", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IndentNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand12.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IndentNumber1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IndentNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand12.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Quantity", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Quantity", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand12.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Quantity1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Quantity", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand12.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SerialNumber", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SerialNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand12.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SerialNumber1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SerialNumber", System.Data.DataRowVersion.Original, Nothing))
            '
            'OleDbCommand13
            '
            Me.OleDbCommand13.CommandText = "INSERT INTO E002CBDSubTable(CBDNumber, Description, DocumentNumber, EngineeringCh" & _
            "angeNumber, IndentNumber, Quantity, Revision, TraceabilityCode) VALUES (?, ?, ?," & _
            " ?, ?, ?, ?, ?)"
            Me.OleDbCommand13.Connection = Me.OleDbConn
            Me.OleDbCommand13.Parameters.Add(New System.Data.OleDb.OleDbParameter("CBDNumber", System.Data.OleDb.OleDbType.VarWChar, 50, "CBDNumber"))
            Me.OleDbCommand13.Parameters.Add(New System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.VarWChar, 50, "Description"))
            Me.OleDbCommand13.Parameters.Add(New System.Data.OleDb.OleDbParameter("DocumentNumber", System.Data.OleDb.OleDbType.VarWChar, 50, "DocumentNumber"))
            Me.OleDbCommand13.Parameters.Add(New System.Data.OleDb.OleDbParameter("EngineeringChangeNumber", System.Data.OleDb.OleDbType.VarWChar, 50, "EngineeringChangeNumber"))
            Me.OleDbCommand13.Parameters.Add(New System.Data.OleDb.OleDbParameter("IndentNumber", System.Data.OleDb.OleDbType.VarWChar, 50, "IndentNumber"))
            Me.OleDbCommand13.Parameters.Add(New System.Data.OleDb.OleDbParameter("Quantity", System.Data.OleDb.OleDbType.VarWChar, 50, "Quantity"))
            Me.OleDbCommand13.Parameters.Add(New System.Data.OleDb.OleDbParameter("Revision", System.Data.OleDb.OleDbType.VarWChar, 50, "Revision"))
            Me.OleDbCommand13.Parameters.Add(New System.Data.OleDb.OleDbParameter("TraceabilityCode", System.Data.OleDb.OleDbType.VarWChar, 50, "TraceabilityCode"))
            '
            'daE003AsBlt
            '
            Me.daE003AsBlt.DeleteCommand = Me.OleDbCommand10
            Me.daE003AsBlt.InsertCommand = Me.OleDbCommand14
            Me.daE003AsBlt.SelectCommand = Me.OleDbCommand15
            Me.daE003AsBlt.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "E003AsBuiltConfigurationRecord", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ABCRDate", "ABCRDate"), New System.Data.Common.DataColumnMapping("ABCRNumber", "ABCRNumber"), New System.Data.Common.DataColumnMapping("ABCRRevision", "ABCRRevision"), New System.Data.Common.DataColumnMapping("Engineer", "Engineer"), New System.Data.Common.DataColumnMapping("EngineerDate", "EngineerDate"), New System.Data.Common.DataColumnMapping("Manufacturing", "Manufacturing"), New System.Data.Common.DataColumnMapping("ManufacturingDate", "ManufacturingDate")})})
            Me.daE003AsBlt.UpdateCommand = Me.OleDbCommand5
            '
            'OleDbCommand14
            '
            Me.OleDbCommand14.CommandText = "INSERT INTO E003AsBuiltConfigurationRecord(ABCRDate, ABCRNumber, ABCRRevision, En" & _
            "gineer, EngineerDate, Manufacturing, ManufacturingDate) VALUES (?, ?, ?, ?, ?, ?" & _
            ", ?)"
            Me.OleDbCommand14.Connection = Me.OleDbConn
            Me.OleDbCommand14.Parameters.Add(New System.Data.OleDb.OleDbParameter("ABCRDate", System.Data.OleDb.OleDbType.DBDate, 0, "ABCRDate"))
            Me.OleDbCommand14.Parameters.Add(New System.Data.OleDb.OleDbParameter("ABCRNumber", System.Data.OleDb.OleDbType.VarWChar, 50, "ABCRNumber"))
            Me.OleDbCommand14.Parameters.Add(New System.Data.OleDb.OleDbParameter("ABCRRevision", System.Data.OleDb.OleDbType.VarWChar, 50, "ABCRRevision"))
            Me.OleDbCommand14.Parameters.Add(New System.Data.OleDb.OleDbParameter("Engineer", System.Data.OleDb.OleDbType.VarWChar, 50, "Engineer"))
            Me.OleDbCommand14.Parameters.Add(New System.Data.OleDb.OleDbParameter("EngineerDate", System.Data.OleDb.OleDbType.DBDate, 0, "EngineerDate"))
            Me.OleDbCommand14.Parameters.Add(New System.Data.OleDb.OleDbParameter("Manufacturing", System.Data.OleDb.OleDbType.VarWChar, 50, "Manufacturing"))
            Me.OleDbCommand14.Parameters.Add(New System.Data.OleDb.OleDbParameter("ManufacturingDate", System.Data.OleDb.OleDbType.DBDate, 0, "ManufacturingDate"))
            '
            'OleDbCommand15
            '
            Me.OleDbCommand15.CommandText = "SELECT ABCRDate, ABCRNumber, ABCRRevision, Engineer, EngineerDate, Manufacturing," & _
            " ManufacturingDate FROM E003AsBuiltConfigurationRecord"
            Me.OleDbCommand15.Connection = Me.OleDbConn
            '
            'daE003AsBltSubTbl
            '
            Me.daE003AsBltSubTbl.DeleteCommand = Me.OleDbCommand11
            Me.daE003AsBltSubTbl.InsertCommand = Me.OleDbInsertCommand4
            Me.daE003AsBltSubTbl.SelectCommand = Me.OleDbSelectCommand4
            Me.daE003AsBltSubTbl.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "E003AsBltSubTbl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ABCRecId", "ABCRecId"), New System.Data.Common.DataColumnMapping("ABCRNumber", "ABCRNumber"), New System.Data.Common.DataColumnMapping("AsDesignedAsBuiltDifferences", "AsDesignedAsBuiltDifferences"), New System.Data.Common.DataColumnMapping("Description", "Description"), New System.Data.Common.DataColumnMapping("DocumentNumber", "DocumentNumber"), New System.Data.Common.DataColumnMapping("EngineeringChangeNumber", "EngineeringChangeNumber"), New System.Data.Common.DataColumnMapping("IndentNumber", "IndentNumber"), New System.Data.Common.DataColumnMapping("Quantity", "Quantity"), New System.Data.Common.DataColumnMapping("SerialNumber", "SerialNumber")})})
            Me.daE003AsBltSubTbl.UpdateCommand = Me.OleDbCommand12
            '
            'OleDbSelectCommand4
            '
            Me.OleDbSelectCommand4.CommandText = "SELECT ABCRecId, ABCRNumber, AsDesignedAsBuiltDifferences, Description, DocumentN" & _
            "umber, EngineeringChangeNumber, IndentNumber, Quantity, SerialNumber FROM E003As" & _
            "BltSubTbl"
            Me.OleDbSelectCommand4.Connection = Me.OleDbConn
            '
            'daE002CBDSubTbl
            '
            Me.daE002CBDSubTbl.DeleteCommand = Me.OleDbCommand16
            Me.daE002CBDSubTbl.InsertCommand = Me.OleDbCommand13
            Me.daE002CBDSubTbl.SelectCommand = Me.OleDbCommand9
            Me.daE002CBDSubTbl.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "E002CBDSubTable", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CBDNumber", "CBDNumber"), New System.Data.Common.DataColumnMapping("CBDRecId", "CBDRecId"), New System.Data.Common.DataColumnMapping("Description", "Description"), New System.Data.Common.DataColumnMapping("DocumentNumber", "DocumentNumber"), New System.Data.Common.DataColumnMapping("EngineeringChangeNumber", "EngineeringChangeNumber"), New System.Data.Common.DataColumnMapping("IndentNumber", "IndentNumber"), New System.Data.Common.DataColumnMapping("Quantity", "Quantity"), New System.Data.Common.DataColumnMapping("Revision", "Revision"), New System.Data.Common.DataColumnMapping("TraceabilityCode", "TraceabilityCode")})})
            Me.daE002CBDSubTbl.UpdateCommand = Me.OleDbCommand17
            '
            'OleDbCommand16
            '
            Me.OleDbCommand16.CommandText = "DELETE FROM E002CBDSubTable WHERE (CBDRecId = ?) AND (CBDNumber = ? OR ? IS NULL " & _
            "AND CBDNumber IS NULL) AND (Description = ? OR ? IS NULL AND Description IS NULL" & _
            ") AND (DocumentNumber = ? OR ? IS NULL AND DocumentNumber IS NULL) AND (Engineer" & _
            "ingChangeNumber = ? OR ? IS NULL AND EngineeringChangeNumber IS NULL) AND (Inden" & _
            "tNumber = ? OR ? IS NULL AND IndentNumber IS NULL) AND (Quantity = ? OR ? IS NUL" & _
            "L AND Quantity IS NULL) AND (Revision = ? OR ? IS NULL AND Revision IS NULL) AND" & _
            " (TraceabilityCode = ? OR ? IS NULL AND TraceabilityCode IS NULL)"
            Me.OleDbCommand16.Connection = Me.OleDbConn
            Me.OleDbCommand16.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CBDRecId", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CBDRecId", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand16.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CBDNumber", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CBDNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand16.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CBDNumber1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CBDNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand16.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Description", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Description", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand16.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Description1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Description", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand16.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DocumentNumber", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DocumentNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand16.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DocumentNumber1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DocumentNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand16.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringChangeNumber", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringChangeNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand16.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringChangeNumber1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringChangeNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand16.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IndentNumber", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IndentNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand16.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IndentNumber1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IndentNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand16.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Quantity", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Quantity", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand16.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Quantity1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Quantity", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand16.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Revision", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Revision", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand16.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Revision1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Revision", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand16.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TraceabilityCode", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TraceabilityCode", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand16.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TraceabilityCode1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TraceabilityCode", System.Data.DataRowVersion.Original, Nothing))
            '
            'OleDbCommand17
            '
            Me.OleDbCommand17.CommandText = "UPDATE E002CBDSubTable SET CBDNumber = ?, Description = ?, DocumentNumber = ?, En" & _
            "gineeringChangeNumber = ?, IndentNumber = ?, Quantity = ?, Revision = ?, Traceab" & _
            "ilityCode = ? WHERE (CBDRecId = ?) AND (CBDNumber = ? OR ? IS NULL AND CBDNumber" & _
            " IS NULL) AND (Description = ? OR ? IS NULL AND Description IS NULL) AND (Docume" & _
            "ntNumber = ? OR ? IS NULL AND DocumentNumber IS NULL) AND (EngineeringChangeNumb" & _
            "er = ? OR ? IS NULL AND EngineeringChangeNumber IS NULL) AND (IndentNumber = ? O" & _
            "R ? IS NULL AND IndentNumber IS NULL) AND (Quantity = ? OR ? IS NULL AND Quantit" & _
            "y IS NULL) AND (Revision = ? OR ? IS NULL AND Revision IS NULL) AND (Traceabilit" & _
            "yCode = ? OR ? IS NULL AND TraceabilityCode IS NULL)"
            Me.OleDbCommand17.Connection = Me.OleDbConn
            Me.OleDbCommand17.Parameters.Add(New System.Data.OleDb.OleDbParameter("CBDNumber", System.Data.OleDb.OleDbType.VarWChar, 50, "CBDNumber"))
            Me.OleDbCommand17.Parameters.Add(New System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.VarWChar, 50, "Description"))
            Me.OleDbCommand17.Parameters.Add(New System.Data.OleDb.OleDbParameter("DocumentNumber", System.Data.OleDb.OleDbType.VarWChar, 50, "DocumentNumber"))
            Me.OleDbCommand17.Parameters.Add(New System.Data.OleDb.OleDbParameter("EngineeringChangeNumber", System.Data.OleDb.OleDbType.VarWChar, 50, "EngineeringChangeNumber"))
            Me.OleDbCommand17.Parameters.Add(New System.Data.OleDb.OleDbParameter("IndentNumber", System.Data.OleDb.OleDbType.VarWChar, 50, "IndentNumber"))
            Me.OleDbCommand17.Parameters.Add(New System.Data.OleDb.OleDbParameter("Quantity", System.Data.OleDb.OleDbType.VarWChar, 50, "Quantity"))
            Me.OleDbCommand17.Parameters.Add(New System.Data.OleDb.OleDbParameter("Revision", System.Data.OleDb.OleDbType.VarWChar, 50, "Revision"))
            Me.OleDbCommand17.Parameters.Add(New System.Data.OleDb.OleDbParameter("TraceabilityCode", System.Data.OleDb.OleDbType.VarWChar, 50, "TraceabilityCode"))
            Me.OleDbCommand17.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CBDRecId", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CBDRecId", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand17.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CBDNumber", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CBDNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand17.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CBDNumber1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CBDNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand17.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Description", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Description", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand17.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Description1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Description", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand17.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DocumentNumber", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DocumentNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand17.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DocumentNumber1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DocumentNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand17.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringChangeNumber", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringChangeNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand17.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringChangeNumber1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringChangeNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand17.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IndentNumber", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IndentNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand17.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IndentNumber1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IndentNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand17.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Quantity", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Quantity", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand17.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Quantity1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Quantity", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand17.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Revision", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Revision", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand17.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Revision1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Revision", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand17.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TraceabilityCode", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TraceabilityCode", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand17.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TraceabilityCode1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TraceabilityCode", System.Data.DataRowVersion.Original, Nothing))
            '
            'OleDbCommand18
            '
            Me.OleDbCommand18.CommandText = "DELETE FROM E002ConfigurationBaselineDocument WHERE (CBDNumber = ?) AND (CDBDate " & _
            "= ? OR ? IS NULL AND CDBDate IS NULL) AND (CDBRevision = ? OR ? IS NULL AND CDBR" & _
            "evision IS NULL) AND (Customer = ? OR ? IS NULL AND Customer IS NULL) AND (Custo" & _
            "merDate = ? OR ? IS NULL AND CustomerDate IS NULL) AND (Engineer = ? OR ? IS NUL" & _
            "L AND Engineer IS NULL) AND (EngineerDate = ? OR ? IS NULL AND EngineerDate IS N" & _
            "ULL)"
            Me.OleDbCommand18.Connection = Me.OleDbConn
            Me.OleDbCommand18.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CBDNumber", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CBDNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand18.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CDBDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CDBDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand18.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CDBDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CDBDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand18.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CDBRevision", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CDBRevision", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand18.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CDBRevision1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CDBRevision", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand18.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Customer", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Customer", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand18.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Customer1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Customer", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand18.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CustomerDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CustomerDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand18.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CustomerDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CustomerDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand18.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Engineer", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand18.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Engineer1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand18.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineerDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineerDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbCommand18.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineerDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineerDate", System.Data.DataRowVersion.Original, Nothing))
            '
            'daE002CBD
            '
            Me.daE002CBD.DeleteCommand = Me.OleDbCommand18
            Me.daE002CBD.InsertCommand = Me.OleDbCommand7
            Me.daE002CBD.SelectCommand = Me.OleDbCommand6
            Me.daE002CBD.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "E002ConfigurationBaselineDocument", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CBDNumber", "CBDNumber"), New System.Data.Common.DataColumnMapping("CDBDate", "CDBDate"), New System.Data.Common.DataColumnMapping("CDBRevision", "CDBRevision"), New System.Data.Common.DataColumnMapping("Customer", "Customer"), New System.Data.Common.DataColumnMapping("CustomerDate", "CustomerDate"), New System.Data.Common.DataColumnMapping("Engineer", "Engineer"), New System.Data.Common.DataColumnMapping("EngineerDate", "EngineerDate")})})
            Me.daE002CBD.UpdateCommand = Me.OleDbCommand8
            '
            'DataSet11
            '
            Me.DataSet11.DataSetName = "DataSet1"
            Me.DataSet11.Locale = New System.Globalization.CultureInfo("en-US")
            '
            'OleDbSelectCommand8
            '
            Me.OleDbSelectCommand8.CommandText = "SELECT AffectedDocuments, [Authorizations-Engineering], [Authorizations-Engineeri" & _
            "ngDate], [Authorizations-Manufacturing], [Authorizations-ManufacturingDate], [Au" & _
            "thorizations-Purchasing], [Authorizations-PurchasingDate], [Authorizations-Quali" & _
            "ty], [Authorizations-QualityDate], ClassofChange, DescriptionofChange, Engineeri" & _
            "ngChangeNumber, Manager, ManagerDate, ManagerDepartment, Originator, OriginatorD" & _
            "ate, OriginatorDepartment, Priority, RfcCostImprovement, RfcCustomerDirected, Rf" & _
            "cDesignError, RfcDraftingError, RfcFacilitateInspection, RfcFacilitateProduction" & _
            ", RfcNewRelease, RfcOtherExplain, RfcRedrawError, RfcSafteyInprovement, RfcSched" & _
            "uleImprovement, RfcVendorRequested FROM E037EngineeringChange ORDER BY Engineeri" & _
            "ngChangeNumber DESC"
            Me.OleDbSelectCommand8.Connection = Me.OleDbConn
            '
            'OleDbInsertCommand8
            '
            Me.OleDbInsertCommand8.CommandText = "INSERT INTO E037EngineeringChange(AffectedDocuments, [Authorizations-Engineering]" & _
            ", [Authorizations-EngineeringDate], [Authorizations-Manufacturing], [Authorizati" & _
            "ons-ManufacturingDate], [Authorizations-Purchasing], [Authorizations-PurchasingD" & _
            "ate], [Authorizations-Quality], [Authorizations-QualityDate], ClassofChange, Des" & _
            "criptionofChange, Manager, ManagerDate, ManagerDepartment, Originator, Originato" & _
            "rDate, OriginatorDepartment, Priority, RfcCostImprovement, RfcCustomerDirected, " & _
            "RfcDesignError, RfcDraftingError, RfcFacilitateInspection, RfcFacilitateProducti" & _
            "on, RfcNewRelease, RfcOtherExplain, RfcRedrawError, RfcSafteyInprovement, RfcSch" & _
            "eduleImprovement, RfcVendorRequested) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?" & _
            ", ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"
            Me.OleDbInsertCommand8.Connection = Me.OleDbConn
            Me.OleDbInsertCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("AffectedDocuments", System.Data.OleDb.OleDbType.Integer, 0, "AffectedDocuments"))
            Me.OleDbInsertCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("Authorizations_Engineering", System.Data.OleDb.OleDbType.VarWChar, 50, "Authorizations-Engineering"))
            Me.OleDbInsertCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("Authorizations_EngineeringDate", System.Data.OleDb.OleDbType.DBDate, 0, "Authorizations-EngineeringDate"))
            Me.OleDbInsertCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("Authorizations_Manufacturing", System.Data.OleDb.OleDbType.VarWChar, 50, "Authorizations-Manufacturing"))
            Me.OleDbInsertCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("Authorizations_ManufacturingDate", System.Data.OleDb.OleDbType.DBDate, 0, "Authorizations-ManufacturingDate"))
            Me.OleDbInsertCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("Authorizations_Purchasing", System.Data.OleDb.OleDbType.VarWChar, 50, "Authorizations-Purchasing"))
            Me.OleDbInsertCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("Authorizations_PurchasingDate", System.Data.OleDb.OleDbType.DBDate, 0, "Authorizations-PurchasingDate"))
            Me.OleDbInsertCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("Authorizations_Quality", System.Data.OleDb.OleDbType.VarWChar, 50, "Authorizations-Quality"))
            Me.OleDbInsertCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("Authorizations_QualityDate", System.Data.OleDb.OleDbType.DBDate, 0, "Authorizations-QualityDate"))
            Me.OleDbInsertCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("ClassofChange", System.Data.OleDb.OleDbType.VarWChar, 50, "ClassofChange"))
            Me.OleDbInsertCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("DescriptionofChange", System.Data.OleDb.OleDbType.VarWChar, 50, "DescriptionofChange"))
            Me.OleDbInsertCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("Manager", System.Data.OleDb.OleDbType.VarWChar, 50, "Manager"))
            Me.OleDbInsertCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("ManagerDate", System.Data.OleDb.OleDbType.DBDate, 0, "ManagerDate"))
            Me.OleDbInsertCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("ManagerDepartment", System.Data.OleDb.OleDbType.VarWChar, 50, "ManagerDepartment"))
            Me.OleDbInsertCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("Originator", System.Data.OleDb.OleDbType.VarWChar, 50, "Originator"))
            Me.OleDbInsertCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("OriginatorDate", System.Data.OleDb.OleDbType.DBDate, 0, "OriginatorDate"))
            Me.OleDbInsertCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("OriginatorDepartment", System.Data.OleDb.OleDbType.VarWChar, 50, "OriginatorDepartment"))
            Me.OleDbInsertCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("Priority", System.Data.OleDb.OleDbType.VarWChar, 50, "Priority"))
            Me.OleDbInsertCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("RfcCostImprovement", System.Data.OleDb.OleDbType.Boolean, 2, "RfcCostImprovement"))
            Me.OleDbInsertCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("RfcCustomerDirected", System.Data.OleDb.OleDbType.Boolean, 2, "RfcCustomerDirected"))
            Me.OleDbInsertCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("RfcDesignError", System.Data.OleDb.OleDbType.Boolean, 2, "RfcDesignError"))
            Me.OleDbInsertCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("RfcDraftingError", System.Data.OleDb.OleDbType.Boolean, 2, "RfcDraftingError"))
            Me.OleDbInsertCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("RfcFacilitateInspection", System.Data.OleDb.OleDbType.Boolean, 2, "RfcFacilitateInspection"))
            Me.OleDbInsertCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("RfcFacilitateProduction", System.Data.OleDb.OleDbType.Boolean, 2, "RfcFacilitateProduction"))
            Me.OleDbInsertCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("RfcNewRelease", System.Data.OleDb.OleDbType.Boolean, 2, "RfcNewRelease"))
            Me.OleDbInsertCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("RfcOtherExplain", System.Data.OleDb.OleDbType.VarWChar, 0, "RfcOtherExplain"))
            Me.OleDbInsertCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("RfcRedrawError", System.Data.OleDb.OleDbType.Boolean, 2, "RfcRedrawError"))
            Me.OleDbInsertCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("RfcSafteyInprovement", System.Data.OleDb.OleDbType.Boolean, 2, "RfcSafteyInprovement"))
            Me.OleDbInsertCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("RfcScheduleImprovement", System.Data.OleDb.OleDbType.Boolean, 2, "RfcScheduleImprovement"))
            Me.OleDbInsertCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("RfcVendorRequested", System.Data.OleDb.OleDbType.Boolean, 2, "RfcVendorRequested"))
            '
            'OleDbUpdateCommand7
            '
            Me.OleDbUpdateCommand7.CommandText = "UPDATE E037EngineeringChange SET AffectedDocuments = ?, [Authorizations-Engineeri" & _
            "ng] = ?, [Authorizations-EngineeringDate] = ?, [Authorizations-Manufacturing] = " & _
            "?, [Authorizations-ManufacturingDate] = ?, [Authorizations-Purchasing] = ?, [Aut" & _
            "horizations-PurchasingDate] = ?, [Authorizations-Quality] = ?, [Authorizations-Q" & _
            "ualityDate] = ?, ClassofChange = ?, DescriptionofChange = ?, Manager = ?, Manage" & _
            "rDate = ?, ManagerDepartment = ?, Originator = ?, OriginatorDate = ?, Originator" & _
            "Department = ?, Priority = ?, RfcCostImprovement = ?, RfcCustomerDirected = ?, R" & _
            "fcDesignError = ?, RfcDraftingError = ?, RfcFacilitateInspection = ?, RfcFacilit" & _
            "ateProduction = ?, RfcNewRelease = ?, RfcOtherExplain = ?, RfcRedrawError = ?, R" & _
            "fcSafteyInprovement = ?, RfcScheduleImprovement = ?, RfcVendorRequested = ? WHER" & _
            "E (EngineeringChangeNumber = ?) AND (AffectedDocuments = ? OR ? IS NULL AND Affe" & _
            "ctedDocuments IS NULL) AND ([Authorizations-Engineering] = ? OR ? IS NULL AND [A" & _
            "uthorizations-Engineering] IS NULL) AND ([Authorizations-EngineeringDate] = ? OR" & _
            " ? IS NULL AND [Authorizations-EngineeringDate] IS NULL) AND ([Authorizations-Ma" & _
            "nufacturing] = ? OR ? IS NULL AND [Authorizations-Manufacturing] IS NULL) AND ([" & _
            "Authorizations-ManufacturingDate] = ? OR ? IS NULL AND [Authorizations-Manufactu" & _
            "ringDate] IS NULL) AND ([Authorizations-Purchasing] = ? OR ? IS NULL AND [Author" & _
            "izations-Purchasing] IS NULL) AND ([Authorizations-PurchasingDate] = ? OR ? IS N" & _
            "ULL AND [Authorizations-PurchasingDate] IS NULL) AND ([Authorizations-Quality] =" & _
            " ? OR ? IS NULL AND [Authorizations-Quality] IS NULL) AND ([Authorizations-Quali" & _
            "tyDate] = ? OR ? IS NULL AND [Authorizations-QualityDate] IS NULL) AND (ClassofC" & _
            "hange = ? OR ? IS NULL AND ClassofChange IS NULL) AND (DescriptionofChange = ? O" & _
            "R ? IS NULL AND DescriptionofChange IS NULL) AND (Manager = ? OR ? IS NULL AND M" & _
            "anager IS NULL) AND (ManagerDate = ? OR ? IS NULL AND ManagerDate IS NULL) AND (" & _
            "ManagerDepartment = ? OR ? IS NULL AND ManagerDepartment IS NULL) AND (Originato" & _
            "r = ? OR ? IS NULL AND Originator IS NULL) AND (OriginatorDate = ? OR ? IS NULL " & _
            "AND OriginatorDate IS NULL) AND (OriginatorDepartment = ? OR ? IS NULL AND Origi" & _
            "natorDepartment IS NULL) AND (Priority = ? OR ? IS NULL AND Priority IS NULL) AN" & _
            "D (RfcCostImprovement = ?) AND (RfcCustomerDirected = ?) AND (RfcDesignError = ?" & _
            ") AND (RfcDraftingError = ?) AND (RfcFacilitateInspection = ?) AND (RfcFacilitat" & _
            "eProduction = ?) AND (RfcNewRelease = ?) AND (RfcRedrawError = ?) AND (RfcSaftey" & _
            "Inprovement = ?) AND (RfcScheduleImprovement = ?) AND (RfcVendorRequested = ?)"
            Me.OleDbUpdateCommand7.Connection = Me.OleDbConn
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("AffectedDocuments", System.Data.OleDb.OleDbType.Integer, 0, "AffectedDocuments"))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Authorizations_Engineering", System.Data.OleDb.OleDbType.VarWChar, 50, "Authorizations-Engineering"))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Authorizations_EngineeringDate", System.Data.OleDb.OleDbType.DBDate, 0, "Authorizations-EngineeringDate"))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Authorizations_Manufacturing", System.Data.OleDb.OleDbType.VarWChar, 50, "Authorizations-Manufacturing"))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Authorizations_ManufacturingDate", System.Data.OleDb.OleDbType.DBDate, 0, "Authorizations-ManufacturingDate"))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Authorizations_Purchasing", System.Data.OleDb.OleDbType.VarWChar, 50, "Authorizations-Purchasing"))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Authorizations_PurchasingDate", System.Data.OleDb.OleDbType.DBDate, 0, "Authorizations-PurchasingDate"))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Authorizations_Quality", System.Data.OleDb.OleDbType.VarWChar, 50, "Authorizations-Quality"))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Authorizations_QualityDate", System.Data.OleDb.OleDbType.DBDate, 0, "Authorizations-QualityDate"))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("ClassofChange", System.Data.OleDb.OleDbType.VarWChar, 50, "ClassofChange"))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("DescriptionofChange", System.Data.OleDb.OleDbType.VarWChar, 50, "DescriptionofChange"))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Manager", System.Data.OleDb.OleDbType.VarWChar, 50, "Manager"))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("ManagerDate", System.Data.OleDb.OleDbType.DBDate, 0, "ManagerDate"))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("ManagerDepartment", System.Data.OleDb.OleDbType.VarWChar, 50, "ManagerDepartment"))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Originator", System.Data.OleDb.OleDbType.VarWChar, 50, "Originator"))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("OriginatorDate", System.Data.OleDb.OleDbType.DBDate, 0, "OriginatorDate"))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("OriginatorDepartment", System.Data.OleDb.OleDbType.VarWChar, 50, "OriginatorDepartment"))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Priority", System.Data.OleDb.OleDbType.VarWChar, 50, "Priority"))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("RfcCostImprovement", System.Data.OleDb.OleDbType.Boolean, 2, "RfcCostImprovement"))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("RfcCustomerDirected", System.Data.OleDb.OleDbType.Boolean, 2, "RfcCustomerDirected"))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("RfcDesignError", System.Data.OleDb.OleDbType.Boolean, 2, "RfcDesignError"))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("RfcDraftingError", System.Data.OleDb.OleDbType.Boolean, 2, "RfcDraftingError"))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("RfcFacilitateInspection", System.Data.OleDb.OleDbType.Boolean, 2, "RfcFacilitateInspection"))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("RfcFacilitateProduction", System.Data.OleDb.OleDbType.Boolean, 2, "RfcFacilitateProduction"))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("RfcNewRelease", System.Data.OleDb.OleDbType.Boolean, 2, "RfcNewRelease"))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("RfcOtherExplain", System.Data.OleDb.OleDbType.VarWChar, 0, "RfcOtherExplain"))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("RfcRedrawError", System.Data.OleDb.OleDbType.Boolean, 2, "RfcRedrawError"))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("RfcSafteyInprovement", System.Data.OleDb.OleDbType.Boolean, 2, "RfcSafteyInprovement"))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("RfcScheduleImprovement", System.Data.OleDb.OleDbType.Boolean, 2, "RfcScheduleImprovement"))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("RfcVendorRequested", System.Data.OleDb.OleDbType.Boolean, 2, "RfcVendorRequested"))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringChangeNumber", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringChangeNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AffectedDocuments", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AffectedDocuments", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AffectedDocuments1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AffectedDocuments", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Authorizations_Engineering", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Authorizations-Engineering", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Authorizations_Engineering1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Authorizations-Engineering", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Authorizations_EngineeringDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Authorizations-EngineeringDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Authorizations_EngineeringDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Authorizations-EngineeringDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Authorizations_Manufacturing", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Authorizations-Manufacturing", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Authorizations_Manufacturing1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Authorizations-Manufacturing", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Authorizations_ManufacturingDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Authorizations-ManufacturingDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Authorizations_ManufacturingDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Authorizations-ManufacturingDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Authorizations_Purchasing", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Authorizations-Purchasing", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Authorizations_Purchasing1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Authorizations-Purchasing", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Authorizations_PurchasingDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Authorizations-PurchasingDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Authorizations_PurchasingDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Authorizations-PurchasingDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Authorizations_Quality", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Authorizations-Quality", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Authorizations_Quality1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Authorizations-Quality", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Authorizations_QualityDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Authorizations-QualityDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Authorizations_QualityDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Authorizations-QualityDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ClassofChange", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ClassofChange", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ClassofChange1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ClassofChange", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DescriptionofChange", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescriptionofChange", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DescriptionofChange1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescriptionofChange", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Manager", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Manager", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Manager1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Manager", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ManagerDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ManagerDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ManagerDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ManagerDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ManagerDepartment", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ManagerDepartment", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ManagerDepartment1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ManagerDepartment", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Originator", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Originator", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Originator1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Originator", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OriginatorDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OriginatorDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OriginatorDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OriginatorDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OriginatorDepartment", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OriginatorDepartment", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OriginatorDepartment1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OriginatorDepartment", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Priority", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Priority", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Priority1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Priority", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RfcCostImprovement", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RfcCostImprovement", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RfcCustomerDirected", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RfcCustomerDirected", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RfcDesignError", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RfcDesignError", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RfcDraftingError", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RfcDraftingError", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RfcFacilitateInspection", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RfcFacilitateInspection", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RfcFacilitateProduction", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RfcFacilitateProduction", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RfcNewRelease", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RfcNewRelease", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RfcRedrawError", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RfcRedrawError", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RfcSafteyInprovement", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RfcSafteyInprovement", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RfcScheduleImprovement", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RfcScheduleImprovement", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RfcVendorRequested", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RfcVendorRequested", System.Data.DataRowVersion.Original, Nothing))
            '
            'OleDbDeleteCommand7
            '
            Me.OleDbDeleteCommand7.CommandText = "DELETE FROM E037EngineeringChange WHERE (EngineeringChangeNumber = ?) AND (Affect" & _
            "edDocuments = ? OR ? IS NULL AND AffectedDocuments IS NULL) AND ([Authorizations" & _
            "-Engineering] = ? OR ? IS NULL AND [Authorizations-Engineering] IS NULL) AND ([A" & _
            "uthorizations-EngineeringDate] = ? OR ? IS NULL AND [Authorizations-EngineeringD" & _
            "ate] IS NULL) AND ([Authorizations-Manufacturing] = ? OR ? IS NULL AND [Authoriz" & _
            "ations-Manufacturing] IS NULL) AND ([Authorizations-ManufacturingDate] = ? OR ? " & _
            "IS NULL AND [Authorizations-ManufacturingDate] IS NULL) AND ([Authorizations-Pur" & _
            "chasing] = ? OR ? IS NULL AND [Authorizations-Purchasing] IS NULL) AND ([Authori" & _
            "zations-PurchasingDate] = ? OR ? IS NULL AND [Authorizations-PurchasingDate] IS " & _
            "NULL) AND ([Authorizations-Quality] = ? OR ? IS NULL AND [Authorizations-Quality" & _
            "] IS NULL) AND ([Authorizations-QualityDate] = ? OR ? IS NULL AND [Authorization" & _
            "s-QualityDate] IS NULL) AND (ClassofChange = ? OR ? IS NULL AND ClassofChange IS" & _
            " NULL) AND (DescriptionofChange = ? OR ? IS NULL AND DescriptionofChange IS NULL" & _
            ") AND (Manager = ? OR ? IS NULL AND Manager IS NULL) AND (ManagerDate = ? OR ? I" & _
            "S NULL AND ManagerDate IS NULL) AND (ManagerDepartment = ? OR ? IS NULL AND Mana" & _
            "gerDepartment IS NULL) AND (Originator = ? OR ? IS NULL AND Originator IS NULL) " & _
            "AND (OriginatorDate = ? OR ? IS NULL AND OriginatorDate IS NULL) AND (Originator" & _
            "Department = ? OR ? IS NULL AND OriginatorDepartment IS NULL) AND (Priority = ? " & _
            "OR ? IS NULL AND Priority IS NULL) AND (RfcCostImprovement = ?) AND (RfcCustomer" & _
            "Directed = ?) AND (RfcDesignError = ?) AND (RfcDraftingError = ?) AND (RfcFacili" & _
            "tateInspection = ?) AND (RfcFacilitateProduction = ?) AND (RfcNewRelease = ?) AN" & _
            "D (RfcRedrawError = ?) AND (RfcSafteyInprovement = ?) AND (RfcScheduleImprovemen" & _
            "t = ?) AND (RfcVendorRequested = ?)"
            Me.OleDbDeleteCommand7.Connection = Me.OleDbConn
            Me.OleDbDeleteCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringChangeNumber", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringChangeNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AffectedDocuments", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AffectedDocuments", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AffectedDocuments1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AffectedDocuments", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Authorizations_Engineering", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Authorizations-Engineering", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Authorizations_Engineering1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Authorizations-Engineering", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Authorizations_EngineeringDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Authorizations-EngineeringDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Authorizations_EngineeringDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Authorizations-EngineeringDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Authorizations_Manufacturing", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Authorizations-Manufacturing", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Authorizations_Manufacturing1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Authorizations-Manufacturing", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Authorizations_ManufacturingDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Authorizations-ManufacturingDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Authorizations_ManufacturingDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Authorizations-ManufacturingDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Authorizations_Purchasing", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Authorizations-Purchasing", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Authorizations_Purchasing1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Authorizations-Purchasing", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Authorizations_PurchasingDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Authorizations-PurchasingDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Authorizations_PurchasingDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Authorizations-PurchasingDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Authorizations_Quality", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Authorizations-Quality", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Authorizations_Quality1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Authorizations-Quality", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Authorizations_QualityDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Authorizations-QualityDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Authorizations_QualityDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Authorizations-QualityDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ClassofChange", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ClassofChange", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ClassofChange1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ClassofChange", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DescriptionofChange", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescriptionofChange", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DescriptionofChange1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescriptionofChange", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Manager", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Manager", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Manager1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Manager", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ManagerDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ManagerDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ManagerDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ManagerDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ManagerDepartment", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ManagerDepartment", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ManagerDepartment1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ManagerDepartment", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Originator", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Originator", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Originator1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Originator", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OriginatorDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OriginatorDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OriginatorDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OriginatorDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OriginatorDepartment", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OriginatorDepartment", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OriginatorDepartment1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OriginatorDepartment", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Priority", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Priority", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Priority1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Priority", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RfcCostImprovement", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RfcCostImprovement", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RfcCustomerDirected", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RfcCustomerDirected", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RfcDesignError", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RfcDesignError", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RfcDraftingError", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RfcDraftingError", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RfcFacilitateInspection", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RfcFacilitateInspection", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RfcFacilitateProduction", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RfcFacilitateProduction", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RfcNewRelease", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RfcNewRelease", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RfcRedrawError", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RfcRedrawError", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RfcSafteyInprovement", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RfcSafteyInprovement", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RfcScheduleImprovement", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RfcScheduleImprovement", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RfcVendorRequested", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RfcVendorRequested", System.Data.DataRowVersion.Original, Nothing))
            '
            'daE037EngChng
            '
            Me.daE037EngChng.DeleteCommand = Me.OleDbDeleteCommand7
            Me.daE037EngChng.InsertCommand = Me.OleDbInsertCommand8
            Me.daE037EngChng.SelectCommand = Me.OleDbSelectCommand8
            Me.daE037EngChng.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "E037EngineeringChange", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("AffectedDocuments", "AffectedDocuments"), New System.Data.Common.DataColumnMapping("Authorizations-Engineering", "Authorizations-Engineering"), New System.Data.Common.DataColumnMapping("Authorizations-EngineeringDate", "Authorizations-EngineeringDate"), New System.Data.Common.DataColumnMapping("Authorizations-Manufacturing", "Authorizations-Manufacturing"), New System.Data.Common.DataColumnMapping("Authorizations-ManufacturingDate", "Authorizations-ManufacturingDate"), New System.Data.Common.DataColumnMapping("Authorizations-Purchasing", "Authorizations-Purchasing"), New System.Data.Common.DataColumnMapping("Authorizations-PurchasingDate", "Authorizations-PurchasingDate"), New System.Data.Common.DataColumnMapping("Authorizations-Quality", "Authorizations-Quality"), New System.Data.Common.DataColumnMapping("Authorizations-QualityDate", "Authorizations-QualityDate"), New System.Data.Common.DataColumnMapping("ClassofChange", "ClassofChange"), New System.Data.Common.DataColumnMapping("DescriptionofChange", "DescriptionofChange"), New System.Data.Common.DataColumnMapping("EngineeringChangeNumber", "EngineeringChangeNumber"), New System.Data.Common.DataColumnMapping("Manager", "Manager"), New System.Data.Common.DataColumnMapping("ManagerDate", "ManagerDate"), New System.Data.Common.DataColumnMapping("ManagerDepartment", "ManagerDepartment"), New System.Data.Common.DataColumnMapping("Originator", "Originator"), New System.Data.Common.DataColumnMapping("OriginatorDate", "OriginatorDate"), New System.Data.Common.DataColumnMapping("OriginatorDepartment", "OriginatorDepartment"), New System.Data.Common.DataColumnMapping("Priority", "Priority"), New System.Data.Common.DataColumnMapping("RfcCostImprovement", "RfcCostImprovement"), New System.Data.Common.DataColumnMapping("RfcCustomerDirected", "RfcCustomerDirected"), New System.Data.Common.DataColumnMapping("RfcDesignError", "RfcDesignError"), New System.Data.Common.DataColumnMapping("RfcDraftingError", "RfcDraftingError"), New System.Data.Common.DataColumnMapping("RfcFacilitateInspection", "RfcFacilitateInspection"), New System.Data.Common.DataColumnMapping("RfcFacilitateProduction", "RfcFacilitateProduction"), New System.Data.Common.DataColumnMapping("RfcNewRelease", "RfcNewRelease"), New System.Data.Common.DataColumnMapping("RfcOtherExplain", "RfcOtherExplain"), New System.Data.Common.DataColumnMapping("RfcRedrawError", "RfcRedrawError"), New System.Data.Common.DataColumnMapping("RfcSafteyInprovement", "RfcSafteyInprovement"), New System.Data.Common.DataColumnMapping("RfcScheduleImprovement", "RfcScheduleImprovement"), New System.Data.Common.DataColumnMapping("RfcVendorRequested", "RfcVendorRequested")})})
            Me.daE037EngChng.UpdateCommand = Me.OleDbUpdateCommand7
            '
            'OleDbSelectCommand5
            '
            Me.OleDbSelectCommand5.CommandText = "SELECT BlockID, BlockName, CanonicalMediaName, CurrentStyleSheet, DescAtt1, DescA" & _
            "tt2, DescAtt3, PlotCentered, PlotConfigurationName, PlotRotation, Plotscale, Plo" & _
            "tSettingsName, RevAtt1, Type FROM TrackingBlockNames"
            Me.OleDbSelectCommand5.Connection = Me.OleDbConn
            '
            'OleDbInsertCommand7
            '
            Me.OleDbInsertCommand7.CommandText = "INSERT INTO TrackingBlockNames(BlockName, CanonicalMediaName, CurrentStyleSheet, " & _
            "DescAtt1, DescAtt2, DescAtt3, PlotCentered, PlotConfigurationName, PlotRotation," & _
            " Plotscale, PlotSettingsName, RevAtt1, Type) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, " & _
            "?, ?, ?, ?)"
            Me.OleDbInsertCommand7.Connection = Me.OleDbConn
            Me.OleDbInsertCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("BlockName", System.Data.OleDb.OleDbType.VarWChar, 50, "BlockName"))
            Me.OleDbInsertCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("CanonicalMediaName", System.Data.OleDb.OleDbType.VarWChar, 50, "CanonicalMediaName"))
            Me.OleDbInsertCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("CurrentStyleSheet", System.Data.OleDb.OleDbType.VarWChar, 50, "CurrentStyleSheet"))
            Me.OleDbInsertCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("DescAtt1", System.Data.OleDb.OleDbType.VarWChar, 50, "DescAtt1"))
            Me.OleDbInsertCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("DescAtt2", System.Data.OleDb.OleDbType.VarWChar, 50, "DescAtt2"))
            Me.OleDbInsertCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("DescAtt3", System.Data.OleDb.OleDbType.VarWChar, 50, "DescAtt3"))
            Me.OleDbInsertCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("PlotCentered", System.Data.OleDb.OleDbType.Boolean, 2, "PlotCentered"))
            Me.OleDbInsertCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("PlotConfigurationName", System.Data.OleDb.OleDbType.VarWChar, 50, "PlotConfigurationName"))
            Me.OleDbInsertCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("PlotRotation", System.Data.OleDb.OleDbType.VarWChar, 50, "PlotRotation"))
            Me.OleDbInsertCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Plotscale", System.Data.OleDb.OleDbType.VarWChar, 50, "Plotscale"))
            Me.OleDbInsertCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("PlotSettingsName", System.Data.OleDb.OleDbType.VarWChar, 50, "PlotSettingsName"))
            Me.OleDbInsertCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("RevAtt1", System.Data.OleDb.OleDbType.VarWChar, 50, "RevAtt1"))
            Me.OleDbInsertCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("Type", System.Data.OleDb.OleDbType.VarWChar, 50, "Type"))
            '
            'OleDbUpdateCommand6
            '
            Me.OleDbUpdateCommand6.CommandText = "UPDATE TrackingBlockNames SET BlockName = ?, CanonicalMediaName = ?, CurrentStyle" & _
            "Sheet = ?, DescAtt1 = ?, DescAtt2 = ?, DescAtt3 = ?, PlotCentered = ?, PlotConfi" & _
            "gurationName = ?, PlotRotation = ?, Plotscale = ?, PlotSettingsName = ?, RevAtt1" & _
            " = ?, Type = ? WHERE (BlockID = ?) AND (BlockName = ? OR ? IS NULL AND BlockName" & _
            " IS NULL) AND (CanonicalMediaName = ? OR ? IS NULL AND CanonicalMediaName IS NUL" & _
            "L) AND (CurrentStyleSheet = ? OR ? IS NULL AND CurrentStyleSheet IS NULL) AND (D" & _
            "escAtt1 = ? OR ? IS NULL AND DescAtt1 IS NULL) AND (DescAtt2 = ? OR ? IS NULL AN" & _
            "D DescAtt2 IS NULL) AND (DescAtt3 = ? OR ? IS NULL AND DescAtt3 IS NULL) AND (Pl" & _
            "otCentered = ?) AND (PlotConfigurationName = ? OR ? IS NULL AND PlotConfiguratio" & _
            "nName IS NULL) AND (PlotRotation = ? OR ? IS NULL AND PlotRotation IS NULL) AND " & _
            "(PlotSettingsName = ? OR ? IS NULL AND PlotSettingsName IS NULL) AND (Plotscale " & _
            "= ? OR ? IS NULL AND Plotscale IS NULL) AND (RevAtt1 = ? OR ? IS NULL AND RevAtt" & _
            "1 IS NULL) AND (Type = ? OR ? IS NULL AND Type IS NULL)"
            Me.OleDbUpdateCommand6.Connection = Me.OleDbConn
            Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("BlockName", System.Data.OleDb.OleDbType.VarWChar, 50, "BlockName"))
            Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("CanonicalMediaName", System.Data.OleDb.OleDbType.VarWChar, 50, "CanonicalMediaName"))
            Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("CurrentStyleSheet", System.Data.OleDb.OleDbType.VarWChar, 50, "CurrentStyleSheet"))
            Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("DescAtt1", System.Data.OleDb.OleDbType.VarWChar, 50, "DescAtt1"))
            Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("DescAtt2", System.Data.OleDb.OleDbType.VarWChar, 50, "DescAtt2"))
            Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("DescAtt3", System.Data.OleDb.OleDbType.VarWChar, 50, "DescAtt3"))
            Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("PlotCentered", System.Data.OleDb.OleDbType.Boolean, 2, "PlotCentered"))
            Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("PlotConfigurationName", System.Data.OleDb.OleDbType.VarWChar, 50, "PlotConfigurationName"))
            Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("PlotRotation", System.Data.OleDb.OleDbType.VarWChar, 50, "PlotRotation"))
            Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Plotscale", System.Data.OleDb.OleDbType.VarWChar, 50, "Plotscale"))
            Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("PlotSettingsName", System.Data.OleDb.OleDbType.VarWChar, 50, "PlotSettingsName"))
            Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("RevAtt1", System.Data.OleDb.OleDbType.VarWChar, 50, "RevAtt1"))
            Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Type", System.Data.OleDb.OleDbType.VarWChar, 50, "Type"))
            Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BlockID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BlockID", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BlockName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BlockName", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BlockName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BlockName", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CanonicalMediaName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CanonicalMediaName", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CanonicalMediaName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CanonicalMediaName", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CurrentStyleSheet", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CurrentStyleSheet", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CurrentStyleSheet1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CurrentStyleSheet", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DescAtt1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescAtt1", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DescAtt11", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescAtt1", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DescAtt2", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescAtt2", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DescAtt21", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescAtt2", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DescAtt3", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescAtt3", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DescAtt31", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescAtt3", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PlotCentered", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PlotCentered", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PlotConfigurationName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PlotConfigurationName", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PlotConfigurationName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PlotConfigurationName", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PlotRotation", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PlotRotation", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PlotRotation1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PlotRotation", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PlotSettingsName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PlotSettingsName", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PlotSettingsName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PlotSettingsName", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Plotscale", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Plotscale", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Plotscale1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Plotscale", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RevAtt1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RevAtt1", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RevAtt11", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RevAtt1", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Type", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Type", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Type1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Type", System.Data.DataRowVersion.Original, Nothing))
            '
            'OleDbDeleteCommand6
            '
            Me.OleDbDeleteCommand6.CommandText = "DELETE FROM TrackingBlockNames WHERE (BlockID = ?) AND (BlockName = ? OR ? IS NUL" & _
            "L AND BlockName IS NULL) AND (CanonicalMediaName = ? OR ? IS NULL AND CanonicalM" & _
            "ediaName IS NULL) AND (CurrentStyleSheet = ? OR ? IS NULL AND CurrentStyleSheet " & _
            "IS NULL) AND (DescAtt1 = ? OR ? IS NULL AND DescAtt1 IS NULL) AND (DescAtt2 = ? " & _
            "OR ? IS NULL AND DescAtt2 IS NULL) AND (DescAtt3 = ? OR ? IS NULL AND DescAtt3 I" & _
            "S NULL) AND (PlotCentered = ?) AND (PlotConfigurationName = ? OR ? IS NULL AND P" & _
            "lotConfigurationName IS NULL) AND (PlotRotation = ? OR ? IS NULL AND PlotRotatio" & _
            "n IS NULL) AND (PlotSettingsName = ? OR ? IS NULL AND PlotSettingsName IS NULL) " & _
            "AND (Plotscale = ? OR ? IS NULL AND Plotscale IS NULL) AND (RevAtt1 = ? OR ? IS " & _
            "NULL AND RevAtt1 IS NULL) AND (Type = ? OR ? IS NULL AND Type IS NULL)"
            Me.OleDbDeleteCommand6.Connection = Me.OleDbConn
            Me.OleDbDeleteCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BlockID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BlockID", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BlockName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BlockName", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BlockName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BlockName", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CanonicalMediaName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CanonicalMediaName", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CanonicalMediaName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CanonicalMediaName", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CurrentStyleSheet", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CurrentStyleSheet", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CurrentStyleSheet1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CurrentStyleSheet", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DescAtt1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescAtt1", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DescAtt11", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescAtt1", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DescAtt2", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescAtt2", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DescAtt21", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescAtt2", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DescAtt3", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescAtt3", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DescAtt31", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescAtt3", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PlotCentered", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PlotCentered", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PlotConfigurationName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PlotConfigurationName", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PlotConfigurationName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PlotConfigurationName", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PlotRotation", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PlotRotation", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PlotRotation1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PlotRotation", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PlotSettingsName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PlotSettingsName", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PlotSettingsName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PlotSettingsName", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Plotscale", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Plotscale", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Plotscale1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Plotscale", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RevAtt1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RevAtt1", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RevAtt11", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RevAtt1", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Type", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Type", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Type1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Type", System.Data.DataRowVersion.Original, Nothing))
            '
            'daTrackingBlockNames
            '
            Me.daTrackingBlockNames.DeleteCommand = Me.OleDbDeleteCommand6
            Me.daTrackingBlockNames.InsertCommand = Me.OleDbInsertCommand7
            Me.daTrackingBlockNames.SelectCommand = Me.OleDbSelectCommand5
            Me.daTrackingBlockNames.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "TrackingBlockNames", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("BlockID", "BlockID"), New System.Data.Common.DataColumnMapping("BlockName", "BlockName"), New System.Data.Common.DataColumnMapping("CanonicalMediaName", "CanonicalMediaName"), New System.Data.Common.DataColumnMapping("CurrentStyleSheet", "CurrentStyleSheet"), New System.Data.Common.DataColumnMapping("DescAtt1", "DescAtt1"), New System.Data.Common.DataColumnMapping("DescAtt2", "DescAtt2"), New System.Data.Common.DataColumnMapping("DescAtt3", "DescAtt3"), New System.Data.Common.DataColumnMapping("PlotCentered", "PlotCentered"), New System.Data.Common.DataColumnMapping("PlotConfigurationName", "PlotConfigurationName"), New System.Data.Common.DataColumnMapping("PlotRotation", "PlotRotation"), New System.Data.Common.DataColumnMapping("Plotscale", "Plotscale"), New System.Data.Common.DataColumnMapping("PlotSettingsName", "PlotSettingsName"), New System.Data.Common.DataColumnMapping("RevAtt1", "RevAtt1"), New System.Data.Common.DataColumnMapping("Type", "Type")})})
            Me.daTrackingBlockNames.UpdateCommand = Me.OleDbUpdateCommand6
            '
            'daE001ProdIntroNotice
            '
            Me.daE001ProdIntroNotice.DeleteCommand = Me.OleDbDeleteCommand11
            Me.daE001ProdIntroNotice.InsertCommand = Me.OleDbInsertCommand12
            Me.daE001ProdIntroNotice.SelectCommand = Me.OleDbSelectCommand12
            Me.daE001ProdIntroNotice.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "E001ProductIntroductionNotice", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Engineer", "Engineer"), New System.Data.Common.DataColumnMapping("EngineerDate", "EngineerDate"), New System.Data.Common.DataColumnMapping("EngineeringManager", "EngineeringManager"), New System.Data.Common.DataColumnMapping("EngineeringManagerDate", "EngineeringManagerDate"), New System.Data.Common.DataColumnMapping("ProdIntrNoticeNumID", "ProdIntrNoticeNumID"), New System.Data.Common.DataColumnMapping("Product", "Product"), New System.Data.Common.DataColumnMapping("ProjectClassification", "ProjectClassification"), New System.Data.Common.DataColumnMapping("ProjectDepartment", "ProjectDepartment"), New System.Data.Common.DataColumnMapping("ProjectIs", "ProjectIs"), New System.Data.Common.DataColumnMapping("ProjectNumber", "ProjectNumber"), New System.Data.Common.DataColumnMapping("ProjectTitle", "ProjectTitle"), New System.Data.Common.DataColumnMapping("ProjectType", "ProjectType"), New System.Data.Common.DataColumnMapping("PurposeOfProject", "PurposeOfProject"), New System.Data.Common.DataColumnMapping("SpecifyOtherProjectClassification", "SpecifyOtherProjectClassification")})})
            Me.daE001ProdIntroNotice.UpdateCommand = Me.OleDbUpdateCommand11
            '
            'OleDbDeleteCommand11
            '
            Me.OleDbDeleteCommand11.CommandText = "DELETE FROM E001ProductIntroductionNotice WHERE (ProdIntrNoticeNumID = ?) AND (En" & _
            "gineer = ? OR ? IS NULL AND Engineer IS NULL) AND (EngineerDate = ? OR ? IS NULL" & _
            " AND EngineerDate IS NULL) AND (EngineeringManager = ? OR ? IS NULL AND Engineer" & _
            "ingManager IS NULL) AND (EngineeringManagerDate = ? OR ? IS NULL AND Engineering" & _
            "ManagerDate IS NULL) AND (Product = ? OR ? IS NULL AND Product IS NULL) AND (Pro" & _
            "jectClassification = ? OR ? IS NULL AND ProjectClassification IS NULL) AND (Proj" & _
            "ectDepartment = ? OR ? IS NULL AND ProjectDepartment IS NULL) AND (ProjectIs = ?" & _
            " OR ? IS NULL AND ProjectIs IS NULL) AND (ProjectNumber = ? OR ? IS NULL AND Pro" & _
            "jectNumber IS NULL) AND (ProjectType = ? OR ? IS NULL AND ProjectType IS NULL)"
            Me.OleDbDeleteCommand11.Connection = Me.OleDbConn
            Me.OleDbDeleteCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProdIntrNoticeNumID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProdIntrNoticeNumID", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Engineer", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Engineer1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineerDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineerDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineerDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineerDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringManager", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringManager", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringManager1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringManager", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringManagerDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringManagerDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringManagerDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringManagerDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Product", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Product", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Product1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Product", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProjectClassification", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectClassification", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProjectClassification1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectClassification", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProjectDepartment", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectDepartment", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProjectDepartment1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectDepartment", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProjectIs", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectIs", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProjectIs1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectIs", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProjectNumber", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProjectNumber1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProjectType", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectType", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProjectType1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectType", System.Data.DataRowVersion.Original, Nothing))
            '
            'OleDbInsertCommand12
            '
            Me.OleDbInsertCommand12.CommandText = "INSERT INTO E001ProductIntroductionNotice(Engineer, EngineerDate, EngineeringMana" & _
            "ger, EngineeringManagerDate, Product, ProjectClassification, ProjectDepartment, " & _
            "ProjectIs, ProjectNumber, ProjectTitle, ProjectType, PurposeOfProject, SpecifyOt" & _
            "herProjectClassification) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"
            Me.OleDbInsertCommand12.Connection = Me.OleDbConn
            Me.OleDbInsertCommand12.Parameters.Add(New System.Data.OleDb.OleDbParameter("Engineer", System.Data.OleDb.OleDbType.VarWChar, 50, "Engineer"))
            Me.OleDbInsertCommand12.Parameters.Add(New System.Data.OleDb.OleDbParameter("EngineerDate", System.Data.OleDb.OleDbType.DBDate, 0, "EngineerDate"))
            Me.OleDbInsertCommand12.Parameters.Add(New System.Data.OleDb.OleDbParameter("EngineeringManager", System.Data.OleDb.OleDbType.VarWChar, 50, "EngineeringManager"))
            Me.OleDbInsertCommand12.Parameters.Add(New System.Data.OleDb.OleDbParameter("EngineeringManagerDate", System.Data.OleDb.OleDbType.DBDate, 0, "EngineeringManagerDate"))
            Me.OleDbInsertCommand12.Parameters.Add(New System.Data.OleDb.OleDbParameter("Product", System.Data.OleDb.OleDbType.VarWChar, 50, "Product"))
            Me.OleDbInsertCommand12.Parameters.Add(New System.Data.OleDb.OleDbParameter("ProjectClassification", System.Data.OleDb.OleDbType.VarWChar, 50, "ProjectClassification"))
            Me.OleDbInsertCommand12.Parameters.Add(New System.Data.OleDb.OleDbParameter("ProjectDepartment", System.Data.OleDb.OleDbType.VarWChar, 50, "ProjectDepartment"))
            Me.OleDbInsertCommand12.Parameters.Add(New System.Data.OleDb.OleDbParameter("ProjectIs", System.Data.OleDb.OleDbType.VarWChar, 50, "ProjectIs"))
            Me.OleDbInsertCommand12.Parameters.Add(New System.Data.OleDb.OleDbParameter("ProjectNumber", System.Data.OleDb.OleDbType.VarWChar, 50, "ProjectNumber"))
            Me.OleDbInsertCommand12.Parameters.Add(New System.Data.OleDb.OleDbParameter("ProjectTitle", System.Data.OleDb.OleDbType.VarWChar, 0, "ProjectTitle"))
            Me.OleDbInsertCommand12.Parameters.Add(New System.Data.OleDb.OleDbParameter("ProjectType", System.Data.OleDb.OleDbType.VarWChar, 50, "ProjectType"))
            Me.OleDbInsertCommand12.Parameters.Add(New System.Data.OleDb.OleDbParameter("PurposeOfProject", System.Data.OleDb.OleDbType.VarWChar, 0, "PurposeOfProject"))
            Me.OleDbInsertCommand12.Parameters.Add(New System.Data.OleDb.OleDbParameter("SpecifyOtherProjectClassification", System.Data.OleDb.OleDbType.VarWChar, 0, "SpecifyOtherProjectClassification"))
            '
            'OleDbSelectCommand12
            '
            Me.OleDbSelectCommand12.CommandText = "SELECT Engineer, EngineerDate, EngineeringManager, EngineeringManagerDate, ProdIn" & _
            "trNoticeNumID, Product, ProjectClassification, ProjectDepartment, ProjectIs, Pro" & _
            "jectNumber, ProjectTitle, ProjectType, PurposeOfProject, SpecifyOtherProjectClas" & _
            "sification FROM E001ProductIntroductionNotice"
            Me.OleDbSelectCommand12.Connection = Me.OleDbConn
            '
            'OleDbUpdateCommand11
            '
            Me.OleDbUpdateCommand11.CommandText = "UPDATE E001ProductIntroductionNotice SET Engineer = ?, EngineerDate = ?, Engineer" & _
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
            Me.OleDbUpdateCommand11.Connection = Me.OleDbConn
            Me.OleDbUpdateCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("Engineer", System.Data.OleDb.OleDbType.VarWChar, 50, "Engineer"))
            Me.OleDbUpdateCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("EngineerDate", System.Data.OleDb.OleDbType.DBDate, 0, "EngineerDate"))
            Me.OleDbUpdateCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("EngineeringManager", System.Data.OleDb.OleDbType.VarWChar, 50, "EngineeringManager"))
            Me.OleDbUpdateCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("EngineeringManagerDate", System.Data.OleDb.OleDbType.DBDate, 0, "EngineeringManagerDate"))
            Me.OleDbUpdateCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("Product", System.Data.OleDb.OleDbType.VarWChar, 50, "Product"))
            Me.OleDbUpdateCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("ProjectClassification", System.Data.OleDb.OleDbType.VarWChar, 50, "ProjectClassification"))
            Me.OleDbUpdateCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("ProjectDepartment", System.Data.OleDb.OleDbType.VarWChar, 50, "ProjectDepartment"))
            Me.OleDbUpdateCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("ProjectIs", System.Data.OleDb.OleDbType.VarWChar, 50, "ProjectIs"))
            Me.OleDbUpdateCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("ProjectNumber", System.Data.OleDb.OleDbType.VarWChar, 50, "ProjectNumber"))
            Me.OleDbUpdateCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("ProjectTitle", System.Data.OleDb.OleDbType.VarWChar, 0, "ProjectTitle"))
            Me.OleDbUpdateCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("ProjectType", System.Data.OleDb.OleDbType.VarWChar, 50, "ProjectType"))
            Me.OleDbUpdateCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("PurposeOfProject", System.Data.OleDb.OleDbType.VarWChar, 0, "PurposeOfProject"))
            Me.OleDbUpdateCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("SpecifyOtherProjectClassification", System.Data.OleDb.OleDbType.VarWChar, 0, "SpecifyOtherProjectClassification"))
            Me.OleDbUpdateCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProdIntrNoticeNumID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProdIntrNoticeNumID", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Engineer", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Engineer1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineerDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineerDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineerDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineerDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringManager", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringManager", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringManager1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringManager", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringManagerDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringManagerDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringManagerDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringManagerDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Product", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Product", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Product1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Product", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProjectClassification", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectClassification", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProjectClassification1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectClassification", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProjectDepartment", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectDepartment", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProjectDepartment1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectDepartment", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProjectIs", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectIs", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProjectIs1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectIs", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProjectNumber", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProjectNumber1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProjectType", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectType", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProjectType1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectType", System.Data.DataRowVersion.Original, Nothing))
            '
            'daE045EngChPrtNumInput
            '
            Me.daE045EngChPrtNumInput.DeleteCommand = Me.OleDbDeleteCommand8
            Me.daE045EngChPrtNumInput.InsertCommand = Me.OleDbInsertCommand9
            Me.daE045EngChPrtNumInput.SelectCommand = Me.OleDbSelectCommand9
            Me.daE045EngChPrtNumInput.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "E045EngineeringChangePartNumberInput", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("BillofMaterialSheets", "BillofMaterialSheets"), New System.Data.Common.DataColumnMapping("DocumentNumber", "DocumentNumber"), New System.Data.Common.DataColumnMapping("DocumentSize", "DocumentSize"), New System.Data.Common.DataColumnMapping("DocumentTitle", "DocumentTitle"), New System.Data.Common.DataColumnMapping("EngineeringChangePartNumberInputNumber", "EngineeringChangePartNumberInputNumber"), New System.Data.Common.DataColumnMapping("NumberofSheets", "NumberofSheets")})})
            Me.daE045EngChPrtNumInput.UpdateCommand = Me.OleDbUpdateCommand8
            '
            'OleDbDeleteCommand8
            '
            Me.OleDbDeleteCommand8.CommandText = "DELETE FROM E045EngineeringChangePartNumberInput WHERE (EngineeringChangePartNumb" & _
            "erInputNumber = ?) AND (BillofMaterialSheets = ? OR ? IS NULL AND BillofMaterial" & _
            "Sheets IS NULL) AND (DocumentNumber = ? OR ? IS NULL AND DocumentNumber IS NULL)" & _
            " AND (DocumentSize = ? OR ? IS NULL AND DocumentSize IS NULL) AND (DocumentTitle" & _
            " = ? OR ? IS NULL AND DocumentTitle IS NULL) AND (NumberofSheets = ? OR ? IS NUL" & _
            "L AND NumberofSheets IS NULL)"
            Me.OleDbDeleteCommand8.Connection = Me.OleDbConn
            Me.OleDbDeleteCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringChangePartNumberInputNumber", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringChangePartNumberInputNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BillofMaterialSheets", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BillofMaterialSheets", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BillofMaterialSheets1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BillofMaterialSheets", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DocumentNumber", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DocumentNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DocumentNumber1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DocumentNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DocumentSize", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DocumentSize", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DocumentSize1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DocumentSize", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DocumentTitle", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DocumentTitle", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DocumentTitle1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DocumentTitle", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NumberofSheets", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumberofSheets", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NumberofSheets1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumberofSheets", System.Data.DataRowVersion.Original, Nothing))
            '
            'OleDbInsertCommand9
            '
            Me.OleDbInsertCommand9.CommandText = "INSERT INTO E045EngineeringChangePartNumberInput(BillofMaterialSheets, DocumentNu" & _
            "mber, DocumentSize, DocumentTitle, NumberofSheets) VALUES (?, ?, ?, ?, ?)"
            Me.OleDbInsertCommand9.Connection = Me.OleDbConn
            Me.OleDbInsertCommand9.Parameters.Add(New System.Data.OleDb.OleDbParameter("BillofMaterialSheets", System.Data.OleDb.OleDbType.VarWChar, 50, "BillofMaterialSheets"))
            Me.OleDbInsertCommand9.Parameters.Add(New System.Data.OleDb.OleDbParameter("DocumentNumber", System.Data.OleDb.OleDbType.VarWChar, 100, "DocumentNumber"))
            Me.OleDbInsertCommand9.Parameters.Add(New System.Data.OleDb.OleDbParameter("DocumentSize", System.Data.OleDb.OleDbType.VarWChar, 50, "DocumentSize"))
            Me.OleDbInsertCommand9.Parameters.Add(New System.Data.OleDb.OleDbParameter("DocumentTitle", System.Data.OleDb.OleDbType.VarWChar, 50, "DocumentTitle"))
            Me.OleDbInsertCommand9.Parameters.Add(New System.Data.OleDb.OleDbParameter("NumberofSheets", System.Data.OleDb.OleDbType.VarWChar, 50, "NumberofSheets"))
            '
            'OleDbSelectCommand9
            '
            Me.OleDbSelectCommand9.CommandText = "SELECT BillofMaterialSheets, DocumentNumber, DocumentSize, DocumentTitle, Enginee" & _
            "ringChangePartNumberInputNumber, NumberofSheets FROM E045EngineeringChangePartNu" & _
            "mberInput ORDER BY EngineeringChangePartNumberInputNumber DESC"
            Me.OleDbSelectCommand9.Connection = Me.OleDbConn
            '
            'OleDbUpdateCommand8
            '
            Me.OleDbUpdateCommand8.CommandText = "UPDATE E045EngineeringChangePartNumberInput SET BillofMaterialSheets = ?, Documen" & _
            "tNumber = ?, DocumentSize = ?, DocumentTitle = ?, NumberofSheets = ? WHERE (Engi" & _
            "neeringChangePartNumberInputNumber = ?) AND (BillofMaterialSheets = ? OR ? IS NU" & _
            "LL AND BillofMaterialSheets IS NULL) AND (DocumentNumber = ? OR ? IS NULL AND Do" & _
            "cumentNumber IS NULL) AND (DocumentSize = ? OR ? IS NULL AND DocumentSize IS NUL" & _
            "L) AND (DocumentTitle = ? OR ? IS NULL AND DocumentTitle IS NULL) AND (NumberofS" & _
            "heets = ? OR ? IS NULL AND NumberofSheets IS NULL)"
            Me.OleDbUpdateCommand8.Connection = Me.OleDbConn
            Me.OleDbUpdateCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("BillofMaterialSheets", System.Data.OleDb.OleDbType.VarWChar, 50, "BillofMaterialSheets"))
            Me.OleDbUpdateCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("DocumentNumber", System.Data.OleDb.OleDbType.VarWChar, 100, "DocumentNumber"))
            Me.OleDbUpdateCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("DocumentSize", System.Data.OleDb.OleDbType.VarWChar, 50, "DocumentSize"))
            Me.OleDbUpdateCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("DocumentTitle", System.Data.OleDb.OleDbType.VarWChar, 50, "DocumentTitle"))
            Me.OleDbUpdateCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("NumberofSheets", System.Data.OleDb.OleDbType.VarWChar, 50, "NumberofSheets"))
            Me.OleDbUpdateCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringChangePartNumberInputNumber", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringChangePartNumberInputNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BillofMaterialSheets", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BillofMaterialSheets", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BillofMaterialSheets1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BillofMaterialSheets", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DocumentNumber", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DocumentNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DocumentNumber1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DocumentNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DocumentSize", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DocumentSize", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DocumentSize1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DocumentSize", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DocumentTitle", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DocumentTitle", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DocumentTitle1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DocumentTitle", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NumberofSheets", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumberofSheets", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NumberofSheets1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumberofSheets", System.Data.DataRowVersion.Original, Nothing))
            '
            'daE045SubTable
            '
            Me.daE045SubTable.DeleteCommand = Me.OleDbDeleteCommand9
            Me.daE045SubTable.InsertCommand = Me.OleDbInsertCommand11
            Me.daE045SubTable.SelectCommand = Me.OleDbSelectCommand11
            Me.daE045SubTable.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "E045SubTable", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CCBStatus", "CCBStatus"), New System.Data.Common.DataColumnMapping("DocRevision", "DocRevision"), New System.Data.Common.DataColumnMapping("EngineeringChangeNumber", "EngineeringChangeNumber"), New System.Data.Common.DataColumnMapping("EngineeringChangePartNumberInputNumber", "EngineeringChangePartNumberInputNumber"), New System.Data.Common.DataColumnMapping("EngineeringChangeReleaseDate", "EngineeringChangeReleaseDate"), New System.Data.Common.DataColumnMapping("IncorporationDate", "IncorporationDate"), New System.Data.Common.DataColumnMapping("NoteComments", "NoteComments"), New System.Data.Common.DataColumnMapping("PendingDate", "PendingDate")})})
            Me.daE045SubTable.UpdateCommand = Me.OleDbUpdateCommand9
            '
            'OleDbDeleteCommand9
            '
            Me.OleDbDeleteCommand9.CommandText = "DELETE FROM E045SubTable WHERE (EngineeringChangePartNumberInputNumber = ?) AND (" & _
            "CCBStatus = ? OR ? IS NULL AND CCBStatus IS NULL) AND (DocRevision = ? OR ? IS N" & _
            "ULL AND DocRevision IS NULL) AND (EngineeringChangeNumber = ? OR ? IS NULL AND E" & _
            "ngineeringChangeNumber IS NULL) AND (EngineeringChangeReleaseDate = ? OR ? IS NU" & _
            "LL AND EngineeringChangeReleaseDate IS NULL) AND (IncorporationDate = ? OR ? IS " & _
            "NULL AND IncorporationDate IS NULL) AND (PendingDate = ? OR ? IS NULL AND Pendin" & _
            "gDate IS NULL)"
            Me.OleDbDeleteCommand9.Connection = Me.OleDbConn
            Me.OleDbDeleteCommand9.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringChangePartNumberInputNumber", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringChangePartNumberInputNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand9.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CCBStatus", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CCBStatus", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand9.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CCBStatus1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CCBStatus", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand9.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DocRevision", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DocRevision", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand9.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DocRevision1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DocRevision", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand9.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringChangeNumber", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringChangeNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand9.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringChangeNumber1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringChangeNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand9.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringChangeReleaseDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringChangeReleaseDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand9.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringChangeReleaseDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringChangeReleaseDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand9.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IncorporationDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IncorporationDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand9.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IncorporationDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IncorporationDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand9.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PendingDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PendingDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand9.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PendingDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PendingDate", System.Data.DataRowVersion.Original, Nothing))
            '
            'OleDbInsertCommand11
            '
            Me.OleDbInsertCommand11.CommandText = "INSERT INTO E045SubTable(CCBStatus, DocRevision, EngineeringChangeNumber, Enginee" & _
            "ringChangePartNumberInputNumber, EngineeringChangeReleaseDate, IncorporationDate" & _
            ", NoteComments, PendingDate) VALUES (?, ?, ?, ?, ?, ?, ?, ?)"
            Me.OleDbInsertCommand11.Connection = Me.OleDbConn
            Me.OleDbInsertCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("CCBStatus", System.Data.OleDb.OleDbType.VarWChar, 50, "CCBStatus"))
            Me.OleDbInsertCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("DocRevision", System.Data.OleDb.OleDbType.VarWChar, 50, "DocRevision"))
            Me.OleDbInsertCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("EngineeringChangeNumber", System.Data.OleDb.OleDbType.VarWChar, 50, "EngineeringChangeNumber"))
            Me.OleDbInsertCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("EngineeringChangePartNumberInputNumber", System.Data.OleDb.OleDbType.Integer, 0, "EngineeringChangePartNumberInputNumber"))
            Me.OleDbInsertCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("EngineeringChangeReleaseDate", System.Data.OleDb.OleDbType.DBDate, 0, "EngineeringChangeReleaseDate"))
            Me.OleDbInsertCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("IncorporationDate", System.Data.OleDb.OleDbType.DBDate, 0, "IncorporationDate"))
            Me.OleDbInsertCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("NoteComments", System.Data.OleDb.OleDbType.VarWChar, 0, "NoteComments"))
            Me.OleDbInsertCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("PendingDate", System.Data.OleDb.OleDbType.DBDate, 0, "PendingDate"))
            '
            'OleDbSelectCommand11
            '
            Me.OleDbSelectCommand11.CommandText = "SELECT CCBStatus, DocRevision, EngineeringChangeNumber, EngineeringChangePartNumb" & _
            "erInputNumber, EngineeringChangeReleaseDate, IncorporationDate, NoteComments, Pe" & _
            "ndingDate FROM E045SubTable"
            Me.OleDbSelectCommand11.Connection = Me.OleDbConn
            '
            'OleDbUpdateCommand9
            '
            Me.OleDbUpdateCommand9.CommandText = "UPDATE E045SubTable SET CCBStatus = ?, DocRevision = ?, EngineeringChangeNumber =" & _
            " ?, EngineeringChangePartNumberInputNumber = ?, EngineeringChangeReleaseDate = ?" & _
            ", IncorporationDate = ?, NoteComments = ?, PendingDate = ? WHERE (EngineeringCha" & _
            "ngePartNumberInputNumber = ?) AND (CCBStatus = ? OR ? IS NULL AND CCBStatus IS N" & _
            "ULL) AND (DocRevision = ? OR ? IS NULL AND DocRevision IS NULL) AND (Engineering" & _
            "ChangeNumber = ? OR ? IS NULL AND EngineeringChangeNumber IS NULL) AND (Engineer" & _
            "ingChangeReleaseDate = ? OR ? IS NULL AND EngineeringChangeReleaseDate IS NULL) " & _
            "AND (IncorporationDate = ? OR ? IS NULL AND IncorporationDate IS NULL) AND (Pend" & _
            "ingDate = ? OR ? IS NULL AND PendingDate IS NULL)"
            Me.OleDbUpdateCommand9.Connection = Me.OleDbConn
            Me.OleDbUpdateCommand9.Parameters.Add(New System.Data.OleDb.OleDbParameter("CCBStatus", System.Data.OleDb.OleDbType.VarWChar, 50, "CCBStatus"))
            Me.OleDbUpdateCommand9.Parameters.Add(New System.Data.OleDb.OleDbParameter("DocRevision", System.Data.OleDb.OleDbType.VarWChar, 50, "DocRevision"))
            Me.OleDbUpdateCommand9.Parameters.Add(New System.Data.OleDb.OleDbParameter("EngineeringChangeNumber", System.Data.OleDb.OleDbType.VarWChar, 50, "EngineeringChangeNumber"))
            Me.OleDbUpdateCommand9.Parameters.Add(New System.Data.OleDb.OleDbParameter("EngineeringChangePartNumberInputNumber", System.Data.OleDb.OleDbType.Integer, 0, "EngineeringChangePartNumberInputNumber"))
            Me.OleDbUpdateCommand9.Parameters.Add(New System.Data.OleDb.OleDbParameter("EngineeringChangeReleaseDate", System.Data.OleDb.OleDbType.DBDate, 0, "EngineeringChangeReleaseDate"))
            Me.OleDbUpdateCommand9.Parameters.Add(New System.Data.OleDb.OleDbParameter("IncorporationDate", System.Data.OleDb.OleDbType.DBDate, 0, "IncorporationDate"))
            Me.OleDbUpdateCommand9.Parameters.Add(New System.Data.OleDb.OleDbParameter("NoteComments", System.Data.OleDb.OleDbType.VarWChar, 0, "NoteComments"))
            Me.OleDbUpdateCommand9.Parameters.Add(New System.Data.OleDb.OleDbParameter("PendingDate", System.Data.OleDb.OleDbType.DBDate, 0, "PendingDate"))
            Me.OleDbUpdateCommand9.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringChangePartNumberInputNumber", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringChangePartNumberInputNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand9.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CCBStatus", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CCBStatus", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand9.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CCBStatus1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CCBStatus", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand9.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DocRevision", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DocRevision", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand9.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DocRevision1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DocRevision", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand9.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringChangeNumber", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringChangeNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand9.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringChangeNumber1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringChangeNumber", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand9.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringChangeReleaseDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringChangeReleaseDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand9.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EngineeringChangeReleaseDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringChangeReleaseDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand9.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IncorporationDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IncorporationDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand9.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IncorporationDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IncorporationDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand9.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PendingDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PendingDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand9.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PendingDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PendingDate", System.Data.DataRowVersion.Original, Nothing))
            CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

#End Region


    End Class

End Namespace