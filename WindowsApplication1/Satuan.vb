Public Class Satuan
    Dim SQL As String
    Dim Proses As New Koneksi
    Dim tblSatuan As DataTable

    Sub Data_Record()
        tblSatuan = Proses.ExecuteQuery("Select * From TblSatuan order by no asc")
        DGSatuan.DataSource = tblSatuan
        DGSatuan.Columns(1).Width = 130
    End Sub

    Sub Kode_Otomatis()
        tblSatuan = Proses.ExecuteQuery("Select * From TblSatuan order by No desc")
        If tblSatuan.Rows.Count = 0 Then
            txtKodeSatuan.Text = "1"
        Else
            With tblSatuan.Rows(0)
                txtKodeSatuan.Text = .Item("No")
            End With
            txtKodeSatuan.Text = Val(txtKodeSatuan.Text) + 1
        End If
    End Sub

    Sub Bersih()
        Call Kode_Otomatis()
        Call Data_Record()
        BtnSimpan.Enabled = True
        BtnUbah.Enabled = False
        BtnHapus.Enabled = False
        txtKodeSatuan.Enabled = False
        txtSatuan.Text = ""
        txtSatuan.Focus()
    End Sub

    Private Sub Satuan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Bersih()
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        If txtSatuan.Text = "" Then
            txtSatuan.Focus()
            Exit Sub
        End If
        SQL = "Insert Into TblSatuan values ('" & txtKodeSatuan.Text & "','" & txtSatuan.Text & "')"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data Baru telah disimpan..!!", "Penyimpanan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub

    Private Sub BtnUbah_Click(sender As Object, e As EventArgs) Handles BtnUbah.Click
        If txtSatuan.Text = "" Then
            txtSatuan.Focus()
            Exit Sub
        End If
        SQL = "Update TblSatuan set Satuan = '" & txtSatuan.Text & "' Where No = '" & txtKodeSatuan.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data berhasil diubah..!!", "Perubahan Data Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        SQL = "Delete from TblSatuan Where No = '" & txtKodeSatuan.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data berhasil dihapus..!!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub


    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Call Bersih()
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub

    Private Sub DGSatuan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGSatuan.CellClick
        Dim i As Integer
        With DGSatuan
            If e.RowIndex >= 0 Then
                i = .CurrentRow.Index
                txtKodeSatuan.Text = .Rows(i).Cells("No").Value.ToString
                txtSatuan.Text = .Rows(i).Cells("Satuan").Value.ToString
                BtnUbah.Enabled = True
                BtnHapus.Enabled = True
                BtnSimpan.Enabled = False
            End If
        End With
    End Sub
End Class