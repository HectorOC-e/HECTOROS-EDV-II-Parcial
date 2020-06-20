<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Arreglos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbPrecios = New System.Windows.Forms.ComboBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.cmbComputadoras = New System.Windows.Forms.ComboBox()
        Me.btnGenerarPrecio = New System.Windows.Forms.Button()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbCompus = New System.Windows.Forms.ComboBox()
        Me.btnSolicitar = New System.Windows.Forms.Button()
        Me.txtCant = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnRegistro = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCantComp = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnVender = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCantVender = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cmbPrecios)
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.cmbComputadoras)
        Me.GroupBox1.Controls.Add(Me.btnGenerarPrecio)
        Me.GroupBox1.Controls.Add(Me.btnGenerar)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(44, 29)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(354, 312)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ArregloUnidimensionales"
        '
        'cmbPrecios
        '
        Me.cmbPrecios.FormattingEnabled = True
        Me.cmbPrecios.Location = New System.Drawing.Point(77, 218)
        Me.cmbPrecios.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbPrecios.Name = "cmbPrecios"
        Me.cmbPrecios.Size = New System.Drawing.Size(223, 23)
        Me.cmbPrecios.TabIndex = 3
        '
        'btnLimpiar
        '
        Me.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Aqua
        Me.btnLimpiar.FlatAppearance.BorderSize = 2
        Me.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnLimpiar.Location = New System.Drawing.Point(77, 249)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(127, 40)
        Me.btnLimpiar.TabIndex = 5
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'cmbComputadoras
        '
        Me.cmbComputadoras.FormattingEnabled = True
        Me.cmbComputadoras.Location = New System.Drawing.Point(77, 132)
        Me.cmbComputadoras.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbComputadoras.Name = "cmbComputadoras"
        Me.cmbComputadoras.Size = New System.Drawing.Size(223, 23)
        Me.cmbComputadoras.TabIndex = 2
        '
        'btnGenerarPrecio
        '
        Me.btnGenerarPrecio.FlatAppearance.BorderColor = System.Drawing.Color.Aqua
        Me.btnGenerarPrecio.FlatAppearance.BorderSize = 2
        Me.btnGenerarPrecio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.btnGenerarPrecio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.btnGenerarPrecio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerarPrecio.Location = New System.Drawing.Point(77, 163)
        Me.btnGenerarPrecio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnGenerarPrecio.Name = "btnGenerarPrecio"
        Me.btnGenerarPrecio.Size = New System.Drawing.Size(151, 46)
        Me.btnGenerarPrecio.TabIndex = 1
        Me.btnGenerarPrecio.Text = "Agregar Precio"
        Me.btnGenerarPrecio.UseVisualStyleBackColor = True
        '
        'btnGenerar
        '
        Me.btnGenerar.FlatAppearance.BorderColor = System.Drawing.Color.Aqua
        Me.btnGenerar.FlatAppearance.BorderSize = 2
        Me.btnGenerar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.btnGenerar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerar.Location = New System.Drawing.Point(77, 77)
        Me.btnGenerar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(223, 47)
        Me.btnGenerar.TabIndex = 0
        Me.btnGenerar.Text = "Agregar Ordenadores"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.cmbCompus)
        Me.GroupBox2.Controls.Add(Me.btnSolicitar)
        Me.GroupBox2.Controls.Add(Me.txtCant)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(44, 372)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(354, 166)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dinamico"
        '
        'cmbCompus
        '
        Me.cmbCompus.FormattingEnabled = True
        Me.cmbCompus.Location = New System.Drawing.Point(90, 108)
        Me.cmbCompus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbCompus.Name = "cmbCompus"
        Me.cmbCompus.Size = New System.Drawing.Size(173, 23)
        Me.cmbCompus.TabIndex = 4
        '
        'btnSolicitar
        '
        Me.btnSolicitar.FlatAppearance.BorderColor = System.Drawing.Color.Aqua
        Me.btnSolicitar.FlatAppearance.BorderSize = 2
        Me.btnSolicitar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.btnSolicitar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.btnSolicitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSolicitar.Location = New System.Drawing.Point(119, 62)
        Me.btnSolicitar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSolicitar.Name = "btnSolicitar"
        Me.btnSolicitar.Size = New System.Drawing.Size(128, 38)
        Me.btnSolicitar.TabIndex = 3
        Me.btnSolicitar.Text = "Solicitar"
        Me.btnSolicitar.UseVisualStyleBackColor = True
        '
        'txtCant
        '
        Me.txtCant.Location = New System.Drawing.Point(90, 32)
        Me.txtCant.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCant.Name = "txtCant"
        Me.txtCant.Size = New System.Drawing.Size(173, 22)
        Me.txtCant.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.MenuDeLasTareas.My.Resources.Resources.foreclosure_96px
        Me.PictureBox1.Location = New System.Drawing.Point(444, 311)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(71, 59)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.btnRegistro)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txtCantComp)
        Me.GroupBox3.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox3.Location = New System.Drawing.Point(478, 29)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(369, 137)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Registro"
        '
        'btnRegistro
        '
        Me.btnRegistro.FlatAppearance.BorderColor = System.Drawing.Color.Aqua
        Me.btnRegistro.FlatAppearance.BorderSize = 2
        Me.btnRegistro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.btnRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.btnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistro.Location = New System.Drawing.Point(242, 86)
        Me.btnRegistro.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRegistro.Name = "btnRegistro"
        Me.btnRegistro.Size = New System.Drawing.Size(93, 32)
        Me.btnRegistro.TabIndex = 5
        Me.btnRegistro.Text = "Registrar"
        Me.btnRegistro.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 52)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cantidad de computadoras"
        '
        'txtCantComp
        '
        Me.txtCantComp.Location = New System.Drawing.Point(188, 46)
        Me.txtCantComp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCantComp.Mask = "99"
        Me.txtCantComp.Name = "txtCantComp"
        Me.txtCantComp.Size = New System.Drawing.Size(147, 22)
        Me.txtCantComp.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.GroupBox4.Controls.Add(Me.btnBuscar)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.txtCantidad)
        Me.GroupBox4.Controls.Add(Me.txtPrecio)
        Me.GroupBox4.Controls.Add(Me.txtModelo)
        Me.GroupBox4.Controls.Add(Me.txtMarca)
        Me.GroupBox4.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox4.Location = New System.Drawing.Point(533, 175)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Size = New System.Drawing.Size(311, 300)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Busqueda"
        '
        'btnBuscar
        '
        Me.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Aqua
        Me.btnBuscar.FlatAppearance.BorderSize = 2
        Me.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Location = New System.Drawing.Point(175, 263)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(99, 29)
        Me.btnBuscar.TabIndex = 6
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 223)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Cantidad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 167)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Precio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 111)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Modelo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 41)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Marca"
        '
        'txtCantidad
        '
        Me.txtCantidad.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Location = New System.Drawing.Point(137, 217)
        Me.txtCantidad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(137, 22)
        Me.txtCantidad.TabIndex = 3
        '
        'txtPrecio
        '
        Me.txtPrecio.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio.Location = New System.Drawing.Point(137, 161)
        Me.txtPrecio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(137, 22)
        Me.txtPrecio.TabIndex = 2
        '
        'txtModelo
        '
        Me.txtModelo.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModelo.Location = New System.Drawing.Point(137, 104)
        Me.txtModelo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(137, 22)
        Me.txtModelo.TabIndex = 1
        '
        'txtMarca
        '
        Me.txtMarca.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarca.Location = New System.Drawing.Point(137, 41)
        Me.txtMarca.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(137, 22)
        Me.txtMarca.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.btnVender)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.txtCantVender)
        Me.GroupBox5.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox5.Location = New System.Drawing.Point(474, 483)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox5.Size = New System.Drawing.Size(370, 111)
        Me.GroupBox5.TabIndex = 9
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Vender"
        '
        'btnVender
        '
        Me.btnVender.FlatAppearance.BorderColor = System.Drawing.Color.Aqua
        Me.btnVender.FlatAppearance.BorderSize = 2
        Me.btnVender.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.btnVender.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.btnVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVender.Location = New System.Drawing.Point(246, 71)
        Me.btnVender.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnVender.Name = "btnVender"
        Me.btnVender.Size = New System.Drawing.Size(84, 32)
        Me.btnVender.TabIndex = 7
        Me.btnVender.Text = "Vender"
        Me.btnVender.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 42)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 16)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Cantidad"
        '
        'txtCantVender
        '
        Me.txtCantVender.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.txtCantVender.Location = New System.Drawing.Point(117, 38)
        Me.txtCantVender.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCantVender.Name = "txtCantVender"
        Me.txtCantVender.Size = New System.Drawing.Size(213, 23)
        Me.txtCantVender.TabIndex = 7
        '
        'Arreglos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(867, 653)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Arreglos"
        Me.Text = "Arreglos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmbPrecios As ComboBox
    Friend WithEvents cmbComputadoras As ComboBox
    Friend WithEvents btnGenerarPrecio As Button
    Friend WithEvents btnGenerar As Button
    Friend WithEvents btnSolicitar As Button
    Friend WithEvents txtCant As TextBox
    Friend WithEvents cmbCompus As ComboBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtCantComp As MaskedTextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnRegistro As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btnVender As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCantVender As TextBox
End Class
