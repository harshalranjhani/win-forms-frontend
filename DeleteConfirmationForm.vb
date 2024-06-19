Public Class DeleteConfirmationForm
    Public Property ConfirmDelete As Boolean = False

    Private Sub YesButton_Click(sender As Object, e As EventArgs) Handles YesButton.Click
        ConfirmDelete = True
        Me.Close()
    End Sub

    Private Sub NoButton_Click(sender As Object, e As EventArgs) Handles NoButton.Click
        ConfirmDelete = False
        Me.Close()
    End Sub
End Class
