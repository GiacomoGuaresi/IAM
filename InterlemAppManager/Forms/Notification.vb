Public Class Notification

    Public titolo As String
    Public testo As String
    Public link As String

    Private Sub Notification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - Size.Width - 20, Screen.PrimaryScreen.WorkingArea.Height - Size.Height - 20)
        Label2.Text = titolo
        TextBox1.Text = testo
        TextBox1.SelectionStart = 0
        TextBox1.SelectionLength = 0

        Label1.Select()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Me.Opacity >= 1 Then
            Timer1.Stop()
            Exit Sub
        End If
        Me.Opacity += 0.3
    End Sub

    Private Sub Notification_Click(sender As Object, e As EventArgs) Handles Me.Click
        Process.Start(link)
        Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Process.Start(link)
        Close()
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        Process.Start(link)
        Close()
    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click
        Close()

    End Sub

End Class