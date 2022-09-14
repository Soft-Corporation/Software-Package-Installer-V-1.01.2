Imports MaterialSkin
Imports System.Net
Imports System.IO

Public Class Form1

    Dim NuovP As System.Drawing.Point
    Dim x, y As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Vsc.Show()
    End Sub

    Private Sub Panel8_MouseEnter(sender As Object, e As EventArgs) Handles Panel8.MouseEnter
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub




    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Visual_Studio.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Libreoffice.Show()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Edge.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        Chrome.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        Firefox.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        Iobit_Driver_Booster.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)
        IObit_Unistaller.Show()

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)
        Hwmonitor.Show()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs)
        _7zip.Show()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs)
        If Panel1.Visible = True Then

            Panel2.Show()
        Else
            Panel1.Show()
            Panel2.Hide()
        End If


    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs)
        If Panel2.Visible = True Then
            Panel2.Hide()
        Else
            Panel1.Hide()

        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs)
        Notepad__.Show()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs)
        Discord.Show()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs)
        Steam.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs)
        Virtualbox.Show()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs)
        Vmware.Show()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs)
        Sky_Go.Show()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs)
        Ccleaner.Show()
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs)
        Google_Drive.Show()
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs)
        Obs.Show()
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs)
        Flowgorithm.Show()
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs)
        Teamviewer.Show()
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs)
        Soft_Optimizer.Show()

    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs)
        Gimp.Show()
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs)
        Abobe_Acrobat_Reader.Show()
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs)
        Audacity.Show()
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs)
        Install_Creator.Show()
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs)
        Shotcut.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Informazioni_di_Software_Package_Installer.Show()
    End Sub

    Private Sub MaterialLabel1_Click(sender As Object, e As EventArgs)
        Teamviewer.Show()
    End Sub

    Private Sub PictureBox21_Click(sender As Object, e As EventArgs) Handles PictureBox21.Click

    End Sub

    Private Sub MaterialLabel2_Click(sender As Object, e As EventArgs)
        Soft_Optimizer.Show()
    End Sub

    Private Sub MaterialLabel3_Click(sender As Object, e As EventArgs)
        Gimp.Show()
    End Sub

    Private Sub PictureBox23_Click(sender As Object, e As EventArgs) Handles PictureBox23.Click

    End Sub

    Private Sub MaterialLabel4_Click(sender As Object, e As EventArgs)
        Abobe_Acrobat_Reader.Show()
    End Sub

    Private Sub PictureBox24_Click(sender As Object, e As EventArgs) Handles PictureBox24.Click

    End Sub

    Private Sub MaterialLabel5_Click(sender As Object, e As EventArgs)
        Audacity.Show()
    End Sub

    Private Sub PictureBox25_Click(sender As Object, e As EventArgs) Handles PictureBox25.Click

    End Sub

    Private Sub MaterialButton3_Click(sender As Object, e As EventArgs)
        Informazioni_di_Software_Package_Installer.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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




        Timer1.Start()


        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Up") Then
            Download.DownloadFileAsync(New Uri("Server Ftp Url"), Application.StartupPath & "\Updater.txt")

            Timer2.Start()
            Timer3.Start()
            Timer4.Start()
        End If





    End Sub

    Public WithEvents Download As New WebClient
    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs)
        Panel2.Hide()
        Panel1.Hide()
        Panel3.Hide()
        Panel4.Hide()
        Panel5.Hide()
        Panel6.Hide()



        szp.Show()
    End Sub

    Private Sub MaterialButton2_Click(sender As Object, e As EventArgs)
        Panel1.Show()
        Panel2.Hide()
        Panel3.Hide()
        Panel4.Hide()
        Panel5.Hide()
        Panel6.Hide()

    End Sub

    Private Sub PictureBox22_Click(sender As Object, e As EventArgs) Handles PictureBox22.Click

    End Sub

    Private Sub PictureBox26_Click(sender As Object, e As EventArgs) Handles PictureBox26.Click

    End Sub

    Private Sub PictureBox27_Click(sender As Object, e As EventArgs) Handles PictureBox27.Click

    End Sub

    Private Sub MaterialLabel7_Click(sender As Object, e As EventArgs)
        Shotcut.Show()
    End Sub

    Private Sub MaterialLabel6_Click(sender As Object, e As EventArgs)
        Install_Creator.Show()
    End Sub

    Private Sub MaterialLabel9_Click(sender As Object, e As EventArgs)
        Notepad__.Show()
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click

    End Sub

    Private Sub MaterialLabel10_Click(sender As Object, e As EventArgs)
        Discord.Show()

    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click

    End Sub

    Private Sub MaterialLabel11_Click(sender As Object, e As EventArgs)
        Steam.Show()
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click

    End Sub

    Private Sub MaterialLabel12_Click(sender As Object, e As EventArgs)
        Virtualbox.Show()
    End Sub



    Private Sub MaterialLabel13_Click(sender As Object, e As EventArgs)
        Vmware.Show()
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click

    End Sub

    Private Sub MaterialLabel14_Click(sender As Object, e As EventArgs)
        Sky_Go.Show()
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click

    End Sub

    Private Sub MaterialLabel15_Click(sender As Object, e As EventArgs)
        Ccleaner.Show()
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click

    End Sub

    Private Sub MaterialLabel16_Click(sender As Object, e As EventArgs)
        Google_Drive.Show()
    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click

    End Sub

    Private Sub MaterialLabel17_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles PictureBox19.Click
        Obs.Show()
    End Sub

    Private Sub MaterialLabel18_Click(sender As Object, e As EventArgs)
        Flowgorithm.Show()
    End Sub

    Private Sub PictureBox20_Click(sender As Object, e As EventArgs) Handles PictureBox20.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub MaterialButton4_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub MaterialButton4_Click_1(sender As Object, e As EventArgs)
        Panel2.Show()
        Panel1.Hide()
        Panel3.Hide()
        Panel4.Hide()
        Panel5.Hide()
        Panel6.Hide()

        szp.Hide()

    End Sub

    Private Sub MaterialLabel19_Click(sender As Object, e As EventArgs)
        Vsc.Show()
    End Sub



    Private Sub MaterialLabel20_Click(sender As Object, e As EventArgs)
        Visual_Studio.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles vsp.Click
      
    End Sub

    Private Sub MaterialLabel21_Click(sender As Object, e As EventArgs)
        Firefox.Show()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles fip.Click

    End Sub

    Private Sub MaterialLabel22_Click(sender As Object, e As EventArgs)
        Iobit_Driver_Booster.Show()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles bdp.Click

    End Sub

    Private Sub MaterialLabel23_Click(sender As Object, e As EventArgs)
        Libreoffice.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles lbp.Click

    End Sub

    Private Sub MaterialLabel24_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles edp.Click

    End Sub

    Private Sub MaterialLabel25_Click(sender As Object, e As EventArgs)
        Chrome.Show()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles chp.Click

    End Sub

    Private Sub MaterialLabel26_Click(sender As Object, e As EventArgs)
        IObit_Unistaller.Show()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles up.Click

    End Sub

    Private Sub MaterialLabel27_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles hwp.Click

    End Sub

    Private Sub MaterialLabel28_Click(sender As Object, e As EventArgs)

    End Sub




    Private Sub MaterialLabel29_Click(sender As Object, e As EventArgs)
        Trading_View.Show()
    End Sub

    Private Sub PictureBox28_Click(sender As Object, e As EventArgs) Handles PictureBox28.Click

    End Sub

    Private Sub PictureBox29_Click(sender As Object, e As EventArgs) Handles PictureBox29.Click

    End Sub

    Private Sub MaterialLabel30_Click(sender As Object, e As EventArgs)
        Logitech_G_Hub.Show()
    End Sub

    Private Sub PictureBox30_Click(sender As Object, e As EventArgs) Handles PictureBox30.Click

    End Sub

    Private Sub MaterialLabel31_Click(sender As Object, e As EventArgs)
        Anydesk.Show()
    End Sub

    Private Sub PictureBox40_Click(sender As Object, e As EventArgs) Handles PictureBox40.Click


    End Sub

    Private Sub MaterialLabel41_Click(sender As Object, e As EventArgs)
        Opera.Show()
    End Sub

    Private Sub PictureBox39_Click(sender As Object, e As EventArgs) Handles PictureBox39.Click

    End Sub

    Private Sub MaterialLabel40_Click(sender As Object, e As EventArgs)
        Opera_Gx.Show()
    End Sub

    Private Sub PictureBox38_Click(sender As Object, e As EventArgs) Handles PictureBox38.Click


    End Sub

    Private Sub MaterialLabel39_Click(sender As Object, e As EventArgs)
        Vivaldi.Show()

    End Sub

    Private Sub PictureBox37_Click(sender As Object, e As EventArgs) Handles PictureBox37.Click

    End Sub

    Private Sub MaterialLabel38_Click(sender As Object, e As EventArgs)
        OperaCB.Show()
    End Sub

    Private Sub PictureBox36_Click(sender As Object, e As EventArgs) Handles PictureBox36.Click

    End Sub

    Private Sub MaterialLabel37_Click(sender As Object, e As EventArgs)
        OnlyOffice.Show()
    End Sub

    Private Sub PictureBox35_Click(sender As Object, e As EventArgs) Handles PictureBox35.Click


    End Sub

    Private Sub MaterialLabel36_Click(sender As Object, e As EventArgs)
        Rufus.Show()

    End Sub

    Private Sub PictureBox34_Click(sender As Object, e As EventArgs) Handles PictureBox34.Click

    End Sub

    Private Sub MaterialLabel35_Click(sender As Object, e As EventArgs)
        Python.Show()
    End Sub

    Private Sub PictureBox33_Click(sender As Object, e As EventArgs) Handles PictureBox33.Click

    End Sub

    Private Sub MaterialLabel34_Click(sender As Object, e As EventArgs)
        Davinci_Resolve.Show()
    End Sub

    Private Sub PictureBox32_Click(sender As Object, e As EventArgs) Handles PictureBox32.Click


    End Sub

    Private Sub MaterialLabel33_Click(sender As Object, e As EventArgs)
        Openshot.Show()
    End Sub

    Private Sub PictureBox31_Click(sender As Object, e As EventArgs) Handles PictureBox31.Click

    End Sub

    Private Sub MaterialLabel32_Click(sender As Object, e As EventArgs)
        Driver_Easy.Show()

    End Sub

    Private Sub PictureBox50_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MaterialLabel51_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox49_Click(sender As Object, e As EventArgs) Handles PictureBox49.Click


    End Sub

    Private Sub MaterialLabel50_Click(sender As Object, e As EventArgs)
        Iobit_Malware_Fighter.Show()
    End Sub

    Private Sub MaterialButton5_Click(sender As Object, e As EventArgs)
        Panel3.Show()
        Panel2.Hide()
        Panel1.Hide()
        Panel4.Hide()
        Panel5.Hide()
        Panel6.Hide()

    End Sub

    Private Sub MaterialButton6_Click(sender As Object, e As EventArgs)
        Panel3.Hide()
        Panel2.Hide()
        Panel1.Hide()
        Panel4.Show()
        Panel5.Hide()
        Panel6.Hide()


    End Sub

    Private Sub MaterialButton7_Click(sender As Object, e As EventArgs)
        Impostazioni.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Conf") Then


        Else

            Configurazione.Show()

        End If

    End Sub

    Private Sub PictureBox41_Click(sender As Object, e As EventArgs) Handles PictureBox41.Click

    End Sub

    Private Sub MaterialLabel42_Click(sender As Object, e As EventArgs)
        IObit_Software_Updater.Show()

    End Sub

    Private Sub PictureBox42_Click(sender As Object, e As EventArgs) Handles PictureBox42.Click

    End Sub

    Private Sub MaterialLabel43_Click(sender As Object, e As EventArgs)
        Soft_Usb_Passwords.Show()
    End Sub

    Private Sub PictureBox43_Click(sender As Object, e As EventArgs) Handles PictureBox43.Click


    End Sub

    Private Sub MaterialLabel44_Click(sender As Object, e As EventArgs)
        Soft_Launcher.Show()
    End Sub

    Private Sub PictureBox44_Click(sender As Object, e As EventArgs) Handles PictureBox44.Click


    End Sub

    Private Sub MaterialLabel45_Click(sender As Object, e As EventArgs)
        Nox_Player.Show()
    End Sub

    Private Sub PictureBox45_Click(sender As Object, e As EventArgs) Handles PictureBox45.Click


    End Sub

    Private Sub MaterialLabel46_Click(sender As Object, e As EventArgs)
        Telegram.Show()

    End Sub

    Private Sub PictureBox46_Click(sender As Object, e As EventArgs) Handles PictureBox46.Click

    End Sub

    Private Sub MaterialLabel47_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox47_Click(sender As Object, e As EventArgs) Handles PictureBox47.Click


    End Sub

    Private Sub MaterialLabel48_Click(sender As Object, e As EventArgs)
        AlgoBuild.Show()
    End Sub

    Private Sub PictureBox48_Click(sender As Object, e As EventArgs) Handles PictureBox48.Click


    End Sub

    Private Sub MaterialLabel49_Click(sender As Object, e As EventArgs)
        Crystaldiskmark.Show()

    End Sub

    Private Sub PictureBox50_Click_1(sender As Object, e As EventArgs) Handles PictureBox50.Click

    End Sub

    Private Sub MaterialLabel51_Click_1(sender As Object, e As EventArgs)
        Crystaldiskinfo.Show()

    End Sub

    Private Sub PictureBox60_Click(sender As Object, e As EventArgs) Handles PictureBox60.Click

    End Sub

    Private Sub MaterialLabel61_Click(sender As Object, e As EventArgs)
        Zoom.Show()
    End Sub

    Private Sub PictureBox59_Click(sender As Object, e As EventArgs) Handles PictureBox59.Click


    End Sub

    Private Sub MaterialLabel60_Click(sender As Object, e As EventArgs)
        Vlc.Show()

    End Sub

    Private Sub PictureBox58_Click(sender As Object, e As EventArgs) Handles PictureBox58.Click

    End Sub

    Private Sub MaterialLabel59_Click(sender As Object, e As EventArgs)
        Epic_Games_Launcher.Show()
    End Sub

    Private Sub PictureBox57_Click(sender As Object, e As EventArgs) Handles PictureBox57.Click

    End Sub

    Private Sub MaterialLabel58_Click(sender As Object, e As EventArgs)
        Battlenet.Show()
    End Sub

    Private Sub PictureBox56_Click(sender As Object, e As EventArgs) Handles PictureBox56.Click

    End Sub

    Private Sub MaterialLabel57_Click(sender As Object, e As EventArgs)
        Chrome_Canary.Show()
    End Sub

    Private Sub PictureBox55_Click(sender As Object, e As EventArgs) Handles PictureBox55.Click


    End Sub

    Private Sub MaterialLabel56_Click(sender As Object, e As EventArgs)
        Notion.Show()
    End Sub

    Private Sub PictureBox54_Click(sender As Object, e As EventArgs) Handles PictureBox54.Click

    End Sub

    Private Sub MaterialLabel55_Click(sender As Object, e As EventArgs)
        Nvidia_Geforce_Experience.Show()
    End Sub

    Private Sub MaterialButton8_Click(sender As Object, e As EventArgs)
        Panel3.Hide()
        Panel2.Hide()
        Panel1.Hide()
        Panel4.Hide()
        Panel5.Show()
        Panel6.Hide()



    End Sub

    Private Sub CircularProgressBar1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        On Error Resume Next

        Dim apri As String = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\Updater.txt")
        b.Text = apri

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick

        If a.Text < b.Text Then
            Process.Start("https://grammaticosamuele4.wixsite.com/ilmiosito/updater-spi-me")
        Else


        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Timer3.Stop()
    End Sub

    Private Sub PictureBox51_Click(sender As Object, e As EventArgs) Handles PictureBox51.Click


    End Sub

    Private Sub MaterialLabel52_Click(sender As Object, e As EventArgs)
        Filezilla_Server.Show()
    End Sub

    Private Sub PictureBox52_Click(sender As Object, e As EventArgs) Handles PictureBox52.Click

    End Sub

    Private Sub MaterialLabel53_Click(sender As Object, e As EventArgs)
        Filezilla_Ser.Show()

    End Sub

    Private Sub PictureBox53_Click(sender As Object, e As EventArgs) Handles PictureBox53.Click

    End Sub

    Private Sub MaterialLabel54_Click(sender As Object, e As EventArgs)
        Advanced_Systemcare.Show()
    End Sub

    Private Sub PictureBox70_Click(sender As Object, e As EventArgs) Handles PictureBox70.Click

    End Sub

    Private Sub MaterialLabel71_Click(sender As Object, e As EventArgs)
        Smart_Defrag.Show()
    End Sub

    Private Sub PictureBox69_Click(sender As Object, e As EventArgs) Handles PictureBox69.Click

    End Sub

    Private Sub MaterialLabel70_Click(sender As Object, e As EventArgs)
        Iobit_Protected_Folder.Show()
    End Sub

    Private Sub PictureBox68_Click(sender As Object, e As EventArgs) Handles PictureBox68.Click

    End Sub

    Private Sub MaterialLabel69_Click(sender As Object, e As EventArgs)
        Itop_Vpn.Show()
    End Sub

    Private Sub PictureBox67_Click(sender As Object, e As EventArgs) Handles PictureBox67.Click

    End Sub

    Private Sub MaterialLabel68_Click(sender As Object, e As EventArgs)
        Droidcam.Show()
    End Sub

    Private Sub PictureBox66_Click(sender As Object, e As EventArgs) Handles PictureBox66.Click

    End Sub

    Private Sub MaterialLabel67_Click(sender As Object, e As EventArgs)
        OpenOffice.Show()
    End Sub

    Private Sub PictureBox65_Click(sender As Object, e As EventArgs) Handles PictureBox65.Click


    End Sub

    Private Sub MaterialLabel66_Click(sender As Object, e As EventArgs)
        Ps_Remote_Play.Show()
    End Sub

    Private Sub PictureBox64_Click(sender As Object, e As EventArgs) Handles PictureBox64.Click

    End Sub

    Private Sub MaterialLabel65_Click(sender As Object, e As EventArgs)
        Itunes.Show()

    End Sub

    Private Sub MaterialButton3_Click_1(sender As Object, e As EventArgs)
        Panel3.Hide()
        Panel2.Hide()
        Panel1.Hide()
        Panel4.Hide()
        Panel5.Hide()
        Panel6.Show()

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Impostazioni.Show()
    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles vsp.Click
        Vsc.Show()
    End Sub
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Panel2.Hide()
        Panel1.Hide()
        Panel3.Hide()
        Panel4.Hide()
        Panel5.Hide()
        Panel6.Hide()
        Panel20.Hide()
        Panel21.Hide()
        Vsc.Show()
        Vs.Show()
        Ed.Show()
        Ch.Show()
        Fi.Show()
        Bd.Show()
        u.Show()
        sz.Show()
        hw.Show()

        szp.Show()

        vscp.Show()
        vsp.Show()
        lbp.Show()
        edp.Show()
        chp.Show()
        fip.Show()
        bdp.Show()
        up.Show()
        hwp.Show()
        szp.Show()
        Lb.Show()
        CheckBox1.Show()
        CheckBox2.Show()
        CheckBox3.Show()
        CheckBox4.Show()
        CheckBox5.Show()
        CheckBox6.Show()
        CheckBox7.Show()
        CheckBox8.Show()
        CheckBox9.Show()
        CheckBox10.Show()
        CheckBox11.Hide()
        CheckBox12.Hide()
        CheckBox13.Hide()
        CheckBox14.Hide()
        CheckBox15.Hide()
        CheckBox16.Hide()
        CheckBox17.Hide()
        CheckBox18.Hide()
        CheckBox19.Hide()
        CheckBox20.Hide()
        CheckBox21.Hide()
        CheckBox22.Hide()
        CheckBox23.Hide()
        CheckBox24.Hide()
        CheckBox25.Hide()
        CheckBox26.Hide()
        CheckBox27.Hide()
        CheckBox28.Hide()
        CheckBox29.Hide()
        CheckBox30.Hide()
        CheckBox31.Hide()
        CheckBox32.Hide()
        CheckBox33.Hide()
        CheckBox34.Hide()
        CheckBox35.Hide()
        CheckBox36.Hide()
        CheckBox37.Hide()
        CheckBox38.Hide()
        CheckBox39.Hide()
        CheckBox40.Hide()
        CheckBox41.Hide()
        CheckBox42.Hide()
        CheckBox43.Hide()
        CheckBox44.Hide()
        CheckBox45.Hide()
        CheckBox46.Hide()
        CheckBox47.Hide()
        CheckBox48.Hide()
        CheckBox49.Hide()
        CheckBox50.Hide()
        CheckBox51.Hide()
        CheckBox52.Hide()
        CheckBox53.Hide()
        CheckBox54.Hide()
        CheckBox55.Hide()
        CheckBox56.Hide()
        CheckBox57.Hide()
        CheckBox58.Hide()
        CheckBox59.Hide()
        CheckBox79.Hide()
        CheckBox74.Hide()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Panel21.Hide()
        Panel20.Hide()
        Panel1.Show()
        Panel2.Hide()
        Panel3.Hide()
        Panel4.Hide()
        Panel5.Hide()
        Panel6.Hide()
        Vsc.Hide()
        Vs.Hide()
        Ed.Hide()
        Ch.Hide()
        Fi.Hide()
        Bd.Hide()
        u.Hide()
        sz.Hide()
        hw.Hide()
        tv.Hide()
        so.Hide()
        gi.Hide()
        ac.Hide()
        au.Hide()
        ic.Hide()
        sh.Hide()
        tr.Hide()
        lh.Hide()
        an.Hide()
        Lb.Hide()
        CheckBox1.Hide()
        CheckBox2.Hide()
        CheckBox3.Hide()
        CheckBox4.Hide()
        CheckBox5.Hide()
        CheckBox6.Hide()
        CheckBox7.Hide()
        CheckBox8.Hide()
        CheckBox9.Hide()
        CheckBox10.Hide()
        CheckBox11.Show()
        CheckBox12.Show()
        CheckBox13.Show()
        CheckBox14.Show()
        CheckBox15.Show()
        CheckBox16.Show()
        CheckBox17.Show()
        CheckBox18.Show()
        CheckBox19.Show()
        CheckBox20.Show()
        CheckBox21.Hide()
        CheckBox22.Hide()
        CheckBox23.Hide()
        CheckBox24.Hide()
        CheckBox25.Hide()
        CheckBox26.Hide()
        CheckBox27.Hide()
        CheckBox28.Hide()
        CheckBox29.Hide()
        CheckBox30.Hide()
        CheckBox31.Hide()
        CheckBox32.Hide()
        CheckBox33.Hide()
        CheckBox34.Hide()
        CheckBox35.Hide()
        CheckBox36.Hide()
        CheckBox37.Hide()
        CheckBox38.Hide()
        CheckBox39.Hide()
        CheckBox40.Hide()
        CheckBox41.Hide()
        CheckBox42.Hide()
        CheckBox43.Hide()
        CheckBox44.Hide()
        CheckBox45.Hide()
        CheckBox46.Hide()
        CheckBox47.Hide()
        CheckBox48.Hide()
        CheckBox49.Hide()
        CheckBox50.Hide()
        CheckBox51.Hide()
        CheckBox52.Hide()
        CheckBox53.Hide()
        CheckBox54.Hide()
        CheckBox55.Hide()
        CheckBox56.Hide()
        CheckBox57.Hide()
        CheckBox58.Hide()
        CheckBox59.Hide()
        CheckBox79.Hide()
        CheckBox74.Hide()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Panel20.Hide()
        Panel21.Hide()
        Panel2.Show()
        Panel1.Hide()
        Panel3.Hide()
        Panel4.Hide()
        Panel5.Hide()
        Panel6.Hide()
        tv.Show()
        so.Show()
        gi.Show()
        ac.Show()
        au.Show()
        ic.Show()
        sh.Show()
        tr.Show()
        lh.Show()
        an.Show()
        Vsc.Hide()
        Vs.Hide()
        Ed.Hide()
        Ch.Hide()
        Fi.Hide()
        Bd.Hide()
        u.Hide()
        sz.Hide()
        hw.Hide()
        szp.Hide()
        Lb.Hide()
        CheckBox1.Hide()
        CheckBox2.Hide()
        CheckBox3.Hide()
        CheckBox4.Hide()
        CheckBox5.Hide()
        CheckBox6.Hide()
        CheckBox7.Hide()
        CheckBox8.Hide()
        CheckBox9.Hide()
        CheckBox10.Hide()
        CheckBox11.Hide()
        CheckBox12.Hide()
        CheckBox13.Hide()
        CheckBox14.Hide()
        CheckBox15.Hide()
        CheckBox16.Hide()
        CheckBox17.Hide()
        CheckBox18.Hide()
        CheckBox19.Hide()
        CheckBox20.Hide()
        CheckBox21.Show()
        CheckBox22.Show()
        CheckBox23.Show()
        CheckBox24.Show()
        CheckBox25.Show()
        CheckBox26.Show()
        CheckBox27.Show()
        CheckBox28.Show()
        CheckBox29.Show()
        CheckBox30.Show()
        CheckBox31.Hide()
        CheckBox32.Hide()
        CheckBox33.Hide()
        CheckBox34.Hide()
        CheckBox35.Hide()
        CheckBox36.Hide()
        CheckBox37.Hide()
        CheckBox38.Hide()
        CheckBox39.Hide()
        CheckBox40.Hide()
        CheckBox41.Hide()
        CheckBox42.Hide()
        CheckBox43.Hide()
        CheckBox44.Hide()
        CheckBox45.Hide()
        CheckBox46.Hide()
        CheckBox47.Hide()
        CheckBox48.Hide()
        CheckBox49.Hide()
        CheckBox50.Hide()
        CheckBox51.Hide()
        CheckBox52.Hide()
        CheckBox53.Hide()
        CheckBox54.Hide()
        CheckBox55.Hide()
        CheckBox56.Hide()
        CheckBox57.Hide()
        CheckBox58.Hide()
        CheckBox59.Hide()
        CheckBox79.Hide()
        CheckBox74.Hide()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Panel3.Show()
        Panel2.Hide()
        Panel1.Hide()
        Panel4.Hide()
        Panel5.Hide()
        Panel6.Hide()
        Panel21.Hide()
        Panel20.Hide()

        Vsc.Hide()
        Vs.Hide()
        Ed.Hide()
        Ch.Hide()
        Fi.Hide()
        Bd.Hide()
        u.Hide()
        sz.Hide()
        hw.Hide()

        tv.Hide()
        so.Hide()
        gi.Hide()
        ac.Hide()
        au.Hide()
        ic.Hide()
        sh.Hide()
        tr.Hide()
        lh.Hide()
        an.Hide()
        vscp.Hide()
        vsp.Hide()
        lbp.Hide()
        edp.Hide()
        chp.Hide()
        fip.Hide()
        bdp.Hide()
        up.Hide()
        hwp.Hide()
        szp.Hide()
        Lb.Hide()
        CheckBox1.Hide()
        CheckBox2.Hide()
        CheckBox3.Hide()
        CheckBox4.Hide()
        CheckBox5.Hide()
        CheckBox6.Hide()
        CheckBox7.Hide()
        CheckBox8.Hide()
        CheckBox9.Hide()
        CheckBox10.Hide()
        CheckBox11.Hide()
        CheckBox12.Hide()
        CheckBox13.Hide()
        CheckBox14.Hide()
        CheckBox15.Hide()
        CheckBox16.Hide()
        CheckBox17.Hide()
        CheckBox18.Hide()
        CheckBox19.Hide()
        CheckBox20.Hide()
        CheckBox21.Hide()
        CheckBox22.Hide()
        CheckBox23.Hide()
        CheckBox24.Hide()
        CheckBox25.Hide()
        CheckBox26.Hide()
        CheckBox27.Hide()
        CheckBox28.Hide()
        CheckBox29.Hide()
        CheckBox30.Hide()
        CheckBox31.Show()
        CheckBox32.Show()
        CheckBox33.Show()
        CheckBox34.Show()
        CheckBox35.Show()
        CheckBox36.Show()
        CheckBox37.Show()
        CheckBox38.Show()
        CheckBox39.Show()
        CheckBox40.Show()
        CheckBox41.Hide()
        CheckBox42.Hide()
        CheckBox43.Hide()
        CheckBox44.Hide()
        CheckBox45.Hide()
        CheckBox46.Hide()
        CheckBox47.Hide()
        CheckBox48.Hide()
        CheckBox49.Hide()
        CheckBox50.Hide()
        CheckBox51.Hide()
        CheckBox52.Hide()
        CheckBox53.Hide()
        CheckBox54.Hide()
        CheckBox55.Hide()
        CheckBox56.Hide()
        CheckBox57.Hide()
        CheckBox58.Hide()
        CheckBox59.Hide()
        CheckBox79.Hide()
        CheckBox74.Hide()

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Panel20.Hide()
        Panel21.Hide()
        Panel3.Hide()
        Panel2.Hide()
        Panel1.Hide()
        Panel4.Show()
        Panel5.Hide()
        Panel6.Hide()

        Vsc.Hide()
        Vs.Hide()
        Ed.Hide()
        Ch.Hide()
        Fi.Hide()
        Bd.Hide()
        u.Hide()
        sz.Hide()
        hw.Hide()

        tv.Hide()
        so.Hide()
        gi.Hide()
        ac.Hide()
        au.Hide()
        ic.Hide()
        sh.Hide()
        tr.Hide()
        lh.Hide()
        Lb.Hide()

        an.Hide()
        vscp.Hide()
        vsp.Hide()
        lbp.Hide()
        edp.Hide()
        chp.Hide()
        fip.Hide()
        bdp.Hide()
        up.Hide()
        hwp.Hide()
        szp.Hide()
        CheckBox1.Hide()
        CheckBox2.Hide()
        CheckBox3.Hide()
        CheckBox4.Hide()
        CheckBox5.Hide()
        CheckBox6.Hide()
        CheckBox7.Hide()
        CheckBox8.Hide()
        CheckBox9.Hide()
        CheckBox10.Hide()
        CheckBox11.Hide()
        CheckBox12.Hide()
        CheckBox13.Hide()
        CheckBox14.Hide()
        CheckBox15.Hide()
        CheckBox16.Hide()
        CheckBox17.Hide()
        CheckBox18.Hide()
        CheckBox19.Hide()
        CheckBox20.Hide()
        CheckBox21.Hide()
        CheckBox22.Hide()
        CheckBox23.Hide()
        CheckBox24.Hide()
        CheckBox25.Hide()
        CheckBox26.Hide()
        CheckBox27.Hide()
        CheckBox28.Hide()
        CheckBox29.Hide()
        CheckBox30.Hide()
        CheckBox31.Hide()
        CheckBox32.Hide()
        CheckBox33.Hide()
        CheckBox34.Hide()
        CheckBox35.Hide()
        CheckBox36.Hide()
        CheckBox37.Hide()
        CheckBox38.Hide()
        CheckBox39.Hide()
        CheckBox40.Hide()
        CheckBox41.Show()
        CheckBox42.Show()
        CheckBox43.Show()
        CheckBox44.Show()
        CheckBox45.Show()
        CheckBox46.Show()
        CheckBox47.Show()
        CheckBox48.Show()
        CheckBox49.Show()
        CheckBox50.Hide()
        CheckBox51.Hide()
        CheckBox52.Hide()
        CheckBox53.Hide()
        CheckBox54.Hide()
        CheckBox55.Hide()
        CheckBox56.Hide()
        CheckBox57.Hide()
        CheckBox58.Hide()
        CheckBox59.Hide()

        CheckBox79.Hide()
        CheckBox74.Hide()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Panel20.Hide()
        Panel21.Hide()
        Panel3.Hide()
        Panel2.Hide()
        Panel1.Hide()
        Panel4.Hide()
        Panel5.Show()
        Panel6.Hide()
        Vsc.Hide()
        Vs.Hide()
        Ed.Hide()
        Ch.Hide()
        Fi.Hide()
        Bd.Hide()
        u.Hide()
        sz.Hide()
        hw.Hide()
        tv.Hide()
        so.Hide()
        gi.Hide()
        ac.Hide()
        au.Hide()
        ic.Hide()
        sh.Hide()
        tr.Hide()
        lh.Hide()
        an.Hide()
        vscp.Hide()
        vsp.Hide()
        lbp.Hide()
        edp.Hide()
        chp.Hide()
        fip.Hide()
        bdp.Hide()
        up.Hide()
        hwp.Hide()
        szp.Hide()
        Lb.Hide()
        CheckBox1.Hide()
        CheckBox2.Hide()
        CheckBox3.Hide()
        CheckBox4.Hide()
        CheckBox5.Hide()
        CheckBox6.Hide()
        CheckBox7.Hide()
        CheckBox8.Hide()
        CheckBox9.Hide()
        CheckBox10.Hide()
        CheckBox11.Hide()
        CheckBox12.Hide()
        CheckBox13.Hide()
        CheckBox14.Hide()
        CheckBox15.Hide()
        CheckBox16.Hide()
        CheckBox17.Hide()
        CheckBox18.Hide()
        CheckBox19.Hide()
        CheckBox20.Hide()
        CheckBox21.Hide()
        CheckBox22.Hide()
        CheckBox23.Hide()
        CheckBox24.Hide()
        CheckBox25.Hide()
        CheckBox26.Hide()
        CheckBox27.Hide()
        CheckBox28.Hide()
        CheckBox29.Hide()
        CheckBox30.Hide()
        CheckBox31.Hide()
        CheckBox32.Hide()
        CheckBox33.Hide()
        CheckBox34.Hide()
        CheckBox35.Hide()
        CheckBox36.Hide()
        CheckBox37.Hide()
        CheckBox38.Hide()
        CheckBox39.Hide()
        CheckBox40.Hide()
        CheckBox41.Hide()
        CheckBox42.Hide()
        CheckBox43.Hide()
        CheckBox44.Hide()
        CheckBox45.Hide()
        CheckBox46.Hide()
        CheckBox47.Hide()
        CheckBox48.Hide()
        CheckBox49.Hide()
        CheckBox50.Show()
        CheckBox51.Show()
        CheckBox52.Show()
        CheckBox53.Show()
        CheckBox54.Show()
        CheckBox55.Show()
        CheckBox56.Show()
        CheckBox57.Show()
        CheckBox58.Show()
        CheckBox59.Show()
        CheckBox79.Hide()
        CheckBox74.Hide()
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Panel21.Hide()
        Panel20.Hide()
        Panel3.Hide()
        Panel2.Hide()
        Panel1.Hide()
        Panel4.Hide()
        Panel5.Hide()
        Panel6.Show()
        Vsc.Hide()
        Vs.Hide()
        Ed.Hide()
        Ch.Hide()
        Fi.Hide()
        Bd.Hide()
        u.Hide()
        sz.Hide()
        hw.Hide()
        tv.Hide()
        so.Hide()
        gi.Hide()
        ac.Hide()
        au.Hide()
        ic.Hide()
        sh.Hide()
        tr.Hide()
        lh.Hide()
        an.Hide()
        vscp.Hide()
        vsp.Hide()
        lbp.Hide()
        edp.Hide()
        chp.Hide()
        fip.Hide()
        bdp.Hide()
        up.Hide()
        hwp.Hide()
        szp.Hide()
        Lb.Hide()
        CheckBox1.Hide()
        CheckBox2.Hide()
        CheckBox3.Hide()
        CheckBox4.Hide()
        CheckBox5.Hide()
        CheckBox6.Hide()
        CheckBox7.Hide()
        CheckBox8.Hide()
        CheckBox9.Hide()
        CheckBox10.Hide()
        CheckBox11.Hide()
        CheckBox12.Hide()
        CheckBox13.Hide()
        CheckBox14.Hide()
        CheckBox15.Hide()
        CheckBox16.Hide()
        CheckBox17.Hide()
        CheckBox18.Hide()
        CheckBox19.Hide()
        CheckBox20.Hide()
        CheckBox21.Hide()
        CheckBox22.Hide()
        CheckBox23.Hide()
        CheckBox24.Hide()
        CheckBox25.Hide()
        CheckBox26.Hide()
        CheckBox27.Hide()
        CheckBox28.Hide()
        CheckBox29.Hide()
        CheckBox30.Hide()
        CheckBox31.Hide()
        CheckBox32.Hide()
        CheckBox33.Hide()
        CheckBox34.Hide()
        CheckBox35.Hide()
        CheckBox36.Hide()
        CheckBox37.Hide()
        CheckBox38.Hide()
        CheckBox39.Hide()
        CheckBox40.Hide()
        CheckBox41.Hide()
        CheckBox42.Hide()
        CheckBox43.Hide()
        CheckBox44.Hide()
        CheckBox45.Hide()
        CheckBox46.Hide()
        CheckBox47.Hide()
        CheckBox48.Hide()
        CheckBox49.Hide()
        CheckBox50.Hide()
        CheckBox51.Hide()
        CheckBox52.Hide()
        CheckBox53.Hide()
        CheckBox54.Hide()
        CheckBox55.Hide()
        CheckBox56.Hide()
        CheckBox57.Hide()
        CheckBox58.Hide()
        CheckBox59.Hide()
        CheckBox60.Show()
        CheckBox61.Show()
        CheckBox62.Show()
        CheckBox63.Show()
        CheckBox64.Show()
        CheckBox65.Show()
        CheckBox66.Show()
        CheckBox79.Hide()
        CheckBox74.Hide()
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Panel8.BackColor = Color.FromArgb(TrackBar1.Value, Color.RoyalBlue)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
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

    Private Sub Panel8_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel8.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            NuovP = Control.MousePosition
            NuovP.X -= (x)
            NuovP.Y -= (y)
            Me.Location = NuovP
        End If
    End Sub

    Private Sub vscp_Click(sender As Object, e As EventArgs) Handles vscp.Click

    End Sub

    Private Sub CheckBox41_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox41.CheckedChanged
        If CheckBox41.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Malware Fighter"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox40.Text = save.FileName

            End If

        Else
            Texbbb.TextBox40.Text = ("")


        End If
    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub Label60_Click(sender As Object, e As EventArgs) Handles Label60.Click

        If CheckBox1.Checked Then
            Visual.Show()
        End If

        If CheckBox2.Checked Then
            Visual_Studio.Show()
        End If

        If CheckBox3.Checked Then
            Libreoffice.Show()
        End If

        If CheckBox4.Checked Then
            Edge.Show()
        End If

        If CheckBox5.Checked Then
            Chrome.Show()
        End If

        If CheckBox6.Checked Then
            Firefox.Show()
        End If

        If CheckBox7.Checked Then
            Iobit_Driver_Booster.Show()
        End If

        If CheckBox8.Checked Then
            IObit_Unistaller.Show()
        End If

        If CheckBox9.Checked Then
            Hwmonitor.Show()
        End If

        If CheckBox10.Checked Then
            _7zip.Show()
        End If

        If CheckBox11.Checked Then
            Notepad__.Show()
        End If

        If CheckBox12.Checked Then
            Discord.Show()
        End If

        If CheckBox13.Checked Then
            Steam.Show()
        End If

        If CheckBox14.Checked Then
            Virtualbox.Show()
        End If

        If CheckBox15.Checked Then
            Vmware.Show()

        End If

        If CheckBox16.Checked Then
            Sky_Go.Show()
        End If

        If CheckBox17.Checked Then
            Ccleaner.Show()
        End If

        If CheckBox18.Checked Then
            Google_Drive.Show()
        End If

        If CheckBox19.Checked Then
            Obs.Show()

        End If

        If CheckBox20.Checked Then
            Flowgorithm.Show()
        End If

        If CheckBox21.Checked Then
            Teamviewer.Show()
        End If

        If CheckBox22.Checked Then
            Soft_Optimizer.Show()
        End If

        If CheckBox23.Checked Then
            Gimp.Show()
        End If

        If CheckBox24.Checked Then
            Abobe_Acrobat_Reader.Show()
        End If

        If CheckBox25.Checked Then
            Audacity.Show()
        End If

        If CheckBox26.Checked Then
            Install_Creator.Show()
        End If

        If CheckBox27.Checked Then
            Shotcut.Show()
        End If

        If CheckBox28.Checked Then
            Trading_View.Show()
        End If

        If CheckBox29.Checked Then
            Logitech_G_Hub.Show()
        End If

        If CheckBox30.Checked Then
            Anydesk.Show()
        End If

        If CheckBox31.Checked Then
            Opera.Show()
        End If


        If CheckBox32.Checked Then
            Opera_Gx.Show()
        End If

        If CheckBox33.Checked Then
            Vivaldi.Show()
        End If

        If CheckBox34.Checked Then
            OperaCB.Show()
        End If

        If CheckBox35.Checked Then
            OnlyOffice.Show()
        End If

        If CheckBox36.Checked Then
            Rufus.Show()
        End If

        If CheckBox37.Checked Then
            Python.Show()
        End If

        If CheckBox38.Checked Then
            Davinci_Resolve.Show()
        End If

        If CheckBox39.Checked Then
            Openshot.Show()
        End If

        If CheckBox40.Checked Then
            Driver_Easy.Show()
        End If

        If CheckBox41.Checked Then
            Iobit_Malware_Fighter.Show()
        End If

        If CheckBox42.Checked Then
            IObit_Software_Updater.Show()
        End If

        If CheckBox43.Checked Then
            Soft_Usb_Passwords.Show()
        End If

        If CheckBox44.Checked Then
            Nox_Player.Show()
        End If

        If CheckBox45.Checked Then
            Telegram.Show()
        End If

        If CheckBox46.Checked Then
            Dev_C__.Show()
        End If

        If CheckBox47.Checked Then
            AlgoBuild.Show()
        End If

        If CheckBox48.Checked Then
            Crystaldiskmark.Show()
        End If

        If CheckBox49.Checked Then
            Crystaldiskinfo.Show()
        End If

        If CheckBox50.Checked Then
            Zoom.Show()
        End If

        If CheckBox51.Checked Then
            Vlc.Show()
        End If

        If CheckBox52.Checked Then
            Epic_Games_Launcher.Show()
        End If

        If CheckBox53.Checked Then
            Battlenet.Show()
        End If

        If CheckBox54.Checked Then
            Chrome_Canary.Show()
        End If

        If CheckBox55.Checked Then
            Notion.Show()
        End If

        If CheckBox56.Checked Then
            Nvidia_Geforce_Experience.Show()
        End If

        If CheckBox57.Checked Then
            Filezilla_Server.Show()
        End If

        If CheckBox58.Checked Then
            Filezilla_Ser.Show()
        End If

        If CheckBox59.Checked Then
            Advanced_Systemcare.Show()
        End If

        If CheckBox60.Checked Then
            Smart_Defrag.Show()
        End If

        If CheckBox61.Checked Then
            Iobit_Protected_Folder.Show()
        End If

        If CheckBox62.Checked Then
            Itop_Vpn.Show()
        End If

        If CheckBox63.Checked Then
            Droidcam.Show()
        End If

        If CheckBox64.Checked Then
            OpenOffice.Show()
        End If

        If CheckBox65.Checked Then
            Ps_Remote_Play.Show()
        End If

        If CheckBox66.Checked Then
            Itunes.Show()
        End If

        If CheckBox67.Checked Then
            Docker.Show()
        End If

        If CheckBox68.Checked Then
            Avast.Show()
        End If

        If CheckBox69.Checked Then
            MAlware_Bytes.Show()
        End If

        If CheckBox79.Checked Then
            Avg.Show()
        End If

        If CheckBox71.Checked Then
            TunnelBear.Show()
        End If

        If CheckBox78.Checked Then
            Vim.Show()
        End If

        If CheckBox77.Checked Then
            Node_JS.Show()
        End If

        If CheckBox76.Checked Then
            Mega.Show()
        End If

        If CheckBox75.Checked Then
            Smart_game_Booster.Show()
        End If

        If CheckBox74.Checked Then
            BAlena_Etcher.Show()
        End If

        If CheckBox73.Checked Then
            Deskreen.Show()
        End If

        If CheckBox72.Checked Then
            Vera_Crypt.Show()
        End If

        If CheckBox70.Checked Then
            Greenshot.Show()
        End If

        If CheckBox89.Checked Then
            File_Converter.Show()
        End If

        If CheckBox88.Checked Then
            Edge_Dev.Show()
        End If

        If CheckBox87.Checked Then
            Edge_Beta.Show()
        End If


    End Sub

    Private Sub Timer10_Tick(sender As Object, e As EventArgs) Handles Timer10.Tick

    End Sub

    Private Sub Timer11_Tick(sender As Object, e As EventArgs) Handles Timer11.Tick

    End Sub

    Private Sub Timer12_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        Texbbb.Show()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Visual studio code"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox1.Text = save.FileName

            End If

        Else
            Texbbb.TextBox1.Text = ("")


        End If

    End Sub

    Private Sub Vsc_Click(sender As Object, e As EventArgs) Handles Vsc.Click

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

        If CheckBox2.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Visual Studio"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox2.Text = save.FileName

            End If

        Else
            Texbbb.TextBox2.Text = ("")


        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Libreoffice"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox3.Text = save.FileName

            End If

        Else
            Texbbb.TextBox3.Text = ("")


        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Edge"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox4.Text = save.FileName

            End If

        Else
            Texbbb.TextBox4.Text = ("")


        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Chrome"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox5.Text = save.FileName

            End If

        Else
            Texbbb.TextBox5.Text = ("")


        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Firefox"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox6.Text = save.FileName

            End If

        Else
            Texbbb.TextBox6.Text = ("")


        End If
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        If CheckBox7.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Driver Booster"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox7.Text = save.FileName

            End If

        Else
            Texbbb.TextBox7.Text = ("")


        End If
    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged
        If CheckBox8.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Iobit Uninstaller"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox8.Text = save.FileName

            End If

        Else
            Texbbb.TextBox8.Text = ("")


        End If
    End Sub

    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox9.CheckedChanged
        If CheckBox9.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Hwmonitor"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox9.Text = save.FileName

            End If

        Else
            Texbbb.TextBox9.Text = ("")


        End If
    End Sub

    Private Sub CheckBox10_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox10.CheckedChanged
        If CheckBox10.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "7Zip"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox10.Text = save.FileName

            End If

        Else
            Texbbb.TextBox10.Text = ("")


        End If
    End Sub

    Private Sub CheckBox11_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox11.CheckedChanged
        If CheckBox11.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Notepad++"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox11.Text = save.FileName

            End If

        Else
            Texbbb.TextBox11.Text = ("")


        End If
    End Sub

    Private Sub CheckBox12_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox12.CheckedChanged
        If CheckBox12.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Discord"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox12.Text = save.FileName

            End If

        Else
            Texbbb.TextBox12.Text = ("")


        End If
    End Sub

    Private Sub CheckBox13_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox13.CheckedChanged
        If CheckBox13.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Steam"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox13.Text = save.FileName

            End If

        Else
            Texbbb.TextBox13.Text = ("")


        End If
    End Sub

    Private Sub CheckBox14_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox14.CheckedChanged
        If CheckBox14.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Virtual Box"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox14.Text = save.FileName

            End If

        Else
            Texbbb.TextBox14.Text = ("")


        End If
    End Sub

    Private Sub CheckBox15_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox15.CheckedChanged
        If CheckBox15.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Vmware Player"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox15.Text = save.FileName

            End If

        Else
            Texbbb.TextBox15.Text = ("")


        End If
    End Sub

    Private Sub CheckBox16_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox16.CheckedChanged
        If CheckBox16.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Sky Go"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox16.Text = save.FileName

            End If

        Else
            Texbbb.TextBox16.Text = ("")


        End If
    End Sub

    Private Sub CheckBox17_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox17.CheckedChanged
        If CheckBox17.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Ccleaner"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox17.Text = save.FileName

            End If

        Else
            Texbbb.TextBox17.Text = ("")


        End If
    End Sub

    Private Sub CheckBox18_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox18.CheckedChanged
        If CheckBox18.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Google Drive"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox18.Text = save.FileName

            End If

        Else
            Texbbb.TextBox18.Text = ("")


        End If
    End Sub

    Private Sub CheckBox19_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox19.CheckedChanged
        If CheckBox19.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Obs"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox19.Text = save.FileName

            End If

        Else
            Texbbb.TextBox19.Text = ("")


        End If
    End Sub

    Private Sub CheckBox20_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox20.CheckedChanged
        If CheckBox20.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Flowgorithm"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox20.Text = save.FileName

            End If

        Else
            Texbbb.TextBox20.Text = ("")


        End If
    End Sub

    Private Sub CheckBox21_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox21.CheckedChanged
        If CheckBox21.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Teamviewer"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox21.Text = save.FileName

            End If

        Else
            Texbbb.TextBox21.Text = ("")


        End If
    End Sub

    Private Sub CheckBox22_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox22.CheckedChanged
        If CheckBox22.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Soft Optimizer"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox22.Text = save.FileName

            End If

        Else
            Texbbb.TextBox22.Text = ("")


        End If
    End Sub

    Private Sub CheckBox23_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox23.CheckedChanged
        If CheckBox23.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Gimp"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox23.Text = save.FileName

            End If

        Else
            Texbbb.TextBox23.Text = ("")


        End If
    End Sub

    Private Sub CheckBox24_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox24.CheckedChanged
        If CheckBox24.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Adobe Acrobat Reader DC"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox24.Text = save.FileName

            End If

        Else
            Texbbb.TextBox24.Text = ("")


        End If
    End Sub

    Private Sub CheckBox25_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox25.CheckedChanged
        If CheckBox25.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Audacity"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox25.Text = save.FileName

            End If

        Else
            Texbbb.TextBox25.Text = ("")


        End If
    End Sub

    Private Sub CheckBox26_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox26.CheckedChanged
        If CheckBox26.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Install Creator"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox26.Text = save.FileName

            End If

        Else
            Texbbb.TextBox26.Text = ("")


        End If
    End Sub

    Private Sub CheckBox27_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox27.CheckedChanged
        If CheckBox27.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Shotcut"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox27.Text = save.FileName

            End If

        Else
            Texbbb.TextBox27.Text = ("")


        End If
    End Sub

    Private Sub CheckBox28_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox28.CheckedChanged
        If CheckBox28.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Trading View"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox28.Text = save.FileName

            End If

        Else
            Texbbb.TextBox28.Text = ("")


        End If
    End Sub

    Private Sub CheckBox29_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox29.CheckedChanged
        If CheckBox29.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Logitech G hub"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox29.Text = save.FileName

            End If

        Else
            Texbbb.TextBox29.Text = ("")


        End If
    End Sub

    Private Sub CheckBox30_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox30.CheckedChanged
        If CheckBox30.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Anydesk"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox30.Text = save.FileName

            End If

        Else
            Texbbb.TextBox30.Text = ("")


        End If
    End Sub

    Private Sub CheckBox31_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox31.CheckedChanged
        If CheckBox31.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Opera"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox31.Text = save.FileName

            End If

        Else
            Texbbb.TextBox31.Text = ("")


        End If
    End Sub

    Private Sub CheckBox32_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox32.CheckedChanged
        If CheckBox32.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Opera Gx"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox32.Text = save.FileName

            End If

        Else
            Texbbb.TextBox32.Text = ("")


        End If
    End Sub

    Private Sub CheckBox33_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox33.CheckedChanged
        If CheckBox33.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Vivaldi"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox33.Text = save.FileName

            End If

        Else
            Texbbb.TextBox33.Text = ("")


        End If
    End Sub

    Private Sub CheckBox34_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox34.CheckedChanged
        If CheckBox34.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Opera Crypto Browser"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox34.Text = save.FileName

            End If

        Else
            Texbbb.TextBox34.Text = ("")


        End If
    End Sub

    Private Sub CheckBox35_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox35.CheckedChanged
        If CheckBox35.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Onlyoffice"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox35.Text = save.FileName

            End If

        Else
            Texbbb.TextBox35.Text = ("")


        End If
    End Sub

    Private Sub CheckBox36_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox36.CheckedChanged
        If CheckBox36.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Rufus"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox36.Text = save.FileName

            End If

        Else
            Texbbb.TextBox36.Text = ("")


        End If
    End Sub

    Private Sub CheckBox37_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox37.CheckedChanged
        If CheckBox37.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Python"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox37.Text = save.FileName

            End If

        Else
            Texbbb.TextBox37.Text = ("")


        End If
    End Sub

    Private Sub CheckBox39_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox39.CheckedChanged
        If CheckBox39.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Openshot"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox38.Text = save.FileName

            End If

        Else
            Texbbb.TextBox38.Text = ("")


        End If
    End Sub

    Private Sub CheckBox40_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox40.CheckedChanged
        If CheckBox40.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Driver Easy"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox39.Text = save.FileName

            End If

        Else
            Texbbb.TextBox39.Text = ("")


        End If
    End Sub

    Private Sub CheckBox42_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox42.CheckedChanged
        If CheckBox42.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Software Updater"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox41.Text = save.FileName

            End If

        Else
            Texbbb.TextBox41.Text = ("")


        End If
    End Sub

    Private Sub CheckBox43_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox43.CheckedChanged
        If CheckBox43.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Soft Usb Passwords"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox42.Text = save.FileName

            End If

        Else
            Texbbb.TextBox42.Text = ("")


        End If
    End Sub

    Private Sub CheckBox44_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox44.CheckedChanged
        If CheckBox44.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Nox"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox43.Text = save.FileName

            End If

        Else
            Texbbb.TextBox43.Text = ("")

        End If
    End Sub

    Private Sub CheckBox45_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox45.CheckedChanged
        If CheckBox45.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Telegram"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox44.Text = save.FileName

            End If

        Else
            Texbbb.TextBox44.Text = ("")


        End If
    End Sub

    Private Sub CheckBox46_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox46.CheckedChanged
        If CheckBox46.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Dev C++"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox45.Text = save.FileName

            End If

        Else
            Texbbb.TextBox45.Text = ("")


        End If
    End Sub

    Private Sub CheckBox47_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox47.CheckedChanged
        If CheckBox47.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Algobuild"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox46.Text = save.FileName

            End If

        Else
            Texbbb.TextBox46.Text = ("")


        End If
    End Sub

    Private Sub CheckBox48_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox48.CheckedChanged
        If CheckBox48.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Crystaldiskmark"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox47.Text = save.FileName

            End If

        Else
            Texbbb.TextBox47.Text = ("")


        End If
    End Sub

    Private Sub CheckBox49_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox49.CheckedChanged
        If CheckBox49.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Crystaldiskinfo"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox48.Text = save.FileName

            End If

        Else
            Texbbb.TextBox48.Text = ("")


        End If
    End Sub

    Private Sub CheckBox50_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox50.CheckedChanged
        If CheckBox50.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Obs Streamlabs"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox49.Text = save.FileName

            End If

        Else
            Texbbb.TextBox49.Text = ("")


        End If
    End Sub

    Private Sub CheckBox51_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox51.CheckedChanged
        If CheckBox51.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Vlc"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox50.Text = save.FileName

            End If

        Else
            Texbbb.TextBox50.Text = ("")


        End If
    End Sub

    Private Sub CheckBox52_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox52.CheckedChanged
        If CheckBox52.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Epic Games Launcher"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox51.Text = save.FileName

            End If

        Else
            Texbbb.TextBox51.Text = ("")


        End If
    End Sub

    Private Sub CheckBox53_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox53.CheckedChanged
        If CheckBox53.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Discord Canary"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox52.Text = save.FileName

            End If

        Else
            Texbbb.TextBox52.Text = ("")


        End If
    End Sub

    Private Sub CheckBox54_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox54.CheckedChanged
        If CheckBox54.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Google Chrome Canary"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox53.Text = save.FileName

            End If

        Else
            Texbbb.TextBox53.Text = ("")


        End If
    End Sub

    Private Sub CheckBox55_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox55.CheckedChanged
        If CheckBox55.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Notion"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox54.Text = save.FileName

            End If

        Else
            Texbbb.TextBox54.Text = ("")


        End If
    End Sub

    Private Sub CheckBox56_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox56.CheckedChanged
        If CheckBox56.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Nvidia Geforce Experience"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox55.Text = save.FileName

            End If

        Else
            Texbbb.TextBox55.Text = ("")


        End If
    End Sub

    Private Sub CheckBox57_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox57.CheckedChanged
        If CheckBox57.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Filezilla Client"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox56.Text = save.FileName

            End If

        Else
            Texbbb.TextBox56.Text = ("")


        End If
    End Sub

    Private Sub CheckBox58_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox58.CheckedChanged
        If CheckBox58.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Filezilla Server"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox57.Text = save.FileName

            End If

        Else
            Texbbb.TextBox57.Text = ("")


        End If
    End Sub

    Private Sub CheckBox59_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox59.CheckedChanged
        If CheckBox59.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Advanced Systemcare"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox58.Text = save.FileName

            End If

        Else
            Texbbb.TextBox58.Text = ("")


        End If
    End Sub

    Private Sub CheckBox60_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox60.CheckedChanged
        If CheckBox60.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Smart Defrag"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox59.Text = save.FileName

            End If

        Else
            Texbbb.TextBox59.Text = ("")


        End If
    End Sub

    Private Sub CheckBox61_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox61.CheckedChanged
        If CheckBox61.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Protected Folder"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox60.Text = save.FileName

            End If

        Else
            Texbbb.TextBox60.Text = ("")


        End If
    End Sub

    Private Sub CheckBox62_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox62.CheckedChanged
        If CheckBox62.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Itop Vpn"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox61.Text = save.FileName

            End If

        Else
            Texbbb.TextBox61.Text = ("")


        End If
    End Sub

    Private Sub CheckBox63_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox63.CheckedChanged
        If CheckBox63.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Droidcam"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox62.Text = save.FileName

            End If

        Else
            Texbbb.TextBox62.Text = ("")


        End If
    End Sub

    Private Sub CheckBox64_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox64.CheckedChanged
        If CheckBox64.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Openoffice"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox63.Text = save.FileName

            End If

        Else
            Texbbb.TextBox63.Text = ("")


        End If
    End Sub

    Private Sub CheckBox65_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox65.CheckedChanged
        If CheckBox65.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Ps remote Play"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox64.Text = save.FileName

            End If

        Else
            Texbbb.TextBox64.Text = ("")


        End If
    End Sub

    Private Sub Timer12_Tick_1(sender As Object, e As EventArgs) Handles Timer12.Tick
        Panel8.BackColor = Color.FromArgb(TrackBar1.Value, Color.Gold)
    End Sub

    Private Sub Label62_Click(sender As Object, e As EventArgs) Handles Label62.Click
        PictureBox71.Show()
        PictureBox63.Show()
        PictureBox62.Show()
        PictureBox10.Show()
        PictureBox9.Show()
        Panel3.Hide()
        Panel2.Hide()
        Panel1.Hide()
        Panel4.Hide()
        Panel5.Hide()
        Panel6.Hide()
        Panel21.Hide()
        Panel20.Show()
        Vsc.Hide()
        Vs.Hide()
        Ed.Hide()
        Ch.Hide()
        Fi.Hide()
        Bd.Hide()
        u.Hide()
        sz.Hide()
        hw.Hide()
        tv.Hide()
        so.Hide()
        gi.Hide()
        ac.Hide()
        au.Hide()
        ic.Hide()
        sh.Hide()
        tr.Hide()
        lh.Hide()
        an.Hide()
        vscp.Hide()
        vsp.Hide()
        lbp.Hide()
        edp.Hide()
        chp.Hide()
        fip.Hide()
        bdp.Hide()
        up.Hide()
        hwp.Hide()
        szp.Hide()
        Lb.Hide()
        CheckBox1.Hide()
        CheckBox2.Hide()
        CheckBox3.Hide()
        CheckBox4.Hide()
        CheckBox5.Hide()
        CheckBox6.Hide()
        CheckBox7.Hide()
        CheckBox8.Hide()
        CheckBox9.Hide()
        CheckBox10.Hide()
        CheckBox11.Hide()
        CheckBox12.Hide()
        CheckBox13.Hide()
        CheckBox14.Hide()
        CheckBox15.Hide()
        CheckBox16.Hide()
        CheckBox17.Hide()
        CheckBox18.Hide()
        CheckBox19.Hide()
        CheckBox20.Hide()
        CheckBox21.Hide()
        CheckBox22.Hide()
        CheckBox23.Hide()
        CheckBox24.Hide()
        CheckBox25.Hide()
        CheckBox26.Hide()
        CheckBox27.Hide()
        CheckBox28.Hide()
        CheckBox29.Hide()
        CheckBox30.Hide()
        CheckBox31.Hide()
        CheckBox32.Hide()
        CheckBox33.Hide()
        CheckBox34.Hide()
        CheckBox35.Hide()
        CheckBox36.Hide()
        CheckBox37.Hide()
        CheckBox38.Hide()
        CheckBox39.Hide()
        CheckBox40.Hide()
        CheckBox41.Hide()
        CheckBox42.Hide()
        CheckBox43.Hide()
        CheckBox44.Hide()
        CheckBox45.Hide()
        CheckBox46.Hide()
        CheckBox47.Hide()
        CheckBox48.Hide()
        CheckBox49.Hide()
        CheckBox50.Hide()
        CheckBox51.Hide()
        CheckBox52.Hide()
        CheckBox53.Hide()
        CheckBox54.Hide()
        CheckBox55.Hide()
        CheckBox56.Hide()
        CheckBox57.Hide()
        CheckBox58.Hide()
        CheckBox59.Hide()
        CheckBox60.Show()
        CheckBox61.Show()
        CheckBox62.Show()
        CheckBox63.Show()
        CheckBox64.Show()
        CheckBox65.Show()
        CheckBox66.Show()
        CheckBox79.Show()
        CheckBox74.Show()
    End Sub

    Private Sub Label61_Click(sender As Object, e As EventArgs) Handles Label61.Click
        PictureBox71.Hide()
        PictureBox63.Hide()
        PictureBox62.Hide()
        PictureBox10.Hide()
        PictureBox9.Hide()
        Panel3.Hide()
        Panel2.Hide()
        Panel1.Hide()
        Panel4.Hide()
        Panel5.Hide()
        Panel6.Hide()
        Panel21.Show()
        Panel20.Hide()
        Vsc.Hide()
        Vs.Hide()
        Ed.Hide()
        Ch.Hide()
        Fi.Hide()
        Bd.Hide()
        u.Hide()
        sz.Hide()
        hw.Hide()
        tv.Hide()
        so.Hide()
        gi.Hide()
        ac.Hide()
        au.Hide()
        ic.Hide()
        sh.Hide()
        tr.Hide()
        lh.Hide()
        an.Hide()
        vscp.Hide()
        vsp.Hide()
        lbp.Hide()
        edp.Hide()
        chp.Hide()
        fip.Hide()
        bdp.Hide()
        up.Hide()
        hwp.Hide()
        szp.Hide()
        Lb.Hide()
        CheckBox1.Hide()
        CheckBox2.Hide()
        CheckBox3.Hide()
        CheckBox4.Hide()
        CheckBox5.Hide()
        CheckBox6.Hide()
        CheckBox7.Hide()
        CheckBox8.Hide()
        CheckBox9.Hide()
        CheckBox10.Hide()
        CheckBox11.Hide()
        CheckBox12.Hide()
        CheckBox13.Hide()
        CheckBox14.Hide()
        CheckBox15.Hide()
        CheckBox16.Hide()
        CheckBox17.Hide()
        CheckBox18.Hide()
        CheckBox19.Hide()
        CheckBox20.Hide()
        CheckBox21.Hide()
        CheckBox22.Hide()
        CheckBox23.Hide()
        CheckBox24.Hide()
        CheckBox25.Hide()
        CheckBox26.Hide()
        CheckBox27.Hide()
        CheckBox28.Hide()
        CheckBox29.Hide()
        CheckBox30.Hide()
        CheckBox31.Hide()
        CheckBox32.Hide()
        CheckBox33.Hide()
        CheckBox34.Hide()
        CheckBox35.Hide()
        CheckBox36.Hide()
        CheckBox37.Hide()
        CheckBox38.Hide()
        CheckBox39.Hide()
        CheckBox40.Hide()
        CheckBox41.Hide()
        CheckBox42.Hide()
        CheckBox43.Hide()
        CheckBox44.Hide()
        CheckBox45.Hide()
        CheckBox46.Hide()
        CheckBox47.Hide()
        CheckBox48.Hide()
        CheckBox49.Hide()
        CheckBox50.Hide()
        CheckBox51.Hide()
        CheckBox52.Hide()
        CheckBox53.Hide()
        CheckBox54.Hide()
        CheckBox55.Hide()
        CheckBox56.Hide()
        CheckBox57.Hide()
        CheckBox58.Hide()
        CheckBox59.Hide()
        CheckBox60.Show()
        CheckBox61.Show()
        CheckBox62.Show()
        CheckBox63.Show()
        CheckBox64.Show()
        CheckBox65.Show()
        CheckBox66.Show()
        CheckBox79.Hide()
        CheckBox74.Hide()
    End Sub

    Private Sub CheckBox67_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox67.CheckedChanged
        If CheckBox67.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Docker"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox66.Text = save.FileName

            End If

        Else
            Texbbb.TextBox66.Text = ("")


        End If
    End Sub

    Private Sub CheckBox68_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox68.CheckedChanged
        If CheckBox68.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Avast"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox67.Text = save.FileName

            End If

        Else
            Texbbb.TextBox67.Text = ("")


        End If
    End Sub

    Private Sub CheckBox69_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox69.CheckedChanged
        If CheckBox69.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Malware Bytes"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox68.Text = save.FileName

            End If

        Else
            Texbbb.TextBox68.Text = ("")


        End If
    End Sub

    Private Sub CheckBox70_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox70.CheckedChanged
        If CheckBox70.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Greenshot"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox78.Text = save.FileName

            End If

        Else
            Texbbb.TextBox78.Text = ("")


        End If
    End Sub

    Private Sub CheckBox79_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox79.CheckedChanged
        If CheckBox79.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Avg"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox69.Text = save.FileName

            End If

        Else
            Texbbb.TextBox69.Text = ("")


        End If
    End Sub

    Private Sub CheckBox78_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox78.CheckedChanged
        If CheckBox78.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Vim"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox70.Text = save.FileName

            End If

        Else
            Texbbb.TextBox70.Text = ("")


        End If
    End Sub

    Private Sub CheckBox71_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox71.CheckedChanged
        If CheckBox71.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "TunnelBear"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox71.Text = save.FileName

            End If

        Else
            Texbbb.TextBox71.Text = ("")


        End If
    End Sub

    Private Sub CheckBox77_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox77.CheckedChanged
        If CheckBox77.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Node Js"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox72.Text = save.FileName

            End If

        Else
            Texbbb.TextBox72.Text = ("")


        End If
    End Sub

    Private Sub CheckBox76_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox76.CheckedChanged
        If CheckBox76.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Mega"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox73.Text = save.FileName

            End If

        Else
            Texbbb.TextBox73.Text = ("")


        End If
    End Sub

    Private Sub CheckBox75_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox75.CheckedChanged
        If CheckBox75.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Smart Game Booster"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox74.Text = save.FileName

            End If

        Else
            Texbbb.TextBox74.Text = ("")


        End If
    End Sub

    Private Sub CheckBox74_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox74.CheckedChanged
        If CheckBox74.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Balena Etcher"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox75.Text = save.FileName

            End If

        Else
            Texbbb.TextBox75.Text = ("")


        End If
    End Sub

    Private Sub CheckBox73_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox73.CheckedChanged
        If CheckBox73.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Deskreen"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox76.Text = save.FileName

            End If

        Else
            Texbbb.TextBox76.Text = ("")


        End If
    End Sub

    Private Sub CheckBox72_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox72.CheckedChanged
        If CheckBox72.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Vera Crypt"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox77.Text = save.FileName

            End If

        Else
            Texbbb.TextBox77.Text = ("")


        End If
    End Sub

    Private Sub Panel17_Paint(sender As Object, e As PaintEventArgs) Handles Panel17.Paint

    End Sub

    Private Sub CheckBox89_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox89.CheckedChanged
        If CheckBox89.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "File Converter"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox79.Text = save.FileName

            End If

        Else
            Texbbb.TextBox79.Text = ("")


        End If
    End Sub

    Private Sub CheckBox88_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox88.CheckedChanged
        If CheckBox88.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Edge Dev"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox80.Text = save.FileName

            End If

        Else
            Texbbb.TextBox80.Text = ("")


        End If
    End Sub

    Private Sub CheckBox87_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox87.CheckedChanged
        If CheckBox87.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Edge Beta"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox81.Text = save.FileName

            End If

        Else
            Texbbb.TextBox81.Text = ("")


        End If
    End Sub

    Private Sub CheckBox66_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox66.CheckedChanged
        If CheckBox66.Checked Then
            Dim save As New SaveFileDialog
            save.Filter = "Archivio zip|.zip"
            save.FileName = "Itunes"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Texbbb.TextBox65.Text = save.FileName

            End If

        Else
            Texbbb.TextBox65.Text = ("")


        End If
    End Sub
End Class
