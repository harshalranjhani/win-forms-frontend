Public Class MainFormComponent
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set up keyboard shortcuts
        Me.KeyPreview = True
        AddHandler Me.KeyDown, AddressOf MainForm_KeyDown
    End Sub

    Private Sub MainForm_KeyDown(sender As Object, e As KeyEventArgs)
        If e.Control AndAlso e.KeyCode = Keys.V Then
            ViewSubmissions()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            CreateNewSubmission()
        End If
    End Sub

    Private Sub ViewSubmissionsButton_Click(sender As Object, e As EventArgs) Handles ViewSubmissionsButton.Click
        ViewSubmissions()
    End Sub

    Private Sub CreateSubmissionButton_Click(sender As Object, e As EventArgs) Handles CreateSubmissionButton.Click
        CreateNewSubmission()
    End Sub

    Private Sub ViewSubmissions()
        ' Code to open the View Submissions form
        Dim viewForm As New ViewSubmissionsForm
        viewForm.Show()
    End Sub

    Private Sub CreateNewSubmission()
        ' Code to open the Create Submission form
        Dim createForm As New CreateSubmissionForm
        createForm.Show()
    End Sub
End Class
