Public Class Bolsa_solidaria
    Private beneficiario As Integer
    Private Beneficiados(100, 7) As String
    Private Sub limpiar()
        txtDepartamento.Clear()
        txtIdentidad.Clear()
        txtIntegrantes.Clear()
        txtMunicipio.Clear()
        txtNombreCompleto.Clear()
        chkPobreza.Checked = False
        chkPobrezaExtrema.Checked = False
    End Sub
    Private Function validar_beneficiario(buscar As String)
        Dim verdadero As Integer
        verdadero = 0

        For i = 0 To 100 Step 1
            If buscar = Beneficiados(i, 0) Then
                verdadero = 1
            End If
        Next

        If verdadero = 1 Then
            Return 1
        Else
            Return 0
        End If

    End Function

    Private Sub guardar_Datos()
        Dim bolsa, situacion, tipobolsa As String

        If Val(txtIntegrantes.Text) < 0 Then
            MsgBox("Escriba una cantidad de integrantes valida", vbExclamation + vbOKOnly, "Advertencia")
            limpiar()

        ElseIf Not IsNumeric(txtIntegrantes.Text) Then
            MsgBox("Escriba una cantidad de integrantes valida", vbExclamation + vbOKOnly, "Advertencia")
            limpiar()

        ElseIf chkPobreza.Checked = False And chkPobrezaExtrema.Checked = False Then
            MsgBox("Debe seleccionar la situacion de la persona", vbExclamation + vbOKOnly, "Advertencia")
            limpiar()

        Else

            If Val(txtIntegrantes.Text) <= 3 Then
                bolsa = "Bolsa Basica"
                tipobolsa = "2 lb arroz ,1 aceite,2 maseca,3 lb maiz,1 lb frijoles"
            ElseIf Val(txtIntegrantes.Text) > 3 Then
                bolsa = "Bolsa Regular"
                tipobolsa = "4 lb arroz,4 aceite,4 maseca,4 lb maiz,3 lb frijoles"
            End If

            If chkPobreza.Checked = True Then
                situacion = "Pobreza"
            ElseIf chkPobrezaExtrema.Checked = True Then
                situacion = "Pobreza Extrema"
            End If

            Beneficiados(beneficiario, 0) = txtIdentidad.Text
            Beneficiados(beneficiario, 1) = txtNombreCompleto.Text
            Beneficiados(beneficiario, 2) = txtDepartamento.Text
            Beneficiados(beneficiario, 3) = txtMunicipio.Text
            Beneficiados(beneficiario, 4) = txtIntegrantes.Text
            Beneficiados(beneficiario, 5) = situacion
            Beneficiados(beneficiario, 6) = bolsa
            Beneficiados(beneficiario, 7) = tipobolsa
            txtBolsa.Text = bolsa
            Reporte(beneficiario)
            beneficiario += 1
        End If

    End Sub

    Private Sub Reporte(Usuario As Integer)
        dtgReporte.Rows.Add(Beneficiados(Usuario, 0), Beneficiados(Usuario, 1), Beneficiados(Usuario, 2), Beneficiados(Usuario, 3), Beneficiados(Usuario, 4), Beneficiados(Usuario, 5), Beneficiados(Usuario, 6), Beneficiados(beneficiario, 7))
    End Sub

    Private Sub btnSolicitar_Click(sender As Object, e As EventArgs) Handles btnSolicitar.Click
        Dim encontrado As Integer


        encontrado = validar_beneficiario(txtIdentidad.Text)
        If txtIdentidad.Text.Length <> 13 Then
            MsgBox("Ingrese un numero de identidad correcto", vbExclamation + vbOKOnly, "Advertencia")
        ElseIf encontrado = 1 Then
            MsgBox("La persona ya fue beneficiada ingrese otra persona", vbInformation + vbOKOnly, "Beneficiario Existe")
            limpiar()
        Else
            guardar_Datos()
        End If



    End Sub

    Private Sub chkPobreza_CheckedChanged(sender As Object, e As EventArgs) Handles chkPobreza.CheckedChanged
        If chkPobreza.Checked = True Then
            chkPobrezaExtrema.Checked = False
        End If
    End Sub

    Private Sub chkPobrezaExtrema_CheckedChanged(sender As Object, e As EventArgs) Handles chkPobrezaExtrema.CheckedChanged
        If chkPobrezaExtrema.Checked = True Then
            chkPobreza.Checked = False
        End If
    End Sub

    Private Sub txtIdentidad_Validating_1(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtIdentidad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtNombreCompleto_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNombreCompleto.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtDepartamento_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtDepartamento.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtMunicipio_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtMunicipio.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtIntegrantes_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtIntegrantes.Validating
        If DirectCast(sender, MaskedTextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtIdentidad_MouseHover(sender As Object, e As EventArgs) Handles txtIdentidad.MouseHover
        ToolTip.SetToolTip(txtIdentidad, "Ingrese el numero de indentidad")
        ToolTip.ToolTipTitle = "Identidad"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtNombreCompleto_MouseHover(sender As Object, e As EventArgs) Handles txtNombreCompleto.MouseHover
        ToolTip.SetToolTip(txtNombreCompleto, "Ingrese el nombre completo")
        ToolTip.ToolTipTitle = "Nombre Beneficiario"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtDepartamento_MouseHover(sender As Object, e As EventArgs) Handles txtDepartamento.MouseHover
        ToolTip.SetToolTip(txtDepartamento, "Ingrese el departamento")
        ToolTip.ToolTipTitle = "Departamento"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtMunicipio_MouseHover(sender As Object, e As EventArgs) Handles txtMunicipio.MouseHover
        ToolTip.SetToolTip(txtMunicipio, "Ingrese el municipio")
        ToolTip.ToolTipTitle = "Municipio"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtIntegrantes_MouseHover(sender As Object, e As EventArgs) Handles txtIntegrantes.MouseHover
        ToolTip.SetToolTip(txtIntegrantes, "Ingrese la cantidad de integrantes")
        ToolTip.ToolTipTitle = "Integrantes"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class