Public Class Suggestions
    Dim Menu As Menu_Page
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Menu = New Menu_Page()
        Me.Close()
        Menu_Page.Show()
    End Sub
End Class