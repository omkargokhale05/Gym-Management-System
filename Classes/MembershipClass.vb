Imports System.Data
Imports System.Data.SqlClient
Imports Gym_Management_System.DBConnection
Imports Gym_Management_System.DBFunction
Imports Gym_Management_System.MembershipClass
Public Class MembershipClass

#Region "Declaration of variables"

    'Declaring SQL variables
    Dim objDb As New DBConnection
    Dim Con As New SqlConnection
    Dim command As New SqlCommand
    Dim da As New SqlDataAdapter
    'Dim dr As New SqlDataReader
    Public ds As New DataSet
    Dim str As String

    Public dvMembership As DataView
    Public clsDbFun As New DBFunction
    Public currentRow As Integer

    Public flag As Boolean = True
    'Declaring Membership variables

    Private _MembershipID As String
    Public Property MembershipID() As String
        Get
            Return _MembershipID
        End Get
        Set(ByVal value As String)
            _MembershipID = value
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

    Private _MembershipDate As String
    Public Property MembershipDate() As String
        Get
            Return _MembershipDate
        End Get
        Set(ByVal value As String)
            _MembershipDate = value
        End Set
    End Property

    Private _Purpose As String
    Public Property Purpose() As String
        Get
            Return _Purpose
        End Get
        Set(ByVal value As String)
            _Purpose = value
        End Set
    End Property

    Private _PackageID As String
    Public Property PackageID() As String
        Get
            Return _PackageID
        End Get
        Set(ByVal value As String)
            _PackageID = value
        End Set
    End Property

    Private _ValidUpto As String
    Public Property ValidUpto() As String
        Get
            Return _ValidUpto
        End Get
        Set(ByVal value As String)
            _ValidUpto = value
        End Set
    End Property

    Private _PayFee As String
    Public Property PayFee() As String
        Get
            Return _PayFee
        End Get
        Set(ByVal value As String)
            _PayFee = value
        End Set
    End Property
    Private _BalanceAmount As String
    Public Property BalanceAmount() As String
        Get
            Return _BalanceAmount
        End Get
        Set(ByVal value As String)
            _BalanceAmount = value
        End Set
    End Property
    Private _PaymentMode As String
    Public Property PaymentMode() As String
        Get
            Return _PaymentMode
        End Get
        Set(ByVal value As String)
            _PaymentMode = value
        End Set
    End Property
    Private _BankName As String
    Public Property BankName() As String
        Get
            Return _BankName
        End Get
        Set(ByVal value As String)
            _BankName = value
        End Set
    End Property
    Private _ChecqueNo As String
    Public Property ChecqueNo() As String
        Get
            Return _ChecqueNo
        End Get
        Set(ByVal value As String)
            _ChecqueNo = value
        End Set
    End Property
#End Region

#Region "Generate ID"

    Public Sub GenerateMembershipID()

        Con = objDb.SetConnection()
        command.CommandText = ("exec GenerateMembershipID")
        command = objDb.CreateCommand(Con, command.CommandText)
        Con.Open()
        Dim dr As SqlDataReader = command.ExecuteReader

        While dr.Read
            frmMembershipDetails.txtMembershipID.Text = dr(0)
        End While
        frmMembershipDetails.txtMembershipID.Text = Val(frmMembershipDetails.txtMembershipID.Text) + 1
        dr.Close()
        Con.Close()
    End Sub
#End Region

#Region "Display Data"

    Public Sub DisplayDataMembership()
        Try
            Con = objDb.SetConnection()
            command.CommandText = ("exec DisplayDataMembership")
            command = objDb.CreateCommand(Con, command.CommandText)
            da = New SqlDataAdapter(command.CommandText, Con)
            ds = New DataSet
            da.Fill(ds, "MembershipProfile")
            dvMembership = New DataView(ds.Tables("MembershipProfile"))
            Con.Open()
            command.ExecuteReader()
            Con.Close()
            frmMembershipDetails.dgMembershipDetails.DataSource = dvMembership

        Catch ex As Exception
        End Try
    End Sub
#End Region

#Region "Check Textboxes"

    Public Sub CheckTextMembership()

        Try

            If frmMembershipDetails.cmbMemberID.Text.Trim() = String.Empty Then
                MessageBox.Show("Please enter Member ID..!!")
                flag = False
            ElseIf frmMembershipDetails.txtPurpose.Text.Trim() = String.Empty Then
                MessageBox.Show("Please enter Purpose ..!!")
                flag = False
            ElseIf frmMembershipDetails.cmbPackageID.Text.Trim() = String.Empty Then
                MessageBox.Show("Please enter Package ID..!!")
                flag = False
            ElseIf frmMembershipDetails.txtPaidFee.Text.Trim() = String.Empty Then
                MessageBox.Show("Please enter Total Fee..!!")
                flag = False
            ElseIf frmMembershipDetails.cmbPaymentMode.Text.Trim() = String.Empty Then
                MessageBox.Show("Please Select Payment Mode..!!")
                flag = False
            ElseIf frmMembershipDetails.cmbPaymentMode.Text <> "Cash" Then

                If frmMembershipDetails.txtBankName.Text.Trim() = String.Empty Then
                    MessageBox.Show("Please enter bank name..!!")
                    flag = False
                ElseIf frmMembershipDetails.txtCheqckNo.Text.Trim() = String.Empty Then
                    MessageBox.Show("Please enter cheqec no..!!")
                    flag = False
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
#End Region

