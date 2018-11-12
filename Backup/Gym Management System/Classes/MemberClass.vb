Imports System.Data
Imports System.Data.SqlClient
Imports Gym_Management_System.DBConnection
Imports Gym_Management_System.DBFunction
Imports Gym_Management_System.MemberClass
Public Class MemberClass

#Region "Declaration of variables"

    'Declaring SQL variables
    Dim objDb As New DBConnection
    Dim Con As New SqlConnection
    Dim command As New SqlCommand
    Dim da As New SqlDataAdapter
    Public ds As New DataSet
    Dim str As String

    Public dvMember As DataView
    Public clsDbFun As New DBFunction
    Public currentRow As Integer

    Public flag As Boolean = True
    'Declaring Member variables

    Private _MemberID As String
    Public Property MemberID() As String
        Get
            Return _MemberID
        End Get
        Set(ByVal value As String)
            _MemberID = value
        End Set
    End Property
    Private _MemberName As String
    Public Property MemberName() As String
        Get
            Return _MemberName
        End Get
        Set(ByVal value As String)
            _MemberName = value
        End Set
    End Property

    Private _Address As String
    Public Property Address() As String
        Get
            Return _Address
        End Get
        Set(ByVal value As String)
            _Address = value
        End Set
    End Property

    Private _ResidentNo As String
    Public Property ResidentNo() As String
        Get
            Return _ResidentNo
        End Get
        Set(ByVal value As String)
            _ResidentNo = value
        End Set
    End Property

    Private _MobileNo As String
    Public Property MobileNo() As String
        Get
            Return _MobileNo
        End Get
        Set(ByVal value As String)
            _MobileNo = value
        End Set
    End Property
    Private _DOB As String
    Public Property DOB() As String
        Get
            Return _DOB
        End Get
        Set(ByVal value As String)
            _DOB = value
        End Set
    End Property
    Private _Gender As String
    Public Property Gender() As String
        Get
            Return _Gender
        End Get
        Set(ByVal value As String)
            _Gender = value
        End Set
    End Property
#End Region

#Region "Display Data"

    Public Sub DisplayDataMember()
        Try
            Con = objDb.SetConnection()
            command.CommandText = ("exec DisplayDataMember")
            command = objDb.CreateCommand(Con, command.CommandText)
            da = New SqlDataAdapter(command.CommandText, Con)
            ds = New DataSet
            da.Fill(ds, "Member")
            dvMember = New DataView(ds.Tables("Member"))
            Con.Open()
            command.ExecuteReader()
            Con.Close()
            frmMemberMaster.dgMemberShow.DataSource = dvMember

        Catch ex As Exception

        End Try
    End Sub

#End Region

#Region "Generate ID"

    Public Sub GenerateMemberId()

        Con = objDb.SetConnection()
        command.CommandText = ("exec GenerateMemberID")
        command = objDb.CreateCommand(Con, command.CommandText)
        Con.Open()
        Dim dr As SqlDataReader = command.ExecuteReader

        While dr.Read
            frmMemberMaster.txtMemberID.Text = dr(0)
        End While
        frmMemberMaster.txtMemberID.Text = Val(frmMemberMaster.txtMemberID.Text) + 1
        dr.Close()
        Con.Close()
    End Sub
#End Region

#Region "Check Textboxes"

    Public Sub CheckTextMember()

        Try
            If frmMemberMaster.txtMemberName.Text.Trim() = String.Empty Then
                MessageBox.Show("Please enter Member Name..!!")
                flag = False
            ElseIf frmMemberMaster.rtbMemberAddress.Text.Trim() = String.Empty Then
                MessageBox.Show("Please enter Member Address..!!")
                flag = False
            ElseIf frmMemberMaster.txtResidentNo.Text.Trim() = String.Empty Then
                MessageBox.Show("Please enter Member Resident No..!!")
                flag = False
            ElseIf frmMemberMaster.txtMobileNo.Text.Trim() = String.Empty Then
                MessageBox.Show("Please enter Mobile No..!!")
                flag = False
            ElseIf frmMemberMaster.cmbGender.Text.Trim() = String.Empty Then
                MessageBox.Show("Please select Gender..!!")
                flag = False

            End If

        Catch ex As Exception

        End Try

    End Sub

#End Region

