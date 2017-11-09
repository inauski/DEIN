<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBajas
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSalirBajas = New System.Windows.Forms.Button()
        Me.btnBajasPos = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(151, 116)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(155, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 25)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "POSICION"
        '
        'btnSalirBajas
        '
        Me.btnSalirBajas.Location = New System.Drawing.Point(87, 198)
        Me.btnSalirBajas.Name = "btnSalirBajas"
        Me.btnSalirBajas.Size = New System.Drawing.Size(255, 23)
        Me.btnSalirBajas.TabIndex = 13
        Me.btnSalirBajas.Text = "&Salir de bajas"
        Me.btnSalirBajas.UseVisualStyleBackColor = True
        '
        'btnBajasPos
        '
        Me.btnBajasPos.Location = New System.Drawing.Point(87, 48)
        Me.btnBajasPos.Name = "btnBajasPos"
        Me.btnBajasPos.Size = New System.Drawing.Size(255, 23)
        Me.btnBajasPos.TabIndex = 12
        Me.btnBajasPos.Text = "&Bajas en posicion"
        Me.btnBajasPos.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(174, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 25)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "BAJAS"
        '
        'frmBajas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 234)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSalirBajas)
        Me.Controls.Add(Me.btnBajasPos)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmBajas"
        Me.Text = "Bajas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents btnSalirBajas As System.Windows.Forms.Button
    Private WithEvents btnBajasPos As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
