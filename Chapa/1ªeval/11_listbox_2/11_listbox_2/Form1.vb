Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        MessageBox.Show(lstDatos.GetSelected(2)) 'devuelve true si esta seleccionada la posicion    
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        lstDatos.SetSelected(2, True) 'selecciona desde el boton la posicion indicada con true
        lstDatos.SetSelected(4, False)
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        lstDatos_2.Items.Clear()

        For i = 0 To lstDatos.Items.Count - 1
            If lstDatos.GetSelected(i) Then
                lstDatos_2.Items.Add(lstDatos.Items(i))
            End If
        Next
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        lstDatos_2.Items.Clear()

        For Each paso As Object In lstDatos.SelectedItems
            lstDatos_2.Items.Add(paso)
        Next
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Dim t() As String = {"aa", "fff", "ddd"} 'tiene que ser string. Al pulsar en el boton carga el array
        lstDatos_2.Items.AddRange(t)
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        If lstDatos.Items.Contains("Avila") Then ' tiene que estar escrito exactamente igual
            MessageBox.Show("Existe")
        Else
            MessageBox.Show("No existe")
        End If
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click

        MessageBox.Show(lstDatos.Items.IndexOf("Avila")) ' devuelve el indice del string pasado,si no existe devuelve -1

    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        Dim provincia As String
        provincia = InputBox("Introduce provincia... ", "HOLA")
        provincia = provincia.ToLower 'para evitar los espacios existe trim, y para las mayus, toUpper

        If lstDatos.Items.Contains(provincia) Then
            MessageBox.Show("Existe")
        Else
            MessageBox.Show("No existe")
            lstDatos.Items.Add(provincia)
        End If
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        MessageBox.Show(lstDatos.SelectedIndex)
        lstDatos.SelectedIndex = 0 ' le pasas el indice que quieres que se quede como seleccionado

    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        ListBox1.Items.Add("89")
    End Sub

    Private Sub ListBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstDatos2.SelectedIndexChanged

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub btnOrdenar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrdenar.Click
        Dim total As Integer = LstDatos2.Items.Count
        Dim auxiliar As String
        For i = total - 1 To 1 Step -1 'si son 5 nums son 4 indices por lo tanto total -1 y vamos hasta el indice 1 restando de 1 en 1
            For x = 0 To i - 1 'con este 2º for, comparamos el indice q se va restando, es decir , al principio teniamos 4 indices pero al colocar el mayor en la ultima pos, nos quedamos con 3 indices a comparar, despues colocamos en indice 3 el mayor y nos quedamos con 2 nums a comparar, etc.
                If CInt(LstDatos2.Items(x)) > CInt(LstDatos2.Items(x + 1)) Then 'se convierte a int para q hagan bien la comparacion
                    auxiliar = LstDatos2.Items(x)
                    LstDatos2.Items(x) = LstDatos2.Items(x + 1)
                    LstDatos2.Items(x + 1) = auxiliar

                    auxiliar = LstDatos1.Items(x)
                    LstDatos1.Items(x) = LstDatos1.Items(x + 1)
                    LstDatos1.Items(x + 1) = auxiliar
                End If
            Next
        Next
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Dim fruta, precio As String
        Dim i As Integer

        fruta = InputBox("Nueva Fruta", "FRUTA")
        precio = InputBox("Nuevo Precio", "PRECIO")

        For i = 0 To LstDatos2.Items.Count - 1
            If CInt(precio) < CInt(LstDatos2.Items(i)) Then
                Exit For
            End If
        Next
        LstDatos1.Items.Insert(i, fruta)
        LstDatos2.Items.Insert(i, precio)
    End Sub

    Private Sub lstDatos_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstDatos.SelectedIndexChanged

    End Sub
End Class
