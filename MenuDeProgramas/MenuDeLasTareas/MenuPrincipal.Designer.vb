<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipal
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
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPrincipal))
        Dim Animation2 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Me.MenuTop = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SidebarWrapper = New System.Windows.Forms.Panel()
        Me.Wrapper = New System.Windows.Forms.Panel()
        Me.CurvaSidebar = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.AnimacionSidebar = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.AnimacionSidebarBack = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.Sidebar = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BunifuFlatButton2 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnEjercicio1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lineasidebar = New Bunifu.Framework.UI.BunifuSeparator()
        Me.btnRestaurar = New System.Windows.Forms.Button()
        Me.btnMaximizar = New System.Windows.Forms.Button()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnmenu = New System.Windows.Forms.PictureBox()
        Me.MenuTop.SuspendLayout()
        Me.SidebarWrapper.SuspendLayout()
        Me.Sidebar.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnmenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuTop
        '
        Me.MenuTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.MenuTop.Controls.Add(Me.btnRestaurar)
        Me.MenuTop.Controls.Add(Me.btnMaximizar)
        Me.MenuTop.Controls.Add(Me.btnMinimizar)
        Me.MenuTop.Controls.Add(Me.btnSalir)
        Me.MenuTop.Controls.Add(Me.Label1)
        Me.MenuTop.Controls.Add(Me.btnmenu)
        Me.AnimacionSidebarBack.SetDecoration(Me.MenuTop, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionSidebar.SetDecoration(Me.MenuTop, BunifuAnimatorNS.DecorationType.None)
        Me.MenuTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.MenuTop.Location = New System.Drawing.Point(0, 0)
        Me.MenuTop.Name = "MenuTop"
        Me.MenuTop.Size = New System.Drawing.Size(1867, 80)
        Me.MenuTop.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.AnimacionSidebar.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionSidebarBack.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Imprint MT Shadow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(53, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Menu Principal"
        '
        'SidebarWrapper
        '
        Me.SidebarWrapper.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.SidebarWrapper.Controls.Add(Me.Sidebar)
        Me.AnimacionSidebarBack.SetDecoration(Me.SidebarWrapper, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionSidebar.SetDecoration(Me.SidebarWrapper, BunifuAnimatorNS.DecorationType.None)
        Me.SidebarWrapper.Dock = System.Windows.Forms.DockStyle.Left
        Me.SidebarWrapper.Location = New System.Drawing.Point(0, 80)
        Me.SidebarWrapper.Name = "SidebarWrapper"
        Me.SidebarWrapper.Size = New System.Drawing.Size(400, 1022)
        Me.SidebarWrapper.TabIndex = 1
        '
        'Wrapper
        '
        Me.Wrapper.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.AnimacionSidebarBack.SetDecoration(Me.Wrapper, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionSidebar.SetDecoration(Me.Wrapper, BunifuAnimatorNS.DecorationType.None)
        Me.Wrapper.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Wrapper.Location = New System.Drawing.Point(400, 80)
        Me.Wrapper.Name = "Wrapper"
        Me.Wrapper.Size = New System.Drawing.Size(1467, 1022)
        Me.Wrapper.TabIndex = 1
        '
        'CurvaSidebar
        '
        Me.CurvaSidebar.ElipseRadius = 7
        Me.CurvaSidebar.TargetControl = Me.Sidebar
        '
        'AnimacionSidebar
        '
        Me.AnimacionSidebar.AnimationType = BunifuAnimatorNS.AnimationType.Particles
        Me.AnimacionSidebar.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 1
        Animation1.Padding = New System.Windows.Forms.Padding(100, 50, 100, 150)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 2.0!
        Animation1.TransparencyCoeff = 0!
        Me.AnimacionSidebar.DefaultAnimation = Animation1
        '
        'AnimacionSidebarBack
        '
        Me.AnimacionSidebarBack.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide
        Me.AnimacionSidebarBack.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 0
        Animation2.Padding = New System.Windows.Forms.Padding(0)
        Animation2.RotateCoeff = 0!
        Animation2.RotateLimit = 0!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0!
        Animation2.TransparencyCoeff = 0!
        Me.AnimacionSidebarBack.DefaultAnimation = Animation2
        '
        'Sidebar
        '
        Me.Sidebar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Sidebar.BackgroundImage = CType(resources.GetObject("Sidebar.BackgroundImage"), System.Drawing.Image)
        Me.Sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Sidebar.Controls.Add(Me.BunifuFlatButton2)
        Me.Sidebar.Controls.Add(Me.BtnEjercicio1)
        Me.Sidebar.Controls.Add(Me.Label2)
        Me.Sidebar.Controls.Add(Me.PictureBox2)
        Me.Sidebar.Controls.Add(Me.lineasidebar)
        Me.AnimacionSidebarBack.SetDecoration(Me.Sidebar, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionSidebar.SetDecoration(Me.Sidebar, BunifuAnimatorNS.DecorationType.None)
        Me.Sidebar.GradientBottomLeft = System.Drawing.Color.DarkBlue
        Me.Sidebar.GradientBottomRight = System.Drawing.Color.Indigo
        Me.Sidebar.GradientTopLeft = System.Drawing.SystemColors.InactiveCaptionText
        Me.Sidebar.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Sidebar.Location = New System.Drawing.Point(15, 0)
        Me.Sidebar.Name = "Sidebar"
        Me.Sidebar.Quality = 10
        Me.Sidebar.Size = New System.Drawing.Size(360, 978)
        Me.Sidebar.TabIndex = 0
        '
        'BunifuFlatButton2
        '
        Me.BunifuFlatButton2.Activecolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton2.BorderRadius = 0
        Me.BunifuFlatButton2.ButtonText = "                     Primer Ejercicio"
        Me.BunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AnimacionSidebar.SetDecoration(Me.BunifuFlatButton2, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionSidebarBack.SetDecoration(Me.BunifuFlatButton2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.Iconimage = Global.MenuDeLasTareas.My.Resources.Resources.pdf_64px
        Me.BunifuFlatButton2.Iconimage_right = Nothing
        Me.BunifuFlatButton2.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton2.Iconimage_Selected = Nothing
        Me.BunifuFlatButton2.IconMarginLeft = 0
        Me.BunifuFlatButton2.IconMarginRight = 0
        Me.BunifuFlatButton2.IconRightVisible = True
        Me.BunifuFlatButton2.IconRightZoom = 0R
        Me.BunifuFlatButton2.IconVisible = True
        Me.BunifuFlatButton2.IconZoom = 75.0R
        Me.BunifuFlatButton2.IsTab = False
        Me.BunifuFlatButton2.Location = New System.Drawing.Point(11, 322)
        Me.BunifuFlatButton2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuFlatButton2.Name = "BunifuFlatButton2"
        Me.BunifuFlatButton2.Normalcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.OnHovercolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton2.selected = False
        Me.BunifuFlatButton2.Size = New System.Drawing.Size(230, 59)
        Me.BunifuFlatButton2.TabIndex = 10
        Me.BunifuFlatButton2.Text = "                     Primer Ejercicio"
        Me.BunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton2.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton2.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BtnEjercicio1
        '
        Me.BtnEjercicio1.Activecolor = System.Drawing.Color.Transparent
        Me.BtnEjercicio1.BackColor = System.Drawing.Color.Transparent
        Me.BtnEjercicio1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnEjercicio1.BorderRadius = 0
        Me.BtnEjercicio1.ButtonText = "                     Primer Ejercicio"
        Me.BtnEjercicio1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AnimacionSidebar.SetDecoration(Me.BtnEjercicio1, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionSidebarBack.SetDecoration(Me.BtnEjercicio1, BunifuAnimatorNS.DecorationType.None)
        Me.BtnEjercicio1.DisabledColor = System.Drawing.Color.Gray
        Me.BtnEjercicio1.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnEjercicio1.Iconimage = Global.MenuDeLasTareas.My.Resources.Resources.pdf_64px
        Me.BtnEjercicio1.Iconimage_right = Nothing
        Me.BtnEjercicio1.Iconimage_right_Selected = Nothing
        Me.BtnEjercicio1.Iconimage_Selected = Nothing
        Me.BtnEjercicio1.IconMarginLeft = 0
        Me.BtnEjercicio1.IconMarginRight = 0
        Me.BtnEjercicio1.IconRightVisible = True
        Me.BtnEjercicio1.IconRightZoom = 0R
        Me.BtnEjercicio1.IconVisible = True
        Me.BtnEjercicio1.IconZoom = 75.0R
        Me.BtnEjercicio1.IsTab = False
        Me.BtnEjercicio1.Location = New System.Drawing.Point(11, 88)
        Me.BtnEjercicio1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnEjercicio1.Name = "BtnEjercicio1"
        Me.BtnEjercicio1.Normalcolor = System.Drawing.Color.Transparent
        Me.BtnEjercicio1.OnHovercolor = System.Drawing.Color.Transparent
        Me.BtnEjercicio1.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnEjercicio1.selected = False
        Me.BtnEjercicio1.Size = New System.Drawing.Size(230, 59)
        Me.BtnEjercicio1.TabIndex = 8
        Me.BtnEjercicio1.Text = "                     Primer Ejercicio"
        Me.BtnEjercicio1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEjercicio1.Textcolor = System.Drawing.Color.White
        Me.BtnEjercicio1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.AnimacionSidebar.SetDecoration(Me.Label2, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionSidebarBack.SetDecoration(Me.Label2, BunifuAnimatorNS.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Imprint MT Shadow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(84, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Tareas"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.AnimacionSidebar.SetDecoration(Me.PictureBox2, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionSidebarBack.SetDecoration(Me.PictureBox2, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox2.Image = Global.MenuDeLasTareas.My.Resources.Resources.windows_client_64px
        Me.PictureBox2.Location = New System.Drawing.Point(21, 10)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'lineasidebar
        '
        Me.lineasidebar.BackColor = System.Drawing.Color.Transparent
        Me.AnimacionSidebarBack.SetDecoration(Me.lineasidebar, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionSidebar.SetDecoration(Me.lineasidebar, BunifuAnimatorNS.DecorationType.None)
        Me.lineasidebar.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lineasidebar.LineThickness = 1
        Me.lineasidebar.Location = New System.Drawing.Point(9, 59)
        Me.lineasidebar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lineasidebar.Name = "lineasidebar"
        Me.lineasidebar.Size = New System.Drawing.Size(336, 1)
        Me.lineasidebar.TabIndex = 0
        Me.lineasidebar.Transparency = 255
        Me.lineasidebar.Vertical = False
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurar.BackgroundImage = Global.MenuDeLasTareas.My.Resources.Resources.Restore_Window_2_48px
        Me.btnRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AnimacionSidebar.SetDecoration(Me.btnRestaurar, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionSidebarBack.SetDecoration(Me.btnRestaurar, BunifuAnimatorNS.DecorationType.None)
        Me.btnRestaurar.FlatAppearance.BorderSize = 0
        Me.btnRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestaurar.Location = New System.Drawing.Point(1772, 26)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(35, 35)
        Me.btnRestaurar.TabIndex = 5
        Me.btnRestaurar.UseVisualStyleBackColor = True
        Me.btnRestaurar.Visible = False
        '
        'btnMaximizar
        '
        Me.btnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximizar.BackgroundImage = Global.MenuDeLasTareas.My.Resources.Resources.Maximize_Window_2_48px
        Me.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AnimacionSidebar.SetDecoration(Me.btnMaximizar, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionSidebarBack.SetDecoration(Me.btnMaximizar, BunifuAnimatorNS.DecorationType.None)
        Me.btnMaximizar.FlatAppearance.BorderSize = 0
        Me.btnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximizar.Location = New System.Drawing.Point(1772, 26)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(35, 35)
        Me.btnMaximizar.TabIndex = 4
        Me.btnMaximizar.UseVisualStyleBackColor = True
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.BackgroundImage = Global.MenuDeLasTareas.My.Resources.Resources.Minimize_Window_2_48px
        Me.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AnimacionSidebar.SetDecoration(Me.btnMinimizar, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionSidebarBack.SetDecoration(Me.btnMinimizar, BunifuAnimatorNS.DecorationType.None)
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.Location = New System.Drawing.Point(1731, 26)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(35, 35)
        Me.btnMinimizar.TabIndex = 3
        Me.btnMinimizar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.BackgroundImage = Global.MenuDeLasTareas.My.Resources.Resources.Close_Window__2_48px
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AnimacionSidebar.SetDecoration(Me.btnSalir, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionSidebarBack.SetDecoration(Me.btnSalir, BunifuAnimatorNS.DecorationType.None)
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Location = New System.Drawing.Point(1813, 26)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(35, 35)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnmenu
        '
        Me.AnimacionSidebar.SetDecoration(Me.btnmenu, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionSidebarBack.SetDecoration(Me.btnmenu, BunifuAnimatorNS.DecorationType.None)
        Me.btnmenu.Image = Global.MenuDeLasTareas.My.Resources.Resources.Menu_48px
        Me.btnmenu.Location = New System.Drawing.Point(12, 26)
        Me.btnmenu.Name = "btnmenu"
        Me.btnmenu.Size = New System.Drawing.Size(35, 35)
        Me.btnmenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnmenu.TabIndex = 0
        Me.btnmenu.TabStop = False
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1867, 1102)
        Me.Controls.Add(Me.Wrapper)
        Me.Controls.Add(Me.SidebarWrapper)
        Me.Controls.Add(Me.MenuTop)
        Me.AnimacionSidebarBack.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionSidebar.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Tareas"
        Me.MenuTop.ResumeLayout(False)
        Me.MenuTop.PerformLayout()
        Me.SidebarWrapper.ResumeLayout(False)
        Me.Sidebar.ResumeLayout(False)
        Me.Sidebar.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnmenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MenuTop As Panel
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnmenu As PictureBox
    Friend WithEvents SidebarWrapper As Panel
    Friend WithEvents Wrapper As Panel
    Friend WithEvents btnMaximizar As Button
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnRestaurar As Button
    Friend WithEvents Sidebar As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lineasidebar As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents CurvaSidebar As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuFlatButton2 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BtnEjercicio1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents AnimacionSidebarBack As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents AnimacionSidebar As BunifuAnimatorNS.BunifuTransition
End Class
