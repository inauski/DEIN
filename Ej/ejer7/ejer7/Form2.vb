Public Class Form2
    Dim conta As Integer
   

    Private Sub btnVerificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerificar.Click
        conta = conta + 1
        txtIntento.Text = conta
        If IsNumeric(txtNum.Text) Then

            If (txtNum.Text > variable) Then
                txtResultado.Text = "Menor"
            ElseIf (txtNum.Text < variable) Then
                txtResultado.Text = "Mayor"
            Else
                txtResultado.Text = "ACERTADO"
                MessageBox.Show("Has ganado")
            End If

            If txtIntento.Text = 11 Then
                MessageBox.Show("Has llegado a 10 intentos")
                txtResultado.Text = variable
                btnVerificar.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnFinalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinalizar.Click
        End
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Me.Dispose()
    End Sub
End Class