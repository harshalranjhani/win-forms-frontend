﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewSubmissionsForm
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
        Me.PreviousButton = New System.Windows.Forms.Button()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
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
        Me.NameTextBox.ReadOnly = True
        Me.NameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NameTextBox.TabIndex = 5
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(50, 90)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.ReadOnly = True
        Me.EmailTextBox.Size = New System.Drawing.Size(200, 20)
        Me.EmailTextBox.TabIndex = 6
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.Location = New System.Drawing.Point(50, 130)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.ReadOnly = True
        Me.PhoneTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PhoneTextBox.TabIndex = 7
        '
        'GithubLinkTextBox
        '
        Me.GithubLinkTextBox.Location = New System.Drawing.Point(50, 170)
        Me.GithubLinkTextBox.Name = "GithubLinkTextBox"
        Me.GithubLinkTextBox.ReadOnly = True
        Me.GithubLinkTextBox.Size = New System.Drawing.Size(200, 20)
        Me.GithubLinkTextBox.TabIndex = 8
        '
        'StopwatchTimeTextBox
        '
        Me.StopwatchTimeTextBox.Location = New System.Drawing.Point(50, 210)
        Me.StopwatchTimeTextBox.Name = "StopwatchTimeTextBox"
        Me.StopwatchTimeTextBox.ReadOnly = True
        Me.StopwatchTimeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.StopwatchTimeTextBox.TabIndex = 9
        '
        'PreviousButton
        '
        Me.PreviousButton.BackColor = System.Drawing.Color.Orange
        Me.PreviousButton.Location = New System.Drawing.Point(50, 250)
        Me.PreviousButton.Name = "PreviousButton"
        Me.PreviousButton.Size = New System.Drawing.Size(120, 30)
        Me.PreviousButton.TabIndex = 10
        Me.PreviousButton.Text = "PREVIOUS (CTRL + P)"
        Me.PreviousButton.UseVisualStyleBackColor = False
        '
        'NextButton
        '
        Me.NextButton.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.NextButton.Location = New System.Drawing.Point(180, 250)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(120, 30)
        Me.NextButton.TabIndex = 11
        Me.NextButton.Text = "NEXT (CTRL + N)"
        Me.NextButton.UseVisualStyleBackColor = False
        '
        'EditButton
        '
        Me.EditButton.BackColor = System.Drawing.Color.LightGreen
        Me.EditButton.Location = New System.Drawing.Point(310, 250)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(120, 30)
        Me.EditButton.TabIndex = 12
        Me.EditButton.Text = "EDIT"
        Me.EditButton.UseVisualStyleBackColor = False
        '
        'DeleteButton
        '
        Me.DeleteButton.BackColor = System.Drawing.Color.Red
        Me.DeleteButton.Location = New System.Drawing.Point(440, 250)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(120, 30)
        Me.DeleteButton.TabIndex = 13
        Me.DeleteButton.Text = "DELETE"
        Me.DeleteButton.UseVisualStyleBackColor = False
        '
        'ViewSubmissionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 320)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.EditButton)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.PreviousButton)
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
        Me.Name = "ViewSubmissionsForm"
        Me.Text = "View Submissions"
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
    Friend WithEvents PreviousButton As Button
    Friend WithEvents NextButton As Button
    Friend WithEvents EditButton As Button
    Friend WithEvents DeleteButton As Button
End Class
