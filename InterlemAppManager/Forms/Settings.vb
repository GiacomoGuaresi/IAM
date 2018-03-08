Imports System.Xml
Imports System.IO
Imports System.Text

Public Class Settings

    Private Sub CLI_RUN()

        Select Case TextBox1.Text
            Case "popup"
                Notification.testo = "Testo"
                Notification.titolo = "Titolo"
                Notification.link = "http://www.google.it"
                Notification.Show()

            Case "miniBrowser"
                MiniBrowser.showTool("www.google.it", Color.White, Color.LightGray)

            Case "miniBrowser.keep"
                MiniBrowser.showTool("keep.google.com", Color.FromArgb(255, 160, 0), Color.FromArgb(255, 179, 0))
            Case "miniBrowser.timesheet"
                MiniBrowser.showTool("timesheet.interlem.it/timesheet/login.jsp", Color.FromArgb(255, 160, 0), Color.FromArgb(255, 179, 0))
            Case "miniBrowser.openproject"
                MiniBrowser.showTool("projects.interlem.it", Color.FromArgb(255, 160, 0), Color.FromArgb(255, 179, 0))
            Case "miniBrowser.gmail"
                MiniBrowser.showTool("mail.google.com", Color.FromArgb(255, 160, 0), Color.FromArgb(255, 179, 0))
            Case "miniBrowser.openproject"
                MiniBrowser.showTool("projects.interlem.it", Color.FromArgb(255, 160, 0), Color.FromArgb(255, 179, 0))
            Case "miniBrowser.otrs"
                MiniBrowser.showTool("support.interlem.it/otrs/index.pl", Color.FromArgb(255, 160, 0), Color.FromArgb(255, 179, 0))
            Case "miniBrowser.calendar"
                MiniBrowser.showTool("file:///" & System.IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\") & "calendar.html", Color.FromArgb(255, 160, 0), Color.FromArgb(255, 179, 0))

            Case "launchpad"
                LaunchPad.Show()
            Case Else
                Debug.WriteLine("unknown command")
        End Select

        TextBox1.Text = ""

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CLI_RUN()
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            CLI_RUN()
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'configurazioni mail
        TextBox2.Text = My.Settings.Mail_Config_Indirizzo
        TextBox4.Text = My.Settings.Mail_Config_Password
        TextBox5.Text = My.Settings.Mail_Titolo
        TextBox6.Text = My.Settings.Mail_Testo
        TextBox7.Text = My.Settings.Mail_Link

        'configurazioni timesheet
        TextBox9.Text = My.Settings.Timesheet_Titolo
        TextBox8.Text = My.Settings.Timesheet_Testo
        TextBox3.Text = My.Settings.Timesheet_Link
        NumericUpDown1.Value = My.Settings.Timesheet_Hour
        NumericUpDown2.Value = My.Settings.Timesheet_Min

        'aspetto
        Button5.BackColor = My.Settings.Background
        NumericUpDown3.Value = My.Settings.BackgroundA


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'configurazioni mail
        My.Settings.Mail_Config_Indirizzo = TextBox2.Text
        My.Settings.Mail_Config_Password = TextBox4.Text
        My.Settings.Mail_Titolo = TextBox5.Text
        My.Settings.Mail_Testo = TextBox6.Text
        My.Settings.Mail_Link = TextBox7.Text

        'configurazioni timesheet
        My.Settings.Timesheet_Titolo = TextBox9.Text
        My.Settings.Timesheet_Testo = TextBox8.Text
        My.Settings.Timesheet_Link = TextBox3.Text
        My.Settings.Timesheet_Hour = NumericUpDown1.Value
        My.Settings.Timesheet_Min = NumericUpDown2.Value

        'aspetto
        My.Settings.Background = Button5.BackColor
        My.Settings.BackgroundA = NumericUpDown3.Value

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Button2.PerformClick()
        Close()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        If (ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Button5.BackColor = ColorDialog1.Color
        End If

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

End Class