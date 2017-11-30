Public Class Form1
    Dim sexo As String
    Private Sub btnCalcular_Click(sender As System.Object, e As System.EventArgs) Handles btnCalcular.Click
        Dim pesoIdeal As Double

        If CDbl(txtEstatura.Text) < 120 And CDbl(txtEstatura.Text) > 220 Then
            MessageBox.Show("Altura no valida")
        ElseIf rbtMujer.Checked = True Then
            pesoIdeal = ((CDbl(txtEstatura.Text) - 100)) * 0.85
            etPesoIdeal.Text = CStr(pesoIdeal)
        ElseIf rbtHombre.Checked = True Then
            pesoIdeal = ((CDbl(txtEstatura.Text) - 100)) * 0.9
            etPesoIdeal.Text = CStr(pesoIdeal)
        ElseIf Not IsNumeric(txtEstatura.Text) Then
            MessageBox.Show("Solo se admiten números")
        End If

        If chkLista.Checked = True Then
            Dim estatura As Integer
            estatura = CInt(txtEstatura.Text)

            Dim peso As Double
            peso = pesoIdeal

            If rbtMujer.Checked = True Then
                sexo = "Mujer"
            ElseIf rbtHombre.Checked = True Then
                sexo = "Hombre"
            End If
            lsSEP.Items.Add(sexo & vbTab & estatura & "                    " & peso)
        End If

    End Sub

    Private Sub rbtPequeño_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtPequeño.CheckedChanged
        lsSEP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8)

        '    If (rbtPequeño.Checked = True) Then
        '        Dim fuente As New Font("Comic Sans MS", 8)
        '        lsSEP.Font = fuente
        '    End If
        '    If (rbtGrande.Checked = True) Then
        '        Dim fuente As New Font("Comic Sans MS", 9)
        '        lsSEP.Font = fuente
        '    End If

    End Sub

    Private Sub rbtGrande_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtGrande.CheckedChanged
        lsSEP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9)
    End Sub

    Private Sub btnBorrarEnt_Click(sender As System.Object, e As System.EventArgs) Handles btnBorrarEnt.Click
        Dim seleccionado As String
        seleccionado = CStr(lsSEP.SelectedIndex)
        lsSEP.Items.RemoveAt(CInt(seleccionado))
    End Sub

    Private Sub btnBorrarTodo_Click(sender As System.Object, e As System.EventArgs) Handles btnBorrarTodo.Click
        lsSEP.Items.Clear()
    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub lsSEP_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lsSEP.SelectedIndexChanged

    End Sub
End Class
