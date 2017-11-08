Public Class Form1

    Private Sub btnIrAOpcion_Click(sender As System.Object, e As System.EventArgs) Handles btnIrAOpcion.Click
        If rbtAltas.Checked = True Then
            gbAltas.Enabled = True
            gbOpciones.Enabled = False
            btnIrAOpcion.Enabled = False
            gbBajas.Enabled = False
            Exit Sub
        End If


        If (rbtModif.Checked = True Or rbtBajas.Checked = True) And lstTitulo.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar titulo", "AVISO")
            Exit Sub
        End If


        If rbtModif.Checked = True Then
            gbModif.Enabled = True
            gbOpciones.Enabled = False
            btnIrAOpcion.Enabled = False
            gbAltas.Enabled = False
            gbBajas.Enabled = False
        Else
            gbBajas.Enabled = True
            gbOpciones.Enabled = False
            btnIrAOpcion.Enabled = False
            gbAltas.Enabled = False
        End If

    End Sub

    Private Sub btnXaltas_Click(sender As System.Object, e As System.EventArgs) Handles btnXaltas.Click
        gbAltas.Enabled = False
        gbOpciones.Enabled = True
        btnIrAOpcion.Enabled = True
    End Sub

    Private Sub btnXmodif_Click(sender As System.Object, e As System.EventArgs) Handles btnXmodif.Click
        gbModif.Enabled = False
        gbOpciones.Enabled = True
        btnIrAOpcion.Enabled = True
    End Sub

    Private Sub btnXbajas_Click(sender As System.Object, e As System.EventArgs) Handles btnXbajas.Click
        gbBajas.Enabled = False
        gbOpciones.Enabled = True
        btnIrAOpcion.Enabled = True
    End Sub

    Private Sub btnHacerAltas_Click(sender As System.Object, e As System.EventArgs) Handles btnHacerAltas.Click
        Dim respuesta As DialogResult
        If lstTitulo.Items.Contains(txtTituloAltas.Text) Then 'si esta en la lista 
            MessageBox.Show("Ya esta en la lista", "ATENCION")
        Else
            If txtUnidAltas.Text = "" Then
                MessageBox.Show("No ha introducido unidades", "ATENCION")
            Else
                respuesta = MessageBox.Show("¿Quiere darle de alta?", "ATENCION", MessageBoxButtons.YesNo)

                If respuesta = Windows.Forms.DialogResult.Yes Then
                    lstTitulo.Items.Add(txtTituloAltas.Text)
                    lstUnid.Items.Add(txtUnidAltas.Text)

                    txtTituloAltas.Clear()
                    txtUnidAltas.Clear()
                End If
            End If
        End If
    End Sub

    Private Sub txtTituloAltas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTituloAltas.KeyPress
        If Not (e.KeyChar Like "[A-Z-Ñ ]") And e.KeyChar <> Convert.ToChar(Keys.Separator) Then 'si la letra no esta entre la A-Z no DEJA ESCRIBIRLO
            e.Handled = True
        End If
    End Sub
    Private Sub txtUnidAltas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUnidAltas.KeyPress
        If Not (e.KeyChar Like "[1-9]") And e.KeyChar <> Convert.ToChar(Keys.Back) Then 'si el numero no esta entre 0-9 no DEJA ESCRIBIRLO
            e.Handled = True
        End If
    End Sub
    Private Sub txtTituloAltas_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtTituloAltas.Validating
        If txtTituloAltas.Text = "" Then
            e.Cancel = True 'no deja salir del boton hasta que metamos algo
        End If
    End Sub


    Private Sub lstTitulo_Click(sender As Object, e As System.EventArgs) Handles lstTitulo.Click
        Dim seleccionado As String
        seleccionado = lstTitulo.SelectedIndex
        lstUnid.SelectedIndex = seleccionado
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Dispose()
    End Sub

    Private Sub btnHacerModif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHacerModif.Click
        Dim respuesta As DialogResult
        Dim pos As Integer

        If lstTitulo.SelectedIndex = -1 Then
            MessageBox.Show("No hay nada seleccionado", "ATENCION")
        Else

            If txtUnidModif.Text = "" Then
                MessageBox.Show("No ha introducido unidades", "ATENCION")
            Else
                respuesta = MessageBox.Show("¿Quiere darle de alta?", "ATENCION", MessageBoxButtons.YesNo)

                If respuesta = Windows.Forms.DialogResult.Yes Then
                    pos = lstTitulo.SelectedIndex
                    lstUnid.Items.RemoveAt(pos)
                    lstUnid.Items.Insert(pos, txtUnidModif.Text)
                    txtUnidModif.Clear() 'limpiamos la caja de texto
                End If
            End If
        End If
    End Sub
    Private Sub txtUnidModif_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUnidModif.KeyPress
        If Not (e.KeyChar Like "[1-9]") And e.KeyChar <> Convert.ToChar(Keys.Back) Then 'si no es numero o retroceso no DEJA ESCRIBIRLO
            e.Handled = True
        End If
    End Sub

    Private Sub btnHacerBajas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHacerBajas.Click
        Dim respuesta As DialogResult
        Dim pos As Integer

        If lstTitulo.SelectedIndex = -1 Then
            MessageBox.Show("No hay nada seleccionado", "ATENCION")
        Else
            respuesta = MessageBox.Show("¿Quiere darle de Baja?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

            If respuesta = Windows.Forms.DialogResult.Yes Then
                pos = lstTitulo.SelectedIndex
                lstTitulo.Items.RemoveAt(pos)
                lstUnid.Items.RemoveAt(pos)
            End If
        End If


        If lstTitulo.Items.Count > 0 Then
            lstTitulo.SelectedIndex = 0
        Else
            gbBajas.Enabled = False
            gbOpciones.Enabled = True
        End If

    End Sub

    Private Sub VerPortadasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerPortadasToolStripMenuItem.Click
        Form2.ShowDialog()
    End Sub
    Private Sub LstTitulo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstTitulo.SelectedIndexChanged
        lstUnid.SelectedIndex = lstTitulo.SelectedIndex
    End Sub

    Private Sub rbtModif_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtModif.CheckedChanged

    End Sub
End Class
