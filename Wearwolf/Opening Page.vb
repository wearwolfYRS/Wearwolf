Public Class opening
    Dim SignInPage As Sign_In_Page
    Dim OpeningPage As opening 'Come back to this and make it work instead of just hiding it!
    Dim CreateAccount As Create_Account_Page
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SignInPage = New Sign_In_Page()
        OpeningPage = New opening()
        CreateAccount = New Create_Account_Page()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        Me.Hide()
        SignInPage.Show()
    End Sub

    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click
        Me.Hide()
        CreateAccount.Show()
    End Sub
End Class
