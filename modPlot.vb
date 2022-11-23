Option Explicit On 

Imports System
Imports System.IO
Imports System.Text
Imports System.Windows.Forms
Imports System.Collections

Imports Autodesk.AutoCAD.Runtime
Imports Autodesk.AutoCAD.GraphicsInterface
Imports Autodesk.AutoCAD.Windows
Imports Autodesk.AutoCAD.EditorInput
Imports Autodesk.AutoCAD.ApplicationServices
Imports Autodesk.AutoCAD.DatabaseServices
Imports Autodesk.AutoCAD.PlottingServices
Imports Autodesk.AutoCAD.Geometry
Imports Autodesk.AutoCAD.Publishing
Imports Autodesk.AutoCAD.Interop
Imports Autodesk.AutoCAD.Interop.Common

Namespace nsMods
    Module modPlot

        Public Sub pltCurrLayout(ByVal PltScale As StdScaleType, ByVal fade255 As Boolean)

            Dim doc As Document = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument
            Dim oLayMan As LayoutManager = LayoutManager.Current
            Dim cLoutName As String = oLayMan.CurrentLayout
            Dim cLoutID As ObjectId = oLayMan.GetLayoutId(cLoutName)
            Dim db As Database = HostApplicationServices.WorkingDatabase
            Dim trans As Transaction = db.TransactionManager.StartTransaction()
            Dim lOut As Layout = trans.GetObject(cLoutID, OpenMode.ForWrite)
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
            pltSet.CopyFrom(lOut)

            Dim pltInfo As PlotInfo = New PlotInfo
            Dim pltPgInfo As PlotPageInfo = New PlotPageInfo
            Dim pltEngine As PlotEngine = PlotFactory.CreatePublishEngine()
            ' Dim pltPgrs As Autodesk.AutoCAD.PlottingServices.PlotProgress
            Dim pltDialog As PlotProgressDialog = New PlotProgressDialog(False, 1, False)
            Dim piValidator As PlotInfoValidator = New PlotInfoValidator
            Dim psValidator As PlotSettingsValidator = PlotSettingsValidator.Current()

            Try
                pltDialog.PlotProgressPos = 0
                pltDialog.OnBeginPlot()
                pltDialog.IsVisible = True

                pltInfo.Layout = cLoutID

                pltSet.ShadePlot = PlotSettingsShadePlotType.AsDisplayed

                Dim cmnl As System.Collections.Specialized.StringCollection
                cmnl = psValidator.GetPlotStyleSheetList()
                ' Dim stnm As String
                ' For Each stnm In cmnl
                'MessageBox.Show(stnm)
                'Next

                Dim scss As String = ""

                If fade255 = True Then
                    scss = "monochrome_Xrefs.ctb"
                Else
                    scss = "monochrome_0500mm.ctb"
                End If

                psValidator.SetCurrentStyleSheet(pltSet, scss)  ' find type first stb or ctb

                psValidator.SetPlotConfigurationName(pltSet, "LSCAHP5100.pc3", "11x17")

                psValidator.SetPlotType(pltSet, Autodesk.AutoCAD.DatabaseServices.PlotType.Extents)
                psValidator.SetPlotCentered(pltSet, True)
                psValidator.SetStdScaleType(pltSet, PltScale)
                ' psValidator.SetPlotOrigin(pltSet, New Point2d(0.0, 0.0))
                psValidator.SetPlotRotation(pltSet, PlotRotation.Degrees090)

                pltInfo.OverrideSettings = pltSet
                piValidator.Validate(pltInfo)

                pltEngine.BeginPlot(pltDialog, Nothing)
                pltEngine.BeginDocument(pltInfo, doc.Name, Nothing, 1, False, Nothing)
                'pltEngine.BeginDocument(pltInfo, doc.Name, Nothing, 1, True, "C:\Gary\Cad Files Test\Test.dwf")

                pltDialog.OnBeginSheet()
                pltDialog.PlotProgressPos = 0
                pltEngine.BeginPage(pltPgInfo, pltInfo, True, Nothing)
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

        End Sub ' works

        Public Sub pltCurrLayoutDWF3(ByVal PltScale As StdScaleType, ByVal fade255 As Boolean)

            Dim doc As Document = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument
            Dim oLayMan As LayoutManager = LayoutManager.Current
            Dim cLoutName As String = oLayMan.CurrentLayout
            Dim cLoutID As ObjectId = oLayMan.GetLayoutId(cLoutName)
            Dim db As Database = HostApplicationServices.WorkingDatabase
            Dim trans As Transaction = db.TransactionManager.StartTransaction()
            Dim lOut As Layout = trans.GetObject(cLoutID, OpenMode.ForWrite)

            Dim dwfName As String = doc.Name

            Dim pth As String = Path.GetDirectoryName(dwfName)

            dwfName = Path.GetFileNameWithoutExtension(dwfName)


            dwfName = pth & dwfName & "-" & lOut.LayoutName & ".dwf"

            '''''''''''''''''''
            Dim mdltype As Boolean : Dim cSpace As String = modUtility.CurSpace
            Select Case cSpace
                Case "*Model_Space" : mdltype = True
                Case "*MODEL_SPACE" : mdltype = True
                Case "*Paper_Space" : mdltype = False
                Case "*PAPER_SPACE" : mdltype = False
            End Select

            ' MessageBox.Show("Starting Plot")
            Dim ConfigInfoName As String = ""
            Dim inf As Autodesk.AutoCAD.PlottingServices.PlotConfigInfo
            For Each inf In Autodesk.AutoCAD.PlottingServices.PlotConfigManager.Devices
                If inf.DeviceName.Equals("DWF6 ePlot.pc3") Then
                    ' MessageBox.Show("found the right device")
                    ConfigInfoName = inf.DeviceName
                    Exit For
                End If
            Next
            Dim pConfig As Autodesk.AutoCAD.PlottingServices.PlotConfig = Autodesk.AutoCAD.PlottingServices.PlotConfigManager.SetCurrentConfig(ConfigInfoName)

            Dim pInfo As Autodesk.AutoCAD.PlottingServices.PlotInfo = New Autodesk.AutoCAD.PlottingServices.PlotInfo
            Dim lMan As Autodesk.AutoCAD.DatabaseServices.LayoutManager = Autodesk.AutoCAD.DatabaseServices.LayoutManager.Current
            pInfo.Layout = lMan.GetLayoutId(lMan.CurrentLayout)
            pInfo.DeviceOverride = pConfig

            Dim pSettings As Autodesk.AutoCAD.DatabaseServices.PlotSettings = New Autodesk.AutoCAD.DatabaseServices.PlotSettings(mdltype)

            Dim pSValidator As Autodesk.AutoCAD.DatabaseServices.PlotSettingsValidator = Autodesk.AutoCAD.DatabaseServices.PlotSettingsValidator.Current

            Dim scss As String = ""

            If fade255 = True Then
                scss = "monochrome_Xrefs.ctb"
            Else
                scss = "monochrome_0500mm.ctb"
            End If


            pSValidator.SetCurrentStyleSheet(pSettings, scss)
            pSValidator.SetPlotConfigurationName(pSettings, "Microsoft Office Document Image Writer", "Tabloid")
            pSValidator.SetPlotType(pSettings, Autodesk.AutoCAD.DatabaseServices.PlotType.Extents)
            pSValidator.SetPlotCentered(pSettings, True)
            pSValidator.SetStdScaleType(pSettings, PltScale)

            pInfo.OverrideSettings = pSettings

            Dim validator As Autodesk.AutoCAD.PlottingServices.PlotInfoValidator = New Autodesk.AutoCAD.PlottingServices.PlotInfoValidator
            validator.MediaMatchingPolicy = Autodesk.AutoCAD.PlottingServices.MatchingPolicy.MatchEnabled
            validator.Validate(pInfo)

            Dim pProgDialog As Autodesk.AutoCAD.PlottingServices.PlotProgressDialog = New Autodesk.AutoCAD.PlottingServices.PlotProgressDialog(False, 1, True)

            pProgDialog.PlotMsgString(PlotMessageIndex.DialogTitle) = "Plotting..."
            pProgDialog.PlotMsgString(PlotMessageIndex.CancelJobButtonMessage) = "Cancel Plot"
            pProgDialog.PlotMsgString(PlotMessageIndex.CancelSheetButtonMessage) = "Cancel Sheet"
            pProgDialog.PlotMsgString(PlotMessageIndex.SheetSetProgressCaption) = "Plot Progress"
            pProgDialog.PlotMsgString(PlotMessageIndex.SheetProgressCaption) = "Sheet Progress"

            pProgDialog.LowerPlotProgressRange = 0
            pProgDialog.UpperPlotProgressRange = 100
            'pProgDialog.OnBeginPlot();
            pProgDialog.IsVisible = True
            Dim pPInfo As Autodesk.AutoCAD.PlottingServices.PlotPageInfo = New Autodesk.AutoCAD.PlottingServices.PlotPageInfo

            Dim parms As Object = Nothing
            Dim pEngine As Autodesk.AutoCAD.PlottingServices.PlotEngine = Nothing
            Try
                pEngine = Autodesk.AutoCAD.PlottingServices.PlotFactory.CreatePublishEngine()

                pEngine.BeginPlot(pProgDialog, parms)
                pEngine.BeginDocument(pInfo, doc.Name, parms, 1, True, dwfName)

                pEngine.BeginPage(pPInfo, pInfo, True, parms)
                pEngine.BeginGenerateGraphics(parms)
                pEngine.EndGenerateGraphics(parms)
                pEngine.EndPage(parms)

                pEngine.EndDocument(parms)


                pEngine.EndPlot(parms)
            Catch ex As Autodesk.AutoCAD.Runtime.Exception
                MessageBox.Show(ex.ToString)
            Finally
                pEngine.Destroy()
                pEngine = Nothing
                pProgDialog.Destroy()
                pSettings.Dispose()
                trans.Dispose()

            End Try


        End Sub ' WORKS


        Public Sub CurLayoutDwf2()

            Dim doc As Document = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument
            Dim oLayMan As LayoutManager = LayoutManager.Current
            Dim cLoutName As String = oLayMan.CurrentLayout
            Dim cLoutID As ObjectId = oLayMan.GetLayoutId(cLoutName)
            Dim db As Database = HostApplicationServices.WorkingDatabase
            Dim trans As Transaction = db.TransactionManager.StartTransaction()
            Dim lOut As Layout = trans.GetObject(cLoutID, OpenMode.ForWrite)

            Dim dwfName As String = doc.Name
            dwfName = dwfName.Replace(".dwg", "") : dwfName = dwfName.Replace(".DWG", "") ' Should upper case this and then strip it
            dwfName = dwfName & "-" & lOut.LayoutName & ".dwf"

            '  Dim objAutoCADApp = New AcadApplicationClass


            Dim objAutoCADApp As Autodesk.AutoCAD.Interop.AcadApplication = GetObject(, "AutoCAD.Application")
            'System.Runtime.InteropServices.Marshal.GetActiveObject("AutoCAD.Application")

            'Dim actLayout As acadlayout
            Dim objAutoCADDoc As Autodesk.AutoCAD.Interop.AcadDocument = objAutoCADApp.ActiveDocument

            objAutoCADDoc.PaperSpace.Layout.PlotType = AcPlotType.acExtents
            objAutoCADDoc.PaperSpace.Layout.StandardScale = AcPlotScale.acScaleToFit
            objAutoCADDoc.PaperSpace.Layout.CenterPlot = True
            objAutoCADDoc.PaperSpace.Layout.ConfigName = "DWF6 ePlot.pc3"
            objAutoCADDoc.Plot.PlotToFile(dwfName)

            objAutoCADDoc.Close()


        End Sub ' does not work ????????

        Public Sub MkDWF(ByVal doc As Document, ByVal dwfName As String)

            '''''''''''''''''''
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

            'MessageBox.Show("Starting Plot")
            Dim ConfigInfoName As String = ""
            Dim inf As Autodesk.AutoCAD.PlottingServices.PlotConfigInfo
            For Each inf In Autodesk.AutoCAD.PlottingServices.PlotConfigManager.Devices
                If inf.DeviceName.Equals("DWF6 ePlot.pc3") Then
                    ' MessageBox.Show("found the right device")
                    ConfigInfoName = inf.DeviceName
                    Exit For
                End If
            Next

            Dim pConfig As Autodesk.AutoCAD.PlottingServices.PlotConfig = Autodesk.AutoCAD.PlottingServices.PlotConfigManager.SetCurrentConfig(ConfigInfoName)

            Dim pInfo As Autodesk.AutoCAD.PlottingServices.PlotInfo = New Autodesk.AutoCAD.PlottingServices.PlotInfo
            Dim lMan As Autodesk.AutoCAD.DatabaseServices.LayoutManager = Autodesk.AutoCAD.DatabaseServices.LayoutManager.Current
            pInfo.Layout = lMan.GetLayoutId(lMan.CurrentLayout)
            pInfo.DeviceOverride = pConfig

            Dim pSettings As Autodesk.AutoCAD.DatabaseServices.PlotSettings = New Autodesk.AutoCAD.DatabaseServices.PlotSettings(mdltype)
            Dim pSValidator As Autodesk.AutoCAD.DatabaseServices.PlotSettingsValidator = Autodesk.AutoCAD.DatabaseServices.PlotSettingsValidator.Current

            Dim validator As Autodesk.AutoCAD.PlottingServices.PlotInfoValidator = New Autodesk.AutoCAD.PlottingServices.PlotInfoValidator

            validator.MediaMatchingPolicy = Autodesk.AutoCAD.PlottingServices.MatchingPolicy.MatchEnabled

            ''''''''''''
            Dim cmnl As System.Collections.Specialized.StringCollection
            cmnl = pSValidator.GetPlotStyleSheetList()
            ' Dim stnm As String
            ' For Each stnm In cmnl
            'MessageBox.Show(stnm)
            'Next

            Dim scss As String = "monochrome.ctb"
            pSValidator.SetCurrentStyleSheet(pSettings, scss)  ' find type first stb or ctb

            Try
                pSValidator.SetPlotConfigurationName(pSettings, "DWF6 ePlot.pc3", "ANSI expand B (11.00 x 17.00 Inches)")
            Catch ex As System.Exception
                MessageBox.Show(ex.ToString)
            End Try


            pSValidator.SetPlotType(pSettings, Autodesk.AutoCAD.DatabaseServices.PlotType.Extents)
            pSValidator.SetPlotCentered(pSettings, True)
            pSValidator.SetStdScaleType(pSettings, StdScaleType.StdScale1To1)
            'psValidator.SetPlotOrigin(pltSet, New Point2d(0.0, 0.0))
            pSValidator.SetPlotRotation(pSettings, PlotRotation.Degrees090)

            pInfo.OverrideSettings = pSettings

            '''''''''''''''
            validator.Validate(pInfo) ' this works on test1 only ?????
            Dim pProgDialog As Autodesk.AutoCAD.PlottingServices.PlotProgressDialog = New Autodesk.AutoCAD.PlottingServices.PlotProgressDialog(False, 1, True)

            pProgDialog.PlotMsgString(PlotMessageIndex.DialogTitle) = "Plotting..."
            pProgDialog.PlotMsgString(PlotMessageIndex.CancelJobButtonMessage) = "Cancel Plot"
            pProgDialog.PlotMsgString(PlotMessageIndex.CancelSheetButtonMessage) = "Cancel Sheet"
            pProgDialog.PlotMsgString(PlotMessageIndex.SheetSetProgressCaption) = "Plot Progress"
            pProgDialog.PlotMsgString(PlotMessageIndex.SheetProgressCaption) = "Sheet Progress"

            pProgDialog.LowerPlotProgressRange = 0
            pProgDialog.UpperPlotProgressRange = 100
            'pProgDialog.OnBeginPlot();
            pProgDialog.IsVisible = True
            Dim pPInfo As Autodesk.AutoCAD.PlottingServices.PlotPageInfo = New Autodesk.AutoCAD.PlottingServices.PlotPageInfo

            Dim parms As Object = Nothing
            Dim pEngine As Autodesk.AutoCAD.PlottingServices.PlotEngine = Autodesk.AutoCAD.PlottingServices.PlotFactory.CreatePublishEngine()
            pEngine.BeginPlot(pProgDialog, parms)

            pEngine.BeginDocument(pInfo, doc.Name, parms, 1, True, dwfName)

            pEngine.BeginPage(pPInfo, pInfo, True, parms)
            pEngine.BeginGenerateGraphics(parms)
            pEngine.EndGenerateGraphics(parms)
            pEngine.EndPage(parms)
            pEngine.EndDocument(parms)
            pEngine.EndPlot(parms)
            pEngine.Destroy()
            pEngine = Nothing
            pProgDialog.Destroy()


        End Sub ' WORKS WITH ERROR

        Public Sub MkDWF()

            '''''''''''''''''''
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

            'MessageBox.Show("Starting Plot")
            Dim ConfigInfoName As String = ""
            Dim inf As Autodesk.AutoCAD.PlottingServices.PlotConfigInfo
            For Each inf In Autodesk.AutoCAD.PlottingServices.PlotConfigManager.Devices
                If inf.DeviceName.Equals("DWF6 ePlot.pc3") Then
                    ' MessageBox.Show("found the right device")
                    ConfigInfoName = inf.DeviceName
                    Exit For
                End If
            Next

            Dim pConfig As Autodesk.AutoCAD.PlottingServices.PlotConfig = Autodesk.AutoCAD.PlottingServices.PlotConfigManager.SetCurrentConfig(ConfigInfoName)

            Dim pInfo As Autodesk.AutoCAD.PlottingServices.PlotInfo = New Autodesk.AutoCAD.PlottingServices.PlotInfo
            Dim lMan As Autodesk.AutoCAD.DatabaseServices.LayoutManager = Autodesk.AutoCAD.DatabaseServices.LayoutManager.Current
            pInfo.Layout = lMan.GetLayoutId(lMan.CurrentLayout)
            pInfo.DeviceOverride = pConfig

            Dim pSettings As Autodesk.AutoCAD.DatabaseServices.PlotSettings = New Autodesk.AutoCAD.DatabaseServices.PlotSettings(mdltype)
            Dim pSValidator As Autodesk.AutoCAD.DatabaseServices.PlotSettingsValidator = Autodesk.AutoCAD.DatabaseServices.PlotSettingsValidator.Current

            Dim validator As Autodesk.AutoCAD.PlottingServices.PlotInfoValidator = New Autodesk.AutoCAD.PlottingServices.PlotInfoValidator

            validator.MediaMatchingPolicy = Autodesk.AutoCAD.PlottingServices.MatchingPolicy.MatchEnabled

            validator.Validate(pInfo) ' still will not validate a tab that has not been setup ????

            Dim pProgDialog As Autodesk.AutoCAD.PlottingServices.PlotProgressDialog = New Autodesk.AutoCAD.PlottingServices.PlotProgressDialog(False, 1, True)

            pProgDialog.PlotMsgString(PlotMessageIndex.DialogTitle) = "Plotting..."
            pProgDialog.PlotMsgString(PlotMessageIndex.CancelJobButtonMessage) = "Cancel Plot"
            pProgDialog.PlotMsgString(PlotMessageIndex.CancelSheetButtonMessage) = "Cancel Sheet"
            pProgDialog.PlotMsgString(PlotMessageIndex.SheetSetProgressCaption) = "Plot Progress"
            pProgDialog.PlotMsgString(PlotMessageIndex.SheetProgressCaption) = "Sheet Progress"

            pProgDialog.LowerPlotProgressRange = 0
            pProgDialog.UpperPlotProgressRange = 100
            'pProgDialog.OnBeginPlot();
            pProgDialog.IsVisible = True
            Dim pPInfo As Autodesk.AutoCAD.PlottingServices.PlotPageInfo = New Autodesk.AutoCAD.PlottingServices.PlotPageInfo

            Dim parms As Object = Nothing
            Dim pEngine As Autodesk.AutoCAD.PlottingServices.PlotEngine = Autodesk.AutoCAD.PlottingServices.PlotFactory.CreatePublishEngine()
            pEngine.BeginPlot(pProgDialog, parms)

            pEngine.BeginDocument(pInfo, "C:\Gary\Cad Files\Test1.dwg", parms, 1, True, "C:\Gary\Cad Files\Test1.dwf")

            pEngine.BeginPage(pPInfo, pInfo, True, parms)
            pEngine.BeginGenerateGraphics(parms)
            pEngine.EndGenerateGraphics(parms)
            pEngine.EndPage(parms)
            pEngine.EndDocument(parms)
            pEngine.EndPlot(parms)
            pEngine.Destroy()
            pEngine = Nothing
            pProgDialog.Destroy()


        End Sub ' does not work ????????

        Public Sub pltCurrLayoutDWF2()

            Dim doc As Document = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument
            Dim oLayMan As LayoutManager = LayoutManager.Current
            Dim cLoutName As String = oLayMan.CurrentLayout
            Dim cLoutID As ObjectId = oLayMan.GetLayoutId(cLoutName)
            Dim db As Database = HostApplicationServices.WorkingDatabase
            Dim trans As Transaction = db.TransactionManager.StartTransaction()
            Dim lOut As Layout = trans.GetObject(cLoutID, OpenMode.ForWrite)
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
            pltSet.CopyFrom(lOut)

            Dim pltInfo As PlotInfo = New PlotInfo
            Dim pltPgInfo As PlotPageInfo = New PlotPageInfo
            Dim pltEngine As PlotEngine = PlotFactory.CreatePublishEngine()
            ' Dim pltPgrs As Autodesk.AutoCAD.PlottingServices.PlotProgress
            Dim pltDialog As PlotProgressDialog = New PlotProgressDialog(False, 1, False)
            Dim piValidator As PlotInfoValidator = New PlotInfoValidator
            'validator.MediaMatchingPolicy = Autodesk.AutoCAD.PlottingServices.MatchingPolicy.MatchEnabled
            Dim psValidator As PlotSettingsValidator = PlotSettingsValidator.Current()

            Try
                pltDialog.PlotProgressPos = 0
                pltDialog.OnBeginPlot()
                pltDialog.IsVisible = True

                pltInfo.Layout = cLoutID

                Dim pltStlShtLst As System.Collections.Specialized.StringCollection
                pltStlShtLst = psValidator.GetPlotStyleSheetList()
                ' Dim stnm As String
                ' For Each stnm In cmnl
                'MessageBox.Show(stnm)
                'Next

                Dim scss As String = "monochrome.ctb"
                psValidator.SetCurrentStyleSheet(pltSet, scss)  ' find type first stb or ctb

                'psValidator.SetPlotConfigurationName(pltSet, "LSCAHP5100.pc3", "11x17")
                psValidator.SetPlotConfigurationName(pltSet, "DWF6 ePlot.pc3", "ANSI expand A (8.50 x 11.00 Inches)")

                psValidator.SetPlotType(pltSet, Autodesk.AutoCAD.DatabaseServices.PlotType.Extents)
                psValidator.SetPlotCentered(pltSet, True)
                psValidator.SetStdScaleType(pltSet, StdScaleType.StdScale1To1)
                ' psValidator.SetPlotOrigin(pltSet, New Point2d(0.0, 0.0))
                psValidator.SetPlotRotation(pltSet, PlotRotation.Degrees090)

                pltInfo.OverrideSettings = pltSet
                piValidator.Validate(pltInfo)

                pltEngine.BeginPlot(pltDialog, Nothing)
                'pltEngine.BeginDocument(pltInfo, doc.Name, Nothing, 1, False, Nothing)
                pltEngine.BeginDocument(pltInfo, "C:\Gary\Cad Files\Test1.dwg", Nothing, 1, True, "C:\Gary\Cad Files\Test1.dwf")


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

        End Sub ' does not work ????????

        Public Sub pltCurrLayout_Orig()

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
            'Dim pltPgrs As Autodesk.AutoCAD.PlottingServices.PlotProgress
            Dim pltDialog As PlotProgressDialog = New PlotProgressDialog(False, 1, False)
            Dim piValidator As PlotInfoValidator = New PlotInfoValidator
            'validator.MediaMatchingPolicy = Autodesk.AutoCAD.PlottingServices.MatchingPolicy.MatchEnabled
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

        End Sub

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
            'Dim pltPgrs As Autodesk.AutoCAD.PlottingServices.PlotProgress
            Dim pltDialog As PlotProgressDialog = New PlotProgressDialog(False, 1, False)
            Dim piValidator As PlotInfoValidator = New PlotInfoValidator
            'validator.MediaMatchingPolicy = Autodesk.AutoCAD.PlottingServices.MatchingPolicy.MatchEnabled
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

        Public Sub pltCurrLayout(ByVal pltSetName As String, ByVal pltStylTbl As String, ByVal pltScale As String, ByVal pltMediaName As String, ByVal isCen As String)

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
            'Dim pltPgrs As Autodesk.AutoCAD.PlottingServices.PlotProgress
            Dim pltDialog As PlotProgressDialog = New PlotProgressDialog(False, 1, False)
            Dim piValidator As PlotInfoValidator = New PlotInfoValidator
            'validator.MediaMatchingPolicy = Autodesk.AutoCAD.PlottingServices.MatchingPolicy.MatchEnabled
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

        End Sub

    End Module

End Namespace

