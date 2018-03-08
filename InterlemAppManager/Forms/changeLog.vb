Public Class changeLog
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub changeLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Resources.ChangeLog
    End Sub
End Class