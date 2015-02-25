Public Class maketest
    Public qn As Integer

    Private Sub maketest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.Test' table. You can move, or remove it, as needed.
        Me.TestTableAdapter.Fill(Me.DatabaseDataSet.Test)
        qn = 1

    End Sub

    Private Sub nextb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nextb.Click

        TestTableAdapter.InsertQuery(qn, posttest1.tn + 1, TextBoxQ.Text, TextBoxo1.Text, TextBoxo2.Text, TextBoxo3.Text, TextBoxo4.Text, Val(TextBoxans.Text), posttest1.TextBoxyear.Text, posttest1.TextBoxclass.Text, posttest1.TextBoxdept.Text)
        qn = qn + 1
        TextBoxans.Clear()
        TextBoxo1.Clear()
        TextBoxo2.Clear()
        TextBoxo3.Clear()
        TextBoxo4.Clear()
        TextBoxQ.Clear()
    End Sub

    Private Sub finishb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles finishb.Click
        MessageBox.Show("  Saved")
        Me.Close()
    End Sub
End Class