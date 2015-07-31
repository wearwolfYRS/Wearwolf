Imports System
Imports System.Net
Imports System.Xml
Imports Microsoft.VisualBasic
Imports Newtonsoft.Json
Imports System.IO

Public Class Search_Page
    Dim fileWriter As StreamWriter
    Dim fileReader As StreamReader
    Dim MenuPage As Menu_Page
    Dim ChanceOfRain, ChanceOfSnow, match, rainsuitable, snowsuitable, tempsuitable As Boolean
    Dim tempkelvin, tempcelcius, weather, occasion, season, filename, occasionfile, seasonfile, weatherfile As String
    Dim requestUrl, cityID, chosencity As String
    Dim imagenum, selected(100), y, highestnum As Integer
    Private DataSourceID As String = "90f4e33537fc6a861ca13921e07b323f"
    Dim webClient As New System.Net.WebClient
    Dim result As String = webClient.DownloadString("http://api.openweathermap.org/data/2.5/forecast/city?id=" & cityID & "&APPID=90f4e33537fc6a861ca13921e07b323f")
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        MenuPage = New Menu_Page()
        Me.Close()
        MenuPage.Show()
    End Sub

    Private Sub Search_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        requestUrl = "http://api.openweathermap.org/data/2.5/forecast/city?id=2643743&APPID=90f4e33537fc6a861ca13921e07b323f"
        chosencity = comboCity.Text
        Select Case chosencity 'selecting the correct ID code for the required city
            Case "Aberdeen"
                cityID = "3333224"
            Case "Birmingham"
                cityID = "2655603"
            Case "Cambridge"
                cityID = "4931972"
            Case "London"
                cityID = "2643743"
        End Select
        If chosencity = "" Then
            MsgBox("Please fill out the location box")
        ElseIf cityID = "" Then
            MsgBox("Sorry, an error has occurred. Please check your city is correct")
        Else
            result = webClient.DownloadString("http://api.openweathermap.org/data/2.5/forecast/city?id=" & cityID & "&APPID=90f4e33537fc6a861ca13921e07b323f")
            Dim city As City ' Link to new City Case
            city = JsonConvert.DeserializeObject(Of City)(result)
            tempkelvin = city.list(0).Main.temp
            tempcelcius = tempkelvin - 273.15
            weather = city.list(0).Weather(0).description
            lblWeather.Text = "Weather : " & weather & ControlChars.NewLine & "It will be " & tempcelcius & Chr(176) & "C"
            ChanceOfRain = weather.Contains("rain")
            If ChanceOfRain = True Then
                lblWeather.Text = lblWeather.Text & " - remember an umbrella!"
            End If
            ChanceOfSnow = weather.Contains("snow")
        End If

        For x = 0 To 100
            selected(x) = 0
        Next

        match = False
        occasion = comboOccasion.Text
        season = comboSeason.Text
        fileReader = New StreamReader("ImageNo.txt")
        imagenum = Int(fileReader.ReadLine())
        fileReader.Close()
        y = 0

        For x = 1 To imagenum
            filename = x & "imageinfo.txt"
            If File.Exists(filename) = True Then
                fileReader = New StreamReader(filename)
                occasionfile = fileReader.ReadLine()
                seasonfile = fileReader.ReadLine()
                weatherfile = fileReader.ReadLine()
                rainsuitable = weatherfile.Contains("Rain")
                If ChanceOfRain = True And weatherfile = "All" Then
                    rainsuitable = True
                ElseIf ChanceOfRain = False Then
                    rainsuitable = False
                End If
                ''''''''''''''
                If rainsuitable = ChanceOfRain Then
                    match = True
                End If
                ''''''''''''
                If weatherfile.Contains("Heat") And tempcelcius > 23 Then
                    tempsuitable = True
                ElseIf weatherfile.Contains("Cold") And tempcelcius <= 23 Then
                    tempsuitable = True
                Else
                    match = False
                End If
                '''''''''
                If season = "All" Then
                    seasonfile = "All"
                End If
                ''''''''
                If seasonfile = "All" Then
                    season = "All"
                End If
                If occasionfile = occasion And seasonfile = season And match = True And tempsuitable = True Then
                    selected(y) = x
                    highestnum = y
                    y = y + 1
                End If

                If selected(0) = 0 Then
                    MsgBox("Sorry, there are no outfits avaliable for these criteria")
                Else
                    filename = selected(0) & "image.jpg"
                    Dim stream As New FileStream(filename, FileMode.Open)
                    Dim image As Image = image.FromStream(stream)
                    pictureboxOutfit.Image = image
                    stream.Close()
                    Me.pictureboxOutfit.SizeMode = PictureBoxSizeMode.StretchImage ' making it the correct size for the picture box
                End If

                y = 0

            End If
        Next

    End Sub

    Private Sub btnNextOutfit_Click(sender As Object, e As EventArgs) Handles btnNextOutfit.Click
        y = y + 1
        If y > highestnum Then
            MsgBox("Sorry, there are no more outfits that meet your requirements")
            y = 0
        ElseIf selected(y) = 0 Then
            ''
        End If
        filename = selected(y) & "image.jpg"
        pictureboxOutfit.Image = Image.FromFile(filename)
        Me.pictureboxOutfit.SizeMode = PictureBoxSizeMode.StretchImage ' making it the correct size for the picture box

    End Sub

    Private Sub btnPreviousSearch_Click(sender As Object, e As EventArgs) Handles btnPreviousSearch.Click
        y = y - 1
        If y < 0 Then
            y = highestnum
        End If
        filename = selected(y) & "image.jpg"
        pictureboxOutfit.Image = Image.FromFile(filename)
        Me.pictureboxOutfit.SizeMode = PictureBoxSizeMode.StretchImage ' making it the correct size for the picture box
    End Sub
End Class