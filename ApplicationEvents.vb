Namespace My
    ' Następujące zdarzenia są dostępne dla MyApplication:
    ' Startup: występuje podczas uruchamiania aplikacji, przed utworzeniem formularza początkowego.
    ' Shutdown: występuje po zamknięciu wszystkich formularzy aplikacji.  To zdarzenie nie jest wywoływane, jeśli aplikacja nieprawidłowo kończy działanie.
    ' UnhandledException: występuje, gdy aplikacja napotka nieobsługiwany wyjątek.
    ' StartupNextInstance: występuje podczas uruchamiania pojedynczego wystąpienia aplikacji i gdy aplikacja jest już aktywna. 
    ' NetworkAvailabilityChanged: występuje, gdy połączenie sieciowe jest połączone lub rozłączone.
    Partial Friend Class MyApplication
        Private Sub MyApplication_Startup(sender As Object, e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup

        End Sub
    End Class

End Namespace
