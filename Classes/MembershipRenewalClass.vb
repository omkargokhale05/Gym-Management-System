Imports System.Data
Imports System.Data.SqlClient
Imports Gym_Management_System.DBConnection
Imports Gym_Management_System.DBFunction
Imports Gym_Management_System.MembershipRenewalClass
Public Class MembershipRenewalClass

#Region "Declaration of variables"

    'Declaring SQL variables
    Dim objDb As New DBConnection
    Dim Con As New SqlConnection
    Dim command As New SqlCommand
    Dim da As New SqlDataAdapter
    'Dim dr As New SqlDataReader
    Public ds As New DataSet
    Dim str As String

    Public dvMembershipRenewal As DataView
    Public clsDbFun As New DBFunction
    Public currentRow As Integer

    Public flag As Boolean = True
    'Declaring MembershipRenewal variables

    Private _MembershipID As String
    Public Property MembershipID() As String
        Get
            Return _MembershipID
        End Get
        Set(ByVal value As String)
            _MembershipID = value
        End Set
    End Property
    Private _RenewalDate As String
    Public Property RenewalDate() As String
        Get
            Return _RenewalDate
        End Get
        Set(ByVal value As String)
            _RenewalDate = value
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
    Private _TotalFee As String
    Public Property TotalFee() As String
        Get
            Return _TotalFee
        End Get
        Set(ByVal value As String)
            _TotalFee = value
        End Set
    End Property
    Private _PaidFee As String
    Public Property PaidFee() As String
        Get
            Return _PaidFee
        End Get
        Set(ByVal value As String)
            _PaidFee = value
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

#Region "Display Data"

    Public Sub DisplayDataMembershipRenewal()
        Try
            Con = objDb.SetConnection()
            command.CommandText = ("exec DisplayDataMembershipRenewal")
            command = objDb.CreateCommand(Con, command.CommandText)
            da = New SqlDataAdapter(command.CommandText, Con)
            ds = New DataSet
            da.Fill(ds, "MembershipRenewal")
            dvMembershipRenewal = New DataView(ds.Tables("MembershipRenewal"))
            Con.Open()
            command.ExecuteReader()
            Con.Close()
            frmMembershipRenewal.dgMembershipRenewalDetails.DataSource = dvMembershipRenewal

        Catch ex As Exception
        End Try
    End Sub
#End Region

#Region "Check Textboxes"

    Public Sub CheckTextMembershipRenewal()
        Try
            If frmMembershipRenewal.cmbMembershipID.Text.Trim() = String.Empty Then
                MessageBox.Show("Please enter Membership ID..!!")
                flag = False
            ElseIf frmMembershipRenewal.cmbPackageID.Text.Trim() = String.Empty Then
                MessageBox.Show("Please select Package ID ..!!")
                flag = False
            ElseIf frmMembershipRenewal.txtTotalFee.Text.Trim() = String.Empty Then
                MessageBox.Show("Please enter total fee...!!")
                flag = False
            ElseIf frmMembershipRenewal.txtPaidFee.Text.Trim() = String.Empty Then
                MessageBox.Show("Please enter Paid Fee..!!")
                flag = False
            ElseIf frmMembershipRenewal.cmbPaymentMode.Text.Trim() = String.Empty Then
                MessageBox.Show("Please select payment Mode..!!")
                flag = False

            ElseIf frmMembershipRenewal.cmbPaymentMode.Text.Trim() = "Cheqec" Then

                If frmMembershipRenewal.txtBankName.Text.Trim() = String.Empty Then
                    MessageBox.Show("Please enter bank name..!!")
                    flag = False
                ElseIf frmMembershipRenewal.txtCheqckNo.Text.Trim() = String.Empty Then
                    MessageBox.Show("Please enter cheqec number..!!")
                    flag = False
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
#End Region

