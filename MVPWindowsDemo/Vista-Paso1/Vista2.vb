Imports MVPWindowsDemo

Public Class Vista2
    Implements IVista2



    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        AddHandler Me.Load, AddressOf DispararEventoLoad
    End Sub

    Public Event MostrarMensajeBienvenida As EventHandler Implements IVista2.MostrarMensajeBienvenida

    Private Sub DispararEventoLoad(sender As Object, e As EventArgs)
        RaiseEvent MostrarMensajeBienvenida(sender, e)
    End Sub
End Class