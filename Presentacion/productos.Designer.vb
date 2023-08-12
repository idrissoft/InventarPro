<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class productos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(productos))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.editar_productos = New System.Windows.Forms.Button()
        Me.eliminar_productos = New System.Windows.Forms.Button()
        Me.nuevo_productos = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DataGridView_prudoctos = New System.Windows.Forms.DataGridView()
        Me.cantidad = New System.Windows.Forms.TextBox()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Guardar_cambios = New System.Windows.Forms.Button()
        Me.Guardar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.precio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.nombre = New System.Windows.Forms.TextBox()
        Me.description = New System.Windows.Forms.TextBox()
        Me.id_productos = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.fechacreacion = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView_prudoctos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel11.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Panel1.Controls.Add(Me.editar_productos)
        Me.Panel1.Controls.Add(Me.eliminar_productos)
        Me.Panel1.Controls.Add(Me.nuevo_productos)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(215, 1088)
        Me.Panel1.TabIndex = 0
        '
        'editar_productos
        '
        Me.editar_productos.BackColor = System.Drawing.Color.Transparent
        Me.editar_productos.BackgroundImage = CType(resources.GetObject("editar_productos.BackgroundImage"), System.Drawing.Image)
        Me.editar_productos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.editar_productos.Dock = System.Windows.Forms.DockStyle.Top
        Me.editar_productos.FlatAppearance.BorderSize = 0
        Me.editar_productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.editar_productos.Location = New System.Drawing.Point(0, 173)
        Me.editar_productos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.editar_productos.Name = "editar_productos"
        Me.editar_productos.Size = New System.Drawing.Size(215, 64)
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
        Me.eliminar_productos.Location = New System.Drawing.Point(0, 108)
        Me.eliminar_productos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.eliminar_productos.Name = "eliminar_productos"
        Me.eliminar_productos.Size = New System.Drawing.Size(215, 65)
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
        Me.nuevo_productos.Location = New System.Drawing.Point(0, 48)
        Me.nuevo_productos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.nuevo_productos.Name = "nuevo_productos"
        Me.nuevo_productos.Size = New System.Drawing.Size(215, 60)
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
        Me.Panel4.Size = New System.Drawing.Size(215, 48)
        Me.Panel4.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(215, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1790, 85)
        Me.Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(707, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Productos"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.DataGridView_prudoctos)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(215, 85)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1790, 437)
        Me.Panel3.TabIndex = 2
        '
        'DataGridView_prudoctos
        '
        Me.DataGridView_prudoctos.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView_prudoctos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_prudoctos.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView_prudoctos.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView_prudoctos.Name = "DataGridView_prudoctos"
        Me.DataGridView_prudoctos.RowHeadersWidth = 51
        Me.DataGridView_prudoctos.Size = New System.Drawing.Size(1861, 427)
        Me.DataGridView_prudoctos.TabIndex = 0
        '
        'cantidad
        '
        Me.cantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cantidad.Location = New System.Drawing.Point(173, 116)
        Me.cantidad.Margin = New System.Windows.Forms.Padding(4)
        Me.cantidad.Name = "cantidad"
        Me.cantidad.Size = New System.Drawing.Size(107, 26)
        Me.cantidad.TabIndex = 0
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.Guardar_cambios)
        Me.Panel11.Controls.Add(Me.Guardar)
        Me.Panel11.Controls.Add(Me.Label5)
        Me.Panel11.Controls.Add(Me.Label7)
        Me.Panel11.Controls.Add(Me.Label4)
        Me.Panel11.Controls.Add(Me.cantidad)
        Me.Panel11.Controls.Add(Me.precio)
        Me.Panel11.Controls.Add(Me.Label3)
        Me.Panel11.Controls.Add(Me.Label8)
        Me.Panel11.Controls.Add(Me.nombre)
        Me.Panel11.Controls.Add(Me.description)
        Me.Panel11.Controls.Add(Me.id_productos)
        Me.Panel11.Controls.Add(Me.Label6)
        Me.Panel11.Controls.Add(Me.fechacreacion)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel11.Location = New System.Drawing.Point(215, 693)
        Me.Panel11.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(1790, 395)
        Me.Panel11.TabIndex = 4
        Me.Panel11.Visible = False
        '
        'Guardar_cambios
        '
        Me.Guardar_cambios.BackColor = System.Drawing.Color.Transparent
        Me.Guardar_cambios.BackgroundImage = CType(resources.GetObject("Guardar_cambios.BackgroundImage"), System.Drawing.Image)
        Me.Guardar_cambios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guardar_cambios.FlatAppearance.BorderSize = 0
        Me.Guardar_cambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Guardar_cambios.Location = New System.Drawing.Point(27, 316)
        Me.Guardar_cambios.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guardar_cambios.Name = "Guardar_cambios"
        Me.Guardar_cambios.Size = New System.Drawing.Size(177, 53)
        Me.Guardar_cambios.TabIndex = 3
        Me.Guardar_cambios.Text = "Guardar Cambios"
        Me.Guardar_cambios.UseVisualStyleBackColor = False
        '
        'Guardar
        '
        Me.Guardar.BackColor = System.Drawing.Color.Transparent
        Me.Guardar.BackgroundImage = CType(resources.GetObject("Guardar.BackgroundImage"), System.Drawing.Image)
        Me.Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guardar.FlatAppearance.BorderSize = 0
        Me.Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Guardar.Location = New System.Drawing.Point(27, 316)
        Me.Guardar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(177, 53)
        Me.Guardar.TabIndex = 2
        Me.Guardar.Text = "Guardar"
        Me.Guardar.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(36, 155)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 20)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Description:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(39, 212)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 20)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Precio:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(39, 116)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Cantidad:"
        '
        'precio
        '
        Me.precio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.precio.Location = New System.Drawing.Point(173, 208)
        Me.precio.Margin = New System.Windows.Forms.Padding(4)
        Me.precio.Name = "precio"
        Me.precio.Size = New System.Drawing.Size(173, 26)
        Me.precio.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(39, 74)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "nombre:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(39, 31)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 20)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "id_Productos:"
        '
        'nombre
        '
        Me.nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombre.Location = New System.Drawing.Point(173, 70)
        Me.nombre.Margin = New System.Windows.Forms.Padding(4)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(107, 26)
        Me.nombre.TabIndex = 0
        '
        'description
        '
        Me.description.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.description.Location = New System.Drawing.Point(173, 151)
        Me.description.Margin = New System.Windows.Forms.Padding(4)
        Me.description.Multiline = True
        Me.description.Name = "description"
        Me.description.Size = New System.Drawing.Size(173, 48)
        Me.description.TabIndex = 0
        '
        'id_productos
        '
        Me.id_productos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id_productos.Location = New System.Drawing.Point(173, 27)
        Me.id_productos.Margin = New System.Windows.Forms.Padding(4)
        Me.id_productos.Name = "id_productos"
        Me.id_productos.Size = New System.Drawing.Size(107, 26)
        Me.id_productos.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(23, 258)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 20)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "FechaCreacion:"
        '
        'fechacreacion
        '
        Me.fechacreacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fechacreacion.Location = New System.Drawing.Point(173, 255)
        Me.fechacreacion.Margin = New System.Windows.Forms.Padding(4)
        Me.fechacreacion.Name = "fechacreacion"
        Me.fechacreacion.Size = New System.Drawing.Size(173, 26)
        Me.fechacreacion.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 53)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1790, 32)
        Me.Panel5.TabIndex = 1
        '
        'productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2005, 1088)
        Me.Controls.Add(Me.Panel11)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "productos"
        Me.Text = "productos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.DataGridView_prudoctos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents nuevo_productos As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents editar_productos As Button
    Friend WithEvents eliminar_productos As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cantidad As TextBox
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents precio As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents nombre As TextBox
    Friend WithEvents description As TextBox
    Friend WithEvents id_productos As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents fechacreacion As TextBox
    Friend WithEvents Guardar As Button
    Friend WithEvents Guardar_cambios As Button
    Friend WithEvents DataGridView_prudoctos As DataGridView
    Friend WithEvents Panel5 As Panel
End Class
