<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CATALOGO
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
        Me.cbTipoProd = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstArticulo = New System.Windows.Forms.ListBox()
        Me.rbtTotalUnid = New System.Windows.Forms.RadioButton()
        Me.rbtPrecioMedio = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.etNumerica = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.rbtUnidades = New System.Windows.Forms.RadioButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo de producto"
        '
        'cbTipoProd
        '
        Me.cbTipoProd.FormattingEnabled = True
        Me.cbTipoProd.Items.AddRange(New Object() {"Camisetas", "Gorras", "Zapatillas", "Pantalones", "Cazadoras"})
        Me.cbTipoProd.Location = New System.Drawing.Point(41, 44)
        Me.cbTipoProd.Name = "cbTipoProd"
        Me.cbTipoProd.Size = New System.Drawing.Size(121, 21)
        Me.cbTipoProd.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(207, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Articulo"
        '
        'lstArticulo
        '
        Me.lstArticulo.FormattingEnabled = True
        Me.lstArticulo.Location = New System.Drawing.Point(192, 44)
        Me.lstArticulo.Name = "lstArticulo"
        Me.lstArticulo.Size = New System.Drawing.Size(141, 95)
        Me.lstArticulo.TabIndex = 3
        '
        'rbtTotalUnid
        '
        Me.rbtTotalUnid.AutoSize = True
        Me.rbtTotalUnid.Location = New System.Drawing.Point(192, 166)
        Me.rbtTotalUnid.Name = "rbtTotalUnid"
        Me.rbtTotalUnid.Size = New System.Drawing.Size(180, 17)
        Me.rbtTotalUnid.TabIndex = 4
        Me.rbtTotalUnid.TabStop = True
        Me.rbtTotalUnid.Text = "Total unidades de estos articulos"
        Me.rbtTotalUnid.UseVisualStyleBackColor = True
        '
        'rbtPrecioMedio
        '
        Me.rbtPrecioMedio.AutoSize = True
        Me.rbtPrecioMedio.Location = New System.Drawing.Point(192, 213)
        Me.rbtPrecioMedio.Name = "rbtPrecioMedio"
        Me.rbtPrecioMedio.Size = New System.Drawing.Size(171, 17)
        Me.rbtPrecioMedio.TabIndex = 5
        Me.rbtPrecioMedio.TabStop = True
        Me.rbtPrecioMedio.Text = "Precio medio de estos articulos"
        Me.rbtPrecioMedio.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(381, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(146, 95)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'etNumerica
        '
        Me.etNumerica.AutoSize = True
        Me.etNumerica.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etNumerica.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etNumerica.Location = New System.Drawing.Point(435, 172)
        Me.etNumerica.Name = "etNumerica"
        Me.etNumerica.Size = New System.Drawing.Size(28, 27)
        Me.etNumerica.TabIndex = 7
        Me.etNumerica.Text = "X"
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(41, 236)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(486, 23)
        Me.btnVolver.TabIndex = 8
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'rbtUnidades
        '
        Me.rbtUnidades.AutoSize = True
        Me.rbtUnidades.Location = New System.Drawing.Point(192, 190)
        Me.rbtUnidades.Name = "rbtUnidades"
        Me.rbtUnidades.Size = New System.Drawing.Size(95, 17)
        Me.rbtUnidades.TabIndex = 9
        Me.rbtUnidades.TabStop = True
        Me.rbtUnidades.Text = "Total unidades"
        Me.rbtUnidades.UseVisualStyleBackColor = True
        '
        'CATALOGO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 275)
        Me.Controls.Add(Me.rbtUnidades)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.etNumerica)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.rbtPrecioMedio)
        Me.Controls.Add(Me.rbtTotalUnid)
        Me.Controls.Add(Me.lstArticulo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbTipoProd)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CATALOGO"
        Me.Text = "CATALOGO"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbTipoProd As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lstArticulo As System.Windows.Forms.ListBox
    Friend WithEvents rbtTotalUnid As System.Windows.Forms.RadioButton
    Friend WithEvents rbtPrecioMedio As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents etNumerica As System.Windows.Forms.Label
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents rbtUnidades As System.Windows.Forms.RadioButton
End Class
