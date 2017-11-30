Public Class Form1

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

        ListBox1.SelectedIndex = ComboBox1.SelectedIndex

        If ListBox1.SelectedIndex = 0 Then
            PictureBox1.Image = Image.FromFile(Application.StartupPath & "\caratulas\lossimpsons.jpg")
        End If

        If ListBox1.SelectedIndex = 1 Then
            PictureBox1.Image = Image.FromFile(Application.StartupPath & "\caratulas\minions.jpg")
        End If

        If ListBox1.SelectedIndex = 2 Then
            PictureBox1.Image = Image.FromFile(Application.StartupPath & "\caratulas\it.jpg")
        End If

        If ListBox1.SelectedIndex = 3 Then
            PictureBox1.Image = Image.FromFile(Application.StartupPath & "\caratulas\emoji.jpg")
        End If



        If ListBox1.SelectedIndex = 0 Then
            RichTextBox1.LoadFile(Application.StartupPath & "\sinopsis\lossimpsons.rtf")
        End If

        If ListBox1.SelectedIndex = 1 Then
            RichTextBox1.LoadFile(Application.StartupPath & "\sinopsis\minions.rtf")
        End If

        If ListBox1.SelectedIndex = 2 Then
            RichTextBox1.LoadFile(Application.StartupPath & "\sinopsis\it.rtf")
        End If

        If ListBox1.SelectedIndex = 3 Then
            RichTextBox1.LoadFile(Application.StartupPath & "\sinopsis\Emoji.rtf")
        End If

        
    End Sub

End Class
