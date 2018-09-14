
Imports MenuPrincipal.Clases
    Imports System.Globalization
    Imports System.Threading
    Imports Telerik.WinControls

    NotInheritable Class Program

        Private Sub New()

        End Sub

        <STAThread()>
        Public Shared Sub Main()
            '  Evento para el manejo de exepciones de hilos UI.
            AddHandler Application.ThreadException, AddressOf ManejeLaExcepcionDeHilosEnInterfaz

            'Activa el modo para que todas las excepciones de windows forms pase atravez el evento
            'definido
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException)

            ' Evento para el manejo de exepciones de hilos non-UI.
            AddHandler AppDomain.CurrentDomain.UnhandledException, AddressOf ManejeLaExcepcionDeHilosQueNoSonDeInterfaz

            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)

        Try


                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US")


            Using vistaInicial = New Vista()
                Using presenter = New VistaPresenter(vistaInicial)


                    Application.Run(vistaInicial)
                End Using

            End Using

        Catch ex As Exception



            RadMessageBox.Show("Error", "Error", MessageBoxButtons.OK,
                               RadMessageIcon.Error)

            Application.Exit()
            End Try
            'Application.Run(prueba)
        End Sub

        Private Shared Sub ManejeLaExcepcionDeHilosEnInterfaz(ByVal invocador As Object,
                                                          ByVal eventos As ThreadExceptionEventArgs)


        RadMessageBox.Show("Error", "Advertencia", MessageBoxButtons.OK,
                           RadMessageIcon.Exclamation)
    End Sub

        Private Shared Sub ManejeLaExcepcionDeHilosQueNoSonDeInterfaz(ByVal invocador As Object,
                                                                  ByVal eventos As UnhandledExceptionEventArgs)


        RadMessageBox.Show("Falolo", "Error", MessageBoxButtons.OK, RadMessageIcon.Error)
    End Sub
    End Class






