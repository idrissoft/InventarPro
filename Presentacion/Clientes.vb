Public Class Clientes

    Dim Eclient As New Eclientes
    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim _cliente As New Dclientes
        DataGridView_clientes.DataSource = _cliente.Get_clientes()
        CenterToParent()
    End Sub
    Dim nombres() As Integer
    Private Sub Sumar_Click(sender As Object, e As EventArgs) Handles Sumar.Click

        Dim lines() As String = TextBox1.Lines
        Dim sum As Integer = 0
        Dim num As Integer

        For Each nbre As String In lines

            If Integer.TryParse(CStr(nbre), num) Then

                sum += num ' مجموع 

            End If
        Next
        TextBox2.Text = CStr(sum)

    End Sub

    Private Sub multiplicar_Click(sender As Object, e As EventArgs) Handles multiplicar.Click
        Dim lines() As String = TextBox1.Lines
        Dim mult As Integer = 1
        Dim num As Integer

        For Each nbre As String In lines

            If Integer.TryParse(CStr(nbre), num) Then

                mult = num * mult

            End If
        Next
        TextBox2.Text = CStr(mult)
    End Sub
End Class