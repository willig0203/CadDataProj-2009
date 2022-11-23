Option Explicit On

Imports System.Collections
Imports System.Windows.Forms
Imports System.Drawing
Imports System.IO

Imports Autodesk.AutoCAD.ApplicationServices
Imports Autodesk.AutoCAD.DatabaseServices
Imports Autodesk.AutoCAD.DatabaseServices.XrefObjectId
Imports Autodesk.AutoCAD.EditorInput
Imports Autodesk.AutoCAD.Geometry

Imports rnsCadDataProj.nsForms
Imports rnsCadDataProj.nsMods

Imports rnsCadDataProj.nsUserCtls.ucRevisions


Namespace nsUserCtls

    Public Class ucDwgLstTbLst

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
        Friend WithEvents cmnuFileLst As System.Windows.Forms.ContextMenu
        Friend WithEvents miGetFls As System.Windows.Forms.MenuItem
        Friend WithEvents miClrLst As System.Windows.Forms.MenuItem
        Friend WithEvents miOpnFlsGtLyts As System.Windows.Forms.MenuItem
        Friend WithEvents cmnuUpdateTBlst As System.Windows.Forms.ContextMenu
        Friend WithEvents miUpDateTBds As System.Windows.Forms.MenuItem
        Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
        Friend WithEvents cmnuTransToNewFrm As System.Windows.Forms.ContextMenu
        Friend WithEvents miTransToE044DRN As System.Windows.Forms.MenuItem
        Friend WithEvents miTransToE046CRN As System.Windows.Forms.MenuItem
        Friend WithEvents miTransToE025BOM As System.Windows.Forms.MenuItem
        Friend WithEvents miTransToEMail As System.Windows.Forms.MenuItem
        Friend WithEvents miClrCloneTbl As System.Windows.Forms.MenuItem
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents rbtnPltwStoredSettings As System.Windows.Forms.RadioButton
        Friend WithEvents rbtnPlt1to1 As System.Windows.Forms.RadioButton
        Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
        Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
        Friend WithEvents tpGridView As System.Windows.Forms.TabPage
        Friend WithEvents dgBldLst As System.Windows.Forms.DataGrid
        Friend WithEvents tpListBox As System.Windows.Forms.TabPage
        Friend WithEvents ListBox3 As System.Windows.Forms.ListBox
        Friend WithEvents tpBlockList As System.Windows.Forms.TabPage
        Friend WithEvents DataGrid4 As System.Windows.Forms.DataGrid
        Friend WithEvents tpStamps As System.Windows.Forms.TabPage
        Friend WithEvents chkbxAllLayouts As System.Windows.Forms.CheckBox
        Friend WithEvents UcRevisions1 As rnsCadDataProj.nsUserCtls.ucRevisions
        Friend WithEvents UcStamps1 As rnsCadDataProj.nsUserCtls.ucStamps
        Friend WithEvents tpBatchOptions As System.Windows.Forms.TabPage
        Friend WithEvents chkbxClrRevs As System.Windows.Forms.CheckBox
        Friend WithEvents chkbxCloseAndDiscard As System.Windows.Forms.CheckBox
        Friend WithEvents chkbxCloseAndSave As System.Windows.Forms.CheckBox
        Friend WithEvents chkbxAddNextRev As System.Windows.Forms.CheckBox
        Friend WithEvents chkbxAddRevsFrmLst As System.Windows.Forms.CheckBox
        Friend WithEvents UcTransmit1 As rnsCadDataProj.nsUserCtls.ucTransmit
        Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
        Friend WithEvents btnShowBrowserForm As System.Windows.Forms.Button
        Friend WithEvents btnShowBlockMan As System.Windows.Forms.Button
        Friend WithEvents tpRevisions As System.Windows.Forms.TabPage
        Friend WithEvents rbtnPltLayoutsDWF1to1 As System.Windows.Forms.RadioButton
        Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
        Public WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents tpTransmitDocsData As System.Windows.Forms.TabPage
        Friend WithEvents tpAttOptions As System.Windows.Forms.TabPage
        Friend WithEvents UcAttOptions1 As rnsCadDataProj.nsUserCtls.ucAttOptions
        Friend WithEvents rbPltToFit As System.Windows.Forms.RadioButton
        Friend WithEvents lstBxXrefs As System.Windows.Forms.ListBox
        Friend WithEvents Splitter2 As System.Windows.Forms.Splitter
        Friend WithEvents chkbxFade255 As System.Windows.Forms.CheckBox
        Friend WithEvents miGetLayoutsCurrentDwg As System.Windows.Forms.MenuItem
        Friend WithEvents rbtnMkDwfBook As System.Windows.Forms.RadioButton
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
            Me.cmnuFileLst = New System.Windows.Forms.ContextMenu
            Me.miGetFls = New System.Windows.Forms.MenuItem
            Me.miClrLst = New System.Windows.Forms.MenuItem
            Me.miOpnFlsGtLyts = New System.Windows.Forms.MenuItem
            Me.miGetLayoutsCurrentDwg = New System.Windows.Forms.MenuItem
            Me.cmnuUpdateTBlst = New System.Windows.Forms.ContextMenu
            Me.miUpDateTBds = New System.Windows.Forms.MenuItem
            Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
            Me.cmnuTransToNewFrm = New System.Windows.Forms.ContextMenu
            Me.miTransToE044DRN = New System.Windows.Forms.MenuItem
            Me.miTransToE046CRN = New System.Windows.Forms.MenuItem
            Me.miTransToE025BOM = New System.Windows.Forms.MenuItem
            Me.miTransToEMail = New System.Windows.Forms.MenuItem
            Me.miClrCloneTbl = New System.Windows.Forms.MenuItem
            Me.Panel1 = New System.Windows.Forms.Panel
            Me.btnShowBrowserForm = New System.Windows.Forms.Button
            Me.Label1 = New System.Windows.Forms.Label
            Me.ListBox1 = New System.Windows.Forms.ListBox
            Me.btnShowBlockMan = New System.Windows.Forms.Button
            Me.GroupBox1 = New System.Windows.Forms.GroupBox
            Me.chkbxFade255 = New System.Windows.Forms.CheckBox
            Me.rbtnMkDwfBook = New System.Windows.Forms.RadioButton
            Me.rbPltToFit = New System.Windows.Forms.RadioButton
            Me.chkbxAddNextRev = New System.Windows.Forms.CheckBox
            Me.chkbxAllLayouts = New System.Windows.Forms.CheckBox
            Me.rbtnPltwStoredSettings = New System.Windows.Forms.RadioButton
            Me.rbtnPlt1to1 = New System.Windows.Forms.RadioButton
            Me.chkbxCloseAndDiscard = New System.Windows.Forms.CheckBox
            Me.chkbxClrRevs = New System.Windows.Forms.CheckBox
            Me.chkbxCloseAndSave = New System.Windows.Forms.CheckBox
            Me.chkbxAddRevsFrmLst = New System.Windows.Forms.CheckBox
            Me.rbtnPltLayoutsDWF1to1 = New System.Windows.Forms.RadioButton
            Me.Splitter1 = New System.Windows.Forms.Splitter
            Me.TabControl2 = New System.Windows.Forms.TabControl
            Me.tpGridView = New System.Windows.Forms.TabPage
            Me.dgBldLst = New System.Windows.Forms.DataGrid
            Me.tpListBox = New System.Windows.Forms.TabPage
            Me.lstBxXrefs = New System.Windows.Forms.ListBox
            Me.Splitter2 = New System.Windows.Forms.Splitter
            Me.ListBox3 = New System.Windows.Forms.ListBox
            Me.tpBlockList = New System.Windows.Forms.TabPage
            Me.DataGrid4 = New System.Windows.Forms.DataGrid
            Me.tpRevisions = New System.Windows.Forms.TabPage
            Me.UcRevisions1 = New rnsCadDataProj.nsUserCtls.ucRevisions
            Me.tpAttOptions = New System.Windows.Forms.TabPage
            Me.UcAttOptions1 = New rnsCadDataProj.nsUserCtls.ucAttOptions
            Me.tpBatchOptions = New System.Windows.Forms.TabPage
            Me.tpTransmitDocsData = New System.Windows.Forms.TabPage
            Me.tpStamps = New System.Windows.Forms.TabPage
            Me.UcStamps1 = New rnsCadDataProj.nsUserCtls.ucStamps
            Me.Panel1.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.TabControl2.SuspendLayout()
            Me.tpGridView.SuspendLayout()
            CType(Me.dgBldLst, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tpListBox.SuspendLayout()
            Me.tpBlockList.SuspendLayout()
            CType(Me.DataGrid4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tpRevisions.SuspendLayout()
            Me.tpAttOptions.SuspendLayout()
            Me.tpBatchOptions.SuspendLayout()
            Me.tpStamps.SuspendLayout()
            Me.SuspendLayout()
            '
            'cmnuFileLst
            '
            Me.cmnuFileLst.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miGetFls, Me.miClrLst, Me.miOpnFlsGtLyts, Me.miGetLayoutsCurrentDwg})
            '
            'miGetFls
            '
            Me.miGetFls.Index = 0
            Me.miGetFls.Text = "Get Files"
            '
            'miClrLst
            '
            Me.miClrLst.Index = 1
            Me.miClrLst.Text = "Clear List"
            '
            'miOpnFlsGtLyts
            '
            Me.miOpnFlsGtLyts.Index = 2
            Me.miOpnFlsGtLyts.Text = "Open Files - Get Layouts"
            '
            'miGetLayoutsCurrentDwg
            '
            Me.miGetLayoutsCurrentDwg.Index = 3
            Me.miGetLayoutsCurrentDwg.Text = "GetLayoutsCurrentDwg"
            '
            'cmnuUpdateTBlst
            '
            Me.cmnuUpdateTBlst.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miUpDateTBds})
            '
            'miUpDateTBds
            '
            Me.miUpDateTBds.Index = 0
            Me.miUpDateTBds.Text = "UpDate Data Source"
            '
            'OpenFileDialog1
            '
            Me.OpenFileDialog1.Filter = """DWG files (*.dwg)|*.dwg|All files (*.*)|*.*"""
            Me.OpenFileDialog1.Multiselect = True
            '
            'cmnuTransToNewFrm
            '
            Me.cmnuTransToNewFrm.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miTransToE044DRN, Me.miTransToE046CRN, Me.miTransToE025BOM, Me.miTransToEMail, Me.miClrCloneTbl})
            '
            'miTransToE044DRN
            '
            Me.miTransToE044DRN.Index = 0
            Me.miTransToE044DRN.Text = "Trans to E044 DRN"
            '
            'miTransToE046CRN
            '
            Me.miTransToE046CRN.Index = 1
            Me.miTransToE046CRN.Text = "Trans to E046 CRN"
            '
            'miTransToE025BOM
            '
            Me.miTransToE025BOM.Index = 2
            Me.miTransToE025BOM.Text = "Trans to E025 BOM"
            '
            'miTransToEMail
            '
            Me.miTransToEMail.Index = 3
            Me.miTransToEMail.Text = "Trans to E-Mail"
            '
            'miClrCloneTbl
            '
            Me.miClrCloneTbl.Index = 4
            Me.miClrCloneTbl.Text = "Clear Table"
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.btnShowBrowserForm)
            Me.Panel1.Controls.Add(Me.Label1)
            Me.Panel1.Controls.Add(Me.ListBox1)
            Me.Panel1.Controls.Add(Me.btnShowBlockMan)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(624, 176)
            Me.Panel1.TabIndex = 27
            '
            'btnShowBrowserForm
            '
            Me.btnShowBrowserForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnShowBrowserForm.Location = New System.Drawing.Point(552, 48)
            Me.btnShowBrowserForm.Name = "btnShowBrowserForm"
            Me.btnShowBrowserForm.Size = New System.Drawing.Size(64, 48)
            Me.btnShowBrowserForm.TabIndex = 16
            Me.btnShowBrowserForm.Text = "Show Browser Form"
            '
            'Label1
            '
            Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label1.Location = New System.Drawing.Point(8, 8)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(608, 23)
            Me.Label1.TabIndex = 15
            Me.Label1.Text = "Select Folder"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'ListBox1
            '
            Me.ListBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.ListBox1.ContextMenu = Me.cmnuFileLst
            Me.ListBox1.HorizontalScrollbar = True
            Me.ListBox1.Location = New System.Drawing.Point(8, 32)
            Me.ListBox1.Name = "ListBox1"
            Me.ListBox1.Size = New System.Drawing.Size(536, 134)
            Me.ListBox1.TabIndex = 14
            '
            'btnShowBlockMan
            '
            Me.btnShowBlockMan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnShowBlockMan.Location = New System.Drawing.Point(552, 104)
            Me.btnShowBlockMan.Name = "btnShowBlockMan"
            Me.btnShowBlockMan.Size = New System.Drawing.Size(64, 48)
            Me.btnShowBlockMan.TabIndex = 16
            Me.btnShowBlockMan.Text = "Show BlockMan"
            '
            'GroupBox1
            '
            Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.GroupBox1.Controls.Add(Me.chkbxFade255)
            Me.GroupBox1.Controls.Add(Me.rbtnMkDwfBook)
            Me.GroupBox1.Controls.Add(Me.rbPltToFit)
            Me.GroupBox1.Controls.Add(Me.chkbxAddNextRev)
            Me.GroupBox1.Controls.Add(Me.chkbxAllLayouts)
            Me.GroupBox1.Controls.Add(Me.rbtnPltwStoredSettings)
            Me.GroupBox1.Controls.Add(Me.rbtnPlt1to1)
            Me.GroupBox1.Controls.Add(Me.chkbxCloseAndDiscard)
            Me.GroupBox1.Controls.Add(Me.chkbxClrRevs)
            Me.GroupBox1.Controls.Add(Me.chkbxCloseAndSave)
            Me.GroupBox1.Controls.Add(Me.chkbxAddRevsFrmLst)
            Me.GroupBox1.Controls.Add(Me.rbtnPltLayoutsDWF1to1)
            Me.GroupBox1.Location = New System.Drawing.Point(16, 16)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(440, 224)
            Me.GroupBox1.TabIndex = 25
            Me.GroupBox1.TabStop = False
            '
            'chkbxFade255
            '
            Me.chkbxFade255.AutoSize = True
            Me.chkbxFade255.Location = New System.Drawing.Point(8, 16)
            Me.chkbxFade255.Name = "chkbxFade255"
            Me.chkbxFade255.Size = New System.Drawing.Size(71, 17)
            Me.chkbxFade255.TabIndex = 26
            Me.chkbxFade255.Text = "Fade 255"
            Me.chkbxFade255.UseVisualStyleBackColor = True
            '
            'rbtnMkDwfBook
            '
            Me.rbtnMkDwfBook.Location = New System.Drawing.Point(8, 168)
            Me.rbtnMkDwfBook.Name = "rbtnMkDwfBook"
            Me.rbtnMkDwfBook.Size = New System.Drawing.Size(96, 24)
            Me.rbtnMkDwfBook.TabIndex = 28
            Me.rbtnMkDwfBook.Text = "Mk Dwf Book"
            '
            'rbPltToFit
            '
            Me.rbPltToFit.Location = New System.Drawing.Point(8, 32)
            Me.rbPltToFit.Name = "rbPltToFit"
            Me.rbPltToFit.Size = New System.Drawing.Size(104, 24)
            Me.rbPltToFit.TabIndex = 27
            Me.rbPltToFit.Text = "Plt To Fit"
            '
            'chkbxAddNextRev
            '
            Me.chkbxAddNextRev.Location = New System.Drawing.Point(136, 72)
            Me.chkbxAddNextRev.Name = "chkbxAddNextRev"
            Me.chkbxAddNextRev.Size = New System.Drawing.Size(104, 24)
            Me.chkbxAddNextRev.TabIndex = 20
            Me.chkbxAddNextRev.Text = "Add Next Rev"
            '
            'chkbxAllLayouts
            '
            Me.chkbxAllLayouts.Location = New System.Drawing.Point(216, 16)
            Me.chkbxAllLayouts.Name = "chkbxAllLayouts"
            Me.chkbxAllLayouts.Size = New System.Drawing.Size(104, 24)
            Me.chkbxAllLayouts.TabIndex = 19
            Me.chkbxAllLayouts.Text = "All Layouts"
            '
            'rbtnPltwStoredSettings
            '
            Me.rbtnPltwStoredSettings.Location = New System.Drawing.Point(8, 96)
            Me.rbtnPltwStoredSettings.Name = "rbtnPltwStoredSettings"
            Me.rbtnPltwStoredSettings.Size = New System.Drawing.Size(88, 32)
            Me.rbtnPltwStoredSettings.TabIndex = 1
            Me.rbtnPltwStoredSettings.Text = "Plt w Stored Settings"
            '
            'rbtnPlt1to1
            '
            Me.rbtnPlt1to1.Location = New System.Drawing.Point(8, 56)
            Me.rbtnPlt1to1.Name = "rbtnPlt1to1"
            Me.rbtnPlt1to1.Size = New System.Drawing.Size(88, 40)
            Me.rbtnPlt1to1.TabIndex = 0
            Me.rbtnPlt1to1.Text = "Plt Layouts 1to1"
            '
            'chkbxCloseAndDiscard
            '
            Me.chkbxCloseAndDiscard.Location = New System.Drawing.Point(272, 96)
            Me.chkbxCloseAndDiscard.Name = "chkbxCloseAndDiscard"
            Me.chkbxCloseAndDiscard.Size = New System.Drawing.Size(120, 24)
            Me.chkbxCloseAndDiscard.TabIndex = 18
            Me.chkbxCloseAndDiscard.Text = "Close And Discard"
            '
            'chkbxClrRevs
            '
            Me.chkbxClrRevs.Location = New System.Drawing.Point(136, 48)
            Me.chkbxClrRevs.Name = "chkbxClrRevs"
            Me.chkbxClrRevs.Size = New System.Drawing.Size(72, 24)
            Me.chkbxClrRevs.TabIndex = 26
            Me.chkbxClrRevs.Text = "Clr Revs"
            '
            'chkbxCloseAndSave
            '
            Me.chkbxCloseAndSave.Location = New System.Drawing.Point(272, 72)
            Me.chkbxCloseAndSave.Name = "chkbxCloseAndSave"
            Me.chkbxCloseAndSave.Size = New System.Drawing.Size(104, 24)
            Me.chkbxCloseAndSave.TabIndex = 18
            Me.chkbxCloseAndSave.Text = "Close And Save"
            '
            'chkbxAddRevsFrmLst
            '
            Me.chkbxAddRevsFrmLst.Location = New System.Drawing.Point(136, 96)
            Me.chkbxAddRevsFrmLst.Name = "chkbxAddRevsFrmLst"
            Me.chkbxAddRevsFrmLst.Size = New System.Drawing.Size(120, 24)
            Me.chkbxAddRevsFrmLst.TabIndex = 20
            Me.chkbxAddRevsFrmLst.Text = "Add Revs Frm Lst"
            '
            'rbtnPltLayoutsDWF1to1
            '
            Me.rbtnPltLayoutsDWF1to1.Location = New System.Drawing.Point(8, 128)
            Me.rbtnPltLayoutsDWF1to1.Name = "rbtnPltLayoutsDWF1to1"
            Me.rbtnPltLayoutsDWF1to1.Size = New System.Drawing.Size(88, 40)
            Me.rbtnPltLayoutsDWF1to1.TabIndex = 0
            Me.rbtnPltLayoutsDWF1to1.Text = "Plt Layouts DWF1to1"
            '
            'Splitter1
            '
            Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Splitter1.Location = New System.Drawing.Point(0, 176)
            Me.Splitter1.Name = "Splitter1"
            Me.Splitter1.Size = New System.Drawing.Size(624, 3)
            Me.Splitter1.TabIndex = 28
            Me.Splitter1.TabStop = False
            '
            'TabControl2
            '
            Me.TabControl2.Controls.Add(Me.tpGridView)
            Me.TabControl2.Controls.Add(Me.tpListBox)
            Me.TabControl2.Controls.Add(Me.tpBlockList)
            Me.TabControl2.Controls.Add(Me.tpRevisions)
            Me.TabControl2.Controls.Add(Me.tpAttOptions)
            Me.TabControl2.Controls.Add(Me.tpBatchOptions)
            Me.TabControl2.Controls.Add(Me.tpTransmitDocsData)
            Me.TabControl2.Controls.Add(Me.tpStamps)
            Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControl2.Location = New System.Drawing.Point(0, 179)
            Me.TabControl2.Name = "TabControl2"
            Me.TabControl2.SelectedIndex = 0
            Me.TabControl2.Size = New System.Drawing.Size(624, 301)
            Me.TabControl2.TabIndex = 29
            '
            'tpGridView
            '
            Me.tpGridView.Controls.Add(Me.dgBldLst)
            Me.tpGridView.Location = New System.Drawing.Point(4, 22)
            Me.tpGridView.Name = "tpGridView"
            Me.tpGridView.Size = New System.Drawing.Size(616, 275)
            Me.tpGridView.TabIndex = 2
            Me.tpGridView.Text = "Grid View"
            '
            'dgBldLst
            '
            Me.dgBldLst.ContextMenu = Me.cmnuTransToNewFrm
            Me.dgBldLst.DataMember = ""
            Me.dgBldLst.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgBldLst.HeaderForeColor = System.Drawing.SystemColors.ControlText
            Me.dgBldLst.Location = New System.Drawing.Point(0, 0)
            Me.dgBldLst.Name = "dgBldLst"
            Me.dgBldLst.Size = New System.Drawing.Size(616, 275)
            Me.dgBldLst.TabIndex = 0
            '
            'tpListBox
            '
            Me.tpListBox.Controls.Add(Me.lstBxXrefs)
            Me.tpListBox.Controls.Add(Me.Splitter2)
            Me.tpListBox.Controls.Add(Me.ListBox3)
            Me.tpListBox.Location = New System.Drawing.Point(4, 22)
            Me.tpListBox.Name = "tpListBox"
            Me.tpListBox.Size = New System.Drawing.Size(616, 275)
            Me.tpListBox.TabIndex = 0
            Me.tpListBox.Text = "List Box"
            Me.tpListBox.Visible = False
            '
            'lstBxXrefs
            '
            Me.lstBxXrefs.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lstBxXrefs.FormattingEnabled = True
            Me.lstBxXrefs.Location = New System.Drawing.Point(0, 111)
            Me.lstBxXrefs.Name = "lstBxXrefs"
            Me.lstBxXrefs.Size = New System.Drawing.Size(616, 160)
            Me.lstBxXrefs.TabIndex = 19
            '
            'Splitter2
            '
            Me.Splitter2.Dock = System.Windows.Forms.DockStyle.Top
            Me.Splitter2.Location = New System.Drawing.Point(0, 108)
            Me.Splitter2.Name = "Splitter2"
            Me.Splitter2.Size = New System.Drawing.Size(616, 3)
            Me.Splitter2.TabIndex = 18
            Me.Splitter2.TabStop = False
            '
            'ListBox3
            '
            Me.ListBox3.Dock = System.Windows.Forms.DockStyle.Top
            Me.ListBox3.Location = New System.Drawing.Point(0, 0)
            Me.ListBox3.Name = "ListBox3"
            Me.ListBox3.Size = New System.Drawing.Size(616, 108)
            Me.ListBox3.TabIndex = 17
            '
            'tpBlockList
            '
            Me.tpBlockList.Controls.Add(Me.DataGrid4)
            Me.tpBlockList.Location = New System.Drawing.Point(4, 22)
            Me.tpBlockList.Name = "tpBlockList"
            Me.tpBlockList.Size = New System.Drawing.Size(616, 275)
            Me.tpBlockList.TabIndex = 1
            Me.tpBlockList.Text = "Block List"
            Me.tpBlockList.Visible = False
            '
            'DataGrid4
            '
            Me.DataGrid4.ContextMenu = Me.cmnuUpdateTBlst
            Me.DataGrid4.DataMember = ""
            Me.DataGrid4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.DataGrid4.HeaderForeColor = System.Drawing.SystemColors.ControlText
            Me.DataGrid4.Location = New System.Drawing.Point(0, 0)
            Me.DataGrid4.Name = "DataGrid4"
            Me.DataGrid4.Size = New System.Drawing.Size(616, 275)
            Me.DataGrid4.TabIndex = 0
            '
            'tpRevisions
            '
            Me.tpRevisions.Controls.Add(Me.UcRevisions1)
            Me.tpRevisions.Location = New System.Drawing.Point(4, 22)
            Me.tpRevisions.Name = "tpRevisions"
            Me.tpRevisions.Size = New System.Drawing.Size(616, 275)
            Me.tpRevisions.TabIndex = 3
            Me.tpRevisions.Text = "Revisions"
            '
            'UcRevisions1
            '
            Me.UcRevisions1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UcRevisions1.Location = New System.Drawing.Point(0, 0)
            Me.UcRevisions1.Name = "UcRevisions1"
            Me.UcRevisions1.Size = New System.Drawing.Size(616, 275)
            Me.UcRevisions1.TabIndex = 0
            '
            'tpAttOptions
            '
            Me.tpAttOptions.Controls.Add(Me.UcAttOptions1)
            Me.tpAttOptions.Location = New System.Drawing.Point(4, 22)
            Me.tpAttOptions.Name = "tpAttOptions"
            Me.tpAttOptions.Size = New System.Drawing.Size(616, 275)
            Me.tpAttOptions.TabIndex = 7
            Me.tpAttOptions.Text = "Att Options"
            '
            'UcAttOptions1
            '
            Me.UcAttOptions1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UcAttOptions1.Location = New System.Drawing.Point(0, 0)
            Me.UcAttOptions1.Name = "UcAttOptions1"
            Me.UcAttOptions1.Size = New System.Drawing.Size(616, 275)
            Me.UcAttOptions1.TabIndex = 0
            '
            'tpBatchOptions
            '
            Me.tpBatchOptions.Controls.Add(Me.GroupBox1)
            Me.tpBatchOptions.Location = New System.Drawing.Point(4, 22)
            Me.tpBatchOptions.Name = "tpBatchOptions"
            Me.tpBatchOptions.Size = New System.Drawing.Size(616, 275)
            Me.tpBatchOptions.TabIndex = 5
            Me.tpBatchOptions.Text = "Batch Options"
            '
            'tpTransmitDocsData
            '
            Me.tpTransmitDocsData.Location = New System.Drawing.Point(4, 22)
            Me.tpTransmitDocsData.Name = "tpTransmitDocsData"
            Me.tpTransmitDocsData.Size = New System.Drawing.Size(616, 275)
            Me.tpTransmitDocsData.TabIndex = 6
            Me.tpTransmitDocsData.Text = "Transmit Docs & Data"
            '
            'tpStamps
            '
            Me.tpStamps.Controls.Add(Me.UcStamps1)
            Me.tpStamps.Location = New System.Drawing.Point(4, 22)
            Me.tpStamps.Name = "tpStamps"
            Me.tpStamps.Size = New System.Drawing.Size(616, 275)
            Me.tpStamps.TabIndex = 4
            Me.tpStamps.Text = "Stamps"
            '
            'UcStamps1
            '
            Me.UcStamps1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UcStamps1.Location = New System.Drawing.Point(0, 0)
            Me.UcStamps1.Name = "UcStamps1"
            Me.UcStamps1.Size = New System.Drawing.Size(616, 275)
            Me.UcStamps1.TabIndex = 0
            '
            'ucDwgLstTbLst
            '
            Me.Controls.Add(Me.TabControl2)
            Me.Controls.Add(Me.Splitter1)
            Me.Controls.Add(Me.Panel1)
            Me.Name = "ucDwgLstTbLst"
            Me.Size = New System.Drawing.Size(624, 480)
            Me.Panel1.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.TabControl2.ResumeLayout(False)
            Me.tpGridView.ResumeLayout(False)
            CType(Me.dgBldLst, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tpListBox.ResumeLayout(False)
            Me.tpBlockList.ResumeLayout(False)
            CType(Me.DataGrid4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tpRevisions.ResumeLayout(False)
            Me.tpAttOptions.ResumeLayout(False)
            Me.tpBatchOptions.ResumeLayout(False)
            Me.tpStamps.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private Sub ucDwgLstTbLst_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

            If SqlDaComp.DataSet11.TrackingBlockNames.Count = 0 Then

                SqlDaComp.SqlConn.ConnectionString = words
                SqlDaComp.daTrkBlkNames.Fill(SqlDaComp.DataSet11.TrackingBlockNames)
                DataGrid4.DataSource = SqlDaComp.DataSet11.TrackingBlockNames
            End If


            Me.UcTransmit1 = New rnsCadDataProj.nsUserCtls.ucTransmit
            Me.UcTransmit1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UcTransmit1.Location = New System.Drawing.Point(0, 0)
            Me.UcTransmit1.Name = "UcTransmit1"
            tpTransmitDocsData.Controls.Add(UcTransmit1)


            ' Tool tips
            Dim toolTip1 As New ToolTip : toolTip1.AutoPopDelay = 5000
            toolTip1.InitialDelay = 1000 : toolTip1.ReshowDelay = 500
            toolTip1.ShowAlways = True
            toolTip1.SetToolTip(rbtnPlt1to1, "Layout Must Be Setup !")
            toolTip1.SetToolTip(rbtnPltwStoredSettings, "Not Working Properly Yet")
            toolTip1.SetToolTip(chkbxAllLayouts, "All Layouts (No Title Block Search)")

        End Sub

        Private Sub miUpDateTBds_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miUpDateTBds.Click
            Try : SqlDaComp.daTrkBlkNames.Update(SqlDaComp.DataSet11.TrackingBlockNames)
                ' Catch dbcx As DBConcurrencyException
                'createMessage(dbcx, "TrackingBlockNames")
            Catch ex As Exception
                MessageBox.Show("Update Failed", ex.GetType().ToString())
            End Try
            SqlDaComp.DataSet11.TrackingBlockNames.Clear()
            SqlDaComp.daTrkBlkNames.Fill(SqlDaComp.DataSet11.TrackingBlockNames)
        End Sub

        Private Sub miTransToE025CRN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miTransToE046CRN.Click
            Dim response As System.Windows.Forms.DialogResult
            Dim MyNewRow As DataRow : Dim MyTransRow As DataRow
            Dim c As Integer ': Dim Cc As Integer
            If crnID <> Nothing And Not cloneTable Is Nothing Then
                For c = 0 To (cloneTable.Rows.Count - 1)
                    MyTransRow = cloneTable.Rows(c)
                    MyNewRow = SqlDaComp.DataSet11.E046SubTable.NewRow()
                    '= MyTransRow("FileName") & "-" & MyTransRow("Layout")
                    Dim str As String = MyTransRow("FileName") : str = str.Replace(".dwg", "") : str = str.Replace(".DWG", "")
                    str = str & " - " & MyTransRow("Layout")
                    MyNewRow("DocumentNumber") = str
                    MyNewRow("Description") = MyTransRow("TitleBlock")
                    MyNewRow("NumberofCopies") = 1
                    MyNewRow("Revision") = MyTransRow("RevisionBlock")
                    MyNewRow("CopyRequestNumber") = crnID  'dgE044DRN.Item(dgE044DRN.CurrentRowIndex, 1)
                    SqlDaComp.DataSet11.E046SubTable.Rows.Add(MyNewRow)
                Next
                crnID = Nothing
                Dim frm As frmMain = Me.FindForm() : frm.TabControl1.SelectedTab = frm.tpE046CRN
                response = MessageBox.Show("Update Datasource ?", "Update Datasource ?", MessageBoxButtons.YesNo)
                Select Case response
                    Case System.Windows.Forms.DialogResult.Yes
                        Try : SqlDaComp.DaE046SubTable.Update(SqlDaComp.DataSet11.E046SubTable)
                        Catch dbcx As DBConcurrencyException
                            'createMessage(dbcx, "E024ItemMasterInput")
                        Catch ex As Exception
                            MessageBox.Show("Update Failed", ex.GetType().ToString())
                        End Try
                    Case Else
                End Select
            Else : MessageBox.Show("Table is Empty")
            End If
        End Sub

        Private Sub miTransToE044DRN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miTransToE044DRN.Click
            Dim response As System.Windows.Forms.DialogResult
            Dim MyNewRow As DataRow : Dim MyTransRow As DataRow
            Dim c As Integer ': Dim Cc As Integer

            If drnID <> Nothing And Not cloneTable Is Nothing Then
                For c = 0 To (cloneTable.Rows.Count - 1)
                    MyTransRow = cloneTable.Rows(c)
                    MyNewRow = SqlDaComp.DataSet11.E044ReleasedDocuments.NewRow()
                    MyNewRow("FileName") = MyTransRow("FileName")
                    MyNewRow("Layout") = MyTransRow("Layout")
                    MyNewRow("TitleBlock") = MyTransRow("TitleBlock")
                    MyNewRow("RevisionBlock") = MyTransRow("RevisionBlock")
                    MyNewRow("ControlStamp") = MyTransRow("ControlStamp")

                    MyNewRow("DocumentReleaseNoticeNumber") = drnID  'dgE044DRN.Item(dgE044DRN.CurrentRowIndex, 1)
                    SqlDaComp.DataSet11.E044ReleasedDocuments.Rows.Add(MyNewRow)
                Next
                drnID = Nothing
                Dim frm As frmMain = Me.FindForm()
                frm.TabControl1.SelectedTab = frm.tpE044DRN

                response = MessageBox.Show("Update Datasource ?", "Update Datasource ?", MessageBoxButtons.YesNo)
                Select Case response
                    Case System.Windows.Forms.DialogResult.Yes
                        Try : SqlDaComp.DaE044RelDocs.Update(SqlDaComp.DataSet11.E044ReleasedDocuments)
                            'Catch dbcx As DBConcurrencyException
                            'createMessage(dbcx, "E024ItemMasterInput")
                        Catch ex As Exception
                            MessageBox.Show("Update Failed" & ex.ToString())
                            'MessageBox.Show(MyNewRow.RowError.ToString)
                        End Try
                    Case Else
                End Select

            Else : MessageBox.Show("drnID <> Nothing And Not cloneTable Is Nothing")
            End If
        End Sub

        Private Sub miTransToE025BOM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miTransToE025BOM.Click
            MessageBox.Show("not defined yet")
        End Sub

        Private Sub miTransToEMail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miTransToEMail.Click
            MessageBox.Show("not defined yet")
        End Sub

        Private Sub miGetFls_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miGetFls.Click
            Dim fileOpened As Boolean = False
            Dim result As DialogResult = FolderBrowserDialog1.ShowDialog()
            If (result = System.Windows.Forms.DialogResult.OK) Then
                FolderName = FolderBrowserDialog1.SelectedPath 'OpenFileDialog1.SelectedPath  ?
                Label1.Text = FolderName
                If (Not fileOpened) Then
                    OpenFileDialog1.InitialDirectory = FolderName
                    OpenFileDialog1.FileName = Nothing
                    Dim resultF As DialogResult = OpenFileDialog1.ShowDialog()
                    If (resultF = System.Windows.Forms.DialogResult.OK) Then
                        OpenFileNames = OpenFileDialog1.FileNames
                        'ListBox1.Items.Clear()
                        'cloneTable = Nothing
                        For Each OpenFileName In OpenFileNames
                            'splitFName(OpenFileName)
                            'Dim tmpSplt = (splitStrAry(splitStrAry.Length - 1))
                            'ListBox1.Items.Add(FolderName & "\" & (splitStrAry(splitStrAry.Length - 1)))
                            ListBox1.Items.Add(OpenFileName)
                        Next
                    End If
                End If
            End If

        End Sub

        Private Sub miClrLst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miClrLst.Click
            ListBox1.Items.Clear()
        End Sub

        Public Sub putAtt(ByVal Doc As Autodesk.AutoCAD.ApplicationServices.Document, ByVal trans As Transaction, ByVal lOut As Layout, ByVal attTag As String)
            Dim myEntObj As Entity : Dim myEntObjId As ObjectId
            Dim LayMan As LayoutManager = LayoutManager.Current
            'Dim lOut As Layout = trans.GetObject(LayMan.GetLayoutId(LayMan.CurrentLayout), OpenMode.ForRead)

            Dim btRec As BlockTableRecord : btRec = trans.GetObject(lOut.BlockTableRecordId, OpenMode.ForRead)
            For Each myEntObjId In btRec
                myEntObj = trans.GetObject(myEntObjId, OpenMode.ForRead)
                Dim ObjClsName As String = myEntObj.GetRXClass.Name
                Dim BlkRefObj As BlockReference : Dim BlkTblRec As BlockTableRecord : Dim BlkRefObjName As String
                ' this gets long for model space tab
                Select Case ObjClsName
                    Case "AcDbBlockReference"
                        LayMan.CurrentLayout = lOut.LayoutName
                        BlkRefObj = trans.GetObject(myEntObjId, OpenMode.ForRead)
                        BlkTblRec = trans.GetObject(BlkRefObj.BlockTableRecord, OpenMode.ForRead)
                        BlkRefObjName = BlkTblRec.Name
                        Dim MyRow As DataRow
                        Dim BlkName As String
                        For Each MyRow In SqlDaComp.DataSet11.TrackingBlockNames ' could exclude some?
                            If Not IsDBNull(MyRow(0)) Then
                                BlkName = MyRow(0) ' is the name
                                Select Case BlkRefObjName
                                    Case BlkName
                                        Dim AttCol As Autodesk.AutoCAD.DatabaseServices.AttributeCollection
                                        Dim Att As AttributeReference : Dim AttObjID As ObjectId
                                        AttCol = BlkRefObj.AttributeCollection
                                        For Each AttObjID In AttCol
                                            Att = trans.GetObject(AttObjID, OpenMode.ForWrite)

                                            If Att.Tag = attTag And attTag = "CUSTOMER" Then Att.TextString = UcAttOptions1.tbCustomer.Text
                                            If Att.Tag = attTag And attTag = "PROJECT" Then Att.TextString = UcAttOptions1.tbProject.Text
                                            If Att.Tag = attTag And attTag = "LOCATION" Then Att.TextString = UcAttOptions1.tbLocation.Text
                                            If Att.Tag = attTag And attTag = "DESC_1" Then Att.TextString = UcAttOptions1.tbDesc_1.Text
                                            If Att.Tag = attTag And attTag = "DESC_2" Then Att.TextString = UcAttOptions1.tbDesc_2.Text
                                            If Att.Tag = attTag And attTag = "DESC_3" Then Att.TextString = UcAttOptions1.tbDesc_3.Text
                                            If Att.Tag = attTag And attTag = "SCALE" Then Att.TextString = UcAttOptions1.tbScale.Text
                                            If Att.Tag = attTag And attTag = "FILE" Then Att.TextString = Doc.Name
                                            If Att.Tag = attTag And attTag = "DWG_NUM" Then
                                                Dim str As String = Path.GetFileNameWithoutExtension(Doc.Name)
                                                Att.TextString = str & "-" & lOut.LayoutName
                                            End If
                                            If Att.Tag = attTag And attTag = "DRW_DATE" Then Att.TextString = UcAttOptions1.tbDrawnDate.Text
                                            If Att.Tag = attTag And attTag = "CHKD_DATE" Then Att.TextString = UcAttOptions1.tbCheckedDate.Text
                                            If Att.Tag = attTag And attTag = "DRW" Then Att.TextString = UcAttOptions1.tbDrawnBy.Text
                                            If Att.Tag = attTag And attTag = "CHKD" Then Att.TextString = UcAttOptions1.tbCheckedBy.Text

                                        Next
                                End Select
                            End If
                        Next
                    Case Else
                End Select
            Next
        End Sub


        Private Sub miGetLayoutsCurrentDwg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miGetLayoutsCurrentDwg.Click
            If cloneTable Is Nothing Then
                cloneTable = SqlDaComp.DataSet11.E044ReleasedDocuments.Clone() : cloneTable.PrimaryKey = Nothing
                cloneTable.Columns.Remove("DocumentNumberID") : cloneTable.Columns.Remove("DocumentReleaseNoticeNumber")
            End If

            Dim currLayout As String = ""
            Dim LayMan As LayoutManager = Nothing

            Dim Doc As Autodesk.AutoCAD.ApplicationServices.Document
            Dim db As Database = HostApplicationServices.WorkingDatabase
            ' Dim item As String

            lstBxXrefs.Items.Clear()

            'For Each item In ListBox1.Items  ' add - check for images and xrefs
            If currLayout <> "" Then currLayout = ""
            Doc = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument

            xRefStr = ""
            TestXrefPrint()
            'GetXrefList()

            db = Doc.Database : splitFName(Doc) : ListBox3.Items.Add(Doc.Name)
            Dim lDic As Autodesk.AutoCAD.DatabaseServices.DBDictionary
            Dim lDicdEnt As System.Collections.DictionaryEntry
            Dim trans As Transaction = db.TransactionManager.StartTransaction()
            Dim docLock As DocumentLock = Doc.LockDocument()
            Try
                lDic = trans.GetObject(db.LayoutDictionaryId, OpenMode.ForRead)
                LayMan = LayoutManager.Current
                If currLayout = "" Then currLayout = LayMan.CurrentLayout


                Dim mySL As SortedList = New SortedList()

                For Each lDicdEnt In lDic
                    Dim lOut As Layout = trans.GetObject(lDicdEnt.Value, OpenMode.ForRead)
                    mySL.Add(lOut.TabOrder, lOut.LayoutName)
                Next

                'For i As Integer = 0 To mySL.Count - 1
                '    ListBox3.Items.Add(mySL.GetKey(i) & " - " & mySL.GetByIndex(i))
                'Next

                For i As Integer = 1 To mySL.Count - 1 ' 0 is model tab
                    'For Each lDicdEnt In lDic
                    LayMan.CurrentLayout = mySL.GetByIndex(i)

                    Dim lOut As Layout = trans.GetObject(lDic.GetAt(LayMan.CurrentLayout), OpenMode.ForRead) ' write causes lock violation?

                    ListBox3.Items.Add("Layout Name: " & lOut.LayoutName & " Tab Order: " & lOut.TabOrder)

                    If chkbxAllLayouts.Checked Then ' no title blocks, no model tab
                        Select Case lOut.LayoutName
                            Case Is <> "Model"

                                Dim exMin As Point3d = Autodesk.AutoCAD.ApplicationServices.Application.GetSystemVariable("EXTMIN")
                                Dim exMax As Point3d = Autodesk.AutoCAD.ApplicationServices.Application.GetSystemVariable("EXTMAX")

                                If rbtnPlt1to1.Checked Then modPlot.pltCurrLayout(StdScaleType.ScaleToFit, chkbxFade255.Checked)

                                Dim MyNewRow As DataRow = cloneTable.NewRow()
                                MyNewRow("FileName") = splitStrAry(splitStrAry.Length - 1)
                                MyNewRow("Layout") = lOut.LayoutName  ' lDicdEnt.Key

                                MyNewRow("TitleBlock") = exMin.X.ToString("###,###.00") & ", " & exMin.Y.ToString("###,###.00") & ": " & exMax.X.ToString("###,###.00") & ", " & exMax.Y.ToString("###,###.00")

                                cloneTable.Rows.Add(MyNewRow)
                            Case Else
                        End Select
                    Else

                        Dim btRec As BlockTableRecord
                        btRec = trans.GetObject(lOut.BlockTableRecordId, OpenMode.ForRead)
                        Dim myEntObjId As ObjectId
                        Dim myEntObj As Entity
                        For Each myEntObjId In btRec
                            myEntObj = trans.GetObject(myEntObjId, OpenMode.ForRead)
                            Dim ObjClsName As String = myEntObj.GetRXClass.Name
                            Dim BlkRefObj As BlockReference
                            Dim BlkTblRec As BlockTableRecord
                            Dim BlkRefObjName As String
                            Select Case ObjClsName
                                Case "AcDbBlockReference" ' add - and has attributes ???
                                    LayMan.CurrentLayout = lOut.LayoutName

                                    BlkRefObj = trans.GetObject(myEntObjId, OpenMode.ForRead)
                                    BlkTblRec = trans.GetObject(BlkRefObj.BlockTableRecord, OpenMode.ForRead)

                                    'If BlkTblRec.IsFromExternalReference Then
                                    '    'MessageBox.Show("Found Xreference - What to do ??")
                                    '    lstBxXrefs.Items.Add("Doc: " & Doc.Name & " Is Overlay: " & BlkTblRec.IsFromOverlayReference & " Xref:  " & BlkTblRec.Name)
                                    '    xRefStr = xRefStr & "Doc: " & Doc.Name & " Is Overlay: " & BlkTblRec.IsFromOverlayReference & " Xref:  " & BlkTblRec.Name & vbCrLf
                                    'End If

                                    BlkRefObjName = BlkTblRec.Name
                                    Dim MyRow As DataRow : Dim BlkName As String ': Dim BlkType As String
                                    For Each MyRow In SqlDaComp.DataSet11.TrackingBlockNames ' could exclude some?
                                        If Not IsDBNull(MyRow(0)) Then
                                            BlkName = MyRow(0) ' is the name
                                            'BlkType = MyRow(1)
                                            Select Case BlkRefObjName
                                                Case BlkName
                                                    Dim MyNewRow As DataRow = cloneTable.NewRow()
                                                    MyNewRow("FileName") = splitStrAry(splitStrAry.Length - 1)
                                                    MyNewRow("Layout") = lOut.LayoutName  ' lDicdEnt.Key
                                                    ListBox3.Items.Add(BlkRefObjName & "  Block Name")

                                                    If chkbxClrRevs.Checked Then UcRevisions1.ClrRevs() ' does the cur layout
                                                    If chkbxAddRevsFrmLst.Checked Then UcRevisions1.AddRevsFrmLst()
                                                    If chkbxAddNextRev.Checked Then UcRevisions1.AddNextRev()

                                                    If UcAttOptions1.chkbxCustomer.Checked Then putAtt(Doc, trans, lOut, "CUSTOMER")
                                                    If UcAttOptions1.chkbxProject.Checked Then putAtt(Doc, trans, lOut, "PROJECT")
                                                    If UcAttOptions1.chkbxLocation.Checked Then putAtt(Doc, trans, lOut, "LOCATION")
                                                    If UcAttOptions1.chkbxDesc_1.Checked Then putAtt(Doc, trans, lOut, "DESC_1")
                                                    If UcAttOptions1.chkbxDesc_2.Checked Then putAtt(Doc, trans, lOut, "DESC_2")
                                                    If UcAttOptions1.chkbxDesc_3.Checked Then putAtt(Doc, trans, lOut, "DESC_3")
                                                    If UcAttOptions1.chkbxScale.Checked Then putAtt(Doc, trans, lOut, "SCALE")

                                                    If UcAttOptions1.chkbxDwgPath.Checked Then putAtt(Doc, trans, lOut, "FILE")
                                                    If UcAttOptions1.chkbxFileLayAtt.Checked Then putAtt(Doc, trans, lOut, "DWG_NUM")

                                                    If UcAttOptions1.chkbxDrawnDate.Checked Then putAtt(Doc, trans, lOut, "DRW_DATE")
                                                    If UcAttOptions1.chkbxCheckedDate.Checked Then putAtt(Doc, trans, lOut, "CHKD_DATE")

                                                    If UcAttOptions1.chkbxDrawnBy.Checked Then putAtt(Doc, trans, lOut, "DRW")
                                                    If UcAttOptions1.chkbxCheckedBy.Checked Then putAtt(Doc, trans, lOut, "CHKD")

                                                    GetAtts(BlkRefObjName, BlkRefObj, trans)

                                                    Dim myComparer As myReverserClass = New myReverserClass
                                                    Array.Sort(revs) : Array.Sort(revs, myComparer)

                                                    '
                                                    ' ''Dim cnt As Integer = 0
                                                    ' ''Dim str As String
                                                    ' ''Dim strAll As String = ""

                                                    ' ''For Each str In revs
                                                    ' ''    If str <> "" Then strAll = strAll & ": " & str
                                                    ' ''Next

                                                    ' ''MyNewRow("RevisionBlock") = strAll

                                                    ' ''Dim pnts As Point3dCollection = New Point3dCollection
                                                    ' ''Dim p1 As Point3d = New Point3d(39.84, 4.74, 0)
                                                    ' ''Dim p2 As Point3d = New Point3d(38.38, 1.92, 0)

                                                    ' ''pnts.Add(p1)
                                                    ' ''pnts.Add(p2)

                                                    ' ''Dim ss As SelectionSet = SSgetWindow(pnts)
                                                    ' ''Dim tbTxt As String = ""

                                                    ' ''If Not ss Is Nothing Then
                                                    ' ''    Dim typEntObj As Entity = trans.GetObject(ss(0).ObjectId, OpenMode.ForRead)
                                                    ' ''    Dim typObjClsName As String = typEntObj.GetRXClass.Name

                                                    ' ''    Select Case typObjClsName
                                                    ' ''        Case "AcDbMText"
                                                    ' ''            Dim mt As MText = trans.GetObject(ss(0).ObjectId, OpenMode.ForRead)
                                                    ' ''            tbTxt = ""

                                                    ' ''            tbTxt = mt.Contents()
                                                    ' ''            '  tbTxt = mt.Text()
                                                    ' ''            Dim repStr As String = tbTxt.Replace("\P", " ")

                                                    ' ''            MyNewRow("TitleBlock") = repStr
                                                    ' ''        Case "AcDbDBText"
                                                    ' ''            Dim tStr As String = ""
                                                    ' ''            For Each tEnt As Entity In ss
                                                    ' ''                Dim t As DBText = trans.GetObject(ss(0).ObjectId, OpenMode.ForRead)
                                                    ' ''                tStr = tStr & t.TextString
                                                    ' ''            Next
                                                    ' ''            MyNewRow("TitleBlock") = tStr & "---TS---"
                                                    ' ''    End Select
                                                    ' ''Else
                                                    ' ''    MyNewRow("TitleBlock") = "? ? ?"
                                                    ' ''End If

                                                    MyNewRow("RevisionBlock") = revs(0)

                                                    MyNewRow("TitleBlock") = Desc(0) & "; " & Desc(1) & "; " & Desc(2)

                                                    MyNewRow("ControlStamp") = xRefStr

                                                    Dim len As Integer = xRefStr.Length

                                                    cloneTable.Rows.Add(MyNewRow)

                                                    If rbtnPltwStoredSettings.Checked Then
                                                        Dim myrows As DataRow() = getPltInfFrmTbl("BlockName = '" & BlkName & "'")
                                                        modPlot.pltCurrLayout(MyRow.Item("PlotSettingsName").ToString, MyRow.Item("CurrentStyleSheet").ToString, MyRow.Item("PlotScale").ToString, MyRow.Item("CanonicalMediaName").ToString, MyRow.Item("PlotCentered").ToString)
                                                    End If

                                                    If rbtnPlt1to1.Checked Then modPlot.pltCurrLayout(StdScaleType.StdScale1To1, chkbxFade255.Checked)

                                                    ' ''If rbPltToFit.Checked And tbTxt <> "X" Then modPlot.pltCurrLayout(StdScaleType.ScaleToFit)

                                                    If rbPltToFit.Checked Then modPlot.pltCurrLayout(StdScaleType.ScaleToFit, chkbxFade255.Checked)

                                                    If rbtnPltLayoutsDWF1to1.Checked Then pltCurrLayoutDWF3(StdScaleType.StdScale1To1, chkbxFade255.Checked)

                                                    If rbtnMkDwfBook.Checked Then MessageBox.Show("Not Working Yet")

                                                    'Dim ed As Autodesk.AutoCAD.EditorInput.Editor = Doc.Editor
                                                    'ed.Regen()

                                                Case Else
                                            End Select
                                        End If
                                    Next
                                Case Else
                            End Select
                        Next
                    End If
                Next
                LayMan.CurrentLayout = currLayout
                ListBox3.Items.Add("") : trans.Commit() : docLock.Dispose()
            Finally
                trans.Dispose()
            End Try
            'If chkbxCloseAndSave.Checked Then Doc.CloseAndSave(item)
            'If chkbxCloseAndDiscard.Checked Then Doc.CloseAndDiscard()
            'Next
            dgBldLst.DataSource = cloneTable
        End Sub



        Dim xRefStr As String = ""

        Private Sub miOpnFlsGtLyts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miOpnFlsGtLyts.Click
            If cloneTable Is Nothing Then
                cloneTable = SqlDaComp.DataSet11.E044ReleasedDocuments.Clone() : cloneTable.PrimaryKey = Nothing
                cloneTable.Columns.Remove("DocumentNumberID") : cloneTable.Columns.Remove("DocumentReleaseNoticeNumber")
            End If

            Dim currLayout As String = ""
            Dim LayMan As LayoutManager = Nothing

            Dim Doc As Autodesk.AutoCAD.ApplicationServices.Document
            Dim db As Database = HostApplicationServices.WorkingDatabase
            Dim item As String

            lstBxXrefs.Items.Clear()

            For Each item In ListBox1.Items  ' add - check for images and xrefs
                If currLayout <> "" Then currLayout = ""
                '   Doc = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.Open(item, False)

                xRefStr = ""
                TestXrefPrint()
                'GetXrefList()

                db = Doc.Database : splitFName(Doc) : ListBox3.Items.Add(item)
                Dim lDic As Autodesk.AutoCAD.DatabaseServices.DBDictionary
                Dim lDicdEnt As System.Collections.DictionaryEntry
                Dim trans As Transaction = db.TransactionManager.StartTransaction()
                Dim docLock As DocumentLock = Doc.LockDocument()
                Try
                    lDic = trans.GetObject(db.LayoutDictionaryId, OpenMode.ForRead)
                    LayMan = LayoutManager.Current
                    If currLayout = "" Then currLayout = LayMan.CurrentLayout


                    Dim mySL As SortedList = New SortedList()

                    For Each lDicdEnt In lDic
                        Dim lOut As Layout = trans.GetObject(lDicdEnt.Value, OpenMode.ForRead)
                        mySL.Add(lOut.TabOrder, lOut.LayoutName)
                    Next

                    'For i As Integer = 0 To mySL.Count - 1
                    '    ListBox3.Items.Add(mySL.GetKey(i) & " - " & mySL.GetByIndex(i))
                    'Next

                    For i As Integer = 1 To mySL.Count - 1 ' 0 is model tab
                        'For Each lDicdEnt In lDic
                        LayMan.CurrentLayout = mySL.GetByIndex(i)

                        Dim lOut As Layout = trans.GetObject(lDic.GetAt(LayMan.CurrentLayout), OpenMode.ForRead) ' write causes lock violation?

                        ListBox3.Items.Add("Layout Name: " & lOut.LayoutName & " Tab Order: " & lOut.TabOrder)

                        If chkbxAllLayouts.Checked Then ' no title blocks, no model tab
                            Select Case lOut.LayoutName
                                Case Is <> "Model"

                                    Dim exMin As Point3d = Autodesk.AutoCAD.ApplicationServices.Application.GetSystemVariable("EXTMIN")
                                    Dim exMax As Point3d = Autodesk.AutoCAD.ApplicationServices.Application.GetSystemVariable("EXTMAX")

                                    If rbtnPlt1to1.Checked Then modPlot.pltCurrLayout(StdScaleType.ScaleToFit, chkbxFade255.Checked)

                                    Dim MyNewRow As DataRow = cloneTable.NewRow()
                                    MyNewRow("FileName") = splitStrAry(splitStrAry.Length - 1)
                                    MyNewRow("Layout") = lOut.LayoutName  ' lDicdEnt.Key

                                    MyNewRow("TitleBlock") = exMin.X.ToString("###,###.00") & ", " & exMin.Y.ToString("###,###.00") & ": " & exMax.X.ToString("###,###.00") & ", " & exMax.Y.ToString("###,###.00")

                                    cloneTable.Rows.Add(MyNewRow)
                                Case Else
                            End Select
                        Else

                            Dim btRec As BlockTableRecord
                            btRec = trans.GetObject(lOut.BlockTableRecordId, OpenMode.ForRead)
                            Dim myEntObjId As ObjectId
                            Dim myEntObj As Entity
                            For Each myEntObjId In btRec
                                myEntObj = trans.GetObject(myEntObjId, OpenMode.ForRead)
                                Dim ObjClsName As String = myEntObj.GetRXClass.Name
                                Dim BlkRefObj As BlockReference
                                Dim BlkTblRec As BlockTableRecord
                                Dim BlkRefObjName As String
                                Select Case ObjClsName
                                    Case "AcDbBlockReference" ' add - and has attributes ???
                                        LayMan.CurrentLayout = lOut.LayoutName

                                        BlkRefObj = trans.GetObject(myEntObjId, OpenMode.ForRead)
                                        BlkTblRec = trans.GetObject(BlkRefObj.BlockTableRecord, OpenMode.ForRead)

                                        'If BlkTblRec.IsFromExternalReference Then
                                        '    'MessageBox.Show("Found Xreference - What to do ??")
                                        '    lstBxXrefs.Items.Add("Doc: " & Doc.Name & " Is Overlay: " & BlkTblRec.IsFromOverlayReference & " Xref:  " & BlkTblRec.Name)
                                        '    xRefStr = xRefStr & "Doc: " & Doc.Name & " Is Overlay: " & BlkTblRec.IsFromOverlayReference & " Xref:  " & BlkTblRec.Name & vbCrLf
                                        'End If

                                        BlkRefObjName = BlkTblRec.Name
                                        Dim MyRow As DataRow : Dim BlkName As String ': Dim BlkType As String
                                        For Each MyRow In SqlDaComp.DataSet11.TrackingBlockNames ' could exclude some?
                                            If Not IsDBNull(MyRow(0)) Then
                                                BlkName = MyRow(0) ' is the name
                                                'BlkType = MyRow(1)
                                                Select Case BlkRefObjName
                                                    Case BlkName
                                                        Dim MyNewRow As DataRow = cloneTable.NewRow()
                                                        MyNewRow("FileName") = splitStrAry(splitStrAry.Length - 1)
                                                        MyNewRow("Layout") = lOut.LayoutName  ' lDicdEnt.Key
                                                        ListBox3.Items.Add(BlkRefObjName & "  Block Name")

                                                        If chkbxClrRevs.Checked Then UcRevisions1.ClrRevs() ' does the cur layout
                                                        If chkbxAddRevsFrmLst.Checked Then UcRevisions1.AddRevsFrmLst()
                                                        If chkbxAddNextRev.Checked Then UcRevisions1.AddNextRev()

                                                        If UcAttOptions1.chkbxCustomer.Checked Then putAtt(Doc, trans, lOut, "CUSTOMER")
                                                        If UcAttOptions1.chkbxProject.Checked Then putAtt(Doc, trans, lOut, "PROJECT")
                                                        If UcAttOptions1.chkbxLocation.Checked Then putAtt(Doc, trans, lOut, "LOCATION")
                                                        If UcAttOptions1.chkbxDesc_1.Checked Then putAtt(Doc, trans, lOut, "DESC_1")
                                                        If UcAttOptions1.chkbxDesc_2.Checked Then putAtt(Doc, trans, lOut, "DESC_2")
                                                        If UcAttOptions1.chkbxDesc_3.Checked Then putAtt(Doc, trans, lOut, "DESC_3")
                                                        If UcAttOptions1.chkbxScale.Checked Then putAtt(Doc, trans, lOut, "SCALE")

                                                        If UcAttOptions1.chkbxDwgPath.Checked Then putAtt(Doc, trans, lOut, "FILE")
                                                        If UcAttOptions1.chkbxFileLayAtt.Checked Then putAtt(Doc, trans, lOut, "DWG_NUM")

                                                        If UcAttOptions1.chkbxDrawnDate.Checked Then putAtt(Doc, trans, lOut, "DRW_DATE")
                                                        If UcAttOptions1.chkbxCheckedDate.Checked Then putAtt(Doc, trans, lOut, "CHKD_DATE")

                                                        If UcAttOptions1.chkbxDrawnBy.Checked Then putAtt(Doc, trans, lOut, "DRW")
                                                        If UcAttOptions1.chkbxCheckedBy.Checked Then putAtt(Doc, trans, lOut, "CHKD")

                                                        GetAtts(BlkRefObjName, BlkRefObj, trans)

                                                        Dim myComparer As myReverserClass = New myReverserClass
                                                        Array.Sort(revs) : Array.Sort(revs, myComparer)

                                                        '
                                                        ' ''Dim cnt As Integer = 0
                                                        ' ''Dim str As String
                                                        ' ''Dim strAll As String = ""

                                                        ' ''For Each str In revs
                                                        ' ''    If str <> "" Then strAll = strAll & ": " & str
                                                        ' ''Next

                                                        ' ''MyNewRow("RevisionBlock") = strAll

                                                        ' ''Dim pnts As Point3dCollection = New Point3dCollection
                                                        ' ''Dim p1 As Point3d = New Point3d(39.84, 4.74, 0)
                                                        ' ''Dim p2 As Point3d = New Point3d(38.38, 1.92, 0)

                                                        ' ''pnts.Add(p1)
                                                        ' ''pnts.Add(p2)

                                                        ' ''Dim ss As SelectionSet = SSgetWindow(pnts)
                                                        ' ''Dim tbTxt As String = ""

                                                        ' ''If Not ss Is Nothing Then
                                                        ' ''    Dim typEntObj As Entity = trans.GetObject(ss(0).ObjectId, OpenMode.ForRead)
                                                        ' ''    Dim typObjClsName As String = typEntObj.GetRXClass.Name

                                                        ' ''    Select Case typObjClsName
                                                        ' ''        Case "AcDbMText"
                                                        ' ''            Dim mt As MText = trans.GetObject(ss(0).ObjectId, OpenMode.ForRead)
                                                        ' ''            tbTxt = ""

                                                        ' ''            tbTxt = mt.Contents()
                                                        ' ''            '  tbTxt = mt.Text()
                                                        ' ''            Dim repStr As String = tbTxt.Replace("\P", " ")

                                                        ' ''            MyNewRow("TitleBlock") = repStr
                                                        ' ''        Case "AcDbDBText"
                                                        ' ''            Dim tStr As String = ""
                                                        ' ''            For Each tEnt As Entity In ss
                                                        ' ''                Dim t As DBText = trans.GetObject(ss(0).ObjectId, OpenMode.ForRead)
                                                        ' ''                tStr = tStr & t.TextString
                                                        ' ''            Next
                                                        ' ''            MyNewRow("TitleBlock") = tStr & "---TS---"
                                                        ' ''    End Select
                                                        ' ''Else
                                                        ' ''    MyNewRow("TitleBlock") = "? ? ?"
                                                        ' ''End If

                                                        MyNewRow("RevisionBlock") = revs(0)

                                                        MyNewRow("TitleBlock") = Desc(0) & "; " & Desc(1) & "; " & Desc(2)

                                                        MyNewRow("ControlStamp") = xRefStr

                                                        Dim len As Integer = xRefStr.Length

                                                        cloneTable.Rows.Add(MyNewRow)

                                                        If rbtnPltwStoredSettings.Checked Then
                                                            Dim myrows As DataRow() = getPltInfFrmTbl("BlockName = '" & BlkName & "'")
                                                            modPlot.pltCurrLayout(MyRow.Item("PlotSettingsName").ToString, MyRow.Item("CurrentStyleSheet").ToString, MyRow.Item("PlotScale").ToString, MyRow.Item("CanonicalMediaName").ToString, MyRow.Item("PlotCentered").ToString)
                                                        End If

                                                        If rbtnPlt1to1.Checked Then modPlot.pltCurrLayout(StdScaleType.StdScale1To1, chkbxFade255.Checked)

                                                        ' ''If rbPltToFit.Checked And tbTxt <> "X" Then modPlot.pltCurrLayout(StdScaleType.ScaleToFit)

                                                        If rbPltToFit.Checked Then modPlot.pltCurrLayout(StdScaleType.ScaleToFit, chkbxFade255.Checked)

                                                        If rbtnPltLayoutsDWF1to1.Checked Then pltCurrLayoutDWF3(StdScaleType.StdScale1To1, chkbxFade255.Checked)

                                                        If rbtnMkDwfBook.Checked Then MessageBox.Show("Not Working Yet")

                                                        'Dim ed As Autodesk.AutoCAD.EditorInput.Editor = Doc.Editor
                                                        'ed.Regen()

                                                    Case Else
                                                End Select
                                            End If
                                        Next
                                    Case Else
                                End Select
                            Next
                        End If
                    Next
                    LayMan.CurrentLayout = currLayout
                    ListBox3.Items.Add("") : trans.Commit() : docLock.Dispose()
                Finally
                    trans.Dispose()
                End Try
                'If chkbxCloseAndSave.Checked Then Doc.CloseAndSave(item)
                'If chkbxCloseAndDiscard.Checked Then Doc.CloseAndDiscard()
            Next
            dgBldLst.DataSource = cloneTable
        End Sub

        Public Sub GetXrefList()

            Dim Doc As Document = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument
            Dim Ed As Editor = Doc.Editor
            Dim Db As Database = Doc.Database
            Dim Tr As Transaction = Db.TransactionManager.StartTransaction()

            Using Tr
                Dim DbXrGraph As XrefGraph = Db.GetHostDwgXrefGraph(False)

                ' look at all Nodes in the XrefGraph.  Skip 0 node since it is the drawing itself.
                For i As Integer = 1 To DbXrGraph.NumNodes - 1
                    Dim XrGraphNode As XrefGraphNode = DbXrGraph.GetXrefNode(i)
                    If Not XrGraphNode.IsNested Then
                        Dim btr As BlockTableRecord = DirectCast(Tr.GetObject(XrGraphNode.BlockTableRecordId, OpenMode.ForRead), BlockTableRecord)
                        ' Print Xref at the top of the Chain

                        lstBxXrefs.Items.Add(vbNewLine & "TOP:" & XrGraphNode.Name)

                        'Ed.WriteMessage(vbNewLine & "TOP:" & XrGraphNode.Name)
                        getSubReference(Tr, XrGraphNode.BlockTableRecordId, Ed)
                    End If

                Next
            End Using

        End Sub

        Private Function getSubReference(ByRef Tr As Transaction, ByVal BlockID As ObjectId, ByRef Ed As Editor) As Boolean
            Dim btr As BlockTableRecord = DirectCast(Tr.GetObject(BlockID, OpenMode.ForRead), BlockTableRecord)
            Dim hasXref As Boolean = False
            Dim iter As BlockTableRecordEnumerator = btr.GetEnumerator

            While iter.MoveNext
                Dim ent As Entity = iter.Current.GetObject(OpenMode.ForRead)

                If TypeName(ent) = "BlockReference" Then
                    Dim BR As BlockReference = CType(ent, BlockReference)
                    Dim nBTR As BlockTableRecord = Tr.GetObject(BR.BlockTableRecord, OpenMode.ForRead)
                    ' Check if Xref exists
                    If nBTR.IsFromExternalReference Then 'And nBTR.IsResolved Then
                        If getSubReference(Tr, nBTR.ObjectId, Ed) Then
                            ' Print Xref that links to another xref
                            lstBxXrefs.Items.Add(vbNewLine & "Middle: " & btr.Name & " Sub: " & nBTR.Name)
                            ' Ed.WriteMessage(vbNewLine & "Middle: " & btr.Name & " Sub: " & nBTR.Name)
                        Else
                            lstBxXrefs.Items.Add(vbNewLine & "end:" & btr.Name & " Sub: " & nBTR.Name)
                            ' Print Xref at the end of the chain
                            'Ed.WriteMessage(vbNewLine & "end:" & btr.Name & " Sub: " & nBTR.Name)
                        End If
                        hasXref = True
                    End If
                End If

            End While

            Return hasXref

        End Function


        Public Sub TestXrefPrint()
            Dim Doc As Document = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument
            Dim Db As Database = Doc.Database
            Dim Ed As Editor = Doc.Editor
            Dim XrGraph As XrefGraph = Db.GetHostDwgXrefGraph(False)
            For i As Integer = 1 To XrGraph.NumNodes - 1
                Dim XrNode As XrefGraphNode = XrGraph.GetXrefNode(i)

                Dim BlkTblRec As BlockTableRecord
                Dim trans As Transaction = Db.TransactionManager.StartTransaction()
                Dim docLock As DocumentLock = Doc.LockDocument()
                BlkTblRec = trans.GetObject(XrNode.BlockTableRecordId, OpenMode.ForRead)


                lstBxXrefs.Items.Add("OL: " & BlkTblRec.IsFromOverlayReference & " : " & XrNode.Name)
                xRefStr = xRefStr & "OL: " & BlkTblRec.IsFromOverlayReference & " : " & XrNode.Name & vbCrLf
                'Ed.WriteMessage(vbLf & " Name: {0}", XrNode.Name)
                For j As Integer = 0 To XrNode.NumIn - 1
                    Dim tempInt As Integer = IsXrNodeEqual(XrGraph, XrNode.[In](j))
                    If tempInt.Equals(-1) Then
                        Continue For
                    End If
                    lstBxXrefs.Items.Add("Is In:  " & XrGraph.GetXrefNode(tempInt).Name)
                    xRefStr = xRefStr & "Is In:  " & XrGraph.GetXrefNode(tempInt).Name & vbCrLf
                    'Ed.WriteMessage(vbLf & " Is In: {0}", XrGraph.GetXrefNode(tempInt).Name)
                Next
                For j As Integer = 0 To XrNode.NumOut - 1
                    Dim tempInt As Integer = IsXrNodeEqual(XrGraph, XrNode.Out(j))
                    If tempInt.Equals(-1) Then
                        Continue For
                    End If
                    lstBxXrefs.Items.Add("Has within:  " & XrGraph.GetXrefNode(tempInt).Name)
                    xRefStr = xRefStr & "Has within:  " & XrGraph.GetXrefNode(tempInt).Name & vbCrLf
                    'Ed.WriteMessage(vbLf & " Has within: {0}", XrGraph.GetXrefNode(tempInt).Name)
                Next
                lstBxXrefs.Items.Add("")
                'Ed.WriteMessage(vbLf)

                trans.Commit() : docLock.Dispose()
                trans.Dispose()
            Next
        End Sub


        Public Function IsXrNodeEqual(ByVal xrGraph As XrefGraph, ByVal grNode As GraphNode) As Integer
            For i As Integer = 0 To xrGraph.NumNodes - 1
                If grNode = TryCast(xrGraph.GetXrefNode(i), GraphNode) Then
                    Return i
                End If
            Next
            Return -1
        End Function



        ' Dim revs(50) As String
        Dim revs() As String = {"", "", "", "", "", ""}
        Dim Desc() As String = {"", "", ""}

        Private Sub GetAtts(ByVal BlkRefObjName As String, ByVal BlkRefObj As BlockReference, ByVal trans As Transaction)
            Dim AttObjID As ObjectId
            Dim AttCol As Autodesk.AutoCAD.DatabaseServices.AttributeCollection
            Dim Att As AttributeReference
            AttCol = BlkRefObj.AttributeCollection

            'Dim cnt As Integer = 0
            'For Each AttObjID In AttCol
            '    Att = trans.GetObject(AttObjID, OpenMode.ForRead)

            '    revs.SetValue(Att.TextString, cnt)
            '    cnt = cnt + 1

            'Next


            For Each AttObjID In AttCol
                Att = trans.GetObject(AttObjID, OpenMode.ForRead)
                ListBox3.Items.Add(Att.Tag & "   " & Att.TextString)

                Try ' could get from db
                    If Att.Tag = "REV1" Then revs.SetValue(Att.TextString, 0)
                    If Att.Tag = "REV2" Then revs.SetValue(Att.TextString, 1)
                    If Att.Tag = "REV3" Then revs.SetValue(Att.TextString, 2)
                    If Att.Tag = "REV4" Then revs.SetValue(Att.TextString, 3)
                    If Att.Tag = "REV5" Then revs.SetValue(Att.TextString, 4)
                    If Att.Tag = "REV6" Then revs.SetValue(Att.TextString, 5)
                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                End Try
                Try ' could get from db
                    If Att.Tag = "DESC_1" Then Desc.SetValue(Att.TextString, 0)
                    If Att.Tag = "DESC_2" Then Desc.SetValue(Att.TextString, 1)
                    If Att.Tag = "DESC_3" Then Desc.SetValue(Att.TextString, 2)
                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                End Try
            Next
            ListBox3.Items.Add("")
        End Sub

        Private Function getRevAttFrmTbl(ByVal strExpr As String) As DataRow()
            Dim strSort As String = "BlockName DESC"
            Dim foundRows As DataRow() = _
            SqlDaComp.DataSet11.Tables("TrackingBlockNames").Select(strExpr, strSort, DataViewRowState.CurrentRows)
            Return foundRows
        End Function

        Private Function getPltInfFrmTbl(ByVal strExpr As String) As DataRow()
            Dim strSort As String = "BlockName DESC"
            Dim foundRows As DataRow() = _
            SqlDaComp.DataSet11.Tables("TrackingBlockNames").Select(strExpr, strSort, DataViewRowState.ModifiedCurrent)
            Return foundRows
        End Function

        Private Sub miClrCloneTbl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miClrCloneTbl.Click
            cloneTable.Clear()
            cloneTable = Nothing
        End Sub

        Private Sub GroupBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupBox1.DoubleClick
            rbPltToFit.Checked = False
            rbtnPlt1to1.Checked = False
            rbtnPltwStoredSettings.Checked = False
            rbtnPltLayoutsDWF1to1.Checked = False
            rbtnMkDwfBook.Checked = False

        End Sub

        Private Sub btnShowBrowserForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowBrowserForm.Click
            'Dim frmBrowser As New BrowserForm
            'frmBrowser.Show()
        End Sub

        Private Sub btnShowBlockMan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowBlockMan.Click
            'Dim frmBlocMan As New frmBlockMan
            'frmBlocMan.Show()
        End Sub


        Friend Shared Function SSgetWindow(ByVal PntCol As Point3dCollection, Optional ByVal SSFilter() As TypedValue = Nothing, Optional ByVal RejLkdLyr As Boolean = True, Optional ByVal RejNonSpc As Boolean = True, Optional ByVal RetSubs As Boolean = False, Optional ByVal Crossing As Boolean = True) As SelectionSet
            Dim prSelRes As PromptSelectionResult
            Dim prselops As New PromptSelectionOptions
            Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
            prselops.RejectObjectsOnLockedLayers = RejLkdLyr
            prselops.RejectObjectsFromNonCurrentSpace = RejNonSpc
            prselops.ForceSubSelections = RetSubs
            prselops.AllowSubSelections = RetSubs
            prselops.PrepareOptionalDetails = True
            Try
                If Not IsNothing(SSFilter) Then
                    Dim prEntFil As SelectionFilter
                    prEntFil = New SelectionFilter(SSFilter)
                    If Crossing Then
                        If PntCol.Count > 2 Then
                            prSelRes = ed.SelectCrossingPolygon(PntCol, prEntFil)
                        ElseIf PntCol.Count = 2 Then
                            prSelRes = ed.SelectCrossingWindow(PntCol.Item(0), PntCol.Item(1), prEntFil)
                        Else
                            prSelRes = Nothing
                            ed.WriteMessage("Invalid Point List!" & vbCrLf)
                        End If
                    Else
                        If PntCol.Count = 2 Then
                            prSelRes = ed.SelectWindow(PntCol.Item(0), PntCol.Item(1), prEntFil)
                        ElseIf PntCol.Count > 2 Then
                            prSelRes = ed.SelectWindowPolygon(PntCol, prEntFil)
                        Else
                            prSelRes = Nothing
                            ed.WriteMessage("Invalid Point List!" & vbCrLf)
                        End If
                    End If
                Else
                    If Crossing Then
                        If PntCol.Count = 2 Then
                            prSelRes = ed.SelectCrossingWindow(PntCol.Item(0), PntCol.Item(1))
                        ElseIf PntCol.Count > 2 Then
                            prSelRes = ed.SelectCrossingPolygon(PntCol)
                        Else
                            prSelRes = Nothing
                            ed.WriteMessage("Invalid Point List!" & vbCrLf)
                        End If
                    Else
                        If PntCol.Count = 2 Then
                            prSelRes = ed.SelectWindow(PntCol.Item(0), PntCol.Item(1))
                        ElseIf PntCol.Count > 2 Then
                            prSelRes = ed.SelectWindowPolygon(PntCol)
                        Else
                            prSelRes = Nothing
                            ed.WriteMessage("Invalid Point List!" & vbCrLf)
                        End If
                    End If
                End If
                Select Case prSelRes.Status
                    Case PromptStatus.Error, PromptStatus.None, PromptStatus.Other
                        Return Nothing
                    Case PromptStatus.OK
                    Case Else
                        Return Nothing
                End Select
            Catch ex As System.Exception
                ed.WriteMessage(ex.Message & " In: " & ex.Source & vbCrLf & ex.StackTrace & vbCrLf)
                Return Nothing
            Finally
                ed = Nothing
            End Try
            Return prSelRes.Value
        End Function




        
    End Class

End Namespace
