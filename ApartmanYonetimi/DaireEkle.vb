Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class DaireEkle
    Dim src = Acilis.src
    Public dairesayisi As Integer
    Public yetki As String
    Dim baglanti As New OleDbConnection("Provider=sqloledb;Data Source=" & src & ";Initial Catalog=apartmanyonetimi;Integrated Security=SSPI;")
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            'TC KİMLİK KONTROLÜ
            Dim kisileri_listele As New OleDbCommand("select * from daireler where kisi_tc='" & MaskedTextBox1.Text & "'", baglanti)
            Dim veriokuyucu_kisi As OleDbDataReader
            baglanti.Open()
            veriokuyucu_kisi = kisileri_listele.ExecuteReader
            If veriokuyucu_kisi.HasRows Then
                baglanti.Close()
                MsgBox("Bu TC kimlik numarası başkası tarafından kullanılıyor", MsgBoxStyle.Critical, "UYARI")
            Else
                baglanti.Close()






                If yetki <> "TAM YETKI" Then
                    '
                    ' COMBOBOX3 KISITLI YETKİLİ YÖNETİCİ 
                    '
                    If ComboBox3.SelectedItem = "" Or TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox4.Text = "" Or MaskedTextBox1.Text = "" Or TextBox3.Text = "" Or TextBox6.Text = "" Then
                        MsgBox("Bütün alanları doldurun", MsgBoxStyle.Critical, "UYARI")
                    ElseIf Strings.Len(MaskedTextBox1.Text) <> 11 Then
                        MsgBox("TC Kimlik numarası 11 haneli olmalıdır", MsgBoxStyle.Critical, "UYARI")
                    Else
                        '' ''
                        ' ''If ComboBox1.Text = "" Then
                        ' ''    arsiv_bina_adi = ComboBox1.Text
                        ' ''Else
                        ' ''    arsiv_bina_adi = ComboBox3.Text
                        ' ''End If

                        ' ''arsiv_kat = TextBox1.Text
                        ' ''arsiv_kapi_no = TextBox2.Text



                        '
                        '
                        ' KİŞİ - DAİRE KONTROLÜ VE KAYDI
                        Dim komut1 As New OleDbCommand("select * from daireler where bina_adi= '" & ComboBox3.Text & "' and daire_kat='" & TextBox1.Text & "' and daire_kapi_no='" & TextBox2.Text & "'", baglanti)
                        Dim komut As New OleDbCommand("Insert into daireler(bina_adi, daire_kat, daire_kapi_no, ikamet_eden_kisi, kisi_tc, kisi_tel, kisi_eposta, kisi_notlar, gelis_tarihi, bakiye) values('" & ComboBox3.Text & "', '" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox4.Text & "', '" & MaskedTextBox1.Text & "', '" & TextBox3.Text & "', '" & TextBox6.Text & "', '" & RichTextBox1.Text & "', '" & GunaDateTimePicker1.Text & "', '0')", baglanti)

                        Dim komut10 As New OleDbCommand("select * from kisiler where kisi_tc= '" & MaskedTextBox1.Text & "'", baglanti)
                        Dim komutt As New OleDbCommand("Insert into kisiler(kisi_adsoyad, kisi_tc, kisi_tel, kisi_eposta, kisi_notlar, gelis_tarihi) values('" & TextBox4.Text & "', '" & MaskedTextBox1.Text & "', '" & TextBox3.Text & "', '" & TextBox6.Text & "', '" & RichTextBox1.Text & "', '" & GunaDateTimePicker1.Text & "')", baglanti)


                        Dim veriokuyucu, veriokuyucu2 As OleDbDataReader
                        baglanti.Open()
                        veriokuyucu = komut10.ExecuteReader
                        veriokuyucu2 = komut1.ExecuteReader
                        If veriokuyucu.HasRows Then
                            baglanti.Close()
                            MsgBox("BU TC ZATEN KAYITLI", MsgBoxStyle.Critical, "UYARI")
                        ElseIf veriokuyucu2.HasRows Then
                            baglanti.Close()
                            MsgBox("Bu daire zaten dolu!!!!", MsgBoxStyle.Critical, "UYARI")
                        Else
                            baglanti.Close()
                            baglanti.Open()
                            komut.ExecuteNonQuery()
                            komutt.ExecuteNonQuery()
                            baglanti.Close()
                            MsgBox("DAİRE VE KİŞİ KAYDI BAŞARILI", MsgBoxStyle.OkOnly, "Başarılı")
                            AnaSayfa.mybindgrid()

                            'TODO: This line of code loads data into the 'ApartmanyonetimiDataSet.daireler' table. You can move, or remove it, as needed.
                            AnaSayfa.DairelerTableAdapter.Fill(AnaSayfa.ApartmanyonetimiDataSet5.daireler)
                            Me.BinalarTableAdapter.Fill(Me.ApartmanyonetimiDataSet5.binalar)
                            dairesayisi = AnaSayfa.BunifuCustomDataGrid2.Rows.Count()
                            AnaSayfa.Label13.Text = ("(" & dairesayisi & ")")
                            Acilis.SitelerTableAdapter.Fill(Acilis.ApartmanyonetimiDataSet5.siteler)
                            Me.Close()
                        End If
                    End If
                Else
                    '
                    'COMBOBOX1 TAM YETKİLİ TÜM BLOKLAR:
                    '
                    If ComboBox1.Text = "" Or ComboBox1.SelectedValue = "" Or TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox4.Text = "" Or MaskedTextBox1.Text = "" Or TextBox3.Text = "" Or TextBox6.Text = "" Then
                        MsgBox("Bütün alanları doldurun", MsgBoxStyle.Critical, "UYARI")
                    ElseIf Strings.Len(MaskedTextBox1.Text) <> 11 Then
                        MsgBox("TC Kimlik numarası 11 haneli olmalıdır", MsgBoxStyle.Critical, "UYARI")
                    Else
                        '' ''
                        ' ''If ComboBox1.Text = "" Then
                        ' ''    arsiv_bina_adi = ComboBox3.Text
                        ' ''Else
                        ' ''    arsiv_bina_adi = ComboBox1.Text
                        ' ''End If

                        ' ''arsiv_kat = TextBox1.Text
                        ' ''arsiv_kapi_no = TextBox2.Text


                        Dim komut1 As New OleDbCommand("select * from daireler where bina_adi= '" & ComboBox1.Text & "' and daire_kat='" & TextBox1.Text & "' and daire_kapi_no='" & TextBox2.Text & "'", baglanti)
                        Dim komut As New OleDbCommand("Insert into daireler(bina_adi, daire_kat, daire_kapi_no, ikamet_eden_kisi, kisi_tc, kisi_tel, kisi_eposta, kisi_notlar, gelis_tarihi, bakiye) values('" & ComboBox1.Text & "', '" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox4.Text & "', '" & MaskedTextBox1.Text & "', '" & TextBox3.Text & "', '" & TextBox6.Text & "', '" & RichTextBox1.Text & "' , '" & GunaDateTimePicker1.Text & "', '0')", baglanti)

                        Dim komut10 As New OleDbCommand("select * from kisiler where kisi_tc= '" & MaskedTextBox1.Text & "'", baglanti)
                        Dim komutt As New OleDbCommand("Insert into kisiler(kisi_adsoyad, kisi_tc, kisi_tel, kisi_eposta, kisi_notlar, gelis_tarihi) values('" & TextBox4.Text & "', '" & MaskedTextBox1.Text & "', '" & TextBox3.Text & "', '" & TextBox6.Text & "', '" & RichTextBox1.Text & "', '" & GunaDateTimePicker1.Text & "')", baglanti)


                        Dim veriokuyucu, veriokuyucu2 As OleDbDataReader
                        baglanti.Open()
                        veriokuyucu = komut10.ExecuteReader
                        veriokuyucu2 = komut1.ExecuteReader
                        If veriokuyucu.HasRows Then
                            baglanti.Close()
                            MsgBox("BU TC ZATEN KAYITLI", MsgBoxStyle.Critical, "UYARI")
                        ElseIf veriokuyucu2.HasRows Then
                            baglanti.Close()
                            MsgBox("Bu daire zaten dolu!!!!", MsgBoxStyle.Critical, "UYARI")
                        Else
                            baglanti.Close()
                            baglanti.Open()
                            komut.ExecuteNonQuery()
                            komutt.ExecuteNonQuery()
                            baglanti.Close()
                            MsgBox("DAİRE VE KİŞİ KAYDI BAŞARILI", MsgBoxStyle.OkOnly, "Başarılı")
                            AnaSayfa.mybindgrid()

                            'TODO: This line of code loads data into the 'ApartmanyonetimiDataSet.daireler' table. You can move, or remove it, as needed.
                            AnaSayfa.DairelerTableAdapter.Fill(AnaSayfa.ApartmanyonetimiDataSet5.daireler)
                            Me.BinalarTableAdapter.Fill(Me.ApartmanyonetimiDataSet5.binalar)
                            dairesayisi = AnaSayfa.BunifuCustomDataGrid2.Rows.Count()
                            AnaSayfa.Label13.Text = ("(" & dairesayisi & ")")
                            Acilis.SitelerTableAdapter.Fill(Acilis.ApartmanyonetimiDataSet5.siteler)
                            Me.Close()
                        End If
                    End If
                End If


            End If




        Catch ex As Exception
            MsgBox("Bir hatayla karşılaşıldı. (Try-Catch)", MsgBoxStyle.Critical, "Uyarı")
        End Try

    End Sub

    Private Sub DaireEkle_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Try


            'TODO: This line of code loads data into the 'ApartmanyonetimiDataSet2.binalar' table. You can move, or remove it, as needed.
            Me.BinalarTableAdapter.Fill(Me.ApartmanyonetimiDataSet5.binalar)


            yetki = AnaSayfa.yetki
            If yetki = "TAM YETKI" Then
                Me.ComboBox1.Visible = True
                Me.ComboBox3.Visible = False
                'TODO: This line of code loads data into the 'ApartmanyonetimiDataSet4.binalar' table. You can move, or remove it, as needed.
                Me.BinalarTableAdapter.Fill(Me.ApartmanyonetimiDataSet5.binalar)

            Else
                ComboBox1.Visible = False
                Me.ComboBox3.Visible = True
                Me.ComboBox3.Items.Add(yetki)
            End If

            Me.TopMost = True
        Catch ex As Exception
            MsgBox("Bir hatayla karşılaşıldı. (Try-Catch)", MsgBoxStyle.Critical, "Uyarı")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Try
            KisiEkle.Show()
        Catch ex As Exception
            MsgBox("Bir hatayla karşılaşıldı. (Try-Catch)", MsgBoxStyle.Critical, "Uyarı")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Me.Hide()
        Catch ex As Exception
            MsgBox("Bir hatayla karşılaşıldı. (Try-Catch)", MsgBoxStyle.Critical, "Uyarı")
        End Try
    End Sub

End Class