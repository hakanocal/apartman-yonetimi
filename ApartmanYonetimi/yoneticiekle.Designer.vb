<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class yoneticiekle
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tb_sifre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.tb_tc = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.YetkilerBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ApartmanyonetimiDataSet5 = New ApartmanYonetimi.apartmanyonetimiDataSet5()
        Me.YetkilerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.YetkilerTableAdapter = New ApartmanYonetimi.apartmanyonetimiDataSet5TableAdapters.yetkilerTableAdapter()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GunaDateTimePicker1 = New Guna.UI.WinForms.GunaDateTimePicker()
        CType(Me.YetkilerBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApartmanyonetimiDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YetkilerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tb_sifre_tekrar
        '
        Me.tb_sifre_tekrar.Location = New System.Drawing.Point(124, 241)
        Me.tb_sifre_tekrar.Name = "tb_sifre_tekrar"
        Me.tb_sifre_tekrar.Size = New System.Drawing.Size(130, 20)
        Me.tb_sifre_tekrar.TabIndex = 44
        Me.tb_sifre_tekrar.UseSystemPasswordChar = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(49, 244)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 13)
        Me.Label11.TabIndex = 52
        Me.Label11.Text = "Şifre Tekrar:"
        '
        'tb_eposta
        '
        Me.tb_eposta.Location = New System.Drawing.Point(123, 151)
        Me.tb_eposta.Name = "tb_eposta"
        Me.tb_eposta.Size = New System.Drawing.Size(130, 20)
        Me.tb_eposta.TabIndex = 41
        '
        'tb_telefon
        '
        Me.tb_telefon.Location = New System.Drawing.Point(123, 121)
        Me.tb_telefon.Name = "tb_telefon"
        Me.tb_telefon.Size = New System.Drawing.Size(130, 20)
        Me.tb_telefon.TabIndex = 40
        '
        'tb_soyad
        '
        Me.tb_soyad.Location = New System.Drawing.Point(123, 91)
        Me.tb_soyad.Name = "tb_soyad"
        Me.tb_soyad.Size = New System.Drawing.Size(130, 20)
        Me.tb_soyad.TabIndex = 39
        '
        'tb_ad
        '
        Me.tb_ad.Location = New System.Drawing.Point(123, 61)
        Me.tb_ad.Name = "tb_ad"
        Me.tb_ad.Size = New System.Drawing.Size(130, 20)
        Me.tb_ad.TabIndex = 38
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(90, 182)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(24, 13)
        Me.Label10.TabIndex = 50
        Me.Label10.Text = "TC:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(68, 152)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 13)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "E-posta:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(68, 125)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Telefon:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(74, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Soyad:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(91, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 13)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "Ad:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.Location = New System.Drawing.Point(49, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 13)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "YÖNETİCİ BİLGİLERİ"
        '
        'tb_sifre
        '
        Me.tb_sifre.Location = New System.Drawing.Point(124, 211)
        Me.tb_sifre.Name = "tb_sifre"
        Me.tb_sifre.Size = New System.Drawing.Size(130, 20)
        Me.tb_sifre.TabIndex = 43
        Me.tb_sifre.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 215)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Giriş Şifresi:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(196, 353)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 35)
        Me.Button1.TabIndex = 46
        Me.Button1.Text = "KAYDET"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(101, 353)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 35)
        Me.Button2.TabIndex = 47
        Me.Button2.Text = "İPTAL"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'tb_tc
        '
        Me.tb_tc.Location = New System.Drawing.Point(124, 182)
        Me.tb_tc.Mask = "00000000000"
        Me.tb_tc.Name = "tb_tc"
        Me.tb_tc.Size = New System.Drawing.Size(129, 20)
        Me.tb_tc.TabIndex = 42
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(73, 299)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "YETKİ:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.YetkilerBindingSource1, "yetki", True))
        Me.ComboBox1.DataSource = Me.YetkilerBindingSource
        Me.ComboBox1.DisplayMember = "yetki"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(124, 296)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(130, 21)
        Me.ComboBox1.TabIndex = 45
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(103, 320)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Yeni yetkiler için"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(182, 320)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(70, 13)
        Me.LinkLabel1.TabIndex = 48
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "bina ekleyiniz"
        '
        'YetkilerTableAdapter
        '
        Me.YetkilerTableAdapter.ClearBeforeFill = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(80, 272)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Tarih:"
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
        Me.GunaDateTimePicker1.Location = New System.Drawing.Point(124, 267)
        Me.GunaDateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.GunaDateTimePicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.GunaDateTimePicker1.Name = "GunaDateTimePicker1"
        Me.GunaDateTimePicker1.OnHoverBaseColor = System.Drawing.Color.White
        Me.GunaDateTimePicker1.OnHoverBorderColor = System.Drawing.Color.Green
        Me.GunaDateTimePicker1.OnHoverForeColor = System.Drawing.Color.Green
        Me.GunaDateTimePicker1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaDateTimePicker1.Size = New System.Drawing.Size(130, 21)
        Me.GunaDateTimePicker1.TabIndex = 62
        Me.GunaDateTimePicker1.Text = "1.4.2020"
        Me.GunaDateTimePicker1.Value = New Date(2020, 4, 1, 17, 35, 40, 159)
        '
        'yoneticiekle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(296, 400)
        Me.Controls.Add(Me.GunaDateTimePicker1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb_tc)
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
        Me.Name = "yoneticiekle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "YÖNETİCİ EKLE • APARTMAN YÖNETİMİ"
        CType(Me.YetkilerBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApartmanyonetimiDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YetkilerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tb_sifre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents tb_tc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents ApartmanyonetimiDataSet5 As ApartmanYonetimi.apartmanyonetimiDataSet5
    Friend WithEvents YetkilerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents YetkilerTableAdapter As ApartmanYonetimi.apartmanyonetimiDataSet5TableAdapters.yetkilerTableAdapter
    Friend WithEvents YetkilerBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GunaDateTimePicker1 As Guna.UI.WinForms.GunaDateTimePicker
End Class
