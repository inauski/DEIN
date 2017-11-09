<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAltasFinal
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAltasFinal = New System.Windows.Forms.TextBox()
        Me.btnAltasFinal = New System.Windows.Forms.Button()
        Me.btnSalirAltasFinal = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(135, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ALTAS"
        '
        'txtAltasFinal
        '
        Me.txtAltasFinal.Location = New System.Drawing.Point(48, 50)
        Me.txtAltasFinal.Name = "txtAltasFinal"
        Me.txtAltasFinal.Size = New System.Drawing.Size(255, 20)
        Me.txtAltasFinal.TabIndex = 1
        '
        'btnAltasFinal
        '
        Me.btnAltasFinal.Location = New System.Drawing.Point(48, 86)
        Me.btnAltasFinal.Name = "btnAltasFinal"
        Me.btnAltasFinal.Size = New System.Drawing.Size(255, 23)
        Me.btnAltasFinal.TabIndex = 2
        Me.btnAltasFinal.Text = "&Altas al final"
        Me.btnAltasFinal.UseVisualStyleBackColor = True
        '
        'btnSalirAltasFinal
        '
        Me.btnSalirAltasFinal.Location = New System.Drawing.Point(48, 170)
        Me.btnSalirAltasFinal.Name = "btnSalirAltasFinal"
        Me.btnSalirAltasFinal.Size = New System.Drawing.Size(255, 23)
        Me.btnSalirAltasFinal.TabIndex = 3
        Me.btnSalirAltasFinal.Text = "&Salir de altas"
        Me.btnSalirAltasFinal.UseVisualStyleBackColor = True
        '
        'frmAltasFinal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 261)
        Me.Controls.Add(Me.btnSalirAltasFinal)
        Me.Controls.Add(Me.btnAltasFinal)
        Me.Controls.Add(Me.txtAltasFinal)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAltasFinal"
        Me.Text = "Altas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAltasFinal As System.Windows.Forms.TextBox
    Private WithEvents btnAltasFinal As System.Windows.Forms.Button
    Private WithEvents btnSalirAltasFinal As System.Windows.Forms.Button
End Class
