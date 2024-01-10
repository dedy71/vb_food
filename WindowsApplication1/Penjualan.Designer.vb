<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Penjualan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Penjualan))
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnCetak = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.LblTotalHarga = New System.Windows.Forms.Label()
        Me.DGPenjualan = New System.Windows.Forms.DataGridView()
        Me.TxtDiscount = New System.Windows.Forms.TextBox()
        Me.TxtJumlah = New System.Windows.Forms.TextBox()
        Me.CmbObat = New System.Windows.Forms.ComboBox()
        Me.CmbPelanggan = New System.Windows.Forms.ComboBox()
        Me.LblTotalHargaBersih = New System.Windows.Forms.Label()
        Me.LblTotalHargaKotor = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LblStock = New System.Windows.Forms.Label()
        Me.LblHarga = New System.Windows.Forms.Label()
        Me.LblNamaObat = New System.Windows.Forms.Label()
        Me.LblFaktur = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblNmPelanggan = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DGPenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBatal
        '
        Me.btnBatal.Image = CType(resources.GetObject("btnBatal.Image"), System.Drawing.Image)
        Me.btnBatal.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBatal.Location = New System.Drawing.Point(141, 352)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(57, 59)
        Me.btnBatal.TabIndex = 70
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnCetak
        '
        Me.btnCetak.Image = CType(resources.GetObject("btnCetak.Image"), System.Drawing.Image)
        Me.btnCetak.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCetak.Location = New System.Drawing.Point(78, 352)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(57, 59)
        Me.btnCetak.TabIndex = 69
        Me.btnCetak.Text = "Cetak"
        Me.btnCetak.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCetak.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Image = CType(resources.GetObject("btnSimpan.Image"), System.Drawing.Image)
        Me.btnSimpan.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSimpan.Location = New System.Drawing.Point(15, 352)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(57, 59)
        Me.btnSimpan.TabIndex = 68
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'LblTotalHarga
        '
        Me.LblTotalHarga.AutoSize = True
        Me.LblTotalHarga.BackColor = System.Drawing.Color.Black
        Me.LblTotalHarga.ForeColor = System.Drawing.Color.White
        Me.LblTotalHarga.Location = New System.Drawing.Point(677, 47)
        Me.LblTotalHarga.Name = "LblTotalHarga"
        Me.LblTotalHarga.Size = New System.Drawing.Size(39, 13)
        Me.LblTotalHarga.TabIndex = 67
        Me.LblTotalHarga.Text = "Label4"
        '
        'DGPenjualan
        '
        Me.DGPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGPenjualan.Location = New System.Drawing.Point(7, 101)
        Me.DGPenjualan.Name = "DGPenjualan"
        Me.DGPenjualan.Size = New System.Drawing.Size(727, 232)
        Me.DGPenjualan.TabIndex = 66
        '
        'TxtDiscount
        '
        Me.TxtDiscount.Location = New System.Drawing.Point(616, 367)
        Me.TxtDiscount.Name = "TxtDiscount"
        Me.TxtDiscount.Size = New System.Drawing.Size(100, 20)
        Me.TxtDiscount.TabIndex = 65
        '
        'TxtJumlah
        '
        Me.TxtJumlah.Location = New System.Drawing.Point(616, 71)
        Me.TxtJumlah.Name = "TxtJumlah"
        Me.TxtJumlah.Size = New System.Drawing.Size(100, 20)
        Me.TxtJumlah.TabIndex = 64
        '
        'CmbObat
        '
        Me.CmbObat.FormattingEnabled = True
        Me.CmbObat.Location = New System.Drawing.Point(106, 74)
        Me.CmbObat.Name = "CmbObat"
        Me.CmbObat.Size = New System.Drawing.Size(121, 21)
        Me.CmbObat.TabIndex = 63
        '
        'CmbPelanggan
        '
        Me.CmbPelanggan.FormattingEnabled = True
        Me.CmbPelanggan.Location = New System.Drawing.Point(106, 6)
        Me.CmbPelanggan.Name = "CmbPelanggan"
        Me.CmbPelanggan.Size = New System.Drawing.Size(121, 21)
        Me.CmbPelanggan.TabIndex = 62
        '
        'LblTotalHargaBersih
        '
        Me.LblTotalHargaBersih.AutoSize = True
        Me.LblTotalHargaBersih.BackColor = System.Drawing.Color.White
        Me.LblTotalHargaBersih.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblTotalHargaBersih.ForeColor = System.Drawing.Color.Red
        Me.LblTotalHargaBersih.Location = New System.Drawing.Point(616, 398)
        Me.LblTotalHargaBersih.Name = "LblTotalHargaBersih"
        Me.LblTotalHargaBersih.Size = New System.Drawing.Size(26, 15)
        Me.LblTotalHargaBersih.TabIndex = 61
        Me.LblTotalHargaBersih.Text = "Rp,"
        Me.LblTotalHargaBersih.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblTotalHargaKotor
        '
        Me.LblTotalHargaKotor.AutoSize = True
        Me.LblTotalHargaKotor.BackColor = System.Drawing.Color.White
        Me.LblTotalHargaKotor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblTotalHargaKotor.Location = New System.Drawing.Point(616, 343)
        Me.LblTotalHargaKotor.Name = "LblTotalHargaKotor"
        Me.LblTotalHargaKotor.Size = New System.Drawing.Size(26, 15)
        Me.LblTotalHargaKotor.TabIndex = 60
        Me.LblTotalHargaKotor.Text = "Rp,"
        Me.LblTotalHargaKotor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(536, 398)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 13)
        Me.Label12.TabIndex = 59
        Me.Label12.Text = "Harga Bersih :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(536, 370)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 13)
        Me.Label11.TabIndex = 58
        Me.Label11.Text = "Disc :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(536, 343)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 13)
        Me.Label10.TabIndex = 57
        Me.Label10.Text = "Harga Kotor :"
        '
        'LblStock
        '
        Me.LblStock.AutoSize = True
        Me.LblStock.BackColor = System.Drawing.Color.White
        Me.LblStock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblStock.Location = New System.Drawing.Point(562, 74)
        Me.LblStock.Name = "LblStock"
        Me.LblStock.Size = New System.Drawing.Size(15, 15)
        Me.LblStock.TabIndex = 56
        Me.LblStock.Text = "0"
        '
        'LblHarga
        '
        Me.LblHarga.AutoSize = True
        Me.LblHarga.BackColor = System.Drawing.Color.White
        Me.LblHarga.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblHarga.Location = New System.Drawing.Point(408, 74)
        Me.LblHarga.Name = "LblHarga"
        Me.LblHarga.Size = New System.Drawing.Size(15, 15)
        Me.LblHarga.TabIndex = 55
        Me.LblHarga.Text = "0"
        '
        'LblNamaObat
        '
        Me.LblNamaObat.AutoSize = True
        Me.LblNamaObat.BackColor = System.Drawing.Color.White
        Me.LblNamaObat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblNamaObat.Location = New System.Drawing.Point(262, 74)
        Me.LblNamaObat.Name = "LblNamaObat"
        Me.LblNamaObat.Size = New System.Drawing.Size(2, 15)
        Me.LblNamaObat.TabIndex = 54
        '
        'LblFaktur
        '
        Me.LblFaktur.AutoSize = True
        Me.LblFaktur.BackColor = System.Drawing.Color.White
        Me.LblFaktur.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblFaktur.Location = New System.Drawing.Point(648, 9)
        Me.LblFaktur.Name = "LblFaktur"
        Me.LblFaktur.Size = New System.Drawing.Size(2, 15)
        Me.LblFaktur.TabIndex = 53
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(555, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 13)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Faktur Penjualan"
        '
        'LblNmPelanggan
        '
        Me.LblNmPelanggan.AutoSize = True
        Me.LblNmPelanggan.BackColor = System.Drawing.Color.White
        Me.LblNmPelanggan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblNmPelanggan.Location = New System.Drawing.Point(106, 47)
        Me.LblNmPelanggan.Name = "LblNmPelanggan"
        Me.LblNmPelanggan.Size = New System.Drawing.Size(2, 15)
        Me.LblNmPelanggan.TabIndex = 51
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Obat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Nama Pelanggan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Pelanggan"
        '
        'Penjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 419)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnCetak)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.LblTotalHarga)
        Me.Controls.Add(Me.DGPenjualan)
        Me.Controls.Add(Me.TxtDiscount)
        Me.Controls.Add(Me.TxtJumlah)
        Me.Controls.Add(Me.CmbObat)
        Me.Controls.Add(Me.CmbPelanggan)
        Me.Controls.Add(Me.LblTotalHargaBersih)
        Me.Controls.Add(Me.LblTotalHargaKotor)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.LblStock)
        Me.Controls.Add(Me.LblHarga)
        Me.Controls.Add(Me.LblNamaObat)
        Me.Controls.Add(Me.LblFaktur)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LblNmPelanggan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Penjualan"
        Me.Text = "Penjualan"
        CType(Me.DGPenjualan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnCetak As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents LblTotalHarga As System.Windows.Forms.Label
    Friend WithEvents DGPenjualan As System.Windows.Forms.DataGridView
    Friend WithEvents TxtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents TxtJumlah As System.Windows.Forms.TextBox
    Friend WithEvents CmbObat As System.Windows.Forms.ComboBox
    Friend WithEvents CmbPelanggan As System.Windows.Forms.ComboBox
    Friend WithEvents LblTotalHargaBersih As System.Windows.Forms.Label
    Friend WithEvents LblTotalHargaKotor As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents LblStock As System.Windows.Forms.Label
    Friend WithEvents LblHarga As System.Windows.Forms.Label
    Friend WithEvents LblNamaObat As System.Windows.Forms.Label
    Friend WithEvents LblFaktur As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LblNmPelanggan As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
