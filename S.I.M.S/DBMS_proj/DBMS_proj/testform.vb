Public Class testform
    Public t1, t2, t3, tn As Integer
    Dim no_oftest As Integer



    Private Sub testform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.Student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.DatabaseDataSet.Student)
        'TODO: This line of code loads data into the 'DatabaseDataSet.Student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.DatabaseDataSet.Student)
        'TODO: This line of code loads data into the 'DatabaseDataSet.Test' table. You can move, or remove it, as needed.

        Me.TestTableAdapter.Fill(Me.DatabaseDataSet.Test)

        t1 = StudentTableAdapter.gettest1mak(Student.roll_no.Text)
        t2 = StudentTableAdapter.gettest2mark(Student.roll_no.Text)
        t3 = StudentTableAdapter.gettest3mark(Student.roll_no.Text)
        no_oftest = TestTableAdapter.nooftest(Student.year.Text, Student.dept.Text, Student.class_section.Text)
        If (no_oftest > 0) Then


            If (t1 = -1 And 1 <= no_oftest) Then

                ComboBox1.Items.Add("1")
            End If

            If (t2 = -1 And 2 <= no_oftest) Then
                ComboBox1.Items.Add("2")
            End If

            If (t3 = -1 And 3 <= no_oftest) Then
                ComboBox1.Items.Add("3")
            End If

        End If



    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        tn = Val(ComboBox1.Text)

        Me.Hide()

        If (Equals(tn, 1) And t1 <> -1) Then
            MessageBox.Show("  Test Already Taken")
            
        ElseIf (Equals(tn, 1)) Then
            test1.Show()
            
        End If




        If (Equals(tn, 2) And t2 <> -1) Then
            MessageBox.Show("  Test Already Taken")
            
        ElseIf (Equals(tn, 2)) Then
            test1.Show()
            
        End If




        If (Equals(tn, 3) And t3 <> -1) Then
            MessageBox.Show("  Test Already Taken")
            
        ElseIf (Equals(tn, 3)) Then
            test1.Show()

        End If


        If (tn = 0) Then
            MessageBox.Show("  Pls Select A Test Number")
        End If

        
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Student.Show()
        Me.Close()
    End Sub
End Class