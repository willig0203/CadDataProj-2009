
Imports System
Imports System.Windows.Forms
Imports Autodesk.AutoCAD.DatabaseServices
Imports Autodesk.AutoCAD.Runtime
Imports Autodesk.AutoCAD.Geometry
Imports Autodesk.AutoCAD.EditorInput
Imports Autodesk.AutoCAD.ApplicationServices
Imports AcadApp = Autodesk.AutoCAD.ApplicationServices.Application
Imports System.Reflection



Namespace CaddZone


    Public Class InsertJig
        Inherits EntityJig

        Private position As Point3d

        Public Sub New(ByVal BlockId As ObjectId, ByVal Position As Point3d, ByVal Normal As Vector3d)
            MyBase.New(New BlockReference(Position, BlockId))
            BlockReference.Normal = Normal
            Position = Position
        End Sub

        Public ReadOnly Property BlockReference() As BlockReference
            Get
                Return CType(MyBase.Entity, BlockReference)
            End Get
        End Property

        Protected Overrides Function Sampler(ByVal prompts As JigPrompts) As SamplerStatus
            Dim jigOpts As JigPromptOptions = New JigPromptOptions
            jigOpts.UserInputControls = UserInputControls.Accept3dCoordinates
            jigOpts.Message = "" & vbLf & "Insertion point: "
            Dim res As PromptPointResult = prompts.AcquirePoint(jigOpts)
            Dim curPoint As Point3d = res.Value
            If (position.DistanceTo(curPoint) > 0.0001) Then
                position = curPoint
            Else
                Return SamplerStatus.NoChange
            End If
            If (res.Status = PromptStatus.Cancel) Then
                Return SamplerStatus.Cancel
            Else
                Return SamplerStatus.OK
            End If
        End Function

        Protected Overrides Function Update() As Boolean
            Try
                If (Me.BlockReference.Position.DistanceTo(position) > 0.0001) Then
                    Me.BlockReference.Position = position
                    Return True
                End If
            Catch ex As System.Exception

            End Try
            Return False
        End Function
    End Class

    ' Test InsertJig from command line
    Public Class Class1

        Private Sub New()
            MyBase.New()

        End Sub

        '<CommandMethod("DragInsertDemo")> _
        Public Shared Sub DragInsertDemo()
            Dim db As Database = AcadApp.DocumentManager.MdiActiveDocument.Database
            Dim ed As Editor = AcadApp.DocumentManager.MdiActiveDocument.Editor
            Dim Normal As Vector3d = db.Ucsxdir.CrossProduct(db.Ucsydir)
            Dim opts As PromptStringOptions = New PromptStringOptions("" & vbLf & "Block name: ")
            opts.AllowSpaces = True
            Dim docLock As DocumentLock = ed.Document.LockDocument

            Dim res As PromptResult = ed.GetString(opts)
            If ((res.Status = PromptStatus.OK) _
                        AndAlso (res.StringResult.Trim <> String.Empty)) Then
                Dim block As ObjectId = GetBlockId(db, res.StringResult)
                If block.IsNull Then
                    ed.WriteMessage("" & vbLf & "Block {0} not found.", res.StringResult)
                    Return
                End If
                Dim jig As InsertJig = New InsertJig(block, Point3d.Origin, Normal.GetNormal)
                res = ed.Drag(jig)
                If (res.Status = PromptStatus.OK) Then
                    'does not insert the block and causes some error
                    Dim tr As Transaction = db.TransactionManager.StartTransaction
                    Dim bt As BlockTable = CType(tr.GetObject(db.BlockTableId, OpenMode.ForRead, False), BlockTable)
                    Dim btr As BlockTableRecord = CType(tr.GetObject(bt(BlockTableRecord.ModelSpace), OpenMode.ForWrite, False), BlockTableRecord)
                    Try
                        btr.AppendEntity(jig.BlockReference)
                        tr.AddNewlyCreatedDBObject(jig.BlockReference, True)
                    Catch ex As Exception
                        MessageBox.Show(ex.ToString)
                    Finally
                        docLock.Dispose()
                        tr.Commit()
                    End Try

                End If
            End If
        End Sub

        Private Shared Function GetBlockId(ByVal db As Database, ByVal Name As String) As ObjectId
            Dim id As ObjectId = ObjectId.Null
            Dim tr As Transaction = db.TransactionManager.StartTransaction
            Dim blocks As BlockTable = CType(tr.GetObject(db.BlockTableId, OpenMode.ForRead), BlockTable)
            If blocks.Has(Name) Then
                id = blocks(Name)
                If id.IsErased Then
                    For Each btrId As ObjectId In blocks
                        If Not id.IsErased Then
                            Dim rec As BlockTableRecord = CType(tr.GetObject(btrId, OpenMode.ForRead), BlockTableRecord)
                            If (String.Compare(rec.Name, Name, True) = 0) Then
                                id = btrId
                                'TODO: Warning!!! break;If
                            End If
                        End If
                    Next
                End If
            End If
            Return id
        End Function
    End Class
End Namespace

