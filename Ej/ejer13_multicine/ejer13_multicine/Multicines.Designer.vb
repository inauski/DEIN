<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Multicines
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
        Me.btDevolucion = New System.Windows.Forms.Button()
        Me.btVenta = New System.Windows.Forms.Button()
        Me.txtEntradas = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Horario = New System.Windows.Forms.GroupBox()
        Me.rbt1000 = New System.Windows.Forms.RadioButton()
        Me.rbt700 = New System.Windows.Forms.RadioButton()
        Me.rbt530 = New System.Windows.Forms.RadioButton()
        Me.Sala = New System.Windows.Forms.GroupBox()
        Me.rbtSala4 = New System.Windows.Forms.RadioButton()
        Me.rbtSala3 = New System.Windows.Forms.RadioButton()
        Me.rbtSala2 = New System.Windows.Forms.RadioButton()
        Me.rbtSala1 = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.titulo4 = New System.Windows.Forms.TextBox()
        Me.titulo3 = New System.Windows.Forms.TextBox()
        Me.titulo2 = New System.Windows.Forms.TextBox()
        Me.titulo1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambioDePeliculaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PeliculaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.peli1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.peli2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.peli3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.peli4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Horario.SuspendLayout()
        Me.Sala.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btDevolucion
        '
        Me.btDevolucion.Location = New System.Drawing.Point(407, 370)
        Me.btDevolucion.Name = "btDevolucion"
        Me.btDevolucion.Size = New System.Drawing.Size(116, 50)
        Me.btDevolucion.TabIndex = 44
        Me.btDevolucion.Text = "Devolucion"
        Me.btDevolucion.UseVisualStyleBackColor = True
        '
        'btVenta
        '
        Me.btVenta.Location = New System.Drawing.Point(249, 370)
        Me.btVenta.Name = "btVenta"
        Me.btVenta.Size = New System.Drawing.Size(116, 50)
        Me.btVenta.TabIndex = 43
        Me.btVenta.Text = "Venta"
        Me.btVenta.UseVisualStyleBackColor = True
        '
        'txtEntradas
        '
        Me.txtEntradas.Location = New System.Drawing.Point(135, 386)
        Me.txtEntradas.Name = "txtEntradas"
        Me.txtEntradas.Size = New System.Drawing.Size(76, 20)
        Me.txtEntradas.TabIndex = 42
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(132, 370)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 13)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Nº de Entradas"
        '
        'Horario
        '
        Me.Horario.Controls.Add(Me.rbt1000)
        Me.Horario.Controls.Add(Me.rbt700)
        Me.Horario.Controls.Add(Me.rbt530)
        Me.Horario.Location = New System.Drawing.Point(417, 254)
        Me.Horario.Name = "Horario"
        Me.Horario.Size = New System.Drawing.Size(78, 86)
        Me.Horario.TabIndex = 40
        Me.Horario.TabStop = False
        Me.Horario.Text = "Horario"
        '
        'rbt1000
        '
        Me.rbt1000.AutoSize = True
        Me.rbt1000.Location = New System.Drawing.Point(10, 63)
        Me.rbt1000.Name = "rbt1000"
        Me.rbt1000.Size = New System.Drawing.Size(52, 17)
        Me.rbt1000.TabIndex = 2
        Me.rbt1000.Text = "10:00"
        Me.rbt1000.UseVisualStyleBackColor = True
        '
        'rbt700
        '
        Me.rbt700.AutoSize = True
        Me.rbt700.Location = New System.Drawing.Point(10, 42)
        Me.rbt700.Name = "rbt700"
        Me.rbt700.Size = New System.Drawing.Size(46, 17)
        Me.rbt700.TabIndex = 1
        Me.rbt700.Text = "7:00"
        Me.rbt700.UseVisualStyleBackColor = True
        '
        'rbt530
        '
        Me.rbt530.AutoSize = True
        Me.rbt530.Checked = True
        Me.rbt530.Location = New System.Drawing.Point(10, 19)
        Me.rbt530.Name = "rbt530"
        Me.rbt530.Size = New System.Drawing.Size(46, 17)
        Me.rbt530.TabIndex = 0
        Me.rbt530.TabStop = True
        Me.rbt530.Text = "5:30"
        Me.rbt530.UseVisualStyleBackColor = True
        '
        'Sala
        '
        Me.Sala.Controls.Add(Me.rbtSala4)
        Me.Sala.Controls.Add(Me.rbtSala3)
        Me.Sala.Controls.Add(Me.rbtSala2)
        Me.Sala.Controls.Add(Me.rbtSala1)
        Me.Sala.Location = New System.Drawing.Point(135, 254)
        Me.Sala.Name = "Sala"
        Me.Sala.Size = New System.Drawing.Size(200, 86)
        Me.Sala.TabIndex = 39
        Me.Sala.TabStop = False
        Me.Sala.Text = "Sala"
        '
        'rbtSala4
        '
        Me.rbtSala4.AutoSize = True
        Me.rbtSala4.Location = New System.Drawing.Point(104, 55)
        Me.rbtSala4.Name = "rbtSala4"
        Me.rbtSala4.Size = New System.Drawing.Size(55, 17)
        Me.rbtSala4.TabIndex = 3
        Me.rbtSala4.Text = "Sala 4"
        Me.rbtSala4.UseVisualStyleBackColor = True
        '
        'rbtSala3
        '
        Me.rbtSala3.AutoSize = True
        Me.rbtSala3.Location = New System.Drawing.Point(104, 24)
        Me.rbtSala3.Name = "rbtSala3"
        Me.rbtSala3.Size = New System.Drawing.Size(55, 17)
        Me.rbtSala3.TabIndex = 2
        Me.rbtSala3.Text = "Sala 3"
        Me.rbtSala3.UseVisualStyleBackColor = True
        '
        'rbtSala2
        '
        Me.rbtSala2.AutoSize = True
        Me.rbtSala2.Location = New System.Drawing.Point(8, 55)
        Me.rbtSala2.Name = "rbtSala2"
        Me.rbtSala2.Size = New System.Drawing.Size(55, 17)
        Me.rbtSala2.TabIndex = 1
        Me.rbtSala2.Text = "Sala 2"
        Me.rbtSala2.UseVisualStyleBackColor = True
        '
        'rbtSala1
        '
        Me.rbtSala1.AutoSize = True
        Me.rbtSala1.Checked = True
        Me.rbtSala1.Location = New System.Drawing.Point(8, 24)
        Me.rbtSala1.Name = "rbtSala1"
        Me.rbtSala1.Size = New System.Drawing.Size(55, 17)
        Me.rbtSala1.TabIndex = 0
        Me.rbtSala1.TabStop = True
        Me.rbtSala1.Text = "Sala 1"
        Me.rbtSala1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(95, 216)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "10:30"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(101, 187)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 13)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "7:00"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(101, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "5:30"
        '
        'ListBox4
        '
        Me.ListBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.ItemHeight = 24
        Me.ListBox4.Items.AddRange(New Object() {"100", "100", "100"})
        Me.ListBox4.Location = New System.Drawing.Point(475, 159)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(58, 76)
        Me.ListBox4.TabIndex = 35
        '
        'ListBox3
        '
        Me.ListBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.ItemHeight = 24
        Me.ListBox3.Items.AddRange(New Object() {"120", "120", "120"})
        Me.ListBox3.Location = New System.Drawing.Point(355, 159)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(58, 76)
        Me.ListBox3.TabIndex = 34
        '
        'ListBox2
        '
        Me.ListBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 24
        Me.ListBox2.Items.AddRange(New Object() {"150", "150", "150"})
        Me.ListBox2.Location = New System.Drawing.Point(240, 159)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(58, 76)
        Me.ListBox2.TabIndex = 33
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 24
        Me.ListBox1.Items.AddRange(New Object() {"200", "200", "200"})
        Me.ListBox1.Location = New System.Drawing.Point(135, 159)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(58, 76)
        Me.ListBox1.TabIndex = 32
        '
        'titulo4
        '
        Me.titulo4.Location = New System.Drawing.Point(465, 119)
        Me.titulo4.Name = "titulo4"
        Me.titulo4.Size = New System.Drawing.Size(82, 20)
        Me.titulo4.TabIndex = 31
        Me.titulo4.Text = "Emoji"
        '
        'titulo3
        '
        Me.titulo3.Location = New System.Drawing.Point(346, 119)
        Me.titulo3.Name = "titulo3"
        Me.titulo3.Size = New System.Drawing.Size(82, 20)
        Me.titulo3.TabIndex = 30
        Me.titulo3.Text = "It"
        '
        'titulo2
        '
        Me.titulo2.Location = New System.Drawing.Point(231, 119)
        Me.titulo2.Name = "titulo2"
        Me.titulo2.Size = New System.Drawing.Size(82, 20)
        Me.titulo2.TabIndex = 29
        Me.titulo2.Text = "Minions"
        '
        'titulo1
        '
        Me.titulo1.Location = New System.Drawing.Point(125, 119)
        Me.titulo1.Name = "titulo1"
        Me.titulo1.Size = New System.Drawing.Size(82, 20)
        Me.titulo1.TabIndex = 28
        Me.titulo1.Text = "Los simpsons"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(486, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Sala 4"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(362, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Sala 3"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(246, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Sala 2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(146, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Sala 1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(185, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(310, 27)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Multicines ""Cinemanía Galáctica"""
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.PeliculaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(643, 24)
        Me.MenuStrip1.TabIndex = 45
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CambioDePeliculaToolStripMenuItem, Me.ToolStripMenuItem1, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'CambioDePeliculaToolStripMenuItem
        '
        Me.CambioDePeliculaToolStripMenuItem.Name = "CambioDePeliculaToolStripMenuItem"
        Me.CambioDePeliculaToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.CambioDePeliculaToolStripMenuItem.Text = "Cambio de Pelicula"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(173, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'PeliculaToolStripMenuItem
        '
        Me.PeliculaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.peli1, Me.peli2, Me.peli3, Me.peli4})
        Me.PeliculaToolStripMenuItem.Name = "PeliculaToolStripMenuItem"
        Me.PeliculaToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.PeliculaToolStripMenuItem.Text = "Pelicula"
        '
        'peli1
        '
        Me.peli1.Name = "peli1"
        Me.peli1.Size = New System.Drawing.Size(152, 22)
        Me.peli1.Text = "peli1"
        '
        'peli2
        '
        Me.peli2.Name = "peli2"
        Me.peli2.Size = New System.Drawing.Size(152, 22)
        Me.peli2.Text = "peli2"
        '
        'peli3
        '
        Me.peli3.Name = "peli3"
        Me.peli3.Size = New System.Drawing.Size(152, 22)
        Me.peli3.Text = "peli3"
        '
        'peli4
        '
        Me.peli4.Name = "peli4"
        Me.peli4.Size = New System.Drawing.Size(152, 22)
        Me.peli4.Text = "peli4"
        '
        'Multicines
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 472)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btDevolucion)
        Me.Controls.Add(Me.btVenta)
        Me.Controls.Add(Me.txtEntradas)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Horario)
        Me.Controls.Add(Me.Sala)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ListBox4)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.titulo4)
        Me.Controls.Add(Me.titulo3)
        Me.Controls.Add(Me.titulo2)
        Me.Controls.Add(Me.titulo1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Multicines"
        Me.Text = "Form1"
        Me.Horario.ResumeLayout(False)
        Me.Horario.PerformLayout()
        Me.Sala.ResumeLayout(False)
        Me.Sala.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btDevolucion As System.Windows.Forms.Button
    Friend WithEvents btVenta As System.Windows.Forms.Button
    Friend WithEvents txtEntradas As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Horario As System.Windows.Forms.GroupBox
    Friend WithEvents rbt1000 As System.Windows.Forms.RadioButton
    Friend WithEvents rbt700 As System.Windows.Forms.RadioButton
    Friend WithEvents rbt530 As System.Windows.Forms.RadioButton
    Friend WithEvents Sala As System.Windows.Forms.GroupBox
    Friend WithEvents rbtSala4 As System.Windows.Forms.RadioButton
    Friend WithEvents rbtSala3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbtSala2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbtSala1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ListBox4 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox3 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents titulo4 As System.Windows.Forms.TextBox
    Friend WithEvents titulo3 As System.Windows.Forms.TextBox
    Friend WithEvents titulo2 As System.Windows.Forms.TextBox
    Friend WithEvents titulo1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CambioDePeliculaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PeliculaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents peli1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents peli2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents peli3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents peli4 As System.Windows.Forms.ToolStripMenuItem

End Class
