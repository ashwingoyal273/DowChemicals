Public Class Instructions
    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        Me.Close()
    End Sub

    Private Sub Instructions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ActiveControl = lbltitle

    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        Dim prompt = MessageBox.Show(Me, "Are you sure you want to reset the database to the default state?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
        If prompt = DialogResult.OK Then

            Dim cnn As New OleDb.OleDbConnection
            Dim cmd As New OleDb.OleDbCommand
            cnn.ConnectionString = My.Settings.adminconnectionstring
            If Not cnn.State = ConnectionState.Open Then
                cnn.Open()
            End If
            cmd.Connection = cnn
            cmd.CommandText = "UPDATE adminpass SET [password] ='tulip123' WHERE [username] ='admin'"
            cmd.ExecuteNonQuery()
            cnn.Close()
            Dim prompt1 = MessageBox.Show(Me, "Do you want to reset all the path settings to default too?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
            If prompt1 = DialogResult.OK Then
                My.Settings.Reset()
            End If
        End If
    End Sub
End Class