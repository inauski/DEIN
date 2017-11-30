Public Class frmTipos
    'tipos de variables
    Private Sub btnCalcular_Click(sender As System.Object, e As System.EventArgs) Handles btnCalcular.Click
        'integer para num enteros, long, para decimales single, y double num grandes, para nombres string
        Dim num1, num2, resultado As Single

        'MessageBox.Show(0.5 * 4) se utiliza para que salga una ventana flotante

        'num1 = CSng(txt1.Text) 'CSng para convertir a single, tambien hay Cint, Clng, cdbl, cstr
        'num2 = CSng(txt2.Text)
        'resultado = num1 * num2
        'txtResul.Text = CStr(resultado)

        ' sumar + ,restar -, multiplicar * , dividir /, resto mod, division entera \
        'MessageBox.Show(7 \ 2)
        'MessageBox.Show ("Hola " + "caracola") 'para concatenar cadenas se puede usar el + pero mejor usar &
        'MessageBox.Show(CInt(txt1.Text) + CInt(txt2.Text))
    End Sub

    Private Sub frmTipos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'Dim a, b, s As Double
        'a = CDbl(txt1.Text)
        'b = CDbl(txt2.Text)
        's = a * b
        'txtResul.Text = Format(s, "#,##0.00") ' para formatear la salida, si se pone 0 se escribe el numero q esta en esa posicion, si tiene almuadilla, si no es necesario no escribe
        'txtResul.t()
        'MessageBox.Show(2 ^ 4) ' para exponenciacion
    End Sub
End Class
