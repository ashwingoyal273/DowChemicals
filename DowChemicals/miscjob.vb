Imports System.ComponentModel
Imports Microsoft.Office.Interop
Public Class miscjob

    Private Sub Miscjob_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Me.lblusername.Text = "Username: " & Environment.NewLine & Mainlogin.empusername
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblTime.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub

    Private Sub BtnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
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
            Dim objapp As Excel.Application = Nothing
            Dim objbook As Excel._Workbook = Nothing
            Dim objsheet As Excel._Worksheet = Nothing
            Dim rng As Excel.Range = Nothing
            Dim opath As String = My.Settings.rtmpath
            Dim ctr As Integer = txtnooftags.Text
            Dim prompt = MessageBox.Show(Me, "Please input the Location listings one by one in the subsequent Input Boxes", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
            If prompt = DialogResult.OK Then
                Dim locationlisting(100) As String
                For i = 1 To ctr
                    locationlisting(i - 1) = InputBox("Please input the LOCATION LISTING NUMBER " & i, "LOCATION LISTING " & i)
                Next
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


                For i = 1 To ctr
                    With oDoc.Tables.Item(1).Cell(7 + i, 2).Range
                        .Text = locationlisting(i - 1)
                        .Font.Size = 10
                        .ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
                    End With
                    With oDoc.Tables.Item(1).Cell(7 + i, 1).Range
                        .Text = redtagmaster & "A" & i
                        .Font.Size = 9
                        .ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
                    End With
                Next
                Try
                    System.IO.Directory.CreateDirectory(My.Settings.savepath & Mainlogin.empusername & " " & DateString & "\")
                    oDoc.Application.ActiveDocument.SaveAs(My.Settings.savepath & Mainlogin.empusername & " " & DateString & "\" & jobscope & " Location Listing" & ".docx")
                Catch ex As Exception
                    MessageBox.Show(Me, "The RTM FILES could not be saved!" & Environment.NewLine & "Please check if the save path exists: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    oDoc.ActiveWindow.Close()
                    oWord.Quit()
                    Exit Sub
                End Try

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
                Try
                    oDoc1.Application.ActiveDocument.SaveAs(My.Settings.savepath & Mainlogin.empusername & " " & DateString & "\" & jobscope & " RTM file" & ".docx")
                Catch ex As Exception
                    MessageBox.Show(Me, "The RTM FILES could not be saved!" & Environment.NewLine & "Please check if the save path exists: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    oDoc.ActiveWindow.Close()
                    oWord.Quit()
                    Exit Sub
                End Try


                prompt = MessageBox.Show(Me, "Please Review the RTM MASTER FILE and the RTM LOCATION LISTING FILE" & Environment.NewLine & "Prints will be generated as soon as you click OK", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
                If prompt = DialogResult.OK Then
                    Try
                        objapp = CreateObject("Excel.Application")
                        objbook = objapp.Workbooks.Add(Environment.CurrentDirectory.ToString & "\Tag.xlsx")
                        objsheet = objbook.Sheets.Item(1)
                        objapp.Visible = True
                    Catch ex As Exception
                        MessageBox.Show(Me, "The Excel Template for the Red Tag Printing could not be opened" & Environment.NewLine & "Please check if the file exists " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        objbook.Close(False)
                        objapp.Quit()
                        oDoc.ActiveWindow.Close()
                        oWord.Quit()
                        GC.Collect()
                        GC.WaitForPendingFinalizers()
                        Exit Sub
                    End Try
                    For i = 2 To ctr + 1
                        rng = objsheet.Range("A7")
                        rng.Value2 = jobscope
                        rng = objsheet.Range("B18")
                        rng.Value2 = txtName.Text
                        rng = objsheet.Range("B19")
                        rng.Value2 = redtagmaster
                        rng = objsheet.Range("A22")
                        rng.Value2 = locationlisting(i - 2)
                        rng = objsheet.Range("B27")
                        rng.Value2 = redtagmaster & "A" & i - 1
                        objsheet.PrintOutEx()
                    Next
                    objbook.Close(False)
                    objapp.Quit()
                    GC.Collect()
                    GC.WaitForPendingFinalizers()
                    Me.TopMost = True
                    MessageBox.Show(Me, "Please collect the Print Outs", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If
            End If
        End If
    End Sub

    Private Sub Miscjob_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Exit()
    End Sub

    Private Sub Btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Miscjob_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        Me.lblusername.Text = "Username: " & Environment.NewLine & Mainlogin.empusername
        txtName.Text = ""
        txtnooftags.Text = ""
        txtJob.Text = ""
        txtequipment.Text = ""
        txtName.Focus()
    End Sub
End Class