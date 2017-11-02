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
        Me.txta = New System.Windows.Forms.TextBox()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.txtc = New System.Windows.Forms.TextBox()
        Me.txtd = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txta
        '
        Me.txta.Location = New System.Drawing.Point(12, 12)
        Me.txta.Name = "txta"
        Me.txta.Size = New System.Drawing.Size(100, 20)
        Me.txta.TabIndex = 0
        '
        'txtB
        '
        Me.txtB.Location = New System.Drawing.Point(12, 38)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(100, 20)
        Me.txtB.TabIndex = 1
        '
        'txtc
        '
        Me.txtc.Location = New System.Drawing.Point(12, 64)
        Me.txtc.Name = "txtc"
        Me.txtc.Size = New System.Drawing.Size(100, 20)
        Me.txtc.TabIndex = 2
        '
        'txtd
        '
        Me.txtd.Location = New System.Drawing.Point(12, 90)
        Me.txtd.Name = "txtd"
        Me.txtd.Size = New System.Drawing.Size(100, 20)
        Me.txtd.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 116)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(12, 155)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(100, 20)
        Me.txtValor.TabIndex = 5
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 181)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Desglosar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(22, 229)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 7
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(128, 226)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtd)
        Me.Controls.Add(Me.txtc)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.txta)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txta As System.Windows.Forms.TextBox
    Friend WithEvents txtB As System.Windows.Forms.TextBox
    Friend WithEvents txtc As System.Windows.Forms.TextBox
    Friend WithEvents txtd As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtValor As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button

End Class
