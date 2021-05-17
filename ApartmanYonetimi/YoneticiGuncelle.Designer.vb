<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class YoneticiGuncelle
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.YetkilerBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ApartmanyonetimiDataSet5 = New ApartmanYonetimi.apartmanyonetimiDataSet5()
        Me.YetkilerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_tc = New System.Windows.Forms.MaskedTextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tb_sifre_tekrar = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tb_eposta = New System.Windows.Forms.TextBox()
        Me.tb_telefon = New System.Windows.Forms.TextBox()
        Me.tb_soyad = New System.Windows.Forms.TextBox()
        Me.tb_ad = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tb_sifre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GunaDateTimePicker1 = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.YetkilerTableAdapter = New ApartmanYonetimi.apartmanyonetimiDataSet5TableAdapters.yetkilerTableAdapter()
        CType(Me.YetkilerBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApartmanyonetimiDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YetkilerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.YetkilerBindingSource1, "yetki", True))
        Me.ComboBox1.DataSource = Me.YetkilerBindingSource
        Me.ComboBox1.DisplayMember = "yetki"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(87, 256)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(130, 21)
        Me.ComboBox1.TabIndex = 68
        Me.ComboBox1.ValueMember = "yetki"
        '
        'YetkilerBindingSource1
        '
        Me.YetkilerBindingSource1.DataMember = "yetkiler"
        Me.YetkilerBindingSource1.DataSource = Me.ApartmanyonetimiDataSet5
        '
        'ApartmanyonetimiDataSet5
        '
        Me.ApartmanyonetimiDataSet5.DataSetName = "apartmanyonetimiDataSet5"
        Me.ApartmanyonetimiDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'YetkilerBindingSource
        '
        Me.YetkilerBindingSource.DataMember = "yetkiler"
        Me.YetkilerBindingSource.DataSource = Me.ApartmanyonetimiDataSet5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 262)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "YETKİ:"
        '
        'tb_tc
        '
        Me.tb_tc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.tb_tc.Location = New System.Drawing.Point(87, 143)
        Me.tb_tc.Mask = "00000000000"
        Me.tb_tc.Name = "tb_tc"
        Me.tb_tc.Size = New System.Drawing.Size(129, 20)
        Me.tb_tc.TabIndex = 65
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(72, 348)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 35)
        Me.Button2.TabIndex = 70
        Me.Button2.Text = "İPTAL"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(167, 348)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 35)
        Me.Button1.TabIndex = 69
        Me.Button1.Text = "GÜNCELLE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tb_sifre_tekrar
        '
        Me.tb_sifre_tekrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.tb_sifre_tekrar.Location = New System.Drawing.Point(87, 201)
        Me.tb_sifre_tekrar.Name = "tb_sifre_tekrar"
        Me.tb_sifre_tekrar.Size = New System.Drawing.Size(130, 20)
        Me.tb_sifre_tekrar.TabIndex = 67
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label11.Location = New System.Drawing.Point(16, 204)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 13)
        Me.Label11.TabIndex = 76
        Me.Label11.Text = "Şifre Tekrar:"
        '
        'tb_eposta
        '
        Me.tb_eposta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.tb_eposta.Location = New System.Drawing.Point(86, 114)
        Me.tb_eposta.Name = "tb_eposta"
        Me.tb_eposta.Size = New System.Drawing.Size(130, 20)
        Me.tb_eposta.TabIndex = 64
        '
        'tb_telefon
        '
        Me.tb_telefon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.tb_telefon.Location = New System.Drawing.Point(86, 85)
        Me.tb_telefon.Name = "tb_telefon"
        Me.tb_telefon.Size = New System.Drawing.Size(130, 20)
        Me.tb_telefon.TabIndex = 63
        '
        'tb_soyad
        '
        Me.tb_soyad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.tb_soyad.Location = New System.Drawing.Point(86, 56)
        Me.tb_soyad.Name = "tb_soyad"
        Me.tb_soyad.Size = New System.Drawing.Size(130, 20)
        Me.tb_soyad.TabIndex = 62
        '
        'tb_ad
        '
        Me.tb_ad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.tb_ad.Location = New System.Drawing.Point(86, 27)
        Me.tb_ad.Name = "tb_ad"
        Me.tb_ad.Size = New System.Drawing.Size(130, 20)
        Me.tb_ad.TabIndex = 61
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label10.Location = New System.Drawing.Point(57, 146)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(24, 13)
        Me.Label10.TabIndex = 74
        Me.Label10.Text = "TC:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label9.Location = New System.Drawing.Point(35, 117)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 13)
        Me.Label9.TabIndex = 72
        Me.Label9.Text = "E-posta:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label8.Location = New System.Drawing.Point(35, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 71
        Me.Label8.Text = "Telefon:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label7.Location = New System.Drawing.Point(41, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 73
        Me.Label7.Text = "Soyad:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label6.Location = New System.Drawing.Point(58, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 13)
        Me.Label6.TabIndex = 78
        Me.Label6.Text = "Ad:"
        '
        'tb_sifre
        '
        Me.tb_sifre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.tb_sifre.Location = New System.Drawing.Point(87, 172)
        Me.tb_sifre.Name = "tb_sifre"
        Me.tb_sifre.Size = New System.Drawing.Size(130, 20)
        Me.tb_sifre.TabIndex = 66
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 75
        Me.Label3.Text = "Giriş Şifresi:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.GunaDateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.tb_ad)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tb_sifre)
        Me.GroupBox1.Controls.Add(Me.tb_tc)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.tb_sifre_tekrar)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.tb_eposta)
        Me.GroupBox1.Controls.Add(Me.tb_soyad)
        Me.GroupBox1.Controls.Add(Me.tb_telefon)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(18, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(237, 302)
        Me.GroupBox1.TabIndex = 80
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "YÖNETİCİ GÜNCELLE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(47, 231)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "Tarih:"
        '
        'GunaDateTimePicker1
        '
        Me.GunaDateTimePicker1.BaseColor = System.Drawing.Color.White
        Me.GunaDateTimePicker1.BorderColor = System.Drawing.Color.Silver
        Me.GunaDateTimePicker1.CustomFormat = Nothing
        Me.GunaDateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.GunaDateTimePicker1.FocusedColor = System.Drawing.Color.ForestGreen
        Me.GunaDateTimePicker1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaDateTimePicker1.ForeColor = System.Drawing.Color.Black
        Me.GunaDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.GunaDateTimePicker1.Location = New System.Drawing.Point(86, 227)
        Me.GunaDateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.GunaDateTimePicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.GunaDateTimePicker1.Name = "GunaDateTimePicker1"
        Me.GunaDateTimePicker1.OnHoverBaseColor = System.Drawing.Color.White
        Me.GunaDateTimePicker1.OnHoverBorderColor = System.Drawing.Color.Green
        Me.GunaDateTimePicker1.OnHoverForeColor = System.Drawing.Color.Green
        Me.GunaDateTimePicker1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaDateTimePicker1.Size = New System.Drawing.Size(130, 21)
        Me.GunaDateTimePicker1.TabIndex = 80
        Me.GunaDateTimePicker1.Text = "1.4.2020"
        Me.GunaDateTimePicker1.Value = New Date(2020, 4, 1, 17, 35, 40, 159)
        '
        'YetkilerTableAdapter
        '
        Me.YetkilerTableAdapter.ClearBeforeFill = True
        '
        'YoneticiGuncelle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(275, 395)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "YoneticiGuncelle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "YÖNETİCİ GÜNCELLE • APARTMAN YÖNETİMİ"
        CType(Me.YetkilerBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApartmanyonetimiDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YetkilerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tb_tc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents tb_sifre_tekrar As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tb_eposta As System.Windows.Forms.TextBox
    Friend WithEvents tb_telefon As System.Windows.Forms.TextBox
    Friend WithEvents tb_soyad As System.Windows.Forms.TextBox
    Friend WithEvents tb_ad As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tb_sifre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ApartmanyonetimiDataSet5 As ApartmanYonetimi.apartmanyonetimiDataSet5
    Friend WithEvents YetkilerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents YetkilerTableAdapter As ApartmanYonetimi.apartmanyonetimiDataSet5TableAdapters.yetkilerTableAdapter
    Friend WithEvents YetkilerBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GunaDateTimePicker1 As Guna.UI.WinForms.GunaDateTimePicker
End Class
