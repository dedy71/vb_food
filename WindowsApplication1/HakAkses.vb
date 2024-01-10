Public Class HakAkses
    Dim SQL As String
    Dim Proses As New Koneksi
    Dim tblHakAkses As DataTable

    Sub kosong()
        cmbLevel.Text = ""
        chkPengguna.Checked = False
        chkJenis.Checked = False
        chkSatuan.Checked = False
        chkObat.Checked = False
        chkSupplier.Checked = False
        chkPelanggan.Checked = False
        chkPembelian.Checked = False
        chkPenjualan.Checked = False
        chkLprSupplier.Checked = False
        chkLprPlgn.Checked = False
        chkLprObat.Checked = False
        chkLprPembelian.Checked = False
        chkLprPenjualan.Checked = False
        chkAkses.Checked = False
    End Sub

    Sub Hak_Akses()
        tblHakAkses = Proses.ExecuteQuery("Select * From TblHakAkses Where level ='" & cmbLevel.Text & "'")
        If tblHakAkses.Rows.Count = 0 Then
            Call kosong()
        Else
            With tblHakAkses.Rows(0)
                chkPengguna.Checked = .Item("pengguna")
                chkJenis.Checked = .Item("jenis_Obat")
                chkSatuan.Checked = .Item("satuan")
                chkObat.Checked = .Item("Obat")
                chkSupplier.Checked = .Item("supplier")
                chkPelanggan.Checked = .Item("pelanggan")
                chkPembelian.Checked = .Item("pembelian")
                chkPenjualan.Checked = .Item("penjualan")
                chkLprSupplier.Checked = .Item("lprsupplier")
                chkLprPlgn.Checked = .Item("lprpelanggan")
                chkLprObat.Checked = .Item("lprObat")
                chkLprPembelian.Checked = .Item("lprpembelian")
                chkLprPenjualan.Checked = .Item("lprpenjualan")
                chkAkses.Checked = .Item("hakakses")
            End With
        End If
    End Sub

    Private Sub HakAkses_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Call Hak_Akses()
    End Sub

    Private Sub HakAkses_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbLevel.Items.Add("ADMIN")
        cmbLevel.Items.Add("OPERATOR")
    End Sub

    Private Sub OkBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If cmbLevel.Text = "" Then Exit Sub

        tblHakAkses = Proses.ExecuteQuery("Select * From TblHakAkses Where level ='" & cmbLevel.Text & "'")
        If tblHakAkses.Rows.Count = 0 Then
            SQL = "Insert Into Tblhakakses Values ('" & cmbLevel.Text & "','" &
            CInt(chkPengguna.Checked) * -1 & "','" & CInt(chkJenis.Checked) * -1 & "','" &
            CInt(chkSatuan.Checked) * -1 & "','" & CInt(chkObat.Checked) * -1 & "','" &
            CInt(chkSupplier.Checked) * -1 & "','" & CInt(chkPelanggan.Checked) * -1 & "','" &
            CInt(chkPembelian.Checked) * -1 & "','" & CInt(chkPenjualan.Checked) * -1 & "','" &
            CInt(chkLprSupplier.Checked) * -1 & "','" & CInt(chkLprPlgn.Checked) * -1 & "','" &
            CInt(chkLprObat.Checked) * -1 & "','" & CInt(chkLprPembelian.Checked) * -1 & "','" &
            CInt(chkLprPenjualan.Checked) * -1 & "','" & CInt(chkAkses.Checked) * -1 & "')"
            Proses.ExecuteNonQuery(SQL)
            MessageBox.Show("Data Baru telah disimpan..!!", "Penyimpanan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            SQL = "Update Tblhakakses Set Pengguna = '" & CInt(chkPengguna.Checked) * -1 & "',jenis_Obat = '" &
            CInt(chkJenis.Checked) * -1 & "',satuan = '" & CInt(chkSatuan.Checked) * -1 & "', Obat = '" &
            CInt(chkObat.Checked) * -1 & "',supplier= '" & CInt(chkSupplier.Checked) * -1 & "',pelanggan = '" &
            CInt(chkPelanggan.Checked) * -1 & "',pembelian = '" & CInt(chkPembelian.Checked) * -1 & "',penjualan = '" &
            CInt(chkPenjualan.Checked) * -1 & "',LprSupplier ='" & CInt(chkLprSupplier.Checked) * -1 & "',LprPelanggan = '" &
            CInt(chkLprPlgn.Checked) * -1 & "',LprObat = '" & CInt(chkLprObat.Checked) * -1 & "',LprPembelian = '" &
            CInt(chkLprPembelian.Checked) * -1 & "',LprPenjualan = '" & CInt(chkLprPenjualan.Checked) * -1 &
            "',HakAkses = '" & CInt(chkAkses.Checked) * -1 & "' where Level = '" & cmbLevel.Text & "' "
            Proses.ExecuteNonQuery(SQL)
            MessageBox.Show("Data telah diubah..!!", "Penyimpanan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Call kosong()
    End Sub

    Private Sub CmbLevel_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbLevel.TextChanged
        Call Hak_Akses()
    End Sub

    Private Sub CmbLevel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLevel.SelectedIndexChanged

    End Sub
End Class