Imports System.Data
Imports System.Data.SqlClient
Imports Gym_Management_System.DBConnection
Imports Gym_Management_System.DBFunction
Imports Gym_Management_System.PackageMaster
Public Class PackageMaster

#Region "Declaration of variables"

    'Declaring SQL variables
    Dim objDb As New DBConnection
    Dim Con As New SqlConnection
    Dim command As New SqlCommand
    Dim da As New SqlDataAdapter
    Public ds As New DataSet
    Dim str As String

    Public dvPackage As DataView
    Public clsDbFun As New DBFunction
    Public currentRow As Integer

    Public flag As Boolean = True
    'Declaring Package variables

    Private _PackageID As String
    Public Property PackageID() As String
        Get
            Return _PackageID
        End Get
        Set(ByVal value As String)
            _PackageID = value
        End Set
    End Property
    Private _PackageName As String
    Public Property PackageName() As String
        Get
            Return _PackageName
        End Get
        Set(ByVal value As String)
            _PackageName = value
        End Set
    End Property

    Private _PackageAmount As String
    Public Property PackageAmount() As String
        Get
            Return _PackageAmount
        End Get
        Set(ByVal value As String)
            _PackageAmount = value
        End Set
    End Property
    Private _PackageTerms As String
    Public Property PackageTerms() As String
        Get
            Return _PackageTerms
        End Get
        Set(ByVal value As String)
            _PackageTerms = value
        End Set
    End Property
    Private _ActiveStatus As String
    Public Property ActiveStatus() As String
        Get
            Return _ActiveStatus
        End Get
        Set(ByVal value As String)
            _ActiveStatus = value
        End Set
    End Property
    Private _NoOfInstallments As String
    Public Property NoOfInstallments() As String
        Get
            Return _NoOfInstallments
        End Get
        Set(ByVal value As String)
            _NoOfInstallments = value
        End Set
    End Property
#End Region


#Region "Display Data"

    Public Sub DisplayDataPackage()
        Try
            Con = objDb.SetConnection()
            Command.CommandText = ("exec DisplayDataPackage")
            Command = objDb.CreateCommand(Con, Command.CommandText)
            da = New SqlDataAdapter(Command.CommandText, Con)
            ds = New DataSet
            da.Fill(ds, "Package")
            dvPackage = New DataView(ds.Tables("Package"))
            Con.Open()
            Command.ExecuteReader()
            Con.Close()
            frmPackageMaster.dgPackageShow.DataSource = dvPackage

        Catch ex As Exception

        End Try
    End Sub

#End Region

#Region "Generate ID"

    Public Sub GeneratePackageId()

        Con = objDb.SetConnection()
        Command.CommandText = ("exec GeneratePackageID")
        Command = objDb.CreateCommand(Con, Command.CommandText)
        Con.Open()
        Dim dr As SqlDataReader = Command.ExecuteReader

        While dr.Read
            frmPackageMaster.txtPackageID.Text = dr(0)
        End While
        frmPackageMaster.txtPackageID.Text = Val(frmPackageMaster.txtPackageID.Text) + 1
        dr.Close()
        Con.Close()
    End Sub
#End Region

