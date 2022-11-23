Option Explicit On 

Imports System.Windows.Forms
Imports System.ComponentModel

Imports Autodesk.AutoCAD.ApplicationServices
Imports Autodesk.AutoCAD.DatabaseServices

Imports rnsCadDataProj.nsMods


Namespace nsForms

    Public Class CadDataProjForm

        Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

        Public Sub New()
            MyBase.New()
            'This call is required by the Windows Form Designer.
            InitializeComponent()
            'Add any initialization after the InitializeComponent() call

        End Sub

        'Form overrides dispose to clean up the component list.
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
       
        Public Shared WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
       
        Public Shared WithEvents TabControl3 As System.Windows.Forms.TabControl
        Public Shared WithEvents tpE044DRN As System.Windows.Forms.TabPage
        Public Shared WithEvents tpE046CRN As System.Windows.Forms.TabPage
        Public Shared WithEvents tpE025BOM As System.Windows.Forms.TabPage
        Public Shared WithEvents tpBaseLineMan As System.Windows.Forms.TabPage
        Public Shared WithEvents tpTitleBlockList As System.Windows.Forms.TabPage
        Public Shared WithEvents tpArcUtil As System.Windows.Forms.TabPage
        Public Shared WithEvents tpOther As System.Windows.Forms.TabPage
        Public Shared WithEvents tpE037EngChng As System.Windows.Forms.TabPage


        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.TabControl3 = New System.Windows.Forms.TabControl
            Me.tpE044DRN = New System.Windows.Forms.TabPage
            Me.tpE046CRN = New System.Windows.Forms.TabPage
            Me.tpE037EngChng = New System.Windows.Forms.TabPage
            Me.tpE025BOM = New System.Windows.Forms.TabPage
            Me.tpBaseLineMan = New System.Windows.Forms.TabPage
            Me.tpTitleBlockList = New System.Windows.Forms.TabPage
            Me.tpArcUtil = New System.Windows.Forms.TabPage
            Me.tpOther = New System.Windows.Forms.TabPage
            Me.TabControl3.SuspendLayout()
            Me.SuspendLayout()
            '
            'TabControl3
            '
            Me.TabControl3.Controls.Add(Me.tpE044DRN)
            Me.TabControl3.Controls.Add(Me.tpE046CRN)
            Me.TabControl3.Controls.Add(Me.tpE037EngChng)
            Me.TabControl3.Controls.Add(Me.tpE025BOM)
            Me.TabControl3.Controls.Add(Me.tpBaseLineMan)
            Me.TabControl3.Controls.Add(Me.tpTitleBlockList)
            Me.TabControl3.Controls.Add(Me.tpArcUtil)
            Me.TabControl3.Controls.Add(Me.tpOther)
            Me.TabControl3.Location = New System.Drawing.Point(32, 56)
            Me.TabControl3.Name = "TabControl3"
            Me.TabControl3.SelectedIndex = 0
            Me.TabControl3.Size = New System.Drawing.Size(800, 100)
            Me.TabControl3.TabIndex = 0
            '
            'tpE044DRN
            '
            Me.tpE044DRN.Location = New System.Drawing.Point(4, 22)
            Me.tpE044DRN.Name = "tpE044DRN"
            Me.tpE044DRN.Size = New System.Drawing.Size(792, 74)
            Me.tpE044DRN.TabIndex = 0
            Me.tpE044DRN.Text = "E044DRN"
            '
            'tpE046CRN
            '
            Me.tpE046CRN.Location = New System.Drawing.Point(4, 22)
            Me.tpE046CRN.Name = "tpE046CRN"
            Me.tpE046CRN.Size = New System.Drawing.Size(792, 74)
            Me.tpE046CRN.TabIndex = 1
            Me.tpE046CRN.Text = "E046CRN"
            '
            'tpE037EngChng
            '
            Me.tpE037EngChng.Location = New System.Drawing.Point(4, 22)
            Me.tpE037EngChng.Name = "tpE037EngChng"
            Me.tpE037EngChng.Size = New System.Drawing.Size(792, 74)
            Me.tpE037EngChng.TabIndex = 2
            Me.tpE037EngChng.Text = "E037EngChng"
            '
            'tpE025BOM
            '
            Me.tpE025BOM.Location = New System.Drawing.Point(4, 22)
            Me.tpE025BOM.Name = "tpE025BOM"
            Me.tpE025BOM.Size = New System.Drawing.Size(792, 74)
            Me.tpE025BOM.TabIndex = 3
            Me.tpE025BOM.Text = "E025BOM"
            '
            'tpBaseLineMan
            '
            Me.tpBaseLineMan.Location = New System.Drawing.Point(4, 22)
            Me.tpBaseLineMan.Name = "tpBaseLineMan"
            Me.tpBaseLineMan.Size = New System.Drawing.Size(792, 74)
            Me.tpBaseLineMan.TabIndex = 4
            Me.tpBaseLineMan.Text = "BaseLineMan"
            '
            'tpTitleBlockList
            '
            Me.tpTitleBlockList.Location = New System.Drawing.Point(4, 22)
            Me.tpTitleBlockList.Name = "tpTitleBlockList"
            Me.tpTitleBlockList.Size = New System.Drawing.Size(792, 74)
            Me.tpTitleBlockList.TabIndex = 5
            Me.tpTitleBlockList.Text = "TitleBlockList"
            '
            'tpArcUtil
            '
            Me.tpArcUtil.Location = New System.Drawing.Point(4, 22)
            Me.tpArcUtil.Name = "tpArcUtil"
            Me.tpArcUtil.Size = New System.Drawing.Size(792, 74)
            Me.tpArcUtil.TabIndex = 6
            Me.tpArcUtil.Text = "ArcUtil"
            '
            'tpOther
            '
            Me.tpOther.Location = New System.Drawing.Point(4, 22)
            Me.tpOther.Name = "tpOther"
            Me.tpOther.Size = New System.Drawing.Size(792, 74)
            Me.tpOther.TabIndex = 7
            Me.tpOther.Text = "Other"
            '
            'CadDataProjForm
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(896, 638)
            Me.Controls.Add(Me.TabControl3)
            Me.Name = "CadDataProjForm"
            Me.Text = "Cad Data Proj"
            Me.TabControl3.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

