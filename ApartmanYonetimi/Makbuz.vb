Imports System.Data
Imports System.Data.OleDb
Imports System.Drawing
Imports System.Drawing.Printing


Public Class Makbuz
    Dim src = Acilis.src
    Dim baglanti As New OleDbConnection("Provider=sqloledb;Data Source=" & src & ";Initial Catalog=apartmanyonetimi;Integrated Security=SSPI;")
    Dim adres As String
    Dim WithEvents mPrintDocument As New PrintDocument
    Dim mPrintBitMap As Bitmap

    Private Sub Makbuz_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ADRES BİLGİLERİNİN VERİTABANINDAN ALINMASI
        Dim komut2 As New OleDbCommand("select * from adres", baglanti)
        Dim verioku2 As OleDbDataReader
        baglanti.Open()

        verioku2 = komut2.ExecuteReader
        If verioku2.HasRows Then
            Do While verioku2.Read
                adres = verioku2("adres")
            Loop
            RichTextBox1.Text = adres
            baglanti.Close()
        Else
            baglanti.Close()
            MsgBox("Bir hatayla karşılaşıldı", MsgBoxStyle.Critical, "Uyarı")
        End If
        '
        '
        '
        'NÜSHA1
        Label1.Text = AnaSayfa.Label6.Text
        Label4.Text = Borclandir_islem.BunifuCustomDataGrid1.Rows(Borclandir_islem.rowIndex2).Cells(0).Value
        Label2.Text = Borclandir_islem.BunifuCustomDataGrid1.Rows(Borclandir_islem.rowIndex2).Cells(1).Value
        Label12.Text = Borclandir_islem.BunifuCustomDataGrid1.Rows(Borclandir_islem.rowIndex2).Cells(2).Value
        Label6.Text = Borclandir_islem.BunifuCustomDataGrid1.Rows(Borclandir_islem.rowIndex2).Cells(3).Value
        Label5.Text = Borclandir_islem.BunifuCustomDataGrid1.Rows(Borclandir_islem.rowIndex2).Cells(4).Value
        Label7.Text = Borclandir_islem.BunifuCustomDataGrid1.Rows(Borclandir_islem.rowIndex2).Cells(5).Value
        Label8.Text = Borclandir_islem.BunifuCustomDataGrid1.Rows(Borclandir_islem.rowIndex2).Cells(6).Value
        Label9.Text = Borclandir_islem.BunifuCustomDataGrid1.Rows(Borclandir_islem.rowIndex2).Cells(7).Value
        Label10.Text = "YALNIZ " + (Borclandir_islem.BunifuCustomDataGrid1.Rows(Borclandir_islem.rowIndex2).Cells(8).Value.ToString()) + " LİRA SAYIN " + (Borclandir_islem.BunifuCustomDataGrid1.Rows(Borclandir_islem.rowIndex2).Cells(7).Value.ToString()) + " 'dan  " + (Borclandir_islem.BunifuCustomDataGrid1.Rows(Borclandir_islem.rowIndex2).Cells(9).Value.ToString()) + " BEDELİ OLARAK ALINMIŞTIR. "

        ' sayfa yüklendiğinde direkt olarak yazdırma penceresi gelsin
        Button1.Visible = False
        Button2.Visible = False
        Dim preview As New PrintPreviewDialog
        Dim pd As New System.Drawing.Printing.PrintDocument
        pd.DefaultPageSettings.Landscape = True
        AddHandler pd.PrintPage, AddressOf OnPrintPage
        preview.Document = pd
        preview.Height = 500
        preview.Width = 700
        preview.ShowDialog()

        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Visible = False
        Button2.Visible = False
        Dim preview As New PrintPreviewDialog
        Dim pd As New System.Drawing.Printing.PrintDocument
        pd.DefaultPageSettings.Landscape = True
        AddHandler pd.PrintPage, AddressOf OnPrintPage
        preview.Document = pd
        preview.ShowDialog()
        Me.Close()
    End Sub

    Private Sub OnPrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        Me.CenterToScreen()
        Using bmp As Bitmap = New Bitmap(Me.Width, Me.Height)
            Me.DrawToBitmap(bmp, New Rectangle(0, 0, Me.Width, Me.Height))
            Dim ratio As Single = CSng(bmp.Width / bmp.Height)
            If ratio > e.MarginBounds.Width / e.MarginBounds.Height Then
                e.Graphics.DrawImage(bmp,
                e.MarginBounds.Left,
                CInt(e.MarginBounds.Top + (e.MarginBounds.Height / 2) - ((e.MarginBounds.Width / ratio) / 2)),
                e.MarginBounds.Width,
                CInt(e.MarginBounds.Width / ratio))
            Else
                e.Graphics.DrawImage(bmp,
                CInt(e.MarginBounds.Left + (e.MarginBounds.Width / 2) - (e.MarginBounds.Height * ratio / 2)),
                e.MarginBounds.Top,
                CInt(e.MarginBounds.Height * ratio),
                e.MarginBounds.Height)
            End If
        End Using
    End Sub

    Private Sub PrintDocument1_BeginPrint(sender As Object, e As PrintEventArgs) Handles PrintDocument1.BeginPrint
        Me.CenterToScreen()
        MsgBox("begin print called")
    End Sub

    Private Sub PrintDocument1_EndPrint(sender As Object, e As PrintEventArgs) Handles PrintDocument1.EndPrint
        Me.CenterToScreen()
        MsgBox("end print called")
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Me.CenterToScreen()
        MsgBox("print page called")
    End Sub

    Private Sub m_PrintDocument_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles mPrintDocument.PrintPage
        Me.CenterToScreen()
        Dim lWidth As Integer = e.MarginBounds.X + (e.MarginBounds.Width - mPrintBitMap.Width) \ 2
        Dim lHeight As Integer = e.MarginBounds.Y + (e.MarginBounds.Height - mPrintBitMap.Height) \ 2
        e.Graphics.DrawImage(mPrintBitMap, lWidth, lHeight)
        e.HasMorePages = False
    End Sub

    Private Sub PrintDocument1_QueryPageSettings(sender As Object, e As QueryPageSettingsEventArgs) Handles PrintDocument1.QueryPageSettings
        Me.CenterToScreen()
        MsgBox("query page set called")
    End Sub
End Class