Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim I As Integer = 0
        Dim TotalRepeticiones As Integer = CInt(TextBox1.Text)
        For I = 1 To TotalRepeticiones
            MessageBox.Show("Esta linea de codigo ha sido repetida " & I & " veces", "Atención")
        Next
    End Sub





    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim CONTADOR As Integer = 0
        Dim SUMA As Integer = 0
        Do While SUMA < 500
            SUMA = SUMA + CInt(TextBox2.Text)
            CONTADOR = CONTADOR + 1
        Loop
        MessageBox.Show("Este número se ha sumado " & CStr(CONTADOR) & " veces antes de llegar a 500", "Atención")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim CONTADOR1 As Integer = 0
        Dim SUMA1 As Integer = 0
        Do Until SUMA1 >= 500
            SUMA1 = SUMA1 + CInt(TextBox3.Text)
            CONTADOR1 = CONTADOR1 + 1
        Loop
        MessageBox.Show("Este número se ha sumado a si mismo " & CStr(CONTADOR1) & " veces antes de llegar a 500", "Atención")
    End Sub




    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        TextBox1.Text = ""
    End Sub


    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles TextBox2.Click
        TextBox2.Text = ""
    End Sub


    Private Sub TextBox3_Click(sender As Object, e As EventArgs) Handles TextBox3.Click
        TextBox3.Text = ""
    End Sub
End Class
