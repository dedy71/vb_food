Public Class Login
    Dim SQL As String
    Dim Proses As New Koneksi
    Dim tblLogin As DataTable

    Sub Bersih()
        txtKdPengguna.Text = ""
        txtPassword.Text = ""
        txtKdPengguna.Focus()
    End Sub

    Sub Login()
        If txtKdPengguna.Text = "" Then
            txtKdPengguna.Focus()
            Exit Sub
        End If
        If txtPassword.Text = "" Then
            txtPassword.Focus()
            Exit Sub
        End If
        tblLogin = Proses.ExecuteQuery("Select * From TblPengguna Where kode_pengguna = '" & txtKdPengguna.Text & "' and password ='" & txtPassword.Text & "'")
        If tblLogin.Rows.Count = 0 Then
            MessageBox.Show("Login tidak berhasil..!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtKdPengguna.Focus()
        Else
            With tblLogin.Rows(0)
                MenuUtama.TsPengguna.Text = txtKdPengguna.Text
                MenuUtama.TsNmPengguna.Text = .Item("Nama_Pengguna")
                MenuUtama.TsLevel.Text = .Item("Level")
                Me.Hide()
                MenuUtama.Show()
            End With

        End If
    End Sub

    Private Sub KdPenggunaTxt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKdPengguna.KeyPress
        If e.KeyChar = Chr(13) Then
            tblLogin = Proses.ExecuteQuery("Select * From TblPengguna Where kode_pengguna = '" & txtKdPengguna.Text & "'")
            If tblLogin.Rows.Count = 0 Then
                MessageBox.Show("Kode tidak ditemukan..!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtKdPengguna.Focus()
            Else
                txtPassword.Focus()
            End If
        End If
    End Sub

    Private Sub PswTxt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Login()
        End If
    End Sub
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Call Login()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
