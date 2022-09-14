Imports System.IO
Imports MaterialSkin

Public Class Impostazioni

    Dim NuovP As System.Drawing.Point
    Dim x, y As Integer


    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs)
        On Error Resume Next

        Directory.CreateDirectory(Application.StartupPath & "\Dark")
        Directory.Delete(Application.StartupPath & "\Light")






        MsgBox("Per Applicare le modifiche è richiesto il riavvio del Software")

        Process.Start(Application.StartupPath & "\Software Package Installer.exe")
        Form1.Close()

    End Sub

    Private Sub MaterialButton2_Click(sender As Object, e As EventArgs)
        On Error Resume Next
        Directory.CreateDirectory(Application.StartupPath & "\Light")
        Directory.Delete(Application.StartupPath & "\Dark")

        MsgBox("Per applicare le modifiche è richiesto il riavvio del Software")

        Process.Start(Application.StartupPath & "\Software Package Installer.exe")
        Form1.Close()
    End Sub

    Private Sub MaterialButton3_Click(sender As Object, e As EventArgs)
        On Error Resume Next
        Directory.CreateDirectory(Application.StartupPath & "\Blue")
        Directory.Delete(Application.StartupPath & "\Orange ")
        Directory.Delete(Application.StartupPath & "\Red")
        Directory.Delete(Application.StartupPath & "\Green")
        Directory.Delete(Application.StartupPath & "\Purple")


        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance


        MsgBox("Per applicare le modifiche è richiesto il riavvio del software")

        Process.Start(Application.StartupPath & "\Software Package Installer.exe")

        Form1.Close()
    End Sub

    Private Sub MaterialButton4_Click(sender As Object, e As EventArgs)
        On Error Resume Next
        Directory.CreateDirectory(Application.StartupPath & "\Red")
        Directory.Delete(Application.StartupPath & "\Orange")
        Directory.Delete(Application.StartupPath & "\Blue")
        Directory.Delete(Application.StartupPath & "\Green")
        Directory.Delete(Application.StartupPath & "\Purple")

        MsgBox("Per applicare le modifiche è richiesto il riavvio del software")

        Process.Start(Application.StartupPath & "\Software Package Installer.exe")

        Form1.Close()
    End Sub

    Private Sub MaterialButton5_Click(sender As Object, e As EventArgs)
        On Error Resume Next
        Directory.CreateDirectory(Application.StartupPath & "\Green")
        Directory.Delete(Application.StartupPath & "\Orange")
        Directory.Delete(Application.StartupPath & "\Blue")
        Directory.Delete(Application.StartupPath & "\Red")
        Directory.Delete(Application.StartupPath & "\Purple")

        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance



        MsgBox("Per applicare le modifiche è richiesto il riavvio del software")

        Process.Start(Application.StartupPath & "\Software Package Installer.exe")

        Form1.Close()
    End Sub



    Private Sub Panel8_MouseEnter(sender As Object, e As EventArgs) Handles Panel8.MouseEnter
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub




    Private Sub Impostazioni_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Blue") Then
            Timer1.Start()
            Timer2.Stop()
            Timer3.Stop()
            Timer4.Stop()
            Timer5.Stop()
            Timer6.Stop()

        End If


        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Red") Then
            Timer1.Stop()
            Timer2.Start()
            Timer3.Stop()
            Timer4.Stop()
            Timer5.Stop()
            Timer6.Stop()

        End If

        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Green") Then
            Timer1.Stop()
            Timer2.Stop()
            Timer3.Start()
            Timer4.Stop()
            Timer5.Stop()
            Timer6.Stop()

        End If

        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Orange") Then
            Timer1.Stop()
            Timer2.Stop()
            Timer3.Stop()
            Timer4.Start()
            Timer5.Stop()
            Timer6.Stop()

        End If

        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Purple") Then
            Timer1.Stop()
            Timer2.Stop()
            Timer3.Stop()
            Timer4.Stop()
            Timer5.Start()
            Timer6.Stop()

        End If

        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Gold") Then
            Timer1.Stop()
            Timer2.Stop()
            Timer3.Stop()
            Timer4.Stop()
            Timer5.Stop()
            Timer6.Start()
        End If

    End Sub

    Private Sub MaterialButton6_Click(sender As Object, e As EventArgs)

        On Error Resume Next
        Directory.CreateDirectory(Application.StartupPath & "\Orange")
        Directory.Delete(Application.StartupPath & "\Blue")
        Directory.Delete(Application.StartupPath & "\Red")
        Directory.Delete(Application.StartupPath & "\Green")
        Directory.Delete(Application.StartupPath & "\Purple")


        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance


        MsgBox("Per applicare le modifiche è richiesto il riavvio del software")

        Process.Start(Application.StartupPath & "\Software Package Installer.exe")

        Form1.Close()
    End Sub

    Private Sub MaterialButton7_Click(sender As Object, e As EventArgs)

        On Error Resume Next
        Directory.CreateDirectory(Application.StartupPath & "\Purple")
        Directory.Delete(Application.StartupPath & "\Orange")
        Directory.Delete(Application.StartupPath & "\Blue")
        Directory.Delete(Application.StartupPath & "\Red")
        Directory.Delete(Application.StartupPath & "\Green")


        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance


        MsgBox("Per applicare le modifiche è richiesto il riavvio del software")

        Process.Start(Application.StartupPath & "\Software Package Installer.exe")

        Form1.Close()
    End Sub

    Private Sub MaterialButton8_Click(sender As Object, e As EventArgs)
        Informazioni_di_Software_Package_Installer.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Panel8.BackColor = Color.FromArgb(TrackBar1.Value, Color.RoyalBlue)
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Panel8.BackColor = Color.FromArgb(TrackBar1.Value, Color.Red)
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Panel8.BackColor = Color.FromArgb(TrackBar1.Value, Color.Green)
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Panel8.BackColor = Color.FromArgb(TrackBar1.Value, Color.Orange)
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Panel8.BackColor = Color.FromArgb(TrackBar1.Value, Color.Purple)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        On Error Resume Next
        Directory.CreateDirectory(Application.StartupPath & "\Blue")
        Directory.Delete(Application.StartupPath & "\red")
        Directory.Delete(Application.StartupPath & "\Green")
        Directory.Delete(Application.StartupPath & "\Orange")
        Directory.Delete(Application.StartupPath & "\Purple")
        Directory.Delete(Application.StartupPath & "\Gold")
        MsgBox("E' neccessario riavviare il software per le modifiche ")
        Process.Start(Application.StartupPath & "\Software Package Installer ME.exe")

        Form1.Close()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        On Error Resume Next
        Directory.CreateDirectory(Application.StartupPath & "\Red")
        Directory.Delete(Application.StartupPath & "\Blue")
        Directory.Delete(Application.StartupPath & "\Green")
        Directory.Delete(Application.StartupPath & "\Orange")
        Directory.Delete(Application.StartupPath & "\Purple")
        Directory.Delete(Application.StartupPath & "\Gold")
        MsgBox("Per effetuare le modifiche è necessario il riavvio")
        Process.Start(Application.StartupPath & "\Software Package Installer ME.exe")
        Form1.Close()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        On Error Resume Next
        Directory.Delete(Application.StartupPath & "\Green")
        Directory.Delete(Application.StartupPath & "\red")
        Directory.CreateDirectory(Application.StartupPath & "\Green")
        Directory.Delete(Application.StartupPath & "\Orange")
        Directory.Delete(Application.StartupPath & "\Purple")
        Directory.Delete(Application.StartupPath & "\Gold")
        MsgBox("E' neccessario riavviare il software per le modifiche ")
        Process.Start(Application.StartupPath & "\Software Package Installer ME.exe")
        Form1.Close()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        On Error Resume Next
        Directory.Delete(Application.StartupPath & "\Blue")
        Directory.Delete(Application.StartupPath & "\red")
        Directory.Delete(Application.StartupPath & "\Green")
        Directory.CreateDirectory(Application.StartupPath & "\Orange")
        Directory.Delete(Application.StartupPath & "\Purple")
        Directory.Delete(Application.StartupPath & "\Gold")
        MsgBox("E' neccessario riavviare il software per le modifiche ")
        Process.Start(Application.StartupPath & "\Software Package Installer ME.exe")
        Form1.Close()


    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        On Error Resume Next
        Directory.Delete(Application.StartupPath & "\Blue")
        Directory.Delete(Application.StartupPath & "\red")
        Directory.Delete(Application.StartupPath & "\Green")
        Directory.Delete(Application.StartupPath & "\Orange")
        Directory.CreateDirectory(Application.StartupPath & "\Purple")
        Directory.Delete(Application.StartupPath & "\Gold")
        MsgBox("E' neccessario riavviare il software per le modifiche ")
        Process.Start(Application.StartupPath & "\Software Package Installer ME.exe")
        Form1.Close()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Informazioni_di_Software_Package_Installer.Show()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        On Error Resume Next
        Directory.Delete(Application.StartupPath & "\Blue")
        Directory.Delete(Application.StartupPath & "\red")
        Directory.Delete(Application.StartupPath & "\Green")
        Directory.Delete(Application.StartupPath & "\Orange")
        Directory.CreateDirectory(Application.StartupPath & "\Purple")
        Directory.CreateDirectory(Application.StartupPath & "\Gold")
        MsgBox("E' neccessario riavviare il software per le modifiche ")
        Process.Start(Application.StartupPath & "\Software Package Installer ME.exe")
        Form1.Close()
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        Panel8.BackColor = Color.FromArgb(TrackBar1.Value, Color.Gold)
    End Sub

    Private Sub Panel8_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel8.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            NuovP = Control.MousePosition
            NuovP.X -= (x)
            NuovP.Y -= (y)
            Me.Location = NuovP
        End If

    End Sub
End Class