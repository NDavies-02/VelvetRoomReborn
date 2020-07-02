Public Class MainMenu
    Private Sub ApplicationInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApplicationInfoToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub ViewAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewAllToolStripMenuItem.Click
        ViewAllPersonas.Show()
    End Sub

    Private Sub MainMenu_Show(sender As Object, e As EventArgs) Handles MyBase.Shown
        My.Computer.Audio.Play(My.Resources.VRTheme, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ArcanaSearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArcanaSearchToolStripMenuItem.Click
        SearchbyArcana.Show()
    End Sub

    Private Sub BasicToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BasicToolStripMenuItem.Click
        BasicFusion.Show()
    End Sub
    Private Sub AdvancedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdvancedToolStripMenuItem.Click
        AdvancedFusion.Show()
    End Sub

    Private Sub StrengthenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StrengthenToolStripMenuItem.Click
        StrengthenPersona.Show()
    End Sub

    Private Sub ItemizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItemizeToolStripMenuItem.Click
        ItemizePersona.Show()
    End Sub

    Private Sub NetworkFusionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NetworkFusionToolStripMenuItem.Click
        NetworkFusion.Show()
    End Sub

    Private Sub ResetApplicationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetApplicationToolStripMenuItem.Click
        If MsgBox("This will reset all application data by recreating the Persona Compendium. To cancel, click no or cancel.", 3 + 32, "Compendium Reset") = DialogResult.OK Then
            ResetInitialPersonas.Reset()
            ResetInitialPersonas.WriteAllPersonas()
        End If
    End Sub

    Private Sub RegisterAllPersonasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisterAllPersonasToolStripMenuItem.Click
        If MsgBox("Register all Personas?", 4 + 64, "Register All") = DialogResult.Yes Then
            MsgBox("All Personas have now been registered.")
        End If
    End Sub

    Private Sub HelpAndSupportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpAndSupportToolStripMenuItem.Click
        Help.Show()
    End Sub
End Class
