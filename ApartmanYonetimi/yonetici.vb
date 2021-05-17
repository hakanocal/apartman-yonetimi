Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class yonetici
    Dim src = Acilis.src
    Dim baglanti As New OleDbConnection("Provider=sqloledb;Data Source=" & src & ";Initial Catalog=apartmanyonetimi;Integrated Security=SSPI;")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim tcno, apt_adi, apt_adres As String
            apt_adi = tb_site_adi.Text
            apt_adres = RichTextBox1.Text
            tcno = tb_tc.Text

            If guvenlik_sorusu.Text = "" Or cevap.Text = "" Or ComboBox1.Text = "" Or apt_adi = "" Or apt_adres = "" Or tb_ad.Text = "" Or tb_soyad.Text = "" Or tb_telefon.Text = "" Or tb_eposta.Text = "" Or tb_tc.Text = "" Or tb_sifre.Text = "" Or tb_sifre_tekrar.Text = "" Then
                MsgBox("Bütün alanları doldurun", MsgBoxStyle.Critical, "UYARI")
            ElseIf Strings.Len(tcno) < 11 Or Strings.Len(tcno) > 11 Then
                MsgBox("TC Kimlik numarası 11 haneli olmalıdır", MsgBoxStyle.Critical, "UYARI")
            Else
                If tb_sifre.Text = tb_sifre_tekrar.Text Then
                    Dim komut1 As New OleDbCommand("select * from yoneticiler where tc= '" & tcno & "'", baglanti)
                    Dim komut As New OleDbCommand("Insert into yoneticiler(ad, soyad, tel, eposta, tc, sifre, yetki, guvenlik_sorusu, cevap, gelis_tarihi) values('" & tb_ad.Text & "', '" & tb_soyad.Text & "', '" & tb_telefon.Text & "', '" & tb_eposta.Text & "', '" & tb_tc.Text & "', '" & tb_sifre.Text & "', '" & ComboBox1.Text & "', '" & guvenlik_sorusu.Text & "', '" & cevap.Text & "' , '" & Today & "')", baglanti)
                    Dim komut6 As New OleDbCommand("Insert into yetkiler(yetki) values('" & ComboBox1.Text & "')", baglanti)
                    Dim komut7 As New OleDbCommand("Insert into adres(adres) values('" & RichTextBox1.Text & "')", baglanti)

                    Dim veriokuyucu As OleDbDataReader
                    baglanti.Open()
                    veriokuyucu = komut1.ExecuteReader
                    If veriokuyucu.HasRows Then
                        baglanti.Close()
                        MsgBox("BU YÖNETİCİ ZATEN KAYITLI", MsgBoxStyle.Critical, "UYARI")
                    Else
                        baglanti.Close()
                        baglanti.Open()
                        komut.ExecuteNonQuery()
                        komut6.ExecuteNonQuery()
                        komut7.ExecuteNonQuery()
                        baglanti.Close()
                        MsgBox("YÖNETİCİ VE APARTMAN KAYDI BAŞARILI", MsgBoxStyle.OkOnly, "Başarılı")
                        Acilis.SitelerTableAdapter.Fill(Acilis.ApartmanyonetimiDataSet5.siteler)

                        tb_ad.Clear()
                        tb_soyad.Clear()
                        tb_telefon.Clear()
                        tb_eposta.Clear()
                        tb_tc.Clear()
                        tb_sifre.Clear()
                        tb_sifre_tekrar.Clear()
                        Me.Hide()

                        Dim komut2 As New OleDbCommand("select * from yoneticiler", baglanti)
                        baglanti.Open()
                        veriokuyucu = komut2.ExecuteReader

                        If veriokuyucu.HasRows Then
                            baglanti.Close()
                            Acilis.Button3.Enabled = False
                        Else
                            baglanti.Close()
                            baglanti.Open()
                            komut2.ExecuteNonQuery()
                            baglanti.Close()
                            Acilis.Button3.Enabled = True
                        End If
                        '
                        ' VERİTABANINDA Kİ APARTMANLAR KONTROL EDİLİYOR
                        '
                        Dim komut3 As New OleDbCommand("select * from siteler where site_adi='" & apt_adi & "'", baglanti)
                        Dim komut4 As New OleDbCommand("Insert into siteler(site_adi, site_adresi) values('" & apt_adi & "', '" & apt_adres & "')", baglanti)
                        Dim veriokuyucu2 As OleDbDataReader
                        baglanti.Open()
                        veriokuyucu2 = komut3.ExecuteReader
                        If veriokuyucu2.HasRows Then
                            baglanti.Close()
                            MsgBox("Bu apartman Zaten kayıtlı", MsgBoxStyle.Critical, "UYARI")
                        Else
                            baglanti.Close()
                            baglanti.Open()
                            komut4.ExecuteNonQuery()
                            baglanti.Close()

                            Dim komut5 As New OleDbCommand("select * from yoneticiler", baglanti)
                            baglanti.Open()
                            Dim veriokuyucu3 As OleDbDataReader
                            Dim veriokuyucu4 As OleDbDataReader
                            veriokuyucu4 = komut3.ExecuteReader

                            veriokuyucu3 = komut5.ExecuteReader

                            If veriokuyucu3.HasRows And veriokuyucu4.HasRows Then
                                baglanti.Close()
                                Acilis.Button3.Enabled = False
                            Else
                                baglanti.Close()
                                baglanti.Open()
                                komut5.ExecuteNonQuery()
                                baglanti.Close()
                                Acilis.Button3.Enabled = True
                            End If
                            Acilis.SitelerTableAdapter.Fill(Acilis.ApartmanyonetimiDataSet5.siteler)
                        End If
                        '
                        '
                        '




                        'gridview  yönetici güncelleme işlemi
                        ''''' AnaSayfa.YoneticilerTableAdapter.Fill(AnaSayfa.ApartmanyonetimiDataSet1.yoneticiler)
                    End If
                Else
                    MsgBox("Şifreler uyuşmuyor", MsgBoxStyle.Critical, "UYARI")
                    tb_sifre.Clear()
                    tb_sifre_tekrar.Clear()
                End If
            End If
        Catch ex As Exception
            MsgBox("Bir hatayla karşılaşıldı. (Try-Catch)", MsgBoxStyle.Critical, "Uyarı")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            tb_ad.Clear()
            tb_soyad.Clear()
            tb_telefon.Clear()
            tb_eposta.Clear()
            tb_tc.Clear()
            tb_sifre.Clear()
            tb_sifre_tekrar.Clear()
            Me.Hide()
            Acilis.Show()
            Dim komut2 As New OleDbCommand("select * from yoneticiler", baglanti)
            Dim veriokuyucu As OleDbDataReader
            baglanti.Open()
            veriokuyucu = komut2.ExecuteReader

            If veriokuyucu.HasRows Then
                baglanti.Close()
                Acilis.Button3.Enabled = False
            Else
                baglanti.Close()
                baglanti.Open()
                komut2.ExecuteNonQuery()
                baglanti.Close()
                Acilis.Button3.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("Bir hatayla karşılaşıldı. (Try-Catch)", MsgBoxStyle.Critical, "Uyarı")
        End Try
        
    End Sub

    Private Sub yonetici_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            '"Yönetici ekle penceresinin  ana sayfa penceresinin altında kalması" sorunu çözüldü

        Catch ex As Exception
            MsgBox("Bir hatayla karşılaşıldı. (Try-Catch)", MsgBoxStyle.Critical, "Uyarı")
        End Try
    End Sub
End Class