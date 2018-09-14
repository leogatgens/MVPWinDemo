Imports MVPWindowsDemo

Public Class Vista
    Implements IVista

    Public ReadOnly Property MenuEnVista As IMenu Implements IVista.MenuEnVista


    Public ReadOnly Property GridConMenuEnVista As IGridConMenu Implements IVista.GridConMenuEnVista


    Public ReadOnly Property PieEnVista As IPiePagina Implements IVista.PieEnVista


    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'Inicializa los controles que va utilizar la vista
        MenuEnVista = New Menu() With {.Dock = DockStyle.Fill}
        GridConMenuEnVista = New GridConMenu() With {.Dock = DockStyle.Fill}
        PieEnVista = New PiePagina() With {.Dock = DockStyle.Fill}

        'Ingresar los controles en el lugar deseado de la vista
        Me.RadPanel4.Controls.Add(PieEnVista)
        Me.RadPanel5.Controls.Add(GridConMenuEnVista)
        Me.RadPanel2.Controls.Add(MenuEnVista)
    End Sub
End Class
