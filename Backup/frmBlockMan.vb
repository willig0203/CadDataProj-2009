Option Strict Off
Option Explicit On 

Imports System
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports System.Environment

Imports Autodesk.AutoCAD.EditorInput
Imports Autodesk.AutoCAD.ApplicationServices
Imports Autodesk.AutoCAD.DatabaseServices
Imports Autodesk.AutoCAD.Geometry

Imports rnsCadDataProj.nsMods

Imports vbAccelerator.Components.Shell

'Imports AxExpressViewerDll



Namespace nsForms

    <CLSCompliant(False)> _
    Public Class frmBlockMan
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
        Public WithEvents LblDwgCount As System.Windows.Forms.Label
        Public WithEvents CmdExplore As System.Windows.Forms.Button
        Public WithEvents Refresh_Renamed As System.Windows.Forms.Button
        Public WithEvents SSTab1 As System.Windows.Forms.TabControl
        Public WithEvents _SSTab1_TabPage0 As System.Windows.Forms.TabPage
        Public WithEvents Drive1 As Microsoft.VisualBasic.Compatibility.VB6.DriveListBox
        Public WithEvents Dir1 As Microsoft.VisualBasic.Compatibility.VB6.DirListBox
        Public WithEvents _SSTab1_TabPage1 As System.Windows.Forms.TabPage
        Public WithEvents List1 As System.Windows.Forms.ListBox
        Public WithEvents File1 As Microsoft.VisualBasic.Compatibility.VB6.FileListBox
        Public WithEvents HScroll1 As System.Windows.Forms.HScrollBar
        Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
        Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
        Friend WithEvents btnExit As System.Windows.Forms.Button
        Friend WithEvents miInsertFile As System.Windows.Forms.MenuItem
        Friend WithEvents cbxScale As System.Windows.Forms.ComboBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents ilsIcons As System.Windows.Forms.ImageList
        Friend WithEvents lvwThumbNails As System.Windows.Forms.ListView
        Friend WithEvents miOpenFile As System.Windows.Forms.MenuItem
        Friend WithEvents miZoomAndSave As System.Windows.Forms.MenuItem
        Friend WithEvents tlp1 As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents cbxImageSize As System.Windows.Forms.ComboBox
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Me.LblDwgCount = New System.Windows.Forms.Label
            Me.CmdExplore = New System.Windows.Forms.Button
            Me.Refresh_Renamed = New System.Windows.Forms.Button
            Me.SSTab1 = New System.Windows.Forms.TabControl
            Me._SSTab1_TabPage0 = New System.Windows.Forms.TabPage
            Me.Drive1 = New Microsoft.VisualBasic.Compatibility.VB6.DriveListBox
            Me.Dir1 = New Microsoft.VisualBasic.Compatibility.VB6.DirListBox
            Me._SSTab1_TabPage1 = New System.Windows.Forms.TabPage
            Me.List1 = New System.Windows.Forms.ListBox
            Me.File1 = New Microsoft.VisualBasic.Compatibility.VB6.FileListBox
            Me.HScroll1 = New System.Windows.Forms.HScrollBar
            Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
            Me.miInsertFile = New System.Windows.Forms.MenuItem
            Me.miOpenFile = New System.Windows.Forms.MenuItem
            Me.miZoomAndSave = New System.Windows.Forms.MenuItem
            Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
            Me.btnExit = New System.Windows.Forms.Button
            Me.cbxScale = New System.Windows.Forms.ComboBox
            Me.Label2 = New System.Windows.Forms.Label
            Me.ilsIcons = New System.Windows.Forms.ImageList(Me.components)
            Me.lvwThumbNails = New System.Windows.Forms.ListView
            Me.cbxImageSize = New System.Windows.Forms.ComboBox
            Me.tlp1 = New System.Windows.Forms.TableLayoutPanel
            Me.SSTab1.SuspendLayout()
            Me._SSTab1_TabPage0.SuspendLayout()
            Me._SSTab1_TabPage1.SuspendLayout()
            Me.SuspendLayout()
            '
            'LblDwgCount
            '
            Me.LblDwgCount.BackColor = System.Drawing.SystemColors.Control
            Me.LblDwgCount.Cursor = System.Windows.Forms.Cursors.Default
            Me.LblDwgCount.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblDwgCount.ForeColor = System.Drawing.SystemColors.ControlText
            Me.LblDwgCount.Location = New System.Drawing.Point(16, 8)
            Me.LblDwgCount.Name = "LblDwgCount"
            Me.LblDwgCount.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.LblDwgCount.Size = New System.Drawing.Size(104, 17)
            Me.LblDwgCount.TabIndex = 44
            Me.LblDwgCount.Text = "Dwg Count"
            '
            'CmdExplore
            '
            Me.CmdExplore.BackColor = System.Drawing.SystemColors.Control
            Me.CmdExplore.Cursor = System.Windows.Forms.Cursors.Default
            Me.CmdExplore.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CmdExplore.ForeColor = System.Drawing.SystemColors.ControlText
            Me.CmdExplore.Location = New System.Drawing.Point(112, 8)
            Me.CmdExplore.Name = "CmdExplore"
            Me.CmdExplore.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.CmdExplore.Size = New System.Drawing.Size(65, 26)
            Me.CmdExplore.TabIndex = 81
            Me.CmdExplore.Text = "Explore"
            Me.CmdExplore.UseVisualStyleBackColor = False
            '
            'Refresh_Renamed
            '
            Me.Refresh_Renamed.BackColor = System.Drawing.SystemColors.Control
            Me.Refresh_Renamed.Cursor = System.Windows.Forms.Cursors.Default
            Me.Refresh_Renamed.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Refresh_Renamed.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Refresh_Renamed.Location = New System.Drawing.Point(176, 8)
            Me.Refresh_Renamed.Name = "Refresh_Renamed"
            Me.Refresh_Renamed.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Refresh_Renamed.Size = New System.Drawing.Size(64, 26)
            Me.Refresh_Renamed.TabIndex = 80
            Me.Refresh_Renamed.Text = "Refresh"
            Me.Refresh_Renamed.UseVisualStyleBackColor = False
            '
            'SSTab1
            '
            Me.SSTab1.Controls.Add(Me._SSTab1_TabPage0)
            Me.SSTab1.Controls.Add(Me._SSTab1_TabPage1)
            Me.SSTab1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.SSTab1.ItemSize = New System.Drawing.Size(42, 18)
            Me.SSTab1.Location = New System.Drawing.Point(8, 40)
            Me.SSTab1.Name = "SSTab1"
            Me.SSTab1.SelectedIndex = 0
            Me.SSTab1.Size = New System.Drawing.Size(320, 409)
            Me.SSTab1.TabIndex = 83
            '
            '_SSTab1_TabPage0
            '
            Me._SSTab1_TabPage0.Controls.Add(Me.Drive1)
            Me._SSTab1_TabPage0.Controls.Add(Me.Dir1)
            Me._SSTab1_TabPage0.Location = New System.Drawing.Point(4, 22)
            Me._SSTab1_TabPage0.Name = "_SSTab1_TabPage0"
            Me._SSTab1_TabPage0.Size = New System.Drawing.Size(312, 383)
            Me._SSTab1_TabPage0.TabIndex = 0
            Me._SSTab1_TabPage0.Text = "Directory"
            '
            'Drive1
            '
            Me.Drive1.BackColor = System.Drawing.SystemColors.Window
            Me.Drive1.Cursor = System.Windows.Forms.Cursors.Default
            Me.Drive1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Drive1.ForeColor = System.Drawing.SystemColors.WindowText
            Me.Drive1.FormattingEnabled = True
            Me.Drive1.Location = New System.Drawing.Point(8, 8)
            Me.Drive1.Name = "Drive1"
            Me.Drive1.Size = New System.Drawing.Size(296, 21)
            Me.Drive1.TabIndex = 81
            '
            'Dir1
            '
            Me.Dir1.BackColor = System.Drawing.SystemColors.Window
            Me.Dir1.Cursor = System.Windows.Forms.Cursors.Default
            Me.Dir1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Dir1.ForeColor = System.Drawing.SystemColors.WindowText
            Me.Dir1.FormattingEnabled = True
            Me.Dir1.IntegralHeight = False
            Me.Dir1.Location = New System.Drawing.Point(8, 32)
            Me.Dir1.Name = "Dir1"
            Me.Dir1.Size = New System.Drawing.Size(296, 344)
            Me.Dir1.TabIndex = 81
            '
            '_SSTab1_TabPage1
            '
            Me._SSTab1_TabPage1.Controls.Add(Me.List1)
            Me._SSTab1_TabPage1.Controls.Add(Me.File1)
            Me._SSTab1_TabPage1.Location = New System.Drawing.Point(4, 22)
            Me._SSTab1_TabPage1.Name = "_SSTab1_TabPage1"
            Me._SSTab1_TabPage1.Size = New System.Drawing.Size(312, 383)
            Me._SSTab1_TabPage1.TabIndex = 1
            Me._SSTab1_TabPage1.Text = "Drawings"
            Me._SSTab1_TabPage1.Visible = False
            '
            'List1
            '
            Me.List1.BackColor = System.Drawing.SystemColors.Window
            Me.List1.Cursor = System.Windows.Forms.Cursors.Default
            Me.List1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.List1.ForeColor = System.Drawing.SystemColors.WindowText
            Me.List1.ItemHeight = 14
            Me.List1.Location = New System.Drawing.Point(24, 160)
            Me.List1.Name = "List1"
            Me.List1.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.List1.Size = New System.Drawing.Size(193, 46)
            Me.List1.TabIndex = 81
            Me.List1.Visible = False
            '
            'File1
            '
            Me.File1.BackColor = System.Drawing.SystemColors.Window
            Me.File1.Cursor = System.Windows.Forms.Cursors.Default
            Me.File1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.File1.ForeColor = System.Drawing.SystemColors.WindowText
            Me.File1.FormattingEnabled = True
            Me.File1.Location = New System.Drawing.Point(8, 8)
            Me.File1.Name = "File1"
            Me.File1.Pattern = "*.dwg"
            Me.File1.Size = New System.Drawing.Size(296, 368)
            Me.File1.TabIndex = 81
            '
            'HScroll1
            '
            Me.HScroll1.Cursor = System.Windows.Forms.Cursors.Default
            Me.HScroll1.LargeChange = 1
            Me.HScroll1.Location = New System.Drawing.Point(8, 464)
            Me.HScroll1.Maximum = 32767
            Me.HScroll1.Name = "HScroll1"
            Me.HScroll1.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.HScroll1.Size = New System.Drawing.Size(249, 16)
            Me.HScroll1.TabIndex = 84
            Me.HScroll1.TabStop = True
            '
            'ContextMenu1
            '
            Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miInsertFile, Me.miOpenFile, Me.miZoomAndSave})
            '
            'miInsertFile
            '
            Me.miInsertFile.Index = 0
            Me.miInsertFile.Text = "InsertFile (s)"
            '
            'miOpenFile
            '
            Me.miOpenFile.Index = 1
            Me.miOpenFile.Text = "OpenFile (s)"
            '
            'miZoomAndSave
            '
            Me.miZoomAndSave.Index = 2
            Me.miZoomAndSave.Text = "Zoom And Save ()"
            '
            'btnExit
            '
            Me.btnExit.Location = New System.Drawing.Point(16, 488)
            Me.btnExit.Name = "btnExit"
            Me.btnExit.Size = New System.Drawing.Size(75, 23)
            Me.btnExit.TabIndex = 86
            Me.btnExit.Text = "Exit"
            '
            'cbxScale
            '
            Me.cbxScale.Items.AddRange(New Object() {"0.125", "0.25", "0.5", "1.0", "1.5", "2.0", "2.5"})
            Me.cbxScale.Location = New System.Drawing.Point(840, 16)
            Me.cbxScale.Name = "cbxScale"
            Me.cbxScale.Size = New System.Drawing.Size(104, 21)
            Me.cbxScale.TabIndex = 87
            Me.cbxScale.Text = "ComboBox1"
            '
            'Label2
            '
            Me.Label2.Location = New System.Drawing.Point(848, 0)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(48, 16)
            Me.Label2.TabIndex = 88
            Me.Label2.Text = "Scale"
            '
            'ilsIcons
            '
            Me.ilsIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
            Me.ilsIcons.ImageSize = New System.Drawing.Size(100, 100)
            Me.ilsIcons.TransparentColor = System.Drawing.Color.Transparent
            '
            'lvwThumbNails
            '
            Me.lvwThumbNails.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lvwThumbNails.ContextMenu = Me.ContextMenu1
            Me.lvwThumbNails.LargeImageList = Me.ilsIcons
            Me.lvwThumbNails.Location = New System.Drawing.Point(328, 43)
            Me.lvwThumbNails.Name = "lvwThumbNails"
            Me.lvwThumbNails.Size = New System.Drawing.Size(616, 541)
            Me.lvwThumbNails.TabIndex = 89
            Me.lvwThumbNails.UseCompatibleStateImageBehavior = False
            '
            'cbxImageSize
            '
            Me.cbxImageSize.Items.AddRange(New Object() {"75", "100", "125"})
            Me.cbxImageSize.Location = New System.Drawing.Point(704, 16)
            Me.cbxImageSize.Name = "cbxImageSize"
            Me.cbxImageSize.Size = New System.Drawing.Size(121, 21)
            Me.cbxImageSize.TabIndex = 90
            Me.cbxImageSize.Text = "Image Size"
            Me.cbxImageSize.Visible = False
            '
            'tlp1
            '
            Me.tlp1.ColumnCount = 8
            Me.tlp1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
            Me.tlp1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
            Me.tlp1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
            Me.tlp1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
            Me.tlp1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
            Me.tlp1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
            Me.tlp1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
            Me.tlp1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
            Me.tlp1.Location = New System.Drawing.Point(353, 8)
            Me.tlp1.Name = "tlp1"
            Me.tlp1.RowCount = 8
            Me.tlp1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
            Me.tlp1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
            Me.tlp1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
            Me.tlp1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
            Me.tlp1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
            Me.tlp1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
            Me.tlp1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
            Me.tlp1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
            Me.tlp1.Size = New System.Drawing.Size(90, 29)
            Me.tlp1.TabIndex = 91
            '
            'frmBlockMan
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(952, 590)
            Me.Controls.Add(Me.tlp1)
            Me.Controls.Add(Me.cbxImageSize)
            Me.Controls.Add(Me.lvwThumbNails)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.cbxScale)
            Me.Controls.Add(Me.btnExit)
            Me.Controls.Add(Me.HScroll1)
            Me.Controls.Add(Me.SSTab1)
            Me.Controls.Add(Me.CmdExplore)
            Me.Controls.Add(Me.Refresh_Renamed)
            Me.Controls.Add(Me.LblDwgCount)
            Me.Name = "frmBlockMan"
            Me.Text = "frmBlockMan"
            Me.SSTab1.ResumeLayout(False)
            Me._SSTab1_TabPage0.ResumeLayout(False)
            Me._SSTab1_TabPage1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

