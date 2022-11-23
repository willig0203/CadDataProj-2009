Option Explicit On 

Imports System.Drawing
Imports System.Windows.Forms

Imports rnsCadDataProj.nsMods

Namespace nsForms

    Public Class frmE024ItmMstrDetail

        Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

        Public Sub New()
            MyBase.New()

            'This call is required by the Windows Form Designer.
            InitializeComponent()

            'Add any initialization after the InitializeComponent() call

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

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid

        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.DataGrid1 = New System.Windows.Forms.DataGrid
            CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'DataGrid1
            '
            Me.DataGrid1.DataMember = ""
            Me.DataGrid1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
            Me.DataGrid1.Location = New System.Drawing.Point(0, 0)
            Me.DataGrid1.Name = "DataGrid1"
            Me.DataGrid1.Size = New System.Drawing.Size(704, 294)
            Me.DataGrid1.TabIndex = 0
            '
            'E024ItmMstrDetailFrm
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(704, 294)
            Me.Controls.Add(Me.DataGrid1)
            Me.Name = "E024ItmMstrDetailFrm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "E024ItmMstrDetailFrm"
            CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Dim dvItmMstrs As DataView
        Dim ItmMstrsTblsAdded As Boolean
        Dim ItmMstrsts As New DataGridTableStyle

        Public Sub FindItmMstrs(ByVal dg As DataGrid, ByVal Col As Integer)

            If SqlDaComp.DataSet11.E024ItemMasterInput.Count = 0 Then
                SqlDaComp.SqlConn.ConnectionString = words
                SqlDaComp.DaE024ItmMstr.Fill(SqlDaComp.DataSet11.E024ItemMasterInput)
            End If

            If ItmMstrsTblsAdded = False Then
                ItmMstrsts.MappingName = "E024ItemMasterInput"
                Dim TextCol1 As New DataGridTextBoxColumn
                TextCol1.MappingName = "EngineeringPartNumber"
                TextCol1.HeaderText = "Part Number"
                TextCol1.Width = 300
                ItmMstrsts.GridColumnStyles.Add(TextCol1)
                Dim TextCol2 As New DataGridTextBoxColumn
                TextCol2.MappingName = "EngineeringDashNumber"
                TextCol2.HeaderText = "Dash"
                TextCol2.Width = 50
                ItmMstrsts.GridColumnStyles.Add(TextCol2)
                Dim TextCol3 As New DataGridTextBoxColumn
                TextCol3.MappingName = "EngineeringRevisionCode"
                TextCol3.HeaderText = "Rev"
                TextCol3.Width = 50
                ItmMstrsts.GridColumnStyles.Add(TextCol3)
                Dim TextCol4 As New DataGridTextBoxColumn
                TextCol4.MappingName = "EngineeringDescription"
                TextCol4.HeaderText = "Description"
                TextCol4.Width = 300
                ItmMstrsts.GridColumnStyles.Add(TextCol4)
                ItmMstrsts.AlternatingBackColor = Color.LightBlue
                ItmMstrsTblsAdded = True
            End If
            If DataGrid1.TableStyles.Contains("E024ItemMasterInput") = False Then DataGrid1.TableStyles.Add(ItmMstrsts)
            If dvItmMstrs Is Nothing Then dvItmMstrs = New DataView
            With dvItmMstrs
                .Table = SqlDaComp.DataSet11.Tables("E024ItemMasterInput")
                Dim str As String
                str = dg.Item(dg.CurrentRowIndex, Col - 1)
                str = str.Replace(".dwg", "") : str = str.Replace(".DWG", "") ' Should upper case this and then strip it
                'this works for drn
                Try : .RowFilter = "EngineeringPartNumber = '" & str & " - " & dg.Item(dg.CurrentRowIndex, Col) & "'"
                Catch ex As Exception : MessageBox.Show(ex.ToString)
                End Try
                '.RowStateFilter = DataViewRowState.ModifiedCurrent
                '.Sort = "CompanyName DESC"
            End With
            DataGrid1.DataSource = dvItmMstrs

        End Sub



    End Class

End Namespace
