Imports System.Data.SqlClient
Imports QLBH.QLYBHDataSetTableAdapters

Public Class Restore_Pass
    Dim connectionString As String = "Data Source=HEHE\SQLEXPRESS;Initial Catalog=QLYBH;Integrated Security=True"

    Private Function rsINFOR()
        txtMKmoi.Clear()
        txtReMKmoi.Clear()
        txtTK.Clear()
    End Function
    Private Function isTKvalid(tk As String) As Boolean
        Return True
    End Function

    Private Function isTKexist(tk As String) As Boolean
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim querry As String = "SELECT COUNT (*) FROM TaiKhoan Where TenDN = @tk"
            Dim command As New SqlCommand(querry, connection)
            command.Parameters.AddWithValue("@tk", tk)

            Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
            Return count > 0
        End Using
    End Function

    Private Sub lblRSPW_Click(sender As Object, e As EventArgs) Handles lblRSPW.Click
        If isTKvalid(txtTK.Text) Then
            If isTKexist(txtTK.Text) Then
                Using connection As New SqlConnection(connectionString)
                    connection.Open()

                    Dim query As String = "UPDATE [TaiKhoan] SET MatKhau = @MatKhau WHERE TenDN = @TenDN"

                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@MatKhau", txtMKmoi.Text)
                        command.Parameters.AddWithValue("@TenDN", txtTK.Text)

                        command.ExecuteNonQuery()

                        MsgBox("Mật khẩu đã được cập nhật thành công!")
                        rsINFOR()
                        txtTK.Focus()
                    End Using
                End Using
            Else
                MsgBox("Không tồn tại tài khoản !")
            End If
        End If
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtTK.Focus()
    End Sub

    Private Sub lblForget_Click(sender As Object, e As EventArgs) Handles lblForget.Click
        Me.Hide()
        SignIn.Show()
    End Sub

    Private Sub lblSignUp_Click(sender As Object, e As EventArgs) Handles lblSignUp.Click
        Me.Hide()
        SignUp.Show()
    End Sub
End Class