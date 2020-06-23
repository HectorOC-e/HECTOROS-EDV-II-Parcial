<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipal_Tarea1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPrincipal_Tarea1))
        Dim Animation3 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation4 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Me.MenuTop = New System.Windows.Forms.Panel()
        Me.btnRestaurar = New System.Windows.Forms.Button()
        Me.btnMaximizar = New System.Windows.Forms.Button()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnmenu = New System.Windows.Forms.PictureBox()
        Me.SidebarWrapper = New System.Windows.Forms.Panel()
        Me.Sidebar = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.panelSubmenuTareas = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.btnProgramasTarea = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.panelSubMenuClases = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnLibretadeahorros = New System.Windows.Forms.Button()
        Me.btnArreglosUni = New System.Windows.Forms.Button()
        Me.btnUIuser = New System.Windows.Forms.Button()
        Me.btnMenuEClases = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lineasidebar = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FormulariosHijos = New System.Windows.Forms.Panel()
        Me.titulo = New System.Windows.Forms.Label()
        Me.CurvaSidebar = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.AnimacionSidebar = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.AnimacionSidebarBack = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.MenuTop.SuspendLayout()
        CType(Me.btnmenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SidebarWrapper.SuspendLayout()
        Me.Sidebar.SuspendLayout()
        Me.panelSubmenuTareas.SuspendLayout()
        Me.panelSubMenuClases.SuspendLayout()
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FormulariosHijos.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuTop
        '
        Me.MenuTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.AnimacionSidebar.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionSidebarBack.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(53, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Menu Principal"
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
        'SidebarWrapper
        '
        Me.SidebarWrapper.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.SidebarWrapper.Controls.Add(Me.Sidebar)
        Me.AnimacionSidebarBack.SetDecoration(Me.SidebarWrapper, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionSidebar.SetDecoration(Me.SidebarWrapper, BunifuAnimatorNS.DecorationType.None)
        Me.SidebarWrapper.Dock = System.Windows.Forms.DockStyle.Left
        Me.SidebarWrapper.Location = New System.Drawing.Point(0, 80)
        Me.SidebarWrapper.Name = "SidebarWrapper"
        Me.SidebarWrapper.Size = New System.Drawing.Size(400, 1022)
        Me.SidebarWrapper.TabIndex = 1
        '
        'Sidebar
        '
        Me.Sidebar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Sidebar.BackgroundImage = CType(resources.GetObject("Sidebar.BackgroundImage"), System.Drawing.Image)
        Me.Sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Sidebar.Controls.Add(Me.panelSubmenuTareas)
        Me.Sidebar.Controls.Add(Me.btnProgramasTarea)
        Me.Sidebar.Controls.Add(Me.panelSubMenuClases)
        Me.Sidebar.Controls.Add(Me.btnMenuEClases)
        Me.Sidebar.Controls.Add(Me.BunifuGradientPanel1)
        Me.AnimacionSidebarBack.SetDecoration(Me.Sidebar, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionSidebar.SetDecoration(Me.Sidebar, BunifuAnimatorNS.DecorationType.None)
        Me.Sidebar.GradientBottomLeft = System.Drawing.Color.DodgerBlue
        Me.Sidebar.GradientBottomRight = System.Drawing.Color.Cyan
        Me.Sidebar.GradientTopLeft = System.Drawing.SystemColors.Highlight
        Me.Sidebar.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Sidebar.Location = New System.Drawing.Point(15, 0)
        Me.Sidebar.Name = "Sidebar"
        Me.Sidebar.Quality = 10
        Me.Sidebar.Size = New System.Drawing.Size(360, 978)
        Me.Sidebar.TabIndex = 0
        '
        'panelSubmenuTareas
        '
        Me.panelSubmenuTareas.BackgroundImage = CType(resources.GetObject("panelSubmenuTareas.BackgroundImage"), System.Drawing.Image)
        Me.panelSubmenuTareas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panelSubmenuTareas.Controls.Add(Me.Button2)
        Me.panelSubmenuTareas.Controls.Add(Me.Button3)
        Me.panelSubmenuTareas.Controls.Add(Me.Button5)
        Me.panelSubmenuTareas.Controls.Add(Me.Button6)
        Me.AnimacionSidebarBack.SetDecoration(Me.panelSubmenuTareas, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionSidebar.SetDecoration(Me.panelSubmenuTareas, BunifuAnimatorNS.DecorationType.None)
        Me.panelSubmenuTareas.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelSubmenuTareas.GradientBottomLeft = System.Drawing.Color.DodgerBlue
        Me.panelSubmenuTareas.GradientBottomRight = System.Drawing.Color.Cyan
        Me.panelSubmenuTareas.GradientTopLeft = System.Drawing.SystemColors.Highlight
        Me.panelSubmenuTareas.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.panelSubmenuTareas.Location = New System.Drawing.Point(0, 416)
        Me.panelSubmenuTareas.Name = "panelSubmenuTareas"
        Me.panelSubmenuTareas.Quality = 10
        Me.panelSubmenuTareas.Size = New System.Drawing.Size(360, 208)
        Me.panelSubmenuTareas.TabIndex = 15
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.AnimacionSidebar.SetDecoration(Me.Button2, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionSidebarBack.SetDecoration(Me.Button2, BunifuAnimatorNS.DecorationType.None)
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(0, 120)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(70, 0, 0, 0)
        Me.Button2.Size = New System.Drawing.Size(360, 40)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Button2"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.AnimacionSidebar.SetDecoration(Me.Button3, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionSidebarBack.SetDecoration(Me.Button3, BunifuAnimatorNS.DecorationType.None)
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(0, 80)
        Me.Button3.Name = "Button3"
        Me.Button3.Padding = New System.Windows.Forms.Padding(70, 0, 0, 0)
        Me.Button3.Size = New System.Drawing.Size(360, 40)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Arreglos Bidimensionales"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.AnimacionSidebar.SetDecoration(Me.Button5, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionSidebarBack.SetDecoration(Me.Button5, BunifuAnimatorNS.DecorationType.None)
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(0, 40)
        Me.Button5.Name = "Button5"
        Me.Button5.Padding = New System.Windows.Forms.Padding(70, 0, 0, 0)
        Me.Button5.Size = New System.Drawing.Size(360, 40)
        Me.Button5.TabIndex = 1
        Me.Button5.Text = "Arreglos unidimensionales"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.AnimacionSidebar.SetDecoration(Me.Button6, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionSidebarBack.SetDecoration(Me.Button6, BunifuAnimatorNS.DecorationType.None)
        Me.Button6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(0, 0)
        Me.Button6.Name = "Button6"
        Me.Button6.Padding = New System.Windows.Forms.Padding(70, 0, 0, 0)
        Me.Button6.Size = New System.Drawing.Size(360, 40)
        Me.Button6.TabIndex = 0
        Me.Button6.Text = "UIuser"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button6.UseVisualStyleBackColor = False
        '
        'btnProgramasTarea
        '
        Me.btnProgramasTarea.Activecolor = System.Drawing.Color.Navy
        Me.btnProgramasTarea.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnProgramasTarea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnProgramasTarea.BorderRadius = 0
        Me.btnProgramasTarea.ButtonText = "            Programas Tareas"
        Me.btnProgramasTarea.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AnimacionSidebar.SetDecoration(Me.btnProgramasTarea, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionSidebarBack.SetDecoration(Me.btnProgramasTarea, BunifuAnimatorNS.DecorationType.None)
        Me.btnProgramasTarea.DisabledColor = System.Drawing.Color.Gray
        Me.btnProgramasTarea.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnProgramasTarea.Iconcolor = System.Drawing.Color.Transparent
        Me.btnProgramasTarea.Iconimage = Global.MenuDeLasTareas.My.Resources.Resources.school_30px
        Me.btnProgramasTarea.Iconimage_right = Nothing
        Me.btnProgramasTarea.Iconimage_right_Selected = Nothing
        Me.btnProgramasTarea.Iconimage_Selected = Nothing
        Me.btnProgramasTarea.IconMarginLeft = 0
        Me.btnProgramasTarea.IconMarginRight = 0
        Me.btnProgramasTarea.IconRightVisible = True
        Me.btnProgramasTarea.IconRightZoom = 0R
        Me.btnProgramasTarea.IconVisible = True
        Me.btnProgramasTarea.IconZoom = 90.0R
        Me.btnProgramasTarea.IsTab = False
        Me.btnProgramasTarea.Location = New System.Drawing.Point(0, 357)
        Me.btnProgramasTarea.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnProgramasTarea.Name = "btnProgramasTarea"
        Me.btnProgramasTarea.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnProgramasTarea.OnHovercolor = System.Drawing.Color.Cyan
        Me.btnProgramasTarea.OnHoverTextColor = System.Drawing.SystemColors.Highlight
        Me.btnProgramasTarea.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnProgramasTarea.selected = False
        Me.btnProgramasTarea.Size = New System.Drawing.Size(360, 59)
        Me.btnProgramasTarea.TabIndex = 15
        Me.btnProgramasTarea.Text = "            Programas Tareas"
        Me.btnProgramasTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnProgramasTarea.Textcolor = System.Drawing.Color.White
        Me.btnProgramasTarea.TextFont = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'panelSubMenuClases
        '
        Me.panelSubMenuClases.BackColor = System.Drawing.Color.Transparent
        Me.panelSubMenuClases.BackgroundImage = CType(resources.GetObject("panelSubMenuClases.BackgroundImage"), System.Drawing.Image)
        Me.panelSubMenuClases.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panelSubMenuClases.Controls.Add(Me.Button1)
        Me.panelSubMenuClases.Controls.Add(Me.btnLibretadeahorros)
        Me.panelSubMenuClases.Controls.Add(Me.btnArreglosUni)
        Me.panelSubMenuClases.Controls.Add(Me.btnUIuser)
        Me.AnimacionSidebarBack.SetDecoration(Me.panelSubMenuClases, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionSidebar.SetDecoration(Me.panelSubMenuClases, BunifuAnimatorNS.DecorationType.None)
        Me.panelSubMenuClases.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelSubMenuClases.GradientBottomLeft = System.Drawing.Color.DodgerBlue
        Me.panelSubMenuClases.GradientBottomRight = System.Drawing.Color.Cyan
        Me.panelSubMenuClases.GradientTopLeft = System.Drawing.SystemColors.Highlight
        Me.panelSubMenuClases.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.panelSubMenuClases.Location = New System.Drawing.Point(0, 149)
        Me.panelSubMenuClases.Name = "panelSubMenuClases"
        Me.panelSubMenuClases.Quality = 10
        Me.panelSubMenuClases.Size = New System.Drawing.Size(360, 208)
        Me.panelSubMenuClases.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.AnimacionSidebar.SetDecoration(Me.Button1, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionSidebarBack.SetDecoration(Me.Button1, BunifuAnimatorNS.DecorationType.None)
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(0, 122)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(70, 0, 0, 0)
        Me.Button1.Size = New System.Drawing.Size(360, 40)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Button1"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnLibretadeahorros
        '
        Me.btnLibretadeahorros.BackColor = System.Drawing.Color.Transparent
        Me.AnimacionSidebar.SetDecoration(Me.btnLibretadeahorros, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionSidebarBack.SetDecoration(Me.btnLibretadeahorros, BunifuAnimatorNS.DecorationType.None)
        Me.btnLibretadeahorros.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnLibretadeahorros.FlatAppearance.BorderSize = 0
        Me.btnLibretadeahorros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy
        Me.btnLibretadeahorros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue
        Me.btnLibretadeahorros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLibretadeahorros.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLibretadeahorros.ForeColor = System.Drawing.Color.White
        Me.btnLibretadeahorros.Location = New System.Drawing.Point(0, 82)
        Me.btnLibretadeahorros.Name = "btnLibretadeahorros"
        Me.btnLibretadeahorros.Padding = New System.Windows.Forms.Padding(70, 0, 0, 0)
        Me.btnLibretadeahorros.Size = New System.Drawing.Size(360, 40)
        Me.btnLibretadeahorros.TabIndex = 2
        Me.btnLibretadeahorros.Text = "Libreta de Ahorros"
        Me.btnLibretadeahorros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLibretadeahorros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLibretadeahorros.UseVisualStyleBackColor = False
        '
        'btnArreglosUni
        '
        Me.btnArreglosUni.BackColor = System.Drawing.Color.Transparent
        Me.AnimacionSidebar.SetDecoration(Me.btnArreglosUni, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionSidebarBack.SetDecoration(Me.btnArreglosUni, BunifuAnimatorNS.DecorationType.None)
        Me.btnArreglosUni.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnArreglosUni.FlatAppearance.BorderSize = 0
        Me.btnArreglosUni.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy
        Me.btnArreglosUni.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue
        Me.btnArreglosUni.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnArreglosUni.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArreglosUni.ForeColor = System.Drawing.Color.White
        Me.btnArreglosUni.Location = New System.Drawing.Point(0, 42)
        Me.btnArreglosUni.Name = "btnArreglosUni"
        Me.btnArreglosUni.Padding = New System.Windows.Forms.Padding(70, 0, 0, 0)
        Me.btnArreglosUni.Size = New System.Drawing.Size(360, 40)
        Me.btnArreglosUni.TabIndex = 1
        Me.btnArreglosUni.Text = "Arreglos unidimensionales"
        Me.btnArreglosUni.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnArreglosUni.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnArreglosUni.UseVisualStyleBackColor = False
        '
        'btnUIuser
        '
        Me.btnUIuser.BackColor = System.Drawing.Color.Transparent
        Me.AnimacionSidebar.SetDecoration(Me.btnUIuser, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionSidebarBack.SetDecoration(Me.btnUIuser, BunifuAnimatorNS.DecorationType.None)
        Me.btnUIuser.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUIuser.FlatAppearance.BorderSize = 0
        Me.btnUIuser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy
        Me.btnUIuser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue
        Me.btnUIuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUIuser.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUIuser.ForeColor = System.Drawing.Color.White
        Me.btnUIuser.Location = New System.Drawing.Point(0, 0)
        Me.btnUIuser.Name = "btnUIuser"
        Me.btnUIuser.Padding = New System.Windows.Forms.Padding(70, 0, 0, 0)
        Me.btnUIuser.Size = New System.Drawing.Size(360, 42)
        Me.btnUIuser.TabIndex = 0
        Me.btnUIuser.Text = "UIuser"
        Me.btnUIuser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUIuser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUIuser.UseVisualStyleBackColor = False
        '
        'btnMenuEClases
        '
        Me.btnMenuEClases.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnMenuEClases.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnMenuEClases.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMenuEClases.BorderRadius = 0
        Me.btnMenuEClases.ButtonText = "            Programas Clase"
        Me.btnMenuEClases.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AnimacionSidebar.SetDecoration(Me.btnMenuEClases, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionSidebarBack.SetDecoration(Me.btnMenuEClases, BunifuAnimatorNS.DecorationType.None)
        Me.btnMenuEClases.DisabledColor = System.Drawing.Color.Gray
        Me.btnMenuEClases.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMenuEClases.Iconcolor = System.Drawing.Color.Transparent
        Me.btnMenuEClases.Iconimage = Global.MenuDeLasTareas.My.Resources.Resources.study_96px
        Me.btnMenuEClases.Iconimage_right = Nothing
        Me.btnMenuEClases.Iconimage_right_Selected = Nothing
        Me.btnMenuEClases.Iconimage_Selected = Nothing
        Me.btnMenuEClases.IconMarginLeft = 0
        Me.btnMenuEClases.IconMarginRight = 0
        Me.btnMenuEClases.IconRightVisible = True
        Me.btnMenuEClases.IconRightZoom = 0R
        Me.btnMenuEClases.IconVisible = True
        Me.btnMenuEClases.IconZoom = 90.0R
        Me.btnMenuEClases.IsTab = False
        Me.btnMenuEClases.Location = New System.Drawing.Point(0, 90)
        Me.btnMenuEClases.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnMenuEClases.Name = "btnMenuEClases"
        Me.btnMenuEClases.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnMenuEClases.OnHovercolor = System.Drawing.Color.Cyan
        Me.btnMenuEClases.OnHoverTextColor = System.Drawing.SystemColors.Highlight
        Me.btnMenuEClases.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnMenuEClases.selected = False
        Me.btnMenuEClases.Size = New System.Drawing.Size(360, 59)
        Me.btnMenuEClases.TabIndex = 10
        Me.btnMenuEClases.Text = "            Programas Clase"
        Me.btnMenuEClases.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnMenuEClases.Textcolor = System.Drawing.Color.White
        Me.btnMenuEClases.TextFont = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.PictureBox2)
        Me.BunifuGradientPanel1.Controls.Add(Me.lineasidebar)
        Me.BunifuGradientPanel1.Controls.Add(Me.Label2)
        Me.AnimacionSidebarBack.SetDecoration(Me.BunifuGradientPanel1, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionSidebar.SetDecoration(Me.BunifuGradientPanel1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.DodgerBlue
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Cyan
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.SystemColors.Highlight
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(360, 90)
        Me.BunifuGradientPanel1.TabIndex = 9
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.AnimacionSidebar.SetDecoration(Me.PictureBox2, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionSidebarBack.SetDecoration(Me.PictureBox2, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox2.Image = Global.MenuDeLasTareas.My.Resources.Resources.windows_client_64px
        Me.PictureBox2.Location = New System.Drawing.Point(13, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(54, 56)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'lineasidebar
        '
        Me.lineasidebar.BackColor = System.Drawing.Color.Transparent
        Me.AnimacionSidebarBack.SetDecoration(Me.lineasidebar, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionSidebar.SetDecoration(Me.lineasidebar, BunifuAnimatorNS.DecorationType.None)
        Me.lineasidebar.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lineasidebar.LineThickness = 1
        Me.lineasidebar.Location = New System.Drawing.Point(13, 71)
        Me.lineasidebar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lineasidebar.Name = "lineasidebar"
        Me.lineasidebar.Size = New System.Drawing.Size(336, 1)
        Me.lineasidebar.TabIndex = 9
        Me.lineasidebar.Transparency = 255
        Me.lineasidebar.Vertical = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.AnimacionSidebar.SetDecoration(Me.Label2, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionSidebarBack.SetDecoration(Me.Label2, BunifuAnimatorNS.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(90, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 23)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Tareas"
        '
        'FormulariosHijos
        '
        Me.FormulariosHijos.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.FormulariosHijos.Controls.Add(Me.titulo)
        Me.AnimacionSidebarBack.SetDecoration(Me.FormulariosHijos, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionSidebar.SetDecoration(Me.FormulariosHijos, BunifuAnimatorNS.DecorationType.None)
        Me.FormulariosHijos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormulariosHijos.Location = New System.Drawing.Point(400, 80)
        Me.FormulariosHijos.Name = "FormulariosHijos"
        Me.FormulariosHijos.Size = New System.Drawing.Size(1467, 1022)
        Me.FormulariosHijos.TabIndex = 1
        '
        'titulo
        '
        Me.titulo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.titulo.AutoSize = True
        Me.AnimacionSidebar.SetDecoration(Me.titulo, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionSidebarBack.SetDecoration(Me.titulo, BunifuAnimatorNS.DecorationType.None)
        Me.titulo.Font = New System.Drawing.Font("Times New Roman", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titulo.Image = Global.MenuDeLasTareas.My.Resources.Resources.vb_64px
        Me.titulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.titulo.Location = New System.Drawing.Point(271, 259)
        Me.titulo.Name = "titulo"
        Me.titulo.Size = New System.Drawing.Size(750, 89)
        Me.titulo.TabIndex = 0
        Me.titulo.Text = "     Programas Hector"
        Me.titulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Animation3.AnimateOnlyDifferences = True
        Animation3.BlindCoeff = CType(resources.GetObject("Animation3.BlindCoeff"), System.Drawing.PointF)
        Animation3.LeafCoeff = 0!
        Animation3.MaxTime = 1.0!
        Animation3.MinTime = 0!
        Animation3.MosaicCoeff = CType(resources.GetObject("Animation3.MosaicCoeff"), System.Drawing.PointF)
        Animation3.MosaicShift = CType(resources.GetObject("Animation3.MosaicShift"), System.Drawing.PointF)
        Animation3.MosaicSize = 1
        Animation3.Padding = New System.Windows.Forms.Padding(100, 50, 100, 150)
        Animation3.RotateCoeff = 0!
        Animation3.RotateLimit = 0!
        Animation3.ScaleCoeff = CType(resources.GetObject("Animation3.ScaleCoeff"), System.Drawing.PointF)
        Animation3.SlideCoeff = CType(resources.GetObject("Animation3.SlideCoeff"), System.Drawing.PointF)
        Animation3.TimeCoeff = 2.0!
        Animation3.TransparencyCoeff = 0!
        Me.AnimacionSidebar.DefaultAnimation = Animation3
        '
        'AnimacionSidebarBack
        '
        Me.AnimacionSidebarBack.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide
        Me.AnimacionSidebarBack.Cursor = Nothing
        Animation4.AnimateOnlyDifferences = True
        Animation4.BlindCoeff = CType(resources.GetObject("Animation4.BlindCoeff"), System.Drawing.PointF)
        Animation4.LeafCoeff = 0!
        Animation4.MaxTime = 1.0!
        Animation4.MinTime = 0!
        Animation4.MosaicCoeff = CType(resources.GetObject("Animation4.MosaicCoeff"), System.Drawing.PointF)
        Animation4.MosaicShift = CType(resources.GetObject("Animation4.MosaicShift"), System.Drawing.PointF)
        Animation4.MosaicSize = 0
        Animation4.Padding = New System.Windows.Forms.Padding(0)
        Animation4.RotateCoeff = 0!
        Animation4.RotateLimit = 0!
        Animation4.ScaleCoeff = CType(resources.GetObject("Animation4.ScaleCoeff"), System.Drawing.PointF)
        Animation4.SlideCoeff = CType(resources.GetObject("Animation4.SlideCoeff"), System.Drawing.PointF)
        Animation4.TimeCoeff = 0!
        Animation4.TransparencyCoeff = 0!
        Me.AnimacionSidebarBack.DefaultAnimation = Animation4
        '
        'MenuPrincipal_Tarea1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1867, 1102)
        Me.Controls.Add(Me.FormulariosHijos)
        Me.Controls.Add(Me.SidebarWrapper)
        Me.Controls.Add(Me.MenuTop)
        Me.AnimacionSidebarBack.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionSidebar.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MenuPrincipal_Tarea1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Tareas"
        Me.MenuTop.ResumeLayout(False)
        Me.MenuTop.PerformLayout()
        CType(Me.btnmenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SidebarWrapper.ResumeLayout(False)
        Me.Sidebar.ResumeLayout(False)
        Me.panelSubmenuTareas.ResumeLayout(False)
        Me.panelSubMenuClases.ResumeLayout(False)
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FormulariosHijos.ResumeLayout(False)
        Me.FormulariosHijos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MenuTop As Panel
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnmenu As PictureBox
    Friend WithEvents SidebarWrapper As Panel
    Friend WithEvents FormulariosHijos As Panel
    Friend WithEvents btnMaximizar As Button
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnRestaurar As Button
    Friend WithEvents Sidebar As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents CurvaSidebar As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents AnimacionSidebarBack As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents AnimacionSidebar As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lineasidebar As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Label2 As Label
    Friend WithEvents panelSubmenuTareas As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents titulo As Label
    Friend WithEvents btnMenuEClases As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents panelSubMenuClases As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents btnLibretadeahorros As Button
    Friend WithEvents btnArreglosUni As Button
    Friend WithEvents btnUIuser As Button
    Friend WithEvents btnProgramasTarea As Bunifu.Framework.UI.BunifuFlatButton
End Class
