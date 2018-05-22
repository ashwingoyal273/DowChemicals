Imports System.ComponentModel
Public Class Addchangeusers
    Dim cnn As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Private Sub Addchangeusers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnn.ConnectionString = My.Settings.empConnectionString
        'TODO: This line of code loads data into the 'EmpDataSet.employee' table. You can move, or remove it, as needed.
        update_display()
    End Sub

    Private Sub update_display()


        If Not cnn.State = ConnectionState.Open Then
            cnn.Open()
        End If
        cmd.Connection = cnn
        cmd.CommandText = "SELECT [username] FROM employee"
        Using sda As New OleDb.OleDbDataAdapter(cmd)
            Using dt As New DataTable
                sda.Fill(dt)
                DataGridView1.ReadOnly = True
                DataGridView1.AutoResizeColumns()
                DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                DataGridView1.DataSource = dt
            End Using

        End Using
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        cnn.Close()
        LoginForm3.Show()
        Me.Hide()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtusername.Text = "" Or txtpass.Text = "" Then
            MessageBox.Show(text:="Username and password cannot be empty!", caption:="Error", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
        Else

            If Not cnn.State = ConnectionState.Open Then
                cnn.Open()
            End If
            cmd.Connection = cnn
            Try
                cmd.CommandText = "INSERT INTO employee([username], [password]) " & " VALUES ('" & Me.txtusername.Text & "','" & Me.txtpass.Text & "')"
                cmd.ExecuteNonQuery()
            Catch ex As System.Data.OleDb.OleDbException
                MessageBox.Show(text:="Error occured in insertion please check if the username already exists in the database", caption:="Error", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
            End Try
            update_display()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtusername.Text = "" Then
            MessageBox.Show(text:="Username cannot be empty while deletion!", caption:="Error", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
        Else
            If Not cnn.State = ConnectionState.Open Then
                cnn.Open()
            End If
            cmd.Connection = cnn
            Try
                cmd.CommandText = "DELETE FROM employee where [username] = '" & txtusername.Text & "'"
                cmd.ExecuteNonQuery()
            Catch ex As System.Data.OleDb.OleDbException
                MessageBox.Show(text:="Error occured in deletion please check if the username is in the database", caption:="Error", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
            End Try
            update_display()
        End If
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtpass.Text = ""
        txtusername.Text = ""
    End Sub

    Private Sub Addchangeusers_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        LoginForm3.Show()
        cnn.Close()
    End Sub
End Class