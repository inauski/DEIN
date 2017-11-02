Public Class Form1

    Private Sub btnNuevoAtleta_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevoAtleta.Click
        Dim atleta As String
        Dim num As Integer = 0
        atleta = txtAtleta.Text
        cbAtleta.Items.Add(atleta)

        ListBox1.Items.Add(num)
        ListBox2.Items.Add(num)
        ListBox3.Items.Add(num)

        cbAtleta.SelectedItem = atleta
    End Sub
End Class
