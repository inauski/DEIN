<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.etUnidDispon = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.etEncontrados = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.etTotalUnidEncon = New System.Windows.Forms.Label()
        Me.chbTotalUnid = New System.Windows.Forms.CheckBox()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.etTotalUnid = New System.Windows.Forms.Label()
        Me.lstTit = New System.Windows.Forms.ListBox()
        Me.lstUnidades = New System.Windows.Forms.ListBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(45, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(224, 228)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(275, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Unidades disponibles"
        '
        'etUnidDispon
        '
        Me.etUnidDispon.AutoSize = True
        Me.etUnidDispon.Location = New System.Drawing.Point(321, 111)
        Me.etUnidDispon.Name = "etUnidDispon"
        Me.etUnidDispon.Size = New System.Drawing.Size(14, 13)
        Me.etUnidDispon.TabIndex = 2
        Me.etUnidDispon.Text = "X"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.Location = New System.Drawing.Point(413, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 468)
        Me.Panel1.TabIndex = 3
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(468, 27)
        Me.txtBuscar.Multiline = True
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(103, 26)
        Me.txtBuscar.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(606, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = " Pulsar ENTER para buscar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(447, 376)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(193, 26)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Nº libros encontrados"
        '
        'etEncontrados
        '
        Me.etEncontrados.AutoSize = True
        Me.etEncontrados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etEncontrados.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etEncontrados.Location = New System.Drawing.Point(706, 375)
        Me.etEncontrados.Name = "etEncontrados"
        Me.etEncontrados.Size = New System.Drawing.Size(26, 26)
        Me.etEncontrados.TabIndex = 9
        Me.etEncontrados.Text = "X"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(437, 438)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(245, 26)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Total unidades encontradas"
        '
        'etTotalUnidEncon
        '
        Me.etTotalUnidEncon.AutoSize = True
        Me.etTotalUnidEncon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etTotalUnidEncon.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etTotalUnidEncon.Location = New System.Drawing.Point(706, 438)
        Me.etTotalUnidEncon.Name = "etTotalUnidEncon"
        Me.etTotalUnidEncon.Size = New System.Drawing.Size(26, 26)
        Me.etTotalUnidEncon.TabIndex = 11
        Me.etTotalUnidEncon.Text = "X"
        '
        'chbTotalUnid
        '
        Me.chbTotalUnid.AutoSize = True
        Me.chbTotalUnid.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbTotalUnid.Location = New System.Drawing.Point(22, 394)
        Me.chbTotalUnid.Name = "chbTotalUnid"
        Me.chbTotalUnid.Size = New System.Drawing.Size(313, 28)
        Me.chbTotalUnid.TabIndex = 12
        Me.chbTotalUnid.Text = "Mostrar total unidades disponibles"
        Me.chbTotalUnid.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(45, 494)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(687, 23)
        Me.btnVolver.TabIndex = 13
        Me.btnVolver.Text = "Volver al formulario principal"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'HScrollBar1
        '
        Me.HScrollBar1.LargeChange = 1
        Me.HScrollBar1.Location = New System.Drawing.Point(45, 291)
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(313, 26)
        Me.HScrollBar1.TabIndex = 3
        '
        'etTotalUnid
        '
        Me.etTotalUnid.AutoSize = True
        Me.etTotalUnid.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etTotalUnid.Location = New System.Drawing.Point(365, 395)
        Me.etTotalUnid.Name = "etTotalUnid"
        Me.etTotalUnid.Size = New System.Drawing.Size(0, 24)
        Me.etTotalUnid.TabIndex = 14
        '
        'lstTit
        '
        Me.lstTit.FormattingEnabled = True
        Me.lstTit.Location = New System.Drawing.Point(437, 103)
        Me.lstTit.Name = "lstTit"
        Me.lstTit.Size = New System.Drawing.Size(235, 212)
        Me.lstTit.TabIndex = 15
        '
        'lstUnidades
        '
        Me.lstUnidades.FormattingEnabled = True
        Me.lstUnidades.Location = New System.Drawing.Point(683, 103)
        Me.lstUnidades.Name = "lstUnidades"
        Me.lstUnidades.Size = New System.Drawing.Size(61, 212)
        Me.lstUnidades.TabIndex = 16
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 529)
        Me.Controls.Add(Me.lstUnidades)
        Me.Controls.Add(Me.lstTit)
        Me.Controls.Add(Me.etTotalUnid)
        Me.Controls.Add(Me.HScrollBar1)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.chbTotalUnid)
        Me.Controls.Add(Me.etTotalUnidEncon)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.etEncontrados)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.etUnidDispon)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents etUnidDispon As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents etEncontrados As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents etTotalUnidEncon As System.Windows.Forms.Label
    Friend WithEvents chbTotalUnid As System.Windows.Forms.CheckBox
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents HScrollBar1 As System.Windows.Forms.HScrollBar
    Friend WithEvents etTotalUnid As System.Windows.Forms.Label
    Friend WithEvents lstTit As System.Windows.Forms.ListBox
    Friend WithEvents lstUnidades As System.Windows.Forms.ListBox
End Class
