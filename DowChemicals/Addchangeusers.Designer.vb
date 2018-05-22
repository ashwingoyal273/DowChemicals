<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Addchangeusers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Addchangeusers))
        Me.lbltitleaddchange = New System.Windows.Forms.Label()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblname = New System.Windows.Forms.Label()
        Me.lblpass = New System.Windows.Forms.Label()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbltitleaddchange
        '
        Me.lbltitleaddchange.AutoSize = True
        Me.lbltitleaddchange.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitleaddchange.Location = New System.Drawing.Point(203, -1)
        Me.lbltitleaddchange.Name = "lbltitleaddchange"
        Me.lbltitleaddchange.Size = New System.Drawing.Size(402, 51)
        Me.lbltitleaddchange.TabIndex = 12
        Me.lbltitleaddchange.Text = "Add/Change Users"
        '
        'btnDone
        '
        Me.btnDone.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDone.Location = New System.Drawing.Point(212, 378)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(393, 40)
        Me.btnDone.TabIndex = 13
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(124, 74)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(205, 22)
        Me.txtusername.TabIndex = 14
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(124, 113)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass.Size = New System.Drawing.Size(205, 22)
        Me.txtpass.TabIndex = 15
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(352, 74)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(393, 40)
        Me.btnAdd.TabIndex = 18
        Me.btnAdd.Text = "Insert User"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(352, 120)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(393, 40)
        Me.btnDelete.TabIndex = 19
        Me.btnDelete.Text = "Delete User"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(15, 76)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(94, 20)
        Me.lblname.TabIndex = 20
        Me.lblname.Text = "Username"
        '
        'lblpass
        '
        Me.lblpass.AutoSize = True
        Me.lblpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpass.Location = New System.Drawing.Point(18, 113)
        Me.lblpass.Name = "lblpass"
        Me.lblpass.Size = New System.Drawing.Size(91, 20)
        Me.lblpass.TabIndex = 21
        Me.lblpass.Text = "Password"
        '
        'btnclear
        '
        Me.btnclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.Location = New System.Drawing.Point(207, 143)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(122, 37)
        Me.btnclear.TabIndex = 22
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(13, 211)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(732, 150)
        Me.DataGridView1.TabIndex = 23
        '
        'Addchangeusers
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.lblpass)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.lbltitleaddchange)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Addchangeusers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Addchangeusers"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbltitleaddchange As Label
    Friend WithEvents btnDone As Button
    Friend WithEvents txtusername As TextBox
    Friend WithEvents txtpass As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents lblname As Label
    Friend WithEvents lblpass As Label
    Friend WithEvents btnclear As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
