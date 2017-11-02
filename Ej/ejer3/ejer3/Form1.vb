Public Class Form1
    Dim cant As Integer
    Dim temp, max, min, media, suma As Double
    'Private mayor as single= single.MinValue
    'Private menor as single= single.MaxValue

    Private Sub btnTemp_Click(sender As System.Object, e As System.EventArgs) Handles btnTemp.Click

        temp = CDbl(txtTemp.Text)
        If cant = 0 Then
            min = 55
            max = 0
        End If
        If (opcCalor.Checked = True) Then
            If temp <= 11 Or temp >= 50 Then 'fuera de limites
                MessageBox.Show("La temperatura ha de estar entre 11 y 50 grados", "HACE CALOR")
            Else
                If (temp > max) Then
                    max = temp
                End If

                If (temp < min) Then
                    min = temp
                End If

                txtMax.Text = max
                txtMin.Text = min

                cant = cant + 1
                suma = suma + temp
                media = suma / cant

                txtConta.Text = cant
                txtMedia.Text = media
            End If

        End If
        If (opcFrio.Checked = True) Then
            If temp <= 0 Or temp >= 10 Then 'fuera de limites
                MessageBox.Show("La temperatura ha de estar entre 0 y 10", "HACE FRIO")
            Else
                If (temp > max) Then
                    max = temp
                End If
                If (temp < min) Then
                    min = temp
                End If

                txtMax.Text = max
                txtMin.Text = min

                cant = cant + 1
                suma = suma + temp
                media = suma / cant

                txtConta.Text = cant
                txtMedia.Text = media


            End If
        End If

    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class