#Region "Adding Member"
    'Adding Member
    Public Sub AddMember(ByVal MemberID, ByVal MemberName, ByVal Address, ByVal ResidentNo, ByVal MobileNo, ByVal DOB, ByVal Gender)
        Try
            Con = objDb.SetConnection()
            command.CommandText = ("exec AddMember '" & MemberID & "','" & MemberName & "','" & Address & "','" & ResidentNo & "','" & MobileNo & "','" & DOB & "','" & Gender & "'")
            command = objDb.CreateCommand(Con, command.CommandText)

            Con.Open()
            command.ExecuteNonQuery()
            Con.Close()
            MessageBox.Show("Member Details Added Successfully!!!", "Confirmation...(Gym Management System)", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ClearTextMember()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error in Adding Member")

        End Try
    End Sub
#End Region

#Region "Updating Member"

    'Updating Member
    Public Sub UpdateMember(ByVal MemberID, ByVal MemberName, ByVal Address, ByVal ResidentNo, ByVal MobileNo, ByVal DOB, ByVal Gender)
        Try
            Con = objDb.SetConnection()
            command.CommandText = ("exec UpdateMember '" & MemberID & "','" & MemberName & "','" & Address & "','" & ResidentNo & "','" & MobileNo & "','" & DOB & "','" & Gender & "'")
            command = objDb.CreateCommand(Con, command.CommandText)

            Con.Open()
            command.ExecuteNonQuery()
            Con.Close()
            MessageBox.Show("Member Details Updated Successfully!!!", "Confirmation...(Gym Management System)", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ClearTextMember()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error in Updating Member")
        End Try
    End Sub
#End Region

#Region "Delete Member"
    'Delete Member
    Public Sub DeleteMember(ByVal MemberID As String)
        Try
            Con = objDb.SetConnection()

            command.CommandText = ("exec DeleteMember '" & MemberID & "'")
            command = objDb.CreateCommand(Con, command.CommandText)

            Con.Open()
            command.ExecuteNonQuery()
            Con.Close()
            MessageBox.Show("Member Details Delete Successfully!!!", "Confirmation...(Gym Management System)", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ClearTextMember()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error in Deleting Member")

        End Try
    End Sub
#End Region

#Region "Clear Textboxes"

    Public Sub ClearTextMember()

        With frmMemberMaster
            .txtMemberID.Clear()
            .txtMemberName.Clear()
            .rtbMemberAddress.Clear()
            .txtResidentNo.Clear()
            .txtMobileNo.Clear()
            .cmbGender.Text = String.Empty
        End With
    End Sub
#End Region

#Region "Binding Navigator"

    Public Sub navigationMember()
        Try
            ds = New DataSet
            currentRow = 0
            Con = objDb.SetConnection()
            command.CommandText = ("exec BindMember")
            command = objDb.CreateCommand(Con, command.CommandText)
            da = New SqlDataAdapter(command.CommandText, Con)
            da.Fill(ds, "MD")
            ShowDataMember(currentRow)
        Catch ex As Exception

        End Try

    End Sub
    Public Sub ShowDataMember(ByVal currentRow)

        Try
            frmMemberMaster.txtMemberID.Text = ds.Tables("MD").Rows(currentRow).Item(0)
            frmMemberMaster.txtMemberName.Text = ds.Tables("MD").Rows(currentRow).Item(1)
            frmMemberMaster.rtbMemberAddress.Text = ds.Tables("MD").Rows(currentRow).Item(2)
            frmMemberMaster.txtResidentNo.Text = ds.Tables("MD").Rows(currentRow).Item(3)
            frmMemberMaster.txtMobileNo.Text = ds.Tables("MD").Rows(currentRow).Item(4)
            frmMemberMaster.DTPDateOfBirth.Text = ds.Tables("MD").Rows(currentRow).Item(5)
            frmMemberMaster.cmbGender.Text = ds.Tables("MD").Rows(currentRow).Item(6)
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Cell Click"

    Public Sub CellClickMember(ByVal e As Object)

        Try
            frmMemberMaster.txtMemberID.Text = frmMemberMaster.dgMemberShow.Rows(e.rowindex).Cells(0).Value
            frmMemberMaster.txtMemberName.Text = frmMemberMaster.dgMemberShow.Rows(e.rowindex).Cells(1).Value
            frmMemberMaster.rtbMemberAddress.Text = frmMemberMaster.dgMemberShow.Rows(e.rowindex).Cells(2).Value
            frmMemberMaster.txtResidentNo.Text = frmMemberMaster.dgMemberShow.Rows(e.rowindex).Cells(3).Value
            frmMemberMaster.txtMobileNo.Text = frmMemberMaster.dgMemberShow.Rows(e.rowindex).Cells(4).Value
            frmMemberMaster.DTPDateOfBirth.Text = frmMemberMaster.dgMemberShow.Rows(e.rowindex).Cells(5).Value
            frmMemberMaster.cmbGender.Text = frmMemberMaster.dgMemberShow.Rows(e.rowindex).Cells(6).Value
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Search Member"

    Public Sub SearchMember(ByVal objMember As Object)

        Try
            If frmMemberMaster.rbtID.Checked = True Then
                command.CommandText = ("exec SearchMemberByID '" & objMember & "'")
                command = objDb.CreateCommand(Con, command.CommandText)

                clsDbFun.Display(frmMemberMaster.dgMemberShow, command.CommandText)

                conn.Open()
                Dim sqlcomm = New SqlCommand(command.CommandText, conn)

                Dim sqldr As SqlDataReader = sqlcomm.ExecuteReader
                While sqldr.Read
                    frmMemberMaster.txtMemberID.Text = sqldr(0)
                    frmMemberMaster.txtMemberName.Text = sqldr(1)
                    frmMemberMaster.rtbMemberAddress.Text = sqldr(2)
                    frmMemberMaster.txtResidentNo.Text = sqldr(3)
                    frmMemberMaster.txtMobileNo.Text = sqldr(4)
                    frmMemberMaster.DTPDateOfBirth.Text = sqldr(5)
                    frmMemberMaster.cmbGender.Text = sqldr(6)
                End While
                conn.Close()
            End If


            If frmMemberMaster.rbtName.Checked = True Then
                command.CommandText = ("exec SearchMemberByName '%" & objMember & "%'")
                command = objDb.CreateCommand(Con, command.CommandText)

                clsDbFun.Display(frmMemberMaster.dgMemberShow, command.CommandText)
                conn.Open()
                Dim sqlcomm = New SqlCommand(command.CommandText, conn)

                Dim sqldr As SqlDataReader = sqlcomm.ExecuteReader
                While sqldr.Read
                    frmMemberMaster.txtMemberID.Text = sqldr(0)
                    frmMemberMaster.txtMemberName.Text = sqldr(1)
                    frmMemberMaster.rtbMemberAddress.Text = sqldr(2)
                    frmMemberMaster.txtResidentNo.Text = sqldr(3)
                    frmMemberMaster.txtMobileNo.Text = sqldr(4)
                    frmMemberMaster.DTPDateOfBirth.Text = sqldr(5)
                    frmMemberMaster.cmbGender.Text = sqldr(6)

                End While
                conn.Close()

            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
End Class
