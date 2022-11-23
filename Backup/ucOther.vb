Option Explicit On 

Imports System.Windows.Forms
Imports System.ComponentModel
Imports System.IO

Imports Autodesk.AutoCAD.EditorInput
Imports Autodesk.AutoCAD.ApplicationServices
Imports Autodesk.AutoCAD.DatabaseServices
Imports Autodesk.AutoCAD.Geometry

Imports rnsCadDataProj.nsMods

Namespace nsUserCtls

    Public Class ucOther

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
        Friend WithEvents chkAddLayout As System.Windows.Forms.CheckBox
        Friend WithEvents chkFullName As System.Windows.Forms.CheckBox
        Friend WithEvents btnFileNametoAtt As System.Windows.Forms.Button
        Friend WithEvents btnVPScaletoAtt As System.Windows.Forms.Button
        Friend WithEvents gbDateFormat As System.Windows.Forms.GroupBox
        Friend WithEvents rbNumbers As System.Windows.Forms.RadioButton
        Friend WithEvents rbText As System.Windows.Forms.RadioButton
        Friend WithEvents btnDateToAtt As System.Windows.Forms.Button
        Friend WithEvents btnExpldGrp As System.Windows.Forms.Button
        Friend WithEvents chkOvrWrtFile As System.Windows.Forms.CheckBox
        Friend WithEvents chkRemAllYellow As System.Windows.Forms.CheckBox
        Friend WithEvents chkWbbl As System.Windows.Forms.CheckBox
        Friend WithEvents btnRemVportsLayZero As System.Windows.Forms.Button
        Friend WithEvents btnColorBylayerAllBlks As System.Windows.Forms.Button
        Friend WithEvents btnLstXrefs As System.Windows.Forms.Button
        Friend WithEvents dgXrefs As System.Windows.Forms.DataGrid
        Friend WithEvents btnMkXrefsTbls As System.Windows.Forms.Button
        Friend WithEvents btnGetShortCuts As System.Windows.Forms.Button
        Friend WithEvents btnGetTasks As System.Windows.Forms.Button
        Friend WithEvents btnGetDirs As System.Windows.Forms.Button
        Friend WithEvents btnGetServices As System.Windows.Forms.Button
        Friend WithEvents btnGetDB As System.Windows.Forms.Button
        Friend WithEvents btnEventLogs As System.Windows.Forms.Button
        Friend WithEvents btnIIS As System.Windows.Forms.Button
        Friend WithEvents btnWblkByLay As System.Windows.Forms.Button
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.chkAddLayout = New System.Windows.Forms.CheckBox
            Me.chkFullName = New System.Windows.Forms.CheckBox
            Me.btnFileNametoAtt = New System.Windows.Forms.Button
            Me.btnVPScaletoAtt = New System.Windows.Forms.Button
            Me.gbDateFormat = New System.Windows.Forms.GroupBox
            Me.rbNumbers = New System.Windows.Forms.RadioButton
            Me.rbText = New System.Windows.Forms.RadioButton
            Me.btnDateToAtt = New System.Windows.Forms.Button
            Me.btnExpldGrp = New System.Windows.Forms.Button
            Me.btnWblkByLay = New System.Windows.Forms.Button
            Me.chkOvrWrtFile = New System.Windows.Forms.CheckBox
            Me.chkRemAllYellow = New System.Windows.Forms.CheckBox
            Me.chkWbbl = New System.Windows.Forms.CheckBox
            Me.btnRemVportsLayZero = New System.Windows.Forms.Button
            Me.btnColorBylayerAllBlks = New System.Windows.Forms.Button
            Me.btnLstXrefs = New System.Windows.Forms.Button
            Me.dgXrefs = New System.Windows.Forms.DataGrid
            Me.btnMkXrefsTbls = New System.Windows.Forms.Button
            Me.btnGetShortCuts = New System.Windows.Forms.Button
            Me.btnGetTasks = New System.Windows.Forms.Button
            Me.btnGetDirs = New System.Windows.Forms.Button
            Me.btnGetServices = New System.Windows.Forms.Button
            Me.btnGetDB = New System.Windows.Forms.Button
            Me.btnEventLogs = New System.Windows.Forms.Button
            Me.btnIIS = New System.Windows.Forms.Button
            Me.gbDateFormat.SuspendLayout()
            CType(Me.dgXrefs, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'chkAddLayout
            '
            Me.chkAddLayout.Location = New System.Drawing.Point(112, 168)
            Me.chkAddLayout.Name = "chkAddLayout"
            Me.chkAddLayout.Size = New System.Drawing.Size(88, 24)
            Me.chkAddLayout.TabIndex = 11
            Me.chkAddLayout.Text = "Add Layout"
            '
            'chkFullName
            '
            Me.chkFullName.Location = New System.Drawing.Point(112, 144)
            Me.chkFullName.Name = "chkFullName"
            Me.chkFullName.Size = New System.Drawing.Size(88, 24)
            Me.chkFullName.TabIndex = 10
            Me.chkFullName.Text = "Full Name ?"
            '
            'btnFileNametoAtt
            '
            Me.btnFileNametoAtt.Location = New System.Drawing.Point(8, 144)
            Me.btnFileNametoAtt.Name = "btnFileNametoAtt"
            Me.btnFileNametoAtt.Size = New System.Drawing.Size(96, 23)
            Me.btnFileNametoAtt.TabIndex = 9
            Me.btnFileNametoAtt.Text = "File Name to Att"
            '
            'btnVPScaletoAtt
            '
            Me.btnVPScaletoAtt.Location = New System.Drawing.Point(8, 112)
            Me.btnVPScaletoAtt.Name = "btnVPScaletoAtt"
            Me.btnVPScaletoAtt.Size = New System.Drawing.Size(96, 23)
            Me.btnVPScaletoAtt.TabIndex = 8
            Me.btnVPScaletoAtt.Text = "VP Scale to Att"
            '
            'gbDateFormat
            '
            Me.gbDateFormat.Controls.Add(Me.rbNumbers)
            Me.gbDateFormat.Controls.Add(Me.rbText)
            Me.gbDateFormat.Controls.Add(Me.btnDateToAtt)
            Me.gbDateFormat.Location = New System.Drawing.Point(8, 8)
            Me.gbDateFormat.Name = "gbDateFormat"
            Me.gbDateFormat.Size = New System.Drawing.Size(184, 88)
            Me.gbDateFormat.TabIndex = 7
            Me.gbDateFormat.TabStop = False
            Me.gbDateFormat.Text = "Date Format"
            '
            'rbNumbers
            '
            Me.rbNumbers.Location = New System.Drawing.Point(16, 56)
            Me.rbNumbers.Name = "rbNumbers"
            Me.rbNumbers.Size = New System.Drawing.Size(72, 24)
            Me.rbNumbers.TabIndex = 1
            Me.rbNumbers.Text = "Numbers"
            '
            'rbText
            '
            Me.rbText.Checked = True
            Me.rbText.Location = New System.Drawing.Point(16, 24)
            Me.rbText.Name = "rbText"
            Me.rbText.Size = New System.Drawing.Size(72, 24)
            Me.rbText.TabIndex = 0
            Me.rbText.TabStop = True
            Me.rbText.Text = "Text"
            '
            'btnDateToAtt
            '
            Me.btnDateToAtt.Location = New System.Drawing.Point(96, 24)
            Me.btnDateToAtt.Name = "btnDateToAtt"
            Me.btnDateToAtt.Size = New System.Drawing.Size(75, 23)
            Me.btnDateToAtt.TabIndex = 1
            Me.btnDateToAtt.Text = "Date To Att"
            '
            'btnExpldGrp
            '
            Me.btnExpldGrp.Location = New System.Drawing.Point(208, 16)
            Me.btnExpldGrp.Name = "btnExpldGrp"
            Me.btnExpldGrp.Size = New System.Drawing.Size(88, 23)
            Me.btnExpldGrp.TabIndex = 12
            Me.btnExpldGrp.Text = "Explode Group"
            '
            'btnWblkByLay
            '
            Me.btnWblkByLay.Location = New System.Drawing.Point(208, 64)
            Me.btnWblkByLay.Name = "btnWblkByLay"
            Me.btnWblkByLay.Size = New System.Drawing.Size(75, 39)
            Me.btnWblkByLay.TabIndex = 13
            Me.btnWblkByLay.Text = "WBBL Breton"
            '
            'chkOvrWrtFile
            '
            Me.chkOvrWrtFile.AutoSize = True
            Me.chkOvrWrtFile.Checked = True
            Me.chkOvrWrtFile.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkOvrWrtFile.Location = New System.Drawing.Point(208, 110)
            Me.chkOvrWrtFile.Name = "chkOvrWrtFile"
            Me.chkOvrWrtFile.Size = New System.Drawing.Size(102, 17)
            Me.chkOvrWrtFile.TabIndex = 14
            Me.chkOvrWrtFile.Text = "Over Write Exist"
            Me.chkOvrWrtFile.UseVisualStyleBackColor = True
            '
            'chkRemAllYellow
            '
            Me.chkRemAllYellow.AutoSize = True
            Me.chkRemAllYellow.Checked = True
            Me.chkRemAllYellow.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkRemAllYellow.Location = New System.Drawing.Point(208, 133)
            Me.chkRemAllYellow.Name = "chkRemAllYellow"
            Me.chkRemAllYellow.Size = New System.Drawing.Size(96, 17)
            Me.chkRemAllYellow.TabIndex = 15
            Me.chkRemAllYellow.Text = "Rem All Yellow"
            Me.chkRemAllYellow.UseVisualStyleBackColor = True
            '
            'chkWbbl
            '
            Me.chkWbbl.AutoSize = True
            Me.chkWbbl.Location = New System.Drawing.Point(289, 76)
            Me.chkWbbl.Name = "chkWbbl"
            Me.chkWbbl.Size = New System.Drawing.Size(51, 17)
            Me.chkWbbl.TabIndex = 16
            Me.chkWbbl.Text = "Wbbl"
            Me.chkWbbl.UseVisualStyleBackColor = True
            '
            'btnRemVportsLayZero
            '
            Me.btnRemVportsLayZero.Location = New System.Drawing.Point(379, 23)
            Me.btnRemVportsLayZero.Name = "btnRemVportsLayZero"
            Me.btnRemVportsLayZero.Size = New System.Drawing.Size(75, 40)
            Me.btnRemVportsLayZero.TabIndex = 17
            Me.btnRemVportsLayZero.Text = "Rem Vports Lay Zero"
            Me.btnRemVportsLayZero.UseVisualStyleBackColor = True
            '
            'btnColorBylayerAllBlks
            '
            Me.btnColorBylayerAllBlks.Location = New System.Drawing.Point(430, 112)
            Me.btnColorBylayerAllBlks.Name = "btnColorBylayerAllBlks"
            Me.btnColorBylayerAllBlks.Size = New System.Drawing.Size(115, 23)
            Me.btnColorBylayerAllBlks.TabIndex = 18
            Me.btnColorBylayerAllBlks.Text = "ColorBylayerAllBlks"
            Me.btnColorBylayerAllBlks.UseVisualStyleBackColor = True
            '
            'btnLstXrefs
            '
            Me.btnLstXrefs.Location = New System.Drawing.Point(321, 230)
            Me.btnLstXrefs.Name = "btnLstXrefs"
            Me.btnLstXrefs.Size = New System.Drawing.Size(75, 23)
            Me.btnLstXrefs.TabIndex = 19
            Me.btnLstXrefs.Text = "List Xrefs"
            Me.btnLstXrefs.UseVisualStyleBackColor = True
            '
            'dgXrefs
            '
            Me.dgXrefs.DataMember = ""
            Me.dgXrefs.HeaderForeColor = System.Drawing.SystemColors.ControlText
            Me.dgXrefs.Location = New System.Drawing.Point(112, 259)
            Me.dgXrefs.Name = "dgXrefs"
            Me.dgXrefs.Size = New System.Drawing.Size(665, 80)
            Me.dgXrefs.TabIndex = 20
            '
            'btnMkXrefsTbls
            '
            Me.btnMkXrefsTbls.Location = New System.Drawing.Point(431, 229)
            Me.btnMkXrefsTbls.Name = "btnMkXrefsTbls"
            Me.btnMkXrefsTbls.Size = New System.Drawing.Size(75, 23)
            Me.btnMkXrefsTbls.TabIndex = 21
            Me.btnMkXrefsTbls.Text = "Mk Xrefs Tbl"
            Me.btnMkXrefsTbls.UseVisualStyleBackColor = True
            '
            'btnGetShortCuts
            '
            Me.btnGetShortCuts.Location = New System.Drawing.Point(675, 16)
            Me.btnGetShortCuts.Name = "btnGetShortCuts"
            Me.btnGetShortCuts.Size = New System.Drawing.Size(102, 23)
            Me.btnGetShortCuts.TabIndex = 22
            Me.btnGetShortCuts.Text = "Get Short Cuts"
            Me.btnGetShortCuts.UseVisualStyleBackColor = True
            '
            'btnGetTasks
            '
            Me.btnGetTasks.Location = New System.Drawing.Point(675, 45)
            Me.btnGetTasks.Name = "btnGetTasks"
            Me.btnGetTasks.Size = New System.Drawing.Size(102, 23)
            Me.btnGetTasks.TabIndex = 23
            Me.btnGetTasks.Text = "Get Tasks"
            Me.btnGetTasks.UseVisualStyleBackColor = True
            '
            'btnGetDirs
            '
            Me.btnGetDirs.Location = New System.Drawing.Point(675, 74)
            Me.btnGetDirs.Name = "btnGetDirs"
            Me.btnGetDirs.Size = New System.Drawing.Size(102, 23)
            Me.btnGetDirs.TabIndex = 24
            Me.btnGetDirs.Text = "Get Dirs"
            Me.btnGetDirs.UseVisualStyleBackColor = True
            '
            'btnGetServices
            '
            Me.btnGetServices.Location = New System.Drawing.Point(675, 103)
            Me.btnGetServices.Name = "btnGetServices"
            Me.btnGetServices.Size = New System.Drawing.Size(102, 23)
            Me.btnGetServices.TabIndex = 25
            Me.btnGetServices.Text = "Get Services"
            Me.btnGetServices.UseVisualStyleBackColor = True
            '
            'btnGetDB
            '
            Me.btnGetDB.Location = New System.Drawing.Point(675, 132)
            Me.btnGetDB.Name = "btnGetDB"
            Me.btnGetDB.Size = New System.Drawing.Size(102, 23)
            Me.btnGetDB.TabIndex = 26
            Me.btnGetDB.Text = "Get DB"
            Me.btnGetDB.UseVisualStyleBackColor = True
            '
            'btnEventLogs
            '
            Me.btnEventLogs.Location = New System.Drawing.Point(675, 161)
            Me.btnEventLogs.Name = "btnEventLogs"
            Me.btnEventLogs.Size = New System.Drawing.Size(102, 23)
            Me.btnEventLogs.TabIndex = 27
            Me.btnEventLogs.Text = "Event Logs"
            Me.btnEventLogs.UseVisualStyleBackColor = True
            '
            'btnIIS
            '
            Me.btnIIS.Location = New System.Drawing.Point(675, 191)
            Me.btnIIS.Name = "btnIIS"
            Me.btnIIS.Size = New System.Drawing.Size(102, 23)
            Me.btnIIS.TabIndex = 28
            Me.btnIIS.Text = "IIs"
            Me.btnIIS.UseVisualStyleBackColor = True
            '
            'ucOther
            '
            Me.Controls.Add(Me.btnIIS)
            Me.Controls.Add(Me.btnEventLogs)
            Me.Controls.Add(Me.btnGetDB)
            Me.Controls.Add(Me.btnGetServices)
            Me.Controls.Add(Me.btnGetDirs)
            Me.Controls.Add(Me.btnGetTasks)
            Me.Controls.Add(Me.btnGetShortCuts)
            Me.Controls.Add(Me.btnMkXrefsTbls)
            Me.Controls.Add(Me.dgXrefs)
            Me.Controls.Add(Me.btnLstXrefs)
            Me.Controls.Add(Me.btnColorBylayerAllBlks)
            Me.Controls.Add(Me.btnRemVportsLayZero)
            Me.Controls.Add(Me.chkWbbl)
            Me.Controls.Add(Me.chkRemAllYellow)
            Me.Controls.Add(Me.chkOvrWrtFile)
            Me.Controls.Add(Me.btnWblkByLay)
            Me.Controls.Add(Me.btnExpldGrp)
            Me.Controls.Add(Me.chkAddLayout)
            Me.Controls.Add(Me.chkFullName)
            Me.Controls.Add(Me.btnFileNametoAtt)
            Me.Controls.Add(Me.btnVPScaletoAtt)
            Me.Controls.Add(Me.gbDateFormat)
            Me.Name = "ucOther"
            Me.Size = New System.Drawing.Size(799, 358)
            Me.gbDateFormat.ResumeLayout(False)
            CType(Me.dgXrefs, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region


        Private Sub btnDateToAtt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDateToAtt.Click
            Dim frm As Form = Me.FindForm()
            frm.Hide()
            DateToAtt(rbNumbers.Checked)
            frm.Show()
        End Sub

        Private Sub btnVPScaletoAtt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVPScaletoAtt.Click
            Dim db As Database = HostApplicationServices.WorkingDatabase
            Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
            Dim frm As Form = Me.FindForm()
            frm.Hide()
            Dim trans As Transaction = db.TransactionManager.StartTransaction()
            Dim DocCol As DocumentCollection = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager
            Dim docLock As DocumentLock = DocCol.MdiActiveDocument.LockDocument()
            Try
                Dim prEnt As PromptNestedEntityOptions = New PromptNestedEntityOptions("Select the Attribute in Current VPort ...")
                Dim prEntRes As PromptEntityResult = ed.GetNestedEntity(prEnt)
                If prEntRes.Status <> PromptStatus.OK Then
                    frm.Show()
                    Return
                End If
                Dim cVPScaleStr As String
                Dim currVP As Viewport = trans.GetObject(ed.Document.Editor.CurrentViewportObjectId, OpenMode.ForRead)
                'MessageBox.Show(currVP.StandardScale.ToString)
                'Autocad Standard Scales
                Select Case currVP.StandardScale.ToString
                    Case "Scale1To64inchAnd1ft" : cVPScaleStr = "1/64""=1'-0"""
                    Case "Scale1To32inchAnd1ft" : cVPScaleStr = "1/32""=1'-0"""
                    Case "Scale1To16inchAnd1ft" : cVPScaleStr = "1/16""=1'-0"""
                    Case "Scale3To32inchAnd1ft" : cVPScaleStr = "3/32""=1'-0"""
                    Case "Scale1To8inchAnd1ft" : cVPScaleStr = "1/8""=1'-0"""
                    Case "Scale3To16inchAnd1ft" : cVPScaleStr = "3/16""=1'-0"""
                    Case "Scale1To4inchAnd1ft" : cVPScaleStr = "1/4""=1'-0"""
                    Case "Scale3To8inchAnd1ft" : cVPScaleStr = "3/8""=1'-0"""
                    Case "Scale1To2inchAnd1ft" : cVPScaleStr = "1/2""=1'-0"""
                    Case "Scale3To4inchAnd1ft" : cVPScaleStr = "3/4""=1'-0"""
                    Case "Scale1inAnd1ft" : cVPScaleStr = "1""=1'-0"""
                    Case "30" : cVPScaleStr = "1 1/2""=1'-0"""
                    Case "Scale3inAnd1ft" : cVPScaleStr = "3""=1'-0"""
                    Case "Scale6inAnd1ft" : cVPScaleStr = "6""=1'-0"""
                    Case "Scale1ftAnd1ft" : cVPScaleStr = "1'-0""=1'-0"""

                    Case Else   ' Other values.
                        cVPScaleStr = "Not on Current Case List"
                End Select
                Dim ent As Entity = trans.GetObject(prEntRes.ObjectId, OpenMode.ForRead)
                If TypeOf ent Is AttributeReference Then
                    Dim att As AttributeReference = trans.GetObject(prEntRes.ObjectId, OpenMode.ForWrite)
                    att.TextString = cVPScaleStr
                    trans.Commit()
                End If
                If TypeOf ent Is MText Then
                    Dim att As MText = trans.GetObject(prEntRes.ObjectId, OpenMode.ForWrite)
                    att.Contents = cVPScaleStr
                    trans.Commit()
                End If
                If TypeOf ent Is DBText Then
                    Dim att As DBText = trans.GetObject(prEntRes.ObjectId, OpenMode.ForWrite)
                    att.TextString = cVPScaleStr
                    trans.Commit()
                End If
            Finally
                docLock.Dispose() : trans.Dispose() ': Me.Show()
            End Try
        End Sub

        Private Sub btnFileNametoAtt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFileNametoAtt.Click
            Dim frm As Form = Me.FindForm()
            frm.Hide()
            FileNametoAtt(chkFullName.Checked, chkAddLayout.Checked)
            frm.Show()
        End Sub

        Private Sub btnExpldGrp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExpldGrp.Click
            PrintGroupNamesOfEntity()
        End Sub

        Public Sub GetGroupNames()
            Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
            Dim db As Database = HostApplicationServices.WorkingDatabase
            Dim trans As Transaction = db.TransactionManager.StartTransaction
            Try
                Dim lt As DBDictionary = CType(trans.GetObject(db.GroupDictionaryId, OpenMode.ForRead), DBDictionary)
                For Each ide As DictionaryEntry In lt
                    Dim ltr As Group = CType(trans.GetObject(CType(ide.Value, ObjectId), OpenMode.ForRead), Group)
                    MessageBox.Show(ltr.Name) 'ed.WriteMessage("" & vbLf & "Group Name: {0}", ltr.Name)
                Next
                trans.Commit()
            Finally
                trans.Dispose()
            End Try
        End Sub

        Private Function GetAllGroupsIds() As ArrayList
            Dim ids As ArrayList = New ArrayList
            Dim db As Database = HostApplicationServices.WorkingDatabase
            Dim trans As Transaction = db.TransactionManager.StartTransaction
            Try
                Dim lt As DBDictionary = CType(trans.GetObject(db.GroupDictionaryId, OpenMode.ForRead), DBDictionary)
                For Each ide As DictionaryEntry In lt
                    ids.Add(ide.Value)
                Next
                trans.Commit()
            Finally
                trans.Dispose()
            End Try
            Return ids
        End Function

        Public Sub PrintGroupNamesOfEntity() ' erases points that were in the group
            Dim frm As Form = Me.FindForm()
            Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
            Dim db As Database = HostApplicationServices.WorkingDatabase
            Dim trans As Transaction = db.TransactionManager.StartTransaction
            Dim DocCol As DocumentCollection = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager
            Dim docLock As DocumentLock = DocCol.MdiActiveDocument.LockDocument()
            Try
                Dim groupIds As ArrayList = GetAllGroupsIds()
                If (groupIds.Count = 0) Then
                    ed.WriteMessage("" & vbLf & "Drawing has no groups!")
                    Return
                End If
                frm.Hide() : Dim entres As PromptEntityResult = ed.GetEntity("" & vbLf & "Select entity: ")
                If (entres.Status = PromptStatus.OK) Then
                    Dim en As Entity = CType(trans.GetObject(entres.ObjectId, OpenMode.ForRead), Entity)
                    For Each id As ObjectId In groupIds
                        If en.HasPersistentReactor(id) Then
                            Dim gr As Group = CType(trans.GetObject(id, OpenMode.ForWrite), Group)
                            Dim entIds As Autodesk.AutoCAD.DatabaseServices.ObjectId() = gr.GetAllEntityIds : Dim remEnt As ObjectId
                            For Each remEnt In entIds
                                gr.Remove(remEnt)
                                Dim ent As Entity = CType(trans.GetObject(remEnt, OpenMode.ForWrite), Entity)
                                If TypeOf ent Is DBPoint Then
                                    ent.Erase()
                                End If
                            Next
                            Dim lt As DBDictionary = CType(trans.GetObject(db.GroupDictionaryId, OpenMode.ForWrite), DBDictionary)
                            lt.Remove(gr.ObjectId)
                        End If
                    Next
                End If
                trans.Commit()
            Finally
                docLock.Dispose() : trans.Dispose() ': frm.Show()
            End Try
        End Sub


        Private Sub InsertFile2(ByVal fullName As String) 'As ObjectId
            Dim tbl As New Table
            Dim bt As BlockTable
            Dim btr As BlockTableRecord
            Dim db As Database = HostApplicationServices.WorkingDatabase
            Dim trans As Transaction
            trans = db.TransactionManager.StartTransaction()

            Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor

            ''frm.Hide()
            'Dim tblPnt As PromptPointOptions = New PromptPointOptions("Select Insertion Point...")
            'Dim tblPntRes As PromptPointResult = ed.GetPoint(tblPnt)
            'If tblPntRes.Status <> PromptStatus.OK Then
            '    ' frm.Show()
            '    Return
            'End If

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
            Dim pnt As Point3d = New Point3d(0, 0, 0)
            Dim bref As BlockReference = New BlockReference(pnt, idBTR)
            Dim theScale As Scale3d = New Scale3d(1, 1, 1)
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
                    'bref.Visible = True
                Finally : bref.Dispose()
                End Try
                trans.Commit()
            Finally
                docLock.Dispose() : trans.Dispose()
                ' frm.Show()
            End Try
        End Sub


        Private Sub btnWblkByLay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWblkByLay.Click
            Dim frm As Form = Me.FindForm()
            Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
            Dim db As Database = HostApplicationServices.WorkingDatabase
            Dim trans As Transaction = db.TransactionManager.StartTransaction
            Dim DocCol As DocumentCollection = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager
            Dim docLock As DocumentLock = DocCol.MdiActiveDocument.LockDocument()
            Dim id As ObjectId : Dim lt As LayerTable = CType(trans.GetObject(db.LayerTableId, OpenMode.ForRead), LayerTable)
            Dim fldr As New FolderBrowserDialog : fldr.ShowDialog() : frm.Hide()
            'getUblocks(db, ed, trans)
            'Return

            Try
                For Each id In lt
                    Dim ltr As LayerTableRecord = CType(trans.GetObject(id, OpenMode.ForWrite), LayerTableRecord)
                    If ltr.IsFrozen Then ltr.IsFrozen = False
                    If ltr.IsOff Then ltr.IsOff = False
                    If ltr.IsLocked Then ltr.IsLocked = False
                    ltr.Color = Autodesk.AutoCAD.Colors.Color.FromColorIndex(Autodesk.AutoCAD.Colors.ColorMethod.ByLayer, 7) '.FromRgb(0, 0, 0)

                    Dim lIds(0) As ObjectId
                    lIds(0) = ltr.ObjectId
                    Autodesk.AutoCAD.Internal.LayerUtilities.RegenLayers(lIds, Autodesk.AutoCAD.Internal.LayerUtilities.RegenPending)
                    If ltr.Name <> "0" Then
                        GetObjectsFromLayer(db, ed, trans, fldr.SelectedPath, ltr.Name)
                    End If
                Next
                trans.Commit()
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            Finally
                docLock.Dispose() : trans.Dispose()
            End Try
        End Sub

        Private Sub getUblocks(ByVal db As Database, ByVal ed As Editor, ByVal tr As Transaction)
            Dim bt As BlockTable = DirectCast(tr.GetObject(db.BlockTableId, OpenMode.ForWrite), BlockTable)
            Dim ms As BlockTableRecord = DirectCast(tr.GetObject(bt(BlockTableRecord.ModelSpace), OpenMode.ForWrite), BlockTableRecord)
            Dim it As BlockTableRecordEnumerator = ms.GetEnumerator()
            While it.MoveNext()
                Dim ent As Entity = DirectCast(tr.GetObject(it.Current, OpenMode.ForRead), Entity)
                ' ed.WriteMessage(ent.GetType.ToString & ControlChars.CrLf)
                If ent.GetType.ToString = GetType(BlockReference).ToString Then
                    Dim blk As BlockReference = DirectCast(ent, BlockReference)
                    If blk.Name.Chars(0) = "*" Then
                        ' Dim dbo As DBObject = blk.BlockTableRecord.GetObject(OpenMode.ForWrite)
                        ed.WriteMessage(blk.Name & ControlChars.CrLf)
                    End If
                End If
            End While
            it.Dispose()
        End Sub

        Private Sub lstSubBlocks()
            Dim subBlocks As New DBObjectCollection()
            ' br is a BlockReference object 
            '     br.Explode(subBlocks)
            For Each subBlock As DBObject In subBlocks
                Dim subBlockName As String = ""
                If (TypeOf subBlock Is BlockReference) Then
                    ' Gets name from BlockTableRecord
                    ' BlockUtils is a custom class
                    '   subBlockName = BlockUtils.GetBlockName(CType(subBloque, BlockReference))
                Else
                    subBlockName = subBlock.GetType().Name
                End If
                Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor.WriteMessage(subBlockName & vbCrLf)
            Next subBlock
        End Sub

        Public Shared Function GetAllObjectIdsInBlockDef(ByVal idBlockDef As ObjectId) As ObjectIdCollection
            Dim ids As New ObjectIdCollection()
            Dim db As Database = idBlockDef.Database
            Dim trans As Transaction = db.TransactionManager.StartTransaction()
            Try
                Dim btr As BlockTableRecord = DirectCast((trans.GetObject(idBlockDef, OpenMode.ForRead)), BlockTableRecord)
                For Each id As ObjectId In btr
                    ids.Add(id)
                Next
                trans.Commit()
            Finally
                trans.Dispose()
            End Try
            Return ids
        End Function

        Private Sub GetObjectsFromLayer(ByVal db As Database, ByVal ed As Editor, ByVal tr As Transaction, ByVal pathName As String, ByVal layName As String) ', ByVal blkId As ObjectId)
            Try
                'Dim Values0(1) As TypedValue
                'Values0(0) = New TypedValue(DxfCode.Start, "INSERT")
                'Values0(1) = New TypedValue(DxfCode.LayerName, "0")
                'Dim SF0 As New SelectionFilter(Values0)
                'Dim Result0 As PromptSelectionResult = ed.SelectAll(SF0)
                'If Result0.Status <> PromptStatus.OK Then Return
                'Dim IDArray0 As ObjectId() = Result0.Value.GetObjectIds

                Dim objIdColl As New ObjectIdCollection
                Dim i As Integer
                'For i = 0 To IDArray0.Length - 1
                '    objIdColl.Add(IDArray0(i))
                'Next

                Dim Values() As TypedValue = {New TypedValue(DxfCode.LayerName, layName)}
                Dim SF As New SelectionFilter(Values)
                Dim Result As PromptSelectionResult = ed.SelectAll(SF)
                If Result.Status <> PromptStatus.OK Then Return
                Dim IDArray As ObjectId() = Result.Value.GetObjectIds

                For i = 0 To IDArray.Length - 1
                    Dim ent As Entity = tr.GetObject(IDArray(i), Autodesk.AutoCAD.DatabaseServices.OpenMode.ForWrite)

                    If chkRemAllYellow.Checked Then
                        If ent.ColorIndex = 2 Then ent.ColorIndex = 4
                    End If


                    Dim entTyp As String = ent.GetType.Name
                    ' ed.WriteMessage(entTyp & ControlChars.CrLf)
                    ' ed.WriteMessage(ControlChars.CrLf)
                    Select Case entTyp

                        Case "BlockReference"
                            Dim blk As BlockReference = tr.GetObject(IDArray(i), Autodesk.AutoCAD.DatabaseServices.OpenMode.ForWrite)
                            'If blk.IsDynamicBlock Then
                            '    ed.WriteMessage("DynamicBlock" & ControlChars.CrLf)
                            '    ed.WriteMessage(layName & ControlChars.CrLf)
                            'End If

                            'If blk.Name.Chars(0) = "*" And blk.Name.Chars(1) = "X" Then
                            Dim btr As BlockTableRecord = blk.BlockTableRecord.GetObject(OpenMode.ForWrite)

                            Dim AttCol As Autodesk.AutoCAD.DatabaseServices.AttributeCollection
                            Dim Att As AttributeReference : Dim AttObjID As ObjectId
                            AttCol = blk.AttributeCollection
                            For Each AttObjID In AttCol
                                Att = tr.GetObject(AttObjID, OpenMode.ForWrite)
                                If chkRemAllYellow.Checked Then
                                    If Att.ColorIndex = 2 Then Att.ColorIndex = 4
                                End If
                            Next

                            ' Dim ids As New ObjectIdCollection()
                            For Each id As ObjectId In btr
                                ' ids.Add(id)
                                Dim e As Entity = tr.GetObject(id, Autodesk.AutoCAD.DatabaseServices.OpenMode.ForWrite)
                                If chkRemAllYellow.Checked Then
                                    If e.ColorIndex = 2 Then e.ColorIndex = 4 'yel to cyan  '256 is bylayer  '0 is byblock
                                End If
                                '       ed.WriteMessage("blk ent Id " & e.ObjectId.ToString & ControlChars.CrLf)
                            Next

                            '   ed.WriteMessage(layName & " " & blk.Name & ControlChars.CrLf)
                            ' End If

                    End Select
                    objIdColl.Add(IDArray(i))
                Next

                If chkWbbl.Checked Then
                    Dim tempDb As New Autodesk.AutoCAD.DatabaseServices.Database(True, True)
                    db.Wblock(tempDb, objIdColl, New Point3d(0, 0, 0), DuplicateRecordCloning.Ignore)

                    If (Not chkOvrWrtFile.Checked) And File.Exists(pathName & "\" & layName & ".dwg") Then
                        MessageBox.Show("The target file already exists and will be over written. " & pathName & "\" & layName & ".dwg")
                        tempDb.SaveAs(pathName & "\" & layName & ".dwg", DwgVersion.Current)
                    Else
                        tempDb.SaveAs(pathName & "\" & layName & ".dwg", DwgVersion.Current)
                    End If
                End If

            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            Finally

            End Try
        End Sub


#Region "arx aced cmd Import - acedRedraw"

        <System.Security.SuppressUnmanagedCodeSecurity()> _
    <System.Runtime.InteropServices.DllImport("acad.exe", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Private Shared Function acedRedraw(ByVal name As Long(), ByVal mode As Integer) As Integer
        End Function

        '<CommandMethod("MyRedraw")> _
        Public Sub MyRedraw()
            acedRedraw(Nothing, 1)
        End Sub

#End Region


        'Sub Test()
        '    Dim aBlock As IAcadBlock3
        '    For Each aBlock In ThisDrawing.Blocks
        '        If IsAnonDynamicBlock(aBlock) Then
        '            Dim parentBlock As IAcadBlock3
        '            parentBlock = GetAnonDBlockParent(aBlock)
        '            Debug.Print(aBlock.Name & vbTab & "True" & vbTab & parentBlock.Name)
        '        Else
        '            Debug.Print(aBlock.Name & vbTab & aBlock.IsDynamicBlock)
        '        End If
        '    Next aBlock
        'End Sub

        'Private Function IsAnonDynamicBlock(ByVal Block As IAcadBlock3) As Boolean
        '    ' This function expects IAcadBlock3 because it is likely run in a loop
        '    ' that will be working with that interface rather than AcadBlock.
        '    Dim dxfType As Object, dxfData As Object
        '    Block.GetXData("AcDbBlockRepBTag", dxfType, dxfData)
        '    If IsArray(dxfType) Then IsAnonDynamicBlock = True
        'End Function

        'Private Function GetAnonDBlockParent(ByVal Block As IAcadBlock3) As IAcadBlock3
        '    Dim dxfType As Object, dxfData As Object
        '    Block.GetXData("AcDbBlockRepBTag", dxfType, dxfData)
        '    Dim i As Long
        '    For i = 0 To UBound(dxfType)
        '        If dxfType(i) = 1005 Then
        '            Dim parentHandle As String
        '            parentHandle = dxfData(i)
        '            Exit For
        '        End If
        '    Next i
        '    GetAnonDBlockParent = ThisDrawing.HandleToObject(parentHandle)
        'End Function



        ' not used
        Public Sub CopyLayerFrom(ByVal lname As String, ByVal fname As String)
            Try
                Dim doc As Document = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument
                Dim ed As Editor = doc.Editor
                Dim thisDb As Database = HostApplicationServices.WorkingDatabase
                Using docLock As DocumentLock = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.LockDocument
                    Using db As Database = New Database(False, False)
                        db.ReadDwgFile(fname, System.IO.FileShare.Read, True, Nothing)
                        Using tr As Transaction = db.TransactionManager.StartTransaction
                            Dim lt As LayerTable = tr.GetObject(db.LayerTableId, OpenMode.ForRead, False)
                            If lt.Has(lname) Then
                                Dim ltr As LayerTableRecord = tr.GetObject(lt(lname), OpenMode.ForRead)
                                If Not ltr.IsErased Then
                                    Using thisTr As Transaction = thisDb.TransactionManager.StartTransaction
                                        Dim thisLt As LayerTable = thisTr.GetObject(thisDb.LayerTableId, OpenMode.ForWrite)
                                        Dim map As New IdMapping()
                                        Dim objIDs As ObjectIdCollection = New ObjectIdCollection
                                        objIDs.Add(ltr.ObjectId)
                                        thisDb.WblockCloneObjects(objIDs, thisLt.ObjectId, map, DuplicateRecordCloning.Replace, False) 'no defer
                                        thisTr.Commit()
                                    End Using
                                    tr.Commit()
                                End If
                            End If
                        End Using
                    End Using
                End Using
            Catch ex As Autodesk.AutoCAD.Runtime.Exception
                Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
                ed.WriteMessage(ControlChars.CrLf & "Error {0} Copy layer from other document" & ControlChars.CrLf, ex)
                ed.WriteMessage(ex.StackTrace)
            End Try
        End Sub


        Private Sub btnRemVportsLayZero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemVportsLayZero.Click
            '    Dim frm As Form = Me.FindForm()
            Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
            ed.WriteMessage(ControlChars.CrLf & "Not Using This" & ControlChars.CrLf)
            '    Dim db As Database = HostApplicationServices.WorkingDatabase
            '    Dim trans As Transaction = db.TransactionManager.StartTransaction
            '    Dim DocCol As DocumentCollection = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager
            '    Dim docLock As DocumentLock = DocCol.MdiActiveDocument.LockDocument()
            '    Dim id As ObjectId : Dim lt As LayerTable = CType(trans.GetObject(db.LayerTableId, OpenMode.ForRead), LayerTable)
            '    ' Dim fldr As New FolderBrowserDialog : fldr.ShowDialog() : frm.Hide()
            '    'getUblocks(db, ed, trans)
            '    'Return

            '    Try
            '        For Each id In lt
            '            Dim ltr As LayerTableRecord = CType(trans.GetObject(id, OpenMode.ForWrite), LayerTableRecord)
            '            If ltr.IsFrozen Then ltr.IsFrozen = False
            '            If ltr.IsOff Then ltr.IsOff = False
            '            If ltr.IsLocked Then ltr.IsLocked = False
            '            '    ltr.Color = Autodesk.AutoCAD.Colors.Color.FromColorIndex(Autodesk.AutoCAD.Colors.ColorMethod.ByLayer, 7) '.FromRgb(0, 0, 0)

            '            Dim lIds(0) As ObjectId
            '            lIds(0) = ltr.ObjectId
            '            Autodesk.AutoCAD.Internal.LayerUtilities.RegenLayers(lIds, Autodesk.AutoCAD.Internal.LayerUtilities.RegenPending)

            '            'GetObjectsFromLayer(db, ed, trans, fldr.SelectedPath, ltr.Name)
            '            Try
            '                Dim i As Integer

            '                Dim Values() As TypedValue = {New TypedValue(DxfCode.LayerName, ltr.Name)}
            '                Dim SF As New SelectionFilter(Values)
            '                Dim Result As PromptSelectionResult = ed.SelectAll(SF)
            '                If Result.Status <> PromptStatus.OK Then Return
            '                Dim IDArray As ObjectId() = Result.Value.GetObjectIds

            '                For i = 0 To IDArray.Length - 1
            '                    Dim ent As Entity = trans.GetObject(IDArray(i), Autodesk.AutoCAD.DatabaseServices.OpenMode.ForWrite)

            '                    Dim entTyp As String = ent.GetType.Name
            '                    ' ed.WriteMessage(entTyp & ControlChars.CrLf)
            '                    ' ed.WriteMessage(ControlChars.CrLf)
            '                    Select Case entTyp

            '                        Case "Viewport"
            '                            If ent.Layer = "0" Then
            '                                ent.Erase()
            '                            End If

            '                    End Select

            '                Next

            '            Catch ex As Exception
            '                MessageBox.Show(ex.ToString)
            '            Finally
            '                trans.Commit()
            '            End Try

            '        Next

            '    Catch ex As Exception
            '        MessageBox.Show(ex.ToString)
            '    Finally
            '        docLock.Dispose() : trans.Dispose()
            '    End Try
        End Sub

        Private Sub btnColorBylayerAllBlks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnColorBylayerAllBlks.Click
            AddLayer()
            Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
            Dim db As Database = HostApplicationServices.WorkingDatabase
            Dim trans As Transaction = db.TransactionManager.StartTransaction
            Dim DocCol As DocumentCollection = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager
            Dim docLock As DocumentLock = DocCol.MdiActiveDocument.LockDocument()
            Try
                Dim bt As BlockTable = DirectCast(trans.GetObject(db.BlockTableId, OpenMode.ForWrite), BlockTable)
                For Each id As ObjectId In bt
                    Dim btr As BlockTableRecord = trans.GetObject(id, Autodesk.AutoCAD.DatabaseServices.OpenMode.ForWrite)

                    If btr.XrefStatus = XrefStatus.NotAnXref Then
                        For Each idd As ObjectId In btr
                            Dim en As Entity = trans.GetObject(idd, Autodesk.AutoCAD.DatabaseServices.OpenMode.ForWrite)

                            'If en.BlockName <> "*Paper_Space" And en.BlockName <> "*Model_Space" Then

                            'TODO: ... eKey error?
                            If en.Layer = "0" Then
                                en.Layer = "00"
                            End If

                            'End If

                            en.ColorIndex = 256 'is bylayer  '0 is byblock
                        Next
                    End If

                Next
                trans.Commit()
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            Finally
                docLock.Dispose() : trans.Dispose()
            End Try

        End Sub



        Public Sub AddLayer()
            Dim curdb As Database = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Database
            Dim tm As Autodesk.AutoCAD.DatabaseServices.TransactionManager = curdb.TransactionManager
            Dim myT As Transaction = tm.StartTransaction()
            Dim DocCol As DocumentCollection = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager
            Dim docLock As DocumentLock = DocCol.MdiActiveDocument.LockDocument()
            Try
                Dim lt As LayerTable = CType(tm.GetObject(curdb.LayerTableId, OpenMode.ForWrite), LayerTable)
                Dim layer As New LayerTableRecord
                With layer
                    .Name = "00"
                    .IsOff = False
                    .IsFrozen = False
                    .IsLocked = False
                    .Color = Autodesk.AutoCAD.Colors.Color.FromColorIndex(Autodesk.AutoCAD.Colors.ColorMethod.ByColor, 7)
                    .LineWeight = LineWeight.ByLineWeightDefault
                    .IsPlottable = True
                End With
                lt.Add(layer)
                myT.AddNewlyCreatedDBObject(layer, True)
                layer.Description = "Layer created programmatically for layer 0"
                myT.Commit()
            Catch ex As Exception
                myT.Abort()
                MessageBox.Show("An error ocurred while trying to add a new layer")
            Finally
                docLock.Dispose() : myT.Dispose()
            End Try
        End Sub


        Dim aLst As New ArrayList

        Private Sub btnLstXrefs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLstXrefs.Click
            aLst = New ArrayList
            GetXrefList()
            dgXrefs.DataSource = aLst
        End Sub


        Public Sub GetXrefList()
            Dim Doc As Document = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument
            Dim Db As Database = Doc.Database
            Dim Tr As Transaction = Db.TransactionManager.StartTransaction()

            Using Tr
                Dim DbXrGraph As XrefGraph = Db.GetHostDwgXrefGraph(False)
                For i As Integer = 1 To DbXrGraph.NumNodes - 1
                    Dim XrGraphNode As XrefGraphNode = DbXrGraph.GetXrefNode(i)
                    If Not XrGraphNode.IsNested Then
                        Dim btr As BlockTableRecord = DirectCast(Tr.GetObject(XrGraphNode.BlockTableRecordId, OpenMode.ForRead), BlockTableRecord)
                        aLst.Add(New Developer("TOP: " & XrGraphNode.Name, btr.IsFromOverlayReference, XrGraphNode.XrefStatus.ToString(), XrGraphNode.XrefNotificationStatus.ToString()))
                        getSubReference(Tr, XrGraphNode.BlockTableRecordId, DbXrGraph)
                    End If

                Next
            End Using

        End Sub


        Private Function getSubReference(ByRef Tr As Transaction, ByVal BlockID As ObjectId, ByVal DbXrGraph As XrefGraph) As Boolean
            Dim btr As BlockTableRecord = DirectCast(Tr.GetObject(BlockID, OpenMode.ForRead), BlockTableRecord)
            Dim hasXref As Boolean = False
            Dim iter As BlockTableRecordEnumerator = btr.GetEnumerator

            While iter.MoveNext
                Dim ent As Entity = iter.Current.GetObject(OpenMode.ForRead)
                If TypeName(ent) = "BlockReference" Then
                    Dim BR As BlockReference = CType(ent, BlockReference)
                    Dim nBTR As BlockTableRecord = Tr.GetObject(BR.BlockTableRecord, OpenMode.ForRead)
                    If nBTR.IsFromExternalReference Then
                        If getSubReference(Tr, nBTR.ObjectId, DbXrGraph) Then
                            aLst.Add(New Developer("Mid: " & btr.Name & " Sub: " & nBTR.Name, nBTR.IsFromOverlayReference, DbXrGraph.GetXrefNode(nBTR.Name).XrefStatus.ToString(), DbXrGraph.GetXrefNode(nBTR.Name).XrefNotificationStatus.ToString()))
                        Else
                            aLst.Add(New Developer("End: " & btr.Name & " Sub: " & nBTR.Name, nBTR.IsFromOverlayReference, DbXrGraph.GetXrefNode(nBTR.Name).XrefStatus.ToString(), DbXrGraph.GetXrefNode(nBTR.Name).XrefNotificationStatus.ToString()))
                        End If
                        hasXref = True
                    End If
                End If

            End While
            Return hasXref
        End Function


        Private Sub btnMkXrefsTbls_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMkXrefsTbls.Click
            Dim tbl As New Table
            Dim bt As BlockTable
            Dim btr As BlockTableRecord
            Dim db As Database = HostApplicationServices.WorkingDatabase
            Dim trans As Transaction
            trans = db.TransactionManager.StartTransaction()
            tbl.IsHeaderSuppressed = False
            tbl.IsTitleSuppressed = False
            tbl.InsertRows(1, 0.25, aLst.Count + 1)
            tbl.InsertColumns(0, 1, dgXrefs.VisibleColumnCount - 1)
            tbl.SetTextString(0, 0, "Xrefs")
            Dim c As Short
            Dim Cc As Short

            tbl.SetColumnWidth(0, 15)
            tbl.SetColumnWidth(1, 5)
            tbl.SetColumnWidth(2, 5)
            tbl.SetColumnWidth(3, 5)

            tbl.SetAlignment(1, 0, CellAlignment.MiddleLeft)
            tbl.SetTextString(1, 0, "Name")

            tbl.SetAlignment(1, 1, CellAlignment.MiddleLeft)
            tbl.SetTextString(1, 1, "Overlayed")

            tbl.SetAlignment(1, 2, CellAlignment.MiddleLeft)
            tbl.SetTextString(1, 2, "Status")

            tbl.SetAlignment(1, 3, CellAlignment.MiddleLeft)
            tbl.SetTextString(1, 3, "StatusNotify")

            For c = 0 To (aLst.Count - 1)
                For Cc = 0 To dgXrefs.VisibleColumnCount - 1
                    If Not IsDBNull(dgXrefs.Item(c, Cc)) Then
                        tbl.SetAlignment(c + 2, Cc, CellAlignment.MiddleLeft)
                        tbl.SetTextString(c + 2, Cc, dgXrefs.Item(c, Cc))
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


        Public Class Developer
            Private m_Name As String
            Private m_IsOverlay As String
            Private m_Status As String
            Private m_StatusNotify As String

            Public Sub New(ByVal Name As String, ByVal IsOverlay As String, ByVal Status As String, ByVal StatusNotify As String)
                Me.m_Name = Name
                Me.m_IsOverlay = IsOverlay
                Me.m_Status = Status
                Me.m_StatusNotify = StatusNotify
            End Sub

            Public ReadOnly Property FirstName() As String
                Get
                    Return Me.m_Name
                End Get
            End Property

            Public ReadOnly Property IsOverlay() As String
                Get
                    Return Me.m_IsOverlay
                End Get
            End Property

            Public ReadOnly Property Status() As String
                Get
                    Return Me.m_Status
                End Get
            End Property

            Public ReadOnly Property StatusNotify() As String
                Get
                    Return Me.m_StatusNotify
                End Get
            End Property
        End Class


        'Public Function DefineTableStyle(ByVal strStyleName As String) As TableStyle
        '    Dim ts As TableStyle = Nothing
        '    Dim Doc As Document = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument
        '    Dim Db As Database = Doc.Database
        '    Dim DocCol As DocumentCollection = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager
        '    Dim docLock As DocumentLock = DocCol.MdiActiveDocument.LockDocument()

        '    Using trans As Transaction = Db.TransactionManager.StartTransaction
        '        Dim tsd As DBDictionary = trans.GetObject(Db.TableStyleDictionaryId, OpenMode.ForWrite, True, True)
        '        If tsd.Contains(strStyleName) Then
        '            ts = tsd.GetAt(strStyleName).GetObject(OpenMode.ForWrite)
        '        Else
        '            ts = New TableStyle
        '            tsd.SetAt(strStyleName, ts)
        '            trans.AddNewlyCreatedDBObject(ts, True)
        '        End If
        '        Select Case strStyleName

        '            Case "XrefListTbl"
        '                ts.HorizontalCellMargin = 1
        '                ts.VerticalCellMargin = 5
        '                Dim txtstyle As ObjectId = AddTextStyle("Simplex", "Simplex")
        '                ts.SetTextStyle(txtstyle, RowType.TitleRow)
        '                ts.SetTextStyle(txtstyle, RowType.HeaderRow)
        '                ts.SetTextStyle(txtstyle, RowType.DataRow)
        '                ts.SetTextHeight(8, RowType.TitleRow)
        '                ts.SetTextHeight(6, RowType.HeaderRow)
        '                ts.SetTextHeight(6, RowType.DataRow)
        '                ts.SetAlignment(CellAlignment.MiddleLeft, RowType.TitleRow)
        '                ts.SetAlignment(CellAlignment.MiddleCenter, RowType.HeaderRow)
        '                ts.SetAlignment(CellAlignment.MiddleCenter, RowType.DataRow)

        '            Case Else
        '        End Select
        '        docLock.Dispose() : trans.Commit()
        '    End Using
        '    Return ts
        'End Function

        'Function AddTextStyle(ByVal TextStyleName As String, ByVal FontName As String) As ObjectId
        '    Dim id As ObjectId
        '    Dim myDWG As Autodesk.AutoCAD.ApplicationServices.Document
        '    Dim myDB As Autodesk.AutoCAD.DatabaseServices.Database
        '    Dim myTransMan As Autodesk.AutoCAD.DatabaseServices.TransactionManager
        '    Dim myTrans As Autodesk.AutoCAD.DatabaseServices.Transaction

        '    myDWG = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument
        '    myDB = myDWG.Database
        '    myTransMan = myDWG.TransactionManager
        '    myTrans = myTransMan.StartTransaction

        '    Dim myTST As Autodesk.AutoCAD.DatabaseServices.TextStyleTable
        '    Dim myTSTR As Autodesk.AutoCAD.DatabaseServices.TextStyleTableRecord

        '    Try
        '        myTST = myDB.TextStyleTableId.GetObject(Autodesk.AutoCAD.DatabaseServices.OpenMode.ForWrite)
        '        myTSTR = New Autodesk.AutoCAD.DatabaseServices.TextStyleTableRecord
        '        myTSTR.Name = TextStyleName
        '        Dim myFont As New Autodesk.AutoCAD.GraphicsInterface.FontDescriptor(FontName, False, False, 0, 0)
        '        myTSTR.Font = myFont
        '        myTST.Add(myTSTR)
        '        myTrans.AddNewlyCreatedDBObject(myTSTR, True)
        '        id = myTSTR.ObjectId
        '    Catch ex As Exception
        '        If ex.Message = "eDuplicateRecordName" Then
        '            ' style is already present
        '            myTrans.Dispose()
        '            myTransMan.Dispose()
        '            Return id
        '        End If
        '    End Try
        '    ' Commit and Dispose Transaction
        '    myTrans.Commit() : myTrans.Dispose() : myTransMan.Dispose()

        '    Return id

        'End Function




        Private Sub btnGetShortCuts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetShortCuts.Click


            Dim cls As clsUtil.Class1 = New clsUtil.Class1()

            Dim clsTbl As New clsUtil.Class1.shCt()


            Dim retArryLst As ArrayList = cls.GetShortcuts()





            Dim tbl As New Table
            Dim bt As BlockTable
            Dim btr As BlockTableRecord
            Dim db As Database = HostApplicationServices.WorkingDatabase
            Dim trans As Transaction
            trans = db.TransactionManager.StartTransaction()
            tbl.IsHeaderSuppressed = False
            tbl.IsTitleSuppressed = False
            tbl.InsertRows(1, 0.25, retArryLst.Count + 1)
            tbl.InsertColumns(0, 1, 1)
            tbl.SetTextString(0, 0, "Reports")
            Dim c As Short
            'Dim Cc As Short

            tbl.SetColumnWidth(0, 5)
            tbl.SetColumnWidth(1, 10)
            'tbl.SetColumnWidth(2, 5)
            'tbl.SetColumnWidth(3, 5)

            tbl.SetAlignment(1, 0, CellAlignment.MiddleLeft)
            tbl.SetTextString(1, 0, "Shortcut Name")

            tbl.SetAlignment(1, 1, CellAlignment.MiddleLeft)
            tbl.SetTextString(1, 1, "Path")

            'tbl.SetAlignment(1, 2, CellAlignment.MiddleLeft)
            'tbl.SetTextString(1, 2, "..")

            'tbl.SetAlignment(1, 3, CellAlignment.MiddleLeft)
            'tbl.SetTextString(1, 3, "...")



            For c = 0 To (retArryLst.Count - 1)

                tbl.SetAlignment(c + 2, 0, CellAlignment.MiddleLeft)
                tbl.SetAlignment(c + 2, 1, CellAlignment.MiddleLeft)
                'tbl.SetAlignment(c + 2, 2, CellAlignment.MiddleLeft)
                'tbl.SetAlignment(c + 2, 3, CellAlignment.MiddleLeft)

                clsTbl = retArryLst(c)

                tbl.SetTextString(c + 2, 0, clsTbl.link)
                tbl.SetTextString(c + 2, 1, clsTbl.args)
                'tbl.SetTextString(c + 2, 2, "..")
                'tbl.SetTextString(c + 2, 3, "...")

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


        Private Sub btnGetTasks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetTasks.Click
            Dim cls As clsUtil.Class1 = New clsUtil.Class1()

            Dim clsTbl As New clsUtil.Class1.tsk()

            Dim retArryLst As ArrayList = cls.GetTasks()

            Dim tbl As New Table
            Dim bt As BlockTable
            Dim btr As BlockTableRecord
            Dim db As Database = HostApplicationServices.WorkingDatabase
            Dim trans As Transaction
            trans = db.TransactionManager.StartTransaction()
            tbl.IsHeaderSuppressed = False
            tbl.IsTitleSuppressed = False
            tbl.InsertRows(1, 0.25, retArryLst.Count + 1)

            tbl.InsertColumns(0, 1, 3) ' 4 cols
            tbl.SetTextString(0, 0, "Tasks")
            Dim c As Short
            'Dim Cc As Short

            tbl.SetColumnWidth(0, 8)
            tbl.SetColumnWidth(1, 8)
            tbl.SetColumnWidth(2, 8)
            tbl.SetColumnWidth(3, 8)

            tbl.SetAlignment(1, 0, CellAlignment.MiddleLeft)
            tbl.SetTextString(1, 0, "Application")

            tbl.SetAlignment(1, 1, CellAlignment.MiddleLeft)
            tbl.SetTextString(1, 1, "Account")

            tbl.SetAlignment(1, 2, CellAlignment.MiddleLeft)
            tbl.SetTextString(1, 2, "Working Dir")

            tbl.SetAlignment(1, 3, CellAlignment.MiddleLeft)
            tbl.SetTextString(1, 3, "Trigger")



            For c = 0 To (retArryLst.Count - 1)

                tbl.SetAlignment(c + 2, 0, CellAlignment.MiddleLeft)
                tbl.SetAlignment(c + 2, 1, CellAlignment.MiddleLeft)
                tbl.SetAlignment(c + 2, 2, CellAlignment.MiddleLeft)
                tbl.SetAlignment(c + 2, 3, CellAlignment.MiddleLeft)

                clsTbl = retArryLst(c)

                tbl.SetTextString(c + 2, 0, clsTbl.appName)
                tbl.SetTextString(c + 2, 1, clsTbl.accName)
                tbl.SetTextString(c + 2, 2, clsTbl.appWorkDir)
                tbl.SetTextString(c + 2, 3, clsTbl.appTrigger)

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


        Private Sub btnGetDirs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetDirs.Click

            Dim cls As clsUtil.Class1 = New clsUtil.Class1()
            Dim clsTbl As New clsUtil.Class1.dir()
            Dim retArryLst As ArrayList = cls.GetDirs()


            Dim tbl As New Table
            Dim bt As BlockTable
            Dim btr As BlockTableRecord
            Dim db As Database = HostApplicationServices.WorkingDatabase
            Dim trans As Transaction
            trans = db.TransactionManager.StartTransaction()
            tbl.IsHeaderSuppressed = False
            tbl.IsTitleSuppressed = False
            tbl.InsertRows(1, 0.25, retArryLst.Count + 1)

            ' tbl.InsertColumns(0, 1, 1) ' xtra cols (one by default)
            tbl.SetTextString(0, 0, "Apps")
            Dim c As Short
            'Dim Cc As Short

            tbl.SetColumnWidth(0, 8)
            ' tbl.SetColumnWidth(1, 8)
            'tbl.SetColumnWidth(2, 8)
            'tbl.SetColumnWidth(3, 8)

            tbl.SetAlignment(1, 0, CellAlignment.MiddleLeft)
            tbl.SetTextString(1, 0, "Application")

            'tbl.SetAlignment(1, 1, CellAlignment.MiddleLeft)
            'tbl.SetTextString(1, 1, "Account")

            'tbl.SetAlignment(1, 2, CellAlignment.MiddleLeft)
            'tbl.SetTextString(1, 2, "Working Dir")

            'tbl.SetAlignment(1, 3, CellAlignment.MiddleLeft)
            'tbl.SetTextString(1, 3, "Trigger")



            For c = 0 To (retArryLst.Count - 1)

                tbl.SetAlignment(c + 2, 0, CellAlignment.MiddleLeft)
                'tbl.SetAlignment(c + 2, 1, CellAlignment.MiddleLeft)
                'tbl.SetAlignment(c + 2, 2, CellAlignment.MiddleLeft)
                'tbl.SetAlignment(c + 2, 3, CellAlignment.MiddleLeft)

                clsTbl = retArryLst(c)

                tbl.SetTextString(c + 2, 0, clsTbl.appDir)
                'tbl.SetTextString(c + 2, 1, "''")
                'tbl.SetTextString(c + 2, 2, "''")
                'tbl.SetTextString(c + 2, 3, "''")

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






        Private Sub btnGetServices_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetServices.Click
            Dim cls As clsUtil.Class1 = New clsUtil.Class1()
            Dim clsTbl As New clsUtil.Class1.svc()
            Dim retArryLst As ArrayList = cls.getSvc()


            Dim tbl As New Table
            Dim bt As BlockTable
            Dim btr As BlockTableRecord
            Dim db As Database = HostApplicationServices.WorkingDatabase
            Dim trans As Transaction
            trans = db.TransactionManager.StartTransaction()
            tbl.IsHeaderSuppressed = False
            tbl.IsTitleSuppressed = False
            tbl.InsertRows(1, 0.25, retArryLst.Count + 1)

            tbl.InsertColumns(0, 1, 5) ' xtra cols (one by default)
            tbl.SetTextString(0, 0, "Services")
            Dim c As Short
            'Dim Cc As Short

            tbl.SetColumnWidth(0, 8)
            tbl.SetColumnWidth(1, 15)
            tbl.SetColumnWidth(2, 4)
            tbl.SetColumnWidth(3, 4)
            tbl.SetColumnWidth(4, 4)
            tbl.SetColumnWidth(5, 4)

            tbl.SetAlignment(1, 0, CellAlignment.MiddleLeft)
            tbl.SetTextString(1, 0, "Description")

            tbl.SetAlignment(1, 1, CellAlignment.MiddleLeft)
            tbl.SetTextString(1, 1, "PathName")

            tbl.SetAlignment(1, 2, CellAlignment.MiddleLeft)
            tbl.SetTextString(1, 2, "ServiceType")

            tbl.SetAlignment(1, 3, CellAlignment.MiddleLeft)
            tbl.SetTextString(1, 3, "State")

            tbl.SetAlignment(1, 4, CellAlignment.MiddleLeft)
            tbl.SetTextString(1, 4, "StartMode")

            tbl.SetAlignment(1, 5, CellAlignment.MiddleLeft)
            tbl.SetTextString(1, 5, "StartName")


            For c = 0 To (retArryLst.Count - 1)

                tbl.SetAlignment(c + 2, 0, CellAlignment.MiddleLeft)
                tbl.SetAlignment(c + 2, 1, CellAlignment.MiddleLeft)
                tbl.SetAlignment(c + 2, 2, CellAlignment.MiddleLeft)
                tbl.SetAlignment(c + 2, 3, CellAlignment.MiddleLeft)
                tbl.SetAlignment(c + 2, 4, CellAlignment.MiddleLeft)
                tbl.SetAlignment(c + 2, 5, CellAlignment.MiddleLeft)

                clsTbl = retArryLst(c)

                tbl.SetTextString(c + 2, 0, clsTbl.Description)
                tbl.SetTextString(c + 2, 1, clsTbl.PathName)
                tbl.SetTextString(c + 2, 2, clsTbl.ServiceType)
                tbl.SetTextString(c + 2, 3, clsTbl.State)
                tbl.SetTextString(c + 2, 4, clsTbl.StartMode)
                tbl.SetTextString(c + 2, 5, clsTbl.StartName)


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










        Private Sub btnGetDB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetDB.Click
            Dim cls As clsUtil.Class1 = New clsUtil.Class1()
            Dim clsTbl As New clsUtil.Class1.DB()
            'Dim retArryLst As System.Data.DataTable = cls.getDB()

            Dim retArryLst As ArrayList = cls.getDB()

            '  dgXrefs.DataSource = retArryLst

            Dim tbl As New Table
            Dim bt As BlockTable
            Dim btr As BlockTableRecord
            Dim db As Database = HostApplicationServices.WorkingDatabase
            Dim trans As Transaction
            trans = db.TransactionManager.StartTransaction()
            tbl.IsHeaderSuppressed = False
            tbl.IsTitleSuppressed = False
            tbl.InsertRows(1, 0.25, retArryLst.Count + 1)

            tbl.InsertColumns(0, 1, 1) ' xtra cols (one by default)
            tbl.SetTextString(0, 0, "Databases")
            Dim c As Short
            'Dim Cc As Short

            tbl.SetColumnWidth(0, 8)
            tbl.SetColumnWidth(1, 15)
            'tbl.SetColumnWidth(2, 4)
            'tbl.SetColumnWidth(3, 4)
            'tbl.SetColumnWidth(4, 4)
            'tbl.SetColumnWidth(5, 4)

            tbl.SetAlignment(1, 0, CellAlignment.MiddleLeft)
            tbl.SetTextString(1, 0, "Database")

            tbl.SetAlignment(1, 1, CellAlignment.MiddleLeft)
            tbl.SetTextString(1, 1, "Table")

            'tbl.SetAlignment(1, 2, CellAlignment.MiddleLeft)
            'tbl.SetTextString(1, 2, "ServiceType")

            'tbl.SetAlignment(1, 3, CellAlignment.MiddleLeft)
            'tbl.SetTextString(1, 3, "State")

            'tbl.SetAlignment(1, 4, CellAlignment.MiddleLeft)
            'tbl.SetTextString(1, 4, "StartMode")

            'tbl.SetAlignment(1, 5, CellAlignment.MiddleLeft)
            'tbl.SetTextString(1, 5, "StartName")


            For c = 0 To (retArryLst.Count - 1)

                tbl.SetAlignment(c + 2, 0, CellAlignment.MiddleLeft)
                tbl.SetAlignment(c + 2, 1, CellAlignment.MiddleLeft)
                'tbl.SetAlignment(c + 2, 2, CellAlignment.MiddleLeft)
                'tbl.SetAlignment(c + 2, 3, CellAlignment.MiddleLeft)
                'tbl.SetAlignment(c + 2, 4, CellAlignment.MiddleLeft)
                'tbl.SetAlignment(c + 2, 5, CellAlignment.MiddleLeft)

                clsTbl = retArryLst(c)

                tbl.SetTextString(c + 2, 0, clsTbl.TABLE_QUALIFIER)
                tbl.SetTextString(c + 2, 1, clsTbl.TABLE_NAME)
                'tbl.SetTextString(c + 2, 2, clsTbl.ServiceType)
                'tbl.SetTextString(c + 2, 3, clsTbl.State)
                'tbl.SetTextString(c + 2, 4, clsTbl.StartMode)
                'tbl.SetTextString(c + 2, 5, clsTbl.StartName)


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

        Private Sub btnEventLogs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEventLogs.Click
            Dim cls As clsUtil.Class1 = New clsUtil.Class1()
            Dim clsTbl As New clsUtil.Class1.evntLog()
            'Dim retArryLst As System.Data.DataTable = cls.getDB()

            Dim retArryLst As ArrayList = cls.getEL()



            Dim tbl As New Table
            Dim bt As BlockTable
            Dim btr As BlockTableRecord
            Dim db As Database = HostApplicationServices.WorkingDatabase
            Dim trans As Transaction
            trans = db.TransactionManager.StartTransaction()
            tbl.IsHeaderSuppressed = False
            tbl.IsTitleSuppressed = False
            tbl.InsertRows(1, 0.25, retArryLst.Count + 1)

            tbl.InsertColumns(0, 1, 1) ' xtra cols (one by default)
            tbl.SetTextString(0, 0, "Event Logs")
            Dim c As Short
            'Dim Cc As Short

            tbl.SetColumnWidth(0, 8)
            tbl.SetColumnWidth(1, 15)
            'tbl.SetColumnWidth(2, 4)
            'tbl.SetColumnWidth(3, 4)
            'tbl.SetColumnWidth(4, 4)
            'tbl.SetColumnWidth(5, 4)

            tbl.SetAlignment(1, 0, CellAlignment.MiddleLeft)
            tbl.SetTextString(1, 0, "Name")

            tbl.SetAlignment(1, 1, CellAlignment.MiddleLeft)
            tbl.SetTextString(1, 1, "?")

            'tbl.SetAlignment(1, 2, CellAlignment.MiddleLeft)
            'tbl.SetTextString(1, 2, "ServiceType")

            'tbl.SetAlignment(1, 3, CellAlignment.MiddleLeft)
            'tbl.SetTextString(1, 3, "State")

            'tbl.SetAlignment(1, 4, CellAlignment.MiddleLeft)
            'tbl.SetTextString(1, 4, "StartMode")

            'tbl.SetAlignment(1, 5, CellAlignment.MiddleLeft)
            'tbl.SetTextString(1, 5, "StartName")


            For c = 0 To (retArryLst.Count - 1)

                tbl.SetAlignment(c + 2, 0, CellAlignment.MiddleLeft)
                tbl.SetAlignment(c + 2, 1, CellAlignment.MiddleLeft)
                'tbl.SetAlignment(c + 2, 2, CellAlignment.MiddleLeft)
                'tbl.SetAlignment(c + 2, 3, CellAlignment.MiddleLeft)
                'tbl.SetAlignment(c + 2, 4, CellAlignment.MiddleLeft)
                'tbl.SetAlignment(c + 2, 5, CellAlignment.MiddleLeft)

                clsTbl = retArryLst(c)

                tbl.SetTextString(c + 2, 0, clsTbl.Name)
                tbl.SetTextString(c + 2, 1, clsTbl.Name)
                'tbl.SetTextString(c + 2, 2, clsTbl.ServiceType)
                'tbl.SetTextString(c + 2, 3, clsTbl.State)
                'tbl.SetTextString(c + 2, 4, clsTbl.StartMode)
                'tbl.SetTextString(c + 2, 5, clsTbl.StartName)


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

        Private Sub btnIIS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIIS.Click
            Dim cls As clsUtil.Class1 = New clsUtil.Class1()
            'Dim clsTbl As New clsUtil.Class1.evntLog()
            'Dim retArryLst As System.Data.DataTable = cls.getDB()

            'Dim retArryLst As String = 
            'cls.GetSites("DFHLSCASQL01")

        End Sub
    End Class





End Namespace