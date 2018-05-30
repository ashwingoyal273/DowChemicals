Imports System.ComponentModel

Public Class AdminchangePassword
    Dim adminpass As String = My.Settings.pass
    Private Sub Btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        If txtold.Text = "" Or txtnew.Text = "" Or txtconfirm.Text = "" Then
            MessageBox.Show(text:="All fields have to be filled", caption:="Error", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
            Exit Sub
        End If
        If StrComp(txtold.Text, adminpass) <> 0 Then
            MessageBox.Show(text:="The Old Password Entered is Wrong", caption:="Error", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
            Exit Sub
        End If
        If StrComp(txtnew.Text, txtconfirm.Text) <> 0 Then
            MessageBox.Show(text:="New Passwords do not match", caption:="Error", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
            Exit Sub
        End If
        My.Settings.pass = txtconfirm.Text
        MessageBox.Show(text:="Admin Password Successfully changed", caption:=
                              "Success", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Asterisk)
        LoginForm3.Show()
        Me.Hide()
    End Sub

    Private Sub Btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        LoginForm3.Show()
        Me.Hide()
    End Sub

    Private Sub AdminchangePassword_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        adminpass = My.Settings.pass
        txtold.Text = ""
        txtnew.Text = ""
        txtconfirm.Text = ""
        txtold.Focus()
    End Sub

    Private Sub AdminchangePassword_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Form1.Show()
        Me.Hide()
    End Sub
End Class