Public Class Pengguna
    Dim SQL As String
    Dim Proses As New Koneksi
    Dim tblPengguna As DataTable

    Sub Data_Record()
        tblPengguna = Proses.ExecuteQuery("Select * From TblPengguna")
        DgPengguna.DataSource = tblPengguna
        DgPengguna.Columns(1).Width = 200
        DgPengguna.Columns(2).Visible = False
    End Sub

    Sub Kode_Otomatis()
        tblPengguna = Proses.ExecuteQuery("Select * From TblPengguna order by kode_pengguna desc")
        If tblPengguna.Rows.Count = 0 Then
            txtKdPengguna.Text = "PGN-001"
        Else
            With tblPengguna.Rows(0)
                txtKdPengguna.Text = .Item("Kode_Pengguna")
                txtKdPengguna.Focus()
            End With
            txtKdPengguna.Text = Val(Microsoft.VisualBasic.Mid(txtKdPengguna.Text, 5, 3)) + 1
            If Len(txtKdPengguna.Text) = 1 Then
                txtKdPengguna.Text = "PGN-00" & txtKdPengguna.Text & ""
            ElseIf Len(txtKdPengguna.Text) = 2 Then
                txtKdPengguna.Text = "PGN-0" & txtKdPengguna.Text & ""
            ElseIf Len(txtKdPengguna.Text) = 3 Then
                txtKdPengguna.Text = "PGN-" & txtKdPengguna.Text & ""
            End If
        End If
    End Sub

    Sub Bersih()
        txtKdPengguna.Enabled = True
        txtKdPengguna.Text = ""
        txtNmPengguna.Text = ""
        cmbLevel.Text = ""
        Call Kode_Otomatis()
        Call Data_Record()
        btnSimpan.Enabled = True
        btnUbah.Enabled = False
        btnHapus.Enabled = False
        btnTutup.Enabled = True
        txtKdPengguna.Enabled = False
        txtPassword.Enabled = True
        txtUlangPassword.Enabled = True
        txtPassword.Text = ""
        txtUlangPassword.Text = ""
    End Sub

    Private Sub Pengguna_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Left = 0
        Top = 0
        Call Bersih()
        cmbLevel.Items.Add("ADMIN")
        cmbLevel.Items.Add("OPERATOR")
    End Sub

    Private Sub Pengguna_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Call Data_Record()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtNmPengguna.Text = "" Then
            txtNmPengguna.Focus()
            Exit Sub
        End If
        If txtPassword.Text = "" Then
            txtPassword.Focus()
            Exit Sub
        End If
        If txtUlangPassword.Text = "" Then
            txtUlangPassword.Focus()
            Exit Sub
        End If
        If cmbLevel.Text = "" Then
            cmbLevel.Focus()
            Exit Sub
        End If
        If txtPassword.Text <> txtUlangPassword.Text Then
            MsgBox("Ulangi, password keliru!!!", MsgBoxStyle.Critical, "Password")
            txtUlangPassword.Focus()
            Exit Sub
        Else
            SQL = "Insert Into TblPengguna values ('" & txtKdPengguna.Text & "','" & txtNmPengguna.Text & "','" & txtPassword.Text & "','" & cmbLevel.Text & "')"
            Proses.ExecuteNonQuery(SQL)
            MessageBox.Show("Data Baru telah disimpan..!!", "Penyimpanan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call Bersih()
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If txtNmPengguna.Text = "" Then
            txtNmPengguna.Focus()
            Exit Sub
        End If
        If cmbLevel.Text = "" Then
            cmbLevel.Focus()
            Exit Sub
        Else
            SQL = "Update TblPengguna Set Nama_pengguna = '" & txtNmPengguna.Text & "',Level = '" & cmbLevel.Text & "' Where Kode_Pengguna = '" & txtKdPengguna.Text & "'"
            Proses.ExecuteNonQuery(SQL)
            MessageBox.Show("Data telah diubah..!!", "Perubahan Data Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call Bersih()
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Call Bersih()
        txtKdPengguna.Focus()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        SQL = "Delete From TblPengguna Where Kode_Pengguna = '" & txtKdPengguna.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data telah dihapus..!!", "Penghapusan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub

    Private Sub DGPengguna_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgPengguna.CellContentClick
        btnHapus.Enabled = True
        btnUbah.Enabled = True
        Dim value As Object = DgPengguna.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
        If IsDBNull(value) Then
            Call Kode_Otomatis()
            txtNmPengguna.Focus()
        Else
            txtKdPengguna.Text = CType(value, String)
        End If
    End Sub

    Private Sub DgPengguna_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgPengguna.CellClick
        Dim i As Integer
        With DgPengguna
            If e.RowIndex >= 0 Then
                i = .CurrentRow.Index
                txtKdPengguna.Text = .Rows(i).Cells("Kode_Pengguna").Value.ToString
                txtNmPengguna.Text = .Rows(i).Cells("Nama_Pengguna").Value.ToString
                txtPassword.Text = .Rows(i).Cells("Password").Value.ToString
                txtPassword.Enabled = False
                txtUlangPassword.Enabled = False
                cmbLevel.Text = .Rows(i).Cells("Level").Value.ToString
                btnUbah.Enabled = True
                btnHapus.Enabled = True
                btnSimpan.Enabled = False
            End If
        End With
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        txtKdPengguna.Text = InputBox("Masukkan kode pengguna !!!")
        If txtKdPengguna.Text = "" Then
            Call Kode_Otomatis()
            txtNmPengguna.Focus()
            Exit Sub
        End If
        tblPengguna = Proses.ExecuteQuery("Select * From TblPengguna Where Kode_Pengguna = '" & txtKdPengguna.Text & "'")
        If tblPengguna.Rows.Count = 0 Then
            MessageBox.Show("Data Pengguna Tidak Ditemukan..!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNmPengguna.Focus()
            Call Kode_Otomatis()
        Else
            With tblPengguna.Rows(0)
                txtKdPengguna.Text = .Item("Kode_Pengguna")
                txtNmPengguna.Text = .Item("Nama_Pengguna")
                txtPassword.Text = .Item("Password")
                txtPassword.Enabled = False
                txtUlangPassword.Enabled = False
                cmbLevel.Text = .Item("Level")
            End With
            btnSimpan.Enabled = False
            btnUbah.Enabled = True
            btnHapus.Enabled = True
            btnBatal.Enabled = True
        End If
    End Sub
End Class