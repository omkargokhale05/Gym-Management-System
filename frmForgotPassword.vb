Imports System.Data.SqlClient
Imports Gym_Management_System
Public Class frmForgotPassword
#Region "Declare"

    Dim objDb As New DBConnection
    Dim Con As New SqlConnection
    Dim command As New SqlCommand
    Dim a, cnt As Integer
    Dim c As String
    Dim cls As LoginClass
    Dim clsDBFun As New DBFunction
    Dim b, query, x, z As String
    Dim count As Integer
    Dim read, dr As SqlDataReader

    Private Sub frmForgotPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
#End Region
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGenerateQuestion.Click
        Try
            b = txtUserName.Text
            c = b
            Dim a As String

            query = "select Question from LoginTable where UserName='" & b & "'"
            Dim ds As New DataSet
            ds = clsDBFun.SelectQuery(query)
            count = ds.Tables(0).Rows.Count
            a = ds.Tables(0).Rows(0).Item(0).ToString
            txtQuestion.Text = a
        Catch q As SqlException
            MsgBox("Invalid User")
        End Try
    End Sub



    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtUserName.Clear()
        txtQuestion.Clear()
        txtAnswer.Clear()
        txtPassword.Clear()
        txtConfirmPassword.Clear()

    End Sub


    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        b = txtAnswer.Text
        query = "select Question from LoginTable where Answer='" & b & "'"
        Dim ds1 As New DataSet
        ds1 = clsDBFun.SelectQuery(query)
        count = ds1.Tables(0).Rows.Count
        If count > 0 Then
            x = txtPassword.Text
            z = txtConfirmPassword.Text
            If x = z Then

                query = "Update LoginTable set Password='" & x & "' where UserName='" & c & "'"
                Con = objDb.SetConnection()
                Con.Open()
                command = New SqlCommand(query, Con)
                count = command.ExecuteNonQuery
                MsgBox(count.ToString + " Updated Successfully")
            Else
                MsgBox("Password dosent match")
            End If
        ElseIf count = 0 Then

            MsgBox("Security Answer Is Wrong")
        End If
    End Sub
End Class