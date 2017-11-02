Public Class Form1
    Private zz As Integer

    'Const a as single = 5 , la va a valer todo el rato 5
    'MessageBox.show(FormatNumber(123456.567,2))
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim a, b, c As Integer
        a = 1
        b = 2
        c = 3
        ' operadores logicos:  >, >=, < , <=,  <>(distinto) , = (igual)
        If a > b Then
            MessageBox.Show("patata")
        ElseIf a = 15 Then
                MessageBox.Show("pato cua cua ")
        Else
            MessageBox.Show(" ddd")
            End If

        'and, or, not, tb se utilizan

    End Sub

    Private Sub selecCase_Click(sender As System.Object, e As System.EventArgs) Handles selecCase.Click
        'selec case es como switch
        Dim numero As Integer
        numero = CInt(TextBox1.Text)

        Select Case numero
            Case 1 ' tb se puede 1 to 5, de 1 a 5
                MessageBox.Show("uno")
                'Case 2   se puede separar valores por comas, funciona como el or, por ejemplo case 2, 3, 5 etc.
                MessageBox.Show("dos")
            Case Else
                MessageBox.Show("Otra cosa")
        End Select
    End Sub

    Private Sub opcAzul_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles opcAzul.CheckedChanged
        MessageBox.Show("cambio azul")
    End Sub

    Private Sub opcRojo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles opcRojo.CheckedChanged
        MessageBox.Show("cambio rojo")
    End Sub

    Private Sub opcAzul_Click(sender As Object, e As System.EventArgs) Handles opcAzul.Click
        MessageBox.Show("click azul")
    End Sub

    Private Sub opcRojo_Click(sender As Object, e As System.EventArgs) Handles opcRojo.Click
        MessageBox.Show("click rojo")
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If opcAzul.Checked = True Then
            MessageBox.Show("azul")
        Else
            MessageBox.Show("rojo")
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox2.TextChanged
        Dim jj As String
        jj = InputBox("introduce algo", "Nombre de la ventana") 'inputBox se utiliza para que salga una ventana nueva preguntando algo
        MessageBox.Show(jj * 2)
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged

    End Sub
End Class
