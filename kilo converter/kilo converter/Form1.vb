Public Class KiloConvertor

    Private Sub KiloConvertor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnInches_Click(sender As Object, e As EventArgs) Handles btnInches.Click
        lblMessage.Text = "1 kilo = 39,370 inches"
    End Sub

    Private Sub btnFeet_Click(sender As Object, e As EventArgs) Handles btnFeet.Click
        lblMessage.Text = "1 kilo = 3,281 feet"
    End Sub

    Private Sub btnYards_Click(sender As Object, e As EventArgs) Handles btnYards.Click
        lblMessage.Text = "1 kilo = 1,093 yards"
    End Sub

    Private Sub btnMiles_Click(sender As Object, e As EventArgs) Handles btnMiles.Click
        lblMessage.Text = "1 kilo = 0.6214 Miles"
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
