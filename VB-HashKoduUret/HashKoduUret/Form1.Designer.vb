<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MetinTBox = New System.Windows.Forms.TextBox()
        Me.HashAlgoritmaCBox = New System.Windows.Forms.ComboBox()
        Me.HashKoduTBox = New System.Windows.Forms.TextBox()
        Me.UzunlukTBox = New System.Windows.Forms.TextBox()
        Me.KopyalaBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Metin:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Hash Algoritması:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Hash Kodu:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Uzunluk:"
        '
        'MetinTBox
        '
        Me.MetinTBox.Location = New System.Drawing.Point(110, 28)
        Me.MetinTBox.Name = "MetinTBox"
        Me.MetinTBox.Size = New System.Drawing.Size(577, 20)
        Me.MetinTBox.TabIndex = 4
        '
        'HashAlgoritmaCBox
        '
        Me.HashAlgoritmaCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.HashAlgoritmaCBox.FormattingEnabled = True
        Me.HashAlgoritmaCBox.Items.AddRange(New Object() {"Bir Algoritma Seçiniz", "MD5", "SHA1", "SHA256", "SHA384", "SHA512"})
        Me.HashAlgoritmaCBox.Location = New System.Drawing.Point(110, 54)
        Me.HashAlgoritmaCBox.Name = "HashAlgoritmaCBox"
        Me.HashAlgoritmaCBox.Size = New System.Drawing.Size(209, 21)
        Me.HashAlgoritmaCBox.TabIndex = 5
        '
        'HashKoduTBox
        '
        Me.HashKoduTBox.Location = New System.Drawing.Point(110, 81)
        Me.HashKoduTBox.Multiline = True
        Me.HashKoduTBox.Name = "HashKoduTBox"
        Me.HashKoduTBox.ReadOnly = True
        Me.HashKoduTBox.Size = New System.Drawing.Size(577, 130)
        Me.HashKoduTBox.TabIndex = 6
        '
        'UzunlukTBox
        '
        Me.UzunlukTBox.Location = New System.Drawing.Point(110, 217)
        Me.UzunlukTBox.Name = "UzunlukTBox"
        Me.UzunlukTBox.ReadOnly = True
        Me.UzunlukTBox.Size = New System.Drawing.Size(100, 20)
        Me.UzunlukTBox.TabIndex = 7
        '
        'KopyalaBtn
        '
        Me.KopyalaBtn.FlatAppearance.BorderSize = 0
        Me.KopyalaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KopyalaBtn.Image = Global.HashKoduUret.My.Resources.Resources.kopyala
        Me.KopyalaBtn.Location = New System.Drawing.Point(558, 220)
        Me.KopyalaBtn.Name = "KopyalaBtn"
        Me.KopyalaBtn.Size = New System.Drawing.Size(129, 23)
        Me.KopyalaBtn.TabIndex = 8
        Me.KopyalaBtn.Text = "Hafızaya Kopyala"
        Me.KopyalaBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.KopyalaBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 265)
        Me.Controls.Add(Me.KopyalaBtn)
        Me.Controls.Add(Me.UzunlukTBox)
        Me.Controls.Add(Me.HashKoduTBox)
        Me.Controls.Add(Me.HashAlgoritmaCBox)
        Me.Controls.Add(Me.MetinTBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Hash Kodu Üret"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents MetinTBox As TextBox
    Friend WithEvents HashAlgoritmaCBox As ComboBox
    Friend WithEvents HashKoduTBox As TextBox
    Friend WithEvents UzunlukTBox As TextBox
    Friend WithEvents KopyalaBtn As Button
End Class
