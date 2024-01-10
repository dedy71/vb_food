Public Class Penjualan
    Dim SQL As String
    Dim Proses As New Koneksi
    Dim tblJual As DataTable
    Dim tblBeli As DataTable

    Sub Data_Record()
        tblJual = Proses.ExecuteQuery("Select tblPenjualan_rinci.No, tblPenjualan_rinci.Kode_Obat,tblObat.Nama_Obat, tblPenjualan_rinci.Harga_Jual,tblPenjualan_rinci.Jumlah, tblPenjualan_rinci.Sub_Total From tblPenjualan_rinci Inner Join tblObat on tblPenjualan_rinci.kode_Obat = tblObat.Kode_Obat Where tblPenjualan_rinci.Faktur_Penjualan = '" & LblFaktur.Text & "' order by tblPenjualan_rinci.no asc")
        DGPenjualan.DataSource = tblJual
        DGPenjualan.Columns(0).Width = 50
        DGPenjualan.Columns(1).Width = 98
        DGPenjualan.Columns(2).Width = 150
        DGPenjualan.Columns(4).Width = 50
    End Sub

    Sub Pelanggan()
        tblJual = Proses.ExecuteQuery("Select * From TblPelanggan order by Kode_Pelanggan asc")
        If tblJual.Rows.Count = 0 Then
        Else
            CmbPelanggan.Items.Clear()
            With tblJual.Columns(1)
                For a = 0 To tblJual.Rows.Count - 1
                    CmbPelanggan.Items.Add("" & .Table.Rows(a).Item(0) & " - " & .Table.Rows(a).Item(1) & "")
                Next a
            End With
        End If
    End Sub

    Sub Obat()
        tblBeli = Proses.ExecuteQuery("Select * From TblObat order by Kode_Obat asc")
        If tblBeli.Rows.Count = 0 Then
        Else
            CmbObat.Items.Clear()
            With tblBeli.Columns(1)
                For a = 0 To tblBeli.Rows.Count - 1
                    CmbObat.Items.Add("" & .Table.Rows(a).Item(0) & " - " & .Table.Rows(a).Item(1) & "")
                Next a
            End With
        End If
    End Sub

    Sub Faktur_Otomatis()
        tblJual = Proses.ExecuteQuery("Select * From TblPenjualan order by faktur_Penjualan desc")
        If tblJual.Rows.Count = 0 Then
            LblFaktur.Text = "0001"
        Else
            With tblJual.Rows(0)
                LblFaktur.Text = .Item("faktur_Penjualan")
            End With
            LblFaktur.Text = Val(LblFaktur.Text) + 1
            If Len(LblFaktur.Text) = 1 Then
                LblFaktur.Text = "000" & LblFaktur.Text & ""
            ElseIf Len(LblFaktur.Text) = 2 Then
                LblFaktur.Text = "00" & LblFaktur.Text & ""
            ElseIf Len(LblFaktur.Text) = 3 Then
                LblFaktur.Text = "0" & LblFaktur.Text & ""
            ElseIf Len(LblFaktur.Text) = 4 Then
                LblFaktur.Text = "" & LblFaktur.Text & ""
            End If
        End If
    End Sub

    Sub Bersih()
        CmbObat.Text = ""
        LblNamaObat.Text = ""
        LblHarga.Text = ""
        LblStock.Text = ""
        TxtJumlah.Text = ""
        TxtDiscount.Text = ""
        LblTotalHargaKotor.Text = "Rp,"
        LblTotalHargaBersih.Text = ""
        LblTotalHarga.Text = ""
        CmbPelanggan.Enabled = True
        CmbObat.Enabled = True
        CmbObat.Focus()
        Call Pelanggan()
        Call Obat()
        Call Faktur_Otomatis()
        Call Data_Record()
        On Error Resume Next
        Dim Total_Seluruh As Single
        Dim i As Integer
        If DGPenjualan.RowCount > 1 Then
            i = DGPenjualan.CurrentRow.Index
            For i = 0 To DGPenjualan.Rows.Count - 1
                Total_Seluruh = Val(Total_Seluruh) + Val(DGPenjualan.Item(5, i).Value)
            Next
            LblTotalHargaKotor.Text = Total_Seluruh.ToString("#,#")
            LblTotalHarga.Text = LblTotalHargaKotor.Text
        End If
    End Sub

    Private Sub Penjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Bersih()
        btnSimpan.Enabled = False
    End Sub

    Private Sub CmbPelanggan_TextChanged(sender As Object, e As EventArgs) Handles CmbPelanggan.TextChanged
        tblJual = Proses.ExecuteQuery("Select * From TblPelanggan where Kode_Pelanggan ='" & Mid(CmbPelanggan.Text, 1, 6) & "'")
        If tblJual.Rows.Count = 0 Then
        Else
            LblNmPelanggan.Text = tblJual.Rows(0).Item("Nama_Pelanggan")
        End If
    End Sub

    Private Sub CmbPelanggan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbPelanggan.KeyPress
        e.KeyChar = Chr(0)
    End Sub

    Private Sub CmbObat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbObat.KeyPress
        e.KeyChar = Chr(0)
    End Sub

    Private Sub CmbObat_TextChanged(sender As Object, e As EventArgs) Handles CmbObat.TextChanged
        tblBeli = Proses.ExecuteQuery("Select * From TblObat where Kode_Obat ='" & Mid(CmbObat.Text, 1, 6) & "'")
        If tblBeli.Rows.Count = 0 Then
        Else
            LblNamaObat.Text = tblBeli.Rows(0).Item("Nama_Obat")
            LblHarga.Text = tblBeli.Rows(0).Item("Harga_Jual")
            LblStock.Text = tblBeli.Rows(0).Item("Stock")
            TxtJumlah.Focus()
        End If
    End Sub

    Private Sub TxtJumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtJumlah.KeyPress
        Select Case e.KeyChar
            Case Chr(47) To Chr(57)
                TxtJumlah.Focus()
            Case Chr(8)
                e.KeyChar = Chr(8)
            Case Chr(13)
                tblJual = Proses.ExecuteQuery("Select * From TblPenjualan_Rinci where Faktur_Penjualan ='" & LblFaktur.Text & "' and Kode_Obat ='" &
                Mid(CmbObat.Text, 1, 6) & "'")
                If tblJual.Rows.Count = 0 Then
                    Dim Total = Val(LblHarga.Text) * Val(TxtJumlah.Text)
                    SQL = "Insert Into TblPenjualan_Rinci values ('" & LblFaktur.Text & "','" & DGPenjualan.RowCount & "','" & Mid(CmbObat.Text, 1, 6) & "','" &
                    Val(LblHarga.Text) & "','" & TxtJumlah.Text & "','" & Total & "')"
                    Proses.ExecuteNonQuery(SQL)
                    btnSimpan.Enabled = True
                Else
                    MsgBox("Proses Penjualan tidak dapat dilakukan !")
                End If
                Call Bersih()
                Dim Total_Seluruh As Single
                Dim i As Integer
                i = DGPenjualan.CurrentRow.Index
                For i = 0 To DGPenjualan.Rows.Count - 1
                    Total_Seluruh = Val(Total_Seluruh) + Val(DGPenjualan.Item(5, i).Value)
                Next
                LblTotalHargaKotor.Text = Total_Seluruh.ToString("#,#")
                LblTotalHarga.Text = LblTotalHargaKotor.Text
            Case Else
                e.KeyChar = Chr(0)
        End Select
    End Sub

    Private Sub TxtDiscount_TextChanged(sender As Object, e As EventArgs) Handles TxtDiscount.TextChanged
        If TxtDiscount.Text = "" Then
            TxtDiscount.Text = "0"
        End If
        Dim Disc As Single
        Disc = (Val(Replace(LblTotalHargaKotor.Text, ".", "") * TxtDiscount.Text)) / 100
        LblTotalHargaBersih.Text = (Val(Replace(LblTotalHargaKotor.Text, ".", "")) - Val(Disc)).ToString("#,#")
    End Sub

    Private Sub LblTotalHargaBersih_TextChanged(sender As Object, e As EventArgs) Handles LblTotalHargaBersih.TextChanged
        If LblTotalHargaBersih.Text = "" Then
            LblTotalHargaBersih.Text = "0"
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If LblTotalHargaKotor.Text = "" Then
            Exit Sub
        End If
        If TxtDiscount.Text = "" Then
            TxtDiscount.Text = "0"
        End If
        SQL = "Insert Into TblPenjualan values ('" & LblFaktur.Text & "','" & Format(Now, "yyyy/MM/dd") & "','" & Microsoft.VisualBasic.Left(CmbPelanggan.Text, 6) & "','" & TxtDiscount.Text & "','" & Replace(LblTotalHargaBersih.Text, ".", "") & "')"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data Baru telah disimpan..!!", "Penyimpanan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
        CmbPelanggan.Text = ""
        LblNmPelanggan.Text = ""
        LblTotalHargaKotor.Text = ""
        CmbPelanggan.Focus()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        On Error GoTo Keluar
        Dim i As Integer
        i = DGPenjualan.CurrentRow.Index
        For i = 0 To DGPenjualan.Rows.Count - 1
            tblJual = Proses.ExecuteQuery("Select * From TblObat where Kode_Obat ='" & DGPenjualan.Item(2, i).Value & "'")
            If tblJual.Rows.Count = 0 Then
            Else
                Dim Jumlah = Val(tblJual.Rows(0).Item("Stock")) - Val(DGPenjualan.Item(4, i).Value)
                SQL = "Update TblObat set Stock ='" & CInt(Jumlah) & "' where Kode_Obat ='" & DGPenjualan.Item(2, i).Value & "'"
                Proses.ExecuteNonQuery(SQL)
            End If
        Next
        SQL = "Delete From TblPenjualan_Rinci where Faktur_Penjualan ='" & LblFaktur.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        Call Bersih()
        Exit Sub ' Jika semuanya berhasil, keluar dari sub sebelum blok error handling
Keluar:
        MsgBox("Terjadi kesalahan: " & Err.Description, MsgBoxStyle.Critical, "Kesalahan")
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        Dim No = InputBox("Masukkan no faktur")
        If No = "" Then
            Exit Sub
        Else
            'FakturPenjualan.CrystalReportViewer1.SelectionFormula = "{vw_penjualan.faktur_penjualan} Like '" + No + "'"
            'FakturPenjualan.CrystalReportViewer1.RefreshReport()
            FakturPenjualan.Show()
        End If
    End Sub
End Class