Option Explicit On 

Imports Aras.IOM

Imports System.IO
Imports System.Net
Imports System.Windows.Forms

Imports TRANSMITTALLib

Imports rnsCadDataProj.nsMods


Namespace nsUserCtls

    Public Class ucTransmit
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
        Public WithEvents File2 As Microsoft.VisualBasic.Compatibility.VB6.FileListBox
        Friend WithEvents chkbxAddCadFiles As System.Windows.Forms.CheckBox
        Friend WithEvents btnTransmit As System.Windows.Forms.Button
        Friend WithEvents btnRefreshFolder As System.Windows.Forms.Button
        Public WithEvents btnDelSelDwfs As System.Windows.Forms.Button
        Public WithEvents btnSendToOutlookDocs As System.Windows.Forms.Button
        Public WithEvents File3 As Microsoft.VisualBasic.Compatibility.VB6.FileListBox
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucTransmit))
            Me.btnRefreshFolder = New System.Windows.Forms.Button
            Me.File2 = New Microsoft.VisualBasic.Compatibility.VB6.FileListBox
            Me.btnDelSelDwfs = New System.Windows.Forms.Button
            Me.btnSendToOutlookDocs = New System.Windows.Forms.Button
            Me.chkbxAddCadFiles = New System.Windows.Forms.CheckBox
            Me.btnTransmit = New System.Windows.Forms.Button
            Me.File3 = New Microsoft.VisualBasic.Compatibility.VB6.FileListBox
            Me.SuspendLayout()
            '
            'btnRefreshFolder
            '
            Me.btnRefreshFolder.Location = New System.Drawing.Point(8, 8)
            Me.btnRefreshFolder.Name = "btnRefreshFolder"
            Me.btnRefreshFolder.Size = New System.Drawing.Size(88, 24)
            Me.btnRefreshFolder.TabIndex = 0
            Me.btnRefreshFolder.Text = "Refresh Folder"
            '
            'File2
            '
            Me.File2.BackColor = System.Drawing.SystemColors.Window
            Me.File2.Cursor = System.Windows.Forms.Cursors.Default
            Me.File2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.File2.ForeColor = System.Drawing.SystemColors.WindowText
            Me.File2.FormattingEnabled = True
            Me.File2.Location = New System.Drawing.Point(8, 80)
            Me.File2.Name = "File2"
            Me.File2.Pattern = "*.dwf"
            Me.File2.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
            Me.File2.Size = New System.Drawing.Size(240, 228)
            Me.File2.TabIndex = 80
            '
            'btnDelSelDwfs
            '
            Me.btnDelSelDwfs.BackColor = System.Drawing.SystemColors.Control
            Me.btnDelSelDwfs.Cursor = System.Windows.Forms.Cursors.Default
            Me.btnDelSelDwfs.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnDelSelDwfs.ForeColor = System.Drawing.SystemColors.ControlText
            Me.btnDelSelDwfs.Location = New System.Drawing.Point(8, 32)
            Me.btnDelSelDwfs.Name = "btnDelSelDwfs"
            Me.btnDelSelDwfs.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.btnDelSelDwfs.Size = New System.Drawing.Size(129, 24)
            Me.btnDelSelDwfs.TabIndex = 78
            Me.btnDelSelDwfs.Text = "Delete Selected Dwfs"
            Me.btnDelSelDwfs.UseVisualStyleBackColor = False
            '
            'btnSendToOutlookDocs
            '
            Me.btnSendToOutlookDocs.BackColor = System.Drawing.SystemColors.Control
            Me.btnSendToOutlookDocs.Cursor = System.Windows.Forms.Cursors.Default
            Me.btnSendToOutlookDocs.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSendToOutlookDocs.ForeColor = System.Drawing.SystemColors.ControlText
            Me.btnSendToOutlookDocs.Location = New System.Drawing.Point(96, 8)
            Me.btnSendToOutlookDocs.Name = "btnSendToOutlookDocs"
            Me.btnSendToOutlookDocs.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.btnSendToOutlookDocs.Size = New System.Drawing.Size(120, 24)
            Me.btnSendToOutlookDocs.TabIndex = 75
            Me.btnSendToOutlookDocs.Text = "SendToOutlookDocs"
            Me.btnSendToOutlookDocs.UseVisualStyleBackColor = False
            '
            'chkbxAddCadFiles
            '
            Me.chkbxAddCadFiles.Location = New System.Drawing.Point(96, 56)
            Me.chkbxAddCadFiles.Name = "chkbxAddCadFiles"
            Me.chkbxAddCadFiles.Size = New System.Drawing.Size(96, 24)
            Me.chkbxAddCadFiles.TabIndex = 85
            Me.chkbxAddCadFiles.Text = "Add Cad Files"
            '
            'btnTransmit
            '
            Me.btnTransmit.Location = New System.Drawing.Point(136, 32)
            Me.btnTransmit.Name = "btnTransmit"
            Me.btnTransmit.Size = New System.Drawing.Size(80, 24)
            Me.btnTransmit.TabIndex = 86
            Me.btnTransmit.Text = "Tramsmit"
            '
            'File3
            '
            Me.File3.BackColor = System.Drawing.SystemColors.Window
            Me.File3.Cursor = System.Windows.Forms.Cursors.Default
            Me.File3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.File3.ForeColor = System.Drawing.SystemColors.WindowText
            Me.File3.FormattingEnabled = True
            Me.File3.Location = New System.Drawing.Point(8, 320)
            Me.File3.Name = "File3"
            Me.File3.Pattern = "*.dwf"
            Me.File3.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
            Me.File3.Size = New System.Drawing.Size(240, 130)
            Me.File3.TabIndex = 87
          
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private Sub btnRefreshFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshFolder.Click
            File2.Path = FolderName : File2.Refresh()
            File3.Path = transmittalFldr : File3.Refresh()
        End Sub

        Private Sub btnDelSelDwfs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelSelDwfs.Click
            Dim mydwg As String ': Dim J As Short 
            Dim i As Short
            For i = 0 To File2.Items.Count - 1
                If File2.GetSelected(i) = True Then
                    mydwg = FolderName & "\" & File2.Items(i)
                    Kill(mydwg)
                End If
            Next i
            File2.Refresh()
        End Sub

        Private Sub btnSendToOutlookDocs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendToOutlookDocs.Click
            If Not dvE044DRN Is Nothing Then
                Dim email As Mail.MailMessage = Nothing
                '         email.To = "gary.williams@cambriausa.com"
                '          email.From = "gary.williams@cambriausa.com"
                'email.Body = "MessageText"
                '           email.Subject = "SubjectText"
                '       email.BodyFormat = Mail.MailFormat.Text

                mkDrnTransReport()
                Dim myAttachment As Mail.Attachment = New Mail.Attachment(transmittalFldr & "\Document List " & drnID & ".txt")
                email.Attachments.Add(myAttachment)
                email.Body = "See Document List " & drnID & ".txt"

                Dim J As Short : Dim mydwg As String
                For J = 0 To File2.Items.Count - 1
                    If File2.Items.Count > 0 Then
                        mydwg = File2.Path & "\" & File2.Items(J)
                        myAttachment = New Mail.Attachment(mydwg)
                        email.Attachments.Add(myAttachment)
                    End If
                Next

                '''''''
                'Dim row As System.Data.DataRow
                'Dim newRow As String = ""
                'Dim c As Integer
                'For c = 0 To (dvE044DRN.Count - 1)
                'row = dvE044DRN.Item(c).Row
                'newRow = newRow & row("FileName") & ControlChars.Tab
                'newRow = newRow & row("Layout") & ControlChars.Tab
                'newRow = newRow & row("TitleBlock") & ControlChars.Tab
                'newRow = newRow & row("RevisionBlock") & ControlChars.Tab
                'newRow = newRow & row("DocumentReleaseNoticeNumber") & ControlChars.NewLine
                'Next c
                '''''''
                ' email.Body = newRow

                '             Mail.SmtpMail.SmtpServer = "dfhlscausers01.dfh.local"
                '             Mail.SmtpMail.Send(email)
                Kill(transmittalFldr & "\Document List " & drnID & ".txt")
            Else
                MessageBox.Show("Select A Document Release Notice.")
            End If
        End Sub



        '#Region "arx aced cmd Import - acedRedraw"

        '        <System.Security.SuppressUnmanagedCodeSecurity()> _
        '    <System.Runtime.InteropServices.DllImport("acad.exe", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
        '    Private Shared Function acedRedraw(ByVal name As Long(), ByVal mode As Integer) As Integer
        '        End Function

        '        '<CommandMethod("MyRedraw")> _
        '        Public Sub MyRedraw()
        '            acedRedraw(Nothing, 1)
        '        End Sub

        '#End Region





