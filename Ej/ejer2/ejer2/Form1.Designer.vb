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
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.etCalc = New System.Windows.Forms.Label()
        Me.etEuro = New System.Windows.Forms.Label()
        Me.etPesetas = New System.Windows.Forms.Label()
        Me.txtEuros = New System.Windows.Forms.TextBox()
        Me.txtPesetas = New System.Windows.Forms.TextBox()
        Me.etEurPes = New System.Windows.Forms.Label()
        Me.etCambiar = New System.Windows.Forms.Label()
        Me.btnPesEur = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.SuspendLayout()
        '
        'btnCalcular
        '
        Me.btnCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.Location = New System.Drawing.Point(149, 272)
        Me.btnCalcular.Margin = New System.Windows.Forms.Padding(6)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(408, 35)
        Me.btnCalcular.TabIndex = 0
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'etCalc
        '
        Me.etCalc.AutoSize = True
        Me.etCalc.Location = New System.Drawing.Point(245, 24)
        Me.etCalc.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.etCalc.Name = "etCalc"
        Me.etCalc.Size = New System.Drawing.Size(224, 24)
        Me.etCalc.TabIndex = 1
        Me.etCalc.Text = "EURO CALCULADORA"
        '
        'etEuro
        '
        Me.etEuro.AutoSize = True
        Me.etEuro.Location = New System.Drawing.Point(151, 109)
        Me.etEuro.Name = "etEuro"
        Me.etEuro.Size = New System.Drawing.Size(81, 24)
        Me.etEuro.TabIndex = 2
        Me.etEuro.Text = "EUROS"
        '
        'etPesetas
        '
        Me.etPesetas.AutoSize = True
        Me.etPesetas.Location = New System.Drawing.Point(431, 109)
        Me.etPesetas.Name = "etPesetas"
        Me.etPesetas.Size = New System.Drawing.Size(104, 24)
        Me.etPesetas.TabIndex = 3
        Me.etPesetas.Text = "PESETAS"
        '
        'txtEuros
        '
        Me.txtEuros.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEuros.Location = New System.Drawing.Point(122, 162)
        Me.txtEuros.Name = "txtEuros"
        Me.txtEuros.Size = New System.Drawing.Size(145, 29)
        Me.txtEuros.TabIndex = 4
        '
        'txtPesetas
        '
        Me.txtPesetas.Enabled = False
        Me.txtPesetas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPesetas.Location = New System.Drawing.Point(424, 162)
        Me.txtPesetas.Name = "txtPesetas"
        Me.txtPesetas.Size = New System.Drawing.Size(146, 29)
        Me.txtPesetas.TabIndex = 5
        '
        'etEurPes
        '
        Me.etEurPes.AutoSize = True
        Me.etEurPes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etEurPes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etEurPes.Location = New System.Drawing.Point(284, 203)
        Me.etEurPes.Name = "etEurPes"
        Me.etEurPes.Size = New System.Drawing.Size(113, 17)
        Me.etEurPes.TabIndex = 6
        Me.etEurPes.Text = "Euros a Pesetas"
        '
        'etCambiar
        '
        Me.etCambiar.AutoSize = True
        Me.etCambiar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etCambiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etCambiar.Location = New System.Drawing.Point(59, 366)
        Me.etCambiar.Name = "etCambiar"
        Me.etCambiar.Size = New System.Drawing.Size(97, 17)
        Me.etCambiar.TabIndex = 7
        Me.etCambiar.Text = "Cambiar a -->"
        '
        'btnPesEur
        '
        Me.btnPesEur.Location = New System.Drawing.Point(213, 352)
        Me.btnPesEur.Name = "btnPesEur"
        Me.btnPesEur.Size = New System.Drawing.Size(282, 40)
        Me.btnPesEur.TabIndex = 8
        Me.btnPesEur.Text = "PESETAS A EUROS"
        Me.btnPesEur.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(155, 434)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(401, 50)
        Me.btnSalir.TabIndex = 9
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(763, 626)
        Me.ShapeContainer1.TabIndex = 10
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BorderWidth = 2
        Me.RectangleShape2.Location = New System.Drawing.Point(35, 332)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(680, 188)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderWidth = 5
        Me.RectangleShape1.Location = New System.Drawing.Point(29, 10)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(684, 308)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 626)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnPesEur)
        Me.Controls.Add(Me.etCambiar)
        Me.Controls.Add(Me.etEurPes)
        Me.Controls.Add(Me.txtPesetas)
        Me.Controls.Add(Me.txtEuros)
        Me.Controls.Add(Me.etPesetas)
        Me.Controls.Add(Me.etEuro)
        Me.Controls.Add(Me.etCalc)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCalcular As System.Windows.Forms.Button
    Friend WithEvents etCalc As System.Windows.Forms.Label
    Friend WithEvents etEuro As System.Windows.Forms.Label
    Friend WithEvents etPesetas As System.Windows.Forms.Label
    Friend WithEvents txtEuros As System.Windows.Forms.TextBox
    Friend WithEvents txtPesetas As System.Windows.Forms.TextBox
    Friend WithEvents etEurPes As System.Windows.Forms.Label
    Friend WithEvents etCambiar As System.Windows.Forms.Label
    Friend WithEvents btnPesEur As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape

End Class
