Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim gpa As Double = Double.Parse(TextGPA.Text)
        Dim tinchiHT As Integer = Integer.Parse(TextTinChi.Text)
        Dim tongTin As Integer = Integer.Parse(TextTongTinChi.Text)
        Dim tinA As Integer = CheckEmptyInput(TextTinA.Text)
        Dim tinB As Integer = CheckEmptyInput(TextTinB.Text)
        Dim tinC As Integer = CheckEmptyInput(TextTinC.Text)
        Dim tinD As Integer = CheckEmptyInput(TextTinD.Text)

        If tinA + tinB + tinC + tinD > tongTin - tinchiHT Then
            MessageBox.Show("Tổng số tín chỉ của các môn A, B, C, D không được vượt quá số tín chỉ học tập hiện tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim gpaDuKien As Double = (gpa * tinchiHT + tinA * 4 + tinB * 3 + tinC * 2 + tinD) / tongTin
        TextGPAdukien.Text = gpaDuKien.ToString("0.00")
        If gpaDuKien >= 3.6 Then
            TextKetQua.Text = "Xuất sắc"
        ElseIf gpaDuKien >= 3.2 Then
            TextKetQua.Text = "Giỏi"
        ElseIf gpaDuKien >= 2.5 Then
            TextKetQua.Text = "Khá"
        ElseIf gpaDuKien >= 2 Then
            TextKetQua.Text = "Trung bình"
        Else
            TextKetQua.Text = "Yếu"
        End If
    End Sub

    Private Function CheckEmptyInput(ByVal input As String) As Integer
        If String.IsNullOrEmpty(input) Then
            Return 0
        Else
            Return Integer.Parse(input)
        End If
    End Function
End Class