#Region "Check Textboxes"

    Public Sub CheckTextPackage()
        Try
            If frmPackageMaster.txtPackageName.Text.Trim() = String.Empty Then
                MessageBox.Show("Please enter Package Name..!!")
                flag = False
            ElseIf frmPackageMaster.txtPackageAmount.Text.Trim() = String.Empty Then
                MessageBox.Show("Please enter Package Amount..!!")
                flag = False
            ElseIf frmPackageMaster.rtbPackageTerms.Text.Trim() = String.Empty Then
                MessageBox.Show("Please Enter Package Terms.!!")
                flag = False
            ElseIf frmPackageMaster.cmbActiveStatus.Text.Trim() = String.Empty Then
                MessageBox.Show("Please select Active Status..!!")
                flag = False
            ElseIf frmPackageMaster.txtNoOfInstallments.Text.Trim() = String.Empty Then
                MessageBox.Show("Please enter No of Installments Status..!!")
                flag = False
            End If

        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Adding Package"
    'Adding Package
    Public Sub AddPackage(ByVal PackageID, ByVal PackageName, ByVal PackageAmount, ByVal PackageTerms, ByVal ActiveStatus, ByVal NoOfInstallments)
        Try
            Con = objDb.SetConnection()
            command.CommandText = ("exec AddPackage '" & PackageID & "','" & PackageName & "','" & PackageAmount & "','" & PackageTerms & "','" & ActiveStatus & "','" & NoOfInstallments & "'")
            command = objDb.CreateCommand(Con, command.CommandText)

            Con.Open()
            command.ExecuteNonQuery()
            Con.Close()
            MessageBox.Show("Package Details Added Successfully!!!", "Confirmation...(Gym Management System)", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'ClearTextPackage()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error in Adding Package")

        End Try
    End Sub
#End Region

#Region "Updating Package"

    'Updating Package
    Public Sub UpdatePackage(ByVal PackageID, ByVal PackageName, ByVal PackageAmount, ByVal PackageTerms, ByVal ActiveStatus, ByVal NoOfInstallments)
        Try
            Con = objDb.SetConnection()
            command.CommandText = ("exec UpdatePackage '" & PackageID & "','" & PackageName & "','" & PackageAmount & "','" & PackageTerms & "','" & ActiveStatus & "','" & NoOfInstallments & "'")
            command = objDb.CreateCommand(Con, command.CommandText)

            Con.Open()
            command.ExecuteNonQuery()
            Con.Close()
            MessageBox.Show("Package Details Updated Successfully!!!", "Confirmation...(Gym Management System)", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ClearTextPackage()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error in Updating Package")
        End Try
    End Sub
#End Region

#Region "Clear Textboxes"

    Public Sub ClearTextPackage()

        With frmPackageMaster

            .txtPackageID.Clear()
            .txtPackageName.Clear()
            .txtPackageAmount.Clear()
            .txtNoOfInstallments.Clear()
            .rtbPackageTerms.Clear()
            .cmbActiveStatus.Text = String.Empty
        End With
    End Sub
#End Region

#Region "Binding Navigator"

    Public Sub navigationPackage()
        Try
            ds = New DataSet
            currentRow = 0
            Con = objDb.SetConnection()
            Command.CommandText = ("exec BindPackage")
            Command = objDb.CreateCommand(Con, Command.CommandText)
            da = New SqlDataAdapter(Command.CommandText, Con)
            da.Fill(ds, "PM")
            ShowDataPackage(currentRow)
        Catch ex As Exception

        End Try

    End Sub
    Public Sub ShowDataPackage(ByVal currentRow)

        Try
            frmPackageMaster.txtPackageID.Text = ds.Tables("PM").Rows(currentRow).Item(0)
            frmPackageMaster.txtPackageName.Text = ds.Tables("PM").Rows(currentRow).Item(1)
            frmPackageMaster.txtPackageAmount.Text = ds.Tables("PM").Rows(currentRow).Item(2)
            frmPackageMaster.rtbPackageTerms.Text = ds.Tables("PM").Rows(currentRow).Item(3)
            frmPackageMaster.cmbActiveStatus.Text = ds.Tables("PM").Rows(currentRow).Item(4)
            frmPackageMaster.txtNoOfInstallments.Text = ds.Tables("PM").Rows(currentRow).Item(5)
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Cell Click"

    Public Sub CellClickPackage(ByVal e As Object)

        Try
            frmPackageMaster.txtPackageID.Text = frmPackageMaster.dgPackageShow.Rows(e.rowindex).Cells(0).Value
            frmPackageMaster.txtPackageName.Text = frmPackageMaster.dgPackageShow.Rows(e.rowindex).Cells(1).Value
            frmPackageMaster.txtPackageAmount.Text = frmPackageMaster.dgPackageShow.Rows(e.rowindex).Cells(2).Value
            frmPackageMaster.rtbPackageTerms.Text = frmPackageMaster.dgPackageShow.Rows(e.rowindex).Cells(3).Value
            frmPackageMaster.cmbActiveStatus.Text = frmPackageMaster.dgPackageShow.Rows(e.rowindex).Cells(4).Value
            frmPackageMaster.txtNoOfInstallments.Text = frmPackageMaster.dgPackageShow.Rows(e.rowindex).Cells(5).Value
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Bind Package"
    'Bind Package
    Public Sub BindFacilityDtls()

        Dim ds As New DataSet

        Con = objDb.SetConnection()
        command.CommandText = ("exec BindFacilityDtls")

        da = New SqlDataAdapter(command.CommandText, Con)
        da.Fill(ds)

        frmPackageMaster.lstFacilityName.DataSource = ds.Tables(0)
        frmPackageMaster.lstFacilityName.DisplayMember = ds.Tables(0).Columns(1).ToString()
        frmPackageMaster.lstFacilityName.ValueMember = ds.Tables(0).Columns(0).ToString()
    End Sub
#End Region

#Region "Adding Package Mapping"

    'Adding Package Mapping
    Public Sub addPackageMapping(ByVal PackageID As String, ByVal FacilityID As String)
        Try
            Con = objDb.SetConnection()
            command.CommandText = ("exec InsertPackageMapping '" & PackageID & "', '" & FacilityID & "'")
            command = objDb.CreateCommand(Con, command.CommandText)

            Con.Open()
            command.ExecuteNonQuery()
            Con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error in Adding Package")
        End Try
    End Sub
#End Region

End Class
