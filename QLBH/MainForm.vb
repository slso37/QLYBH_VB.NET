Imports System.Data.SqlClient

Public Class MainForm
    Dim connectionString As String = "Data Source=HEHE\SQLEXPRESS;Initial Catalog=QLYBH;Integrated Security=True"
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'QLYBHDataSet.tblKhachHang' table. You can move, or remove it, as needed.
        Me.TblKhachHangTableAdapter.Fill(Me.QLYBHDataSet.tblKhachHang)
        btnSave.Visible = False

    End Sub

    Private Function reset_infor()
        txtHoTen.Clear()
        cbbGioiTinh.ResetText()
        txtDienThoai.Clear()
        txtMaKH.Clear()
        NgaySinhPicker.ResetText()
        txtDiaChi.Clear()
    End Function
    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        End
    End Sub

    Private Sub lblLogOut_Click(sender As Object, e As EventArgs) Handles lblLogOut.Click
        Me.Hide()
        SignIn.Show()
    End Sub

    Private Sub lblAdd_Click(sender As Object, e As EventArgs) Handles lblAdd.Click
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim query As String = "INSERT INTO [tblKhachHang] ([MaKH], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai]) VALUES (@MaKH, @HoTen, @NgaySinh, @GioiTinh, @DiaChi, @DienThoai)"

            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@MaKH", txtMaKH.Text)
                command.Parameters.AddWithValue("@HoTen", txtHoTen.Text)
                command.Parameters.AddWithValue("@NgaySinh", NgaySinhPicker.Value)
                command.Parameters.AddWithValue("@GioiTinh", cbbGioiTinh.Text)
                command.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text)
                command.Parameters.AddWithValue("@DienThoai", txtDienThoai.Text)

                command.ExecuteNonQuery()
            End Using
        End Using

        ' Refresh data after adding a new record
        Me.TblKhachHangTableAdapter.Fill(Me.QLYBHDataSet.tblKhachHang)

        reset_infor()
    End Sub
    Private Sub lblDelete_Click(sender As Object, e As EventArgs) Handles lblDelete.Click
        Dim result As DialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "DELETE FROM [tblKhachHang] WHERE MaKH = @MaKH"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@MaKH", txtMaKH.Text)

                    command.ExecuteNonQuery()
                End Using
            End Using

            ' Refresh data after deleting a record
            Me.TblKhachHangTableAdapter.Fill(Me.QLYBHDataSet.tblKhachHang)
        End If
    End Sub

    Private Sub lblSearch_Click(sender As Object, e As EventArgs) Handles lblSearch.Click
        Dim search = InputBox("Nhập mã khách bạn muốn tìm vào đây", "Tìm kiếm")
        TblKhachHangBindingSource.Filter = "MaKH ='" & search & " '"
    End Sub

    Private Sub lblUpdate_Click(sender As Object, e As EventArgs) Handles lblUpdate.Click
        Dim search As String = InputBox("Nhập mã khách bạn muốn cập nhật vào đây", "Cập nhật")

        ' Kiểm tra xem mã khách hàng đã được nhập hay chưa
        If Not String.IsNullOrEmpty(search) Then

            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT * FROM [tblKhachHang] WHERE MaKH = @MaKH"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@MaKH", search)

                    Using reader As SqlDataReader = command.ExecuteReader()
                        ' Kiểm tra xem có dữ liệu trả về hay không
                        If reader.Read() Then
                            ' Hiển thị thông tin khách hàng lên các điều khiển TextBox
                            txtMaKH.Text = reader("MaKH").ToString()
                            txtHoTen.Text = reader("HoTen").ToString()
                            cbbGioiTinh.Text = reader("GioiTinh").ToString()
                            txtDiaChi.Text = reader("DiaChi").ToString()
                            txtDienThoai.Text = reader("DienThoai").ToString()

                            btnSave.Visible = True
                        Else
                            MessageBox.Show("Không tìm thấy khách hàng với mã đã nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                End Using
            End Using
            ' Refresh data after deleting a record
            Me.TblKhachHangTableAdapter.Fill(Me.QLYBHDataSet.tblKhachHang)
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not String.IsNullOrEmpty(txtMaKH.Text) Then
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "UPDATE [tblKhachHang] SET HoTen = @HoTen, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, DiaChi = @DiaChi, DienThoai = @DienThoai WHERE MaKH = @MaKH"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@HoTen", txtHoTen.Text)
                    command.Parameters.AddWithValue("@NgaySinh", NgaySinhPicker.Value)
                    command.Parameters.AddWithValue("@GioiTinh", cbbGioiTinh.Text)
                    command.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text)
                    command.Parameters.AddWithValue("@DienThoai", txtDienThoai.Text)
                    command.Parameters.AddWithValue("@MaKH", txtMaKH.Text)

                    command.ExecuteNonQuery()

                    MessageBox.Show("Cập nhật thông tin khách hàng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            End Using
            ' Refresh data after deleting a record
            Me.TblKhachHangTableAdapter.Fill(Me.QLYBHDataSet.tblKhachHang)
        End If

        reset_infor()

        btnSave.Visible = False

    End Sub
End Class