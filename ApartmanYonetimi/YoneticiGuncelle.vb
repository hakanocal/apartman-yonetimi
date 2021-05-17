Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Imports System.Data.DataTable


Public Class YoneticiGuncelle
    Dim src = Acilis.src
    Dim rowIndex = AnaSayfa.rowIndex
    Dim baglanti As New OleDbConnection("Provider=sqloledb;Data Source=" & src & ";Initial Catalog=apartmanyonetimi;Integrated Security=SSPI;")
    Dim cevap As Integer
    Dim sifre As String
    Dim database_tc As New ArrayList
    Dim durum As String
    Dim tamyetkiliyoneticisayisi As Integer = AnaSayfa.tamyetkiliyoneticisayisi


    Private Sub YoneticiGuncelle_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'ApartmanyonetimiDataSet2.yetkiler' table. You can move, or remove it, as needed.
        Me.YetkilerTableAdapter.Fill(Me.ApartmanyonetimiDataSet5.yetkiler)

        tb_ad.Text = AnaSayfa.BunifuCustomDataGrid1.Rows(rowIndex).Cells(0).Value
        tb_soyad.Text = AnaSayfa.BunifuCustomDataGrid1.Rows(rowIndex).Cells(1).Value
        tb_telefon.Text = AnaSayfa.BunifuCustomDataGrid1.Rows(rowIndex).Cells(2).Value
        tb_eposta.Text = AnaSayfa.BunifuCustomDataGrid1.Rows(rowIndex).Cells(3).Value
        tb_tc.Text = AnaSayfa.BunifuCustomDataGrid1.Rows(rowIndex).Cells(4).Value
        GunaDateTimePicker1.Value = AnaSayfa.BunifuCustomDataGrid1.Rows(rowIndex).Cells(6).Value
        ComboBox1.Text = AnaSayfa.BunifuCustomDataGrid1.Rows(rowIndex).Cells(5).Value

        'TÜM YÖNETİCİLERİN BİLGİLERİNİN GETİRİLMESİ VE TC KİMLİK KONTROLÜ
        'GÜNCELLERKEN DİĞER YÖNETİCİLERİN TC KİMLİK NUMARASIYLA UYUŞMAMASINA DİKKAT EDİLECEK
        Dim komut10 As New OleDbCommand("select * from yoneticiler", baglanti)
        Dim veriokuyucu10 As OleDbDataReader
        baglanti.Open()
        veriokuyucu10 = komut10.ExecuteReader
        If veriokuyucu10.HasRows Then
            Do While veriokuyucu10.Read
                database_tc.Add(veriokuyucu10("tc"))
            Loop
            baglanti.Close()
        Else
            baglanti.Close()
            MsgBox("VERİTABANINDA BU YÖNETİCİ BULUNAMADI / BİR HATAYLA KARŞILAŞILDI", MsgBoxStyle.OkOnly, "BAŞARILI")
        End If
        'SEÇİLİ YÖNETİCİNİN BİLGİLERİNİN GETİRİLMESİ
        If Not AnaSayfa.BunifuCustomDataGrid1.Rows(AnaSayfa.rowIndex).IsNewRow Then
            Dim komut1 As New OleDbCommand("select * from yoneticiler where tc= '" & tb_tc.Text & "'", baglanti)
            Dim komut As New OleDbCommand("update yoneticiler set ad= '" & tb_ad.Text & "' and soyad='" & tb_soyad.Text & "' and telefon='" & tb_telefon.Text & "' and eposta='" & tb_eposta.Text & "' and tc='" & tb_tc.Text & "' and yetki='" & ComboBox1.Text & "'", baglanti)
            Dim veriokuyucu As OleDbDataReader
            baglanti.Open()
            veriokuyucu = komut1.ExecuteReader
            If veriokuyucu.HasRows Then
                Do While veriokuyucu.Read
                    sifre = veriokuyucu("sifre")
                Loop

                baglanti.Close()
            Else
                baglanti.Close()
                MsgBox("VERİTABANINDA BU YÖNETİCİ BULUNAMADI / BİR HATAYLA KARŞILAŞILDI", MsgBoxStyle.OkOnly, "BAŞARILI")
            End If
        End If


        tb_sifre.Text = sifre
        tb_sifre_tekrar.Text = sifre


        ' TAM YETKİLİ YÖNETİCİ SAYISININ BELİRLENMESİ
        tamyetkiliyoneticisayisi = 0
        Dim komut3 As New OleDbCommand("select * from yoneticiler", baglanti)
        Dim verioku2 As OleDbDataReader
        baglanti.Open()
        verioku2 = komut3.ExecuteReader
        If verioku2.HasRows Then
            Do While verioku2.Read
                If verioku2("yetki") = "TAM YETKI" Then
                    tamyetkiliyoneticisayisi += 1
                End If
            Loop
            AnaSayfa.Label16.Text = tamyetkiliyoneticisayisi

            baglanti.Close()
        Else
            baglanti.Close()
            MsgBox("Bir hatayla karşılaşıldı", MsgBoxStyle.Critical, "Uyarı")
        End If

        ' TAM YETKİLİ YÖNETİCİ SAYISI=1 İSE YETKİ AYARLAMASINI DEVRE DIŞI BIRAKMA.
        'DEVAM EDİLECEKK..
        If tamyetkiliyoneticisayisi = 1 And AnaSayfa.BunifuCustomDataGrid1.Rows(rowIndex).Cells(5).Value = "TAM YETKI" Then
            ComboBox1.Enabled = False
        Else
            ComboBox1.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Try
            ' TAM YETKİLİ YÖNETİCİ SAYISININ BELİRLENMESİ
            tamyetkiliyoneticisayisi = 0
            Dim komut2 As New OleDbCommand("select * from yoneticiler", baglanti)
            Dim verioku2 As OleDbDataReader
            baglanti.Open()
            verioku2 = komut2.ExecuteReader
            If verioku2.HasRows Then
                Do While verioku2.Read
                    If verioku2("yetki") = "TAM YETKI" Then
                        tamyetkiliyoneticisayisi += 1
                    End If
                Loop
                AnaSayfa.Label16.Text = tamyetkiliyoneticisayisi

                baglanti.Close()
            Else
                baglanti.Close()
                MsgBox("Bir hatayla karşılaşıldı", MsgBoxStyle.Critical, "Uyarı")
            End If

            ' YÖNETİCİ GÜNCELLEME İŞEMLERİ
            For i As Integer = 0 To AnaSayfa.BunifuCustomDataGrid1.Rows.Count - 1
                If tb_tc.Text = AnaSayfa.BunifuCustomDataGrid1.Rows(i).Cells(4).Value Then
                    durum = "var"
                End If
            Next
            If ComboBox1.Text = "" Or ComboBox1.SelectedValue = "" Or tb_ad.Text = "" Or tb_soyad.Text = "" Or tb_telefon.Text = "" Or tb_eposta.Text = "" Or tb_tc.Text = "" Or tb_sifre.Text = "" Or tb_sifre_tekrar.Text = "" Then
                MsgBox("Bütün alanları doldurun", MsgBoxStyle.Critical, "UYARI")
            ElseIf Strings.Len(tb_tc.Text) < 11 Or Strings.Len(tb_tc.Text) > 11 Then
                MsgBox("TC Kimlik numarası 11 haneli olmalıdır", MsgBoxStyle.Critical, "UYARI")
            Else
                If tb_sifre.Text = tb_sifre_tekrar.Text Then
                    If tb_tc.Text = AnaSayfa.BunifuCustomDataGrid1.Rows(rowIndex).Cells(4).Value Then
