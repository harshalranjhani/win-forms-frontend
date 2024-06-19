<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DeleteConfirmationForm
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
        Me.ConfirmationLabel = New System.Windows.Forms.Label()
        Me.YesButton = New System.Windows.Forms.Button()
        Me.NoButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ConfirmationLabel
        '
        Me.ConfirmationLabel.AutoSize = True
        Me.ConfirmationLabel.Location = New System.Drawing.Point(50, 30)
        Me.ConfirmationLabel.Name = "ConfirmationLabel"
        Me.ConfirmationLabel.Size = New System.Drawing.Size(179, 13)
        Me.ConfirmationLabel.TabIndex = 0
        Me.ConfirmationLabel.Text = "Are you sure you want to delete this?"
        '
        'YesButton
        '
        Me.YesButton.BackColor = System.Drawing.Color.LightGreen
        Me.YesButton.Location = New System.Drawing.Point(50, 60)
        Me.YesButton.Name = "YesButton"
        Me.YesButton.Size = New System.Drawing.Size(75, 23)
        Me.YesButton.TabIndex = 1
        Me.YesButton.Text = "Yes"
        Me.YesButton.UseVisualStyleBackColor = False
        '
        'NoButton
        '
        Me.NoButton.BackColor = System.Drawing.Color.Red
        Me.NoButton.Location = New System.Drawing.Point(150, 60)
        Me.NoButton.Name = "NoButton"
        Me.NoButton.Size = New System.Drawing.Size(75, 23)
        Me.NoButton.TabIndex = 2
        Me.NoButton.Text = "No"
        Me.NoButton.UseVisualStyleBackColor = False
        '
        'DeleteConfirmationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 111)
        Me.Controls.Add(Me.NoButton)
        Me.Controls.Add(Me.YesButton)
        Me.Controls.Add(Me.ConfirmationLabel)
        Me.Name = "DeleteConfirmationForm"
        Me.Text = "Delete Confirmation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ConfirmationLabel As Label
    Friend WithEvents YesButton As Button
    Friend WithEvents NoButton As Button
End Class
