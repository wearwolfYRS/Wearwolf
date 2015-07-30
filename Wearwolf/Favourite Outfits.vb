Imports System.IO ' for reading and writing to files

Public Class Favourite_Outfits
    Dim MenuPage As Menu_Page
    Dim fileWriter As StreamWriter
    Dim fileReader As StreamReader
    Dim line, favourite(100), filename As String
    Dim lineno, index As Integer

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        MenuPage = New Menu_Page()
        Me.Close()
        MenuPage.Show()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        index = index + 1
        If index >= lineno Then
            MsgBox("You have reached then end of your list of favourite outfits")
            index = 0
        End If
            filename = favourite(index) + "image.jpg"
            pictureboxFave.Image = Image.FromFile(filename)
            Me.pictureboxFave.SizeMode = PictureBoxSizeMode.StretchImage ' making it the correct size for the picture box
    End Sub

    Private Sub Favourite_Outfits_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        index = 0
        lineno = 0
        fileReader = New StreamReader("Fave.txt")
        line = fileReader.ReadLine()
        fileReader.Close()
        If line = 0 Then
            MsgBox("Sorry, you have not selected any favourite outfits")
        Else
            pictureboxFave.Image = Image.FromFile(line & "image.jpg")
            Me.pictureboxFave.SizeMode = PictureBoxSizeMode.StretchImage ' making it the correct size for the picture box
        End If

        fileReader = New StreamReader("Fave.txt")
        Do Until fileReader.ReadLine() = Nothing
            lineno = lineno + 1
        Loop
        fileReader.Close()
        fileReader = New StreamReader("Fave.txt")
        For x = 0 To lineno
            favourite(x) = fileReader.ReadLine()
        Next
        fileReader.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPreviousFave.Click
        index = index - 1
        If index < 0 Then
            index = lineno - 1
        End If

        If index < lineno Then
            filename = favourite(index) + "image.jpg"
            pictureboxFave.Image = Image.FromFile(filename)
            Me.pictureboxFave.SizeMode = PictureBoxSizeMode.StretchImage ' making it the correct size for the picture box
        Else
            MsgBox("You have reached then end of your list of favourite outfits")
            index = -1
        End If
    End Sub
End Class