Imports System.Data
Imports System.Data.SqlClient
Public Class DBConnection
    Public Shared conn As SqlConnection

    Public Function SetConnection()
        Try
            conn = New SqlConnection("Data Source=DESKTOP-NOI2A00\SQLEXPRESS;Initial Catalog=GymMgmt;Integrated Security=True")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return conn
    End Function

    Public Function CreateCommand(ByVal con As SqlConnection, ByVal query As String)
        Dim cmd As New SqlCommand
        cmd.Connection = con
        cmd.CommandText = query
        Return cmd
    End Function

End Class
