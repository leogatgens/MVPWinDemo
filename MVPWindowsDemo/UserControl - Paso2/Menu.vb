Imports MVPWindowsDemo

Public Class Menu
    Implements IMenu

    Public Event ClickOpcionMenu As EventHandler Implements IMenu.ClickOpcionMenu

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.RadPanel1.BackColor = Color.BlueViolet
    End Sub
End Class
