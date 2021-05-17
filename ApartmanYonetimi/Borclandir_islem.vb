Imports System.Data
Imports System.Data.OleDb

Public Class Borclandir_islem
    Dim src = Acilis.src
    Dim baglanti As New OleDbConnection("Provider=sqloledb;Data Source=" & src & ";Initial Catalog=apartmanyonetimi;Integrated Security=SSPI;")
    Dim load_bina_adi, load_daire_kat, load_daire_kapi_no, load_ikamet_eden_kisi, load_kisi_tc, load_kisi_tel, load_kisi_eposta, load_kisi_notlar, load_gelis_tarihi As String
    Dim rowIndex = AnaSayfa.rowIndex
    Dim yetki As String
    Public rowIndex2 As Integer = 0
    Dim bakiye As Integer = 0

    Public Sub borc_renk()
        If Label10.Text <= 0 Then
            Label9.ForeColor = Color.Green
            Label10.ForeColor = Color.Green
            Label18.ForeColor = Color.Green
        End If
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

    Private Sub Borclandir_islem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ApartmanyonetimiDataSet5.makbuz' table. You can move, or remove it, as needed.
        Me.MakbuzTableAdapter.Fill(Me.ApartmanyonetimiDataSet5.makbuz)
        bakiyehesapla()
        Label10.Text = bakiye
        'TODO: This line of code loads data into the 'ApartmanyonetimiDataSet5.borclar' table. You can move, or remove it, as needed.
        Me.BorclarTableAdapter.Fill(Me.ApartmanyonetimiDataSet5.borclar)
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
        borc_renk()
        BorclarBindingSource.Filter = "[kisi_tc] = '" & Label14.Text & "'" 'TC'ye göre borç filtreleme.
        'Try
        MakbuzBindingSource.Filter = "[kisi_tc] = '" & Label14.Text & "'" 'TC'ye göre makbuz filtreleme
        'Catch ex As Exception

        'End Try

        Me.TopMost = True
    End Sub
    Private Sub BunifuCustomDataGrid12_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles BunifuCustomDataGrid12.CellMouseUp
        Try
            'GridView Hücreye sağ click yapıldığında tüm satır seçiliyor ve ContextMenuStrip5 açılıyor.
            If e.Button = MouseButtons.Right Then
                Me.BunifuCustomDataGrid12.Rows(e.RowIndex).Selected = True
                Me.rowIndex2 = e.RowIndex
                Me.BunifuCustomDataGrid12.CurrentCell = Me.BunifuCustomDataGrid12.Rows(e.RowIndex).Cells(0)
                Me.ContextMenuStrip1.Show(Me.BunifuCustomDataGrid12, e.Location)
                ContextMenuStrip1.Show(Cursor.Position)
            End If
        Catch ex As Exception
            MsgBox("Bir hatayla karşılaşıldı. (Try-Catch)", MsgBoxStyle.Critical, "Uyarı")
        End Try
    End Sub



    Private Sub ÖdeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÖdeToolStripMenuItem.Click
        If Me.BunifuCustomDataGrid12.Rows(Me.rowIndex2).Cells(5).Value <= 0 Then
            MsgBox("Zaten bu borcun tamamı tahsil edilmiştir.", MsgBoxStyle.Critical, "Uyarı")
        Else
            OdemeYap.Show()

        End If
    End Sub

    Private Sub BunifuCustomDataGrid11_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles BunifuCustomDataGrid1.CellMouseUp
        Try
            'GridView Hücreye sağ click yapıldığında tüm satır seçiliyor ve ContextMenuStrip5 açılıyor.
            If e.Button = MouseButtons.Right Then
                Me.BunifuCustomDataGrid1.Rows(e.RowIndex).Selected = True
                Me.rowIndex2 = e.RowIndex
                Me.BunifuCustomDataGrid1.CurrentCell = Me.BunifuCustomDataGrid1.Rows(e.RowIndex).Cells(0)
                Me.ContextMenuStrip2.Show(Me.BunifuCustomDataGrid1, e.Location)
                ContextMenuStrip2.Show(Cursor.Position)
            End If
        Catch ex As Exception
            MsgBox("Bir hatayla karşılaşıldı. (Try-Catch)", MsgBoxStyle.Critical, "Uyarı")
        End Try
    End Sub
    Private Sub YazdırToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YazdırToolStripMenuItem.Click
        Makbuz.Show()
    End Sub
End Class