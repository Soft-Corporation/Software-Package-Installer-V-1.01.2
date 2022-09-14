Public Class Texbbb
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim save As New SaveFileDialog
        save.Filter = "Archivio zip|.zip"
        save.FileName = "Itop Vpn"
        If save.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox2.Text = save.FileName

        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Hide()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Label60_Click(sender As Object, e As EventArgs) Handles Label60.Click

    End Sub
End Class