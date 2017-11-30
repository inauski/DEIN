<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAltasEnPos
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
        Me.btnSalirAltasFinal = New System.Windows.Forms.Button()
        Me.btnAltasPos = New System.Windows.Forms.Button()
        Me.txtAltasPos = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnSalirAltasFinal
        '
        Me.btnSalirAltasFinal.Location = New System.Drawing.Point(51, 226)
        Me.btnSalirAltasFinal.Name = "btnSalirAltasFinal"
        Me.btnSalirAltasFinal.Size = New System.Drawing.Size(255, 23)
        Me.btnSalirAltasFinal.TabIndex = 7
        Me.btnSalirAltasFinal.Text = "&Salir de altas"
        Me.btnSalirAltasFinal.UseVisualStyleBackColor = True
        '
        'btnAltasPos
        '
        Me.btnAltasPos.Location = New System.Drawing.Point(51, 82)
        Me.btnAltasPos.Name = "btnAltasPos"
        Me.btnAltasPos.Size = New System.Drawing.Size(255, 23)
        Me.btnAltasPos.TabIndex = 6
        Me.btnAltasPos.Text = "&Altas en posicion"
        Me.btnAltasPos.UseVisualStyleBackColor = True
        '
        'txtAltasPos
        '
        Me.txtAltasPos.Location = New System.Drawing.Point(51, 46)
        Me.txtAltasPos.Name = "txtAltasPos"
        Me.txtAltasPos.Size = New System.Drawing.Size(255, 20)
        Me.txtAltasPos.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(138, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ALTAS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(119, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 25)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "POSICION"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(115, 147)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 9
        '
        'frmAltasEnPos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 261)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSalirAltasFinal)
        Me.Controls.Add(Me.btnAltasPos)
        Me.Controls.Add(Me.txtAltasPos)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAltasEnPos"
        Me.Text = "Altas en posicion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents btnSalirAltasFinal As System.Windows.Forms.Button
    Private WithEvents btnAltasPos As System.Windows.Forms.Button
    Friend WithEvents txtAltasPos As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
