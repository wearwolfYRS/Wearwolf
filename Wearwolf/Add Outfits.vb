Imports System.IO ' for reading and writing to files
Public Class Create_Outfit
    Dim route As String
    Dim fileWriter As StreamWriter
    Dim fileReader As StreamReader
    Dim strm As System.IO.Stream
    Dim line, imagefilename, imageinfofilename As String
    Dim imageno As Integer
    Dim MenuPage As Menu_Page

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        OpenFileDialog1.Title = "Please select your image"
        OpenFileDialog1.InitialDirectory = "C:temp"
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        
        
        strm = OpenFileDialog1.OpenFile() ' the user picks the file
        route = OpenFileDialog1.FileName.ToString()
        strm.Close()
        pictureboxAddOutfit.Image = Image.FromFile(route)
        Me.pictureboxAddOutfit.SizeMode = PictureBoxSizeMode.StretchImage ' making it the correct size for the picture box
        

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        fileReader = New StreamReader("ImageNo.txt") 'preparing the file names to store image and info
        line = fileReader.ReadLine()
        fileReader.Close()
        imageno = Int(line) + 1
        imagefilename = imageno & "image.jpg"
        imageinfofilename = imageno & "imageinfo.txt"
        fileWriter = New StreamWriter("ImageNo.txt")
        fileWriter.WriteLine(imageno)
        fileWriter.Close()
        pictureboxAddOutfit.Image.Save(imagefilename) ' saving the image

        fileWriter = New StreamWriter(imageinfofilename)
        fileWriter.WriteLine(comboOccasion.Text)
        fileWriter.WriteLine(comboSeason.Text)
        fileWriter.WriteLine(comboWeather.Text)
        fileWriter.Close()

        comboOccasion.ResetText()
        comboSeason.ResetText()
        comboWeather.ResetText()
        pictureboxAddOutfit.Image = Nothing

    End Sub

    Private Sub btnClearAll_Click(sender As Object, e As EventArgs) Handles btnClearAll.Click
        comboOccasion.ResetText()
        comboSeason.ResetText()
        comboWeather.ResetText()
        pictureboxAddOutfit.Image = Nothing

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        MenuPage = New Menu_Page()
        Me.Close()
        MenuPage.Show()
    End Sub

    Private Sub btnClearText_Click(sender As Object, e As EventArgs) Handles btnClearText.Click
        comboOccasion.ResetText()
        comboSeason.ResetText()
        comboWeather.ResetText()
    End Sub

    Private Sub Create_Outfit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class