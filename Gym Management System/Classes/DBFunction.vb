Imports System.Data
Imports System.Data.SqlClient
Imports Gym_Management_System.DBConnection
Imports Gym_Management_System.SplashScreenClass
Imports System.Text.RegularExpressions

Public Class DBFunction

#Region "Declaration"
    Dim objDb As New DBConnection
    Dim Con As New SqlConnection
    Dim command As New SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    ' Dim frmStd As frmStudent
    Dim dvResort As New DataView
    Dim str As String
    Dim dr As SqlDataReader
#End Region

#Region "Dislay"
    Public Sub Display(ByVal Dgview As DataGridView, ByVal Query As String)
        Try
            Dgview.DataSource = 0
            conn.Open()
            da = New SqlDataAdapter(Query, conn)
            Dim sqlds As New DataSet
            da.Fill(sqlds)
            Dgview.DataSource = sqlds.Tables(0)
            Dgview.Columns(0).Visible = True
            Dgview.Refresh()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "SelectQuery"
    Public Function SelectQuery(ByVal Query As String)
        Dim ds_select As New DataSet
        Try
            Con = objDb.SetConnection
            Con.Open()
            da = New SqlDataAdapter(Query, Con)
            da.Fill(ds_select)
            Con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return ds_select
    End Function
#End Region

#Region "Reader"
    Public Function Reader(ByVal Query As String)
        'Dim dr As SqlDataAdapter
        Con = objDb.SetConnection()
        Con.Open()
        da = New SqlDataAdapter(Query, Con)
        command = New SqlCommand(Query, Con)
        dr = command.ExecuteReader
        Return dr
    End Function
#End Region

#Region "BindCombo"
    Public Function BindCombo(ByVal Query As String, ByVal cmb As ComboBox)
        Try
            Dim ds As New DataSet

            Con = objDb.SetConnection()
            Con.Open()
            da = New SqlDataAdapter(Query, Con)
            da.Fill(ds)
            cmb.DataSource = ds.Tables(0)
            cmb.DisplayMember = ds.Tables(0).Columns(1).ToString()
            cmb.ValueMember = ds.Tables(0).Columns(0).ToString()
            Con.Close()
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try

        Return ds
    End Function
#End Region

#Region "GetMaxValue"
    Public Function GetMaxValue(ByVal Query As String)
        Dim value As Integer
        Try
            Con = objDb.SetConnection()
            Con.Open()
            command = New SqlCommand(Query, Con)
            value = command.ExecuteScalar()
            Con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return value
    End Function
#End Region
#Region "ContactsNoValidation"
    Public Function numval(ByVal val As Integer) As Byte
        If val Like "8" Then
            numval = val
            Exit Function
        End If
        If Not Chr(val) Like "[0-9]" Then
            val = 0
        Else
            numval = val
        End If
    End Function
#End Region

#Region "CheckEmail"
    Public Function EmailAddressCheck(ByVal emailAddress As String) As Boolean

        Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"

        Dim emailAddressMatch As Match = Regex.Match(emailAddress, pattern)

        If emailAddressMatch.Success Then
            EmailAddressCheck = True
        Else
            EmailAddressCheck = False
        End If
    End Function
#End Region
#Region "CheckName"
    Public Function TextOnly(ByVal val As Integer) As Byte
        If val Like "8" Then
            TextOnly = val
            Exit Function
        End If
        If Not Chr(val) Like "[a-zA-Z.  ' ' ]" Then
            val = 0
        Else
            TextOnly = val
        End If
    End Function
#End Region

End Class
