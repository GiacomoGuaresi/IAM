Imports System
Imports System.Net
Imports System.IO

Public Class FormPanelInternal

    Private Sub FormPanelInternal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Size = New Size(50, Screen.PrimaryScreen.WorkingArea.Height)
        Me.TransparencyKey = Color.LightBlue
        Me.BackColor = Color.LightBlue
    End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click
        Dim webAddress As String = "http://projects.interlem.it"
        Process.Start(webAddress)
        FormButton.BarToggle()
    End Sub

    Private Sub Panel2_Click(sender As Object, e As EventArgs) Handles Panel2.Click
        Dim webAddress As String = "https://mail.google.com"
        Process.Start(webAddress)
        FormButton.BarToggle()
    End Sub

    Private Sub Panel3_Click(sender As Object, e As EventArgs) Handles Panel3.Click
        Dim webAddress As String = "http://hangouts.google.com"
        Process.Start(webAddress)
        FormButton.BarToggle()
    End Sub

    Private Sub Panel4_Click(sender As Object, e As EventArgs) Handles Panel4.Click
        Dim webAddress As String = "https://www.antexweb.net/portal/auth/portal/default"
        Process.Start(webAddress)
        FormButton.BarToggle()
    End Sub

    Private Sub Panel5_Click(sender As Object, e As EventArgs) Handles Panel5.Click
        Dim webAddress As String = "http://timesheet.interlem.it/timesheet/login.jsp"
        Process.Start(webAddress)
        FormButton.BarToggle()
    End Sub

    Private Sub Panel6_Click(sender As Object, e As EventArgs) Handles Panel6.Click
        Dim webAddress As String = "https://support.interlem.it/otrs/index.pl"
        Process.Start(webAddress)
        FormButton.BarToggle()
    End Sub

    Private Sub Panel7_Click(sender As Object, e As EventArgs) Handles Panel7.Click
        Dim webAddress As String = "https://calendar.google.com"
        Process.Start(webAddress)
        FormButton.BarToggle()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim sURL As String
        sURL = "https://www.googleapis.com/gmail/v1/users/me/drafts?includeSpamTrash=true&q=is%3Aincoming"

        Dim wrGETURL As WebRequest
        wrGETURL = WebRequest.Create(sURL)

        Dim myProxy As New WebProxy("myproxy", 80)
        myProxy.BypassProxyOnLocal = True

        'wrGETURL.Proxy = myProxy
        wrGETURL.Proxy = WebProxy.GetDefaultProxy()

        Dim objStream As Stream
        objStream = wrGETURL.GetResponse.GetResponseStream()

        Dim objReader As New StreamReader(objStream)
        Dim sLine As String = ""
        Dim i As Integer = 0

        Do While Not sLine Is Nothing
            i += 1
            sLine = objReader.ReadLine
            If Not sLine Is Nothing Then
                Console.WriteLine("{0}:{1}", i, sLine)
            End If
        Loop

        Console.ReadLine()


    End Sub

End Class