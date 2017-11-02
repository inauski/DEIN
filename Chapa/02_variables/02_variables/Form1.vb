Public Class frmVariables
    Dim i As Integer 'las variables se pueden declarar como dim o private 

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtNumero_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNumero.TextChanged

    End Sub

    Private Sub btnVer_Click(sender As System.Object, e As System.EventArgs) Handles btnVer.Click
        'Static i As Integer
        i = i + 25
        etResultado.Text = i
    End Sub

    Private Sub btnVer2_Click(sender As System.Object, e As System.EventArgs) Handles btnVer2.Click
        'Dim i As Integer
        i = i + 13
        txtNumero.Text = i 'las variables num se inicializan por defecto a 0 pero si lo inicializamos como static ira sumando cada vez
    End Sub

    Private Sub btnForm2_Click(sender As System.Object, e As System.EventArgs) Handles btnForm2.Click
        MessageBox.Show("jjj") 'esto es para ir de un form a otro
        Form2.ShowDialog() 'para abrir formulario de forma modal se utiliza showDialog
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles ZZZ.Click

    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class
