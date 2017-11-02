<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm))
        Me.picCoche = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMatricula = New System.Windows.Forms.TextBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.picCoche, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picCoche
        '
        Me.picCoche.Location = New System.Drawing.Point(12, 12)
        Me.picCoche.Name = "picCoche"
        Me.picCoche.Size = New System.Drawing.Size(140, 100)
        Me.picCoche.TabIndex = 0
        Me.picCoche.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(168, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "&Matricula"
        '
        'txtMatricula
        '
        Me.txtMatricula.Location = New System.Drawing.Point(171, 46)
        Me.txtMatricula.Name = "txtMatricula"
        Me.txtMatricula.Size = New System.Drawing.Size(100, 20)
        Me.txtMatricula.TabIndex = 2
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(171, 72)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 3
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(270, 72)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(171, 101)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 5
        '
        'frm
        '
        Me.AcceptButton = Me.btnAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 135)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtMatricula)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picCoche)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm"
        Me.Text = "Vehiculos en venta"
        CType(Me.picCoche, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picCoche As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMatricula As System.Windows.Forms.TextBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
