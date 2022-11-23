Option Explicit On 

Imports System.windows.Forms
Imports Autodesk.AutoCAD.DatabaseServices
Imports Autodesk.AutoCAD.ApplicationServices

Imports rnsCadDataProj.nsCDPUtility
Imports rnsCadDataProj.nsForms

Imports rnsCadDataProj.nsMods

Namespace nsCDPUtility

    Module modUtility

        Public drnID As String : Public crnID As String : Public ecoID As String : Public bomID As String

        Public rOnly As Boolean = False
        Public pathStr As String = "C:\Documents and Settings\gdw\Desktop\Cad 2006 Netload\Engineering Procedures Handbook\"

        Public FolderName As String : Public OpenFileName As String : Public OpenFileNames As String()

        Public chdlg As New ClassofChangeFrm
        Public cloneTable As System.data.DataTable


        Private Sub processResponse(ByVal response As System.Windows.Forms.DialogResult, ByVal dbcx As DBConcurrencyException, ByVal dtMod As System.Data.DataTable, ByVal rowInDB As DataRow)



            Select Case response
                Case System.Windows.Forms.DialogResult.Yes
                    Select Case dtMod.TableName

                        Case "E044ReleasedDocuments"

                            ' UpdateRow(dtMod, dbcx.Row.Item("DocumentNumberID"))


                            Dim file As New System.IO.StreamReader("C:\DataLinks" & "\DBTest.txt")
                            Dim words As String = file.ReadToEnd() : file.Close()
                            daComp.dbconnE044DRN.ConnectionString = words

                            Dim clnTbl As System.Data.DataTable = daComp.DataSet11.E044ReleasedDocuments.Clone()
                            daComp.daE044ReleasedDocuments.Fill(clnTbl)

                            Dim AddResponse As MsgBoxResult : Dim UpdateResponse As MsgBoxResult
                            Dim fStr As String ': Dim str As String
                            Dim foundRows() As DataRowView

                            fStr = dbcx.Row.Item(5) 'check this the id

                            Dim MyNewRow As DataRow : Dim MyRow As DataRowView : Dim c As Integer : Dim Cc As Integer

                            Dim E024ItmMstrDV As DataView = New DataView(clnTbl, "", _
                                                                    "DocumentNumberID", _
                                                             DataViewRowState.CurrentRows) '"EngineeringPartNumber, EngineeringRevisionCode",

                            Try : foundRows = E024ItmMstrDV.FindRows(New Object() {fStr}) '{fStr, rStr}
                                If foundRows.Length = 0 Then
                                    AddResponse = MessageBox.Show("No match found. Press Ok To Add To Item Master", MsgBoxStyle.OKCancel)
                                ElseIf foundRows.Length = 1 Then

                                    'Copy the new data from the database to the DataRow

                                    Dim dc As System.Data.DataColumn

                                    For Each dc In daComp.DataSet11.E044ReleasedDocuments.Columns
                                        If dc.ReadOnly = False Then _
                                        rowInDB.Item(dc.ColumnName) = foundRows(0)(dc.ColumnName)
                                    Next

                                    rowInDB.AcceptChanges()

                                    'update the database from dataset
                                    daComp.daE024ItemMasterInput.Update(daComp.DataSet11.E024ItemMasterInput)


                                    clnTbl = Nothing


                                End If

                            Catch ex As Exception

                                MessageBox.Show(ex.ToString)

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
            Dim rowInDB As DataRow
            Select Case dtMod.TableName
                Case "E044ReleasedDocuments"

                    'THIS IS ACTUALLY THE DATASET RECORD
                    'get from database instead

                    rowInDB = daComp.DataSet11.E044ReleasedDocuments.FindByDocumentNumberID(CType(dbcx.Row("DocumentNumberID"), String))

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
                strInDB &= rowInDB(i, DataRowVersion.Current) & ControlChars.Tab
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
            processResponse(response, dbcx, dtMod, rowInDB)
        End Sub












        Public Function Dec2Frac(ByVal f As Double) As String
            Dim df As Double
            Dim lUpperPart As Long
            Dim lLowerPart As Long
            lUpperPart = 1
            lLowerPart = 1
            df = lUpperPart / lLowerPart
            While (df <> f)
                If (df < f) Then
                    lUpperPart = lUpperPart + 1
                Else
                    lLowerPart = lLowerPart + 1
                    lUpperPart = f * lLowerPart
                End If
                df = lUpperPart / lLowerPart
            End While
            Dec2Frac = CStr(lUpperPart) & "/" & CStr(lLowerPart)
            Dim ift As Integer : Dim iInch As Integer : Dim dFrac As Double
            ift = Fix((lUpperPart / 12) / lLowerPart)
            iInch = Fix(df Mod (12 / lLowerPart) * lLowerPart)
            dFrac = df Mod (1 / lLowerPart) * lLowerPart
            Dec2Frac = ift & "'" & iInch & "-" & modUtility.DecimalToMixed2(dFrac.ToString) & """ "
        End Function

        'Code to convert decimal numbers to mixed numbers, and vice versa.
        'DecimalToMixedNumber: Convert a number like "3.8 nto "3 4/5"
        'SimplifyFraction: Convert a fraction like "50/100" into "1/2"
        'FractionToDecimal: Converts a fraction like "22/4" into "5 1/2".

        Function DecimalToMixed2(ByVal Number As String) As String
            Dim perPos As Long, wholepart As String, fracpart As String

            perPos = InStr(1, Number, ".")
            wholepart = Mid(Number, 1, perPos - 1)
            fracpart = Mid(Number, perPos + 1)

            If wholepart = 0 Then
                DecimalToMixed2 = SimplifyFraction(fracpart & "/" & CStr(10 ^ (Len(fracpart))))
            Else
                DecimalToMixed2 = wholepart & " " & SimplifyFraction(fracpart & "/" & CStr(10 ^ (Len(fracpart))))
            End If

        End Function
        Function DecimalToMixed(ByVal Number As String) As String
            Dim perPos As Long, wholepart As String, fracpart As String

            perPos = InStr(1, Number, ".")
            wholepart = Mid(Number, 1, perPos - 1)
            fracpart = Mid(Number, perPos + 1)

            DecimalToMixed = wholepart & " " & SimplifyFraction(fracpart & "/" & CStr(10 ^ (Len(fracpart))))
        End Function
        Function SimplifyFraction(ByVal Fraction As String) As String
            Dim divPos As Long, numerator As Long, denominator As Long
            Dim tmp As Long, lCounter1 As Long
            divPos = InStr(1, Fraction, "/")

            numerator = Mid(Fraction, 1, divPos - 1)
            denominator = Mid(Fraction, divPos + 1)


            If numerator > denominator Then tmp = denominator Else tmp = numerator

            For lCounter1 = tmp To 2 Step -1
                If ((numerator Mod lCounter1 = 0) And (denominator Mod lCounter1 = 0)) Then
                    numerator = numerator \ lCounter1
                    denominator = denominator \ lCounter1
                End If
            Next lCounter1

            SimplifyFraction = CStr(numerator) & "/" & CStr(denominator)
        End Function

        Function FractionToDecimal(ByVal Fraction As String) As String
            Dim divPos As Long, numerator As Long, denominator As Long

            divPos = InStr(1, Fraction, "/")
            numerator = Mid(Fraction, 1, divPos - 1)
            denominator = Mid(Fraction, divPos + 1)

            FractionToDecimal = numerator / denominator
        End Function





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
        End Function

        Public Function splitFName(ByVal doc As Document) As String()
            Dim delimStr As String = "\"
            Dim delimiter As Char() = delimStr.ToCharArray()
            Dim words As String = ""
            splitStrAry = doc.Name.Split(delimiter)
        End Function


    End Module
End Namespace
