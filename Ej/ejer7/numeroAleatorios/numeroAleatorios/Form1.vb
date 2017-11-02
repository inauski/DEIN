Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim t(5) As Integer
        Dim i As Integer = 0
        Dim num As Integer
        Dim aleatorio As New Random
        Dim esta As Boolean

        While i < 6
            num = aleatorio.Next(1, 10)
            esta = False
            For x = 0 To i - 1
                If t(x) = num Then
                    esta = True
                    Exit For
                End If
            Next
            If esta = False Then
                t(i) = num
                i = i + 1
            End If
        End While
        ListBox1.Items.Clear()
        For x = 0 To 5
            ListBox1.Items.Add(t(x))
        Next
    End Sub
End Class
