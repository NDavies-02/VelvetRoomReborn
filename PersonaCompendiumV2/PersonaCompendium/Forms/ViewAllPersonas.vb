Public Class ViewAllPersonas
    Private Sub LDPButton_Click(sender As Object, e As EventArgs) Handles LDPButton.Click
        MsgBox("Loading all personas...")
        Module1.ViewAllPersonas(ListBox1)
    End Sub


    Private Sub frmViewPersonas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'procedure that reads all data from file into an array of records:

    End Sub
End Class