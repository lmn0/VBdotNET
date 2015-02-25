Public Class Student
    Dim temp_rollno As String
    Dim flag As Integer = 0
    Dim piclocation As String

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub year_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles year.Click

    End Sub

    Private Sub Student_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet1.Assignments' table. You can move, or remove it, as needed.
        'Me.AssignmentsTableAdapter.Fill(Me.DatabaseDataSet1.Assignments)
        'TODO: This line of code loads data into the 'DatabaseDataSet1.Test' table. You can move, or remove it, as needed.
        Me.TestTableAdapter.Fill(Me.DatabaseDataSet1.Test)
        'TODO: This line of code loads data into the 'DatabaseDataSet1.Student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.DatabaseDataSet1.Student)
        Me.Invalidate()
        temp_rollno = LoginForm1.UserIDTextBox.Text
        labelname.Text = StudentTableAdapter.getname(temp_rollno)
        roll_no.Text = temp_rollno
        dept.Text = StudentTableAdapter.getdept(temp_rollno)
        class_section.Text = StudentTableAdapter.getclass_section(temp_rollno)
        year.Text = StudentTableAdapter.getyear(temp_rollno)
        cgpa.Text = StudentTableAdapter.getcgpa(temp_rollno)
        piclocation = "Pics\" + temp_rollno + ".jpg"

        If (FileIO.FileSystem.FileExists(piclocation)) Then
            PictureBox1.Invalidate()
            PictureBox1.Load(piclocation)
        End If


        If (StudentTableAdapter.gettest1mak(temp_rollno) <> -1) Then
            test1mark.Text = StudentTableAdapter.gettest1mak(temp_rollno)
        Else
            test1mark.Text = "Not Taken"
            flag = 1
        End If



        If (StudentTableAdapter.gettest2mark(temp_rollno) <> -1) Then
            test2mark.Text = StudentTableAdapter.gettest2mark(temp_rollno)
        Else
            test2mark.Text = "Not Taken"
            flag = 1
        End If



        If (StudentTableAdapter.gettest3mark(temp_rollno) <> -1) Then
            test3mark.Text = StudentTableAdapter.gettest3mark(temp_rollno)
        Else
            test3mark.Text = "Not Taken"
            flag = 1
        End If
        If (flag = 1) Then
            test_launch.Show()
        End If

        totalmarks.Text = StudentTableAdapter.gettotalmarks(temp_rollno)


    End Sub

    Private Sub assgn_launch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles assgn_launch.Click
        assignment.Show()
    End Sub

    Private Sub test_launch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles test_launch.Click
        testform.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        LoginForm1.Show()
        testform.Close()
        chngpwd.Close()
        assignment.Close()
        Me.Close()
        End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        chngpwd.Show()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
    End Sub
End Class