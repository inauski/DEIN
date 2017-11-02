<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cambio
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
        Me.btActualizar = New System.Windows.Forms.Button()
        Me.txtTituloNuevo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTituloActual = New System.Windows.Forms.TextBox()
        Me.btVolver = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btActualizar
        '
        Me.btActualizar.Location = New System.Drawing.Point(219, 233)
        Me.btActualizar.Name = "btActualizar"
        Me.btActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btActualizar.TabIndex = 14
        Me.btActualizar.Text = "Actualizar"
        Me.btActualizar.UseVisualStyleBackColor = True
        '
        'txtTituloNuevo
        '
        Me.txtTituloNuevo.Location = New System.Drawing.Point(179, 180)
        Me.txtTituloNuevo.Name = "txtTituloNuevo"
        Me.txtTituloNuevo.Size = New System.Drawing.Size(115, 20)
        Me.txtTituloNuevo.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 183)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Nueva Pelicula:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Pelicula Actual:"
        '
        'txtTituloActual
        '
        Me.txtTituloActual.Location = New System.Drawing.Point(179, 110)
        Me.txtTituloActual.Name = "txtTituloActual"
        Me.txtTituloActual.Size = New System.Drawing.Size(115, 20)
        Me.txtTituloActual.TabIndex = 10
        '
        'btVolver
        '
        Me.btVolver.Location = New System.Drawing.Point(85, 233)
        Me.btVolver.Name = "btVolver"
        Me.btVolver.Size = New System.Drawing.Size(75, 23)
        Me.btVolver.TabIndex = 9
        Me.btVolver.Text = "Volver"
        Me.btVolver.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(67, 53)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(227, 21)
        Me.ComboBox1.TabIndex = 8
        '
        'cambioPelicula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 309)
        Me.Controls.Add(Me.btActualizar)
        Me.Controls.Add(Me.txtTituloNuevo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTituloActual)
        Me.Controls.Add(Me.btVolver)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "cambioPelicula"
        Me.Text = "cambioPelicula"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btActualizar As System.Windows.Forms.Button
    Friend WithEvents txtTituloNuevo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTituloActual As System.Windows.Forms.TextBox
    Friend WithEvents btVolver As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
