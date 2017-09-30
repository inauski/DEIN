Public Class Form1

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        If txtEuros.Enabled = True Then
            If txtEuros.Text = "" Or Not IsNumeric(txtEuros.Text) Then
                MessageBox.Show("Rellena con numero")
            Else
                Dim euros, pesetas As Integer
                euros = CInt(txtEuros.Text)
                pesetas = euros * 166.386
                txtPesetas.Text = pesetas

            End If

        Else
            If txtPesetas.Text = "" Or Not IsNumeric(txtPesetas.Text) Then
                MessageBox.Show("Rellena con numero")
            Else
                Dim euros, pesetas As Integer
                pesetas = CInt(txtPesetas.Text)
                euros = pesetas / 166.386
                txtEuros.Text = euros
            End If
         

        End If

    End Sub

    Private Sub RectangleShape2_Click(sender As System.Object, e As System.EventArgs) Handles RectangleShape2.Click

    End Sub

    Private Sub btnPesEur_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesEur.Click
        If txtEuros.Enabled = True Then
            txtEuros.Enabled = False
            txtPesetas.Enabled = True
            etEurPes.Text = " Pesetas a euros"
            btnPesEur.Text = "Euros a pesetas"
        Else
            txtEuros.Enabled = True
            txtPesetas.Enabled = False
            etEurPes.Text = "Euros a pesetas"
            btnPesEur.Text = "Pesetas a euros"
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class
