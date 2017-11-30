Public Class Form1

    'Ejercicio con SelectionMode a Multiextended
    Private Sub btnAñadir_Click(sender As System.Object, e As System.EventArgs) Handles btnAñadir.Click
        Dim dato As String
        dato = txtDato.Text
        btnBorrarUno.Enabled = True
        btnDatosA2.Enabled = True
        If rbtPrimero.Checked Then
            lstDatos.Items.Insert(0, dato)
        ElseIf rbtUltimo.Checked Then
            lstDatos.Items.Add(dato)
        End If

    End Sub

    Private Sub btnDatosA2_Click(sender As System.Object, e As System.EventArgs) Handles btnDatosA2.Click
        Try
            lstDatos2.Items.Add(lstDatos.SelectedItem)
            lstDatos.Items.Remove(lstDatos.SelectedItem)
            btnDatosA1.Enabled = True
            btnBorrarDos.Enabled = True
            If lstDatos.Items.Count = 0 Then
                btnBorrarUno.Enabled = False
                btnDatosA2.Enabled = False
            End If
        Catch ex As ArgumentNullException
            MessageBox.Show("No se ha seleccionado ningun elemento")
        End Try


    End Sub

    Private Sub btnDatosA1_Click(sender As System.Object, e As System.EventArgs) Handles btnDatosA1.Click

        Try
            lstDatos.Items.Add(lstDatos2.SelectedItem)
            lstDatos2.Items.Remove(lstDatos2.SelectedItem)
            btnBorrarUno.Enabled = True
            btnDatosA2.Enabled = True
            If lstDatos2.Items.Count = 0 Then
                btnBorrarDos.Enabled = False
                btnDatosA1.Enabled = False
            End If
        Catch ex As ArgumentNullException
            MessageBox.Show("No se ha seleccionado ningun elemento")
        End Try

    End Sub

    Private Sub btnBorrarUno_Click(sender As System.Object, e As System.EventArgs) Handles btnBorrarUno.Click
        lstDatos.Items.Remove(lstDatos.SelectedItem)
        If lstDatos.Items.Count = 0 Then
            btnBorrarUno.Enabled = False
        End If
        If lstDatos.SelectedItem = 0 Then
            MessageBox.Show("No se ha seleccionado ningun elemento")
        End If
    End Sub

    Private Sub btnBorrarDos_Click(sender As System.Object, e As System.EventArgs) Handles btnBorrarDos.Click
        lstDatos2.Items.Remove(lstDatos2.SelectedItem)
        If lstDatos2.Items.Count = 0 Then
            btnBorrarDos.Enabled = False
            btnDatosA1.Enabled = False
        End If
        If lstDatos2.SelectedItem = 0 Then
            MessageBox.Show("No se ha seleccionado ningun elemento")
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

 
End Class
