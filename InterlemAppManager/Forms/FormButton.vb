Imports System
Imports S22.Imap

Public Class FormButton

    Dim PanelState As Boolean = False
    Dim positionHeight As Integer = (Screen.PrimaryScreen.WorkingArea.Height - 200) / 2
    Dim movimento As Boolean = False
    Dim moment As DateTime
    Dim scheduled_timesheet_enabled As Boolean = False
    Dim yMousePositionStart As Integer = 0

    Public Sub BarToggle()
        If (PanelState) Then
            Location = New Point(0, positionHeight)
            FormPanel.Hide()
            FormPanelInternal.Hide()

        Else
            Location = New Point(50, positionHeight)
            FormPanel.Show()
            FormPanelInternal.Show()
        End If
        PanelState = Not PanelState
        Return
    End Sub

    Private Sub FormButton_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Size = New Size(18, 120)
        Location = New Point(0, (Screen.PrimaryScreen.WorkingArea.Height - 200) / 2)
        BackColor = My.Settings.Background
        Opacity = My.Settings.BackgroundA / 100
    End Sub

    Private Sub FormButton_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        ' move graphics origin to where you want the label
        e.Graphics.TranslateTransform(14, 10)
        ' rotate it 90 degrees
        e.Graphics.RotateTransform(90)
        ' draw the text


        If (Int(My.Settings.Background.R) + Int(My.Settings.Background.G) + Int(My.Settings.Background.B)) / 3 > 122 Then
            e.Graphics.DrawString("Interlem Application", Font, Brushes.Black, New Point(0, 0))
        Else
            e.Graphics.DrawString("Interlem Application", Font, Brushes.White, New Point(0, 0))
        End If


    End Sub

    Private Sub FormButton_Click(sender As Object, e As EventArgs) Handles Me.Click
        If Not movimento Then
            BarToggle()
        End If

    End Sub

    Private Sub timerTick()
        moment = DateTime.Now

        If (moment.Hour >= My.MySettings.Default.Timesheet_Hour) And (moment.Minute >= My.MySettings.Default.Timesheet_Min) And (scheduled_timesheet_enabled = False) Then
            scheduled_timesheet_enabled = True
            Notification.testo = My.MySettings.Default.Timesheet_Testo
            Notification.titolo = My.MySettings.Default.Timesheet_Titolo
            Notification.link = My.MySettings.Default.Timesheet_Link
            Notification.Show()
        End If

        Using Client As ImapClient = New ImapClient("imap.gmail.com", 993, My.Settings.Mail_Config_Indirizzo, My.Settings.Mail_Config_Password, AuthMethod.Login, True)
            Dim n As Integer = Client.Search(SearchCondition.Unseen()).Count
            If n >= 1 Then
                Notification.testo = My.MySettings.Default.Mail_Testo.Replace("{n}", n)
                Notification.titolo = My.MySettings.Default.Mail_Titolo
                Notification.link = My.MySettings.Default.Mail_Link
                Notification.Show()
            End If

        End Using
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timerTick()
    End Sub

    Private Sub EsciToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EsciToolStripMenuItem.Click
        Application.Exit()

    End Sub

    Private Sub FormButton_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter
        BackColor = ControlPaint.Light(My.Settings.Background)

    End Sub

    Private Sub FormButton_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
        BackColor = My.Settings.Background

    End Sub

    Private Sub InformazioniToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformazioniToolStripMenuItem.Click
        AboutBox1.Show()

    End Sub

    Private Sub SettingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingToolStripMenuItem.Click
        Settings.Show()
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Activate()

    End Sub

    Private Sub ChangelogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangelogToolStripMenuItem.Click
        changeLog.Show()
    End Sub

    Private Sub FormButton_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left And Not PanelState And Math.Abs(MousePosition.Y - yMousePositionStart) > 20 Then
            yMousePositionStart = 0
            movimento = True
            positionHeight = MousePosition.Y - (Size.Height / 2)
            Location = New Point(0, positionHeight)
        ElseIf movimento Then
            movimento = False
        End If

    End Sub

    Private Sub FormButton_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        yMousePositionStart = MousePosition.Y
    End Sub

    Private Sub SynkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SynkToolStripMenuItem.Click
        timerTick()
    End Sub
End Class