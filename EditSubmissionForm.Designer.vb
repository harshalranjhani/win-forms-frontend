<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditSubmissionForm
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
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.EmailLabel = New System.Windows.Forms.Label()
        Me.PhoneLabel = New System.Windows.Forms.Label()
        Me.GithubLinkLabel = New System.Windows.Forms.Label()
        Me.StopwatchLabel = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.GithubLinkTextBox = New System.Windows.Forms.TextBox()
        Me.StopwatchTimeTextBox = New System.Windows.Forms.TextBox()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(50, 30)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(35, 13)
        Me.NameLabel.TabIndex = 0
        Me.NameLabel.Text = "Name"
        '
        'EmailLabel
        '
        Me.EmailLabel.AutoSize = True
        Me.EmailLabel.Location = New System.Drawing.Point(50, 70)
        Me.EmailLabel.Name = "EmailLabel"
        Me.EmailLabel.Size = New System.Drawing.Size(32, 13)
        Me.EmailLabel.TabIndex = 1
        Me.EmailLabel.Text = "Email"
        '
        'PhoneLabel
        '
        Me.PhoneLabel.AutoSize = True
        Me.PhoneLabel.Location = New System.Drawing.Point(50, 110)
        Me.PhoneLabel.Name = "PhoneLabel"
        Me.PhoneLabel.Size = New System.Drawing.Size(38, 13)
        Me.PhoneLabel.TabIndex = 2
        Me.PhoneLabel.Text = "Phone"
        '
        'GithubLinkLabel
        '
        Me.GithubLinkLabel.AutoSize = True
        Me.GithubLinkLabel.Location = New System.Drawing.Point(50, 150)
        Me.GithubLinkLabel.Name = "GithubLinkLabel"
        Me.GithubLinkLabel.Size = New System.Drawing.Size(63, 13)
        Me.GithubLinkLabel.TabIndex = 3
        Me.GithubLinkLabel.Text = "Github Link"
        '
        'StopwatchLabel
        '
        Me.StopwatchLabel.AutoSize = True
        Me.StopwatchLabel.Location = New System.Drawing.Point(50, 190)
        Me.StopwatchLabel.Name = "StopwatchLabel"
        Me.StopwatchLabel.Size = New System.Drawing.Size(63, 13)
        Me.StopwatchLabel.TabIndex = 4
        Me.StopwatchLabel.Text = "Stopwatch"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(50, 50)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NameTextBox.TabIndex = 5
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(50, 90)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(200, 20)
        Me.EmailTextBox.TabIndex = 6
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.Location = New System.Drawing.Point(50, 130)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PhoneTextBox.TabIndex = 7
        '
        'GithubLinkTextBox
        '
        Me.GithubLinkTextBox.Location = New System.Drawing.Point(50, 170)
        Me.GithubLinkTextBox.Name = "GithubLinkTextBox"
        Me.GithubLinkTextBox.Size = New System.Drawing.Size(200, 20)
        Me.GithubLinkTextBox.TabIndex = 8
        '
        'StopwatchTimeTextBox
        '
        Me.StopwatchTimeTextBox.Location = New System.Drawing.Point(50, 210)
        Me.StopwatchTimeTextBox.Name = "StopwatchTimeTextBox"
        Me.StopwatchTimeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.StopwatchTimeTextBox.TabIndex = 9
        '
        'SaveButton
        '
        Me.SaveButton.BackColor = System.Drawing.Color.LightGreen
        Me.SaveButton.Location = New System.Drawing.Point(50, 250)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(120, 30)
        Me.SaveButton.TabIndex = 10
        Me.SaveButton.Text = "SAVE"
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'EditSubmissionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 320)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.StopwatchTimeTextBox)
        Me.Controls.Add(Me.GithubLinkTextBox)
        Me.Controls.Add(Me.PhoneTextBox)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.StopwatchLabel)
        Me.Controls.Add(Me.GithubLinkLabel)
        Me.Controls.Add(Me.PhoneLabel)
        Me.Controls.Add(Me.EmailLabel)
        Me.Controls.Add(Me.NameLabel)
        Me.Name = "EditSubmissionForm"
        Me.Text = "John Doe, Slidely Task 2 - Edit Submission"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NameLabel As Label
    Friend WithEvents EmailLabel As Label
    Friend WithEvents PhoneLabel As Label
    Friend WithEvents GithubLinkLabel As Label
    Friend WithEvents StopwatchLabel As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents GithubLinkTextBox As TextBox
    Friend WithEvents StopwatchTimeTextBox As TextBox
    Friend WithEvents SaveButton As Button
End Class
