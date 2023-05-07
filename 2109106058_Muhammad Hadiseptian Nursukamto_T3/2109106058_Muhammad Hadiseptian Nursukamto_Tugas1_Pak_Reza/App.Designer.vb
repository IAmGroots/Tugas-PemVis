<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class App
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.tmrStart = New System.Windows.Forms.Timer(Me.components)
        Me.tmrFinish = New System.Windows.Forms.Timer(Me.components)
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.txtJari = New System.Windows.Forms.TextBox()
        Me.txtKecepatan = New System.Windows.Forms.TextBox()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtHasil = New System.Windows.Forms.Button()
        Me.background = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrStart
        '
        Me.tmrStart.Enabled = True
        '
        'tmrFinish
        '
        Me.tmrFinish.Enabled = True
        '
        'btnHitung
        '
        Me.btnHitung.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnHitung.BackColor = System.Drawing.Color.White
        Me.btnHitung.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHitung.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHitung.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHitung.Location = New System.Drawing.Point(115, 267)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(150, 48)
        Me.btnHitung.TabIndex = 0
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = False
        '
        'txtJari
        '
        Me.txtJari.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtJari.BackColor = System.Drawing.Color.White
        Me.txtJari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtJari.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJari.Location = New System.Drawing.Point(271, 156)
        Me.txtJari.Name = "txtJari"
        Me.txtJari.Size = New System.Drawing.Size(150, 35)
        Me.txtJari.TabIndex = 1
        '
        'txtKecepatan
        '
        Me.txtKecepatan.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtKecepatan.BackColor = System.Drawing.Color.White
        Me.txtKecepatan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKecepatan.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKecepatan.Location = New System.Drawing.Point(271, 103)
        Me.txtKecepatan.Name = "txtKecepatan"
        Me.txtKecepatan.Size = New System.Drawing.Size(150, 35)
        Me.txtKecepatan.TabIndex = 2
        '
        'btnKeluar
        '
        Me.btnKeluar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnKeluar.BackColor = System.Drawing.Color.White
        Me.btnKeluar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKeluar.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeluar.Location = New System.Drawing.Point(271, 267)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(150, 48)
        Me.btnKeluar.TabIndex = 4
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(180, 159)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 27)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Jari-jari"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(90, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 27)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Kecepatan linear"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(204, 212)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 27)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Hasil"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Location = New System.Drawing.Point(427, 103)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(270, 212)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'txtHasil
        '
        Me.txtHasil.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtHasil.BackColor = System.Drawing.Color.White
        Me.txtHasil.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtHasil.Enabled = False
        Me.txtHasil.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.txtHasil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtHasil.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHasil.ForeColor = System.Drawing.Color.Black
        Me.txtHasil.Location = New System.Drawing.Point(271, 208)
        Me.txtHasil.Name = "txtHasil"
        Me.txtHasil.Size = New System.Drawing.Size(150, 35)
        Me.txtHasil.TabIndex = 9
        Me.txtHasil.UseVisualStyleBackColor = False
        '
        'background
        '
        Me.background.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.background.BackColor = System.Drawing.Color.White
        Me.background.Enabled = False
        Me.background.FlatAppearance.BorderSize = 0
        Me.background.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.background.Location = New System.Drawing.Point(66, 73)
        Me.background.Name = "background"
        Me.background.Size = New System.Drawing.Size(658, 272)
        Me.background.TabIndex = 10
        Me.background.UseVisualStyleBackColor = False
        '
        'App
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtHasil)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.txtKecepatan)
        Me.Controls.Add(Me.txtJari)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.background)
        Me.Name = "App"
        Me.Text = "2109106058 - Percepatan Sentripetal"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tmrStart As Timer
    Friend WithEvents tmrFinish As Timer
    Friend WithEvents btnHitung As Button
    Friend WithEvents txtJari As TextBox
    Friend WithEvents txtKecepatan As TextBox
    Friend WithEvents btnKeluar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtHasil As Button
    Friend WithEvents background As Button
End Class
