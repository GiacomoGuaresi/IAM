Public Class MiniBrowser

    Private link As String
    Private color As Color
    Private colorButton As Color

    Public Sub showTool(ToolbarLink, ToolbarColor, ToolbarColorButton)
        link = ToolbarLink
        color = ToolbarColor
        colorButton = ToolbarColorButton

        Me.Show()

    End Sub


    Private Sub MiniBrowser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Location = New Point(0, (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2)
        Panel1.BackColor = color
        Panel2.BackColor = color
        Button1.BackColor = colorButton

        WebBrowser1.Navigate(link)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

End Class