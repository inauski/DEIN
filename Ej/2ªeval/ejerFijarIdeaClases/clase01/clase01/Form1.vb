Public Class Form1

    Private Sub btnCalcular_Click(sender As System.Object, e As System.EventArgs) Handles btnSuma.Click
        Dim rect01 As New clsNumeros

        rect01.num1 = CDbl(txtNum1.Text)
        rect01.num2 = CDbl(txtNum2.Text)

        txtResul.Text = rect01.calcularSuma
    End Sub

    Private Sub btnResta_Click(sender As System.Object, e As System.EventArgs) Handles btnResta.Click
        Dim rect01 As New clsNumeros

        rect01.num1 = CDbl(txtNum1.Text)
        rect01.num2 = CDbl(txtNum2.Text)

        txtResul.Text = rect01.calcularResta
    End Sub

    Private Sub btnMulti_Click(sender As System.Object, e As System.EventArgs) Handles btnMulti.Click
        Dim rect01 As New clsNumeros

        rect01.num1 = CDbl(txtNum1.Text)
        rect01.num2 = CDbl(txtNum2.Text)

        txtResul.Text = rect01.calcularMultiplicacion
    End Sub

    Private Sub btnDiv_Click(sender As System.Object, e As System.EventArgs) Handles btnDiv.Click
        Dim rect01 As New clsNumeros

        rect01.num1 = CDbl(txtNum1.Text)
        rect01.num2 = CDbl(txtNum2.Text)

        txtResul.Text = rect01.calcularDivision
    End Sub
End Class
