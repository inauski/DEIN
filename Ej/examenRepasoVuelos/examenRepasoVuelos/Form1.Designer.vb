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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbOrigen = New System.Windows.Forms.ComboBox()
        Me.rbNacional = New System.Windows.Forms.RadioButton()
        Me.rbInternacional = New System.Windows.Forms.RadioButton()
        Me.lstNacional = New System.Windows.Forms.ListBox()
        Me.lstInternacional = New System.Windows.Forms.ListBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.cbTarifa = New System.Windows.Forms.ComboBox()
        Me.btnAnadirVuelo = New System.Windows.Forms.Button()
        Me.lstCompras = New System.Windows.Forms.ListBox()
        Me.btnElimVuelo = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtCodigoPostal = New System.Windows.Forms.TextBox()
        Me.etTotal = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Origen"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(313, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Destino"
        '
        'cbOrigen
        '
        Me.cbOrigen.FormattingEnabled = True
        Me.cbOrigen.Items.AddRange(New Object() {"BARCELONA", "BILBAO", "MADRID", "SANTANDER", "VITORIA", "ZARAGOZA"})
        Me.cbOrigen.Location = New System.Drawing.Point(33, 40)
        Me.cbOrigen.Name = "cbOrigen"
        Me.cbOrigen.Size = New System.Drawing.Size(121, 21)
        Me.cbOrigen.TabIndex = 2
        '
        'rbNacional
        '
        Me.rbNacional.AutoSize = True
        Me.rbNacional.Checked = True
        Me.rbNacional.Location = New System.Drawing.Point(316, 40)
        Me.rbNacional.Name = "rbNacional"
        Me.rbNacional.Size = New System.Drawing.Size(67, 17)
        Me.rbNacional.TabIndex = 3
        Me.rbNacional.TabStop = True
        Me.rbNacional.Text = "Nacional"
        Me.rbNacional.UseVisualStyleBackColor = True
        '
        'rbInternacional
        '
        Me.rbInternacional.AutoSize = True
        Me.rbInternacional.Location = New System.Drawing.Point(510, 40)
        Me.rbInternacional.Name = "rbInternacional"
        Me.rbInternacional.Size = New System.Drawing.Size(86, 17)
        Me.rbInternacional.TabIndex = 4
        Me.rbInternacional.TabStop = True
        Me.rbInternacional.Text = "Internacional"
        Me.rbInternacional.UseVisualStyleBackColor = True
        '
        'lstNacional
        '
        Me.lstNacional.FormattingEnabled = True
        Me.lstNacional.Items.AddRange(New Object() {"BARCELONA", "BILBAO", "MADRID", "SANTANDER", "VITORIA", "ZARAGOZA"})
        Me.lstNacional.Location = New System.Drawing.Point(316, 73)
        Me.lstNacional.Name = "lstNacional"
        Me.lstNacional.Size = New System.Drawing.Size(120, 95)
        Me.lstNacional.TabIndex = 5
        '
        'lstInternacional
        '
        Me.lstInternacional.FormattingEnabled = True
        Me.lstInternacional.Items.AddRange(New Object() {"AMSTERDAM", "ESTOCOLMO", "LONDRES", "NEW YORK", "PARIS", "SIDNEY"})
        Me.lstInternacional.Location = New System.Drawing.Point(501, 73)
        Me.lstInternacional.Name = "lstInternacional"
        Me.lstInternacional.Size = New System.Drawing.Size(120, 95)
        Me.lstInternacional.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(671, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(157, 144)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 224)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Nº de billetes"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(104, 222)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDown1.TabIndex = 10
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'cbTarifa
        '
        Me.cbTarifa.FormattingEnabled = True
        Me.cbTarifa.Items.AddRange(New Object() {"--seleccione tarifa--", "Básica...........150€", "Clasica..........200€", "Extra..............300€", "VIP.................500€"})
        Me.cbTarifa.Location = New System.Drawing.Point(32, 260)
        Me.cbTarifa.Name = "cbTarifa"
        Me.cbTarifa.Size = New System.Drawing.Size(121, 21)
        Me.cbTarifa.TabIndex = 11
        '
        'btnAnadirVuelo
        '
        Me.btnAnadirVuelo.Location = New System.Drawing.Point(317, 204)
        Me.btnAnadirVuelo.Name = "btnAnadirVuelo"
        Me.btnAnadirVuelo.Size = New System.Drawing.Size(119, 101)
        Me.btnAnadirVuelo.TabIndex = 12
        Me.btnAnadirVuelo.Text = "Añadir vuelo"
        Me.btnAnadirVuelo.UseVisualStyleBackColor = True
        '
        'lstCompras
        '
        Me.lstCompras.FormattingEnabled = True
        Me.lstCompras.Location = New System.Drawing.Point(455, 210)
        Me.lstCompras.Name = "lstCompras"
        Me.lstCompras.Size = New System.Drawing.Size(227, 95)
        Me.lstCompras.TabIndex = 13
        '
        'btnElimVuelo
        '
        Me.btnElimVuelo.Location = New System.Drawing.Point(713, 204)
        Me.btnElimVuelo.Name = "btnElimVuelo"
        Me.btnElimVuelo.Size = New System.Drawing.Size(120, 101)
        Me.btnElimVuelo.TabIndex = 14
        Me.btnElimVuelo.Text = "Eliminar vuelo"
        Me.btnElimVuelo.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 411)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Nombre"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(174, 411)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Apellido"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(324, 411)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Codigo Postal"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(587, 367)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(120, 101)
        Me.btnAceptar.TabIndex = 20
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(713, 367)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(120, 101)
        Me.btnCancelar.TabIndex = 21
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(26, 491)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(807, 23)
        Me.btnSalir.TabIndex = 22
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(26, 427)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(142, 20)
        Me.txtNombre.TabIndex = 23
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(174, 427)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(142, 20)
        Me.txtApellido.TabIndex = 24
        '
        'txtCodigoPostal
        '
        Me.txtCodigoPostal.Location = New System.Drawing.Point(322, 427)
        Me.txtCodigoPostal.Name = "txtCodigoPostal"
        Me.txtCodigoPostal.Size = New System.Drawing.Size(142, 20)
        Me.txtCodigoPostal.TabIndex = 25
        '
        'etTotal
        '
        Me.etTotal.AutoSize = True
        Me.etTotal.Location = New System.Drawing.Point(668, 323)
        Me.etTotal.Name = "etTotal"
        Me.etTotal.Size = New System.Drawing.Size(0, 13)
        Me.etTotal.TabIndex = 16
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 530)
        Me.Controls.Add(Me.txtCodigoPostal)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.etTotal)
        Me.Controls.Add(Me.btnElimVuelo)
        Me.Controls.Add(Me.lstCompras)
        Me.Controls.Add(Me.btnAnadirVuelo)
        Me.Controls.Add(Me.cbTarifa)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lstInternacional)
        Me.Controls.Add(Me.lstNacional)
        Me.Controls.Add(Me.rbInternacional)
        Me.Controls.Add(Me.rbNacional)
        Me.Controls.Add(Me.cbOrigen)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Vuela con nosotros !!!"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbOrigen As System.Windows.Forms.ComboBox
    Friend WithEvents rbNacional As System.Windows.Forms.RadioButton
    Friend WithEvents rbInternacional As System.Windows.Forms.RadioButton
    Friend WithEvents lstNacional As System.Windows.Forms.ListBox
    Friend WithEvents lstInternacional As System.Windows.Forms.ListBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents cbTarifa As System.Windows.Forms.ComboBox
    Friend WithEvents btnAnadirVuelo As System.Windows.Forms.Button
    Friend WithEvents lstCompras As System.Windows.Forms.ListBox
    Friend WithEvents btnElimVuelo As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoPostal As System.Windows.Forms.TextBox
    Friend WithEvents etTotal As System.Windows.Forms.Label

End Class
