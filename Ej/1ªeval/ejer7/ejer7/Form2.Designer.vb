<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.etResultado = New System.Windows.Forms.Label()
        Me.btnVerificar = New System.Windows.Forms.Button()
        Me.txtIntento = New System.Windows.Forms.TextBox()
        Me.etIntento = New System.Windows.Forms.Label()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.etTitulo2 = New System.Windows.Forms.Label()
        Me.etTitulo = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnFinalizar
        '
        Me.btnFinalizar.Location = New System.Drawing.Point(237, 316)
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.Size = New System.Drawing.Size(130, 31)
        Me.btnFinalizar.TabIndex = 17
        Me.btnFinalizar.Text = "Finalizar"
        Me.btnFinalizar.UseVisualStyleBackColor = True
        '
        'txtResultado
        '
        Me.txtResultado.Enabled = False
        Me.txtResultado.Location = New System.Drawing.Point(158, 264)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(100, 20)
        Me.txtResultado.TabIndex = 16
        '
        'etResultado
        '
        Me.etResultado.Location = New System.Drawing.Point(121, 228)
        Me.etResultado.Name = "etResultado"
        Me.etResultado.Size = New System.Drawing.Size(175, 23)
        Me.etResultado.TabIndex = 15
        Me.etResultado.Text = "Resultado comprobación"
        Me.etResultado.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnVerificar
        '
        Me.btnVerificar.Location = New System.Drawing.Point(124, 177)
        Me.btnVerificar.Name = "btnVerificar"
        Me.btnVerificar.Size = New System.Drawing.Size(181, 32)
        Me.btnVerificar.TabIndex = 14
        Me.btnVerificar.Text = "Verificar"
        Me.btnVerificar.UseVisualStyleBackColor = True
        '
        'txtIntento
        '
        Me.txtIntento.Enabled = False
        Me.txtIntento.Location = New System.Drawing.Point(182, 129)
        Me.txtIntento.Name = "txtIntento"
        Me.txtIntento.Size = New System.Drawing.Size(100, 20)
        Me.txtIntento.TabIndex = 13
        '
        'etIntento
        '
        Me.etIntento.Location = New System.Drawing.Point(77, 129)
        Me.etIntento.Name = "etIntento"
        Me.etIntento.Size = New System.Drawing.Size(78, 19)
        Me.etIntento.TabIndex = 12
        Me.etIntento.Text = "Intento"
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(155, 80)
        Me.txtNum.MaxLength = 3
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(100, 20)
        Me.txtNum.TabIndex = 11
        '
        'etTitulo2
        '
        Me.etTitulo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etTitulo2.Location = New System.Drawing.Point(155, 43)
        Me.etTitulo2.Name = "etTitulo2"
        Me.etTitulo2.Size = New System.Drawing.Size(100, 23)
        Me.etTitulo2.TabIndex = 10
        Me.etTitulo2.Text = "Introduzca numero"
        Me.etTitulo2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'etTitulo
        '
        Me.etTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etTitulo.Location = New System.Drawing.Point(35, 9)
        Me.etTitulo.Name = "etTitulo"
        Me.etTitulo.Size = New System.Drawing.Size(305, 30)
        Me.etTitulo.TabIndex = 9
        Me.etTitulo.Text = "Adivine el numero"
        Me.etTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(48, 316)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(130, 31)
        Me.btnNuevo.TabIndex = 18
        Me.btnNuevo.Text = "Nuevo Juego"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 369)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnFinalizar)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.etResultado)
        Me.Controls.Add(Me.btnVerificar)
        Me.Controls.Add(Me.txtIntento)
        Me.Controls.Add(Me.etIntento)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.etTitulo2)
        Me.Controls.Add(Me.etTitulo)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnFinalizar As System.Windows.Forms.Button
    Friend WithEvents txtResultado As System.Windows.Forms.TextBox
    Friend WithEvents etResultado As System.Windows.Forms.Label
    Friend WithEvents btnVerificar As System.Windows.Forms.Button
    Friend WithEvents txtIntento As System.Windows.Forms.TextBox
    Friend WithEvents etIntento As System.Windows.Forms.Label
    Friend WithEvents txtNum As System.Windows.Forms.TextBox
    Friend WithEvents etTitulo2 As System.Windows.Forms.Label
    Friend WithEvents etTitulo As System.Windows.Forms.Label
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
End Class
