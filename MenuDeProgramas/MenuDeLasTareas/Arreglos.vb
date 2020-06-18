Public Class Arreglos
    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Dim computadoras(3) As String
        computadoras(0) = "Razer"
        computadoras(1) = "Alienware"
        computadoras(2) = "Asus ROG"
        computadoras(3) = "MSI"
        For i = 0 To (computadoras.Length - 1) Step 1
            cmbComputadoras.Items.Add(computadoras(i))
        Next

    End Sub

    Private Sub btnGenerarPrecio_Click(sender As Object, e As EventArgs) Handles btnGenerarPrecio.Click
        Dim precio(3) As Integer
        precio(0) = 40000
        precio(1) = 80000
        precio(2) = 45000
        precio(3) = 42000
        For i = 0 To (precio.Length - 1) Step 1
            cmbPrecios.Items.Add(precio(i))
        Next
    End Sub

    Private Sub btnSolicitar_Click(sender As Object, e As EventArgs) Handles btnSolicitar.Click
        Dim cant As Integer
        Dim comp() As String

        cant = Val(txtCant.Text)
        ReDim comp(cant)

        For i = 0 To (comp.Length - 1) Step 1
            comp(i) = InputBox("Ingrese la marca de la pc", "Ingreso")
        Next

        For j = 0 To (comp.Length - 1) Step 1
            cmbCompus.Items.Add(comp(j))
        Next
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs)
        cmbComputadoras.Items.Clear()
        cmbPrecios.Items.Clear()
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs)
        WindowState = FormWindowState.Maximized
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class