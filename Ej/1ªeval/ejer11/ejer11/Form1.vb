Public Class Form1
    Dim seleccionado As Integer
    Dim totalNulos As Integer
    Dim maximo As Double = 0

    Private Sub btnNuevoAtleta_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevoAtleta.Click
        Dim nombreAtleta As String
        Dim num As Integer = 0
        nombreAtleta = txtAtleta.Text

        If nombreAtleta <> "" Then
            If Not cbAtleta.Items.Contains(nombreAtleta) Then
                cbAtleta.Items.Add(nombreAtleta)
                ListBox1.Items.Add(num)
                ListBox2.Items.Add(num)
                ListBox3.Items.Add(num)
            Else
                MessageBox.Show("Atleta ya inscrito")
            End If
        End If

    End Sub

    Private Sub cbAtleta_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbAtleta.SelectedIndexChanged

        seleccionado = cbAtleta.SelectedIndex

        ListBox1.SelectedIndex = seleccionado
        ListBox2.SelectedIndex = seleccionado
        ListBox3.SelectedIndex = seleccionado

    End Sub

    Private Sub txtAtleta_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtAtleta.KeyPress
        If Not (e.KeyChar Like "[A-Z]") And e.KeyChar <> Convert.ToChar(Keys.Back) And e.KeyChar <> Convert.ToChar(Keys.Space) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnEntrarSalto_Click(sender As System.Object, e As System.EventArgs) Handles btnEntrarSalto.Click

        If seleccionado >= 0 Then
            If ListBox1.SelectedItem = "0" Then
                If rbtValido.Checked = True Then
                    Dim salto As Double = InputBox("Introduce salto", "SALTO")
                    If salto < 0 Or salto > 25 Then
                        MessageBox.Show("Salto fuera de limites. Limites--> Minimo: 0 Máximo: 25")
                        Exit Sub
                    End If
                    ListBox1.Items(seleccionado) = salto
                    If salto > maximo Then
                        maximo = salto
                    End If
                Else
                    ListBox1.Items(seleccionado) = "NULO"
                    totalNulos += 1
                End If
            ElseIf ListBox2.SelectedItem = "0" Then
                If rbtValido.Checked = True Then
                    Dim salto As Double = InputBox("Introduce salto", "SALTO")
                    If salto < 0 Or salto > 25 Then
                        MessageBox.Show("Salto fuera de limites. Limites--> Minimo: 0 Máximo: 25")
                        Exit Sub
                    End If
                    ListBox2.Items(seleccionado) = salto
                    If salto > maximo Then
                        maximo = salto
                    End If
                Else
                    ListBox2.Items(seleccionado) = "NULO"
                    totalNulos += 1
                End If
            ElseIf ListBox3.SelectedItem = "0" Then
                If rbtValido.Checked = True Then
                    Dim salto As Double = InputBox("Introduce salto", "SALTO")
                    If salto < 0 Or salto > 25 Then
                        MessageBox.Show("Salto fuera de limites. Limites--> Minimo: 0 Máximo: 25")
                        Exit Sub
                    End If
                    ListBox3.Items(seleccionado) = salto
                    If salto > maximo Then
                        maximo = salto
                    End If
                Else
                    ListBox3.Items(seleccionado) = "NULO"
                    totalNulos += 1
                End If
            Else
                MessageBox.Show("Ya ha realizado los 3 saltos")

            End If
        Else
            MessageBox.Show("Se debe seleccionar un atleta")

        End If

        procedimiento()
    End Sub

    Sub procedimiento()

        Dim mejorSalto As Integer
        lblNulo.Text = totalNulos
        If (ListBox1.Items.Contains(maximo)) Then
            mejorSalto = ListBox1.Items.IndexOf(maximo)
        ElseIf ListBox2.Items.Contains(maximo) Then
            mejorSalto = ListBox2.Items.IndexOf(maximo)
        ElseIf ListBox3.Items.Contains(maximo) Then
            mejorSalto = ListBox3.Items.IndexOf(maximo)
        End If

        If maximo <> 0 Then
            lblMejorSalto.Text = cbAtleta.Items(mejorSalto) & "              " & maximo
        End If
    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub
End Class
