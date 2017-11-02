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
        Me.rbtMujer = New System.Windows.Forms.RadioButton()
        Me.imgMujer = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.rbtHombre = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.txtEstatura = New System.Windows.Forms.TextBox()
        Me.lblEstatura = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.etPesoIdeal = New System.Windows.Forms.Label()
        Me.chkLista = New System.Windows.Forms.CheckBox()
        Me.lblPesoIdeal = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtGrande = New System.Windows.Forms.RadioButton()
        Me.rbtPequeño = New System.Windows.Forms.RadioButton()
        Me.btnBorrarEnt = New System.Windows.Forms.Button()
        Me.btnBorrarTodo = New System.Windows.Forms.Button()
        Me.lsSEP = New System.Windows.Forms.ListBox()
        Me.lblPeso = New System.Windows.Forms.Label()
        Me.etEstatura = New System.Windows.Forms.Label()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        CType(Me.imgMujer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rbtMujer
        '
        Me.rbtMujer.AutoSize = True
        Me.rbtMujer.Location = New System.Drawing.Point(27, 25)
        Me.rbtMujer.Name = "rbtMujer"
        Me.rbtMujer.Size = New System.Drawing.Size(14, 13)
        Me.rbtMujer.TabIndex = 0
        Me.rbtMujer.TabStop = True
        Me.rbtMujer.UseVisualStyleBackColor = True
        '
        'imgMujer
        '
        Me.imgMujer.Image = CType(resources.GetObject("imgMujer.Image"), System.Drawing.Image)
        Me.imgMujer.InitialImage = CType(resources.GetObject("imgMujer.InitialImage"), System.Drawing.Image)
        Me.imgMujer.Location = New System.Drawing.Point(59, 14)
        Me.imgMujer.Name = "imgMujer"
        Me.imgMujer.Size = New System.Drawing.Size(36, 34)
        Me.imgMujer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgMujer.TabIndex = 1
        Me.imgMujer.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(226, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 34)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'rbtHombre
        '
        Me.rbtHombre.AutoSize = True
        Me.rbtHombre.Location = New System.Drawing.Point(196, 25)
        Me.rbtHombre.Name = "rbtHombre"
        Me.rbtHombre.Size = New System.Drawing.Size(14, 13)
        Me.rbtHombre.TabIndex = 3
        Me.rbtHombre.TabStop = True
        Me.rbtHombre.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnCalcular)
        Me.Panel1.Controls.Add(Me.txtEstatura)
        Me.Panel1.Controls.Add(Me.lblEstatura)
        Me.Panel1.Controls.Add(Me.rbtHombre)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.imgMujer)
        Me.Panel1.Controls.Add(Me.rbtMujer)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(359, 185)
        Me.Panel1.TabIndex = 4
        '
        'btnCalcular
        '
        Me.btnCalcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCalcular.Location = New System.Drawing.Point(109, 124)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(138, 36)
        Me.btnCalcular.TabIndex = 6
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'txtEstatura
        '
        Me.txtEstatura.Location = New System.Drawing.Point(109, 88)
        Me.txtEstatura.Name = "txtEstatura"
        Me.txtEstatura.Size = New System.Drawing.Size(81, 20)
        Me.txtEstatura.TabIndex = 5
        '
        'lblEstatura
        '
        Me.lblEstatura.AutoSize = True
        Me.lblEstatura.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEstatura.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatura.Location = New System.Drawing.Point(109, 65)
        Me.lblEstatura.Name = "lblEstatura"
        Me.lblEstatura.Size = New System.Drawing.Size(100, 20)
        Me.lblEstatura.TabIndex = 4
        Me.lblEstatura.Text = "Estatura (cm)"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.etPesoIdeal)
        Me.Panel2.Controls.Add(Me.chkLista)
        Me.Panel2.Controls.Add(Me.lblPesoIdeal)
        Me.Panel2.Location = New System.Drawing.Point(388, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(313, 184)
        Me.Panel2.TabIndex = 5
        '
        'etPesoIdeal
        '
        Me.etPesoIdeal.AutoSize = True
        Me.etPesoIdeal.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etPesoIdeal.Location = New System.Drawing.Point(70, 71)
        Me.etPesoIdeal.Name = "etPesoIdeal"
        Me.etPesoIdeal.Size = New System.Drawing.Size(0, 22)
        Me.etPesoIdeal.TabIndex = 2
        '
        'chkLista
        '
        Me.chkLista.AutoSize = True
        Me.chkLista.Location = New System.Drawing.Point(62, 124)
        Me.chkLista.Name = "chkLista"
        Me.chkLista.Size = New System.Drawing.Size(48, 17)
        Me.chkLista.TabIndex = 1
        Me.chkLista.Text = "Lista"
        Me.chkLista.UseVisualStyleBackColor = True
        '
        'lblPesoIdeal
        '
        Me.lblPesoIdeal.AutoSize = True
        Me.lblPesoIdeal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPesoIdeal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPesoIdeal.Location = New System.Drawing.Point(81, 14)
        Me.lblPesoIdeal.Name = "lblPesoIdeal"
        Me.lblPesoIdeal.Size = New System.Drawing.Size(102, 18)
        Me.lblPesoIdeal.TabIndex = 0
        Me.lblPesoIdeal.Text = "Peso Ideal (Kg)"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Controls.Add(Me.btnBorrarEnt)
        Me.Panel3.Controls.Add(Me.btnBorrarTodo)
        Me.Panel3.Controls.Add(Me.lsSEP)
        Me.Panel3.Controls.Add(Me.lblPeso)
        Me.Panel3.Controls.Add(Me.etEstatura)
        Me.Panel3.Controls.Add(Me.lblSexo)
        Me.Panel3.Location = New System.Drawing.Point(13, 207)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(687, 306)
        Me.Panel3.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtGrande)
        Me.GroupBox1.Controls.Add(Me.rbtPequeño)
        Me.GroupBox1.Location = New System.Drawing.Point(473, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(140, 100)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tamaño de la fuente"
        '
        'rbtGrande
        '
        Me.rbtGrande.AutoSize = True
        Me.rbtGrande.Location = New System.Drawing.Point(20, 55)
        Me.rbtGrande.Name = "rbtGrande"
        Me.rbtGrande.Size = New System.Drawing.Size(60, 17)
        Me.rbtGrande.TabIndex = 1
        Me.rbtGrande.TabStop = True
        Me.rbtGrande.Text = "Grande"
        Me.rbtGrande.UseVisualStyleBackColor = True
        '
        'rbtPequeño
        '
        Me.rbtPequeño.AutoSize = True
        Me.rbtPequeño.Location = New System.Drawing.Point(20, 32)
        Me.rbtPequeño.Name = "rbtPequeño"
        Me.rbtPequeño.Size = New System.Drawing.Size(68, 17)
        Me.rbtPequeño.TabIndex = 0
        Me.rbtPequeño.TabStop = True
        Me.rbtPequeño.Text = "Pequeño"
        Me.rbtPequeño.UseVisualStyleBackColor = True
        '
        'btnBorrarEnt
        '
        Me.btnBorrarEnt.Location = New System.Drawing.Point(473, 175)
        Me.btnBorrarEnt.Name = "btnBorrarEnt"
        Me.btnBorrarEnt.Size = New System.Drawing.Size(140, 23)
        Me.btnBorrarEnt.TabIndex = 8
        Me.btnBorrarEnt.Text = "Borrar entrada"
        Me.btnBorrarEnt.UseVisualStyleBackColor = True
        '
        'btnBorrarTodo
        '
        Me.btnBorrarTodo.Location = New System.Drawing.Point(473, 204)
        Me.btnBorrarTodo.Name = "btnBorrarTodo"
        Me.btnBorrarTodo.Size = New System.Drawing.Size(140, 23)
        Me.btnBorrarTodo.TabIndex = 9
        Me.btnBorrarTodo.Text = "Borrar todo"
        Me.btnBorrarTodo.UseVisualStyleBackColor = True
        '
        'lsSEP
        '
        Me.lsSEP.FormattingEnabled = True
        Me.lsSEP.IntegralHeight = False
        Me.lsSEP.Location = New System.Drawing.Point(23, 87)
        Me.lsSEP.Name = "lsSEP"
        Me.lsSEP.Size = New System.Drawing.Size(223, 199)
        Me.lsSEP.TabIndex = 3
        '
        'lblPeso
        '
        Me.lblPeso.AutoSize = True
        Me.lblPeso.Location = New System.Drawing.Point(143, 55)
        Me.lblPeso.Name = "lblPeso"
        Me.lblPeso.Size = New System.Drawing.Size(31, 13)
        Me.lblPeso.TabIndex = 2
        Me.lblPeso.Text = "Peso"
        '
        'etEstatura
        '
        Me.etEstatura.AutoSize = True
        Me.etEstatura.Location = New System.Drawing.Point(67, 55)
        Me.etEstatura.Name = "etEstatura"
        Me.etEstatura.Size = New System.Drawing.Size(46, 13)
        Me.etEstatura.TabIndex = 1
        Me.etEstatura.Text = "Estatura"
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Location = New System.Drawing.Point(20, 55)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(31, 13)
        Me.lblSexo.TabIndex = 0
        Me.lblSexo.Text = "Sexo"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(12, 529)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(688, 32)
        Me.btnSalir.TabIndex = 7
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 578)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.imgMujer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rbtMujer As System.Windows.Forms.RadioButton
    Friend WithEvents imgMujer As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents rbtHombre As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnCalcular As System.Windows.Forms.Button
    Friend WithEvents txtEstatura As System.Windows.Forms.TextBox
    Friend WithEvents lblEstatura As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents etPesoIdeal As System.Windows.Forms.Label
    Friend WithEvents chkLista As System.Windows.Forms.CheckBox
    Friend WithEvents lblPesoIdeal As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtGrande As System.Windows.Forms.RadioButton
    Friend WithEvents rbtPequeño As System.Windows.Forms.RadioButton
    Friend WithEvents btnBorrarEnt As System.Windows.Forms.Button
    Friend WithEvents btnBorrarTodo As System.Windows.Forms.Button
    Friend WithEvents lsSEP As System.Windows.Forms.ListBox
    Friend WithEvents lblPeso As System.Windows.Forms.Label
    Friend WithEvents etEstatura As System.Windows.Forms.Label
    Friend WithEvents lblSexo As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button

End Class
