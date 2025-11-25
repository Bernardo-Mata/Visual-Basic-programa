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
            Dim dt As New DataTable()
            Dim result As Object = dt.Compute(txtCalcDisplay.Text, "")
            txtCalcDisplay.Text = result.ToString()
        Catch ex As Exception
            txtCalcDisplay.Text = "Error"
        End Try
    End Sub

    Private Sub btnCalcOp_Click(sender As Object, e As EventArgs) Handles btnPlus.Click, btnMinus.Click, btnMult.Click, btnDiv.Click
        Dim btn As Button = CType(sender, Button)
        txtCalcDisplay.Text &= btn.Text
    End Sub

    Private Sub MenuPrincipal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

End Class