#Region "releaseFilesToInnovator"

        Private Sub btnTransmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransmit.Click
            'If Not dvE044DRN Is Nothing Then
            '    Dim transInfo2 As TransmittalInfo2 : Dim transOper2 As New TransmittalOperation2
            '    transInfo2 = transOper2.getTransmittalInfoInterface()
            '    transInfo2.destinationRoot = transmittalFldr
            '    'transInfo2.organizedFolder = True
            '    'transInfo2.relativePath = True
            '    'transInfo2.preserveSubdirs = True
            '    transInfo2.plotConfigFilePath = "C:\Gary\Plotters"
            '    transInfo2.plotStyleTablePath = "C:\Gary\Plot Styles"

            '    Dim transFile As New TransmittalFile : Dim addFilRetVal As AddFileReturnVal : Dim fil As String
            '    For Each fil In OpenFileNames
            '        addFilRetVal = transOper2.addDrawingFile(fil, transFile)
            '    Next

            '    Dim transGraphIntface As TransmittalFilesGraph2
            '    transGraphIntface = transOper2.getTransmittalGraphInterface()
            '    Dim transReport As String = transOper2.getTransmittalReport()
            '    CreateTextFile(transmittalFldr & "\Report.txt", transReport)
            '    transOper2.createTransmittalPackage()
            '    mkDrnTransReport()

            '    '
            '    ConnToInnovator()
            '    Dim iomDoc As Aras.IOM.Item
            '    Dim iomECN As Aras.IOM.Item = addECNToInnovator()

            '    ' dwfs
            '    '                Dim iomDoc As IOM.Item = addDocToInnovator("DRN-" & drnID & "-Doc Files")
            '    ' Check if These Files Exist or will have duplicates.
            '    Dim myRow As DataRow
            '    Dim ctr As Integer ': Dim Cc As Integer
            '    For ctr = 0 To (cloneTable.Rows.Count - 1)
            '        myRow = cloneTable.Rows(ctr)
            '        Dim fn As String = myRow.Item(0).substring(0, myRow.Item(0).lastindexof(".")) & "-" & myRow.Item(1) & ".dwf"

            '        iomDoc = addDocToInnovator(myRow.Item(1) & ".dwf")

            '        addFilesToInnovator(FolderName, fn, iomDoc)

            '        iomDoc.setProperty("name", myRow.Item(0))  '"DRN-" & drnID & " " &
            '        iomDoc.setProperty("description", myRow.Item(2) & ControlChars.CrLf & myRow.Item(3))
            '        iomDoc.setProperty("classification", "/Document/Drawing")
            '        iomDoc.setProperty("effective_date", Now)
            '        iomDoc.setProperty("drawing_size", "B")
            '        iomDoc.setProperty("scale", "None")
            '        iomDoc.setProperty("authoring_tool", "AutoCAD")
            '        iomDoc.setProperty("authoring_tool_version", "2009")
            '        iomDoc.setProperty("managed_by", "2EA7BAAA8CDE46C5A2E1E08E8BFBB8B8")
            '        iomDoc.setProperty("owned_by_id", "30B991F927274FA3829655F50C99472E")

            '        Dim EDdocRes As Aras.IOM.Item = iomDoc.apply()
            '        If EDdocRes.isError Then Console.WriteLine(EDdocRes.getErrorDetail)

            '        Dim str As String = EDdocRes.getItemByIndex(0).getID()

            '        Dim relItm As Aras.IOM.Item = inn.newItem("ECN Affected Item", "add")

            '        Dim affItm As Aras.IOM.Item = inn.newItem("Affected Item", "add")

            '        affItm.setProperty("action", "Add")
            '        affItm.setProperty("new_item_id", str)

            '        ' affItm.setProperty() type

            '        relItm.setRelatedItem(affItm)

            '        iomECN.addRelationship(relItm)

            '    Next

            '    Dim ecnEDdocRes As Aras.IOM.Item = iomECN.apply()
            '    If ecnEDdocRes.isError Then Console.WriteLine(ecnEDdocRes.getErrorDetail)

            '    conn.Logout()

            'Else
            '    MessageBox.Show("Select A Document Release Notice.")
            'End If
        End Sub

        Public Function addECNToInnovator() As Aras.IOM.Item

            Dim docItm As Aras.IOM.Item = inn.newItem("ECN", "add")
            docItm.setProperty("title", "DRN-" & drnID)
            docItm.setProperty("effectivity_date", Now.ToString)

            Dim docRes As Aras.IOM.Item = docItm.apply()
            If docRes.isError Then Console.WriteLine(docRes.getErrorDetail)

            Dim ECNnum As String = docRes.getProperty("item_number")

            Dim EDdocItm As Aras.IOM.Item = inn.newItem("ECN", "edit")
            EDdocItm.setAttribute("where", "[ECN].ITEM_NUMBER='" & ECNnum & "' and [ECN].IS_CURRENT='1'")

            Return EDdocItm

        End Function

        Public Function addDocToInnovator(ByVal itmNum As String) As Aras.IOM.Item

            Dim docItm As Aras.IOM.Item = inn.newItem("Document", "add")
            docItm.setProperty("item_number", itmNum)

            Dim docRes As Aras.IOM.Item = docItm.apply()
            If docRes.isError Then Console.WriteLine(docRes.getErrorDetail)

            Dim EDdocItm As Aras.IOM.Item = inn.newItem("Document", "edit")
            EDdocItm.setAttribute("where", "[DOCUMENT].ITEM_NUMBER='" & itmNum & "' and [DOCUMENT].IS_CURRENT='1'")

            Return EDdocItm

        End Function

        Public Sub addFilesToInnovator(ByVal fldrName As String, ByVal filName As String, ByVal docItm As Aras.IOM.Item)

            Dim fileItm As Aras.IOM.Item = inn.newItem("File", "add")
            Dim fileLocatedRel As Aras.IOM.Item = inn.newItem("Located", "add")

            fileItm.setProperty("filename", filName)
            fileItm.setProperty("actual_filename", FolderName & "\" & filName)
            fileItm.setProperty("checkedout_path", FolderName)
            fileItm.attachPhysicalFile(FolderName & "\" & filName, vDefaultVault)

            Dim Res As Aras.IOM.Item = Nothing

            Try
                Res = fileItm.apply()
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try

            If Res.isError Then Console.WriteLine(Res.getErrorDetail)

            Dim fileItm2 As Aras.IOM.Item = inn.getItemByKeyedName("File", filName)
            Dim relItm As Aras.IOM.Item = inn.newItem("Document File", "add")
            relItm.setRelatedItem(fileItm2)

            docItm.addRelationship(relItm)

        End Sub

        Dim vDefaultVault As String
        Public conn As Aras.IOM.HttpServerConnection
        Dim inn As Aras.IOM.Innovator

        Public Sub ConnToInnovator()
            Dim pw As String = Aras.IOM.Innovator.ScalcMD5("12345678")
            conn = IomFactory.CreateHttpServerConnection("http://10.12.24.111/InnovatorServer/Server/InnovatorServer.aspx", "InnovatorSolutions", "willig01", pw)

            inn = New Aras.IOM.Innovator(conn)

            Dim ConnectTest As Aras.IOM.Item = inn.newItem("User", "get")
            ConnectTest.setAttribute("select", "E Drive Vault")
            ConnectTest.setProperty("login_name", "admin")
            Dim ConnectTestResult As Aras.IOM.Item
            ConnectTestResult = ConnectTest.apply()
            If ConnectTestResult.isError() Then
                MsgBox("Error: " & ConnectTestResult.getErrorDetail(), , "Publish2Innovator")
                conn.Logout()
                Return
            End If
            vDefaultVault = ConnectTestResult.getProperty("E Drive Vault")
        End Sub

        Public Sub CreateTextFile(ByVal FileName As String, ByVal TextToAdd As String)
            Dim file As New System.IO.StreamWriter(FileName)
            file.Write(TextToAdd) : file.Close()
        End Sub

#End Region




        Private Sub File2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles File2.SelectedIndexChanged
            'AxCExpressViewerControl1.SourcePath = FolderName & "\" & File2.SelectedItem : File2.Focus()
        End Sub

#Region "DrnTransReport"

        Dim transmittalFldr As String = "c:\Gary\Transmittals"

        Private Sub mkDrnTransReport()
            'Dim cCur As Cursor = Cursor.Current : Cursor.Current = Cursors.WaitCursor
            Dim ds As New System.Data.DataSet
            ds.Tables.Add(dvE044DRN.Table.Clone)
            Dim row As System.Data.DataRow : Dim newRow As System.Data.DataRow
            Dim c As Integer
            For c = 0 To (dvE044DRN.Count - 1)
                row = dvE044DRN.Item(c).Row
                newRow = ds.Tables(0).NewRow()
                newRow("FileName") = row("FileName")
                newRow("Layout") = row("Layout")
                newRow("TitleBlock") = row("TitleBlock")
                newRow("RevisionBlock") = row("RevisionBlock")
                newRow("DocumentReleaseNoticeNumber") = row("DocumentReleaseNoticeNumber")
                ds.Tables(0).Rows.Add(newRow)
            Next c
            mkFile(ds)
            'Cursor.Current = cCur
        End Sub

        Public Sub mkFile(ByVal ds As DataSet)
            Dim fn As String = transmittalFldr & "\Document List " & drnID & ".txt"
            Dim fs As FileStream
            If File.Exists(fn) = False Then
                fs = File.Create(fn)
                fs.Close()
            End If
            Dim sr As StreamWriter = File.CreateText(fn)
            PrintTable(ds.Tables(0), sr)
            sr.Close()
        End Sub

        Private Sub PrintTable(ByVal myTable As System.Data.DataTable, ByVal sr As StreamWriter)
            Dim myRow As DataRow
            Dim myColumn As System.Data.DataColumn
            Dim ts As String = ""
            For Each myColumn In myTable.Columns
                ts = ts & myColumn.ColumnName & ControlChars.Tab
            Next
            sr.WriteLine(ts) : ts = Nothing
            For Each myRow In myTable.Rows
                For Each myColumn In myTable.Columns
                    ts = ts & myRow(myColumn) & ControlChars.Tab
                Next
                sr.WriteLine(ts) : ts = Nothing
            Next
        End Sub

#End Region

    End Class

End Namespace
