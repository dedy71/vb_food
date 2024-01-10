Public Class Supplier
    Dim SQL As String
    Dim Proses As New Koneksi
    Dim tblSupplier As DataTable

    Sub Data_Record()
        tblSupplier = Proses.ExecuteQuery("Select * From TblSupplier order by kode_supplier asc")
        DGSupplier.DataSource = tblSupplier
        DGSupplier.Columns(1).Width = 150
        DGSupplier.Columns(2).Width = 435
    End Sub

    Sub Kode_Otomatis()
        tblSupplier = Proses.ExecuteQuery("Select * From TblSupplier order by kode_supplier desc")
        If tblSupplier.Rows.Count = 0 Then
            txtKodeSupplier.Text = "KS-001"
        Else
            With tblSupplier.Rows(0)
                txtKodeSupplier.Text = .Item("kode_supplier")
                txtKodeSupplier.Focus()
            End With
            txtKodeSupplier.Text = Val(Microsoft.VisualBasic.Mid(txtKodeSupplier.Text, 4, 3)) + 1
            If Len(txtKodeSupplier.Text) = 1 Then
                txtKodeSupplier.Text = "KS-00" & txtKodeSupplier.Text & ""
            ElseIf Len(txtKodeSupplier.Text) = 2 Then
                txtKodeSupplier.Text = "KS-0" & txtKodeSupplier.Text & ""
            ElseIf Len(txtKodeSupplier.Text) = 3 Then
                txtKodeSupplier.Text = "KS-" & txtKodeSupplier.Text & ""
            End If
        End If
    End Sub

    Sub Bersih()
        txtKodeSupplier.Enabled = False
        txtNamaSupplier.Text = ""
        txtAlamat.Text = ""
        txtTelepon.Text = ""
        txtKontak.Text = ""
        txtNamaSupplier.Focus()
        Call Kode_Otomatis()
        Call Data_Record()
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
        If CariKdSupplier.Checked = True Then
            tblSupplier = Proses.ExecuteQuery("Select * From TblSupplier where Kode_Supplier Like '%" & txtCariData.Text & "%'")
            If tblSupplier.Rows.Count = 0 Then
                DGSupplier.DataSource = tblSupplier
                txtCariData.Focus()
            Else
                DGSupplier.DataSource = tblSupplier
            End If
        ElseIf CariNmSupplier.Checked = True Then
            tblSupplier = Proses.ExecuteQuery("Select * From TblSupplier where Nama_Supplier Like '%" & txtCariData.Text & "%'")
            If tblSupplier.Rows.Count = 0 Then
                DGSupplier.DataSource = tblSupplier
                txtCariData.Focus()
            Else
                DGSupplier.DataSource = tblSupplier
            End If
        ElseIf CariKontak.Checked = True Then
            tblSupplier = Proses.ExecuteQuery("Select * From TblSupplier where KOntak Like '%" & txtCariData.Text & "%'")
            If tblSupplier.Rows.Count = 0 Then
                DGSupplier.DataSource = tblSupplier
                txtCariData.Focus()
            Else
                DGSupplier.DataSource = tblSupplier
            End If
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtNamaSupplier.Text = "" Then
            txtNamaSupplier.Focus()
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
        If txtKontak.Text = "" Then
            txtKontak.Focus()
            Exit Sub
        End If
        SQL = "Insert Into TblSupplier values ('" & txtKodeSupplier.Text & "','" & txtNamaSupplier.Text & "','" & txtAlamat.Text & "','" & txtTelepon.Text & "','" &
        txtKontak.Text & "')"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data Baru telah disimpan..!!", "Penyimpanan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If txtNamaSupplier.Text = "" Then
            txtNamaSupplier.Focus()
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
        If txtKontak.Text = "" Then
            txtKontak.Focus()
            Exit Sub
        End If
        SQL = "Update TblSupplier set Nama_Supplier = '" & txtNamaSupplier.Text & "',Alamat = '" & txtAlamat.Text & "',Telepon = '" & txtTelepon.Text & "',Kontak ='" & txtKontak.Text & "' Where Kode_Supplier = '" & txtKodeSupplier.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data Berhasil dirubah..!!", "Perubahan Data Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Call Bersih()
        txtKodeSupplier.Focus()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        SQL = "Delete From TblSupplier Where Kode_Supplier = '" & txtKodeSupplier.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data telah dihapus..!!", "Penghapusan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub

    Private Sub DGSupplier_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGSupplier.CellClick
        Dim i As Integer
        With DGSupplier
            If e.RowIndex >= 0 Then
                i = .CurrentRow.Index
                txtKodeSupplier.Text = .Rows(i).Cells("Kode_Supplier").Value.ToString
                txtNamaSupplier.Text = .Rows(i).Cells("Nama_Supplier").Value.ToString
                txtAlamat.Text = .Rows(i).Cells("Alamat").Value.ToString
                txtTelepon.Text = .Rows(i).Cells("Telepon").Value.ToString
                txtKontak.Text = .Rows(i).Cells("Kontak").Value.ToString
                btnUbah.Enabled = True
                btnHapus.Enabled = True
                btnSimpan.Enabled = False
            End If
        End With
    End Sub
End Class