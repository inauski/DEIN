Public Class Form1

    Private Sub btnCalcular_Click(sender As System.Object, e As System.EventArgs) Handles btnCalcular.Click
        Dim rect03 As New clases3_chapa.clsRectangulo03

        rect03.altura = CDbl(txtAltura.Text)
        rect03.anchura = CDbl(txtBase.Text)

        txtArea.Text = rect03.calcularArea
        txtPerimetro.Text = rect03.calcularPerimetro
    End Sub
End Class
