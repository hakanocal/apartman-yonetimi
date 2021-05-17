Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class KisiEkle
    Dim src = Acilis.src

    Dim baglanti As New OleDbConnection("Provider=sqloledb;Data Source=" & src & ";Initial Catalog=apartmanyonetimi;Integrated Security=SSPI;")


    Private Sub KisiEkle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim kisi_tc As String
            kisi_tc = MaskedTextBox1.Text

            If TextBox1.Text = "" Or TextBox3.Text = "" Or MaskedTextBox1.Text = "" Or TextBox6.Text = "" Then
                MsgBox("Tüm Alanları doldurun", MsgBoxStyle.Critical, "UYARI")
            ElseIf Strings.Len(MaskedTextBox1.Text) < 11 Or Strings.Len(MaskedTextBox1.Text) > 11 Then
                MsgBox("TC Kimlik numarası 11 haneli olmalıdır", MsgBoxStyle.Critical, "UYARI")
            Else
                Dim komut1 As New OleDbCommand("select * from kisiler where kisi_tc= '" & kisi_tc & "'", baglanti)
                Dim komut As New OleDbCommand("Insert into kisiler(kisi_adsoyad, kisi_tc, kisi_tel, kisi_eposta, kisi_notlar, gelis_tarihi) values('" & TextBox1.Text & "', '" & kisi_tc & "', '" & TextBox3.Text & "', '" & TextBox6.Text & "', '" & RichTextBox1.Text & "', '" & Today & "')", baglanti)
                Dim veriokuyucu As OleDbDataReader
                baglanti.Open()
                veriokuyucu = komut1.ExecuteReader
                If veriokuyucu.HasRows Then
                    baglanti.Close()
                    MsgBox("Bu kisi zaten kayıtlı", MsgBoxStyle.Critical, "UYARI")
                Else
                    baglanti.Close()
                    baglanti.Open()
                    
                    komut.ExecuteNonQuery()
                    baglanti.Close()
                    MsgBox("kişi kaydı başarılı", MsgBoxStyle.OkOnly, "Başarılı")

                End If
            End If
        Catch ex As Exception
            MsgBox("Bir hatayla karşılaşıldı. (Try-Catch)", MsgBoxStyle.Critical, "Uyarı")
        End Try
    End Sub
End Class