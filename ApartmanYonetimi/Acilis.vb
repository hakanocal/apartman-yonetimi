Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient


Public Class Acilis
    Public src As String = "CASPER\SQLEXPRESS"
    'Public src As String = "DESKTOP-QVGBQJ3\SQLEXPRESS"
    'Public src As String = "ENESAYDN\SQLEXPRESS"


    Dim baglanti As New OleDbConnection("Provider=sqloledb;Data Source=" & src & ";Initial Catalog=apartmanyonetimi;Integrated Security=SSPI;")


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            'Yonetici bilgilerinin veritabanında çekilmesi ve giriş işlemleri
            Dim yon_tc, yon_sifre, sql As String
            yon_tc = y_tc.Text
            yon_sifre = y_sifre.Text
            sql = "Select * from yoneticiler where tc='" & yon_tc & "' and sifre= '" & yon_sifre & "'"
            Dim verial As New OleDbDataAdapter(sql, baglanti)
            Dim ds As New DataSet
            verial.Fill(ds)
            Dim kisi_sayisi As Integer
            kisi_sayisi = ds.Tables(0).Rows.Count
            If kisi_sayisi = 1 Then
                Me.Hide()
                AnaSayfa.Show()
                'Oturum süresi başlatıldı
                AnaSayfa.Timer1.Start()
            Else
                baglanti.Close()
                MsgBox("Giriş bilgileri hatalı", MsgBoxStyle.Critical, "Uyarı")
            End If
            y_sifre.Text = ""
        Catch ex As Exception
            MsgBox("Bir hatayla karşılaşıldı. (Try-Catch)", MsgBoxStyle.Critical, "Uyarı")
        End Try
    End Sub

    Private Sub Acilis_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Try
            'TODO: This line of code loads data into the 'ApartmanyonetimiDataSet5.siteler' table. You can move, or remove it, as needed.
            Me.SitelerTableAdapter.Fill(Me.ApartmanyonetimiDataSet5.siteler)

            Dim komut2 As New OleDbCommand("select * from yoneticiler", baglanti)
            Dim veriokuyucu As OleDbDataReader
            baglanti.Open()
            veriokuyucu = komut2.ExecuteReader

            If veriokuyucu.HasRows Then
                baglanti.Close()
                Button3.Enabled = False
            Else
                baglanti.Close()
                baglanti.Open()
                komut2.ExecuteNonQuery()
                baglanti.Close()
                Button3.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("Bir hatayla karşılaşıldı. (Try-Catch)", MsgBoxStyle.Critical, "Uyarı")
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            yonetici.Show()
        Catch ex As Exception
            MsgBox("Bir hatayla karşılaşıldı. (Try-Catch)", MsgBoxStyle.Critical, "Uyarı")
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs)
        Try
            baglanti.Open()
        Catch ex As Exception
            MsgBox("Bir hatayla karşılaşıldı. (Try-Catch)", MsgBoxStyle.Critical, "Uyarı")
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Try
            Dim yon_tc, yon_sifre, sql As String
            yon_tc = y_tc.Text
            yon_sifre = y_sifre.Text
            sql = "Select * from yoneticiler where tc='" & yon_tc & "'"
            Dim verial As New OleDbDataAdapter(sql, baglanti)
            Dim ds As New DataSet
            verial.Fill(ds)
            Dim kisi_sayisi As Integer
            kisi_sayisi = ds.Tables(0).Rows.Count
            If kisi_sayisi = 1 Then
                SifremiUnuttum.Show()
            Else
                baglanti.Close()
                MsgBox("LÜTFEN DOĞRU TC KİMLİK NUMARASI GİRİNİZ", MsgBoxStyle.Critical, "Uyarı")
            End If
        Catch ex As Exception
            MsgBox("Bir hatayla karşılaşıldı. (Try-Catch)", MsgBoxStyle.Critical, "Uyarı")
        End Try
    End Sub
End Class
