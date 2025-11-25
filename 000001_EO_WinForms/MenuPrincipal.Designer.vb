<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuPrincipal
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New System.ComponentModel.Container()
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(900, 550)
        Text = "Menú Principal"
        StartPosition = FormStartPosition.CenterScreen

        ' Left Panel for LinkLabels
        Dim pnlMenu As New Panel()
        pnlMenu.Location = New Point(0, 0)
        pnlMenu.Size = New Size(150, 550)
        pnlMenu.BackColor = Color.LightGray
        Me.Controls.Add(pnlMenu)

        ' LinkLabels
        lnkBio = New LinkLabel()
        lnkBio.Text = "Biografía"
        lnkBio.Location = New Point(20, 30)
        lnkBio.Size = New Size(100, 25)
        pnlMenu.Controls.Add(lnkBio)

        lnkOps = New LinkLabel()
        lnkOps.Text = "Operaciones"
        lnkOps.Location = New Point(20, 70)
        lnkOps.Size = New Size(100, 25)
        pnlMenu.Controls.Add(lnkOps)

        lnkInteres = New LinkLabel()
        lnkInteres.Text = "Interés"
        lnkInteres.Location = New Point(20, 110)
        lnkInteres.Size = New Size(100, 25)
        pnlMenu.Controls.Add(lnkInteres)

        lnkCalc = New LinkLabel()
        lnkCalc.Text = "Calculadora"
        lnkCalc.Location = New Point(20, 150)
        lnkCalc.Size = New Size(100, 25)
        pnlMenu.Controls.Add(lnkCalc)

        lnkInfo = New LinkLabel()
        lnkInfo.Text = "Información"
        lnkInfo.Location = New Point(20, 190)
        lnkInfo.Size = New Size(100, 25)
        pnlMenu.Controls.Add(lnkInfo)

        ' ============== PANELS (Right Side - Overlapping) ==============

        ' Bio Panel with TabControl
        pnlBio = New Panel()
        pnlBio.Location = New Point(160, 10)
        pnlBio.Size = New Size(720, 520)
        pnlBio.BorderStyle = BorderStyle.FixedSingle
        Me.Controls.Add(pnlBio)

        Dim lblBioTitle As New Label()
        lblBioTitle.Text = "Biografía"
        lblBioTitle.Font = New Font("Arial", 14, FontStyle.Bold)
        lblBioTitle.Location = New Point(10, 10)
        lblBioTitle.Size = New Size(200, 30)
        pnlBio.Controls.Add(lblBioTitle)

        tabBio = New TabControl()
        tabBio.Location = New Point(10, 50)
        tabBio.Size = New Size(690, 450)

        Dim tabPage1 As New TabPage("Personal")
        Dim lblPersonal As New Label()
        lblPersonal.Text = "Información personal del usuario." & vbCrLf & vbCrLf & "Nombre: Usuario Demo" & vbCrLf & "Edad: 25 años" & vbCrLf & "Ocupación: Desarrollador"
        lblPersonal.Location = New Point(20, 20)
        lblPersonal.Size = New Size(600, 150)
        tabPage1.Controls.Add(lblPersonal)

        Dim tabPage2 As New TabPage("Educación")
        Dim lblEducacion As New Label()
        lblEducacion.Text = "Historial educativo del usuario." & vbCrLf & vbCrLf & "Universidad: Universidad Nacional" & vbCrLf & "Carrera: Ingeniería en Sistemas" & vbCrLf & "Año de graduación: 2023"
        lblEducacion.Location = New Point(20, 20)
        lblEducacion.Size = New Size(600, 150)
        tabPage2.Controls.Add(lblEducacion)

        Dim tabPage3 As New TabPage("Experiencia")
        Dim lblExperiencia As New Label()
        lblExperiencia.Text = "Experiencia laboral del usuario." & vbCrLf & vbCrLf & "Empresa: Tech Solutions" & vbCrLf & "Puesto: Desarrollador de Software" & vbCrLf & "Años de experiencia: 3"
        lblExperiencia.Location = New Point(20, 20)
        lblExperiencia.Size = New Size(600, 150)
        tabPage3.Controls.Add(lblExperiencia)

        tabBio.TabPages.Add(tabPage1)
        tabBio.TabPages.Add(tabPage2)
        tabBio.TabPages.Add(tabPage3)
        pnlBio.Controls.Add(tabBio)

        ' Ops Panel - Operations (Sum, Res, Mult, Div)
        pnlOps = New Panel()
        pnlOps.Location = New Point(160, 10)
        pnlOps.Size = New Size(720, 520)
        pnlOps.BorderStyle = BorderStyle.FixedSingle
        pnlOps.Visible = False
        Me.Controls.Add(pnlOps)

        Dim lblOpsTitle As New Label()
        lblOpsTitle.Text = "Operaciones Aritméticas"
        lblOpsTitle.Font = New Font("Arial", 14, FontStyle.Bold)
        lblOpsTitle.Location = New Point(10, 10)
        lblOpsTitle.Size = New Size(300, 30)
        pnlOps.Controls.Add(lblOpsTitle)

        Dim lblNum1 As New Label()
        lblNum1.Text = "Número 1:"
        lblNum1.Location = New Point(30, 60)
        lblNum1.Size = New Size(80, 25)
        pnlOps.Controls.Add(lblNum1)

        txtNum1 = New TextBox()
        txtNum1.Location = New Point(120, 57)
        txtNum1.Size = New Size(150, 25)
        pnlOps.Controls.Add(txtNum1)

        Dim lblNum2 As New Label()
        lblNum2.Text = "Número 2:"
        lblNum2.Location = New Point(30, 100)
        lblNum2.Size = New Size(80, 25)
        pnlOps.Controls.Add(lblNum2)

        txtNum2 = New TextBox()
        txtNum2.Location = New Point(120, 97)
        txtNum2.Size = New Size(150, 25)
        pnlOps.Controls.Add(txtNum2)

        btnSumar = New Button()
        btnSumar.Text = "Sumar"
        btnSumar.Location = New Point(30, 150)
        btnSumar.Size = New Size(100, 35)
        pnlOps.Controls.Add(btnSumar)

        btnRestar = New Button()
        btnRestar.Text = "Restar"
        btnRestar.Location = New Point(140, 150)
        btnRestar.Size = New Size(100, 35)
        pnlOps.Controls.Add(btnRestar)

        btnMultiplicar = New Button()
        btnMultiplicar.Text = "Multiplicar"
        btnMultiplicar.Location = New Point(250, 150)
        btnMultiplicar.Size = New Size(100, 35)
        pnlOps.Controls.Add(btnMultiplicar)

        btnDividir = New Button()
        btnDividir.Text = "Dividir"
        btnDividir.Location = New Point(360, 150)
        btnDividir.Size = New Size(100, 35)
        pnlOps.Controls.Add(btnDividir)

        lblResultOps = New Label()
        lblResultOps.Text = "Resultado: "
        lblResultOps.Font = New Font("Arial", 12, FontStyle.Bold)
        lblResultOps.Location = New Point(30, 210)
        lblResultOps.Size = New Size(400, 30)
        pnlOps.Controls.Add(lblResultOps)

        ' Interes Panel - Compound Interest Formula
        pnlInteres = New Panel()
        pnlInteres.Location = New Point(160, 10)
        pnlInteres.Size = New Size(720, 520)
        pnlInteres.BorderStyle = BorderStyle.FixedSingle
        pnlInteres.Visible = False
        Me.Controls.Add(pnlInteres)

        Dim lblInteresTitle As New Label()
        lblInteresTitle.Text = "Cálculo de Interés Compuesto"
        lblInteresTitle.Font = New Font("Arial", 14, FontStyle.Bold)
        lblInteresTitle.Location = New Point(10, 10)
        lblInteresTitle.Size = New Size(350, 30)
        pnlInteres.Controls.Add(lblInteresTitle)

        Dim lblFormula As New Label()
        lblFormula.Text = "Fórmula: M = C * (1 + r/100)^t"
        lblFormula.Font = New Font("Arial", 11, FontStyle.Italic)
        lblFormula.Location = New Point(10, 45)
        lblFormula.Size = New Size(300, 25)
        pnlInteres.Controls.Add(lblFormula)

        Dim lblCapital As New Label()
        lblCapital.Text = "Capital (C):"
        lblCapital.Location = New Point(30, 90)
        lblCapital.Size = New Size(100, 25)
        pnlInteres.Controls.Add(lblCapital)

        txtCapital = New TextBox()
        txtCapital.Location = New Point(140, 87)
        txtCapital.Size = New Size(150, 25)
        pnlInteres.Controls.Add(txtCapital)

        Dim lblTasa As New Label()
        lblTasa.Text = "Tasa (r%):"
        lblTasa.Location = New Point(30, 130)
        lblTasa.Size = New Size(100, 25)
        pnlInteres.Controls.Add(lblTasa)

        txtTasa = New TextBox()
        txtTasa.Location = New Point(140, 127)
        txtTasa.Size = New Size(150, 25)
        pnlInteres.Controls.Add(txtTasa)

        Dim lblTiempo As New Label()
        lblTiempo.Text = "Tiempo (t):"
        lblTiempo.Location = New Point(30, 170)
        lblTiempo.Size = New Size(100, 25)
        pnlInteres.Controls.Add(lblTiempo)

        txtTiempo = New TextBox()
        txtTiempo.Location = New Point(140, 167)
        txtTiempo.Size = New Size(150, 25)
        pnlInteres.Controls.Add(txtTiempo)

        btnCalcularInteres = New Button()
        btnCalcularInteres.Text = "Calcular"
        btnCalcularInteres.Location = New Point(140, 210)
        btnCalcularInteres.Size = New Size(100, 35)
        pnlInteres.Controls.Add(btnCalcularInteres)

        lblResultInteres = New Label()
        lblResultInteres.Text = "Monto Final (M): "
        lblResultInteres.Font = New Font("Arial", 12, FontStyle.Bold)
        lblResultInteres.Location = New Point(30, 270)
        lblResultInteres.Size = New Size(400, 30)
        pnlInteres.Controls.Add(lblResultInteres)

        ' Calc Panel - Calculator with numeric buttons
        pnlCalc = New Panel()
        pnlCalc.Location = New Point(160, 10)
        pnlCalc.Size = New Size(720, 520)
        pnlCalc.BorderStyle = BorderStyle.FixedSingle
        pnlCalc.Visible = False
        Me.Controls.Add(pnlCalc)

        Dim lblCalcTitle As New Label()
        lblCalcTitle.Text = "Calculadora"
        lblCalcTitle.Font = New Font("Arial", 14, FontStyle.Bold)
        lblCalcTitle.Location = New Point(10, 10)
        lblCalcTitle.Size = New Size(200, 30)
        pnlCalc.Controls.Add(lblCalcTitle)

        txtCalcDisplay = New TextBox()
        txtCalcDisplay.Location = New Point(30, 50)
        txtCalcDisplay.Size = New Size(260, 30)
        txtCalcDisplay.Font = New Font("Arial", 14)
        txtCalcDisplay.TextAlign = HorizontalAlignment.Right
        pnlCalc.Controls.Add(txtCalcDisplay)

        ' Numeric buttons
        Dim btnSize As New Size(60, 50)
        Dim startX As Integer = 30
        Dim startY As Integer = 100

        btn7 = New Button()
        btn7.Text = "7"
        btn7.Location = New Point(startX, startY)
        btn7.Size = btnSize
        btn7.Font = New Font("Arial", 12, FontStyle.Bold)
        pnlCalc.Controls.Add(btn7)

        btn8 = New Button()
        btn8.Text = "8"
        btn8.Location = New Point(startX + 65, startY)
        btn8.Size = btnSize
        btn8.Font = New Font("Arial", 12, FontStyle.Bold)
        pnlCalc.Controls.Add(btn8)

        btn9 = New Button()
        btn9.Text = "9"
        btn9.Location = New Point(startX + 130, startY)
        btn9.Size = btnSize
        btn9.Font = New Font("Arial", 12, FontStyle.Bold)
        pnlCalc.Controls.Add(btn9)

        btnDiv = New Button()
        btnDiv.Text = "/"
        btnDiv.Location = New Point(startX + 195, startY)
        btnDiv.Size = btnSize
        btnDiv.Font = New Font("Arial", 12, FontStyle.Bold)
        pnlCalc.Controls.Add(btnDiv)

        btn4 = New Button()
        btn4.Text = "4"
        btn4.Location = New Point(startX, startY + 55)
        btn4.Size = btnSize
        btn4.Font = New Font("Arial", 12, FontStyle.Bold)
        pnlCalc.Controls.Add(btn4)

        btn5 = New Button()
        btn5.Text = "5"
        btn5.Location = New Point(startX + 65, startY + 55)
        btn5.Size = btnSize
        btn5.Font = New Font("Arial", 12, FontStyle.Bold)
        pnlCalc.Controls.Add(btn5)

        btn6 = New Button()
        btn6.Text = "6"
        btn6.Location = New Point(startX + 130, startY + 55)
        btn6.Size = btnSize
        btn6.Font = New Font("Arial", 12, FontStyle.Bold)
        pnlCalc.Controls.Add(btn6)

        btnMult = New Button()
        btnMult.Text = "*"
        btnMult.Location = New Point(startX + 195, startY + 55)
        btnMult.Size = btnSize
        btnMult.Font = New Font("Arial", 12, FontStyle.Bold)
        pnlCalc.Controls.Add(btnMult)

        btn1 = New Button()
        btn1.Text = "1"
        btn1.Location = New Point(startX, startY + 110)
        btn1.Size = btnSize
        btn1.Font = New Font("Arial", 12, FontStyle.Bold)
        pnlCalc.Controls.Add(btn1)

        btn2 = New Button()
        btn2.Text = "2"
        btn2.Location = New Point(startX + 65, startY + 110)
        btn2.Size = btnSize
        btn2.Font = New Font("Arial", 12, FontStyle.Bold)
        pnlCalc.Controls.Add(btn2)

        btn3 = New Button()
        btn3.Text = "3"
        btn3.Location = New Point(startX + 130, startY + 110)
        btn3.Size = btnSize
        btn3.Font = New Font("Arial", 12, FontStyle.Bold)
        pnlCalc.Controls.Add(btn3)

        btnMinus = New Button()
        btnMinus.Text = "-"
        btnMinus.Location = New Point(startX + 195, startY + 110)
        btnMinus.Size = btnSize
        btnMinus.Font = New Font("Arial", 12, FontStyle.Bold)
        pnlCalc.Controls.Add(btnMinus)

        btn0 = New Button()
        btn0.Text = "0"
        btn0.Location = New Point(startX, startY + 165)
        btn0.Size = btnSize
        btn0.Font = New Font("Arial", 12, FontStyle.Bold)
        pnlCalc.Controls.Add(btn0)

        btnClear = New Button()
        btnClear.Text = "C"
        btnClear.Location = New Point(startX + 65, startY + 165)
        btnClear.Size = btnSize
        btnClear.Font = New Font("Arial", 12, FontStyle.Bold)
        pnlCalc.Controls.Add(btnClear)

        btnEquals = New Button()
        btnEquals.Text = "="
        btnEquals.Location = New Point(startX + 130, startY + 165)
        btnEquals.Size = btnSize
        btnEquals.Font = New Font("Arial", 12, FontStyle.Bold)
        pnlCalc.Controls.Add(btnEquals)

        btnPlus = New Button()
        btnPlus.Text = "+"
        btnPlus.Location = New Point(startX + 195, startY + 165)
        btnPlus.Size = btnSize
        btnPlus.Font = New Font("Arial", 12, FontStyle.Bold)
        pnlCalc.Controls.Add(btnPlus)

        ' Info Panel - Information text
        pnlInfo = New Panel()
        pnlInfo.Location = New Point(160, 10)
        pnlInfo.Size = New Size(720, 520)
        pnlInfo.BorderStyle = BorderStyle.FixedSingle
        pnlInfo.Visible = False
        Me.Controls.Add(pnlInfo)

        Dim lblInfoTitle As New Label()
        lblInfoTitle.Text = "Información"
        lblInfoTitle.Font = New Font("Arial", 14, FontStyle.Bold)
        lblInfoTitle.Location = New Point(10, 10)
        lblInfoTitle.Size = New Size(200, 30)
        pnlInfo.Controls.Add(lblInfoTitle)

        Dim lblInfoContent As New Label()
        lblInfoContent.Text = "Bienvenido a la aplicación 000001_EO_WinForms" & vbCrLf & vbCrLf &
                              "Esta aplicación fue desarrollada con VB.NET WinForms." & vbCrLf & vbCrLf &
                              "Funcionalidades:" & vbCrLf &
                              "• Biografía: Información personal organizada en pestañas" & vbCrLf &
                              "• Operaciones: Calculadora de operaciones aritméticas básicas" & vbCrLf &
                              "• Interés: Cálculo de interés compuesto con fórmula M=C*(1+r/100)^t" & vbCrLf &
                              "• Calculadora: Calculadora con botones numéricos" & vbCrLf &
                              "• Información: Esta sección con detalles de la aplicación" & vbCrLf & vbCrLf &
                              "Usuario: SAM" & vbCrLf &
                              "Contraseña: 123" & vbCrLf & vbCrLf &
                              "Versión: 1.0" & vbCrLf &
                              "© 2024 - Todos los derechos reservados"
        lblInfoContent.Location = New Point(20, 50)
        lblInfoContent.Size = New Size(680, 400)
        pnlInfo.Controls.Add(lblInfoContent)

    End Sub

    ' Control declarations
    ' LinkLabels
    Private WithEvents lnkBio As LinkLabel
    Private WithEvents lnkOps As LinkLabel
    Private WithEvents lnkInteres As LinkLabel
    Private WithEvents lnkCalc As LinkLabel
    Private WithEvents lnkInfo As LinkLabel

    ' Panels
    Private pnlBio As Panel
    Private pnlOps As Panel
    Private pnlInteres As Panel
    Private pnlCalc As Panel
    Private pnlInfo As Panel

    ' Bio Panel controls
    Private tabBio As TabControl

    ' Ops Panel controls
    Private txtNum1 As TextBox
    Private txtNum2 As TextBox
    Private WithEvents btnSumar As Button
    Private WithEvents btnRestar As Button
    Private WithEvents btnMultiplicar As Button
    Private WithEvents btnDividir As Button
    Private lblResultOps As Label

    ' Interes Panel controls
    Private txtCapital As TextBox
    Private txtTasa As TextBox
    Private txtTiempo As TextBox
    Private WithEvents btnCalcularInteres As Button
    Private lblResultInteres As Label

    ' Calc Panel controls
    Private txtCalcDisplay As TextBox
    Private WithEvents btn0 As Button
    Private WithEvents btn1 As Button
    Private WithEvents btn2 As Button
    Private WithEvents btn3 As Button
    Private WithEvents btn4 As Button
    Private WithEvents btn5 As Button
    Private WithEvents btn6 As Button
    Private WithEvents btn7 As Button
    Private WithEvents btn8 As Button
    Private WithEvents btn9 As Button
    Private WithEvents btnPlus As Button
    Private WithEvents btnMinus As Button
    Private WithEvents btnMult As Button
    Private WithEvents btnDiv As Button
    Private WithEvents btnEquals As Button
    Private WithEvents btnClear As Button

End Class
