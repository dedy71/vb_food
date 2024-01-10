<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pembelian
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pembelian))
        Me.DGPembelian = New System.Windows.Forms.DataGridView()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnCetak = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.TxtDiscount = New System.Windows.Forms.TextBox()
        Me.TxtJumlah = New System.Windows.Forms.TextBox()
        Me.CmbObat = New System.Windows.Forms.ComboBox()
        Me.CmbSupplier = New System.Windows.Forms.ComboBox()
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
        Me.LblNmSupplier = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DGPembelian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGPembelian
        '
        Me.DGPembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGPembelian.Location = New System.Drawing.Point(15, 100)
        Me.DGPembelian.Name = "DGPembelian"
        Me.DGPembelian.Size = New System.Drawing.Size(727, 232)
        Me.DGPembelian.TabIndex = 43
        '
        'btnBatal
        '
        Me.btnBatal.Image = CType(resources.GetObject("btnBatal.Image"), System.Drawing.Image)
        Me.btnBatal.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBatal.Location = New System.Drawing.Point(148, 351)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(57, 59)
        Me.btnBatal.TabIndex = 42
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnCetak
        '
        Me.btnCetak.Image = CType(resources.GetObject("btnCetak.Image"), System.Drawing.Image)
        Me.btnCetak.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCetak.Location = New System.Drawing.Point(85, 351)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(57, 59)
        Me.btnCetak.TabIndex = 41
        Me.btnCetak.Text = "Cetak"
        Me.btnCetak.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCetak.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Image = CType(resources.GetObject("btnSimpan.Image"), System.Drawing.Image)
        Me.btnSimpan.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSimpan.Location = New System.Drawing.Point(22, 351)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(57, 59)
        Me.btnSimpan.TabIndex = 40
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'TxtDiscount
        '
        Me.TxtDiscount.Location = New System.Drawing.Point(624, 366)
        Me.TxtDiscount.Name = "TxtDiscount"
        Me.TxtDiscount.Size = New System.Drawing.Size(100, 20)
        Me.TxtDiscount.TabIndex = 39
        '
        'TxtJumlah
        '
        Me.TxtJumlah.Location = New System.Drawing.Point(624, 70)
        Me.TxtJumlah.Name = "TxtJumlah"
        Me.TxtJumlah.Size = New System.Drawing.Size(100, 20)
        Me.TxtJumlah.TabIndex = 38
        '
        'CmbObat
        '
        Me.CmbObat.FormattingEnabled = True
        Me.CmbObat.Location = New System.Drawing.Point(97, 73)
        Me.CmbObat.Name = "CmbObat"
        Me.CmbObat.Size = New System.Drawing.Size(121, 21)
        Me.CmbObat.TabIndex = 37
        '
        'CmbSupplier
        '
        Me.CmbSupplier.FormattingEnabled = True
        Me.CmbSupplier.Location = New System.Drawing.Point(97, 5)
        Me.CmbSupplier.Name = "CmbSupplier"
        Me.CmbSupplier.Size = New System.Drawing.Size(121, 21)
        Me.CmbSupplier.TabIndex = 36
        '
        'LblTotalHargaBersih
        '
        Me.LblTotalHargaBersih.AutoSize = True
        Me.LblTotalHargaBersih.BackColor = System.Drawing.Color.White
        Me.LblTotalHargaBersih.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblTotalHargaBersih.ForeColor = System.Drawing.Color.Red
        Me.LblTotalHargaBersih.Location = New System.Drawing.Point(624, 397)
        Me.LblTotalHargaBersih.Name = "LblTotalHargaBersih"
        Me.LblTotalHargaBersih.Size = New System.Drawing.Size(26, 15)
        Me.LblTotalHargaBersih.TabIndex = 35
        Me.LblTotalHargaBersih.Text = "Rp,"
        Me.LblTotalHargaBersih.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblTotalHargaKotor
        '
        Me.LblTotalHargaKotor.AutoSize = True
        Me.LblTotalHargaKotor.BackColor = System.Drawing.Color.White
        Me.LblTotalHargaKotor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblTotalHargaKotor.Location = New System.Drawing.Point(624, 342)
        Me.LblTotalHargaKotor.Name = "LblTotalHargaKotor"
        Me.LblTotalHargaKotor.Size = New System.Drawing.Size(26, 15)
        Me.LblTotalHargaKotor.TabIndex = 34
        Me.LblTotalHargaKotor.Text = "Rp,"
        Me.LblTotalHargaKotor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(544, 397)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 13)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "Harga Bersih :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(544, 369)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 13)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Disc :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(544, 342)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 13)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Harga Kotor :"
        '
        'LblStock
        '
        Me.LblStock.AutoSize = True
        Me.LblStock.BackColor = System.Drawing.Color.White
        Me.LblStock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblStock.Location = New System.Drawing.Point(570, 73)
        Me.LblStock.Name = "LblStock"
        Me.LblStock.Size = New System.Drawing.Size(15, 15)
        Me.LblStock.TabIndex = 30
        Me.LblStock.Text = "0"
        '
        'LblHarga
        '
        Me.LblHarga.AutoSize = True
        Me.LblHarga.BackColor = System.Drawing.Color.White
        Me.LblHarga.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblHarga.Location = New System.Drawing.Point(416, 73)
        Me.LblHarga.Name = "LblHarga"
        Me.LblHarga.Size = New System.Drawing.Size(15, 15)
        Me.LblHarga.TabIndex = 29
        Me.LblHarga.Text = "0"
        '
        'LblNamaObat
        '
        Me.LblNamaObat.AutoSize = True
        Me.LblNamaObat.BackColor = System.Drawing.Color.White
        Me.LblNamaObat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblNamaObat.Location = New System.Drawing.Point(253, 73)
        Me.LblNamaObat.Name = "LblNamaObat"
        Me.LblNamaObat.Size = New System.Drawing.Size(2, 15)
        Me.LblNamaObat.TabIndex = 28
        '
        'LblFaktur
        '
        Me.LblFaktur.AutoSize = True
        Me.LblFaktur.BackColor = System.Drawing.Color.White
        Me.LblFaktur.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblFaktur.Location = New System.Drawing.Point(662, 8)
        Me.LblFaktur.Name = "LblFaktur"
        Me.LblFaktur.Size = New System.Drawing.Size(2, 15)
        Me.LblFaktur.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(567, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Faktur Pembelian"
        '
        'LblNmSupplier
        '
        Me.LblNmSupplier.AutoSize = True
        Me.LblNmSupplier.BackColor = System.Drawing.Color.White
        Me.LblNmSupplier.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblNmSupplier.Location = New System.Drawing.Point(97, 46)
        Me.LblNmSupplier.Name = "LblNmSupplier"
        Me.LblNmSupplier.Size = New System.Drawing.Size(2, 15)
        Me.LblNmSupplier.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Obat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Nama Supplier"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Supplier"
        '
        'Pembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 416)
        Me.Controls.Add(Me.DGPembelian)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnCetak)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.TxtDiscount)
        Me.Controls.Add(Me.TxtJumlah)
        Me.Controls.Add(Me.CmbObat)
        Me.Controls.Add(Me.CmbSupplier)
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
        Me.Controls.Add(Me.LblNmSupplier)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Pembelian"
        Me.Text = "Pembelian"
        CType(Me.DGPembelian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGPembelian As System.Windows.Forms.DataGridView
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnCetak As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents TxtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents TxtJumlah As System.Windows.Forms.TextBox
    Friend WithEvents CmbObat As System.Windows.Forms.ComboBox
    Friend WithEvents CmbSupplier As System.Windows.Forms.ComboBox
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
    Friend WithEvents LblNmSupplier As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
