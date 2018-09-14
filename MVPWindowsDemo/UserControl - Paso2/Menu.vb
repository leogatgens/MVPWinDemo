Imports MVPWindowsDemo

Public Class Menu
    Implements IMenu

    Public Event ClickOpcionMenu As EventHandler Implements IMenu.ClickOpcionMenu

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.RadPanel1.BackColor = Color.BlueViolet

        Dim menu As MenuStrip = New MenuStrip()
        menu.Items.Add(New ToolStripMenuItem With {.Name = "HOla", .Text = "Archivo"})
        Me.RadPanel1.Controls.Add(menu)
        AddHandler menu.Click, AddressOf DispararClickOpcionMenu


    End Sub

    Private Sub DispararClickOpcionMenu(sender As Object, e As EventArgs)
        RaiseEvent ClickOpcionMenu(sender, e)

    End Sub
End Class
