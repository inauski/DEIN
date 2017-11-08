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
        Me.lstRopa = New System.Windows.Forms.ListBox()
        Me.lstTipoProd = New System.Windows.Forms.ListBox()
        Me.lstPrecio = New System.Windows.Forms.ListBox()
        Me.lstDisponibles = New System.Windows.Forms.ListBox()
        Me.Articulo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCatalogo = New System.Windows.Forms.Button()
        Me.btnElimArt = New System.Windows.Forms.Button()
        Me.btnElimProd = New System.Windows.Forms.Button()
        Me.cbProd1 = New System.Windows.Forms.ComboBox()
        Me.btnUnidades = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.chbDto = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btnComprarCanc = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.txtUnidNuevo = New System.Windows.Forms.TextBox()
        Me.txtPrecioNuev = New System.Windows.Forms.TextBox()
        Me.txtArtNuevo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnNuevoArt = New System.Windows.Forms.Button()
        Me.btnFinalizar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstRopa
        '
        Me.lstRopa.FormattingEnabled = True
        Me.lstRopa.Items.AddRange(New Object() {"DICKIES CAMILA", "ADIDAS GAZELLE", "BILLABONG HEAD", "QUICKSILVER FIRSTY", "CARHARTT TEXAX"})
        Me.lstRopa.Location = New System.Drawing.Point(28, 41)
        Me.lstRopa.Name = "lstRopa"
        Me.lstRopa.Size = New System.Drawing.Size(159, 134)
        Me.lstRopa.TabIndex = 0
        '
        'lstTipoProd
        '
        Me.lstTipoProd.Enabled = False
        Me.lstTipoProd.FormattingEnabled = True
        Me.lstTipoProd.Items.AddRange(New Object() {"Camisetas", "Zapatillas", "Gorras", "Gorras", "Pantalones"})
        Me.lstTipoProd.Location = New System.Drawing.Point(221, 41)
        Me.lstTipoProd.Name = "lstTipoProd"
        Me.lstTipoProd.Size = New System.Drawing.Size(108, 134)
        Me.lstTipoProd.TabIndex = 1
        '
        'lstPrecio
        '
        Me.lstPrecio.Enabled = False
        Me.lstPrecio.FormattingEnabled = True
        Me.lstPrecio.Items.AddRange(New Object() {"25", "75", "21", "15", "80"})
        Me.lstPrecio.Location = New System.Drawing.Point(360, 41)
        Me.lstPrecio.Name = "lstPrecio"
        Me.lstPrecio.Size = New System.Drawing.Size(55, 134)
        Me.lstPrecio.TabIndex = 2
        '
        'lstDisponibles
        '
        Me.lstDisponibles.Enabled = False
        Me.lstDisponibles.FormattingEnabled = True
        Me.lstDisponibles.Items.AddRange(New Object() {"10", "10", "5", "3", "5"})
        Me.lstDisponibles.Location = New System.Drawing.Point(444, 41)
        Me.lstDisponibles.Name = "lstDisponibles"
        Me.lstDisponibles.Size = New System.Drawing.Size(55, 134)
        Me.lstDisponibles.TabIndex = 3
        '
        'Articulo
        '
        Me.Articulo.AutoSize = True
        Me.Articulo.Location = New System.Drawing.Point(25, 25)
        Me.Articulo.Name = "Articulo"
        Me.Articulo.Size = New System.Drawing.Size(42, 13)
        Me.Articulo.TabIndex = 4
        Me.Articulo.Text = "Articulo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(218, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Tipo de producto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(357, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Precio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(441, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Disponibles"
        '
        'btnCatalogo
        '
        Me.btnCatalogo.Image = CType(resources.GetObject("btnCatalogo.Image"), System.Drawing.Image)
        Me.btnCatalogo.Location = New System.Drawing.Point(525, 41)
        Me.btnCatalogo.Name = "btnCatalogo"
        Me.btnCatalogo.Size = New System.Drawing.Size(137, 134)
        Me.btnCatalogo.TabIndex = 8
        Me.btnCatalogo.UseVisualStyleBackColor = True
        '
        'btnElimArt
        '
        Me.btnElimArt.Location = New System.Drawing.Point(28, 198)
        Me.btnElimArt.Name = "btnElimArt"
        Me.btnElimArt.Size = New System.Drawing.Size(278, 23)
        Me.btnElimArt.TabIndex = 9
        Me.btnElimArt.Text = "Eliminar articulo seleccionado"
        Me.btnElimArt.UseVisualStyleBackColor = True
        '
        'btnElimProd
        '
        Me.btnElimProd.Location = New System.Drawing.Point(312, 198)
        Me.btnElimProd.Name = "btnElimProd"
        Me.btnElimProd.Size = New System.Drawing.Size(212, 23)
        Me.btnElimProd.TabIndex = 10
        Me.btnElimProd.Text = "Eliminar productos -->"
        Me.btnElimProd.UseVisualStyleBackColor = True
        '
        'cbProd1
        '
        Me.cbProd1.FormattingEnabled = True
        Me.cbProd1.Items.AddRange(New Object() {"Camisetas", "Gorras", "Zapatillas", "Pantalones", "Cazadoras"})
        Me.cbProd1.Location = New System.Drawing.Point(541, 198)
        Me.cbProd1.Name = "cbProd1"
        Me.cbProd1.Size = New System.Drawing.Size(121, 21)
        Me.cbProd1.TabIndex = 11
        '
        'btnUnidades
        '
        Me.btnUnidades.Location = New System.Drawing.Point(28, 243)
        Me.btnUnidades.Name = "btnUnidades"
        Me.btnUnidades.Size = New System.Drawing.Size(148, 36)
        Me.btnUnidades.TabIndex = 12
        Me.btnUnidades.Text = "Unidades a comprar -->"
        Me.btnUnidades.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(221, 243)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(85, 38)
        Me.TextBox1.TabIndex = 13
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'chbDto
        '
        Me.chbDto.AutoSize = True
        Me.chbDto.Location = New System.Drawing.Point(350, 254)
        Me.chbDto.Name = "chbDto"
        Me.chbDto.Size = New System.Drawing.Size(102, 17)
        Me.chbDto.TabIndex = 14
        Me.chbDto.Text = "Aplicar dto 10 %"
        Me.chbDto.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 311)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Articulo--Unidades---Total a pagar"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(28, 337)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(332, 20)
        Me.TextBox2.TabIndex = 16
        '
        'btnComprarCanc
        '
        Me.btnComprarCanc.Location = New System.Drawing.Point(403, 309)
        Me.btnComprarCanc.Name = "btnComprarCanc"
        Me.btnComprarCanc.Size = New System.Drawing.Size(259, 48)
        Me.btnComprarCanc.TabIndex = 17
        Me.btnComprarCanc.Text = "Comprar ///// Cancelar la compra"
        Me.btnComprarCanc.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.txtUnidNuevo)
        Me.Panel1.Controls.Add(Me.txtPrecioNuev)
        Me.Panel1.Controls.Add(Me.txtArtNuevo)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.btnNuevoArt)
        Me.Panel1.Location = New System.Drawing.Point(28, 407)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(634, 100)
        Me.Panel1.TabIndex = 18
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Camisetas", "Gorras", "Zapatillas", "Pantalones", "Cazadoras"})
        Me.ComboBox1.Location = New System.Drawing.Point(148, 65)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(206, 21)
        Me.ComboBox1.TabIndex = 9
        '
        'txtUnidNuevo
        '
        Me.txtUnidNuevo.Enabled = False
        Me.txtUnidNuevo.Location = New System.Drawing.Point(512, 65)
        Me.txtUnidNuevo.Name = "txtUnidNuevo"
        Me.txtUnidNuevo.Size = New System.Drawing.Size(100, 20)
        Me.txtUnidNuevo.TabIndex = 8
        Me.txtUnidNuevo.Text = "10"
        '
        'txtPrecioNuev
        '
        Me.txtPrecioNuev.Location = New System.Drawing.Point(370, 66)
        Me.txtPrecioNuev.Name = "txtPrecioNuev"
        Me.txtPrecioNuev.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecioNuev.TabIndex = 7
        '
        'txtArtNuevo
        '
        Me.txtArtNuevo.Location = New System.Drawing.Point(15, 65)
        Me.txtArtNuevo.Name = "txtArtNuevo"
        Me.txtArtNuevo.Size = New System.Drawing.Size(100, 20)
        Me.txtArtNuevo.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(509, 49)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Unidades"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(367, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Precio"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(145, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Tipo de producto"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Articulo"
        '
        'btnNuevoArt
        '
        Me.btnNuevoArt.Location = New System.Drawing.Point(15, 13)
        Me.btnNuevoArt.Name = "btnNuevoArt"
        Me.btnNuevoArt.Size = New System.Drawing.Size(604, 23)
        Me.btnNuevoArt.TabIndex = 0
        Me.btnNuevoArt.Text = "Nuevo articulo"
        Me.btnNuevoArt.UseVisualStyleBackColor = True
        '
        'btnFinalizar
        '
        Me.btnFinalizar.Location = New System.Drawing.Point(28, 528)
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.Size = New System.Drawing.Size(634, 23)
        Me.btnFinalizar.TabIndex = 19
        Me.btnFinalizar.Text = "Finalizar"
        Me.btnFinalizar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 561)
        Me.Controls.Add(Me.btnFinalizar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnComprarCanc)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chbDto)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnUnidades)
        Me.Controls.Add(Me.cbProd1)
        Me.Controls.Add(Me.btnElimProd)
        Me.Controls.Add(Me.btnElimArt)
        Me.Controls.Add(Me.btnCatalogo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Articulo)
        Me.Controls.Add(Me.lstDisponibles)
        Me.Controls.Add(Me.lstPrecio)
        Me.Controls.Add(Me.lstTipoProd)
        Me.Controls.Add(Me.lstRopa)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstRopa As System.Windows.Forms.ListBox
    Friend WithEvents lstTipoProd As System.Windows.Forms.ListBox
    Friend WithEvents lstPrecio As System.Windows.Forms.ListBox
    Friend WithEvents lstDisponibles As System.Windows.Forms.ListBox
    Friend WithEvents Articulo As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnCatalogo As System.Windows.Forms.Button
    Friend WithEvents btnElimArt As System.Windows.Forms.Button
    Friend WithEvents btnElimProd As System.Windows.Forms.Button
    Friend WithEvents cbProd1 As System.Windows.Forms.ComboBox
    Friend WithEvents btnUnidades As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents chbDto As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents btnComprarCanc As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents txtUnidNuevo As System.Windows.Forms.TextBox
    Friend WithEvents txtPrecioNuev As System.Windows.Forms.TextBox
    Friend WithEvents txtArtNuevo As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnNuevoArt As System.Windows.Forms.Button
    Friend WithEvents btnFinalizar As System.Windows.Forms.Button

End Class
