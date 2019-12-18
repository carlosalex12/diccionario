Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Form2.Show()

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Form3.Show()
    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        Form4.Show()
    End Sub
End Class
