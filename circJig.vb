
Imports System
Imports Autodesk.AutoCAD.Runtime
Imports Autodesk.AutoCAD.EditorInput
Imports Autodesk.AutoCAD.Geometry
Imports Autodesk.AutoCAD.DatabaseServices
Imports Autodesk.AutoCAD.GraphicsInterface
Imports Autodesk.AutoCAD.ApplicationServices

Namespace circJig

    ' bug in AquireAngle function - can't use it refers to distance

    Public Class JigExample
        Inherits DrawJig

        Private previousCursorPosition As Point3d
        Private currentCursorPosition As Point3d
        Private entityToDrag As Entity

        '<CommandMethod("StartJig")> _
        Public Sub StartJig()
            previousCursorPosition = New Point3d(0, 0, 0)
            entityToDrag = New Circle(New Point3d(0, 0, 0), New Vector3d(0, 0, 1), 6)
            Application.DocumentManager.MdiActiveDocument.Editor.Drag(Me)
        End Sub

        Public Function StartJig(ByVal arcEnt As Entity)
            previousCursorPosition = New Point3d(0, 0, 0)
            'pass my arc entiy?
            entityToDrag = arcEnt
            Application.DocumentManager.MdiActiveDocument.Editor.Drag(Me)
        End Function

        'You must override this method
        Protected Overrides Function Sampler(ByVal prompts As JigPrompts) As SamplerStatus
            'Get the current cursor position
            Dim userFeedback As PromptPointResult = prompts.AcquirePoint
            currentCursorPosition = userFeedback.Value
            If CursorHasMoved() Then
                'Get the vector of the move
                Dim displacementVector As Vector3d = currentCursorPosition.GetVectorTo(previousCursorPosition)
                'Transform the circle to the new location
                entityToDrag.TransformBy(Matrix3d.Displacement(displacementVector))
                'Save the cursor position
                previousCursorPosition = currentCursorPosition
                Return SamplerStatus.OK
            Else
                Return SamplerStatus.NoChange
            End If
        End Function

        'You must override this method
        Protected Overrides Function WorldDraw(ByVal draw As WorldDraw) As Boolean
            draw.Geometry.Draw(entityToDrag)
            Return True
        End Function

        Private Function CursorHasMoved() As Boolean
            Return Not (currentCursorPosition.ToString = previousCursorPosition.ToString)
        End Function

    End Class

End Namespace



