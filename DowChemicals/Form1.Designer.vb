<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblname = New System.Windows.Forms.Label()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.cbxScope = New System.Windows.Forms.ComboBox()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnmisc = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbxsubarea = New System.Windows.Forms.ComboBox()
        Me.cbxarea = New System.Windows.Forms.ComboBox()
        Me.btnchngpass = New System.Windows.Forms.Button()
        Me.lblusername = New System.Windows.Forms.Label()
        Me.btnlogout = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(138, 96)
        Me.txtName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(454, 27)
        Me.txtName.TabIndex = 0
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(15, 98)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(92, 20)
        Me.lblname.TabIndex = 1
        Me.lblname.Text = "Issued By"
        '
        'btnDisplay
        '
        Me.btnDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplay.Location = New System.Drawing.Point(198, 252)
        Me.btnDisplay.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(219, 36)
        Me.btnDisplay.TabIndex = 4
        Me.btnDisplay.Text = "Print RTM"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'cbxScope
        '
        Me.cbxScope.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxScope.FormattingEnabled = True
        Me.cbxScope.Location = New System.Drawing.Point(138, 206)
        Me.cbxScope.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbxScope.Name = "cbxScope"
        Me.cbxScope.Size = New System.Drawing.Size(454, 28)
        Me.cbxScope.TabIndex = 3
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblTime.Location = New System.Drawing.Point(474, 416)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(46, 20)
        Me.lblTime.TabIndex = 6
        Me.lblTime.Text = "Time"
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 215)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Job Scope"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(129, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(342, 51)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Red Tag Master"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 295)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(144, 142)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'btnmisc
        '
        Me.btnmisc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmisc.Location = New System.Drawing.Point(19, 252)
        Me.btnmisc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnmisc.Name = "btnmisc"
        Me.btnmisc.Size = New System.Drawing.Size(151, 36)
        Me.btnmisc.TabIndex = 5
        Me.btnmisc.Text = "Misc. Job"
        Me.btnmisc.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Area"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 20)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Sub-Area"
        '
        'cbxsubarea
        '
        Me.cbxsubarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxsubarea.FormattingEnabled = True
        Me.cbxsubarea.Items.AddRange(New Object() {"T1", "T2", "PU", "PE"})
        Me.cbxsubarea.Location = New System.Drawing.Point(138, 172)
        Me.cbxsubarea.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbxsubarea.Name = "cbxsubarea"
        Me.cbxsubarea.Size = New System.Drawing.Size(454, 28)
        Me.cbxsubarea.TabIndex = 2
        '
        'cbxarea
        '
        Me.cbxarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxarea.FormattingEnabled = True
        Me.cbxarea.Items.AddRange(New Object() {"Production", "Logistics", "Utility", "Maintainance"})
        Me.cbxarea.Location = New System.Drawing.Point(138, 136)
        Me.cbxarea.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbxarea.Name = "cbxarea"
        Me.cbxarea.Size = New System.Drawing.Size(454, 28)
        Me.cbxarea.TabIndex = 1
        '
        'btnchngpass
        '
        Me.btnchngpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnchngpass.Location = New System.Drawing.Point(459, 295)
        Me.btnchngpass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnchngpass.Name = "btnchngpass"
        Me.btnchngpass.Size = New System.Drawing.Size(133, 58)
        Me.btnchngpass.TabIndex = 14
        Me.btnchngpass.Text = "Change Password"
        Me.btnchngpass.UseVisualStyleBackColor = True
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.Location = New System.Drawing.Point(12, 34)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(94, 20)
        Me.lblusername.TabIndex = 15
        Me.lblusername.Text = "Username"
        '
        'btnlogout
        '
        Me.btnlogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogout.Location = New System.Drawing.Point(459, 252)
        Me.btnlogout.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(132, 36)
        Me.btnlogout.TabIndex = 16
        Me.btnlogout.Text = "Logout"
        Me.btnlogout.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(605, 450)
        Me.Controls.Add(Me.btnlogout)
        Me.Controls.Add(Me.lblusername)
        Me.Controls.Add(Me.btnchngpass)
        Me.Controls.Add(Me.cbxarea)
        Me.Controls.Add(Me.cbxsubarea)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnmisc)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.cbxScope)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.txtName)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Red Tag Master"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents lblname As Label
    Friend WithEvents btnDisplay As Button
    Friend WithEvents cbxScope As ComboBox
    Friend WithEvents lblTime As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnmisc As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbxsubarea As ComboBox
    Friend WithEvents cbxarea As ComboBox
    Friend WithEvents btnchngpass As Button
    Friend WithEvents lblusername As Label
    Friend WithEvents btnlogout As Button
End Class

