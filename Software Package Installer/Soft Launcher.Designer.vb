<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Soft_Launcher
    Inherits MaterialSkin.Controls.MaterialForm

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
        Me.MaterialButton2 = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MaterialButton2
        '
        Me.MaterialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.MaterialButton2.Depth = 0
        Me.MaterialButton2.HighEmphasis = True
        Me.MaterialButton2.Icon = Nothing
        Me.MaterialButton2.Location = New System.Drawing.Point(559, 262)
        Me.MaterialButton2.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialButton2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialButton2.Name = "MaterialButton2"
        Me.MaterialButton2.NoAccentTextColor = System.Drawing.Color.Empty
        Me.MaterialButton2.Size = New System.Drawing.Size(82, 36)
        Me.MaterialButton2.TabIndex = 215
        Me.MaterialButton2.Text = "Scarica"
        Me.MaterialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.MaterialButton2.UseAccentColor = False
        Me.MaterialButton2.UseVisualStyleBackColor = True
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel1.Location = New System.Drawing.Point(149, 128)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(101, 19)
        Me.MaterialLabel1.TabIndex = 209
        Me.MaterialLabel1.Text = "Soft Launcher"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(559, 71)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 208
        Me.TextBox2.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Software_Package_Installer.My.Resources.Resources.Senza_titolo4
        Me.PictureBox1.Location = New System.Drawing.Point(27, 86)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(116, 101)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 207
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'Timer2
        '
        '
        'Soft_Launcher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 321)
        Me.Controls.Add(Me.MaterialButton2)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.Name = "Soft_Launcher"
        Me.Text = "Soft Launcher"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MaterialButton2 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
End Class
