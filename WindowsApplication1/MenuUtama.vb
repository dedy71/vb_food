Public Class MenuUtama
    Dim SQL As String
    Dim Proses As New Koneksi
    Dim tblHakAkses As DataTable

    Sub Hak_Akses()
        tblHakAkses = Proses.ExecuteQuery("Select * From TblHakAkses Where level ='" & TsLevel.Text & "'")
        If tblHakAkses.Rows.Count = 0 Then
            PenggunaToolStripMenuItem.Enabled = False
            HakAksesToolStripMenuItem.Enabled = False
            JenisObatToolStripMenuItem.Enabled = False
            SatuanToolStripMenuItem.Enabled = False
            ObatToolStripMenuItem.Enabled = False
            SupplierToolStripMenuItem.Enabled = False
            PelangganToolStripMenuItem.Enabled = False
            PembelianToolStripMenuItem.Enabled = False
            PenjualanToolStripMenuItem.Enabled = False
            SupplierToolStripMenuItem1.Enabled = False
            PelangganToolStripMenuItem1.Enabled = False
            ObatToolStripMenuItem1.Enabled = False
            PembelianToolStripMenuItem1.Enabled = False
            PenjualanToolStripMenuItem1.Enabled = False
        Else
            With tblHakAkses.Rows(0)
                PenggunaToolStripMenuItem.Enabled = .Item("pengguna")
                HakAksesToolStripMenuItem.Enabled = .Item("hakakses")
                JenisObatToolStripMenuItem.Enabled = .Item("jenis_Obat")
                SatuanToolStripMenuItem.Enabled = .Item("satuan")
                ObatToolStripMenuItem.Enabled = .Item("Obat")
                SupplierToolStripMenuItem.Enabled = .Item("supplier")
                PelangganToolStripMenuItem.Enabled = .Item("pelanggan")
                PembelianToolStripMenuItem.Enabled = .Item("pembelian")
                PenjualanToolStripMenuItem.Enabled = .Item("penjualan")
                SupplierToolStripMenuItem1.Enabled = .Item("lprsupplier")
                PelangganToolStripMenuItem1.Enabled = .Item("lprpelanggan")
                ObatToolStripMenuItem1.Enabled = .Item("lprObat")
                PembelianToolStripMenuItem1.Enabled = .Item("lprpembelian")
                PenjualanToolStripMenuItem1.Enabled = .Item("lprpenjualan")
            End With
        End If
    End Sub
    Private Sub Jam_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Jam.Tick
        TsJam.Text = Format(Now, "hh:mm:ss")
    End Sub

    Private Sub PenggunaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenggunaToolStripMenuItem.Click
        Pengguna.Show()
    End Sub

    Private Sub MenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Hak_Akses()
        TsTanggal.Text = Format(Now, "dddd, dd/MM/yyyy")
    End Sub

    Private Sub JenisObatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JenisObatToolStripMenuItem.Click
        JenisObat.MdiParent = Me
        JenisObat.Show()
    End Sub

    Private Sub SatuanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SatuanToolStripMenuItem.Click
        Satuan.MdiParent = Me
        Satuan.Show()
    End Sub

    Private Sub ObatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ObatToolStripMenuItem.Click
        Obat.MdiParent = Me
        Obat.Show()
    End Sub

    Private Sub SupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupplierToolStripMenuItem.Click
        Supplier.MdiParent = Me
        Supplier.Show()
    End Sub

    Private Sub PelangganToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PelangganToolStripMenuItem.Click
        Pelanggan.MdiParent = Me
        Pelanggan.Show()
    End Sub

    Private Sub PembelianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PembelianToolStripMenuItem.Click
        Pembelian.MdiParent = Me
        Pembelian.Show()
    End Sub

    Private Sub PenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenjualanToolStripMenuItem.Click
        Pembelian.MdiParent = Me
        Penjualan.Show()
    End Sub

    Private Sub SupplierToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SupplierToolStripMenuItem1.Click
        LprSupplier.Show()
    End Sub

    Private Sub PelangganToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PelangganToolStripMenuItem1.Click
        LprPelanggan.Show()
    End Sub

    Private Sub ObatToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ObatToolStripMenuItem1.Click
        LprObat.Show()
    End Sub

    Private Sub UbahPasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UbahPasswordToolStripMenuItem.Click
        UbahPassword.MdiParent = Me
        UbahPassword.Show()
    End Sub

    Private Sub HakAksesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HakAksesToolStripMenuItem.Click
        HakAkses.ShowDialog()
    End Sub

    Private Sub PenjualanToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PenjualanToolStripMenuItem1.Click

    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        End
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub PembelianToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PembelianToolStripMenuItem1.Click
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
