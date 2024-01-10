<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Supplier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Supplier))
        Me.DGSupplier = New System.Windows.Forms.DataGridView()
        Me.CariKontak = New System.Windows.Forms.RadioButton()
        Me.CariNmSupplier = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CariKdSupplier = New System.Windows.Forms.RadioButton()
        Me.txtCariData = New System.Windows.Forms.TextBox()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.txtKontak = New System.Windows.Forms.TextBox()
        Me.txtTelepon = New System.Windows.Forms.TextBox()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.txtNamaSupplier = New System.Windows.Forms.TextBox()
        Me.txtKodeSupplier = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DGSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGSupplier
        '
        Me.DGSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGSupplier.Location = New System.Drawing.Point(8, 186)
        Me.DGSupplier.Name = "DGSupplier"
        Me.DGSupplier.Size = New System.Drawing.Size(689, 168)
        Me.DGSupplier.TabIndex = 34
        '
        'CariKontak
        '
        Me.CariKontak.AutoSize = True
        Me.CariKontak.Location = New System.Drawing.Point(198, 20)
        Me.CariKontak.Name = "CariKontak"
        Me.CariKontak.Size = New System.Drawing.Size(59, 17)
        Me.CariKontak.TabIndex = 13
        Me.CariKontak.TabStop = True
        Me.CariKontak.Text = "Kontak"
        Me.CariKontak.UseVisualStyleBackColor = True
        '
        'CariNmSupplier
        '
        Me.CariNmSupplier.AutoSize = True
        Me.CariNmSupplier.Location = New System.Drawing.Point(102, 20)
        Me.CariNmSupplier.Name = "CariNmSupplier"
        Me.CariNmSupplier.Size = New System.Drawing.Size(94, 17)
        Me.CariNmSupplier.TabIndex = 12
        Me.CariNmSupplier.TabStop = True
        Me.CariNmSupplier.Text = "Nama Supplier"
        Me.CariNmSupplier.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CariKontak)
        Me.GroupBox1.Controls.Add(Me.CariNmSupplier)
        Me.GroupBox1.Controls.Add(Me.CariKdSupplier)
        Me.GroupBox1.Controls.Add(Me.txtCariData)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 129)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(689, 51)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cari Berdasarkan"
        '
        'CariKdSupplier
        '
        Me.CariKdSupplier.AutoSize = True
        Me.CariKdSupplier.Location = New System.Drawing.Point(6, 20)
        Me.CariKdSupplier.Name = "CariKdSupplier"
        Me.CariKdSupplier.Size = New System.Drawing.Size(91, 17)
        Me.CariKdSupplier.TabIndex = 11
        Me.CariKdSupplier.TabStop = True
        Me.CariKdSupplier.Text = "Kode Supplier"
        Me.CariKdSupplier.UseVisualStyleBackColor = True
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
        Me.btnTutup.Location = New System.Drawing.Point(628, 69)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(75, 54)
        Me.btnTutup.TabIndex = 32
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnTutup.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Image = CType(resources.GetObject("btnHapus.Image"), System.Drawing.Image)
        Me.btnHapus.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnHapus.Location = New System.Drawing.Point(547, 69)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 54)
        Me.btnHapus.TabIndex = 31
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Image = CType(resources.GetObject("btnBatal.Image"), System.Drawing.Image)
        Me.btnBatal.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBatal.Location = New System.Drawing.Point(466, 69)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 54)
        Me.btnBatal.TabIndex = 30
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnUbah
        '
        Me.btnUbah.Image = CType(resources.GetObject("btnUbah.Image"), System.Drawing.Image)
        Me.btnUbah.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnUbah.Location = New System.Drawing.Point(385, 69)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(75, 54)
        Me.btnUbah.TabIndex = 29
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUbah.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Image = CType(resources.GetObject("btnSimpan.Image"), System.Drawing.Image)
        Me.btnSimpan.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSimpan.Location = New System.Drawing.Point(304, 69)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 54)
        Me.btnSimpan.TabIndex = 28
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'txtKontak
        '
        Me.txtKontak.Location = New System.Drawing.Point(372, 30)
        Me.txtKontak.Name = "txtKontak"
        Me.txtKontak.Size = New System.Drawing.Size(100, 20)
        Me.txtKontak.TabIndex = 27
        '
        'txtTelepon
        '
        Me.txtTelepon.Location = New System.Drawing.Point(372, 4)
        Me.txtTelepon.Name = "txtTelepon"
        Me.txtTelepon.Size = New System.Drawing.Size(100, 20)
        Me.txtTelepon.TabIndex = 26
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(101, 56)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(197, 50)
        Me.txtAlamat.TabIndex = 25
        '
        'txtNamaSupplier
        '
        Me.txtNamaSupplier.Location = New System.Drawing.Point(101, 30)
        Me.txtNamaSupplier.Name = "txtNamaSupplier"
        Me.txtNamaSupplier.Size = New System.Drawing.Size(197, 20)
        Me.txtNamaSupplier.TabIndex = 24
        '
        'txtKodeSupplier
        '
        Me.txtKodeSupplier.Location = New System.Drawing.Point(101, 4)
        Me.txtKodeSupplier.Name = "txtKodeSupplier"
        Me.txtKodeSupplier.Size = New System.Drawing.Size(100, 20)
        Me.txtKodeSupplier.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(327, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Kontak"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(327, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Telepon"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Alamat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Nama Supplier"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Kode Supplier"
        '
        'Supplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 359)
        Me.Controls.Add(Me.DGSupplier)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnTutup)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnUbah)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.txtKontak)
        Me.Controls.Add(Me.txtTelepon)
        Me.Controls.Add(Me.txtAlamat)
        Me.Controls.Add(Me.txtNamaSupplier)
        Me.Controls.Add(Me.txtKodeSupplier)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Supplier"
        Me.Text = "Supplier"
        CType(Me.DGSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGSupplier As System.Windows.Forms.DataGridView
    Friend WithEvents CariKontak As System.Windows.Forms.RadioButton
    Friend WithEvents CariNmSupplier As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CariKdSupplier As System.Windows.Forms.RadioButton
    Friend WithEvents txtCariData As System.Windows.Forms.TextBox
    Friend WithEvents btnTutup As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnUbah As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents txtKontak As System.Windows.Forms.TextBox
    Friend WithEvents txtTelepon As System.Windows.Forms.TextBox
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaSupplier As System.Windows.Forms.TextBox
    Friend WithEvents txtKodeSupplier As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
