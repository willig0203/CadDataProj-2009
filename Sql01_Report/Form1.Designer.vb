<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnIIS = New System.Windows.Forms.Button()
        Me.btnEventLogs = New System.Windows.Forms.Button()
        Me.btnGetDB = New System.Windows.Forms.Button()
        Me.btnGetServices = New System.Windows.Forms.Button()
        Me.btnGetDirs = New System.Windows.Forms.Button()
        Me.btnGetTasks = New System.Windows.Forms.Button()
        Me.btnGetShortCuts = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnIIS
        '
        Me.btnIIS.Location = New System.Drawing.Point(380, 187)
        Me.btnIIS.Name = "btnIIS"
        Me.btnIIS.Size = New System.Drawing.Size(102, 23)
        Me.btnIIS.TabIndex = 35
        Me.btnIIS.Text = "IIs"
        Me.btnIIS.UseVisualStyleBackColor = True
        '
        'btnEventLogs
        '
        Me.btnEventLogs.Location = New System.Drawing.Point(380, 157)
        Me.btnEventLogs.Name = "btnEventLogs"
        Me.btnEventLogs.Size = New System.Drawing.Size(102, 23)
        Me.btnEventLogs.TabIndex = 34
        Me.btnEventLogs.Text = "Event Logs"
        Me.btnEventLogs.UseVisualStyleBackColor = True
        '
        'btnGetDB
        '
        Me.btnGetDB.Location = New System.Drawing.Point(380, 128)
        Me.btnGetDB.Name = "btnGetDB"
        Me.btnGetDB.Size = New System.Drawing.Size(102, 23)
        Me.btnGetDB.TabIndex = 33
        Me.btnGetDB.Text = "Get DB"
        Me.btnGetDB.UseVisualStyleBackColor = True
        '
        'btnGetServices
        '
        Me.btnGetServices.Location = New System.Drawing.Point(380, 99)
        Me.btnGetServices.Name = "btnGetServices"
        Me.btnGetServices.Size = New System.Drawing.Size(102, 23)
        Me.btnGetServices.TabIndex = 32
        Me.btnGetServices.Text = "Get Services"
        Me.btnGetServices.UseVisualStyleBackColor = True
        '
        'btnGetDirs
        '
        Me.btnGetDirs.Location = New System.Drawing.Point(380, 70)
        Me.btnGetDirs.Name = "btnGetDirs"
        Me.btnGetDirs.Size = New System.Drawing.Size(102, 23)
        Me.btnGetDirs.TabIndex = 31
        Me.btnGetDirs.Text = "Get Dirs"
        Me.btnGetDirs.UseVisualStyleBackColor = True
        '
        'btnGetTasks
        '
        Me.btnGetTasks.Location = New System.Drawing.Point(380, 41)
        Me.btnGetTasks.Name = "btnGetTasks"
        Me.btnGetTasks.Size = New System.Drawing.Size(102, 23)
        Me.btnGetTasks.TabIndex = 30
        Me.btnGetTasks.Text = "Get Tasks"
        Me.btnGetTasks.UseVisualStyleBackColor = True
        '
        'btnGetShortCuts
        '
        Me.btnGetShortCuts.Location = New System.Drawing.Point(380, 12)
        Me.btnGetShortCuts.Name = "btnGetShortCuts"
        Me.btnGetShortCuts.Size = New System.Drawing.Size(102, 23)
        Me.btnGetShortCuts.TabIndex = 29
        Me.btnGetShortCuts.Text = "Get Short Cuts"
        Me.btnGetShortCuts.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 384)
        Me.Controls.Add(Me.btnIIS)
        Me.Controls.Add(Me.btnEventLogs)
        Me.Controls.Add(Me.btnGetDB)
        Me.Controls.Add(Me.btnGetServices)
        Me.Controls.Add(Me.btnGetDirs)
        Me.Controls.Add(Me.btnGetTasks)
        Me.Controls.Add(Me.btnGetShortCuts)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnIIS As System.Windows.Forms.Button
    Friend WithEvents btnEventLogs As System.Windows.Forms.Button
    Friend WithEvents btnGetDB As System.Windows.Forms.Button
    Friend WithEvents btnGetServices As System.Windows.Forms.Button
    Friend WithEvents btnGetDirs As System.Windows.Forms.Button
    Friend WithEvents btnGetTasks As System.Windows.Forms.Button
    Friend WithEvents btnGetShortCuts As System.Windows.Forms.Button

End Class
