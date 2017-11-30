Public Class cambio

    Private Sub cambio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Sala 1")
        ComboBox1.Items.Add("Sala 2")
        ComboBox1.Items.Add("Sala 3")
        ComboBox1.Items.Add("Sala 4")
        ComboBox1.SelectedIndex = 0 'Para que salga por defecto la sala seleccionada
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        'El titulo de la pelicula 1 en titulo1(caja de texto) de Multicines.vb
        If ComboBox1.SelectedIndex = 0 Then
            txtTituloActual.Text = Multicines.titulo1.Text
            'El titulo de la pelicula 2 en titulo2 de Multicines.vb,etc.
        ElseIf ComboBox1.SelectedIndex = 1 Then
            txtTituloActual.Text = Multicines.titulo2.Text
        ElseIf ComboBox1.SelectedIndex = 2 Then
            txtTituloActual.Text = Multicines.titulo3.Text
        ElseIf ComboBox1.SelectedIndex = 3 Then
            txtTituloActual.Text = Multicines.titulo4.Text
        End If
    End Sub

    'Al clicar en este botón es cuando se cambiará el titulo en Multicines.vb
    Private Sub btActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btActualizar.Click
        If ComboBox1.SelectedIndex = 0 Then
            Multicines.titulo1.Text = txtTituloNuevo.Text
        ElseIf ComboBox1.SelectedIndex = 1 Then
            Multicines.titulo2.Text = txtTituloNuevo.Text
        ElseIf ComboBox1.SelectedIndex = 2 Then
            Multicines.titulo3.Text = txtTituloNuevo.Text
        ElseIf ComboBox1.SelectedIndex = 3 Then
            Multicines.titulo4.Text = txtTituloNuevo.Text
        End If
        MessageBox.Show("Titulo Cambiado")
        Multicines.cambiarMenu()
    End Sub

    Private Sub btVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btVolver.Click
        Me.Dispose()
    End Sub
End Class