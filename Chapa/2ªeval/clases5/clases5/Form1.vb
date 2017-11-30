Public Class Form1

    Private frutas01 As New clsFrutas

    Private Sub txtArticulo_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtArticulo.KeyPress
        'validar q solo se puedan meter letras

        Dim caracterTecleado As String
        caracterTecleado = e.KeyChar

        If Not frutas01.CaracterValido(caracterTecleado) Then ' si es falso, no escribe el caracter
            e.Handled = True
        End If
    End Sub

    Private Sub txtArticulo_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtArticulo.Validating
        If frutas01.existeFruta(txtArticulo.Text) = False Then  ' No deja salir hasta meter un articulo que exista
            e.Cancel = True
        End If
    End Sub

    Private Sub txtUnidades_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtUnidades.KeyPress
        If Not e.KeyChar Like "[0-9]" Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnCalcular_Click(sender As System.Object, e As System.EventArgs) Handles btnCalcular.Click
        Dim uni As Integer
        uni = CInt(txtUnidades.Text) 'guardamos en uni lo introducido en txtUnidades
        frutas01.unidades = uni

        etImporte.Text = frutas01.importe
    End Sub
End Class
