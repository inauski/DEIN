Public Class frmAltasFinal

    Private Sub btnAltasFinal_Click(sender As System.Object, e As System.EventArgs) Handles btnAltasFinal.Click
        Dim recoger As String
        recoger = txtAltasFinal.Text

        For i = 1 To 1
            Form1.lstImagenes.Items.Add(recoger)
        Next
        MessageBox.Show("Añadido")
    End Sub

    Private Sub btnSalirAltasFinal_Click(sender As System.Object, e As System.EventArgs) Handles btnSalirAltasFinal.Click
        Me.Dispose()
        Form1.Show()
    End Sub
End Class