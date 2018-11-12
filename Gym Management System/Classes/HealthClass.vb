Imports System.Data
Imports System.Data.SqlClient
Imports Gym_Management_System.DBConnection
Imports Gym_Management_System.DBFunction
Imports Gym_Management_System.HealthClass
Public Class HealthClass

#Region "Declaration of variables"

    'Declaring SQL variables
    Dim objDb As New DBConnection
    Dim Con As New SqlConnection
    Dim command As New SqlCommand
    Dim da As New SqlDataAdapter
    Public ds As New DataSet
    Dim str As String

    Public dvHealth As DataView
    Public clsDbFun As New DBFunction
    Public currentRow As Integer

    Public flag As Boolean = True
    'Declaring Health variables

    Private _HealthID As String
    Public Property HealthID() As String
        Get
            Return _HealthID
        End Get
        Set(ByVal value As String)
            _HealthID = value
        End Set
    End Property
    Private _Height As String
    Public Property Height() As String
        Get
            Return _Height
        End Get
        Set(ByVal value As String)
            _Height = value
        End Set
    End Property

    Private _Weight As String
    Public Property Weight() As String
        Get
            Return _Weight
        End Get
        Set(ByVal value As String)
            _Weight = value
        End Set
    End Property

    Private _HeartBeat As String
    Public Property HeartBeat() As String
        Get
            Return _HeartBeat
        End Get
        Set(ByVal value As String)
            _HeartBeat = value
        End Set
    End Property

    Private _BMI As String
    Public Property BMI() As String
        Get
            Return _BMI
        End Get
        Set(ByVal value As String)
            _BMI = value
        End Set
    End Property
    Private _Chest As String
    Public Property Chest() As String
        Get
            Return _Chest
        End Get
        Set(ByVal value As String)
            _Chest = value
        End Set
    End Property
    Private _Waist As String
    Public Property Waist() As String
        Get
            Return _Waist
        End Get
        Set(ByVal value As String)
            _Waist = value
        End Set
    End Property
    Private _Biceps As String
    Public Property Biceps() As String
        Get
            Return _Biceps
        End Get
        Set(ByVal value As String)
            _Biceps = value
        End Set
    End Property
#End Region

#Region "Display Data"

    Public Sub DisplayDataHealth()
        Try
            Con = objDb.SetConnection()
            command.CommandText = ("exec DisplayDataHealth")
            command = objDb.CreateCommand(Con, command.CommandText)
            da = New SqlDataAdapter(command.CommandText, Con)
            ds = New DataSet
            da.Fill(ds, "Health")
            dvHealth = New DataView(ds.Tables("Health"))
            Con.Open()
            command.ExecuteReader()
            Con.Close()
            frmHealthDetails.dgHealthShow.DataSource = dvHealth

        Catch ex As Exception

        End Try
    End Sub

#End Region

#Region "Generate ID"

    Public Sub GenerateHealthId()

        Con = objDb.SetConnection()
        command.CommandText = ("exec GenerateHealthID")
        command = objDb.CreateCommand(Con, command.CommandText)
        Con.Open()
        Dim dr As SqlDataReader = command.ExecuteReader

        While dr.Read
            frmHealthDetails.txtHealthID.Text = dr(0)
        End While
        frmHealthDetails.txtHealthID.Text = Val(frmHealthDetails.txtHealthID.Text) + 1
        dr.Close()
        Con.Close()
    End Sub
#End Region

#Region "Check Textboxes"

    Public Sub CheckTextHealth()

        Try
            If frmHealthDetails.txtHeight.Text.Trim() = String.Empty Then
                MessageBox.Show("Please enter Height..!!")
                flag = False
            ElseIf frmHealthDetails.txtWeight.Text.Trim() = String.Empty Then
                MessageBox.Show("Please enter Weight..!!")
                flag = False
            ElseIf frmHealthDetails.txtHeartBeat.Text.Trim() = String.Empty Then
                MessageBox.Show("Please enter Heart Beat..!!")
                flag = False
            ElseIf frmHealthDetails.txtBMI.Text.Trim() = String.Empty Then
                MessageBox.Show("Please enter BMI..!!")
                flag = False
            ElseIf frmHealthDetails.txtChestSize.Text.Trim() = String.Empty Then
                MessageBox.Show("Please enter Chest Size..!!")
                flag = False
            ElseIf frmHealthDetails.txtWaistSize.Text.Trim() = String.Empty Then
                MessageBox.Show("Please enter Wiast Size..!!")
                flag = False
            ElseIf frmHealthDetails.txtBicepSize.Text.Trim() = String.Empty Then
                MessageBox.Show("Please enter Bicep Size..!!")
                flag = False

            End If

        Catch ex As Exception

        End Try

    End Sub

#End Region

