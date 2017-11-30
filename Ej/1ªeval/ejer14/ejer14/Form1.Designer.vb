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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lstImagenes = New System.Windows.Forms.ListBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ListaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AñadirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlfinalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnPosicionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImagenesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IcoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JpgToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.etHora = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstImagenes
        '
        Me.lstImagenes.FormattingEnabled = True
        Me.lstImagenes.Items.AddRange(New Object() {"HIPOTALAMO", "PSICODREAMER", "IMAGEN", "BELFOS"})
        Me.lstImagenes.Location = New System.Drawing.Point(35, 71)
        Me.lstImagenes.Name = "lstImagenes"
        Me.lstImagenes.Size = New System.Drawing.Size(120, 225)
        Me.lstImagenes.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(190, 88)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(272, 208)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListaToolStripMenuItem, Me.ImagenesToolStripMenuItem, Me.AcercaDeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(512, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ListaToolStripMenuItem
        '
        Me.ListaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AñadirToolStripMenuItem, Me.BorrarToolStripMenuItem, Me.ToolStripMenuItem1, Me.SalirToolStripMenuItem})
        Me.ListaToolStripMenuItem.Name = "ListaToolStripMenuItem"
        Me.ListaToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.ListaToolStripMenuItem.Text = "Lista"
        '
        'AñadirToolStripMenuItem
        '
        Me.AñadirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlfinalToolStripMenuItem, Me.EnPosicionToolStripMenuItem})
        Me.AñadirToolStripMenuItem.Name = "AñadirToolStripMenuItem"
        Me.AñadirToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.AñadirToolStripMenuItem.Text = "Añadir"
        '
        'AlfinalToolStripMenuItem
        '
        Me.AlfinalToolStripMenuItem.Name = "AlfinalToolStripMenuItem"
        Me.AlfinalToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.AlfinalToolStripMenuItem.Text = "Al &final"
        '
        'EnPosicionToolStripMenuItem
        '
        Me.EnPosicionToolStripMenuItem.Name = "EnPosicionToolStripMenuItem"
        Me.EnPosicionToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.EnPosicionToolStripMenuItem.Text = "En &Posicion"
        '
        'BorrarToolStripMenuItem
        '
        Me.BorrarToolStripMenuItem.Name = "BorrarToolStripMenuItem"
        Me.BorrarToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.BorrarToolStripMenuItem.Text = "Borrar"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(106, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ImagenesToolStripMenuItem
        '
        Me.ImagenesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IcoToolStripMenuItem, Me.JpgToolStripMenuItem})
        Me.ImagenesToolStripMenuItem.Name = "ImagenesToolStripMenuItem"
        Me.ImagenesToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.ImagenesToolStripMenuItem.Text = "Imagenes"
        '
        'IcoToolStripMenuItem
        '
        Me.IcoToolStripMenuItem.Name = "IcoToolStripMenuItem"
        Me.IcoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.IcoToolStripMenuItem.Text = "*.ico"
        '
        'JpgToolStripMenuItem
        '
        Me.JpgToolStripMenuItem.Name = "JpgToolStripMenuItem"
        Me.JpgToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.JpgToolStripMenuItem.Text = "*.jpg"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'etHora
        '
        Me.etHora.AutoSize = True
        Me.etHora.Location = New System.Drawing.Point(396, 332)
        Me.etHora.Name = "etHora"
        Me.etHora.Size = New System.Drawing.Size(14, 13)
        Me.etHora.TabIndex = 3
        Me.etHora.Text = "X"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 362)
        Me.Controls.Add(Me.etHora)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lstImagenes)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstImagenes As System.Windows.Forms.ListBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ListaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AñadirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlfinalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnPosicionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BorrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImagenesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IcoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JpgToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents etHora As System.Windows.Forms.Label

End Class
