<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm3))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnback = New System.Windows.Forms.Button()
        Me.btnequipment = New System.Windows.Forms.Button()
        Me.btnchng = New System.Windows.Forms.Button()
        Me.btnadduser = New System.Windows.Forms.Button()
        Me.btnequipmentremove = New System.Windows.Forms.Button()
        Me.btnchangesource = New System.Windows.Forms.Button()
        Me.btnview = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnsavepath = New System.Windows.Forms.Button()
        Me.btnviewpath = New System.Windows.Forms.Button()
        Me.pickersource = New System.Windows.Forms.FolderBrowserDialog()
        Me.chngdbpath = New System.Windows.Forms.Button()
        Me.BtnViewDB = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(12, 301)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(151, 137)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(232, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 51)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Setup"
        '
        'btnback
        '
        Me.btnback.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.Location = New System.Drawing.Point(481, 402)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(123, 36)
        Me.btnback.TabIndex = 8
        Me.btnback.Text = "Logout"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'btnequipment
        '
        Me.btnequipment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnequipment.Location = New System.Drawing.Point(191, 82)
        Me.btnequipment.Name = "btnequipment"
        Me.btnequipment.Size = New System.Drawing.Size(90, 38)
        Me.btnequipment.TabIndex = 0
        Me.btnequipment.Text = "Add"
        Me.btnequipment.UseVisualStyleBackColor = True
        '
        'btnchng
        '
        Me.btnchng.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnchng.Location = New System.Drawing.Point(56, 126)
        Me.btnchng.Name = "btnchng"
        Me.btnchng.Size = New System.Drawing.Size(477, 37)
        Me.btnchng.TabIndex = 3
        Me.btnchng.Text = "Change Admin Password"
        Me.btnchng.UseVisualStyleBackColor = True
        '
        'btnadduser
        '
        Me.btnadduser.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadduser.Location = New System.Drawing.Point(56, 169)
        Me.btnadduser.Name = "btnadduser"
        Me.btnadduser.Size = New System.Drawing.Size(477, 37)
        Me.btnadduser.TabIndex = 4
        Me.btnadduser.Text = "Add/Change user"
        Me.btnadduser.UseVisualStyleBackColor = True
        '
        'btnequipmentremove
        '
        Me.btnequipmentremove.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnequipmentremove.Location = New System.Drawing.Point(418, 82)
        Me.btnequipmentremove.Name = "btnequipmentremove"
        Me.btnequipmentremove.Size = New System.Drawing.Size(115, 38)
        Me.btnequipmentremove.TabIndex = 2
        Me.btnequipmentremove.Text = "Remove "
        Me.btnequipmentremove.UseVisualStyleBackColor = True
        '
        'btnchangesource
        '
        Me.btnchangesource.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnchangesource.Location = New System.Drawing.Point(56, 212)
        Me.btnchangesource.Name = "btnchangesource"
        Me.btnchangesource.Size = New System.Drawing.Size(185, 37)
        Me.btnchangesource.TabIndex = 5
        Me.btnchangesource.Text = "Change source path"
        Me.btnchangesource.UseVisualStyleBackColor = True
        '
        'btnview
        '
        Me.btnview.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnview.Location = New System.Drawing.Point(287, 82)
        Me.btnview.Name = "btnview"
        Me.btnview.Size = New System.Drawing.Size(125, 38)
        Me.btnview.TabIndex = 1
        Me.btnview.Text = "View"
        Me.btnview.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Equipment"
        '
        'btnsavepath
        '
        Me.btnsavepath.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsavepath.Location = New System.Drawing.Point(247, 212)
        Me.btnsavepath.Name = "btnsavepath"
        Me.btnsavepath.Size = New System.Drawing.Size(171, 37)
        Me.btnsavepath.TabIndex = 6
        Me.btnsavepath.Text = "Change save path"
        Me.btnsavepath.UseVisualStyleBackColor = True
        '
        'btnviewpath
        '
        Me.btnviewpath.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnviewpath.Location = New System.Drawing.Point(424, 211)
        Me.btnviewpath.Name = "btnviewpath"
        Me.btnviewpath.Size = New System.Drawing.Size(109, 38)
        Me.btnviewpath.TabIndex = 7
        Me.btnviewpath.Text = "View"
        Me.btnviewpath.UseVisualStyleBackColor = True
        '
        'chngdbpath
        '
        Me.chngdbpath.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chngdbpath.Location = New System.Drawing.Point(56, 255)
        Me.chngdbpath.Name = "chngdbpath"
        Me.chngdbpath.Size = New System.Drawing.Size(362, 38)
        Me.chngdbpath.TabIndex = 11
        Me.chngdbpath.Text = "Change Database Path"
        Me.chngdbpath.UseVisualStyleBackColor = True
        '
        'BtnViewDB
        '
        Me.BtnViewDB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnViewDB.Location = New System.Drawing.Point(424, 255)
        Me.BtnViewDB.Name = "BtnViewDB"
        Me.BtnViewDB.Size = New System.Drawing.Size(109, 38)
        Me.BtnViewDB.TabIndex = 12
        Me.BtnViewDB.Text = "View"
        Me.BtnViewDB.UseVisualStyleBackColor = True
        '
        'LoginForm3
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(616, 450)
        Me.Controls.Add(Me.BtnViewDB)
        Me.Controls.Add(Me.chngdbpath)
        Me.Controls.Add(Me.btnviewpath)
        Me.Controls.Add(Me.btnsavepath)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnequipment)
        Me.Controls.Add(Me.btnview)
        Me.Controls.Add(Me.btnchangesource)
        Me.Controls.Add(Me.btnequipmentremove)
        Me.Controls.Add(Me.btnadduser)
        Me.Controls.Add(Me.btnchng)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "LoginForm3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Setup"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnback As Button
    Friend WithEvents btnequipment As Button
    Friend WithEvents btnchng As Button
    Friend WithEvents btnadduser As Button
    Friend WithEvents btnequipmentremove As Button
    Friend WithEvents btnchangesource As Button
    Friend WithEvents btnview As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnsavepath As Button
    Friend WithEvents btnviewpath As Button
    Friend WithEvents pickersource As FolderBrowserDialog
    Friend WithEvents chngdbpath As Button
    Friend WithEvents BtnViewDB As Button
End Class
