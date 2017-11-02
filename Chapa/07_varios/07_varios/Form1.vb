Public Class Form1

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Dim numero As Single = -123.567
        MessageBox.Show(Int(numero)) ' Int coge el entero menor, entre 1,5 y 2 , 1. Entre -1,5 y 2 coge -2
        MessageBox.Show(Fix(numero))  ' int coge la parte entera solamente
        Dim h As Integer = numero
        MessageBox.Show(h)
        ' / division normal, \ solo devuelve la parte entera de la division
    End Sub

End Class
