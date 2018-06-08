<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class miscjob
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(miscjob))
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblname = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblTime = New System.Windows.Forms.Label()
        Me.txtJob = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnooftags = New System.Windows.Forms.TextBox()
        Me.txtequipment = New System.Windows.Forms.TextBox()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnback = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblusername = New System.Windows.Forms.Label()
        Me.txtremove = New System.Windows.Forms.TextBox()
        Me.lblremove = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(151, 100)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(442, 27)
        Me.txtName.TabIndex = 10
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(16, 100)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(98, 20)
        Me.lblname.TabIndex = 11
        Me.lblname.Text = "Tagged By"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 336)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(142, 143)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Job Scope"
        '
        'Timer1
        '
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblTime.Location = New System.Drawing.Point(475, 432)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(46, 20)
        Me.lblTime.TabIndex = 12
        Me.lblTime.Text = "Time"
        '
        'txtJob
        '
        Me.txtJob.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJob.Location = New System.Drawing.Point(151, 143)
        Me.txtJob.Name = "txtJob"
        Me.txtJob.Size = New System.Drawing.Size(442, 27)
        Me.txtJob.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 248)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 20)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Equipment"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 44)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Number of Tags required"
        '
        'txtnooftags
        '
        Me.txtnooftags.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnooftags.Location = New System.Drawing.Point(151, 188)
        Me.txtnooftags.Name = "txtnooftags"
        Me.txtnooftags.Size = New System.Drawing.Size(442, 27)
        Me.txtnooftags.TabIndex = 19
        '
        'txtequipment
        '
        Me.txtequipment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtequipment.Location = New System.Drawing.Point(151, 245)
        Me.txtequipment.Name = "txtequipment"
        Me.txtequipment.Size = New System.Drawing.Size(442, 27)
        Me.txtequipment.TabIndex = 20
        '
        'btnDisplay
        '
        Me.btnDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplay.Location = New System.Drawing.Point(375, 371)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(218, 36)
        Me.btnDisplay.TabIndex = 21
        Me.btnDisplay.Text = "Print RTM"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnback
        '
        Me.btnback.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.Location = New System.Drawing.Point(178, 371)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(170, 36)
        Me.btnback.TabIndex = 22
        Me.btnback.Text = "Back"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(169, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(343, 51)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Red Tag Master"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusername.Location = New System.Drawing.Point(17, 37)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(94, 20)
        Me.lblusername.TabIndex = 24
        Me.lblusername.Text = "Username"
        '
        'txtremove
        '
        Me.txtremove.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtremove.Location = New System.Drawing.Point(151, 301)
        Me.txtremove.Name = "txtremove"
        Me.txtremove.Size = New System.Drawing.Size(442, 27)
        Me.txtremove.TabIndex = 26
        '
        'lblremove
        '
        Me.lblremove.AutoSize = True
        Me.lblremove.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblremove.Location = New System.Drawing.Point(17, 288)
        Me.lblremove.Name = "lblremove"
        Me.lblremove.Size = New System.Drawing.Size(114, 40)
        Me.lblremove.TabIndex = 25
        Me.lblremove.Text = "To be " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Removed By"
        '
        'miscjob
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(605, 487)
        Me.Controls.Add(Me.txtremove)
        Me.Controls.Add(Me.lblremove)
        Me.Controls.Add(Me.lblusername)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.txtequipment)
        Me.Controls.Add(Me.txtnooftags)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtJob)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.txtName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "miscjob"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Miscellaneous Job"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents lblname As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblTime As Label
    Friend WithEvents txtJob As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtnooftags As TextBox
    Friend WithEvents txtequipment As TextBox
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnback As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents lblusername As Label
    Friend WithEvents txtremove As TextBox
    Friend WithEvents lblremove As Label
End Class
