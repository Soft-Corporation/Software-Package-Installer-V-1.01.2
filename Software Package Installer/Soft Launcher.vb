Imports MaterialSkin
Imports System.Net

Public Class Soft_Launcher
    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Public WithEvents download As New WebClient

    Private Sub Soft_Launcher_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        MsgBox("Soft Launcher è stato ritirato non è più possibile installarlo")

        Timer1.start

    End Sub

    Private Sub download_DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs) Handles download.DownloadProgressChanged

    End Sub

    Private Sub MaterialButton2_Click(sender As Object, e As EventArgs) Handles MaterialButton2.Click
        MsgBox("La funzione download non è disponibile verrai indirizzato al nostro sito web per il download")
        Process.Start("https://grammaticosamuele4.wixsite.com/ilmiosito/soft-laucher")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Close()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

    End Sub
End Class