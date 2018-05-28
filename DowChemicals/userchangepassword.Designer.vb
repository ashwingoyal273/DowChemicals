<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Userchangepassword
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Userchangepassword))
        Me.lblusername = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblOld = New System.Windows.Forms.Label()
        Me.lblnew = New System.Windows.Forms.Label()
        Me.lblconfirm = New System.Windows.Forms.Label()
        Me.txtold = New System.Windows.Forms.TextBox()
        Me.txtnew = New System.Windows.Forms.TextBox()
        Me.txtconfirm = New System.Windows.Forms.TextBox()
        Me.btnok = New System.Windows.Forms.Button()
        Me.btnback = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusername.Location = New System.Drawing.Point(13, 86)
        Me.lblusername.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(94, 20)
        Me.lblusername.TabIndex = 0
        Me.lblusername.Text = "Username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(89, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(332, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Change User Password"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblOld
        '
        Me.lblOld.AutoSize = True
        Me.lblOld.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOld.Location = New System.Drawing.Point(13, 165)
        Me.lblOld.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOld.Name = "lblOld"
        Me.lblOld.Size = New System.Drawing.Size(126, 20)
        Me.lblOld.TabIndex = 2
        Me.lblOld.Text = "Old Password"
        '
        'lblnew
        '
        Me.lblnew.AutoSize = True
        Me.lblnew.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnew.Location = New System.Drawing.Point(13, 209)
        Me.lblnew.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblnew.Name = "lblnew"
        Me.lblnew.Size = New System.Drawing.Size(133, 20)
        Me.lblnew.TabIndex = 3
        Me.lblnew.Text = "New Password"
        '
        'lblconfirm
        '
        Me.lblconfirm.AutoSize = True
        Me.lblconfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblconfirm.Location = New System.Drawing.Point(13, 255)
        Me.lblconfirm.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblconfirm.Name = "lblconfirm"
        Me.lblconfirm.Size = New System.Drawing.Size(163, 20)
        Me.lblconfirm.TabIndex = 4
        Me.lblconfirm.Text = "Confirm Password"
        '
        'txtold
        '
        Me.txtold.Location = New System.Drawing.Point(184, 162)
        Me.txtold.Margin = New System.Windows.Forms.Padding(4)
        Me.txtold.Name = "txtold"
        Me.txtold.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtold.Size = New System.Drawing.Size(303, 27)
        Me.txtold.TabIndex = 0
        '
        'txtnew
        '
        Me.txtnew.Location = New System.Drawing.Point(184, 206)
        Me.txtnew.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnew.Name = "txtnew"
        Me.txtnew.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtnew.Size = New System.Drawing.Size(303, 27)
        Me.txtnew.TabIndex = 1
        '
        'txtconfirm
        '
        Me.txtconfirm.Location = New System.Drawing.Point(184, 252)
        Me.txtconfirm.Margin = New System.Windows.Forms.Padding(4)
        Me.txtconfirm.Name = "txtconfirm"
        Me.txtconfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtconfirm.Size = New System.Drawing.Size(303, 27)
        Me.txtconfirm.TabIndex = 2
        '
        'btnok
        '
        Me.btnok.Location = New System.Drawing.Point(184, 299)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(159, 32)
        Me.btnok.TabIndex = 3
        Me.btnok.Text = "&Ok"
        Me.btnok.UseVisualStyleBackColor = True
        '
        'btnback
        '
        Me.btnback.Location = New System.Drawing.Point(349, 299)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(138, 32)
        Me.btnback.TabIndex = 4
        Me.btnback.Text = "Back"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'userchangepassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(509, 369)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.txtconfirm)
        Me.Controls.Add(Me.txtnew)
        Me.Controls.Add(Me.txtold)
        Me.Controls.Add(Me.lblconfirm)
        Me.Controls.Add(Me.lblnew)
        Me.Controls.Add(Me.lblOld)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblusername)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "userchangepassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change user password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblusername As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblOld As Label
    Friend WithEvents lblnew As Label
    Friend WithEvents lblconfirm As Label
    Friend WithEvents txtold As TextBox
    Friend WithEvents txtnew As TextBox
    Friend WithEvents txtconfirm As TextBox
    Friend WithEvents btnok As Button
    Friend WithEvents btnback As Button
End Class
