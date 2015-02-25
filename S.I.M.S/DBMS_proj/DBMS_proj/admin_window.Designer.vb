<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin_window
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
        Me.newadm = New System.Windows.Forms.Button
        Me.editstaff = New System.Windows.Forms.Button
        Me.editstudent = New System.Windows.Forms.Button
        Me.newstaff = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Labeladminname = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Button2 = New System.Windows.Forms.Button
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'newadm
        '
        Me.newadm.Location = New System.Drawing.Point(32, 236)
        Me.newadm.Name = "newadm"
        Me.newadm.Size = New System.Drawing.Size(134, 41)
        Me.newadm.TabIndex = 0
        Me.newadm.Text = "New Student"
        Me.newadm.UseVisualStyleBackColor = True
        '
        'editstaff
        '
        Me.editstaff.Location = New System.Drawing.Point(298, 300)
        Me.editstaff.Name = "editstaff"
        Me.editstaff.Size = New System.Drawing.Size(134, 39)
        Me.editstaff.TabIndex = 1
        Me.editstaff.Text = "Edit Staff Details"
        Me.editstaff.UseVisualStyleBackColor = True
        '
        'editstudent
        '
        Me.editstudent.Location = New System.Drawing.Point(32, 300)
        Me.editstudent.Name = "editstudent"
        Me.editstudent.Size = New System.Drawing.Size(134, 39)
        Me.editstudent.TabIndex = 2
        Me.editstudent.Text = "Edit Student Details"
        Me.editstudent.UseVisualStyleBackColor = True
        '
        'newstaff
        '
        Me.newstaff.Location = New System.Drawing.Point(298, 236)
        Me.newstaff.Name = "newstaff"
        Me.newstaff.Size = New System.Drawing.Size(134, 41)
        Me.newstaff.TabIndex = 3
        Me.newstaff.Text = "New Staff"
        Me.newstaff.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(332, 378)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 30)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Sign Out"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Labeladminname
        '
        Me.Labeladminname.AutoSize = True
        Me.Labeladminname.BackColor = System.Drawing.Color.Transparent
        Me.Labeladminname.ForeColor = System.Drawing.Color.White
        Me.Labeladminname.Location = New System.Drawing.Point(29, 31)
        Me.Labeladminname.Name = "Labeladminname"
        Me.Labeladminname.Size = New System.Drawing.Size(0, 13)
        Me.Labeladminname.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.default_user
        Me.PictureBox1.Location = New System.Drawing.Point(275, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(177, 152)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(32, 369)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(134, 39)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Change Password"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'admin_window
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.bg
        Me.ClientSize = New System.Drawing.Size(492, 420)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Labeladminname)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.newstaff)
        Me.Controls.Add(Me.editstudent)
        Me.Controls.Add(Me.editstaff)
        Me.Controls.Add(Me.newadm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "admin_window"
        Me.Text = "Administrator"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents newadm As System.Windows.Forms.Button
    Friend WithEvents editstaff As System.Windows.Forms.Button
    Friend WithEvents editstudent As System.Windows.Forms.Button
    Friend WithEvents newstaff As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Labeladminname As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
