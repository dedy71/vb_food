Public Class Pembelian
    Dim SQL As String
    Dim Proses As New Koneksi
    Dim tblBeli As DataTable

    Sub Data_Record()
        tblBeli = Proses.ExecuteQuery("Select TblPembelian_Rinci.No, TblPembelian_Rinci.Kode_Obat,tblObat.Nama_Obat, TblPembelian_Rinci.Harga_Beli,TblPembelian_Rinci.Jumlah, TblPembelian_Rinci.Sub_Total From TblPembelian_Rinci Inner Join tblObat on TblPembelian_Rinci.kode_Obat = tblObat.Kode_Obat Where TblPembelian_Rinci.Faktur_Pembelian = '" & LblFaktur.Text & "' order by TblPembelian_Rinci.no asc")
        DGPembelian.DataSource = tblBeli
        DGPembelian.Columns(0).Width = 50
        DGPembelian.Columns(1).Width = 98
        DGPembelian.Columns(2).Width = 150
        DGPembelian.Columns(4).Width = 50
    End Sub

    Sub Supplier()
        tblBeli = Proses.ExecuteQuery("Select * From TblSupplier order by Kode_Supplier asc")
        If tblBeli.Rows.Count = 0 Then
        Else
            CmbSupplier.Items.Clear()
            With tblBeli.Columns(1)
                For a = 0 To tblBeli.Rows.Count - 1
                    CmbSupplier.Items.Add("" & .Table.Rows(a).Item(0) & " - " & .Table.Rows(a).Item(1) & "")
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
        tblBeli = Proses.ExecuteQuery("Select * From TblPembelian order by Faktur_Pembelian desc")
        If tblBeli.Rows.Count = 0 Then
            LblFaktur.Text = "0001"
        Else
            With tblBeli.Rows(0)
                LblFaktur.Text = .Item("Faktur_Pembelian")
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
        CmbSupplier.Enabled = True
        CmbObat.Enabled = True
        CmbObat.Focus()
        Call Supplier()
        Call Obat()
        Call Faktur_Otomatis()
        Call Data_Record()
        On Error Resume Next
        Dim Total_Seluruh As Single
        Dim i As Integer
        If DGPembelian.RowCount > 1 Then
            i = DGPembelian.CurrentRow.Index
            For i = 0 To DGPembelian.Rows.Count - 1
                Total_Seluruh = Val(Total_Seluruh) + Val(DGPembelian.Item(5, i).Value)
            Next
            LblTotalHargaKotor.Text = Total_Seluruh.ToString("#,#")
        End If
    End Sub

    Private Sub Pembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Bersih()
        btnSimpan.Enabled = False
    End Sub

    Private Sub CmbSupplier_TextChanged(sender As Object, e As EventArgs) Handles CmbSupplier.TextChanged
        tblBeli = Proses.ExecuteQuery("Select * From TblSupplier where Kode_Supplier ='" & Mid(CmbSupplier.Text, 1, 6) & "'")
        If tblBeli.Rows.Count = 0 Then
        Else
            LblNmSupplier.Text = tblBeli.Rows(0).Item("Nama_Supplier")
        End If
    End Sub

    Private Sub CmbSupplier_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbSupplier.KeyPress
        e.KeyChar = Chr(0)
    End Sub

    Private Sub CmbObat_TextChanged(sender As Object, e As EventArgs) Handles CmbObat.TextChanged
        tblBeli = Proses.ExecuteQuery("Select * From TblObat where Kode_Obat ='" & Mid(CmbObat.Text, 1, 6) & "'")
        If tblBeli.Rows.Count = 0 Then
        Else
            LblNamaObat.Text = tblBeli.Rows(0).Item("Nama_Obat")
            LblHarga.Text = tblBeli.Rows(0).Item("Harga_Beli")
            LblStock.Text = tblBeli.Rows(0).Item("Stock")
            TxtJumlah.Focus()
        End If
    End Sub

    Private Sub CmbObat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbObat.KeyPress
        e.KeyChar = Chr(0)
    End Sub

    Private Sub TxtJumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtJumlah.KeyPress
        Select Case e.KeyChar
            Case Chr(47) To Chr(57)
                TxtJumlah.Focus()
            Case Chr(8)
                e.KeyChar = Chr(8)
            Case Chr(13)
                tblBeli = Proses.ExecuteQuery("Select * From TblPembelian_Rinci where Faktur_Pembelian ='" & LblFaktur.Text & "' and Kode_Obat ='" &
                Mid(CmbObat.Text, 1, 6) & "'")
                If tblBeli.Rows.Count = 0 Then
                    Dim Total = Val(LblHarga.Text) * Val(TxtJumlah.Text)
                    SQL = "Insert Into TblPembelian_Rinci values ('" & LblFaktur.Text & "','" & DGPembelian.RowCount & "','" & Mid(CmbObat.Text, 1, 6) & "','" &
                    Val(LblHarga.Text) & "','" & TxtJumlah.Text & "','" & Total & "')"
                    Proses.ExecuteNonQuery(SQL)
                    btnSimpan.Enabled = True
                Else
                    MsgBox("Proses pembelian tidak dapat dilakukan !")
                End If
                Call Bersih()
                Dim Total_Seluruh As Single
                Dim i As Integer
                i = DGPembelian.CurrentRow.Index
                For i = 0 To DGPembelian.Rows.Count - 1
                    Total_Seluruh = Val(Total_Seluruh) + Val(DGPembelian.Item(5, i).Value)
                Next
                LblTotalHargaKotor.Text = Total_Seluruh.ToString("#,#")
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
        SQL = "Insert Into TblPembelian values ('" & LblFaktur.Text & "','" & Format(Now, "yyyy/MM/dd") & "','" &
Microsoft.VisualBasic.Left(CmbSupplier.Text, 6) & "','" & TxtDiscount.Text & "','" & Replace(LblTotalHargaBersih.Text, ".", "") & "')"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data Baru telah disimpan..!!", "Penyimpanan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
        CmbSupplier.Text = ""
        LblNmSupplier.Text = ""
        LblTotalHargaKotor.Text = ""
        CmbSupplier.Focus()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        On Error GoTo Keluar
        Dim i As Integer
        i = DGPembelian.CurrentRow.Index
        For i = 0 To DGPembelian.Rows.Count - 1
            tblBeli = Proses.ExecuteQuery("Select * From TblObat where Kode_Obat ='" & DGPembelian.Item(2, i).Value & "'")
            If tblBeli.Rows.Count = 0 Then
            Else
                Dim Jumlah = Val(tblBeli.Rows(0).Item("Stock")) - Val(DGPembelian.Item(4, i).Value)
                SQL = "Update TblObat set Stock ='" & CInt(Jumlah) & "' where Kode_Obat ='" & DGPembelian.Item(2, i).Value & "'"
                Proses.ExecuteNonQuery(SQL)
            End If
        Next
        SQL = "Delete From TblPembelian_Rinci where Faktur_Pembelian ='" & LblFaktur.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        Call Bersih()
Keluar:
    End Sub

    Private Sub DGPembelian_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGPembelian.CellClick

    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        Dim No = InputBox("Masukkan no faktur")
        If No = "" Then
            Exit Sub
        Else
            'FakturPembelian.CrystalReportViewer1.SelectionFormula = "{vw_pembelian.faktur_pembelian} Like '" + No + "'"
            'FakturPembelian.CrystalReportViewer1.RefreshReport()
            FakturPembelian.Show()
        End If
    End Sub
End Class