Public Class Form1
    Dim l As ArrayList = New ArrayList

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        MessageBox.Show("Boton 1")
        hola() 'procedimiento, si hay dos q se llaman igual se ejecuta antes el q primero aparezca
        holas() 'procedimiento creado en modulo
        MessageBox.Show("otra vez boton 1")

    End Sub
    Sub hola() 'llamada a procedimiento hola
        MessageBox.Show("Estoy en hola")
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim resul As Long
        factorial(4, resul)
        MessageBox.Show("El factorial de 4 es: " & resul)

    End Sub
    Sub factorial(ByVal n As Integer, ByRef f As Long)
        If n = 0 Then
            f = 1
        Else
            f = 1
            While n > 0
                f = f * n
                n = n - 1
            End While

        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim a, b, s As Integer
        a = 7
        b = 13
        MessageBox.Show("valor de a: " & a)
        MessageBox.Show("valor de b: " & b)
        s = sumar(a, b) 'recoge un valor por eso ponemos s=, de aqui pasamos a la funcion, hace la suma y despues pasa al messageBox de abajo
        MessageBox.Show("La suma es: " & s)

        MessageBox.Show("valor de a: " & a)
        MessageBox.Show("valor de b: " & b)
    End Sub
    Function sumar(ByRef x As Integer, ByVal y As Integer) As Integer 'la funcion devuelve algo(as integer del final) // 'byVal es pasar por valor algo a otra variable, pero luego seguira valiendo lo que valia (en nuestro caso a=7,b=13), si pasamos por byRef, cambia el valor en la variable de arriba tb
        x = x + 10
        y = y + 10
        Return x + y
    End Function

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim a() As Integer = {10, 20, 30, 40}
        sumamatriz(a) 'se puede poner como parametro una matriz
        'cuando se pasa un array SIEMPRE es por REFERENCIA
        MessageBox.Show(a(2))
    End Sub

    Sub sumamatriz(ByRef matriz() As Integer)
        For i = 0 To matriz.Length - 1
            matriz(i) = matriz(i) + 4 'sumamos 4 a cada valor de la matriz
        Next
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        l.Add("1")
        l.Add(2)

        MessageBox.Show(CStr(l.Item(0) * 2))
        MessageBox.Show(CStr(l.Item(1) * 2))
    End Sub
End Class
