Imports System.ComponentModel
Public Class LoginForm3
    Private Sub Btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Mainlogin.Show()
        Me.Hide()
    End Sub



    Private Sub Btnchng_Click(sender As Object, e As EventArgs) Handles btnchng.Click
        'Dim strpass As String
        'strpass = InputBox("New Password", "Password Change", " ")
        'If strpass = "" Then
        '    Exit Sub
        'ElseIf strpass = " " Then
        '    MessageBox.Show(text:="Please enter a valid password", caption:=
        '                        "Error", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
        'Else
        '    My.Settings.pass = strpass
        'End If
        AdminchangePassword.Show()
        Me.Hide()
        My.Settings.Save()
    End Sub


    Private Sub BtnAddUser_Click(sender As Object, e As EventArgs) Handles btnadduser.Click
        Addchangeusers.Show()
    End Sub


    Private Sub Btnequipment_Click(sender As Object, e As EventArgs) Handles btnequipment.Click
        Dim eqp As String = InputBox("Please enter name of the new equipment", "Equipment name Entry", " ")
        If eqp = " " Then
            MessageBox.Show(text:="Please enter valid Equipment name", caption:=
                                "Error", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
        ElseIf eqp = "" Then
            Exit Sub
        Else
            If My.Settings.equipment.IndexOf(eqp) <> -1 Then
                MessageBox.Show(text:="The Equipment already exists in the Equipment List", caption:=
                                "Error", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)

            Else
                My.Settings.equipment.Add(eqp)
                MessageBox.Show(text:="Equiment Successfully added to the Equipment List", caption:=
                                "Success", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Asterisk)
            End If
        End If
    End Sub

    Private Sub Btnequipmentremove_Click(sender As Object, e As EventArgs) Handles btnequipmentremove.Click
        Dim eqp As String = InputBox("Please enter the name of the equipment that is to be deleted", "Equipment removal", " ")
        If eqp = " " Then
            MessageBox.Show(text:="Please enter valid File name", caption:=
                                "Error", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
        ElseIf eqp = "" Then
            Exit Sub
        Else
            If My.Settings.equipment.IndexOf(eqp) <> -1 Then
                Dim confirmation As DialogResult
                confirmation = MessageBox.Show(text:="Confirm Delete" & Environment.NewLine & eqp & " ?", caption:="Remove Confirmation", buttons:=MessageBoxButtons.YesNo, icon:=MessageBoxIcon.Warning)
                If confirmation = vbYes Then
                    My.Settings.equipment.Remove(eqp)
                End If
            Else
                MessageBox.Show(text:="Requested equipment could not be found in the equipment List", caption:="Error", icon:=MessageBoxIcon.Error, buttons:=MessageBoxButtons.OK)
            End If
        End If
    End Sub

    Private Sub LoginForm3_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Exit()
    End Sub


    Private Sub Btnchange_Click(sender As Object, e As EventArgs) Handles btnchangesource.Click
        'Dim rtmpathstr As String = InputBox("Please enter the full master file path" & Environment.NewLine & "A typical file path looks like this:" & Environment.NewLine & "DriveName:\Directory1\Directory2\", "Change File Path", " ")
        'If rtmpathstr = " " Then
        '    MessageBox.Show(text:="Please enter a valid File Path", caption:=
        '                        "Error", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
        'ElseIf rtmpathstr = "" Then
        '    Exit Sub
        'Else
        '    My.Settings.rtmpath = rtmpathstr
        'End If
        pickersource.Description = "Select RTM Source File Path"
        Dim sourcestr As String = ""
        If pickersource.ShowDialog() = DialogResult.OK Then
            sourcestr = pickersource.SelectedPath
            sourcestr &= "\"
            MessageBox.Show(Me, "The RTM file path has successfully been changed to:" & Environment.NewLine & sourcestr, "RTM File Path Change", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            My.Settings.rtmpath = sourcestr
        End If

    End Sub

    Private Sub Btnview_Click(sender As Object, e As EventArgs) Handles btnview.Click
        Dim viewstr As String = "The Equipment List in the system is:" & Environment.NewLine
        For Each eqp In My.Settings.equipment
            viewstr &= eqp & Environment.NewLine
        Next
        MessageBox.Show(Me, viewstr, "Equipment List", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Sub

    Private Sub Btnviewpath_Click(sender As Object, e As EventArgs) Handles btnviewpath.Click
        Dim viewstr As String = "The Source Path is:" & Environment.NewLine
        viewstr &= My.Settings.rtmpath & Environment.NewLine
        viewstr &= "The Save Path is:" & Environment.NewLine
        viewstr &= My.Settings.savepath
        MessageBox.Show(Me, viewstr, "System Path Settings", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Sub

    Private Sub Btnsavepath_Click(sender As Object, e As EventArgs) Handles btnsavepath.Click
        'Dim rtmpathstr As String = InputBox("Please enter the full save file path" & Environment.NewLine & "A typical file path looks like this:" & Environment.NewLine & "DriveName:\Directory1\Directory2\", "Change File Path", " ")
        'If rtmpathstr = " " Then
        '    MessageBox.Show(text:="Please enter a valid File Path", caption:=
        '                        "Error", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
        'ElseIf rtmpathstr = "" Then
        '    Exit Sub
        'Else
        '    My.Settings.savepath = rtmpathstr
        'End If
        pickersource.Description = "Select RTM Save File Path"
        Dim savestr As String = ""
        If pickersource.ShowDialog() = DialogResult.OK Then
            savestr = pickersource.SelectedPath
            pickersource.Description = "Select RTM Save File Path"
            savestr &= "\"
            MessageBox.Show(Me, "The RTM Save Path has successfully been changed to:" & Environment.NewLine & savestr, "RTM Save File Path Change", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            My.Settings.rtmpath = savestr
        End If
    End Sub
End Class

'Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
'    Dim filename As String = InputBox("Please enter the RTM file name:", "File name Removal", " ")
'    If filename = " " Then
'        MessageBox.Show(text:="Please enter valid File name", caption:=
'                            "Error", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
'    ElseIf filename = "" Then
'        Exit Sub
'    Else
'        If My.Settings.Filelist.IndexOf(filename) <> -1 Then
'            Dim confirmation As DialogResult
'            confirmation = MessageBox.Show(text:="Confirm Delete" & Environment.NewLine & filename & " ?", caption:="Remove Confirmation", buttons:=MessageBoxButtons.YesNo, icon:=MessageBoxIcon.Warning)
'            If confirmation = vbYes Then
'                My.Settings.Filelist.Remove(filename)
'            End If
'        Else
'            MessageBox.Show(text:="Requested File could not be found in the File List", caption:="Error", icon:=MessageBoxIcon.Error, buttons:=MessageBoxButtons.OK)
'        End If
'    End If
'    Form1.Refresh()
'End Sub

'Private Sub btnAddRtm_Click(sender As Object, e As EventArgs) Handles btnAddRtm.Click
'    Dim filename As String = InputBox("Please enter the RTM file name:" & Environment.NewLine & "PLEASE NOTE: The RTM file name entry should be exactly same as the RTM file name in the folder", "File name Entry", " ")
'    If filename = " " Then
'        MessageBox.Show(text:="Please enter valid File name", caption:=
'                            "Error", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
'    ElseIf filename = "" Then
'        Exit Sub
'    Else

'        If My.Settings.Filelist.IndexOf(filename) <> -1 Then
'            MessageBox.Show(text:="The file name already exists in the File List", caption:=
'                            "Error", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)

'        Else
'            My.Settings.Filelist.Add(filename)
'            MessageBox.Show(text:="File Successfully added to the File List", caption:=
'                            "Success", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Asterisk)
'        End If
'    End If

'End Sub