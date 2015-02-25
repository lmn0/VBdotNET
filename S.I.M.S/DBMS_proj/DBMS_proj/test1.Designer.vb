<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class test1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.LabelTestNo = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.TextBoxAns = New System.Windows.Forms.TextBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.ButtonNext = New System.Windows.Forms.Button
        Me.ButtonPrev = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBoxOpt4 = New System.Windows.Forms.TextBox
        Me.TextBoxOpt3 = New System.Windows.Forms.TextBox
        Me.TextBoxopt2 = New System.Windows.Forms.TextBox
        Me.TextBoxOpt1 = New System.Windows.Forms.TextBox
        Me.TextBoxQuestion = New System.Windows.Forms.TextBox
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSet = New WindowsApplication1.databaseDataSet
        Me.TestTableAdapter = New WindowsApplication1.databaseDataSetTableAdapters.TestTableAdapter
        Me.StudentTableAdapter = New WindowsApplication1.databaseDataSetTableAdapters.StudentTableAdapter
        Me.GroupBox1.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.LabelTestNo)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextBoxAns)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.ButtonNext)
        Me.GroupBox1.Controls.Add(Me.ButtonPrev)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBoxOpt4)
        Me.GroupBox1.Controls.Add(Me.TextBoxOpt3)
        Me.GroupBox1.Controls.Add(Me.TextBoxopt2)
        Me.GroupBox1.Controls.Add(Me.TextBoxOpt1)
        Me.GroupBox1.Controls.Add(Me.TextBoxQuestion)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(56, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(492, 458)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Test :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(49, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "a"
        '
        'LabelTestNo
        '
        Me.LabelTestNo.AutoSize = True
        Me.LabelTestNo.Location = New System.Drawing.Point(40, 0)
        Me.LabelTestNo.Name = "LabelTestNo"
        Me.LabelTestNo.Size = New System.Drawing.Size(0, 13)
        Me.LabelTestNo.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(183, 309)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Answer"
        '
        'TextBoxAns
        '
        Me.TextBoxAns.Location = New System.Drawing.Point(236, 306)
        Me.TextBoxAns.MaxLength = 1
        Me.TextBoxAns.Name = "TextBoxAns"
        Me.TextBoxAns.Size = New System.Drawing.Size(28, 20)
        Me.TextBoxAns.TabIndex = 13
        Me.TextBoxAns.Text = "0"
        Me.TextBoxAns.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button3
        '
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(197, 411)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(101, 32)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Submit"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'ButtonNext
        '
        Me.ButtonNext.ForeColor = System.Drawing.Color.Black
        Me.ButtonNext.Location = New System.Drawing.Point(290, 352)
        Me.ButtonNext.Name = "ButtonNext"
        Me.ButtonNext.Size = New System.Drawing.Size(101, 21)
        Me.ButtonNext.TabIndex = 11
        Me.ButtonNext.Text = "Next"
        Me.ButtonNext.UseVisualStyleBackColor = True
        '
        'ButtonPrev
        '
        Me.ButtonPrev.ForeColor = System.Drawing.Color.Black
        Me.ButtonPrev.Location = New System.Drawing.Point(106, 352)
        Me.ButtonPrev.Name = "ButtonPrev"
        Me.ButtonPrev.Size = New System.Drawing.Size(101, 21)
        Me.ButtonPrev.TabIndex = 10
        Me.ButtonPrev.Text = "Previous"
        Me.ButtonPrev.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(271, 261)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "4."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(76, 261)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "3."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(271, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "2."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(76, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "1."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(65, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Question"
        '
        'TextBoxOpt4
        '
        Me.TextBoxOpt4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TextBoxOpt4.Location = New System.Drawing.Point(290, 258)
        Me.TextBoxOpt4.Name = "TextBoxOpt4"
        Me.TextBoxOpt4.ReadOnly = True
        Me.TextBoxOpt4.Size = New System.Drawing.Size(112, 20)
        Me.TextBoxOpt4.TabIndex = 4
        '
        'TextBoxOpt3
        '
        Me.TextBoxOpt3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TextBoxOpt3.Location = New System.Drawing.Point(95, 258)
        Me.TextBoxOpt3.Name = "TextBoxOpt3"
        Me.TextBoxOpt3.ReadOnly = True
        Me.TextBoxOpt3.Size = New System.Drawing.Size(112, 20)
        Me.TextBoxOpt3.TabIndex = 3
        '
        'TextBoxopt2
        '
        Me.TextBoxopt2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TextBoxopt2.Location = New System.Drawing.Point(290, 190)
        Me.TextBoxopt2.Name = "TextBoxopt2"
        Me.TextBoxopt2.ReadOnly = True
        Me.TextBoxopt2.Size = New System.Drawing.Size(112, 20)
        Me.TextBoxopt2.TabIndex = 2
        '
        'TextBoxOpt1
        '
        Me.TextBoxOpt1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TextBoxOpt1.Location = New System.Drawing.Point(95, 190)
        Me.TextBoxOpt1.Name = "TextBoxOpt1"
        Me.TextBoxOpt1.ReadOnly = True
        Me.TextBoxOpt1.Size = New System.Drawing.Size(112, 20)
        Me.TextBoxOpt1.TabIndex = 1
        '
        'TextBoxQuestion
        '
        Me.TextBoxQuestion.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TextBoxQuestion.Location = New System.Drawing.Point(68, 44)
        Me.TextBoxQuestion.Multiline = True
        Me.TextBoxQuestion.Name = "TextBoxQuestion"
        Me.TextBoxQuestion.ReadOnly = True
        Me.TextBoxQuestion.Size = New System.Drawing.Size(334, 95)
        Me.TextBoxQuestion.TabIndex = 0
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "Student"
        Me.BindingSource1.DataSource = Me.DatabaseDataSet
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "databaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TestTableAdapter
        '
        Me.TestTableAdapter.ClearBeforeFill = True
        '
        'StudentTableAdapter
        '
        Me.StudentTableAdapter.ClearBeforeFill = True
        '
        'test1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.bg
        Me.ClientSize = New System.Drawing.Size(607, 533)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "test1"
        Me.Text = "Online Test"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxOpt4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxOpt3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxopt2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxOpt1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxQuestion As System.Windows.Forms.TextBox
    Friend WithEvents ButtonPrev As System.Windows.Forms.Button
    Friend WithEvents TextBoxAns As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ButtonNext As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LabelTestNo As System.Windows.Forms.Label
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DatabaseDataSet As WindowsApplication1.databaseDataSet
    Friend WithEvents TestTableAdapter As WindowsApplication1.databaseDataSetTableAdapters.TestTableAdapter
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents StudentTableAdapter As WindowsApplication1.databaseDataSetTableAdapters.StudentTableAdapter
End Class
