Imports System.IO ' for reading and writing to files
Public Class All_Outfits
    Dim fileReader As StreamReader
    Dim fileWriter As StreamWriter
    Dim imagenum, currentnum, linetotal As Integer
    Dim filename As String
    Dim MenuPage As Menu_Page

    Private Sub All_Outfits_Load(sender As Object, e As EventArgs) Handles Me.Load
        fileReader = New StreamReader("ImageNo.txt")
        imagenum = Int(fileReader.ReadLine())
        fileReader.Close()
        currentnum = 1
        filename = currentnum & "Image.jpg"
        pictureboxAll.Image = Image.FromFile(filename)
        Me.pictureboxAll.SizeMode = PictureBoxSizeMode.StretchImage ' making it the correct size for the picture box
    End Sub

    Private Sub btnNextAll_Click(sender As Object, e As EventArgs) Handles btnNextAll.Click
        currentnum = currentnum + 1
        If currentnum > imagenum Then
            MsgBox("End of outfits")
            currentnum = 1
        End If
        filename = currentnum & "Image.jpg"
        pictureboxAll.Image = Image.FromFile(filename)
        Me.pictureboxAll.SizeMode = PictureBoxSizeMode.StretchImage ' making it the correct size for the picture box

    End Sub

    Private Sub btnBackAll_Click(sender As Object, e As EventArgs) Handles btnBackAll.Click
        MenuPage = New Menu_Page()
        Me.Close()
        MenuPage.Show()
    End Sub

    Private Sub btnDeleteAll_Click(sender As Object, e As EventArgs) Handles btnDeleteAll.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        currentnum = currentnum - 1
        If currentnum < 1 Then
            currentnum = imagenum
        End If

        filename = currentnum & "Image.jpg"
        pictureboxAll.Image = Image.FromFile(filename)
        Me.pictureboxAll.SizeMode = PictureBoxSizeMode.StretchImage ' making it the correct size for the picture box
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnFavourite.Click
        Dim repeat As Boolean
        Dim line As Integer
        repeat = False
        line = 0
        linetotal = 0
        fileReader = New StreamReader("Fave.txt")
        Do Until fileReader.ReadLine() = Nothing ' A loop to calculate how many lines there are in the file
            linetotal = linetotal + 1 ' Every time the loop repeats, 1 is added to y
        Loop
        fileReader.Close()
        fileReader = New StreamReader("Fave.txt")
        For x = 1 To linetotal
            line = Int(fileReader.ReadLine())
            If currentnum = line Then
                MsgBox("This outfit is already saved as one of your favourites")
                repeat = True
            End If
        Next
        fileReader.Close()
        If repeat = False Then
            fileWriter = New StreamWriter("Fave.txt", True)
            fileWriter.WriteLine(currentnum)
            fileWriter.Close()
            MsgBox("This outfit has been added to your favourites")
        End If
        
    End Sub
End Class