Imports System.Data
Imports System.Data.SqlClient
Imports Gym_Management_System.DBConnection
Imports Gym_Management_System.DBFunction
Imports Gym_Management_System.FacilityClass
Public Class FacilityClass

#Region "Declaration of variables"

    'Declaring SQL variables
    Dim objDb As New DBConnection
    Dim Con As New SqlConnection
    Dim command As New SqlCommand
    Dim da As New SqlDataAdapter
    Public ds As New DataSet
    Dim str As String

    Public dvFacility As DataView
    Public clsDbFun As New DBFunction
    Public currentRow As Integer

    Public flag As Boolean = True
    'Declaring Facility variables

    Private _FacilityID As String
    Public Property FacilityID() As String
        Get
            Return _FacilityID
        End Get
        Set(ByVal value As String)
            _FacilityID = value
        End Set
    End Property
    Private _FacilityName As String
    Public Property FacilityName() As String
        Get
            Return _FacilityName
        End Get
        Set(ByVal value As String)
            _FacilityName = value
        End Set
    End Property

    Private _Charges As String
    Public Property Charges() As String
        Get
            Return _Charges
        End Get
        Set(ByVal value As String)
            _Charges = value
        End Set
    End Property
    Private _Frequency As String
    Public Property Frequency() As String
        Get
            Return _Frequency
        End Get
        Set(ByVal value As String)
            _Frequency = value
        End Set
    End Property
    Private _Status As String
    Public Property Status() As String
        Get
            Return _Status
        End Get
        Set(ByVal value As String)
            _Status = value
        End Set
    End Property
#End Region

#Region "Display Data"

    Public Sub DisplayDataFacility()
        Try
            Con = objDb.SetConnection()
            command.CommandText = ("exec DisplayDataFacility")
            command = objDb.CreateCommand(Con, command.CommandText)
            da = New SqlDataAdapter(command.CommandText, Con)
            ds = New DataSet
            da.Fill(ds, "Facility")
            dvFacility = New DataView(ds.Tables("Facility"))
            Con.Open()
            command.ExecuteReader()
            Con.Close()
            frmFacilityMaster.dgFacilityShow.DataSource = dvFacility

        Catch ex As Exception

        End Try
    End Sub

#End Region

#Region "Generate ID"

    Public Sub GenerateFacilityId()

        Con = objDb.SetConnection()
        command.CommandText = ("exec GenerateFacilityID")
        command = objDb.CreateCommand(Con, command.CommandText)
        Con.Open()
        Dim dr As SqlDataReader = command.ExecuteReader

        While dr.Read
            frmFacilityMaster.txtFacilityID.Text = dr(0)
        End While
        frmFacilityMaster.txtFacilityID.Text = Val(frmFacilityMaster.txtFacilityID.Text) + 1
        dr.Close()
        Con.Close()
    End Sub
#End Region

#Region "Check Textboxes"

    Public Sub CheckTextFacility()
        Try
            If frmFacilityMaster.txtFacilityName.Text.Trim() = String.Empty Then
                MessageBox.Show("Please enter Facility Name..!!")
                flag = False
            ElseIf frmFacilityMaster.txtcharges.Text.Trim() = String.Empty Then
                MessageBox.Show("Please enter Charges..!!")
                flag = False
            ElseIf frmFacilityMaster.txtFrequency.Text.Trim() = String.Empty Then
                MessageBox.Show("Please Enter Frequency.!!")
                flag = False
            ElseIf frmFacilityMaster.cmbStatus.Text.Trim() = String.Empty Then
                MessageBox.Show("Please select Status..!!")
                flag = False
            End If

        Catch ex As Exception

        End Try

    End Sub

#End Region

#Region "Adding Facility"
    'Adding Facility
    Public Sub AddFacility(ByVal FacilityID, ByVal FacilityName, ByVal Charges, ByVal Frequency, ByVal Status)
        Try
            Con = objDb.SetConnection()
            command.CommandText = ("exec AddFacility '" & FacilityID & "','" & FacilityName & "','" & Charges & "','" & Frequency & "','" & Status & "'")
            command = objDb.CreateCommand(Con, command.CommandText)

            Con.Open()
            command.ExecuteNonQuery()
            Con.Close()
            MessageBox.Show("Facility Details Added Successfully!!!", "Confirmation...(Gym Management System)", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ClearTextFacility()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error in Adding Facility")

        End Try
    End Sub
#End Region

#Region "Updating Facility"

    'Updating Facility
    Public Sub UpdateFacility(ByVal FacilityID, ByVal FacilityName, ByVal Charges, ByVal Frequency, ByVal Status)
        Try
            Con = objDb.SetConnection()
            command.CommandText = ("exec UpdateFacility '" & FacilityID & "','" & FacilityName & "','" & Charges & "','" & Frequency & "','" & Status & "'")
            command = objDb.CreateCommand(Con, command.CommandText)

            Con.Open()
            command.ExecuteNonQuery()
            Con.Close()
            MessageBox.Show("Facility Details Updated Successfully!!!", "Confirmation...(Gym Management System)", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ClearTextFacility()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error in Updating Facility")
        End Try
    End Sub
#End Region

#Region "Clear Textboxes"

    Public Sub ClearTextFacility()

        With frmFacilityMaster

            .txtFacilityID.Clear()
            .txtFacilityName.Clear()
            .txtcharges.Clear()
            .txtFrequency.Clear()
            .cmbStatus.Text = String.Empty
        End With
    End Sub
#End Region

#Region "Binding Navigator"

    Public Sub navigationFacility()
        Try
            ds = New DataSet
            currentRow = 0
            Con = objDb.SetConnection()
            command.CommandText = ("exec BindFacility")
            command = objDb.CreateCommand(Con, command.CommandText)
            da = New SqlDataAdapter(command.CommandText, Con)
            da.Fill(ds, "FM")
            ShowDataFacility(currentRow)
        Catch ex As Exception

        End Try

    End Sub
    Public Sub ShowDataFacility(ByVal currentRow)

        Try
            frmFacilityMaster.txtFacilityID.Text = ds.Tables("FM").Rows(currentRow).Item(0)
            frmFacilityMaster.txtFacilityName.Text = ds.Tables("FM").Rows(currentRow).Item(1)
            frmFacilityMaster.txtcharges.Text = ds.Tables("FM").Rows(currentRow).Item(2)
            frmFacilityMaster.txtFrequency.Text = ds.Tables("FM").Rows(currentRow).Item(3)
            frmFacilityMaster.cmbStatus.Text = ds.Tables("FM").Rows(currentRow).Item(4)
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Cell Click"

    Public Sub CellClickFacility(ByVal e As Object)

        Try
            frmFacilityMaster.txtFacilityID.Text = frmFacilityMaster.dgFacilityShow.Rows(e.rowindex).Cells(0).Value
            frmFacilityMaster.txtFacilityName.Text = frmFacilityMaster.dgFacilityShow.Rows(e.rowindex).Cells(1).Value
            frmFacilityMaster.txtcharges.Text = frmFacilityMaster.dgFacilityShow.Rows(e.rowindex).Cells(2).Value
            frmFacilityMaster.txtFrequency.Text = frmFacilityMaster.dgFacilityShow.Rows(e.rowindex).Cells(3).Value
            frmFacilityMaster.cmbStatus.Text = frmFacilityMaster.dgFacilityShow.Rows(e.rowindex).Cells(4).Value
        Catch ex As Exception

        End Try
    End Sub
#End Region
End Class
