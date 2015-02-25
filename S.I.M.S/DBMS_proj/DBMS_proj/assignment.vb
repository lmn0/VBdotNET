Public Class assignment
    Dim temp_class As String
    Dim temp_dept As String
    Dim temp_year As String
    Dim temp_assno As Integer
    Dim temp_str As String



    Private Sub assignment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet1.Student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.DatabaseDataSet1.Student)
        'TODO: This line of code loads data into the 'DatabaseDataSet1.Assignments' table. You can move, or remove it, as needed.
        temp_class = StudentTableAdapter.getclass_section(LoginForm1.UserIDTextBox.Text)
        temp_dept = StudentTableAdapter.getdept(LoginForm1.UserIDTextBox.Text)
        temp_year = StudentTableAdapter.getyear(LoginForm1.UserIDTextBox.Text)
        Me.AssignmentsTableAdapter.GetData(temp_class, temp_year, temp_dept)
        Me.AssignmentsTableAdapter.FillBy(Me.DatabaseDataSet1.Assignments, temp_class, temp_year, temp_dept)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBoxQuestion.Clear()
        temp_assno = Val(ComboBox1.Text)
        temp_str = AssignmentsTableAdapter.getquestion(temp_assno, temp_class, temp_dept, temp_year)
        TextBoxQuestion.Text = temp_str
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Student.Show()
        Me.Close()

    End Sub
End Class
