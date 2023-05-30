Imports System.Data.SqlClient
Imports QLBH.QLYBHDataSetTableAdapters

Public Class SignUp
    Dim connectionString As String = "Data Source=HEHE\SQLEXPRESS;Initial Catalog=QLYBH;Integrated Security=True"
    Private Sub lblLogin_Click(sender As Object, e As EventArgs) Handles lblLogin.Click
        Me.Hide()
        SignIn.Show()
    End Sub

    Private Function reset_infor()
        txtMK.Clear()
        txtReMK.Clear()
        txtTK.Clear()
    End Function
    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) 
        If txtReMK.Text = txtTK.Text Then
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "INSERT INTO [TaiKhoan] ([TenDN], [MatKhau]) VALUES (@TenDN, @MatKhau)"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@TenDN", txtTK.Text)
                    command.Parameters.AddWithValue("@MatKhau", txtMK.Text)

                    command.ExecuteNonQuery()
                End Using
            End Using
            reset_infor()
            MsgBox("Thêm tài khoản thành công !!")
        Else
            MsgBox("Mật khẩu nhập lại không trùng !!")
            txtReMK.Clear()
            txtReMK.Focus()
        End If
    End Sub

    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        End
    End Sub

    Private Sub txtTK_TextChanged(sender As Object, e As EventArgs) Handles txtTK.TextChanged
        txtTK.Focus()
    End Sub
End Class
