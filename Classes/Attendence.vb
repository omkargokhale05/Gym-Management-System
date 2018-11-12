Imports System.Data
Imports System.Data.SqlClient
Imports Gym_Management_System.DBConnection
Imports Gym_Management_System.DBFunction
Imports Gym_Management_System.Attendence
Public Class Attendence

#Region "Declaration of variables"

    'Declaring SQL variables
    Dim objDb As New DBConnection
    Dim Con As New SqlConnection
    Dim command As New SqlCommand
    Dim da As New SqlDataAdapter
    'Dim dr As New SqlDataReader
    Public ds As New DataSet
    Dim str As String

    Public dvAttendence As DataView
    Public clsDbFun As New DBFunction
    Public currentRow As Integer

    Public flag As Boolean = True
    'Declaring Attendence variables

    Private _MemberID As String
    Public Property MemberID() As String
        Get
            Return _MemberID
        End Get
        Set(ByVal value As String)
            _MemberID = value
        End Set
    End Property

    Private _Month As String
    Public Property Month() As String
        Get
            Return _Month
        End Get
        Set(ByVal value As String)
            _Month = value
        End Set
    End Property

    Private _Year As String
    Public Property Year() As String
        Get
            Return _Year
        End Get
        Set(ByVal value As String)
            _Year = value
        End Set
    End Property

    Private _InTime As String
    Public Property InTime() As String
        Get
            Return _InTime
        End Get
        Set(ByVal value As String)
            _InTime = value
        End Set
    End Property
    Private _OutTime As String
    Public Property OutTime() As String
        Get
            Return _OutTime
        End Get
        Set(ByVal value As String)
            _OutTime = value
        End Set
    End Property
#End Region

#Region "Display Data"

    Public Sub DisplayDataAttendence()
        Try
            Con = objDb.SetConnection()
            command.CommandText = ("exec DisplayDataAttendence")
            command = objDb.CreateCommand(Con, command.CommandText)
            da = New SqlDataAdapter(command.CommandText, Con)
            ds = New DataSet
            da.Fill(ds, "Attendence")
            dvAttendence = New DataView(ds.Tables("Attendence"))
            Con.Open()
            command.ExecuteReader()
            Con.Close()
            frmAttendence.dgAttendenceShow.DataSource = dvAttendence

        Catch ex As Exception
        End Try
    End Sub
#End Region

#Region "Check Textboxes"

    Public Sub CheckTextAttendence()
        Try
            If frmAttendence.cmbMemberID.Text.Trim() = String.Empty Then
                MessageBox.Show("Please Select MemberID..!!")
                flag = False
            ElseIf frmAttendence.cmbStatus.Text.Trim() = String.Empty Then
                MessageBox.Show("Please select Status..!!")
                flag = False
            ElseIf frmAttendence.DTPInTime.Text.Trim() = String.Empty Then
                MessageBox.Show("Please enter In Time..!!")
                flag = False
            ElseIf frmAttendence.DTPOutTime.Text.Trim() = String.Empty Then
                MessageBox.Show("Please enter Out Time..!!")
                flag = False
            End If

        Catch ex As Exception
        End Try
    End Sub
#End Region

