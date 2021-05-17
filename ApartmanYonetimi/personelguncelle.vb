Imports System.Data
Imports System.Data.OleDb
Public Class personelguncelle
    Dim src = Acilis.src
    Dim baglanti As New OleDbConnection("Provider=sqloledb;Data Source=" & src & ";Initial Catalog=apartmanyonetimi;Integrated Security=SSPI;")
    Private Sub personelguncelle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ApartmanyonetimiDataSet5.binalar' table. You can move, or remove it, as needed.
        Me.BinalarTableAdapter.Fill(Me.ApartmanyonetimiDataSet5.binalar)

        Dim komut1 As New OleDbCommand("select * from personel where adsoyad= '" & AnaSayfa.BunifuCustomDataGrid6.Rows(AnaSayfa.rowIndex).Cells(0).Value & "'", baglanti)
        Dim veriokuyucu As OleDbDataReader
        baglanti.Open()
        veriokuyucu = komut1.ExecuteReader
        If veriokuyucu.HasRows Then
            Do While veriokuyucu.Read
                TextBox1.Text = veriokuyucu("adsoyad")
                TextBox3.Text = veriokuyucu("telefon")
                TextBox4.Text = veriokuyucu("eposta")
                TextBox2.Text = veriokuyucu("brans")

                MaskedTextBox1.Text = veriokuyucu("tc")
                ComboBox1.Text = veriokuyucu("blok")
            Loop
            baglanti.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cevap As Integer

            Dim komut1 As New OleDbCommand("select * from personel where tc= '" & AnaSayfa.BunifuCustomDataGrid6.Rows(AnaSayfa.rowIndex).Cells(3).Value & "'", baglanti)
            Dim komut As New OleDbCommand("update personel set adsoyad='" & TextBox1.Text & "', telefon='" & TextBox3.Text & "', eposta='" & TextBox4.Text & "', tc='" & MaskedTextBox1.Text & "' , brans='" & TextBox2.Text & "' , blok ='" & ComboBox1.SelectedValue & "' where tc='" & AnaSayfa.BunifuCustomDataGrid6.Rows(AnaSayfa.rowIndex).Cells(3).Value & "'", baglanti)
            Dim veriokuyucu As OleDbDataReader
            baglanti.Open()
            veriokuyucu = komut1.ExecuteReader
            If veriokuyucu.HasRows Then
                Do While veriokuyucu.Read
                    cevap = MsgBox(veriokuyucu("adsoyad") + " adlı personel güncellenecek Emin misiniz?", MsgBoxStyle.YesNoCancel, "Uyarı")
                Loop
                baglanti.Close()
                If cevap = DialogResult.Yes Then
                    baglanti.Open()
                    komut.ExecuteNonQuery()
                    'TODO: This line of code loads data into the 'ApartmanyonetimiDataSet.yoneticiler' table. You can move, or remove it, as needed.
                    AnaSayfa.PersonelTableAdapter.Fill(AnaSayfa.ApartmanyonetimiDataSet5.personel)
                    baglanti.Close()
                Else

                    baglanti.Close()

                End If
                Me.Close()
            Else
            End If
        

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class