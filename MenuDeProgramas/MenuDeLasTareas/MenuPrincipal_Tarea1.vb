
Imports System.Runtime.InteropServices
Public Class MenuPrincipal_Tarea1

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        WindowState = FormWindowState.Normal
        btnRestaurar.Visible = False
        btnMaximizar.Visible = True

    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        WindowState = FormWindowState.Minimized

    End Sub

    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click
        WindowState = FormWindowState.Maximized
        btnMaximizar.Visible = False
        btnRestaurar.Visible = True

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Application.Exit()

    End Sub

    Private Sub btnmenu_Click(sender As Object, e As EventArgs) Handles btnmenu.Click
        If Sidebar.Width = 270 Then

            Sidebar.Visible = False
            Sidebar.Width = 68
            SidebarWrapper.Width = 90
            lineasidebar.Width = 52
            AnimacionSidebar.Show(Sidebar)
            hidesubmenu()

        Else

            Sidebar.Visible = False
            Sidebar.Width = 270
            SidebarWrapper.Width = 300
            lineasidebar.Width = 252
            AnimacionSidebarBack.Show(Sidebar)
            hidesubmenu()

        End If

    End Sub

    Private Sub MenuTop_MouseMove(sender As Object, e As MouseEventArgs) Handles MenuTop.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)

    End Sub
    Private Formulario As Form = Nothing
    Private Sub abrirFormularios(ByVal formHijo As Form)
        Try
            If Formulario IsNot Nothing Then
                Formulario.Close()
            End If
            Formulario = formHijo
            formHijo.TopLevel = False
            formHijo.FormBorderStyle = FormBorderStyle.None
            formHijo.Dock = DockStyle.Fill
            FormulariosHijos.Controls.Add(formHijo)
            FormulariosHijos.Tag = formHijo
            formHijo.BringToFront()
            formHijo.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub hidesubmenu()
        panelSubMenuClases.Visible = False
        panelSubmenuTareas.Visible = False

    End Sub

    Private Sub MenuPrincipal_Tarea1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hidesubmenu()
    End Sub
    Private Sub mostrarsubmenu(submenu As Panel)
        If submenu.Visible = False Then
            hidesubmenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If
    End Sub
    Private Sub btnMenuEClases_Click_1(sender As Object, e As EventArgs) Handles btnMenuEClases.Click
        mostrarsubmenu(panelSubMenuClases)
    End Sub

    Private Sub btnUIuser_Click_1(sender As Object, e As EventArgs) Handles btnUIuser.Click
        abrirFormularios(UIuser_EJclase1)
    End Sub

    Private Sub btnArreglosUni_Click_1(sender As Object, e As EventArgs) Handles btnArreglosUni.Click
        abrirFormularios(Arreglos)
    End Sub

    Private Sub btnProgramasTarea_Click(sender As Object, e As EventArgs) Handles btnProgramasTarea.Click
        mostrarsubmenu(panelSubmenuTareas)
    End Sub

    Private Sub btnLibretadeahorros_Click(sender As Object, e As EventArgs) Handles btnLibretadeahorros.Click
        abrirFormularios(Libretadeahorros)
    End Sub
End Class
