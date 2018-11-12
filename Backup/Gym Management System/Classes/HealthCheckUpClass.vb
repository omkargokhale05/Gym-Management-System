Imports System.Data
Imports System.Data.SqlClient
Imports Gym_Management_System.DBConnection
Imports Gym_Management_System.DBFunction
Imports Gym_Management_System.HealthCheckUpClass
Public Class HealthCheckUpClass

#Region "Declaration of variables"

    'Declaring SQL variables
    Dim objDb As New DBConnection
    Dim Con As New SqlConnection
    Dim command As New SqlCommand
    Dim da As New SqlDataAdapter
    'Dim dr As New SqlDataReader
    Public ds As New DataSet
    Dim str As String

    Public dvHealthCheckUp As DataView
    Public clsDbFun As New DBFunction
    Public currentRow As Integer

    Public flag As Boolean = True
    'Declaring HealthCheckUp variables

    Private _HealthID As String
    Public Property HealthID() As String
        Get
            Return _HealthID
        End Get
        Set(ByVal value As String)
            _HealthID = value
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

    Private _Month As String
    Public Property Month() As String
        Get
            Return _Month
        End Get
        Set(ByVal value As String)
            _Month = value
        End Set
    End Property

    Private _MonthCount As String
    Public Property MonthCount() As String
        Get
            Return _MonthCount
        End Get
        Set(ByVal value As String)
            _MonthCount = value
        End Set
    End Property

    Private _CheckUpDate As String
    Public Property CheckUpDate() As String
        Get
            Return _CheckUpDate
        End Get
        Set(ByVal value As String)
            _CheckUpDate = value
        End Set
    End Property
#End Region

#Region "Display Data"

    Public Sub DisplayDataHealthCheckUp()
        Try
            Con = objDb.SetConnection()
            command.CommandText = ("exec DisplayDataHealthCheckUp")
            command = objDb.CreateCommand(Con, command.CommandText)
            da = New SqlDataAdapter(command.CommandText, Con)
            ds = New DataSet
            da.Fill(ds, "HealthCheckUp")
            dvHealthCheckUp = New DataView(ds.Tables("HealthCheckUp"))
            Con.Open()
            command.ExecuteReader()
            Con.Close()
            frmHealthCheckUp.dgHealthCheckUpShow.DataSource = dvHealthCheckUp

        Catch ex As Exception
        End Try
    End Sub
#End Region

#Region "Check Textboxes"

    Public Sub CheckTextHealthCheckUp()

        Try
            If frmHealthCheckUp.cmbHealthID.Text.Trim() = String.Empty Then
                MessageBox.Show("Please enter Height..!!")
                flag = False
            ElseIf frmHealthCheckUp.cmbMemberID.Text.Trim() = String.Empty Then
                MessageBox.Show("Please enter Weight..!!")
                flag = False
            ElseIf frmHealthCheckUp.cmbMonth.Text.Trim() = String.Empty Then
                MessageBox.Show("Please enter Heart Beat..!!")
                flag = False
            ElseIf frmHealthCheckUp.txtMonthCount.Text.Trim() = String.Empty Then
                MessageBox.Show("Please enter BMI..!!")
                flag = False
            ElseIf frmHealthCheckUp.DTPCheckUp.Text.Trim() = String.Empty Then
                MessageBox.Show("Please enter Chest Size..!!")
                flag = False
            End If

        Catch ex As Exception
        End Try
    End Sub
#End Region

