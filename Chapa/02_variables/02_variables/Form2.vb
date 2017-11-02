Public Class Form2
    Private i As Integer

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Close() 'para salir se escribe me.close
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        i = i + 11
        MessageBox.Show(i)
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        zzz += 10
    End Sub
End Class