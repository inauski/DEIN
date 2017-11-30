Public Class frmBajas

    Private Sub frmBajas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        For i = 0 To Form1.lstImagenes.Items.Count - 1 'nos da los indices de los items que hay en listbox del form1
            ComboBox1.Items.Add(i)
        Next


    End Sub

    Private Sub btnBajasPos_Click(sender As System.Object, e As System.EventArgs) Handles btnBajasPos.Click
        If ComboBox1.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar un indice para borrar")
        Else
            Form1.lstImagenes.Items.RemoveAt(ComboBox1.SelectedItem) 'Insertamos en el indice seleccionado con el combobox, lo que escribimos en recoger(txtAltasPos)
            MessageBox.Show("Borrado")
        End If

    End Sub

    Private Sub btnSalirBajas_Click(sender As System.Object, e As System.EventArgs) Handles btnSalirBajas.Click
        Me.Dispose()
        Form1.Show()
    End Sub
End Class