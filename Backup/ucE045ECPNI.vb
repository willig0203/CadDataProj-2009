Option Explicit On 

Imports System.Windows.Forms
Imports System.Drawing

Imports rnsCadDataProj.nsMods


Namespace nsUserCtls

    Public Class ucE045ECPNI

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
        Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
        Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
        Friend WithEvents DataGrid2 As System.Windows.Forms.DataGrid
        Friend WithEvents cmE045EngChPNI As System.Windows.Forms.ContextMenu
        Friend WithEvents cmE045SubTbl As System.Windows.Forms.ContextMenu
        Friend WithEvents miE045SubTbl_Update As System.Windows.Forms.MenuItem
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.DataGrid1 = New System.Windows.Forms.DataGrid
            Me.Splitter1 = New System.Windows.Forms.Splitter
            Me.DataGrid2 = New System.Windows.Forms.DataGrid
            Me.cmE045EngChPNI = New System.Windows.Forms.ContextMenu
            Me.cmE045SubTbl = New System.Windows.Forms.ContextMenu
            Me.miE045SubTbl_Update = New System.Windows.Forms.MenuItem
            CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'DataGrid1
            '
            Me.DataGrid1.ContextMenu = Me.cmE045EngChPNI
            Me.DataGrid1.DataMember = ""
            Me.DataGrid1.Dock = System.Windows.Forms.DockStyle.Top
            Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
            Me.DataGrid1.Location = New System.Drawing.Point(0, 0)
            Me.DataGrid1.Name = "DataGrid1"
            Me.DataGrid1.Size = New System.Drawing.Size(800, 264)
            Me.DataGrid1.TabIndex = 0
            '
            'Splitter1
            '
            Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Splitter1.Location = New System.Drawing.Point(0, 264)
            Me.Splitter1.Name = "Splitter1"
            Me.Splitter1.Size = New System.Drawing.Size(800, 3)
            Me.Splitter1.TabIndex = 1
            Me.Splitter1.TabStop = False
            '
            'DataGrid2
            '
            Me.DataGrid2.ContextMenu = Me.cmE045SubTbl
            Me.DataGrid2.DataMember = ""
            Me.DataGrid2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.DataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText
            Me.DataGrid2.Location = New System.Drawing.Point(0, 267)
            Me.DataGrid2.Name = "DataGrid2"
            Me.DataGrid2.Size = New System.Drawing.Size(800, 109)
            Me.DataGrid2.TabIndex = 2
            '
            'cmE045SubTbl
            '
            Me.cmE045SubTbl.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miE045SubTbl_Update})
            '
            'miE045SubTbl_Update
            '
            Me.miE045SubTbl_Update.Index = 0
            Me.miE045SubTbl_Update.Text = "Update E045SubTbl Data Source"
            '
            'ucE045ECPNI
            '
            Me.Controls.Add(Me.DataGrid2)
            Me.Controls.Add(Me.Splitter1)
            Me.Controls.Add(Me.DataGrid1)
            Me.Name = "ucE045ECPNI"
            Me.Size = New System.Drawing.Size(800, 376)
            CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private Sub ucE045ECPNI_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

            If SqlDaComp.DataSet11.E045EngineeringChangePartNumberInput.Count = 0 Then
                SqlDaComp.SqlConn.ConnectionString = words
                SqlDaComp.DaE045EngChPrtNumIn.Fill(SqlDaComp.DataSet11.E045EngineeringChangePartNumberInput)
            End If
            If SqlDaComp.DataSet11.E045SubTable.Count = 0 Then
               
                SqlDaComp.SqlConn.ConnectionString = words
                SqlDaComp.DaE045SubTable.Fill(SqlDaComp.DataSet11.E045SubTable)
            End If

            DataGrid1.DataSource = SqlDaComp.DataSet11.E045EngineeringChangePartNumberInput
            DataGrid2.DataSource = SqlDaComp.DataSet11.E045SubTable

        End Sub

        Dim dvE045SBTBL As DataView
        Dim E045SBTBLtblsAdded As Boolean
        Dim E045SBTBLts As New DataGridTableStyle

        Private Sub DataGrid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.DoubleClick

            If E045SBTBLtblsAdded = False Then
                E045SBTBLts.MappingName = "E045SubTable"
                Dim TextCol1 As New DataGridTextBoxColumn
                TextCol1.MappingName = "DocRevision"
                TextCol1.HeaderText = "DocRevision"
                TextCol1.Width = 50
                E045SBTBLts.GridColumnStyles.Add(TextCol1)
                Dim TextCol2 As New DataGridTextBoxColumn
                TextCol2.MappingName = "EngineeringChangeNumber"
                TextCol2.HeaderText = "EngineeringChangeNumber"
                TextCol2.Width = 250
                E045SBTBLts.GridColumnStyles.Add(TextCol2)
                Dim TextCol3 As New DataGridTextBoxColumn
                TextCol3.MappingName = "PendingDate"
                TextCol3.HeaderText = "PendingDate"
                TextCol3.Width = 75
                E045SBTBLts.GridColumnStyles.Add(TextCol3)
                Dim TextCol4 As New DataGridTextBoxColumn
                TextCol4.MappingName = "CCBStatus"
                TextCol4.HeaderText = "CCBStatus"
                TextCol4.Width = 75
                E045SBTBLts.GridColumnStyles.Add(TextCol4)

                Dim TextCol5 As New DataGridTextBoxColumn
                TextCol5.MappingName = "EngineeringChangeReleaseDate"
                TextCol5.HeaderText = "EngineeringChangeReleaseDate"
                TextCol5.Width = 75
                E045SBTBLts.GridColumnStyles.Add(TextCol5)

                Dim TextCol6 As New DataGridTextBoxColumn
                TextCol6.MappingName = "IncorporationDate"
                TextCol6.HeaderText = "IncorporationDate"
                TextCol6.Width = 75
                E045SBTBLts.GridColumnStyles.Add(TextCol6)

                Dim TextCol7 As New DataGridTextBoxColumn
                TextCol7.MappingName = "NoteComments"
                TextCol7.HeaderText = "NoteComments"
                TextCol7.Width = 75
                E045SBTBLts.GridColumnStyles.Add(TextCol7)


                E045SBTBLts.AlternatingBackColor = Color.LightBlue
                E045SBTBLtblsAdded = True
            End If
            If DataGrid2.TableStyles.Contains("E045SubTable") = False Then DataGrid2.TableStyles.Add(E045SBTBLts)
            dvE045SBTBL = New DataView
        
            SqlDaComp.SqlConn.ConnectionString = words
            SqlDaComp.DataSet11.E045SubTable.Clear()
            SqlDaComp.DaE045SubTable.Fill(SqlDaComp.DataSet11.E045SubTable)

            With dvE045SBTBL
                .Table = SqlDaComp.DataSet11.Tables("E045SubTable")

                Dim Str As String = DataGrid1.Item(DataGrid1.CurrentRowIndex, 0) 'EngineeringChangePartNumberInputNumber

                'Str = Str.Replace(".dwg", "") : Str = Str.Replace(".DWG", "") ' Should upper case this and then strip it
                Str = "EngineeringChangePartNumberInputNumber = '" & Str & "'"
                Try : .RowFilter = Str
                Catch ex As Exception : MessageBox.Show(ex.ToString)
                End Try
                '.RowStateFilter = DataViewRowState.ModifiedCurrent
                '.Sort = "CompanyName DESC"
            End With
            DataGrid2.DataSource = dvE045SBTBL
            echpniID = DataGrid1.Item(DataGrid1.CurrentRowIndex, 0)
            Dim frm As Form = Me.FindForm()
            frm.Text = "E045 Engineering Chng / Part Number Input # : " & echpniID
            'crnID = Nothing
            'bomID = Nothing
            'ecoID = Nothing
        End Sub


        Private Sub miE045SubTbl_Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miE045SubTbl_Update.Click
            'SqlDaComp.SqlConn.ConnectionString = words
            'SqlDaComp.DataSet11.E045SubTable.Clear()
            SqlDaComp.DaE045SubTable.Update(SqlDaComp.DataSet11.E045SubTable)
        End Sub


    End Class


End Namespace
