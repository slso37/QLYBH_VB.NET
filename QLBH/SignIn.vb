Imports System.Data.SqlClient
Imports System.Windows
Imports QLBH.QLYBHDataSetTableAdapters

Public Class SignIn
    Dim connectionString As String = "Data Source=HEHE\SQLEXPRESS;Initial Catalog=QLYBH;Integrated Security=True"
    Private Sub lblSignUp_Click(sender As Object, e As EventArgs) Handles lblSignUp.Click
        Me.Hide()
        SignUp.Show()
    End Sub

    Private Function isTKvalid(tk As String) As Boolean
        Return True
    End Function

    Private Function isTKexist(tk As String, mk As String) As Boolean
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim querry As String = "SELECT COUNT (*) FROM TaiKhoan Where TenDN = @tk and MatKhau = @mk"
            Dim command As New SqlCommand(querry, connection)
            command.Parameters.AddWithValue("@tk", tk)
            command.Parameters.AddWithValue("@mk", mk)

            Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
            Return count > 0
        End Using
    End Function
    Private Sub lblSignIn_Click(sender As Object, e As EventArgs) Handles lblSignIn.Click
        Dim TK As String = txtTK.Text.Trim()
        Dim MK As String = txtMK.Text.Trim()

        If isTKvalid(TK) Then
            If (isTKexist(TK, MK)) Then
                Me.Hide()
                MainForm.Show()
            Else
                MsgBox("Sai tài khoản hoặc mật khẩu !")
            End If

        End If
    End Sub

    Private Sub lblForget_Click(sender As Object, e As EventArgs) Handles lblForget.Click
        Me.Hide()
        Restore_Pass.Show()
    End Sub

    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        End
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtTK.Focus()
    End Sub
End Class