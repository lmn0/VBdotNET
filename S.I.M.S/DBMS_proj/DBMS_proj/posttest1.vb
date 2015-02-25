
Public Class posttest1
    Public tn As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (TestTableAdapter.nooftest(TextBoxyear.Text, TextBoxdept.Text, TextBoxclass.Text) <> 3) Then
            tn = TestTableAdapter.nooftest(TextBoxyear.Text, TextBoxdept.Text, TextBoxclass.Text)
            maketest.Show()
        Else
            MessageBox.Show("  Sorry 3 Tests already posted for this class")
        End If
    End Sub

    Private Sub posttest1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.Test' table. You can move, or remove it, as needed.
        'Me.TestTableAdapter.Fill(Me.DatabaseDataSet.Test)

    End Sub
End Class