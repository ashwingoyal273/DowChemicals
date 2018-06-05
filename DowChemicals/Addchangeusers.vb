Imports System.ComponentModel
Public Class Addchangeusers
    Dim cnn As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Private Sub Addchangeusers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnn.ConnectionString = My.Settings.empConnectionString
        'TODO: This line of code loads data into the 'EmpDataSet.employee' table. You can move, or remove it, as needed.
        Update_display()
    End Sub

    Private Sub Update_display()

        Try

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
            cnn.Close()
        Catch ex As OleDb.OleDbException
            MessageBox.Show("COULD NOT CONNECT TO DATABASE" & Environment.NewLine & ex.Message, "Error", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
            Me.Close()
        End Try
    End Sub

    Private Sub BtnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        cnn.Close()
        LoginForm3.Show()
        Me.Hide()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtusername.Text = "" Or txtpass.Text = "" Or txtconfirm.Text = "" Then
            MessageBox.Show(text:="Username and password cannot be empty!", caption:="Error", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
        ElseIf StrComp(txtconfirm.Text, txtpass.Text, vbBinaryCompare) <> 0 Then
            MessageBox.Show(Me, text:="Passwords do not match!", caption:="Error", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
        Else
            If Not cnn.State = ConnectionState.Open Then
                cnn.Open()
            End If
            cmd.Connection = cnn
            Try
                cmd.CommandText = "INSERT INTO employee([username], [password]) " & " VALUES ('" & Me.txtusername.Text & "','" & Me.txtpass.Text & "')"
                cmd.ExecuteNonQuery()
            Catch ex As System.Data.OleDb.OleDbException
                Mainlogin.BackgroundWorker1.RunWorkerAsync()
                MessageBox.Show(text:="Error occured in insertion please check if the username already exists in the database", caption:="Error", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
            End Try
            Update_display()
            MessageBox.Show(Me, "User Successfully added into the database", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
        txtusername.Text = ""
        txtpass.Text = ""
        txtconfirm.Text = ""
        cnn.Close()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtusername.Text = "" Then
            MessageBox.Show(text:="Username cannot be empty while deletion!", caption:="Error", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
        Else

            If Not cnn.State = ConnectionState.Open Then
                cnn.Open()
            End If
            cmd.Connection = cnn
            Try
                cmd.CommandText = "DELETE FROM employee where strcomp([username],'" & txtusername.Text & "',0) = 0"
                cmd.ExecuteNonQuery()
            Catch ex As System.Data.OleDb.OleDbException
                Mainlogin.BackgroundWorker1.RunWorkerAsync()
                MessageBox.Show(text:="Error occured in deletion please check if the username is in the database", caption:="Error", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
            End Try
            Update_display()
            MessageBox.Show(Me, "User Successfully deleted from the database!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
        txtusername.Text = ""
        cnn.Close()
    End Sub

    Private Sub Btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtpass.Text = ""
        txtusername.Text = ""
        txtconfirm.Text = ""
    End Sub

    Private Sub Addchangeusers_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        LoginForm3.Show()
        cnn.Close()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        txtusername.Text = DataGridView1.CurrentCell.Value.ToString
        txtpass.Text = ""
        txtconfirm.Text = ""
    End Sub
End Class