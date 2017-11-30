Public Class Form1

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        etHora.Text = Date.Now.ToLongTimeString
    End Sub

    Private Sub lstImagenes_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstImagenes.SelectedIndexChanged
        If lstImagenes.SelectedItem = "HIPOTALAMO" Then
            PictureBox1.Image = Image.FromFile(Application.StartupPath & "\imagenes\" & "hipotalamo.jpg")
        ElseIf lstImagenes.SelectedItem = "PSICODREAMER" Then
            PictureBox1.Image = Image.FromFile(Application.StartupPath & "\imagenes\" & "psico.jpg")
        ElseIf lstImagenes.SelectedItem = "IMAGEN" Then
            PictureBox1.Image = Image.FromFile(Application.StartupPath & "\imagenes\" & "imagen.jpg")
        ElseIf lstImagenes.SelectedItem = "BELFOS" Then
            PictureBox1.Image = Image.FromFile(Application.StartupPath & "\imagenes\" & "belfo.jpg")
        Else
            PictureBox1.Image = Image.FromFile(Application.StartupPath & "\imagenes\" & "no disponible.jpg")
        End If
    End Sub

    Private Sub AlfinalToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AlfinalToolStripMenuItem.Click
        frmAltasFinal.ShowDialog()
    End Sub

    Private Sub EnPosicionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EnPosicionToolStripMenuItem.Click
        frmAltasEnPos.ShowDialog()
    End Sub

    Private Sub BorrarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BorrarToolStripMenuItem.Click
        frmBajas.ShowDialog()
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AcercaDeToolStripMenuItem.Click
        frmAcercaDe.ShowDialog()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Dispose()
    End Sub

    Private Sub IcoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles IcoToolStripMenuItem.Click
        Dim dlgAbrir As New OpenFileDialog
        dlgAbrir.ShowReadOnly = True
        dlgAbrir.InitialDirectory = "c:\"
        dlgAbrir.Filter = "Los ico|*.ico"
        dlgAbrir.RestoreDirectory = True
        If dlgAbrir.ShowDialog = Windows.Forms.DialogResult.OK Then
            MessageBox.Show(dlgAbrir.FileName)
        Else
            MessageBox.Show("Has cancelado")
        End If
    End Sub

    Private Sub JpgToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles JpgToolStripMenuItem.Click
        Dim dlgAbrir As New OpenFileDialog
        dlgAbrir.ShowReadOnly = True
        dlgAbrir.InitialDirectory = "c:\"
        dlgAbrir.Filter = "Los jpg|*.jpg"
        dlgAbrir.RestoreDirectory = True
        If dlgAbrir.ShowDialog = Windows.Forms.DialogResult.OK Then
            MessageBox.Show(dlgAbrir.FileName)
        Else
            MessageBox.Show("Has cancelado")
        End If
    End Sub
End Class
