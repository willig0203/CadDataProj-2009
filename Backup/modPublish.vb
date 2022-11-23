Option Explicit On 

Imports System
Imports System.IO
Imports System.Text
Imports System.Windows.Forms
Imports System.Collections
Imports System.Diagnostics

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

    Module modPublish

#Region "NewPublish"

        ''''''''''''''''''''''''''''''' new code

        '<Assembly: ExtensionApplication(Type.GetType(NET.MyApp))> 

        'Namespace nsModNewPublish
        Public Class CLASS3
            'Implements IExtensionApplication
            Public Shared m_PublishEvents As PublishEvents = Nothing
            Public Sub Terminate()
                If Not m_PublishEvents Is Nothing Then
                    'm_PublishEvents.Undo();
                    m_PublishEvents = Nothing
                End If
            End Sub
            Public Sub Initialize()
                m_PublishEvents = New PublishEvents
            End Sub
        End Class

        Public Class PublishEvents
            Private Shared m_pb As Publisher = Nothing
            Private m_bDone As Boolean
            Public Sub New()
                m_bDone = False
                m_pb = Autodesk.AutoCAD.ApplicationServices.Application.Publisher
                DoMe()
            End Sub
            Public Sub DoMe()
                ' Only plant it once.
                If m_bDone = False Then
                    m_bDone = True
                Else
                    Return
                End If

                Try
                    m_pb = Autodesk.AutoCAD.ApplicationServices.Application.Publisher
                    AddHandler m_pb.AboutToBeginBackgroundPublishing, New AboutToBeginBackgroundPublishingEventHandler(AddressOf callback_AboutToBeginBackgroundPublishingEventHandler)

                    AddHandler m_pb.AboutToBeginPublishing, New AboutToBeginPublishingEventHandler(AddressOf callback_AboutToBeginPublishingEventHandler)
                    AddHandler m_pb.AboutToEndPublishing, New AboutToEndPublishingEventHandler(AddressOf callback_AboutToEndPublishingEventHandler)
                    AddHandler m_pb.AboutToMoveFile, New AboutToMoveFileEventHandler(AddressOf callback_AboutToMoveFileHandler)
                    AddHandler m_pb.BeginAggregation, New BeginAggregationEventHandler(AddressOf callback_BeginAggregationEventHandler)
                    AddHandler m_pb.BeginEntity, New BeginEntityEventHandler(AddressOf callback_BeginEntityEventHandler)
                    AddHandler m_pb.BeginPublishingSheet, New BeginPublishingSheetEventHandler(AddressOf callback_BeginPublishingSheetEventHandler)
                    AddHandler m_pb.BeginSheet, New BeginSheetEventHandler(AddressOf callback_BeginSheetEventHandler)
                    AddHandler m_pb.CancelledOrFailedPublishing, New CancelledOrFailedPublishingEventHandler(AddressOf callback_CancelledOrFailedPublishingEventHandler)

                    AddHandler m_pb.EndEntity, New EndEntityEventHandler(AddressOf callback_EndEntityEventHandler)
                    AddHandler m_pb.EndPublish, New EndPublishEventHandler(AddressOf callback_EndPublishEventHandler)
                    AddHandler m_pb.EndSheet, New EndSheetEventHandler(AddressOf callback_EndSheetEventHandler)
                    'AddHandler m_pb.InitPublishOptionsDialog, new InitPublishOptionsDialogEventHandler (AddressOf callback_InitPublishOptionsDialogEventHandler);
                Catch ex As System.Exception
                    MyPrint(String.Format("\terror = {0}", ex.Message))
                End Try
            End Sub
            Public Sub Undo()
                If m_pb Is Nothing Or m_bDone = False Then
                    Return
                End If

                Try
                    RemoveHandler m_pb.AboutToBeginBackgroundPublishing, New AboutToBeginBackgroundPublishingEventHandler(AddressOf callback_AboutToBeginBackgroundPublishingEventHandler)

                    RemoveHandler m_pb.AboutToBeginPublishing, New AboutToBeginPublishingEventHandler(AddressOf callback_AboutToBeginPublishingEventHandler)
                    RemoveHandler m_pb.AboutToEndPublishing, New AboutToEndPublishingEventHandler(AddressOf callback_AboutToEndPublishingEventHandler)
                    RemoveHandler m_pb.AboutToMoveFile, New AboutToMoveFileEventHandler(AddressOf callback_AboutToMoveFileHandler)
                    RemoveHandler m_pb.BeginAggregation, New BeginAggregationEventHandler(AddressOf callback_BeginAggregationEventHandler)
                    RemoveHandler m_pb.BeginEntity, New BeginEntityEventHandler(AddressOf callback_BeginEntityEventHandler)
                    RemoveHandler m_pb.BeginPublishingSheet, New BeginPublishingSheetEventHandler(AddressOf callback_BeginPublishingSheetEventHandler)
                    RemoveHandler m_pb.BeginSheet, New BeginSheetEventHandler(AddressOf callback_BeginSheetEventHandler)
                    RemoveHandler m_pb.CancelledOrFailedPublishing, New CancelledOrFailedPublishingEventHandler(AddressOf callback_CancelledOrFailedPublishingEventHandler)

                    RemoveHandler m_pb.EndEntity, New EndEntityEventHandler(AddressOf callback_EndEntityEventHandler)
                    RemoveHandler m_pb.EndPublish, New EndPublishEventHandler(AddressOf callback_EndPublishEventHandler)
                    RemoveHandler m_pb.EndSheet, New EndSheetEventHandler(AddressOf callback_EndSheetEventHandler)
                    ' RemoveHandler m_pb.InitPublishOptionsDialog , new InitPublishOptionsDialogEventHandler (AddressOf callback_InitPublishOptionsDialogEventHandler);

                    m_pb = Nothing
                Catch ex As System.Exception
                    MyPrint(String.Format("\terror = {0}", ex.Message))
                End Try

                m_bDone = False
            End Sub

            Private Sub callback_AboutToBeginBackgroundPublishingEventHandler(ByVal sender As Object, ByVal e As AboutToBeginBackgroundPublishingEventArgs)
                MyPrint("AboutToBeginBackgroundPublishingEventHandler")
                Dim dsdData As Autodesk.AutoCAD.PlottingServices.DsdData = e.DsdData ' e.get_DsdData
                MyPrint(String.Format("\tPlotStampOn = {0}", dsdData.PlotStampOn))
            End Sub

            Private Sub callback_AboutToBeginPublishingEventHandler(ByVal sender As Object, ByVal e As AboutToBeginPublishingEventArgs)
                MyPrint("AboutToBeginPublishingEventHandler")
                MyPrint(String.Format("\tget_JobWillPublishInBackground = {0}", e.JobWillPublishInBackground))
                Dim dsdData As Autodesk.AutoCAD.PlottingServices.DsdData = e.DsdData
                MyPrint(String.Format("\tPlotStampOn = {0}", dsdData.PlotStampOn))
            End Sub

            Private Sub callback_AboutToEndPublishingEventHandler(ByVal sender As Object, ByVal e As PublishEventArgs)
                MyPrint("AboutToEndPublishingEventHandler")
                MyPrint(String.Format("\tget_DwfFileName = {0}", e.DwfFileName))
                MyPrint(String.Format("\tget_IsMultiSheetDwf = {0}", e.IsMultiSheetDwf))
                MyPrint(String.Format("\tget_TemporaryDwfFileName = {0}", e.TemporaryDwfFileName))
            End Sub

            Private Sub callback_AboutToMoveFileHandler(ByVal sender As Object, ByVal e As PublishEventArgs)
                MyPrint("AboutToMoveFileHandler")
                MyPrint(String.Format("\tget_DwfFileName = {0}", e.DwfFileName))
                MyPrint(String.Format("\tget_IsMultiSheetDwf = {0}", e.IsMultiSheetDwf))
                MyPrint(String.Format("\tget_TemporaryDwfFileName = {0}", e.TemporaryDwfFileName))
            End Sub

            Private Sub callback_BeginAggregationEventHandler(ByVal sender As Object, ByVal e As BeginAggregationEventArgs)
                MyPrint("BeginAggregationEventHandler")
                e.PlotLogger.LogMessage("From my BeginAggregationEventHandler EVENT!!")
            End Sub
            Private Sub callback_BeginEntityEventHandler(ByVal sender As Object, ByVal e As PublishEntityEventArgs)
                MyPrint("BeginEntityEventHandler")
                MyPrint(String.Format("\tget_UniqueEntityId() = {0}", e.UniqueEntityId))
            End Sub

            Private Sub callback_BeginPublishingSheetEventHandler(ByVal sender As Object, ByVal e As BeginPublishingSheetEventArgs)
                MyPrint("BeginPublishingSheetEventHandler")
                MyPrint(String.Format("\tDwgName = {0}", e.DsdEntry.DwgName))
                e.PlotLogger.LogMessage("From my BeginPublishingSheetEventHandler EVENT!!")
            End Sub

            Private Sub callback_BeginSheetEventHandler(ByVal sender As Object, ByVal e As PublishSheetEventArgs)
                MyPrint("BeginSheetEventHandler")
                MyPrint(String.Format("\tget_CanonicalMediaName = {0}", e.CanonicalMediaName))
                MyPrint(String.Format("\tget_Configuration = {0}", e.Configuration))
                MyPrint(String.Format("\tget_DrawingScale = {0}", e.DrawingScale.ToString()))
                MyPrint(String.Format("\tget_PlotLayoutId = {0}", e.PlotLayoutId.ToString()))
                e.PlotLogger.LogMessage("From my BeginSheetEventHandler EVENT!!")
            End Sub
            Private Sub callback_CancelledOrFailedPublishingEventHandler(ByVal sender As Object, ByVal e As PublishEventArgs)
                MyPrint("CancelledOrFailedPublishingEventHandler")
                MyPrint(String.Format("\tget_DwfFileName = {0}", e.DwfFileName))
                MyPrint(String.Format("\tget_IsMultiSheetDwf = {0}", e.IsMultiSheetDwf))
                MyPrint(String.Format("\tget_TemporaryDwfFileName = {0}", e.TemporaryDwfFileName))
            End Sub

            Private Sub callback_EndEntityEventHandler(ByVal sender As Object, ByVal e As PublishEntityEventArgs)
                MyPrint("EndEntityEventHandler")
                MyPrint(String.Format("\tget_UniqueEntityId() = {0}", e.UniqueEntityId))
            End Sub

            Private Sub callback_EndPublishEventHandler(ByVal sender As Object, ByVal e As PublishEventArgs)
                MyPrint("EndPublishEventHandler")
                MyPrint(String.Format("\tget_DwfFileName = {0}", e.DwfFileName))
                MyPrint(String.Format("\tget_IsMultiSheetDwf = {0}", e.IsMultiSheetDwf))
                MyPrint(String.Format("\tget_TemporaryDwfFileName = {0}", e.TemporaryDwfFileName))
            End Sub

            Private Sub callback_EndSheetEventHandler(ByVal sender As Object, ByVal e As PublishSheetEventArgs)
                MyPrint("EndSheetEventHandler")
            End Sub

            Private Sub MyPrint(ByVal s As String)
                Dim strLogFileName As String = "c:\\test.log"
                Dim tw As System.IO.TextWriter = System.IO.File.AppendText(strLogFileName)
                tw.WriteLine(s)
                tw.Close()
            End Sub
        End Class
        '    End Namespace


#End Region



 

    End Module
End Namespace

