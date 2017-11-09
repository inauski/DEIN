Public Class frmAltasEnPos

  
    Private Sub btnAltasPos_Click(sender As System.Object, e As System.EventArgs) Handles btnAltasPos.Click
        Dim recoger As String
        recoger = txtAltasPos.Text
        If ComboBox1.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar un indice para insertar")
        Else
            Form1.lstImagenes.Items.Insert(ComboBox1.SelectedIndex, recoger) 'Insertamos en el indice seleccionado con el combobox, lo que escribimos en recoger(txtAltasPos)
            MessageBox.Show("Añadido")
        End If

    End Sub

    Private Sub frmAltasEnPos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


        For i = 0 To Form1.lstImagenes.Items.Count - 1 'nos da los indices de los items que hay en listbox del form1
            ComboBox1.Items.Add(i)
        Next


    End Sub

    Private Sub btnSalirAltasFinal_Click(sender As System.Object, e As System.EventArgs) Handles btnSalirAltasFinal.Click
        Me.Dispose()
        Form1.Show()
    End Sub
End Class