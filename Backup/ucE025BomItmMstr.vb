Option Explicit On 

Imports System.Windows.Forms
Imports System.Drawing

Imports Autodesk.AutoCAD.EditorInput
Imports Autodesk.AutoCAD.ApplicationServices
Imports Autodesk.AutoCAD.DatabaseServices

Imports rnsCadDataProj.nsForms.frmMain
Imports rnsCadDataProj.nsMods

Namespace nsUserCtls

    Public Class ucE025BomItmMstr

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
        Friend WithEvents cmnuBomMain As System.Windows.Forms.ContextMenu
        Friend WithEvents miNewE025Bom As System.Windows.Forms.MenuItem
        Friend WithEvents miUpDateDS As System.Windows.Forms.MenuItem
        Friend WithEvents miEngProcHelpE025 As System.Windows.Forms.MenuItem
        Friend WithEvents miEP0109ProdStuctHlp As System.Windows.Forms.MenuItem
        Friend WithEvents miEP0209Bomhlp As System.Windows.Forms.MenuItem
        Friend WithEvents cmnuE024ItmMstr As System.Windows.Forms.ContextMenu
        Friend WithEvents miAddItmToBom As System.Windows.Forms.MenuItem
        Friend WithEvents miUpdE024ItmMstrDaSrc As System.Windows.Forms.MenuItem
        Friend WithEvents miEngProcHelpE024ItmMstr As System.Windows.Forms.MenuItem
        Friend WithEvents miEP0208ItmMstrInHlp As System.Windows.Forms.MenuItem
        Friend WithEvents cmnuBomTbl As System.Windows.Forms.ContextMenu
        Friend WithEvents miMakeBomTbl As System.Windows.Forms.MenuItem
        Friend WithEvents miUpdateBomSub As System.Windows.Forms.MenuItem
        Friend WithEvents miMakeOrigTbl As System.Windows.Forms.MenuItem
        Friend WithEvents dgE025BOM As System.Windows.Forms.DataGrid
        Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
        Friend WithEvents dgE025BOMdv As System.Windows.Forms.DataGrid
        Friend WithEvents Splitter2 As System.Windows.Forms.Splitter
        Friend WithEvents dgE024ItmMstr As System.Windows.Forms.DataGrid
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.cmnuBomMain = New System.Windows.Forms.ContextMenu
            Me.miNewE025Bom = New System.Windows.Forms.MenuItem
            Me.miUpDateDS = New System.Windows.Forms.MenuItem
            Me.miEngProcHelpE025 = New System.Windows.Forms.MenuItem
            Me.miEP0109ProdStuctHlp = New System.Windows.Forms.MenuItem
            Me.miEP0209Bomhlp = New System.Windows.Forms.MenuItem
            Me.cmnuE024ItmMstr = New System.Windows.Forms.ContextMenu
            Me.miAddItmToBom = New System.Windows.Forms.MenuItem
            Me.miUpdE024ItmMstrDaSrc = New System.Windows.Forms.MenuItem
            Me.miEngProcHelpE024ItmMstr = New System.Windows.Forms.MenuItem
            Me.miEP0208ItmMstrInHlp = New System.Windows.Forms.MenuItem
            Me.cmnuBomTbl = New System.Windows.Forms.ContextMenu
            Me.miMakeBomTbl = New System.Windows.Forms.MenuItem
            Me.miUpdateBomSub = New System.Windows.Forms.MenuItem
            Me.miMakeOrigTbl = New System.Windows.Forms.MenuItem
            Me.dgE025BOM = New System.Windows.Forms.DataGrid
            Me.Splitter1 = New System.Windows.Forms.Splitter
            Me.dgE025BOMdv = New System.Windows.Forms.DataGrid
            Me.Splitter2 = New System.Windows.Forms.Splitter
            Me.dgE024ItmMstr = New System.Windows.Forms.DataGrid
            CType(Me.dgE025BOM, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgE025BOMdv, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgE024ItmMstr, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'cmnuBomMain
            '
            Me.cmnuBomMain.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miNewE025Bom, Me.miUpDateDS, Me.miEngProcHelpE025})
            '
            'miNewE025Bom
            '
            Me.miNewE025Bom.Index = 0
            Me.miNewE025Bom.Text = "New E025 BOM"
            '
            'miUpDateDS
            '
            Me.miUpDateDS.Index = 1
            Me.miUpDateDS.Text = "Update Datasource"
            '
            'miEngProcHelpE025
            '
            Me.miEngProcHelpE025.Index = 2
            Me.miEngProcHelpE025.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miEP0109ProdStuctHlp, Me.miEP0209Bomhlp})
            Me.miEngProcHelpE025.Text = "Eng Proc Help"
            '
            'miEP0109ProdStuctHlp
            '
            Me.miEP0109ProdStuctHlp.Index = 0
            Me.miEP0109ProdStuctHlp.Text = "EP-01-09 Product Stucturing"
            '
            'miEP0209Bomhlp
            '
            Me.miEP0209Bomhlp.Index = 1
            Me.miEP0209Bomhlp.Text = "EP-02-09 Bill of Material"
            '
            'cmnuE024ItmMstr
            '
            Me.cmnuE024ItmMstr.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miAddItmToBom, Me.miUpdE024ItmMstrDaSrc, Me.miEngProcHelpE024ItmMstr})
            '
            'miAddItmToBom
            '
            Me.miAddItmToBom.Index = 0
            Me.miAddItmToBom.Text = "Add Item(s) To Bom"
            '
            'miUpdE024ItmMstrDaSrc
            '
            Me.miUpdE024ItmMstrDaSrc.Index = 1
            Me.miUpdE024ItmMstrDaSrc.Text = "Update Datasource"
            '
            'miEngProcHelpE024ItmMstr
            '
            Me.miEngProcHelpE024ItmMstr.Index = 2
            Me.miEngProcHelpE024ItmMstr.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miEP0208ItmMstrInHlp})
            Me.miEngProcHelpE024ItmMstr.Text = "Eng Proc Help"
            '
            'miEP0208ItmMstrInHlp
            '
            Me.miEP0208ItmMstrInHlp.Index = 0
            Me.miEP0208ItmMstrInHlp.Text = "EP-02-08 Item Master Input"
            '
            'cmnuBomTbl
            '
            Me.cmnuBomTbl.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miMakeBomTbl, Me.miUpdateBomSub, Me.miMakeOrigTbl})
            '
            'miMakeBomTbl
            '
            Me.miMakeBomTbl.Index = 0
            Me.miMakeBomTbl.Text = "Make Bom Tbl"
            '
            'miUpdateBomSub
            '
            Me.miUpdateBomSub.Index = 1
            Me.miUpdateBomSub.Text = "Update Datasource"
            '
            'miMakeOrigTbl
            '
            Me.miMakeOrigTbl.Index = 2
            Me.miMakeOrigTbl.Text = "Make Orig Tbl"
            '
            'dgE025BOM
            '
            Me.dgE025BOM.ContextMenu = Me.cmnuBomMain
            Me.dgE025BOM.DataMember = ""
            Me.dgE025BOM.Dock = System.Windows.Forms.DockStyle.Top
            Me.dgE025BOM.HeaderForeColor = System.Drawing.SystemColors.ControlText
            Me.dgE025BOM.Location = New System.Drawing.Point(0, 0)
            Me.dgE025BOM.Name = "dgE025BOM"
            Me.dgE025BOM.Size = New System.Drawing.Size(672, 176)
            Me.dgE025BOM.TabIndex = 1
            Me.dgE025BOM.Tag = ""
            '
            'Splitter1
            '
            Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Splitter1.Location = New System.Drawing.Point(0, 176)
            Me.Splitter1.Name = "Splitter1"
            Me.Splitter1.Size = New System.Drawing.Size(672, 3)
            Me.Splitter1.TabIndex = 2
            Me.Splitter1.TabStop = False
            '
            'dgE025BOMdv
            '
            Me.dgE025BOMdv.ContextMenu = Me.cmnuBomTbl
            Me.dgE025BOMdv.DataMember = ""
            Me.dgE025BOMdv.Dock = System.Windows.Forms.DockStyle.Top
            Me.dgE025BOMdv.HeaderForeColor = System.Drawing.SystemColors.ControlText
            Me.dgE025BOMdv.Location = New System.Drawing.Point(0, 179)
            Me.dgE025BOMdv.Name = "dgE025BOMdv"
            Me.dgE025BOMdv.Size = New System.Drawing.Size(672, 189)
            Me.dgE025BOMdv.TabIndex = 3
            '
            'Splitter2
            '
            Me.Splitter2.Dock = System.Windows.Forms.DockStyle.Top
            Me.Splitter2.Location = New System.Drawing.Point(0, 368)
            Me.Splitter2.Name = "Splitter2"
            Me.Splitter2.Size = New System.Drawing.Size(672, 3)
            Me.Splitter2.TabIndex = 4
            Me.Splitter2.TabStop = False
            '
            'dgE024ItmMstr
            '
            Me.dgE024ItmMstr.ContextMenu = Me.cmnuE024ItmMstr
            Me.dgE024ItmMstr.DataMember = ""
            Me.dgE024ItmMstr.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgE024ItmMstr.HeaderForeColor = System.Drawing.SystemColors.ControlText
            Me.dgE024ItmMstr.Location = New System.Drawing.Point(0, 371)
            Me.dgE024ItmMstr.Name = "dgE024ItmMstr"
            Me.dgE024ItmMstr.Size = New System.Drawing.Size(672, 109)
            Me.dgE024ItmMstr.TabIndex = 5
            '
            'ucE025BomItmMstr
            '
            Me.Controls.Add(Me.dgE024ItmMstr)
            Me.Controls.Add(Me.Splitter2)
            Me.Controls.Add(Me.dgE025BOMdv)
            Me.Controls.Add(Me.Splitter1)
            Me.Controls.Add(Me.dgE025BOM)
            Me.Name = "ucE025BomItmMstr"
            Me.Size = New System.Drawing.Size(672, 480)
            CType(Me.dgE025BOM, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgE025BOMdv, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgE024ItmMstr, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private Sub ucE025BomItmMstr_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            If SqlDaComp.DataSet11.E025BillofMaterialInput.Count = 0 Or SqlDaComp.DataSet11.E025BillofMaterialInputSubTable.Count = 0 Or SqlDaComp.DataSet11.E024ItemMasterInput.Count = 0 Then
               
                SqlDaComp.SqlConn.ConnectionString = words

                SqlDaComp.DaE025BillOfMat.Fill(SqlDaComp.DataSet11.E025BillofMaterialInput)
                dgE025BOM.DataSource = SqlDaComp.DataSet11.E025BillofMaterialInput
                SqlDaComp.DaE025BillOfMatSubTable.Fill(SqlDaComp.DataSet11.E025BillofMaterialInputSubTable)
                SqlDaComp.DaE024ItmMstr.Fill(SqlDaComp.DataSet11.E024ItemMasterInput)
                dgE024ItmMstr.DataSource = SqlDaComp.DataSet11.E024ItemMasterInput

                dgE025BOMdv.DataSource = Nothing
            End If

            mkTblStylE024ItmMstr()

        End Sub

        Dim dvE024ItmMstr As DataView
        Dim E024ItmMstrtblsAdded As Boolean
        Dim E024ItmMstrts As New DataGridTableStyle

        Private Sub mkTblStylE024ItmMstr()
            If E024ItmMstrtblsAdded = False Then
                E024ItmMstrts.MappingName = "E024ItemMasterInput"
                Dim TextCol1 As New DataGridTextBoxColumn
                TextCol1.MappingName = "EngineeringPartNumber"
                TextCol1.HeaderText = "EngineeringPartNumber"
                TextCol1.Width = 300
                E024ItmMstrts.GridColumnStyles.Add(TextCol1)
                Dim TextCol2 As New DataGridTextBoxColumn
                TextCol2.MappingName = "EngineeringDashNumber"
                TextCol2.HeaderText = "EngineeringDashNumber"
                TextCol2.Width = 125
                E024ItmMstrts.GridColumnStyles.Add(TextCol2)
                Dim TextCol3 As New DataGridTextBoxColumn
                TextCol3.MappingName = "EngineeringRevisionCode"
                TextCol3.HeaderText = "EngineeringRevisionCode"
                TextCol3.Width = 125
                E024ItmMstrts.GridColumnStyles.Add(TextCol3)
                Dim TextCol4 As New DataGridTextBoxColumn
                TextCol4.MappingName = "EngineeringEngineeringChangeNumberAndDate"
                TextCol4.HeaderText = "EngineeringEngineeringChangeNumberAndDate"
                TextCol4.Width = 150
                E024ItmMstrts.GridColumnStyles.Add(TextCol4)
                E024ItmMstrts.AlternatingBackColor = Color.LightBlue
                E024ItmMstrtblsAdded = True
            End If
            If dgE024ItmMstr.TableStyles.Contains("E024ItemMasterInput") = False Then dgE024ItmMstr.TableStyles.Add(E024ItmMstrts)
            dvE024ItmMstr = New DataView
            With dvE024ItmMstr
                .Table = SqlDaComp.DataSet11.Tables("E024ItemMasterInput")
                'Try : .RowFilter = "BillofMaterialInputNumber = '" & dgE024ItmMstr.Item(dgE025BOM.CurrentRowIndex, 4) & "'"
                'Catch ex As Exception
                '    MessageBox.Show(ex.ToString)
                'End Try
                '.RowStateFilter = DataViewRowState.ModifiedCurrent
                '.Sort = "CompanyName DESC"
            End With
            dgE024ItmMstr.DataSource = dvE024ItmMstr
            'bomID = dgE025BOM.Item(dgE025BOM.CurrentRowIndex, 4)
            'Dim frm As Form = Me.FindForm()
            'frm.Text = "E025 Bill of Materials # : " & bomID
            'crnID = Nothing
            'drnID = Nothing
            'ecoID = Nothing
        End Sub

        Dim dvE025BOM As DataView
        Dim E025BOMtblsAdded As Boolean
        Dim E025BOMts As New DataGridTableStyle
        Private Sub dgE025BOM_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgE025BOM.DoubleClick
            If E025BOMtblsAdded = False Then
                E025BOMts.MappingName = "E025BillofMaterialInputSubTable"
                Dim TextCol1 As New DataGridTextBoxColumn
                TextCol1.MappingName = "BOMItemNumber"
                TextCol1.HeaderText = "Item"
                TextCol1.Width = 50
                E025BOMts.GridColumnStyles.Add(TextCol1)
                Dim TextCol2 As New DataGridTextBoxColumn
                TextCol2.MappingName = "QuantityPer"
                TextCol2.HeaderText = "Qty"
                TextCol2.Width = 50
                E025BOMts.GridColumnStyles.Add(TextCol2)
                Dim TextCol3 As New DataGridTextBoxColumn
                TextCol3.MappingName = "ComponentPartNumber"
                TextCol3.HeaderText = "Comp. Part #"
                TextCol3.Width = 150
                E025BOMts.GridColumnStyles.Add(TextCol3)
                Dim TextCol4 As New DataGridTextBoxColumn
                TextCol4.MappingName = "EngineeringDescription"
                TextCol4.HeaderText = "Description"
                TextCol4.Width = 250
                E025BOMts.GridColumnStyles.Add(TextCol4)

                ' add Effectivity Columns - join from ???

                E025BOMts.AlternatingBackColor = Color.LightBlue
                E025BOMtblsAdded = True
            End If
            If dgE025BOMdv.TableStyles.Contains("E025BillofMaterialInputSubTable") = False Then dgE025BOMdv.TableStyles.Add(E025BOMts)
            dvE025BOM = New DataView
            With dvE025BOM
                .Table = SqlDaComp.DataSet11.Tables("E025BillofMaterialInputSubTable")
                Try
                    .RowFilter = "BillofMaterialInputNumber = '" & dgE025BOM.Item(dgE025BOM.CurrentRowIndex, 0) & "'"
                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                End Try
                '.RowStateFilter = DataViewRowState.ModifiedCurrent
                '.Sort = "CompanyName DESC"
            End With
            dgE025BOMdv.DataSource = dvE025BOM
            bomID = dgE025BOM.Item(dgE025BOM.CurrentRowIndex, 0)
            Dim frm As Form = Me.FindForm()
            frm.Text = "E025 Bill of Materials # : " & bomID
            crnID = Nothing
            drnID = Nothing
            ecoID = Nothing
        End Sub

        Private Sub miNewE025Bom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miNewE025Bom.Click
            'NewE044DRN.ShowDialog()
            SqlDaComp.DataSet11.E025BillofMaterialInput.Clear()
            SqlDaComp.DaE025BillOfMat.Fill(SqlDaComp.DataSet11)
            Dim MyNewRow As DataRow ': Dim classResponse As MsgBoxResult
            MyNewRow = SqlDaComp.DataSet11.E025BillofMaterialInput.NewRow
            'MyNewRow("AffectedDocuments") = dgE044DRN.Item(dgE044DRN.CurrentRowIndex, 1) 'e044DrN num
            MyNewRow("Originator") = UCase(SystemInformation.UserName)
            MyNewRow("OriginatorDate") = UCase(Format(Now, "MMM/dd/yy").ToString)
            'MyNewRow("ClassofChange") = chdlg.ChngType
            SqlDaComp.DataSet11.E025BillofMaterialInput.Rows.Add(MyNewRow)
            Try : SqlDaComp.DaE025BillOfMat.Update(SqlDaComp.DataSet11.E025BillofMaterialInput)
            Catch dbcx As DBConcurrencyException
                'createMessage(dbcx, "E025Bom")
            Catch ex As Exception
                MessageBox.Show("Update Failed", ex.GetType().ToString())
            End Try
            ' ecoID = MyNewRow.Item(11).ToString
            SqlDaComp.DataSet11.E025BillofMaterialInput.Clear()
            SqlDaComp.DaE025BillOfMat.Fill(SqlDaComp.DataSet11)
        End Sub

        Private Sub miUpDateDS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miUpDateDS.Click
            Try : SqlDaComp.DaE025BillOfMat.Update(SqlDaComp.DataSet11.E025BillofMaterialInput)
            Catch dbcx As DBConcurrencyException
                'createMessage(dbcx, "E025BillofMaterialInput")
            Catch ex As Exception
                MessageBox.Show("Update Failed", ex.GetType().ToString())
            End Try
        End Sub

        Private Sub miEP0109ProdStuctHlp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miEP0109ProdStuctHlp.Click
            Dim HelpFileName As String = pathStrToHandBook & "01 Product Design and Development.dwg"
            HlpDwg(HelpFileName, "EP-01-09 Product Structuring (1)", rOnly)
        End Sub

        Private Sub miEP0209Bomhlp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miEP0209Bomhlp.Click
            Dim HelpFileName As String = pathStrToHandBook & "02 Product and Documentation Identification.dwg"
            HlpDwg(HelpFileName, "EP-02-09 Bill of Material (1)", rOnly)
        End Sub

        Private Sub miMakeBomTbl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miMakeBomTbl.Click
            Dim tbl As New Table
            tbl.IsHeaderSuppressed = False
            tbl.IsTitleSuppressed = False
            tbl.InsertRows(1, 0.25, dvE025BOM.Count + 1)
            tbl.InsertColumns(1, 2, dgE025BOMdv.VisibleColumnCount - 1)
            'tbl.SetAlignment(0, 0, CellAlignment.TopLeft)
            tbl.SetTextString(0, 0, "Bill of Materials # " & dgE025BOM.Item(dgE025BOM.CurrentRowIndex, 4))
            Dim c As Short : Dim Cc As Short : Dim MyRow As DataRowView
            For c = 1 To 1
                MyRow = dvE025BOM.Item(c)
                For Cc = 0 To dgE025BOMdv.VisibleColumnCount - 1
                    'tbl.SetAlignment(c, Cc, CellAlignment.TopLeft)
                    tbl.SetTextString(c, Cc, E025BOMts.GridColumnStyles(Cc).HeaderText)
                Next
            Next

            For c = 0 To (dvE025BOM.Count - 1)
                MyRow = dvE025BOM.Item(c)
                For Cc = 0 To dgE025BOMdv.VisibleColumnCount - 1
                    If Not IsDBNull(dgE025BOMdv.Item(c, Cc)) Then
                        'tbl.SetAlignment(c + 2, Cc, CellAlignment.TopLeft)
                        tbl.SetTextString(c + 2, Cc, dgE025BOMdv.Item(c, Cc))
                    Else
                        'tbl.SetAlignment(c + 2, Cc, CellAlignment.TopLeft)
                        tbl.SetTextString(c + 2, Cc, "Null")
                    End If
                Next
            Next

            Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
            Dim frm As Form = Me.FindForm()
            frm.Hide()
            Dim tblPnt As PromptPointOptions = New PromptPointOptions("Select Insertion Point...")
            Dim tblPntRes As PromptPointResult = ed.GetPoint(tblPnt)
            If tblPntRes.Status <> PromptStatus.OK Then
                frm.Show()
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

        Private Sub miUpdateBomSub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miUpdateBomSub.Click

            Try : SqlDaComp.DaE025BillOfMatSubTable.Update(SqlDaComp.DataSet11.E025BillofMaterialInputSubTable)
            Catch dbcx As DBConcurrencyException
                'createMessage(dbcx, "E025BillofMaterialInputSubTable", dsMod)
            Catch ex As Exception
                MessageBox.Show("Update Failed", ex.GetType().ToString())
            Finally
                SqlDaComp.DataSet11.E025BillofMaterialInputSubTable.Clear()
                SqlDaComp.DaE025BillOfMatSubTable.Fill(SqlDaComp.DataSet11)
            End Try
        End Sub

        Private Sub miMakeOrigTbl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miMakeOrigTbl.Click
            Dim tbl As New Table
            Dim bt As BlockTable
            Dim btr As BlockTableRecord
            Dim db As Database = HostApplicationServices.WorkingDatabase
            Dim trans As Transaction
            trans = db.TransactionManager.StartTransaction()
            tbl.IsHeaderSuppressed = False
            tbl.IsTitleSuppressed = False
            tbl.InsertRows(1, 0.25, dvE025BOM.Count + 1)
            tbl.InsertColumns(1, 2, SqlDaComp.DataSet11.Tables("E025BillofMaterialInputSubTable").Columns.Count - 1)
            tbl.SetTextString(0, 0, "Bill of Materials")
            Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
            Dim frm As Form = Me.FindForm()
            frm.Hide()
            Dim tblPnt As PromptPointOptions = New PromptPointOptions("Select Insertion Point...")
            Dim tblPntRes As PromptPointResult = ed.GetPoint(tblPnt)
            If tblPntRes.Status <> PromptStatus.OK Then
                frm.Show()
                Return
            End If
            tbl.Position = tblPntRes.Value
            Dim c As Short
            Dim Cc As Short
            Dim MyRow As DataRowView
            For c = 1 To 1
                MyRow = dvE025BOM.Item(c)
                For Cc = 0 To SqlDaComp.DataSet11.Tables("E025BillofMaterialInputSubTable").Columns.Count - 1
                    tbl.SetTextString(c, Cc, SqlDaComp.DataSet11.Tables("E025BillofMaterialInputSubTable").Columns(Cc).ColumnName)
                Next
            Next
            For c = 0 To (dvE025BOM.Count - 1)
                MyRow = dvE025BOM.Item(c)
                For Cc = 0 To SqlDaComp.DataSet11.Tables("E025BillofMaterialInputSubTable").Columns.Count - 1
                    If Not IsDBNull(MyRow(Cc)) Then
                        tbl.SetTextString(c + 2, Cc, MyRow(Cc))
                    Else
                        tbl.SetTextString(c + 2, Cc, "Null")
                    End If
                Next
            Next
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

        Private Sub miAddItmToBom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miAddItmToBom.Click

            ' this adds two records ???

            Dim response As System.Windows.Forms.DialogResult
            Dim myRow As DataRow
            myRow = SqlDaComp.DataSet11.E025BillofMaterialInputSubTable.NewRow()
            myRow("BillofMaterialInputNumber") = dgE025BOM.Item(dgE025BOM.CurrentRowIndex, 0)
            myRow("ComponentPartNumber") = dgE024ItmMstr.Item(dgE024ItmMstr.CurrentRowIndex, 0) & " - " & dgE024ItmMstr.Item(dgE024ItmMstr.CurrentRowIndex, 1)

            SqlDaComp.DataSet11.E025BillofMaterialInputSubTable.Rows.Add(myRow)

            response = MessageBox.Show("Update Datasource ?", "Update Datasource ?", MessageBoxButtons.YesNo)
            Select Case response
                Case System.Windows.Forms.DialogResult.Yes
                    Try : SqlDaComp.DaE025BillOfMatSubTable.Update(SqlDaComp.DataSet11.E025BillofMaterialInputSubTable)
                    Catch dbcx As DBConcurrencyException
                        'createMessage(dbcx, "E024ItemMasterInput")
                    Catch ex As Exception
                        MessageBox.Show("Update Failed", ex.GetType().ToString())
                    End Try
                    SqlDaComp.DataSet11.Tables("E025BillofMaterialInputSubTable").Clear()
                    SqlDaComp.DaE025BillOfMatSubTable.Fill(SqlDaComp.DataSet11)
                Case Else
            End Select

        End Sub

        Private Sub miUpdE024ItmMstrDaSrc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miUpdE024ItmMstrDaSrc.Click
            Try : SqlDaComp.DaE024ItmMstr.Update(SqlDaComp.DataSet11.E024ItemMasterInput)
                'Catch dbcx As DBConcurrencyException
                'createMessage(dbcx, "E024ItemMasterInput")
            Catch ex As Exception
                MessageBox.Show("Update Failed" & " " & ex.ToString())
            End Try
        End Sub

        Private Sub miEP0208ItmMstrInHlp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miEP0208ItmMstrInHlp.Click
            Dim HelpFileName As String = pathStrToHandBook & "02 Product and Documentation Identification.dwg"
            HlpDwg(HelpFileName, "EP-02-08 Item Master Input (1)", rOnly)
        End Sub

    End Class
End Namespace