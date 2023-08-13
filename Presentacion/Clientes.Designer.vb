<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clientes))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView_clientes = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.editar_productos = New System.Windows.Forms.Button()
        Me.eliminar_productos = New System.Windows.Forms.Button()
        Me.nuevo_productos = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Buscar = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridView_clientes)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(2160, 1202)
        Me.Panel1.TabIndex = 0
        '
        'DataGridView_clientes
        '
        Me.DataGridView_clientes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_clientes.Location = New System.Drawing.Point(147, 88)
        Me.DataGridView_clientes.Name = "DataGridView_clientes"
        Me.DataGridView_clientes.RowHeadersWidth = 51
        Me.DataGridView_clientes.RowTemplate.Height = 24
        Me.DataGridView_clientes.Size = New System.Drawing.Size(2010, 426)
        Me.DataGridView_clientes.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Panel2.Controls.Add(Me.editar_productos)
        Me.Panel2.Controls.Add(Me.eliminar_productos)
        Me.Panel2.Controls.Add(Me.nuevo_productos)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(150, 1202)
        Me.Panel2.TabIndex = 2
        '
        'editar_productos
        '
        Me.editar_productos.BackColor = System.Drawing.Color.Transparent
        Me.editar_productos.BackgroundImage = CType(resources.GetObject("editar_productos.BackgroundImage"), System.Drawing.Image)
        Me.editar_productos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.editar_productos.Dock = System.Windows.Forms.DockStyle.Top
        Me.editar_productos.FlatAppearance.BorderSize = 0
        Me.editar_productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.editar_productos.Location = New System.Drawing.Point(0, 213)
        Me.editar_productos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.editar_productos.Name = "editar_productos"
        Me.editar_productos.Size = New System.Drawing.Size(150, 64)
        Me.editar_productos.TabIndex = 3
        Me.editar_productos.Text = "Modificar Producto"
        Me.editar_productos.UseVisualStyleBackColor = False
        '
        'eliminar_productos
        '
        Me.eliminar_productos.BackColor = System.Drawing.Color.Transparent
        Me.eliminar_productos.BackgroundImage = CType(resources.GetObject("eliminar_productos.BackgroundImage"), System.Drawing.Image)
        Me.eliminar_productos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.eliminar_productos.Dock = System.Windows.Forms.DockStyle.Top
        Me.eliminar_productos.FlatAppearance.BorderSize = 0
        Me.eliminar_productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.eliminar_productos.Location = New System.Drawing.Point(0, 148)
        Me.eliminar_productos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.eliminar_productos.Name = "eliminar_productos"
        Me.eliminar_productos.Size = New System.Drawing.Size(150, 65)
        Me.eliminar_productos.TabIndex = 2
        Me.eliminar_productos.Text = "Eliminar Prudocto"
        Me.eliminar_productos.UseVisualStyleBackColor = False
        '
        'nuevo_productos
        '
        Me.nuevo_productos.BackColor = System.Drawing.Color.Transparent
        Me.nuevo_productos.BackgroundImage = CType(resources.GetObject("nuevo_productos.BackgroundImage"), System.Drawing.Image)
        Me.nuevo_productos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.nuevo_productos.Dock = System.Windows.Forms.DockStyle.Top
        Me.nuevo_productos.FlatAppearance.BorderSize = 0
        Me.nuevo_productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nuevo_productos.Location = New System.Drawing.Point(0, 88)
        Me.nuevo_productos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.nuevo_productos.Name = "nuevo_productos"
        Me.nuevo_productos.Size = New System.Drawing.Size(150, 60)
        Me.nuevo_productos.TabIndex = 1
        Me.nuevo_productos.Text = "Nuevo Prudocto"
        Me.nuevo_productos.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(150, 88)
        Me.Panel4.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Location = New System.Drawing.Point(116, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(2044, 88)
        Me.Panel3.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(756, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Clientes"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Buscar)
        Me.Panel5.Controls.Add(Me.PictureBox1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 56)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(2044, 32)
        Me.Panel5.TabIndex = 1
        '
        'Buscar
        '
        Me.Buscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Buscar.Location = New System.Drawing.Point(624, 3)
        Me.Buscar.Multiline = True
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(746, 29)
        Me.Buscar.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(578, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(400, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2160, 1202)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Clientes"
        Me.Text = "Clietes"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents editar_productos As Button
    Friend WithEvents eliminar_productos As Button
    Friend WithEvents nuevo_productos As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Buscar As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridView_clientes As DataGridView
    Friend WithEvents Label1 As Label
End Class
