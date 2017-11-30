'Option Explicit Off ' no hace falta declarar las variables con dim
'Option Strict On 'sirve para pasar de single a integer, a string,etc...
Public Class Form2

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim a As Integer
        a = CInt(TextBox1.Text)
        MessageBox.Show(CStr(a))
    End Sub
End Class