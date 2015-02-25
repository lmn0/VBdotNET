Public Class newstafff

    Private Sub Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button.Click
        StaffTableAdapter.InsertQuery(textboxStaffID.Text, TextBoxSname.Text, TextBoxPassword.Text, TextBoxDept.Text, TextBoxClass.Text)
        TextBoxClass.Clear()
        TextBoxDept.Clear()
        TextBoxPassword.Clear()
        TextBoxSname.Clear()
        textboxStaffID.Clear()
        MessageBox.Show("    Saved")

    End Sub

    Private Sub newstaff_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.Staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter.Fill(Me.DatabaseDataSet.Staff)

    End Sub
End Class