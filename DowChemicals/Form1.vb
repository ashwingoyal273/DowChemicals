Imports System.ComponentModel
Imports System.IO
Imports Microsoft.Office.Interop
Public Class Form1
    Dim opath As String = My.Settings.rtmpath
    Private Sub BtnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        If txtName.Text = "" Then
            MessageBox.Show("Please enter the name of the RTM issuer", "Error", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
        ElseIf cbxScope.SelectedItem = "" Then
            MessageBox.Show("Please select the Job Scope", "Error", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
        Else
            Dim jobscope As String = cbxScope.SelectedItem
            jobscope = jobscope.Insert(0, "RTM for ")
            ' Dim year As Integer = DateTime.Now.Date.Year
            Dim month As Integer = DateTime.Now.Date.Month
            Dim day As Integer = DateTime.Now.Date.Day
            Dim hour As Integer = DateTime.Now.TimeOfDay.Hours
            Dim min As Integer = DateTime.Now.TimeOfDay.Minutes
            Dim sec As Integer = DateTime.Now.TimeOfDay.Seconds
            ' year.ToString("D4") &
            Dim redtagmaster As String = month.ToString("D2") & day.ToString("D2") & hour.ToString("D2") & min.ToString("D2") & sec.ToString("D2")
            Dim oWord As Word.Application
            Dim oDoc As Word.Document
            Dim oDoc1 As Word.Document = Nothing
            Dim opath1 As String = My.Settings.rtmpath
            'If StrComp(cbxarea.SelectedItem, "Production") = 0 Then
            '    opath &= "Production\"
            '    If StrComp(cbxsubarea.SelectedItem, "T1") = 0 Then
            '        opath &= "T1\"
            '    ElseIf StrComp(cbxsubarea.SelectedItem, "T2") = 0 Then
            '        opath &= "T2\"
            '    ElseIf StrComp(cbxsubarea.SelectedItem, "PE") = 0 Then
            '        opath &= "PE\"
            '    ElseIf StrComp(cbxsubarea.SelectedItem, "PU") = 0 Then
            '        opath &= "PU\"
            '    End If

            Dim ofilename As String = jobscope
            Dim ctr As Integer = 1
            oWord = Nothing
            oDoc = Nothing
            Try
                oWord = CreateObject("Word.Application")
                oDoc = oWord.Documents.Add(opath & ofilename & ".docx")
                oWord.Visible = True
                jobscope = jobscope.Replace("RTM for ", "")
            Catch ex As Exception
                MessageBox.Show(Me, "Error opening the RTM file:" & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Try
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


                Dim n As String = oDoc.Tables.Item(1).Cell(7 + ctr, 2).Range.Text
                n = Mid(n, 1, Len(n) - 1)
                Do Until String.IsNullOrEmpty(n) = True Or String.IsNullOrWhiteSpace(n) = True
                    ctr += 1
                    n = oDoc.Tables.Item(1).Cell(7 + ctr, 2).Range.Text
                    n = Mid(n, 1, Len(n) - 1)

                Loop
                ctr -= 1
                For i = 1 To ctr
                    With oDoc.Tables.Item(1).Cell(7 + i, 1).Range
                        .Text = redtagmaster & "A" & i
                        .Font.Size = 9
                        .ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
                    End With
                Next
            Catch ex As Exception
                oDoc.ActiveWindow.Close()
                oWord.Quit()
                MessageBox.Show(Me, "Error in the structure of the RTM Location listing file:" & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Form1_Load(Me, Nothing)
                Exit Sub
            End Try

            System.IO.Directory.CreateDirectory(My.Settings.savepath & Mainlogin.UsernameLabel.Text & " " & DateString & "\")
            oDoc.Application.ActiveDocument.SaveAs(My.Settings.savepath & Mainlogin.UsernameLabel.Text & " " & DateString & "\" & ofilename & " Location Listing" & ".docx")
            Dim equipment As String = "Please fill manually"
                For Each eqp As String In My.Settings.equipment
                    If ofilename.IndexOf(eqp) <> -1 Then
                        If StrComp("Please fill manually", equipment) = 0 Then
                            equipment = ""
                        End If
                        equipment &= eqp & " "
                    End If
                Next
            Try
                oDoc1 = oWord.Documents.Add(opath1 & "RTM master file" & ".docx")
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

            Catch ex As Exception
                oDoc.ActiveWindow.Close()
                oWord.Quit()
                MessageBox.Show(Me, "Error in the structure of the RTM master file:" & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Form1_Load(Me, Nothing)
                Exit Sub
            End Try
            oDoc1.Application.ActiveDocument.SaveAs(My.Settings.savepath & Mainlogin.UsernameLabel.Text & " " & DateString & "\" & ofilename & " RTM file" & ".docx")
            'oDoc.Close(Word.WdSaveOptions.wdDoNotSaveChanges)



        End If

    End Sub
    Public Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        Me.lblusername.Text = "Username: " & Environment.NewLine & Mainlogin.empusername
        cbxsubarea.Enabled = False
        cbxScope.Items.Clear()

    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblTime.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub


    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Exit()
    End Sub

    Private Sub Btnmisc_Click(sender As Object, e As EventArgs) Handles btnmisc.Click
        miscjob.Show()
        Me.Hide()

    End Sub

    Private Sub Cleardropdown()
        cbxScope.Text = String.Empty
        cbxScope.Items.Clear()
        cbxScope.SelectedIndex = -1
        cbxScope.DropDownHeight = 106
        cbxScope.IntegralHeight = False
    End Sub

    Private Sub Cbxarea_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxarea.SelectedIndexChanged
        opath = My.Settings.rtmpath
        Cleardropdown()
        If StrComp(cbxarea.SelectedItem, "Production") = 0 Then
            cbxsubarea.Enabled = True
            opath &= "Production\"
        Else
            cbxsubarea.Enabled = False

            If StrComp(cbxarea.SelectedItem, "Utility") = 0 Then
                opath &= "Utilities\"

            ElseIf StrComp(cbxarea.SelectedItem, "Logistics") = 0 Then
                opath &= "Logistics\"

            ElseIf StrComp(cbxarea.SelectedItem, "Maintainance") = 0 Then
                opath &= "Maintainance\"
                Dim filename As String
                Dim FileLocation As DirectoryInfo = New DirectoryInfo(opath)
                For Each File In FileLocation.GetFiles()
                    filename = File.ToString
                    If (File IsNot Nothing) Then
                        If (Path.GetExtension(File.ToString.ToLower) = ".docx") Then
                            If (File.ToString.ToLower.Contains("rtm for")) Then
                                filename = filename.Replace("RTM for ", "")
                                filename = filename.Replace(".docx", "")
                                cbxScope.Items.Add(filename)
                            End If
                        End If
                    End If
                Next
                cbxScope.IntegralHeight = True
            End If



        End If
    End Sub

    Private Sub Cbxsubarea_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxsubarea.SelectedIndexChanged
        Cleardropdown()
        opath = My.Settings.rtmpath & "Production\"
        If StrComp(cbxsubarea.SelectedItem, "T1") = 0 Then
            opath &= "T1\"
        ElseIf StrComp(cbxsubarea.SelectedItem, "T2") = 0 Then
            opath &= "T2\"
        ElseIf StrComp(cbxsubarea.SelectedItem, "PE") = 0 Then
            opath &= "PE\"
        ElseIf StrComp(cbxsubarea.SelectedItem, "PU") = 0 Then
            opath &= "PU\"
        End If
        Dim filename As String
        Dim FileLocation As DirectoryInfo = New DirectoryInfo(opath)
        For Each File In FileLocation.GetFiles()
            filename = File.ToString
            If (File IsNot Nothing) Then
                If (Path.GetExtension(File.ToString.ToLower) = ".docx") Then
                    If (File.ToString.ToLower.Contains("rtm for")) Then
                        filename = filename.Replace("RTM for ", "")
                        filename = filename.Replace(".docx", "")
                        cbxScope.Items.Add(filename)
                    End If
                End If
            End If
        Next
        cbxScope.IntegralHeight = True
    End Sub

    Private Sub Btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Mainlogin.Show()
        Me.Hide()
    End Sub

    Private Sub Btnchngpass_Click(sender As Object, e As EventArgs) Handles btnchngpass.Click
        Userchangepassword.Show()
        Me.Hide()
    End Sub

    Private Sub Form1_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        Me.lblusername.Text = "Username: " & Environment.NewLine & Mainlogin.empusername
        txtName.Text = ""
    End Sub

    Private Sub Btninstructions_Click(sender As Object, e As EventArgs) Handles Btninstructions.Click
        Instructions.Show()
    End Sub
End Class

