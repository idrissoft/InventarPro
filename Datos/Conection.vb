Imports System.Data.SqlClient

Public Class Conection
    Protected con As New SqlConnection
    Protected Function conectado()
        Try
            con = New SqlConnection("server=DESKTOP-N0AAU33\SQLEXPRESS; database=InventarPro; integrated security=true")
            con.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Protected Function desconectado()
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
