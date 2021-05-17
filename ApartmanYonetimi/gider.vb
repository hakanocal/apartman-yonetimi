Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Imports System.Data.DataTable
Imports System.Data.SqlClient

Public Class gider
    Dim src = Acilis.src

    Dim baglanti As New OleDbConnection("Provider=sqloledb;Data Source=" & src & ";Initial Catalog=apartmanyonetimi;Integrated Security=SSPI;")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim gider As Integer
        gider = TextBox1.Text
        Dim aciklama, aciklama_detay As String
        aciklama_detay = RichTextBox1.Text
        aciklama = ComboBox1.Text
        Dim komut As New OleDbCommand("Insert into kasa(gider,aciklama,aciklama_detay, tarih) values('" & gider & "', '" & aciklama & "', '" & aciklama_detay & "', '" & Today & "')", baglanti)
        baglanti.Open()
        komut.ExecuteNonQuery()
        MsgBox("Gider Başarıyla Eklendi", MsgBoxStyle.OkOnly, "Başarılı")
        baglanti.Close()

        Dim gkomut1 As New OleDbCommand("SELECT Sum(gider) FROM kasa", baglanti)
        Dim veriokuyucu As OleDbDataReader
        baglanti.Open()
        veriokuyucu = gkomut1.ExecuteReader()
        If veriokuyucu.HasRows Then
            Do While veriokuyucu.Read
                AnaSayfa.GunaTextBox2.Text = 0
                AnaSayfa.GunaTextBox2.Text = veriokuyucu(0)

            Loop
            baglanti.Close()
        Else
        End If
        AnaSayfa.GunaTextBox3.Text = Convert.ToInt32(AnaSayfa.GunaTextBox1.Text) - Convert.ToInt32(AnaSayfa.GunaTextBox2.Text)
        'TODO: This line of code loads data into the 'ApartmanyonetimiDataSet5.kasa' table. You can move, or remove it, as needed.
        AnaSayfa.KasaTableAdapter.Fill(AnaSayfa.ApartmanyonetimiDataSet5.kasa)
        Me.Close()
    End Sub


    Private Sub gider_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class