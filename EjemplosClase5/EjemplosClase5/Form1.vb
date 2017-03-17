Public Class Form1

    Dim figura As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim area As Integer
        Select Case figura
            Case 0
                area = Int(txtLado1.Text) * Int(txtLado1.Text)
            Case 1
                area = Int(txtLado1.Text) * Int(txtLado2.Text)
            Case 2
                area = (Int(txtLado1.Text) * Int(txtLado2.Text)) / 2
            Case 3
                area = Int(txtLado1.Text) * Int(txtLado2.Text)

        End Select
        txtRespuesta.Visible = True
        txtRespuesta.Text = "El área de la figura es " & area
    End Sub

    Private Sub cbxFigura_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxFigura.SelectedIndexChanged
        figura = cbxFigura.SelectedIndex()

        Select Case figura
            Case 0
                txtLado1.Visible = True
                txtLado1.Text = "0"
                lblLado1.Visible = True
                lblLado1.Text = "Lado"
            Case 1
                txtLado1.Visible = True
                txtLado1.Text = "0"
                txtLado2.Visible = True
                txtLado2.Text = "0"
                lblLado1.Visible = True
                lblLado1.Text = "Largo"
                lblLado2.Visible = True
                lblLado2.Text = "Ancho"
            Case 2
                txtLado1.Visible = True
                txtLado1.Text = "0"
                txtLado2.Visible = True
                txtLado2.Text = "0"
                lblLado1.Visible = True
                lblLado1.Text = "Base"
                lblLado2.Visible = True
                lblLado2.Text = "Altura"
            Case 3
                txtLado1.Visible = True
                txtLado1.Text = "0"
                txtLado2.Visible = True
                txtLado2.Text = "0"
                lblLado1.Visible = True
                lblLado1.Text = "Base"
                lblLado2.Visible = True
                lblLado2.Text = "Altura"
        End Select



    End Sub

    Function fibonacci(n As Integer) As Integer
        Dim i As Integer = 0
        Dim j As Integer = 1
        Dim t As Integer
        For index = 1 To n - 1
            t = i + j
            i = j
            j = t
        Next
        Return j
    End Function


    Sub dividir()
        Dim vec() As String
        vec = Split("Year/Month/Day Hours:Minutes:Seconds.Milliseconds", " ")
        Dim str As String = "casa"
        Dim resp As String = ""

        For index = 1 To str.Length
            resp += Mid(str, index, 1)
        Next

    End Sub


    Function buscar(palabra As String, letra As String) As Integer
        Dim posicion As Integer = -1
        Dim index As Integer = 1
        Dim bandera As Boolean = False

        While index <= palabra.Length And bandera = False
            If letra = Mid(palabra, index, 1) Then
                posicion = index
                bandera = True
            End If
            index += 1
        End While

        Return posicion
    End Function


    Function comparar(palabra1 As String, palabra2 As String) As Integer
        Dim resp As Integer = 0
        If palabra1.Length = palabra2.Length Then
            Dim index As Integer = 0
            While palabra1.Chars(index) = palabra2.Chars(index) And index < palabra1.Length - 1
                index = index + 1
            End While
            If index = palabra2.Length - 1 Then
                resp = 1
            End If
        End If
        Return resp
    End Function

    Private Sub txtFibo_Click(sender As Object, e As EventArgs) Handles txtFibo.Click
        'txtRespuesta.Text = fibonacci(Int(txtRespuesta.Text))
        'dividir()
        'Dim vec() As String = Split(txtRespuesta.Text, ",")
        'txtRespuesta.Text = buscar(vec(0), vec(1))
        comparar("casa", "casa")
        Dim ch As Char = txtRespuesta.Text.Chars(1)
    End Sub
End Class
