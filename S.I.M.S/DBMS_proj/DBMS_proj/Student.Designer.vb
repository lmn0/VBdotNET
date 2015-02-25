<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Student
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
        Me.test_launch = New System.Windows.Forms.Button
        Me.assgn_launch = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.labelname = New System.Windows.Forms.Label
        Me.roll_no = New System.Windows.Forms.Label
        Me.dept = New System.Windows.Forms.Label
        Me.class_section = New System.Windows.Forms.Label
        Me.year = New System.Windows.Forms.Label
        Me.cgpa = New System.Windows.Forms.Label
        Me.test1mark = New System.Windows.Forms.Label
        Me.test2mark = New System.Windows.Forms.Label
        Me.test3mark = New System.Windows.Forms.Label
        Me.totalmarks = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSet1 = New WindowsApplication1.databaseDataSet
        Me.StudentTableAdapter = New WindowsApplication1.databaseDataSetTableAdapters.StudentTableAdapter
        Me.TestTableAdapter = New WindowsApplication1.databaseDataSetTableAdapters.TestTableAdapter
        Me.AssignmentsTableAdapter = New WindowsApplication1.databaseDataSetTableAdapters.AssignmentsTableAdapter
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Button2 = New System.Windows.Forms.Button
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'test_launch
        '
        Me.test_launch.Location = New System.Drawing.Point(68, 376)
        Me.test_launch.Name = "test_launch"
        Me.test_launch.Size = New System.Drawing.Size(94, 30)
        Me.test_launch.TabIndex = 0
        Me.test_launch.Text = "Take Test"
        Me.test_launch.UseVisualStyleBackColor = True
        Me.test_launch.Visible = False
        '
        'assgn_launch
        '
        Me.assgn_launch.Location = New System.Drawing.Point(207, 376)
        Me.assgn_launch.Name = "assgn_launch"
        Me.assgn_launch.Size = New System.Drawing.Size(113, 30)
        Me.assgn_launch.TabIndex = 1
        Me.assgn_launch.Text = "View Assignments"
        Me.assgn_launch.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(65, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(65, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Roll.No"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(65, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Department"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(65, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Class"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(65, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Year"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(65, 183)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "CGPA"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(65, 240)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Test 1 Mark"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(65, 267)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Test 2 Mark"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(65, 298)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Test 3 Mark"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(65, 327)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Total Marks"
        '
        'labelname
        '
        Me.labelname.AutoSize = True
        Me.labelname.BackColor = System.Drawing.Color.Transparent
        Me.labelname.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.labelname.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelname.ForeColor = System.Drawing.Color.White
        Me.labelname.Location = New System.Drawing.Point(147, 44)
        Me.labelname.Name = "labelname"
        Me.labelname.Size = New System.Drawing.Size(0, 14)
        Me.labelname.TabIndex = 13
        '
        'roll_no
        '
        Me.roll_no.AutoSize = True
        Me.roll_no.BackColor = System.Drawing.Color.Transparent
        Me.roll_no.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.roll_no.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roll_no.ForeColor = System.Drawing.Color.White
        Me.roll_no.Location = New System.Drawing.Point(147, 74)
        Me.roll_no.Name = "roll_no"
        Me.roll_no.Size = New System.Drawing.Size(0, 14)
        Me.roll_no.TabIndex = 14
        '
        'dept
        '
        Me.dept.AutoSize = True
        Me.dept.BackColor = System.Drawing.Color.Transparent
        Me.dept.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.dept.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dept.ForeColor = System.Drawing.Color.White
        Me.dept.Location = New System.Drawing.Point(147, 106)
        Me.dept.Name = "dept"
        Me.dept.Size = New System.Drawing.Size(0, 14)
        Me.dept.TabIndex = 15
        '
        'class_section
        '
        Me.class_section.AutoSize = True
        Me.class_section.BackColor = System.Drawing.Color.Transparent
        Me.class_section.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.class_section.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.class_section.ForeColor = System.Drawing.Color.White
        Me.class_section.Location = New System.Drawing.Point(147, 131)
        Me.class_section.Name = "class_section"
        Me.class_section.Size = New System.Drawing.Size(0, 14)
        Me.class_section.TabIndex = 16
        '
        'year
        '
        Me.year.AutoSize = True
        Me.year.BackColor = System.Drawing.Color.Transparent
        Me.year.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.year.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.year.ForeColor = System.Drawing.Color.White
        Me.year.Location = New System.Drawing.Point(147, 157)
        Me.year.Name = "year"
        Me.year.Size = New System.Drawing.Size(0, 14)
        Me.year.TabIndex = 17
        '
        'cgpa
        '
        Me.cgpa.AutoSize = True
        Me.cgpa.BackColor = System.Drawing.Color.Transparent
        Me.cgpa.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cgpa.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cgpa.ForeColor = System.Drawing.Color.White
        Me.cgpa.Location = New System.Drawing.Point(147, 185)
        Me.cgpa.Name = "cgpa"
        Me.cgpa.Size = New System.Drawing.Size(0, 14)
        Me.cgpa.TabIndex = 18
        '
        'test1mark
        '
        Me.test1mark.AutoSize = True
        Me.test1mark.BackColor = System.Drawing.Color.Transparent
        Me.test1mark.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.test1mark.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.test1mark.ForeColor = System.Drawing.Color.White
        Me.test1mark.Location = New System.Drawing.Point(147, 241)
        Me.test1mark.Name = "test1mark"
        Me.test1mark.Size = New System.Drawing.Size(0, 14)
        Me.test1mark.TabIndex = 19
        '
        'test2mark
        '
        Me.test2mark.AutoSize = True
        Me.test2mark.BackColor = System.Drawing.Color.Transparent
        Me.test2mark.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.test2mark.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.test2mark.ForeColor = System.Drawing.Color.White
        Me.test2mark.Location = New System.Drawing.Point(147, 269)
        Me.test2mark.Name = "test2mark"
        Me.test2mark.Size = New System.Drawing.Size(0, 14)
        Me.test2mark.TabIndex = 20
        '
        'test3mark
        '
        Me.test3mark.AutoSize = True
        Me.test3mark.BackColor = System.Drawing.Color.Transparent
        Me.test3mark.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.test3mark.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.test3mark.ForeColor = System.Drawing.Color.White
        Me.test3mark.Location = New System.Drawing.Point(147, 299)
        Me.test3mark.Name = "test3mark"
        Me.test3mark.Size = New System.Drawing.Size(0, 14)
        Me.test3mark.TabIndex = 21
        '
        'totalmarks
        '
        Me.totalmarks.AutoSize = True
        Me.totalmarks.BackColor = System.Drawing.Color.Transparent
        Me.totalmarks.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.totalmarks.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalmarks.ForeColor = System.Drawing.Color.White
        Me.totalmarks.Location = New System.Drawing.Point(147, 329)
        Me.totalmarks.Name = "totalmarks"
        Me.totalmarks.Size = New System.Drawing.Size(0, 14)
        Me.totalmarks.TabIndex = 22
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(376, 376)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 30)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Sign Out"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "Assignments"
        Me.BindingSource1.DataSource = Me.DatabaseDataSet1
        '
        'DatabaseDataSet1
        '
        Me.DatabaseDataSet1.DataSetName = "databaseDataSet"
        Me.DatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentTableAdapter
        '
        Me.StudentTableAdapter.ClearBeforeFill = True
        '
        'TestTableAdapter
        '
        Me.TestTableAdapter.ClearBeforeFill = True
        '
        'AssignmentsTableAdapter
        '
        Me.AssignmentsTableAdapter.ClearBeforeFill = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.default_user
        Me.PictureBox1.Location = New System.Drawing.Point(329, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(177, 152)
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(68, 433)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(110, 30)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "Change Password"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Student
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(541, 475)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.totalmarks)
        Me.Controls.Add(Me.test3mark)
        Me.Controls.Add(Me.test2mark)
        Me.Controls.Add(Me.test1mark)
        Me.Controls.Add(Me.cgpa)
        Me.Controls.Add(Me.year)
        Me.Controls.Add(Me.class_section)
        Me.Controls.Add(Me.dept)
        Me.Controls.Add(Me.roll_no)
        Me.Controls.Add(Me.labelname)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.assgn_launch)
        Me.Controls.Add(Me.test_launch)
        Me.Name = "Student"
        Me.Text = "Student"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents test_launch As System.Windows.Forms.Button
    Friend WithEvents assgn_launch As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents labelname As System.Windows.Forms.Label
    Friend WithEvents roll_no As System.Windows.Forms.Label
    Friend WithEvents dept As System.Windows.Forms.Label
    Friend WithEvents class_section As System.Windows.Forms.Label
    Friend WithEvents year As System.Windows.Forms.Label
    Friend WithEvents cgpa As System.Windows.Forms.Label
    Friend WithEvents test1mark As System.Windows.Forms.Label
    Friend WithEvents test2mark As System.Windows.Forms.Label
    Friend WithEvents test3mark As System.Windows.Forms.Label
    Friend WithEvents totalmarks As System.Windows.Forms.Label
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DatabaseDataSet1 As WindowsApplication1.databaseDataSet
    Friend WithEvents StudentTableAdapter As WindowsApplication1.databaseDataSetTableAdapters.StudentTableAdapter
    Friend WithEvents TestTableAdapter As WindowsApplication1.databaseDataSetTableAdapters.TestTableAdapter
    Friend WithEvents AssignmentsTableAdapter As WindowsApplication1.databaseDataSetTableAdapters.AssignmentsTableAdapter
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
