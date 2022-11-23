Option Explicit On 

Imports System.IO
Imports System.windows.Forms

Imports Autodesk.AutoCAD.EditorInput
Imports Autodesk.AutoCAD.DatabaseServices
Imports Autodesk.AutoCAD.ApplicationServices

Imports rnsCadDataProj.nsForms

Namespace nsMods

    Module modUtility

        Public chdlg As New frmClassofChange

        Public Sub FileNametoAtt(ByVal fullName As Boolean, ByVal addLayout As Boolean)
            Dim db As Database = HostApplicationServices.WorkingDatabase
            Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
            Dim trans As Transaction = db.TransactionManager.StartTransaction()
            Dim DocCol As DocumentCollection = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager
            Dim docLock As DocumentLock = DocCol.MdiActiveDocument.LockDocument()
            Try
                Dim prEnt As PromptNestedEntityOptions = New PromptNestedEntityOptions("Select the Attribute in Current VPort ...")
                Dim prEntRes As PromptEntityResult = ed.GetNestedEntity(prEnt)
                ' If prEntRes.Status <> PromptStatus.OK Then
                ' frm.Show()
                ' Return
                ' End If
                Dim fnStr As String

                If fullName = False Then
                    Dim str As String = Path.GetFileNameWithoutExtension(ed.Document.Name)
                    If addLayout = True Then
                        Dim oLayoutManager As LayoutManager = LayoutManager.Current
                        Dim cLout As String = oLayoutManager.CurrentLayout
                        fnStr = str & "-" & cLout
                    Else
                        fnStr = str
                    End If
                Else
                    If addLayout = True Then
                        Dim str As String = Path.GetFileNameWithoutExtension(ed.Document.Name)
                        Dim oLayoutManager As LayoutManager = LayoutManager.Current
                        Dim cLout As String = oLayoutManager.CurrentLayout
                        fnStr = str & "-" & cLout
                    Else
                        Dim str As String = Path.GetFileNameWithoutExtension(ed.Document.Name)
                        fnStr = str
                    End If
                    If addLayout = True Then
                        Dim oLayoutManager As LayoutManager = LayoutManager.Current
                        Dim cLout As String = oLayoutManager.CurrentLayout
                        fnStr = ed.Document.Name & "-" & cLout
                    Else
                        fnStr = ed.Document.Name
                    End If
                End If
                Dim ent As Entity = trans.GetObject(prEntRes.ObjectId, OpenMode.ForRead)
                If TypeOf ent Is AttributeReference Then
                    Dim att As AttributeReference = trans.GetObject(prEntRes.ObjectId, OpenMode.ForWrite)
                    att.TextString = fnStr
                    trans.Commit()
                End If
                If TypeOf ent Is MText Then
                    Dim att As MText = trans.GetObject(prEntRes.ObjectId, OpenMode.ForWrite)
                    att.Contents = fnStr
                    trans.Commit()
                End If
                'If TypeOf ent Is DBText Then
                '    Dim att As DBText = trans.GetObject(prEntRes.ObjectId, OpenMode.ForWrite)
                '    att.TextString = fnStr
                '    trans.Commit()
                'End If
            Finally
                docLock.Dispose() : trans.Dispose() ': Me.Show()
            End Try
        End Sub

        Public Sub DateToAtt(ByVal NumElsTxt As Boolean)
            Dim db As Database = HostApplicationServices.WorkingDatabase
            Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
            Dim trans As Transaction = db.TransactionManager.StartTransaction()
            Dim DocCol As DocumentCollection = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager
            Dim docLock As DocumentLock = DocCol.MdiActiveDocument.LockDocument()
            Try
                Dim prEnt As PromptNestedEntityOptions = New PromptNestedEntityOptions("Select the Attribute ...")
                Dim prEntRes As PromptEntityResult = ed.GetNestedEntity(prEnt)
                'If prEntRes.Status <> PromptStatus.OK Then
                'frm.Show()
                'Return
                'End If
                Dim NewDate As String
                If NumElsTxt Then
                    NewDate = Format(Now, "dd/MM/yy").ToString
                Else
                    NewDate = UCase(Format(Now, "dd/MMM/yy").ToString)
                End If

                Dim ent As Entity = trans.GetObject(prEntRes.ObjectId, OpenMode.ForRead)
             
                If TypeOf ent Is AttributeReference Then
                    Dim att As AttributeReference = trans.GetObject(prEntRes.ObjectId, OpenMode.ForWrite)
                    att.TextString = NewDate
                    trans.Commit()
                End If
                If TypeOf ent Is MText Then
                    Dim att As MText = trans.GetObject(prEntRes.ObjectId, OpenMode.ForWrite)
                    att.Contents = NewDate
                    trans.Commit()
                End If
                'If TypeOf ent Is DBText Then
                '    Dim att As DBText = trans.GetObject(prEntRes.ObjectId, OpenMode.ForWrite)
                '    att.TextString = NewDate
                '    trans.Commit()
                'End If

            Finally
                docLock.Dispose() : trans.Dispose() ': Me.Show()
            End Try
        End Sub

        Public Class myReverserClass
            Implements IComparer

            ' Calls CaseInsensitiveComparer.Compare with the parameters reversed.
            Function Compare(ByVal x As [Object], ByVal y As [Object]) As Integer _
               Implements IComparer.Compare
                Return New CaseInsensitiveComparer().Compare(y, x)
            End Function 'IComparer.Compare

        End Class 'myReverserClass

        Private Sub processResponse(ByVal response As System.Windows.Forms.DialogResult, ByVal dbcx As DBConcurrencyException, ByVal dtMod As System.Data.DataTable, ByVal rowInDB As DataRow)
            Select Case response
                Case System.Windows.Forms.DialogResult.Yes
                    Select Case dtMod.TableName
                        Case "E044ReleasedDocuments"
                            ' UpdateRow(dtMod, dbcx.Row.Item("DocumentNumberID"))
                            Dim file As New System.IO.StreamReader("C:\DataLinks" & "\DBTest.txt")
                            Dim words As String = file.ReadToEnd() : file.Close()
                            SqlDaComp.SqlConn.ConnectionString = words
                            Dim clnTbl As System.Data.DataTable = SqlDaComp.DataSet11.E044ReleasedDocuments.Clone()
                            SqlDaComp.DaE044RelDocs.Fill(clnTbl)
                            Dim AddResponse As MsgBoxResult ': Dim UpdateResponse As MsgBoxResult
                            Dim fStr As String ': Dim str As String
                            Dim foundRows() As DataRowView
                            fStr = dbcx.Row.Item(5) 'check this the id
                            'Dim MyNewRow As DataRow : Dim MyRow As DataRowView : Dim c As Integer : Dim Cc As Integer
                            Dim E024ItmMstrDV As DataView = New DataView(clnTbl, "", _
                                                                    "DocumentNumberID", _
                                                             DataViewRowState.CurrentRows) '"EngineeringPartNumber, EngineeringRevisionCode",
                            Try : foundRows = E024ItmMstrDV.FindRows(New Object() {fStr}) '{fStr, rStr}
                                If foundRows.Length = 0 Then
                                    AddResponse = MessageBox.Show("No match found. Press Ok To Add To Item Master")
                                ElseIf foundRows.Length = 1 Then
                                    'Copy the new data from the database to the DataRow
                                    Dim dc As System.Data.DataColumn
                                    For Each dc In SqlDaComp.DataSet11.E044ReleasedDocuments.Columns
                                        If dc.ReadOnly = False Then _
                                        rowInDB.Item(dc.ColumnName) = foundRows(0)(dc.ColumnName)
                                    Next
                                    rowInDB.AcceptChanges()
                                    'update the database from dataset
                                    SqlDaComp.DaE024ItmMstr.Update(SqlDaComp.DataSet11.E024ItemMasterInput)
                                    clnTbl = Nothing
                                End If
                            Catch ex As Exception : MessageBox.Show(ex.ToString)
                            End Try

                        Case "E025BillofMaterialInputSubTable"
                        Case "E024ItemMasterInput"
                        Case "E025BillofMaterialInput"
                        Case "E037EngineeringChange"
                        Case "E046CopyRequest"
                        Case "E046SubTable"
                        Case "E044DocumentReleaseNotice"
                        Case "TrackingBlockNames"
                    End Select
                Case System.Windows.Forms.DialogResult.No
                    ' Cancel proposed changes and refresh DsAuthors1.
                    ' DsAuthors1.Merge(DsAuthors2)
                    'DataSet14.Merge(rowInDB(0))
            End Select
        End Sub

        Public Sub createMessage(ByVal dbcx As DBConcurrencyException, ByVal dtMod As System.Data.DataTable)
            ' Declare variables to hold the row versions for display 
            ' in the message box.
            Dim strInDs As String = "Original record in: " & dtMod.TableName _
               & ControlChars.CrLf
            Dim strInDB As String = "Current record in database:" _
               & ControlChars.CrLf
            Dim strProposed As String = "Proposed change:" & ControlChars.CrLf
            Dim strPromptText As String = "Do you want to overwrite the current record in the database with the proposed change?" & ControlChars.CrLf
            Dim strMessage As String
            Dim response As System.Windows.Forms.DialogResult
            ' Locate the current record in the data source that caused the exception
            '  Dim rowInDB As DataRow
            Select Case dtMod.TableName
                Case "E044ReleasedDocuments"

                    'THIS IS ACTUALLY THE DATASET RECORD
                    'get from database instead

                    'rowInDB = SqlDaComp.DataSet11.E044ReleasedDocuments.FindByDocumentNumberID(CType(dbcx.Row("DocumentNumberID"), String))

                Case "E025BillofMaterialInputSubTable"
                    '  rowInDB = daComp.DataSet11.E025BillofMaterialInputSubTable.FindByItemNumber _
                    '                                           (CType(dbcx.Row("ItemNumber"), String))
                Case "E024ItemMasterInput"
                    ' rowInDB = daComp.DataSet11.E024ItemMasterInput.FindByItemMasterInputNumber _
                    '                              (CType(dbcx.Row("ItemMasterInputNumber"), String))
                Case "E025BillofMaterialInput"
                    '  rowInDB = daComp.DataSet11.E025BillofMaterialInput.FindByBillofMaterialInputNumber _
                    '                                   (CType(dbcx.Row("BillofMaterialInputNumber"), String))
                Case "E037EngineeringChange"
                    ' rowInDB = daComp.DataSet11.E037EngineeringChange.FindByEngineeringChangeNumber _
                    '                                (CType(dbcx.Row("EngineeringChangeNumber"), String))
                Case "E046CopyRequest"
                    ' rowInDB = daComp.DataSet11.E046CopyRequest.FindByCopyRequestNumber _
                    '                         (CType(dbcx.Row("CopyRequestNumber"), String))
                Case "E046SubTable"
                    ' rowInDB = daComp.DataSet11.E046SubTable.FindByDocumentNumberID _
                    '                       (CType(dbcx.Row("DocumentNumberID"), String))
                Case "E044DocumentReleaseNotice"
                    ' rowInDB = daComp.DataSet11.E044DocumentReleaseNotice.FindByDocumentReleaseNoticeNumberID _
                    '                                    (CType(dbcx.Row("DocumentReleaseNoticeNumberID"), String))
                Case "TrackingBlockNames"
                    ' rowInDB = daComp.DataSet11.TrackingBlockNames.FindByBlockID _
                    '                            (CType(dbcx.Row("BlockID"), String))

                Case Else : MessageBox.Show("Add to the Case List :   " & dtMod.TableName)
            End Select
            ' Loop through the column values.  
            Dim i As Integer
            For i = 0 To dbcx.Row.ItemArray.Length - 1
                strInDs &= dbcx.Row(i, DataRowVersion.Original) & _
                   ControlChars.Tab
                ' strInDB &= rowInDB(i, DataRowVersion.Current) & ControlChars.Tab
                strProposed &= dbcx.Row(i, DataRowVersion.Current) & _
                   ControlChars.Tab
            Next
            ' Create the message box text string.
            strMessage = strInDs & ControlChars.CrLf
            strMessage &= strInDB & ControlChars.CrLf
            strMessage &= strProposed & ControlChars.CrLf
            strMessage &= strPromptText
            ' Display the message box.
            response = MessageBox.Show(strMessage, "Update Failed", _
               MessageBoxButtons.YesNo)
            ' processResponse(response, dbcx, dtMod, rowInDB)
        End Sub

        Public Sub HlpDwg(ByVal HelpFileName As String, ByVal cLayout As String, ByVal rOnly As Boolean)
            Dim Doc As Autodesk.AutoCAD.ApplicationServices.Document
            Dim db As Database = HostApplicationServices.WorkingDatabase
            Dim trans As Transaction = db.TransactionManager.StartTransaction()
            Doc = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.Open(HelpFileName, rOnly)
            Dim docLock As DocumentLock = Doc.LockDocument()
            Try : Dim LayMan As LayoutManager = LayoutManager.Current
                LayMan.CurrentLayout = cLayout
            Finally : docLock.Dispose() : trans.Dispose() ': Me.Hide()
            End Try
        End Sub

        Public Function CurSpace() As String
            Dim DB As Database = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Database
            Dim TM As Autodesk.AutoCAD.DatabaseServices.TransactionManager = DB.TransactionManager
            Dim CT As Transaction = TM.StartTransaction
            Try
                Dim BT As BlockTable = CT.GetObject(DB.BlockTableId, OpenMode.ForRead)
                Dim CurrentSpace As BlockTableRecord = CT.GetObject(DB.CurrentSpaceId, OpenMode.ForRead)
                CurSpace = CurrentSpace.Name
            Finally
                CT.Dispose()
            End Try
        End Function

        Public splitStrAry As String() = Nothing

        Public Function splitFName(ByVal OpenFileName As String) As String()
            Dim delimStr As String = "\"
            Dim delimiter As Char() = delimStr.ToCharArray()
            Dim words As String = ""
            splitStrAry = OpenFileName.Split(delimiter)
            Return splitStrAry
        End Function

        Public Function splitFName(ByVal doc As Document) As String()
            Dim delimStr As String = "\"
            Dim delimiter As Char() = delimStr.ToCharArray()
            Dim words As String = ""
            splitStrAry = doc.Name.Split(delimiter)
            Return splitStrAry
        End Function


    End Module
End Namespace
