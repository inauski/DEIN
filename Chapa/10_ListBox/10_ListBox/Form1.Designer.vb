<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lstDatos = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.lstDatos2 = New System.Windows.Forms.ListBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstDatos
        '
        Me.lstDatos.FormattingEnabled = True
        Me.lstDatos.Items.AddRange(New Object() {"Barcelona", "Tarragona", "Lleida", "Girona", "Caceres", "Badajoz"})
        Me.lstDatos.Location = New System.Drawing.Point(12, 12)
        Me.lstDatos.Name = "lstDatos"
        Me.lstDatos.Size = New System.Drawing.Size(99, 147)
        Me.lstDatos.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(117, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(227, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Añadir Final"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(117, 41)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(227, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Añadir en posicion"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(117, 70)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(227, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Eliminar elementos por valor"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(117, 99)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(227, 23)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Eliminar por indice"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(117, 128)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(227, 23)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Elimina todo"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(117, 157)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(227, 23)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "Numero de elementos"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(117, 186)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(227, 23)
        Me.Button7.TabIndex = 7
        Me.Button7.Text = "Indice elementos seleccionado"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(117, 216)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(227, 23)
        Me.Button8.TabIndex = 8
        Me.Button8.Text = "Valor del elemento seleccionado"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(117, 245)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(227, 23)
        Me.Button9.TabIndex = 9
        Me.Button9.Text = "Acceder a valor por indice"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'lstDatos2
        '
        Me.lstDatos2.FormattingEnabled = True
        Me.lstDatos2.Location = New System.Drawing.Point(355, 12)
        Me.lstDatos2.Name = "lstDatos2"
        Me.lstDatos2.Size = New System.Drawing.Size(98, 147)
        Me.lstDatos2.TabIndex = 10
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(117, 285)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(75, 23)
        Me.Button10.TabIndex = 11
        Me.Button10.Text = "->"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(117, 328)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(227, 23)
        Me.Button11.TabIndex = 12
        Me.Button11.Text = "Cambiar valor"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(117, 357)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(227, 23)
        Me.Button12.TabIndex = 13
        Me.Button12.Text = "Cambiar valor del elemento seleccionado"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 402)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.lstDatos2)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lstDatos)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstDatos As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents lstDatos2 As System.Windows.Forms.ListBox
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button

End Class
