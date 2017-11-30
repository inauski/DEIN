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
        Me.opcCalor = New System.Windows.Forms.RadioButton()
        Me.opcFrio = New System.Windows.Forms.RadioButton()
        Me.etTemp = New System.Windows.Forms.Label()
        Me.btnTemp = New System.Windows.Forms.Button()
        Me.etMax = New System.Windows.Forms.Label()
        Me.etMin = New System.Windows.Forms.Label()
        Me.txtTemp = New System.Windows.Forms.TextBox()
        Me.txtMax = New System.Windows.Forms.TextBox()
        Me.txtMin = New System.Windows.Forms.TextBox()
        Me.etConta = New System.Windows.Forms.Label()
        Me.etMedia = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtConta = New System.Windows.Forms.TextBox()
        Me.txtMedia = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'opcCalor
        '
        Me.opcCalor.AutoSize = True
        Me.opcCalor.BackColor = System.Drawing.Color.Transparent
        Me.opcCalor.Location = New System.Drawing.Point(283, 35)
        Me.opcCalor.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.opcCalor.Name = "opcCalor"
        Me.opcCalor.Size = New System.Drawing.Size(64, 22)
        Me.opcCalor.TabIndex = 0
        Me.opcCalor.TabStop = True
        Me.opcCalor.Text = "calor"
        Me.opcCalor.UseVisualStyleBackColor = False
        '
        'opcFrio
        '
        Me.opcFrio.AutoSize = True
        Me.opcFrio.BackColor = System.Drawing.Color.Transparent
        Me.opcFrio.Location = New System.Drawing.Point(553, 35)
        Me.opcFrio.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.opcFrio.Name = "opcFrio"
        Me.opcFrio.Size = New System.Drawing.Size(51, 22)
        Me.opcFrio.TabIndex = 1
        Me.opcFrio.TabStop = True
        Me.opcFrio.Text = "frio"
        Me.opcFrio.UseVisualStyleBackColor = False
        '
        'etTemp
        '
        Me.etTemp.AutoSize = True
        Me.etTemp.BackColor = System.Drawing.Color.Transparent
        Me.etTemp.Location = New System.Drawing.Point(332, 74)
        Me.etTemp.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.etTemp.Name = "etTemp"
        Me.etTemp.Size = New System.Drawing.Size(131, 18)
        Me.etTemp.TabIndex = 2
        Me.etTemp.Text = "TEMPERATURA"
        '
        'btnTemp
        '
        Me.btnTemp.Location = New System.Drawing.Point(235, 149)
        Me.btnTemp.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnTemp.Name = "btnTemp"
        Me.btnTemp.Size = New System.Drawing.Size(335, 39)
        Me.btnTemp.TabIndex = 3
        Me.btnTemp.Text = "Introducir temperatura"
        Me.btnTemp.UseVisualStyleBackColor = True
        '
        'etMax
        '
        Me.etMax.AutoSize = True
        Me.etMax.BackColor = System.Drawing.Color.Transparent
        Me.etMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etMax.Location = New System.Drawing.Point(205, 205)
        Me.etMax.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.etMax.Name = "etMax"
        Me.etMax.Size = New System.Drawing.Size(49, 13)
        Me.etMax.TabIndex = 4
        Me.etMax.Text = "Máxima"
        '
        'etMin
        '
        Me.etMin.AutoSize = True
        Me.etMin.BackColor = System.Drawing.Color.Transparent
        Me.etMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etMin.Location = New System.Drawing.Point(542, 205)
        Me.etMin.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.etMin.Name = "etMin"
        Me.etMin.Size = New System.Drawing.Size(48, 13)
        Me.etMin.TabIndex = 5
        Me.etMin.Text = "Mínima"
        '
        'txtTemp
        '
        Me.txtTemp.Location = New System.Drawing.Point(347, 107)
        Me.txtTemp.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtTemp.Name = "txtTemp"
        Me.txtTemp.Size = New System.Drawing.Size(106, 24)
        Me.txtTemp.TabIndex = 6
        '
        'txtMax
        '
        Me.txtMax.Enabled = False
        Me.txtMax.Location = New System.Drawing.Point(171, 242)
        Me.txtMax.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtMax.Name = "txtMax"
        Me.txtMax.Size = New System.Drawing.Size(131, 24)
        Me.txtMax.TabIndex = 7
        '
        'txtMin
        '
        Me.txtMin.Enabled = False
        Me.txtMin.Location = New System.Drawing.Point(501, 242)
        Me.txtMin.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtMin.Name = "txtMin"
        Me.txtMin.Size = New System.Drawing.Size(131, 24)
        Me.txtMin.TabIndex = 8
        '
        'etConta
        '
        Me.etConta.AutoSize = True
        Me.etConta.BackColor = System.Drawing.Color.Transparent
        Me.etConta.Location = New System.Drawing.Point(134, 351)
        Me.etConta.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.etConta.Name = "etConta"
        Me.etConta.Size = New System.Drawing.Size(255, 18)
        Me.etConta.TabIndex = 9
        Me.etConta.Text = "Nº de temperaturas introducidas:"
        '
        'etMedia
        '
        Me.etMedia.AutoSize = True
        Me.etMedia.BackColor = System.Drawing.Color.Transparent
        Me.etMedia.Location = New System.Drawing.Point(133, 390)
        Me.etMedia.Name = "etMedia"
        Me.etMedia.Size = New System.Drawing.Size(304, 18)
        Me.etMedia.TabIndex = 10
        Me.etMedia.Text = "Media de las temperaturas introducidas"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(191, 442)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(435, 43)
        Me.btnSalir.TabIndex = 11
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'txtConta
        '
        Me.txtConta.Enabled = False
        Me.txtConta.Location = New System.Drawing.Point(514, 350)
        Me.txtConta.Name = "txtConta"
        Me.txtConta.Size = New System.Drawing.Size(76, 24)
        Me.txtConta.TabIndex = 12
        '
        'txtMedia
        '
        Me.txtMedia.Enabled = False
        Me.txtMedia.Location = New System.Drawing.Point(514, 384)
        Me.txtMedia.Name = "txtMedia"
        Me.txtMedia.Size = New System.Drawing.Size(76, 24)
        Me.txtMedia.TabIndex = 13
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(237, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(44, 45)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(501, 21)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(44, 45)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(810, 611)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtMedia)
        Me.Controls.Add(Me.txtConta)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.etMedia)
        Me.Controls.Add(Me.etConta)
        Me.Controls.Add(Me.txtMin)
        Me.Controls.Add(Me.txtMax)
        Me.Controls.Add(Me.txtTemp)
        Me.Controls.Add(Me.etMin)
        Me.Controls.Add(Me.etMax)
        Me.Controls.Add(Me.btnTemp)
        Me.Controls.Add(Me.etTemp)
        Me.Controls.Add(Me.opcFrio)
        Me.Controls.Add(Me.opcCalor)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents opcCalor As System.Windows.Forms.RadioButton
    Friend WithEvents opcFrio As System.Windows.Forms.RadioButton
    Friend WithEvents etTemp As System.Windows.Forms.Label
    Friend WithEvents btnTemp As System.Windows.Forms.Button
    Friend WithEvents etMax As System.Windows.Forms.Label
    Friend WithEvents etMin As System.Windows.Forms.Label
    Friend WithEvents txtTemp As System.Windows.Forms.TextBox
    Friend WithEvents txtMax As System.Windows.Forms.TextBox
    Friend WithEvents txtMin As System.Windows.Forms.TextBox
    Friend WithEvents etConta As System.Windows.Forms.Label
    Friend WithEvents etMedia As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents txtConta As System.Windows.Forms.TextBox
    Friend WithEvents txtMedia As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox

End Class
