<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm2
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
        Me.lblPrimo = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnPrimo = New System.Windows.Forms.Button()
        Me.txtCaja = New System.Windows.Forms.TextBox()
        Me.etVer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblPrimo
        '
        Me.lblPrimo.AutoSize = True
        Me.lblPrimo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPrimo.Location = New System.Drawing.Point(113, 163)
        Me.lblPrimo.Name = "lblPrimo"
        Me.lblPrimo.Size = New System.Drawing.Size(47, 15)
        Me.lblPrimo.TabIndex = 6
        Me.lblPrimo.Text = "¿Primo?"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(47, 207)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(191, 29)
        Me.btnSalir.TabIndex = 9
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnPrimo
        '
        Me.btnPrimo.Location = New System.Drawing.Point(52, 91)
        Me.btnPrimo.Name = "btnPrimo"
        Me.btnPrimo.Size = New System.Drawing.Size(170, 34)
        Me.btnPrimo.TabIndex = 8
        Me.btnPrimo.Text = "Primo Si/No"
        Me.btnPrimo.UseVisualStyleBackColor = True
        '
        'txtCaja
        '
        Me.txtCaja.Location = New System.Drawing.Point(110, 55)
        Me.txtCaja.Name = "txtCaja"
        Me.txtCaja.Size = New System.Drawing.Size(50, 20)
        Me.txtCaja.TabIndex = 7
        '
        'etVer
        '
        Me.etVer.AutoSize = True
        Me.etVer.Location = New System.Drawing.Point(72, 24)
        Me.etVer.Name = "etVer"
        Me.etVer.Size = New System.Drawing.Size(128, 13)
        Me.etVer.TabIndex = 5
        Me.etVer.Text = "Ver si un número es primo"
        '
        'frm2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lblPrimo)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnPrimo)
        Me.Controls.Add(Me.txtCaja)
        Me.Controls.Add(Me.etVer)
        Me.Name = "frm2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPrimo As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnPrimo As System.Windows.Forms.Button
    Friend WithEvents txtCaja As System.Windows.Forms.TextBox
    Friend WithEvents etVer As System.Windows.Forms.Label
End Class
