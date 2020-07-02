Imports System.IO
Public Class Intialise


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Module1.createNewFile()
        Dim name, arcana As String
        name = "Arsene"
        arcana = "Fool"
        writeToFile(arcana, name)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class
