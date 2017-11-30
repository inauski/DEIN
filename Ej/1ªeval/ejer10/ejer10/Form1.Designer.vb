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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDato = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtUltimo = New System.Windows.Forms.RadioButton()
        Me.rbtPrimero = New System.Windows.Forms.RadioButton()
        Me.lstDatos = New System.Windows.Forms.ListBox()
        Me.lstDatos2 = New System.Windows.Forms.ListBox()
        Me.btnDatosA2 = New System.Windows.Forms.Button()
        Me.btnDatosA1 = New System.Windows.Forms.Button()
        Me.btnAñadir = New System.Windows.Forms.Button()
        Me.btnBorrarUno = New System.Windows.Forms.Button()
        Me.btnBorrarDos = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Introduzca Nuevo Dato"
        '
        'txtDato
        '
        Me.txtDato.Location = New System.Drawing.Point(218, 30)
        Me.txtDato.Name = "txtDato"
        Me.txtDato.Size = New System.Drawing.Size(100, 20)
        Me.txtDato.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.rbtUltimo)
        Me.GroupBox1.Controls.Add(Me.rbtPrimero)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 99)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(111, 82)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Posición"
        '
        'rbtUltimo
        '
        Me.rbtUltimo.AutoSize = True
        Me.rbtUltimo.Location = New System.Drawing.Point(21, 43)
        Me.rbtUltimo.Name = "rbtUltimo"
        Me.rbtUltimo.Size = New System.Drawing.Size(54, 17)
        Me.rbtUltimo.TabIndex = 3
        Me.rbtUltimo.TabStop = True
        Me.rbtUltimo.Text = "Último"
        Me.rbtUltimo.UseVisualStyleBackColor = True
        '
        'rbtPrimero
        '
        Me.rbtPrimero.AutoSize = True
        Me.rbtPrimero.Location = New System.Drawing.Point(21, 20)
        Me.rbtPrimero.Name = "rbtPrimero"
        Me.rbtPrimero.Size = New System.Drawing.Size(60, 17)
        Me.rbtPrimero.TabIndex = 0
        Me.rbtPrimero.TabStop = True
        Me.rbtPrimero.Text = "Primero"
        Me.rbtPrimero.UseVisualStyleBackColor = True
        '
        'lstDatos
        '
        Me.lstDatos.FormattingEnabled = True
        Me.lstDatos.Location = New System.Drawing.Point(149, 99)
        Me.lstDatos.Name = "lstDatos"
        Me.lstDatos.Size = New System.Drawing.Size(84, 134)
        Me.lstDatos.TabIndex = 3
        '
        'lstDatos2
        '
        Me.lstDatos2.FormattingEnabled = True
        Me.lstDatos2.Location = New System.Drawing.Point(390, 99)
        Me.lstDatos2.Name = "lstDatos2"
        Me.lstDatos2.Size = New System.Drawing.Size(84, 134)
        Me.lstDatos2.TabIndex = 4
        '
        'btnDatosA2
        '
        Me.btnDatosA2.Enabled = False
        Me.btnDatosA2.Location = New System.Drawing.Point(274, 113)
        Me.btnDatosA2.Name = "btnDatosA2"
        Me.btnDatosA2.Size = New System.Drawing.Size(75, 23)
        Me.btnDatosA2.TabIndex = 5
        Me.btnDatosA2.Text = "=>"
        Me.btnDatosA2.UseVisualStyleBackColor = True
        '
        'btnDatosA1
        '
        Me.btnDatosA1.Enabled = False
        Me.btnDatosA1.Location = New System.Drawing.Point(274, 178)
        Me.btnDatosA1.Name = "btnDatosA1"
        Me.btnDatosA1.Size = New System.Drawing.Size(75, 23)
        Me.btnDatosA1.TabIndex = 6
        Me.btnDatosA1.Text = "<="
        Me.btnDatosA1.UseVisualStyleBackColor = True
        '
        'btnAñadir
        '
        Me.btnAñadir.Location = New System.Drawing.Point(112, 288)
        Me.btnAñadir.Name = "btnAñadir"
        Me.btnAñadir.Size = New System.Drawing.Size(75, 42)
        Me.btnAñadir.TabIndex = 7
        Me.btnAñadir.Text = "Añadir"
        Me.btnAñadir.UseVisualStyleBackColor = True
        '
        'btnBorrarUno
        '
        Me.btnBorrarUno.Enabled = False
        Me.btnBorrarUno.Location = New System.Drawing.Point(193, 288)
        Me.btnBorrarUno.Name = "btnBorrarUno"
        Me.btnBorrarUno.Size = New System.Drawing.Size(75, 42)
        Me.btnBorrarUno.TabIndex = 9
        Me.btnBorrarUno.Text = "Borrar Entrada Uno"
        Me.btnBorrarUno.UseVisualStyleBackColor = True
        '
        'btnBorrarDos
        '
        Me.btnBorrarDos.Enabled = False
        Me.btnBorrarDos.Location = New System.Drawing.Point(274, 288)
        Me.btnBorrarDos.Name = "btnBorrarDos"
        Me.btnBorrarDos.Size = New System.Drawing.Size(75, 42)
        Me.btnBorrarDos.TabIndex = 10
        Me.btnBorrarDos.Text = "Borrar Entrada Dos"
        Me.btnBorrarDos.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(355, 288)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 42)
        Me.btnSalir.TabIndex = 11
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 368)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnBorrarDos)
        Me.Controls.Add(Me.btnBorrarUno)
        Me.Controls.Add(Me.btnAñadir)
        Me.Controls.Add(Me.btnDatosA1)
        Me.Controls.Add(Me.btnDatosA2)
        Me.Controls.Add(Me.lstDatos2)
        Me.Controls.Add(Me.lstDatos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtDato)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDato As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtUltimo As System.Windows.Forms.RadioButton
    Friend WithEvents rbtPrimero As System.Windows.Forms.RadioButton
    Friend WithEvents lstDatos As System.Windows.Forms.ListBox
    Friend WithEvents lstDatos2 As System.Windows.Forms.ListBox
    Friend WithEvents btnDatosA2 As System.Windows.Forms.Button
    Friend WithEvents btnDatosA1 As System.Windows.Forms.Button
    Friend WithEvents btnAñadir As System.Windows.Forms.Button
    Friend WithEvents btnBorrarUno As System.Windows.Forms.Button
    Friend WithEvents btnBorrarDos As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button

End Class
