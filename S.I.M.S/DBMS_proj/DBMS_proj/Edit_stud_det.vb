Public Class Edit_stud_det

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        StudentTableAdapter.UpdateQuery(TextBoxname.Text, TextBoxpwd.Text, TextBoxyear.Text, TextBoxclass.Text, TextBoxdept.Text, Val(TextBoxcgpa.Text), TextBoxrollno.Text)
        TextBoxcgpa.Clear()
        TextBoxyear.Clear()
        TextBoxclass.Clear()
        TextBoxdept.Clear()
        TextBoxname.Clear()
        TextBoxpwd.Clear()
        TextBoxrollno.Clear()
        MessageBox.Show("   Saved")

    End Sub

    Private Sub Edit_stud_det_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.Student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.DatabaseDataSet.Student)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (Comparer.Equals(TextBoxrollno.Text, StudentTableAdapter.getrollno(TextBoxrollno.Text))) Then
            GroupBox1.Show()
            TextBoxcgpa.AppendText(StudentTableAdapter.getcgpa(TextBoxrollno.Text))
            TextBoxyear.AppendText(StudentTableAdapter.getyear(TextBoxrollno.Text))
            TextBoxclass.AppendText(StudentTableAdapter.getclass_section(TextBoxrollno.Text))
            TextBoxdept.AppendText(StudentTableAdapter.getdept(TextBoxrollno.Text))
            TextBoxname.AppendText(StudentTableAdapter.getname(TextBoxrollno.Text))
            TextBoxpwd.AppendText(StudentTableAdapter.getpwd(TextBoxrollno.Text))
        Else
            MessageBox.Show("Sorry No Student In This Roll Number")
        End If
    End Sub
End Class