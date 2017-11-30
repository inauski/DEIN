Public Class Form1

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        ListBox1.SelectedIndex = ComboBox1.SelectedIndex
        If ListBox1.SelectedIndex = 0 Then
            PictureBox1.Image = Image.FromFile(Application.StartupPath & "\cosas\1.jpg")
        End If
        If ListBox1.SelectedIndex = 1 Then
            PictureBox1.Image = Image.FromFile(Application.StartupPath & "\cosas\2.jpg")
        End If
        If ListBox1.SelectedIndex = 2 Then
            PictureBox1.Image = Image.FromFile(Application.StartupPath & "\cosas\3.jpg")
        End If
        If ListBox1.SelectedIndex = 3 Then
            PictureBox1.Image = Image.FromFile(Application.StartupPath & "\cosas\4.jpg")
        End If

        If ListBox1.SelectedIndex = 0 Then
            RichTextBox1.LoadFile(Application.StartupPath & "\cosas\1.rtf")
        End If
        If ListBox1.SelectedIndex = 1 Then
            RichTextBox1.LoadFile(Application.StartupPath & "\cosas\2.rtf")
        End If
        If ListBox1.SelectedIndex = 2 Then
            RichTextBox1.LoadFile(Application.StartupPath & "\cosas\3.rtf")
        End If
        If ListBox1.SelectedIndex = 3 Then
            RichTextBox1.LoadFile(Application.StartupPath & "\cosas\4.rtf")
        End If



    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class
