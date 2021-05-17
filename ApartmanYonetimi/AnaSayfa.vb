Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Imports System.Data.DataTable
Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class AnaSayfa
    Dim pers_tel, pers_eposta, pers_tc, pers_gelis, pers_brans, pers_blok As String
    Dim src = Acilis.src
    Dim baglanti As New OleDbConnection("Provider=sqloledb;Data Source=" & src & ";Initial Catalog=apartmanyonetimi;Integrated Security=SSPI;")
    Private Const ConnectionString As String = "Data Source=.\SQLEXPRESS;Initial Catalog=apartmanyonetimi;Integrated Security = true"
    Dim salise As Integer = 60
    Dim saniye As Integer = 59
    Dim dakika As Integer = 29
    Public rowIndex As Integer = 0
    Dim cevap As Integer
    Dim yoneticisayisi As Integer = yoneticiekle.yoneticisayisi
    Dim dairesayisi As Integer = DaireEkle.dairesayisi
    Public tamyetkiliyoneticisayisi As Integer
    Dim binasayisi As Integer
    Public yetki As String
    Dim load_bina_adi, load_daire_kat, load_daire_kapi_no, load_ikamet_eden_kisi, load_kisi_tc, load_kisi_tel, load_kisi_eposta, load_kisi_notlar, load_gelis_tarihi As String
    Dim secilen_yonetici_yetki, secilen_yonetici_tel, secilen_yonetici_tc, secilen_yonetici_sifre, secilen_yonetici_guvenlik_sorusu, secilen_yonetici_gelis_tarihi, secilen_yonetici_cikis_tarihi, secilen_yonetici_eposta, secilen_yonetici_soyad, secilen_yonetici_cevap, secilen_yonetici_ad As String
    Public borlandir_tc As New ArrayList
    Public borlandir_ad As New ArrayList
    Public borlandir_bakiye As New ArrayList
    Dim adres As String


    Private Sub AnaSayfa_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Try





            Me.BindGrid()



            Dim komut22 As New OleDbCommand("select * from adres", baglanti)
            Dim verioku22 As OleDbDataReader
            baglanti.Open()

            verioku22 = komut22.ExecuteReader
            If verioku22.HasRows Then
                Do While verioku22.Read
                    adres = verioku22("adres")
                Loop
                RichTextBox1.Text = adres

                baglanti.Close()
            Else
                baglanti.Close()
                MsgBox("Bir hatayla karşılaşıldı", MsgBoxStyle.Critical, "Uyarı")
            End If






            'TODO: This line of code loads data into the 'ApartmanyonetimiDataSet5.kasa' table. You can move, or remove it, as needed.
            Me.KasaTableAdapter.Fill(Me.ApartmanyonetimiDataSet5.kasa)
            'TODO: This line of code loads data into the 'ApartmanyonetimiDataSet54.eski_personel' table. You can move, or remove it, as needed.
            Me.Eski_personelTableAdapter.Fill(Me.ApartmanyonetimiDataSet54.eski_personel)




            'TODO: This line of code loads data into the 'ApartmanyonetimiDataSet53.eski_personel' table. You can move, or remove it, as needed.
            Me.Eski_personelTableAdapter.Fill(Me.ApartmanyonetimiDataSet53.eski_personel)
            'TODO: This line of code loads data into the 'ApartmanyonetimiDataSet52.personel' table. You can move, or remove it, as needed.
            Me.PersonelTableAdapter.Fill(Me.ApartmanyonetimiDataSet5.personel)
            'TODOss
            Me.Eski_yoneticilerTableAdapter.Fill(Me.ApartmanyonetimiDataSet5.eski_yoneticiler)
            'TODO: This line of code loads data into the 'ApartmanyonetimiDataSet5.eski_daireler' table. You can move, or remove it, as needed.
            Me.Eski_dairelerTableAdapter.Fill(Me.ApartmanyonetimiDataSet5.eski_daireler)
            'TODO: This line of code loads data into the 'ApartmanyonetimiDataSet2.yoneticiler' table. You can move, or remove it, as needed.
            Me.YoneticilerTableAdapter.Fill(Me.ApartmanyonetimiDataSet5.yoneticiler)
            'TODO: This line of code loads data into the 'ApartmanyonetimiDataSet2.daireler' table. You can move, or remove it, as needed.
            Me.DairelerTableAdapter.Fill(Me.ApartmanyonetimiDataSet5.daireler)
            'TODO: This line of code loads data into the 'ApartmanyonetimiDataSet2.binalar' table. You can move, or remove it, as needed.
            Me.BinalarTableAdapter.Fill(Me.ApartmanyonetimiDataSet5.binalar)




            ' TAM YETKİLİ YÖNETİCİ SAYISI

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
                Label16.Text = tamyetkiliyoneticisayisi

                baglanti.Close()
            Else
                baglanti.Close()
                MsgBox("Bir hatayla karşılaşıldı", MsgBoxStyle.Critical, "Uyarı")
            End If
            panelgizle()
            Panel2_ANASAYFA.Show()
            yoneticisayisi = BunifuCustomDataGrid1.Rows.Count()
            Label8.Text = ("(" & yoneticisayisi & ")")
            dairesayisi = BunifuCustomDataGrid2.Rows.Count()
            Label13.Text = ("(" & dairesayisi & ")")
            binasayisi = BunifuCustomDataGrid3.Rows.Count()
            Label15.Text = ("(" & binasayisi & ")")
            'Oturum açma kodları
            Dim tc As String
            tc = Acilis.y_tc.Text
            Dim komut As New OleDbCommand("select * from yoneticiler where tc='" & tc & "'", baglanti)
            Dim verioku As OleDbDataReader
            baglanti.Open()
            verioku = komut.ExecuteReader
            If verioku.HasRows Then
                Do While verioku.Read
                    Label6.Text = Acilis.ComboBox1.SelectedValue
                    Label7.Text = verioku("ad") + " " + verioku("soyad")
                    yetki = verioku("yetki")
                Loop
                baglanti.Close()
            Else
                baglanti.Close()
                MsgBox("Bir hatayla karşılaşıldı", MsgBoxStyle.Critical, "Uyarı")
            End If
            panelgizle()
            Panel2_ANASAYFA.Show()

            'YETKİ DURUMUNA GÖRE KISITLAMA
            If yetki <> "TAM YETKI" Then
                GunaButton6.Visible = False
                BunifuCustomDataGrid3.Enabled = False
                TextBox3.Enabled = False
                Button12.Enabled = False
                Label13.Visible = False ' daire sayısını gizledim
                DairelerBindingSource.Filter = "[bina_adi] = '" & yetki & "'" 'YETKİYE GÖRE DAİRE FİLTRELEME. DairelerBindingSource1, daireler gridview'den alındı
                DairelerBindingSource2.Filter = "[bina_adi] = '" & yetki & "'" 'YETKİYE GÖRE BORÇLANDIR SAYFASI DAİRE FİLTRELEME. DairelerBindingSource1, daireler gridview'den alındı

            End If

        Catch ex As Exception
            MsgBox("Bir hatayla karşılaşıldı. (Try-Catch)", MsgBoxStyle.Critical, "Uyarı")
        End Try
    End Sub

    Private Sub panelgizle()
        Panel2_ANASAYFA.Hide()
        Panel3_KASA.Hide()
        Panel4_BINALAR_DAIRELER.Hide()
        Panel5_BORCLANDIR.Hide()
        Panel6_PERSONEL.Hide()
        Panel7_YONETİCİLER.Hide()
        Panel8_ARŞİV.Hide()
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Try
            Me.Text = GunaButton1.Text + " • APARTMAN YÖNETİMİ"
            panelgizle()
            Panel2_ANASAYFA.Show()
        Catch ex As Exception
            MsgBox("Bir hatayla karşılaşıldı. (Try-Catch)", MsgBoxStyle.Critical, "Uyarı")
        End Try
    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        'Kasa gelir gider toplama

        'Try
        panelgizle()
        Panel3_KASA.Show()
        Dim gkomut1 As New OleDbCommand("SELECT Sum(gider) FROM kasa", baglanti)
        Dim veriokuyucu As OleDbDataReader
        baglanti.Open()
        veriokuyucu = gkomut1.ExecuteReader()
        If veriokuyucu.HasRows Then
            Do While veriokuyucu.Read
                GunaTextBox2.Text = "0"
                GunaTextBox2.Text = veriokuyucu(0).ToString()
            Loop
            baglanti.Close()
        Else
            GunaTextBox2.Text = "0"
        End If



        Dim gkomut2 As New OleDbCommand("SELECT Sum(gelir) FROM kasa", baglanti)
        Dim veriokuyucu2 As OleDbDataReader
        baglanti.Open()
        veriokuyucu2 = gkomut2.ExecuteReader()
        If veriokuyucu2.HasRows Then
            Do While veriokuyucu2.Read
                GunaTextBox1.Text = 0
                GunaTextBox1.Text = veriokuyucu2(0).ToString()
            Loop
            baglanti.Close()
        Else
            GunaTextBox1.Text = "0"
        End If

        If GunaTextBox1.Text = "" Then
            GunaTextBox1.Text = "0"
        ElseIf GunaTextBox2.Text = "" Then
            GunaTextBox2.Text = "0"
        Else
            GunaTextBox3.Text = Convert.ToInt32(GunaTextBox1.Text) - Convert.ToInt32(GunaTextBox2.Text)
        End If

        Me.Text = GunaButton2.Text + " • APARTMAN YÖNETİMİ"

        'Catch ex As Exception
        '    MsgBox("Bir hatayla karşılaşıldı. (Try-Catch)", MsgBoxStyle.Critical, "Uyarı")
        'End Try
    End Sub

    Private Sub GunaButton3_Click(sender As Object, e As EventArgs) Handles GunaButton3.Click
        Try
            Me.Text = GunaButton3.Text + " • APARTMAN YÖNETİMİ"
            panelgizle()
            Panel4_BINALAR_DAIRELER.Show()
        Catch ex As Exception
            MsgBox("Bir hatayla karşılaşıldı. (Try-Catch)", MsgBoxStyle.Critical, "Uyarı")
        End Try
    End Sub

    Private Sub GunaButton4_Click(sender As Object, e As EventArgs) Handles GunaButton4.Click
        Try
            Me.Text = GunaButton4.Text + " • APARTMAN YÖNETİMİ"
            panelgizle()
            Panel5_BORCLANDIR.Show()
        Catch ex As Exception
            MsgBox("Bir hatayla karşılaşıldı. (Try-Catch)", MsgBoxStyle.Critical, "Uyarı")
        End Try
    End Sub

    Private Sub GunaButton5_Click(sender As Object, e As EventArgs) Handles GunaButton5.Click
        Try
            Me.Text = GunaButton5.Text + " • APARTMAN YÖNETİMİ"
            panelgizle()
            Panel6_PERSONEL.Show()
        Catch ex As Exception
            MsgBox("Bir hatayla karşılaşıldı. (Try-Catch)", MsgBoxStyle.Critical, "Uyarı")
        End Try
    End Sub

    Private Sub GunaButton6_Click(sender As Object, e As EventArgs) Handles GunaButton6.Click
        Try
            Me.Text = GunaButton6.Text + " • APARTMAN YÖNETİMİ"
            panelgizle()
            Panel7_YONETİCİLER.Show()
        Catch ex As Exception
            MsgBox("Bir hatayla karşılaşıldı. (Try-Catch)", MsgBoxStyle.Critical, "Uyarı")
        End Try
    End Sub

    Private Sub GunaButton8_Click(sender As Object, e As EventArgs) Handles GunaButton8.Click
        Try
            Me.Close()
            Acilis.Close()
        Catch ex As Exception
            MsgBox("Bir hatayla karşılaşıldı. (Try-Catch)", MsgBoxStyle.Critical, "Uyarı")
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            salise = salise - 1
            If salise = 0 Then
                salise = 60
                saniye = saniye - 1
                If saniye = 0 Then
                    If dakika = 0 And saniye = 0 Then
                        salise = 60
                        saniye = 59 'Class altındaki saniye değişkeninin değeriyle aynı olması lazım
                        dakika = 29 'Class altındaki dakika değişkeninin değeriyle aynı olması lazım
                        Timer1.Stop()
                        Me.Close()
                        Acilis.Show()
                        Acilis.y_tc.Text = ""
                        'Bu döngü ile açık olan tüm formlar kapatıldı
                        For Each f As Form In Application.OpenForms
                            f.Hide()
                        Next
                        Acilis.Show()
                        MsgBox("Apartman Yönetimi oturumunuz otomatik olarak sonlandırıldı." + Chr(13) + "Lütfen tekrar oturum açın.", 262144, Title:="UYARI")
                    Else
                        saniye = 59
                        dakika = dakika - 1
                    End If
                End If
            End If

            Label11.Text = ("Oturumunuz " & dakika & " dakika " & saniye & " saniye sonra sonlandırılacaktır")

        Catch ex As Exception
            MsgBox("Bir hatayla karşılaşıldı. (Try-Catch)", MsgBoxStyle.Critical, "Uyarı")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            yoneticiekle.Show()
        Catch ex As Exception
            MsgBox("Bir hatayla karşılaşıldı. (Try-Catch)", MsgBoxStyle.Critical, "Uyarı")
        End Try
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            DaireEkle.Show()
        Catch ex As Exception
            MsgBox("Bir hatayla karşılaşıldı. (Try-Catch)", MsgBoxStyle.Critical, "Uyarı")
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            gider.Show()
        Catch ex As Exception
            MsgBox("Bir hatayla karşılaşıldı. (Try-Catch)", MsgBoxStyle.Critical, "Uyarı")
        End Try
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Try
            If TextBox3.Text = "" Or TextBox3.Text = " " Then
                MsgBox("Bina adı boş bırakılamaz", MsgBoxStyle.Critical, "UYARI")
            Else
                Dim komut1 As New OleDbCommand("select * from binalar where bina_adi= '" & TextBox3.Text & "'", baglanti)
                Dim komut As New OleDbCommand("Insert into binalar(bina_adi) values('" & TextBox3.Text & "')", baglanti)
                Dim komut6 As New OleDbCommand("Insert into yetkiler(yetki) values('" & TextBox3.Text & "')", baglanti)

                Dim veriokuyucu As OleDbDataReader
                baglanti.Open()
                veriokuyucu = komut1.ExecuteReader
                If veriokuyucu.HasRows Then
                    baglanti.Close()
                    MsgBox("BU BİNA ZATEN KAYITLI", MsgBoxStyle.Critical, "UYARI")
                Else
                    baglanti.Close()
                    baglanti.Open()
                    komut.ExecuteNonQuery()
                    komut6.ExecuteNonQuery()
                    MsgBox("KAYIT BAŞARILI", MsgBoxStyle.OkOnly, "BAŞARILI")
                    'TODO: This line of code loads data into the 'ApartmanyonetimiDataSet4.yetkiler' table. You can move, or remove it, as needed.
                    yoneticiekle.YetkilerTableAdapter.Fill(yoneticiekle.ApartmanyonetimiDataSet5.yetkiler)

                    Me.BinalarTableAdapter.Fill(Me.ApartmanyonetimiDataSet5.binalar)
                    binasayisi = BunifuCustomDataGrid3.Rows.Count()
                    Label15.Text = ("(" & binasayisi & ")")
                    baglanti.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox("Bir hatayla karşılaşıldı. (Try-Catch)", MsgBoxStyle.Critical, "Uyarı")
        End Try
    End Sub

    'Yoneticiler datagrid1 Sil/güncelle contextmenustrip1
    Private Sub BunifuCustomDataGrid1_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles BunifuCustomDataGrid1.CellMouseUp
        Try
            'GridView Hücreye sağ click yapıldığında tüm satır seçiliyor ve ContextMenuStrip1 açılıyor.
            If e.Button = MouseButtons.Right Then
                Me.BunifuCustomDataGrid1.Rows(e.RowIndex).Selected = True
                Me.rowIndex = e.RowIndex
                Me.BunifuCustomDataGrid1.CurrentCell = Me.BunifuCustomDataGrid1.Rows(e.RowIndex).Cells(1)
                Me.ContextMenuStrip1.Show(Me.BunifuCustomDataGrid1, e.Location)
                ContextMenuStrip1.Show(Cursor.Position)
            End If
        Catch ex As Exception
            MsgBox("Bir hatayla karşılaşıldı. (Try-Catch)", MsgBoxStyle.Critical, "Uyarı")
        End Try
    End Sub
    'Daireler datagrid1 Sil/güncelle contextmenustrip2
    Private Sub BunifuCustomDataGrid2_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles BunifuCustomDataGrid2.CellMouseUp
        Try
            'GridView Hücreye sağ click yapıldığında tüm satır seçiliyor ve ContextMenuStrip1 açılıyor.
            If e.Button = MouseButtons.Right Then
                Me.BunifuCustomDataGrid2.Rows(e.RowIndex).Selected = True
                Me.rowIndex = e.RowIndex
                Me.BunifuCustomDataGrid2.CurrentCell = Me.BunifuCustomDataGrid2.Rows(e.RowIndex).Cells(1)
                Me.ContextMenuStrip2.Show(Me.BunifuCustomDataGrid2, e.Location)
                ContextMenuStrip2.Show(Cursor.Position)
            End If
        Catch ex As Exception
            MsgBox("Bir hatayla karşılaşıldı. (Try-Catch)", MsgBoxStyle.Critical, "Uyarı")
        End Try
    End Sub

    'Binalar datagrid1 Sil/güncelle contextmenustrip3
    Private Sub BunifuCustomDataGrid3_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles BunifuCustomDataGrid3.CellMouseUp
        Try
            'GridView Hücreye sağ click yapıldığında tüm satır seçiliyor ve ContextMenuStrip1 açılıyor.
            If e.Button = MouseButtons.Right Then
                Me.BunifuCustomDataGrid3.Rows(e.RowIndex).Selected = True
                Me.rowIndex = e.RowIndex
                Me.BunifuCustomDataGrid3.CurrentCell = Me.BunifuCustomDataGrid3.Rows(e.RowIndex).Cells(0)
                Me.ContextMenuStrip3.Show(Me.BunifuCustomDataGrid3, e.Location)
                ContextMenuStrip3.Show(Cursor.Position)
            End If
        Catch ex As Exception
            MsgBox("Bir hatayla karşılaşıldı. (Try-Catch)", MsgBoxStyle.Critical, "Uyarı")
        End Try
    End Sub

    'borçlandır datagrid11 islem yap contextmenustrip5
    Private Sub BunifuCustomDataGrid11_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles BunifuCustomDataGrid11.CellMouseUp
        Try
            'GridView Hücreye sağ click yapıldığında tüm satır seçiliyor ve ContextMenuStrip5 açılıyor.
            If e.Button = MouseButtons.Right Then
                Me.BunifuCustomDataGrid11.Rows(e.RowIndex).Selected = True
                Me.rowIndex = e.RowIndex
                Me.BunifuCustomDataGrid11.CurrentCell = Me.BunifuCustomDataGrid11.Rows(e.RowIndex).Cells(0)
                Me.ContextMenuStrip5.Show(Me.BunifuCustomDataGrid11, e.Location)
                ContextMenuStrip5.Show(Cursor.Position)
            End If
        Catch ex As Exception
            MsgBox("Bir hatayla karşılaşıldı. (Try-Catch)", MsgBoxStyle.Critical, "Uyarı")
        End Try
    End Sub

    Private Sub BunifuCustomDataGrid6_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles BunifuCustomDataGrid6.CellMouseUp
        Try
            'GridView Hücreye sağ click yapıldığında tüm satır seçiliyor ve ContextMenuStrip1 açılıyor.
            If e.Button = MouseButtons.Right Then
                Me.BunifuCustomDataGrid6.Rows(e.RowIndex).Selected = True
                Me.rowIndex = e.RowIndex
                Me.BunifuCustomDataGrid6.CurrentCell = Me.BunifuCustomDataGrid6.Rows(e.RowIndex).Cells(0)
                Me.ContextMenuStrip4.Show(Me.BunifuCustomDataGrid6, e.Location)
                ContextMenuStrip4.Show(Cursor.Position)
            End If
        Catch ex As Exception
            MsgBox("Bir hatayla karşılaşıldı. (Try-Catch)", MsgBoxStyle.Critical, "Uyarı")
        End Try
    End Sub

    Private Sub SilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SilToolStripMenuItem.Click
        Try
            '
            '
            '
            ' TAM YETKİLİ YÖNETİCİ SAYISININ BELİRLENMESİ
            tamyetkiliyoneticisayisi = 0
            Dim komut5 As New OleDbCommand("select * from yoneticiler", baglanti)
            Dim verioku5 As OleDbDataReader
            baglanti.Open()
            verioku5 = komut5.ExecuteReader
            If verioku5.HasRows Then
                Do While verioku5.Read
                    If verioku5("yetki") = "TAM YETKI" Then
                        tamyetkiliyoneticisayisi += 1
                    End If
                Loop
                Label16.Text = tamyetkiliyoneticisayisi

                baglanti.Close()
            Else
                baglanti.Close()
                MsgBox("Bir hatayla karşılaşıldı", MsgBoxStyle.Critical, "Uyarı")
            End If
            '
            '
            '
            '
            '
            '
            'GridView yönetici silme kodları
            'TODO: This line of code loads data into the 'ApartmanyonetimiDataSet.yoneticiler' table. You can move, or remove it, as needed.
            Me.YoneticilerTableAdapter.Fill(Me.ApartmanyonetimiDataSet5.yoneticiler)
            yoneticisayisi = BunifuCustomDataGrid1.Rows.Count
            If tamyetkiliyoneticisayisi >= 2 Or BunifuCustomDataGrid1.Rows(rowIndex).Cells(5).Value <> "TAM YETKI" Then
                Dim tc As String
                tc = BunifuCustomDataGrid1.Rows(rowIndex).Cells(4).Value
                If Not Me.BunifuCustomDataGrid1.Rows(Me.rowIndex).IsNewRow Then
                    Dim komut1 As New OleDbCommand("select * from yoneticiler where tc= '" & tc & "'", baglanti)
                    Dim komut As New OleDbCommand("DELETE FROM yoneticiler WHERE tc= '" & tc & "'", baglanti)

                    Dim veriokuyucu As OleDbDataReader
                    baglanti.Open()
                    veriokuyucu = komut1.ExecuteReader
                    If veriokuyucu.HasRows Then
                        Do While veriokuyucu.Read
                            cevap = MsgBox(veriokuyucu("ad") + " " + veriokuyucu("soyad") + " adlı yönetici silinecek. Emin misiniz?", MsgBoxStyle.YesNoCancel, "Uyarı")
                            secilen_yonetici_ad = veriokuyucu("ad")
                            secilen_yonetici_soyad = veriokuyucu("soyad")
                            secilen_yonetici_tel = veriokuyucu("tel")
                            secilen_yonetici_eposta = veriokuyucu("eposta")
                            secilen_yonetici_tc = veriokuyucu("tc")
                            secilen_yonetici_sifre = veriokuyucu("sifre")
                            secilen_yonetici_yetki = veriokuyucu("yetki")
                            'secilen_yonetici_guvenlik_sorusu = veriokuyucu("guvenlik_sorusu") ' A BLOK YÖNETİCİSİNE GÜVENLİK SORUSU SORMADIĞIMIZ İÇİN NULL DEĞER DÖNDÜRÜYOR
                            'secilen_yonetici_cevap = veriokuyucu("cevap")
                            secilen_yonetici_gelis_tarihi = veriokuyucu("gelis_tarihi")

                        Loop
                        baglanti.Close()
                        If cevap = DialogResult.Yes Then
                            Me.BunifuCustomDataGrid1.Rows.RemoveAt(Me.rowIndex)
                            yoneticisayisi = BunifuCustomDataGrid1.Rows.Count()
                            Label8.Text = ("(" & yoneticisayisi & ")")
                            baglanti.Open()
                            Dim eski_yoneticiler As New OleDbCommand("insert into eski_yoneticiler(ad, soyad, tel, eposta, tc, sifre, yetki, gelis_tarihi, cikis_tarihi) values('" & secilen_yonetici_ad & "', '" & secilen_yonetici_soyad & "','" & secilen_yonetici_tel & "','" & secilen_yonetici_eposta & "','" & secilen_yonetici_tc & "','" & secilen_yonetici_sifre & "','" & secilen_yonetici_yetki & "', '" & secilen_yonetici_gelis_tarihi & "','" & Today & "')", baglanti)
                            eski_yoneticiler.ExecuteNonQuery()
                            komut.ExecuteNonQuery()
                            'TODOssss
                            Me.Eski_yoneticilerTableAdapter.Fill(Me.ApartmanyonetimiDataSet5.eski_yoneticiler)
                            'TODO: This line of code loads data into the 'ApartmanyonetimiDataSet.yoneticiler' table. You can move, or remove it, as needed.
                            Me.YoneticilerTableAdapter.Fill(Me.ApartmanyonetimiDataSet5.yoneticiler)

                            baglanti.Close()
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
                                Label16.Text = tamyetkiliyoneticisayisi

                                baglanti.Close()
                            Else
                                baglanti.Close()
                                MsgBox("Bir hatayla karşılaşıldı", MsgBoxStyle.Critical, "Uyarı")
                            End If
                            '
                            '
                            '
                        Else
                        End If
                    Else
                        baglanti.Close()
                        MsgBox("VERİTABANINDA BU YÖNETİCİ BULUNAMADI / BİR HATAYLA KARŞILAŞILDI", MsgBoxStyle.OkOnly, "BAŞARILI")
                    End If
                End If
            Else
                MsgBox("TAM YETKİLİ SON YÖNETİCİYİ SİLEMEZSİNİZ", MsgBoxStyle.Critical, "UYARI")
            End If
        Catch ex As Exception
            MsgBox("Bir hatayla karşılaşıldı. (Try-Catch)", MsgBoxStyle.Critical, "Uyarı")
        End Try
    End Sub

    Private Sub DüzenleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DüzenleToolStripMenuItem.Click
        Try
            '
            'GridView yönetici güncelleme kodları'
            '
            YoneticiGuncelle.Show()
        Catch ex As Exception
            MsgBox("Bir hatayla karşılaşıldı. (Try-Catch)", MsgBoxStyle.Critical, "Uyarı")
        End Try
    End Sub


    Private Sub SilToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SilToolStripMenuItem1.Click
        Try

            Dim komut20 As New OleDbCommand("select * from daireler where kisi_tc='" & Me.BunifuCustomDataGrid2.Rows(rowIndex).Cells(4).Value & "'", baglanti)
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

                Loop
                baglanti.Close()



            End If
            '
            ' GridView daire silme kodları
            '
            'TODO: This line of code loads data into the 'ApartmanyonetimiDataSet.yoneticiler' table. You can move, or remove it, as needed.
            Me.DairelerTableAdapter.Fill(Me.ApartmanyonetimiDataSet5.daireler)

            Dim bina_adi, daire_kat, daire_kapi_no, kisi_tc As String
            bina_adi = BunifuCustomDataGrid2.Rows(rowIndex).Cells(0).Value
            daire_kat = BunifuCustomDataGrid2.Rows(rowIndex).Cells(1).Value
            daire_kapi_no = BunifuCustomDataGrid2.Rows(rowIndex).Cells(2).Value
            kisi_tc = BunifuCustomDataGrid2.Rows(rowIndex).Cells(4).Value

            If Not Me.BunifuCustomDataGrid2.Rows(Me.rowIndex).IsNewRow Then

                Dim komut1 As New OleDbCommand("select * from daireler where bina_adi= '" & bina_adi & "' and daire_kat='" & daire_kat & "' and daire_kapi_no='" & daire_kapi_no & "'", baglanti)
                Dim komut As New OleDbCommand("DELETE FROM daireler where bina_adi= '" & bina_adi & "' and daire_kat='" & daire_kat & "' and daire_kapi_no='" & daire_kapi_no & "'", baglanti)
                Dim komut_kisi_sil As New OleDbCommand("DELETE FROM kisiler where kisi_tc= '" & kisi_tc & "'", baglanti)
                Dim eski_daire_ekle As New OleDbCommand("Insert into eski_daireler(bina_adi, daire_kat, daire_kapi_no, ikamet_eden_kisi, kisi_tc, kisi_tel, kisi_eposta, kisi_notlar, gelis_tarihi, cikis_tarihi) values('" & load_bina_adi & "', '" & load_daire_kat & "','" & load_daire_kapi_no & "','" & load_ikamet_eden_kisi & "','" & load_kisi_tc & "','" & load_kisi_tel & "','" & load_kisi_eposta & "','" & load_kisi_notlar & "', '" & load_gelis_tarihi & "', '" & Today & "')", baglanti)

                Dim veriokuyucu As OleDbDataReader
                baglanti.Open()
                veriokuyucu = komut1.ExecuteReader
                If veriokuyucu.HasRows Then
                    Do While veriokuyucu.Read
                        cevap = MsgBox(veriokuyucu("bina_adi") + "," + " " + veriokuyucu("ikamet_eden_kisi") + Chr(13) + "kişisinin oturduğu daire silinecek. Emin misiniz?", MsgBoxStyle.YesNoCancel, "Uyarı")
                    Loop
                    baglanti.Close()
                    If cevap = DialogResult.Yes Then


                        Me.BunifuCustomDataGrid2.Rows.RemoveAt(Me.rowIndex)
                        dairesayisi = BunifuCustomDataGrid2.Rows.Count()
                        Label13.Text = ("(" & dairesayisi & ")")
                        baglanti.Open()

                        komut_kisi_sil.ExecuteNonQuery()
                        eski_daire_ekle.ExecuteNonQuery()
                        komut.ExecuteNonQuery()
                        'komut_kisi_sil.ExecuteNonQuery()
                        Me.DairelerTableAdapter.Fill(Me.ApartmanyonetimiDataSet5.daireler)
                        'TODO: This line of code loads data into the 'ApartmanyonetimiDataSet5.eski_daireler' table. You can move, or remove it, as needed.
                        Me.Eski_dairelerTableAdapter.Fill(Me.ApartmanyonetimiDataSet5.eski_daireler)
                        Me.mybindgrid()

                        baglanti.Close()
                    Else
                    End If
                Else
                    baglanti.Close()
                    MsgBox("VERİTABANINDA BU DAİRE BULUNAMADI / BİR HATAYLA KARŞILAŞILDI", MsgBoxStyle.OkOnly, "BAŞARILI")
                End If
            End If

        Catch ex As Exception
            MsgBox("Bir hatayla karşılaşıldı. (Try-Catch)", MsgBoxStyle.Critical, "Uyarı")
        End Try
    End Sub

    Private Sub DüzenleToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DüzenleToolStripMenuItem1.Click
        DaireGuncelle.Show()

    End Sub

    Private Sub SilToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles SilToolStripMenuItem2.Click
        Try

            '
            ' GridView Bina silme kodları
            '
            'TODO: This line of code loads data into the 'ApartmanyonetimiDataSet.yoneticiler' table. You can move, or remove it, as needed.




            Me.BinalarTableAdapter.Fill(Me.ApartmanyonetimiDataSet5.binalar)

            Dim bina_adi As String
            bina_adi = BunifuCustomDataGrid3.Rows(rowIndex).Cells(0).Value

            If Not Me.BunifuCustomDataGrid3.Rows(Me.rowIndex).IsNewRow Then
                Dim komut1 As New OleDbCommand("select * from binalar where bina_adi= '" & bina_adi & "'", baglanti)
                Dim komut As New OleDbCommand("DELETE FROM binalar where bina_adi= '" & bina_adi & "'", baglanti)
                Dim komut2 As New OleDbCommand("DELETE FROM yetkiler where yetki= '" & bina_adi & "'", baglanti)

                Dim veriokuyucu As OleDbDataReader
                baglanti.Open()
                veriokuyucu = komut1.ExecuteReader
                If veriokuyucu.HasRows Then
                    Do While veriokuyucu.Read
                        cevap = MsgBox(veriokuyucu("bina_adi") + " binası silinecek Emin misiniz?", MsgBoxStyle.YesNoCancel, "Uyarı")
                    Loop
                    baglanti.Close()
                    If cevap = DialogResult.Yes Then

                        Me.BunifuCustomDataGrid3.Rows.RemoveAt(Me.rowIndex)
                        binasayisi = BunifuCustomDataGrid3.Rows.Count()
                        Label15.Text = ("(" & binasayisi & ")")
                        baglanti.Open()
                        komut.ExecuteNonQuery()
                        komut2.ExecuteNonQuery()
                        Me.BinalarTableAdapter.Fill(Me.ApartmanyonetimiDataSet5.binalar)

                        yoneticiekle.YetkilerTableAdapter.Fill(yoneticiekle.ApartmanyonetimiDataSet5.yetkiler)
                        baglanti.Close()
                    Else
                    End If
                Else
                    baglanti.Close()
                    MsgBox("VERİTABANINDA BU BİNA BULUNAMADI / BİR HATAYLA KARŞILAŞILDI", MsgBoxStyle.OkOnly, "BAŞARILI")
                End If
            End If

        Catch ex As Exception
            MsgBox("Bir hatayla karşılaşıldı. (Try-Catch)", MsgBoxStyle.Critical, "Uyarı")
        End Try
    End Sub

    Private Sub GunaButton7_Click(sender As Object, e As EventArgs) Handles GunaButton7.Click
        Try
            Me.Text = GunaButton7.Text + " • APARTMAN YÖNETİMİ"
            panelgizle()
            Panel8_ARŞİV.Show()
            'TODO: This line of code loads data into the 'ApartmanyonetimiDataSet54.eski_personel' table. You can move, or remove it, as needed.
            Me.Eski_personelTableAdapter.Fill(Me.ApartmanyonetimiDataSet54.eski_personel)
            'TODO: This line of code loads data into the 'ApartmanyonetimiDataSet53.eski_personel' table. You can move, or remove it, as needed.
            Me.Eski_personelTableAdapter.Fill(Me.ApartmanyonetimiDataSet53.eski_personel)
            'TODO: This line of code loads data into the 'ApartmanyonetimiDataSet53.eski_personel' table. You can move, or remove it, as needed.
            Me.Eski_personelTableAdapter.Fill(Me.ApartmanyonetimiDataSet51.eski_personel)
        Catch ex As Exception
            MsgBox("Bir hatayla karşılaşıldı. (Try-Catch)", MsgBoxStyle.Critical, "Uyarı")
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        personelekle.Show()
    End Sub



    Private Sub SilToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles SilToolStripMenuItem3.Click
        'Personel Silme İşlemi
        'Personel Silinirken arşiv sayfasına düşüyor

        Dim pers_adi As String
        pers_adi = BunifuCustomDataGrid6.Rows(rowIndex).Cells(0).Value

        If Not Me.BunifuCustomDataGrid6.Rows(Me.rowIndex).IsNewRow Then
            Dim komut1 As New OleDbCommand("select * from personel where adsoyad= '" & pers_adi & "'", baglanti)
            Dim komut As New OleDbCommand("DELETE FROM personel where adsoyad= '" & pers_adi & "'", baglanti)
            Dim veriokuyucu As OleDbDataReader
            baglanti.Open()
            veriokuyucu = komut1.ExecuteReader
            If veriokuyucu.HasRows Then
                Do While veriokuyucu.Read
                    pers_tel = veriokuyucu("telefon")
                    pers_eposta = veriokuyucu("eposta")
                    pers_tc = veriokuyucu("tc")
                    pers_gelis = veriokuyucu("gelis_tarihi")
                    pers_brans = veriokuyucu("brans")
                    pers_blok = veriokuyucu("blok")
                    cevap = MsgBox(veriokuyucu("adsoyad") + " isimli personel silinecek Emin misiniz?", MsgBoxStyle.YesNoCancel, "Uyarı")
                Loop
                baglanti.Close()
                If cevap = DialogResult.Yes Then
                    Me.BunifuCustomDataGrid6.Rows.RemoveAt(Me.rowIndex)
                    baglanti.Open()
                    komut.ExecuteNonQuery()

                    Dim komut2 As New OleDbCommand("Insert into eski_personel(adsoyad,telefon,eposta,tc,gelis_tarihi,cikis_tarihi,brans,blok) values('" & pers_adi & "','" & pers_tel & "','" & pers_eposta & "','" & pers_tc & "','" & pers_gelis & "','" & Today & "','" & pers_brans & "','" & pers_blok & "')", baglanti)
                    komut2.ExecuteNonQuery()
                    baglanti.Close()
                    MsgBox("Silme İşlemi Başarılı", MsgBoxStyle.OkOnly, "Başarılı")
                    'TODO: This line of code loads data into the 'ApartmanyonetimiDataSet53.eski_personel' table. You can move, or remove it, as needed.
                    Me.Eski_personelTableAdapter.Fill(Me.ApartmanyonetimiDataSet53.eski_personel)
                Else
                End If
            Else
                baglanti.Close()
                MsgBox("VERİTABANINDA BU PERSONEL BULUNAMADI / BİR HATAYLA KARŞILAŞILDI", MsgBoxStyle.OkOnly, "UYARI")
            End If
        End If



    End Sub

    Private Sub GüncelleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GüncelleToolStripMenuItem.Click
        personelguncelle.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Gelir.Show()
        Catch ex As Exception
            MsgBox("Bir hatayla karşılaşıldı. (Try-Catch)", MsgBoxStyle.Critical, "Uyarı")
        End Try
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        borlandir_ad.Clear()
        borlandir_tc.Clear()
        borlandir_bakiye.Clear()

        BorcEkle.ListBox1.Items.Clear()


        Dim topla As String = ""
        Dim ad As String = ""
        Dim tc As String = ""
        Dim bakiye As Integer = 0
        For i As Integer = 0 To BunifuCustomDataGrid11.RowCount - 1
            If Convert.ToBoolean(BunifuCustomDataGrid11.Rows(i).Cells(0).Value = True) Then
                tc = BunifuCustomDataGrid11.Rows(i).Cells(5).Value.ToString()
                ad = BunifuCustomDataGrid11.Rows(i).Cells(4).Value.ToString()
                bakiye = BunifuCustomDataGrid11.Rows(i).Cells(6).Value.ToString()

                borlandir_tc.Add(tc)
                borlandir_ad.Add(ad)
                borlandir_bakiye.Add(bakiye)

                'MsgBox(ad)
            End If

        Next
        If ad <> "" Then
            BorcEkle.ListBox1.Items.Clear()

            BorcEkle.Show()

        Else
            MsgBox("İşlem yapabilmek için kişi/kişiler seçin", MsgBoxStyle.Critical, "Hata")
        End If
    End Sub








    '
    'BORÇLANDIR SAYFASI CHECKBOX KULLANIMI (3 BÖLÜM)
    'BÖLÜM1
    '
    '
    Public Sub mybindgrid()
        Using con As SqlConnection = New SqlConnection(ConnectionString)
            Using cmd As SqlCommand = New SqlCommand("SELECT bina_adi, daire_kat, daire_kapi_no,  ikamet_eden_kisi, kisi_tc, bakiye FROM daireler", con)
                cmd.CommandType = CommandType.Text
                Using sda As SqlDataAdapter = New SqlDataAdapter(cmd)
                    Using dt As DataTable = New DataTable()
                        sda.Fill(dt)
                        BunifuCustomDataGrid11.DataSource = dt
                    End Using
                End Using
            End Using
        End Using
    End Sub



    Private headerCheckBox As CheckBox = New CheckBox()
    Private Sub BindGrid()
        '
        ' ' ' BORÇLANDIR DATAGRID SAYFASININ KODLARLA GETIRILMESI (FİLTRELEME YAPMAK İÇİN YORUM SATIRI OLARAK BIRAKILDI)
        '
        'Using con As SqlConnection = New SqlConnection(ConnectionString)
        '    Using cmd As SqlCommand = New SqlCommand("SELECT bina_adi, daire_kat, daire_kapi_no,  ikamet_eden_kisi, kisi_tc, bakiye FROM daireler", con)
        '        cmd.CommandType = CommandType.Text
        '        Using sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        '            Using dt As DataTable = New DataTable()
        '                sda.Fill(dt)
        '                BunifuCustomDataGrid11.DataSource = dt

        '            End Using
        '        End Using
        '    End Using
        'End Using



        'Add a CheckBox Column to the DataGridView Header Cell.

        'Find the Location of Header Cell.
        Dim headerCellLocation As Point = Me.BunifuCustomDataGrid11.GetCellDisplayRectangle(0, -1, True).Location

        'Place the Header CheckBox in the Location of the Header Cell.
        headerCheckBox.Location = New Point(headerCellLocation.X + 8, headerCellLocation.Y + 2)
        headerCheckBox.BackColor = Color.White
        headerCheckBox.Size = New Size(14, 14)


        'Assign Click event to the Header CheckBox.
        AddHandler headerCheckBox.Click, AddressOf HeaderCheckBox_Clicked
        BunifuCustomDataGrid11.Controls.Add(headerCheckBox)

        'Add a CheckBox Column to the DataGridView at the first position.
        Dim checkBoxColumn As DataGridViewCheckBoxColumn = New DataGridViewCheckBoxColumn()
        checkBoxColumn.HeaderText = "       SEÇ"
        checkBoxColumn.Width = 30
        checkBoxColumn.Name = "checkBoxColumn"
        BunifuCustomDataGrid11.Columns.Insert(0, checkBoxColumn)
        'Assign Click event to the DataGridView Cell.
        AddHandler BunifuCustomDataGrid11.CellContentClick, AddressOf DataGridView_CellClick
    End Sub

    '
    '
    'BÖLÜM2
    '
    '

    Private Sub HeaderCheckBox_Clicked(ByVal sender As Object, ByVal e As EventArgs)
        'Necessary to end the edit mode of the Cell.
        BunifuCustomDataGrid11.EndEdit()

        'Loop and check and uncheck all row CheckBoxes based on Header Cell CheckBox.
        For Each row As DataGridViewRow In BunifuCustomDataGrid11.Rows
            Dim checkBox As DataGridViewCheckBoxCell = (TryCast(row.Cells("checkBoxColumn"), DataGridViewCheckBoxCell))
            checkBox.Value = headerCheckBox.Checked
        Next
    End Sub
    '
    '
    'BÖLÜM3
    '
    '
    Private Sub DataGridView_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        'Check to ensure that the row CheckBox is clicked.
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = 0 Then

            'Loop to verify whether all row CheckBoxes are checked or not.
            Dim isChecked As Boolean = True
            For Each row As DataGridViewRow In BunifuCustomDataGrid11.Rows
                If Convert.ToBoolean(row.Cells("checkBoxColumn").EditedFormattedValue) = False Then
                    isChecked = False
                    Exit For
                End If
            Next

            headerCheckBox.Checked = isChecked
        End If
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs)
        BorcEkle.Show()
    End Sub

    Private Sub GörüntüleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GörüntüleToolStripMenuItem.Click
        DaireGoruntule.Show()
    End Sub

    Private Sub İşlemYapToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles İşlemYapToolStripMenuItem.Click
        Borclandir_islem.Show()
    End Sub


End Class
