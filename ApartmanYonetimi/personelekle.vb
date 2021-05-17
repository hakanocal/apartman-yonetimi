Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class personelekle

    Dim src = Acilis.src
    Dim baglanti As New OleDbConnection("Provider=sqloledb;Data Source=" & src & ";Initial Catalog=apartmanyonetimi;Integrated Security=SSPI;")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pers_tc, pers_adsoyad, pers_tel, pers_eposta, pers_tarih, pers_brans, pers_blok As String
        pers_tc = MaskedTextBox1.Text
        pers_adsoyad = TextBox1.Text
        pers_tel = TextBox3.Text
        pers_eposta = TextBox4.Text
        pers_tarih = Today
        pers_brans = TextBox2.Text
        pers_blok = ComboBox1.SelectedValue
        If TextBox1.Text = "" Or MaskedTextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MsgBox("Tüm Alanları doldurun", MsgBoxStyle.Critical, "UYARI")
        ElseIf Strings.Len(MaskedTextBox1.Text) < 11 Or Strings.Len(MaskedTextBox1.Text) > 11 Then
            MsgBox("TC Kimlik numarası 11 haneli olmalıdır", MsgBoxStyle.Critical, "UYARI")
        Else
            Dim komut1 As New OleDbCommand("select * from personel where tc= '" & pers_tc & "'", baglanti)
            Dim komut As New OleDbCommand("Insert into personel(adsoyad,telefon,eposta,tc, gelis_tarihi,brans,blok) values('" & pers_adsoyad & "', '" & pers_tel & "', '" & pers_eposta & "', '" & pers_tc & "', '" & pers_tarih & "', '" & pers_brans & "', '" & pers_blok & "')", baglanti)
            Dim veriokuyucu As OleDbDataReader
            baglanti.Open()
            veriokuyucu = komut1.ExecuteReader
            If veriokuyucu.HasRows Then
                baglanti.Close()
                MsgBox("Bu personel zaten kayıtlı", MsgBoxStyle.Critical, "UYARI")
            Else
                baglanti.Close()
                baglanti.Open()
                komut.ExecuteNonQuery()
                AnaSayfa.PersonelTableAdapter.Fill(AnaSayfa.ApartmanyonetimiDataSet5.personel)
                MsgBox("Personel kaydı başarılı", MsgBoxStyle.OkOnly, "Başarılı")
                baglanti.Close()
            End If
        End If
    End Sub

    Private Sub personelekle_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'ApartmanyonetimiDataSet5.binalar' table. You can move, or remove it, as needed.
        Me.BinalarTableAdapter.Fill(Me.ApartmanyonetimiDataSet51.binalar)
        Me.TopMost = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class