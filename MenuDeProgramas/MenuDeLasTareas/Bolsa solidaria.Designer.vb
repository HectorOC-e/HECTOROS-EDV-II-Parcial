<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bolsa_solidaria
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtIdentidad = New System.Windows.Forms.TextBox()
        Me.txtDepartamento = New System.Windows.Forms.TextBox()
        Me.txtMunicipio = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtBolsa = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkPobrezaExtrema = New System.Windows.Forms.CheckBox()
        Me.chkPobreza = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIntegrantes = New System.Windows.Forms.MaskedTextBox()
        Me.txtNombreCompleto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSolicitar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ErrorValidacion = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.dtgReporte = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgReporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.Controls.Add(Me.txtIdentidad)
        Me.GroupBox1.Controls.Add(Me.txtDepartamento)
        Me.GroupBox1.Controls.Add(Me.txtMunicipio)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtBolsa)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.chkPobrezaExtrema)
        Me.GroupBox1.Controls.Add(Me.chkPobreza)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtIntegrantes)
        Me.GroupBox1.Controls.Add(Me.txtNombreCompleto)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnSolicitar)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Location = New System.Drawing.Point(32, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(454, 684)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informacion Beneficiario"
        '
        'txtIdentidad
        '
        Me.txtIdentidad.Location = New System.Drawing.Point(181, 45)
        Me.txtIdentidad.Name = "txtIdentidad"
        Me.txtIdentidad.Size = New System.Drawing.Size(155, 27)
        Me.txtIdentidad.TabIndex = 21
        '
        'txtDepartamento
        '
        Me.txtDepartamento.Location = New System.Drawing.Point(181, 147)
        Me.txtDepartamento.Name = "txtDepartamento"
        Me.txtDepartamento.Size = New System.Drawing.Size(155, 27)
        Me.txtDepartamento.TabIndex = 20
        '
        'txtMunicipio
        '
        Me.txtMunicipio.Location = New System.Drawing.Point(181, 206)
        Me.txtMunicipio.Name = "txtMunicipio"
        Me.txtMunicipio.Size = New System.Drawing.Size(155, 27)
        Me.txtMunicipio.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 213)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 20)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Municipio"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 156)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 20)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Departamento"
        '
        'txtBolsa
        '
        Me.txtBolsa.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtBolsa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBolsa.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtBolsa.ForeColor = System.Drawing.Color.Red
        Me.txtBolsa.Location = New System.Drawing.Point(79, 446)
        Me.txtBolsa.Name = "txtBolsa"
        Me.txtBolsa.ReadOnly = True
        Me.txtBolsa.Size = New System.Drawing.Size(164, 27)
        Me.txtBolsa.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(75, 410)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(168, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Bolsa a La Que Aplica"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(75, 322)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(160, 20)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Situación Financiera"
        '
        'chkPobrezaExtrema
        '
        Me.chkPobrezaExtrema.AutoSize = True
        Me.chkPobrezaExtrema.Location = New System.Drawing.Point(169, 365)
        Me.chkPobrezaExtrema.Name = "chkPobrezaExtrema"
        Me.chkPobrezaExtrema.Size = New System.Drawing.Size(152, 24)
        Me.chkPobrezaExtrema.TabIndex = 12
        Me.chkPobrezaExtrema.Text = "Pobreza extrema"
        Me.chkPobrezaExtrema.UseVisualStyleBackColor = True
        '
        'chkPobreza
        '
        Me.chkPobreza.AutoSize = True
        Me.chkPobreza.Location = New System.Drawing.Point(24, 365)
        Me.chkPobreza.Name = "chkPobreza"
        Me.chkPobreza.Size = New System.Drawing.Size(89, 24)
        Me.chkPobreza.TabIndex = 11
        Me.chkPobreza.Text = "Pobreza"
        Me.chkPobreza.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 274)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(189, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Integrantes De la familia"
        '
        'txtIntegrantes
        '
        Me.txtIntegrantes.Location = New System.Drawing.Point(290, 267)
        Me.txtIntegrantes.Mask = "99"
        Me.txtIntegrantes.Name = "txtIntegrantes"
        Me.txtIntegrantes.Size = New System.Drawing.Size(46, 27)
        Me.txtIntegrantes.TabIndex = 9
        '
        'txtNombreCompleto
        '
        Me.txtNombreCompleto.Location = New System.Drawing.Point(181, 93)
        Me.txtNombreCompleto.Name = "txtNombreCompleto"
        Me.txtNombreCompleto.Size = New System.Drawing.Size(155, 27)
        Me.txtNombreCompleto.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nombre Completo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Numero de DNI"
        '
        'btnSolicitar
        '
        Me.btnSolicitar.FlatAppearance.BorderColor = System.Drawing.Color.Aqua
        Me.btnSolicitar.FlatAppearance.BorderSize = 2
        Me.btnSolicitar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.btnSolicitar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.btnSolicitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSolicitar.Location = New System.Drawing.Point(101, 506)
        Me.btnSolicitar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSolicitar.Name = "btnSolicitar"
        Me.btnSolicitar.Size = New System.Drawing.Size(108, 38)
        Me.btnSolicitar.TabIndex = 4
        Me.btnSolicitar.Text = "Solicitar"
        Me.btnSolicitar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.AutoSize = True
        Me.GroupBox2.Controls.Add(Me.dtgReporte)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox2.Location = New System.Drawing.Point(520, 23)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(498, 684)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Reporte"
        '
        'ErrorValidacion
        '
        Me.ErrorValidacion.ContainerControl = Me
        '
        'dtgReporte
        '
        Me.dtgReporte.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dtgReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgReporte.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.dtgReporte.GridColor = System.Drawing.Color.Black
        Me.dtgReporte.Location = New System.Drawing.Point(16, 61)
        Me.dtgReporte.Name = "dtgReporte"
        Me.dtgReporte.ReadOnly = True
        Me.dtgReporte.RowHeadersWidth = 51
        Me.dtgReporte.RowTemplate.Height = 24
        Me.dtgReporte.Size = New System.Drawing.Size(460, 559)
        Me.dtgReporte.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Identidad"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nombre"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "Departamento"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "Municipio"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 125
        '
        'Column5
        '
        Me.Column5.HeaderText = "Integrantes"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 125
        '
        'Column6
        '
        Me.Column6.HeaderText = "Situacion "
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 125
        '
        'Column7
        '
        Me.Column7.HeaderText = "Bolsa"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 125
        '
        'Column8
        '
        Me.Column8.HeaderText = "Contenido Bolsa"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 125
        '
        'Bolsa_solidaria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1030, 734)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Bolsa_solidaria"
        Me.Text = "Bolsa_solidaria"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgReporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtMunicipio As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtBolsa As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents chkPobrezaExtrema As CheckBox
    Friend WithEvents chkPobreza As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtIntegrantes As MaskedTextBox
    Friend WithEvents txtNombreCompleto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSolicitar As Button
    Friend WithEvents txtDepartamento As TextBox
    Friend WithEvents txtIdentidad As TextBox
    Friend WithEvents ErrorValidacion As ErrorProvider
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents dtgReporte As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
End Class
