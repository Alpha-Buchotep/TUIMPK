Namespace My
    ' The following events are available for MyApplication:
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication

        Public startVagyStop As Integer
        'Private Sub MyApplication_Startup(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup
        '    '--------------------------------------------------------------------------------------
        '    '--------------------------------------------------------------------------------------
        '    '--------------------------------------------------------------------------------------
        'End Sub

        Private Sub MyApplication_UnhandledException(sender As Object, e As Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs) Handles Me.UnhandledException
            MessageBox.Show("So sorry, but unhandled exception occured." & vbCrLf & vbCrLf & "You can try to delete application settings folder and restart app." & vbCrLf & vbCrLf & "App settings folder: C:\Users\username\AppcData\Local\C2H5Cl_-_Aethyl-chloride\TCPUDPMultiPortKnocker" & vbCrLf & vbCrLf & "Error message: " & vbCrLf & vbCrLf & e.Exception.Message.ToString, "Oops! Unhandled exception!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Sub
        '--------------------------------------------------------------------------------------
        Private Sub MyApplication_NetworkAvailabilityChanged(sender As Object, e As Microsoft.VisualBasic.Devices.NetworkAvailableEventArgs) Handles Me.NetworkAvailabilityChanged
            If My.Computer.Network.IsAvailable = False Then
                frmPortKnocker.ttStatus.Text = "No available network"
            ElseIf My.Computer.Network.IsAvailable = True Then
                frmPortKnocker.ttStatus.Text = "Network Available"
            End If
        End Sub
        '--------------------------------------------------------------------------------------
    End Class

End Namespace
