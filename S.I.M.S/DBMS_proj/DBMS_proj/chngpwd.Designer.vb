<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class chngpwd
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
        Me.savePwd = New System.Windows.Forms.Button
        Me.TextBoxOldPwd = New System.Windows.Forms.TextBox
        Me.TextBoxNewPwd = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSet1 = New WindowsApplication1.databaseDataSet
        Me.StaffTableAdapter = New WindowsApplication1.databaseDataSetTableAdapters.StaffTableAdapter
        Me.StudentTableAdapter = New WindowsApplication1.databaseDataSetTableAdapters.StudentTableAdapter
        Me.AdministratorTableAdapter = New WindowsApplication1.databaseDataSetTableAdapters.AdministratorTableAdapter
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'savePwd
        '
        Me.savePwd.Location = New System.Drawing.Point(87, 176)
        Me.savePwd.Name = "savePwd"
        Me.savePwd.Size = New System.Drawing.Size(120, 23)
        Me.savePwd.TabIndex = 0
        Me.savePwd.Text = "Save Password"
        Me.savePwd.UseVisualStyleBackColor = True
        '
        'TextBoxOldPwd
        '
        Me.TextBoxOldPwd.Location = New System.Drawing.Point(97, 57)
        Me.TextBoxOldPwd.Name = "TextBoxOldPwd"
        Me.TextBoxOldPwd.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxOldPwd.TabIndex = 1
        '
        'TextBoxNewPwd
        '
        Me.TextBoxNewPwd.Location = New System.Drawing.Point(97, 95)
        Me.TextBoxNewPwd.Name = "TextBoxNewPwd"
        Me.TextBoxNewPwd.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxNewPwd.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(19, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Old Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(19, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "New Password"
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "Administrator"
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
        'StudentTableAdapter
        '
        Me.StudentTableAdapter.ClearBeforeFill = True
        '
        'AdministratorTableAdapter
        '
        Me.AdministratorTableAdapter.ClearBeforeFill = True
        '
        'chngpwd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(305, 227)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxNewPwd)
        Me.Controls.Add(Me.TextBoxOldPwd)
        Me.Controls.Add(Me.savePwd)
        Me.MaximizeBox = False
        Me.Name = "chngpwd"
        Me.Text = "Change Password"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents savePwd As System.Windows.Forms.Button
    Friend WithEvents TextBoxOldPwd As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNewPwd As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DatabaseDataSet1 As WindowsApplication1.databaseDataSet
    Friend WithEvents StaffTableAdapter As WindowsApplication1.databaseDataSetTableAdapters.StaffTableAdapter
    Friend WithEvents StudentTableAdapter As WindowsApplication1.databaseDataSetTableAdapters.StudentTableAdapter
    Friend WithEvents AdministratorTableAdapter As WindowsApplication1.databaseDataSetTableAdapters.AdministratorTableAdapter
End Class
