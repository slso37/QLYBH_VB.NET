<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignIn
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblExit = New System.Windows.Forms.Label()
        Me.lblSignUp = New System.Windows.Forms.Label()
        Me.lblSignIn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMK = New System.Windows.Forms.TextBox()
        Me.txtTK = New System.Windows.Forms.TextBox()
        Me.lblForget = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label5.Location = New System.Drawing.Point(125, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 25)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Đăng Nhập"
        '
        'lblExit
        '
        Me.lblExit.AutoSize = True
        Me.lblExit.BackColor = System.Drawing.Color.Red
        Me.lblExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblExit.Location = New System.Drawing.Point(203, 171)
        Me.lblExit.Name = "lblExit"
        Me.lblExit.Size = New System.Drawing.Size(42, 16)
        Me.lblExit.TabIndex = 34
        Me.lblExit.Text = "Thoát"
        '
        'lblSignUp
        '
        Me.lblSignUp.AutoSize = True
        Me.lblSignUp.BackColor = System.Drawing.Color.Chartreuse
        Me.lblSignUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSignUp.Location = New System.Drawing.Point(115, 171)
        Me.lblSignUp.Name = "lblSignUp"
        Me.lblSignUp.Size = New System.Drawing.Size(53, 16)
        Me.lblSignUp.TabIndex = 33
        Me.lblSignUp.Text = "Đăng Kí"
        '
        'lblSignIn
        '
        Me.lblSignIn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblSignIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSignIn.Location = New System.Drawing.Point(251, 89)
        Me.lblSignIn.Name = "lblSignIn"
        Me.lblSignIn.Size = New System.Drawing.Size(74, 65)
        Me.lblSignIn.TabIndex = 32
        Me.lblSignIn.Text = "Đăng Nhập"
        Me.lblSignIn.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 16)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Mật Khẩu:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 16)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Tài Khoản:"
        '
        'txtMK
        '
        Me.txtMK.Location = New System.Drawing.Point(118, 132)
        Me.txtMK.Name = "txtMK"
        Me.txtMK.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtMK.Size = New System.Drawing.Size(127, 22)
        Me.txtMK.TabIndex = 29
        '
        'txtTK
        '
        Me.txtTK.Location = New System.Drawing.Point(118, 89)
        Me.txtTK.Name = "txtTK"
        Me.txtTK.Size = New System.Drawing.Size(127, 22)
        Me.txtTK.TabIndex = 28
        '
        'lblForget
        '
        Me.lblForget.AutoSize = True
        Me.lblForget.BackColor = System.Drawing.SystemColors.Highlight
        Me.lblForget.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblForget.Location = New System.Drawing.Point(129, 197)
        Me.lblForget.Name = "lblForget"
        Me.lblForget.Size = New System.Drawing.Size(97, 16)
        Me.lblForget.TabIndex = 36
        Me.lblForget.Text = "Quên Mật Khẩu"
        '
        'SignIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 242)
        Me.Controls.Add(Me.lblForget)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblExit)
        Me.Controls.Add(Me.lblSignUp)
        Me.Controls.Add(Me.lblSignIn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMK)
        Me.Controls.Add(Me.txtTK)
        Me.Name = "SignIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Đăng Nhập"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents lblExit As Label
    Friend WithEvents lblSignUp As Label
    Friend WithEvents lblSignIn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMK As TextBox
    Friend WithEvents txtTK As TextBox
    Friend WithEvents lblForget As Label
End Class
