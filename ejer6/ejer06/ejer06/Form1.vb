Public Class Form1
    Private dineros() As Double = {500, 200, 100, 50, 20, 10, 5, 2, 1, 0.5, 0.2, 0.1, 0.05, 0.02, 0.01}
    Private moneda(dineros.Length) As TextBox

    Private Sub btCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCalcular.Click
        Dim numero As Double
        Dim euros(14) As Double
        numero = CDbl(txtCantidad.Text)
        For i = 0 To dineros.Length - 1
            euros(i) = Int(numero / dineros(i))
            numero = Math.Round(numero Mod dineros(i), 2)
            moneda(i).Text = euros(i)
            If (moneda(i).Text = 0) Then
                moneda(i).Visible = False
            End If
        Next
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        moneda(0) = txt500
        moneda(1) = txt200
        moneda(2) = txt100
        moneda(3) = txt50
        moneda(4) = txt20
        moneda(5) = txt10
        moneda(6) = txt5
        moneda(7) = txt2
        moneda(8) = txt1
        moneda(9) = txt050
        moneda(10) = txt020
        moneda(11) = txt010
        moneda(12) = txt005
        moneda(13) = txt002
        moneda(14) = txt001
    End Sub

    Private Sub btTerminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btTerminar.Click
        Me.Close()
    End Sub
End Class
