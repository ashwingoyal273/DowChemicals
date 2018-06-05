Imports System.ComponentModel

Public Class AdminchangePassword
    Dim cnn As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Private Sub Btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        If txtold.Text = "" Or txtnew.Text = "" Or txtconfirm.Text = "" Then
            MessageBox.Show(text:="All fields have to be filled", caption:="Error", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
            Exit Sub
        End If
        If Not cnn.State = ConnectionState.Open Then
            cnn.Open()
        End If
        cmd.Connection = cnn
        cmd.CommandText = "SELECT * FROM adminpass WHERE strcomp([username],'admin',0) = 0 AND strcomp([password],'" & txtold.Text & "',0) = 0"
        Dim flag As Boolean = False
        Using sda As New OleDb.OleDbDataAdapter(cmd)
            Using dt As New DataTable
                sda.Fill(dt)
                If dt.Rows.Count < 1 Then flag = True
            End Using
        End Using
        If flag = True Then
            LoginForm1.BackgroundWorker2.RunWorkerAsync()
            MessageBox.Show(text:="Username and Password combination is wrong", caption:="Error", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
            Exit Sub
        End If
        If StrComp(txtnew.Text, txtconfirm.Text) <> 0 Then
            LoginForm1.BackgroundWorker2.RunWorkerAsync()
            MessageBox.Show(text:="New Passwords do not match", caption:="Error", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
            Exit Sub
        End If
        cmd.CommandText = "UPDATE adminpass SET [password] ='" & txtconfirm.Text & "' WHERE [username] ='admin' AND [password] ='" & txtold.Text & "'"
        cmd.ExecuteNonQuery()
        cnn.Close()
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
        txtold.Text = ""
        txtnew.Text = ""
        txtconfirm.Text = ""
        txtold.Focus()
    End Sub

    Private Sub AdminchangePassword_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub AdminchangePassword_Load(sender As Object, e As EventArgs) Handles Me.Load
        cnn.ConnectionString = My.Settings.adminconnectionstring
    End Sub
End Class