﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Instructions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Instructions))
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.PicBoxlogo = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnOk = New System.Windows.Forms.Button()
        CType(Me.PicBoxlogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.Location = New System.Drawing.Point(441, 73)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(196, 38)
        Me.lbltitle.TabIndex = 0
        Me.lbltitle.Text = "Instructions"
        Me.lbltitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PicBoxlogo
        '
        Me.PicBoxlogo.BackgroundImage = Global.DowChemicals.My.Resources.Resources.logo
        Me.PicBoxlogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PicBoxlogo.Image = Global.DowChemicals.My.Resources.Resources.logo
        Me.PicBoxlogo.Location = New System.Drawing.Point(12, 12)
        Me.PicBoxlogo.Name = "PicBoxlogo"
        Me.PicBoxlogo.Size = New System.Drawing.Size(149, 100)
        Me.PicBoxlogo.TabIndex = 0
        Me.PicBoxlogo.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(967, 931)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'BtnOk
        '
        Me.BtnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOk.Location = New System.Drawing.Point(330, 1035)
        Me.BtnOk.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(331, 37)
        Me.BtnOk.TabIndex = 2
        Me.BtnOk.Text = "Close"
        Me.BtnOk.UseVisualStyleBackColor = True
        '
        'Instructions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(997, 529)
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PicBoxlogo)
        Me.Controls.Add(Me.lbltitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Instructions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Instructions"
        Me.TopMost = True
        CType(Me.PicBoxlogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbltitle As Label
    Friend WithEvents PicBoxlogo As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnOk As Button
End Class