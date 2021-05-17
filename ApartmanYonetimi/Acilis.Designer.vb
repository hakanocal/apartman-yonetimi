<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Acilis
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
        Me.y_sifre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SitelerBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ApartmanyonetimiDataSet5 = New ApartmanYonetimi.apartmanyonetimiDataSet5()
        Me.SitelerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.y_tc = New System.Windows.Forms.MaskedTextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.SitelerTableAdapter = New ApartmanYonetimi.apartmanyonetimiDataSet5TableAdapters.sitelerTableAdapter()
        CType(Me.SitelerBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApartmanyonetimiDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SitelerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'y_sifre
        '
        Me.y_sifre.Location = New System.Drawing.Point(155, 168)
        Me.y_sifre.Name = "y_sifre"
        Me.y_sifre.Size = New System.Drawing.Size(121, 20)
        Me.y_sifre.TabIndex = 3
        Me.y_sifre.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(114, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Şifre:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(152, 218)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 48)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Giriş yap"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(294, 114)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(137, 48)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "APARTMAN/SİTE EKLE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(80, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Yönetici TC:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.SitelerBindingSource1, "site_adi", True))
        Me.ComboBox1.DataSource = Me.SitelerBindingSource
        Me.ComboBox1.DisplayMember = "site_adi"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(154, 115)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 1
        Me.ComboBox1.ValueMember = "site_adi"
        '
        'SitelerBindingSource1
        '
        Me.SitelerBindingSource1.DataMember = "siteler"
        Me.SitelerBindingSource1.DataSource = Me.ApartmanyonetimiDataSet5
        '
        'ApartmanyonetimiDataSet5
        '
        Me.ApartmanyonetimiDataSet5.DataSetName = "apartmanyonetimiDataSet5"
        Me.ApartmanyonetimiDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SitelerBindingSource
        '
        Me.SitelerBindingSource.DataMember = "siteler"
        Me.SitelerBindingSource.DataSource = Me.ApartmanyonetimiDataSet5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Site/Apartman Seç:"
        '
        'y_tc
        '
        Me.y_tc.ForeColor = System.Drawing.Color.Black
        Me.y_tc.Location = New System.Drawing.Point(154, 142)
        Me.y_tc.Mask = "00000000000"
        Me.y_tc.Name = "y_tc"
        Me.y_tc.Size = New System.Drawing.Size(122, 20)
        Me.y_tc.TabIndex = 2
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(176, 195)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(79, 13)
        Me.LinkLabel1.TabIndex = 14
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Şifremi unuttum"
        '
        'SitelerTableAdapter
        '
        Me.SitelerTableAdapter.ClearBeforeFill = True
        '
        'Acilis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 361)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.y_tc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.y_sifre)
        Me.Name = "Acilis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GİRİŞ YAP • APARTMAN YÖNETİMİ"
        CType(Me.SitelerBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApartmanyonetimiDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SitelerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents y_sifre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents y_tc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents ApartmanyonetimiDataSet5 As ApartmanYonetimi.apartmanyonetimiDataSet5
    Friend WithEvents SitelerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SitelerTableAdapter As ApartmanYonetimi.apartmanyonetimiDataSet5TableAdapters.sitelerTableAdapter
    Friend WithEvents SitelerBindingSource1 As System.Windows.Forms.BindingSource

End Class
