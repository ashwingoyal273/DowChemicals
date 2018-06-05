
Public Class LoginForm1

    Dim username = My.Settings.adminusername
    Dim password = My.Settings.pass

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        password = My.Settings.pass
        If StrComp(txtusername.Text, username, vbBinaryCompare) = 0 And StrComp(txtpass.Text, password, vbBinaryCompare) = 0 Then
            LoginForm3.Show()
            Me.Hide()
        Else
            MessageBox.Show(Me, "The username or password entered is incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Mainlogin.Show()
        Me.Hide()
    End Sub
    Private Sub Close_form() Handles Me.Closing
        Mainlogin.Show()

    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtusername.Text = ""
        txtpass.Text = ""
    End Sub

    Private Sub LoginForm1_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        username = My.Settings.adminusername
        password = My.Settings.pass
        txtusername.Focus()
        txtusername.Text = ""
        txtpass.Text = ""

    End Sub

    Private Sub Btninstructions_Click(sender As Object, e As EventArgs) Handles Btninstructions.Click
        Instructions.Show()
    End Sub

End Class
