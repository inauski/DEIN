Imports System.Math
Public Class Form1
    Private valor() As Single = {5, 1, 0.05, 0.01}
    Private salida(3) As TextBox

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        salida(0) = txta
        salida(1) = txtB
        salida(2) = txtc
        salida(3) = txtd
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        MessageBox.Show(salida(1).Text)
        MessageBox.Show(txtB.Text)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim cantidad As Single = CSng(txtValor.Text)
        For i = 0 To 3 ' valor.length -1 tb posible
            salida(i).Text = Int(cantidad / valor(i))
            cantidad = Round(cantidad Mod valor(i), 2) ' nos da 2 decimales

        Next
    End Sub

    Private Sub txta_Click(sender As Object, e As System.EventArgs) Handles txta.Click, txtB.Click, txtc.Click, txtd.Click ' al situarse sobre la caja saca el mensaje patata, se puede poner mas de una caja a la vez
        Dim indice As Integer = Array.IndexOf(salida, sender) 'esto es para saber el indice pulsado
        MessageBox.Show(indice)
        'MessageBox.Show("patata")
    End Sub

    Private Sub txta_TextChanged(sender As System.Object, e As System.EventArgs) Handles txta.TextChanged

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        TextBox1.Top = 0
        TextBox1.Left = 100
    End Sub
End Class