etiket:
                        If Not AnaSayfa.BunifuCustomDataGrid1.Rows(AnaSayfa.rowIndex).IsNewRow Then
                            Dim komut1 As New OleDbCommand("select * from yoneticiler where tc= '" & AnaSayfa.BunifuCustomDataGrid1.Rows(rowIndex).Cells(4).Value & "'", baglanti)
                            Dim komut As New OleDbCommand("update yoneticiler set ad='" & tb_ad.Text & "', soyad='" & tb_soyad.Text & "', tel='" & tb_telefon.Text & "', eposta='" & tb_eposta.Text & "', tc='" & tb_tc.Text & "', yetki='" & ComboBox1.Text & "', sifre='" & tb_sifre.Text & "', gelis_tarihi='" & GunaDateTimePicker1.Text & "' where tc='" & AnaSayfa.BunifuCustomDataGrid1.Rows(rowIndex).Cells(4).Value & "'", baglanti)
                            Dim veriokuyucu As OleDbDataReader
                            baglanti.Open()
                            veriokuyucu = komut1.ExecuteReader
                            If veriokuyucu.HasRows Then
                                Do While veriokuyucu.Read
                                    cevap = MsgBox(veriokuyucu("ad") + " " + veriokuyucu("soyad") + " adlı yönetici güncellenecek Emin misiniz?", MsgBoxStyle.YesNoCancel, "Uyarı")
                                    sifre = veriokuyucu("sifre")
                                Loop
                                baglanti.Close()
                                If cevap = DialogResult.Yes Then
                                    'AnaSayfa.BunifuCustomDataGrid1.Rows.RemoveAt(AnaSayfa.rowIndex)
                                    'yoneticisayisi = BunifuCustomDataGrid1.Rows.Count()
                                    'Label8.Text = ("(" & yoneticisayisi & ")")
                                    baglanti.Open()
                                    komut.ExecuteNonQuery()
                                    'TODO: This line of code loads data into the 'ApartmanyonetimiDataSet.yoneticiler' table. You can move, or remove it, as needed.
                                    AnaSayfa.YoneticilerTableAdapter.Fill(AnaSayfa.ApartmanyonetimiDataSet5.yoneticiler)
                                    baglanti.Close()
                                    '
                                    '
                                    '
                                    ' TAM YETKİLİ YÖNETİCİ SAYISININ BELİRLENMESİ
                                    tamyetkiliyoneticisayisi = 0
                                    Dim komut3 As New OleDbCommand("select * from yoneticiler", baglanti)
                                    Dim verioku3 As OleDbDataReader
                                    baglanti.Open()
                                    verioku3 = komut3.ExecuteReader
                                    If verioku3.HasRows Then
                                        Do While verioku3.Read
                                            If verioku3("yetki") = "TAM YETKI" Then
                                                tamyetkiliyoneticisayisi += 1
                                            End If
                                        Loop
                                        AnaSayfa.Label16.Text = tamyetkiliyoneticisayisi

                                        baglanti.Close()
                                    Else
                                        baglanti.Close()
                                        MsgBox("Bir hatayla karşılaşıldı", MsgBoxStyle.Critical, "Uyarı")
                                    End If
                                    '
                                    '
                                    '

                                    Me.Close()
                                Else
                                End If
                            Else
                                baglanti.Close()
                                MsgBox("VERİTABANINDA BU YÖNETİCİ BULUNAMADI / BİR HATAYLA KARŞILAŞILDI", MsgBoxStyle.OkOnly, "BAŞARILI")
                            End If
                        Else
                            MsgBox("Bir hatayla karşılaşıldı", MsgBoxStyle.Critical, "UYARI")
                        End If
                    ElseIf durum = "var" Then
                        MsgBox("Bu TC kimlik numarası başka yönetici tarafından kullanılıyor", MsgBoxStyle.Critical, "UYARI")
                        durum = "yok"
                    Else
                        GoTo etiket
                        Me.Close()
                    End If
                Else
                    MsgBox("Şifreler uyuşmuyor", MsgBoxStyle.Critical, "UYARI")
                End If
            End If
        Catch ex As Exception
            MsgBox("Bir hatayla karşılaşıldı. (Try-Catch)", MsgBoxStyle.Critical, "Uyarı")
        End Try

    End Sub
End Class