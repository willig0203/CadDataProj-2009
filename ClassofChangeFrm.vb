Namespace nsForms

    Public Class ClassofChangeFrm
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
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents rbNonInter As System.Windows.Forms.RadioButton
        Friend WithEvents rbInter As System.Windows.Forms.RadioButton
        Friend WithEvents rbNewDoc As System.Windows.Forms.RadioButton
        Friend WithEvents rbDocChngOnly As System.Windows.Forms.RadioButton
        Friend WithEvents btnClsofChng As System.Windows.Forms.Button
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox
            Me.rbNonInter = New System.Windows.Forms.RadioButton
            Me.rbInter = New System.Windows.Forms.RadioButton
            Me.rbNewDoc = New System.Windows.Forms.RadioButton
            Me.rbDocChngOnly = New System.Windows.Forms.RadioButton
            Me.btnClsofChng = New System.Windows.Forms.Button
            Me.GroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.rbDocChngOnly)
            Me.GroupBox1.Controls.Add(Me.rbNewDoc)
            Me.GroupBox1.Controls.Add(Me.rbInter)
            Me.GroupBox1.Controls.Add(Me.rbNonInter)
            Me.GroupBox1.Location = New System.Drawing.Point(16, 16)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(200, 184)
            Me.GroupBox1.TabIndex = 0
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Class of Engineering Change"
            '
            'rbNonInter
            '
            Me.rbNonInter.Location = New System.Drawing.Point(32, 32)
            Me.rbNonInter.Name = "rbNonInter"
            Me.rbNonInter.Size = New System.Drawing.Size(144, 24)
            Me.rbNonInter.TabIndex = 0
            Me.rbNonInter.Text = "Non-Interchangeable"
            '
            'rbInter
            '
            Me.rbInter.Location = New System.Drawing.Point(32, 64)
            Me.rbInter.Name = "rbInter"
            Me.rbInter.Size = New System.Drawing.Size(144, 24)
            Me.rbInter.TabIndex = 1
            Me.rbInter.Text = "Interchangeable"
            '
            'rbNewDoc
            '
            Me.rbNewDoc.Location = New System.Drawing.Point(32, 96)
            Me.rbNewDoc.Name = "rbNewDoc"
            Me.rbNewDoc.Size = New System.Drawing.Size(144, 24)
            Me.rbNewDoc.TabIndex = 2
            Me.rbNewDoc.Text = "New Document"
            '
            'rbDocChngOnly
            '
            Me.rbDocChngOnly.Location = New System.Drawing.Point(32, 128)
            Me.rbDocChngOnly.Name = "rbDocChngOnly"
            Me.rbDocChngOnly.Size = New System.Drawing.Size(144, 24)
            Me.rbDocChngOnly.TabIndex = 3
            Me.rbDocChngOnly.Text = "Documentation Only"
            '
            'btnClsofChng
            '
            Me.btnClsofChng.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.btnClsofChng.Location = New System.Drawing.Point(152, 224)
            Me.btnClsofChng.Name = "btnClsofChng"
            Me.btnClsofChng.TabIndex = 1
            Me.btnClsofChng.Text = "Ok"
            '
            'ClassofChangeFrm
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(304, 286)
            Me.Controls.Add(Me.btnClsofChng)
            Me.Controls.Add(Me.GroupBox1)
            Me.Name = "ClassofChangeFrm"
            Me.Text = "ClassofChangeFrm"
            Me.GroupBox1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

#End Region


        Public ChngType As String = ""

        Private Sub btnClsofChng_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClsofChng.Click

            If rbNonInter.Checked = True Then ChngType = "Non-Interchangeable"
            If rbInter.Checked = True Then ChngType = "Interchangeable"
            If rbNewDoc.Checked = True Then ChngType = "New Documents"
            If rbDocChngOnly.Checked = True Then ChngType = "Documentation Only"

            Me.Hide()

        End Sub
    End Class


End Namespace