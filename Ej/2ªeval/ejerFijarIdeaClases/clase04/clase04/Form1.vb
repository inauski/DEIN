Public Class Form1
    Private rect01 As New clase03.clsNumeros

    Private Sub btnCalcular_Click(sender As System.Object, e As System.EventArgs) Handles btnSuma.Click


        rect01.num1 = CDbl(txtNum1.Text)
        rect01.num2 = CDbl(txtNum2.Text)

        txtResul.Text = rect01.calcularSuma
    End Sub

    Private Sub btnResta_Click(sender As System.Object, e As System.EventArgs) Handles btnResta.Click


        rect01.num1 = CDbl(txtNum1.Text)
        rect01.num2 = CDbl(txtNum2.Text)

        txtResul.Text = rect01.calcularResta
    End Sub

    Private Sub btnMulti_Click(sender As System.Object, e As System.EventArgs) Handles btnMulti.Click

        rect01.num1 = CDbl(txtNum1.Text)
        rect01.num2 = CDbl(txtNum2.Text)

        txtResul.Text = rect01.calcularMultiplicacion
    End Sub

    Private Sub btnDiv_Click(sender As System.Object, e As System.EventArgs) Handles btnDiv.Click


        rect01.num1 = CDbl(txtNum1.Text)
        rect01.num2 = CDbl(txtNum2.Text)

        txtResul.Text = rect01.calcularDivision
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class