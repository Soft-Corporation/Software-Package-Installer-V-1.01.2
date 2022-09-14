<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Battlenet
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.PictureBox61 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer6 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer7 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer8 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer9 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer12 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.PictureBox61, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(401, 186)
        Me.TrackBar1.Maximum = 255
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(104, 45)
        Me.TrackBar1.TabIndex = 510
        Me.TrackBar1.Value = 80
        Me.TrackBar1.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(14, 353)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(638, 20)
        Me.TextBox1.TabIndex = 507
        Me.TextBox1.Text = "Destinazione Installer"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.RoyalBlue
        Me.ProgressBar1.Location = New System.Drawing.Point(14, 102)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(638, 23)
        Me.ProgressBar1.TabIndex = 506
        Me.ProgressBar1.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(539, 177)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 502
        Me.TextBox2.Visible = False
        '
        'Panel9
        '
        Me.Panel9.BackgroundImage = Global.Software_Package_Installer.My.Resources.Resources._3
        Me.Panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel9.Controls.Add(Me.Panel8)
        Me.Panel9.Location = New System.Drawing.Point(-1, -1)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(668, 84)
        Me.Panel9.TabIndex = 503
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
        Me.Label3.Size = New System.Drawing.Size(450, 39)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Download di Discord Canary"
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
        'Timer1
        '
        '
        'Timer12
        '
        '
        'Battlenet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Software_Package_Installer.My.Resources.Resources.Immagine_2022_06_13_20345310
        Me.ClientSize = New System.Drawing.Size(664, 148)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.TextBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "Battlenet"
        Me.Text = "Discord Canary"
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.PictureBox61, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents PictureBox61 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Timer5 As Timer
    Friend WithEvents Timer6 As Timer
    Friend WithEvents Timer7 As Timer
    Friend WithEvents Timer8 As Timer
    Friend WithEvents Timer9 As Timer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer12 As Timer
End Class
