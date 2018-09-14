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

        Dim dgview As New DataGridView With {.Dock = DockStyle.Fill}
        RadPanel1.Controls.Add(dgview)
        dgview.Location = New Point(12, 12)
        dgview.Size = New Size(250, 250)

        dgview.ColumnCount = 5
        dgview.RowCount = 5

        AddHandler dgview.MouseClick, AddressOf DispararClickEnGrid
    End Sub

    Private Sub DispararClickEnGrid(sender As Object, e As EventArgs)
        RaiseEvent ClickEnGrid(sender, e)
    End Sub
End Class
