<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HakAkses
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
        Me.chkAkses = New System.Windows.Forms.CheckBox()
        Me.chkLprSupplier = New System.Windows.Forms.CheckBox()
        Me.chkLprPenjualan = New System.Windows.Forms.CheckBox()
        Me.chkLprPlgn = New System.Windows.Forms.CheckBox()
        Me.chkLprObat = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.chkLprPembelian = New System.Windows.Forms.CheckBox()
        Me.chkJenis = New System.Windows.Forms.CheckBox()
        Me.chkSatuan = New System.Windows.Forms.CheckBox()
        Me.chkSupplier = New System.Windows.Forms.CheckBox()
        Me.chkObat = New System.Windows.Forms.CheckBox()
        Me.chkPembelian = New System.Windows.Forms.CheckBox()
        Me.chkPenjualan = New System.Windows.Forms.CheckBox()
        Me.chkPelanggan = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkPengguna = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbLevel = New System.Windows.Forms.ComboBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkAkses
        '
        Me.chkAkses.AutoSize = True
        Me.chkAkses.Location = New System.Drawing.Point(296, 423)
        Me.chkAkses.Name = "chkAkses"
        Me.chkAkses.Size = New System.Drawing.Size(78, 17)
        Me.chkAkses.TabIndex = 25
        Me.chkAkses.Text = "Hak Akses"
        Me.chkAkses.UseVisualStyleBackColor = True
        '
        'chkLprSupplier
        '
        Me.chkLprSupplier.AutoSize = True
        Me.chkLprSupplier.Location = New System.Drawing.Point(19, 41)
        Me.chkLprSupplier.Name = "chkLprSupplier"
        Me.chkLprSupplier.Size = New System.Drawing.Size(106, 17)
        Me.chkLprSupplier.TabIndex = 12
        Me.chkLprSupplier.Text = "Laporan Supplier"
        Me.chkLprSupplier.UseVisualStyleBackColor = True
        '
        'chkLprPenjualan
        '
        Me.chkLprPenjualan.AutoSize = True
        Me.chkLprPenjualan.Location = New System.Drawing.Point(19, 133)
        Me.chkLprPenjualan.Name = "chkLprPenjualan"
        Me.chkLprPenjualan.Size = New System.Drawing.Size(115, 17)
        Me.chkLprPenjualan.TabIndex = 16
        Me.chkLprPenjualan.Text = "Laporan Penjualan"
        Me.chkLprPenjualan.UseVisualStyleBackColor = True
        '
        'chkLprPlgn
        '
        Me.chkLprPlgn.AutoSize = True
        Me.chkLprPlgn.Location = New System.Drawing.Point(19, 64)
        Me.chkLprPlgn.Name = "chkLprPlgn"
        Me.chkLprPlgn.Size = New System.Drawing.Size(119, 17)
        Me.chkLprPlgn.TabIndex = 13
        Me.chkLprPlgn.Text = "Laporan Pelanggan"
        Me.chkLprPlgn.UseVisualStyleBackColor = True
        '
        'chkLprObat
        '
        Me.chkLprObat.AutoSize = True
        Me.chkLprObat.Location = New System.Drawing.Point(19, 87)
        Me.chkLprObat.Name = "chkLprObat"
        Me.chkLprObat.Size = New System.Drawing.Size(91, 17)
        Me.chkLprObat.TabIndex = 14
        Me.chkLprObat.Text = "Laporan Obat"
        Me.chkLprObat.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.chkLprSupplier)
        Me.GroupBox4.Controls.Add(Me.chkLprPenjualan)
        Me.GroupBox4.Controls.Add(Me.chkLprPlgn)
        Me.GroupBox4.Controls.Add(Me.chkLprObat)
        Me.GroupBox4.Controls.Add(Me.chkLprPembelian)
        Me.GroupBox4.Location = New System.Drawing.Point(277, 195)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 202)
        Me.GroupBox4.TabIndex = 18
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Laporan"
        '
        'chkLprPembelian
        '
        Me.chkLprPembelian.AutoSize = True
        Me.chkLprPembelian.Location = New System.Drawing.Point(19, 110)
        Me.chkLprPembelian.Name = "chkLprPembelian"
        Me.chkLprPembelian.Size = New System.Drawing.Size(117, 17)
        Me.chkLprPembelian.TabIndex = 15
        Me.chkLprPembelian.Text = "Laporan Pembelian"
        Me.chkLprPembelian.UseVisualStyleBackColor = True
        '
        'chkJenis
        '
        Me.chkJenis.AutoSize = True
        Me.chkJenis.Location = New System.Drawing.Point(16, 41)
        Me.chkJenis.Name = "chkJenis"
        Me.chkJenis.Size = New System.Drawing.Size(50, 17)
        Me.chkJenis.TabIndex = 5
        Me.chkJenis.Text = "Jenis"
        Me.chkJenis.UseVisualStyleBackColor = True
        '
        'chkSatuan
        '
        Me.chkSatuan.AutoSize = True
        Me.chkSatuan.Location = New System.Drawing.Point(16, 64)
        Me.chkSatuan.Name = "chkSatuan"
        Me.chkSatuan.Size = New System.Drawing.Size(60, 17)
        Me.chkSatuan.TabIndex = 6
        Me.chkSatuan.Text = "Satuan"
        Me.chkSatuan.UseVisualStyleBackColor = True
        '
        'chkSupplier
        '
        Me.chkSupplier.AutoSize = True
        Me.chkSupplier.Location = New System.Drawing.Point(16, 110)
        Me.chkSupplier.Name = "chkSupplier"
        Me.chkSupplier.Size = New System.Drawing.Size(64, 17)
        Me.chkSupplier.TabIndex = 8
        Me.chkSupplier.Text = "Supplier"
        Me.chkSupplier.UseVisualStyleBackColor = True
        '
        'chkObat
        '
        Me.chkObat.AutoSize = True
        Me.chkObat.Location = New System.Drawing.Point(16, 87)
        Me.chkObat.Name = "chkObat"
        Me.chkObat.Size = New System.Drawing.Size(49, 17)
        Me.chkObat.TabIndex = 7
        Me.chkObat.Text = "Obat"
        Me.chkObat.UseVisualStyleBackColor = True
        '
        'chkPembelian
        '
        Me.chkPembelian.AutoSize = True
        Me.chkPembelian.Location = New System.Drawing.Point(19, 34)
        Me.chkPembelian.Name = "chkPembelian"
        Me.chkPembelian.Size = New System.Drawing.Size(75, 17)
        Me.chkPembelian.TabIndex = 10
        Me.chkPembelian.Text = "Pembelian"
        Me.chkPembelian.UseVisualStyleBackColor = True
        '
        'chkPenjualan
        '
        Me.chkPenjualan.AutoSize = True
        Me.chkPenjualan.Location = New System.Drawing.Point(19, 57)
        Me.chkPenjualan.Name = "chkPenjualan"
        Me.chkPenjualan.Size = New System.Drawing.Size(73, 17)
        Me.chkPenjualan.TabIndex = 11
        Me.chkPenjualan.Text = "Penjualan"
        Me.chkPenjualan.UseVisualStyleBackColor = True
        '
        'chkPelanggan
        '
        Me.chkPelanggan.AutoSize = True
        Me.chkPelanggan.Location = New System.Drawing.Point(16, 133)
        Me.chkPelanggan.Name = "chkPelanggan"
        Me.chkPelanggan.Size = New System.Drawing.Size(77, 17)
        Me.chkPelanggan.TabIndex = 9
        Me.chkPelanggan.Text = "Pelanggan"
        Me.chkPelanggan.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkJenis)
        Me.GroupBox2.Controls.Add(Me.chkSatuan)
        Me.GroupBox2.Controls.Add(Me.chkSupplier)
        Me.GroupBox2.Controls.Add(Me.chkObat)
        Me.GroupBox2.Controls.Add(Me.chkPelanggan)
        Me.GroupBox2.Location = New System.Drawing.Point(34, 195)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 202)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Master data"
        '
        'chkPengguna
        '
        Me.chkPengguna.AutoSize = True
        Me.chkPengguna.Location = New System.Drawing.Point(16, 45)
        Me.chkPengguna.Name = "chkPengguna"
        Me.chkPengguna.Size = New System.Drawing.Size(75, 17)
        Me.chkPengguna.TabIndex = 4
        Me.chkPengguna.Text = "Pengguna"
        Me.chkPengguna.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkPembelian)
        Me.GroupBox3.Controls.Add(Me.chkPenjualan)
        Me.GroupBox3.Location = New System.Drawing.Point(277, 64)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox3.TabIndex = 20
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Transaksi"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkPengguna)
        Me.GroupBox1.Location = New System.Drawing.Point(34, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sistem"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Level :"
        '
        'cmbLevel
        '
        Me.cmbLevel.FormattingEnabled = True
        Me.cmbLevel.Location = New System.Drawing.Point(113, 14)
        Me.cmbLevel.Name = "cmbLevel"
        Me.cmbLevel.Size = New System.Drawing.Size(121, 21)
        Me.cmbLevel.TabIndex = 22
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(34, 419)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 21
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'HakAkses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 452)
        Me.Controls.Add(Me.chkAkses)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbLevel)
        Me.Controls.Add(Me.btnOk)
        Me.Name = "HakAkses"
        Me.Text = "HakAkses"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkAkses As System.Windows.Forms.CheckBox
    Friend WithEvents chkLprSupplier As System.Windows.Forms.CheckBox
    Friend WithEvents chkLprPenjualan As System.Windows.Forms.CheckBox
    Friend WithEvents chkLprPlgn As System.Windows.Forms.CheckBox
    Friend WithEvents chkLprObat As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents chkLprPembelian As System.Windows.Forms.CheckBox
    Friend WithEvents chkJenis As System.Windows.Forms.CheckBox
    Friend WithEvents chkSatuan As System.Windows.Forms.CheckBox
    Friend WithEvents chkSupplier As System.Windows.Forms.CheckBox
    Friend WithEvents chkObat As System.Windows.Forms.CheckBox
    Friend WithEvents chkPembelian As System.Windows.Forms.CheckBox
    Friend WithEvents chkPenjualan As System.Windows.Forms.CheckBox
    Friend WithEvents chkPelanggan As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkPengguna As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbLevel As System.Windows.Forms.ComboBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
End Class
