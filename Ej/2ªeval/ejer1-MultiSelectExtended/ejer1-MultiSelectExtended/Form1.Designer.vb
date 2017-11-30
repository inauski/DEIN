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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnA2Simp = New System.Windows.Forms.Button()
        Me.btnA2Complejo = New System.Windows.Forms.Button()
        Me.btnA1Simp = New System.Windows.Forms.Button()
        Me.btnA1Complejo = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Todos los elementos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(231, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Elementos seleccionados"
        '
        'btnA2Simp
        '
        Me.btnA2Simp.Location = New System.Drawing.Point(169, 24)
        Me.btnA2Simp.Name = "btnA2Simp"
        Me.btnA2Simp.Size = New System.Drawing.Size(38, 23)
        Me.btnA2Simp.TabIndex = 4
        Me.btnA2Simp.Text = ">"
        Me.btnA2Simp.UseVisualStyleBackColor = True
        '
        'btnA2Complejo
        '
        Me.btnA2Complejo.Location = New System.Drawing.Point(169, 53)
        Me.btnA2Complejo.Name = "btnA2Complejo"
        Me.btnA2Complejo.Size = New System.Drawing.Size(38, 23)
        Me.btnA2Complejo.TabIndex = 5
        Me.btnA2Complejo.Text = ">>"
        Me.btnA2Complejo.UseVisualStyleBackColor = True
        '
        'btnA1Simp
        '
        Me.btnA1Simp.Enabled = False
        Me.btnA1Simp.Location = New System.Drawing.Point(169, 82)
        Me.btnA1Simp.Name = "btnA1Simp"
        Me.btnA1Simp.Size = New System.Drawing.Size(38, 23)
        Me.btnA1Simp.TabIndex = 6
        Me.btnA1Simp.Text = "<"
        Me.btnA1Simp.UseVisualStyleBackColor = True
        '
        'btnA1Complejo
        '
        Me.btnA1Complejo.Enabled = False
        Me.btnA1Complejo.Location = New System.Drawing.Point(169, 111)
        Me.btnA1Complejo.Name = "btnA1Complejo"
        Me.btnA1Complejo.Size = New System.Drawing.Size(38, 23)
        Me.btnA1Complejo.TabIndex = 7
        Me.btnA1Complejo.Text = "<<"
        Me.btnA1Complejo.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"Negro", "Azul", "Verde", "Rojo", "Naranja", "Amarillo", "Blanco", "Gris", "Marron", "Añil", "Morado", "Rosa"})
        Me.ListBox1.Location = New System.Drawing.Point(16, 39)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 95)
        Me.ListBox1.TabIndex = 8
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(238, 39)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(120, 95)
        Me.ListBox2.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 157)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnA1Complejo)
        Me.Controls.Add(Me.btnA1Simp)
        Me.Controls.Add(Me.btnA2Complejo)
        Me.Controls.Add(Me.btnA2Simp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnA2Simp As System.Windows.Forms.Button
    Friend WithEvents btnA2Complejo As System.Windows.Forms.Button
    Friend WithEvents btnA1Simp As System.Windows.Forms.Button
    Friend WithEvents btnA1Complejo As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox

End Class
