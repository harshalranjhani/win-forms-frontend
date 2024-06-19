Imports Newtonsoft.Json
Imports System.Net.Http
Imports System.Text

Public Class CreateSubmissionForm
    Private stopwatch As New Stopwatch()

    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set up keyboard shortcuts
        Me.KeyPreview = True
        AddHandler Me.KeyDown, AddressOf CreateSubmissionForm_KeyDown

        ' Start the timer to update the stopwatch label every second
        AddHandler StopwatchTimer.Tick, AddressOf UpdateStopwatchLabel
        StopwatchTimer.Start()
    End Sub

    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs)
        If e.Control AndAlso e.KeyCode = Keys.T Then
            ToggleStopwatch()
        ElseIf e.Control AndAlso e.KeyCode = Keys.S Then
            SubmitForm()
        End If
    End Sub

    Private Sub ToggleStopwatchButton_Click(sender As Object, e As EventArgs) Handles ToggleStopwatchButton.Click
        ToggleStopwatch()
    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        SubmitForm()
    End Sub

    Private Sub ToggleStopwatch()
        If stopwatch.IsRunning Then
            stopwatch.Stop()
        Else
            stopwatch.Start()
        End If
    End Sub

    Private Sub UpdateStopwatchLabel(sender As Object, e As EventArgs)
        StopwatchLabel.Text = String.Format("{0:hh\:mm\:ss}", stopwatch.Elapsed)
    End Sub

    Private Async Sub SubmitForm()
        ' Code to submit the form data via API
        Dim name As String = NameTextBox.Text
        Dim email As String = EmailTextBox.Text
        Dim phone As String = PhoneTextBox.Text
        Dim githubLink As String = GithubLinkTextBox.Text
        Dim stopwatchTime As String = StopwatchLabel.Text

        ' Create a new instance of the HttpClient
        Dim client As New HttpClient()

        ' Create a new form submission object
        Dim submission As New Dictionary(Of String, String) From {
            {"name", name},
            {"email", email},
            {"phone", phone},
            {"github_link", githubLink},
            {"stopwatch_time", stopwatchTime}
        }

        ' Convert the form submission to JSON
        Dim json As String = JsonConvert.SerializeObject(submission)

        ' Send the POST request
        Dim content As New StringContent(json, Encoding.UTF8, "application/json")
        ' Dim response As HttpResponseMessage = Await client.PostAsync("https://winforms.harshalranjhani.in/submit-vercel", content)
        Dim response As HttpResponseMessage = Await client.PostAsync("http://localhost:8080/submit", content)

        ' Handle the response
        If response.IsSuccessStatusCode Then
            MessageBox.Show("Form submitted successfully!")
        Else
            MessageBox.Show("Error submitting form.")
        End If
    End Sub
End Class
