Public Class Form1

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If IsNumeric(txtNumero.Text) Then
            variable = txtNumero.Text 'variable, creada en Module1 para que sirva para form1 y form2
            Form2.ShowDialog()
        Else
            MessageBox.Show("Debe introducir valor numerico", "AVISO")
        End If
    End Sub

    Private Sub btnFinalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinalizar.Click
        Me.Dispose()
    End Sub

    Private Sub txtNumero_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumero.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            btnAceptar.PerformClick()
            Exit Sub
        End If
        If Not (e.KeyChar Like "[0-9]" And AscW(e.KeyChar) <> Keys.Back) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtNumero_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNumero.TextChanged

    End Sub
End Class
