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
        Me.txtOpci = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.opcPequeña = New System.Windows.Forms.RadioButton()
        Me.opcGrande = New System.Windows.Forms.RadioButton()
        Me.btnSig = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.etLetra = New System.Windows.Forms.Label()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtOpci
        '
        Me.txtOpci.Location = New System.Drawing.Point(90, 50)
        Me.txtOpci.Name = "txtOpci"
        Me.txtOpci.Size = New System.Drawing.Size(48, 20)
        Me.txtOpci.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.opcPequeña)
        Me.Panel1.Controls.Add(Me.opcGrande)
        Me.Panel1.Location = New System.Drawing.Point(344, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(158, 116)
        Me.Panel1.TabIndex = 1
        '
        'opcPequeña
        '
        Me.opcPequeña.AutoSize = True
        Me.opcPequeña.Location = New System.Drawing.Point(20, 49)
        Me.opcPequeña.Name = "opcPequeña"
        Me.opcPequeña.Size = New System.Drawing.Size(103, 17)
        Me.opcPequeña.TabIndex = 1
        Me.opcPequeña.TabStop = True
        Me.opcPequeña.Text = "Fuente pequeña"
        Me.opcPequeña.UseVisualStyleBackColor = True
        '
        'opcGrande
        '
        Me.opcGrande.AutoSize = True
        Me.opcGrande.Location = New System.Drawing.Point(20, 17)
        Me.opcGrande.Name = "opcGrande"
        Me.opcGrande.Size = New System.Drawing.Size(96, 17)
        Me.opcGrande.TabIndex = 0
        Me.opcGrande.TabStop = True
        Me.opcGrande.Text = "Fuente Grande"
        Me.opcGrande.UseVisualStyleBackColor = True
        '
        'btnSig
        '
        Me.btnSig.Location = New System.Drawing.Point(344, 165)
        Me.btnSig.Name = "btnSig"
        Me.btnSig.Size = New System.Drawing.Size(157, 30)
        Me.btnSig.TabIndex = 2
        Me.btnSig.Text = "Siguiente"
        Me.btnSig.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(56, 273)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(178, 44)
        Me.btnBuscar.TabIndex = 3
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(323, 273)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(178, 44)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'etLetra
        '
        Me.etLetra.AutoSize = True
        Me.etLetra.Font = New System.Drawing.Font("Comic Sans MS", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etLetra.Location = New System.Drawing.Point(43, 104)
        Me.etLetra.Name = "etLetra"
        Me.etLetra.Size = New System.Drawing.Size(105, 90)
        Me.etLetra.TabIndex = 5
        Me.etLetra.Text = "W"
        '
        'btnAnterior
        '
        Me.btnAnterior.Location = New System.Drawing.Point(344, 203)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(157, 30)
        Me.btnAnterior.TabIndex = 6
        Me.btnAnterior.Text = "Anterior"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 359)
        Me.Controls.Add(Me.btnAnterior)
        Me.Controls.Add(Me.etLetra)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnSig)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtOpci)
        Me.Name = "Form1"
        Me.Text = "Codigo ASCII"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtOpci As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents opcPequeña As System.Windows.Forms.RadioButton
    Friend WithEvents opcGrande As System.Windows.Forms.RadioButton
    Friend WithEvents btnSig As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents etLetra As System.Windows.Forms.Label
    Friend WithEvents btnAnterior As System.Windows.Forms.Button

End Class
