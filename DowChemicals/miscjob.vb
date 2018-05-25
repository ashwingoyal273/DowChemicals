Imports System.ComponentModel
Imports Microsoft.Office.Interop
Public Class miscjob

    Private Sub miscjob_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Me.lblusername.Text = "Username: " & Environment.NewLine & Mainlogin.empusername
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblTime.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        If txtName.Text = "" Then
            MessageBox.Show("Please enter the name of the RTM issuer", "Error", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
        ElseIf txtJob.Text = "" Then
            MessageBox.Show("Please enter the Job Scope", "Error", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
        ElseIf txtequipment.Text = "" Then
            MessageBox.Show("Please enter the equipment name", "Error", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
        ElseIf txtnooftags.Text = "" Then
            MessageBox.Show("Please enter the number of tags required", "Error", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
        ElseIf IsNumeric(txtnooftags.Text) = False Then
            MessageBox.Show("The Number of tags field can only be a number!", "Error", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
        Else

            ' Dim year As Integer = DateTime.Now.Date.Year
            Dim month As Integer = DateTime.Now.Date.Month
            Dim day As Integer = DateTime.Now.Date.Day
            Dim hour As Integer = DateTime.Now.TimeOfDay.Hours
            Dim min As Integer = DateTime.Now.TimeOfDay.Minutes
            Dim sec As Integer = DateTime.Now.TimeOfDay.Seconds
            ' year.ToString("D4") &
            Dim redtagmaster As String = month.ToString("D2") & day.ToString("D2") & hour.ToString("D2") & min.ToString("D2") & sec.ToString("D2")
            Dim jobscope As String = txtJob.Text
            Dim oWord As Word.Application
            Dim oDoc As Word.Document
            Dim opath As String = My.Settings.rtmpath
            oWord = CreateObject("Word.Application")
            oDoc = oWord.Documents.Add(opath & "0605_IOES_LocationListingRTM" & ".docx")
            oWord.Visible = True

            With oDoc.Tables.Item(1).Cell(3, 1).Range
                .Text &= redtagmaster
                .Font.Size = 9
                .ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
            End With
            With oDoc.Tables.Item(1).Cell(3, 2).Range
                .Text &= DateString
                .ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
            End With
            With oDoc.Tables.Item(1).Cell(4, 2).Range
                .Text = "SCOPE OF WORK And REASON(S) WHY WORK Is BEING DONE: " & Environment.NewLine & jobscope
                .ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
            End With
            With oDoc.Tables.Item(1).Cell(5, 1).Range
                .Text &= txtName.Text
                .ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
            End With

            Dim ctr As Integer = txtnooftags.Text
            For i = 1 To ctr
                With oDoc.Tables.Item(1).Cell(7 + i, 1).Range
                    .Text = redtagmaster & "A" & i
                    .Font.Size = 9
                    .ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
                End With
            Next
            System.IO.Directory.CreateDirectory(My.Settings.savepath & DateString & "\")
            oDoc.Application.ActiveDocument.SaveAs(My.Settings.savepath & DateString & "\" & jobscope & " Location Listing" & ".docx")
            Dim equipment As String = txtequipment.Text
            Dim oDoc1 As Word.Document
            oDoc1 = oWord.Documents.Add(opath & "RTM master file" & ".docx")
            With oDoc1.Tables.Item(1).Cell(1, 2).Range
                .Text = redtagmaster
                .ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
            End With
            With oDoc1.Tables.Item(2).Cell(1, 1).Range
                .Text &= ctr
                .ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
            End With
            With oDoc1.Tables.Item(2).Cell(1, 2).Range
                .Text &= equipment
                .ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
            End With
            With oDoc1.Tables.Item(2).Cell(2, 1).Range
                .Text &= jobscope
                .ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
            End With
            With oDoc1.Tables.Item(2).Cell(5, 1).Range
                .Text &= jobscope
                .ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
            End With
            With oDoc1.Tables.Item(2).Cell(18, 1).Range
                .Text &= txtName.Text
                .ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
            End With
            With oDoc1.Tables.Item(2).Cell(18, 2).Range
                .Text &= DateString
                .ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
            End With
            oDoc1.Application.ActiveDocument.SaveAs(My.Settings.savepath & DateString & "\" & jobscope & " RTM file" & ".docx")
        End If
    End Sub

    Private Sub miscjob_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Exit()
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub miscjob_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        Me.lblusername.Text = "Username: " & Environment.NewLine & Mainlogin.empusername
    End Sub
End Class