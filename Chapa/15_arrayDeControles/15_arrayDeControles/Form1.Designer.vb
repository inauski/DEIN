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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.ra = New System.Windows.Forms.RadioButton()
        Me.rb = New System.Windows.Forms.RadioButton()
        Me.rc = New System.Windows.Forms.RadioButton()
        Me.rd = New System.Windows.Forms.RadioButton()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(40, 26)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(310, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Iniciar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(93, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(40, 110)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(310, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Parar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(93, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Label2"
        '
        'Timer2
        '
        Me.Timer2.Interval = 2000
        '
        'ra
        '
        Me.ra.AutoSize = True
        Me.ra.Checked = True
        Me.ra.Location = New System.Drawing.Point(40, 213)
        Me.ra.Name = "ra"
        Me.ra.Size = New System.Drawing.Size(46, 17)
        Me.ra.TabIndex = 4
        Me.ra.TabStop = True
        Me.ra.Text = "AAA"
        Me.ra.UseVisualStyleBackColor = True
        '
        'rb
        '
        Me.rb.AutoSize = True
        Me.rb.Location = New System.Drawing.Point(40, 236)
        Me.rb.Name = "rb"
        Me.rb.Size = New System.Drawing.Size(46, 17)
        Me.rb.TabIndex = 5
        Me.rb.Text = "BBB"
        Me.rb.UseVisualStyleBackColor = True
        '
        'rc
        '
        Me.rc.AutoSize = True
        Me.rc.Location = New System.Drawing.Point(40, 259)
        Me.rc.Name = "rc"
        Me.rc.Size = New System.Drawing.Size(46, 17)
        Me.rc.TabIndex = 6
        Me.rc.Text = "CCC"
        Me.rc.UseVisualStyleBackColor = True
        '
        'rd
        '
        Me.rd.AutoSize = True
        Me.rd.Location = New System.Drawing.Point(40, 282)
        Me.rd.Name = "rd"
        Me.rd.Size = New System.Drawing.Size(49, 17)
        Me.rd.TabIndex = 7
        Me.rd.Text = "DDD"
        Me.rd.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(175, 213)
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
        Me.ClientSize = New System.Drawing.Size(523, 413)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.rd)
        Me.Controls.Add(Me.rc)
        Me.Controls.Add(Me.rb)
        Me.Controls.Add(Me.ra)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents ra As System.Windows.Forms.RadioButton
    Friend WithEvents rb As System.Windows.Forms.RadioButton
    Friend WithEvents rc As System.Windows.Forms.RadioButton
    Friend WithEvents rd As System.Windows.Forms.RadioButton
    Friend WithEvents Button3 As System.Windows.Forms.Button

End Class
