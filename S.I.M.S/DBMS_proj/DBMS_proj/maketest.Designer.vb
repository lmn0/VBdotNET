<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class maketest
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
        Me.nextb = New System.Windows.Forms.Button
        Me.finishb = New System.Windows.Forms.Button
        Me.TextBoxans = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSet = New WindowsApplication1.databaseDataSet
        Me.TestTableAdapter = New WindowsApplication1.databaseDataSetTableAdapters.TestTableAdapter
        Me.TextBoxQ = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBoxo1 = New System.Windows.Forms.TextBox
        Me.TextBoxo2 = New System.Windows.Forms.TextBox
        Me.TextBoxo3 = New System.Windows.Forms.TextBox
        Me.TextBoxo4 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'nextb
        '
        Me.nextb.Location = New System.Drawing.Point(118, 417)
        Me.nextb.Name = "nextb"
        Me.nextb.Size = New System.Drawing.Size(116, 39)
        Me.nextb.TabIndex = 10
        Me.nextb.Text = "Next"
        Me.nextb.UseVisualStyleBackColor = True
        '
        'finishb
        '
        Me.finishb.Location = New System.Drawing.Point(276, 417)
        Me.finishb.Name = "finishb"
        Me.finishb.Size = New System.Drawing.Size(116, 39)
        Me.finishb.TabIndex = 11
        Me.finishb.Text = "Done"
        Me.finishb.UseVisualStyleBackColor = True
        '
        'TextBoxans
        '
        Me.TextBoxans.BackColor = System.Drawing.Color.White
        Me.TextBoxans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxans.Location = New System.Drawing.Point(234, 356)
        Me.TextBoxans.Name = "TextBoxans"
        Me.TextBoxans.Size = New System.Drawing.Size(23, 20)
        Me.TextBoxans.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(141, 359)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Answer Option No"
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "Test"
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
        'TextBoxQ
        '
        Me.TextBoxQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxQ.Location = New System.Drawing.Point(43, 30)
        Me.TextBoxQ.Multiline = True
        Me.TextBoxQ.Name = "TextBoxQ"
        Me.TextBoxQ.Size = New System.Drawing.Size(334, 91)
        Me.TextBoxQ.TabIndex = 0
        Me.TextBoxQ.Text = "Type The Question Here"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(40, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Question"
        '
        'TextBoxo1
        '
        Me.TextBoxo1.Location = New System.Drawing.Point(43, 166)
        Me.TextBoxo1.Name = "TextBoxo1"
        Me.TextBoxo1.Size = New System.Drawing.Size(148, 20)
        Me.TextBoxo1.TabIndex = 2
        Me.TextBoxo1.Text = "Option1"
        '
        'TextBoxo2
        '
        Me.TextBoxo2.Location = New System.Drawing.Point(234, 166)
        Me.TextBoxo2.Name = "TextBoxo2"
        Me.TextBoxo2.Size = New System.Drawing.Size(148, 20)
        Me.TextBoxo2.TabIndex = 3
        Me.TextBoxo2.Text = "Option2"
        '
        'TextBoxo3
        '
        Me.TextBoxo3.Location = New System.Drawing.Point(43, 246)
        Me.TextBoxo3.Name = "TextBoxo3"
        Me.TextBoxo3.Size = New System.Drawing.Size(148, 20)
        Me.TextBoxo3.TabIndex = 4
        Me.TextBoxo3.Text = "Option3"
        '
        'TextBoxo4
        '
        Me.TextBoxo4.Location = New System.Drawing.Point(234, 246)
        Me.TextBoxo4.Name = "TextBoxo4"
        Me.TextBoxo4.Size = New System.Drawing.Size(148, 20)
        Me.TextBoxo4.TabIndex = 5
        Me.TextBoxo4.Text = "Option4"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(25, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "1."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(214, 249)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "4."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(25, 249)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "3."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(214, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "2."
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBoxo4)
        Me.GroupBox1.Controls.Add(Me.TextBoxo3)
        Me.GroupBox1.Controls.Add(Me.TextBoxo2)
        Me.GroupBox1.Controls.Add(Me.TextBoxo1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBoxQ)
        Me.GroupBox1.Location = New System.Drawing.Point(42, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(415, 298)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'maketest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.bg
        Me.ClientSize = New System.Drawing.Size(542, 486)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBoxans)
        Me.Controls.Add(Me.finishb)
        Me.Controls.Add(Me.nextb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "maketest"
        Me.Text = "Make Test"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nextb As System.Windows.Forms.Button
    Friend WithEvents finishb As System.Windows.Forms.Button
    Friend WithEvents TextBoxans As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DatabaseDataSet As WindowsApplication1.databaseDataSet
    Friend WithEvents TestTableAdapter As WindowsApplication1.databaseDataSetTableAdapters.TestTableAdapter
    Friend WithEvents TextBoxQ As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxo1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxo2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxo3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxo4 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
