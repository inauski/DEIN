Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim i As Integer
        i = 1
        While i < 6
            'MessageBox.Show(i)
            'i += 1 No se puede poner i++
            lstDatos.Items.Add(i)
            i += 1
            If i = 3 Then Exit While
        End While
        MessageBox.Show("Fin while", "WHILE")

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        lstDatos.Items.Clear()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim i As Integer
        i = 1
        Do While i < 6
            
            lstDatos.Items.Add(i)
            i += 1
            If i = 3 Then Exit Do 'Para salir del do while
        Loop
        MessageBox.Show("Fin Do While", "WHILE")
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim i As Integer
        i = 1
        Do Until i = 6 'hasta que sea igual a 6
            lstDatos.Items.Add(i)
            i += 1
            'If i = 3 Then Exit Do 'Para salir del do while
        Loop
        MessageBox.Show("Fin Do Until", "Do Until")
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Dim i As Integer
        i = 1
        Do ' se ejecuta minimo una vez lo q esta dentro del ciclo
            lstDatos.Items.Add(i)
            i += 1
            'If i = 3 Then Exit Do 'Para salir del do while
        Loop While i < 6
        MessageBox.Show("Fin Do Loop While", "WHILE")
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Dim i As Integer
        i = 1
        Do ' se ejecuta minimo una vez lo q esta dentro del ciclo
            lstDatos.Items.Add(i)
            i += 1
            'If i = 3 Then Exit Do 'Para salir del do while
        Loop Until i = 6
        MessageBox.Show("Fin Do Loop Until", "WHILE")
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Dim i As Integer
        For i = 1 To 5 Step 1 'se incrementa en 1 con step, es como i++, tb se puede decrementar,por defecto si no se escribe step ,es 1
            lstDatos.Items.Add(i)
            'If i = 2 Then Exit For  ->sale del for cuando llega a 2

        Next
        MessageBox.Show(i) 'Fuera del for, el num cargado vale uno mas de lo q se ha introducido, aqui 6


    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        Dim dato As String
        dato = TextBox1.Text
        MessageBox.Show(Asc(dato)) 'asc sirve para meter el caracter ascii, lo contrario es chr
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        Dim dato As Integer
        dato = CInt(TextBox2.Text)
        MessageBox.Show(Chr(dato))
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        Dim a, b As Integer
        a = CInt(TextBox1.Text)
        b = CInt(TextBox2.Text)
        If a > b Then
            MessageBox.Show("MAYOR") 'hay q tener cuidado pq 11 no es mayor q 7, porq para comparar utiliza el cod ascii y el 7 es mayor que 11, para eso lo utilizamos con integer y lo convertimos con CInt
        End If
    End Sub

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        TextBox1.Font = New System.Drawing.Font("Comic Sans", 22)
    End Sub
End Class
