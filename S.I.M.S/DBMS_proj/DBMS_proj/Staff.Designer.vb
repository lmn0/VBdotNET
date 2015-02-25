<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Staff
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
        Me.components = New System.ComponentModel.Container
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.label_name = New System.Windows.Forms.Label
        Me.label_id = New System.Windows.Forms.Label
        Me.label_dept = New System.Windows.Forms.Label
        Me.label_class = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.ButtonChngPwd = New System.Windows.Forms.Button
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSet1 = New WindowsApplication1.databaseDataSet
        Me.StaffTableAdapter = New WindowsApplication1.databaseDataSetTableAdapters.StaffTableAdapter
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(46, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(46, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(46, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Department"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(46, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Advisor of"
        '
        'label_name
        '
        Me.label_name.AutoSize = True
        Me.label_name.BackColor = System.Drawing.Color.Transparent
        Me.label_name.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_name.ForeColor = System.Drawing.Color.White
        Me.label_name.Location = New System.Drawing.Point(117, 34)
        Me.label_name.Name = "label_name"
        Me.label_name.Size = New System.Drawing.Size(0, 14)
        Me.label_name.TabIndex = 4
        '
        'label_id
        '
        Me.label_id.AutoSize = True
        Me.label_id.BackColor = System.Drawing.Color.Transparent
        Me.label_id.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_id.ForeColor = System.Drawing.Color.White
        Me.label_id.Location = New System.Drawing.Point(117, 76)
        Me.label_id.Name = "label_id"
        Me.label_id.Size = New System.Drawing.Size(0, 14)
        Me.label_id.TabIndex = 5
        '
        'label_dept
        '
        Me.label_dept.AutoSize = True
        Me.label_dept.BackColor = System.Drawing.Color.Transparent
        Me.label_dept.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_dept.ForeColor = System.Drawing.Color.White
        Me.label_dept.Location = New System.Drawing.Point(117, 117)
        Me.label_dept.Name = "label_dept"
        Me.label_dept.Size = New System.Drawing.Size(0, 14)
        Me.label_dept.TabIndex = 6
        '
        'label_class
        '
        Me.label_class.AutoSize = True
        Me.label_class.BackColor = System.Drawing.Color.Transparent
        Me.label_class.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_class.ForeColor = System.Drawing.Color.White
        Me.label_class.Location = New System.Drawing.Point(117, 162)
        Me.label_class.Name = "label_class"
        Me.label_class.Size = New System.Drawing.Size(0, 14)
        Me.label_class.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(49, 262)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Post Assignment"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(49, 291)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(122, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Post Test"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.default_user
        Me.PictureBox1.Location = New System.Drawing.Point(245, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(177, 152)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(306, 334)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(116, 23)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Sign Out"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ButtonChngPwd
        '
        Me.ButtonChngPwd.Location = New System.Drawing.Point(49, 334)
        Me.ButtonChngPwd.Name = "ButtonChngPwd"
        Me.ButtonChngPwd.Size = New System.Drawing.Size(122, 23)
        Me.ButtonChngPwd.TabIndex = 12
        Me.ButtonChngPwd.Text = "Change Password"
        Me.ButtonChngPwd.UseVisualStyleBackColor = True
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "Staff"
        Me.BindingSource1.DataSource = Me.DatabaseDataSet1
        '
        'DatabaseDataSet1
        '
        Me.DatabaseDataSet1.DataSetName = "databaseDataSet"
        Me.DatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StaffTableAdapter
        '
        Me.StaffTableAdapter.ClearBeforeFill = True
        '
        'Staff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(434, 379)
        Me.Controls.Add(Me.ButtonChngPwd)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.label_class)
        Me.Controls.Add(Me.label_dept)
        Me.Controls.Add(Me.label_id)
        Me.Controls.Add(Me.label_name)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Staff"
        Me.Text = "Staff"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents label_name As System.Windows.Forms.Label
    Friend WithEvents label_id As System.Windows.Forms.Label
    Friend WithEvents label_dept As System.Windows.Forms.Label
    Friend WithEvents label_class As System.Windows.Forms.Label
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DatabaseDataSet1 As WindowsApplication1.databaseDataSet
    Friend WithEvents StaffTableAdapter As WindowsApplication1.databaseDataSetTableAdapters.StaffTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ButtonChngPwd As System.Windows.Forms.Button
End Class
