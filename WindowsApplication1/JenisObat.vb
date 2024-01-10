Public Class JenisObat
    Dim SQL As String
    Dim Proses As New Koneksi
    Dim tblJnsObat As DataTable

    Sub Data_Record()
        tblJnsObat = Proses.ExecuteQuery("Select * From TblJenis_Obat order by no asc")
        DGJenisObat.DataSource = tblJnsObat
        DGJenisObat.Columns(1).Width = 130
    End Sub

    Sub Kode_Otomatis()
        tblJnsObat = Proses.ExecuteQuery("Select * From TblJenis_Obat order by No desc")
        If tblJnsObat.Rows.Count = 0 Then
            txtKodeJenis.Text = "1"
        Else
            With tblJnsObat.Rows(0)
                txtKodeJenis.Text = .Item("No")
            End With
            txtKodeJenis.Text = Val(txtKodeJenis.Text) + 1
        End If
    End Sub

    Sub Bersih()
        Call Kode_Otomatis()
        Call Data_Record()
        BtnSimpan.Enabled = True
        BtnUbah.Enabled = False
        BtnHapus.Enabled = False
        txtKodeJenis.Enabled = False
        txtJenisObat.Text = ""
        txtJenisObat.Focus()
    End Sub

    Private Sub JenisObat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Bersih()
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        If txtJenisObat.Text = "" Then
            txtJenisObat.Focus()
            Exit Sub
        End If
        SQL = "Insert Into TblJenis_Obat values ('" & txtKodeJenis.Text & "','" & txtJenisObat.Text & "')"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data Baru telah disimpan..!!", "Penyimpanan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub

    Private Sub BtnUbah_Click(sender As Object, e As EventArgs) Handles BtnUbah.Click
        If txtJenisObat.Text = "" Then
            txtJenisObat.Focus()
            Exit Sub
        End If
        SQL = "Update TblJenis_Obat set Jenis = '" & txtJenisObat.Text & "' Where No = '" & txtKodeJenis.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data berhasil diubah..!!", "Perubahan Data Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Call Bersih()
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        SQL = "Delete from TblJenis_Obat Where No = '" & txtKodeJenis.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data berhasil dihapus..!!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub

    Private Sub DGJenisObat_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGJenisObat.CellClick
        Dim i As Integer
        With DGJenisObat
            If e.RowIndex >= 0 Then
                i = .CurrentRow.Index
                txtKodeJenis.Text = .Rows(i).Cells("No").Value.ToString
                txtJenisObat.Text = .Rows(i).Cells("Jenis").Value.ToString
                BtnUbah.Enabled = True
                BtnHapus.Enabled = True
                BtnSimpan.Enabled = False
            End If
        End With
    End Sub
End Class