#Region "Adding Health"
    'Adding Health
    Public Sub AddHealthDtls(ByVal HealthID, ByVal Height, ByVal Weight, ByVal HeartBeat, ByVal BMI, ByVal Chest, ByVal Waist, ByVal Biceps)
        Try
            Con = objDb.SetConnection()
            command.CommandText = ("exec AddHealthDtls '" & HealthID & "','" & Height & "','" & Weight & "','" & HeartBeat & "','" & BMI & "','" & Chest & "','" & Waist & "','" & Biceps & "'")
            command = objDb.CreateCommand(Con, command.CommandText)

            Con.Open()
            command.ExecuteNonQuery()
            Con.Close()
            MessageBox.Show("Health Details Added Successfully!!!", "Confirmation...(Gym Management System)", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ClearTextHealth()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error in Adding Health")

        End Try
    End Sub
#End Region

#Region "Updating Health"

    'Updating Health
    Public Sub UpdateHealthDtls(ByVal HealthID, ByVal Height, ByVal Weight, ByVal HeartBeat, ByVal BMI, ByVal Chest, ByVal Waist, ByVal Biceps)
        Try
            Con = objDb.SetConnection()
            command.CommandText = ("exec UpdateHealthDtls '" & HealthID & "','" & Height & "','" & Weight & "','" & HeartBeat & "','" & BMI & "','" & Chest & "','" & Waist & "','" & Biceps & "'")
            command = objDb.CreateCommand(Con, command.CommandText)

            Con.Open()
            command.ExecuteNonQuery()
            Con.Close()
            MessageBox.Show("Health Details Updated Successfully!!!", "Confirmation...(Gym Management System)", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ClearTextHealth()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error in Updating Health")
        End Try
    End Sub
#End Region

#Region "Clear Textboxes"

    Public Sub ClearTextHealth()

        With frmHealthDetails
            .txtHealthID.Clear()
            .txtHeight.Clear()
            .txtWeight.Clear()
            .txtBMI.Clear()
            .txtHeartBeat.Clear()
            .txtChestSize.Clear()
            .txtWaistSize.Clear()
            .txtBicepSize.Clear()
        End With
    End Sub
#End Region

#Region "Binding Navigator"

    Public Sub navigationHealth()
        Try
            ds = New DataSet
            currentRow = 0
            Con = objDb.SetConnection()
            command.CommandText = ("exec BindHealth")
            command = objDb.CreateCommand(Con, command.CommandText)
            da = New SqlDataAdapter(command.CommandText, Con)
            da.Fill(ds, "HD")
            ShowDataHealth(currentRow)
        Catch ex As Exception

        End Try

    End Sub
    Public Sub ShowDataHealth(ByVal currentRow)

        Try
            frmHealthDetails.txtHealthID.Text = ds.Tables("HD").Rows(currentRow).Item(0)
            frmHealthDetails.txtHeight.Text = ds.Tables("HD").Rows(currentRow).Item(1)
            frmHealthDetails.txtWeight.Text = ds.Tables("HD").Rows(currentRow).Item(2)
            frmHealthDetails.txtHeartBeat.Text = ds.Tables("HD").Rows(currentRow).Item(3)
            frmHealthDetails.txtBMI.Text = ds.Tables("HD").Rows(currentRow).Item(4)
            frmHealthDetails.txtChestSize.Text = ds.Tables("HD").Rows(currentRow).Item(5)
            frmHealthDetails.txtWaistSize.Text = ds.Tables("HD").Rows(currentRow).Item(6)
            frmHealthDetails.txtBicepSize.Text = ds.Tables("HD").Rows(currentRow).Item(7)
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Cell Click"

    Public Sub CellClickHealth(ByVal e As Object)

        Try
            frmHealthDetails.txtHealthID.Text = frmHealthDetails.dgHealthShow.Rows(e.rowindex).Cells(0).Value
            frmHealthDetails.txtHeight.Text = frmHealthDetails.dgHealthShow.Rows(e.rowindex).Cells(1).Value
            frmHealthDetails.txtWeight.Text = frmHealthDetails.dgHealthShow.Rows(e.rowindex).Cells(2).Value
            frmHealthDetails.txtHeartBeat.Text = frmHealthDetails.dgHealthShow.Rows(e.rowindex).Cells(3).Value
            frmHealthDetails.txtBMI.Text = frmHealthDetails.dgHealthShow.Rows(e.rowindex).Cells(4).Value
            frmHealthDetails.txtChestSize.Text = frmHealthDetails.dgHealthShow.Rows(e.rowindex).Cells(5).Value
            frmHealthDetails.txtWaistSize.Text = frmHealthDetails.dgHealthShow.Rows(e.rowindex).Cells(6).Value
            frmHealthDetails.txtBicepSize.Text = frmHealthDetails.dgHealthShow.Rows(e.rowindex).Cells(7).Value
        Catch ex As Exception

        End Try
    End Sub
#End Region

End Class
