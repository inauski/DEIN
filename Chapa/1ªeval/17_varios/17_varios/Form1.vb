Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0 'para q salga el elemento del indice 0 como seleccionado al cargar el formulario
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        MessageBox.Show(ComboBox1.SelectedIndex) 'saca en un mensaje el INDICE del combobox seleccionado
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        'Estos 3 son iguales q los de abajo,solo q estos no se pueden poner a false(o true)
        'ListBox1.SelectedIndex = 1
        'ListBox1.SelectedIndex = 3
        'ListBox1.SelectedIndex = 5

        ListBox1.SetSelected(1, True)
        ListBox1.SetSelected(3, True)
        ListBox1.SetSelected(5, True)

        MessageBox.Show(ListBox1.SelectedIndex) 'si hay mas de un indice seleccionado devuelve solo 1
        MessageBox.Show("Esta seleccionado el indice 3? " & ListBox1.GetSelected(3)) 'si esta seleccionado el tercero devolvera true
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        For i = 0 To ListBox1.Items.Count - 1
            If ListBox1.Items(i).Contains("o") = True Then
                'If ListBox1.Items(i).indexOf("chi") = True Then
                MessageBox.Show(ListBox1.Items(i)) 'si alguna palabra del listbox contiene la 'o' nos mostrara las palabras q la contienen
            End If
        Next
    End Sub
End Class
