<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainFormComponent
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ViewSubmissionsButton = New System.Windows.Forms.Button()
        Me.CreateSubmissionButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ViewSubmissionsButton
        '
        Me.ViewSubmissionsButton.BackColor = System.Drawing.Color.Yellow
        Me.ViewSubmissionsButton.Location = New System.Drawing.Point(50, 50)
        Me.ViewSubmissionsButton.Name = "ViewSubmissionsButton"
        Me.ViewSubmissionsButton.Size = New System.Drawing.Size(200, 50)
        Me.ViewSubmissionsButton.TabIndex = 0
        Me.ViewSubmissionsButton.Text = "VIEW SUBMISSIONS (CTRL + V)"
        Me.ViewSubmissionsButton.UseVisualStyleBackColor = False
        '
        'CreateSubmissionButton
        '
        Me.CreateSubmissionButton.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.CreateSubmissionButton.Location = New System.Drawing.Point(50, 120)
        Me.CreateSubmissionButton.Name = "CreateSubmissionButton"
        Me.CreateSubmissionButton.Size = New System.Drawing.Size(200, 50)
        Me.CreateSubmissionButton.TabIndex = 1
        Me.CreateSubmissionButton.Text = "CREATE NEW SUBMISSION (CTRL + N)"
        Me.CreateSubmissionButton.UseVisualStyleBackColor = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 220)
        Me.Controls.Add(Me.CreateSubmissionButton)
        Me.Controls.Add(Me.ViewSubmissionsButton)
        Me.Name = "MainForm"
        Me.Text = "Slidely Task 2 - Slidely Form App"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ViewSubmissionsButton As Button
    Friend WithEvents CreateSubmissionButton As Button
End Class
