Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Imports System.Data.DataTable

Public Class SifremiUnuttum
    Dim src = Acilis.src
    Dim baglanti As New OleDbConnection("Provider=sqloledb;Data Source=" & src & ";Initial Catalog=apartmanyonetimi;Integrated Security=SSPI;")
    Dim guvenlik_sorusu, cevap, sifre As String

    Private Sub SifremiUnuttum_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim komut As New OleDbCommand("select * from yoneticiler where tc='" & Acilis.y_tc.Text & "'", baglanti)
            Dim verioku As OleDbDataReader
            baglanti.Open()
            verioku = komut.ExecuteReader
            If verioku.HasRows Then
                Do While verioku.Read
                    guvenlik_sorusu = verioku("guvenlik_sorusu")
                    cevap = verioku("cevap")
                    sifre = verioku("sifre")
                    Label2.Text = guvenlik_sorusu
                Loop
                baglanti.Close()
            Else
                baglanti.Close()
                MsgBox("Bir hatayla karşılaşıldı", MsgBoxStyle.Critical, "Uyarı")
            End If
        Catch ex As Exception
            MsgBox("Bu yöneticiye ait güvenlik sorusu bulunamadı. Güvenlik sorusu sadece ilk kayıt olan yönetici için sorulur." + Chr(13) + "Bir hatayla karşılaşıldı.! (Try-Catch)", MsgBoxStyle.Critical, "Uyarı")
        End Try
        
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If cevap = TextBox1.Text Then
                Label1.Visible = True
                TextBox4.Visible = True
                TextBox4.Text = sifre
            Else
                MsgBox("Yanlış cevap lütfen cevabınızı kontrol ediniz", MsgBoxStyle.Critical, "Uyarı")

            End If
        Catch ex As Exception
            MsgBox("Bir hatayla karşılaşıldı. (Try-Catch)", MsgBoxStyle.Critical, "Uyarı")
        End Try
    End Sub

    Private Sub TextBox4_MouseHover(sender As Object, e As EventArgs) Handles TextBox4.MouseHover
        Try
            TextBox4.UseSystemPasswordChar = False
        Catch ex As Exception
            MsgBox("Bir hatayla karşılaşıldı. (Try-Catch)", MsgBoxStyle.Critical, "Uyarı")
        End Try
    End Sub

    Private Sub TextBox4_MouseLeave(sender As Object, e As EventArgs) Handles TextBox4.MouseLeave
        Try
            TextBox4.UseSystemPasswordChar = True
        Catch ex As Exception
            MsgBox("Bir hatayla karşılaşıldı. (Try-Catch)", MsgBoxStyle.Critical, "Uyarı")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Label1.Visible = False
            TextBox4.Visible = False
            TextBox1.Text = ""
            Me.Close()
        Catch ex As Exception
            MsgBox("Bir hatayla karşılaşıldı. (Try-Catch)", MsgBoxStyle.Critical, "Uyarı")
        End Try
    End Sub
End Class