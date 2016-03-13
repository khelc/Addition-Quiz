Public Class Form1

    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Dim Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
    End Function

    Public Sub NumGenerator()
        Dim FirstNumber(1000) As Integer
        For i As Integer = 0 To FirstNumber.Length - 1
            lblNum1.Text = GetRandom(1, 1000)
        Next

        Dim SecondNumber(1000) As Integer
        For i As Integer = 0 To SecondNumber.Length - 1
            lblNum2.Text = GetRandom(1, 1000)
        Next
    End Sub
    Public Sub Operation()
        Dim result As Integer
        result = lblNum1.Text + +lblNum2.Text

        If result = txtBoxSum.Text Then
            lblScore.Text += 1
            lblTotal.Text += 1
        Else
            lblTotal.Text += 1
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NumGenerator()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Operation()
        NumGenerator()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
