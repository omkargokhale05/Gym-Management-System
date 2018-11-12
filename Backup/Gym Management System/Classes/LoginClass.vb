Imports System.Data.SqlClient
Imports System.Data

Public Class LoginClass

#Region "Declartion"
    Dim i As Integer
    Dim count As Integer
    Dim query As String
    Dim clsDBFun As New DBFunction
    Dim clscon As New DBConnection
    Dim conn As New SqlConnection
    Dim cmd As New SqlCommand
    Dim adap As New SqlDataAdapter
    Dim ds As New DataSet

#End Region

#Region "Login Button"

    Public Sub LoginButton()
        query = "select * from LoginTable where UserName='" & Trim(frmLogin.txtUserName.Text) & "' and Password='" & Trim(frmLogin.txtPassword.Text) & "'"
        Dim ds As New DataSet
        ds = clsDBFun.SelectQuery(query)
        count = ds.Tables(0).Rows.Count
        If count = 0 Then
            'frmLogin.lbl_result.Visible = True
            'frmLogin.lbl_result.Text = "Invalid Login."
            i = i + 1
            If i > 2 Then
                MsgBox("Login Failed")
                End
            End If
            frmLogin.txtUsername.Text = ""
            frmLogin.txtPassword.Text = ""
            frmLogin.txtUsername.Focus()
        Else
            frmLogin.Hide()
            frmMainMDI.ShowDialog()
            frmLogin.Close()
        End If
    End Sub

#End Region

End Class
