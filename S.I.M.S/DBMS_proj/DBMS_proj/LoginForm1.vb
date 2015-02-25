Public Class LoginForm1
     ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If Equals(PasswordTextBox.Text, AdministratorTableAdapter.getpwd(UserIDTextBox.Text)) Then
            FindWhatUser.Text = 1
            TextBoxPwdentered.Text = PasswordTextBox.Text
            admin_window.Show()

            Me.Hide()
        ElseIf Equals(PasswordTextBox.Text, StaffTableAdapter.getpwd(UserIDTextBox.Text)) Then
            FindWhatUser.Text = 2
            TextBoxPwdentered.Text = PasswordTextBox.Text
            Staff.Show()

            Me.Hide()
        ElseIf Equals(PasswordTextBox.Text, StudentTableAdapter.getpwd(UserIDTextBox.Text)) Then
            FindWhatUser.Text = 3
            TextBoxPwdentered.Text = PasswordTextBox.Text
            Student.Show()

            Me.Hide()
        Else
            MessageBox.Show("Wrong Username/password. Try Again!")
        End If

        PasswordTextBox.Clear()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet1.Student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.DatabaseDataSet1.Student)
        'TODO: This line of code loads data into the 'DatabaseDataSet1.Staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter.Fill(Me.DatabaseDataSet1.Staff)
        'TODO: This line of code loads data into the 'DatabaseDataSet1.Administrator' table. You can move, or remove it, as needed.
        Me.AdministratorTableAdapter.Fill(Me.DatabaseDataSet1.Administrator)
    End Sub

    Private Sub UsernameLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub LogoPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoPictureBox.Click
        AboutBox1.Show()
    End Sub
End Class
