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
        Me.etVer = New System.Windows.Forms.Label()
        Me.txtCaja = New System.Windows.Forms.TextBox()
        Me.btnPrimo = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lblPrimo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'etVer
        '
        Me.etVer.AutoSize = True
        Me.etVer.Location = New System.Drawing.Point(70, 18)
        Me.etVer.Name = "etVer"
        Me.etVer.Size = New System.Drawing.Size(128, 13)
        Me.etVer.TabIndex = 0
        Me.etVer.Text = "Ver si un número es primo"
        '
        'txtCaja
        '
        Me.txtCaja.Location = New System.Drawing.Point(108, 49)
        Me.txtCaja.Name = "txtCaja"
        Me.txtCaja.Size = New System.Drawing.Size(50, 20)
        Me.txtCaja.TabIndex = 1
        '
        'btnPrimo
        '
        Me.btnPrimo.Location = New System.Drawing.Point(50, 85)
        Me.btnPrimo.Name = "btnPrimo"
        Me.btnPrimo.Size = New System.Drawing.Size(170, 34)
        Me.btnPrimo.TabIndex = 2
        Me.btnPrimo.Text = "Primo Si/No"
        Me.btnPrimo.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(45, 201)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(191, 29)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'lblPrimo
        '
        Me.lblPrimo.AutoSize = True
        Me.lblPrimo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPrimo.Location = New System.Drawing.Point(111, 157)
        Me.lblPrimo.Name = "lblPrimo"
        Me.lblPrimo.Size = New System.Drawing.Size(47, 15)
        Me.lblPrimo.TabIndex = 0
        Me.lblPrimo.Text = "¿Primo?"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lblPrimo)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnPrimo)
        Me.Controls.Add(Me.txtCaja)
        Me.Controls.Add(Me.etVer)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents etVer As System.Windows.Forms.Label
    Friend WithEvents txtCaja As System.Windows.Forms.TextBox
    Friend WithEvents btnPrimo As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents lblPrimo As System.Windows.Forms.Label

End Class
