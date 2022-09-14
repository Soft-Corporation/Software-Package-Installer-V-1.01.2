Imports System.Net
Imports MaterialSkin
Public Class Trading_View


    Dim NuovP As System.Drawing.Point
    Dim x, p As Integer



    Private Sub Panel8_MouseEnter(sender As Object, e As EventArgs) Handles Panel8.MouseEnter
        x = Control.MousePosition.X - Me.Location.X
        p = Control.MousePosition.Y - Me.Location.Y
    End Sub


    Private Sub Trading_View_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ProgressBar1.Show()

        download.DownloadFileAsync(New Uri("https://612092f6-6003-49d0-8fe5-2e737d705081.usrfiles.com/archives/612092_39a0d89892f949948d822c95df65b756.zip"), Texbbb.TextBox28.Text)

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

    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub download_DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs) Handles download.DownloadProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
    End Sub

    Public WithEvents download As New WebClient

    Private Sub MaterialButton2_Click(sender As Object, e As EventArgs)

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

    Private Sub Label1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)
        Dim save As New SaveFileDialog
        save.Filter = "Archivio zip|.zip"
        If save.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.Text = save.FileName
        End If

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value = 100 Then
            Me.Close()
        End If
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