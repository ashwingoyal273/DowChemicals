Imports System.ComponentModel

Public Class Mainlogin
    Dim cnn As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Public empusername As String = ""

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If Not cnn.State = ConnectionState.Open Then
            cnn.Open()
        End If
        cmd.Connection = cnn
        cmd.CommandText = "SELECT * FROM employee WHERE [username]='" & Me.txtusername.Text & "' AND [password]='" & Me.txtpass.Text & "'"
        Using da As New OleDb.OleDbDataAdapter(cmd)
            Using dt As New DataTable
                da.Fill(dt)
                If dt.Rows.Count > 0 Then
                    empusername = txtusername.Text
                    Form1.Form1_Load(Me, Nothing)
                    Form1.Show()
                    cnn.Close()
                    Me.Hide()
                Else
                    MessageBox.Show("The username or password entered is incorrect!", "Error", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
                    cnn.Close()
                End If
            End Using
        End Using
    End Sub


    Private Sub Load_form() Handles Me.Load
        cnn.ConnectionString = My.Settings.empConnectionString
    End Sub

    Private Sub Mainlogin_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Exit()
    End Sub

    Private Sub ForgotPassword_click(sender As Object, e As EventArgs) Handles btnFp.Click
        MessageBox.Show(Me, "Please contact your adminstator", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Sub

    Private Sub AdminLogin_Click(sender As Object, e As EventArgs) Handles btnadminlogin.Click
        cnn.Close()
        Me.Hide()
        LoginForm1.Show()

    End Sub

    Private Sub Mainlogin_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        cnn.ConnectionString = My.Settings.empConnectionString
        txtusername.Text = ""
        txtpass.Text = ""
        txtusername.Focus()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub
End Class
