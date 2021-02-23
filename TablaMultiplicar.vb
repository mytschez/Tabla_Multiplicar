Public Class frmTablaMultiplicar
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim Verificado As Boolean
        Dim n As Integer

        Verificado = Verificar()
        If Verificado Then
            n = txtTabla.Text
            CalcularTabla(n)
        End If

    End Sub

    'función para verificar que el valor introducido en el textbox es de tipo entero
    Function Verificar() As Boolean
        Dim num As Integer
        Dim valido As Boolean
        Try
            num = Integer.Parse(txtTabla.Text)
            valido = True
        Catch ex As Exception
            valido = False
            MessageBox.Show("Por favor, introduzca un número entero", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'limpiar el formulario
            txtTablaCompleta.Clear()
            'reiniciar el cuadro para introducir el número cuya tabla se quiere calcular
            txtTabla.Text = 0
            txtTabla.Focus()
            txtTabla.SelectAll()
        End Try

        Return valido

    End Function

    'procedimiento para calcular la tabla de multiplicar del valor indicado
    Private Sub CalcularTabla(n As Integer)
        'variables
        Dim resultado As String
        Dim multi As Integer

        resultado = "La tabla del " & n & " es: " & vbCrLf & vbCrLf

        'calculamos la tabla de multiplicar del número indicado
        For i As Integer = 1 To 10
            multi = i * n
            resultado &= n & " x " & i & " = " & multi & vbCrLf
        Next
        'dibuja la tabla de multiplicar
        txtTablaCompleta.Text = resultado

        'mantener el foco en el cuadro para indicar el número de la tabla de multiplicar que se quiere calcular
        txtTabla.Focus()
        txtTabla.SelectAll()

    End Sub

    'al presionar la tecla enter ejecuta el click del botón calcular
    Private Sub txtTabla_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTabla.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnCalcular.PerformClick()
        End If

    End Sub


End Class
