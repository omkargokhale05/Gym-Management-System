Imports System.Data
Imports System.Data.SqlClient
Imports Gym_Management_System.DBConnection
Imports Gym_Management_System.DBFunction
Imports Gym_Management_System.ReservationRequestClass
Public Class ReservationRequestClass

#Region "Declaration of variables"

    'Declaring SQL variables
    Dim objDb As New DBConnection
    Dim Con As New SqlConnection
    Dim command As New SqlCommand
    Dim da As New SqlDataAdapter
    'Dim dr As New SqlDataReader
    Public ds As New DataSet
    Dim str As String

    Public dvReservationRequest As DataView
    Public clsDbFun As New DBFunction
    Public currentRow As Integer

    Public flag As Boolean = True
    'Declaring ReservationRequest variables

    Private _RequestID As String
    Public Property RequestID() As String
        Get
            Return _RequestID
        End Get
        Set(ByVal value As String)
            _RequestID = value
        End Set
    End Property
    Private _MemberID As String
    Public Property MemberID() As String
        Get
            Return _MemberID
        End Get
        Set(ByVal value As String)
            _MemberID = value
        End Set
    End Property

    Private _RequestDate As String
    Public Property RequestDate() As String
        Get
            Return _RequestDate
        End Get
        Set(ByVal value As String)
            _RequestDate = value
        End Set
    End Property
    Private _UtilisationDate As String
    Public Property UtilisationDate() As String
        Get
            Return _UtilisationDate
        End Get
        Set(ByVal value As String)
            _UtilisationDate = value
        End Set
    End Property
    Private _FacilityID As String
    Public Property FacilityID() As String
        Get
            Return _FacilityID
        End Get
        Set(ByVal value As String)
            _FacilityID = value
        End Set
    End Property 
#End Region

#Region "Generate ID"

    Public Sub GenerateRequestID()

        Con = objDb.SetConnection()
        command.CommandText = ("exec GenerateRequestID")
        command = objDb.CreateCommand(Con, command.CommandText)
        Con.Open()
        Dim dr As SqlDataReader = command.ExecuteReader

        While dr.Read
            frmReservationRequest.txtRequestID.Text = dr(0)
        End While
        frmReservationRequest.txtRequestID.Text = Val(frmReservationRequest.txtRequestID.Text) + 1
        dr.Close()
        Con.Close()

    End Sub
#End Region

#Region "Display Data"

    Public Sub DisplayDataReservationRequest()
        Try
            Con = objDb.SetConnection()
            command.CommandText = ("exec DisplayDataReservationRequest")
            command = objDb.CreateCommand(Con, command.CommandText)
            da = New SqlDataAdapter(command.CommandText, Con)
            ds = New DataSet
            da.Fill(ds, "ReservationRequest")
            dvReservationRequest = New DataView(ds.Tables("ReservationRequest"))
            Con.Open()
            command.ExecuteReader()
            Con.Close()
            frmReservationRequest.dgReservationRequest.DataSource = dvReservationRequest

        Catch ex As Exception
        End Try
    End Sub
#End Region

#Region "Check Textboxes"

    Public Sub CheckTextReservationRequest()
        Try
            If frmReservationRequest.cmbMemberID.Text.Trim() = String.Empty Then
                MessageBox.Show("Please select Member ID..!!")
                flag = False
            ElseIf frmReservationRequest.DTPRequestDate.Text.Trim() = String.Empty Then
                MessageBox.Show("Please select Request Date ...!!")
                flag = False
            ElseIf frmReservationRequest.DTPUtilisationDate.Text.Trim() = String.Empty Then
                MessageBox.Show("Please select Utilisation Date...!!")
                flag = False
            ElseIf frmReservationRequest.cmbFacilityID.Text.Trim() = String.Empty Then
                MessageBox.Show("Please select Facility ID..!!")
                flag = False
            End If
        Catch ex As Exception
        End Try
    End Sub
#End Region

