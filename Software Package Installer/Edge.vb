Imports System.Net
Imports MaterialSkin
Public Class Edge
    Dim NuovP As System.Drawing.Point
    Dim x, p As Integer

    Private Sub Panel8_MouseEnter(sender As Object, e As EventArgs) Handles Panel8.MouseEnter
        x = Control.MousePosition.X - Me.Location.X
        p = Control.MousePosition.Y - Me.Location.Y
    End Sub


    Private Sub Edge_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ProgressBar1.Show()

        download.DownloadFileAsync(New Uri("https://612092f6-6003-49d0-8fe5-2e737d705081.usrfiles.com/archives/612092_df54e0d02127427485704b0a57847d3c.zip"), Texbbb.TextBox4.Text)

        Timer1.Start()





        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Blue") Then
            Timer5.Start()
            Timer6.Stop()
            Timer7.Stop()
            Timer8.Stop()
            Timer9.Stop()
            Timer12.Stop()

        End If


        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Red") Then
            Timer5.Stop()
            Timer6.Start()
            Timer7.Stop()
            Timer8.Stop()
            Timer9.Stop()
            Timer12.Stop()

        End If

        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Green") Then
            Timer5.Stop()
            Timer6.Stop()
            Timer7.Start()
            Timer8.Stop()
            Timer9.Stop()
            Timer12.Stop()

        End If

        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Orange") Then
            Timer5.Stop()
            Timer6.Stop()
            Timer7.Stop()
            Timer8.Start()
            Timer9.Stop()
            Timer12.Stop()

        End If

        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Purple") Then
            Timer5.Stop()
            Timer6.Stop()
            Timer7.Stop()
            Timer8.Stop()
            Timer9.Start()
            Timer12.Stop()

        End If


        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Gold") Then
            Timer5.Stop()
            Timer6.Stop()
            Timer7.Stop()
            Timer8.Stop()
            Timer9.Stop()
            Timer12.Start()
        End If







    End Sub

    Public WithEvents download As New WebClient


    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub download_DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs) Handles download.DownloadProgressChanged
        ProgressBar1.Value = e.ProgressPercentage

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MaterialButton2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Panel8.BackColor = Color.FromArgb(TrackBar1.Value, Color.RoyalBlue)
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        Panel8.BackColor = Color.FromArgb(TrackBar1.Value, Color.Red)
    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        Panel8.BackColor = Color.FromArgb(TrackBar1.Value, Color.Green)
    End Sub

    Private Sub Timer8_Tick(sender As Object, e As EventArgs) Handles Timer8.Tick
        Panel8.BackColor = Color.FromArgb(TrackBar1.Value, Color.Orange)
    End Sub

    Private Sub Timer9_Tick(sender As Object, e As EventArgs) Handles Timer9.Tick
        Panel8.BackColor = Color.FromArgb(TrackBar1.Value, Color.Purple)
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)
        ProgressBar1.Show()

        'Panel1.Hide()
        'Panel7.Hide()
        'download.DownloadFileAsync(New Uri("https://612092f6-6003-49d0-8fe5-2e737d705081.usrfiles.com/archives/612092_ca94125c1ea449b4bf114913f3c4d2ee.zip"), TextBox1.Text)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value = 100 Then
            Me.Close()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ProgressBar1.Show()
        download.DownloadFileAsync(New Uri("https://612092f6-6003-49d0-8fe5-2e737d705081.usrfiles.com/archives/612092_ca94125c1ea449b4bf114913f3c4d2ee.zip"), Texbbb.TextBox2.Text)

        Timer1.Start()
    End Sub

    Private Sub Timer12_Tick(sender As Object, e As EventArgs) Handles Timer12.Tick
        Panel8.BackColor = Color.FromArgb(TrackBar1.Value, Color.Gold)
    End Sub

    Private Sub Panel8_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel8.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            NuovP = Control.MousePosition
            NuovP.X -= (x)
            NuovP.Y -= (p)
            Me.Location = NuovP
        End If
    End Sub
End Class