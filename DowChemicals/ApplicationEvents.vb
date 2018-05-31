Imports Microsoft.VisualBasic.ApplicationServices

Namespace My
    ' The following events are available for MyApplication:
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication
        Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup
            If My.Settings.firstime Then
                My.Settings.firstime = False
                Instructions.Show()
            End If
            AppDomain.CurrentDomain.SetData("DataDirectory", My.Settings.dbpath)
        End Sub

        Private Sub MyApplication_UnhandledException(sender As Object, e As UnhandledExceptionEventArgs) Handles Me.UnhandledException
            MessageBox.Show(text:="A Fatal Error has occured" & Environment.NewLine & "Application will close now" & Environment.NewLine & "Please contact adminstrator", caption:="Error", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
            Environment.Exit(1)
        End Sub

        Private Sub MyApplication_StartupNextInstance(sender As Object, e As StartupNextInstanceEventArgs) Handles Me.StartupNextInstance
            Mainlogin.WindowState = FormWindowState.Normal
            MessageBox.Show(owner:=Mainlogin, text:="An Instance of the Application is already running", caption:="Error", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error, defaultButton:=MessageBoxDefaultButton.Button1)
            For Each frm In Application.OpenForms
                If frm.windowstate = FormWindowState.Minimized Then frm.windowstate = FormWindowState.Normal
            Next
        End Sub
    End Class
End Namespace
