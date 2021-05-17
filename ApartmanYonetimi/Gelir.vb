Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Imports System.Data.DataTable
Imports System.Data.SqlClient

Public Class Gelir
    Dim src = Acilis.src

    Dim baglanti As New OleDbConnection("Provider=sqloledb;Data Source=" & src & ";Initial Catalog=apartmanyonetimi;Integrated Security=SSPI;")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim gelir As Integer
        gelir = TextBox1.Text
        Dim aciklama, aciklama_detay As String
        aciklama = ComboBox1.Text
        aciklama_detay = RichTextBox1.Text
        Dim komut As New OleDbCommand("Insert into kasa(gelir,aciklama,aciklama_detay, tarih) values('" & gelir & "', '" & aciklama & "', '" & aciklama_detay & "', '" & Today & "')", baglanti)
        baglanti.Open()
        komut.ExecuteNonQuery()
        MsgBox("Gelir Başarıyla Eklendi", MsgBoxStyle.OkOnly, "Başarılı")
        baglanti.Close()
        Dim gkomut2 As New OleDbCommand("SELECT Sum(gelir) FROM kasa", baglanti)
        Dim veriokuyucu2 As OleDbDataReader
        baglanti.Open()
        veriokuyucu2 = gkomut2.ExecuteReader()
        If veriokuyucu2.HasRows Then
            Do While veriokuyucu2.Read
                AnaSayfa.GunaTextBox1.Text = 0
                AnaSayfa.GunaTextBox1.Text = veriokuyucu2(0)

            Loop
            baglanti.Close()
        Else
        End If
        AnaSayfa.GunaTextBox3.Text = Convert.ToInt32(AnaSayfa.GunaTextBox1.Text) - Convert.ToInt32(AnaSayfa.GunaTextBox2.Text)
        'TODO: This line of code loads data into the 'ApartmanyonetimiDataSet5.kasa' table. You can move, or remove it, as needed.
        AnaSayfa.KasaTableAdapter.Fill(AnaSayfa.ApartmanyonetimiDataSet5.kasa)
        Me.Close()
    End Sub

    Private Sub Gelir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
    End Sub
End Class