Option Explicit On 

Imports System.Windows.Forms

Imports Autodesk.AutoCAD.ApplicationServices
Imports Autodesk.AutoCAD.DatabaseServices

Imports rnsCadDataProj.nsForms
Imports rnsCadDataProj.nsMods

Namespace nsUserCtls

    Public Class ucRevisions

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
        Friend WithEvents chkbxJustCurLayout As System.Windows.Forms.CheckBox
        Friend WithEvents btnClrRevsLst As System.Windows.Forms.Button
        Friend WithEvents lbRevsFromCurFile As System.Windows.Forms.ListBox
        Friend WithEvents lblNewRev As System.Windows.Forms.Label
        Friend WithEvents dtpRevDate As System.Windows.Forms.DateTimePicker
        Friend WithEvents cbRevBy As System.Windows.Forms.ComboBox
        Friend WithEvents cbRevTxt As System.Windows.Forms.ComboBox
        Friend WithEvents btnSeeNewRev As System.Windows.Forms.Button
        Friend WithEvents tbRevId As System.Windows.Forms.TextBox
        Friend WithEvents btnClrRevs As System.Windows.Forms.Button
        Friend WithEvents btnAddRevsFrmLst As System.Windows.Forms.Button
        Friend WithEvents btnGetRevs As System.Windows.Forms.Button
        Friend WithEvents btnAddNextRev As System.Windows.Forms.Button
        Friend WithEvents chkbxUseLetters As System.Windows.Forms.CheckBox
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.btnAddRevsFrmLst = New System.Windows.Forms.Button()
            Me.chkbxJustCurLayout = New System.Windows.Forms.CheckBox()
            Me.btnClrRevsLst = New System.Windows.Forms.Button()
            Me.btnGetRevs = New System.Windows.Forms.Button()
            Me.lbRevsFromCurFile = New System.Windows.Forms.ListBox()
            Me.lblNewRev = New System.Windows.Forms.Label()
            Me.dtpRevDate = New System.Windows.Forms.DateTimePicker()
            Me.cbRevBy = New System.Windows.Forms.ComboBox()
            Me.cbRevTxt = New System.Windows.Forms.ComboBox()
            Me.btnSeeNewRev = New System.Windows.Forms.Button()
            Me.tbRevId = New System.Windows.Forms.TextBox()
            Me.btnClrRevs = New System.Windows.Forms.Button()
            Me.btnAddNextRev = New System.Windows.Forms.Button()
            Me.chkbxUseLetters = New System.Windows.Forms.CheckBox()
            Me.SuspendLayout()
            '
            'btnAddRevsFrmLst
            '
            Me.btnAddRevsFrmLst.Location = New System.Drawing.Point(77, 537)
            Me.btnAddRevsFrmLst.Name = "btnAddRevsFrmLst"
            Me.btnAddRevsFrmLst.Size = New System.Drawing.Size(376, 67)
            Me.btnAddRevsFrmLst.TabIndex = 19
            Me.btnAddRevsFrmLst.Text = "Add Revs Frm Lst"
            '
            'chkbxJustCurLayout
            '
            Me.chkbxJustCurLayout.Checked = True
            Me.chkbxJustCurLayout.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkbxJustCurLayout.Location = New System.Drawing.Point(327, 298)
            Me.chkbxJustCurLayout.Name = "chkbxJustCurLayout"
            Me.chkbxJustCurLayout.Size = New System.Drawing.Size(300, 53)
            Me.chkbxJustCurLayout.TabIndex = 18
            Me.chkbxJustCurLayout.Text = "JustCurLayout"
            '
            'btnClrRevsLst
            '
            Me.btnClrRevsLst.Location = New System.Drawing.Point(313, 217)
            Me.btnClrRevsLst.Name = "btnClrRevsLst"
            Me.btnClrRevsLst.Size = New System.Drawing.Size(272, 52)
            Me.btnClrRevsLst.TabIndex = 17
            Me.btnClrRevsLst.Text = "Clr Revs Lst"
            '
            'btnGetRevs
            '
            Me.btnGetRevs.Location = New System.Drawing.Point(77, 376)
            Me.btnGetRevs.Name = "btnGetRevs"
            Me.btnGetRevs.Size = New System.Drawing.Size(376, 62)
            Me.btnGetRevs.TabIndex = 16
            Me.btnGetRevs.Text = "Get Revs"
            '
            'lbRevsFromCurFile
            '
            Me.lbRevsFromCurFile.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lbRevsFromCurFile.ItemHeight = 31
            Me.lbRevsFromCurFile.Location = New System.Drawing.Point(759, 321)
            Me.lbRevsFromCurFile.Name = "lbRevsFromCurFile"
            Me.lbRevsFromCurFile.Size = New System.Drawing.Size(907, 438)
            Me.lbRevsFromCurFile.TabIndex = 15
            '
            'lblNewRev
            '
            Me.lblNewRev.Location = New System.Drawing.Point(18, -9)
            Me.lblNewRev.Name = "lblNewRev"
            Me.lblNewRev.Size = New System.Drawing.Size(735, 97)
            Me.lblNewRev.TabIndex = 13
            Me.lblNewRev.Text = "lblNewRev"
            '
            'dtpRevDate
            '
            Me.dtpRevDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpRevDate.Location = New System.Drawing.Point(86, 111)
            Me.dtpRevDate.Name = "dtpRevDate"
            Me.dtpRevDate.Size = New System.Drawing.Size(202, 38)
            Me.dtpRevDate.TabIndex = 12
            '
            'cbRevBy
            '
            Me.cbRevBy.Items.AddRange(New Object() {"GDW", "XXX"})
            Me.cbRevBy.Location = New System.Drawing.Point(294, 111)
            Me.cbRevBy.Name = "cbRevBy"
            Me.cbRevBy.Size = New System.Drawing.Size(151, 39)
            Me.cbRevBy.TabIndex = 11
            Me.cbRevBy.Text = "cbRevBy"
            '
            'cbRevTxt
            '
            Me.cbRevTxt.Items.AddRange(New Object() {"Owner Control", "Preliminary", "Issued For Bid", "Issued For Construction"})
            Me.cbRevTxt.Location = New System.Drawing.Point(461, 114)
            Me.cbRevTxt.Name = "cbRevTxt"
            Me.cbRevTxt.Size = New System.Drawing.Size(280, 39)
            Me.cbRevTxt.TabIndex = 10
            Me.cbRevTxt.Text = "cbRevTxt"
            '
            'btnSeeNewRev
            '
            Me.btnSeeNewRev.Location = New System.Drawing.Point(313, 163)
            Me.btnSeeNewRev.Name = "btnSeeNewRev"
            Me.btnSeeNewRev.Size = New System.Drawing.Size(272, 52)
            Me.btnSeeNewRev.TabIndex = 14
            Me.btnSeeNewRev.Text = "See New Rev"
            '
            'tbRevId
            '
            Me.tbRevId.Location = New System.Drawing.Point(8, 112)
            Me.tbRevId.Name = "tbRevId"
            Me.tbRevId.Size = New System.Drawing.Size(72, 38)
            Me.tbRevId.TabIndex = 20
            Me.tbRevId.Text = "0"
            '
            'btnClrRevs
            '
            Me.btnClrRevs.Location = New System.Drawing.Point(77, 464)
            Me.btnClrRevs.Name = "btnClrRevs"
            Me.btnClrRevs.Size = New System.Drawing.Size(376, 54)
            Me.btnClrRevs.TabIndex = 21
            Me.btnClrRevs.Text = "Clr Revs"
            '
            'btnAddNextRev
            '
            Me.btnAddNextRev.Location = New System.Drawing.Point(77, 636)
            Me.btnAddNextRev.Name = "btnAddNextRev"
            Me.btnAddNextRev.Size = New System.Drawing.Size(376, 63)
            Me.btnAddNextRev.TabIndex = 22
            Me.btnAddNextRev.Text = "Add Next Rev"
            '
            'chkbxUseLetters
            '
            Me.chkbxUseLetters.Location = New System.Drawing.Point(24, 245)
            Me.chkbxUseLetters.Name = "chkbxUseLetters"
            Me.chkbxUseLetters.Size = New System.Drawing.Size(264, 53)
            Me.chkbxUseLetters.TabIndex = 23
            Me.chkbxUseLetters.Text = "Use Letters"
            '
            'ucRevisions
            '
            Me.Controls.Add(Me.chkbxUseLetters)
            Me.Controls.Add(Me.btnAddNextRev)
            Me.Controls.Add(Me.btnClrRevs)
            Me.Controls.Add(Me.tbRevId)
            Me.Controls.Add(Me.btnAddRevsFrmLst)
            Me.Controls.Add(Me.chkbxJustCurLayout)
            Me.Controls.Add(Me.btnClrRevsLst)
            Me.Controls.Add(Me.btnGetRevs)
            Me.Controls.Add(Me.lbRevsFromCurFile)
            Me.Controls.Add(Me.btnSeeNewRev)
            Me.Controls.Add(Me.lblNewRev)
            Me.Controls.Add(Me.dtpRevDate)
            Me.Controls.Add(Me.cbRevBy)
            Me.Controls.Add(Me.cbRevTxt)
            Me.Name = "ucRevisions"
            Me.Size = New System.Drawing.Size(1682, 816)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Dim Rrevs() As String = {"", "", "", "", "", ""}
        Dim RDesc() As String = {"", "", ""}

        Private Sub ucRevisions_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            ' Set up the Rev Date Picker
            dtpRevDate.CustomFormat = "MM/dd/yy"
            dtpRevDate.Format = DateTimePickerFormat.Custom
            ' Set up Default Rev Info
            cbRevBy.SelectedIndex = 0
            cbRevTxt.SelectedIndex = 0
        End Sub

        Private Sub btnSeeNewRev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeeNewRev.Click
            SeeNewRev()
        End Sub

        Private Sub SeeNewRev()
            If lbRevsFromCurFile.Items.Count = 6 Then
                Try : lbRevsFromCurFile.Items.RemoveAt(0)
                Catch ex As Exception : MessageBox.Show(ex.ToString)
                End Try
            End If
            If lbRevsFromCurFile.Items.Count = 0 Then
                lblNewRev.Text = tbRevId.Text & " . " & dtpRevDate.Text & " . " & UCase(cbRevBy.Text) & " . " & UCase(cbRevTxt.Text)
                If drnID <> Nothing Then lblNewRev.Text = lblNewRev.Text & " . " & "DRN #" & drnID
                lbRevsFromCurFile.Items.Add(lblNewRev.Text)
            Else
                Dim myArray() As String = Split(lbRevsFromCurFile.Items(lbRevsFromCurFile.Items.Count - 1))
                tbRevId.Text = Trim(myArray(0)) + 1 'lbRevsFromCurFile.Items.Count
                lblNewRev.Text = tbRevId.Text & " . " & dtpRevDate.Text & " . " & UCase(cbRevBy.Text) & " . " & UCase(cbRevTxt.Text)
                If drnID <> Nothing Then lblNewRev.Text = lblNewRev.Text & " . " & "DRN #" & drnID
                lbRevsFromCurFile.Items.Add(lblNewRev.Text)
            End If
        End Sub

        Private Sub btnGetRevs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetRevs.Click
            Dim Doc As Autodesk.AutoCAD.ApplicationServices.Document = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument
            Dim db As Database = HostApplicationServices.WorkingDatabase
            db = Doc.Database : splitFName(Doc)
            Dim lDic As Autodesk.AutoCAD.DatabaseServices.DBDictionary
            Dim lDicdEnt As System.Collections.DictionaryEntry
            Dim trans As Transaction = db.TransactionManager.StartTransaction()
            Dim docLock As DocumentLock = Doc.LockDocument()
            ClrRevsLst()
            Try : lDic = trans.GetObject(db.LayoutDictionaryId, OpenMode.ForRead)
                If chkbxJustCurLayout.Checked Then
                    getputCurLayoutAtts(Doc, trans) ' does the cur layout
                Else
                    For Each lDicdEnt In lDic
                        getputCurDocAtts(Doc, trans, lDicdEnt) ' does all the layouts
                    Next
                End If
                trans.Commit()
            Finally
                docLock.Dispose() : trans.Dispose()
            End Try
            ' If chkbxCloseFile.Checked = True Then Doc.CloseAndDiscard()
            ' dgBldLst.DataSource = cloneTable
        End Sub

        Private Sub btnAddRevsFrmLst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddRevsFrmLst.Click
            AddRevsFrmLst()
        End Sub

        Public Sub AddRevsFrmLst()
            Dim Doc As Autodesk.AutoCAD.ApplicationServices.Document = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument
            Dim db As Database = HostApplicationServices.WorkingDatabase
            db = Doc.Database : splitFName(Doc)
            Dim lDic As Autodesk.AutoCAD.DatabaseServices.DBDictionary
            Dim lDicdEnt As System.Collections.DictionaryEntry
            Dim trans As Transaction = db.TransactionManager.StartTransaction()
            Dim docLock As DocumentLock = Doc.LockDocument()
            Try : lDic = trans.GetObject(db.LayoutDictionaryId, OpenMode.ForRead)
                If chkbxJustCurLayout.Checked Then
                    clrCurDocRevAtts(Doc, trans)
                    AddRevsFrmLst(Doc, trans)
                Else
                    For Each lDicdEnt In lDic
                        clrCurDocRevAtts(Doc, trans, lDicdEnt)
                        AddRevsFrmLst(Doc, trans, lDicdEnt)
                    Next
                End If
                trans.Commit()
            Finally
                docLock.Dispose() : trans.Dispose()
            End Try
            'If chkbxCloseFile.Checked = True Then Doc.CloseAndDiscard()
            ' dgBldLst.DataSource = cloneTable
        End Sub

        Private Sub btnClrRevsLst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClrRevsLst.Click
            ClrRevsLst()
        End Sub

        Private Sub ClrRevsLst()
            lbRevsFromCurFile.Items.Clear()
            tbRevId.Text = 0
        End Sub

        Private Sub AddRevsFrmLst(ByVal Doc As Autodesk.AutoCAD.ApplicationServices.Document, ByVal trans As Transaction, ByVal lDicdEnt As System.Collections.DictionaryEntry)
            Dim myEntObj As Entity : Dim myEntObjId As ObjectId
            Dim LayMan As LayoutManager = LayoutManager.Current
            Dim lOut As Layout = trans.GetObject(lDicdEnt.Value, OpenMode.ForRead)
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
                                            Try ' could get from db
                                                If Att.Tag = "REV1" Then Att.TextString = lbRevsFromCurFile.Items(0)
                                                If Att.Tag = "REV2" Then Att.TextString = lbRevsFromCurFile.Items(1)
                                                If Att.Tag = "REV3" Then Att.TextString = lbRevsFromCurFile.Items(2)
                                                If Att.Tag = "REV4" Then Att.TextString = lbRevsFromCurFile.Items(3)
                                                If Att.Tag = "REV5" Then Att.TextString = lbRevsFromCurFile.Items(4)
                                                If Att.Tag = "REV6" Then Att.TextString = lbRevsFromCurFile.Items(5)
                                                ' fix this
                                            Catch 'ex As Exception
                                                'MessageBox.Show(ex.ToString)
                                            End Try
                                        Next
                                End Select
                            End If
                        Next
                    Case Else
                End Select
            Next
        End Sub

        Public Sub AddRevsFrmLst(ByVal Doc As Autodesk.AutoCAD.ApplicationServices.Document, ByVal trans As Transaction)
            Dim myEntObj As Entity : Dim myEntObjId As ObjectId
            Dim LayMan As LayoutManager = LayoutManager.Current
            Dim lOut As Layout = trans.GetObject(LayMan.GetLayoutId(LayMan.CurrentLayout), OpenMode.ForRead)

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
                                            Try ' could get from db
                                                If Att.Tag = "REV1" Then Att.TextString = lbRevsFromCurFile.Items(0)
                                                If Att.Tag = "REV2" Then Att.TextString = lbRevsFromCurFile.Items(1)
                                                If Att.Tag = "REV3" Then Att.TextString = lbRevsFromCurFile.Items(2)
                                                If Att.Tag = "REV4" Then Att.TextString = lbRevsFromCurFile.Items(3)
                                                If Att.Tag = "REV5" Then Att.TextString = lbRevsFromCurFile.Items(4)
                                                If Att.Tag = "REV6" Then Att.TextString = lbRevsFromCurFile.Items(5)
                                                ' fix this
                                            Catch 'ex As Exception
                                                'MessageBox.Show(ex.ToString)
                                            End Try
                                        Next
                                End Select
                            End If
                        Next
                    Case Else
                End Select
            Next
        End Sub

        Private Sub getputCurLayoutAtts(ByVal Doc As Autodesk.AutoCAD.ApplicationServices.Document, ByVal trans As Transaction)

            'this does not work for two titleblocks on one tab

            Dim myEntObj As Entity : Dim myEntObjId As ObjectId
            Dim LayMan As LayoutManager = LayoutManager.Current
            Dim lOut As Layout = trans.GetObject(LayMan.GetLayoutId(LayMan.CurrentLayout), OpenMode.ForRead)
            Dim btRec As BlockTableRecord : btRec = trans.GetObject(lOut.BlockTableRecordId, OpenMode.ForRead)
            For Each myEntObjId In btRec
                myEntObj = trans.GetObject(myEntObjId, OpenMode.ForRead)
                Dim ObjClsName As String = myEntObj.GetRXClass.Name
                Dim BlkRefObj As BlockReference : Dim BlkTblRec As BlockTableRecord : Dim BlkRefObjName As String
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
                                            Att = trans.GetObject(AttObjID, OpenMode.ForRead)
                                            Try ' could get from db
                                                If Att.Tag = "REV1" Then Rrevs.SetValue(Att.TextString, 0)
                                                If Att.Tag = "REV2" Then Rrevs.SetValue(Att.TextString, 1)
                                                If Att.Tag = "REV3" Then Rrevs.SetValue(Att.TextString, 2)
                                                If Att.Tag = "REV4" Then Rrevs.SetValue(Att.TextString, 3)
                                                If Att.Tag = "REV5" Then Rrevs.SetValue(Att.TextString, 4)
                                                If Att.Tag = "REV6" Then Rrevs.SetValue(Att.TextString, 5)

                                            Catch ex As Exception
                                                MessageBox.Show(ex.ToString)
                                            End Try
                                            Try ' could get from db
                                                If Att.Tag = "DESC_1" Then RDesc.SetValue(Att.TextString, 0)
                                                If Att.Tag = "DESC_2" Then RDesc.SetValue(Att.TextString, 1)
                                                If Att.Tag = "DESC_3" Then RDesc.SetValue(Att.TextString, 2)
                                            Catch ex As Exception
                                                MessageBox.Show(ex.ToString)
                                            End Try
                                        Next
                                        ' Rrevs.Sort(Rrevs) : Dim myComparer = New myReverserClass
                                        ' Rrevs.Sort(Rrevs, myComparer)
                                        ' Rrevs.Reverse(Rrevs)
                                        'lbRevsFromCurFile.Items.Add(Doc.Name & " - " & lOut.LayoutName)
                                        Dim revItm As String
                                        For Each revItm In Rrevs
                                            If revItm <> "" Then lbRevsFromCurFile.Items.Add(revItm)
                                        Next
                                        SeeNewRev()
                                        AddRevsFrmLst(Doc, trans)
                                        ClrRevsLst()
                                        'lbRevsFromCurFile.Items.Add("")
                                    Case Else
                                End Select
                            End If
                        Next
                    Case Else
                End Select
            Next
        End Sub

        Private Sub getputCurDocAtts(ByVal Doc As Autodesk.AutoCAD.ApplicationServices.Document, ByVal trans As Transaction, ByVal lDicdEnt As System.Collections.DictionaryEntry)

            'this does not work for two titleblocks on one tab

            Dim myEntObj As Entity : Dim myEntObjId As ObjectId
            Dim LayMan As LayoutManager = LayoutManager.Current
            Dim lOut As Layout = trans.GetObject(lDicdEnt.Value, OpenMode.ForRead)
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
                                            Att = trans.GetObject(AttObjID, OpenMode.ForRead)
                                            Try ' could get from db
                                                If Att.Tag = "REV1" Then Rrevs.SetValue(Att.TextString, 0)
                                                If Att.Tag = "REV2" Then Rrevs.SetValue(Att.TextString, 1)
                                                If Att.Tag = "REV3" Then Rrevs.SetValue(Att.TextString, 2)
                                                If Att.Tag = "REV4" Then Rrevs.SetValue(Att.TextString, 3)
                                                If Att.Tag = "REV5" Then Rrevs.SetValue(Att.TextString, 4)
                                                If Att.Tag = "REV6" Then Rrevs.SetValue(Att.TextString, 5)

                                            Catch ex As Exception
                                                MessageBox.Show(ex.ToString)
                                            End Try
                                            Try ' could get from db
                                                If Att.Tag = "DESC_1" Then RDesc.SetValue(Att.TextString, 0)
                                                If Att.Tag = "DESC_2" Then RDesc.SetValue(Att.TextString, 1)
                                                If Att.Tag = "DESC_3" Then RDesc.SetValue(Att.TextString, 2)
                                            Catch ex As Exception
                                                MessageBox.Show(ex.ToString)
                                            End Try
                                        Next
                                        ' Rrevs.Sort(Rrevs) : Dim myComparer = New myReverserClass
                                        ' Rrevs.Sort(Rrevs, myComparer)
                                        ' lbRevsFromCurFile.Items.Add(Doc.Name & " - " & lOut.LayoutName)
                                        Dim revItm As String
                                        For Each revItm In Rrevs
                                            If revItm <> "" Then lbRevsFromCurFile.Items.Add(revItm)
                                        Next
                                        SeeNewRev()
                                        AddRevsFrmLst(Doc, trans, lDicdEnt)
                                        ClrRevsLst()
                                        'lbRevsFromCurFile.Items.Add("")
                                End Select
                            End If
                        Next
                    Case Else
                End Select
            Next
        End Sub

        Private Sub btnClrRevs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClrRevs.Click
            ClrRevs()
        End Sub

        Public Sub ClrRevs()
            Dim Doc As Autodesk.AutoCAD.ApplicationServices.Document = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument
            Dim db As Database = HostApplicationServices.WorkingDatabase
            db = Doc.Database : splitFName(Doc)
            Dim lDic As Autodesk.AutoCAD.DatabaseServices.DBDictionary
            Dim lDicdEnt As System.Collections.DictionaryEntry
            Dim trans As Transaction = db.TransactionManager.StartTransaction()
            Dim docLock As DocumentLock = Doc.LockDocument()
            Try : lDic = trans.GetObject(db.LayoutDictionaryId, OpenMode.ForRead)

                If chkbxJustCurLayout.Checked Then
                    clrCurDocRevAtts(Doc, trans) ' does the cur layout
                Else
                    For Each lDicdEnt In lDic
                        clrCurDocRevAtts(Doc, trans, lDicdEnt)
                    Next
                End If
                trans.Commit()
            Finally
                docLock.Dispose() : trans.Dispose()
            End Try
            'If chkbxCloseFile.Checked = True Then Doc.CloseAndDiscard()
            ' dgBldLst.DataSource = cloneTable
        End Sub

        Private Sub clrCurDocRevAtts(ByVal Doc As Autodesk.AutoCAD.ApplicationServices.Document, ByVal trans As Transaction, ByVal lDicdEnt As System.Collections.DictionaryEntry)
            Dim myEntObj As Entity : Dim myEntObjId As ObjectId
            Dim LayMan As LayoutManager = LayoutManager.Current
            Dim lOut As Layout = trans.GetObject(lDicdEnt.Value, OpenMode.ForRead)
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
                                            Try ' could get from db
                                                If Att.Tag = "REV1" Then Att.TextString = ""
                                                If Att.Tag = "REV2" Then Att.TextString = ""
                                                If Att.Tag = "REV3" Then Att.TextString = ""
                                                If Att.Tag = "REV4" Then Att.TextString = ""
                                                If Att.Tag = "REV5" Then Att.TextString = ""
                                                If Att.Tag = "REV6" Then Att.TextString = ""
                                            Catch ex As Exception
                                                MessageBox.Show(ex.ToString)
                                            End Try
                                        Next
                                End Select
                            End If
                        Next
                    Case Else
                End Select
            Next
        End Sub

        Private Sub clrCurDocRevAtts(ByVal Doc As Autodesk.AutoCAD.ApplicationServices.Document, ByVal trans As Transaction)
            Dim myEntObj As Entity : Dim myEntObjId As ObjectId
            Dim LayMan As LayoutManager = LayoutManager.Current
            Dim lOut As Layout = trans.GetObject(LayMan.GetLayoutId(LayMan.CurrentLayout), OpenMode.ForRead)

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
                                            Try ' could get from db
                                                If Att.Tag = "REV1" Then Att.TextString = ""
                                                If Att.Tag = "REV2" Then Att.TextString = ""
                                                If Att.Tag = "REV3" Then Att.TextString = ""
                                                If Att.Tag = "REV4" Then Att.TextString = ""
                                                If Att.Tag = "REV5" Then Att.TextString = ""
                                                If Att.Tag = "REV6" Then Att.TextString = ""
                                            Catch ex As Exception
                                                MessageBox.Show(ex.ToString)
                                            End Try
                                        Next
                                End Select
                            End If
                        Next
                    Case Else
                End Select
            Next
        End Sub

        Private Sub btnAddNextRev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNextRev.Click
            AddNextRev()
        End Sub

        Public Sub AddNextRev()
            Dim Doc As Autodesk.AutoCAD.ApplicationServices.Document = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument
            Dim db As Database = HostApplicationServices.WorkingDatabase
            db = Doc.Database : splitFName(Doc)
            Dim lDic As Autodesk.AutoCAD.DatabaseServices.DBDictionary
            Dim lDicdEnt As System.Collections.DictionaryEntry
            Dim trans As Transaction = db.TransactionManager.StartTransaction()
            Dim docLock As DocumentLock = Doc.LockDocument()
            Try : lDic = trans.GetObject(db.LayoutDictionaryId, OpenMode.ForRead)
                If chkbxJustCurLayout.Checked Then
                    ClrRevsLst()
                    getputCurLayoutAtts(Doc, trans) ' does the cur layout 
                Else
                    For Each lDicdEnt In lDic
                        ClrRevsLst()
                        getputCurDocAtts(Doc, trans, lDicdEnt) ' does all the layouts
                    Next
                End If
                trans.Commit()
            Finally
                docLock.Dispose() : trans.Dispose()
            End Try
            ' If chkbxCloseFile.Checked = True Then Doc.CloseAndDiscard()
            ' dgBldLst.DataSource = cloneTable
        End Sub

        Private Sub chkbxUseLetters_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkbxUseLetters.CheckedChanged
            MessageBox.Show(" Make Fuction for Letters ?")
        End Sub

    End Class

End Namespace