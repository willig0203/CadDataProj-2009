Option Explicit On 

Imports System.Windows.Forms
Imports System.ComponentModel

Imports Autodesk.AutoCAD.ApplicationServices
Imports Autodesk.AutoCAD.DatabaseServices

Imports rnsCadDataProj.nsMods


Namespace nsForms

    Public Class frmMain

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


        Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
        Friend WithEvents tpE046CRN As System.Windows.Forms.TabPage
        Friend WithEvents tpOther As System.Windows.Forms.TabPage
        Friend WithEvents tpE044DRN As System.Windows.Forms.TabPage
        Friend WithEvents tpE025BOMItmMstr As System.Windows.Forms.TabPage
        Friend WithEvents tpBLManagment As System.Windows.Forms.TabPage
        Friend WithEvents tpE037ECO As System.Windows.Forms.TabPage
        Friend WithEvents tpDwgLstTbLst As System.Windows.Forms.TabPage
        Friend WithEvents tpE045ECPNI As System.Windows.Forms.TabPage
        Friend WithEvents tpE001PIN As System.Windows.Forms.TabPage


        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.TabControl1 = New System.Windows.Forms.TabControl
            Me.tpE001PIN = New System.Windows.Forms.TabPage
            Me.tpE044DRN = New System.Windows.Forms.TabPage
            Me.tpE045ECPNI = New System.Windows.Forms.TabPage
            Me.tpE046CRN = New System.Windows.Forms.TabPage
            Me.tpE037ECO = New System.Windows.Forms.TabPage
            Me.tpE025BOMItmMstr = New System.Windows.Forms.TabPage
            Me.tpBLManagment = New System.Windows.Forms.TabPage
            Me.tpDwgLstTbLst = New System.Windows.Forms.TabPage
            Me.tpOther = New System.Windows.Forms.TabPage
            Me.TabControl1.SuspendLayout()
            Me.SuspendLayout()
            '
            'TabControl1
            '
            Me.TabControl1.Controls.Add(Me.tpDwgLstTbLst)
            Me.TabControl1.Controls.Add(Me.tpE001PIN)
            Me.TabControl1.Controls.Add(Me.tpE044DRN)
            Me.TabControl1.Controls.Add(Me.tpE045ECPNI)
            Me.TabControl1.Controls.Add(Me.tpE046CRN)
            Me.TabControl1.Controls.Add(Me.tpE037ECO)
            Me.TabControl1.Controls.Add(Me.tpE025BOMItmMstr)
            Me.TabControl1.Controls.Add(Me.tpBLManagment)
            Me.TabControl1.Controls.Add(Me.tpOther)
            Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControl1.Location = New System.Drawing.Point(0, 0)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(896, 638)
            Me.TabControl1.TabIndex = 0
            '
            'tpE001PIN
            '
            Me.tpE001PIN.Location = New System.Drawing.Point(4, 22)
            Me.tpE001PIN.Name = "tpE001PIN"
            Me.tpE001PIN.Size = New System.Drawing.Size(888, 612)
            Me.tpE001PIN.TabIndex = 8
            Me.tpE001PIN.Text = "E001 Prod Intro"
            '
            'tpE044DRN
            '
            Me.tpE044DRN.Location = New System.Drawing.Point(4, 22)
            Me.tpE044DRN.Name = "tpE044DRN"
            Me.tpE044DRN.Size = New System.Drawing.Size(888, 612)
            Me.tpE044DRN.TabIndex = 0
            Me.tpE044DRN.Text = "E044 DRN"
            '
            'tpE045ECPNI
            '
            Me.tpE045ECPNI.Location = New System.Drawing.Point(4, 22)
            Me.tpE045ECPNI.Name = "tpE045ECPNI"
            Me.tpE045ECPNI.Size = New System.Drawing.Size(888, 612)
            Me.tpE045ECPNI.TabIndex = 6
            Me.tpE045ECPNI.Text = "E045 ECPNI"
            '
            'tpE046CRN
            '
            Me.tpE046CRN.Location = New System.Drawing.Point(4, 22)
            Me.tpE046CRN.Name = "tpE046CRN"
            Me.tpE046CRN.Size = New System.Drawing.Size(888, 612)
            Me.tpE046CRN.TabIndex = 1
            Me.tpE046CRN.Text = "E046 CRN"
            '
            'tpE037ECO
            '
            Me.tpE037ECO.Location = New System.Drawing.Point(4, 22)
            Me.tpE037ECO.Name = "tpE037ECO"
            Me.tpE037ECO.Size = New System.Drawing.Size(888, 612)
            Me.tpE037ECO.TabIndex = 4
            Me.tpE037ECO.Text = "E037 ECO"
            '
            'tpE025BOMItmMstr
            '
            Me.tpE025BOMItmMstr.Location = New System.Drawing.Point(4, 22)
            Me.tpE025BOMItmMstr.Name = "tpE025BOMItmMstr"
            Me.tpE025BOMItmMstr.Size = New System.Drawing.Size(888, 612)
            Me.tpE025BOMItmMstr.TabIndex = 2
            Me.tpE025BOMItmMstr.Text = "E025 BOM Itm Mstr"
            '
            'tpBLManagment
            '
            Me.tpBLManagment.Location = New System.Drawing.Point(4, 22)
            Me.tpBLManagment.Name = "tpBLManagment"
            Me.tpBLManagment.Size = New System.Drawing.Size(888, 612)
            Me.tpBLManagment.TabIndex = 3
            Me.tpBLManagment.Text = "BL Managment"
            '
            'tpDwgLstTbLst
            '
            Me.tpDwgLstTbLst.Location = New System.Drawing.Point(4, 22)
            Me.tpDwgLstTbLst.Name = "tpDwgLstTbLst"
            Me.tpDwgLstTbLst.Size = New System.Drawing.Size(888, 612)
            Me.tpDwgLstTbLst.TabIndex = 5
            Me.tpDwgLstTbLst.Text = "Dwg Lst Tb Lst"
            '
            'tpOther
            '
            Me.tpOther.Location = New System.Drawing.Point(4, 22)
            Me.tpOther.Name = "tpOther"
            Me.tpOther.Size = New System.Drawing.Size(888, 612)
            Me.tpOther.TabIndex = 7
            Me.tpOther.Text = "Other"
            '
            'frmMain
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(896, 638)
            Me.Controls.Add(Me.TabControl1)
            Me.Name = "frmMain"
            Me.Text = "Main Form"
            Me.TabControl1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

