<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MaKHDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoTenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgaySinhDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GioiTinhDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiaChiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DienThoaiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblKhachHangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QLYBHDataSet = New QLBH.QLYBHDataSet()
        Me.TblKhachHangTableAdapter = New QLBH.QLYBHDataSetTableAdapters.tblKhachHangTableAdapter()
        Me.lblAdd = New System.Windows.Forms.Label()
        Me.lblDelete = New System.Windows.Forms.Label()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.lblUpdate = New System.Windows.Forms.Label()
        Me.lblExit = New System.Windows.Forms.Label()
        Me.lblLogOut = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMaKH = New System.Windows.Forms.TextBox()
        Me.txtHoTen = New System.Windows.Forms.TextBox()
        Me.cbbGioiTinh = New System.Windows.Forms.ComboBox()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.txtDienThoai = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.NgaySinhPicker = New System.Windows.Forms.DateTimePicker()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblKhachHangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QLYBHDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaKHDataGridViewTextBoxColumn, Me.HoTenDataGridViewTextBoxColumn, Me.NgaySinhDataGridViewTextBoxColumn, Me.GioiTinhDataGridViewTextBoxColumn, Me.DiaChiDataGridViewTextBoxColumn, Me.DienThoaiDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblKhachHangBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(82, 60)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(900, 222)
        Me.DataGridView1.TabIndex = 0
        '
        'MaKHDataGridViewTextBoxColumn
        '
        Me.MaKHDataGridViewTextBoxColumn.DataPropertyName = "MaKH"
        Me.MaKHDataGridViewTextBoxColumn.HeaderText = "MaKH"
        Me.MaKHDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MaKHDataGridViewTextBoxColumn.Name = "MaKHDataGridViewTextBoxColumn"
        Me.MaKHDataGridViewTextBoxColumn.Width = 125
        '
        'HoTenDataGridViewTextBoxColumn
        '
        Me.HoTenDataGridViewTextBoxColumn.DataPropertyName = "HoTen"
        Me.HoTenDataGridViewTextBoxColumn.HeaderText = "HoTen"
        Me.HoTenDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.HoTenDataGridViewTextBoxColumn.Name = "HoTenDataGridViewTextBoxColumn"
        Me.HoTenDataGridViewTextBoxColumn.Width = 125
        '
        'NgaySinhDataGridViewTextBoxColumn
        '
        Me.NgaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh"
        Me.NgaySinhDataGridViewTextBoxColumn.HeaderText = "NgaySinh"
        Me.NgaySinhDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NgaySinhDataGridViewTextBoxColumn.Name = "NgaySinhDataGridViewTextBoxColumn"
        Me.NgaySinhDataGridViewTextBoxColumn.Width = 125
        '
        'GioiTinhDataGridViewTextBoxColumn
        '
        Me.GioiTinhDataGridViewTextBoxColumn.DataPropertyName = "GioiTinh"
        Me.GioiTinhDataGridViewTextBoxColumn.HeaderText = "GioiTinh"
        Me.GioiTinhDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.GioiTinhDataGridViewTextBoxColumn.Name = "GioiTinhDataGridViewTextBoxColumn"
        Me.GioiTinhDataGridViewTextBoxColumn.Width = 125
        '
        'DiaChiDataGridViewTextBoxColumn
        '
        Me.DiaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi"
        Me.DiaChiDataGridViewTextBoxColumn.HeaderText = "DiaChi"
        Me.DiaChiDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DiaChiDataGridViewTextBoxColumn.Name = "DiaChiDataGridViewTextBoxColumn"
        Me.DiaChiDataGridViewTextBoxColumn.Width = 125
        '
        'DienThoaiDataGridViewTextBoxColumn
        '
        Me.DienThoaiDataGridViewTextBoxColumn.DataPropertyName = "DienThoai"
        Me.DienThoaiDataGridViewTextBoxColumn.HeaderText = "DienThoai"
        Me.DienThoaiDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DienThoaiDataGridViewTextBoxColumn.Name = "DienThoaiDataGridViewTextBoxColumn"
        Me.DienThoaiDataGridViewTextBoxColumn.Width = 125
        '
        'TblKhachHangBindingSource
        '
        Me.TblKhachHangBindingSource.DataMember = "tblKhachHang"
        Me.TblKhachHangBindingSource.DataSource = Me.QLYBHDataSet
        '
        'QLYBHDataSet
        '
        Me.QLYBHDataSet.DataSetName = "QLYBHDataSet"
        Me.QLYBHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblKhachHangTableAdapter
        '
        Me.TblKhachHangTableAdapter.ClearBeforeFill = True
        '
        'lblAdd
        '
        Me.lblAdd.AutoSize = True
        Me.lblAdd.BackColor = System.Drawing.Color.GreenYellow
        Me.lblAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdd.Location = New System.Drawing.Point(92, 371)
        Me.lblAdd.Name = "lblAdd"
        Me.lblAdd.Size = New System.Drawing.Size(51, 20)
        Me.lblAdd.TabIndex = 1
        Me.lblAdd.Text = "Thêm"
        '
        'lblDelete
        '
        Me.lblDelete.AutoSize = True
        Me.lblDelete.BackColor = System.Drawing.Color.Yellow
        Me.lblDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDelete.Location = New System.Drawing.Point(197, 369)
        Me.lblDelete.Name = "lblDelete"
        Me.lblDelete.Size = New System.Drawing.Size(38, 20)
        Me.lblDelete.TabIndex = 2
        Me.lblDelete.Text = "Xóa"
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.BackColor = System.Drawing.Color.Aqua
        Me.lblSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.Location = New System.Drawing.Point(82, 447)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(80, 20)
        Me.lblSearch.TabIndex = 3
        Me.lblSearch.Text = "Tìm Kiếm"
        '
        'lblUpdate
        '
        Me.lblUpdate.AutoSize = True
        Me.lblUpdate.BackColor = System.Drawing.Color.Orange
        Me.lblUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpdate.Location = New System.Drawing.Point(271, 445)
        Me.lblUpdate.Name = "lblUpdate"
        Me.lblUpdate.Size = New System.Drawing.Size(86, 20)
        Me.lblUpdate.TabIndex = 4
        Me.lblUpdate.Text = "Chỉnh Sửa"
        '
        'lblExit
        '
        Me.lblExit.AutoSize = True
        Me.lblExit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lblExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExit.Location = New System.Drawing.Point(184, 445)
        Me.lblExit.Name = "lblExit"
        Me.lblExit.Size = New System.Drawing.Size(51, 20)
        Me.lblExit.TabIndex = 6
        Me.lblExit.Text = "Thoát"
        '
        'lblLogOut
        '
        Me.lblLogOut.AutoSize = True
        Me.lblLogOut.BackColor = System.Drawing.Color.Red
        Me.lblLogOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblLogOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogOut.Location = New System.Drawing.Point(271, 371)
        Me.lblLogOut.Name = "lblLogOut"
        Me.lblLogOut.Size = New System.Drawing.Size(87, 20)
        Me.lblLogOut.TabIndex = 5
        Me.lblLogOut.Text = "Đăng Xuất"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(502, 350)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Mã KH:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(504, 422)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Họ Tên"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(684, 350)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Ngày Sinh:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(684, 422)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Giới Tính:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(857, 350)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Địa Chỉ:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(857, 422)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Điện Thoại:"
        '
        'txtMaKH
        '
        Me.txtMaKH.Location = New System.Drawing.Point(505, 369)
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.Size = New System.Drawing.Size(131, 22)
        Me.txtMaKH.TabIndex = 13
        '
        'txtHoTen
        '
        Me.txtHoTen.Location = New System.Drawing.Point(505, 445)
        Me.txtHoTen.Name = "txtHoTen"
        Me.txtHoTen.Size = New System.Drawing.Size(131, 22)
        Me.txtHoTen.TabIndex = 14
        '
        'cbbGioiTinh
        '
        Me.cbbGioiTinh.FormattingEnabled = True
        Me.cbbGioiTinh.Items.AddRange(New Object() {"Nam", "Nữ", "Khác"})
        Me.cbbGioiTinh.Location = New System.Drawing.Point(687, 445)
        Me.cbbGioiTinh.Name = "cbbGioiTinh"
        Me.cbbGioiTinh.Size = New System.Drawing.Size(131, 24)
        Me.cbbGioiTinh.TabIndex = 15
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(860, 369)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(131, 22)
        Me.txtDiaChi.TabIndex = 17
        '
        'txtDienThoai
        '
        Me.txtDienThoai.Location = New System.Drawing.Point(860, 447)
        Me.txtDienThoai.Name = "txtDienThoai"
        Me.txtDienThoai.Size = New System.Drawing.Size(131, 22)
        Me.txtDienThoai.TabIndex = 18
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(409, 12)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker1.TabIndex = 19
        '
        'NgaySinhPicker
        '
        Me.NgaySinhPicker.Location = New System.Drawing.Point(687, 369)
        Me.NgaySinhPicker.Name = "NgaySinhPicker"
        Me.NgaySinhPicker.Size = New System.Drawing.Size(131, 22)
        Me.NgaySinhPicker.TabIndex = 20
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Location = New System.Drawing.Point(390, 369)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(59, 100)
        Me.btnSave.TabIndex = 21
        Me.btnSave.Text = "Lưu"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label7.Location = New System.Drawing.Point(390, 297)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(219, 25)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "Quản Lý Khách Hàng"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1066, 518)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.NgaySinhPicker)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txtDienThoai)
        Me.Controls.Add(Me.txtDiaChi)
        Me.Controls.Add(Me.cbbGioiTinh)
        Me.Controls.Add(Me.txtHoTen)
        Me.Controls.Add(Me.txtMaKH)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblExit)
        Me.Controls.Add(Me.lblLogOut)
        Me.Controls.Add(Me.lblUpdate)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.lblDelete)
        Me.Controls.Add(Me.lblAdd)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form3"
        Me.Text = "Quản Lý Bán Hàng"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblKhachHangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QLYBHDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents QLYBHDataSet As QLYBHDataSet
    Friend WithEvents TblKhachHangBindingSource As BindingSource
    Friend WithEvents TblKhachHangTableAdapter As QLYBHDataSetTableAdapters.tblKhachHangTableAdapter
    Friend WithEvents MaKHDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HoTenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NgaySinhDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GioiTinhDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiaChiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DienThoaiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents lblAdd As Label
    Friend WithEvents lblDelete As Label
    Friend WithEvents lblSearch As Label
    Friend WithEvents lblUpdate As Label
    Friend WithEvents lblExit As Label
    Friend WithEvents lblLogOut As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtMaKH As TextBox
    Friend WithEvents txtHoTen As TextBox
    Friend WithEvents cbbGioiTinh As ComboBox
    Friend WithEvents txtDiaChi As TextBox
    Friend WithEvents txtDienThoai As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents NgaySinhPicker As DateTimePicker
    Friend WithEvents btnSave As Button
    Friend WithEvents Label7 As Label
End Class
