Public Class Cajero

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim valor As Double

        If Double.TryParse(txtEntrada.Text, valor) Then
            Dim denominaciones As Double() = {20, 10, 5, 1, 0.25, 0.1, 0.01}
            Dim resultado(6) As Double
            Dim residuo As Double = valor

            For i = 0 To (denominaciones.Length - 1)
                'Dim cantidad es una variable contadora, en la primer vuelta valdra el valor de 199.89 / 20
                Dim cantidad As Integer = CInt(Math.Floor(residuo / denominaciones(i)))

                'luego en nuestro array vacio, asignaremos el resultado de 199.89/20 que guardamos en la variable cantidad
                resultado(i) = cantidad

                'Luego aca sacamos el residuo de 199.89 % 20, luego de 199.89%10 y asi sucesivamente
                residuo = residuo Mod denominaciones(i)
            Next

            txtBilleteV.Text = resultado(0).ToString()
            txtBilletedD.Text = resultado(1).ToString()
            txtBilleteC.Text = resultado(2).ToString()
            txtBilleteU.Text = resultado(3).ToString()
            txtMonedaVc.Text = resultado(4).ToString()
            txtMonedaDs.Text = resultado(5).ToString()
            txtMonedaCtv.Text = resultado(6).ToString()
        Else
            MessageBox.Show("Ingrese un dato valido")
            txtEntrada.Text = ""
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtBilleteV.Text = ""
        txtBilletedD.Text = ""
        txtBilleteC.Text = ""
        txtBilleteU.Text = ""
        txtMonedaVc.Text = ""
        txtMonedaDs.Text = ""
        txtMonedaCtv.Text = ""
        txtEntrada.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub
End Class