#End Region

       
        Private Sub CadDataProjForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            'Dim file As New System.IO.StreamReader(".\" & "\New Text Document.txt")
            'Dim adoDBConn As OleDb.OleDbConnection
            'adoDBConn.open("file name="H:\NetCad2006\DataLinks" & "\DBTest.txt")
            TabControl3.Dock = DockStyle.Fill

            ' user controls
            ucE044DocReleaseNotice.Dock = System.Windows.Forms.DockStyle.Fill : tpE044DRN.Controls.Add(ucE044DocReleaseNotice)
            ucE046CopyRequest.Dock = System.Windows.Forms.DockStyle.Fill : tpE046CRN.Controls.Add(ucE046CopyRequest)
            ucE037EngineeringChange.Dock = System.Windows.Forms.DockStyle.Fill : tpE037EngChng.Controls.Add(ucE037EngineeringChange)
            ucE025BomItmMstr.Dock = System.Windows.Forms.DockStyle.Fill : tpE025BOM.Controls.Add(ucE025BomItmMstr)
            ucBLManagment.Dock = System.Windows.Forms.DockStyle.Fill : tpBaseLineMan.Controls.Add(ucBLManagment)
            ucDwgLstTblst.Dock = System.Windows.Forms.DockStyle.Fill : tpTitleBlockList.Controls.Add(ucDwgLstTblst)
            ucArcUtility.Dock = System.Windows.Forms.DockStyle.None : tpArcUtil.Controls.Add(ucArcUtility)
            ucOther.Dock = System.Windows.Forms.DockStyle.None : tpOther.Controls.Add(ucOther)


        End Sub

       

    End Class


End Namespace