#Region "Adding ReservationRequest"
    'Adding ReservationRequest
    Public Sub AddReservationRequestDtls(ByVal RequestID, ByVal MemberID, ByVal RequestDate, ByVal UtilisationDate, ByVal FacilityID)
        Try
            Con = objDb.SetConnection()
            command.CommandText = ("exec AddReservationRequestDtls '" & RequestID & "','" & MemberID & "','" & RequestDate & "','" & UtilisationDate & "','" & FacilityID & "'")
            command = objDb.CreateCommand(Con, command.CommandText)

            Con.Open()
            command.ExecuteNonQuery()
            Con.Close()
            MessageBox.Show("ReservationRequest Details Added Successfully!!!", "Confirmation...(Gym Management System)", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ClearTextReservationRequest()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error in Adding ReservationRequest")

        End Try
    End Sub
#End Region


#Region "Updating ReservationRequest"

    'Updating ReservationRequest
    Public Sub UpdateReservationRequestDtls(ByVal RequestID, ByVal MemberID, ByVal RequestDate, ByVal UtilisationDate, ByVal FacilityID)
        Try
            Con = objDb.SetConnection()
            command.CommandText = ("exec UpdateReservationRequestDtls '" & RequestID & "','" & MemberID & "','" & RequestDate & "','" & UtilisationDate & "','" & FacilityID & "'")
            command = objDb.CreateCommand(Con, command.CommandText)

            Con.Open()
            command.ExecuteNonQuery()
            Con.Close()
            MessageBox.Show("ReservationRequest Details Updated Successfully!!!", "Confirmation...(Gym Management System)", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ClearTextReservationRequest()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error in Updating ReservationRequest")
        End Try
    End Sub
#End Region

#Region "Display Member Details"
    'Display Member details
    Public Function DisplayMemberDetails(ByVal MemberID) As SqlDataReader
        Dim dr As SqlDataReader
        Con = objDb.SetConnection()
        Con.Open()
        command.CommandText = ("exec DisplayMemberDetails '" & MemberID & "'")
        da = New SqlDataAdapter(command.CommandText, Con)
        command = New SqlCommand(command.CommandText, Con)
        dr = command.ExecuteReader
        If dr.HasRows Then
            While dr.Read

                frmReservationRequest.txtMemberName.Text = dr(1)
                frmReservationRequest.rtbMemberAddress.Text = dr(2)
                frmReservationRequest.txtResidentNo.Text = dr(3)
                frmReservationRequest.txtMobileNo.Text = dr(4)
                frmReservationRequest.DTPDateOfBirth.Text = dr(5)
                frmReservationRequest.cmbGender.Text = dr(6)
            End While
        Else
            frmReservationRequest.txtMemberName.Text = ""
            frmReservationRequest.rtbMemberAddress.Text = ""
            frmReservationRequest.txtResidentNo.Text = ""
            frmReservationRequest.txtMobileNo.Text = ""
            frmReservationRequest.DTPDateOfBirth.Text = ""
            frmReservationRequest.cmbGender.Text = ""
        End If
        Return dr
    End Function
#End Region

#Region "Display Facility Details"
    'Display Facility Details

    Public Function DisplayFacilityDetails(ByVal FacilityID) As SqlDataReader
        Dim dr As SqlDataReader
        Con = objDb.SetConnection()
        Con.Open()
        command.CommandText = ("exec DisplayFacilityDetails '" & FacilityID & "'")
        da = New SqlDataAdapter(command.CommandText, Con)
        command = New SqlCommand(command.CommandText, Con)
        dr = command.ExecuteReader

        If dr.HasRows Then
            While dr.Read
                frmReservationRequest.txtFacilityName.Text = dr(1)
                frmReservationRequest.txtCharges.Text = dr(2)
                frmReservationRequest.txtFrequency.Text = dr(3)
                frmReservationRequest.txtStatus.Text = dr(4)
            End While
        Else
            frmReservationRequest.txtFacilityName.Text = ""
            frmReservationRequest.txtCharges.Text = ""
            frmReservationRequest.txtFrequency.Text = ""
            frmReservationRequest.txtStatus.Text = ""
        End If
        Return dr
    End Function
#End Region

#Region "Clear Textboxes"

    Public Sub ClearTextReservationRequest()

        With frmReservationRequest

            .txtRequestID.Clear()
            .cmbMemberID.Text = String.Empty
            .cmbFacilityID.Text = String.Empty

            .txtMemberName.Clear()
            .rtbMemberAddress.Clear()
            .txtResidentNo.Clear()
            .txtMobileNo.Clear()
            .cmbGender.Text = String.Empty

            .txtFacilityName.Clear()
            .txtCharges.Clear()
            .txtFrequency.Clear()
            .txtStatus.Clear()
           
        End With
    End Sub
#End Region

#Region "Binding Navigator"

    Public Sub navigationReservationRequest()
        Try
            ds = New DataSet
            currentRow = 0
            Con = objDb.SetConnection()
            command.CommandText = ("exec navigationReservationRequest")
            command = objDb.CreateCommand(Con, command.CommandText)
            da = New SqlDataAdapter(command.CommandText, Con)
            da.Fill(ds, "RRD")
            ShowDataReservationRequest(currentRow)
        Catch ex As Exception

        End Try

    End Sub
    Public Sub ShowDataReservationRequest(ByVal currentRow)

        Try
            frmReservationRequest.txtRequestID.Text = ds.Tables("RRD").Rows(currentRow).Item(0)
            frmReservationRequest.cmbMemberID.Text = ds.Tables("RRD").Rows(currentRow).Item(1)
            frmReservationRequest.DTPRequestDate.Text = ds.Tables("RRD").Rows(currentRow).Item(2)
            frmReservationRequest.DTPUtilisationDate.Text = ds.Tables("RRD").Rows(currentRow).Item(3)
            frmReservationRequest.cmbFacilityID.Text = ds.Tables("RRD").Rows(currentRow).Item(4)
           

        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Cell Click"

    Public Sub CellClickReservationRequest(ByVal e As Object)
        Try
            frmReservationRequest.txtRequestID.Text = frmReservationRequest.dgReservationRequest.Rows(e.rowindex).Cells(0).Value
            frmReservationRequest.cmbMemberID.Text = frmReservationRequest.dgReservationRequest.Rows(e.rowindex).Cells(1).Value
            frmReservationRequest.DTPRequestDate.Text = frmReservationRequest.dgReservationRequest.Rows(e.rowindex).Cells(2).Value
            frmReservationRequest.DTPUtilisationDate.Text = frmReservationRequest.dgReservationRequest.Rows(e.rowindex).Cells(3).Value
            frmReservationRequest.cmbFacilityID.Text = frmReservationRequest.dgReservationRequest.Rows(e.rowindex).Cells(4).Value

        Catch ex As Exception

        End Try
    End Sub
#End Region

End Class
