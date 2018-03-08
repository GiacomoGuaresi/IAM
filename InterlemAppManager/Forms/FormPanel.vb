Public Class FormPanel
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackColor = My.Settings.Background
        Size = New Size(50, Screen.PrimaryScreen.WorkingArea.Height)
        Opacity = My.Settings.BackgroundA / 100
    End Sub

End Class
