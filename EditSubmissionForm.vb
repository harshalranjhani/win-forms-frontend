Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Net.Http
Imports System.Text

Public Class EditSubmissionForm
    Private index As Integer

    Public Sub New(submissionData As JObject, submissionIndex As Integer)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        NameTextBox.Text = submissionData("name").Value(Of String)()
        EmailTextBox.Text = submissionData("email").Value(Of String)()
        PhoneTextBox.Text = submissionData("phone").Value(Of String)()
        GithubLinkTextBox.Text = submissionData("github_link").Value(Of String)()
        StopwatchTimeTextBox.Text = submissionData("stopwatch_time").Value(Of String)()

        index = submissionIndex
    End Sub

    Private Async Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        ' Collect data from form
        Dim name As String = NameTextBox.Text
        Dim email As String = EmailTextBox.Text
        Dim phone As String = PhoneTextBox.Text
        Dim githubLink As String = GithubLinkTextBox.Text
        Dim stopwatchTime As String = StopwatchTimeTextBox.Text

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

        ' Send the PUT request
        Dim client As New HttpClient()
        Dim content As New StringContent(json, Encoding.UTF8, "application/json")
        ' Dim response As HttpResponseMessage = Await client.PutAsync($"https://winforms.harshalranjhani.in/edit-vercel/{index}", content)
        Dim response As HttpResponseMessage = Await client.PutAsync($"http://localhost:8080/edit/{index}", content)
        ' Handle the response
        If response.IsSuccessStatusCode Then
            MessageBox.Show("Form updated successfully!")
            Me.Close()
        Else
            MessageBox.Show("Error updating form.")
        End If
    End Sub
End Class