#Region "Adding MembershipRenewal"
    'Adding MembershipRenewal
    Public Sub AddMembershipRenewalDtls(ByVal MembershipID, ByVal RenewalDate, ByVal PackageID, ByVal ValidUpto, ByVal TotalFee, ByVal PaidFee, ByVal BalanceAmount, ByVal PaymentMode, ByVal BankName, ByVal ChecqueNo)
        Try
            Con = objDb.SetConnection()
            command.CommandText = ("exec AddMembershipRenewalDtls '" & MembershipID & "','" & RenewalDate & "','" & PackageID & "','" & ValidUpto & "','" & TotalFee & "','" & PaidFee & "','" & BalanceAmount & "','" & PaymentMode & "','" & BankName & "','" & ChecqueNo & "'")
            command = objDb.CreateCommand(Con, command.CommandText)

            Con.Open()
            command.ExecuteNonQuery()
            Con.Close()
            MessageBox.Show("MembershipRenewal Details Added Successfully!!!", "Confirmation...(Gym Management System)", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ClearTextMembershipRenewal()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error in Adding MembershipRenewal")

        End Try
    End Sub
#End Region

#Region "Updating MembershipRenewal"

    'Updating MembershipRenewal
    Public Sub UpdateMembershipRenewalDtls(ByVal MembershipID, ByVal RenewalDate, ByVal PackageID, ByVal ValidUpto, ByVal TotalFee, ByVal PayFee, ByVal BalanceAmount, ByVal PaymentMode, ByVal BankName, ByVal ChecqueNo)
        Try
            Con = objDb.SetConnection()
            command.CommandText = ("exec UpdateMembershipRenewalDtls '" & MembershipID & "','" & RenewalDate & "','" & PackageID & "','" & ValidUpto & "','" & TotalFee & "','" & PayFee & "','" & BalanceAmount & "','" & PaymentMode & "','" & BankName & "','" & ChecqueNo & "'")
            command = objDb.CreateCommand(Con, command.CommandText)

            Con.Open()
            command.ExecuteNonQuery()
            Con.Close()
            MessageBox.Show("MembershipRenewal Details Updated Successfully!!!", "Confirmation...(Gym Management System)", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ClearTextMembershipRenewal()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error in Updating MembershipRenewal")
        End Try
    End Sub
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
                frmMembershipRenewal.txtPackageName.Text = dr(1)
                frmMembershipRenewal.txtPackageAmount.Text = dr(2)
                frmMembershipRenewal.rtbTerms.Text = dr(3)
                frmMembershipRenewal.txtActiveStatus.Text = dr(4)
                frmMembershipRenewal.txtNoOfInstallments.Text = dr(5)
            End While
        Else
            frmMembershipRenewal.txtPackageName.Text = ""
            frmMembershipRenewal.txtPackageAmount.Text = ""
            frmMembershipRenewal.rtbTerms.Text = ""
            frmMembershipRenewal.txtActiveStatus.Text = ""
            frmMembershipRenewal.txtNoOfInstallments.Text = ""
        End If
        Return dr
    End Function
#End Region

#Region "Clear Textboxes"

    Public Sub ClearTextMembershipRenewal()

        With frmMembershipRenewal
            .cmbMembershipID.Text = String.Empty
            .cmbPackageID.Text = String.Empty
            .txtTotalFee.Clear()
            .txtPaidFee.Clear()
            .txtBalanceAmount.Clear()
            .cmbPaymentMode.Text = String.Empty
            .txtBankName.Clear()
            .txtCheqckNo.Clear()

            .txtPackageName.Clear()
            .txtPackageAmount.Clear()
            .rtbTerms.Clear()
            .txtActiveStatus.Clear()
            .txtNoOfInstallments.Clear()
        End With
    End Sub
#End Region

#Region "Binding Navigator"

    Public Sub navigationMembershipRenewal()
        Try
            ds = New DataSet
            currentRow = 0
            Con = objDb.SetConnection()
            command.CommandText = ("exec navigationMembershipRenewal")
            command = objDb.CreateCommand(Con, command.CommandText)
            da = New SqlDataAdapter(command.CommandText, Con)
            da.Fill(ds, "MRD")
            ShowDataMembershipRenewal(currentRow)
        Catch ex As Exception

        End Try

    End Sub
    Public Sub ShowDataMembershipRenewal(ByVal currentRow)

        Try
            frmMembershipRenewal.cmbMembershipID.Text = ds.Tables("MRD").Rows(currentRow).Item(0)
            frmMembershipRenewal.DTPRenewalDate.Text = ds.Tables("MRD").Rows(currentRow).Item(1)
            frmMembershipRenewal.cmbPackageID.Text = ds.Tables("MRD").Rows(currentRow).Item(2)
            frmMembershipRenewal.DTPValidUpto.Text = ds.Tables("MRD").Rows(currentRow).Item(3)
            frmMembershipRenewal.txtTotalFee.Text = ds.Tables("MRD").Rows(currentRow).Item(4)
            frmMembershipRenewal.txtPaidFee.Text = ds.Tables("MRD").Rows(currentRow).Item(5)
            frmMembershipRenewal.txtBalanceAmount.Text = ds.Tables("MRD").Rows(currentRow).Item(6)
            frmMembershipRenewal.cmbPaymentMode.Text = ds.Tables("MRD").Rows(currentRow).Item(7)
            frmMembershipRenewal.txtBankName.Text = ds.Tables("MRD").Rows(currentRow).Item(8)
            frmMembershipRenewal.txtCheqckNo.Text = ds.Tables("MRD").Rows(currentRow).Item(9)


        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Cell Click"

    Public Sub CellClickMembershipRenewal(ByVal e As Object)

        Try
            frmMembershipRenewal.cmbMembershipID.Text = frmMembershipRenewal.dgMembershipRenewalDetails.Rows(e.rowindex).Cells(0).Value
            frmMembershipRenewal.DTPRenewalDate.Text = frmMembershipRenewal.dgMembershipRenewalDetails.Rows(e.rowindex).Cells(1).Value
            frmMembershipRenewal.cmbPackageID.Text = frmMembershipRenewal.dgMembershipRenewalDetails.Rows(e.rowindex).Cells(2).Value
            frmMembershipRenewal.DTPValidUpto.Text = frmMembershipRenewal.dgMembershipRenewalDetails.Rows(e.rowindex).Cells(3).Value
            frmMembershipRenewal.txtTotalFee.Text = frmMembershipRenewal.dgMembershipRenewalDetails.Rows(e.rowindex).Cells(4).Value
            frmMembershipRenewal.txtPaidFee.Text = frmMembershipRenewal.dgMembershipRenewalDetails.Rows(e.rowindex).Cells(5).Value
            frmMembershipRenewal.txtBalanceAmount.Text = frmMembershipRenewal.dgMembershipRenewalDetails.Rows(e.rowindex).Cells(6).Value
            frmMembershipRenewal.cmbPaymentMode.Text = frmMembershipRenewal.dgMembershipRenewalDetails.Rows(e.rowindex).Cells(7).Value
            frmMembershipRenewal.txtBankName.Text = frmMembershipRenewal.dgMembershipRenewalDetails.Rows(e.rowindex).Cells(8).Value
            frmMembershipRenewal.txtCheqckNo.Text = frmMembershipRenewal.dgMembershipRenewalDetails.Rows(e.rowindex).Cells(9).Value
        Catch ex As Exception

        End Try
    End Sub
#End Region

End Class
