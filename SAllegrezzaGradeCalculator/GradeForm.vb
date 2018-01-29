Imports System.Text.RegularExpressions
Public Class GradeForm
    Dim intStudent0Grades(3) As Integer
    Dim intStudent1Grades(3) As Integer
    Dim intStudent2Grades(3) As Integer
    Dim intStudent3Grades(3) As Integer
    Dim intStudent4Grades(3) As Integer
    Dim strStudentNames(4) As String

    Private Function ValidateInput() As Boolean
        Dim intermediatenumber As Integer
        'First, we mark each invalid input.
        'Then we test each input's background color
        'If it's red, we have in invalid input
        For Each control In pnlGrades.Controls 'Grade validation
            If TypeOf control Is TextBox Then
                If (control.text.Length < 1) Or Not Regex.Match(control.text, "[0-9]").Success Or Not Int32.TryParse(control.text, intermediatenumber) Or Not intermediatenumber - 100 <= 0 Then
                    control.BackColor = Color.LightCoral
                End If
            End If
        Next
        For Each control In pnlNames.Controls
            If (control.Text.length = 0) Or Regex.Match(control.text, "\d").Success Then
                control.BackColor = Color.LightCoral
            End If
        Next
        For Each control In pnlGrades.Controls
            If TypeOf control Is TextBox Then
                If control.BackColor = Color.LightCoral Then
                    Return False
                    Exit Function

                End If
            End If
        Next
        For Each control In pnlGrades.Controls
            If TypeOf control Is TextBox Then
                If control.BackColor = Color.LightCoral Then
                    Return False
                    Exit Function

                End If
            End If
        Next

        Return True
    End Function
    Public ReadOnly Property StudentNames() As String
        Get
            Return strStudentNames.ToString
        End Get
    End Property

    Public ReadOnly Property Student0Average() As Integer 'returns a nested array of students' grades
        Get
            Return intStudent0Grades.Average
        End Get
    End Property
    Public ReadOnly Property Student1Average() As Integer 'returns a nested array of students' grades
        Get
            Return intStudent1Grades.Average
        End Get
    End Property
    Public ReadOnly Property Student2Average() As Integer 'returns a nested array of students' grades
        Get
            Return intStudent2Grades.Average
        End Get
    End Property
    Public ReadOnly Property Student3Average() As Integer 'returns a nested array of students' grades
        Get
            Return intStudent3Grades.Average
        End Get
    End Property
    Public ReadOnly Property Student4Average() As Integer 'returns a nested array of students' grades
        Get
            Return CType(intStudent4Grades.Average, String)
        End Get
    End Property
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        My.Forms.GradeForm.Hide()
    End Sub

    Private Sub btnSaveGrades_Click(sender As Object, e As EventArgs) Handles btnSaveGrades.Click
        'Makes sure the user entered something
        If ValidateInput() = False Then
            lblWarning.Show()
            lblWarning.Text = "Please correct the mistakes"
            Exit Sub
        End If

        'Puts text in the form1 textboxes
        Form1.txtStudent0Name.Text = txtStudent0Name.Text
            Form1.txtStudent1Name.Text = txtStudent1Name.Text
            Form1.txtStudent2Name.Text = txtStudent2Name.Text
            Form1.txtStudent3Name.Text = txtStudent3Name.Text
            Form1.txtStudent4Name.Text = txtStudent4Name.Text

            'Collect the grades for each student
            'I don't know how to loop through controls
            intStudent0Grades(0) = CInt(txtStdnt0gr0.Text)
            intStudent0Grades(1) = CInt(txtStdnt0gr1.Text)
            intStudent0Grades(2) = CInt(txtStdnt0gr2.Text)
            intStudent0Grades(3) = CInt(txtStdnt0gr3.Text)

            intStudent1Grades(0) = CInt(txtStdnt1gr0.Text)
            intStudent1Grades(1) = CInt(txtStdnt1gr1.Text)
            intStudent1Grades(2) = CInt(txtStdnt1gr2.Text)
            intStudent1Grades(3) = CInt(txtStdnt1gr3.Text)

            intStudent2Grades(0) = CInt(txtStdnt2gr0.Text)
            intStudent2Grades(1) = CInt(txtStdnt2gr1.Text)
            intStudent2Grades(2) = CInt(txtStdnt2gr2.Text)
            intStudent2Grades(3) = CInt(txtStdnt2gr3.Text)

            intStudent3Grades(0) = CInt(txtStdnt3gr0.Text)
            intStudent3Grades(1) = CInt(txtStdnt3gr1.Text)
            intStudent3Grades(2) = CInt(txtStdnt3gr2.Text)
            intStudent3Grades(3) = CInt(txtStdnt3gr3.Text)

            intStudent4Grades(0) = CInt(txtStdnt4gr0.Text)
            intStudent4Grades(1) = CInt(txtStdnt4gr1.Text)
            intStudent4Grades(2) = CInt(txtStdnt4gr2.Text)
            intStudent4Grades(3) = CInt(txtStdnt4gr3.Text)
        lblWarning.Text = ""
        My.Forms.GradeForm.Hide()





    End Sub

    Private Sub GradeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWarning.Hide()

    End Sub

    Private Sub ResetColor(sender As Object, e As MouseEventArgs) Handles txtStudent4Name.MouseDown, txtStudent3Name.MouseDown, txtStudent2Name.MouseDown, txtStudent1Name.MouseDown, txtStudent0Name.MouseDown, txtStdnt4gr3.MouseDown, txtStdnt4gr2.MouseDown, txtStdnt4gr1.MouseDown, txtStdnt4gr0.MouseDown, txtStdnt3gr3.MouseDown, txtStdnt3gr2.MouseDown, txtStdnt3gr1.MouseDown, txtStdnt3gr0.MouseDown, txtStdnt2gr3.MouseDown, txtStdnt2gr2.MouseDown, txtStdnt2gr1.MouseDown, txtStdnt2gr0.MouseDown, txtStdnt1gr3.MouseDown, txtStdnt1gr2.MouseDown, txtStdnt1gr1.MouseDown, txtStdnt1gr0.MouseDown, txtStdnt0gr3.MouseDown, txtStdnt0gr2.MouseDown, txtStdnt0gr1.MouseDown, txtStdnt0gr0.MouseDown, txtStdnt4gr3.CursorChanged, txtStdnt4gr2.CursorChanged, txtStdnt4gr1.CursorChanged, txtStdnt4gr0.CursorChanged, txtStdnt3gr3.CursorChanged, txtStdnt3gr2.CursorChanged, txtStdnt3gr1.CursorChanged, txtStdnt3gr0.CursorChanged, txtStdnt2gr3.CursorChanged, txtStdnt2gr2.CursorChanged, txtStdnt2gr1.CursorChanged, txtStdnt2gr0.CursorChanged, txtStdnt1gr3.CursorChanged, txtStdnt1gr2.CursorChanged, txtStdnt1gr1.CursorChanged, txtStdnt1gr0.CursorChanged, txtStdnt0gr3.CursorChanged, txtStdnt0gr2.CursorChanged, txtStdnt0gr1.CursorChanged, txtStdnt0gr0.CursorChanged
        sender.BackColor = Color.White
    End Sub

    Private Sub btnResetForm_Click(sender As Object, e As EventArgs) Handles btnResetForm.Click
        If MessageBox.Show("Are you sure you want to remove all grades?", "This is the caption option", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            For Each control In pnlGrades.Controls
                If TypeOf control Is TextBox Then
                    control.text = ""
                End If
            Next

        End If
    End Sub

    Private Sub ResetColor(sender As Object, e As EventArgs)

    End Sub
End Class