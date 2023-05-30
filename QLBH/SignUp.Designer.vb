<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUp
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtReMK = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblExit = New System.Windows.Forms.Label()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMK = New System.Windows.Forms.TextBox()
        Me.txtTK = New System.Windows.Forms.TextBox()
        Me.TaiKhoanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QLYBHDataSet = New QLBH.QLYBHDataSet()
        Me.TaiKhoanTableAdapter = New QLBH.QLYBHDataSetTableAdapters.TaiKhoanTableAdapter()
        Me.btnSignUp = New System.Windows.Forms.Button()
        CType(Me.TaiKhoanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QLYBHDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 16)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Nhập lại:"
        '
        'txtReMK
        '
        Me.txtReMK.Location = New System.Drawing.Point(124, 179)
        Me.txtReMK.Name = "txtReMK"
        Me.txtReMK.Size = New System.Drawing.Size(127, 22)
        Me.txtReMK.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label5.Location = New System.Drawing.Point(94, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(195, 25)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Đăng Kí Tài Khoản"
        '
        'lblExit
        '
        Me.lblExit.AutoSize = True
        Me.lblExit.BackColor = System.Drawing.Color.Red
        Me.lblExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblExit.Location = New System.Drawing.Point(209, 240)
        Me.lblExit.Name = "lblExit"
        Me.lblExit.Size = New System.Drawing.Size(42, 16)
        Me.lblExit.TabIndex = 24
        Me.lblExit.Text = "Thoát"
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblLogin.Location = New System.Drawing.Point(121, 240)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(75, 16)
        Me.lblLogin.TabIndex = 23
        Me.lblLogin.Text = "Đăng Nhập"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 16)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Mật Khẩu:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 16)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Tài Khoản:"
        '
        'txtMK
        '
        Me.txtMK.Location = New System.Drawing.Point(124, 130)
        Me.txtMK.Name = "txtMK"
        Me.txtMK.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtMK.Size = New System.Drawing.Size(127, 22)
        Me.txtMK.TabIndex = 19
        '
        'txtTK
        '
        Me.txtTK.Location = New System.Drawing.Point(124, 87)
        Me.txtTK.Name = "txtTK"
        Me.txtTK.Size = New System.Drawing.Size(127, 22)
        Me.txtTK.TabIndex = 18
        '
        'TaiKhoanBindingSource
        '
        Me.TaiKhoanBindingSource.DataMember = "TaiKhoan"
        Me.TaiKhoanBindingSource.DataSource = Me.QLYBHDataSet
        '
        'QLYBHDataSet
        '
        Me.QLYBHDataSet.DataSetName = "QLYBHDataSet"
        Me.QLYBHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TaiKhoanTableAdapter
        '
        Me.TaiKhoanTableAdapter.ClearBeforeFill = True
        '
        'btnSignUp
        '
        Me.btnSignUp.BackColor = System.Drawing.Color.Chartreuse
        Me.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSignUp.Location = New System.Drawing.Point(257, 90)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(74, 114)
        Me.btnSignUp.TabIndex = 28
        Me.btnSignUp.Text = "Đăng Kí"
        Me.btnSignUp.UseVisualStyleBackColor = False
        '
        'SignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 302)
        Me.Controls.Add(Me.btnSignUp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtReMK)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblExit)
        Me.Controls.Add(Me.lblLogin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMK)
        Me.Controls.Add(Me.txtTK)
        Me.Name = "SignUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Đăng Kí"
        CType(Me.TaiKhoanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QLYBHDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents txtReMK As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblExit As Label
    Friend WithEvents lblLogin As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMK As TextBox
    Friend WithEvents txtTK As TextBox
    Friend WithEvents QLYBHDataSet As QLYBHDataSet
    Friend WithEvents TaiKhoanBindingSource As BindingSource
    Friend WithEvents TaiKhoanTableAdapter As QLYBHDataSetTableAdapters.TaiKhoanTableAdapter
    Friend WithEvents btnSignUp As Button
End Class
