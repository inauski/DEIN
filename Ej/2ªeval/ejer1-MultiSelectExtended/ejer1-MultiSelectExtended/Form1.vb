Public Class Form1

 
    Private Sub btnA2Simp_Click(sender As System.Object, e As System.EventArgs) Handles btnA2Simp.Click
        Try
            If ListBox1.SelectedIndex = -1 Then
                MessageBox.Show("Debe seleccionar algun elemento")
                Exit Sub
            End If
            For i = ListBox1.Items.Count - 1 To 0 Step -1
                If ListBox1.GetSelected(i) Then
                    ListBox2.Items.Add(ListBox1.SelectedItem)
                    ListBox1.Items.Remove(ListBox1.SelectedItem)
                    btnA1Simp.Enabled = True
                    btnA1Complejo.Enabled = True
                    If ListBox1.Items.Count = 0 Then
                        btnA2Simp.Enabled = False
                        btnA2Complejo.Enabled = False
                    End If
                End If
            Next
        Catch ex As ArgumentNullException
            MessageBox.Show("No se ha seleccionado ningun elemento")
        End Try
    End Sub

    Private Sub btnA1Simp_Click(sender As System.Object, e As System.EventArgs) Handles btnA1Simp.Click
        Try
            If ListBox2.SelectedIndex = -1 Then
                MessageBox.Show("Debe seleccionar algun elemento")
                Exit Sub
            End If
            For i = ListBox2.Items.Count - 1 To 0 Step -1
                If ListBox2.GetSelected(i) Then
                    ListBox1.Items.Add(ListBox2.SelectedItem)
                    ListBox2.Items.Remove(ListBox2.SelectedItem)
                    btnA2Simp.Enabled = True
                    btnA2Complejo.Enabled = True
                    If ListBox2.Items.Count = 0 Then
                        btnA1Simp.Enabled = False
                        btnA1Complejo.Enabled = False
                    End If
                End If
            Next
        Catch ex As ArgumentNullException
            MessageBox.Show("No se ha seleccionado ningun elemento")
        End Try
    End Sub

    Private Sub btnA2Complejo_Click(sender As System.Object, e As System.EventArgs) Handles btnA2Complejo.Click

        For x = 0 To ListBox1.Items.Count - 1
            If ListBox1.GetSelected(x) = False Then
                ListBox1.SetSelected(x, True)
                ListBox2.Items.Add(ListBox1.SelectedItem)
                If ListBox1.Items.Count = 0 Then
                    btnA2Simp.Enabled = False
                    btnA2Complejo.Enabled = False
                End If
                If ListBox2.Items.Count > 0 Then
                    btnA1Simp.Enabled = True
                    btnA1Complejo.Enabled = True
                End If
            End If
        Next
        ListBox1.Items.Clear()

    End Sub

    Private Sub btnA1Complejo_Click(sender As System.Object, e As System.EventArgs) Handles btnA1Complejo.Click

        For x = 0 To ListBox2.Items.Count - 1
            If ListBox2.GetSelected(x) = False Then
                ListBox2.SetSelected(x, True)
                ListBox1.Items.Add(ListBox2.SelectedItem)

                If ListBox2.Items.Count = 0 Then
                    btnA1Simp.Enabled = False
                    btnA1Complejo.Enabled = False
                End If
                If ListBox1.Items.Count > 0 Then
                    btnA2Simp.Enabled = True
                    btnA2Complejo.Enabled = True
                End If
            End If
        Next
        ListBox1.Items.Clear()
    End Sub
End Class
