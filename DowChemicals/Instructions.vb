Public Class Instructions
    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        Me.Close()
    End Sub

    Private Sub Instructions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ActiveControl = lbltitle

    End Sub
End Class