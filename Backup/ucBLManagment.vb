Option Explicit On 

'Imports System
'Imports System.Type
'Imports System.Windows.Forms
'Imports System.Data
'Imports System.Data.Common
'Imports Autodesk.AutoCAD.Runtime
'Imports Autodesk.AutoCAD.Runtime.Converter
'Imports System.ComponentModel
'Imports System.Drawing
'Imports System.Configuration
'Imports Autodesk.AutoCAD.EditorInput
'Imports Autodesk.AutoCAD.ApplicationServices
'Imports Autodesk.AutoCAD.DatabaseServices
'Imports Autodesk.AutoCAD.Geometry
'Imports Autodesk.AutoCAD.PlottingServices
'Imports Autodesk.AutoCAD.Geometry.Point3d

Imports rnsCadDataProj.nsMods
Imports rnsCadDataProj.nsForms.frmMain

Namespace nsUserCtls

    Public Class ucBLManagment
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
        Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
        Friend WithEvents E002CBD As System.Windows.Forms.TabPage
        Friend WithEvents E003AsBlt As System.Windows.Forms.TabPage
        Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
        Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
        Friend WithEvents DataGrid2 As System.Windows.Forms.DataGrid
        Friend WithEvents DataGrid3 As System.Windows.Forms.DataGrid
        Friend WithEvents Splitter2 As System.Windows.Forms.Splitter
        Friend WithEvents DataGrid4 As System.Windows.Forms.DataGrid
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.TabControl1 = New System.Windows.Forms.TabControl
            Me.E002CBD = New System.Windows.Forms.TabPage
            Me.DataGrid2 = New System.Windows.Forms.DataGrid
            Me.Splitter1 = New System.Windows.Forms.Splitter
            Me.DataGrid1 = New System.Windows.Forms.DataGrid
            Me.E003AsBlt = New System.Windows.Forms.TabPage
            Me.DataGrid4 = New System.Windows.Forms.DataGrid
            Me.Splitter2 = New System.Windows.Forms.Splitter
            Me.DataGrid3 = New System.Windows.Forms.DataGrid
            Me.TabControl1.SuspendLayout()
            Me.E002CBD.SuspendLayout()
            CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.E003AsBlt.SuspendLayout()
            CType(Me.DataGrid4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DataGrid3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'TabControl1
            '
            Me.TabControl1.Controls.Add(Me.E002CBD)
            Me.TabControl1.Controls.Add(Me.E003AsBlt)
            Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControl1.Location = New System.Drawing.Point(0, 0)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(432, 368)
            Me.TabControl1.TabIndex = 0
            '
            'E002CBD
            '
            Me.E002CBD.Controls.Add(Me.DataGrid2)
            Me.E002CBD.Controls.Add(Me.Splitter1)
            Me.E002CBD.Controls.Add(Me.DataGrid1)
            Me.E002CBD.Location = New System.Drawing.Point(4, 22)
            Me.E002CBD.Name = "E002CBD"
            Me.E002CBD.Size = New System.Drawing.Size(424, 342)
            Me.E002CBD.TabIndex = 0
            Me.E002CBD.Text = "E002 CBD"
            '
            'DataGrid2
            '
            Me.DataGrid2.DataMember = ""
            Me.DataGrid2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.DataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText
            Me.DataGrid2.Location = New System.Drawing.Point(0, 187)
            Me.DataGrid2.Name = "DataGrid2"
            Me.DataGrid2.Size = New System.Drawing.Size(424, 155)
            Me.DataGrid2.TabIndex = 2
            '
            'Splitter1
            '
            Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Splitter1.Location = New System.Drawing.Point(0, 184)
            Me.Splitter1.Name = "Splitter1"
            Me.Splitter1.Size = New System.Drawing.Size(424, 3)
            Me.Splitter1.TabIndex = 1
            Me.Splitter1.TabStop = False
            '
            'DataGrid1
            '
            Me.DataGrid1.DataMember = ""
            Me.DataGrid1.Dock = System.Windows.Forms.DockStyle.Top
            Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
            Me.DataGrid1.Location = New System.Drawing.Point(0, 0)
            Me.DataGrid1.Name = "DataGrid1"
            Me.DataGrid1.Size = New System.Drawing.Size(424, 184)
            Me.DataGrid1.TabIndex = 0
            '
            'E003AsBlt
            '
            Me.E003AsBlt.Controls.Add(Me.DataGrid4)
            Me.E003AsBlt.Controls.Add(Me.Splitter2)
            Me.E003AsBlt.Controls.Add(Me.DataGrid3)
            Me.E003AsBlt.Location = New System.Drawing.Point(4, 22)
            Me.E003AsBlt.Name = "E003AsBlt"
            Me.E003AsBlt.Size = New System.Drawing.Size(424, 342)
            Me.E003AsBlt.TabIndex = 1
            Me.E003AsBlt.Text = "E003 As Blt"
            '
            'DataGrid4
            '
            Me.DataGrid4.DataMember = ""
            Me.DataGrid4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.DataGrid4.HeaderForeColor = System.Drawing.SystemColors.ControlText
            Me.DataGrid4.Location = New System.Drawing.Point(0, 187)
            Me.DataGrid4.Name = "DataGrid4"
            Me.DataGrid4.Size = New System.Drawing.Size(424, 155)
            Me.DataGrid4.TabIndex = 2
            '
            'Splitter2
            '
            Me.Splitter2.Dock = System.Windows.Forms.DockStyle.Top
            Me.Splitter2.Location = New System.Drawing.Point(0, 184)
            Me.Splitter2.Name = "Splitter2"
            Me.Splitter2.Size = New System.Drawing.Size(424, 3)
            Me.Splitter2.TabIndex = 1
            Me.Splitter2.TabStop = False
            '
            'DataGrid3
            '
            Me.DataGrid3.DataMember = ""
            Me.DataGrid3.Dock = System.Windows.Forms.DockStyle.Top
            Me.DataGrid3.HeaderForeColor = System.Drawing.SystemColors.ControlText
            Me.DataGrid3.Location = New System.Drawing.Point(0, 0)
            Me.DataGrid3.Name = "DataGrid3"
            Me.DataGrid3.Size = New System.Drawing.Size(424, 184)
            Me.DataGrid3.TabIndex = 0
            '
            'ucBLManagment
            '
            Me.Controls.Add(Me.TabControl1)
            Me.Name = "ucBLManagment"
            Me.Size = New System.Drawing.Size(432, 368)
            Me.TabControl1.ResumeLayout(False)
            Me.E002CBD.ResumeLayout(False)
            CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.E003AsBlt.ResumeLayout(False)
            CType(Me.DataGrid4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DataGrid3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private Sub ucBaseLineMan_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

            If SqlDaComp.DataSet11.E002ConfigurationBaselineDocument.Count = 0 Or SqlDaComp.DataSet11.E003AsBuiltConfigurationRecord.Count = 0 Then
               
                SqlDaComp.SqlConn.ConnectionString = words

                SqlDaComp.DaE002ConBaseDoc.Fill(SqlDaComp.DataSet11.E002ConfigurationBaselineDocument)
                DataGrid1.DataSource = SqlDaComp.DataSet11.E002ConfigurationBaselineDocument
                SqlDaComp.DaE002CBDSubTable.Fill(SqlDaComp.DataSet11.E002CBDSubTable)

                DataGrid2.DataSource = SqlDaComp.DataSet11.E002CBDSubTable

                SqlDaComp.DaE003AsBltConRec.Fill(SqlDaComp.DataSet11.E003AsBuiltConfigurationRecord)
                DataGrid3.DataSource = SqlDaComp.DataSet11.E003AsBuiltConfigurationRecord
                SqlDaComp.DaE003AsBltSubTable.Fill(SqlDaComp.DataSet11.E003AsBltSubTbl)

                DataGrid4.DataSource = SqlDaComp.DataSet11.E003AsBltSubTbl
            End If

        End Sub


    End Class


End Namespace