Public Class Form1

    Private Sub btnSiNo_Click(sender As System.Object, e As System.EventArgs) Handles btnSiNo.Click
        Dim resultado As DialogResult
        resultado = MessageBox.Show("Quieres continuar", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Hand)
        If resultado = Windows.Forms.DialogResult.Yes Then
            MessageBox.Show("SI")
        Else
            MessageBox.Show("No")
        End If
    End Sub

    Private Sub btnInput_Click(sender As System.Object, e As System.EventArgs) Handles btnInput.Click
        Dim a As String = InputBox("Provincia", "Titulo", "Navarra") 'Por defecto cogeria navarra
        If a = "" Then 'Con comillas decimos que ha dado en cancelar o no ha escrito, es como darle al no en el boton del dialogResult
            MessageBox.Show("No has escrito o has cancelado")
        Else
            MessageBox.Show(a) 'muestra lo escrito en el inputbox
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        frmPalabraClave.ShowDialog()
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If Not contraseña() Then 'si no acierta la contraseña cierra el formulario
            Me.Close()
        End If
    End Sub

    Function contraseña() As Boolean
        Dim intentos As Integer
        Dim palabraclave As String
        Dim dlg As New frmPalabraClave 'instancia del form2

        Do
            If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then 'si pulsamos aceptar lo muestra,o tb si pulsamos Enter(ponemos en el menu propiedades-accept button->btnAceptar y cancel button->btnCancelar, y ademas en el btnAceptar tb ponemos la opcion DialogResult en OK)
                palabraclave = dlg.txtClave.Text
            Else
                Return False
            End If

            If palabraclave <> "patata" Then
                MessageBox.Show("Error, intentalo otra vez")
                intentos += 1
                MessageBox.Show("Tienes 3 intentos.Intento numero: " & intentos)
            Else
                Return True
            End If


        Loop While intentos < 3 'tenemos 3 intentos para adivinar la contraseña,sino se cerrara.

    End Function

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim dlgAbrir As New OpenFileDialog
        dlgAbrir.ShowReadOnly = True
        dlgAbrir.InitialDirectory = "c:\"
        dlgAbrir.Filter = "los txt|*.txt|los punto doc|*.doc"
        dlgAbrir.FilterIndex = 2
        dlgAbrir.RestoreDirectory = True
        If dlgAbrir.ShowDialog = Windows.Forms.DialogResult.OK Then
            MessageBox.Show(dlgAbrir.FileName)
        Else
            MessageBox.Show("Has cancelado")
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim dlg As New ColorDialog
        dlg.Color = Label1.ForeColor
        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then 'si pinchamos en aceptar en la plantilla de colores q sale nos cambia de color
            Label1.ForeColor = dlg.Color
        End If
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        For i = 0 To 12000000 'se pone numero grande para q vaya mas despacio y de tiempo a ver como se va rellenando la barra
            ProgressBar1.Value = i
        Next
    End Sub
End Class
