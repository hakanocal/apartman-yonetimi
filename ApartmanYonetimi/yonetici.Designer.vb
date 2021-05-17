<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class yonetici
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_sifre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tb_ad = New System.Windows.Forms.TextBox()
        Me.tb_soyad = New System.Windows.Forms.TextBox()
        Me.tb_telefon = New System.Windows.Forms.TextBox()
        Me.tb_eposta = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tb_sifre_tekrar = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_site_adi = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_tc = New System.Windows.Forms.MaskedTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.guvenlik_sorusu = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cevap = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(427, 206)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Giriş Şifresi:"
        '
        'tb_sifre
        '
        Me.tb_sifre.Location = New System.Drawing.Point(496, 203)
        Me.tb_sifre.Name = "tb_sifre"
        Me.tb_sifre.Size = New System.Drawing.Size(130, 20)
        Me.tb_sifre.TabIndex = 8
        Me.tb_sifre.UseSystemPasswordChar = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.Location = New System.Drawing.Point(421, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "YÖNETİCİ BİLGİLERİ"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(465, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 13)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Ad:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(448, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Soyad:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(442, 116)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Telefon:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(442, 143)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 13)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "E-posta:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(464, 173)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(24, 13)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "TC:"
        '
        'tb_ad
        '
        Me.tb_ad.Location = New System.Drawing.Point(495, 53)
        Me.tb_ad.Name = "tb_ad"
        Me.tb_ad.Size = New System.Drawing.Size(130, 20)
        Me.tb_ad.TabIndex = 3
        '
        'tb_soyad
        '
        Me.tb_soyad.Location = New System.Drawing.Point(495, 83)
        Me.tb_soyad.Name = "tb_soyad"
        Me.tb_soyad.Size = New System.Drawing.Size(130, 20)
        Me.tb_soyad.TabIndex = 4
        '
        'tb_telefon
        '
        Me.tb_telefon.Location = New System.Drawing.Point(495, 113)
        Me.tb_telefon.Name = "tb_telefon"
        Me.tb_telefon.Size = New System.Drawing.Size(130, 20)
        Me.tb_telefon.TabIndex = 5
        '
        'tb_eposta
        '
        Me.tb_eposta.Location = New System.Drawing.Point(495, 143)
        Me.tb_eposta.Name = "tb_eposta"
        Me.tb_eposta.Size = New System.Drawing.Size(130, 20)
        Me.tb_eposta.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(423, 235)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 13)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "Şifre Tekrar:"
        '
        'tb_sifre_tekrar
        '
        Me.tb_sifre_tekrar.Location = New System.Drawing.Point(496, 233)
        Me.tb_sifre_tekrar.Name = "tb_sifre_tekrar"
        Me.tb_sifre_tekrar.Size = New System.Drawing.Size(130, 20)
        Me.tb_sifre_tekrar.TabIndex = 9
        Me.tb_sifre_tekrar.UseSystemPasswordChar = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(440, 400)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 40)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "İPTAL"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(536, 400)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 40)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "KAYDET"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(138, 90)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(223, 93)
        Me.RichTextBox1.TabIndex = 2
        Me.RichTextBox1.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(173, 13)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "APARTMAN/SİTE BİLGİLERİ"
        '
        'tb_site_adi
        '
        Me.tb_site_adi.Location = New System.Drawing.Point(138, 56)
        Me.tb_site_adi.Name = "tb_site_adi"
        Me.tb_site_adi.Size = New System.Drawing.Size(223, 20)
        Me.tb_site_adi.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(96, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Adres:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Apartman/Site Adı:"
        '
        'tb_tc
        '
        Me.tb_tc.Location = New System.Drawing.Point(496, 174)
        Me.tb_tc.Mask = "00000000000"
        Me.tb_tc.Name = "tb_tc"
        Me.tb_tc.Size = New System.Drawing.Size(129, 20)
        Me.tb_tc.TabIndex = 7
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(447, 266)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 13)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "YETKİ:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"TAM YETKI"})
        Me.ComboBox1.Location = New System.Drawing.Point(496, 262)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(130, 21)
        Me.ComboBox1.TabIndex = 10
        '
        'guvenlik_sorusu
        '
        Me.guvenlik_sorusu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.guvenlik_sorusu.FormattingEnabled = True
        Me.guvenlik_sorusu.Items.AddRange(New Object() {"En iyi çocukluk arkadaşınız kimdi?", "İlk evcil hayvanınızın ismi neydi?", "Sinemada seyrettiğiniz ilk film neydi?", "ilkokulda en sevdiğiniz öğretmenin adı neydi?", "Yapmayı öğrendiğiniz ilk yemek nedir?", "Hayalinizde ki iş nedir?", "En sevdiğiniz şarkıcı kimdir?"})
        Me.guvenlik_sorusu.Location = New System.Drawing.Point(392, 294)
        Me.guvenlik_sorusu.Name = "guvenlik_sorusu"
        Me.guvenlik_sorusu.Size = New System.Drawing.Size(234, 21)
        Me.guvenlik_sorusu.TabIndex = 47
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(298, 297)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 13)
        Me.Label13.TabIndex = 48
        Me.Label13.Text = "Güvenlik Sorusu:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(345, 327)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(41, 13)
        Me.Label14.TabIndex = 49
        Me.Label14.Text = "Cevap:"
        '
        'cevap
        '
        Me.cevap.Location = New System.Drawing.Point(392, 324)
        Me.cevap.Name = "cevap"
        Me.cevap.Size = New System.Drawing.Size(233, 20)
        Me.cevap.TabIndex = 50
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label15.Location = New System.Drawing.Point(298, 356)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(328, 26)
        Me.Label15.TabIndex = 51
        Me.Label15.Text = "Bu sorular parolanızı unutmanız halinde geri almanız için kullanılacak." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Büyük/Kü" & _
    "çük harf duyarlılığı vardır!"
        '
        'yonetici
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 461)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.cevap)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.guvenlik_sorusu)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.tb_tc)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tb_site_adi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tb_sifre_tekrar)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.tb_eposta)
        Me.Controls.Add(Me.tb_telefon)
        Me.Controls.Add(Me.tb_soyad)
        Me.Controls.Add(Me.tb_ad)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tb_sifre)
        Me.Controls.Add(Me.Label3)
        Me.Name = "yonetici"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "APARTMAN VE YÖNETİCİ EKLE • APARTMAN YÖNETİMİ"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tb_sifre As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tb_ad As System.Windows.Forms.TextBox
    Friend WithEvents tb_soyad As System.Windows.Forms.TextBox
    Friend WithEvents tb_telefon As System.Windows.Forms.TextBox
    Friend WithEvents tb_eposta As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tb_sifre_tekrar As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tb_site_adi As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tb_tc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents guvenlik_sorusu As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cevap As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
End Class
