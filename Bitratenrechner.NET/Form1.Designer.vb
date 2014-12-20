Partial Public Class Form1
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

    End Sub

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Text5 = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Check1 = New System.Windows.Forms.CheckBox
        Me.Ziel_AudRate = New System.Windows.Forms.ComboBox
        Me.Quelle_AudRate = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Text_Sekunden = New System.Windows.Forms.TextBox
        Me.Text_Minuten = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Text_Stunden = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Ziel_VidRate = New System.Windows.Forms.TextBox
        Me.Quelle_VidRate = New System.Windows.Forms.TextBox
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Text5)
        Me.GroupBox3.Controls.Add(Me.Check1)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(8, 244)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox3.Size = New System.Drawing.Size(170, 66)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Größe (MBytes)"
        '
        'Text5
        '
        Me.Text5.Location = New System.Drawing.Point(7, 14)
        Me.Text5.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Text5.Name = "Text5"
        Me.Text5.Size = New System.Drawing.Size(153, 21)
        Me.Text5.TabIndex = 12
        Me.Text5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Ziel_AudRate)
        Me.GroupBox2.Controls.Add(Me.Quelle_AudRate)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(8, 153)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox2.Size = New System.Drawing.Size(170, 73)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Audio-Bitrate"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Enabled = False
        Me.Label8.Location = New System.Drawing.Point(83, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 15)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Ziel"
        '
        'Check1
        '
        Me.Check1.AutoSize = True
        Me.Check1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Check1.Location = New System.Drawing.Point(122, 42)
        Me.Check1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Check1.Name = "Check1"
        Me.Check1.Size = New System.Drawing.Size(15, 14)
        Me.Check1.TabIndex = 5
        '
        'Ziel_AudRate
        '
        Me.Ziel_AudRate.Enabled = False
        Me.Ziel_AudRate.FormattingEnabled = True
        Me.Ziel_AudRate.Items.AddRange(New Object() {"32", "64", "80", "96", "112", "128", "160", "192", "224", "256", "320", "384"})
        Me.Ziel_AudRate.Location = New System.Drawing.Point(86, 38)
        Me.Ziel_AudRate.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Ziel_AudRate.Name = "Ziel_AudRate"
        Me.Ziel_AudRate.Size = New System.Drawing.Size(74, 23)
        Me.Ziel_AudRate.TabIndex = 4
        Me.Ziel_AudRate.Text = "128"
        '
        'Quelle_AudRate
        '
        Me.Quelle_AudRate.FormattingEnabled = True
        Me.Quelle_AudRate.Items.AddRange(New Object() {"32", "64", "80", "96", "112", "128", "160", "192", "224", "256", "320", "384"})
        Me.Quelle_AudRate.Location = New System.Drawing.Point(11, 38)
        Me.Quelle_AudRate.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Quelle_AudRate.Name = "Quelle_AudRate"
        Me.Quelle_AudRate.Size = New System.Drawing.Size(69, 23)
        Me.Quelle_AudRate.TabIndex = 3
        Me.Quelle_AudRate.Text = "128"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(8, 41)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Differenz ermitteln:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Quelle"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Text_Sekunden)
        Me.GroupBox1.Controls.Add(Me.Text_Minuten)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Text_Stunden)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(7, 7)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(171, 72)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Clip-Dauer"
        '
        'Text_Sekunden
        '
        Me.Text_Sekunden.Location = New System.Drawing.Point(101, 36)
        Me.Text_Sekunden.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Text_Sekunden.Name = "Text_Sekunden"
        Me.Text_Sekunden.Size = New System.Drawing.Size(23, 21)
        Me.Text_Sekunden.TabIndex = 7
        Me.Text_Sekunden.Text = "00"
        '
        'Text_Minuten
        '
        Me.Text_Minuten.Location = New System.Drawing.Point(58, 36)
        Me.Text_Minuten.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Text_Minuten.Name = "Text_Minuten"
        Me.Text_Minuten.Size = New System.Drawing.Size(23, 21)
        Me.Text_Minuten.TabIndex = 6
        Me.Text_Minuten.Text = "00"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(15, 15)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Std.      Min.      Sek."
        '
        'Text_Stunden
        '
        Me.Text_Stunden.Location = New System.Drawing.Point(18, 36)
        Me.Text_Stunden.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Text_Stunden.Name = "Text_Stunden"
        Me.Text_Stunden.Size = New System.Drawing.Size(23, 21)
        Me.Text_Stunden.TabIndex = 5
        Me.Text_Stunden.Text = "00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = ":             :"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Ziel_VidRate)
        Me.GroupBox4.Controls.Add(Me.Quelle_VidRate)
        Me.GroupBox4.Location = New System.Drawing.Point(7, 85)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(170, 62)
        Me.GroupBox4.TabIndex = 15
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Video-Bitrate"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Enabled = False
        Me.Label7.Location = New System.Drawing.Point(83, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Ziel"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Quelle"
        '
        'Ziel_VidRate
        '
        Me.Ziel_VidRate.Enabled = False
        Me.Ziel_VidRate.Location = New System.Drawing.Point(86, 30)
        Me.Ziel_VidRate.Name = "Ziel_VidRate"
        Me.Ziel_VidRate.Size = New System.Drawing.Size(74, 20)
        Me.Ziel_VidRate.TabIndex = 1
        '
        'Quelle_VidRate
        '
        Me.Quelle_VidRate.Location = New System.Drawing.Point(6, 32)
        Me.Quelle_VidRate.Name = "Quelle_VidRate"
        Me.Quelle_VidRate.Size = New System.Drawing.Size(74, 20)
        Me.Quelle_VidRate.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(186, 321)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "BitratenRechner.NET"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Text5 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Check1 As System.Windows.Forms.CheckBox
    Friend WithEvents Ziel_AudRate As System.Windows.Forms.ComboBox
    Friend WithEvents Quelle_AudRate As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Text_Sekunden As System.Windows.Forms.TextBox
    Friend WithEvents Text_Minuten As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Text_Stunden As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Ziel_VidRate As System.Windows.Forms.TextBox
    Friend WithEvents Quelle_VidRate As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
