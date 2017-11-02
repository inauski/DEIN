Public Class frmInicio
    Private Sub btHola_Click(sender As Object, e As System.EventArgs) Handles btHola.Click
        'Esto es un comentario que se escribe con la comilla simple
        MessageBox.Show("Hola amiguitos")
        Me.Text = "patata" 'cambia el titulo 
    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class
