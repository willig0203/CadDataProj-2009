Option Explicit On 

Imports System.Windows.Forms
Imports System.Drawing

Imports rnsCadDataProj.nsForms.frmMain
Imports rnsCadDataProj.nsMods

Namespace nsUserCtls

    Public Class ucE037ECO
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

        Friend WithEvents cmnuE037ECO As System.Windows.Forms.ContextMenu
        Friend WithEvents miUpdateE037ECO As System.Windows.Forms.MenuItem
        Friend WithEvents miE037ECOHlp As System.Windows.Forms.MenuItem
        Friend WithEvents miEP0604ECOhlp As System.Windows.Forms.MenuItem
        Friend WithEvents dgE037EngChng As System.Windows.Forms.DataGrid
        Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
        Friend WithEvents dgE037EngChngDV As System.Windows.Forms.DataGrid
        Friend WithEvents miNewE037ECO As System.Windows.Forms.MenuItem
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.cmnuE037ECO = New System.Windows.Forms.ContextMenu
            Me.miNewE037ECO = New System.Windows.Forms.MenuItem
            Me.miUpdateE037ECO = New System.Windows.Forms.MenuItem
            Me.miE037ECOHlp = New System.Windows.Forms.MenuItem
            Me.miEP0604ECOhlp = New System.Windows.Forms.MenuItem
            Me.dgE037EngChng = New System.Windows.Forms.DataGrid
            Me.Splitter1 = New System.Windows.Forms.Splitter
            Me.dgE037EngChngDV = New System.Windows.Forms.DataGrid
            CType(Me.dgE037EngChng, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgE037EngChngDV, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'cmnuE037ECO
            '
            Me.cmnuE037ECO.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miNewE037ECO, Me.miUpdateE037ECO, Me.miE037ECOHlp})
            '
            'miNewE037ECO
            '
            Me.miNewE037ECO.Index = 0
            Me.miNewE037ECO.Text = "New E037 ECO"
            '
            'miUpdateE037ECO
            '
            Me.miUpdateE037ECO.Index = 1
            Me.miUpdateE037ECO.Text = "Update E037 ECO Tbl"
            '
            'miE037ECOHlp
            '
            Me.miE037ECOHlp.Index = 2
            Me.miE037ECOHlp.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miEP0604ECOhlp})
            Me.miE037ECOHlp.Text = "Eng Proc Help"
            '
            'miEP0604ECOhlp
            '
            Me.miEP0604ECOhlp.Index = 0
            Me.miEP0604ECOhlp.Text = "EP-06-04 Engineering Change Procedure"
            '
            'dgE037EngChng
            '
            Me.dgE037EngChng.ContextMenu = Me.cmnuE037ECO
            Me.dgE037EngChng.DataMember = ""
            Me.dgE037EngChng.Dock = System.Windows.Forms.DockStyle.Top
            Me.dgE037EngChng.HeaderForeColor = System.Drawing.SystemColors.ControlText
            Me.dgE037EngChng.Location = New System.Drawing.Point(0, 0)
            Me.dgE037EngChng.Name = "dgE037EngChng"
            Me.dgE037EngChng.Size = New System.Drawing.Size(480, 224)
            Me.dgE037EngChng.TabIndex = 1
            '
            'Splitter1
            '
            Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Splitter1.Location = New System.Drawing.Point(0, 224)
            Me.Splitter1.Name = "Splitter1"
            Me.Splitter1.Size = New System.Drawing.Size(480, 3)
            Me.Splitter1.TabIndex = 2
            Me.Splitter1.TabStop = False
            '
            'dgE037EngChngDV
            '
            Me.dgE037EngChngDV.DataMember = ""
            Me.dgE037EngChngDV.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgE037EngChngDV.HeaderForeColor = System.Drawing.SystemColors.ControlText
            Me.dgE037EngChngDV.Location = New System.Drawing.Point(0, 227)
            Me.dgE037EngChngDV.Name = "dgE037EngChngDV"
            Me.dgE037EngChngDV.Size = New System.Drawing.Size(480, 213)
            Me.dgE037EngChngDV.TabIndex = 3
            '
            'ucE037ECO
            '
            Me.Controls.Add(Me.dgE037EngChngDV)
            Me.Controls.Add(Me.Splitter1)
            Me.Controls.Add(Me.dgE037EngChng)
            Me.Name = "ucE037ECO"
            Me.Size = New System.Drawing.Size(480, 440)
            CType(Me.dgE037EngChng, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgE037EngChngDV, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private Sub ucE037ECO_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            If SqlDaComp.DataSet11.E037EngineeringChange.Count = 0 Or SqlDaComp.DataSet11.E044ReleasedDocuments.Count = 0 Then
               
                SqlDaComp.SqlConn.ConnectionString = words
                SqlDaComp.DaE037EngChng.Fill(SqlDaComp.DataSet11.E037EngineeringChange)
                SqlDaComp.DaE044RelDocs.Fill(SqlDaComp.DataSet11.E044ReleasedDocuments)
            End If
            dgE037EngChng.DataSource = SqlDaComp.DataSet11.E037EngineeringChange
            dgE037EngChngDV.DataSource = Nothing
        End Sub

        Dim dvE037ECO As DataView
        Dim E037ECOtblsAdded As Boolean
        Dim E037ECOts As New DataGridTableStyle

        Private Sub dgE037EngChng_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgE037EngChng.DoubleClick
            If E037ECOtblsAdded = False Then
                E037ECOts.MappingName = "E044ReleasedDocuments"
                Dim TextCol1 As New DataGridTextBoxColumn
                TextCol1.MappingName = "RevisionBlock"
                TextCol1.HeaderText = "Rev"
                TextCol1.Width = 50
                E037ECOts.GridColumnStyles.Add(TextCol1)
                Dim TextCol2 As New DataGridTextBoxColumn
                TextCol2.MappingName = "FileName"
                TextCol2.HeaderText = "Dwg"
                TextCol2.Width = 250
                E037ECOts.GridColumnStyles.Add(TextCol2)
                Dim TextCol3 As New DataGridTextBoxColumn
                TextCol3.MappingName = "Layout"
                TextCol3.HeaderText = "Tab"
                TextCol3.Width = 75
                E037ECOts.GridColumnStyles.Add(TextCol3)
                Dim TextCol4 As New DataGridTextBoxColumn
                TextCol4.MappingName = "ControlStamp"
                TextCol4.HeaderText = "Stamp"
                TextCol4.Width = 75
                E037ECOts.GridColumnStyles.Add(TextCol4)
                E037ECOts.AlternatingBackColor = Color.LightBlue
                E037ECOtblsAdded = True
            End If
            If dgE037EngChngDV.TableStyles.Contains("E044ReleasedDocuments") = False Then dgE037EngChngDV.TableStyles.Add(E037ECOts)
            dvE037ECO = New DataView
            With dvE037ECO
                .Table = SqlDaComp.DataSet11.Tables("E044ReleasedDocuments")
                Dim FltrStr As String = "DocumentReleaseNoticeNumber = '" & Convert.ToInt32(dgE037EngChng.Item(dgE037EngChng.CurrentRowIndex, 9)) & "'"
                Try : .RowFilter = FltrStr
                Catch ex As Exception : MessageBox.Show(ex.ToString)
                End Try
                '.RowStateFilter = DataViewRowState.ModifiedCurrent
                '.Sort = "CompanyName DESC"
            End With
            dgE037EngChngDV.DataSource = dvE037ECO
            ecoID = dgE037EngChng.Item(dgE037EngChng.CurrentRowIndex, 0)
            Dim frm As Form = Me.FindForm()
            frm.Text = "E037 Engineering Change Order # : " & ecoID
            drnID = Nothing
            bomID = Nothing
            crnID = Nothing
        End Sub

        Private Sub miUpdateE037ECO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miUpdateE037ECO.Click
            Try : SqlDaComp.DaE037EngChng.Update(SqlDaComp.DataSet11.E037EngineeringChange)
            Catch dbcx As DBConcurrencyException
                'createMessage(dbcx, "E037EngineeringChange")
            Catch ex As Exception
                MessageBox.Show("Update Failed", ex.GetType().ToString())
            End Try
        End Sub

        Private Sub miEP0604_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            ' Dim HelpFileName As String = pathStr & "06 Document Change Control.dwg"
            ' HlpDwg(HelpFileName, "EP-06-04 Engineering Change Procedure (1)", rOnly)
        End Sub

        Private Sub miEP0604ECOhlp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miEP0604ECOhlp.Click
            Dim HelpFileName As String = pathStrToHandBook & "06 Document Change Control.dwg"
            HlpDwg(HelpFileName, "EP-06-04 Engineering Change Procedure (1)", rOnly)
        End Sub

        Public Shared Sub NewE037ECO(ByVal drnID As String)      'ByVal clsofChng As String
            chdlg.ShowDialog()

            If SqlDaComp.DataSet11.E037EngineeringChange.Count = 0 Then
                SqlDaComp.SqlConn.ConnectionString = words
                SqlDaComp.DataSet11.E037EngineeringChange.Clear()
                SqlDaComp.DaE037EngChng.Fill(SqlDaComp.DataSet11.E037EngineeringChange)
            End If

            Dim MyNewRow As DataRow ': Dim classResponse As MsgBoxResult
            MyNewRow = SqlDaComp.DataSet11.E037EngineeringChange.NewRow

            MyNewRow("AffectedDocuments") = drnID 'ucE044DRN.dgE044DRN.Item(dgE044DRN.CurrentRowIndex, 1) 'e044DrN num

            MyNewRow("Originator") = UCase(SystemInformation.UserName)
            MyNewRow("OriginatorDate") = UCase(Format(Now, "MMM/dd/yy").ToString)
            MyNewRow("OriginatorDepartment") = "CAD"
            MyNewRow("ClassofChange") = chdlg.ChngType

            ' eng ch number cannot be null
            SqlDaComp.DataSet11.E037EngineeringChange.Rows.Add(MyNewRow)
            Try : SqlDaComp.DaE037EngChng.Update(SqlDaComp.DataSet11.E037EngineeringChange)
            Catch dbcx As DBConcurrencyException
                'createMessage(dbcx, "E037EngineeringChange")
            Catch ex As Exception
                MessageBox.Show(MyNewRow.RowError)
                MessageBox.Show("Update Failed", ex.GetType().ToString())
            End Try
            ecoID = MyNewRow.Item(0).ToString
            SqlDaComp.DataSet11.E037EngineeringChange.Clear()
            SqlDaComp.DaE037EngChng.Fill(SqlDaComp.DataSet11.E037EngineeringChange)
        End Sub

        Private Sub miNewE037ECO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miNewE037ECO.Click
            MessageBox.Show("Disabled")
            'NewE037ECO()
        End Sub
    End Class


End Namespace
