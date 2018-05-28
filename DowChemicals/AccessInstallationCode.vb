Imports System.ComponentModel
Imports System.Configuration.Install
Imports System.IO
<RunInstaller(True)>
Public Class AccessInstallationCode

    Dim AccessComponentFile As String = "AccessDatabaseEngine.exe"

    Public Sub New()

        MyBase.New()

        'This call is required by the Component Designer.
        InitializeComponent()

        'Add initialization code after the call to InitializeComponent

    End Sub

    Public Overrides Sub Install(ByVal stateSaver As IDictionary)

        MyBase.Install(stateSaver)

    End Sub

    Private Sub AccessInstallationCode_AfterInstall(ByVal sender As Object, ByVal e As System.Configuration.Install.InstallEventArgs) Handles Me.AfterInstall

        Dim str As String = System.Reflection.Assembly.GetExecutingAssembly().Location
        Dim ex As Exception
        Dim i As Integer = str.LastIndexOf("\"c)

        If AccessDatabaseEngineInstalled() Then
            Exit Sub
        End If

        Dim prc = New System.Diagnostics.Process()

        str = str.Substring(0, i)

        Try
            prc.StartInfo.FileName = str & "\" & AccessComponentFile
            'prc.StartInfo.Arguments = "/quiet"
            prc.Start()
            prc.EnableRaisingEvents = True
            AddHandler prc.Exited, New EventHandler(AddressOf Prc_Exited)

        Catch ex
            System.Windows.Forms.MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Prc_Exited(ByVal sender As Object, ByVal e As EventArgs)

        Dim str As String = System.Reflection.Assembly.GetExecutingAssembly().Location
        Dim ex As Exception

        Dim i As Integer = str.LastIndexOf("\"c)
        str = str.Substring(0, i)

        Dim FolderPath As String = str & "\" & AccessComponentFile

        If File.Exists(FolderPath) Then
            Try
                File.Delete(FolderPath) 'DONT DO THIS afterall!!! See my explanation in this thread below!
            Catch ex
                System.Windows.Forms.MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Function AccessDatabaseEngineInstalled() As Boolean

        Dim FileName1 As String 'Location Prior to Windows 7
        Dim FileName2 As String 'Location for Windows 7 (Not sure if this file location is for the 64bit version of Windows 7 only)

        FileName1 = "C:\Program Files\Common Files\microsoft shared\OFFICE12\ACECORE.DLL"
        FileName2 = "C:\Program Files (x86)\Common Files\microsoft shared\OFFICE12\ACECORE.DLL"

        If File.Exists(FileName1) Or File.Exists(FileName2) Then
            Return True
        Else
            Return False
        End If

    End Function

End Class