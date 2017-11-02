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
        Me.btnFinalizar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.etTitulo2 = New System.Windows.Forms.Label()
        Me.etTitulo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnFinalizar
        '
        Me.btnFinalizar.Location = New System.Drawing.Point(146, 234)
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.Size = New System.Drawing.Size(132, 43)
        Me.btnFinalizar.TabIndex = 11
        Me.btnFinalizar.Text = "Finalizar"
        Me.btnFinalizar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(170, 175)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 9
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(156, 115)
        Me.txtNumero.MaxLength = 3
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNumero.Size = New System.Drawing.Size(100, 20)
        Me.txtNumero.TabIndex = 8
        '
        'etTitulo2
        '
        Me.etTitulo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etTitulo2.Location = New System.Drawing.Point(127, 70)
        Me.etTitulo2.Name = "etTitulo2"
        Me.etTitulo2.Size = New System.Drawing.Size(213, 23)
        Me.etTitulo2.TabIndex = 7
        Me.etTitulo2.Text = "Introduzca numero a adivinar"
        '
        'etTitulo
        '
        Me.etTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etTitulo.Location = New System.Drawing.Point(133, 21)
        Me.etTitulo.Name = "etTitulo"
        Me.etTitulo.Size = New System.Drawing.Size(274, 36)
        Me.etTitulo.TabIndex = 6
        Me.etTitulo.Text = "Adivine el numero"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 301)
        Me.Controls.Add(Me.btnFinalizar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.etTitulo2)
        Me.Controls.Add(Me.etTitulo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnFinalizar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents etTitulo2 As System.Windows.Forms.Label
    Friend WithEvents etTitulo As System.Windows.Forms.Label

End Class