#End Region

        Dim DwgThumb As Object
        Dim i As Short
        Dim DwgLstArray(0, 0) As String
        Dim TFiles As Short
        Dim NPages As Short
        Dim NSpaces As Short
        Dim frm As Form = Me.FindForm()

        Private Sub DefineArray()
            On Error Resume Next
            Dim g As Integer
            Dim f As Integer
            Dim h As Integer
            TFiles = File1.Items.Count
            NPages = Int((TFiles / 30) + 1)
            NSpaces = Int((TFiles / 30) + 1) * 30 - (TFiles)
            If TFiles = 30 Then
                NPages = 1
                NSpaces = 0
            End If
            List1.Items.Clear()
            ReDim DwgLstArray(NPages - 1, 29)
            h = 0
            For f = 0 To NPages - 1
                For g = 0 To 29
                    DwgLstArray(f, g) = File1.Items(h)
                    h = h + 1
                Next g
                If File1.Items.Count <> 0 Then List1.Items.Add(f)
            Next f
            If File1.Items.Count <> 0 Then
                HScroll1.Maximum = (List1.Items.Count - 1 + HScroll1.LargeChange - 1)
                HScroll1.Enabled = True
                HScroll1.Value = 0
            Else
                HScroll1.Enabled = False
            End If
            If File1.Items.Count = 0 Then
                '   AxDwgThumbnail60.DwgFileName = "" : AxDwgThumbnail60.Refresh()
            End If
            Me.Text = "Block Man"
        End Sub

        Private Sub CmdExplore_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdExplore.Click
            Dim sysFldr As String : Dim delim As Char = "\" : Dim strArray As String()
            sysFldr = GetFolderPath(SpecialFolder.System) : strArray = sysFldr.Split(delim)
            Dim RetVal As Object = Shell(strArray(0) & "\" & strArray(1) & "\explorer.EXE " & Dir1.Path, AppWinStyle.NormalFocus, False, )
        End Sub

        Private Sub File1_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles File1.SelectedIndexChanged
            MsgBox("Programming to come ...")
        End Sub

        Private Sub Drive1_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Drive1.SelectedIndexChanged
            Dir1.Path = Drive1.Drive ' Set directory path.
        End Sub

        Public Sub Dir1_Change(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Dir1.Change
            On Error Resume Next '???????
            File1.Path = Dir1.Path
            DefineArray()
            If List1.Items.Count <> 0 Then
                List1.SetSelected(0, True) 'this fires the list1_click
            Else
                lvwThumbNails.Items.Clear()
            End If
            LblDwgCount.Text = File1.Items.Count & "   Dwg(s)"
            'FolderViewer1.RootPath = Dir1.Path
        End Sub

        Private Sub miInsertFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miInsertFile.Click
            Dim itm As ListViewItem
            For Each itm In lvwThumbNails.SelectedItems
                InsertFile2(itm.Text)
            Next itm
            ' Dim itm As ListViewItem = lvwThumbNails.SelectedItems.Item(0) : InsertFile2(itm.Text)
        End Sub

        Private Sub InsertFile2(ByVal fullName As String)
            Dim tbl As New Table
            Dim bt As BlockTable
            Dim btr As BlockTableRecord
            Dim db As Database = HostApplicationServices.WorkingDatabase
            Dim trans As Transaction
            trans = db.TransactionManager.StartTransaction()

            Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor

            frm.Hide()
            Dim tblPnt As PromptPointOptions = New PromptPointOptions("Select Insertion Point...")
            Dim tblPntRes As PromptPointResult = ed.GetPoint(tblPnt)
            If tblPntRes.Status <> PromptStatus.OK Then
                frm.Show()
                Return
            End If

            Dim DocCol As DocumentCollection = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager
            Dim docLock As DocumentLock = DocCol.MdiActiveDocument.LockDocument()
            'Dim fullName As String
            'If Label1.Text <> "" Then
            'fullName = Label1.Text    '"C:\Gary\Cad Files\Stamp.dwg"
            'End If

            'If Not File.Exists(fname) Then
            'fname = HostApplicationServices.Current.FindFile(fname, DocCol.MdiActiveDocument.Database, FindFileHint.Default)
            'End If

            Dim ndb As Database = New Database(False, False)
            ndb.ReadDwgFile(fullName, FileShare.Read, True, Nothing)
            splitFName(fullName)
            Dim fName As String = (splitStrAry(splitStrAry.Length - 1))
            fName = fName.Replace(".dwg", "")
            fName = fName.Replace(".DWG", "")

            Dim idBTR As ObjectId = DocCol.MdiActiveDocument.Database.Insert(fName, ndb, False)
            Dim bref As BlockReference = New BlockReference(tblPntRes.Value, idBTR)
            Dim theScale As Scale3d = New Scale3d(cbxScale.SelectedItem, cbxScale.SelectedItem, cbxScale.SelectedItem)
            bref.ScaleFactors = theScale
            'bref.Rotation = angR

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
                Try : btr.AppendEntity(bref)
                    trans.AddNewlyCreatedDBObject(bref, True)
                Finally : bref.Dispose()
                End Try
                trans.Commit()
            Finally
                docLock.Dispose() : trans.Dispose()
                frm.Show()
            End Try

        End Sub

        Private Sub frmBlockMan_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            '  If AcadAppConnected() = False Then AcadAppConnected()
            '  If ActiveDocFound() = False Then ActiveDocFound()
            Dir1.Path = "C:\Documents and Settings\willig01\Desktop"
            File1.Pattern = "*.dwg"
            Try
                If Not FolderName Is Nothing Then Drive1.Drive = FolderName
                If Not FolderName Is Nothing Then Dir1.Path = FolderName
                ' If Not FolderName Is Nothing Then FolderViewer1.RootPath = FolderName

            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
            cbxScale.SelectedIndex = 2

            'lvwThumbNails.Columns.Add("Name")
            'lvwThumbNails.View = View.Details

        End Sub

        Private Sub addThumbNail(ByVal fileName As String)


            'Dim evc As New AxCExpressViewerControl
            'evc.SourcePath = fileName
            'tlp1.Controls.Add(evc)

            Dim t As ThumbnailCreator = New ThumbnailCreator
            Dim thumb As Bitmap = Nothing
            Try
                thumb = t.GetThumbNail(fileName)
            Catch ex As Exception
                '   MessageBox.Show(Me, String.Format("Failed to get thumbnail: {0}", ex.Message), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
            If Not (thumb Is Nothing) Then
                ilsIcons.Images.Add(thumb)
                Dim listItem As ListViewItem = New ListViewItem(fileName, ilsIcons.Images.Count - 1)
                lvwThumbNails.Items.Add(listItem)
            Else
                thumb = New Bitmap(10, 10)
                ilsIcons.Images.Add(thumb)
                Dim listItem As ListViewItem = New ListViewItem(fileName, ilsIcons.Images.Count - 1)
                lvwThumbNails.Items.Add(listItem)
            End If

        End Sub

        Private Sub fillThumbs2(ByVal MyPgnum As Integer)
            Dim x As Integer : Dim y As Integer : x = MyPgnum
            lvwThumbNails.Items.Clear() : ilsIcons.Images.Clear()
            For y = 0 To 29
                addThumbNail(File1.Path & "\" & DwgLstArray(x, y))
            Next
        End Sub

        Private Sub Refresh_Renamed_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Refresh_Renamed.Click
            Dim pgnum As Integer
            pgnum = HScroll1.Value
            File1.Refresh()
            Dir1_Change(Dir1, New System.EventArgs)
            Dir1.Refresh()
            HScroll1.Value = pgnum
        End Sub

        Private Sub HScroll1_Scroll(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.ScrollEventArgs) Handles HScroll1.Scroll
            fillThumbs2(HScroll1.Value)
        End Sub

        Private Sub List1_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles List1.SelectedIndexChanged
            fillThumbs2(HScroll1.Value)
        End Sub

        Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
            frm.Close() : frm = Nothing
        End Sub

        Private Sub lvwThumbNails_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwThumbNails.DoubleClick
            Dim itm As ListViewItem = lvwThumbNails.SelectedItems.Item(0) : InsertFile2(itm.Text)
        End Sub

        'Private Sub FolderViewer1_LocationChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles FolderViewer1.LocationChanged
        ' fillThumbs2(HScroll1.Value)
        'End Sub

        Private Sub miOpenFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miOpenFile.Click
            Dim Doc As Autodesk.AutoCAD.ApplicationServices.Document
            'Dim itm As ListViewItem = lvwThumbNails.SelectedItems.Item(0)
            Dim itm As ListViewItem
            For Each itm In lvwThumbNails.SelectedItems
                Doc = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.Open(itm.Text, False)
            Next itm
        End Sub

        Private Sub miZoomAndSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miZoomAndSave.Click
            Dim Doc As Autodesk.AutoCAD.ApplicationServices.Document
            Dim acadApp As Autodesk.AutoCAD.Interop.AcadApplication = Autodesk.AutoCAD.ApplicationServices.Application.AcadApplication
            Dim itm As ListViewItem
            For Each itm In lvwThumbNails.SelectedItems
                Doc = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.Open(itm.Text, False)
                acadApp.ZoomExtents()
                Doc.CloseAndSave(itm.Text)
            Next itm
        End Sub

        'not used
        Private Sub cbxImageSize_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxImageSize.SelectedIndexChanged
            Dim sz As Size
            sz.Height = cbxImageSize.SelectedItem
            sz.Width = cbxImageSize.SelectedItem
            ilsIcons.ImageSize = sz
            fillThumbs2(HScroll1.Value)
        End Sub
    End Class
End Namespace