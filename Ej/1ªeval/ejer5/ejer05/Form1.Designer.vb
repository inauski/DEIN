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
        Me.etiNIF = New System.Windows.Forms.Label()
        Me.txtOpci = New System.Windows.Forms.TextBox()
        Me.btnVerificar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'etiNIF
        '
        Me.etiNIF.AutoSize = True
        Me.etiNIF.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiNIF.Location = New System.Drawing.Point(60, 63)
        Me.etiNIF.Name = "etiNIF"
        Me.etiNIF.Size = New System.Drawing.Size(71, 18)
        Me.etiNIF.TabIndex = 0
        Me.etiNIF.Text = "N.I.F -->"
        '
        'txtOpci
        '
        Me.txtOpci.Location = New System.Drawing.Point(165, 61)
        Me.txtOpci.Name = "txtOpci"
        Me.txtOpci.Size = New System.Drawing.Size(137, 20)
        Me.txtOpci.TabIndex = 1
        '
        'btnVerificar
        '
        Me.btnVerificar.Location = New System.Drawing.Point(107, 119)
        Me.btnVerificar.Name = "btnVerificar"
        Me.btnVerificar.Size = New System.Drawing.Size(168, 38)
        Me.btnVerificar.TabIndex = 2
        Me.btnVerificar.Text = "Verificar"
        Me.btnVerificar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(86, 243)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(215, 38)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 304)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnVerificar)
        Me.Controls.Add(Me.txtOpci)
        Me.Controls.Add(Me.etiNIF)
        Me.Name = "Form1"
        Me.Text = "N.I.F"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents etiNIF As System.Windows.Forms.Label
    Friend WithEvents txtOpci As System.Windows.Forms.TextBox
    Friend WithEvents btnVerificar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button

End Class
