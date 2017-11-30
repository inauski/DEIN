Public Class Form1
    Dim letras() As String = {"T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "KE"}


    Private Sub btnVerificar_Click(sender As System.Object, e As System.EventArgs) Handles btnVerificar.Click
        Dim dni As String
        Dim resp As Integer
        Dim resul As String

        If True Then
            dni = CInt(txtOpci.Text)
            resp = dni Mod 23
            resul = dni + letras(resp)
            MessageBox.Show(resul)
            frm2.ShowDialog()
        Else
            MessageBox.Show("NIF incorrecto", "AVISO")
        End If
    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class
