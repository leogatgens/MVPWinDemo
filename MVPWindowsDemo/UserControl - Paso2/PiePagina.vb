Imports MVPWindowsDemo

Public Class PiePagina
    Implements IPiePagina

    Public Event ClickEnPieDePagina As EventHandler Implements IPiePagina.ClickEnPieDePagina
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.RadPanel1.BackColor = Color.Aqua
        Me.RadPanel1.Dock = DockStyle.Fill

    End Sub
End Class
