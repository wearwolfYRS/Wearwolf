Public Class Sign_In_Page
    Dim OpeningPage As opening
    Dim MenuPage As Menu_Page
    Private Sub Sign_In_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub btnBack2_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        OpeningPage = New opening()
        Me.Close()
        OpeningPage.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If txtEmailKnown.Text = "" Then
            MsgBox("Please enter your email address")
        ElseIf txtPasswordKnown.Text = "" Then
            MsgBox("Please enter your password")
        Else
            MenuPage = New Menu_Page()
            Me.Close()
            MenuPage.Show()
        End If
        
    End Sub

    Private Sub txtPasswordKnown_TextChanged(sender As Object, e As EventArgs) Handles txtPasswordKnown.TextChanged

    End Sub
End Class