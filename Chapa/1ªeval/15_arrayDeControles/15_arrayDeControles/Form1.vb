Public Class Form1
    Dim i As Integer
    Const palabra As String = "PATATA"
    Dim x As Integer = 1

    Dim sala(4) As RadioButton

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        i = i + 1
        Label1.Text = i

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Timer1.Enabled = True
        'Intervalo en milisegundos
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Button1.Enabled = False
        Timer1.Enabled = False
        Timer2.Enabled = True
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        Label2.Text = palabra.Substring(0, x)
        x = x + 1
        If x > palabra.Length Then
            Timer2.Enabled = False
        End If
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        sala(0) = ra
        sala(1) = rb
        sala(2) = rc
        sala(3) = rd
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        MessageBox.Show(sala(1).Text) 'es lo mismo esto que rb.text
        MessageBox.Show(rb.Text)
    End Sub

    Private Sub pulsadoSala(sender As Object, e As System.EventArgs) Handles ra.Click, rb.Click, rc.Click, rd.Click
        'MessageBox.Show("Cri cri cri") 'cuando se pulsan los botones hace cri cri
        Dim indice As Integer = Array.IndexOf(sala, sender) 'nos da el indice de cada radioButton al pulsarlo
        MessageBox.Show(indice)
        MessageBox.Show(sala(indice).Text)
    End Sub
End Class
