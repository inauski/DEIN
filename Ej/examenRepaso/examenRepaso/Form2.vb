Public Class Form2

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ponerImagen()
        HScrollBar1.Maximum = Form1.lstTitulo.Items.Count - 1
        lstUnidades.Text = Form1.lstUnid.Items.Item(HScrollBar1.Value)

        etUnidDispon.Text = Form1.lstUnid.Items(HScrollBar1.Value)
    End Sub

    Sub ponerImagen()
        Try
            PictureBox1.Image = Image.FromFile("libreria\" & Form1.lstTitulo.Items(HScrollBar1.Value) & ".JPG") 'saca las imagenes cada vez q cambiamos

        Catch ex As Exception
            PictureBox1.Image = Image.FromFile("libreria\nodisp.jpg") 'saca imagen no disponible si no esta

        End Try
    End Sub

    Private Sub HScrollBar1_Scroll(sender As System.Object, e As System.Windows.Forms.ScrollEventArgs) Handles HScrollBar1.Scroll
        ponerImagen()
        etUnidDispon.Text = Form1.lstUnid.Items(HScrollBar1.Value)
    End Sub

    Private Sub txtBuscar_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then 'Al pulsar enter
            lstTit.Items.Clear()
            lstUnidades.Items.Clear()
            For i = 0 To Form1.lstTitulo.Items.Count - 1
                If Form1.lstTitulo.Items(i).IndexOf(txtBuscar.Text) <> -1 Then
                    lstTit.Items.Add(Form1.lstTitulo.Items(i))
                    lstUnidades.Items.Add(Form1.lstUnid.Items(i))
                End If
            Next
        End If

        'Si no es letra de la A-Z o retroceso o espacio
        If Not (e.KeyChar Like "[A-Z]") And e.KeyChar <> Convert.ToChar(Keys.Back) And e.KeyChar <> Convert.ToChar(Keys.Space) Then
            e.Handled = True
        End If

        'Pone el total de los encontrados de la lista, en la etiqueta
        etEncontrados.Text = lstTit.Items.Count

        'Sumamos las unidades totales de libros y lo ponemos en la etiqueta
        Dim suma As Integer
        For i = 0 To lstUnidades.Items.Count - 1
            suma += lstUnidades.Items(i)
        Next
        etTotalUnidEncon.Text = suma
    End Sub

    'CheckBox(verificacion)
    Private Sub chbTotalUnid_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chbTotalUnid.CheckedChanged
        Dim suma As Integer
        suma = 0
        If chbTotalUnid.Checked = True Then 'Si esta la casilla activada
            For Each unidades In Form1.lstUnid.Items 'recorremos la lista de unidades del form1 y la sumamos
                suma = suma + unidades
            Next
            etTotalUnid.Text = suma 'ponemos la suma en la etiqueta
        Else
            etTotalUnid.Text = ""
        End If
    End Sub

    Private Sub btnVolver_Click(sender As System.Object, e As System.EventArgs) Handles btnVolver.Click
        Me.Dispose() 'cerrar volviendo todos los valores a 0
        Form1.Show()
    End Sub

    Private Sub lstTit_Click(sender As Object, e As System.EventArgs) Handles lstTit.Click
        Dim seleccionado As String
        seleccionado = lstTit.SelectedIndex
        lstUnidades.SelectedIndex = seleccionado
    End Sub
End Class