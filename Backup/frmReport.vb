Option Explicit On 

Imports System.Math
Imports System.Windows.Forms

Imports CrystalDecisions.Shared

Imports rnsCadDataProj.nsMods


Namespace nsForms

    Public Class frmReport

        Inherits System.Windows.Forms.Form


#Region " Windows Form Designer generated code "

        Public Sub New()
            MyBase.New()

            InitializeComponent()

        End Sub

        'Form overrides dispose to clean up the component list.
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Not (components Is Nothing) Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub

        Private WithEvents btnSelectReport As System.Windows.Forms.Button
        Private WithEvents crystalReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer

        Private components As System.ComponentModel.Container

        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.btnSelectReport = New System.Windows.Forms.Button
            Me.crystalReportViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
            Me.SuspendLayout()
            '
            'btnSelectReport
            '
            Me.btnSelectReport.Location = New System.Drawing.Point(8, 8)
            Me.btnSelectReport.Name = "btnSelectReport"
            Me.btnSelectReport.Size = New System.Drawing.Size(112, 32)
            Me.btnSelectReport.TabIndex = 0
            Me.btnSelectReport.Text = "Select Report"
            '
            'crystalReportViewer
            '
            Me.crystalReportViewer.ActiveViewIndex = -1
            Me.crystalReportViewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.crystalReportViewer.Location = New System.Drawing.Point(8, 48)
            Me.crystalReportViewer.Name = "crystalReportViewer"
            Me.crystalReportViewer.ReportSource = Nothing
            Me.crystalReportViewer.Size = New System.Drawing.Size(640, 416)
            Me.crystalReportViewer.TabIndex = 1
            '
            'frmReport
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(659, 472)
            Me.Controls.Add(Me.crystalReportViewer)
            Me.Controls.Add(Me.btnSelectReport)
            Me.Name = "frmReport"
            Me.Text = "View a Crystal Report"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private Sub btnSelectReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectReport.Click
            ' Dim dlg As New System.Windows.Forms.OpenFileDialog
            ' dlg.Title = "Select Crystal Reports file"
            ' dlg.Filter = "Crystal Reports (*.rpt)|*.rpt|All Files (*.*)|*.*"
            ' dlg.InitialDirectory = "C:\Documents and Settings\gdw\Desktop\Cad 2006 Netload\Reports"
            ' If (dlg.ShowDialog() = DialogResult().OK) Then
            'Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            'crystalReportViewer().ReportSource = dlg.FileName
            'Me.Cursor = System.Windows.Forms.Cursors.Default
            'End If


            ' TabControl1.SelectedTab = tpCrystalView
            Dim cCur As Cursor = Cursor.Current : Cursor.Current = Cursors.WaitCursor
            ' Try : rptE044DRN1.Close() : Catch : End Try

            ' Label1.Text = "Double LB 3 cm - " & FromCtDate & " To " & ToCtDate & " Central Time"

            'daComp_Lasers.Ds_LLB_1231._UA_LLB_Laser.Clear() : CloneTbl2.Clear()
            'daComp_Lasers.SqlDa_LLB.SelectCommand.Parameters.Item("@ParamFromDate").Value = FromUtcDate '& " " & FromTime
            'daComp_Lasers.SqlDa_LLB.SelectCommand.Parameters.Item("@ParamToDate").Value = ToUtcDate '& " " & ToTime

            'daComp_Lasers.SqlDa_LLB.SelectCommand.Parameters.Item("@ParamThkLowr").Value = ThkLLbRow.Item(4)
            'daComp_Lasers.SqlDa_LLB.SelectCommand.Parameters.Item("@ParamThkUppr").Value = ThkLLbRow.Item(5)

            'daComp_Lasers.SqlDa_LLB.Fill(daComp_Lasers.Ds_LLB_1231._UA_LLB_Laser)

            '    makeLLbLaserRep(AveRow.Item(0), AveRow.Item(1))
            '   moveRowsLLb(ThkLLbRow.Item(4), ThkLLbRow.Item(5))

            'DataGrid1.DataSource = CloneTbl2
            'PassedDataTable = CloneTbl2

            '            addParams(ThkLLbRow.Item(4), ThkLLbRow.Item(5))

            ShowReportDRN()
            Cursor.Current = cCur

        End Sub

        '  TabControl1.SelectedTab = tpCrystalView


        Private Sub ShowReportDRN()
            '  Dim cCur As Cursor = Cursor.Current : Cursor.Current = Cursors.WaitCursor
            Try : rptE044DRN1.Close() : Catch : End Try

            '  crRepPolishLasWarpAll.SummaryInfo.ReportTitle = Label1.Text

            rptE044DRN1.SetDataSource(SqlDaComp.DataSet11)
            crystalReportViewer.ReportSource = rptE044DRN1
            ' Cursor.Current = cCur
        End Sub






    End Class

End Namespace