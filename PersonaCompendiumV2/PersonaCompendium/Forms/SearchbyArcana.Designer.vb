<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchbyArcana
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
        Me.ArcLblBx = New System.Windows.Forms.Label()
        Me.ShowArcanaBox = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DoArcSearch = New System.Windows.Forms.Button()
        Me.ArcanaQuery = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ArcLblBx
        '
        Me.ArcLblBx.AutoSize = True
        Me.ArcLblBx.Location = New System.Drawing.Point(98, 107)
        Me.ArcLblBx.Name = "ArcLblBx"
        Me.ArcLblBx.Size = New System.Drawing.Size(84, 13)
        Me.ArcLblBx.TabIndex = 9
        Me.ArcLblBx.Text = "Persona Results"
        '
        'ShowArcanaBox
        '
        Me.ShowArcanaBox.FormattingEnabled = True
        Me.ShowArcanaBox.Location = New System.Drawing.Point(13, 123)
        Me.ShowArcanaBox.Name = "ShowArcanaBox"
        Me.ShowArcanaBox.Size = New System.Drawing.Size(272, 160)
        Me.ShowArcanaBox.TabIndex = 8
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(18, -23)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(243, 20)
        Me.TextBox1.TabIndex = 7
        Me.TextBox1.Text = "Enter the Arcana you wish to view Personas for"
        '
        'DoArcSearch
        '
        Me.DoArcSearch.Location = New System.Drawing.Point(74, 59)
        Me.DoArcSearch.Name = "DoArcSearch"
        Me.DoArcSearch.Size = New System.Drawing.Size(134, 29)
        Me.DoArcSearch.TabIndex = 6
        Me.DoArcSearch.Text = "Search"
        Me.DoArcSearch.UseVisualStyleBackColor = True
        '
        'ArcanaQuery
        '
        Me.ArcanaQuery.Location = New System.Drawing.Point(25, 24)
        Me.ArcanaQuery.Name = "ArcanaQuery"
        Me.ArcanaQuery.Size = New System.Drawing.Size(260, 29)
        Me.ArcanaQuery.TabIndex = 5
        Me.ArcanaQuery.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(113, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Enter Arcana"
        '
        'SearchbyArcana
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(297, 298)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ArcLblBx)
        Me.Controls.Add(Me.ShowArcanaBox)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DoArcSearch)
        Me.Controls.Add(Me.ArcanaQuery)
        Me.Name = "SearchbyArcana"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SearchbyArcana"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ArcLblBx As Label
    Friend WithEvents ShowArcanaBox As ListBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DoArcSearch As Button
    Friend WithEvents ArcanaQuery As RichTextBox
    Friend WithEvents Label1 As Label
End Class
