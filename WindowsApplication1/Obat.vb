Public Class Obat
    Dim SQL As String
    Dim Proses As New Koneksi
    Dim tblObat As DataTable

    Sub Data_Record()
        tblObat = Proses.ExecuteQuery("Select * From VwObat order by kode_Obat asc")
        DGObat.DataSource = tblObat
    End Sub
    Sub Jenis_Obat()
        tblObat = Proses.ExecuteQuery("Select * From TblJenis_Obat order by no asc")
        If tblObat.Rows.Count = 0 Then
        Else
            cmbJB.Items.Clear()
            With tblObat.Columns(1)
                For a = 0 To tblObat.Rows.Count - 1
                    cmbJB.Items.Add("" & .Table.Rows(a).Item(0) & " - " & .Table.Rows(a).Item(1) & "")
                Next a
            End With
        End If
    End Sub

    Sub Satuan()
        tblObat = Proses.ExecuteQuery("Select * From TblSatuan order by no asc")
        If tblObat.Rows.Count = 0 Then
        Else
            cmbSatuan.Items.Clear()
            With tblObat.Columns(1)
                For a = 0 To tblObat.Rows.Count - 1
                    cmbSatuan.Items.Add("" & .Table.Rows(a).Item(0) & " - " & .Table.Rows(a).Item(1) & "")
                Next a
            End With
        End If
    End Sub

    Sub Kode_Otomatis()
        tblObat = Proses.ExecuteQuery("Select * From TblObat order by kode_Obat desc")
        If tblObat.Rows.Count = 0 Then
            txtKodeObat.Text = "OB-001"
        Else
            With tblObat.Rows(0)
                txtKodeObat.Text = .Item("kode_Obat")
                txtKodeObat.Focus()
            End With
            txtKodeObat.Text = Val(Microsoft.VisualBasic.Mid(txtKodeObat.Text, 4, 3)) + 1
            If Len(txtKodeObat.Text) = 1 Then
                txtKodeObat.Text = "OB-00" & txtKodeObat.Text & ""
            ElseIf Len(txtKodeObat.Text) = 2 Then
                txtKodeObat.Text = "OB-0" & txtKodeObat.Text & ""
            ElseIf Len(txtKodeObat.Text) = 3 Then
                txtKodeObat.Text = "OB-" & txtKodeObat.Text & ""
            End If
        End If
    End Sub

    Sub Bersih()
        txtKodeObat.Enabled = False
        txtNamaObat.Text = ""
        cmbJB.Text = ""
        cmbSatuan.Text = ""
        txtHargaBeli.Text = ""
        txtHargaJual.Text = ""
        LblStock.Text = "0"
        DTTanggalExpired.ResetText()
        txtNamaObat.Focus()
        Call Kode_Otomatis()
        Call Data_Record()
        Call Jenis_Obat()
        Call Satuan()
        btnSimpan.Enabled = True
        btnUbah.Enabled = False
        btnHapus.Enabled = False
    End Sub

    Private Sub Obat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        Call Bersih()
    End Sub

    Private Sub txtHargaBeli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHargaBeli.KeyPress
        Select Case e.KeyChar
            Case Chr(47) To Chr(57)
                txtHargaBeli.Focus()
            Case Chr(8)
                e.KeyChar = Chr(8)
            Case Else
                e.KeyChar = Chr(0)
        End Select
    End Sub

    Private Sub txtHargaJual_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHargaJual.KeyPress
        Select Case e.KeyChar
            Case Chr(47) To Chr(57)
                txtHargaJual.Focus()
            Case Chr(8)
                e.KeyChar = Chr(8)
            Case Else
                e.KeyChar = Chr(0)
        End Select
    End Sub

    Private Sub txtCariData_TextChanged(sender As Object, e As EventArgs) Handles txtCariData.TextChanged
        If CariKdObat.Checked = True Then
            tblObat = Proses.ExecuteQuery("Select * From VwObat where Kode_Obat Like '%" & txtCariData.Text & "%'")
            If tblObat.Rows.Count = 0 Then
                DGObat.DataSource = tblObat
                txtCariData.Focus()
            Else
                DGObat.DataSource = tblObat
            End If
        ElseIf CariNmObat.Checked = True Then
            tblObat = Proses.ExecuteQuery("Select * From VwObat where Nama_Obat Like '%" & txtCariData.Text & "%'")
            If tblObat.Rows.Count = 0 Then
                DGObat.DataSource = tblObat
                txtCariData.Focus()
            Else
                DGObat.DataSource = tblObat
            End If
        ElseIf CariStock.Checked = True Then
            tblObat = Proses.ExecuteQuery("Select * From VwObat where Stock Like '%" & txtCariData.Text & "%'")
            If tblObat.Rows.Count = 0 Then
                DGObat.DataSource = tblObat
                txtCariData.Focus()
            Else
                DGObat.DataSource = tblObat
            End If
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtNamaObat.Text = "" Then
            txtNamaObat.Focus()
            Exit Sub
        End If
        If cmbJB.Text = "" Then
            cmbJB.Focus()
            Exit Sub
        End If
        If cmbSatuan.Text = "" Then
            cmbSatuan.Focus()
            Exit Sub
        End If
        If txtHargaBeli.Text = "" Then
            txtHargaBeli.Focus()
            Exit Sub
        End If
        If txtHargaJual.Text = "" Then
            txtHargaJual.Focus()
            Exit Sub
        End If
        SQL = "Insert Into TblObat (Kode_Obat, Nama_Obat, Jenis, Satuan, Tgl_Expired, Harga_Beli, Harga_Jual, Stock) values ('" & txtKodeObat.Text & "','" & txtNamaObat.Text & "','" & Val(cmbJB.Text) & "','" & Val(cmbSatuan.Text) & "','" & DTTanggalExpired.Value.ToString("yyyy-MM-dd") & "','" &
