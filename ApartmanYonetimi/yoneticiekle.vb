Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class yoneticiekle
    Dim src = Acilis.src
    Public yoneticisayisi As Integer
    Dim baglanti As New OleDbConnection("Provider=sqloledb;Data Source=" & src & ";Initial Catalog=apartmanyonetimi;Integrated Security=SSPI;")
    Dim tamyetkiliyoneticisayisi As Integer = Me.tamyetkiliyoneticisayisi

    Private Sub yoneticiekle_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Try

            'TODO: This line of code loads data into the 'ApartmanyonetimiDataSet2.yetkiler' table. You can move, or remove it, as needed.
            Me.YetkilerTableAdapter.Fill(Me.ApartmanyonetimiDataSet5.yetkiler)

            Me.TopMost = True
        Catch ex As Exception
            MsgBox("Bir hatayla karşılaşıldı. (Try-Catch)", MsgBoxStyle.Critical, "Uyarı")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

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




            ' GÜNCELLE BUTONU


            Dim tcno As String

            tcno = tb_tc.Text

            If ComboBox1.Text = "" Or ComboBox1.SelectedValue = "" Or tb_ad.Text = "" Or tb_soyad.Text = "" Or tb_telefon.Text = "" Or tb_eposta.Text = "" Or tb_tc.Text = "" Or tb_sifre.Text = "" Or tb_sifre_tekrar.Text = "" Then
                MsgBox("Bütün alanları doldurun", MsgBoxStyle.Critical, "UYARI")
            ElseIf Strings.Len(tcno) < 11 Or Strings.Len(tcno) > 11 Then
                MsgBox("TC Kimlik numarası 11 haneli olmalıdır", MsgBoxStyle.Critical, "UYARI")
            Else
                If tb_sifre.Text = tb_sifre_tekrar.Text Then
                    Dim komut1 As New OleDbCommand("select * from yoneticiler where tc= '" & tcno & "'", baglanti)
                    Dim komut As New OleDbCommand("Insert into yoneticiler(ad, soyad, tel, eposta, tc, sifre, yetki, gelis_tarihi) values('" & tb_ad.Text & "', '" & tb_soyad.Text & "', '" & tb_telefon.Text & "', '" & tb_eposta.Text & "', '" & tb_tc.Text & "', '" & tb_sifre.Text & "', '" & ComboBox1.SelectedValue & "', '" & GunaDateTimePicker1.Text & "')", baglanti)
                    Dim veriokuyucu As OleDbDataReader
                    baglanti.Open()
                    veriokuyucu = komut1.ExecuteReader
                    If veriokuyucu.HasRows Then
                        baglanti.Close()
                        MsgBox("Bu yönetici zaten kayıtlı", MsgBoxStyle.Critical, "UYARI")
                    Else
                        baglanti.Close()
                        baglanti.Open()
                        komut.ExecuteNonQuery()
                        baglanti.Close()
                        MsgBox("Yönetici kaydı başarılı", MsgBoxStyle.OkOnly, "Başarılı")
                        'tododotodotodo this line of code loads dfata into the yorum satırı
                        Acilis.SitelerTableAdapter.Fill(Acilis.ApartmanyonetimiDataSet5.siteler)
                        'TODO: This line of code loads data into the 'ApartmanyonetimiDataSet.yoneticiler' table. You can move, or remove it, as needed.
                        AnaSayfa.YoneticilerTableAdapter.Fill(AnaSayfa.ApartmanyonetimiDataSet5.yoneticiler)
                        yoneticisayisi = AnaSayfa.BunifuCustomDataGrid1.Rows.Count()
                        AnaSayfa.Label8.Text = ("(" & yoneticisayisi & ")")
                        AnaSayfa.YoneticilerTableAdapter.Fill(AnaSayfa.ApartmanyonetimiDataSet5.yoneticiler)
                        tb_ad.Clear()
                        tb_soyad.Clear()
                        tb_telefon.Clear()
                        tb_eposta.Clear()
                        tb_tc.Clear()
                        tb_sifre.Clear()
                        tb_sifre_tekrar.Clear()
                        '
                        '
                        '
                        ' TAM YETKİLİ YÖNETİCİ SAYISININ BELİRLENMESİ
                        tamyetkiliyoneticisayisi = 0
                        Dim komut4 As New OleDbCommand("select * from yoneticiler", baglanti)
                        Dim verioku3 As OleDbDataReader
                        baglanti.Open()
                        verioku3 = komut4.ExecuteReader
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
                        'gridview  yönetici güncelleme işlemi
                        AnaSayfa.YoneticilerTableAdapter.Fill(AnaSayfa.ApartmanyonetimiDataSet5.yoneticiler)
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
        Catch ex As Exception
            MsgBox("Bir hatayla karşılaşıldı. (Try-Catch)", MsgBoxStyle.Critical, "Uyarı")
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Try
            AnaSayfa.Text = AnaSayfa.GunaButton3.Text + " • APARTMAN YÖNETİMİ"

            Me.Hide()
            AnaSayfa.Panel2_ANASAYFA.Hide()
            AnaSayfa.Panel3_KASA.Hide()
            AnaSayfa.Panel4_BINALAR_DAIRELER.Hide()
            AnaSayfa.Panel5_BORCLANDIR.Hide()
            AnaSayfa.Panel6_PERSONEL.Hide()
            AnaSayfa.Panel7_YONETİCİLER.Hide()
            AnaSayfa.Panel4_BINALAR_DAIRELER.Show()
        Catch ex As Exception
            MsgBox("Bir hatayla karşılaşıldı. (Try-Catch)", MsgBoxStyle.Critical, "Uyarı")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Try
            Me.Hide()
            AnaSayfa.Panel4_BINALAR_DAIRELER.Show()
        Catch ex As Exception
            MsgBox("Bir hatayla karşılaşıldı. (Try-Catch)", MsgBoxStyle.Critical, "Uyarı")
        End Try
    End Sub
End Class


''
'Dim k_adi, sifre, yol, x, sql As String
'        k_adi = TextBox1.Text
'        sifre = TextBox2.Text
'        yol = Server.MapPath("veri.accdb")
'        sql = "Select * from uyeler where k_adi='" & k_adi & "' and sifre= '" & sifre & "'"
'Dim baglanti As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=" & yol)
'Dim verial As New OleDbDataAdapter(sql, baglanti)
'Dim ds As New DataSet
'        verial.Fill(ds)
'Dim kisi_sayisi As Integer
'        kisi_sayisi = ds.Tables(0).Rows.Count
'        If kisi_sayisi = 1 Then
'            x = ds.Tables(0).Rows(0).Item(0) '(accsess)'de: 'Item 0 = k_adi' 'Item 1 = sifre' 'Item 2 = ad'
'            Session("k_adi") = x
'            Response.Redirect("anasayfa.aspx")
'        Else
'            Label3.Text = "Hatalı Girişi"
'        End If
