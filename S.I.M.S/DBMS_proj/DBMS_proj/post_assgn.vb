Public Class post_assgn

    Private Sub postassgn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles postassgn.Click
        AssignmentsTableAdapter.post_new_assgn(Val(TextBoxAssgnNo.Text), TextBoxQuestion.Text, TextBoxYear.Text, TextBoxClass.Text, TextBoxDept.Text)
        TextBoxAssgnNo.Clear()
        TextBoxClass.Clear()
        TextBoxDept.Clear()
        TextBoxQuestion.Clear()
        MessageBox.Show("Assignment Posted!")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Staff.Show()
        Me.Close()
    End Sub
End Class