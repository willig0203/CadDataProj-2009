Option Explicit On

Imports System.Windows.Forms
Imports System.Drawing
Imports System.IO
Imports System.Environment


Imports Autodesk.AutoCAD.EditorInput
Imports Autodesk.AutoCAD.ApplicationServices
Imports Autodesk.AutoCAD.DatabaseServices

Imports rnsCadDataProj.nsForms.frmMain
Imports rnsCadDataProj.nsUserCtls.ucE037ECO
Imports rnsCadDataProj.nsMods
Imports rnsCadDataProj.nsForms

Namespace nsUserCtls

    Public Class ucE044DRN

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


        Friend WithEvents dgE044DRN As System.Windows.Forms.DataGrid
        Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
        Friend WithEvents cmnuE044DRN As System.Windows.Forms.ContextMenu
        Friend WithEvents miNewE044DRN As System.Windows.Forms.MenuItem
        Friend WithEvents miUpDtE044DRNTbl As System.Windows.Forms.MenuItem
        Friend WithEvents miEngProcHelpE044 As System.Windows.Forms.MenuItem
        Friend WithEvents miEP0105 As System.Windows.Forms.MenuItem
        Friend WithEvents miEP0106 As System.Windows.Forms.MenuItem
        Friend WithEvents miEP0201 As System.Windows.Forms.MenuItem
        Friend WithEvents miEP0202 As System.Windows.Forms.MenuItem
        Friend WithEvents miEP0203 As System.Windows.Forms.MenuItem
        Friend WithEvents miEP0604 As System.Windows.Forms.MenuItem
        Friend WithEvents miEP0608 As System.Windows.Forms.MenuItem
        Friend WithEvents miEP0702 As System.Windows.Forms.MenuItem
        Friend WithEvents cmnuE044DRNSubTbl As System.Windows.Forms.ContextMenu
        Friend WithEvents miTransToItmMstr As System.Windows.Forms.MenuItem
        Friend WithEvents miUpdateRelDocsDs As System.Windows.Forms.MenuItem
        Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
        Friend WithEvents DataGrid6 As System.Windows.Forms.DataGrid
        Friend WithEvents miClrDRN As System.Windows.Forms.MenuItem
        Friend WithEvents miMkE044DRNTbl As MenuItem
        Friend WithEvents miRptAllDRN As System.Windows.Forms.MenuItem

        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.dgE044DRN = New System.Windows.Forms.DataGrid()
            Me.cmnuE044DRN = New System.Windows.Forms.ContextMenu()
            Me.miNewE044DRN = New System.Windows.Forms.MenuItem()
            Me.miUpDtE044DRNTbl = New System.Windows.Forms.MenuItem()
            Me.miEngProcHelpE044 = New System.Windows.Forms.MenuItem()
            Me.miEP0105 = New System.Windows.Forms.MenuItem()
            Me.miEP0106 = New System.Windows.Forms.MenuItem()
            Me.miEP0201 = New System.Windows.Forms.MenuItem()
            Me.miEP0202 = New System.Windows.Forms.MenuItem()
            Me.miEP0203 = New System.Windows.Forms.MenuItem()
            Me.miEP0604 = New System.Windows.Forms.MenuItem()
            Me.miEP0608 = New System.Windows.Forms.MenuItem()
            Me.miEP0702 = New System.Windows.Forms.MenuItem()
            Me.miRptAllDRN = New System.Windows.Forms.MenuItem()
            Me.miClrDRN = New System.Windows.Forms.MenuItem()
            Me.Splitter1 = New System.Windows.Forms.Splitter()
            Me.cmnuE044DRNSubTbl = New System.Windows.Forms.ContextMenu()
            Me.miUpdateRelDocsDs = New System.Windows.Forms.MenuItem()
            Me.miTransToItmMstr = New System.Windows.Forms.MenuItem()
            Me.DataGrid1 = New System.Windows.Forms.DataGrid()
            Me.DataGrid6 = New System.Windows.Forms.DataGrid()
            Me.miMkE044DRNTbl = New System.Windows.Forms.MenuItem()
            CType(Me.dgE044DRN, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DataGrid6, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'dgE044DRN
            '
            Me.dgE044DRN.ContextMenu = Me.cmnuE044DRN
            Me.dgE044DRN.DataMember = ""
            Me.dgE044DRN.Dock = System.Windows.Forms.DockStyle.Top
            Me.dgE044DRN.HeaderForeColor = System.Drawing.SystemColors.ControlText
            Me.dgE044DRN.Location = New System.Drawing.Point(0, 0)
            Me.dgE044DRN.Name = "dgE044DRN"
            Me.dgE044DRN.Size = New System.Drawing.Size(512, 224)
            Me.dgE044DRN.TabIndex = 13
            Me.dgE044DRN.Tag = ""
            '
            'cmnuE044DRN
            '
            Me.cmnuE044DRN.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miNewE044DRN, Me.miUpDtE044DRNTbl, Me.miEngProcHelpE044, Me.miRptAllDRN, Me.miClrDRN})
            '
            'miNewE044DRN
            '
            Me.miNewE044DRN.Index = 0
            Me.miNewE044DRN.Text = "New E044 DRN"
            '
            'miUpDtE044DRNTbl
            '
            Me.miUpDtE044DRNTbl.Index = 1
            Me.miUpDtE044DRNTbl.Text = "Update E044 DRN Datasource"
            '
            'miEngProcHelpE044
            '
            Me.miEngProcHelpE044.Index = 2
            Me.miEngProcHelpE044.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miEP0105, Me.miEP0106, Me.miEP0201, Me.miEP0202, Me.miEP0203, Me.miEP0604, Me.miEP0608, Me.miEP0702})
            Me.miEngProcHelpE044.Text = "Eng Proc Help"
            '
            'miEP0105
            '
            Me.miEP0105.Index = 0
            Me.miEP0105.Text = "EP-01-05 Engineering Review Board"
            '
            'miEP0106
            '
            Me.miEP0106.Index = 1
            Me.miEP0106.Text = "EP-01-06 Product Phases"
            '
            'miEP0201
            '
            Me.miEP0201.Index = 2
            Me.miEP0201.Text = "EP-02-01 Document Numbering System"
            '
            'miEP0202
            '
            Me.miEP0202.Index = 3
            Me.miEP0202.Text = "EP-02-02 Document Number Assignment Logbook"
            '
            'miEP0203
            '
            Me.miEP0203.Index = 4
            Me.miEP0203.Text = "EP-02-03 Block Number Assignment"
            '
            'miEP0604
            '
            Me.miEP0604.Index = 5
            Me.miEP0604.Text = "EP-06-04 Engineering Change Procedure"
            '
            'miEP0608
            '
            Me.miEP0608.Index = 6
            Me.miEP0608.Text = "EP-06-08 Change Control Board"
            '
            'miEP0702
            '
            Me.miEP0702.Index = 7
            Me.miEP0702.Text = "EP-07-02 Document Release"
            '
            'miRptAllDRN
            '
            Me.miRptAllDRN.Index = 3
            Me.miRptAllDRN.Text = "Report"
            '
            'miClrDRN
            '
            Me.miClrDRN.Index = 4
            Me.miClrDRN.Text = "Clr DRN"
            '
            'Splitter1
            '
            Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Splitter1.Location = New System.Drawing.Point(0, 224)
            Me.Splitter1.Name = "Splitter1"
            Me.Splitter1.Size = New System.Drawing.Size(512, 3)
            Me.Splitter1.TabIndex = 14
            Me.Splitter1.TabStop = False
            '
            'cmnuE044DRNSubTbl
            '
            Me.cmnuE044DRNSubTbl.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miMkE044DRNTbl, Me.miUpdateRelDocsDs, Me.miTransToItmMstr})
            '
            'miUpdateRelDocsDs
            '
            Me.miUpdateRelDocsDs.Index = 1
            Me.miUpdateRelDocsDs.Text = "Update Released Docs Datasource"
            '
            'miTransToItmMstr
            '
            Me.miTransToItmMstr.Index = 2
            Me.miTransToItmMstr.Text = "Trans To Itm Mstr"
            '
            'DataGrid1
            '
            Me.DataGrid1.DataMember = ""
            Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
            Me.DataGrid1.Location = New System.Drawing.Point(312, 144)
            Me.DataGrid1.Name = "DataGrid1"
            Me.DataGrid1.Size = New System.Drawing.Size(168, 152)
            Me.DataGrid1.TabIndex = 15
            Me.DataGrid1.Visible = False
            '
            'DataGrid6
            '
            Me.DataGrid6.ContextMenu = Me.cmnuE044DRNSubTbl
            Me.DataGrid6.DataMember = ""
            Me.DataGrid6.Dock = System.Windows.Forms.DockStyle.Fill
            Me.DataGrid6.HeaderForeColor = System.Drawing.SystemColors.ControlText
            Me.DataGrid6.Location = New System.Drawing.Point(0, 227)
            Me.DataGrid6.Name = "DataGrid6"
            Me.DataGrid6.Size = New System.Drawing.Size(512, 181)
            Me.DataGrid6.TabIndex = 16
            '
            'miMkE044DRNTbl
            '
            Me.miMkE044DRNTbl.Index = 0
            Me.miMkE044DRNTbl.Text = "Make E044 DRN Tbl"
            '
            'ucE044DRN
            '
            Me.Controls.Add(Me.DataGrid1)
            Me.Controls.Add(Me.DataGrid6)
            Me.Controls.Add(Me.Splitter1)
            Me.Controls.Add(Me.dgE044DRN)
            Me.Name = "ucE044DRN"
            Me.Size = New System.Drawing.Size(512, 408)
            CType(Me.dgE044DRN, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DataGrid6, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private Sub ucE044DRN_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            If SqlDaComp.DataSet11.E044DocumentReleaseNotice.Count = 0 Or SqlDaComp.DataSet11.E044ReleasedDocuments.Count = 0 Then
                SqlDaComp.SqlConn.ConnectionString = words
                SqlDaComp.DaE044DocRelNtc.Fill(SqlDaComp.DataSet11.E044DocumentReleaseNotice)
                dgE044DRN.DataSource = SqlDaComp.DataSet11.E044DocumentReleaseNotice
                SqlDaComp.DaE044RelDocs.Fill(SqlDaComp.DataSet11.E044ReleasedDocuments)
                DataGrid6.DataSource = SqlDaComp.DataSet11.E044ReleasedDocuments
            End If
        End Sub

        Private Shared Sub DataGrid6_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid6.DoubleClick
            Dim frm As New frmE024ItmMstrDetail
            frm.Show()
            frm.FindItmMstrs(sender, 2)
        End Sub

        Dim E044DRNtblsAdded As Boolean
        Dim E044DRNts As New DataGridTableStyle

        Private Sub dgE044DRN_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgE044DRN.DoubleClick

            If E044DRNtblsAdded = False Then

                E044DRNts.MappingName = "E044ReleasedDocuments"

                Dim TextCol1 As New DataGridTextBoxColumn
                TextCol1.MappingName = "RevisionBlock"
                TextCol1.HeaderText = "Rev"
                TextCol1.Width = 50
                E044DRNts.GridColumnStyles.Add(TextCol1)

                Dim TextCol2 As New DataGridTextBoxColumn
                TextCol2.MappingName = "FileName"
                TextCol2.HeaderText = "Dwg"
                TextCol2.Width = 250
                E044DRNts.GridColumnStyles.Add(TextCol2)

                Dim TextCol3 As New DataGridTextBoxColumn
                TextCol3.MappingName = "Layout"
                TextCol3.HeaderText = "Tab"
                TextCol3.Width = 200
                E044DRNts.GridColumnStyles.Add(TextCol3)

                Dim TextCol4 As New DataGridTextBoxColumn
                TextCol4.MappingName = "TitleBlock"
                TextCol4.HeaderText = "TitleBlock"
                TextCol4.Width = 200
                E044DRNts.GridColumnStyles.Add(TextCol4)

                Dim TextCol5 As New DataGridTextBoxColumn
                TextCol5.MappingName = "ControlStamp"
                TextCol5.HeaderText = "Stamp"
                TextCol5.Width = 75
                E044DRNts.GridColumnStyles.Add(TextCol5)

                E044DRNts.AlternatingBackColor = Color.LightBlue
                E044DRNtblsAdded = True
            End If
            If DataGrid6.TableStyles.Contains("E044ReleasedDocuments") = False Then DataGrid6.TableStyles.Add(E044DRNts)
            dvE044DRN = New DataView
            With dvE044DRN
                .Table = SqlDaComp.DataSet11.Tables("E044ReleasedDocuments")
                Try : .RowFilter = "DocumentReleaseNoticeNumber = '" & dgE044DRN.Item(dgE044DRN.CurrentRowIndex, 0) & "'"
                Catch ex As Exception : MessageBox.Show(ex.ToString)
                End Try
                '.RowStateFilter = DataViewRowState.ModifiedCurrent
                '.Sort = "CompanyName DESC"
            End With
            DataGrid6.DataSource = dvE044DRN
            drnID = dgE044DRN.Item(dgE044DRN.CurrentRowIndex, 0)
            Dim frm As Form = Me.FindForm()
            frm.Text = "E044 Document Release Notice # : " & drnID
            crnID = Nothing
            bomID = Nothing
            ecoID = Nothing
        End Sub


#Region "menuItems"

        Private Sub miMkE044DRNTbl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miMkE044DRNTbl.Click
            Dim tbl As New Table
            Dim bt As BlockTable
            Dim btr As BlockTableRecord
            Dim db As Database = HostApplicationServices.WorkingDatabase
            Dim trans As Transaction
            trans = db.TransactionManager.StartTransaction()
            tbl.IsHeaderSuppressed = False
            tbl.IsTitleSuppressed = False
            tbl.SetColumnWidth(10.0)
            tbl.InsertRows(1, 0.25, dvE044DRN.Count + 1)
            tbl.InsertColumns(1, 10, DataGrid6.VisibleColumnCount - 1)
            tbl.SetTextString(0, 0, "E044DRN #" & drnID) ' & " " & FolderName)
            Dim c As Short : Dim Cc As Short : Dim MyRow As DataRowView
            For c = 1 To 1
                MyRow = dvE044DRN.Item(c)
                For Cc = 0 To DataGrid6.VisibleColumnCount - 1
                    tbl.SetAlignment(c, Cc, CellAlignment.MiddleLeft)
                    tbl.SetTextString(c, Cc, E044DRNts.GridColumnStyles(Cc).HeaderText)
                Next
            Next
            For c = 0 To (dvE044DRN.Count - 1)
                MyRow = dvE044DRN.Item(c)
                For Cc = 0 To DataGrid6.VisibleColumnCount - 1
                    If Not IsDBNull(DataGrid6.Item(c, Cc)) Then
                        tbl.SetAlignment(c + 2, Cc, CellAlignment.MiddleLeft)
                        tbl.SetTextString(c + 2, Cc, DataGrid6.Item(c, Cc))
                    Else
                        tbl.SetAlignment(c + 2, Cc, CellAlignment.MiddleLeft)
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
                Finally : tbl.Dispose()
                End Try
                trans.Commit()
            Finally
                docLock.Dispose() : trans.Dispose()
            End Try
        End Sub


        Private Sub miTransToItmMstr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miTransToItmMstr.Click

            If SqlDaComp.DataSet11.E045EngineeringChangePartNumberInput.Count = 0 Then
                SqlDaComp.SqlConn.ConnectionString = words
                SqlDaComp.DaE045EngChPrtNumIn.Fill(SqlDaComp.DataSet11.E045EngineeringChangePartNumberInput)
            End If

            If SqlDaComp.DataSet11.E045SubTable.Count = 0 Then
                SqlDaComp.SqlConn.ConnectionString = words
                SqlDaComp.DaE045SubTable.Fill(SqlDaComp.DataSet11.E045SubTable)
            End If

            If SqlDaComp.DataSet11.E024ItemMasterInput.Count = 0 Then
                SqlDaComp.SqlConn.ConnectionString = words
                SqlDaComp.DaE024ItmMstr.Fill(SqlDaComp.DataSet11.E024ItemMasterInput)
            End If

            Dim MyNewRow As DataRow = Nothing : Dim MyRow As DataRowView
            Dim c As Integer ': Dim Cc As Integer
            Dim E024ItmMstrDV As DataView = New DataView(SqlDaComp.DataSet11.E024ItemMasterInput)
            Dim fStr As String : Dim str As String
            Dim AddResponse As MsgBoxResult : Dim UpdateResponse As MsgBoxResult

            For c = 0 To (dvE044DRN.Count - 1)
                MyRow = dvE044DRN.Item(c) : str = MyRow.Item(0)
                str = str.Replace(".dwg", "") : str = str.Replace(".DWG", "") ' Should upper case this and then strip it
                fStr = str & " - " & MyRow.Item(1) ' name and layout

                With E024ItmMstrDV
                    .Table = SqlDaComp.DataSet11.Tables("E024ItemMasterInput")
                    Try : .RowFilter = "EngineeringPartNumber = '" & fStr & "'"
                    Catch ex As Exception : MessageBox.Show(ex.ToString)
                    End Try
                    .RowStateFilter = DataViewRowState.CurrentRows
                    .Sort = "EngineeringDashNumber DESC"
                End With

                DataGrid1.Visible = True : DataGrid1.DataSource = E024ItmMstrDV

                Dim myDRV As DataRowView = Nothing

                If E024ItmMstrDV.Count <> 0 Then
                    Try : myDRV = E024ItmMstrDV.Item(0)
                    Catch
                        'Catch ex As Exception : MessageBox.Show(ex.ToString)
                    End Try
                End If

                ' have the last in doc  ' name - layout    ' dash    ' revision
                'MessageBox.Show(myDRV.Item(6).ToString & vbCrLf & myDRV.Item(3).ToString & vbCrLf & myDRV.Item(8).ToString)

                If myDRV Is Nothing Then
                    AddResponse = MessageBox.Show("No match found. Press Ok To Add To Item Master", "Caption") ', MsgBoxStyle.OKCancel)
                    If AddResponse = MsgBoxResult.Ok Then
                        If ecoID = Nothing Then
                            chdlg.rbNewDoc.Enabled = True
                            chdlg.rbNewDoc.Checked = True
                            NewE037ECO(drnID)
                        End If
                        str = MyRow.Item(0) : str = str.Replace(".dwg", "") : str = str.Replace(".DWG", "")
                        MyNewRow = SqlDaComp.DataSet11.E024ItemMasterInput.NewRow
                        MyNewRow("EngineeringPartNumber") = str & " - " & MyRow.Item(1)
                        MyNewRow("EngineeringDashNumber") = "00"
                        MyNewRow("EngineeringDescription") = "Get From Titleblock"
                        MyNewRow("EngineeringEngineeringChangeNumberAndDate") = ecoID & " - " & UCase(Format(Now, "MMM/dd/yy").ToString)
                        MyNewRow("EngineeringRevisionCode") = MyRow.Item(3) 'rev
                        SqlDaComp.DataSet11.E024ItemMasterInput.Rows.Add(MyNewRow)
                    End If

                    Dim NewRowE045ECPNI As DataRow = SqlDaComp.DataSet11.E045EngineeringChangePartNumberInput.NewRow
                    Dim docName As String = MyNewRow("EngineeringPartNumber") & " - " & MyNewRow("EngineeringDashNumber") '& "-" & MyNewRow("EngineeringRevisionCode")
                    NewRowE045ECPNI("DocumentNumber") = docName
                    SqlDaComp.DataSet11.E045EngineeringChangePartNumberInput.Rows.Add(NewRowE045ECPNI)

                    Dim EcPniDV As DataView = New DataView(SqlDaComp.DataSet11.E045EngineeringChangePartNumberInput)
                    With EcPniDV
                        'str = MyRow.Item(0) : str = str.Replace(".dwg", "") : str = str.Replace(".DWG", "")
                        Try : .RowFilter = ""
                            'Try : .RowFilter = "DocumentNumber = '" & str & " - " & MyRow.Item(1) & " - " & MyRow.Item(2) & "'"
                        Catch ex As Exception : MessageBox.Show(ex.ToString)
                        End Try
                        .RowStateFilter = DataViewRowState.CurrentRows
                        .Sort = "EngineeringChangePartNumberInputNumber DESC"
                    End With

                    Dim pn As DataRowView = EcPniDV.Item(0)
                    Dim NewRowE045SubTbl As DataRow = SqlDaComp.DataSet11.E045SubTable.NewRow

                    NewRowE045SubTbl("EngineeringChangePartNumberInputNumber") = pn.Item(0)
                    NewRowE045SubTbl("EngineeringChangeNumber") = ecoID
                    NewRowE045SubTbl("DocRevision") = MyNewRow("EngineeringRevisionCode")
                    SqlDaComp.DataSet11.E045SubTable.Rows.Add(NewRowE045SubTbl)

                Else

                    If ecoID = Nothing Then
                        MessageBox.Show("Found Match - Make New ECO", "Caption")
                        chdlg.rbNewDoc.Enabled = False : NewE037ECO(drnID)
                    End If

                    ' use a form and two grids instead ??
                    ' can cause error if one doc is existing and one is new ?


                    UpdateResponse = MessageBox.Show("Update This Record " & myDRV("EngineeringPartNumber") & " - " & myDRV("EngineeringDashNumber") & " - " & myDRV("EngineeringRevisionCode") & vbCrLf _
                                           & "With This One          " & str & " - " & MyRow.Item(1) & " - " & myDRV("EngineeringDashNumber") & " - " & MyRow.Item(3), "Caption", MessageBoxButtons.OKCancel)

                    'increment dash number and revision while adding new record
                    If UpdateResponse = MsgBoxResult.Ok And chdlg.ChngType = "Non-Interchangeable" Then
                        str = MyRow.Item(0) : str = str.Replace(".dwg", "") : str = str.Replace(".DWG", "")
                        MyNewRow = SqlDaComp.DataSet11.E024ItemMasterInput.NewRow
                        MyNewRow("EngineeringPartNumber") = str & " - " & MyRow.Item(1)
                        MyNewRow("EngineeringDashNumber") = Format(myDRV("EngineeringDashNumber") + 1, "00").ToString
                        MyNewRow("EngineeringDescription") = "Get From Titleblock"
                        MyNewRow("EngineeringEngineeringChangeNumberAndDate") = ecoID & " - " & UCase(Format(Now, "MMM/dd/yy").ToString)
                        MyNewRow("EngineeringRevisionCode") = MyRow.Item(3) 'rev
                        SqlDaComp.DataSet11.E024ItemMasterInput.Rows.Add(MyNewRow)

                        Dim NewRowE045ECPNI As DataRow = SqlDaComp.DataSet11.E045EngineeringChangePartNumberInput.NewRow
                        Dim docName As String = MyNewRow("EngineeringPartNumber") & " - " & MyNewRow("EngineeringDashNumber") '& "-" & MyNewRow("EngineeringRevisionCode")
                        NewRowE045ECPNI("DocumentNumber") = docName
                        SqlDaComp.DataSet11.E045EngineeringChangePartNumberInput.Rows.Add(NewRowE045ECPNI)

                        Dim EcPniDV As DataView = New DataView(SqlDaComp.DataSet11.E045EngineeringChangePartNumberInput)
                        With EcPniDV
                            'str = MyRow.Item(0) : str = str.Replace(".dwg", "") : str = str.Replace(".DWG", "")
                            Try : .RowFilter = "DocumentNumber = '" & fStr & " - " & MyNewRow("EngineeringDashNumber") & "'"
                                'Try : .RowFilter = "DocumentNumber = '" & str & " - " & MyRow.Item(1) & " - " & MyRow.Item(2) & "'"
                            Catch ex As Exception : MessageBox.Show(ex.ToString)
                            End Try
                            .RowStateFilter = DataViewRowState.CurrentRows
                            .Sort = "DocumentNumber"
                        End With

                        Dim pn As DataRowView = EcPniDV.Item(0)
                        Dim NewRowE045SubTbl As DataRow = SqlDaComp.DataSet11.E045SubTable.NewRow
                        NewRowE045SubTbl("EngineeringChangePartNumberInputNumber") = pn.Item(0)
                        NewRowE045SubTbl("EngineeringChangeNumber") = ecoID
                        NewRowE045SubTbl("DocRevision") = MyNewRow("EngineeringRevisionCode")
                        SqlDaComp.DataSet11.E045SubTable.Rows.Add(NewRowE045SubTbl)

                    End If

                    'if change is interchangeable must add new master "00" item with incremented revision+
                    'if bom assembly item ???
                    If UpdateResponse = MsgBoxResult.Ok And chdlg.ChngType = "Interchangeable" Then
                        str = MyRow.Item(0) : str = str.Replace(".dwg", "") : str = str.Replace(".DWG", "")
                        MyNewRow = SqlDaComp.DataSet11.E024ItemMasterInput.NewRow
                        MyNewRow("EngineeringPartNumber") = str & " - " & MyRow.Item(1)
                        MyNewRow("EngineeringDashNumber") = "00"
                        MyNewRow("EngineeringDescription") = "Get From Titleblock"
                        MyNewRow("EngineeringEngineeringChangeNumberAndDate") = ecoID & " - " & UCase(Format(Now, "MMM/dd/yy").ToString)
                        MyNewRow("EngineeringRevisionCode") = MyRow.Item(3) 'check cad file out and increment revision and put here ?
                        SqlDaComp.DataSet11.E024ItemMasterInput.Rows.Add(MyNewRow)

                        Dim EcPniDV As DataView = New DataView(SqlDaComp.DataSet11.E045EngineeringChangePartNumberInput)
                        With EcPniDV
                            'str = MyRow.Item(0) : str = str.Replace(".dwg", "") : str = str.Replace(".DWG", "")
                            Try : .RowFilter = "DocumentNumber = '" & fStr & " - " & MyNewRow("EngineeringDashNumber") & "'"
                                'Try : .RowFilter = "DocumentNumber = '" & str & " - " & MyRow.Item(1) & " - " & MyRow.Item(2) & "'"
                            Catch ex As Exception : MessageBox.Show(ex.ToString)
                            End Try
                            .RowStateFilter = DataViewRowState.CurrentRows
                            .Sort = "DocumentNumber"
                        End With

                        Dim pn As DataRowView = EcPniDV.Item(0)
                        Dim NewRowE045SubTbl As DataRow = SqlDaComp.DataSet11.E045SubTable.NewRow
                        'Dim num As String = NewRowE045ECPNI.Item(0)
                        NewRowE045SubTbl("EngineeringChangePartNumberInputNumber") = pn.Item(0)
                        NewRowE045SubTbl("EngineeringChangeNumber") = ecoID
                        NewRowE045SubTbl("DocRevision") = MyNewRow("EngineeringRevisionCode")
                        SqlDaComp.DataSet11.E045SubTable.Rows.Add(NewRowE045SubTbl)

                    End If

                    'increment revision only
                    If UpdateResponse = MsgBoxResult.Ok And chdlg.ChngType = "Documentation Only" Then
                        str = MyRow.Item(0) : str = str.Replace(".dwg", "") : str = str.Replace(".DWG", "")
                        MyNewRow = SqlDaComp.DataSet11.E024ItemMasterInput.NewRow
                        MyNewRow("EngineeringPartNumber") = str & " - " & MyRow.Item(1)
                        MyNewRow("EngineeringDashNumber") = "00" ' this should be the highest dash number ?
                        MyNewRow("EngineeringDescription") = "Get From Titleblock"
                        MyNewRow("EngineeringEngineeringChangeNumberAndDate") = ecoID & " - " & UCase(Format(Now, "MMM/dd/yy").ToString)
                        MyNewRow("EngineeringRevisionCode") = MyRow.Item(3) 'rev
                        SqlDaComp.DataSet11.E024ItemMasterInput.Rows.Add(MyNewRow)

                        Dim EcPniDV As DataView = New DataView(SqlDaComp.DataSet11.E045EngineeringChangePartNumberInput)
                        With EcPniDV
                            'str = MyRow.Item(0) : str = str.Replace(".dwg", "") : str = str.Replace(".DWG", "")
                            Try : .RowFilter = "DocumentNumber = '" & fStr & " - " & MyNewRow("EngineeringDashNumber") & "'"
                                'Try : .RowFilter = "DocumentNumber = '" & str & " - " & MyRow.Item(1) & " - " & MyRow.Item(2) & "'"
                            Catch ex As Exception : MessageBox.Show(ex.ToString)
                            End Try
                            .RowStateFilter = DataViewRowState.CurrentRows
                            .Sort = "DocumentNumber"
                        End With

                        Dim pn As DataRowView = EcPniDV.Item(0)
                        Dim NewRowE045SubTbl As DataRow = SqlDaComp.DataSet11.E045SubTable.NewRow
                        'Dim num As String = NewRowE045ECPNI.Item(0)
                        NewRowE045SubTbl("EngineeringChangePartNumberInputNumber") = pn.Item(0)
                        NewRowE045SubTbl("EngineeringChangeNumber") = ecoID
                        NewRowE045SubTbl("DocRevision") = MyNewRow("EngineeringRevisionCode")
                        SqlDaComp.DataSet11.E045SubTable.Rows.Add(NewRowE045SubTbl)

                    End If

                End If
            Next

            If UpdateResponse = MsgBoxResult.Ok Or AddResponse = MsgBoxResult.Ok Then
                ecoID = Nothing

                Dim frm As frmMain = Me.FindForm() : frm.TabControl1.SelectedTab = frm.tpE037ECO

                If SqlDaComp.SqlConn.ConnectionString.ToString = "" Then
                    SqlDaComp.SqlConn.ConnectionString = words
                End If

                Try : SqlDaComp.DaE024ItmMstr.Update(SqlDaComp.DataSet11.E024ItemMasterInput)
                    SqlDaComp.DaE045SubTable.Update(SqlDaComp.DataSet11.E045SubTable)
                    SqlDaComp.DaE045EngChPrtNumIn.Update(SqlDaComp.DataSet11.E045EngineeringChangePartNumberInput)
                Catch dbcx As DBConcurrencyException
                    MessageBox.Show(dbcx.ToString) '   createMessage(dbcx, dtMod)
                Catch ex As Exception
                    MessageBox.Show("Update Failed", ex.GetType().ToString()) : MessageBox.Show(ex.ToString)
                End Try
                SqlDaComp.DataSet11.E024ItemMasterInput.Clear()
                SqlDaComp.DaE024ItmMstr.Fill(SqlDaComp.DataSet11.E024ItemMasterInput)

                SqlDaComp.DataSet11.E045SubTable.Clear()
                SqlDaComp.DaE045SubTable.Fill(SqlDaComp.DataSet11.E045SubTable)

            End If
            DataGrid1.Visible = False
        End Sub

        Private Sub miNewE044DRN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miNewE044DRN.Click

            SqlDaComp.DataSet11.E044DocumentReleaseNotice.Clear()
            SqlDaComp.DaE044DocRelNtc.Fill(SqlDaComp.DataSet11)
            Dim MyNewRow As DataRow ': Dim classResponse As MsgBoxResult
            MyNewRow = SqlDaComp.DataSet11.E044DocumentReleaseNotice.NewRow

            MyNewRow("Engineer") = UCase(SystemInformation.UserName)
            MyNewRow("EngineerDate") = UCase(Format(Now, "MMM/dd/yy").ToString)
            MyNewRow("EngineeringManager") = UCase(SystemInformation.UserName)
            MyNewRow("EngineeringManagerDate") = UCase(Format(Now, "MMM/dd/yy").ToString)

            SqlDaComp.DataSet11.E044DocumentReleaseNotice.Rows.Add(MyNewRow)
            Try : SqlDaComp.DaE044DocRelNtc.Update(SqlDaComp.DataSet11.E044DocumentReleaseNotice)
            Catch dbcx As DBConcurrencyException
                'createMessage(dbcx,  "E044DocumentReleaseNotice")
            Catch ex As Exception
                MessageBox.Show("Update Failed", ex.GetType().ToString())
                MessageBox.Show(MyNewRow.RowError)
            End Try
            ' ecoID = MyNewRow.Item(11).ToString
            SqlDaComp.DataSet11.E044DocumentReleaseNotice.Clear()
            SqlDaComp.DaE044DocRelNtc.Fill(SqlDaComp.DataSet11)
        End Sub

        Private Sub miUpDtE044DRNTbl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miUpDtE044DRNTbl.Click
            Try : SqlDaComp.DaE044DocRelNtc.Update(SqlDaComp.DataSet11.E044DocumentReleaseNotice)
            Catch dbcx As DBConcurrencyException
                'createMessage(dbcx, "E044DocumentReleaseNotice")
            Catch ex As Exception
                MessageBox.Show("Update Failed", ex.GetType().ToString())
            End Try
        End Sub

        Private Sub miUpdateRelDocsDs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miUpdateRelDocsDs.Click

            Dim dtMod As System.Data.DataTable = SqlDaComp.DataSet11.E044ReleasedDocuments.GetChanges
            If Not dtMod Is Nothing Then

                Try : SqlDaComp.DaE044RelDocs.Update(SqlDaComp.DataSet11.E044ReleasedDocuments)

                Catch dbcx As DBConcurrencyException
                    createMessage(dbcx, dtMod)
                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                    MessageBox.Show("Update Failed", ex.GetType().ToString())
                End Try
            End If

        End Sub

        Private Sub miEP0105_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miEP0105.Click
            Dim HelpFileName As String = pathStrToHandBook & "01 Product Design and Development.dwg"
            HlpDwg(HelpFileName, "EP-01-05 Engineering Review Board (1)", rOnly)
        End Sub

        Private Sub miEP0106_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miEP0106.Click
            Dim HelpFileName As String = pathStrToHandBook & "01 Product Design and Development.dwg"
            HlpDwg(HelpFileName, "EP-01-06 Product Phases (1)", rOnly)
        End Sub

        Private Sub miEP0201_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miEP0201.Click
            Dim HelpFileName As String = pathStrToHandBook & "02 Product and Documentation Identification.dwg"
            HlpDwg(HelpFileName, "EP-02-01 Document Numbering System (1)", rOnly)
        End Sub

        Private Sub miEP0202_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miEP0202.Click
            Dim HelpFileName As String = pathStrToHandBook & "02 Product and Documentation Identification.dwg"
            HlpDwg(HelpFileName, "EP-02-02 Document Number Assignment Logbook (1)", rOnly)
        End Sub

        Private Sub miEP0203_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miEP0203.Click
            Dim HelpFileName As String = pathStrToHandBook & "02 Product and Documentation Identification.dwg"
            HlpDwg(HelpFileName, "EP-02-03 Block Number Assignment (1)", rOnly)
        End Sub

        Private Sub miEP0608_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miEP0608.Click
            Dim HelpFileName As String = pathStrToHandBook & "06 Document Change Control.dwg"
            HlpDwg(HelpFileName, "EP-06-08 Change Control Board (1)", rOnly)
        End Sub

        Private Sub miEP0702_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miEP0702.Click
            Dim HelpFileName As String = pathStrToHandBook & "07 Document Control.dwg"
            HlpDwg(HelpFileName, "EP-07-02 Document Release (1)", rOnly)
        End Sub

        Private Sub miEP0604_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miEP0604.Click
            Dim HelpFileName As String = pathStrToHandBook & "06 Document Change Control.dwg"
            HlpDwg(HelpFileName, "EP-06-04 Engineering Change Procedure (1)", rOnly)
        End Sub

        Private Sub miRptAllDRN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miRptAllDRN.Click
            'Dim RepFrm As New frmReport
            'RepFrm.Show()
        End Sub

        Private Sub miClrDRN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miClrDRN.Click
            drnID = Nothing
            DataGrid6.DataSource = Nothing
            Dim frm As Form = Me.FindForm()
            frm.Text = "E044 Document Release Notice # has been cleared"
        End Sub


#End Region





    End Class

End Namespace
