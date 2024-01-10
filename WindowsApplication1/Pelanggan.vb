Public Class Pelanggan
    Dim SQL As String
    Dim Proses As New Koneksi
    Dim tblPelanggan As DataTable

    Sub Data_Record()
        tblPelanggan = Proses.ExecuteQuery("Select * From VwPelanggan order by kode_pelanggan asc")
        DGPelanggan.DataSource = tblPelanggan
    End Sub

    Sub Jenis_Kelamin()
        tblPelanggan = Proses.ExecuteQuery("Select * From TblJenis_Kelamin order by Id_Jenkel asc")
        If tblPelanggan.Rows.Count = 0 Then
        Else
            cmbJenisKelamin.Items.Clear()
            With tblPelanggan.Columns(1)
                For a = 0 To tblPelanggan.Rows.Count - 1
                    cmbJenisKelamin.Items.Add("" & .Table.Rows(a).Item(0) & " - " & .Table.Rows(a).Item(1) & "")
                Next a
            End With
        End If
    End Sub

    Sub Kode_Otomatis()
        tblPelanggan = Proses.ExecuteQuery("Select * From TblPelanggan order by kode_pelanggan desc")
        If tblPelanggan.Rows.Count = 0 Then
            txtKodePelanggan.Text = "KP-001"
        Else
            With tblPelanggan.Rows(0)
                txtKodePelanggan.Text = .Item("kode_pelanggan")
                txtKodePelanggan.Focus()
            End With
            txtKodePelanggan.Text = Val(Microsoft.VisualBasic.Mid(txtKodePelanggan.Text, 4, 3)) + 1
            If Len(txtKodePelanggan.Text) = 1 Then
                txtKodePelanggan.Text = "KP-00" & txtKodePelanggan.Text & ""
            ElseIf Len(txtKodePelanggan.Text) = 2 Then
                txtKodePelanggan.Text = "KP-0" & txtKodePelanggan.Text & ""
            ElseIf Len(txtKodePelanggan.Text) = 3 Then
                txtKodePelanggan.Text = "KP-" & txtKodePelanggan.Text & ""
            End If
        End If
    End Sub

    Sub Bersih()
        txtKodePelanggan.Enabled = False
        txtNamaPelanggan.Text = ""
        txtAlamat.Text = ""
        txtTelepon.Text = ""
        cmbJenisKelamin.Text = ""
        txtNamaPelanggan.Focus()
        Call Kode_Otomatis()
        Call Data_Record()
        Call Jenis_Kelamin()
        btnSimpan.Enabled = True
        btnUbah.Enabled = False
        btnHapus.Enabled = False
    End Sub

    Private Sub Supplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        Call Bersih()
    End Sub

    Private Sub txtCariData_TextChanged(sender As Object, e As EventArgs) Handles txtCariData.TextChanged
        If CariKdPelanggan.Checked = True Then
            tblPelanggan = Proses.ExecuteQuery("Select * From TblPelanggan where Kode_Pelanggan Like '%" & txtCariData.Text & "%'")
            If tblPelanggan.Rows.Count = 0 Then
                DGPelanggan.DataSource = tblPelanggan
                txtCariData.Focus()
            Else
                DGPelanggan.DataSource = tblPelanggan
            End If
        ElseIf CariNmPelanggan.Checked = True Then
            tblPelanggan = Proses.ExecuteQuery("Select * From TblPelanggan where Nama_Pelanggan Like '%" & txtCariData.Text & "%'")
            If tblPelanggan.Rows.Count = 0 Then
                DGPelanggan.DataSource = tblPelanggan
                txtCariData.Focus()
            Else
                DGPelanggan.DataSource = tblPelanggan
            End If
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtNamaPelanggan.Text = "" Then
            txtNamaPelanggan.Focus()
            Exit Sub
        End If
        If txtAlamat.Text = "" Then
            txtAlamat.Focus()
            Exit Sub
        End If
        If txtTelepon.Text = "" Then
            txtTelepon.Focus()
            Exit Sub
        End If
        SQL = "Insert Into TblPelanggan values ('" & txtKodePelanggan.Text & "','" & txtNamaPelanggan.Text & "','" & cmbJenisKelamin.Text(0) & "','" & txtAlamat.Text & "','" & txtTelepon.Text & "')"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data Baru telah disimpan..!!", "Penyimpanan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If txtNamaPelanggan.Text = "" Then
            txtNamaPelanggan.Focus()
            Exit Sub
        End If
        If txtAlamat.Text = "" Then
            txtAlamat.Focus()
            Exit Sub
        End If
        If txtTelepon.Text = "" Then
            txtTelepon.Focus()
            Exit Sub
        End If
        SQL = "Update TblPelanggan set Nama_Pelanggan = '" & txtNamaPelanggan.Text & "',Jenis_Kelamin = '" & cmbJenisKelamin.Text(0) & "',Alamat = '" & txtAlamat.Text & "',Telepon = '" & txtTelepon.Text & "'Where Kode_Pelanggan = '" & txtKodePelanggan.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data Berhasil dirubah..!!", "Perubahan Data Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Call Bersih()
        txtKodePelanggan.Focus()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        SQL = "Delete From TblPelanggan Where Kode_Pelanggan = '" & txtKodePelanggan.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data telah dihapus..!!", "Penghapusan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub

    Private Sub DGPelanggan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGPelanggan.CellClick
        Dim i As Integer
        With DGPelanggan
            If e.RowIndex >= 0 Then
                i = .CurrentRow.Index
                txtKodePelanggan.Text = .Rows(i).Cells("Kode_Pelanggan").Value.ToString
                txtNamaPelanggan.Text = .Rows(i).Cells("Nama_Pelanggan").Value.ToString
                txtAlamat.Text = .Rows(i).Cells("Alamat").Value.ToString
                txtTelepon.Text = .Rows(i).Cells("Telepon").Value.ToString
                If .Rows(i).Cells("Jenis_Kelamin").Value.ToString = "Laki-Laki" Then
                    cmbJenisKelamin.Text = "1 - Laki-Laki"
                ElseIf .Rows(i).Cells("Jenis_Kelamin").Value.ToString = "Perempuan" Then
                    cmbJenisKelamin.Text = "2 - Perempuan"
                End If
                btnUbah.Enabled = True
                btnHapus.Enabled = True
                btnSimpan.Enabled = False
            End If
        End With
    End Sub
End Class