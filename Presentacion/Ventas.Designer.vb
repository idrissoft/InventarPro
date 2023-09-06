<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ventas))
        Me.ListBox = New System.Windows.Forms.ListBox()
        Me.Fecha = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox_clientes = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.agregar_venta = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView_ventas = New System.Windows.Forms.DataGridView()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Txt_stock_acual = New System.Windows.Forms.TextBox()
        Me.Txt_id_productos = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_PrecioUnitario = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Btn_crear_venta = New System.Windows.Forms.Button()
        Me.Combo_productos = New System.Windows.Forms.ComboBox()
        Me.Txt_telefono = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Txt_direccion = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Txt_cliente = New System.Windows.Forms.TextBox()
        Me.txtcantidad = New System.Windows.Forms.NumericUpDown()
        Me.Txt_precio_total = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.DataGridView_Detalle_Venta = New System.Windows.Forms.DataGridView()
        CType(Me.agregar_venta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView_ventas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView_Detalle_Venta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox
        '
        Me.ListBox.ForeColor = System.Drawing.SystemColors.MenuText
        Me.ListBox.FormattingEnabled = True
        Me.ListBox.Location = New System.Drawing.Point(34, 51)
        Me.ListBox.Name = "ListBox"
        Me.ListBox.Size = New System.Drawing.Size(602, 160)
        Me.ListBox.TabIndex = 0
        '
        'Fecha
        '
        Me.Fecha.AutoSize = True
        Me.Fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Fecha.Location = New System.Drawing.Point(42, 77)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(44, 15)
        Me.Fecha.TabIndex = 2
        Me.Fecha.Text = "Fecha:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(111, 77)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(341, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Description:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(410, 80)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(183, 34)
        Me.TextBox1.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label4.Location = New System.Drawing.Point(936, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "ID_Cliente"
        '
        'ComboBox_clientes
        '
        Me.ComboBox_clientes.FormattingEnabled = True
        Me.ComboBox_clientes.Location = New System.Drawing.Point(788, 94)
        Me.ComboBox_clientes.Name = "ComboBox_clientes"
        Me.ComboBox_clientes.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_clientes.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label5.Location = New System.Drawing.Point(692, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Cliente:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label8.Location = New System.Drawing.Point(309, 325)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 13)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Cantidad de Venta:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label9.Location = New System.Drawing.Point(59, 323)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Stock:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label10.Location = New System.Drawing.Point(309, 268)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Producto:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label11.Location = New System.Drawing.Point(59, 266)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 15)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Code producto:"
        '
        'ListBox1
        '
        Me.ListBox1.ForeColor = System.Drawing.SystemColors.MenuText
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(34, 250)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(1142, 186)
        Me.ListBox1.TabIndex = 19
        '
        'agregar_venta
        '
        Me.agregar_venta.BackgroundImage = CType(resources.GetObject("agregar_venta.BackgroundImage"), System.Drawing.Image)
        Me.agregar_venta.Image = CType(resources.GetObject("agregar_venta.Image"), System.Drawing.Image)
        Me.agregar_venta.Location = New System.Drawing.Point(467, 321)
        Me.agregar_venta.Name = "agregar_venta"
        Me.agregar_venta.Size = New System.Drawing.Size(25, 23)
        Me.agregar_venta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.agregar_venta.TabIndex = 28
        Me.agregar_venta.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridView_ventas)
        Me.Panel1.Location = New System.Drawing.Point(34, 463)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1142, 258)
        Me.Panel1.TabIndex = 29
        '
        'DataGridView_ventas
        '
        Me.DataGridView_ventas.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.DataGridView_ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_ventas.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView_ventas.Name = "DataGridView_ventas"
        Me.DataGridView_ventas.Size = New System.Drawing.Size(1139, 255)
        Me.DataGridView_ventas.TabIndex = 0
        '
        'ListBox2
        '
        Me.ListBox2.ForeColor = System.Drawing.SystemColors.MenuText
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(677, 51)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(602, 160)
        Me.ListBox2.TabIndex = 10
        '
        'Txt_stock_acual
        '
        Me.Txt_stock_acual.Location = New System.Drawing.Point(164, 316)
        Me.Txt_stock_acual.Name = "Txt_stock_acual"
        Me.Txt_stock_acual.Size = New System.Drawing.Size(122, 20)
        Me.Txt_stock_acual.TabIndex = 30
        '
        'Txt_id_productos
        '
        Me.Txt_id_productos.Location = New System.Drawing.Point(164, 266)
        Me.Txt_id_productos.Name = "Txt_id_productos"
        Me.Txt_id_productos.Size = New System.Drawing.Size(122, 20)
        Me.Txt_id_productos.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(553, 268)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Precio:"
        '
        'Txt_PrecioUnitario
        '
        Me.Txt_PrecioUnitario.Location = New System.Drawing.Point(611, 266)
        Me.Txt_PrecioUnitario.Name = "Txt_PrecioUnitario"
        Me.Txt_PrecioUnitario.Size = New System.Drawing.Size(100, 20)
        Me.Txt_PrecioUnitario.TabIndex = 33
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(906, 263)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(200, 168)
        Me.PictureBox2.TabIndex = 34
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Informacio de venta"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(674, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Informacio de Cliente"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(31, 234)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 13)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Informacio de Productos"
        '
        'Btn_crear_venta
        '
        Me.Btn_crear_venta.Location = New System.Drawing.Point(1193, 682)
        Me.Btn_crear_venta.Name = "Btn_crear_venta"
        Me.Btn_crear_venta.Size = New System.Drawing.Size(103, 36)
        Me.Btn_crear_venta.TabIndex = 38
        Me.Btn_crear_venta.Text = "Crear Venta"
        Me.Btn_crear_venta.UseVisualStyleBackColor = True
        '
        'Combo_productos
        '
        Me.Combo_productos.FormattingEnabled = True
        Me.Combo_productos.Location = New System.Drawing.Point(405, 266)
        Me.Combo_productos.Name = "Combo_productos"
        Me.Combo_productos.Size = New System.Drawing.Size(121, 21)
        Me.Combo_productos.TabIndex = 39
        '
        'Txt_telefono
        '
        Me.Txt_telefono.Location = New System.Drawing.Point(788, 144)
        Me.Txt_telefono.Name = "Txt_telefono"
        Me.Txt_telefono.Size = New System.Drawing.Size(122, 20)
        Me.Txt_telefono.TabIndex = 41
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label12.Location = New System.Drawing.Point(692, 144)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 15)
        Me.Label12.TabIndex = 40
        Me.Label12.Text = "Telefono:"
        '
        'Txt_direccion
        '
        Me.Txt_direccion.Location = New System.Drawing.Point(1041, 144)
        Me.Txt_direccion.Name = "Txt_direccion"
        Me.Txt_direccion.Size = New System.Drawing.Size(122, 20)
        Me.Txt_direccion.TabIndex = 43
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label13.Location = New System.Drawing.Point(936, 144)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 15)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "Direccion:"
        '
        'Txt_cliente
        '
        Me.Txt_cliente.Location = New System.Drawing.Point(1041, 94)
        Me.Txt_cliente.Name = "Txt_cliente"
        Me.Txt_cliente.Size = New System.Drawing.Size(122, 20)
        Me.Txt_cliente.TabIndex = 44
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(422, 321)
        Me.txtcantidad.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.txtcantidad.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(39, 20)
        Me.txtcantidad.TabIndex = 45
        Me.txtcantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Txt_precio_total
        '
        Me.Txt_precio_total.Location = New System.Drawing.Point(611, 325)
        Me.Txt_precio_total.Name = "Txt_precio_total"
        Me.Txt_precio_total.Size = New System.Drawing.Size(100, 20)
        Me.Txt_precio_total.TabIndex = 47
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label14.Location = New System.Drawing.Point(538, 328)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 13)
        Me.Label14.TabIndex = 46
        Me.Label14.Text = "Precio Total:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(31, 735)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(86, 13)
        Me.Label15.TabIndex = 48
        Me.Label15.Text = "Detalle de Venta"
        '
        'DataGridView_Detalle_Venta
        '
        Me.DataGridView_Detalle_Venta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Detalle_Venta.Location = New System.Drawing.Point(34, 767)
        Me.DataGridView_Detalle_Venta.Name = "DataGridView_Detalle_Venta"
        Me.DataGridView_Detalle_Venta.Size = New System.Drawing.Size(1142, 165)
        Me.DataGridView_Detalle_Venta.TabIndex = 49
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1368, 1014)
        Me.Controls.Add(Me.DataGridView_Detalle_Venta)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Txt_precio_total)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtcantidad)
        Me.Controls.Add(Me.Txt_cliente)
        Me.Controls.Add(Me.Txt_direccion)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Txt_telefono)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Combo_productos)
        Me.Controls.Add(Me.Btn_crear_venta)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Txt_PrecioUnitario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txt_id_productos)
        Me.Controls.Add(Me.Txt_stock_acual)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.agregar_venta)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBox_clientes)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Fecha)
        Me.Controls.Add(Me.ListBox)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Ventas"
        Me.Text = "Ventas"
        CType(Me.agregar_venta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView_ventas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView_Detalle_Venta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox As ListBox
    Friend WithEvents Fecha As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox_clientes As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents agregar_venta As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Txt_stock_acual As TextBox
    Friend WithEvents Txt_id_productos As TextBox
    Friend WithEvents DataGridView_ventas As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_PrecioUnitario As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Btn_crear_venta As Button
    Friend WithEvents Combo_productos As ComboBox
    Friend WithEvents Txt_telefono As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Txt_direccion As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Txt_cliente As TextBox
    Friend WithEvents txtcantidad As NumericUpDown
    Friend WithEvents Txt_precio_total As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents DataGridView_Detalle_Venta As DataGridView
End Class
