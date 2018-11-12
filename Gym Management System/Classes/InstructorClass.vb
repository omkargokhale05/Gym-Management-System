Imports System.Data
Imports System.Data.SqlClient
Imports Gym_Management_System.DBConnection
Imports Gym_Management_System.DBFunction
Imports Gym_Management_System.InstructorClass
Public Class InstructorClass

#Region "Declaration of variables"

    'Declaring SQL variables
    Dim objDb As New DBConnection
    Dim Con As New SqlConnection
    Dim command As New SqlCommand
    Dim da As New SqlDataAdapter
    Public ds As New DataSet
    Dim str As String

    Public dvInstructor As DataView
    Public clsDbFun As New DBFunction
    Public currentRow As Integer

    Public flag As Boolean = True
    'Declaring Instructor variables

    Private _InstructorID As String
    Public Property InstructorID() As String
        Get
            Return _InstructorID
        End Get
        Set(ByVal value As String)
            _InstructorID = value
        End Set
    End Property
    Private _InstructorName As String
    Public Property InstructorName() As String
        Get
            Return _InstructorName
        End Get
        Set(ByVal value As String)
            _InstructorName = value
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
    Private _MobileNo As String
    Public Property MobileNo() As String
        Get
            Return _MobileNo
        End Get
        Set(ByVal value As String)
            _MobileNo = value
        End Set
    End Property
    Private _Expert As String
    Public Property Expert() As String
        Get
            Return _Expert
        End Get
        Set(ByVal value As String)
            _Expert = value
        End Set
    End Property

    Private _DOJ As String
    Public Property DOJ() As String
        Get
            Return _DOJ
        End Get
        Set(ByVal value As String)
            _DOJ = value
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

    Public Sub DisplayDataInstructor()
        Try
            Con = objDb.SetConnection()
            command.CommandText = ("exec DisplayDataInstructor")
            command = objDb.CreateCommand(Con, command.CommandText)
            da = New SqlDataAdapter(command.CommandText, Con)
            ds = New DataSet
            da.Fill(ds, "Instructor")
            dvInstructor = New DataView(ds.Tables("Instructor"))
            Con.Open()
            command.ExecuteReader()
            Con.Close()
            frmInstructorMaster.dgInstructorShow.DataSource = dvInstructor

        Catch ex As Exception

        End Try
    End Sub

#End Region

#Region "Generate ID"

    Public Sub GenerateInstructorId()

        Con = objDb.SetConnection()
        command.CommandText = ("exec GenerateInstructorID")
        command = objDb.CreateCommand(Con, command.CommandText)
        Con.Open()
        Dim dr As SqlDataReader = command.ExecuteReader

        While dr.Read
            frmInstructorMaster.txtInstructorID.Text = dr(0)
        End While
        frmInstructorMaster.txtInstructorID.Text = Val(frmInstructorMaster.txtInstructorID.Text) + 1
        dr.Close()
        Con.Close()
    End Sub
#End Region

#Region "Check Textboxes"

    Public Sub CheckTextInstructor()

        Try
            If frmInstructorMaster.txtInstructorName.Text.Trim() = String.Empty Then
                MessageBox.Show("Please enter Instructor Name..!!")
                flag = False
            ElseIf frmInstructorMaster.rtbInstructorAddress.Text.Trim() = String.Empty Then
                MessageBox.Show("Please enter Instructor Address..!!")
                flag = False
            ElseIf frmInstructorMaster.cmbExperts.Text.Trim() = String.Empty Then
                MessageBox.Show("Please select Expert Level..!!")
                flag = False
            ElseIf frmInstructorMaster.txtMobileNo.Text.Trim() = String.Empty Then
                MessageBox.Show("Please enter Mobile No..!!")
                flag = False
            ElseIf frmInstructorMaster.cmbGender.Text.Trim() = String.Empty Then
                MessageBox.Show("Please select Gender..!!")
                flag = False

            End If

        Catch ex As Exception

        End Try

    End Sub

#End Region

