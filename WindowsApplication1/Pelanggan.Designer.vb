<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pelanggan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pelanggan))
        Me.DGPelanggan = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CariNmPelanggan = New System.Windows.Forms.RadioButton()
        Me.CariKdPelanggan = New System.Windows.Forms.RadioButton()
        Me.txtCariData = New System.Windows.Forms.TextBox()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.txtTelepon = New System.Windows.Forms.TextBox()
        Me.txtNamaPelanggan = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.txtKodePelanggan = New System.Windows.Forms.TextBox()
        Me.cmbJenisKelamin = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.DGPelanggan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGPelanggan
        '
        Me.DGPelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGPelanggan.Location = New System.Drawing.Point(16, 184)
        Me.DGPelanggan.Name = "DGPelanggan"
        Me.DGPelanggan.Size = New System.Drawing.Size(689, 182)
        Me.DGPelanggan.TabIndex = 49
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CariNmPelanggan)
        Me.GroupBox1.Controls.Add(Me.CariKdPelanggan)
        Me.GroupBox1.Controls.Add(Me.txtCariData)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 127)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(689, 51)
        Me.GroupBox1.TabIndex = 48
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cari Berdasarkan"
        '
        'CariNmPelanggan
        '
        Me.CariNmPelanggan.AutoSize = True
        Me.CariNmPelanggan.Location = New System.Drawing.Point(116, 20)
        Me.CariNmPelanggan.Name = "CariNmPelanggan"
        Me.CariNmPelanggan.Size = New System.Drawing.Size(107, 17)
        Me.CariNmPelanggan.TabIndex = 12
        Me.CariNmPelanggan.TabStop = True
        Me.CariNmPelanggan.Text = "Nama Pelanggan"
        Me.CariNmPelanggan.UseVisualStyleBackColor = True
        '
        'CariKdPelanggan
        '
        Me.CariKdPelanggan.AutoSize = True
        Me.CariKdPelanggan.Location = New System.Drawing.Point(6, 20)
        Me.CariKdPelanggan.Name = "CariKdPelanggan"
        Me.CariKdPelanggan.Size = New System.Drawing.Size(104, 17)
        Me.CariKdPelanggan.TabIndex = 11
        Me.CariKdPelanggan.TabStop = True
        Me.CariKdPelanggan.Text = "Kode Pelanggan"
        Me.CariKdPelanggan.UseVisualStyleBackColor = True
        '
        'txtCariData
        '
        Me.txtCariData.Location = New System.Drawing.Point(364, 19)
        Me.txtCariData.Name = "txtCariData"
        Me.txtCariData.Size = New System.Drawing.Size(285, 20)
        Me.txtCariData.TabIndex = 10
        '
        'btnTutup
        '
        Me.btnTutup.Image = CType(resources.GetObject("btnTutup.Image"), System.Drawing.Image)
        Me.btnTutup.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnTutup.Location = New System.Drawing.Point(596, 66)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(58, 58)
        Me.btnTutup.TabIndex = 47
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnTutup.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Image = CType(resources.GetObject("btnHapus.Image"), System.Drawing.Image)
        Me.btnHapus.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnHapus.Location = New System.Drawing.Point(532, 66)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(58, 58)
        Me.btnHapus.TabIndex = 46
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Image = CType(resources.GetObject("btnBatal.Image"), System.Drawing.Image)
        Me.btnBatal.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBatal.Location = New System.Drawing.Point(468, 66)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(58, 58)
        Me.btnBatal.TabIndex = 45
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnUbah
        '
        Me.btnUbah.Image = CType(resources.GetObject("btnUbah.Image"), System.Drawing.Image)
        Me.btnUbah.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnUbah.Location = New System.Drawing.Point(404, 66)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(58, 58)
        Me.btnUbah.TabIndex = 44
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUbah.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Image = CType(resources.GetObject("btnSimpan.Image"), System.Drawing.Image)
        Me.btnSimpan.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSimpan.Location = New System.Drawing.Point(340, 66)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(58, 58)
        Me.btnSimpan.TabIndex = 43
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'txtTelepon
        '
        Me.txtTelepon.Location = New System.Drawing.Point(446, 40)
        Me.txtTelepon.Name = "txtTelepon"
        Me.txtTelepon.Size = New System.Drawing.Size(100, 20)
        Me.txtTelepon.TabIndex = 42
        '
        'txtNamaPelanggan
        '
        Me.txtNamaPelanggan.Location = New System.Drawing.Point(104, 40)
        Me.txtNamaPelanggan.Name = "txtNamaPelanggan"
        Me.txtNamaPelanggan.Size = New System.Drawing.Size(197, 20)
        Me.txtNamaPelanggan.TabIndex = 40
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(355, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Telepon"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Alamat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Nama Pelanggan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Kode Pelanggan"
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(104, 66)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(197, 41)
        Me.txtAlamat.TabIndex = 41
        '
        'txtKodePelanggan
        '
        Me.txtKodePelanggan.Location = New System.Drawing.Point(104, 14)
        Me.txtKodePelanggan.Name = "txtKodePelanggan"
        Me.txtKodePelanggan.Size = New System.Drawing.Size(100, 20)
        Me.txtKodePelanggan.TabIndex = 39
        '
        'cmbJenisKelamin
        '
        Me.cmbJenisKelamin.FormattingEnabled = True
        Me.cmbJenisKelamin.Location = New System.Drawing.Point(446, 14)
        Me.cmbJenisKelamin.Name = "cmbJenisKelamin"
        Me.cmbJenisKelamin.Size = New System.Drawing.Size(134, 21)
        Me.cmbJenisKelamin.TabIndex = 51
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(355, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Jenis Kelamin"
        '
        'Pelanggan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 378)
        Me.Controls.Add(Me.cmbJenisKelamin)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DGPelanggan)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnTutup)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnUbah)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.txtTelepon)
        Me.Controls.Add(Me.txtNamaPelanggan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAlamat)
        Me.Controls.Add(Me.txtKodePelanggan)
        Me.Name = "Pelanggan"
        Me.Text = "Pelanggan"
        CType(Me.DGPelanggan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGPelanggan As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CariNmPelanggan As System.Windows.Forms.RadioButton
    Friend WithEvents CariKdPelanggan As System.Windows.Forms.RadioButton
    Friend WithEvents txtCariData As System.Windows.Forms.TextBox
    Friend WithEvents btnTutup As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnUbah As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents txtTelepon As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaPelanggan As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents txtKodePelanggan As System.Windows.Forms.TextBox
    Friend WithEvents cmbJenisKelamin As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