#Region "Adding Membership"
    'Adding Membership
    Public Sub AddMembershipDtls(ByVal MembershipID, ByVal MemberID, ByVal MembershipDate, ByVal Purpose, ByVal PackageID, ByVal ValidUpto, ByVal TotalFee, ByVal PayFee, ByVal BalanceAmount, ByVal PaymentMode, ByVal BankName, ByVal ChecqueNo)
        Try
            Con = objDb.SetConnection()
            command.CommandText = ("exec AddMembershipDtls '" & MembershipID & "','" & MemberID & "','" & MembershipDate & "','" & Purpose & "','" & PackageID & "','" & ValidUpto & "','" & TotalFee & "','" & PayFee & "','" & BalanceAmount & "','" & PaymentMode & "','" & BankName & "','" & ChecqueNo & "'")
            command = objDb.CreateCommand(Con, command.CommandText)

            Con.Open()
            command.ExecuteNonQuery()
            Con.Close()
            MessageBox.Show("Membership Details Added Successfully!!!", "Confirmation...(Gym Management System)", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ClearTextMembership()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error in Adding Membership")

        End Try
    End Sub
#End Region

#Region "Updating Membership"

    'Updating Membership
    Public Sub UpdateMembershipDtls(ByVal MembershipID, ByVal MemberID, ByVal MembershipDate, ByVal Purpose, ByVal PackageID, ByVal ValidUpto, ByVal TotalFee, ByVal PayFee, ByVal BalanceAmount, ByVal PaymentMode, ByVal BankName, ByVal ChecqueNo)
        Try
            Con = objDb.SetConnection()
            command.CommandText = ("exec UpdateMembershipDtls '" & MembershipID & "','" & MemberID & "','" & MembershipDate & "','" & Purpose & "','" & PackageID & "','" & ValidUpto & "','" & TotalFee & "','" & PayFee & "','" & BalanceAmount & "','" & PaymentMode & "','" & BankName & "','" & ChecqueNo & "'")
            command = objDb.CreateCommand(Con, command.CommandText)

            Con.Open()
            command.ExecuteNonQuery()
            Con.Close()
            MessageBox.Show("Membership Details Updated Successfully!!!", "Confirmation...(Gym Management System)", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ClearTextMembership()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error in Updating Membership")
        End Try
    End Sub
#End Region

#Region "Display Member Details"
    'Display Health CheckUp
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

                frmMembershipDetails.txtMemberName.Text = dr(1)
                frmMembershipDetails.rtbMemberAddress.Text = dr(2)
                frmMembershipDetails.txtResidentNo.Text = dr(3)
                frmMembershipDetails.txtMobileNo.Text = dr(4)
                frmMembershipDetails.DTPDateOfBirth.Text = dr(5)
                frmMembershipDetails.cmbGender.Text = dr(6)
            End While
        Else
            frmMembershipDetails.txtMemberName.Text = ""
            frmMembershipDetails.rtbMemberAddress.Text = ""
            frmMembershipDetails.txtResidentNo.Text = ""
            frmMembershipDetails.txtMobileNo.Text = ""
            frmMembershipDetails.DTPDateOfBirth.Text = ""
            frmMembershipDetails.cmbGender.Text = ""
        End If
        Return dr
    End Function
#End Region

#Region "Display Package Details"
    'Display Package Details
    Public Function DisplayPackageDetails(ByVal PackageID) As SqlDataReader
        Dim dr As SqlDataReader
        Con = objDb.SetConnection()
        Con.Open()
        command.CommandText = ("exec DisplayPackageDetails '" & PackageID & "'")
        da = New SqlDataAdapter(command.CommandText, Con)
        command = New SqlCommand(command.CommandText, Con)
        dr = command.ExecuteReader

        If dr.HasRows Then
            While dr.Read
                frmMembershipDetails.txtPackageName.Text = dr(1)
                frmMembershipDetails.txtPackageAmount.Text = dr(2)
                frmMembershipDetails.rtbPackageTerms.Text = dr(3)
                frmMembershipDetails.txtActiveStatus.Text = dr(4)
                frmMembershipDetails.txtNoOfInstallments.Text = dr(5)
            End While
        Else
            frmMembershipDetails.txtPackageName.Text = ""
            frmMembershipDetails.txtPackageAmount.Text = ""
            frmMembershipDetails.rtbPackageTerms.Text = ""
            frmMembershipDetails.txtActiveStatus.Text = ""
            frmMembershipDetails.txtNoOfInstallments.Text = ""
        End If
        Return dr
    End Function
#End Region

#Region "Clear Textboxes"

    Public Sub ClearTextMembership()

        With frmMembershipDetails
            .cmbMemberID.Text = String.Empty
            .txtPurpose.Clear()
            .cmbPackageID.Text = String.Empty
            .txtTotalFee.Clear()
            .txtPaidFee.Clear()
            .txtBalanceAmount.Clear()
            .cmbPaymentMode.Text = String.Empty
            .txtBankName.Clear()
            .txtCheqckNo.Clear()

            .txtMemberName.Clear()
            .rtbMemberAddress.Clear()
            .txtResidentNo.Clear()
            .txtMobileNo.Clear()
            .cmbGender.Text = String.Empty


            .txtPackageName.Clear()
            .txtPackageAmount.Clear()
            .rtbMemberAddress.Clear()
            .txtActiveStatus.Clear()
            .txtNoOfInstallments.Clear()
        End With
    End Sub
#End Region

#Region "Binding Navigator"

    Public Sub navigationMembership()
        Try
            ds = New DataSet
            currentRow = 0
            Con = objDb.SetConnection()
            command.CommandText = ("exec BindMembershipDtls")
            command = objDb.CreateCommand(Con, command.CommandText)
            da = New SqlDataAdapter(command.CommandText, Con)
            da.Fill(ds, "MSD")
            ShowDataMembership(currentRow)
        Catch ex As Exception

        End Try

    End Sub
    Public Sub ShowDataMembership(ByVal currentRow)

        Try
            frmMembershipDetails.txtMembershipID.Text = ds.Tables("MSD").Rows(currentRow).Item(0)
            frmMembershipDetails.cmbMemberID.Text = ds.Tables("MSD").Rows(currentRow).Item(1)
            frmMembershipDetails.DTPMembershipDate.Text = ds.Tables("MSD").Rows(currentRow).Item(2)
            frmMembershipDetails.txtPurpose.Text = ds.Tables("MSD").Rows(currentRow).Item(3)
            frmMembershipDetails.cmbPackageID.Text = ds.Tables("MSD").Rows(currentRow).Item(4)
            frmMembershipDetails.DTPValidOut.Text = ds.Tables("MSD").Rows(currentRow).Item(5)
            frmMembershipDetails.txtTotalFee.Text = ds.Tables("MSD").Rows(currentRow).Item(6)
            frmMembershipDetails.txtPaidFee.Text = ds.Tables("MSD").Rows(currentRow).Item(7)
            frmMembershipDetails.txtBalanceAmount.Text = ds.Tables("MSD").Rows(currentRow).Item(8)
            frmMembershipDetails.cmbPaymentMode.Text = ds.Tables("MSD").Rows(currentRow).Item(9)
            frmMembershipDetails.txtBankName.Text = ds.Tables("MSD").Rows(currentRow).Item(10)
            frmMembershipDetails.txtCheqckNo.Text = ds.Tables("MSD").Rows(currentRow).Item(11)


        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Cell Click"

    Public Sub CellClickMembership(ByVal e As Object)

        Try
            frmMembershipDetails.txtMembershipID.Text = frmMembershipDetails.dgMembershipDetails.Rows(e.rowindex).Cells(0).Value
            frmMembershipDetails.cmbMemberID.Text = frmMembershipDetails.dgMembershipDetails.Rows(e.rowindex).Cells(1).Value
            frmMembershipDetails.DTPMembershipDate.Text = frmMembershipDetails.dgMembershipDetails.Rows(e.rowindex).Cells(2).Value
            frmMembershipDetails.txtPurpose.Text = frmMembershipDetails.dgMembershipDetails.Rows(e.rowindex).Cells(3).Value
            frmMembershipDetails.cmbPackageID.Text = frmMembershipDetails.dgMembershipDetails.Rows(e.rowindex).Cells(4).Value
            frmMembershipDetails.DTPValidOut.Text = frmMembershipDetails.dgMembershipDetails.Rows(e.rowindex).Cells(5).Value
            frmMembershipDetails.txtTotalFee.Text = frmMembershipDetails.dgMembershipDetails.Rows(e.rowindex).Cells(6).Value
            frmMembershipDetails.txtPaidFee.Text = frmMembershipDetails.dgMembershipDetails.Rows(e.rowindex).Cells(7).Value
            frmMembershipDetails.txtBalanceAmount.Text = frmMembershipDetails.dgMembershipDetails.Rows(e.rowindex).Cells(8).Value
            frmMembershipDetails.cmbPaymentMode.Text = frmMembershipDetails.dgMembershipDetails.Rows(e.rowindex).Cells(9).Value
            frmMembershipDetails.txtBankName.Text = frmMembershipDetails.dgMembershipDetails.Rows(e.rowindex).Cells(10).Value
            frmMembershipDetails.txtCheqckNo.Text = frmMembershipDetails.dgMembershipDetails.Rows(e.rowindex).Cells(11).Value
        Catch ex As Exception

        End Try
    End Sub
#End Region

End Class
