Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Try
            Dim nota1 As Integer
            Dim nota2 As Integer
            Dim promedio As Double
            Dim mensaje As String
            nota1 = CInt(txtNota1.Text)
            nota2 = CInt(txtNota2.Text)

            If nota1 < 0 Or nota1 > 100 Then
                MessageBox.Show("La Nota 1 debe ser mayor o igual a 0 y menor o igual a 100", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf nota2 < 0 Or nota2 > 100 Then
                MessageBox.Show("La Nota 2 debe ser mayor o igual a 0 y menor o igual a 100", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                promedio = CDbl(((nota1 + nota2) / 2))
                mensaje = IIf((promedio >= 70), "Aprobado", "Reporbado")
                txtPromedio.Text = promedio.ToString("00.00") + " %"
                txtResultado.Text = mensaje
            End If
        Catch ex As Exception
            MessageBox.Show("Ocurrio un Error: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_Nuevo_Click(sender As Object, e As EventArgs) Handles btn_Nuevo.Click
        txtNota1.Text = ""
        txtNota2.Text = ""
        txtPromedio.Text = ""
        txtResultado.Text = ""
    End Sub
End Class
