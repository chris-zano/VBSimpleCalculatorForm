Public Class Form1
    Dim firstValue, secondValue, result As Integer
    Dim op As String
    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        TxtDisplay.Text = ""
    End Sub

    Private Sub Number_Click(sender As Object, e As EventArgs) Handles btn_point.Click, btn_9.Click, btn_8.Click, btn_7.Click, btn_6.Click, btn_5.Click, btn_4.Click, btn_3.Click, btn_2.Click, btn_1.Click, btn_0.Click
        Dim b As Button = sender

        If (TxtDisplay.Text = "0") Then
            TxtDisplay.Text = ""
            TxtDisplay.Text = b.Text

        ElseIf (b.Text = ".") Then
            If (Not TxtDisplay.Text.Contains(".")) Then
                TxtDisplay.Text = TxtDisplay.Text + b.Text
            End If

        Else
            TxtDisplay.Text = TxtDisplay.Text + b.Text
        End If
    End Sub

    Private Sub btn_equalto_Click(sender As Object, e As EventArgs) Handles btn_equalto.Click
        If TxtDisplay.Text = "" Then
            secondValue = 0
        Else
            secondValue = CInt(TxtDisplay.Text)
        End If

        If op = "+" Then
            result = firstValue + secondValue
            TxtDisplay.Text = result
        ElseIf op = "-" Then
            result = firstValue - secondValue
            TxtDisplay.Text = result
        ElseIf op = "*" Then
            result = firstValue * secondValue
            TxtDisplay.Text = result
        ElseIf op = "/" Then
            result = firstValue / secondValue
            TxtDisplay.Text = result
        End If
        firstValue = result
        secondValue = 0
        result = 0
    End Sub

    Private Sub btn_clearall_Click(sender As Object, e As EventArgs) Handles btn_clearall.Click
        TxtDisplay.Text = "0"
        firstValue = 0
        secondValue = 0
        result = 0
        op = ""
    End Sub

    Private Sub delBtn(sender As Object, e As EventArgs) Handles btn_del.Click
        If TxtDisplay.Text.Length > 0 Then
            TxtDisplay.Text = TxtDisplay.Text.Remove(TxtDisplay.Text.Length - 1, 1)
        End If
    End Sub

    Private Sub operator_click(sender As Object, e As EventArgs) Handles btn_sub.Click, btn_mul.Click, btn_div.Click, btn_add.Click
        Dim b As Button = DirectCast(sender, Button)
        firstValue = TxtDisplay.Text
        op = b.Text
        TxtDisplay.Text = ""
    End Sub
End Class
