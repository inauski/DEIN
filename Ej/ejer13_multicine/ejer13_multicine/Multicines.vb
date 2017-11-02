Public Class Multicines
    Private horarios(2) As RadioButton
    Private salas(3) As RadioButton
    Private listas(3) As ListBox
    Private numsala, numhora As Integer
    Private datosLista(3) As Integer


    'definicion de los arrays

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        horarios(0) = rbt530
        horarios(1) = rbt700
        horarios(2) = rbt1000

        salas(0) = rbtSala1
        salas(1) = rbtSala2
        salas(2) = rbtSala3
        salas(3) = rbtSala4

        listas(0) = ListBox1
        listas(1) = ListBox2
        listas(2) = ListBox3
        listas(3) = ListBox4

        listas(0).SelectedIndex = 0

        datosLista(0) = 200
        datosLista(1) = 150
        datosLista(2) = 120
        datosLista(3) = 100
        cambiarMenu()

    End Sub

    'elegir los horarios
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbt530.CheckedChanged, rbt700.CheckedChanged, rbt1000.CheckedChanged
        numhora = Array.IndexOf(horarios, sender)
        marcar()
    End Sub

    'seleccionar la sala y el horario
    Sub marcar()
        Try
            listas(numsala).SelectedIndex = numhora
        Catch ex As Exception

        End Try

    End Sub

    'elegir las salas
    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtSala3.CheckedChanged, rbtSala1.CheckedChanged, rbtSala2.CheckedChanged, rbtSala4.CheckedChanged
        Try
            listas(numsala).SelectedIndex = -1 'Para no elegir ninguna, para deseleccionar
            numsala = Array.IndexOf(salas, sender)
            marcar()
        Catch ex As Exception

        End Try

    End Sub

    'restar entradas
    Private Sub btVenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btVenta.Click
        Dim pos, cant As Integer
        If listas(numsala).SelectedIndex = -1 Then
            MessageBox.Show("No hay sala seleccionada", "ERROR")
        Else
            If txtEntradas.Text = "" Then
                MessageBox.Show("No ha introducido cantidad", "ERROR")
            Else
                If txtEntradas.Text > CInt(listas(numsala).Items(numhora)) Then
                    MessageBox.Show("Vas a vender mas de las que hay", "ERROR")
                Else
                    pos = listas(numsala).SelectedIndex 'la posicion
                    cant = CInt(listas(numsala).Items(numhora)) 'la cantidad
                    listas(numsala).Items.RemoveAt(pos)
                    listas(numsala).Items.Insert(pos, (cant - CInt(txtEntradas.Text)))
                    listas(numsala).SelectedIndex = numhora

                End If
            End If
        End If
    End Sub

    'suma entradas
    Private Sub btDevolucion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDevolucion.Click
        Dim pos, cant As Integer
        If listas(numsala).SelectedIndex = -1 Then
            MessageBox.Show("No hay sala seleccionada", "ERROR")
        Else
            If txtEntradas.Text = "" Then
                MessageBox.Show("No ha introducido cantidad", "ERROR")
            Else
                If CInt(listas(numsala).Items(numhora)) + txtEntradas.Text > datosLista(numsala) Then
                    MessageBox.Show("Vas a devolver mas de las que hay", "ERROR")
                Else
                    pos = listas(numsala).SelectedIndex 'guardamos la posicion en pos
                    cant = CInt(listas(numsala).Items(numhora)) 'guardamos la cantidad en cant
                    listas(numsala).Items.RemoveAt(pos)
                    listas(numsala).Items.Insert(pos, (cant + CInt(txtEntradas.Text)))
                    listas(numsala).SelectedIndex = numhora
                End If
            End If
        End If
    End Sub

    Private Sub txtnEntradas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEntradas.KeyPress
        If Not (e.KeyChar Like "[0-9]") And e.KeyChar <> Convert.ToChar(Keys.Back) Then 'si no introducimos numeros en las entradas no DEJA ESCRIBIRLO
            e.Handled = True
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CambioDePeliculaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambioDePeliculaToolStripMenuItem.Click
        cambio.ShowDialog() 'se bloquea el anterior
    End Sub

    'Para cambiar los nombres en el menuStrip1
    Public Sub cambiarMenu()
        peli1.Text = titulo1.Text
        peli2.Text = titulo2.Text
        peli3.Text = titulo3.Text
        peli4.Text = titulo4.Text
    End Sub

    Private Sub peli1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles peli1.Click
        Caratula.Show()
        Try
            Caratula.PictureBox1.Image = Image.FromFile(Application.StartupPath & "\caratulas\" & peli1.Text & ".jpg")
            ' cargar un doc.rtf en la caja
            Caratula.RichTextBox1.LoadFile(Application.StartupPath & "\sinopsis\lossimpsons.rtf")
        Catch ex As Exception
            Caratula.PictureBox1.Image = Image.FromFile(Application.StartupPath & "\caratulas\NODISP.jpg")
            'cargar un texto en la caja
            Caratula.RichTextBox1.Text = "No hay documento"
        End Try

    End Sub

    'Lo mismo que el anterior pero para peli2,peli3 y peli4
    Private Sub peli2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles peli2.Click
        Caratula.Show()
        Try
            Caratula.PictureBox1.Image = Image.FromFile(Application.StartupPath & "\caratulas\" & peli2.Text & ".jpg") 'saca las imagenes cada vez q cambiamos
            'cargar un doc.rtf en la caja
            Caratula.RichTextBox1.LoadFile(Application.StartupPath & "\sinopsis\minions.rtf")

        Catch ex As Exception
            Caratula.PictureBox1.Image = Image.FromFile(Application.StartupPath & "\caratulas\NODISP.jpg") 'saca las imagenes cada vez q cambiamos
            Caratula.RichTextBox1.Text = "No hay documento"
        End Try

    End Sub

    Private Sub peli3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles peli3.Click
        Caratula.Show()

        Try
            Caratula.PictureBox1.Image = Image.FromFile(Application.StartupPath & "\caratulas\" & peli3.Text & ".jpg") 'saca las imagenes cada vez q cambiamos
            Caratula.RichTextBox1.LoadFile(Application.StartupPath & "\sinopsis\it.rtf")

        Catch ex As Exception
            Caratula.PictureBox1.Image = Image.FromFile(Application.StartupPath & "\caratulas\NODISP.JPG") 'saca las imagenes cada vez q cambiamos
            Caratula.RichTextBox1.Text = "No hay documento"
        End Try

    End Sub

    Private Sub peli4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles peli4.Click
        Caratula.Show()

        Try
            Caratula.PictureBox1.Image = Image.FromFile(Application.StartupPath & "\caratulas\" & peli4.Text & ".jpg") 'saca las imagenes cada vez q cambiamos
            Caratula.RichTextBox1.LoadFile(Application.StartupPath & "\sinopsis\Emoji.rtf")
        Catch ex As Exception
            Caratula.PictureBox1.Image = Image.FromFile(Application.StartupPath & "\caratulas\NODISP.JPG") 'saca las imagenes cada vez q cambiamos
            Caratula.RichTextBox1.Text = "No hay documento"
        End Try
    End Sub
End Class

