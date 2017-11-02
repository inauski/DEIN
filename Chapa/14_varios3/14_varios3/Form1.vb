Public Class Form1
    ''probamos en depurar-ventana-inmediato y vemos el orden en el que se ejecutan las declaraciones
    'Private Sub Form1_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
    '    Debug.Print("activated")
    'End Sub

    'Private Sub Form1_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    '    Debug.Print("closed")
    'End Sub

    'Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    '    Debug.Print("closing")
    'End Sub

    'Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
    '    Debug.Print("load")
    'End Sub

    'Private Sub Form1_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
    '    Debug.Print("paint")
    'End Sub

    'Private Sub Form1_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
    '    Debug.Print("resize")
    'End Sub

    'Private Sub Form1_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
    '    Debug.Print("shown")
    'End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'txtDato.SelectionStart = 1
        'txtDato.SelectionLength = 3
        'txtDato.Focus()
        'MessageBox.Show(txtDato.SelectedText) 'coge los caracteres desde la pos 0 hasta la 3 

        'With txtDato
        '    .SelectionStart = 1
        '    .SelectionLength = 3
        '    .Focus()
        'End With

        txtDato.Select(2, 3)
        txtDato.Focus()
        MessageBox.Show(txtDato.SelectedText.Length) 'devuelve 3 pq es los caracteres q seleccionamos en las dos lineas de arriba

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        MessageBox.Show(InStr(txtDato2.Text, ",")) 'busca el caracter coma en txtdato2,las numera desde la pos 1, si no esta devuelve 0
        MessageBox.Show(txtDato2.Text.IndexOf(","c)) 'como el anterior solo q empieza desde 0 y devuelve -1 si no esta
        MessageBox.Show(txtDato2.Text.LastIndexOf(","c))

    End Sub

    Private Sub txtDato2_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtDato2.KeyPress
        'PARA QUE SOLO DEJE INSERTAR UNA COMA y retroceso

        If (Not (e.KeyChar Like "[0-9,]") And AscW(e.KeyChar) <> Keys.Back) Then
            e.Handled = True
        Else
            If e.KeyChar = "," And txtDato2.Text.IndexOf(","c) <> -1 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub txtDato2_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDato2.TextChanged

    End Sub

    Private Sub txtDato2_Validated(sender As Object, e As System.EventArgs) Handles txtDato2.Validated
        txtDato2.Text = FormatNumber(txtDato2.Text, 2) 'FORMATEA el NUMERO a 2 decimales y pone el punto de los miles
    End Sub

    Private Sub txtDato2_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtDato2.Validating
        'si no insertamos numero no deja hacer nada mas
        If Not IsNumeric(txtDato2.Text) Then
            e.Cancel = True
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        PictureBox1.Image = Image.FromFile(Application.StartupPath & "\cosas\triangulo.jpg") 'Application.StartPath sirve para cargar desde el debug
        RichTextBox1.LoadFile(Application.StartupPath & "\cosas\triangulito.rtf")
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CerrarToolStripMenuItem.Click
        MessageBox.Show("cerrar")
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        'MessageBox.Show("afddf","aviso")
        Dim respuesta As DialogResult

        respuesta = MessageBox.Show("Te has divertido?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Hand)
        If respuesta = Windows.Forms.DialogResult.Yes Then
            MessageBox.Show("Si")
        Else
            MessageBox.Show("No")
        End If
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        MessageBox.Show(hs.Value)
    End Sub

    Private Sub hs_Scroll(sender As System.Object, e As System.Windows.Forms.ScrollEventArgs) Handles hs.Scroll
        Label1.Text = hs.Value
    End Sub
End Class
