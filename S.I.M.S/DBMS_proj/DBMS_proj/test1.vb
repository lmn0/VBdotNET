Public Class test1


    Dim ans(10) As Integer
    Dim count As Integer = 1


    Private Sub test1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.Student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.DatabaseDataSet.Student)
        'TODO: This line of code loads data into the 'DatabaseDataSet.Test' table. You can move, or remove it, as needed.
        Me.TestTableAdapter.Fill(Me.DatabaseDataSet.Test)



        For i As Integer = 1 To 10
            ans(i) = 0
        Next

        ButtonPrev.Hide()
        Label7.Text = count
        TextBoxQuestion.AppendText(TestTableAdapter.getQ(testform.tn, count, Student.year.Text, Student.dept.Text, Student.class_section.Text))
        TextBoxOpt1.AppendText(TestTableAdapter.geto1(testform.tn, count, Student.year.Text, Student.dept.Text, Student.class_section.Text))
        TextBoxopt2.AppendText(TestTableAdapter.geto2(testform.tn, count, Student.year.Text, Student.dept.Text, Student.class_section.Text))
        TextBoxOpt3.AppendText(TestTableAdapter.geto3(testform.tn, count, Student.year.Text, Student.dept.Text, Student.class_section.Text))
        TextBoxOpt4.AppendText(TestTableAdapter.geto4(testform.tn, count, Student.year.Text, Student.dept.Text, Student.class_section.Text))
        If (count + 1 <= TestTableAdapter.getqn(testform.tn, Student.year.Text, Student.dept.Text, Student.class_section.Text)) Then
            ButtonNext.Show()
        Else
            ButtonNext.Hide()
            Button3.Show()
        End If

    End Sub

    Private Sub ButtonNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNext.Click
        ans(count) = Val(TextBoxAns.Text)
        count = count + 1
        If (count <= TestTableAdapter.getqn(testform.tn, Student.year.Text, Student.dept.Text, Student.class_section.Text)) Then

            TextBoxOpt1.Clear()
            TextBoxopt2.Clear()
            TextBoxOpt3.Clear()
            TextBoxOpt4.Clear()
            TextBoxQuestion.Clear()
            TextBoxAns.Text = ans(count)
            Label7.Text = count
            TextBoxQuestion.AppendText(TestTableAdapter.getQ(testform.tn, count, Student.year.Text, Student.dept.Text, Student.class_section.Text))
            TextBoxOpt1.AppendText(TestTableAdapter.geto1(testform.tn, count, Student.year.Text, Student.dept.Text, Student.class_section.Text))
            TextBoxopt2.AppendText(TestTableAdapter.geto2(testform.tn, count, Student.year.Text, Student.dept.Text, Student.class_section.Text))
            TextBoxOpt3.AppendText(TestTableAdapter.geto3(testform.tn, count, Student.year.Text, Student.dept.Text, Student.class_section.Text))
            TextBoxOpt4.AppendText(TestTableAdapter.geto4(testform.tn, count, Student.year.Text, Student.dept.Text, Student.class_section.Text))
            If (count > 1) Then
                ButtonPrev.Show()
            End If
            If (count < TestTableAdapter.getqn(testform.tn, Student.year.Text, Student.dept.Text, Student.class_section.Text)) Then
                ButtonNext.Show()
            Else
                ButtonNext.Hide()
                Button3.Show()
            End If
        End If

    End Sub

    Private Sub ButtonPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPrev.Click

        count = count - 1

        TextBoxOpt1.Clear()
        TextBoxopt2.Clear()
        TextBoxOpt3.Clear()
        TextBoxOpt4.Clear()
        TextBoxQuestion.Clear()
        TextBoxAns.Text = 0

        Label7.Text = count
        TextBoxAns.Text = ans(count)
        TextBoxQuestion.AppendText(TestTableAdapter.getQ(testform.tn, count, Student.year.Text, Student.dept.Text, Student.class_section.Text))
        TextBoxOpt1.AppendText(TestTableAdapter.geto1(testform.tn, count, Student.year.Text, Student.dept.Text, Student.class_section.Text))
        TextBoxopt2.AppendText(TestTableAdapter.geto2(testform.tn, count, Student.year.Text, Student.dept.Text, Student.class_section.Text))
        TextBoxOpt3.AppendText(TestTableAdapter.geto3(testform.tn, count, Student.year.Text, Student.dept.Text, Student.class_section.Text))
        TextBoxOpt4.AppendText(TestTableAdapter.geto4(testform.tn, count, Student.year.Text, Student.dept.Text, Student.class_section.Text))

        If (count = 1) Then
            ButtonPrev.Hide()
        End If

        If (count < TestTableAdapter.getqn(testform.tn, Student.year.Text, Student.dept.Text, Student.class_section.Text)) Then
            ButtonNext.Show()
            Button3.Hide()
        Else
            ButtonNext.Hide()
        End If


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim j As Integer = 1
        Dim mark As Integer = 0
        Dim t1mark As Integer
        Dim t2mark As Integer
        Dim t3mark As Integer
        Dim totalmark As Integer


        ans(count) = Val(TextBoxAns.Text)

       
        While j <= count
            If (ans(j) = TestTableAdapter.getans(testform.tn, j, Student.year.Text, Student.dept.Text, Student.class_section.Text)) Then
                mark = mark + 1
            End If
            j = j + 1
        End While

        If (testform.tn = 1) Then
            StudentTableAdapter.utest1(mark, Student.roll_no.Text)

        End If
        If (testform.tn = 2) Then
            StudentTableAdapter.utest2(mark, Student.roll_no.Text)

        End If
        If (testform.tn = 3) Then
            StudentTableAdapter.utest3(mark, Student.roll_no.Text)

        End If

        t1mark = StudentTableAdapter.gettest1mak(Student.roll_no.Text)
        t2mark = StudentTableAdapter.gettest2mark(Student.roll_no.Text)
        t3mark = StudentTableAdapter.gettest3mark(Student.roll_no.Text)
        If (t1mark < 0) Then
            t1mark = 0
        End If
        If (t2mark < 0) Then
            t2mark = 0
        End If
        If (t3mark < 0) Then
            t3mark = 0
        End If
        totalmark = Val(t1mark + t2mark + t3mark)

        StudentTableAdapter.settotalmark(totalmark, Student.roll_no.Text)

        Student.Close()
        Student.Show()
        testform.Close()
        Me.Close()
        
    End Sub

    Private Sub TextBoxAns_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxAns.TextChanged

    End Sub
End Class