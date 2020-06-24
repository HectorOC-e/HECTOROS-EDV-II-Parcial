<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Libretadeahorros_EJclase3
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAperturar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnRetirar = New System.Windows.Forms.Button()
        Me.btnDepositar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstRetiros = New System.Windows.Forms.ListBox()
        Me.lstDepositos = New System.Windows.Forms.ListBox()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.Controls.Add(Me.btnIngresar)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btnAperturar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(25, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(807, 151)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso De Información"
        '
        'btnAperturar
        '
        Me.btnAperturar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAperturar.FlatAppearance.BorderColor = System.Drawing.Color.Aqua
        Me.btnAperturar.FlatAppearance.BorderSize = 2
        Me.btnAperturar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Aqua
        Me.btnAperturar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.btnAperturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAperturar.Location = New System.Drawing.Point(96, 88)
        Me.btnAperturar.Name = "btnAperturar"
        Me.btnAperturar.Size = New System.Drawing.Size(106, 36)
        Me.btnAperturar.TabIndex = 5
        Me.btnAperturar.Text = "Aperturar"
        Me.btnAperturar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(75, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Datos de Usuario"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.AutoSize = True
        Me.GroupBox2.Controls.Add(Me.btnRetirar)
        Me.GroupBox2.Controls.Add(Me.btnDepositar)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(25, 182)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(807, 134)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Operaciones"
        '
        'btnRetirar
        '
        Me.btnRetirar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.btnRetirar.FlatAppearance.BorderColor = System.Drawing.Color.Aqua
        Me.btnRetirar.FlatAppearance.BorderSize = 2
        Me.btnRetirar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Aqua
        Me.btnRetirar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.btnRetirar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRetirar.Location = New System.Drawing.Point(488, 43)
        Me.btnRetirar.Name = "btnRetirar"
        Me.btnRetirar.Size = New System.Drawing.Size(139, 53)
        Me.btnRetirar.TabIndex = 7
        Me.btnRetirar.Text = "Retirar"
        Me.btnRetirar.UseVisualStyleBackColor = True
        '
        'btnDepositar
        '
        Me.btnDepositar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.btnDepositar.FlatAppearance.BorderColor = System.Drawing.Color.Aqua
        Me.btnDepositar.FlatAppearance.BorderSize = 2
        Me.btnDepositar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Aqua
        Me.btnDepositar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.btnDepositar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDepositar.Location = New System.Drawing.Point(214, 43)
        Me.btnDepositar.Name = "btnDepositar"
        Me.btnDepositar.Size = New System.Drawing.Size(139, 53)
        Me.btnDepositar.TabIndex = 6
        Me.btnDepositar.Text = "Depositar"
        Me.btnDepositar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.AutoSize = True
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.btnLimpiar)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.lstRetiros)
        Me.GroupBox3.Controls.Add(Me.lstDepositos)
        Me.GroupBox3.Controls.Add(Me.txtSaldo)
        Me.GroupBox3.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox3.Location = New System.Drawing.Point(25, 344)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(807, 286)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Historial"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(653, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Saldo Total"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Aqua
        Me.btnLimpiar.FlatAppearance.BorderSize = 2
        Me.btnLimpiar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Aqua
        Me.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Location = New System.Drawing.Point(656, 220)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(94, 39)
        Me.btnLimpiar.TabIndex = 6
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(333, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 21)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Retiros"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(57, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Depositos"
        '
        'lstRetiros
        '
        Me.lstRetiros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstRetiros.FormattingEnabled = True
        Me.lstRetiros.ItemHeight = 20
        Me.lstRetiros.Location = New System.Drawing.Point(335, 51)
        Me.lstRetiros.Name = "lstRetiros"
        Me.lstRetiros.Size = New System.Drawing.Size(221, 204)
        Me.lstRetiros.TabIndex = 4
        '
        'lstDepositos
        '
        Me.lstDepositos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstDepositos.FormattingEnabled = True
        Me.lstDepositos.ItemHeight = 20
        Me.lstDepositos.Location = New System.Drawing.Point(60, 51)
        Me.lstDepositos.Name = "lstDepositos"
        Me.lstDepositos.Size = New System.Drawing.Size(221, 204)
        Me.lstDepositos.TabIndex = 3
        '
        'txtSaldo
        '
        Me.txtSaldo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.txtSaldo.Location = New System.Drawing.Point(616, 162)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(165, 28)
        Me.txtSaldo.TabIndex = 2
        '
        'btnIngresar
        '
        Me.btnIngresar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnIngresar.FlatAppearance.BorderColor = System.Drawing.Color.Aqua
        Me.btnIngresar.FlatAppearance.BorderSize = 2
        Me.btnIngresar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Aqua
        Me.btnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIngresar.Location = New System.Drawing.Point(562, 88)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(106, 36)
        Me.btnIngresar.TabIndex = 7
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(541, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(157, 21)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Ingresar al usuario"
        '
        'Libretadeahorros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(867, 653)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Libretadeahorros"
        Me.Text = "Libretadeahorros"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lstRetiros As ListBox
    Friend WithEvents lstDepositos As ListBox
    Friend WithEvents txtSaldo As TextBox
    Friend WithEvents btnAperturar As Button
    Friend WithEvents btnRetirar As Button
    Friend WithEvents btnDepositar As Button
    Friend WithEvents btnIngresar As Button
    Friend WithEvents Label6 As Label
End Class
