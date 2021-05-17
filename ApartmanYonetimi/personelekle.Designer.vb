<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class personelekle
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.BinalarBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ApartmanyonetimiDataSet51 = New ApartmanYonetimi.apartmanyonetimiDataSet5()
        Me.BinalarBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ApartmanyonetimiDataSet5 = New ApartmanYonetimi.apartmanyonetimiDataSet5()
        Me.BinalarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BinalarTableAdapter = New ApartmanYonetimi.apartmanyonetimiDataSet5TableAdapters.binalarTableAdapter()
        Me.BinalarBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.BinalarBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApartmanyonetimiDataSet51, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BinalarBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApartmanyonetimiDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BinalarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BinalarBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 13)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "PERSONEL BİLGİLERİ"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(85, 48)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(127, 20)
        Me.TextBox1.TabIndex = 62
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(85, 77)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(127, 20)
        Me.TextBox3.TabIndex = 64
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(85, 103)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(127, 20)
        Me.TextBox4.TabIndex = 65
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Ad:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "Telefon:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 69
        Me.Label5.Text = "E-posta:"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(85, 130)
        Me.MaskedTextBox1.Mask = "00000000000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(127, 20)
        Me.MaskedTextBox1.TabIndex = 70
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(56, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 13)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "TC"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(118, 248)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 35)
        Me.Button1.TabIndex = 72
        Me.Button1.Text = "KAYDET"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 248)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 35)
        Me.Button2.TabIndex = 73
        Me.Button2.Text = "İPTAL"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "Branş"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(85, 157)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(127, 20)
        Me.TextBox2.TabIndex = 75
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(40, 187)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 13)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "Blok"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BinalarBindingSource3, "bina_adi", True))
        Me.ComboBox1.DataSource = Me.BinalarBindingSource2
        Me.ComboBox1.DisplayMember = "bina_adi"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(85, 187)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(127, 21)
        Me.ComboBox1.TabIndex = 76
        Me.ComboBox1.ValueMember = "bina_adi"
        '
        'BinalarBindingSource3
        '
        Me.BinalarBindingSource3.DataMember = "binalar"
        Me.BinalarBindingSource3.DataSource = Me.ApartmanyonetimiDataSet51
        '
        'ApartmanyonetimiDataSet51
        '
        Me.ApartmanyonetimiDataSet51.DataSetName = "apartmanyonetimiDataSet5"
        Me.ApartmanyonetimiDataSet51.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BinalarBindingSource2
        '
        Me.BinalarBindingSource2.DataMember = "binalar"
        Me.BinalarBindingSource2.DataSource = Me.ApartmanyonetimiDataSet51
        '
        'ApartmanyonetimiDataSet5
        '
        Me.ApartmanyonetimiDataSet5.DataSetName = "apartmanyonetimiDataSet5"
        Me.ApartmanyonetimiDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BinalarBindingSource
        '
        Me.BinalarBindingSource.DataMember = "binalar"
        Me.BinalarBindingSource.DataSource = Me.ApartmanyonetimiDataSet5
        '
        'BinalarTableAdapter
        '
        Me.BinalarTableAdapter.ClearBeforeFill = True
        '
        'BinalarBindingSource1
        '
        Me.BinalarBindingSource1.DataMember = "binalar"
        Me.BinalarBindingSource1.DataSource = Me.ApartmanyonetimiDataSet5
        '
        'personelekle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(234, 300)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "personelekle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "personelekle"
        CType(Me.BinalarBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApartmanyonetimiDataSet51, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BinalarBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApartmanyonetimiDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BinalarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BinalarBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ApartmanyonetimiDataSet5 As ApartmanYonetimi.apartmanyonetimiDataSet5
    Friend WithEvents BinalarBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BinalarTableAdapter As ApartmanYonetimi.apartmanyonetimiDataSet5TableAdapters.binalarTableAdapter
    Friend WithEvents BinalarBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ApartmanyonetimiDataSet51 As ApartmanYonetimi.apartmanyonetimiDataSet5
    Friend WithEvents BinalarBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents BinalarBindingSource3 As System.Windows.Forms.BindingSource
End Class
