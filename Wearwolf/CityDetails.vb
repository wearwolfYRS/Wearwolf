Public Class City
    Public id As Integer
    Public name As String
    Public coord As Coord
    Public country As String
    Public cod As String
    Public message As Decimal
    Public cnt As Integer
    Public list(1) As List
End Class
Public Class Coord
    Public lon As Decimal
    Public lat As Decimal
End Class
Public Class Weather
    Public id As Integer
    Public main As String
    Public description As String
    Public icon As String
End Class

Public Class List
    Public dt As Integer
    Public Main As Main
    Public Weather(1) As Weather
    Public Clouds As Clouds
    Public Wind As Wind
    Public Sys As Sys
    Public dt_txt As String
End Class

Public Class Main
    Public temp As Decimal
    Public temp_min As Decimal
    Public temp_max As Decimal
    Public pressure As Decimal
    Public sea_level As Decimal
    Public grnd_level As Decimal
    Public humidity As Decimal
    Public temp_kf As Decimal
End Class

Public Class Clouds
    Public All As Integer
End Class
Public Class Wind
    Public Speed As Decimal
    Public Deg As Decimal
End Class

Public Class Sys
    Public Pod As String
End Class

