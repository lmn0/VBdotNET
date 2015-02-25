Public Class admin_window

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editstaff.Click
        Edit_staff_det.Show()

    End Sub

    Private Sub newadm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles newadm.Click
        newadmission.show()

    End Sub

    Private Sub newstaff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles newstaff.Click

        newstafff.Show()

    End Sub

    Private Sub editstudent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editstudent.Click
        Edit_stud_det.Show()

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        LoginForm1.Show()
        Edit_stud_det.Close()
        Edit_staff_det.Close()
        newadmission.Close()
        newstafff.Close()
        chngpwd.Close()
        Me.Close()
    End Sub

    Private Sub admin_window_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet1.Administrator' table. You can move, or remove it, as needed.
        Labeladminname.Text = LoginForm1.UserIDTextBox.Text
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        chngpwd.Show()
    End Sub
End Class
