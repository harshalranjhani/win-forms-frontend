Imports Newtonsoft.Json.Linq
Imports System.Net.Http

Public Class ViewSubmissionsForm
    Private currentIndex As Integer = 0

    Private Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set up keyboard shortcuts
        Me.KeyPreview = True
        AddHandler Me.KeyDown, AddressOf ViewSubmissionsForm_KeyDown

        ' Load the first submission
        LoadSubmission(currentIndex)
    End Sub

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs)
        If e.Control AndAlso e.KeyCode = Keys.P Then
            LoadPreviousSubmission()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            LoadNextSubmission()
        End If
    End Sub

    Private Sub PreviousButton_Click(sender As Object, e As EventArgs) Handles PreviousButton.Click
        LoadPreviousSubmission()
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        LoadNextSubmission()
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        OpenEditSubmissionForm()
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        ConfirmDeleteSubmission()
    End Sub

    Private Sub LoadPreviousSubmission()
        If currentIndex > 0 Then
            currentIndex -= 1
            LoadSubmission(currentIndex)
        End If
    End Sub

    Private Sub LoadNextSubmission()
        currentIndex += 1
        LoadSubmission(currentIndex)
    End Sub

    Private Async Sub LoadSubmission(index As Integer)
        ' Create a new instance of the HttpClient
        Dim client As New HttpClient()

        ' Send the GET request to fetch the submission by index
        Dim response As HttpResponseMessage = Await client.GetAsync($"https://winforms.harshalranjhani.in/read-vercel?index={index}")

        ' Handle the response
        If response.IsSuccessStatusCode Then
            Dim jsonResponse As String = Await response.Content.ReadAsStringAsync()
            Dim result As JObject = JObject.Parse(jsonResponse)

            If result("success").Value(Of Boolean)() Then
                Dim data As JObject = result("data")

                NameTextBox.Text = data("name").Value(Of String)()
                EmailTextBox.Text = data("email").Value(Of String)()
                PhoneTextBox.Text = data("phone").Value(Of String)()
                GithubLinkTextBox.Text = data("github_link").Value(Of String)()
                StopwatchTimeTextBox.Text = data("stopwatch_time").Value(Of String)()

                ' Pass the loaded data to the edit form
                EditButton.Tag = data
            Else
                MessageBox.Show(result("error").Value(Of String))
                If index > 0 Then
                    currentIndex -= 1
                End If
            End If
        Else
            MessageBox.Show("Error fetching submission.")
            If index > 0 Then
                currentIndex -= 1
            End If
        End If
    End Sub

    Private Sub OpenEditSubmissionForm()
        Dim submissionData As JObject = CType(EditButton.Tag, JObject)
        Dim editForm As New EditSubmissionForm(submissionData, currentIndex)
        editForm.ShowDialog()
        ' Reload the current submission to reflect any changes
        LoadSubmission(currentIndex)
    End Sub

    Private Sub ConfirmDeleteSubmission()
        Dim confirmationForm As New DeleteConfirmationForm()
        confirmationForm.ShowDialog()

        If confirmationForm.ConfirmDelete Then
            DeleteSubmission(currentIndex)
        End If
    End Sub

    Private Async Sub DeleteSubmission(index As Integer)
        ' Create a new instance of the HttpClient
        Dim client As New HttpClient()

        ' Send the DELETE request to delete the submission by index
        Dim response As HttpResponseMessage = Await client.DeleteAsync($"https://winforms.harshalranjhani.in/delete-vercel/{index}")

        ' Handle the response
        If response.IsSuccessStatusCode Then
            MessageBox.Show("Submission deleted successfully!")
            LoadNextSubmission()
        Else
            MessageBox.Show("Error deleting submission.")
        End If
    End Sub
End Class
