
Imports System.Runtime.InteropServices
Public Class MenuPrincipal

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

        Else

            Sidebar.Visible = False
            Sidebar.Width = 270
            SidebarWrapper.Width = 300
            lineasidebar.Width = 252
            AnimacionSidebarBack.Show(Sidebar)

        End If

    End Sub

    Private Sub MenuTop_MouseMove(sender As Object, e As MouseEventArgs) Handles MenuTop.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)

    End Sub
End Class
