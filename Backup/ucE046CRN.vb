Option Explicit On 

Imports System.Windows.Forms
Imports System.Drawing

Imports Autodesk.AutoCAD.EditorInput
Imports Autodesk.AutoCAD.ApplicationServices
Imports Autodesk.AutoCAD.DatabaseServices

Imports rnsCadDataProj.nsForms.frmMain
Imports rnsCadDataProj.nsMods

Namespace nsUserCtls

    Public Class ucE046CRN

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

        Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
        Friend WithEvents cmnuE046CReq As System.Windows.Forms.ContextMenu
        Friend WithEvents miNewE046CReq As System.Windows.Forms.MenuItem
        Friend WithEvents miE046CRUpdateDS As System.Windows.Forms.MenuItem
        Friend WithEvents miEngProcHelpE046 As System.Windows.Forms.MenuItem
        Friend WithEvents miEP0607CRhlp As System.Windows.Forms.MenuItem
        Friend WithEvents cmnuE046CRsubTbl As System.Windows.Forms.ContextMenu
        Friend WithEvents miMkE046Tbl As System.Windows.Forms.MenuItem
        Friend WithEvents miUpdateE046CRsubTbl As System.Windows.Forms.MenuItem
        Friend WithEvents dgE046CopyRequest As System.Windows.Forms.DataGrid
        Friend WithEvents dgE046CopyRequestDv As System.Windows.Forms.DataGrid

        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.dgE046CopyRequest = New System.Windows.Forms.DataGrid
            Me.cmnuE046CReq = New System.Windows.Forms.ContextMenu
            Me.miNewE046CReq = New System.Windows.Forms.MenuItem
            Me.miE046CRUpdateDS = New System.Windows.Forms.MenuItem
            Me.miEngProcHelpE046 = New System.Windows.Forms.MenuItem
            Me.miEP0607CRhlp = New System.Windows.Forms.MenuItem
            Me.Splitter1 = New System.Windows.Forms.Splitter
            Me.dgE046CopyRequestDv = New System.Windows.Forms.DataGrid
            Me.cmnuE046CRsubTbl = New System.Windows.Forms.ContextMenu
            Me.miMkE046Tbl = New System.Windows.Forms.MenuItem
            Me.miUpdateE046CRsubTbl = New System.Windows.Forms.MenuItem
            CType(Me.dgE046CopyRequest, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgE046CopyRequestDv, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'dgE046CopyRequest
            '
            Me.dgE046CopyRequest.ContextMenu = Me.cmnuE046CReq
            Me.dgE046CopyRequest.DataMember = ""
            Me.dgE046CopyRequest.Dock = System.Windows.Forms.DockStyle.Top
            Me.dgE046CopyRequest.HeaderForeColor = System.Drawing.SystemColors.ControlText
            Me.dgE046CopyRequest.Location = New System.Drawing.Point(0, 0)
            Me.dgE046CopyRequest.Name = "dgE046CopyRequest"
            Me.dgE046CopyRequest.Size = New System.Drawing.Size(488, 176)
            Me.dgE046CopyRequest.TabIndex = 0
            '
            'cmnuE046CReq
            '
            Me.cmnuE046CReq.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miNewE046CReq, Me.miE046CRUpdateDS, Me.miEngProcHelpE046})
            '
            'miNewE046CReq
            '
            Me.miNewE046CReq.Index = 0
            Me.miNewE046CReq.Text = "New E046 CReq"
            '
            'miE046CRUpdateDS
            '
            Me.miE046CRUpdateDS.Index = 1
            Me.miE046CRUpdateDS.Text = "Update E046CR Datasource"
            '
            'miEngProcHelpE046
            '
            Me.miEngProcHelpE046.Index = 2
            Me.miEngProcHelpE046.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miEP0607CRhlp})
            Me.miEngProcHelpE046.Text = "Eng Proc Help"
            '
            'miEP0607CRhlp
            '
            Me.miEP0607CRhlp.Index = 0
            Me.miEP0607CRhlp.Text = "EP-06-7 Copy Request"
            '
            'Splitter1
            '
            Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Splitter1.Location = New System.Drawing.Point(0, 176)
            Me.Splitter1.Name = "Splitter1"
            Me.Splitter1.Size = New System.Drawing.Size(488, 3)
            Me.Splitter1.TabIndex = 1
            Me.Splitter1.TabStop = False
            '
            'dgE046CopyRequestDv
            '
            Me.dgE046CopyRequestDv.ContextMenu = Me.cmnuE046CRsubTbl
            Me.dgE046CopyRequestDv.DataMember = ""
            Me.dgE046CopyRequestDv.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgE046CopyRequestDv.HeaderForeColor = System.Drawing.SystemColors.ControlText
            Me.dgE046CopyRequestDv.Location = New System.Drawing.Point(0, 179)
            Me.dgE046CopyRequestDv.Name = "dgE046CopyRequestDv"
            Me.dgE046CopyRequestDv.Size = New System.Drawing.Size(488, 173)
            Me.dgE046CopyRequestDv.TabIndex = 2
            '
            'cmnuE046CRsubTbl
            '
            Me.cmnuE046CRsubTbl.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miMkE046Tbl, Me.miUpdateE046CRsubTbl})
            '
            'miMkE046Tbl
            '
            Me.miMkE046Tbl.Index = 0
            Me.miMkE046Tbl.Text = "Make E046CR Tbl"
            '
            'miUpdateE046CRsubTbl
            '
            Me.miUpdateE046CRsubTbl.Index = 1
            Me.miUpdateE046CRsubTbl.Text = "Update E046CR Datasource"
            '
            'ucE046CRN
            '
            Me.Controls.Add(Me.dgE046CopyRequestDv)
            Me.Controls.Add(Me.Splitter1)
            Me.Controls.Add(Me.dgE046CopyRequest)
            Me.Name = "ucE046CRN"
            Me.Size = New System.Drawing.Size(488, 352)
            CType(Me.dgE046CopyRequest, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgE046CopyRequestDv, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private Sub ucE046CRN_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            If SqlDaComp.DataSet11.E046CopyRequest.Count = 0 Or SqlDaComp.DataSet11.E046SubTable.Count = 0 Then
             
                SqlDaComp.SqlConn.ConnectionString = words
                SqlDaComp.DaE046CopyReq.Fill(SqlDaComp.DataSet11.E046CopyRequest)
                dgE046CopyRequest.DataSource = SqlDaComp.DataSet11.E046CopyRequest
                SqlDaComp.DaE046SubTable.Fill(SqlDaComp.DataSet11.E046SubTable)
                dgE046CopyRequestDv.DataSource = Nothing
            End If
        End Sub

        Dim dvE046CR As DataView
        Dim E046CRtblsAdded As Boolean
        Dim E046CRts As New DataGridTableStyle

        Private Sub dgE046CopyRequest_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgE046CopyRequest.DoubleClick
            If E046CRtblsAdded = False Then
                E046CRts.MappingName = "E046SubTable"
                Dim TextCol1 As New DataGridTextBoxColumn
                TextCol1.MappingName = "DocumentNumber"
                TextCol1.HeaderText = "DocumentNumber"
                TextCol1.Width = 50
                E046CRts.GridColumnStyles.Add(TextCol1)
                Dim TextCol2 As New DataGridTextBoxColumn
                TextCol2.MappingName = "Revision"
                TextCol2.HeaderText = "Revision"
                TextCol2.Width = 250
                E046CRts.GridColumnStyles.Add(TextCol2)
                Dim TextCol3 As New DataGridTextBoxColumn
                TextCol3.MappingName = "Description"
                TextCol3.HeaderText = "Description"
                TextCol3.Width = 50
                E046CRts.GridColumnStyles.Add(TextCol3)
                Dim TextCol4 As New DataGridTextBoxColumn
                TextCol4.MappingName = "NumberofCopies"
                TextCol4.HeaderText = "Qty"
                TextCol4.Width = 50
                E046CRts.GridColumnStyles.Add(TextCol4)
                E046CRts.AlternatingBackColor = Color.LightBlue
                E046CRtblsAdded = True
            End If
            If dgE046CopyRequestDv.TableStyles.Contains("E046SubTable") = False Then dgE046CopyRequestDv.TableStyles.Add(E046CRts)

            dvE046CR = New DataView
            With dvE046CR
                .Table = SqlDaComp.DataSet11.Tables("E046SubTable")
                '.AllowDelete = True   '.AllowEdit = True   '.AllowNew = True
                Try
                    .RowFilter = "CopyRequestNumber = '" & dgE046CopyRequest.Item(dgE046CopyRequest.CurrentRowIndex, 0) & "'"
                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                End Try
                '.RowStateFilter = DataViewRowState.ModifiedCurrent
                '.Sort = "CompanyName DESC"
            End With
            dgE046CopyRequestDv.DataSource = dvE046CR
            crnID = dgE046CopyRequest.Item(dgE046CopyRequest.CurrentRowIndex, 0)
            Dim frm As Form = Me.FindForm()
            frm.Text = "E046 Copy Request # : " & crnID
            drnID = Nothing
            bomID = Nothing
            ecoID = Nothing
        End Sub

        Private Sub miEP0607CRhlp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miEP0607CRhlp.Click
            Dim HelpFileName As String = pathStrToHandBook & "07 Document Control.dwg"
            HlpDwg(HelpFileName, "EP-07-06 Copy Request (1)", rOnly)
        End Sub

        Private Sub miMkE046Tbl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miMkE046Tbl.Click
            Dim tbl As New Table
            tbl.IsHeaderSuppressed = False
            tbl.IsTitleSuppressed = False
            tbl.InsertRows(1, 0.25, dvE046CR.Count + 1)
            tbl.InsertColumns(1, 2, dgE046CopyRequestDv.VisibleColumnCount - 1)
            tbl.SetTextString(0, 0, "E046CRN #" & dgE046CopyRequest.Item(dgE046CopyRequest.CurrentRowIndex, 0) & " " & FolderName)

            Dim c As Short : Dim Cc As Short : Dim MyRow As DataRowView
            For c = 1 To 1
                MyRow = dvE046CR.Item(c)
                For Cc = 0 To dgE046CopyRequestDv.VisibleColumnCount - 1
                    tbl.SetTextString(c, Cc, E046CRts.GridColumnStyles(Cc).HeaderText)
                Next
            Next

            For c = 0 To (dvE046CR.Count - 1)
                MyRow = dvE046CR.Item(c)
                For Cc = 0 To dgE046CopyRequestDv.VisibleColumnCount - 1
                    If Not IsDBNull(dgE046CopyRequestDv.Item(c, Cc)) Then
                        tbl.SetTextString(c + 2, Cc, dgE046CopyRequestDv.Item(c, Cc))
                    Else
                        tbl.SetTextString(c + 2, Cc, "Null")
                    End If
                Next
            Next

            Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
            Dim frm As Form = Me.FindForm()
            frm.Hide()
            'Me.Hide()
            Dim tblPnt As PromptPointOptions = New PromptPointOptions("Select Insertion Point...")
            Dim tblPntRes As PromptPointResult = ed.GetPoint(tblPnt)
            If tblPntRes.Status <> PromptStatus.OK Then
                frm.Show()
                'Me.Show()
                Return
            End If
            tbl.Position = tblPntRes.Value
            Dim bt As BlockTable
            Dim btr As BlockTableRecord
            Dim db As Database = HostApplicationServices.WorkingDatabase
            Dim trans As Transaction = db.TransactionManager.StartTransaction()
            Dim DocCol As DocumentCollection = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager
            Dim docLock As DocumentLock = DocCol.MdiActiveDocument.LockDocument()
            Try : bt = trans.GetObject(db.BlockTableId, OpenMode.ForRead)
                Dim cSpace As String = modUtility.CurSpace
                Select Case cSpace
                    Case "*Model_Space"
                        btr = trans.GetObject(bt(Autodesk.AutoCAD.DatabaseServices.BlockTableRecord.ModelSpace), OpenMode.ForWrite)
                    Case "*MODEL_SPACE"
                        btr = trans.GetObject(bt(Autodesk.AutoCAD.DatabaseServices.BlockTableRecord.ModelSpace), OpenMode.ForWrite)
                    Case "*Paper_Space"
                        btr = trans.GetObject(bt(Autodesk.AutoCAD.DatabaseServices.BlockTableRecord.PaperSpace), OpenMode.ForWrite)
                    Case "*PAPER_SPACE"
                        btr = trans.GetObject(bt(Autodesk.AutoCAD.DatabaseServices.BlockTableRecord.PaperSpace), OpenMode.ForWrite)
                    Case Else
                        btr = Nothing
                End Select
                Try : btr.AppendEntity(tbl)
                    trans.AddNewlyCreatedDBObject(tbl, True)
                Finally
                    tbl.Dispose()
                End Try
                trans.Commit()
            Finally
                docLock.Dispose() : trans.Dispose()
            End Try
        End Sub

        Private Sub miUpdateE046CRsubTbl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miUpdateE046CRsubTbl.Click
            Try : SqlDaComp.DaE046SubTable.Update(SqlDaComp.DataSet11.E046SubTable)
                'Catch dbcx As DBConcurrencyException
                'createMessage(dbcx, "E046SubTable")
            Catch ex As Exception
                MessageBox.Show("Update Failed", ex.ToString())
            End Try
        End Sub

        Private Sub miNewE046CReq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miNewE046CReq.Click
            'NewE044DRN.ShowDialog()
            SqlDaComp.DataSet11.E046CopyRequest.Clear()
            SqlDaComp.DaE046CopyReq.Fill(SqlDaComp.DataSet11)
            Dim MyNewRow As DataRow ': Dim classResponse As MsgBoxResult
            MyNewRow = SqlDaComp.DataSet11.E046CopyRequest.NewRow
            'MyNewRow("AffectedDocuments") = dgE044DRN.Item(dgE044DRN.CurrentRowIndex, 1) 'e044DrN num
            'MyNewRow("Originator") = UCase(SystemInformation.UserName)
            MyNewRow("CRDate") = UCase(Format(Now, "MMM/dd/yy").ToString)
            MyNewRow("DepartmentNumber") = "?"
            'MyNewRow("ClassofChange") = chdlg.ChngType
            SqlDaComp.DataSet11.E046CopyRequest.Rows.Add(MyNewRow)
            Try : SqlDaComp.DaE046CopyReq.Update(SqlDaComp.DataSet11.E046CopyRequest)
            Catch dbcx As DBConcurrencyException
                'createMessage(dbcx, "E046CReq")
            Catch ex As Exception
                MessageBox.Show("Update Failed", ex.GetType().ToString())
            End Try
            ' ecoID = MyNewRow.Item(11).ToString
            SqlDaComp.DataSet11.E046CopyRequest.Clear()
            SqlDaComp.DaE046CopyReq.Fill(SqlDaComp.DataSet11)
        End Sub

        Private Sub miE046CRUpdateDS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miE046CRUpdateDS.Click
            Try : SqlDaComp.DaE046CopyReq.Update(SqlDaComp.DataSet11.E046CopyRequest)
            Catch dbcx As DBConcurrencyException
                'createMessage(dbcx, "E046CopyRequest")
            Catch ex As Exception
                MessageBox.Show("Update Failed", ex.GetType().ToString())
            End Try
        End Sub
    End Class

End Namespace

