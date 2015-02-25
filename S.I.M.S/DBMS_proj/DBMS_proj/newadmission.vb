Public Class newadmission
    Dim file_path As String
    Dim dest As String

    Private Sub newadmission_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.Student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.DatabaseDataSet.Student)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        StudentTableAdapter.InsertQuery(TextBox7.Text, TextBox1.Text, TextBox2.Text, TextBox4.Text, TextBox3.Text, TextBox6.Text, Convert.ToDecimal(TextBox5.Text))
        dest = "Pics\" + TextBox7.Text + ".jpg"

        If (FileIO.FileSystem.FileExists(file_path)) Then
            FileCopy(file_path, dest)
        End If

        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        'FileCopy(file_path, "Pics\")
        MessageBox.Show("    Saved")

    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        OpenFileDialog1.ShowDialog()
        file_path = OpenFileDialog1.FileName()
        TextBox8.Text = file_path
    End Sub
End Class