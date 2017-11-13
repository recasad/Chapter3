Public Class Form1
    Private Sub btnConvertToFahrenheit_Click(sender As Object, e As EventArgs) Handles btnConvertToFahrenheit.Click
        ' Declare variables for the calculations.
        Dim dblFahrenheit As Double
        Const dblFixedOnePointEight As Double = 1.8D
        Const dblFixedThirtyTwo As Double = 32D

        ' Calculate and display the Fahrenheit Conversion.
        dblFahrenheit = dblFixedOnePointEight * CDec(txtCelsius.Text) + dblFixedThirtyTwo
        lblFahrenheit.Text = dblFahrenheit.ToString
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear TextBox Celsius and Label Fahrenheit.
        txtCelsius.Clear()
        lblFahrenheit.Text = String.Empty

        ' Set focus to txtCelsius.
        txtCelsius.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
