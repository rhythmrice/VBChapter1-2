Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnShowinfo_Click(sender As Object, e As EventArgs) Handles btnShowinfo.Click
        Label1.Visible = True
    End Sub
End Class
