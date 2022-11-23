Option Explicit On 

Namespace nsUserCtls

    Public Class ucAttOptions
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
        Friend WithEvents chkbxCustomer As System.Windows.Forms.CheckBox
        Friend WithEvents tbCustomer As System.Windows.Forms.TextBox
        Friend WithEvents chkbxProject As System.Windows.Forms.CheckBox
        Friend WithEvents tbProject As System.Windows.Forms.TextBox
        Friend WithEvents chkbxLocation As System.Windows.Forms.CheckBox
        Friend WithEvents tbLocation As System.Windows.Forms.TextBox
        Friend WithEvents chkbxDesc_1 As System.Windows.Forms.CheckBox
        Friend WithEvents tbDesc_1 As System.Windows.Forms.TextBox
        Friend WithEvents tbDesc_2 As System.Windows.Forms.TextBox
        Friend WithEvents chkbxDesc_2 As System.Windows.Forms.CheckBox
        Friend WithEvents tbDesc_3 As System.Windows.Forms.TextBox
        Friend WithEvents chkbxDesc_3 As System.Windows.Forms.CheckBox
        Friend WithEvents tbScale As System.Windows.Forms.TextBox
        Friend WithEvents chkbxScale As System.Windows.Forms.CheckBox
        Friend WithEvents chkbxFileLayAtt As System.Windows.Forms.CheckBox
        Friend WithEvents chkbxDrawnDate As System.Windows.Forms.CheckBox
        Friend WithEvents chkbxCheckedDate As System.Windows.Forms.CheckBox
        Friend WithEvents chkbxDwgPath As System.Windows.Forms.CheckBox
        Friend WithEvents tbDrawnDate As System.Windows.Forms.TextBox
        Friend WithEvents tbCheckedDate As System.Windows.Forms.TextBox
        Friend WithEvents chkbxDrawnBy As System.Windows.Forms.CheckBox
        Friend WithEvents chkbxCheckedBy As System.Windows.Forms.CheckBox
        Friend WithEvents tbCheckedBy As System.Windows.Forms.TextBox
        Friend WithEvents tbDrawnBy As System.Windows.Forms.TextBox
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.chkbxCustomer = New System.Windows.Forms.CheckBox
            Me.tbCustomer = New System.Windows.Forms.TextBox
            Me.chkbxProject = New System.Windows.Forms.CheckBox
            Me.tbProject = New System.Windows.Forms.TextBox
            Me.chkbxLocation = New System.Windows.Forms.CheckBox
            Me.tbLocation = New System.Windows.Forms.TextBox
            Me.chkbxDesc_1 = New System.Windows.Forms.CheckBox
            Me.tbDesc_1 = New System.Windows.Forms.TextBox
            Me.tbDesc_2 = New System.Windows.Forms.TextBox
            Me.chkbxDesc_2 = New System.Windows.Forms.CheckBox
            Me.tbDesc_3 = New System.Windows.Forms.TextBox
            Me.chkbxDesc_3 = New System.Windows.Forms.CheckBox
            Me.chkbxFileLayAtt = New System.Windows.Forms.CheckBox
            Me.chkbxDwgPath = New System.Windows.Forms.CheckBox
            Me.chkbxDrawnDate = New System.Windows.Forms.CheckBox
            Me.chkbxCheckedDate = New System.Windows.Forms.CheckBox
            Me.tbScale = New System.Windows.Forms.TextBox
            Me.chkbxScale = New System.Windows.Forms.CheckBox
            Me.tbDrawnDate = New System.Windows.Forms.TextBox
            Me.tbCheckedDate = New System.Windows.Forms.TextBox
            Me.tbCheckedBy = New System.Windows.Forms.TextBox
            Me.tbDrawnBy = New System.Windows.Forms.TextBox
            Me.chkbxDrawnBy = New System.Windows.Forms.CheckBox
            Me.chkbxCheckedBy = New System.Windows.Forms.CheckBox
            Me.SuspendLayout()
            '
            'chkbxCustomer
            '
            Me.chkbxCustomer.Location = New System.Drawing.Point(616, 16)
            Me.chkbxCustomer.Name = "chkbxCustomer"
            Me.chkbxCustomer.Size = New System.Drawing.Size(72, 24)
            Me.chkbxCustomer.TabIndex = 0
            Me.chkbxCustomer.Text = "Customer"
            '
            'tbCustomer
            '
            Me.tbCustomer.Location = New System.Drawing.Point(400, 16)
            Me.tbCustomer.Name = "tbCustomer"
            Me.tbCustomer.Size = New System.Drawing.Size(216, 20)
            Me.tbCustomer.TabIndex = 1
            Me.tbCustomer.Text = "tbCustomer"
            '
            'chkbxProject
            '
            Me.chkbxProject.Location = New System.Drawing.Point(616, 48)
            Me.chkbxProject.Name = "chkbxProject"
            Me.chkbxProject.Size = New System.Drawing.Size(72, 24)
            Me.chkbxProject.TabIndex = 0
            Me.chkbxProject.Text = "Project"
            '
            'tbProject
            '
            Me.tbProject.Location = New System.Drawing.Point(400, 48)
            Me.tbProject.Name = "tbProject"
            Me.tbProject.Size = New System.Drawing.Size(216, 20)
            Me.tbProject.TabIndex = 1
            Me.tbProject.Text = "tbProject"
            '
            'chkbxLocation
            '
            Me.chkbxLocation.Location = New System.Drawing.Point(616, 80)
            Me.chkbxLocation.Name = "chkbxLocation"
            Me.chkbxLocation.Size = New System.Drawing.Size(72, 24)
            Me.chkbxLocation.TabIndex = 0
            Me.chkbxLocation.Text = "Location"
            '
            'tbLocation
            '
            Me.tbLocation.Location = New System.Drawing.Point(400, 80)
            Me.tbLocation.Name = "tbLocation"
            Me.tbLocation.Size = New System.Drawing.Size(216, 20)
            Me.tbLocation.TabIndex = 1
            Me.tbLocation.Text = "tbLocation"
            '
            'chkbxDesc_1
            '
            Me.chkbxDesc_1.Location = New System.Drawing.Point(616, 120)
            Me.chkbxDesc_1.Name = "chkbxDesc_1"
            Me.chkbxDesc_1.Size = New System.Drawing.Size(72, 24)
            Me.chkbxDesc_1.TabIndex = 0
            Me.chkbxDesc_1.Text = "Desc 1"
            '
            'tbDesc_1
            '
            Me.tbDesc_1.Location = New System.Drawing.Point(400, 120)
            Me.tbDesc_1.Name = "tbDesc_1"
            Me.tbDesc_1.Size = New System.Drawing.Size(216, 20)
            Me.tbDesc_1.TabIndex = 1
            Me.tbDesc_1.Text = "tbDesc_1"
            '
            'tbDesc_2
            '
            Me.tbDesc_2.Location = New System.Drawing.Point(400, 152)
            Me.tbDesc_2.Name = "tbDesc_2"
            Me.tbDesc_2.Size = New System.Drawing.Size(216, 20)
            Me.tbDesc_2.TabIndex = 1
            Me.tbDesc_2.Text = "tbDesc_2"
            '
            'chkbxDesc_2
            '
            Me.chkbxDesc_2.Location = New System.Drawing.Point(616, 152)
            Me.chkbxDesc_2.Name = "chkbxDesc_2"
            Me.chkbxDesc_2.Size = New System.Drawing.Size(72, 24)
            Me.chkbxDesc_2.TabIndex = 0
            Me.chkbxDesc_2.Text = "Desc 2"
            '
            'tbDesc_3
            '
            Me.tbDesc_3.Location = New System.Drawing.Point(400, 184)
            Me.tbDesc_3.Name = "tbDesc_3"
            Me.tbDesc_3.Size = New System.Drawing.Size(216, 20)
            Me.tbDesc_3.TabIndex = 1
            Me.tbDesc_3.Text = "tbDesc_3"
            '
            'chkbxDesc_3
            '
            Me.chkbxDesc_3.Location = New System.Drawing.Point(616, 184)
            Me.chkbxDesc_3.Name = "chkbxDesc_3"
            Me.chkbxDesc_3.Size = New System.Drawing.Size(72, 24)
            Me.chkbxDesc_3.TabIndex = 0
            Me.chkbxDesc_3.Text = "Desc 3"
            '
            'chkbxFileLayAtt
            '
            Me.chkbxFileLayAtt.Location = New System.Drawing.Point(56, 152)
            Me.chkbxFileLayAtt.Name = "chkbxFileLayAtt"
            Me.chkbxFileLayAtt.Size = New System.Drawing.Size(88, 24)
            Me.chkbxFileLayAtt.TabIndex = 2
            Me.chkbxFileLayAtt.Text = "File Layout"
            '
            'chkbxDwgPath
            '
            Me.chkbxDwgPath.Location = New System.Drawing.Point(200, 152)
            Me.chkbxDwgPath.Name = "chkbxDwgPath"
            Me.chkbxDwgPath.Size = New System.Drawing.Size(80, 24)
            Me.chkbxDwgPath.TabIndex = 2
            Me.chkbxDwgPath.Text = "Dwg Path"
            '
            'chkbxDrawnDate
            '
            Me.chkbxDrawnDate.Location = New System.Drawing.Point(288, 32)
            Me.chkbxDrawnDate.Name = "chkbxDrawnDate"
            Me.chkbxDrawnDate.Size = New System.Drawing.Size(96, 24)
            Me.chkbxDrawnDate.TabIndex = 3
            Me.chkbxDrawnDate.Text = "Drawn Date"
            '
            'chkbxCheckedDate
            '
            Me.chkbxCheckedDate.Location = New System.Drawing.Point(288, 64)
            Me.chkbxCheckedDate.Name = "chkbxCheckedDate"
            Me.chkbxCheckedDate.Size = New System.Drawing.Size(96, 24)
            Me.chkbxCheckedDate.TabIndex = 3
            Me.chkbxCheckedDate.Text = "Checked Date"
            '
            'tbScale
            '
            Me.tbScale.Location = New System.Drawing.Point(200, 96)
            Me.tbScale.Name = "tbScale"
            Me.tbScale.Size = New System.Drawing.Size(88, 20)
            Me.tbScale.TabIndex = 1
            Me.tbScale.Text = "tbScale"
            '
            'chkbxScale
            '
            Me.chkbxScale.Location = New System.Drawing.Point(288, 96)
            Me.chkbxScale.Name = "chkbxScale"
            Me.chkbxScale.Size = New System.Drawing.Size(56, 24)
            Me.chkbxScale.TabIndex = 0
            Me.chkbxScale.Text = "Scale"
            '
            'tbDrawnDate
            '
            Me.tbDrawnDate.Location = New System.Drawing.Point(200, 32)
            Me.tbDrawnDate.Name = "tbDrawnDate"
            Me.tbDrawnDate.Size = New System.Drawing.Size(88, 20)
            Me.tbDrawnDate.TabIndex = 1
            Me.tbDrawnDate.Text = "tbDrawnDate"
            '
            'tbCheckedDate
            '
            Me.tbCheckedDate.Location = New System.Drawing.Point(200, 64)
            Me.tbCheckedDate.Name = "tbCheckedDate"
            Me.tbCheckedDate.Size = New System.Drawing.Size(88, 20)
            Me.tbCheckedDate.TabIndex = 1
            Me.tbCheckedDate.Text = "tbCheckedDate"
            '
            'tbCheckedBy
            '
            Me.tbCheckedBy.Location = New System.Drawing.Point(8, 64)
            Me.tbCheckedBy.Name = "tbCheckedBy"
            Me.tbCheckedBy.Size = New System.Drawing.Size(88, 20)
            Me.tbCheckedBy.TabIndex = 1
            Me.tbCheckedBy.Text = "tbCheckedBy"
            '
            'tbDrawnBy
            '
            Me.tbDrawnBy.Location = New System.Drawing.Point(8, 32)
            Me.tbDrawnBy.Name = "tbDrawnBy"
            Me.tbDrawnBy.Size = New System.Drawing.Size(88, 20)
            Me.tbDrawnBy.TabIndex = 1
            Me.tbDrawnBy.Text = "tbDrawnBy"
            '
            'chkbxDrawnBy
            '
            Me.chkbxDrawnBy.Location = New System.Drawing.Point(96, 32)
            Me.chkbxDrawnBy.Name = "chkbxDrawnBy"
            Me.chkbxDrawnBy.Size = New System.Drawing.Size(96, 24)
            Me.chkbxDrawnBy.TabIndex = 3
            Me.chkbxDrawnBy.Text = "Drawn By"
            '
            'chkbxCheckedBy
            '
            Me.chkbxCheckedBy.Location = New System.Drawing.Point(96, 64)
            Me.chkbxCheckedBy.Name = "chkbxCheckedBy"
            Me.chkbxCheckedBy.Size = New System.Drawing.Size(96, 24)
            Me.chkbxCheckedBy.TabIndex = 3
            Me.chkbxCheckedBy.Text = "Checked By"
            '
            'ucAttOptions
            '
            Me.Controls.Add(Me.chkbxDrawnDate)
            Me.Controls.Add(Me.chkbxFileLayAtt)
            Me.Controls.Add(Me.tbCustomer)
            Me.Controls.Add(Me.chkbxCustomer)
            Me.Controls.Add(Me.chkbxProject)
            Me.Controls.Add(Me.tbProject)
            Me.Controls.Add(Me.chkbxLocation)
            Me.Controls.Add(Me.tbLocation)
            Me.Controls.Add(Me.chkbxDesc_1)
            Me.Controls.Add(Me.tbDesc_1)
            Me.Controls.Add(Me.tbDesc_2)
            Me.Controls.Add(Me.chkbxDesc_2)
            Me.Controls.Add(Me.tbDesc_3)
            Me.Controls.Add(Me.chkbxDesc_3)
            Me.Controls.Add(Me.chkbxDwgPath)
            Me.Controls.Add(Me.chkbxCheckedDate)
            Me.Controls.Add(Me.tbScale)
            Me.Controls.Add(Me.chkbxScale)
            Me.Controls.Add(Me.tbDrawnDate)
            Me.Controls.Add(Me.tbCheckedDate)
            Me.Controls.Add(Me.tbCheckedBy)
            Me.Controls.Add(Me.tbDrawnBy)
            Me.Controls.Add(Me.chkbxDrawnBy)
            Me.Controls.Add(Me.chkbxCheckedBy)
            Me.Name = "ucAttOptions"
            Me.Size = New System.Drawing.Size(696, 216)
            Me.ResumeLayout(False)

        End Sub

#End Region

       
       
        
        Private Sub chkbxDrawnDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkbxDrawnDate.CheckedChanged
            Dim NewDate As String = UCase(Format(Now, "dd/MMM/yy").ToString)
            tbDrawnDate.Text = NewDate
        End Sub

        Private Sub chkbxCheckedDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkbxCheckedDate.CheckedChanged
            Dim NewDate As String = UCase(Format(Now, "dd/MMM/yy").ToString)
            tbCheckedDate.Text = NewDate
        End Sub

      
       
    End Class

End Namespace
