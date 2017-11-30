Public Class CATALOGO

    Private Sub CATALOGO_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cbTipoProd.SelectedIndex = 0
        'lstArticulo.SelectedIndex = 0
    End Sub

    Private Sub cbTipoProd_SelectedIndexChanged(ByVal sender As System.Object, e As System.EventArgs) Handles cbTipoProd.SelectedIndexChanged
        lstArticulo.Items.Clear()
        For i = 0 To Form1.lstTipoProd.Items.Count - 1
            If cbTipoProd.SelectedItem = Form1.lstTipoProd.Items(i) Then
                lstArticulo.Items.Add(Form1.lstRopa.Items(i))
            End If
        Next
    End Sub

    Private Sub rbtTotalUnid_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtTotalUnid.CheckedChanged
        Dim suma As Integer
        For i = 0 To Form1.lstTipoProd.Items.Count - 1
            If cbTipoProd.SelectedItem = Form1.lstTipoProd.Items(i) Then
                suma += Form1.lstDisponibles.Items(i)
            End If
        Next
        etNumerica.Text = suma
    End Sub

    Private Sub rbtPrecioMedio_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtPrecioMedio.CheckedChanged
        Dim suma As Decimal
        Dim cont As Integer
        Dim media As Decimal
        For i = 0 To Form1.lstTipoProd.Items.Count - 1
            If cbTipoProd.SelectedItem = Form1.lstTipoProd.Items(i) Then
                suma += Form1.lstPrecio.Items(i)
                cont += 1
            End If
        Next
        If cont > 0 Then
            media = suma / cont 'la suma del PRECIO de todos los articulos entre todos los articulos que haya contado(el contador)
        End If
        etNumerica.Text = FormatNumber(media)
    End Sub

    Private Sub rbtUnidades_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtUnidades.CheckedChanged
        Try
            Dim unid = Form1.lstRopa.Items.IndexOf(lstArticulo.SelectedItem)
            etNumerica.Text = Form1.lstDisponibles.Items(unid)
        Catch ex As ArgumentNullException
            MessageBox.Show("Seleccione un ítem")
        End Try
    End Sub

    Private Sub lstArticulo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstArticulo.SelectedIndexChanged
        Try
            PictureBox1.Image = Image.FromFile(Application.StartupPath & "\ropa\" & lstArticulo.SelectedItem & ".jpg")
        Catch ex As Exception
            PictureBox1.Image = Image.FromFile(Application.StartupPath & "\ropa\no disponible.JPG")
        End Try

        'Esto es para que al elegir en el rbt una opcion u otra, en la etiqueta numerica salga correctamente las unidades del articulo seleccionado, pq sino solo mostraba las unidades del primer seleccionado
        If rbtUnidades.Checked = True Then
            Dim n = Form1.lstRopa.Items.IndexOf(lstArticulo.SelectedItem)
            etNumerica.Text = Form1.lstDisponibles.Items(n)
        End If
    End Sub

    Private Sub btnVolver_Click(sender As System.Object, e As System.EventArgs) Handles btnVolver.Click
        Me.Dispose()
        Form1.Show()
    End Sub
End Class