Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Declare variables for the calculations.
        Dim decClassA As Decimal
        Dim decClassB As Decimal
        Dim decClassC As Decimal
        Dim decTotalRevenue As Decimal
        Const decClassARate As Decimal = 15D
        Const decClassBRate As Decimal = 12D
        Const decClassCRate As Decimal = 9D

        ' Calculate and display Class A Revenue.
        decClassA = CDec(txtClassA.Text) * decClassARate
        lblClassA.Text = decClassA.ToString("C")

        ' Calculate and display Class B Revenue.
        decClassB = CDec(txtClassB.Text) * decClassBRate
        lblClassB.Text = decClassB.ToString("C")

        ' Calculate and display Class C Revenue.
        decClassC = CDec(txtClassC.Text) * decClassCRate
        lblClassC.Text = decClassC.ToString("C")

        ' Calculate and display Total Revenue.
        decTotalRevenue = CDec(decClassA) + CDec(decClassB) + CDec(decClassC)
        lblTotalRevenue.Text = decTotalRevenue.ToString("C")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Clear TextBox Classes A-C and Labels A-C and TotalRevenue.
        txtClassA.Clear()
        txtClassB.Clear()
        txtClassC.Clear()
        lblClassA.Text = String.Empty
        lblClassB.Text = String.Empty
        lblClassC.Text = String.Empty
        lblTotalRevenue.Text = String.Empty

        ' Set focus to txtClassA
        txtClassA.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