#Region "Adding HealthCheckUp"
    'Adding HealthCheckUp
    Public Sub AddHealthCheckUpDtls(ByVal HealthID, ByVal MemberID, ByVal Month, ByVal MonthCount, ByVal CheckUpDate)
        Try
            Con = objDb.SetConnection()
            command.CommandText = ("exec AddHealthCheckUpDtls '" & HealthID & "','" & MemberID & "','" & Month & "','" & MonthCount & "','" & CheckUpDate & "'")
            command = objDb.CreateCommand(Con, command.CommandText)

            Con.Open()
            command.ExecuteNonQuery()
            Con.Close()
            MessageBox.Show("HealthCheckUp Details Added Successfully!!!", "Confirmation...(Gym Management System)", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ClearTextHealthCheckUp()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error in Adding HealthCheckUp")

        End Try
    End Sub
#End Region

#Region "Updating HealthCheckUp"

    'Updating HealthCheckUp
    Public Sub UpdateHealthCheckUpDtls(ByVal HealthID, ByVal MemberID, ByVal Month, ByVal MonthCount, ByVal CheckUpDate)
        Try
            Con = objDb.SetConnection()
            command.CommandText = ("exec UpdateHealthCheckUpDtls '" & HealthID & "','" & MemberID & "','" & Month & "','" & MonthCount & "','" & CheckUpDate & "'")
            command = objDb.CreateCommand(Con, command.CommandText)

            Con.Open()
            command.ExecuteNonQuery()
            Con.Close()
            MessageBox.Show("HealthCheckUp Details Updated Successfully!!!", "Confirmation...(Gym Management System)", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ClearTextHealthCheckUp()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error in Updating HealthCheckUp")
        End Try
    End Sub
#End Region

#Region "Display Health CheckUp"
    'Display Health CheckUp
    Public Function DisplayHealthCheckUp(ByVal HealthID) As SqlDataReader
        Dim dr As SqlDataReader
        Con = objDb.SetConnection()
        Con.Open()
        command.CommandText = ("exec DisplayHealthCheckUp '" & HealthID & "'")
        da = New SqlDataAdapter(command.CommandText, Con)
        command = New SqlCommand(command.CommandText, Con)
        dr = command.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                frmHealthCheckUp.txtHeight.Text = dr(1)
                frmHealthCheckUp.txtWeight.Text = dr(2)
                frmHealthCheckUp.txtHeartBeat.Text = dr(3)
                frmHealthCheckUp.txtBMI.Text = dr(3)
                frmHealthCheckUp.txtChestSize.Text = dr(4)
                frmHealthCheckUp.txtWaistSize.Text = dr(5)
                frmHealthCheckUp.txtBicepSize.Text = dr(6)
            End While
        Else
            frmHealthCheckUp.txtHeight.Text = ""
            frmHealthCheckUp.txtWeight.Text = ""
            frmHealthCheckUp.txtHeartBeat.Text = ""
            frmHealthCheckUp.txtBMI.Text = ""
            frmHealthCheckUp.txtChestSize.Text = ""
            frmHealthCheckUp.txtWaistSize.Text = ""
            frmHealthCheckUp.txtBicepSize.Text = ""
        End If
        Return dr
    End Function
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
                frmHealthCheckUp.txtMemberName.Text = dr(1)
                frmHealthCheckUp.rtbMemberAddress.Text = dr(2)
                frmHealthCheckUp.txtResidentNo.Text = dr(3)
                frmHealthCheckUp.txtMobileNo.Text = dr(4)
                frmHealthCheckUp.DTPDateOfBirth.Text = dr(5)
                frmHealthCheckUp.cmbGender.Text = dr(6)
            End While
        Else
            frmHealthCheckUp.txtMemberName.Text = ""
            frmHealthCheckUp.rtbMemberAddress.Text = ""
            frmHealthCheckUp.txtResidentNo.Text = ""
            frmHealthCheckUp.txtMobileNo.Text = ""
            frmHealthCheckUp.DTPDateOfBirth.Text = ""
            frmHealthCheckUp.cmbGender.Text = ""
        End If
        Return dr
    End Function
#End Region

#Region "Clear Textboxes"

    Public Sub ClearTextHealthCheckUp()

        With frmHealthCheckUp
            .cmbHealthID.Text = String.Empty
            .cmbMemberID.Text = String.Empty
            .txtMonthCount.Clear()
            .cmbMonth.Text = String.Empty

            .txtHeight.Clear()
            .txtWeight.Clear()
            .txtBMI.Clear()
            .txtHeartBeat.Clear()
            .txtChestSize.Clear()
            .txtWaistSize.Clear()
            .txtBicepSize.Clear()


            .txtMemberName.Clear()
            .rtbMemberAddress.Clear()
            .txtResidentNo.Clear()
            .txtMobileNo.Clear()
            .cmbGender.Text = String.Empty


        End With
    End Sub
#End Region

#Region "Binding Navigator"

    Public Sub navigationHealthCheckUp()
        Try
            ds = New DataSet
            currentRow = 0
            Con = objDb.SetConnection()
            command.CommandText = ("exec BindHealthCheckUp")
            command = objDb.CreateCommand(Con, command.CommandText)
            da = New SqlDataAdapter(command.CommandText, Con)
            da.Fill(ds, "HCD")
            ShowDataHealthCheckUp(currentRow)
        Catch ex As Exception

        End Try

    End Sub
    Public Sub ShowDataHealthCheckUp(ByVal currentRow)

        Try
            frmHealthCheckUp.cmbHealthID.Text = ds.Tables("HCD").Rows(currentRow).Item(0)
            frmHealthCheckUp.cmbMemberID.Text = ds.Tables("HCD").Rows(currentRow).Item(1)
            frmHealthCheckUp.cmbMonth.Text = ds.Tables("HCD").Rows(currentRow).Item(2)
            frmHealthCheckUp.txtMonthCount.Text = ds.Tables("HCD").Rows(currentRow).Item(3)
            frmHealthCheckUp.DTPCheckUp.Text = ds.Tables("HCD").Rows(currentRow).Item(4)

        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Cell Click"

    Public Sub CellClickHealthCheckUp(ByVal e As Object)

        Try
            frmHealthCheckUp.cmbHealthID.Text = frmHealthCheckUp.dgHealthCheckUpShow.Rows(e.rowindex).Cells(0).Value
            frmHealthCheckUp.cmbMemberID.Text = frmHealthCheckUp.dgHealthCheckUpShow.Rows(e.rowindex).Cells(1).Value
            frmHealthCheckUp.cmbMonth.Text = frmHealthCheckUp.dgHealthCheckUpShow.Rows(e.rowindex).Cells(2).Value
            frmHealthCheckUp.txtMonthCount.Text = frmHealthCheckUp.dgHealthCheckUpShow.Rows(e.rowindex).Cells(3).Value
            frmHealthCheckUp.DTPCheckUp.Text = frmHealthCheckUp.dgHealthCheckUpShow.Rows(e.rowindex).Cells(4).Value

        Catch ex As Exception

        End Try
    End Sub
#End Region

End Class
