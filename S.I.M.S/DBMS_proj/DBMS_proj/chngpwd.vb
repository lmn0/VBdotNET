Public Class chngpwd

    Private Sub savePwd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles savePwd.Click
        ' 1=admin 2=staff 3=student
        Dim temp_finduser As Integer
        Dim temp_pwd As String
        temp_pwd = LoginForm1.TextBoxPwdentered.Text
        temp_finduser = Val(LoginForm1.FindWhatUser.Text)

        If (temp_finduser = 1) Then
            If Equals(TextBoxOldPwd.Text, temp_pwd) Then
                AdministratorTableAdapter.changePwd(TextBoxNewPwd.Text, LoginForm1.UserIDTextBox.Text)
                MessageBox.Show("Saved!")
            Else
                MessageBox.Show("Password did not match!")
            End If
        ElseIf (temp_finduser = 2) Then
            If Equals(TextBoxOldPwd.Text, temp_pwd) Then
                StaffTableAdapter.changePwd(TextBoxNewPwd.Text, LoginForm1.UserIDTextBox.Text)
                MessageBox.Show("Saved!")
            Else
                MessageBox.Show("Password did not match!")
            End If
        ElseIf (temp_finduser = 3) Then
            If Equals(TextBoxOldPwd.Text, temp_pwd) Then
                StudentTableAdapter.changePwd(TextBoxNewPwd.Text, LoginForm1.UserIDTextBox.Text)
                MessageBox.Show("Saved!")
            Else
                MessageBox.Show("Password did not match!")
            End If

        End If
        TextBoxNewPwd.Clear()
        TextBoxOldPwd.Clear()


    End Sub

    Private Sub chngpwd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet1.Administrator' table. You can move, or remove it, as needed.
        Me.AdministratorTableAdapter.Fill(Me.DatabaseDataSet1.Administrator)
        'TODO: This line of code loads data into the 'DatabaseDataSet1.Student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.DatabaseDataSet1.Student)
        'TODO: This line of code loads data into the 'DatabaseDataSet1.Staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter.Fill(Me.DatabaseDataSet1.Staff)

    End Sub
End Class