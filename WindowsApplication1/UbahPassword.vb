Public Class UbahPassword
    Dim SQL As String
    Dim Proses As New Koneksi
    Dim tblUbahPwd As DataTable

    Sub bersih()
        txtPwdLama.Text = ""
        txtPwdBaru.Text = ""
        txtPwdLama.Focus()
    End Sub

    Private Sub UbahBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUbah.Click
        If txtPwdLama.Text = "" Then
            txtPwdLama.Focus()
            Exit Sub
        End If
        If txtPwdBaru.Text = "" Then
            txtPwdBaru.Focus()
            Exit Sub
        End If
        tblUbahPwd = Proses.ExecuteQuery("Select * From TblPengguna Where password = '" & txtPwdLama.Text & "'")
        If tblUbahPwd.Rows.Count = 0 Then
            MessageBox.Show("Perubahan password tidak berhasil...!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtPwdLama.SelectedText = txtPwdLama.Text
            txtPwdLama.Focus()
        Else
            SQL = "Update TblPengguna Set password = '" & txtPwdBaru.Text & "' where kode_pengguna = '" &
            MenuUtama.TsPengguna.Text & "'"
            Proses.ExecuteNonQuery(SQL)
            MessageBox.Show("Password telah diubah..!!", "Perubahan Password Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call bersih()
            Me.Close()
        End If
    End Sub

    Private Sub BatalBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub
End Class