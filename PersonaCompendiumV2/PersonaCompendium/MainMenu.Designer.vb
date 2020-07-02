<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompendiumToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArcanaSearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegisterAllPersonasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonaFusionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BasicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdvancedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StrengthenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NetworkFusionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfigToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetApplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpAndSupportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApplicationInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.CompendiumToolStripMenuItem, Me.PersonaFusionToolStripMenuItem, Me.ConfigToolStripMenuItem, Me.ApplicationInfoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(634, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(12, 20)
        '
        'CompendiumToolStripMenuItem
        '
        Me.CompendiumToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewAllToolStripMenuItem, Me.ArcanaSearchToolStripMenuItem, Me.RegisterAllPersonasToolStripMenuItem})
        Me.CompendiumToolStripMenuItem.Name = "CompendiumToolStripMenuItem"
        Me.CompendiumToolStripMenuItem.Size = New System.Drawing.Size(93, 20)
        Me.CompendiumToolStripMenuItem.Text = "Compendium"
        '
        'ViewAllToolStripMenuItem
        '
        Me.ViewAllToolStripMenuItem.Name = "ViewAllToolStripMenuItem"
        Me.ViewAllToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.ViewAllToolStripMenuItem.Text = "View All"
        '
        'ArcanaSearchToolStripMenuItem
        '
        Me.ArcanaSearchToolStripMenuItem.Name = "ArcanaSearchToolStripMenuItem"
        Me.ArcanaSearchToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.ArcanaSearchToolStripMenuItem.Text = "Arcana Search"
        '
        'RegisterAllPersonasToolStripMenuItem
        '
        Me.RegisterAllPersonasToolStripMenuItem.Name = "RegisterAllPersonasToolStripMenuItem"
        Me.RegisterAllPersonasToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.RegisterAllPersonasToolStripMenuItem.Text = "Register All Personas"
        '
        'PersonaFusionToolStripMenuItem
        '
        Me.PersonaFusionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BasicToolStripMenuItem, Me.AdvancedToolStripMenuItem, Me.StrengthenToolStripMenuItem, Me.ItemizeToolStripMenuItem, Me.NetworkFusionToolStripMenuItem})
        Me.PersonaFusionToolStripMenuItem.Name = "PersonaFusionToolStripMenuItem"
        Me.PersonaFusionToolStripMenuItem.Size = New System.Drawing.Size(99, 20)
        Me.PersonaFusionToolStripMenuItem.Text = "Persona Fusion"
        '
        'BasicToolStripMenuItem
        '
        Me.BasicToolStripMenuItem.Name = "BasicToolStripMenuItem"
        Me.BasicToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.BasicToolStripMenuItem.Text = "Basic"
        '
        'AdvancedToolStripMenuItem
        '
        Me.AdvancedToolStripMenuItem.Name = "AdvancedToolStripMenuItem"
        Me.AdvancedToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.AdvancedToolStripMenuItem.Text = "Advanced"
        '
        'StrengthenToolStripMenuItem
        '
        Me.StrengthenToolStripMenuItem.Name = "StrengthenToolStripMenuItem"
        Me.StrengthenToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.StrengthenToolStripMenuItem.Text = "Strengthen"
        '
        'ItemizeToolStripMenuItem
        '
        Me.ItemizeToolStripMenuItem.Name = "ItemizeToolStripMenuItem"
        Me.ItemizeToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ItemizeToolStripMenuItem.Text = "Itemize"
        '
        'NetworkFusionToolStripMenuItem
        '
        Me.NetworkFusionToolStripMenuItem.Name = "NetworkFusionToolStripMenuItem"
        Me.NetworkFusionToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.NetworkFusionToolStripMenuItem.Text = "Network Fusion"
        '
        'ConfigToolStripMenuItem
        '
        Me.ConfigToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetApplicationToolStripMenuItem, Me.HelpAndSupportToolStripMenuItem})
        Me.ConfigToolStripMenuItem.Name = "ConfigToolStripMenuItem"
        Me.ConfigToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.ConfigToolStripMenuItem.Text = "Config"
        '
        'ResetApplicationToolStripMenuItem
        '
        Me.ResetApplicationToolStripMenuItem.Name = "ResetApplicationToolStripMenuItem"
        Me.ResetApplicationToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.ResetApplicationToolStripMenuItem.Text = "Reset Application"
        '
        'HelpAndSupportToolStripMenuItem
        '
        Me.HelpAndSupportToolStripMenuItem.Name = "HelpAndSupportToolStripMenuItem"
        Me.HelpAndSupportToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.HelpAndSupportToolStripMenuItem.Text = "Help and Support"
        '
        'ApplicationInfoToolStripMenuItem
        '
        Me.ApplicationInfoToolStripMenuItem.Name = "ApplicationInfoToolStripMenuItem"
        Me.ApplicationInfoToolStripMenuItem.Size = New System.Drawing.Size(104, 20)
        Me.ApplicationInfoToolStripMenuItem.Text = "Application Info"
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.PersonaCompendium.My.Resources.Resources.Persona_5_Velvet_Room_1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(634, 361)
        Me.Controls.Add(Me.MenuStrip1)
        Me.HelpButton = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximumSize = New System.Drawing.Size(1920, 1080)
        Me.MinimumSize = New System.Drawing.Size(360, 360)
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Velvet Room"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CompendiumToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArcanaSearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegisterAllPersonasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PersonaFusionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BasicToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdvancedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StrengthenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ItemizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NetworkFusionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfigToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetApplicationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpAndSupportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ApplicationInfoToolStripMenuItem As ToolStripMenuItem
End Class
