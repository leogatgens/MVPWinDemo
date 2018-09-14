Imports MVPWindowsDemo

Public Class GridConMenu
    Implements IGridConMenu

    Public Event ClickEnMenuDelGrid As EventHandler Implements IGridConMenu.ClickEnMenuDelGrid
    Public Event ClickEnGrid As EventHandler Implements IGridConMenu.ClickEnGrid

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.RadPanel1.BackColor = Color.Beige
    End Sub

End Class
