Public Class Instructions
    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        Me.Close()
    End Sub

    Private Sub Instructions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ActiveControl = lbltitle

    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        Dim prompt = MessageBox.Show(Me, "Are you sure you want to reset all the settings to their default state?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
        If prompt = DialogResult.OK Then
            My.Settings.Reset()
        End If
    End Sub
End Class