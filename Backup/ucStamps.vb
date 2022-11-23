Option Explicit On 

Imports System.IO
Imports System.Drawing
Imports System.Windows.Forms

Imports Autodesk.AutoCAD.EditorInput
Imports Autodesk.AutoCAD.ApplicationServices
Imports Autodesk.AutoCAD.DatabaseServices
Imports Autodesk.AutoCAD.Geometry

Imports rnsCadDataProj.nsMods
Imports rnsCadDataProj.nsForms

Namespace nsUserCtls

    Public Class ucStamps

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
        Friend WithEvents btnGetStamp As System.Windows.Forms.Button
        Friend WithEvents btnInsPickStamp As System.Windows.Forms.Button
        Friend WithEvents btnModelInsStamp00 As System.Windows.Forms.Button
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.btnInsPickStamp = New System.Windows.Forms.Button
            Me.btnModelInsStamp00 = New System.Windows.Forms.Button
            Me.btnGetStamp = New System.Windows.Forms.Button
            Me.SuspendLayout()
            '
            'btnInsPickStamp
            '
            Me.btnInsPickStamp.Location = New System.Drawing.Point(24, 40)
            Me.btnInsPickStamp.Name = "btnInsPickStamp"
            Me.btnInsPickStamp.Size = New System.Drawing.Size(72, 32)
            Me.btnInsPickStamp.TabIndex = 0
            Me.btnInsPickStamp.Text = "Ins Pick Stamp"
            '
            'btnModelInsStamp00
            '
            Me.btnModelInsStamp00.Location = New System.Drawing.Point(24, 72)
            Me.btnModelInsStamp00.Name = "btnModelInsStamp00"
            Me.btnModelInsStamp00.Size = New System.Drawing.Size(72, 32)
            Me.btnModelInsStamp00.TabIndex = 1
            Me.btnModelInsStamp00.Text = "Model Ins Stamp 0,0"
            '
            'btnGetStamp
            '
            Me.btnGetStamp.Location = New System.Drawing.Point(24, 136)
            Me.btnGetStamp.Name = "btnGetStamp"
            Me.btnGetStamp.Size = New System.Drawing.Size(104, 23)
            Me.btnGetStamp.TabIndex = 2
            Me.btnGetStamp.Text = "btnGetStamp"
            '
            'ucStamps
            '
            Me.Controls.Add(Me.btnGetStamp)
            Me.Controls.Add(Me.btnModelInsStamp00)
            Me.Controls.Add(Me.btnInsPickStamp)
            Me.Name = "ucStamps"
            Me.Size = New System.Drawing.Size(560, 232)
            Me.ResumeLayout(False)

        End Sub

#End Region



        Private Sub btnInsPickStampOrig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles btnInsPickStamp.Click

            Dim tbl As New Table
            Dim bt As BlockTable
            Dim btr As BlockTableRecord
            Dim db As Database = HostApplicationServices.WorkingDatabase
            Dim trans As Transaction
            trans = db.TransactionManager.StartTransaction()

            Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
            Dim frm As Form = Me.FindForm()
            frm.Hide()
            Dim tblPnt As PromptPointOptions = New PromptPointOptions("Select Insertion Point...")
            Dim tblPntRes As PromptPointResult = ed.GetPoint(tblPnt)
            If tblPntRes.Status <> PromptStatus.OK Then
                frm.Show()
                Return
            End If

            Dim DocCol As DocumentCollection = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager
            Dim docLock As DocumentLock = DocCol.MdiActiveDocument.LockDocument()

            Dim fname As String = "C:\Gary\Cad Files\Stamp.dwg"
            If Not File.Exists(fname) Then
                fname = HostApplicationServices.Current.FindFile(fname, DocCol.MdiActiveDocument.Database, FindFileHint.Default)
            End If
            Dim ndb As Database = New Database(False, False)

            ndb.ReadDwgFile(fname, FileShare.Read, True, Nothing)
            Dim idBTR As ObjectId = DocCol.MdiActiveDocument.Database.Insert("Stamp", ndb, False)
            Dim bref As BlockReference = New BlockReference(tblPntRes.Value, idBTR)

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
            End Try
        End Sub

        Private Sub btnInsPickStamp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsPickStamp.Click
            Dim frm As Form = Me.FindForm()
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
            Dim fullName As String = "C:\Gary\CadFiles\Stamp.dwg"
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
            Dim theScale As Scale3d = New Scale3d(0.5, 0.5, 0.5) '(cbxScale.SelectedItem, cbxScale.SelectedItem, cbxScale.SelectedItem)
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

        ' <CommandMethod("testinsert")> _
        Public Shared Sub DoIt()
            Dim doc As Document = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument
            Dim docLock As DocumentLock = doc.LockDocument()
            Dim fname As String = "C:\Gary\Cad Files\Stamp.dwg"
            If Not File.Exists(fname) Then
                fname = HostApplicationServices.Current.FindFile(fname, doc.Database, FindFileHint.Default)
            End If
            Dim db As Database = New Database(False, False)
            Try
                db.ReadDwgFile(fname, FileShare.Read, True, Nothing)
                ' Using 
                Dim t As Transaction = doc.TransactionManager.StartTransaction
                Try
                    Dim idBTR As ObjectId = doc.Database.Insert("Stamp", db, False)
                    Dim bt As BlockTable = CType(t.GetObject(doc.Database.BlockTableId, OpenMode.ForRead), BlockTable)
                    Dim btr As BlockTableRecord = CType(t.GetObject(bt(BlockTableRecord.ModelSpace), OpenMode.ForWrite), BlockTableRecord)
                    ' Using 
                    Dim bref As BlockReference = New BlockReference(Point3d.Origin, idBTR)
                    Try
                        btr.AppendEntity(bref)
                        t.AddNewlyCreatedDBObject(bref, True)
                    Finally
                        CType(bref, IDisposable).Dispose()
                    End Try
                    t.Commit()
                Finally
                    CType(t, IDisposable).Dispose()
                End Try
            Finally
                docLock.Dispose()
                CType(db, IDisposable).Dispose()
            End Try
        End Sub

        Private Sub btnModelInsStamp00_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModelInsStamp00.Click
            DoIt()
        End Sub

        Private Sub btnGetStamp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetStamp.Click
            MessageBox.Show("Not Made Yet")
        End Sub
    End Class

End Namespace