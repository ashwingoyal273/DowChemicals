Public Class userchangepassword
    Dim cnn As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand

    Private Sub userchangepassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnn.ConnectionString = My.Settings.empConnectionString
    End Sub
End Class