#End Region


        Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            'Dim file As New System.IO.StreamReader(".\" & "\New Text Document.txt")
            'Dim adoDBConn As OleDb.OleDbConnection
            'adoDBConn.open("file name="H:\NetCad2006\DataLinks" & "\DBTest.txt")


            ' user controls
            ucE001PIN.Dock = System.Windows.Forms.DockStyle.Fill : tpE001PIN.Controls.Add(ucE001PIN)
            ucE044DRN.Dock = System.Windows.Forms.DockStyle.Fill : tpE044DRN.Controls.Add(ucE044DRN)
            ucE045ECPNI.Dock = System.Windows.Forms.DockStyle.Fill : tpE045ECPNI.Controls.Add(ucE045ECPNI)
            ucE046CRN.Dock = System.Windows.Forms.DockStyle.Fill : tpE046CRN.Controls.Add(ucE046CRN)
            ucE037ECO.Dock = System.Windows.Forms.DockStyle.Fill : tpE037ECO.Controls.Add(ucE037ECO)
            ucE025BomItmMstr.Dock = System.Windows.Forms.DockStyle.Fill : tpE025BOMItmMstr.Controls.Add(ucE025BomItmMstr)
            ucBLManagment.Dock = System.Windows.Forms.DockStyle.Fill : tpBLManagment.Controls.Add(ucBLManagment)
            ucDwgLstTbLst.Dock = System.Windows.Forms.DockStyle.Fill : tpDwgLstTbLst.Controls.Add(ucDwgLstTbLst)
            'ucOther.Dock = System.Windows.Forms.DockStyle.None : tpOther.Controls.Add(ucOther)


        End Sub



    End Class


End Namespace

