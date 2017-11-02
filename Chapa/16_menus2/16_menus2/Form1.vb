Public Class Form1

    Private Sub ArchivoToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles menuArchi.Click
        MessageBox.Show("Archivo")
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles menuSalir.Click

    End Sub

    Private Sub SalirToolStripMenuItem_MouseEnter(sender As Object, e As System.EventArgs) Handles menuSalir.MouseEnter
        etEstado.Text = "Cierra la aplicacion" 'Cuando estamos en el menu pero no en salir pone, cierre la aplicacion
    End Sub

    Private Sub SalirToolStripMenuItem_MouseLeave(sender As Object, e As System.EventArgs) Handles menuSalir.MouseLeave
        etEstado.Text = "Listooooooo" 'Cuando estemos encima de salir se escribe listoooo
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked
        'Desde el menu, elegimos toolStrip para poder poner el menu de la parte de arriba, podemos insertar por defecto varios iconos con clic derecho-insertar elementos estandar
    End Sub

    Private Sub mnuAñadir_Click(sender As System.Object, e As System.EventArgs) Handles mnuAñadir.Click
        Dim titulo As String
        titulo = "Pais " & mnuPais.DropDownItems.Count - 2 '-2 pq sino empezaria a contar en 3 el nuevo hueco añadido para el pais 

        Dim elemento As ToolStripMenuItem = New ToolStripMenuItem(titulo) 'añade un nuevo hueco de menu con un nuevo titulo 
        mnuPais.DropDownItems.Add(elemento)

        AddHandler elemento.Click, AddressOf elementomenupais_click

    End Sub

    Sub elementomenupais_click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim elemento As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
        MsgBox(elemento.Text)
    End Sub

    Private Sub mnuBorrar_Click(sender As System.Object, e As System.EventArgs) Handles mnuBorrar.Click
        Dim indice As Integer = mnuPais.DropDownItems.Count - 1 'para borrar el ultimo pais añadido
        mnuPais.DropDownItems.RemoveAt(indice)
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        'podemos asignarle un menu, a un textBox, a un boton ,desde la opcion contextMenu del textBox,boton,etc
    End Sub


    Private Sub ToolStripMenuItem4_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem4.Click
        My.Computer.Clipboard.SetText(TextBox1.Text) 'COPIAMOS al portapapeles al clicar en el primer boton del mnuBotonDcho
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        etEstado.Text = My.Computer.Clipboard.GetText() 'ponemos en la etiqueta de abajo lo que hemos COPIADO en el portapapeles desde el menu,cuando pinchemos en el boton
    End Sub
End Class
