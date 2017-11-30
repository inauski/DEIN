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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.cbAtleta = New System.Windows.Forms.ComboBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAtleta = New System.Windows.Forms.TextBox()
        Me.btnNuevoAtleta = New System.Windows.Forms.Button()
        Me.gbNuloValido = New System.Windows.Forms.GroupBox()
        Me.rbtValido = New System.Windows.Forms.RadioButton()
        Me.rbtNulo = New System.Windows.Forms.RadioButton()
        Me.btnEntrarSalto = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblMejorSalto = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblNulo = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gbNuloValido.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbAtleta
        '
        Me.cbAtleta.FormattingEnabled = True
        Me.cbAtleta.Location = New System.Drawing.Point(14, 28)
        Me.cbAtleta.Name = "cbAtleta"
        Me.cbAtleta.Size = New System.Drawing.Size(173, 21)
        Me.cbAtleta.TabIndex = 1
        '
        'ListBox1
        '
        Me.ListBox1.Enabled = False
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(33, 161)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(58, 199)
        Me.ListBox1.TabIndex = 2
        '
        'ListBox2
        '
        Me.ListBox2.Enabled = False
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(108, 161)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(58, 199)
        Me.ListBox2.TabIndex = 3
        '
        'ListBox3
        '
        Me.ListBox3.Enabled = False
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Location = New System.Drawing.Point(184, 161)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(58, 199)
        Me.ListBox3.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(380, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Introduzca nuevo atleta"
        '
        'txtAtleta
        '
        Me.txtAtleta.Location = New System.Drawing.Point(367, 37)
        Me.txtAtleta.Name = "txtAtleta"
        Me.txtAtleta.Size = New System.Drawing.Size(178, 20)
        Me.txtAtleta.TabIndex = 6
        '
        'btnNuevoAtleta
        '
        Me.btnNuevoAtleta.Location = New System.Drawing.Point(367, 63)
        Me.btnNuevoAtleta.Name = "btnNuevoAtleta"
        Me.btnNuevoAtleta.Size = New System.Drawing.Size(178, 23)
        Me.btnNuevoAtleta.TabIndex = 7
        Me.btnNuevoAtleta.Text = "&Nuevo atleta"
        Me.btnNuevoAtleta.UseVisualStyleBackColor = True
        '
        'gbNuloValido
        '
        Me.gbNuloValido.Controls.Add(Me.rbtValido)
        Me.gbNuloValido.Controls.Add(Me.rbtNulo)
        Me.gbNuloValido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbNuloValido.Location = New System.Drawing.Point(367, 170)
        Me.gbNuloValido.Name = "gbNuloValido"
        Me.gbNuloValido.Size = New System.Drawing.Size(178, 56)
        Me.gbNuloValido.TabIndex = 8
        Me.gbNuloValido.TabStop = False
        Me.gbNuloValido.Text = "Validez del salto"
        '
        'rbtValido
        '
        Me.rbtValido.AutoSize = True
        Me.rbtValido.Location = New System.Drawing.Point(99, 20)
        Me.rbtValido.Name = "rbtValido"
        Me.rbtValido.Size = New System.Drawing.Size(54, 17)
        Me.rbtValido.TabIndex = 9
        Me.rbtValido.TabStop = True
        Me.rbtValido.Text = "Valido"
        Me.rbtValido.UseVisualStyleBackColor = True
        '
        'rbtNulo
        '
        Me.rbtNulo.AutoSize = True
        Me.rbtNulo.Location = New System.Drawing.Point(11, 20)
        Me.rbtNulo.Name = "rbtNulo"
        Me.rbtNulo.Size = New System.Drawing.Size(47, 17)
        Me.rbtNulo.TabIndex = 0
        Me.rbtNulo.TabStop = True
        Me.rbtNulo.Text = "Nulo"
        Me.rbtNulo.UseVisualStyleBackColor = True
        '
        'btnEntrarSalto
        '
        Me.btnEntrarSalto.Location = New System.Drawing.Point(367, 265)
        Me.btnEntrarSalto.Name = "btnEntrarSalto"
        Me.btnEntrarSalto.Size = New System.Drawing.Size(144, 33)
        Me.btnEntrarSalto.TabIndex = 9
        Me.btnEntrarSalto.Text = "&Entrar Salto"
        Me.btnEntrarSalto.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 461)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Mejor Salto:"
        '
        'lblMejorSalto
        '
        Me.lblMejorSalto.AutoSize = True
        Me.lblMejorSalto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMejorSalto.ForeColor = System.Drawing.Color.Blue
        Me.lblMejorSalto.Location = New System.Drawing.Point(183, 466)
        Me.lblMejorSalto.Name = "lblMejorSalto"
        Me.lblMejorSalto.Size = New System.Drawing.Size(38, 18)
        Me.lblMejorSalto.TabIndex = 11
        Me.lblMejorSalto.Text = "XXX"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(31, 541)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(525, 23)
        Me.btnSalir.TabIndex = 13
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(385, 332)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 16)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Total saltos nulos"
        '
        'lblNulo
        '
        Me.lblNulo.AutoSize = True
        Me.lblNulo.BackColor = System.Drawing.SystemColors.Control
        Me.lblNulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNulo.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblNulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNulo.Location = New System.Drawing.Point(431, 374)
        Me.lblNulo.Name = "lblNulo"
        Me.lblNulo.Size = New System.Drawing.Size(33, 31)
        Me.lblNulo.TabIndex = 15
        Me.lblNulo.Text = "X"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ListBox3)
        Me.Panel1.Controls.Add(Me.ListBox2)
        Me.Panel1.Controls.Add(Me.ListBox1)
        Me.Panel1.Controls.Add(Me.cbAtleta)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.ShapeContainer1)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.Control
        Me.Panel1.Location = New System.Drawing.Point(12, 9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(573, 566)
        Me.Panel1.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Atleta"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(571, 564)
        Me.ShapeContainer1.TabIndex = 5
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = -4
        Me.LineShape1.X2 = 572
        Me.LineShape1.Y1 = 107
        Me.LineShape1.Y2 = 107
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(33, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Atleta"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 587)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblNulo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lblMejorSalto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnEntrarSalto)
        Me.Controls.Add(Me.gbNuloValido)
        Me.Controls.Add(Me.btnNuevoAtleta)
        Me.Controls.Add(Me.txtAtleta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "CAMPEONATO DE TRIPLE SALTO DE ESTOCOLMO"
        Me.gbNuloValido.ResumeLayout(False)
        Me.gbNuloValido.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbAtleta As System.Windows.Forms.ComboBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox3 As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAtleta As System.Windows.Forms.TextBox
    Friend WithEvents btnNuevoAtleta As System.Windows.Forms.Button
    Friend WithEvents gbNuloValido As System.Windows.Forms.GroupBox
    Friend WithEvents rbtValido As System.Windows.Forms.RadioButton
    Friend WithEvents rbtNulo As System.Windows.Forms.RadioButton
    Friend WithEvents btnEntrarSalto As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblMejorSalto As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblNulo As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape

End Class
