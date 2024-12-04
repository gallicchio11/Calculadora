Public Class Form1

    Dim Operacion As String
    Dim ValorResultado As Nullable(Of Double) = Nothing
    Dim Valor2 As Nullable(Of Double) = Nothing
    Dim SePresionaOperador As Boolean

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        EvaluaRestriccionesParaConcatenar()
        TextBoxResultado.Text &= "1"
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        EvaluaRestriccionesParaConcatenar()
        TextBoxResultado.Text &= "2"

    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button3.Click
        EvaluaRestriccionesParaConcatenar()
        TextBoxResultado.Text &= "3"

    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        EvaluaRestriccionesParaConcatenar()
        TextBoxResultado.Text &= "4"

    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button5.Click
        EvaluaRestriccionesParaConcatenar()
        TextBoxResultado.Text &= "5"

    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        EvaluaRestriccionesParaConcatenar()
        TextBoxResultado.Text &= "6"

    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        EvaluaRestriccionesParaConcatenar()
        TextBoxResultado.Text &= "7"

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        EvaluaRestriccionesParaConcatenar()
        TextBoxResultado.Text &= "8"

    End Sub

    Private Sub Button9_Click_1(sender As Object, e As EventArgs) Handles Button9.Click
        EvaluaRestriccionesParaConcatenar()
        TextBoxResultado.Text &= "9"

    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        EvaluaRestriccionesParaConcatenar()
        TextBoxResultado.Text &= "0"

    End Sub

    Private Sub ButtonPunto_Click(sender As Object, e As EventArgs) Handles ButtonPunto.Click
        EvaluaRestriccionesParaConcatenar()
        If InStr(TextBoxResultado.Text, ".", CompareMethod.Text) = 0 Then
            TextBoxResultado.Text &= "."
        End If
    End Sub

    Private Sub ButtonIgual_Click(sender As Object, e As EventArgs) Handles ButtonIgual.Click
        EvaluayHazOperacion()
        Operacion = ""

    End Sub

    Private Sub ButtonBorrar_Click(sender As Object, e As EventArgs) Handles ButtonBorrar.Click
        TextBoxResultado.Text = "0"
        Valor2 = Nothing


    End Sub

    Private Sub ButtonMas_Click(sender As Object, e As EventArgs) Handles ButtonMas.Click
        EvaluayHazOperacion()
        Operacion = "+"

    End Sub

    Private Sub ButtonMenos_Click(sender As Object, e As EventArgs) Handles ButtonMenos.Click
        EvaluayHazOperacion()
        Operacion = "-"

    End Sub

    Private Sub ButtonDivision_Click(sender As Object, e As EventArgs) Handles ButtonDivision.Click
        EvaluayHazOperacion()
        Operacion = "/"

    End Sub

    Private Sub ButtonMultiplicacion_Click(sender As Object, e As EventArgs) Handles ButtonMultiplicacion.Click
        EvaluayHazOperacion()
        Operacion = "*"

    End Sub

    Public Sub EvaluayHazOperacion()
        SePresionaOperador = True
        Valor2 = Val(TextBoxResultado.Text)
        If ValorResultado IsNot Nothing Then
            Select Case Operacion
                Case "+"
                    ValorResultado = ValorResultado + Valor2
                Case "-"
                    ValorResultado = ValorResultado - Valor2
                Case "*"
                    ValorResultado = ValorResultado * Valor2
                Case "/"
                    ValorResultado = ValorResultado / Valor2
            End Select
            TextBoxResultado.Text = ValorResultado
        Else
            ValorResultado = Valor2
        End If
    End Sub

    Public Sub EvaluaRestriccionesParaConcatenar()
        If SePresionaOperador = True Then
            TextBoxResultado.Text = ""
            SePresionaOperador = False
        ElseIf TextBoxResultado.Text = "0" Then
            TextBoxResultado.Text = ""
        End If
    End Sub
End Class
