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


        Dim textoPiePagina As Label = New Label With {.Text = "Esto es una prueba por leogatgens.", .Dock = DockStyle.Fill}

        Me.RadPanel1.Controls.Add(textoPiePagina)


        AddHandler textoPiePagina.Click, AddressOf DispararClickPiePagina

    End Sub

    Private Sub DispararClickPiePagina(sender As Object, e As EventArgs)
        RaiseEvent ClickEnPieDePagina(sender, e)
    End Sub
End Class
