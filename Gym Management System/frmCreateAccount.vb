Imports Gym_Management_System.LoginClass
Imports Gym_Management_System.Controller
Imports System.Data
Imports System.Data.SqlClient
Public Class frmCreateAccount

#Region "Declaration"

    Dim clsLogin As New LoginClass
    Dim cntr As New Controller
    Dim clsDBFun As New DBFunction
    Dim clsCon As New DBConnection

#End Region
    Private Sub frmCreateAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cntr.GenerateLoginID()
        cntr.ClearTextCreateAccount()

    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim a, b As String
        clsLogin.CheckTextCreateAccount()
        a = txtPassword.Text
        b = txtConfirmPassword.Text
        If a.Equals(b) Then
            If clsLogin.flag = True Then
                cntr.AddAccount(txtLoginID.Text, txtUserName.Text, txtPassword.Text, txtQuestion.Text, txtAnswer.Text)
                'cntr.DisplayDataHealthCheckUp()
                cntr.ClearTextCreateAccount()
            Else
                clsLogin.flag = True
            End If
        Else
            MsgBox("Password Does Not Match")
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtUserName.Clear()
        txtQuestion.Clear()
        txtAnswer.Clear()
        txtPassword.Clear()
        txtConfirmPassword.Clear()
        txtLoginID.Clear()
        cntr.GenerateLoginID()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class