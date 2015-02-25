<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class post_assgn
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
        Me.postassgn = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextBoxAssgnNo = New System.Windows.Forms.TextBox
        Me.TextBoxDept = New System.Windows.Forms.TextBox
        Me.TextBoxYear = New System.Windows.Forms.TextBox
        Me.TextBoxClass = New System.Windows.Forms.TextBox
        Me.TextBoxQuestion = New System.Windows.Forms.TextBox
        Me.DatabaseDataSet1 = New WindowsApplication1.databaseDataSet
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AssignmentsTableAdapter = New WindowsApplication1.databaseDataSetTableAdapters.AssignmentsTableAdapter
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.DatabaseDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'postassgn
        '
        Me.postassgn.Location = New System.Drawing.Point(156, 376)
        Me.postassgn.Name = "postassgn"
        Me.postassgn.Size = New System.Drawing.Size(75, 23)
        Me.postassgn.TabIndex = 0
        Me.postassgn.Text = "Post"
        Me.postassgn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(59, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Assignment.No"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(59, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Department"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(59, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Year"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(59, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Class Section"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(59, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Question"
        '
        'TextBoxAssgnNo
        '
        Me.TextBoxAssgnNo.Location = New System.Drawing.Point(156, 29)
        Me.TextBoxAssgnNo.Name = "TextBoxAssgnNo"
        Me.TextBoxAssgnNo.Size = New System.Drawing.Size(58, 20)
        Me.TextBoxAssgnNo.TabIndex = 6
        '
        'TextBoxDept
        '
        Me.TextBoxDept.Location = New System.Drawing.Point(156, 55)
        Me.TextBoxDept.Name = "TextBoxDept"
        Me.TextBoxDept.Size = New System.Drawing.Size(58, 20)
        Me.TextBoxDept.TabIndex = 7
        '
        'TextBoxYear
        '
        Me.TextBoxYear.Location = New System.Drawing.Point(156, 81)
        Me.TextBoxYear.Name = "TextBoxYear"
        Me.TextBoxYear.Size = New System.Drawing.Size(58, 20)
        Me.TextBoxYear.TabIndex = 8
        '
        'TextBoxClass
        '
        Me.TextBoxClass.Location = New System.Drawing.Point(156, 110)
        Me.TextBoxClass.Name = "TextBoxClass"
        Me.TextBoxClass.Size = New System.Drawing.Size(58, 20)
        Me.TextBoxClass.TabIndex = 9
        '
        'TextBoxQuestion
        '
        Me.TextBoxQuestion.Location = New System.Drawing.Point(156, 180)
        Me.TextBoxQuestion.Multiline = True
        Me.TextBoxQuestion.Name = "TextBoxQuestion"
        Me.TextBoxQuestion.Size = New System.Drawing.Size(181, 124)
        Me.TextBoxQuestion.TabIndex = 10
        '
        'DatabaseDataSet1
        '
        Me.DatabaseDataSet1.DataSetName = "databaseDataSet"
        Me.DatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "Assignments"
        Me.BindingSource1.DataSource = Me.DatabaseDataSet1
        '
        'AssignmentsTableAdapter
        '
        Me.AssignmentsTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(319, 376)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'post_assgn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.bg
        Me.ClientSize = New System.Drawing.Size(504, 446)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBoxQuestion)
        Me.Controls.Add(Me.TextBoxClass)
        Me.Controls.Add(Me.TextBoxYear)
        Me.Controls.Add(Me.TextBoxDept)
        Me.Controls.Add(Me.TextBoxAssgnNo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.postassgn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "post_assgn"
        Me.Text = "Post Assignment"
        CType(Me.DatabaseDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DatabaseDataSet1 As WindowsApplication1.databaseDataSet
    Friend WithEvents AssignmentsTableAdapter As WindowsApplication1.databaseDataSetTableAdapters.AssignmentsTableAdapter
    Friend WithEvents postassgn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBoxAssgnNo As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDept As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxYear As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxClass As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxQuestion As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
