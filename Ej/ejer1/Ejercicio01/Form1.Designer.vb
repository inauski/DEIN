<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEjercicio1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEjercicio1))
        Me.etBase = New System.Windows.Forms.Label()
        Me.etAltura = New System.Windows.Forms.Label()
        Me.etTitulo = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBase = New System.Windows.Forms.TextBox()
        Me.txtAltura = New System.Windows.Forms.TextBox()
        Me.txtArea = New System.Windows.Forms.TextBox()
        Me.btSalir = New System.Windows.Forms.Button()
        Me.btCalcular = New System.Windows.Forms.Button()
        Me.et24 = New System.Windows.Forms.Label()
        Me.et12 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'etBase
        '
        Me.etBase.AutoSize = True
        Me.etBase.Location = New System.Drawing.Point(115, 98)
        Me.etBase.Name = "etBase"
        Me.etBase.Size = New System.Drawing.Size(31, 13)
        Me.etBase.TabIndex = 0
        Me.etBase.Text = "Base"
        '
        'etAltura
        '
        Me.etAltura.AutoSize = True
        Me.etAltura.Location = New System.Drawing.Point(115, 139)
        Me.etAltura.Name = "etAltura"
        Me.etAltura.Size = New System.Drawing.Size(34, 13)
        Me.etAltura.TabIndex = 0
        Me.etAltura.Text = "Altura"
        '
        'etTitulo
        '
        Me.etTitulo.AutoSize = True
        Me.etTitulo.BackColor = System.Drawing.SystemColors.HotTrack
        Me.etTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.etTitulo.Location = New System.Drawing.Point(222, 46)
        Me.etTitulo.Name = "etTitulo"
        Me.etTitulo.Size = New System.Drawing.Size(172, 20)
        Me.etTitulo.TabIndex = 0
        Me.etTitulo.Text = "Área de un triangulo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(223, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Área"
        '
        'txtBase
        '
        Me.txtBase.Location = New System.Drawing.Point(188, 95)
        Me.txtBase.Name = "txtBase"
        Me.txtBase.Size = New System.Drawing.Size(86, 20)
        Me.txtBase.TabIndex = 1
        '
        'txtAltura
        '
        Me.txtAltura.Location = New System.Drawing.Point(188, 136)
        Me.txtAltura.Name = "txtAltura"
        Me.txtAltura.Size = New System.Drawing.Size(86, 20)
        Me.txtAltura.TabIndex = 1
        '
        'txtArea
        '
        Me.txtArea.Enabled = False
        Me.txtArea.Location = New System.Drawing.Point(302, 213)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Size = New System.Drawing.Size(86, 20)
        Me.txtArea.TabIndex = 1
        '
        'btSalir
        '
        Me.btSalir.Location = New System.Drawing.Point(188, 258)
        Me.btSalir.Name = "btSalir"
        Me.btSalir.Size = New System.Drawing.Size(200, 23)
        Me.btSalir.TabIndex = 2
        Me.btSalir.Text = "&Salir"
        Me.btSalir.UseVisualStyleBackColor = True
        '
        'btCalcular
        '
        Me.btCalcular.Location = New System.Drawing.Point(188, 175)
        Me.btCalcular.Name = "btCalcular"
        Me.btCalcular.Size = New System.Drawing.Size(200, 23)
        Me.btCalcular.TabIndex = 2
        Me.btCalcular.Text = "&Calcular área"
        Me.btCalcular.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btCalcular.UseVisualStyleBackColor = True
        '
        'et24
        '
        Me.et24.AutoSize = True
        Me.et24.Location = New System.Drawing.Point(435, 127)
        Me.et24.Name = "et24"
        Me.et24.Size = New System.Drawing.Size(0, 13)
        Me.et24.TabIndex = 0
        '
        'et12
        '
        Me.et12.AutoSize = True
        Me.et12.Location = New System.Drawing.Point(476, 159)
        Me.et12.Name = "et12"
        Me.et12.Size = New System.Drawing.Size(0, 13)
        Me.et12.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(376, 86)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 70)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'frmEjercicio1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 474)
        Me.Controls.Add(Me.et24)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btCalcular)
        Me.Controls.Add(Me.btSalir)
        Me.Controls.Add(Me.txtArea)
        Me.Controls.Add(Me.txtAltura)
        Me.Controls.Add(Me.txtBase)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.etTitulo)
        Me.Controls.Add(Me.et12)
        Me.Controls.Add(Me.etAltura)
        Me.Controls.Add(Me.etBase)
        Me.Name = "frmEjercicio1"
        Me.Text = "Ejercicio 1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents etBase As System.Windows.Forms.Label
    Friend WithEvents etAltura As System.Windows.Forms.Label
    Friend WithEvents etTitulo As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtBase As System.Windows.Forms.TextBox
    Friend WithEvents txtAltura As System.Windows.Forms.TextBox
    Friend WithEvents txtArea As System.Windows.Forms.TextBox
    Friend WithEvents btSalir As System.Windows.Forms.Button
    Friend WithEvents btCalcular As System.Windows.Forms.Button
    Friend WithEvents et24 As System.Windows.Forms.Label
    Friend WithEvents et12 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
