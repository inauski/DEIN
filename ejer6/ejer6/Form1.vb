Public Class Form1

    Private Sub btnPrimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrimo.Click
        Dim numero, contador As Integer
        numero = CInt(txtCaja.Text())
        For i = 1 To numero
            If numero Mod i = 0 Then
                contador = contador + 1
            End If
            If contador > 2 Then Exit For
        Next
        If contador = 2 Then
            lblPrimo.Text = "Sí es nº primo"
        Else
            lblPrimo.Text = "No es nº primo"
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        End
    End Sub
End Class

