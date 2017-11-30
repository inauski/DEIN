Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        TextBox2.PasswordChar = "" 'vuelve al estado normal la caja 2 al pulsar en el boton isNumeric
        If IsNumeric(TextBox1.Text) Then
            MessageBox.Show("Numerico")
        End If
    End Sub

    'Private Sub TextBox1_GotFocus(sender As Object, e As System.EventArgs) Handles TextBox1.GotFocus
    '    TextBox1.Text = "" 'Al clicar por 2ª vez en la caja 1 borra el foco
    'End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        'MessageBox.Show("key press") 'primero se produce key press y luego change,change cambia el textBox
        ' MessageBox.Show(e.KeyChar) 'muestra el caracter pulsado
        If AscW(e.KeyChar) = Keys.Enter Then 'mira si se a pulsado enter
            Label1.Text = TextBox1.Text
            TextBox2.Focus() 'se va el foco a la caja 2
        End If
        If Not (e.KeyChar Like "[A-ZÑ ]") And e.KeyChar <> Convert.ToChar(Keys.Back) Then '"[A-ZÑ8 ]" coge letras, la ñ, el 8 y espacio. Con e.KeyChar <> Convert.ToChar(Keys.Back) podemos borrar 
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        'MessageBox.Show("change")
    End Sub

    Private Sub TextBox1_Validated(sender As Object, e As System.EventArgs) Handles TextBox1.Validated
        MessageBox.Show("Haya patata en el universo")
    End Sub

    Private Sub TextBPPPox1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBox1.Validating
        If TextBox1.Text <> "PATATA" Then 'no saldremos de la caja 1 hasta poner patata(por validating)
            e.Cancel = True
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        ' Label2.Text = Int(4 + Rnd() * 3) 'ramdom. Con Int(4 + Rnd() * 3) sacamos num aleotorios entre 4 y 6 (int(menor + rnd()*(mayor-menor+1))
        Dim numeroaleatorio As New Random
        Dim a As Integer
        a = numeroaleatorio.Next(4, 6) ' genera num aleatorio entre 4 y menor q 6, pero 6 no,para q coja 6 hay q poner 7
        Label2.Text = a

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Randomize() ' utiliza Number para inicializar el generador de números aleatorios de la función Rnd asignándole un nuevo valor de inicialización
    End Sub
End Class
