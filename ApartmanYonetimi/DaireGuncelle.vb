Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Imports System.Data.DataTable

Public Class DaireGuncelle
    Dim src = Acilis.src
    Dim baglanti As New OleDbConnection("Provider=sqloledb;Data Source=" & src & ";Initial Catalog=apartmanyonetimi;Integrated Security=SSPI;")
    Dim rowIndex = AnaSayfa.rowIndex
    Dim durum As String
    Dim cevap As Integer
    Dim sub_bina_adi, sub_daire_kat, sub_daire_kapino As String
    Dim value As String
    Dim yetki As String
    Dim load_bina_adi, load_daire_kat, load_daire_kapi_no, load_ikamet_eden_kisi, load_kisi_tc, load_kisi_tel, load_kisi_eposta, load_kisi_notlar, load_gelis_tarihi As String


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Try






            If yetki <> "TAM YETKI" Then
                '
                '
                ' COMBOBOX3: --- --- --- ---
                '
                '
                '
                ' COMBOBOX3 Daire güncelleme işlemleri
                '
                If Not AnaSayfa.BunifuCustomDataGrid2.Rows(AnaSayfa.rowIndex).IsNewRow Then
                    Dim komut1 As New OleDbCommand("select * from daireler", baglanti)

                    Dim veriokuyucu As OleDbDataReader
                    baglanti.Open()
                    veriokuyucu = komut1.ExecuteReader
                    If veriokuyucu.HasRows Then
                        Do While veriokuyucu.Read
                            sub_bina_adi = veriokuyucu("bina_adi")
                            sub_daire_kat = veriokuyucu("daire_kat")
                            sub_daire_kapino = veriokuyucu("daire_kapi_no")
                            If sub_bina_adi = ComboBox3.SelectedItem And sub_daire_kat = TextBox1.Text And sub_daire_kapino = TextBox2.Text Then
                                durum = "var"
                            Else
                            End If
                        Loop
                        baglanti.Close()
                    Else
                        baglanti.Close()
                        MsgBox("VERİTABANINDA BU YÖNETİCİ BULUNAMADI / BİR HATAYLA KARŞILAŞILDI", MsgBoxStyle.OkOnly, "BAŞARILI")
                    End If
                Else
                    MsgBox("Bir hatayla karşılaşıldı", MsgBoxStyle.Critical, "UYARI")
                End If

                '
                ' COMBOBOX3 VERİTABANI İLE TEXTBOX VERİLERİNİN KARŞILAŞTIRILMASI
                If ComboBox3.SelectedItem = "" Or TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox4.Text = "" Or MaskedTextBox1.Text = "" Or TextBox3.Text = "" Or TextBox6.Text = "" Then
                    MsgBox("Bütün alanları doldurun", MsgBoxStyle.Critical, "UYARI")
                Else
                    ' bu combobox3 combobox.selectedtext olarak değiştirilebilir
                    If ComboBox3.Text = AnaSayfa.BunifuCustomDataGrid2.Rows(rowIndex).Cells(0).Value And TextBox1.Text = AnaSayfa.BunifuCustomDataGrid2.Rows(rowIndex).Cells(1).Value And TextBox2.Text = AnaSayfa.BunifuCustomDataGrid2.Rows(rowIndex).Cells(2).Value Then
                        If Not AnaSayfa.BunifuCustomDataGrid2.Rows(AnaSayfa.rowIndex).IsNewRow Then
                            Dim komut1 As New OleDbCommand("select * from daireler where bina_adi= '" & ComboBox3.Text & "' and daire_kat='" & TextBox1.Text & "' and daire_kapi_no='" & TextBox2.Text & "'", baglanti)
                            Dim eski_daire_ekle As New OleDbCommand("Insert into eski_daireler(bina_adi, daire_kat, daire_kapi_no, ikamet_eden_kisi, kisi_tc, kisi_tel, kisi_eposta, kisi_notlar, gelis_tarihi, cikis_tarihi) values('" & load_bina_adi & "', '" & load_daire_kat & "','" & load_daire_kapi_no & "','" & load_ikamet_eden_kisi & "','" & load_kisi_tc & "','" & load_kisi_tel & "','" & load_kisi_eposta & "','" & load_kisi_notlar & "', '" & load_gelis_tarihi & "', '" & Today & "')", baglanti)
                            Dim komut As New OleDbCommand("update daireler set bina_adi='" & ComboBox3.Text & "', daire_kat='" & TextBox1.Text & "', daire_kapi_no='" & TextBox2.Text & "', ikamet_eden_kisi='" & TextBox4.Text & "', kisi_tc='" & MaskedTextBox1.Text & "', kisi_tel='" & TextBox3.Text & "', kisi_eposta='" & TextBox6.Text & "', kisi_notlar='" & RichTextBox1.Text & "', gelis_tarihi='" & GunaDateTimePicker1.Text & "' WHERE bina_adi='" & AnaSayfa.BunifuCustomDataGrid2.Rows(rowIndex).Cells(0).Value & "' and daire_kat='" & AnaSayfa.BunifuCustomDataGrid2.Rows(rowIndex).Cells(1).Value & "' and daire_kapi_no='" & AnaSayfa.BunifuCustomDataGrid2.Rows(rowIndex).Cells(2).Value & "' and ikamet_eden_kisi='" & AnaSayfa.BunifuCustomDataGrid2.Rows(rowIndex).Cells(3).Value & "'", baglanti)
                            Dim update_kisiler As New OleDbCommand("update kisiler set kisi_adsoyad='" & TextBox4.Text & "', kisi_tc='" & MaskedTextBox1.Text & "', kisi_tel='" & TextBox3.Text & "', kisi_eposta='" & TextBox6.Text & "', kisi_notlar='" & RichTextBox1.Text & "', gelis_tarihi='" & GunaDateTimePicker1.Text & "' WHERE kisi_tc='" & load_kisi_tc & "'", baglanti)


                            Dim veriokuyucu As OleDbDataReader
                            baglanti.Open()
                            veriokuyucu = komut1.ExecuteReader
                            If veriokuyucu.HasRows Then
                                Do While veriokuyucu.Read
                                    cevap = MsgBox(veriokuyucu("bina_adi") + " binası, " + veriokuyucu("daire_kat") + ".kat, " + veriokuyucu("daire_kapi_no") + " numaralı daire güncellenecek Emin misiniz?", MsgBoxStyle.YesNoCancel, "Uyarı")
                                Loop
                                baglanti.Close()
                                If cevap = DialogResult.Yes Then

                                    If ComboBox3.Text = load_bina_adi And TextBox1.Text = load_daire_kat And TextBox2.Text = load_daire_kapi_no Then

                                        'AnaSayfa.BunifuCustomDataGrid1.Rows.RemoveAt(AnaSayfa.rowIndex)
                                        DaireEkle.dairesayisi = AnaSayfa.BunifuCustomDataGrid2.Rows.Count()
                                        AnaSayfa.Label13.Text = ("(" & DaireEkle.dairesayisi & ")")
                                        baglanti.Open()
                                        komut.ExecuteNonQuery()
                                        update_kisiler.ExecuteNonQuery()
                                        'TODO: This line of code loads data into the 'ApartmanyonetimiDataSet.yoneticiler' table. You can move, or remove it, as needed.
                                        AnaSayfa.DairelerTableAdapter.Fill(AnaSayfa.ApartmanyonetimiDataSet5.daireler)
                                        AnaSayfa.mybindgrid()

                                        baglanti.Close()
                                        Me.Close()
                                    Else

                                        DaireEkle.dairesayisi = AnaSayfa.BunifuCustomDataGrid2.Rows.Count()
                                        AnaSayfa.Label13.Text = ("(" & DaireEkle.dairesayisi & ")")
                                        baglanti.Open()
                                        eski_daire_ekle.ExecuteNonQuery()
                                        komut.ExecuteNonQuery()
                                        update_kisiler.ExecuteNonQuery()
                                        'TODO: This line of code loads data into the 'ApartmanyonetimiDataSet5.eski_daireler' table. You can move, or remove it, as needed.
                                        AnaSayfa.Eski_dairelerTableAdapter.Fill(AnaSayfa.ApartmanyonetimiDataSet5.eski_daireler)
                                        'TODO: This line of code loads data into the 'ApartmanyonetimiDataSet.yoneticiler' table. You can move, or remove it, as needed.
                                        AnaSayfa.DairelerTableAdapter.Fill(AnaSayfa.ApartmanyonetimiDataSet5.daireler)
                                        AnaSayfa.mybindgrid()

                                        baglanti.Close()
                                        MsgBox("TAŞINMA İŞLEMİ BAŞARILI", MsgBoxStyle.OkOnly, "BAŞARILI")

                                        Me.Close()
                                    End If

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
                        MsgBox("Zaten böyle bir daire mevcut. Lütfen girdiğiniz bilgileri kontrol ediniz.", MsgBoxStyle.Critical, "UYARI")
                        durum = "yok"
                        Me.Close()
                    Else
                        If Not AnaSayfa.BunifuCustomDataGrid2.Rows(AnaSayfa.rowIndex).IsNewRow Then
                            Dim komut20 As New OleDbCommand("select * from daireler where bina_adi='" & AnaSayfa.BunifuCustomDataGrid2.Rows(rowIndex).Cells(0).Value & "' and daire_kat='" & AnaSayfa.BunifuCustomDataGrid2.Rows(rowIndex).Cells(1).Value & "' and daire_kapi_no='" & AnaSayfa.BunifuCustomDataGrid2.Rows(rowIndex).Cells(2).Value & "'", baglanti)
                            Dim komut25 As New OleDbCommand("update daireler set bina_adi='" & ComboBox3.Text & "', daire_kat='" & TextBox1.Text & "', daire_kapi_no='" & TextBox2.Text & "', ikamet_eden_kisi='" & TextBox4.Text & "' WHERE bina_adi='" & AnaSayfa.BunifuCustomDataGrid2.Rows(rowIndex).Cells(0).Value & "' and daire_kat='" & AnaSayfa.BunifuCustomDataGrid2.Rows(rowIndex).Cells(1).Value & "' and daire_kapi_no='" & AnaSayfa.BunifuCustomDataGrid2.Rows(rowIndex).Cells(2).Value & "' and ikamet_eden_kisi='" & AnaSayfa.BunifuCustomDataGrid2.Rows(rowIndex).Cells(3).Value & "'", baglanti)
                            Dim eski_daire_ekle As New OleDbCommand("Insert into eski_daireler(bina_adi, daire_kat, daire_kapi_no, ikamet_eden_kisi, kisi_tc, kisi_tel, kisi_eposta, kisi_notlar, gelis_tarihi, cikis_tarihi) values('" & load_bina_adi & "', '" & load_daire_kat & "','" & load_daire_kapi_no & "','" & load_ikamet_eden_kisi & "','" & load_kisi_tc & "','" & load_kisi_tel & "','" & load_kisi_eposta & "','" & load_kisi_notlar & "', '" & load_gelis_tarihi & "', '" & Today & "')", baglanti)
                            Dim komut As New OleDbCommand("update daireler set bina_adi='" & ComboBox3.Text & "', daire_kat='" & TextBox1.Text & "', daire_kapi_no='" & TextBox2.Text & "', ikamet_eden_kisi='" & TextBox4.Text & "', kisi_tc='" & MaskedTextBox1.Text & "', kisi_tel='" & TextBox3.Text & "', kisi_eposta='" & TextBox6.Text & "', kisi_notlar='" & RichTextBox1.Text & "', gelis_tarihi='" & GunaDateTimePicker1.Text & "' WHERE bina_adi='" & AnaSayfa.BunifuCustomDataGrid2.Rows(rowIndex).Cells(0).Value & "' and daire_kat='" & AnaSayfa.BunifuCustomDataGrid2.Rows(rowIndex).Cells(1).Value & "' and daire_kapi_no='" & AnaSayfa.BunifuCustomDataGrid2.Rows(rowIndex).Cells(2).Value & "' and ikamet_eden_kisi='" & AnaSayfa.BunifuCustomDataGrid2.Rows(rowIndex).Cells(3).Value & "'", baglanti)
                            Dim update_kisiler As New OleDbCommand("update kisiler set kisi_adsoyad='" & TextBox4.Text & "', kisi_tc='" & MaskedTextBox1.Text & "', kisi_tel='" & TextBox3.Text & "', kisi_eposta='" & TextBox6.Text & "', kisi_notlar='" & RichTextBox1.Text & "', gelis_tarihi='" & GunaDateTimePicker1.Text & "' WHERE kisi_tc='" & load_kisi_tc & "'", baglanti)

                            Dim veriokuyucu23 As OleDbDataReader
                            baglanti.Open()
                            veriokuyucu23 = komut20.ExecuteReader
                            If veriokuyucu23.HasRows Then
                                Do While veriokuyucu23.Read
                                    cevap = MsgBox(veriokuyucu23("bina_adi") + " binası, " + veriokuyucu23("daire_kat") + ".kat, " + veriokuyucu23("daire_kapi_no") + " numaralı daire güncellenecek Emin misiniz?", MsgBoxStyle.YesNoCancel, "Uyarı")
                                Loop
                                baglanti.Close()
                                If cevap = DialogResult.Yes Then

                                    If ComboBox3.Text = load_bina_adi And TextBox1.Text = load_daire_kat And TextBox2.Text = load_daire_kapi_no Then

                                        'AnaSayfa.BunifuCustomDataGrid1.Rows.RemoveAt(AnaSayfa.rowIndex)
                                        DaireEkle.dairesayisi = AnaSayfa.BunifuCustomDataGrid2.Rows.Count()
                                        AnaSayfa.Label13.Text = ("(" & DaireEkle.dairesayisi & ")")
                                        baglanti.Open()
                                        komut25.ExecuteNonQuery()
                                        update_kisiler.ExecuteNonQuery()
                                        'TODO: This line of code loads data into the 'ApartmanyonetimiDataSet.yoneticiler' table. You can move, or remove it, as needed.
                                        AnaSayfa.DairelerTableAdapter.Fill(AnaSayfa.ApartmanyonetimiDataSet5.daireler)
                                        AnaSayfa.mybindgrid()

                                        baglanti.Close()

                                        Me.Close()
                                    Else

                                        DaireEkle.dairesayisi = AnaSayfa.BunifuCustomDataGrid2.Rows.Count()
                                        AnaSayfa.Label13.Text = ("(" & DaireEkle.dairesayisi & ")")
                                        baglanti.Open()
                                        eski_daire_ekle.ExecuteNonQuery()
                                        komut.ExecuteNonQuery()
                                        update_kisiler.ExecuteNonQuery()
                                        'TODO: This line of code loads data into the 'ApartmanyonetimiDataSet5.eski_daireler' table. You can move, or remove it, as needed.
                                        AnaSayfa.Eski_dairelerTableAdapter.Fill(AnaSayfa.ApartmanyonetimiDataSet5.eski_daireler)
                                        'TODO: This line of code loads data into the 'ApartmanyonetimiDataSet.yoneticiler' table. You can move, or remove it, as needed.
                                        AnaSayfa.DairelerTableAdapter.Fill(AnaSayfa.ApartmanyonetimiDataSet5.daireler)
                                        AnaSayfa.mybindgrid()

                                        baglanti.Close()
                                        MsgBox("TAŞINMA İŞLEMİ BAŞARILI", MsgBoxStyle.OkOnly, "BAŞARILI")

                                        Me.Close()
                                    End If

                                Else
                                End If
                            Else
                                baglanti.Close()
                                MsgBox("VERİTABANINDA BU YÖNETİCİ BULUNAMADI / BİR HATAYLA KARŞILAŞILDI!!", MsgBoxStyle.OkOnly, "BAŞARILI")
                            End If
                        Else
                            MsgBox("Bir hatayla karşılaşıldı", MsgBoxStyle.Critical, "UYARI")
                        End If
                    End If
                End If
            Else
                '
                '
                ' COMBOBOX1: --- --- --- ---
                '
                '
                ' COMBOBOX1 Daire güncelleme işlemleri
                '
                If Not AnaSayfa.BunifuCustomDataGrid2.Rows(AnaSayfa.rowIndex).IsNewRow Then
                    Dim komut1 As New OleDbCommand("select * from daireler", baglanti)
                    Dim veriokuyucu As OleDbDataReader
                    baglanti.Open()
                    veriokuyucu = komut1.ExecuteReader
                    If veriokuyucu.HasRows Then
                        Do While veriokuyucu.Read
                            sub_bina_adi = veriokuyucu("bina_adi")
                            sub_daire_kat = veriokuyucu("daire_kat")
                            sub_daire_kapino = veriokuyucu("daire_kapi_no")
                            If sub_bina_adi = ComboBox1.SelectedValue And sub_daire_kat = TextBox1.Text And sub_daire_kapino = TextBox2.Text Then
                                durum = "var"
                            Else
                            End If
                        Loop
                        baglanti.Close()
                    Else
                        baglanti.Close()
                        MsgBox("VERİTABANINDA BU YÖNETİCİ BULUNAMADI / BİR HATAYLA KARŞILAŞILDI", MsgBoxStyle.OkOnly, "BAŞARILI")
                    End If
                Else
                    MsgBox("Bir hatayla karşılaşıldı", MsgBoxStyle.Critical, "UYARI")
                End If

                '
                ' COMBOBOX1 VERİTABANI İLE TEXTBOX VERİLERİNİN KARŞILAŞTIRILMASI
                If ComboBox1.Text = "" Or ComboBox1.SelectedValue = "" Or TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox4.Text = "" Or MaskedTextBox1.Text = "" Or TextBox3.Text = "" Or TextBox6.Text = "" Then
                    MsgBox("Bütün alanları doldurun", MsgBoxStyle.Critical, "UYARI")
                Else
                    If ComboBox1.Text = AnaSayfa.BunifuCustomDataGrid2.Rows(rowIndex).Cells(0).Value And TextBox1.Text = AnaSayfa.BunifuCustomDataGrid2.Rows(rowIndex).Cells(1).Value And TextBox2.Text = AnaSayfa.BunifuCustomDataGrid2.Rows(rowIndex).Cells(2).Value Then
                        If Not AnaSayfa.BunifuCustomDataGrid2.Rows(AnaSayfa.rowIndex).IsNewRow Then
                            Dim komut1 As New OleDbCommand("select * from daireler where bina_adi= '" & ComboBox1.Text & "' and daire_kat='" & TextBox1.Text & "' and daire_kapi_no='" & TextBox2.Text & "'", baglanti)
                            Dim eski_daire_ekle As New OleDbCommand("Insert into eski_daireler(bina_adi, daire_kat, daire_kapi_no, ikamet_eden_kisi, kisi_tc, kisi_tel, kisi_eposta, kisi_notlar, gelis_tarihi, cikis_tarihi) values('" & load_bina_adi & "', '" & load_daire_kat & "','" & load_daire_kapi_no & "','" & load_ikamet_eden_kisi & "','" & load_kisi_tc & "','" & load_kisi_tel & "','" & load_kisi_eposta & "','" & load_kisi_notlar & "', '" & load_gelis_tarihi & "', '" & Today & "')", baglanti)
                            Dim komut As New OleDbCommand("update daireler set bina_adi='" & ComboBox1.Text & "', daire_kat='" & TextBox1.Text & "', daire_kapi_no='" & TextBox2.Text & "', ikamet_eden_kisi='" & TextBox4.Text & "', kisi_tc='" & MaskedTextBox1.Text & "', kisi_tel='" & TextBox3.Text & "', kisi_eposta='" & TextBox6.Text & "', kisi_notlar='" & RichTextBox1.Text & "', gelis_tarihi='" & GunaDateTimePicker1.Text & "' WHERE bina_adi='" & AnaSayfa.BunifuCustomDataGrid2.Rows(rowIndex).Cells(0).Value & "' and daire_kat='" & AnaSayfa.BunifuCustomDataGrid2.Rows(rowIndex).Cells(1).Value & "' and daire_kapi_no='" & AnaSayfa.BunifuCustomDataGrid2.Rows(rowIndex).Cells(2).Value & "' and ikamet_eden_kisi='" & AnaSayfa.BunifuCustomDataGrid2.Rows(rowIndex).Cells(3).Value & "'", baglanti)
                            Dim update_kisiler As New OleDbCommand("update kisiler set kisi_adsoyad='" & TextBox4.Text & "', kisi_tc='" & MaskedTextBox1.Text & "', kisi_tel='" & TextBox3.Text & "', kisi_eposta='" & TextBox6.Text & "', kisi_notlar='" & RichTextBox1.Text & "', gelis_tarihi='" & GunaDateTimePicker1.Text & "' WHERE kisi_tc='" & load_kisi_tc & "'", baglanti)

                            Dim veriokuyucu As OleDbDataReader
                            baglanti.Open()
                            veriokuyucu = komut1.ExecuteReader
                            If veriokuyucu.HasRows Then
                                Do While veriokuyucu.Read
                                    cevap = MsgBox(veriokuyucu("bina_adi") + " binası, " + veriokuyucu("daire_kat") + ".kat, " + veriokuyucu("daire_kapi_no") + " numaralı daire güncellenecek Emin misiniz?", MsgBoxStyle.YesNoCancel, "Uyarı")
                                Loop
                                baglanti.Close()
                                If cevap = DialogResult.Yes Then

                                    If ComboBox1.Text = load_bina_adi And TextBox1.Text = load_daire_kat And TextBox2.Text = load_daire_kapi_no Then

                                        'AnaSayfa.BunifuCustomDataGrid1.Rows.RemoveAt(AnaSayfa.rowIndex)
                                        DaireEkle.dairesayisi = AnaSayfa.BunifuCustomDataGrid2.Rows.Count()
                                        AnaSayfa.Label13.Text = ("(" & DaireEkle.dairesayisi & ")")
                                        baglanti.Open()
                                        update_kisiler.ExecuteNonQuery()
                                        komut.ExecuteNonQuery()
                                        'TODO: This line of code loads data into the 'ApartmanyonetimiDataSet.yoneticiler' table. You can move, or remove it, as needed.
                                        AnaSayfa.DairelerTableAdapter.Fill(AnaSayfa.ApartmanyonetimiDataSet5.daireler)
                                        AnaSayfa.mybindgrid()

                                        baglanti.Close()
                                        Me.Close()
                                    Else

                                        'AnaSayfa.BunifuCustomDataGrid1.Rows.RemoveAt(AnaSayfa.rowIndex)
                                        DaireEkle.dairesayisi = AnaSayfa.BunifuCustomDataGrid2.Rows.Count()
                                        AnaSayfa.Label13.Text = ("(" & DaireEkle.dairesayisi & ")")
                                        baglanti.Open()
                                        eski_daire_ekle.ExecuteNonQuery()
                                        komut.ExecuteNonQuery()
                                        update_kisiler.ExecuteNonQuery()
                                        'TODO: This line of code loads data into the 'ApartmanyonetimiDataSet.yoneticiler' table. You can move, or remove it, as needed.
                                        AnaSayfa.DairelerTableAdapter.Fill(AnaSayfa.ApartmanyonetimiDataSet5.daireler)
                                        'TODO: This line of code loads data into the 'ApartmanyonetimiDataSet5.eski_daireler' table. You can move, or remove it, as needed.
                                        AnaSayfa.Eski_dairelerTableAdapter.Fill(AnaSayfa.ApartmanyonetimiDataSet5.eski_daireler)
                                        AnaSayfa.mybindgrid()

                                        baglanti.Close()
                                        MsgBox("TAŞINMA İŞLEMİ BAŞARILI", MsgBoxStyle.OkOnly, "BAŞARILI")


                                        Me.Close()
                                    End If
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
                        MsgBox("Zaten böyle bir daire mevcut. Lütfen girdiğiniz bilgileri kontrol ediniz.", MsgBoxStyle.Critical, "UYARI")
                        durum = "yok"
                        Me.Close()
                    Else
                        If Not AnaSayfa.BunifuCustomDataGrid2.Rows(AnaSayfa.rowIndex).IsNewRow Then
                            Dim komut20 As New OleDbCommand("select * from daireler where bina_adi='" & AnaSayfa.BunifuCustomDataGrid2.Rows(rowIndex).Cells(0).Value & "' and daire_kat='" & AnaSayfa.BunifuCustomDataGrid2.Rows(rowIndex).Cells(1).Value & "' and daire_kapi_no='" & AnaSayfa.BunifuCustomDataGrid2.Rows(rowIndex).Cells(2).Value & "'", baglanti)
                            Dim komut25 As New OleDbCommand("update daireler set bina_adi='" & ComboBox1.Text & "', daire_kat='" & TextBox1.Text & "', daire_kapi_no='" & TextBox2.Text & "', ikamet_eden_kisi='" & TextBox4.Text & "' WHERE bina_adi='" & AnaSayfa.BunifuCustomDataGrid2.Rows(rowIndex).Cells(0).Value & "' and daire_kat='" & AnaSayfa.BunifuCustomDataGrid2.Rows(rowIndex).Cells(1).Value & "' and daire_kapi_no='" & AnaSayfa.BunifuCustomDataGrid2.Rows(rowIndex).Cells(2).Value & "' and ikamet_eden_kisi='" & AnaSayfa.BunifuCustomDataGrid2.Rows(rowIndex).Cells(3).Value & "'", baglanti)
                            Dim eski_daire_ekle As New OleDbCommand("Insert into eski_daireler(bina_adi, daire_kat, daire_kapi_no, ikamet_eden_kisi, kisi_tc, kisi_tel, kisi_eposta, kisi_notlar, gelis_tarihi, cikis_tarihi) values('" & load_bina_adi & "', '" & load_daire_kat & "','" & load_daire_kapi_no & "','" & load_ikamet_eden_kisi & "','" & load_kisi_tc & "','" & load_kisi_tel & "','" & load_kisi_eposta & "','" & load_kisi_notlar & "', '" & load_gelis_tarihi & "', '" & Today & "')", baglanti)
                            Dim komut As New OleDbCommand("update daireler set bina_adi='" & ComboBox1.Text & "', daire_kat='" & TextBox1.Text & "', daire_kapi_no='" & TextBox2.Text & "', ikamet_eden_kisi='" & TextBox4.Text & "', kisi_tc='" & MaskedTextBox1.Text & "', kisi_tel='" & TextBox3.Text & "', kisi_eposta='" & TextBox6.Text & "', kisi_notlar='" & RichTextBox1.Text & "', gelis_tarihi='" & GunaDateTimePicker1.Text & "' WHERE bina_adi='" & AnaSayfa.BunifuCustomDataGrid2.Rows(rowIndex).Cells(0).Value & "' and daire_kat='" & AnaSayfa.BunifuCustomDataGrid2.Rows(rowIndex).Cells(1).Value & "' and daire_kapi_no='" & AnaSayfa.BunifuCustomDataGrid2.Rows(rowIndex).Cells(2).Value & "' and ikamet_eden_kisi='" & AnaSayfa.BunifuCustomDataGrid2.Rows(rowIndex).Cells(3).Value & "'", baglanti)
                            Dim update_kisiler As New OleDbCommand("update kisiler set kisi_adsoyad='" & TextBox4.Text & "', kisi_tc='" & MaskedTextBox1.Text & "', kisi_tel='" & TextBox3.Text & "', kisi_eposta='" & TextBox6.Text & "', kisi_notlar='" & RichTextBox1.Text & "', gelis_tarihi='" & GunaDateTimePicker1.Text & "' WHERE kisi_tc='" & load_kisi_tc & "'", baglanti)

                            Dim veriokuyucu23 As OleDbDataReader
                            baglanti.Open()
                            veriokuyucu23 = komut20.ExecuteReader
                            If veriokuyucu23.HasRows Then
                                Do While veriokuyucu23.Read
                                    cevap = MsgBox(veriokuyucu23("bina_adi") + " binası, " + veriokuyucu23("daire_kat") + ".kat, " + veriokuyucu23("daire_kapi_no") + " numaralı daire güncellenecek Emin misiniz?", MsgBoxStyle.YesNoCancel, "Uyarı")
                                Loop
                                baglanti.Close()
                                If cevap = DialogResult.Yes Then

                                    If ComboBox1.Text = load_bina_adi And TextBox1.Text = load_daire_kat And TextBox2.Text = load_daire_kapi_no Then

                                        'AnaSayfa.BunifuCustomDataGrid1.Rows.RemoveAt(AnaSayfa.rowIndex)
                                        DaireEkle.dairesayisi = AnaSayfa.BunifuCustomDataGrid2.Rows.Count()
                                        AnaSayfa.Label13.Text = ("(" & DaireEkle.dairesayisi & ")")
                                        baglanti.Open()
                                        komut25.ExecuteNonQuery()
                                        update_kisiler.ExecuteNonQuery()
                                        'TODO: This line of code loads data into the 'ApartmanyonetimiDataSet.yoneticiler' table. You can move, or remove it, as needed.
                                        AnaSayfa.DairelerTableAdapter.Fill(AnaSayfa.ApartmanyonetimiDataSet5.daireler)
                                        AnaSayfa.mybindgrid()

                                        baglanti.Close()
                                        Me.Close()
                                    Else

                                        'AnaSayfa.BunifuCustomDataGrid1.Rows.RemoveAt(AnaSayfa.rowIndex)
                                        DaireEkle.dairesayisi = AnaSayfa.BunifuCustomDataGrid2.Rows.Count()
                                        AnaSayfa.Label13.Text = ("(" & DaireEkle.dairesayisi & ")")
                                        baglanti.Open()
                                        komut.ExecuteNonQuery()
                                        update_kisiler.ExecuteNonQuery()

                                        eski_daire_ekle.ExecuteNonQuery()
                                        'TODO: This line of code loads data into the 'ApartmanyonetimiDataSet.yoneticiler' table. You can move, or remove it, as needed.
                                        AnaSayfa.DairelerTableAdapter.Fill(AnaSayfa.ApartmanyonetimiDataSet5.daireler)
                                        'TODO: This line of code loads data into the 'ApartmanyonetimiDataSet5.eski_daireler' table. You can move, or remove it, as needed.
                                        AnaSayfa.Eski_dairelerTableAdapter.Fill(AnaSayfa.ApartmanyonetimiDataSet5.eski_daireler)
                                        AnaSayfa.mybindgrid()

                                        baglanti.Close()
                                        MsgBox("TAŞINMA İŞLEMİ BAŞARILI", MsgBoxStyle.OkOnly, "BAŞARILI")
                                        Me.Close()
                                    End If


                                Else
                                End If
                            Else
                                baglanti.Close()
                                MsgBox("VERİTABANINDA BU YÖNETİCİ BULUNAMADI / BİR HATAYLA KARŞILAŞILDI!!", MsgBoxStyle.OkOnly, "BAŞARILI")
                            End If
                        Else
                            MsgBox("Bir hatayla karşılaşıldı", MsgBoxStyle.Critical, "UYARI")
                        End If
                    End If
                End If
            End If






        Catch ex As Exception
            MsgBox("Bir hatayla karşılaşıldı. (Try-Catch)", MsgBoxStyle.Critical, "Uyarı")
        End Try
    End Sub

    Private Sub DaireGuncelle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try



            'TODO: This line of code loads data into the 'ApartmanyonetimiDataSet5.kisiler' table. You can move, or remove it, as needed.
            Me.KisilerTableAdapter.Fill(Me.ApartmanyonetimiDataSet5.kisiler)
            'TODO: This line of code loads data into the 'ApartmanyonetimiDataSet5.binalar' table. You can move, or remove it, as needed.
            Me.BinalarTableAdapter.Fill(Me.ApartmanyonetimiDataSet5.binalar)



            Dim komut20 As New OleDbCommand("select * from daireler where kisi_tc='" & AnaSayfa.BunifuCustomDataGrid2.Rows(rowIndex).Cells(4).Value & "'", baglanti)
            'Dim komut25 As New OleDbCommand("update daireler set bina_adi='" & ComboBox1.Text & "', daire_kat='" & TextBox1.Text & "', daire_kapi_no='" & TextBox2.Text & "', ikamet_eden_kisi='" & TextBox4.Text & "' WHERE bina_adi='" & AnaSayfa.BunifuCustomDataGrid2.Rows(rowIndex).Cells(0).Value & "' and daire_kat='" & AnaSayfa.BunifuCustomDataGrid2.Rows(rowIndex).Cells(1).Value & "' and daire_kapi_no='" & AnaSayfa.BunifuCustomDataGrid2.Rows(rowIndex).Cells(2).Value & "' and ikamet_eden_kisi='" & AnaSayfa.BunifuCustomDataGrid2.Rows(rowIndex).Cells(3).Value & "'", baglanti)


            Dim veriokuyucu23 As OleDbDataReader
            baglanti.Open()
            veriokuyucu23 = komut20.ExecuteReader
            If veriokuyucu23.HasRows Then
                Do While veriokuyucu23.Read
                    load_bina_adi = veriokuyucu23("bina_adi")
                    load_daire_kat = veriokuyucu23("daire_kat")
                    load_daire_kapi_no = veriokuyucu23("daire_kapi_no")
                    load_ikamet_eden_kisi = veriokuyucu23("ikamet_eden_kisi")
                    load_kisi_tc = veriokuyucu23("kisi_tc")
                    load_kisi_tel = veriokuyucu23("kisi_tel")
                    load_kisi_eposta = veriokuyucu23("kisi_eposta")
                    load_kisi_notlar = veriokuyucu23("kisi_notlar")
                    load_gelis_tarihi = veriokuyucu23("gelis_tarihi")

                    GunaDateTimePicker1.Value = load_gelis_tarihi
                    'ComboBox1.SelectedValue = load_bina_adi
                    ComboBox1.Text = veriokuyucu23("bina_adi")
                    TextBox1.Text = load_daire_kat
                    TextBox2.Text = load_daire_kapi_no
                    TextBox4.Text = load_ikamet_eden_kisi
                    MaskedTextBox1.Text = load_kisi_tc
                    TextBox3.Text = load_kisi_tel
                    TextBox6.Text = load_kisi_eposta
                    RichTextBox1.Text = load_kisi_notlar
                Loop
                baglanti.Close()
            End If

            Me.TopMost = True


            yetki = AnaSayfa.yetki
            If yetki = "TAM YETKI" Then
                Me.ComboBox1.Visible = True
                Me.ComboBox3.Visible = False
                'TODO: This line of code loads data into the 'ApartmanyonetimiDataSet4.binalar' table. You can move, or remove it, as needed.
                'Me.BinalarTableAdapter.Fill(Me.ApartmanyonetimiDataSet5.binalar)
            Else
                ComboBox1.Visible = False
                Me.ComboBox3.Visible = True
                Me.ComboBox3.Items.Add(yetki)
            End If



        Catch ex As Exception
            MsgBox("Bir hatayla karşılaşıldı. (Try-Catch)", MsgBoxStyle.Critical, "Uyarı")
        End Try

        

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class