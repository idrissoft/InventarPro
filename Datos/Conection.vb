Imports System.Data.SqlClient

Public Class Conection
    Public con As New SqlConnection
    Public Function Conectado()
        Try
            con = New SqlConnection("server=DESKTOP-N0AAU33\SQLEXPRESS; database=InventarPro; integrated security=true")
            con.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Protected Function Desconectado()
        Try
            If con.State = ConnectionState.Open Then
                con.Close()

                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function


End Class
