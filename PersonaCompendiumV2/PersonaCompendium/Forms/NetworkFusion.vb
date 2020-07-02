Public Class NetworkFusion
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GetRandomPersona()
        TextBox1.Text = GetRandomPersona()
    End Sub
End Class