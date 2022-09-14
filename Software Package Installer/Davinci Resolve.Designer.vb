<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Davinci_Resolve
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer6 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer7 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer8 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer9 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.PictureBox61 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer12 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.PictureBox61, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(355, 355)
        Me.TrackBar1.Maximum = 255
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(104, 45)
        Me.TrackBar1.TabIndex = 380
        Me.TrackBar1.Value = 80
        Me.TrackBar1.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(148, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 25)
        Me.Label4.TabIndex = 374
        Me.Label4.Text = "Davinci resolve"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(513, 335)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 372
        Me.TextBox2.Visible = False
        '
        'Timer5
        '
        '
        'Timer6
        '
        '
        'Timer7
        '
        '
        'Timer8
        '
        '
        'Timer9
        '
        '
        'Panel9
        '
        Me.Panel9.BackgroundImage = Global.Software_Package_Installer.My.Resources.Resources._3
        Me.Panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel9.Controls.Add(Me.Panel8)
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(668, 84)
        Me.Panel9.TabIndex = 373
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.PictureBox61)
        Me.Panel8.Controls.Add(Me.Label3)
        Me.Panel8.Location = New System.Drawing.Point(3, 3)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(665, 83)
        Me.Panel8.TabIndex = 28
        '
        'PictureBox61
        '
        Me.PictureBox61.Image = Global.Software_Package_Installer.My.Resources.Resources.Senza_titolo10
        Me.PictureBox61.Location = New System.Drawing.Point(3, 12)
        Me.PictureBox61.Name = "PictureBox61"
        Me.PictureBox61.Size = New System.Drawing.Size(54, 41)
        Me.PictureBox61.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox61.TabIndex = 29
        Me.PictureBox61.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.25!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(60, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(461, 39)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Download di Davinci Resolve"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Software_Package_Installer.My.Resources.Resources.DaVinci_Resolve_17_logo2
        Me.PictureBox1.Location = New System.Drawing.Point(26, 97)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(116, 101)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 371
        Me.PictureBox1.TabStop = False
        '
        'Timer12
        '
        '
        'Davinci_Resolve
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Software_Package_Installer.My.Resources.Resources.Immagine_2022_06_13_20345310
        Me.ClientSize = New System.Drawing.Size(668, 224)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "Davinci_Resolve"
        Me.Text = "Davinci Resolve"
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.PictureBox61, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents PictureBox61 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer5 As Timer
    Friend WithEvents Timer6 As Timer
    Friend WithEvents Timer7 As Timer
    Friend WithEvents Timer8 As Timer
    Friend WithEvents Timer9 As Timer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer12 As Timer
End Class
