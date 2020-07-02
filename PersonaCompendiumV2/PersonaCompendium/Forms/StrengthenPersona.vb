Public Class StrengthenPersona

    Private Sub StrengthenPersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.MaxDropDownItems = PersonaArray.Length
        For stepper = 0 To (PersonaArray.Length - 1)
            ComboBox1.Items.Add(PersonaArray(stepper))
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'show msgbox
    End Sub
End Class