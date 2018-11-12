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

#Region "Declaration of variables"

    'Declaring SQL variables
    Dim objDb As New DBConnection
    Dim Con As New SqlConnection
    Dim command As New SqlCommand
    Dim da As New SqlDataAdapter
    'Dim dr As New SqlDataReader
    Public ds1 As New DataSet
    Dim str As String

    ' Public dvHealthCheckUp As DataView
    Public clsDbFun1 As New DBFunction
    Public currentRow As Integer

    Public flag As Boolean = True
    'Declaring HealthCheckUp variables

    Private _LoginID As String
    Public Property LoginID() As String
        Get
            Return _LoginID
        End Get
        Set(ByVal value As String)
            _LoginID = value
        End Set
    End Property
    Private _UserName As String
    Public Property UserName() As String
        Get
            Return _UserName
        End Get
        Set(ByVal value As String)
            _UserName = value
        End Set
    End Property

    Private _Password As String
    Public Property Password() As String
        Get
            Return _Password
        End Get
        Set(ByVal value As String)
            _Password = value
        End Set
    End Property

    Private _Question As String
    Public Property Question() As String
        Get
            Return _Question
        End Get
        Set(ByVal value As String)
            _Question = value
        End Set
    End Property

    Private _Answer As String
    Public Property Answer() As String
        Get
            Return _Answer
        End Get
        Set(ByVal value As String)
            _Answer = value
        End Set
    End Property
#End Region

#Region "Generate ID"

    Public Sub GenerateLoginID()

        Con = objDb.SetConnection()
        command.CommandText = ("exec GenerateLoginID")
        command = objDb.CreateCommand(Con, command.CommandText)
        Con.Open()
        Dim dr As SqlDataReader = command.ExecuteReader
        '  Try
        While dr.Read

            frmCreateAccount.txtLoginID.Text = dr(0)
            ' If (dr(0).Equals(0)) Then
            'frmHealthCheckUp.txtHealthID.Text = dr(0) + 1
            'End If
        End While
        ' Catch ex As Exception
        'frmHealthCheckUp.txtHealthID.Text = 0
        'End Try

        frmCreateAccount.txtLoginID.Text = Val(frmCreateAccount.txtLoginID.Text) + 1
        dr.Close()
        Con.Close()
    End Sub
#End Region

#Region "Check Textboxes"

    Public Sub CheckTextCreateAccount()

        Try
            If frmCreateAccount.txtUserName.Text.Trim() = String.Empty Then
                MessageBox.Show("Please enter User Name..!!")
                flag = False
            ElseIf frmCreateAccount.txtPassword.Text.Trim() = String.Empty Then
                MessageBox.Show("Please enter Password..!!")
                flag = False
            ElseIf frmCreateAccount.txtConfirmPassword.Text.Trim() = String.Empty Then
                MessageBox.Show("Please ReEnter Password..!!")
                flag = False
            ElseIf frmCreateAccount.txtQuestion.Text.Trim() = String.Empty Then
                MessageBox.Show("Please enter Security Question..!!")
                flag = False
            ElseIf frmCreateAccount.txtAnswer.Text.Trim() = String.Empty Then
                MessageBox.Show("Please enter Answer..!!")
                flag = False
            End If

        Catch ex As Exception
        End Try
    End Sub
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

#Region "Adding Account"
    'Adding Account
    Public Sub AddAccount(ByVal LoginID, ByVal UserName, ByVal Password, ByVal Question, ByVal Answer)
        Try
            Con = objDb.SetConnection()
            command.CommandText = ("exec AddAccount '" & LoginID & "','" & UserName & "','" & Password & "','" & Question & "','" & Answer & "'")
            command = objDb.CreateCommand(Con, command.CommandText)

            Con.Open()
            command.ExecuteNonQuery()
            Con.Close()
            MessageBox.Show("Account Created Successfully!!!", "Confirmation...(Gym Management System)", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ClearTextCreateAccount()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error in Creating Account")

        End Try
    End Sub
#End Region

#Region "Clear Textboxes"

    Public Sub ClearTextCreateAccount()

        With frmCreateAccount
            .txtLoginID.Text = String.Empty
            .txtUserName.Text = String.Empty
            .txtPassword.Clear()
            .txtConfirmPassword.Text = String.Empty

            .txtQuestion.Clear()
            .txtAnswer.Clear()

        End With
    End Sub
#End Region

End Class
