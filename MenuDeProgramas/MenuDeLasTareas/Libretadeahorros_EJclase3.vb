Public Class Libretadeahorros_EJclase3
    Private monto(99) As Double
    Private Usuario(99, 5) As String
    Private Registro, User As Integer

    Private Sub activarControles()
        btnRetirar.Enabled = True
        btnDepositar.Enabled = True
    End Sub

    Private Sub desactivarControles()

        btnAperturar.Enabled = True
        btnRetirar.Enabled = False
        btnDepositar.Enabled = False
    End Sub

    Private Sub limpiar()

        desactivarControles()
        txtSaldo.Clear()
        lstDepositos.Items.Clear()
        lstRetiros.Items.Clear()
    End Sub

    Private Sub LibretaAhorro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        desactivarControles()
    End Sub

    Private Sub mostrarSaldo(x As Integer)
        txtSaldo.Text = monto(x)
    End Sub

    Private Sub btnAperturar_Click(sender As Object, e As EventArgs) Handles btnAperturar.Click
        limpiar()
        Try
            Usuario(Registro, 0) = InputBox("Ingrese la Identidad", "registro")
            Do While (Usuario(Registro, 0).Length <> 13 Or Not IsNumeric(Usuario(Registro, 0)))
                Usuario(Registro, 0) = InputBox("Ingrese la Identidad", "registro")
            Loop

            Usuario(Registro, 1) = InputBox("Ingrese la Nombre", "registro")
            Usuario(Registro, 2) = InputBox("Ingrese la edad", "registro")
            Usuario(Registro, 3) = InputBox("Ingrese la país", "registro")
            Usuario(Registro, 4) = InputBox("Ingrese la ciudad", "registro")
            monto(Registro) = InputBox("Ingrese monto", "registro")

            If (monto(Registro) < 0) Then
                MessageBox.Show("Monto mayor a 0", "Ingresar monto correcto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Registro += 1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Function leer(mensaje As String)
        Dim cantidad As Double
        cantidad = InputBox("Ingrese un monto a" & mensaje, "Operación")
        mostrarSaldo(User)

        Return cantidad
    End Function

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub

    Private Sub btnDepositar_Click(sender As Object, e As EventArgs) Handles btnDepositar.Click
        Dim deposito As Double
        deposito = leer("Depositar")
        monto(User) += deposito
        lstDepositos.Items.Add(deposito)
        mostrarSaldo(User)
    End Sub

    Private Sub btnRetirar_Click(sender As Object, e As EventArgs) Handles btnRetirar.Click
        Dim retiro As Double
        retiro = leer("Retirar")
        If (retiro > monto(User)) Then
            MessageBox.Show("Saldo insuficiente", "Deposite mas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            monto(User) -= retiro
            lstRetiros.Items.Add(retiro)
            mostrarSaldo(User)
        End If
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim ingresar As String
        activarControles()
        limpiar()
        Try
            User = 0
            Do While (Usuario(Registro, 0).Length <> 13 Or Not IsNumeric(Usuario(Registro, 0)))
                ingresar = InputBox("Ingrese la Identidad", "Ingreso")
            Loop

            Do While (ingresar <> Usuario(User, 0))
                    User += 1
                Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        monto(User) += (monto(User)) * 0.3
        mostrarSaldo(User)

    End Sub
End Class