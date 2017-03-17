Public Class Form1
    'Ejercicio 1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtRespuesta.Text = invertir(txtParametro.Text)
    End Sub

    Function invertir(hilera As String) As String
        Dim resp As String = ""
        'el step -1 es para indicar que vaya decrementando el contador
        'en lugar de incrementarlo.
        For index = hilera.Length To 1 Step -1
            resp = resp + Mid(hilera, index, 1)
        Next
        Return resp
    End Function

    'Ejercicio 2
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim vec() As String = Split(txtParametro.Text, ",")
        txtRespuesta.Text = buscar(vec(0), vec(1))
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

    'Ejercicio 3
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim resp As String = ""
        Dim vec() As String = palabras(txtParametro.Text)
        For index = 1 To vec.Length - 1
            resp += vec(index)
            resp += ", "
        Next
        txtRespuesta.Text = resp
    End Sub

    Function palabras(hilera As String) As String()

        Return Split(hilera, " ")

    End Function

    'Ejercicio 4: Resuélvanlo utilizando la función Split 
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

    End Sub

    'Ejercicio 5
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim vec() As String = Split(txtParametro.Text, ",")
        txtRespuesta.Text = comparar(vec(0), vec(1))
    End Sub

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

    'Ejercicio 6
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        txtRespuesta.Text = quitarBlancos(txtParametro.Text)
    End Sub

    Function quitarBlancos(hilera As String) As String
        Dim resp As String = ""

        For index = 0 To hilera.Length - 1
            If hilera.Chars(index) <> " " Then
                resp = resp + hilera.Chars(index)
            End If
        Next
        Return resp
    End Function

    'Ejercicio 7
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        txtRespuesta.Text = quitarRepetidos(txtParametro.Text)
    End Sub

    Function quitarRepetidos(hilera As String) As String
        Dim resp As String = ""
        'Utilizamos la función buscar que ya habíamos creado 
        'para verificar que no se encuentra en el String
        'en el que estabamos guardando los caracteres que no
        'están repetidos.
        For index = 0 To hilera.Length - 1
            If buscar(resp, hilera.Chars(index)) = -1 Then
                resp = resp + hilera.Chars(index)
            End If
        Next
        Return resp
    End Function

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim vector(5) As Integer
        Dim s As String = ""
        For index = 1 To vector.Length
            s = s + vector(index)
        Next

    End Sub
End Class
