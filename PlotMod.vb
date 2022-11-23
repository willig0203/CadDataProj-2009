
Option Explicit On 

'Imports rnsCadDataProj.nsCDPUtility

Imports Autodesk.AutoCAD.EditorInput
Imports Autodesk.AutoCAD.ApplicationServices
Imports Autodesk.AutoCAD.DatabaseServices
Imports Autodesk.AutoCAD.PlottingServices

Namespace nsCDPUtility

    Module PlotMod

        Public Function pltCurrLayout(ByVal pltSetName As String, ByVal pltStylTbl As String, ByVal pltScale As String, ByVal pltMediaName As String, ByVal isCen As String)

            Dim psValidator As PlotSettingsValidator = PlotSettingsValidator.Current()
            Dim doc As Document = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument
            Dim oLayMan As LayoutManager = LayoutManager.Current
            Dim cLoutName As String = oLayMan.CurrentLayout
            Dim cLoutID As ObjectId = oLayMan.GetLayoutId(cLoutName)
            Dim db As Database = HostApplicationServices.WorkingDatabase
            Dim trans As Transaction = db.TransactionManager.StartTransaction()
            Dim lOut As Layout = trans.GetObject(cLoutID, OpenMode.ForRead)
            Dim mdltype As Boolean
            Dim cSpace As String = modUtility.CurSpace
            Select Case cSpace
                Case "*Model_Space"
                    mdltype = True
                Case "*MODEL_SPACE"
                    mdltype = True
                Case "*Paper_Space"
                    mdltype = False
                Case "*PAPER_SPACE"
                    mdltype = False
            End Select
           
            Dim pltSet As PlotSettings = New PlotSettings(mdltype)

            'psValidator.SetPlotConfigurationName(pltSet, pltSetName, pltMediaName) 'pmp
            pltSet.PlotSettingsName = pltSetName
            psValidator.SetCurrentStyleSheet(pltSet, pltStylTbl)
            psValidator.SetUseStandardScale(pltSet, True)
            If pltScale = "Scale1To1" Then psValidator.SetStdScale(pltSet, 1)

            'Try : psValidator.SetCanonicalMediaName(pltSet, pltMediaName)
            'Catch ex As Exception : MessageBox.Show(ex.ToString)
            'End Try

            'Try : psValidator.SetPlotCentered(pltSet, isCen) ' what the ?
            'Catch ex As Exception : MessageBox.Show(ex.ToString)
            'End Try


            Dim pltInfo As PlotInfo = New PlotInfo
            Dim pltPgInfo As PlotPageInfo = New PlotPageInfo
            Dim pltEngine As PlotEngine = PlotFactory.CreatePublishEngine()
            Dim pltPgrs As Autodesk.AutoCAD.PlottingServices.PlotProgress
            Dim pltDialog As PlotProgressDialog = New PlotProgressDialog(False, 1, False)
            Dim piValidator As PlotInfoValidator = New PlotInfoValidator
            Try
                pltDialog.PlotProgressPos = 0
                pltDialog.OnBeginPlot()
                pltDialog.IsVisible = True
                pltEngine.BeginPlot(pltDialog, Nothing)
                pltInfo.Layout = cLoutID
                pltInfo.OverrideSettings = pltSet
                piValidator.MediaMatchingPolicy = MatchingPolicy.MatchEnabled
                piValidator.Validate(pltInfo)
                pltEngine.BeginDocument(pltInfo, doc.Name, Nothing, 1, False, Nothing)
                pltDialog.OnBeginSheet()
                pltDialog.PlotProgressPos = 0
                pltEngine.BeginPage(pltPgInfo, pltInfo, True, Nothing)    ' tell it last page?
                pltEngine.BeginGenerateGraphics(Nothing)
                pltEngine.EndGenerateGraphics(Nothing)
                pltEngine.EndPage(Nothing)
                pltDialog.PlotProgressPos = 100
                pltDialog.OnEndSheet()
                pltDialog.PlotProgressPos = 100
                pltEngine.EndDocument(Nothing)
                pltDialog.OnEndPlot()  '?
                pltDialog.IsVisible = False
                pltEngine.EndPlot(Nothing)
            Finally
                pltEngine.Destroy()
                pltEngine = Nothing
                pltDialog.Destroy()
                pltSet.Dispose()
                trans.Dispose()
            End Try

        End Function

        Public Function pltCurrLayout()

            Dim psValidator As PlotSettingsValidator = PlotSettingsValidator.Current()
            Dim doc As Document = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument
            Dim oLayMan As LayoutManager = LayoutManager.Current
            Dim cLoutName As String = oLayMan.CurrentLayout
            Dim cLoutID As ObjectId = oLayMan.GetLayoutId(cLoutName)
            Dim db As Database = HostApplicationServices.WorkingDatabase
            Dim trans As Transaction = db.TransactionManager.StartTransaction()
            Dim lOut As Layout = trans.GetObject(cLoutID, OpenMode.ForRead)
            Dim mdltype As Boolean

            Dim cSpace As String = modUtility.CurSpace
            Select Case cSpace
                Case "*Model_Space"
                    mdltype = True
                Case "*MODEL_SPACE"
                    mdltype = True
                Case "*Paper_Space"
                    mdltype = False
                Case "*PAPER_SPACE"
                    mdltype = False
            End Select
            Dim pltSet As PlotSettings = New PlotSettings(mdltype)

            pltSet.CopyFrom(lOut) 'drawing must be set up to print
            'pltSet.PlotSettingsName = "eng_copier_q.pc3"
            'pltSet.CanonicalMediaName

            Dim pltInfo As PlotInfo = New PlotInfo
            Dim pltPgInfo As PlotPageInfo = New PlotPageInfo
            Dim pltEngine As PlotEngine = PlotFactory.CreatePublishEngine()
            Dim pltPgrs As Autodesk.AutoCAD.PlottingServices.PlotProgress
            Dim pltDialog As PlotProgressDialog = New PlotProgressDialog(False, 1, False)
            Dim piValidator As PlotInfoValidator = New PlotInfoValidator
            Try
                pltDialog.PlotProgressPos = 0
                pltDialog.OnBeginPlot()
                pltDialog.IsVisible = True
                pltEngine.BeginPlot(pltDialog, Nothing)
                pltInfo.Layout = cLoutID
                pltInfo.OverrideSettings = pltSet
                piValidator.MediaMatchingPolicy = MatchingPolicy.MatchEnabled
                piValidator.Validate(pltInfo)
                pltEngine.BeginDocument(pltInfo, doc.Name, Nothing, 1, False, Nothing)
                pltDialog.OnBeginSheet()
                pltDialog.PlotProgressPos = 0
                pltEngine.BeginPage(pltPgInfo, pltInfo, True, Nothing)    ' tell it last page?
                pltEngine.BeginGenerateGraphics(Nothing)
                pltEngine.EndGenerateGraphics(Nothing)
                pltEngine.EndPage(Nothing)
                pltDialog.PlotProgressPos = 100
                pltDialog.OnEndSheet()
                pltDialog.PlotProgressPos = 100
                pltEngine.EndDocument(Nothing)
                pltDialog.OnEndPlot()  '?
                pltDialog.IsVisible = False
                pltEngine.EndPlot(Nothing)
            Finally
                pltEngine.Destroy()
                pltEngine = Nothing
                pltDialog.Destroy()
                pltSet.Dispose()
                trans.Dispose()
            End Try

        End Function

        Public Sub PltCurrLayout(ByVal doc As Document, ByVal lOut As Layout) ', ByVal trans As Transaction
            Dim psValidator As PlotSettingsValidator = PlotSettingsValidator.Current()
            Dim mdltype As Boolean
            Dim cSpace As String = modUtility.CurSpace
            Select Case cSpace
                Case "*Model_Space"
                    mdltype = True
                Case "*MODEL_SPACE"
                    mdltype = True
                Case "*Paper_Space"
                    mdltype = False
                Case "*PAPER_SPACE"
                    mdltype = False
            End Select
            Dim pltSet As PlotSettings = New PlotSettings(mdltype)
            'MessageBox.Show(lOut.LayoutName)
            pltSet.CopyFrom(lOut)


            'MessageBox.Show(pltSet.PlotSettingsName & "  PlotSettingsName")
            'MessageBox.Show(pltSet.CurrentStyleSheet & "  CurrentStyleSheet")
            'MessageBox.Show(pltSet.PlotConfigurationName & "  PlotConfigurationName")
            'MessageBox.Show(pltSet.CanonicalMediaName & "  CanonicalMediaName")
            'MessageBox.Show(pltSet.PlotCentered & "  PlotCentered")
            'MessageBox.Show(pltSet.PlotRotation & "  PlotRotation")


            'pltSet.PlotSettingsName = "eng_copier_q.pc3"
            'pltSet.CanonicalMediaName

            Dim pltInfo As PlotInfo = New PlotInfo
            Dim pltPgInfo As PlotPageInfo = New PlotPageInfo
            Dim pltEngine As PlotEngine = PlotFactory.CreatePublishEngine()
            Dim pltPgrs As Autodesk.AutoCAD.PlottingServices.PlotProgress
            Dim pltDialog As PlotProgressDialog = New PlotProgressDialog(False, 1, False)
            Dim piValidator As PlotInfoValidator = New PlotInfoValidator
            Try
                pltDialog.PlotProgressPos = 0
                pltDialog.OnBeginPlot()
                pltDialog.IsVisible = True
                pltEngine.BeginPlot(pltDialog, Nothing)
                pltInfo.Layout = lOut.Id
                pltInfo.OverrideSettings = pltSet
                piValidator.MediaMatchingPolicy = MatchingPolicy.MatchEnabled
                piValidator.Validate(pltInfo) ' causes error 522
                pltEngine.BeginDocument(pltInfo, doc.Name, Nothing, 1, False, Nothing)
                pltDialog.OnBeginSheet()
                pltDialog.PlotProgressPos = 0
                pltEngine.BeginPage(pltPgInfo, pltInfo, True, Nothing)    ' tell it last page?
                pltEngine.BeginGenerateGraphics(Nothing)
                pltEngine.EndGenerateGraphics(Nothing)
                pltEngine.EndPage(Nothing)
                pltDialog.PlotProgressPos = 100
                pltDialog.OnEndSheet()
                pltDialog.PlotProgressPos = 100
                pltEngine.EndDocument(Nothing)
                pltDialog.OnEndPlot()  '?
                pltDialog.IsVisible = False
                pltEngine.EndPlot(Nothing)
            Finally
                pltEngine.Destroy()
                pltEngine = Nothing
                pltDialog.Destroy()
                pltSet.Dispose()
                'trans.Dispose()
            End Try
        End Sub


    End Module
End Namespace

