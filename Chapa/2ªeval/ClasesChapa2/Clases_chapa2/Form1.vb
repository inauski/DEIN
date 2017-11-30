Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCalcular_Click(sender As System.Object, e As System.EventArgs) Handles btnCalcular.Click
        Dim rect02 As New figuraGeometrica.clsRectangulo02
        rect02.altura = CDbl(txtAltura.Text)
        rect02.anchura = CDbl(txtBase.Text)

        txtArea.Text = rect02.calcularArea
        txtPerimetro.Text = rect02.calcularPerimetro
    End Sub
End Class
