
Imports System.ComponentModel

Public Class LoginForm1
    Dim cnn As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            If Not cnn.State = ConnectionState.Open Then
                cnn.Open()
            End If
            cmd.Connection = cnn
            cmd.CommandText = "SELECT * FROM adminpass WHERE strcomp([username],'" & Me.txtusername.Text & "',0) = 0 AND strcomp([password],'" & Me.txtpass.Text & "',0) = 0"
            Using da As New OleDb.OleDbDataAdapter(cmd)
                Using dt As New DataTable
                    da.Fill(dt)
                    If dt.Rows.Count > 0 Then
                        LoginForm3.Show()
                        cnn.Close()
                        Me.Hide()
                    Else
                        BackgroundWorker2.RunWorkerAsync()
                        MessageBox.Show("The username or password entered is incorrect!", "Error", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)

                    End If
                End Using
            End Using
        Catch ex As OleDb.OleDbException
            MessageBox.Show("COULD NOT CONNECT TO DATABASE" & Environment.NewLine & ex.Message, "Error", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Mainlogin.Show()
        Me.Hide()
    End Sub
    Private Sub Close_form() Handles Me.Closing
        Mainlogin.Show()

    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnn.ConnectionString = My.Settings.adminconnectionstring
        txtusername.Text = ""
        txtpass.Text = ""
    End Sub

    Private Sub LoginForm1_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        cnn.ConnectionString = My.Settings.adminconnectionstring
        txtusername.Focus()
        txtusername.Text = ""
        txtpass.Text = ""

    End Sub

    Private Sub Btninstructions_Click(sender As Object, e As EventArgs) Handles Btninstructions.Click
        Instructions.Show()
    End Sub

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        If cnn.State = ConnectionState.Open Then cnn.Close()
    End Sub
End Class
