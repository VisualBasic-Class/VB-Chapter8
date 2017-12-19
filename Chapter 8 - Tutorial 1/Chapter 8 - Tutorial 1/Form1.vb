Public Class Form1

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Const intMax_SUBSCRIPT As Integer = 4         ' The maximum subscript.
        Dim intNumbers(intMax_SUBSCRIPT) As Integer   ' Array declaration.
        Dim intCount As Integer                       ' Loop counter.

        Dim rand As New Random

        For intCount = 0 To intMax_SUBSCRIPT          ' Fill the array with random numbers.
            intNumbers(intCount) = rand.Next(100)
        Next

        lblFirst.Text = intNumbers(0).ToString()      ' Display the array elements in labels.
        lblSecond.Text = intNumbers(1).ToString()
        lblThird.Text = intNumbers(2).ToString()
        lblFourth.Text = intNumbers(3).ToString()
        lblFifth.Text = intNumbers(4).ToString()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
