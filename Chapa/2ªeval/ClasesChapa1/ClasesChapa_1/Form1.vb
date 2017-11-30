Public Class Form1

   
    Private Sub btnCalcular_Click(sender As System.Object, e As System.EventArgs) Handles btnCalcular.Click
        Dim rect01 As New clsRectangulo01 'instancia a cls...

        'para mandar lo del textobox al cls
        rect01.anchura = CDbl(txtBase.Text)
        rect01.altura = CDbl(txtAltura.Text)

        txtArea.Text = rect01.calcularArea
        txtPerimetro.Text = rect01.calcularPerimetro
    End Sub
End Class
