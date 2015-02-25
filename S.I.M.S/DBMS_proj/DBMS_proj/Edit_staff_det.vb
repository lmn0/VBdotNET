Public Class Edit_staff_det

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (Comparer.Equals(StaffTableAdapter.getid(TextBoxid.Text), TextBoxid.Text)) Then
            GroupBox1.Show()
            TextBoxclass.AppendText(StaffTableAdapter.getclass(TextBoxid.Text))
            TextBoxdept.AppendText(StaffTableAdapter.getdept(TextBoxid.Text))
            TextBoxname.AppendText(StaffTableAdapter.getname(TextBoxid.Text))
            TextBoxpwd.AppendText(StaffTableAdapter.getpwd(TextBoxid.Text))
        Else
            MessageBox.Show("   Sorry The Staff Does Not Exist")
        End If
    End Sub

    Private Sub Edit_staff_det_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.Staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter.Fill(Me.DatabaseDataSet.Staff)

    End Sub



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        StaffTableAdapter.UpdateQuery(TextBoxname.Text, TextBoxpwd.Text, TextBoxdept.Text, TextBoxclass.Text, TextBoxid.Text)
        TextBoxclass.Clear()
        TextBoxdept.Clear()
        TextBoxid.Clear()
        TextBoxname.Clear()
        TextBoxpwd.Clear()
        MessageBox.Show("   Saved")

    End Sub
End Class