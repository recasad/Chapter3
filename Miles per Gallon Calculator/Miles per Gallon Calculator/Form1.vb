Public Class Form1
    Private Sub btnCalculateMPG_Click(sender As Object, e As EventArgs) Handles btnCalculateMPG.Click
        ' This event handler calculates Miles per Gallon.
        ' Declare a variable to hold the result.
        Dim dblResult As Double

        ' Divide the two numbers and store the results in dblResult.
        dblResult = CDbl(txtMiles.Text) / CDbl(txtGallons.Text)

        ' Display the result.
        lblMPG.Text = CStr(dblResult)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear TextBox Miles and Gallons and Label Miles per Gallon.
        txtGallons.Clear()
        txtMiles.Clear()
        lblMPG.Text = String.Empty

        ' Set focus to txtGallons.
        txtGallons.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
