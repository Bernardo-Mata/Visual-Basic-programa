Public Class MenuPrincipal

    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Show Bio panel by default
        ShowPanel(pnlBio)
    End Sub

    Private Sub ShowPanel(panelToShow As Panel)
        ' Hide all panels
        pnlBio.Visible = False
        pnlOps.Visible = False
        pnlInteres.Visible = False
        pnlCalc.Visible = False
        pnlInfo.Visible = False
        ' Show only the selected panel
        panelToShow.Visible = True
    End Sub

    ' LinkLabel click handlers
    Private Sub lnkBio_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkBio.LinkClicked
        ShowPanel(pnlBio)
    End Sub

    Private Sub lnkOps_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkOps.LinkClicked
        ShowPanel(pnlOps)
    End Sub

    Private Sub lnkInteres_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkInteres.LinkClicked
        ShowPanel(pnlInteres)
    End Sub

    Private Sub lnkCalc_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkCalc.LinkClicked
        ShowPanel(pnlCalc)
    End Sub

    Private Sub lnkInfo_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkInfo.LinkClicked
        ShowPanel(pnlInfo)
    End Sub

    ' Operations Panel (Ops) - Arithmetic operations
    Private Sub btnSumar_Click(sender As Object, e As EventArgs) Handles btnSumar.Click
        CalculateOperation("+")
    End Sub

    Private Sub btnRestar_Click(sender As Object, e As EventArgs) Handles btnRestar.Click
        CalculateOperation("-")
    End Sub

    Private Sub btnMultiplicar_Click(sender As Object, e As EventArgs) Handles btnMultiplicar.Click
        CalculateOperation("*")
    End Sub

    Private Sub btnDividir_Click(sender As Object, e As EventArgs) Handles btnDividir.Click
        CalculateOperation("/")
    End Sub

    Private Sub CalculateOperation(op As String)
        Try
            Dim num1 As Double = Convert.ToDouble(txtNum1.Text)
            Dim num2 As Double = Convert.ToDouble(txtNum2.Text)
            Dim result As Double = 0

            Select Case op
                Case "+"
                    result = num1 + num2
                Case "-"
                    result = num1 - num2
                Case "*"
                    result = num1 * num2
                Case "/"
                    If num2 = 0 Then
                        MessageBox.Show("No se puede dividir entre cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If
                    result = num1 / num2
            End Select

            lblResultOps.Text = "Resultado: " & result.ToString()
        Catch ex As Exception
            MessageBox.Show("Por favor ingrese valores numéricos válidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Interest Panel - Compound Interest Formula M=C*(1+r/100)^t
    Private Sub btnCalcularInteres_Click(sender As Object, e As EventArgs) Handles btnCalcularInteres.Click
        Try
            Dim capital As Double = Convert.ToDouble(txtCapital.Text)
            Dim tasa As Double = Convert.ToDouble(txtTasa.Text)
            Dim tiempo As Double = Convert.ToDouble(txtTiempo.Text)

            ' Formula: M = C * (1 + r/100)^t
            Dim monto As Double = capital * Math.Pow((1 + tasa / 100), tiempo)

            lblResultInteres.Text = "Monto Final (M): " & monto.ToString("F2")
        Catch ex As Exception
            MessageBox.Show("Por favor ingrese valores numéricos válidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Calculator Panel - Numeric buttons
    Private Sub btnCalcNum_Click(sender As Object, e As EventArgs) Handles btn0.Click, btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click
        Dim btn As Button = CType(sender, Button)
        txtCalcDisplay.Text &= btn.Text
    End Sub

    Private Sub btnCalcClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtCalcDisplay.Text = ""
    End Sub

    Private Sub btnCalcEquals_Click(sender As Object, e As EventArgs) Handles btnEquals.Click
        Try
            ' Safe expression evaluator that only handles basic arithmetic
            Dim expression As String = txtCalcDisplay.Text
            Dim result As Double = EvaluateSafeExpression(expression)
            txtCalcDisplay.Text = result.ToString()
        Catch ex As Exception
            txtCalcDisplay.Text = "Error"
        End Try
    End Sub

    ' Safe expression evaluator that only handles numbers and basic operators (+, -, *, /)
    Private Function EvaluateSafeExpression(expression As String) As Double
        ' Validate input contains only allowed characters (digits, operators, decimal point)
        Dim allowedChars As String = "0123456789+-*/."
        For Each c As Char In expression
            If Not allowedChars.Contains(c) Then
                Throw New ArgumentException("Invalid character in expression")
            End If
        Next

        ' Simple left-to-right evaluation (handles one operator at a time)
        Dim tokens As New List(Of String)()
        Dim currentNumber As String = ""

        For Each c As Char In expression
            If "+-*/".Contains(c) Then
                If currentNumber.Length > 0 Then
                    tokens.Add(currentNumber)
                    currentNumber = ""
                End If
                tokens.Add(c.ToString())
            Else
                currentNumber &= c
            End If
        Next

        If currentNumber.Length > 0 Then
            tokens.Add(currentNumber)
        End If

        If tokens.Count = 0 Then Return 0

        ' Evaluate with proper operator precedence (* and / first, then + and -)
        ' First pass: handle * and /
        Dim i As Integer = 0
        While i < tokens.Count
            If tokens(i) = "*" OrElse tokens(i) = "/" Then
                Dim left As Double = Convert.ToDouble(tokens(i - 1))
                Dim right As Double = Convert.ToDouble(tokens(i + 1))
                Dim res As Double

                If tokens(i) = "*" Then
                    res = left * right
                Else
                    If right = 0 Then Throw New DivideByZeroException()
                    res = left / right
                End If

                tokens(i - 1) = res.ToString()
                tokens.RemoveAt(i)
                tokens.RemoveAt(i)
                i -= 1
            End If
            i += 1
        End While

        ' Second pass: handle + and -
        Dim result As Double = Convert.ToDouble(tokens(0))
        i = 1
        While i < tokens.Count
            Dim op As String = tokens(i)
            Dim num As Double = Convert.ToDouble(tokens(i + 1))

            If op = "+" Then
                result += num
            ElseIf op = "-" Then
                result -= num
            End If
            i += 2
        End While

        Return result
    End Function

    Private Sub btnCalcOp_Click(sender As Object, e As EventArgs) Handles btnPlus.Click, btnMinus.Click, btnMult.Click, btnDiv.Click
        Dim btn As Button = CType(sender, Button)
        txtCalcDisplay.Text &= btn.Text
    End Sub

    Private Sub MenuPrincipal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

End Class
