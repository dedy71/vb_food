<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Obat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Obat))
        Me.DGObat = New System.Windows.Forms.DataGridView()
        Me.CariStock = New System.Windows.Forms.RadioButton()
        Me.CariNmObat = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCariData = New System.Windows.Forms.TextBox()
        Me.CariKdObat = New System.Windows.Forms.RadioButton()
        Me.cmbSatuan = New System.Windows.Forms.ComboBox()
        Me.cmbJB = New System.Windows.Forms.ComboBox()
        Me.txtHargaJual = New System.Windows.Forms.TextBox()
        Me.txtHargaBeli = New System.Windows.Forms.TextBox()
        Me.txtNamaObat = New System.Windows.Forms.TextBox()
        Me.txtKodeObat = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DTTanggalExpired = New System.Windows.Forms.DateTimePicker()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.LblStock = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.DGObat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGObat
        '
        Me.DGObat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGObat.Location = New System.Drawing.Point(21, 210)
        Me.DGObat.Name = "DGObat"
        Me.DGObat.Size = New System.Drawing.Size(601, 222)
        Me.DGObat.TabIndex = 42
        '
        'CariStock
        '
        Me.CariStock.AutoSize = True
        Me.CariStock.Location = New System.Drawing.Point(198, 24)
        Me.CariStock.Name = "CariStock"
        Me.CariStock.Size = New System.Drawing.Size(53, 17)
        Me.CariStock.TabIndex = 23
        Me.CariStock.TabStop = True
        Me.CariStock.Text = "Stock"
        Me.CariStock.UseVisualStyleBackColor = True
        '
        'CariNmObat
        '
        Me.CariNmObat.AutoSize = True
        Me.CariNmObat.Location = New System.Drawing.Point(102, 24)
        Me.CariNmObat.Name = "CariNmObat"
        Me.CariNmObat.Size = New System.Drawing.Size(79, 17)
        Me.CariNmObat.TabIndex = 22
        Me.CariNmObat.TabStop = True
        Me.CariNmObat.Text = "Nama Obat"
        Me.CariNmObat.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CariStock)
        Me.GroupBox1.Controls.Add(Me.txtCariData)
        Me.GroupBox1.Controls.Add(Me.CariNmObat)
        Me.GroupBox1.Controls.Add(Me.CariKdObat)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 154)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(601, 50)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cari Berdasarkan"
        '
        'txtCariData
        '
        Me.txtCariData.Location = New System.Drawing.Point(294, 19)
        Me.txtCariData.Name = "txtCariData"
        Me.txtCariData.Size = New System.Drawing.Size(301, 20)
        Me.txtCariData.TabIndex = 17
        '
        'CariKdObat
        '
        Me.CariKdObat.AutoSize = True
        Me.CariKdObat.Location = New System.Drawing.Point(6, 24)
        Me.CariKdObat.Name = "CariKdObat"
        Me.CariKdObat.Size = New System.Drawing.Size(76, 17)
        Me.CariKdObat.TabIndex = 21
        Me.CariKdObat.TabStop = True
        Me.CariKdObat.Text = "Kode Obat"
        Me.CariKdObat.UseVisualStyleBackColor = True
        '
        'cmbSatuan
        '
        Me.cmbSatuan.FormattingEnabled = True
        Me.cmbSatuan.Location = New System.Drawing.Point(134, 90)
        Me.cmbSatuan.Name = "cmbSatuan"
        Me.cmbSatuan.Size = New System.Drawing.Size(121, 21)
        Me.cmbSatuan.TabIndex = 40
        '
        'cmbJB
        '
        Me.cmbJB.FormattingEnabled = True
        Me.cmbJB.Location = New System.Drawing.Point(134, 63)
        Me.cmbJB.Name = "cmbJB"
        Me.cmbJB.Size = New System.Drawing.Size(121, 21)
        Me.cmbJB.TabIndex = 39
        '
        'txtHargaJual
        '
        Me.txtHargaJual.Location = New System.Drawing.Point(361, 37)
        Me.txtHargaJual.Name = "txtHargaJual"
        Me.txtHargaJual.Size = New System.Drawing.Size(100, 20)
        Me.txtHargaJual.TabIndex = 38
        '
        'txtHargaBeli
        '
        Me.txtHargaBeli.Location = New System.Drawing.Point(361, 11)
        Me.txtHargaBeli.Name = "txtHargaBeli"
        Me.txtHargaBeli.Size = New System.Drawing.Size(100, 20)
        Me.txtHargaBeli.TabIndex = 37
        '
        'txtNamaObat
        '
        Me.txtNamaObat.Location = New System.Drawing.Point(134, 37)
        Me.txtNamaObat.Name = "txtNamaObat"
        Me.txtNamaObat.Size = New System.Drawing.Size(100, 20)
        Me.txtNamaObat.TabIndex = 36
        '
        'txtKodeObat
        '
        Me.txtKodeObat.Location = New System.Drawing.Point(134, 11)
        Me.txtKodeObat.Name = "txtKodeObat"
        Me.txtKodeObat.Size = New System.Drawing.Size(100, 20)
        Me.txtKodeObat.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(297, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Harga Jual"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(297, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Harga Beli"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Satuan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Jenis Obat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Nama Obat"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Kode Obat"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 124)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 13)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Tanggal Expried"
        '
        'DTTanggalExpired
        '
        Me.DTTanggalExpired.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTTanggalExpired.Location = New System.Drawing.Point(134, 118)
        Me.DTTanggalExpired.Name = "DTTanggalExpired"
        Me.DTTanggalExpired.Size = New System.Drawing.Size(121, 20)
        Me.DTTanggalExpired.TabIndex = 44
        Me.DTTanggalExpired.Value = New Date(2024, 1, 9, 0, 0, 0, 0)
        '
        'btnTutup
        '
        Me.btnTutup.Image = CType(resources.GetObject("btnTutup.Image"), System.Drawing.Image)
        Me.btnTutup.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnTutup.Location = New System.Drawing.Point(545, 87)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(59, 61)
        Me.btnTutup.TabIndex = 34
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnTutup.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Image = CType(resources.GetObject("btnHapus.Image"), System.Drawing.Image)
        Me.btnHapus.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnHapus.Location = New System.Drawing.Point(480, 87)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(59, 61)
        Me.btnHapus.TabIndex = 33
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Image = CType(resources.GetObject("btnBatal.Image"), System.Drawing.Image)
        Me.btnBatal.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBatal.Location = New System.Drawing.Point(415, 87)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(59, 61)
        Me.btnBatal.TabIndex = 32
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnUbah
        '
        Me.btnUbah.Image = CType(resources.GetObject("btnUbah.Image"), System.Drawing.Image)
        Me.btnUbah.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnUbah.Location = New System.Drawing.Point(350, 87)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(59, 61)
        Me.btnUbah.TabIndex = 31
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUbah.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Image = CType(resources.GetObject("btnSimpan.Image"), System.Drawing.Image)
        Me.btnSimpan.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSimpan.Location = New System.Drawing.Point(285, 87)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(59, 61)
        Me.btnSimpan.TabIndex = 30
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'LblStock
        '
        Me.LblStock.AutoSize = True
        Me.LblStock.BackColor = System.Drawing.Color.White
        Me.LblStock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblStock.Location = New System.Drawing.Point(361, 66)
        Me.LblStock.Name = "LblStock"
        Me.LblStock.Size = New System.Drawing.Size(2, 15)
        Me.LblStock.TabIndex = 46
        Me.LblStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(297, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 13)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Stok"
        '
        'Obat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 460)
        Me.Controls.Add(Me.LblStock)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DTTanggalExpired)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DGObat)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmbSatuan)
        Me.Controls.Add(Me.cmbJB)
        Me.Controls.Add(Me.txtHargaJual)
        Me.Controls.Add(Me.txtHargaBeli)
        Me.Controls.Add(Me.txtNamaObat)
        Me.Controls.Add(Me.txtKodeObat)
        Me.Controls.Add(Me.btnTutup)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnUbah)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Obat"
        Me.Text = "Obat"
        CType(Me.DGObat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGObat As System.Windows.Forms.DataGridView
    Friend WithEvents CariStock As System.Windows.Forms.RadioButton
    Friend WithEvents CariNmObat As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCariData As System.Windows.Forms.TextBox
    Friend WithEvents CariKdObat As System.Windows.Forms.RadioButton
    Friend WithEvents cmbSatuan As System.Windows.Forms.ComboBox
    Friend WithEvents cmbJB As System.Windows.Forms.ComboBox
    Friend WithEvents txtHargaJual As System.Windows.Forms.TextBox
    Friend WithEvents txtHargaBeli As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaObat As System.Windows.Forms.TextBox
    Friend WithEvents txtKodeObat As System.Windows.Forms.TextBox
    Friend WithEvents btnTutup As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnUbah As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DTTanggalExpired As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblStock As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
