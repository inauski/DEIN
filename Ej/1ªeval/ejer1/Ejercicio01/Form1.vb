Public Class frmEjercicio1
    Private Sub btCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCalcular.Click
        Dim num1, num2, resultado As Integer
        num1 = CInt(txtBase.Text)
        num2 = CInt(txtAltura.Text)
        resultado = num1 * num2 / 2
        txtArea.Text = resultado
        et24.Text = num2
        et12.Text = num1

    End Sub

    Private Sub btSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalir.Click
        Me.Close()

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub txtArea_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtArea.TextChanged

    End Sub
End Class
