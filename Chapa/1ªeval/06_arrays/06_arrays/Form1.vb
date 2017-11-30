Public Class Form1
    Private t() As String = {10, 11, 22, 33, 44, 55}

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim m(3) As Integer 'el num entre parentesis es el ultimo num indice
        Dim i As Integer
        m(0) = 10
        m(1) = 11
        m(2) = 22
        m(3) = 33

        For i = 0 To m.Length - 1 ' tb se puede poner to 3
            lstDatos.Items.Add(m(i))
        Next
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        lstDatos.Items.Clear()

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim diasemana() As String = {"Lunes", "Martes", "Miercoles", "Jueves"}

        For i = 0 To diasemana.Length - 1 ' tb se puede poner to 3
            lstDatos.Items.Add(diasemana(i))
        Next
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click


        'For i = 0 To t.Length - 1 ' tb se puede poner to 3
        '    lstDatos.Items.Add(t(i))
        'Next

        ReDim Preserve t(2) 'redimensiona el array guardando los valores
        lstDatos.Items.Clear()


        For i = 0 To t.Length - 1 ' tb se puede poner to 3
            lstDatos.Items.Add(t(i))
        Next
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        'Dim i As Integer

        ReDim Preserve t(t.Length)
        Dim valor As Integer
        valor = CInt(InputBox("Introduce numero", "NUMERO"))
        t(t.Length - 1) = valor

        lstDatos.Items.Clear()

        For i = 0 To t.Length - 1 ' tb se puede poner to 3
            lstDatos.Items.Add(t(i))
        Next

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        't(1) = 9090
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Dim numero() As Integer = {11, 22, 33, 11, 44, 11, 22, 99}
        lstDatos.Items.Clear()
        For i = 0 To numero.Length - 1
            lstDatos.Items.Add(numero(i))
        Next
        Dim buscar As Integer
        buscar = CInt(InputBox("Introduce numero", "AVISO"))

        Dim encontrado As Boolean = False
        For i = 0 To numero.Length - 1
            If (buscar = numero(i)) Then
                MessageBox.Show("Posicion: " & CStr(i), "Encontrado")
                encontrado = True

            End If
        Next
        If encontrado = False Then
            MessageBox.Show("No encontrado", "AVISO")
        End If
        

    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Dim numero() As Integer = {11, 22, 33, 11, 44, 11, 22, 99}
        lstDatos.Items.Clear()
        For i = 0 To numero.Length - 1
            lstDatos.Items.Add(numero(i))
        Next
        Dim buscar As Integer
        buscar = CInt(InputBox("Introduce numero", "AVISO"))

        Dim encontrado As Boolean = False
        For i = 0 To numero.Length - 1
            If (buscar = numero(i)) Then
                MessageBox.Show("Posicion: " & CStr(i), "Encontrado")
                encontrado = True
                'exit for (para la primera vez q lo encuentra y en caso de que el num se repita mas de una vez)
            End If
        Next
        If encontrado = False Then
            MessageBox.Show("No encontrado", "AVISO")
        End If
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        Dim numero() As Integer = {11, 22, 33, 55}
        lstDatos.Items.Clear()
        For i = 0 To numero.Length - 1
            lstDatos.Items.Add(numero(i))
        Next
        Dim buscar As Integer
        buscar = CInt(InputBox("Introduce numero", "AVISO"))
        Dim x As Integer
        x = System.Array.BinarySearch(numero, buscar) 'busca en la tabla 'numero' la posicion 'buscar', tiene que estar el array ordenado
        MessageBox.Show(x)
        If x >= 0 Then
            MessageBox.Show("Posicion: " & CStr(x))
        Else
            MessageBox.Show("No está")
        End If
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        Dim numero() As Integer = {111, 22, 323, 5, 77}


        System.Array.Sort(numero)
        lstDatos.Items.Clear()
        For i = 0 To numero.Length - 1
            lstDatos.Items.Add(numero(i))
        Next
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        Dim numero() As Integer = {111, 22, 323, 5, 77}

        System.Array.Sort(numero) 'primero los ordena
        System.Array.Reverse(numero) ' y los saca de mayor a menor
        lstDatos.Items.Clear()
        For i = 0 To numero.Length - 1
            lstDatos.Items.Add(numero(i))
        Next
    End Sub

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        Dim numero() As Integer = {111, 22, 323, 5, 77}

        System.Array.Clear(numero, 0, numero.Length) 'el 0 nos que numero pone en la posicion pasada en numero.length

        lstDatos.Items.Clear()
        For i = 0 To numero.Length - 1
            lstDatos.Items.Add(numero(i))
        Next
    End Sub

    Private Sub Button12_Click(sender As System.Object, e As System.EventArgs) Handles Button12.Click
        Dim numero() As Integer = {111, 22, 323, 5, 77}
        Dim copia(numero.Length - 1) As Integer


        System.Array.Copy(numero, 0, copia, 0, numero.Length) 'copia los elem de la tabla numero desde la posicion 0 a la tabla copia desde la posicion 0. Con numero.length le decimos los elem a copiar, en este caso todos

        lstDatos.Items.Clear()
        For i = 0 To numero.Length - 1
            lstDatos.Items.Add(copia(i))
        Next
    End Sub

    Private Sub Button13_Click(sender As System.Object, e As System.EventArgs) Handles Button13.Click
        Dim frase As String = "Hola hoy es martes"

        MessageBox.Show(frase.Length) ' nos da los caracteres en total de frase
        MessageBox.Show(frase.Substring(5, 3)) 'coge de frase desde la pos 5 3 caracteres
    End Sub

    Private Sub Button14_Click(sender As System.Object, e As System.EventArgs) Handles Button14.Click
        frm2.ShowDialog() 'Para que habra el segundo formulario y no nos deje tocar el primero, showDialog,sino solo show.
    End Sub
End Class
