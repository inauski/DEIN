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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerPortadasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstTitulo = New System.Windows.Forms.ListBox()
        Me.lstUnid = New System.Windows.Forms.ListBox()
        Me.gbOpciones = New System.Windows.Forms.GroupBox()
        Me.rbtBajas = New System.Windows.Forms.RadioButton()
        Me.rbtModif = New System.Windows.Forms.RadioButton()
        Me.rbtAltas = New System.Windows.Forms.RadioButton()
        Me.btnIrAOpcion = New System.Windows.Forms.Button()
        Me.gbAltas = New System.Windows.Forms.GroupBox()
        Me.btnXaltas = New System.Windows.Forms.Button()
        Me.btnHacerAltas = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUnidAltas = New System.Windows.Forms.TextBox()
        Me.txtTituloAltas = New System.Windows.Forms.TextBox()
        Me.gbModif = New System.Windows.Forms.GroupBox()
        Me.btnXmodif = New System.Windows.Forms.Button()
        Me.btnHacerModif = New System.Windows.Forms.Button()
        Me.txtUnidModif = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gbBajas = New System.Windows.Forms.GroupBox()
        Me.btnXbajas = New System.Windows.Forms.Button()
        Me.btnHacerBajas = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.gbOpciones.SuspendLayout()
        Me.gbAltas.SuspendLayout()
        Me.gbModif.SuspendLayout()
        Me.gbBajas.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(625, 25)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerPortadasToolStripMenuItem, Me.ToolStripMenuItem1, Me.SalirToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(69, 19)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'VerPortadasToolStripMenuItem
        '
        Me.VerPortadasToolStripMenuItem.Name = "VerPortadasToolStripMenuItem"
        Me.VerPortadasToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.VerPortadasToolStripMenuItem.Text = "Ver portadas"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(136, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(284, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Librería ""El pez no pasa, nada"""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 66)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Título"
        '
        'lstTitulo
        '
        Me.lstTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTitulo.FormattingEnabled = True
        Me.lstTitulo.ItemHeight = 16
        Me.lstTitulo.Items.AddRange(New Object() {"BIDASOA", "IGNACIO", "PASIONES ROMANAS"})
        Me.lstTitulo.Location = New System.Drawing.Point(13, 95)
        Me.lstTitulo.Name = "lstTitulo"
        Me.lstTitulo.Size = New System.Drawing.Size(173, 164)
        Me.lstTitulo.TabIndex = 3
        '
        'lstUnid
        '
        Me.lstUnid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstUnid.FormattingEnabled = True
        Me.lstUnid.ItemHeight = 16
        Me.lstUnid.Items.AddRange(New Object() {"15", "8", "4"})
        Me.lstUnid.Location = New System.Drawing.Point(206, 95)
        Me.lstUnid.Name = "lstUnid"
        Me.lstUnid.Size = New System.Drawing.Size(79, 164)
        Me.lstUnid.TabIndex = 4
        '
        'gbOpciones
        '
        Me.gbOpciones.Controls.Add(Me.rbtBajas)
        Me.gbOpciones.Controls.Add(Me.rbtModif)
        Me.gbOpciones.Controls.Add(Me.rbtAltas)
        Me.gbOpciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbOpciones.Location = New System.Drawing.Point(307, 95)
        Me.gbOpciones.Name = "gbOpciones"
        Me.gbOpciones.Size = New System.Drawing.Size(200, 116)
        Me.gbOpciones.TabIndex = 5
        Me.gbOpciones.TabStop = False
        Me.gbOpciones.Text = "Opciones"
        '
        'rbtBajas
        '
        Me.rbtBajas.AutoSize = True
        Me.rbtBajas.Location = New System.Drawing.Point(21, 74)
        Me.rbtBajas.Name = "rbtBajas"
        Me.rbtBajas.Size = New System.Drawing.Size(61, 20)
        Me.rbtBajas.TabIndex = 2
        Me.rbtBajas.Text = "Bajas"
        Me.rbtBajas.UseVisualStyleBackColor = True
        '
        'rbtModif
        '
        Me.rbtModif.AutoSize = True
        Me.rbtModif.Location = New System.Drawing.Point(21, 48)
        Me.rbtModif.Name = "rbtModif"
        Me.rbtModif.Size = New System.Drawing.Size(117, 20)
        Me.rbtModif.TabIndex = 1
        Me.rbtModif.Text = "Modificaciones"
        Me.rbtModif.UseVisualStyleBackColor = True
        '
        'rbtAltas
        '
        Me.rbtAltas.AutoSize = True
        Me.rbtAltas.Checked = True
        Me.rbtAltas.Location = New System.Drawing.Point(21, 22)
        Me.rbtAltas.Name = "rbtAltas"
        Me.rbtAltas.Size = New System.Drawing.Size(56, 20)
        Me.rbtAltas.TabIndex = 0
        Me.rbtAltas.TabStop = True
        Me.rbtAltas.Text = "Altas"
        Me.rbtAltas.UseVisualStyleBackColor = True
        '
        'btnIrAOpcion
        '
        Me.btnIrAOpcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIrAOpcion.Location = New System.Drawing.Point(328, 236)
        Me.btnIrAOpcion.Name = "btnIrAOpcion"
        Me.btnIrAOpcion.Size = New System.Drawing.Size(167, 23)
        Me.btnIrAOpcion.TabIndex = 6
        Me.btnIrAOpcion.Text = "Ir a opción"
        Me.btnIrAOpcion.UseVisualStyleBackColor = True
        '
        'gbAltas
        '
        Me.gbAltas.Controls.Add(Me.btnXaltas)
        Me.gbAltas.Controls.Add(Me.btnHacerAltas)
        Me.gbAltas.Controls.Add(Me.Label4)
        Me.gbAltas.Controls.Add(Me.Label3)
        Me.gbAltas.Controls.Add(Me.txtUnidAltas)
        Me.gbAltas.Controls.Add(Me.txtTituloAltas)
        Me.gbAltas.Enabled = False
        Me.gbAltas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbAltas.Location = New System.Drawing.Point(31, 284)
        Me.gbAltas.Name = "gbAltas"
        Me.gbAltas.Size = New System.Drawing.Size(570, 100)
        Me.gbAltas.TabIndex = 7
        Me.gbAltas.TabStop = False
        Me.gbAltas.Text = "ALTAS"
        '
        'btnXaltas
        '
        Me.btnXaltas.Location = New System.Drawing.Point(426, 47)
        Me.btnXaltas.Name = "btnXaltas"
        Me.btnXaltas.Size = New System.Drawing.Size(49, 23)
        Me.btnXaltas.TabIndex = 5
        Me.btnXaltas.Text = "X"
        Me.btnXaltas.UseVisualStyleBackColor = True
        '
        'btnHacerAltas
        '
        Me.btnHacerAltas.Location = New System.Drawing.Point(319, 47)
        Me.btnHacerAltas.Name = "btnHacerAltas"
        Me.btnHacerAltas.Size = New System.Drawing.Size(75, 23)
        Me.btnHacerAltas.TabIndex = 4
        Me.btnHacerAltas.Text = "Hacer"
        Me.btnHacerAltas.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(223, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Unidades"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Título"
        '
        'txtUnidAltas
        '
        Me.txtUnidAltas.Location = New System.Drawing.Point(226, 47)
        Me.txtUnidAltas.Name = "txtUnidAltas"
        Me.txtUnidAltas.Size = New System.Drawing.Size(75, 22)
        Me.txtUnidAltas.TabIndex = 1
        '
        'txtTituloAltas
        '
        Me.txtTituloAltas.Location = New System.Drawing.Point(6, 47)
        Me.txtTituloAltas.Name = "txtTituloAltas"
        Me.txtTituloAltas.Size = New System.Drawing.Size(214, 22)
        Me.txtTituloAltas.TabIndex = 0
        '
        'gbModif
        '
        Me.gbModif.Controls.Add(Me.btnXmodif)
        Me.gbModif.Controls.Add(Me.btnHacerModif)
        Me.gbModif.Controls.Add(Me.txtUnidModif)
        Me.gbModif.Controls.Add(Me.Label5)
        Me.gbModif.Enabled = False
        Me.gbModif.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbModif.Location = New System.Drawing.Point(31, 400)
        Me.gbModif.Name = "gbModif"
        Me.gbModif.Size = New System.Drawing.Size(570, 100)
        Me.gbModif.TabIndex = 8
        Me.gbModif.TabStop = False
        Me.gbModif.Text = "MODIFICACIONES"
        '
        'btnXmodif
        '
        Me.btnXmodif.Location = New System.Drawing.Point(426, 51)
        Me.btnXmodif.Name = "btnXmodif"
        Me.btnXmodif.Size = New System.Drawing.Size(49, 23)
        Me.btnXmodif.TabIndex = 6
        Me.btnXmodif.Text = "X"
        Me.btnXmodif.UseVisualStyleBackColor = True
        '
        'btnHacerModif
        '
        Me.btnHacerModif.Location = New System.Drawing.Point(309, 51)
        Me.btnHacerModif.Name = "btnHacerModif"
        Me.btnHacerModif.Size = New System.Drawing.Size(75, 23)
        Me.btnHacerModif.TabIndex = 5
        Me.btnHacerModif.Text = "Hacer"
        Me.btnHacerModif.UseVisualStyleBackColor = True
        '
        'txtUnidModif
        '
        Me.txtUnidModif.Location = New System.Drawing.Point(184, 51)
        Me.txtUnidModif.Name = "txtUnidModif"
        Me.txtUnidModif.Size = New System.Drawing.Size(100, 22)
        Me.txtUnidModif.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(103, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Unidades"
        '
        'gbBajas
        '
        Me.gbBajas.Controls.Add(Me.btnXbajas)
        Me.gbBajas.Controls.Add(Me.btnHacerBajas)
        Me.gbBajas.Enabled = False
        Me.gbBajas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbBajas.Location = New System.Drawing.Point(31, 524)
        Me.gbBajas.Name = "gbBajas"
        Me.gbBajas.Size = New System.Drawing.Size(570, 100)
        Me.gbBajas.TabIndex = 9
        Me.gbBajas.TabStop = False
        Me.gbBajas.Text = "BAJAS"
        '
        'btnXbajas
        '
        Me.btnXbajas.Location = New System.Drawing.Point(426, 55)
        Me.btnXbajas.Name = "btnXbajas"
        Me.btnXbajas.Size = New System.Drawing.Size(49, 23)
        Me.btnXbajas.TabIndex = 7
        Me.btnXbajas.Text = "X"
        Me.btnXbajas.UseVisualStyleBackColor = True
        '
        'btnHacerBajas
        '
        Me.btnHacerBajas.Location = New System.Drawing.Point(42, 55)
        Me.btnHacerBajas.Name = "btnHacerBajas"
        Me.btnHacerBajas.Size = New System.Drawing.Size(352, 23)
        Me.btnHacerBajas.TabIndex = 0
        Me.btnHacerBajas.Text = "Hacer"
        Me.btnHacerBajas.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(193, 66)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(140, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Unidades disponibles"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 667)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.gbBajas)
        Me.Controls.Add(Me.gbModif)
        Me.Controls.Add(Me.gbAltas)
        Me.Controls.Add(Me.btnIrAOpcion)
        Me.Controls.Add(Me.gbOpciones)
        Me.Controls.Add(Me.lstUnid)
        Me.Controls.Add(Me.lstTitulo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "PaSa La ViDa, iGuaL Que PaSa La CoRRieNTe"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.gbOpciones.ResumeLayout(False)
        Me.gbOpciones.PerformLayout()
        Me.gbAltas.ResumeLayout(False)
        Me.gbAltas.PerformLayout()
        Me.gbModif.ResumeLayout(False)
        Me.gbModif.PerformLayout()
        Me.gbBajas.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerPortadasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lstTitulo As System.Windows.Forms.ListBox
    Friend WithEvents lstUnid As System.Windows.Forms.ListBox
    Friend WithEvents gbOpciones As System.Windows.Forms.GroupBox
    Friend WithEvents rbtBajas As System.Windows.Forms.RadioButton
    Friend WithEvents rbtModif As System.Windows.Forms.RadioButton
    Friend WithEvents rbtAltas As System.Windows.Forms.RadioButton
    Friend WithEvents btnIrAOpcion As System.Windows.Forms.Button
    Friend WithEvents gbAltas As System.Windows.Forms.GroupBox
    Friend WithEvents btnXaltas As System.Windows.Forms.Button
    Friend WithEvents btnHacerAltas As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtUnidAltas As System.Windows.Forms.TextBox
    Friend WithEvents txtTituloAltas As System.Windows.Forms.TextBox
    Friend WithEvents gbModif As System.Windows.Forms.GroupBox
    Friend WithEvents btnXmodif As System.Windows.Forms.Button
    Friend WithEvents btnHacerModif As System.Windows.Forms.Button
    Friend WithEvents txtUnidModif As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents gbBajas As System.Windows.Forms.GroupBox
    Friend WithEvents btnXbajas As System.Windows.Forms.Button
    Friend WithEvents btnHacerBajas As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
