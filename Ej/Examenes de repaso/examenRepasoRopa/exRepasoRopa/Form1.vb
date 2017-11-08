Public Class Form1
    Dim listaPrecio(1) As ListBox
    Private Sub lstRopa_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstRopa.SelectedIndexChanged
        'Dim seleccionado As String
        'seleccionado = lstRopa.SelectedIndex
        'lstTipoProd.SelectedIndex = seleccionado
        'lstPrecio.SelectedIndex = seleccionado
        'lstDisponibles.SelectedIndex = seleccionado

        lstDisponibles.SelectedIndex = lstRopa.SelectedIndex
        lstPrecio.SelectedIndex = lstRopa.SelectedIndex
        lstTipoProd.SelectedIndex = lstRopa.SelectedIndex
    End Sub

    Private Sub btnElimArt_Click(sender As System.Object, e As System.EventArgs) Handles btnElimArt.Click
        Dim respuesta As DialogResult
        Dim pos As Integer

        If lstRopa.SelectedIndex = -1 Then
            MessageBox.Show("No hay nada seleccionado", "ATENCION")
        Else
            respuesta = MessageBox.Show("¿Desea eliminar el articulo?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

            If respuesta = Windows.Forms.DialogResult.Yes Then
                    pos = lstRopa.SelectedIndex
                    lstRopa.Items.RemoveAt(pos)
                    lstTipoProd.Items.RemoveAt(pos)
                    lstPrecio.Items.RemoveAt(pos)
                    lstDisponibles.Items.RemoveAt(pos)

                End If
            End If


    End Sub

    Private Sub btnElimProd_Click(sender As System.Object, e As System.EventArgs) Handles btnElimProd.Click

        Dim cont As Integer = 0
        If cbProd1.SelectedItem <> "" Then
            Dim resp = MessageBox.Show("¿Deseas eliminar el producto " + cbProd1.SelectedItem, "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If resp = DialogResult.Yes Then
                Dim num = lstRopa.Items.Count - 1
                For i = num To 0 Step -1
                    If CStr(lstTipoProd.Items(i)) = CStr(cbProd1.SelectedItem) Then
                        lstRopa.Items.RemoveAt(i)
                        lstDisponibles.Items.RemoveAt(i)
                        lstPrecio.Items.RemoveAt(i)
                        lstTipoProd.Items.RemoveAt(i)
                        cont += 1
                    End If
                Next
                MessageBox.Show("Ha borrado " & cont & " artículos")
            End If
        Else
            MessageBox.Show("Debe seleccionar un elemento de la lista", "AVISO", MessageBoxButtons.OK)
        End If

    End Sub

    Private Sub btnUnidades_Click(sender As System.Object, e As System.EventArgs) Handles btnUnidades.Click
        Try
            Dim precio As Integer = lstPrecio.SelectedItem
            Dim unidIntroducidas As Integer = TextBox1.Text


            If lstRopa.SelectedIndex = -1 Then
                MessageBox.Show("No se ha seleccionado producto", "ATENCION")
            Else
                If unidIntroducidas > lstDisponibles.SelectedItem Then
                    MessageBox.Show("No hay tantas unidades !!!!")
                Else

                    TextBox2.Text = lstRopa.SelectedItem & " " & unidIntroducidas & " unid " & "  " & (unidIntroducidas * precio) & " €"
                    btnUnidades.Enabled = False
                    btnComprarCanc.Enabled = True

                    If chbDto.Checked = True Then
                        precio = precio - (lstPrecio.SelectedItem * 10 / 100) ' o (CDec(lstPrecio.SelectedItem) * unidIntroducidas * 0.9) 
                        TextBox2.Text = lstRopa.SelectedItem & " " & unidIntroducidas & " unid " & "  " & precio & " €"
                    End If

                End If

            End If
        Catch ia As InvalidCastException
            MessageBox.Show("Introduzca unidades a comprar")
        End Try


    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cbProd1.SelectedIndex = 0 'para que al iniciar salga alguno de los items seleccionados
        ComboBox1.SelectedIndex = 0 'para que al iniciar salga alguno de los items seleccionados

        listaPrecio(0) = lstDisponibles
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not (e.KeyChar Like "[0-9]") And e.KeyChar <> Convert.ToChar(Keys.Back) Then 'si no introducimos numeros no DEJA ESCRIBIRLO
            e.Handled = True
        End If
    End Sub

    Private Sub btnComprarCanc_Click(sender As System.Object, e As System.EventArgs) Handles btnComprarCanc.Click

        Dim x, y, pos, cant As Integer

        Dim respuesta As DialogResult

        respuesta = MessageBox.Show("¿Desea confirmar la compra?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If respuesta = Windows.Forms.DialogResult.Yes Then
            MessageBox.Show("Ha realizado la compra " & TextBox2.Text)

            'restar unidades
            pos = listaPrecio(x).SelectedIndex
            cant = CInt(listaPrecio(x).Items(y))
            listaPrecio(x).Items.RemoveAt(pos)
            listaPrecio(x).Items.Insert(pos, (cant - CInt(TextBox1.Text)))
            listaPrecio(x).SelectedIndex = y

            TextBox2.Text = ""
            TextBox1.Text = ""
            btnComprarCanc.Enabled = False
            btnUnidades.Enabled = True
        Else
            MessageBox.Show("Pedido anulado")
            TextBox2.Text = ""
            TextBox1.Text = ""
            btnComprarCanc.Enabled = False
            btnUnidades.Enabled = True
        End If


    End Sub

    Private Sub btnNuevoArt_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevoArt.Click
        If txtArtNuevo.Text = "" Then
            MessageBox.Show("Debe introducir nombre para el articulo")
        ElseIf txtPrecioNuev.Text = "" Then
            MessageBox.Show("Introduza precio")
        ElseIf lstRopa.Items.Contains(txtArtNuevo.Text) Then 'Comprobamos que ya esta el articulo una vez en la lista con CONTAINS
            MessageBox.Show("Articulo que ya existe")
        Else
            lstRopa.Items.Add(txtArtNuevo.Text)
            lstTipoProd.Items.Add(ComboBox1.SelectedItem)
            lstPrecio.Items.Add(txtPrecioNuev.Text)
            lstDisponibles.Items.Add(txtUnidNuevo.Text)
        End If


    End Sub

    Private Sub txtArtNuevo_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtArtNuevo.KeyPress
        If Not (e.KeyChar Like "[A-Z]") And e.KeyChar <> Convert.ToChar(Keys.Back) And e.KeyChar <> Convert.ToChar(Keys.Space) Then 'si no introducimos numeros en las entradas no DEJA ESCRIBIRLO
            e.Handled = True
        End If
    End Sub

    Private Sub txtPrecioNuev_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrecioNuev.KeyPress
        'Para que solo admita numeros y coma

        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "," And Not txtPrecioNuev.Text.IndexOf(",") Then
            e.Handled = True
        ElseIf e.KeyChar = "," Then
            e.Handled = False
        Else
            e.Handled = True
        End If

        'If Not (e.KeyChar Like "[0-9]") And e.KeyChar <> Convert.ToChar(Keys.Back) Then 'si no introducimos numeros en las entradas no DEJA ESCRIBIRLO
        '    e.Handled = True
        'End If
    End Sub

    Private Sub btnFinalizar_Click(sender As System.Object, e As System.EventArgs) Handles btnFinalizar.Click
        Me.Dispose()
    End Sub

    Private Sub btnCatalogo_Click(sender As System.Object, e As System.EventArgs) Handles btnCatalogo.Click
        CATALOGO.Show()
    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        e.Handled = True
    End Sub

   
End Class
