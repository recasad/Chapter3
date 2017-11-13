Public Class Form1
    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        ' This event handler performs addition.
        ' Declare a variable to hold the result.
        Dim dblResult As Double

        'Indicate "+" as the opperation.
        lblOperation.Text = "+"

        'Add the two numbers and store the result in dblResult.
        dblResult = CDbl(txtNumber1.Text) + CDbl(txtNumber2.Text)

        ' Display the result.
        lblResult.Text = CStr(dblResult)
    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        ' This event handler performs subtraction.
        ' Declare a variable to hold the result.
        Dim dblResult As Double

        'Indicate "-" as the opperation.
        lblOperation.Text = "-"

        'Add the two numbers and store the result in dblResult.
        dblResult = CDbl(txtNumber1.Text) - CDbl(txtNumber2.Text)

        ' Display the result.
        lblResult.Text = CStr(dblResult)
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        ' This event handler performs multiplication.
        ' Declare a variable to hold the result.
        Dim dblResult As Double

        'Indicate "*" as the opperation.
        lblOperation.Text = "*"

        'Add the two numbers and store the result in dblResult.
        dblResult = CDbl(txtNumber1.Text) * CDbl(txtNumber2.Text)

        ' Display the result.
        lblResult.Text = CStr(dblResult)
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        ' This event handler performs division.
        ' Declare a variable to hold the result.
        Dim dblResult As Double

        'Indicate "/" as the opperation.
        lblOperation.Text = "/"

        'Add the two numbers and store the result in dblResult.
        dblResult = CDbl(txtNumber1.Text) / CDbl(txtNumber2.Text)

        ' Display the result.
        lblResult.Text = CStr(dblResult)
    End Sub

    Private Sub btnIntegerDivide_Click(sender As Object, e As EventArgs) Handles btnIntegerDivide.Click
        ' This event handler performs intiger division.
        ' Declare a variable to hold the result.
        Dim intResult As Integer

        'Indicate "\" as the opperation.
        lblOperation.Text = "\"

        'Add the two numbers and store the result in dblResult.
        intResult = CInt(txtNumber1.Text) \ CInt(txtNumber2.Text)

        ' Display the result.
        lblResult.Text = CStr(intResult)
    End Sub

    Private Sub btnExponent_Click(sender As Object, e As EventArgs) Handles btnExponent.Click
        ' This event handler performs exponentiation.
        ' Declare a variable to hold the result.
        Dim dblResult As Double

        'Indicate "^" as the opperation.
        lblOperation.Text = "^"

        'Add the two numbers and store the result in dblResult.
        dblResult = CInt(txtNumber1.Text) ^ CInt(txtNumber2.Text)

        ' Display the result.
        lblResult.Text = CStr(dblResult)
    End Sub

    Private Sub btnMOD_Click(sender As Object, e As EventArgs) Handles btnMOD.Click
        ' This event handler performs multiplication.
        ' Declare a variable to hold the result.
        Dim intResult As Integer

        'Indicate "MOD" as the opperation.
        lblOperation.Text = "MOD"

        'Add the two numbers and store the result in dblResult.
        intResult = CInt(txtNumber1.Text) Mod CInt(txtNumber2.Text)

        ' Display the result.
        lblResult.Text = CStr(intResult)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear TextBox Mubers and the Results Label.
        txtNumber1.Clear()
        txtNumber2.Clear()
        lblOperation.Text = String.Empty
        lblResult.Text = String.Empty

        ' Set focus to txtNumber1.
        txtNumber1.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the program.
        Me.Close()
    End Sub
End Class
