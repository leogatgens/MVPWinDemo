Public Class VistaPresenter
    Implements IDisposable

    Private ReadOnly Contenido As IGridConMenu
    Private ReadOnly Menu As IMenu
    Private ReadOnly Piepagina As IPiePagina

    Sub New(ByVal Vista As IVista)
        Try

            Menu = Vista.MenuEnVista
            Contenido = Vista.GridConMenuEnVista
            Piepagina = Vista.PieEnVista


            AddHandler Menu.ClickOpcionMenu, AddressOf ManejarClickOpcionMenu
            AddHandler Contenido.ClickEnGrid, AddressOf ManejarClickEnGrid
            AddHandler Piepagina.ClickEnPieDePagina, AddressOf ManejarClickEnPieDePagina



        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub

    Private Sub ManejarClickEnPieDePagina(sender As Object, e As EventArgs)
        MsgBox("Click en Pie de pagina")
    End Sub

    Private Sub ManejarClickEnGrid(sender As Object, e As EventArgs)
        MsgBox("Click en grid")
    End Sub

    Private Sub ManejarClickOpcionMenu(sender As Object, e As EventArgs)
        Dim formualarioVista2 As Form = Application.OpenForms("Vista2")

        If formualarioVista2 Is Nothing Then
            Dim vistaPorMostrar As Vista2 = New Vista2()

            Try
                Using presentacion = New Vista2Presenter(vistaPorMostrar)
                    vistaPorMostrar.ShowDialog()

                End Using
            Catch excepcion As Exception
                vistaPorMostrar.Close()
            End Try
        End If

    End Sub

#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                ' TODO: dispose managed state (managed objects).
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
            ' TODO: set large fields to null.
        End If
        disposedValue = True
    End Sub

    ' TODO: override Finalize() only if Dispose(disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
        Dispose(True)
        ' TODO: uncomment the following line if Finalize() is overridden above.
        ' GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class

