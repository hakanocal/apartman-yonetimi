Imports System.Data
Imports System.Data.OleDb

Public Class BorcEkle
    Dim src = Acilis.src
    Dim baglanti As New OleDbConnection("Provider=sqloledb;Data Source=" & src & ";Initial Catalog=apartmanyonetimi;Integrated Security=SSPI;")
    Dim bakiye As Integer
    Dim txt As String
    Private Sub BorcEkle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GunaDateTimePicker1.MinDate = Today
        Dim i As Integer
        For i = 0 To AnaSayfa.borlandir_ad.Count - 1
            Dim str As String = TryCast(AnaSayfa.borlandir_ad.Item(i), String)
            ListBox1.Items.Add(str)
        Next i



    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Try
        If ListBox1.Items.Item(0) = "" Or TextBox2.Text = "" Or RichTextBox1.Text = "" Then
            MsgBox("Lütfen boş alan bırakmayınız", MsgBoxStyle.Critical, "Hata")
        ElseIf Strings.Len(TextBox2.Text) > 9 Then
            MsgBox("En fazla 9 haneli tutar girebilirsiniz", MsgBoxStyle.Critical, "Hata")
        Else
            Dim i As Integer
            For i = 0 To AnaSayfa.borlandir_tc.Count - 1
                Dim str As String = TryCast(AnaSayfa.borlandir_tc.Item(i), String)
                Dim komut1 As New OleDbCommand("select * from daireler where kisi_tc= '" & AnaSayfa.borlandir_tc.Item(i) & "'", baglanti)
                bakiye = AnaSayfa.borlandir_bakiye.Item(i)
                txt = TextBox2.Text
                Dim komut As New OleDbCommand("update daireler set bakiye='" & (TextBox2.Text * -1) + (bakiye) & "' where kisi_tc ='" & AnaSayfa.borlandir_tc.Item(i) & "' ", baglanti)
                Dim komut3 As New OleDbCommand("insert into borclar(kisi_tc, borc_aciklama, tarih, son_odeme_tarihi, tutar, odendigi_tarih) values ('" & AnaSayfa.borlandir_tc.Item(i) & "', '" & RichTextBox1.Text & "', '" & Today & "','" & GunaDateTimePicker1.Text & "', '" & TextBox2.Text & "', 'ödenmedi') ", baglanti)

                Dim veriokuyucu As OleDbDataReader
                baglanti.Open()
                veriokuyucu = komut1.ExecuteReader
                If veriokuyucu.HasRows Then
                    baglanti.Close()
                    'MsgBox("Zaten bakiye mevcut", MsgBoxStyle.Critical, "UYARI")
                    baglanti.Open()
                    komut.ExecuteNonQuery()
                    komut3.ExecuteNonQuery()
                    AnaSayfa.mybindgrid()
                    'MsgBox("Borçlandırma başarılı1", MsgBoxStyle.OkOnly, "Başarılı")
                    baglanti.Close()
                Else
                    baglanti.Close()
                    baglanti.Open()
                    komut.ExecuteNonQuery()
                    komut3.ExecuteNonQuery()

                    AnaSayfa.mybindgrid()
                    MsgBox("Borçlandırma başarılı2 - " + Chr(13) + "Else? veriokuyucu has not rows? rly?", MsgBoxStyle.OkOnly, "Başarılı")
                    baglanti.Close()

                End If

            Next i
            'me.close() 2 saatimi çaldın
            Me.Close()
            MsgBox("Borçlandırma başarılı", MsgBoxStyle.OkOnly, "Başarılı")


        End If
        'Catch ex As Exception
        '    MsgBox("Hata oluştu", MsgBoxStyle.Critical, "Hata")
        'End Try
    End Sub
End Class