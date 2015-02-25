Public Class Staff
    Dim temp_id As String

    Private Sub Staff_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet1.Staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter.Fill(Me.DatabaseDataSet1.Staff)
        temp_id = LoginForm1.UserIDTextBox.Text
        label_class.Text = StaffTableAdapter.getclass(temp_id)
        label_dept.Text = StaffTableAdapter.getdept(temp_id)
        label_id.Text = temp_id
        label_name.Text = StaffTableAdapter.getname(temp_id)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        post_assgn.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        posttest1.Show()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        post_assgn.Close()
        posttest1.Close()
        chngpwd.Close()
        LoginForm1.Show()
        Me.Close()

    End Sub

    Private Sub ButtonChngPwd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonChngPwd.Click
        chngpwd.Show()
    End Sub
End Class