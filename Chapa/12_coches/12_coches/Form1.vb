Public Class frm

    Private Sub picCoche_Click(sender As System.Object, e As System.EventArgs) Handles picCoche.Click

    End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        ' MessageBox.Show(Application.StartupPath) 'nos da la ruta del debug
        mostrarCoche()
    End Sub
    Sub mostrarCoche()
        Const titulo = "Vehiculos en venta"
        Dim imagen As String
        imagen = Application.StartupPath & "\fotos_coches\" & txtMatricula.Text & ".jpg"

        Try
            Me.Text = titulo & " - " & txtMatricula.Text 'cambia el titulo del formulario
            picCoche.Image = Image.FromFile(imagen)
        Catch ex As System.IO.FileNotFoundException
            MessageBox.Show("El coche con matricula " & txtMatricula.Text & " no tiene imagen", "Vehiculo error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtMatricula.Text = String.Empty 'vacia la caja
            picCoche.Image = Nothing
            Me.Text = titulo
        Finally
            txtMatricula.Focus()
            txtMatricula.SelectAll()

        End Try


    End Sub

    Private Sub txtMatricula_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtMatricula.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then 'esto es para que se muestre la imagen cuando escribamos y le DEMOS A INTRO, se ha puesto para eso KEY PRESS y keyChar
            btnAceptar.PerformClick()

        End If
    End Sub
    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub
    'en el frm se puede poner por defecto el boton q se pulsara, para eso se cambia 'accept button' al boton que queramos

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
