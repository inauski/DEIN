Public Class Form1
    Private tarifas() As Integer = {150, 200, 300, 500}
    Private total As Integer

    Private Sub rbNacional_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbNacional.CheckedChanged
        If rbNacional.Checked = True Then
            lstInternacional.Enabled = False
            lstNacional.Enabled = True
            lstInternacional.SelectedIndex = -1 'Para que lo desSeleccione
        ElseIf rbInternacional.Checked = True Then
            lstInternacional.Enabled = True
            lstNacional.Enabled = False
            lstNacional.SelectedIndex = -1 'Para que lo desSeleccione
        End If
    End Sub

  
    Private Sub btnAnadirVuelo_Click(sender As System.Object, e As System.EventArgs) Handles btnAnadirVuelo.Click
        If (lstNacional.SelectedIndex = -1 And lstInternacional.SelectedIndex = -1) Then
            MessageBox.Show("Debe seleccionar destino", "ERROR!!!")
            Exit Sub
        End If

        If cbOrigen.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar origen", "ERROR!!!")
        End If

        If cbOrigen.SelectedItem = lstNacional.SelectedItem Then
            MessageBox.Show("El ORIGEN no puede coincidir con el DESTINO.", "ERROR")
            Exit Sub
        End If
        If (cbTarifa.SelectedIndex = -1) Then
            MessageBox.Show("Debe seleccionar una tarifa", "ERROR!!!")
            Exit Sub
        End If
        Try
            Dim origen As String = cbOrigen.SelectedItem
            Dim destino As String
            Dim numeroBilletes As Integer = NumericUpDown1.Value
            Dim tarifa As Integer = tarifas(cbTarifa.SelectedIndex - 1) * numeroBilletes
          

            If lstInternacional.SelectedIndex = -1 Then
                destino = lstNacional.SelectedItem
            Else
                destino = lstInternacional.SelectedItem
                tarifa = tarifa * 2
            End If

            lstCompras.Items.Add(origen & vbTab & destino & " - " & tarifa & "€")

            If etTotal.Text.Replace("Total a pagar: ", "") <> "" Then
                total = (etTotal.Text.Replace("Total a pagar: ", ""))
            Else
                total = 0
            End If

            total += tarifa

            etTotal.Text = "Total a pagar: " & CStr(FormatNumber(total)) & " €"
        Catch io As IndexOutOfRangeException
            MessageBox.Show("Debe seleccionar una tarifa válida", "AVISO")
        End Try
    End Sub

    
    Private Sub btnElimVuelo_Click(sender As System.Object, e As System.EventArgs) Handles btnElimVuelo.Click
        If lstCompras.Items.Count = 0 Then
            MessageBox.Show("No hay ningún vuelo en la lista.", "ERROR")
            Exit Sub
        End If
        If lstCompras.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar un vuelo a eliminar", "ERROR")
            Exit Sub
        End If

        Dim respuesta As DialogResult
        Dim pos As Integer = lstCompras.SelectedIndex

        respuesta = MessageBox.Show("¿Quiere eliminar el vuelo seleccionado?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        Dim tarifa As String = lstCompras.SelectedItem.ToString
        Dim valor() As String = tarifa.Split(New Char() {"-"})
        Dim tarifaEliminar As Integer = CInt(valor(1).Replace("€", ""))

        If respuesta = Windows.Forms.DialogResult.Yes Then
            If etTotal.Text.Replace("Total a pagar: ", "") <> "" Then
                total = CInt(etTotal.Text.Replace("Total a pagar: ", ""))
            Else
                total = 0
            End If

            total -= tarifaEliminar

            etTotal.Text = "Total a pagar: " & CStr(FormatNumber(total)) & " €"
            pos = lstCompras.SelectedIndex
            lstCompras.Items.RemoveAt(pos)
        End If
     
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        If Not (e.KeyChar Like "[A-Z-Ñ ]") And e.KeyChar <> Convert.ToChar(Keys.Separator) And e.KeyChar <> Convert.ToChar(Keys.Back) Then 'si la letra no esta entre la A-Z no DEJA ESCRIBIRLO
            e.Handled = True
        End If
    End Sub

    Private Sub txtApellido_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtApellido.KeyPress
        If Not (e.KeyChar Like "[A-Z-Ñ ]") And e.KeyChar <> Convert.ToChar(Keys.Separator) And e.KeyChar <> Convert.ToChar(Keys.Back) Then 'si la letra no esta entre la A-Z no DEJA ESCRIBIRLO
            e.Handled = True
        End If
    End Sub

    Private Sub txtCodigoPostal_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigoPostal.KeyPress
        If Not (e.KeyChar Like "[0-9]") And e.KeyChar <> Convert.ToChar(Keys.Separator) And e.KeyChar <> Convert.ToChar(Keys.Back) Then 'si el numero no esta entre 0-9 no DEJA ESCRIBIRLO
            e.Handled = True
            
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        If txtNombre.Text = "" Or txtApellido.Text = "" Or txtCodigoPostal.Text = "" Then
            MessageBox.Show("Debe rellenar todos los campos", "ERROR!")
        Else
            If txtCodigoPostal.TextLength <> 5 Then
                MessageBox.Show("El codigo postal debe tener 5 digitos", "ERROR!")
            Else
                MessageBox.Show(txtNombre.Text + " " + txtApellido.Text + vbNewLine + vbNewLine + txtCodigoPostal.Text + vbNewLine + vbNewLine + "has realizado una compra de: " + vbNewLine + vbNewLine + etTotal.Text + vbNewLine + vbNewLine + " en viajes.")
                lstCompras.Items.Clear()
                etTotal.Text = "Total a pagar: " & CStr(0) & "€"
                txtNombre.Text = ""
                txtApellido.Text = ""
                txtCodigoPostal.Text = ""
            End If
        End If

    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Dim respuesta As DialogResult
        respuesta = MessageBox.Show("¿Deseas eliminar TODOS los viajes?", "AVISO!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If respuesta = Windows.Forms.DialogResult.Yes Then
            lstCompras.Items.Clear()
            etTotal.Text = "Total a pagar: " & CStr(0) & "€"
            txtNombre.Text = ""
            txtApellido.Text = ""
            txtCodigoPostal.Text = ""
        End If
    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub
End Class
