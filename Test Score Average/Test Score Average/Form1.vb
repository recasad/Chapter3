Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalculateAverage.Click
        ' Declare variables for the calculations.
        Dim dblAddedScores As Double
        Dim dblAverage As Double
        Const dblScores As Double = 5D

        'Calculate the added scores.
        dblAddedScores = CDbl(txtTestBox1.Text) + CDbl(txtTestBox2.Text) + CDbl(txtTestBox3.Text) + CDbl(txtTestBox4.Text) + CDbl(txtTestBox5.Text)

        'Average the Scores and display average
        dblAverage = dblAddedScores / dblScores
        lblAverage.Text = dblAverage.ToString
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear TextBox Scores and Average Label
        txtTestBox1.Clear()
        txtTestBox2.Clear()
        txtTestBox3.Clear()
        txtTestBox4.Clear()
        txtTestBox5.Clear()
        lblAverage.Text = String.Empty

        ' Set focus to txtTestBox1
        txtTestBox1.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
