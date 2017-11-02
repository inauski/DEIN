Public Class Form1
    ' Numero entre 32 y 255
    Private Sub btnSig_Click(sender As System.Object, e As System.EventArgs) Handles btnSig.Click
        Dim a As Integer
        a = txtOpci.Text
        If a < 255 Then
            a = a + 1
            etLetra.Text = Chr(a)
            txtOpci.Text = a
        End If
        
    End Sub

    Private Sub opcGrande_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles opcGrande.CheckedChanged
        If (opcGrande.Checked = True) Then
            Dim fuente As New Font("Comic Sans MS", 48)
            etLetra.Font = fuente

        End If
        If (opcPequeña.Checked = True) Then
            Dim fuente As New Font("Comic Sans MS", 34)
            etLetra.Font = fuente
        End If

    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Dim a As Integer
        a = txtOpci.Text
        If a > 32 And a < 255 Then
            etLetra.Text = Chr(a)
        ElseIf a > 255 Then
            etLetra.Text = Chr(a)
        Else
            MessageBox.Show("Error")

        End If
    End Sub

    Private Sub btnAnterior_Click(sender As System.Object, e As System.EventArgs) Handles btnAnterior.Click
        Dim n As Integer
        n = txtOpci.Text
        If n > 33 Then
            n = n - 1
            etLetra.Text = Chr(n)
            txtOpci.Text = n
        End If
    End Sub
End Class