#Region "Adding Attendence"
    'Adding Attendence
    Public Sub AddAttendence(ByVal MemberID, ByVal MemDate, ByVal Status, ByVal Intime, ByVal OutTime)
        Try
            Con = objDb.SetConnection()
            command.CommandText = ("exec AddAttendence '" & MemberID & "','" & MemDate & "','" & Status & "','" & Intime & "','" & OutTime & "'")
            command = objDb.CreateCommand(Con, command.CommandText)

            Con.Open()
            command.ExecuteNonQuery()
            Con.Close()
            MessageBox.Show("Attendence Details Added Successfully!!!", "Confirmation...(Gym Management System)", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ClearTextAttendence()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error in Adding Attendence")

        End Try
    End Sub
#End Region

#Region "Updating Attendence"

    'Updating Attendence
    Public Sub UpdateAttendence(ByVal MemberID, ByVal MemDate, ByVal Status, ByVal Intime, ByVal OutTime)
        Try
            Con = objDb.SetConnection()
            command.CommandText = ("exec UpdateAttendence'" & MemberID & "','" & MemDate & "','" & Status & "','" & Intime & "','" & OutTime & "'")
            command = objDb.CreateCommand(Con, command.CommandText)

            Con.Open()
            command.ExecuteNonQuery()
            Con.Close()
            MessageBox.Show("Attendence Details Updated Successfully!!!", "Confirmation...(Gym Management System)", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ClearTextAttendence()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error in Updating Attendence")
        End Try
    End Sub
#End Region

#Region "Display Member Details"
    'Display Member Details
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
                frmAttendence.txtMemberName.Text = dr(1)
                frmAttendence.rtbMemberAddress.Text = dr(2)
                frmAttendence.txtResidentNo.Text = dr(3)
                frmAttendence.txtMobileNo.Text = dr(4)
                frmAttendence.DTPDateOfBirth.Text = dr(5)
                frmAttendence.cmbGender.Text = dr(6)
            End While
        Else
            frmAttendence.txtMemberName.Text = ""
            frmAttendence.rtbMemberAddress.Text = ""
            frmAttendence.txtResidentNo.Text = ""
            frmAttendence.txtMobileNo.Text = ""
            frmAttendence.DTPDateOfBirth.Text = ""
            frmAttendence.cmbGender.Text = ""
        End If
        Return dr
    End Function
#End Region

#Region "Clear Textboxes"

    Public Sub ClearTextAttendence()

        With frmAttendence
            .cmbMemberID.Text = String.Empty
            .cmbStatus.Text = String.Empty

            .txtMemberName.Clear()
            .rtbMemberAddress.Clear()
            .txtResidentNo.Clear()
            .txtMobileNo.Clear()
            .cmbGender.Text = String.Empty


        End With
    End Sub
#End Region

#Region "Binding Navigator"

    Public Sub navigationAttendence()
        Try
            ds = New DataSet
            currentRow = 0
            Con = objDb.SetConnection()
            command.CommandText = ("exec BindAttendence")
            command = objDb.CreateCommand(Con, command.CommandText)
            da = New SqlDataAdapter(command.CommandText, Con)
            da.Fill(ds, "AD")
            ShowDataAttendence(currentRow)
        Catch ex As Exception

        End Try

    End Sub
    Public Sub ShowDataAttendence(ByVal currentRow)
        Try
            frmAttendence.cmbMemberID.Text = ds.Tables("AD").Rows(currentRow).Item(0)
            frmAttendence.dtpDate.Text = ds.Tables("AD").Rows(currentRow).Item(1)
            frmAttendence.cmbStatus.Text = ds.Tables("AD").Rows(currentRow).Item(2)
            frmAttendence.DTPInTime.Text = ds.Tables("AD").Rows(currentRow).Item(3)
            frmAttendence.DTPOutTime.Text = ds.Tables("AD").Rows(currentRow).Item(4)

        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Cell Click"

    Public Sub CellClickAttendence(ByVal e As Object)
        Try
            frmAttendence.cmbMemberID.Text = frmAttendence.dgAttendenceShow.Rows(e.rowindex).Cells(0).Value
            frmAttendence.dtpDate.Text = frmAttendence.dgAttendenceShow.Rows(e.rowindex).Cells(1).Value
            frmAttendence.cmbStatus.Text = frmAttendence.dgAttendenceShow.Rows(e.rowindex).Cells(2).Value
            frmAttendence.DTPInTime.Text = frmAttendence.dgAttendenceShow.Rows(e.rowindex).Cells(3).Value
            frmAttendence.DTPOutTime.Text = frmAttendence.dgAttendenceShow.Rows(e.rowindex).Cells(4).Value

        Catch ex As Exception

        End Try
    End Sub
#End Region

End Class
