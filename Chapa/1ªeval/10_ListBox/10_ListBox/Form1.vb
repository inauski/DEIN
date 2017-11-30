Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'lstDatos.Items.Add("pato") para introducir datos desde el principio
        'lstDatos.Items.Add("pera")
        'lstDatos.Items.Add("manzana")
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim i As Integer
        Dim provincia As String
        For i = 1 To 3
            provincia = InputBox("Nombre de la provincia", "NUEVA PROVINCIA")
            lstDatos.Items.Add(provincia)
        Next
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Try
            lstDatos.Items.Insert(2, "Huelva") ' inserta en la pos 2 huelva, si insertamos posicion mayor q array va al catch
        Catch ex As Exception
            MessageBox.Show("No se puede insertar en esa posicion", "AVISO")
        End Try

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        lstDatos.Items.Remove("Girona") 'elimina por string o cadena(por valor)
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        lstDatos.Items.RemoveAt(2) 'elimina por indice
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        lstDatos.Items.Clear() ' elimina todo el listBox
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        MessageBox.Show(CStr(lstDatos.Items.Count))
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        MessageBox.Show(CStr(lstDatos.SelectedIndex)) ' devuelve -1 si no hay elemento seleccionado
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        MessageBox.Show(CStr(lstDatos.SelectedItem)) 'devuelve el valor como string,es decir la propia palabra como aparece en el listbox
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        MessageBox.Show(CStr(lstDatos.Items(3))) 'vemos cuanto vale el elemento 3, es Girona
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        For i = 0 To lstDatos.Items.Count - 1
            lstDatos2.Items.Add(lstDatos.Items(i)) 'pasa los datos de un listBox al otro
        Next
    End Sub

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        lstDatos.Items(3) = "Nueva Girona"
    End Sub

    Private Sub Button12_Click(sender As System.Object, e As System.EventArgs) Handles Button12.Click
        Dim indice As Integer = lstDatos.SelectedIndex
        If indice = -1 Then ' -1 devuelve cuando no hay ningun elemento seleccionado y da el aviso
            MessageBox.Show("No hay elemento seleccionado", "AVISO")
        Else
            Dim nuevo As String 'creamos nuevo para poder pedir el valor nuevo a introducir y lo agregamos al listbox
            nuevo = InputBox("Nuevo valor: ", "VALOR")
            lstDatos.Items(indice) = nuevo
        End If
    End Sub
End Class
