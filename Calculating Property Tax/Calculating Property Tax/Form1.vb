Public Class Form1
    Private Sub btnCalculatePropertyTax_Click(sender As Object, e As EventArgs) Handles btnCalculatePropertyTax.Click
        ' Declare variables for the calculations.
        Dim dblAssessmentValue As Decimal
        Dim dblPropertyTaxes As Decimal
        Const dblAssessmentRate As Decimal = 0.6D
        Const dblTaxRate As Decimal = 0.0064D

        ' Calculate and display Assessment Value.
        dblAssessmentValue = CDec(txtActualPropertyValue.Text) * dblAssessmentRate
        lblAssessmentValue.Text = dblAssessmentValue.ToString("C")

        ' Calculate and display Property Tax.
        dblPropertyTaxes = dblAssessmentValue * dblTaxRate
        lblPropertyTax.Text = dblPropertyTaxes.ToString("C")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear Actual Value Text Box and Assessment and Tax Labels.
        txtActualPropertyValue.Clear()
        lblPropertyTax.Text = String.Empty
        lblAssessmentValue.Text = String.Empty

        ' Set focus to txtActualPropertyValue
        txtActualPropertyValue.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