txtHargaBeli.Text & "','" & txtHargaJual.Text & "','" & LblStock.Text & "')"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data Baru telah disimpan..!!", "Penyimpanan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If txtNamaObat.Text = "" Then
            txtNamaObat.Focus()
            Exit Sub
        End If
        If cmbJB.Text = "" Then
            cmbJB.Focus()
            Exit Sub
        End If
        If cmbSatuan.Text = "" Then
            cmbSatuan.Focus()
            Exit Sub
        End If
        If txtHargaBeli.Text = "" Then
            txtHargaBeli.Focus()
            Exit Sub
        End If
        If txtHargaJual.Text = "" Then
            txtHargaJual.Focus()
            Exit Sub
        End If
        SQL = "Update TblObat set nama_Obat = '" & txtNamaObat.Text & "',Jenis = '" & Val(cmbJB.Text) & "',Satuan = '" & Val(cmbSatuan.Text) & "',Harga_Beli = '" & txtHargaBeli.Text & "',harga_Jual = '" & txtHargaJual.Text & "',Tgl_Expired = '" & DTTanggalExpired.Value.ToString("yyyy-MM-dd") & "',Stock = '" & LblStock.Text & "' Where Kode_Obat = '" & txtKodeObat.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data Berhasil dirubah..!!", "Perubahan Data Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Call Bersih()
        txtKodeObat.Focus()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        SQL = "Delete From TblObat Where Kode_Obat = '" & txtKodeObat.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data telah dihapus..!!", "Penghapusan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub

    Private Sub DGObat_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGObat.CellClick
        Dim i As Integer
        With DGObat
            If e.RowIndex >= 0 Then
                i = .CurrentRow.Index
                txtKodeObat.Text = .Rows(i).Cells("Kode_Obat").Value.ToString
                txtNamaObat.Text = .Rows(i).Cells("Nama_Obat").Value.ToString
                txtHargaBeli.Text = .Rows(i).Cells("Harga_Beli").Value.ToString
                txtHargaJual.Text = .Rows(i).Cells("Harga_Jual").Value.ToString
                LblStock.Text = .Rows(i).Cells("Stock").Value.ToString
                btnUbah.Enabled = True
                btnHapus.Enabled = True
                btnSimpan.Enabled = False
            End If
        End With
    End Sub
End Class
