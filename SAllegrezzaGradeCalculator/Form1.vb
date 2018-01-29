
Public Class Form1
    Private Function CalculateAvg(ByVal avg As Integer)
        Select Case avg
            Case 90 To 100
                Return "A"
            Case 80 To 89
                Return "B"
            Case 70 To 79
                Return "C"
            Case 60 To 69
                Return "D"
            Case 0 To 59
                Return "F"
        End Select
        Return "Error"
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEditStudent.Click    'Unhides grade entry form
        My.Forms.GradeForm.Show()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        txtStdnt0Avg.Text = GradeForm.Student0Average
        txtStdnt0Grade.Text = CalculateAvg(GradeForm.Student0Average)

        txtStdnt1Avg.Text = GradeForm.Student1Average
        txtStdnt1Grade.Text = CalculateAvg(GradeForm.Student1Average)

        txtStdnt2Avg.Text = GradeForm.Student2Average
        txtStdnt2Grade.Text = CalculateAvg(GradeForm.Student2Average)

        txtStdnt3Avg.Text = GradeForm.Student3Average
        txtStdnt3Grade.Text = CalculateAvg(GradeForm.Student3Average)

        txtStdnt4Avg.Text = GradeForm.Student4Average
        txtStdnt4Grade.Text = CalculateAvg(GradeForm.Student4Average)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        My.Forms.Form1.Close()
    End Sub
End Class
