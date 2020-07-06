Public Class Estudiantes
    Dim conexion As conexion = New conexion()
    Dim dt As New DataTable
    Private Sub frmEstudiante_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        mostrarDatos()
    End Sub

    Public Sub Limpiar()
        txtCodigo.Enabled = True
        txtCodigo.Clear()
        txtNombre.Clear()
        txtPrimerApellido.Clear()
        txtSegApellido.Clear()
        txtEdad.Clear()
        btnEliminar.Enabled = False
        btnModificar.Enabled = False
        btnGuardar.Enabled = True
        conexion.conexion.Close()

    End Sub


    Private Sub mostrarDatos()
        Try

            dt = conexion.consulta
            If dt.Rows.Count <> 0 Then
                dtgRegistros.DataSource = dt
                conexion.conexion.Close()
            Else
                dtgRegistros.DataSource = Nothing
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try

            Dim guardar As String =
             "insert into personas.estudiante values(" + txtCodigo.Text + ",'" + txtNombre.Text + "','" + txtPrimerApellido.Text + "',
             '" + txtSegApellido.Text + "','" + txtEdad.Text + "','" + cmbSexo.Text + "','" + cmbCodigoClase.Text + "')"

            If (conexion.insertar(guardar)) Then
                MessageBox.Show("Guardado")
                mostrarDatos()
                Limpiar()
                conexion.conexion.Close()
            Else
                MessageBox.Show("Error al guardar")
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If (conexion.eliminar("personas.estudiante", "codigo=" + txtCodigo.Text)) Then
                MessageBox.Show("Eliminado")
                mostrarDatos()
                Limpiar()
                conexion.conexion.Close()
            Else
                MessageBox.Show("Error al Eliminar")
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dtgRegistros_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgRegistros.CellContentClick
        btnGuardar.Enabled = False
        btnModificar.Enabled = True
        btnEliminar.Enabled = True
        txtCodigo.Enabled = False
        llenarCampos(e)
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            Dim modificar As String =
            "nombre='" + txtNombre.Text + "', primerApellido='" + txtPrimerApellido.Text + "', segundoApellido='" + txtSegApellido.Text + "', edad='" + txtEdad.Text + "', codigoClase='" + cmbCodigoClase.Text + "'"
            If (conexion.modificar("personas.estudiante", modificar, " codigo=" + txtCodigo.Text)) Then
                MessageBox.Show("Actualizado")
                mostrarDatos()
                Limpiar()
                conexion.conexion.Close()
            Else
                MessageBox.Show("Error al actualizar")
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub llenarCampos(e As DataGridViewCellEventArgs)
        Try
            Dim dtg As DataGridViewRow = dtgRegistros.Rows(e.RowIndex)
            txtCodigo.Text = dtg.Cells(0).Value.ToString()
            txtNombre.Text = dtg.Cells(1).Value.ToString()
            txtPrimerApellido.Text = dtg.Cells(2).Value.ToString()
            txtSegApellido.Text = dtg.Cells(3).Value.ToString()
            txtEdad.Text = dtg.Cells(4).Value.ToString()
            cmbSexo.Text = dtg.Cells(5).Value.ToString()
            cmbCodigoClase.Text = dtg.Cells(6).Value.ToString()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Limpiar()
    End Sub

    Private Sub mostrarBusqueda()

        Try

            dt = conexion.buscarEstudiante("codigo like '%" + txtCodigo.Text + "%'")
            If dt.Rows.Count <> 0 Then
                dtgRegistros.DataSource = dt
                conexion.conexion.Close()
            Else
                dtgRegistros.DataSource = Nothing
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        mostrarBusqueda()
    End Sub
End Class