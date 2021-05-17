Imports System.Data
Imports System.Data.OleDb
Public Class OdemeYap
    Dim src = Acilis.src
    Dim baglanti As New OleDbConnection("Provider=sqloledb;Data Source=" & src & ";Initial Catalog=apartmanyonetimi;Integrated Security=SSPI;")
    Dim bakiye As Integer = 0
    Dim cevap As Integer
    Dim rowIndex2 = Borclandir_islem.rowIndex2
    Dim donem, donem2 As String

    Private Sub OdemeYap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = Borclandir_islem.BunifuCustomDataGrid12.Rows(rowIndex2).Cells(5).Value
        RichTextBox1.Text = Borclandir_islem.BunifuCustomDataGrid12.Rows(rowIndex2).Cells(2).Value
        Me.TopMost = True
        bakiyehesapla()


    End Sub

    Private Sub bakiyehesapla()


        '
        ' Kişinin borçlarının toplamının hesaplanması
        '
        Dim komut20 As New OleDbCommand("select * from borclar where kisi_tc='" & AnaSayfa.BunifuCustomDataGrid11.Rows(AnaSayfa.rowIndex).Cells(5).Value & "'", baglanti)

        Dim veriokuyucu23 As OleDbDataReader
        baglanti.Open()
        veriokuyucu23 = komut20.ExecuteReader
        If veriokuyucu23.HasRows Then
            Do While veriokuyucu23.Read
                bakiye += veriokuyucu23("tutar")
            Loop
            baglanti.Close()
        End If
        baglanti.Close()
        '
        '
        '
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Boş alanları doldurunuz", MsgBoxStyle.Critical, "UYARI")
        ElseIf TextBox1.Text > Borclandir_islem.BunifuCustomDataGrid12.Rows(Me.rowIndex2).Cells(5).Value Then
            MsgBox("Ödemek istediğiniz tutar borcun kendisinden fazla olamaz", MsgBoxStyle.Critical, "Uyarı")
        Else
            Dim komut1 As New OleDbCommand("select * from daireler where kisi_tc= '" & AnaSayfa.BunifuCustomDataGrid11.Rows(AnaSayfa.rowIndex).Cells(5).Value & "'", baglanti)
            Dim komut As New OleDbCommand("update daireler set bakiye='" & (bakiye - (TextBox1.Text)) * -1 & "' where kisi_tc ='" & AnaSayfa.BunifuCustomDataGrid11.Rows(AnaSayfa.rowIndex).Cells(5).Value & "' ", baglanti)
            Dim text As String
            text = Borclandir_islem.GroupBox1.Text + " - " + Borclandir_islem.Label11.Text + ", " + " KAT: " + Borclandir_islem.Label12.Text + ", " + " NO: " + Borclandir_islem.Label13.Text
            Dim komutt As New OleDbCommand("Insert into kasa(gelir, aciklama, aciklama_detay, tarih) values('" & TextBox1.Text & "', '" & RichTextBox1.Text & "', '" & text & "', '" & Today & "')", baglanti)
            Dim komut4 As New OleDbCommand("update borclar set tutar='" & Borclandir_islem.BunifuCustomDataGrid12.Rows(Borclandir_islem.rowIndex2).Cells(5).Value - (TextBox1.Text) & "', odendigi_tarih = '" & Today & "' where id ='" & Borclandir_islem.BunifuCustomDataGrid12.Rows(Borclandir_islem.rowIndex2).Cells(0).Value & "' ", baglanti)
            donem = Borclandir_islem.BunifuCustomDataGrid12.Rows(Borclandir_islem.rowIndex2).Cells(3).Value
            Dim Dizi() As String
            Dizi = donem.Split(".")
            If Dizi(1).ToString() = "1" Then
                donem2 = "Ocak"
            ElseIf Dizi(1).ToString() = "2" Then
                donem2 = "Şubat"

            ElseIf Dizi(1).ToString() = "3" Then
                donem2 = "Mart"

            ElseIf Dizi(1).ToString() = "4" Then
                donem2 = "Nisan"

            ElseIf Dizi(1).ToString() = "5" Then
                donem2 = "Mayıs"

            ElseIf Dizi(1).ToString() = "6" Then
                donem2 = "Haziran"

            ElseIf Dizi(1).ToString() = "7" Then
                donem2 = "Temmuz"

            ElseIf Dizi(1).ToString() = "8" Then
                donem2 = "Ağustos"

            ElseIf Dizi(1).ToString() = " 9" Then
                donem2 = "Eylül"

            ElseIf Dizi(1).ToString() = "10" Then
                donem2 = "Ekim"

            ElseIf Dizi(1).ToString() = "11" Then
                donem2 = "Kasım"

            ElseIf Dizi(1).ToString() = "12" Then
                donem2 = "Aralık"
            Else
                donem2 = "HATA"
            End If
            Dim komut5 As New OleDbCommand("Insert into makbuz(kisi_tc, aciklama, makbuz_tarihi, bina_adi, daire_kat, daire_kapi_no, donem, veren,alan, miktar ) values('" & Borclandir_islem.Label14.Text & "' , '" & RichTextBox1.Text & "', '" & Today & "', '" & AnaSayfa.BunifuCustomDataGrid11.Rows(AnaSayfa.rowIndex).Cells(1).Value & "', '" & AnaSayfa.BunifuCustomDataGrid11.Rows(AnaSayfa.rowIndex).Cells(2).Value & "', '" & AnaSayfa.BunifuCustomDataGrid11.Rows(AnaSayfa.rowIndex).Cells(3).Value & "', '" & donem2 & "', '" & AnaSayfa.Label7.Text & "', '" & AnaSayfa.BunifuCustomDataGrid11.Rows(AnaSayfa.rowIndex).Cells(4).Value & "', '" & TextBox1.Text & "')", baglanti)



            Dim veriokuyucu As OleDbDataReader
            baglanti.Open()
            veriokuyucu = komut1.ExecuteReader
            If veriokuyucu.HasRows Then
                baglanti.Close()
                'MsgBox("Zaten bakiye mevcut", MsgBoxStyle.Critical, "UYARI")
                baglanti.Open()

                komut4.ExecuteNonQuery()
                komut.ExecuteNonQuery()
                komutt.ExecuteNonQuery()
                komut5.ExecuteNonQuery()
                'TODO: This line of code loads data into the 'ApartmanyonetimiDataSet5.makbuz' table. You can move, or remove it, as needed.
                Borclandir_islem.MakbuzTableAdapter.Fill(Borclandir_islem.ApartmanyonetimiDataSet5.makbuz)
                AnaSayfa.mybindgrid()
                'TODO: This line of code loads data into the 'ApartmanyonetimiDataSet5.borclar' table. You can move, or remove it, as needed.
                Borclandir_islem.BorclarTableAdapter.Fill(Borclandir_islem.ApartmanyonetimiDataSet5.borclar)
                'MsgBox("Borçlandırma başarılı1", MsgBoxStyle.OkOnly, "Başarılı")
                Borclandir_islem.Label10.Text = AnaSayfa.BunifuCustomDataGrid11.Rows(AnaSayfa.rowIndex).Cells(6).Value * -1
                'TODO: This line of code loads data into the 'ApartmanyonetimiDataSet5.kasa' table. You can move, or remove it, as needed.
                AnaSayfa.KasaTableAdapter.Fill(AnaSayfa.ApartmanyonetimiDataSet5.kasa)
                Borclandir_islem.borc_renk()

                baglanti.Close()
            Else
                baglanti.Close()
                baglanti.Open()

                komut4.ExecuteNonQuery()
                komut.ExecuteNonQuery()
                komutt.ExecuteNonQuery()
                komut5.ExecuteNonQuery()
                'TODO: This line of code loads data into the 'ApartmanyonetimiDataSet5.makbuz' table. You can move, or remove it, as needed.
                Borclandir_islem.MakbuzTableAdapter.Fill(Borclandir_islem.ApartmanyonetimiDataSet5.makbuz)
                AnaSayfa.mybindgrid()
                MsgBox("Borçlandırma başarılı2 - " + Chr(13) + "Else? veriokuyucu has not rows? rly?", MsgBoxStyle.OkOnly, "Başarılı")
                Borclandir_islem.Label10.Text = AnaSayfa.BunifuCustomDataGrid11.Rows(AnaSayfa.rowIndex).Cells(6).Value * -1
                'TODO: This line of code loads data into the 'ApartmanyonetimiDataSet5.kasa' table. You can move, or remove it, as needed.
                AnaSayfa.KasaTableAdapter.Fill(AnaSayfa.ApartmanyonetimiDataSet5.kasa)
                Borclandir_islem.borc_renk()

                baglanti.Close()

            End If




            '200IQ
            Me.Hide()
            cevap = MsgBox(TextBox1.Text + " TL ÖDEME ALINDI", MsgBoxStyle.OkOnly, "Başarılı")
            If cevap = DialogResult.Yes Then
                MsgBox("MAKBUZ YAZDIRILDI", MsgBoxStyle.OkOnly, "Başarılı")
            End If

            Me.Close()
        End If

    End Sub
End Class