#Region "Adding Instructor"
    'Adding Instructor
    Public Sub AddInstructor(ByVal InstructorID, ByVal InstructorName, ByVal Address, ByVal MobileNo, ByVal Expert, ByVal DOJ, ByVal Gender)
        Try
            Con = objDb.SetConnection()
            command.CommandText = ("exec AddInstructor '" & InstructorID & "','" & InstructorName & "','" & Address & "','" & MobileNo & "','" & Expert & "','" & DOJ & "','" & Gender & "'")
            command = objDb.CreateCommand(Con, command.CommandText)

            Con.Open()
            command.ExecuteNonQuery()
            Con.Close()
            MessageBox.Show("Instructor Details Added Successfully!!!", "Confirmation...(Gym Management System)", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ClearTextInstructor()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error in Adding Instructor")

        End Try
    End Sub
#End Region

#Region "Updating Instructor"

    'Updating Instructor
    Public Sub UpdateInstructor(ByVal InstructorID, ByVal InstructorName, ByVal Address, ByVal MobileNo, ByVal Expert, ByVal DOJ, ByVal Gender)
        Try
            Con = objDb.SetConnection()
            command.CommandText = ("exec UpdateInstructor '" & InstructorID & "','" & InstructorName & "','" & Address & "','" & MobileNo & "','" & Expert & "','" & DOJ & "','" & Gender & "'")
            command = objDb.CreateCommand(Con, command.CommandText)

            Con.Open()
            command.ExecuteNonQuery()
            Con.Close()
            MessageBox.Show("Instructor Details Updated Successfully!!!", "Confirmation...(Gym Management System)", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ClearTextInstructor()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error in Updating Instructor")
        End Try
    End Sub
#End Region

#Region "Delete Instructor"
    'Delete Instructor
    Public Sub DeleteInstructor(ByVal InstructorID As String)
        Try
            Con = objDb.SetConnection()

            command.CommandText = ("exec DeleteInstructor '" & InstructorID & "'")
            command = objDb.CreateCommand(Con, command.CommandText)

            Con.Open()
            command.ExecuteNonQuery()
            Con.Close()
            MessageBox.Show("Instructor Details Delete Successfully!!!", "Confirmation...(Gym Management System)", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ClearTextInstructor()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error in Deleting Instructor")

        End Try
    End Sub
#End Region

#Region "Clear Textboxes"

    Public Sub ClearTextInstructor()

        With frmInstructorMaster
            .txtInstructorID.Clear()
            .txtInstructorName.Clear()
            .rtbInstructorAddress.Clear()
            .txtMobileNo.Clear()
            .cmbExperts.Text = String.Empty
            .cmbGender.Text = String.Empty
        End With
    End Sub
#End Region

#Region "Binding Navigator"

    Public Sub navigationInstructor()
        Try
            ds = New DataSet
            currentRow = 0
            Con = objDb.SetConnection()
            command.CommandText = ("exec BindInstructor")
            command = objDb.CreateCommand(Con, command.CommandText)
            da = New SqlDataAdapter(command.CommandText, Con)
            da.Fill(ds, "IM")
            ShowDataInstructor(currentRow)
        Catch ex As Exception

        End Try

    End Sub
    Public Sub ShowDataInstructor(ByVal currentRow)

        Try
            frmInstructorMaster.txtInstructorID.Text = ds.Tables("IM").Rows(currentRow).Item(0)
            frmInstructorMaster.txtInstructorName.Text = ds.Tables("IM").Rows(currentRow).Item(1)
            frmInstructorMaster.rtbInstructorAddress.Text = ds.Tables("IM").Rows(currentRow).Item(2)
            frmInstructorMaster.txtMobileNo.Text = ds.Tables("IM").Rows(currentRow).Item(3)
            frmInstructorMaster.cmbExperts.Text = ds.Tables("IM").Rows(currentRow).Item(4)
            frmInstructorMaster.DTPDateOfJoin.Text = ds.Tables("IM").Rows(currentRow).Item(5)
            frmInstructorMaster.cmbGender.Text = ds.Tables("IM").Rows(currentRow).Item(6)
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Cell Click"

    Public Sub CellClickInstructor(ByVal e As Object)

        Try
            frmInstructorMaster.txtInstructorID.Text = frmInstructorMaster.dgInstructorShow.Rows(e.rowindex).Cells(0).Value
            frmInstructorMaster.txtInstructorName.Text = frmInstructorMaster.dgInstructorShow.Rows(e.rowindex).Cells(1).Value
            frmInstructorMaster.rtbInstructorAddress.Text = frmInstructorMaster.dgInstructorShow.Rows(e.rowindex).Cells(2).Value
            frmInstructorMaster.txtMobileNo.Text = frmInstructorMaster.dgInstructorShow.Rows(e.rowindex).Cells(3).Value
            frmInstructorMaster.cmbExperts.Text = frmInstructorMaster.dgInstructorShow.Rows(e.rowindex).Cells(4).Value
            frmInstructorMaster.DTPDateOfJoin.Text = frmInstructorMaster.dgInstructorShow.Rows(e.rowindex).Cells(5).Value
            frmInstructorMaster.cmbGender.Text = frmInstructorMaster.dgInstructorShow.Rows(e.rowindex).Cells(6).Value
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Search Instructor"

    Public Sub SearchInstructor(ByVal objInstructor As Object)

        Try
            If frmInstructorMaster.rbtID.Checked = True Then
                command.CommandText = ("exec SearchInstructorByID '" & objInstructor & "'")
                command = objDb.CreateCommand(Con, command.CommandText)

                clsDbFun.Display(frmInstructorMaster.dgInstructorShow, command.CommandText)

                conn.Open()
                Dim sqlcomm = New SqlCommand(command.CommandText, conn)

                Dim sqldr As SqlDataReader = sqlcomm.ExecuteReader
                While sqldr.Read
                    frmInstructorMaster.txtInstructorID.Text = sqldr(0)
                    frmInstructorMaster.txtInstructorName.Text = sqldr(1)
                    frmInstructorMaster.rtbInstructorAddress.Text = sqldr(2)
                    frmInstructorMaster.txtMobileNo.Text = sqldr(3)
                    frmInstructorMaster.cmbExperts.Text = sqldr(4)
                    frmInstructorMaster.DTPDateOfJoin.Text = sqldr(5)
                    frmInstructorMaster.cmbGender.Text = sqldr(6)
                End While
                conn.Close()
            End If


            If frmInstructorMaster.rbtName.Checked = True Then
                command.CommandText = ("exec SearchInstructorByName '%" & objInstructor & "%'")
                command = objDb.CreateCommand(Con, command.CommandText)

                clsDbFun.Display(frmInstructorMaster.dgInstructorShow, command.CommandText)
                conn.Open()
                Dim sqlcomm = New SqlCommand(command.CommandText, conn)

                Dim sqldr As SqlDataReader = sqlcomm.ExecuteReader
                While sqldr.Read
                    frmInstructorMaster.txtInstructorID.Text = sqldr(0)
                    frmInstructorMaster.txtInstructorName.Text = sqldr(1)
                    frmInstructorMaster.rtbInstructorAddress.Text = sqldr(2)
                    frmInstructorMaster.txtMobileNo.Text = sqldr(3)
                    frmInstructorMaster.cmbExperts.Text = sqldr(4)
                    frmInstructorMaster.DTPDateOfJoin.Text = sqldr(5)
                    frmInstructorMaster.cmbGender.Text = sqldr(6)

                End While
                conn.Close()

            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region

End Class
