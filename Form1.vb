Public Class Form1
    'Lista de variables globales
    Public valor As Double
    Public segundo_valor As Double
    Public flag_suma As Boolean
    Public flag_resta As Boolean
    Public flag_mult As Boolean
    Public flag_dividir As Boolean
    Public flag_clear As Boolean
    Public flag_resultado As Boolean
    Public flag_OperacionEspecial As Boolean
    Public clear_operaciones As Boolean
    Public clearRaiz As Boolean
    Public clearPorciento As Boolean
    Public clear_1Sobre_X As Boolean
    Public sizeInput As Integer
    Public memoria As Double
    Public historyList As New List(Of String)()
    Public copy As Double

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Visible = False 'textbox donde aparece el historial de las operaciones
        Display.Text = "" 'display de valores entrados por el usuario
        Operaciones.Text = "" 'display de las operaciones que este haciendo el usuario
        EtiquetaM.Text = "" 'simbolo M para indicar que un numero esta guardado en memoria
    End Sub

    Private Sub Numero1_Click(sender As Object, e As EventArgs) Handles Numero1.Click
        If flag_clear = True Then
            Display.Text = ""
            flag_clear = False
        End If

        If clear_operaciones = True Then
            Operaciones.Text = ""
            clear_operaciones = False
        End If

        If Len(Display.Text) = 16 Then
            Display.Text = Display.Text
        Else
            Display.Text = Display.Text & "1"
        End If
    End Sub

    Private Sub Numero2_Click(sender As Object, e As EventArgs) Handles Numero2.Click
        If flag_clear = True Then
            Display.Text = ""
            flag_clear = False
        End If

        If clear_operaciones = True Then
            Operaciones.Text = ""
            clear_operaciones = False
        End If

        If Len(Display.Text) = 16 Then
            Display.Text = Display.Text
        Else
            Display.Text = Display.Text & "2"
        End If
    End Sub

    Private Sub Numero3_Click(sender As Object, e As EventArgs) Handles Numero3.Click
        If flag_clear = True Then
            Display.Text = ""
            flag_clear = False
        End If

        If clear_operaciones = True Then
            Operaciones.Text = ""
            clear_operaciones = False
        End If

        If Len(Display.Text) = 16 Then
            Display.Text = Display.Text
        Else
            Display.Text = Display.Text & "3"
        End If
    End Sub

    Private Sub Numero4_Click(sender As Object, e As EventArgs) Handles Numero4.Click
        If flag_clear = True Then
            Display.Text = ""
            flag_clear = False
        End If

        If clear_operaciones = True Then
            Operaciones.Text = ""
            clear_operaciones = False
        End If

        If Len(Display.Text) = 16 Then
            Display.Text = Display.Text
        Else
            Display.Text = Display.Text & "4"
        End If
    End Sub

    Private Sub Numero5_Click(sender As Object, e As EventArgs) Handles Numero5.Click
        If flag_clear = True Then
            Display.Text = ""
            flag_clear = False
        End If

        If clear_operaciones = True Then
            Operaciones.Text = ""
            clear_operaciones = False
        End If

        If Len(Display.Text) = 16 Then
            Display.Text = Display.Text
        Else
            Display.Text = Display.Text & "5"
        End If
    End Sub

    Private Sub Numero6_Click(sender As Object, e As EventArgs) Handles Numero6.Click
        If flag_clear = True Then
            Display.Text = ""
            flag_clear = False
        End If

        If clear_operaciones = True Then
            Operaciones.Text = ""
            clear_operaciones = False
        End If

        If Len(Display.Text) = 16 Then
            Display.Text = Display.Text
        Else
            Display.Text = Display.Text & "6"
        End If
    End Sub

    Private Sub Numero7_Click(sender As Object, e As EventArgs) Handles Numero7.Click
        If flag_clear = True Then
            Display.Text = ""
            flag_clear = False
        End If

        If clear_operaciones = True Then
            Operaciones.Text = ""
            clear_operaciones = False
        End If

        If Len(Display.Text) = 16 Then
            Display.Text = Display.Text
        Else
            Display.Text = Display.Text & "7"
        End If
    End Sub

    Private Sub Numero8_Click(sender As Object, e As EventArgs) Handles Numero8.Click
        If flag_clear = True Then
            Display.Text = ""
            flag_clear = False
        End If

        If clear_operaciones = True Then
            Operaciones.Text = ""
            clear_operaciones = False
        End If

        If Len(Display.Text) = 16 Then
            Display.Text = Display.Text
        Else
            Display.Text = Display.Text & "8"
        End If
    End Sub

    Private Sub Numero9_Click(sender As Object, e As EventArgs) Handles Numero9.Click
        If flag_clear = True Then
            Display.Text = ""
            flag_clear = False
        End If

        If clear_operaciones = True Then
            Operaciones.Text = ""
            clear_operaciones = False
        End If

        If Len(Display.Text) = 16 Then
            Display.Text = Display.Text
        Else
            Display.Text = Display.Text & "9"
        End If
    End Sub

    Private Sub Numero0_Click(sender As Object, e As EventArgs) Handles Numero0.Click
        If flag_clear = True Then
            Display.Text = ""
            flag_clear = False
        End If

        If clear_operaciones = True Then
            Operaciones.Text = ""
            clear_operaciones = False
        End If

        If Len(Display.Text) = 16 Then
            Display.Text = Display.Text
        Else
            Display.Text = Display.Text & "0"
        End If
    End Sub

    Private Sub BotonResultado_Click(sender As Object, e As EventArgs) Handles BotonResultado.Click
        flag_clear = True
        flag_resultado = True
        BotonDecimal.Enabled = True
        clear_operaciones = True

        segundo_valor = Val(Display.Text)

        If flag_suma = True Then
            If flag_OperacionEspecial = False Then
                Display.Text = valor + segundo_valor
                Operaciones.Text = Operaciones.Text & segundo_valor & " = "
                flag_suma = False
            Else
                Display.Text = valor + segundo_valor
                Operaciones.Text = Operaciones.Text & " = "
                flag_suma = False
                flag_OperacionEspecial = False
            End If

        ElseIf flag_resta = True Then
            If flag_OperacionEspecial = False Then
                Display.Text = valor - segundo_valor
                Operaciones.Text = Operaciones.Text & segundo_valor & " = "
                flag_resta = False
            Else
                Display.Text = valor - segundo_valor
                Operaciones.Text = Operaciones.Text & " = "
                flag_resta = False
                flag_OperacionEspecial = False
            End If

        ElseIf flag_mult = True Then
            If flag_OperacionEspecial = False Then
                Display.Text = valor * segundo_valor
                Operaciones.Text = Operaciones.Text & segundo_valor & " = "
                flag_mult = False
            Else
                Display.Text = valor * segundo_valor
                Operaciones.Text = Operaciones.Text & " = "
                flag_mult = False
                flag_OperacionEspecial = False
            End If

        ElseIf flag_dividir = True Then
            If Val(Display.Text) = 0 Then
                Display.Text = "Cannot divide by 0"
                flag_clear = True
                clear_operaciones = True
                flag_dividir = False
                flag_OperacionEspecial = False
            ElseIf flag_OperacionEspecial = False Then
                Display.Text = valor / segundo_valor
                Operaciones.Text = Operaciones.Text & segundo_valor & " = "
                flag_dividir = False
            Else
                Display.Text = valor / segundo_valor
                Operaciones.Text = Operaciones.Text & " = "
                flag_dividir = False
                flag_OperacionEspecial = False
            End If

        End If

        historyList.Add(Operaciones.Text)

    End Sub

    Private Sub BotonSuma_Click(sender As Object, e As EventArgs) Handles BotonSuma.Click
        If flag_resultado = False And flag_OperacionEspecial = False Then
            Operaciones.Text = Operaciones.Text & Display.Text & " + "
        ElseIf flag_resultado = True Then
            Operaciones.Text = Display.Text & " + "
            flag_resultado = False
            flag_clear = False
            clear_operaciones = False
            flag_OperacionEspecial = False
        End If

        If flag_OperacionEspecial = True Then
            Operaciones.Text = Operaciones.Text & " + "
            flag_OperacionEspecial = False
        End If

        If flag_suma = True Then
            Display.Text = valor + Val(Display.Text)
            flag_suma = False

        ElseIf flag_resta = True Then
            Display.Text = valor - Val(Display.Text)
            flag_resta = False

        ElseIf flag_mult = True Then
            Display.Text = valor * Val(Display.Text)
            flag_mult = False

        ElseIf flag_dividir = True Then
            If Val(Display.Text) = 0 Then
                Display.Text = "Cannot divide by 0"
                flag_clear = True
                clear_operaciones = True
                flag_dividir = False
            Else
                Display.Text = valor / Val(Display.Text)
                flag_dividir = False
            End If

        End If

        valor = Val(Display.Text)
        flag_clear = True
        flag_suma = True
        BotonDecimal.Enabled = True

    End Sub

    Private Sub BotonResta_Click(sender As Object, e As EventArgs) Handles BotonResta.Click
        If flag_resultado = False And flag_OperacionEspecial = False Then
            Operaciones.Text = Operaciones.Text & Display.Text & " - "
        ElseIf flag_resultado = True Then
            Operaciones.Text = Display.Text & " - "
            flag_resultado = False
            flag_clear = False
            clear_operaciones = False
            flag_OperacionEspecial = False
        End If

        If flag_OperacionEspecial = True Then
            Operaciones.Text = Operaciones.Text & " - "
            flag_OperacionEspecial = False
        End If

        If flag_suma = True Then
            Display.Text = valor + Val(Display.Text)
            flag_suma = False

        ElseIf flag_resta = True Then
            Display.Text = valor - Val(Display.Text)
            flag_resta = False

        ElseIf flag_mult = True Then
            Display.Text = valor * Val(Display.Text)
            flag_mult = False

        ElseIf flag_dividir = True Then
            If Val(Display.Text) = 0 Then
                Display.Text = "Cannot divide by 0"
                flag_clear = True
                clear_operaciones = True
                flag_dividir = False
            Else
                Display.Text = valor / Val(Display.Text)
                flag_dividir = False
            End If

        End If

        valor = Val(Display.Text)
        flag_clear = True
        flag_resta = True
        BotonDecimal.Enabled = True

    End Sub

    Private Sub BotonMultiplicar_Click(sender As Object, e As EventArgs) Handles BotonMultiplicar.Click
        If flag_resultado = False And flag_OperacionEspecial = False Then
            Operaciones.Text = Operaciones.Text & Display.Text & " * "
        ElseIf flag_resultado = True Then
            Operaciones.Text = Display.Text & " * "
            flag_resultado = False
            flag_clear = False
            clear_operaciones = False
            flag_OperacionEspecial = False
        End If

        If flag_OperacionEspecial = True Then
            Operaciones.Text = Operaciones.Text & " * "
            flag_OperacionEspecial = False
        End If

        If flag_suma = True Then
            Display.Text = valor + Val(Display.Text)
            flag_suma = False

        ElseIf flag_resta = True Then
            Display.Text = valor - Val(Display.Text)
            flag_resta = False

        ElseIf flag_mult = True Then
            Display.Text = valor * Val(Display.Text)
            flag_mult = False

        ElseIf flag_dividir = True Then
            If Val(Display.Text) = 0 Then
                Display.Text = "Cannot divide by 0"
                flag_clear = True
                clear_operaciones = True
                flag_dividir = False
            Else
                Display.Text = valor / Val(Display.Text)
                flag_dividir = False
            End If
        End If

        valor = Val(Display.Text)
        flag_clear = True
        flag_mult = True
        BotonDecimal.Enabled = True

    End Sub

    Private Sub BotonDividir_Click(sender As Object, e As EventArgs) Handles BotonDividir.Click
        If flag_resultado = False And flag_OperacionEspecial = False Then
            Operaciones.Text = Operaciones.Text & Display.Text & " / "
        ElseIf flag_resultado = True Then
            Operaciones.Text = Display.Text & " / "
            flag_resultado = False
            flag_clear = False
            clear_operaciones = False
            flag_OperacionEspecial = False
        End If

        If flag_OperacionEspecial = True Then
            Operaciones.Text = Operaciones.Text & " / "
            flag_OperacionEspecial = False
        End If

        If flag_suma = True Then
            Display.Text = valor + Val(Display.Text)
            flag_suma = False

        ElseIf flag_resta = True Then
            Display.Text = valor - Val(Display.Text)
            flag_resta = False

        ElseIf flag_mult = True Then
            Display.Text = valor * Val(Display.Text)
            flag_mult = False

        ElseIf flag_dividir = True Then
            If Val(Display.Text) = 0 Then
                Display.Text = "Cannot divide by 0"
                flag_clear = True
                clear_operaciones = True
                flag_dividir = False
            Else
                Display.Text = valor / Val(Display.Text)
                flag_dividir = False
            End If
        End If

        valor = Val(Display.Text)
        flag_clear = True
        flag_dividir = True
        BotonDecimal.Enabled = True

    End Sub

    Private Sub BotonDecimal_Click(sender As Object, e As EventArgs) Handles BotonDecimal.Click
        If flag_clear = True Then
            Display.Text = ""
            flag_clear = False
        End If

        If Val(Display.Text) = 0 Then
            Display.Text = "0."
            flag_clear = False
            BotonDecimal.Enabled = False
        Else
            Display.Text = Display.Text & "."
            BotonDecimal.Enabled = False
        End If

    End Sub

    Private Sub numero1_sobreX_Click(sender As Object, e As EventArgs) Handles numero1_sobreX.Click
        flag_clear = True
        BotonDecimal.Enabled = True
        flag_OperacionEspecial = True

        If flag_resultado = False Then
            Operaciones.Text = Operaciones.Text & "1/(" & Display.Text & ")"
        ElseIf flag_resultado = True Then
            Operaciones.Text = "1/(" & Display.Text & ")"
            flag_resultado = False
            flag_clear = False
            clear_operaciones = False
        End If

        If Val(Display.Text) = 0 Then
            Display.Text = "Cannot divide by 0"
            flag_clear = True
            clear_operaciones = True
        Else
            sizeInput = Len(Display.Text)
            clear_1Sobre_X = True
            clearPorciento = False
            clearRaiz = False
            Display.Text = 1 / Val(Display.Text)
        End If
    End Sub

    Private Sub BotonPorciento_Click(sender As Object, e As EventArgs) Handles BotonPorciento.Click
        flag_clear = True
        BotonDecimal.Enabled = True
        flag_OperacionEspecial = True

        If flag_resultado = False Then
            Operaciones.Text = Operaciones.Text & Display.Text & "/(100)"
        ElseIf flag_resultado = True Then
            Operaciones.Text = Display.Text & "/(100)"
            flag_resultado = False
            flag_clear = False
            clear_operaciones = False
        End If

        sizeInput = Len(Display.Text)
        clearPorciento = True
        clear_1Sobre_X = False
        clearRaiz = False
        Display.Text = Display.Text / 100
    End Sub

    Private Sub BotonRaizCuadrada_Click(sender As Object, e As EventArgs) Handles BotonRaizCuadrada.Click
        flag_clear = True
        BotonDecimal.Enabled = True
        flag_OperacionEspecial = True

        If flag_resultado = False Then
            Operaciones.Text = Operaciones.Text & "√(" & Display.Text & ")"
        ElseIf flag_resultado = True Then
            Operaciones.Text = "√(" & Display.Text & ")"
            flag_resultado = False
            flag_clear = False
            clear_operaciones = False
        End If

        If Val(Display.Text) < 0 Then
            Display.Text = "Invalid Input"
            flag_clear = True
            clear_operaciones = True
        Else
            sizeInput = Len(Display.Text)
            clearRaiz = True
            clear_1Sobre_X = False
            clearPorciento = False
            Display.Text = Math.Sqrt(Display.Text)
        End If
    End Sub

    Private Sub BotonPositivoNegativo_Click(sender As Object, e As EventArgs) Handles BotonPositivoNegativo.Click

        Display.Text = Display.Text * -1

    End Sub

    Private Sub Clear_All_Input_Click(sender As Object, e As EventArgs) Handles Clear_All_Input.Click
        flag_clear = True
        clear_operaciones = True
        BotonDecimal.Enabled = True
        flag_suma = False
        flag_resta = False
        flag_mult = False
        flag_dividir = False
        flag_OperacionEspecial = False
        Display.Text = ""
        Operaciones.Text = ""
    End Sub

    Private Sub Clear_Entry_Click(sender As Object, e As EventArgs) Handles Clear_Entry.Click
        BotonDecimal.Enabled = True
        Dim temporal As String

        If clear_1Sobre_X = True Then
            Operaciones.Text = Operaciones.Text.Replace("1/(", "").Replace(")", "")
            temporal = Operaciones.Text.Remove(Operaciones.Text.Length - sizeInput)
            Operaciones.Text = temporal
            Display.Text = ""
            flag_OperacionEspecial = False
            clear_1Sobre_X = False

        ElseIf clearPorciento = True Then
            Operaciones.Text = Operaciones.Text.Replace("/(100)", "")
            temporal = Operaciones.Text.Remove(Operaciones.Text.Length - sizeInput)
            Operaciones.Text = temporal
            Display.Text = ""
            flag_OperacionEspecial = False
            clearPorciento = False

        ElseIf clearRaiz = True Then
            Operaciones.Text = Operaciones.Text.Replace("√(", "").Replace(")", "")
            temporal = Operaciones.Text.Remove(Operaciones.Text.Length - sizeInput)
            Operaciones.Text = temporal
            Display.Text = ""
            flag_OperacionEspecial = False
            clearRaiz = False

        ElseIf clear_operaciones = True Then
            Operaciones.Text = ""
            Display.Text = ""
            clear_operaciones = False

        Else
            Display.Text = ""

        End If

    End Sub

    Private Sub Boton_Retroceder_Click(sender As Object, e As EventArgs) Handles Boton_Retroceder.Click
        If Len(Display.Text) = 1 Then
            Display.Text = ""
        Else
            Display.Text = Display.Text.Remove(Display.Text.Length - 1)
        End If

    End Sub

    Private Sub Memory_Store_Click(sender As Object, e As EventArgs) Handles Memory_Store.Click
        BotonDecimal.Enabled = True

        memoria = Val(Display.Text)
        flag_clear = True

        If memoria <> 0 Then
            EtiquetaM.Text = "M"
        End If
    End Sub

    Private Sub Memory_Recall_Click(sender As Object, e As EventArgs) Handles Memory_Recall.Click
        Display.Text = memoria
        flag_clear = True
    End Sub

    Private Sub Memory_Add_Click(sender As Object, e As EventArgs) Handles Memory_Add.Click
        BotonDecimal.Enabled = True

        memoria = memoria + Val(Display.Text)
        flag_clear = True

        If memoria <> 0 Then
            EtiquetaM.Text = "M"
        End If
    End Sub

    Private Sub Memory_Substract_Click(sender As Object, e As EventArgs) Handles Memory_Substract.Click
        BotonDecimal.Enabled = True

        memoria = memoria - Val(Display.Text)
        flag_clear = True

        If memoria <> 0 Then
            EtiquetaM.Text = "M"
        End If
    End Sub

    Private Sub Memory_Clear_Click(sender As Object, e As EventArgs) Handles Memory_Clear.Click
        BotonDecimal.Enabled = True

        memoria = 0
        EtiquetaM.Text = ""
    End Sub

    Private Sub StandardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StandardToolStripMenuItem.Click
        TextBox1.Visible = False
    End Sub

    Private Sub HistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistoryToolStripMenuItem.Click
        Dim history As String = ""
        TextBox1.Visible = True

        For Each elem As String In historyList
            history &= elem & " " & vbNewLine
            TextBox1.Text = history
        Next
    End Sub

    Private Sub ClearHistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearHistoryToolStripMenuItem.Click
        TextBox1.Clear()
        historyList.Clear()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        copy = Val(Display.Text)
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        Display.Text = copy
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("Visual Oriented Programming Proyecto #1" & vbNewLine &
               "Calculadora hecha por Gabriel Eduardo Gonzalez Ortiz",
                MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informacion Sobre Calculadora")
    End Sub
End Class
