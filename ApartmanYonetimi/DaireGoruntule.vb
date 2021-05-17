Imports System.Data
Imports System.Data.OleDb

Public Class DaireGoruntule
    Dim src = Acilis.src
    Dim baglanti As New OleDbConnection("Provider=sqloledb;Data Source=" & src & ";Initial Catalog=apartmanyonetimi;Integrated Security=SSPI;")
    Dim load_bina_adi, load_daire_kat, load_daire_kapi_no, load_ikamet_eden_kisi, load_kisi_tc, load_kisi_tel, load_kisi_eposta, load_kisi_notlar, load_gelis_tarihi As String
    Dim rowIndex = AnaSayfa.rowIndex
    Dim yetki As String

    Private Sub DaireGoruntule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim komut20 As New OleDbCommand("select * from daireler where kisi_tc='" & AnaSayfa.BunifuCustomDataGrid2.Rows(rowIndex).Cells(4).Value & "'", baglanti)
        'Dim komut25 As New OleDbCommand("update daireler set bina_adi='" & ComboBox1.Text & "', daire_kat='" & TextBox1.Text & "', daire_kapi_no='" & TextBox2.Text & "', ikamet_eden_kisi='" & TextBox4.Text & "' WHERE bina_adi='" & AnaSayfa.BunifuCustomDataGrid2.Rows(rowIndex).Cells(0).Value & "' and daire_kat='" & AnaSayfa.BunifuCustomDataGrid2.Rows(rowIndex).Cells(1).Value & "' and daire_kapi_no='" & AnaSayfa.BunifuCustomDataGrid2.Rows(rowIndex).Cells(2).Value & "' and ikamet_eden_kisi='" & AnaSayfa.BunifuCustomDataGrid2.Rows(rowIndex).Cells(3).Value & "'", baglanti)


        Dim veriokuyucu23 As OleDbDataReader
        baglanti.Open()
        veriokuyucu23 = komut20.ExecuteReader
        If veriokuyucu23.HasRows Then
            Do While veriokuyucu23.Read
                Label11.Text = veriokuyucu23("bina_adi")
                Label12.Text = veriokuyucu23("daire_kat")
                Label13.Text = veriokuyucu23("daire_kapi_no")
                GroupBox1.Text = veriokuyucu23("ikamet_eden_kisi")
                Label14.Text = veriokuyucu23("kisi_tc")
                Label15.Text = veriokuyucu23("kisi_tel")
                Label16.Text = veriokuyucu23("kisi_eposta")
                RichTextBox1.Text = veriokuyucu23("kisi_notlar")
                Label17.Text = veriokuyucu23("gelis_tarihi")
            Loop
            baglanti.Close()
        End If

        Me.TopMost = True


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class