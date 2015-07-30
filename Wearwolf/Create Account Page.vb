Imports System.Data.SqlClient ' is this still in use by database?
Imports System.IO ' for reading and writing to files

Public Class Create_Account_Page
    Dim con As New OleDb.OleDbConnection
    Dim OpeningPage As opening
    Dim fileWriter As StreamWriter
    Dim fileReader As StreamReader
    Dim Menu As Menu_Page


    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'Dim IDvalue As Integer
        ' Dim line As String
        'Dim dbProvider As String
        'Dim dbSource As String
        ' Dim CustomersRow As DataRow
        'Dim newCustomersRow As DataRow
        ' Dim table1 As DataTable = Wearwolf_Accounts.Tables.Table1 '!!!!!!!!!!!!!!!!!!!!!

        ' line = ""
        'newCustomersRow = Wearwolf_Accounts.table1.NewRow() '!!!!!!!!!!!!!!1

        'fileReader = New StreamReader("ID.txt")
        'line = fileReader.ReadLine()
        'IDvalue = Int(line) ' finds the value of the last ID number used
        'IDvalue = IDvalue + 1 ' for the next record
        'fileReader.Close()
        'fileWriter = New StreamWriter("ID.txt")
        'fileWriter.WriteLine(IDvalue)
        'fileWriter.Close()


        'newCustomersRow.ID = IDvalue


        'dbProvider = "PROVIDER=Microsoft.ACE.OLEDB.12.0;"
        'dbSource = "Data Source = C:\Users\Anna\Documents\Visual Studio 2012\Projects\Wearwolf\Wearwolf\Wearwolf Accounts.accdb"
        'con.ConnectionString = dbProvider & dbSource

        'con.Open()

        'con.Close()

        If txtName.Text = "" Then
            MsgBox("Please enter your full name")
        ElseIf txtEmail.Text = "" Then
            MsgBox("Please enter your email address")
        ElseIf txtPassword.Text = "" Then
            MsgBox("Please enter your password")
        ElseIf txtRepeatPassword.Text = "" Then
            MsgBox("Please enter your repeated password")
        Else
            Menu = New Menu_Page()
            Me.Close()
            Menu.Show()
        End If

        Dim LengthofPassword As Integer

        LengthofPassword = Len(txtPassword.Text)
        If LengthofPassword < 6 Then
            MsgBox("Please enter a password with 6 or more digits")
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        OpeningPage = New opening()
        Me.Close()
        OpeningPage.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class

