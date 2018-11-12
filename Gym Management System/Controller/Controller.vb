Imports System.Data
Imports System.Data.SqlClient
Imports Gym_Management_System.DBConnection
Imports Gym_Management_System.DBFunction
Public Class Controller
#Region "Declaration"
    Dim clsMember As New MemberClass
    Dim clsInstructor As New InstructorClass
    Dim clsHealthDtls As New HealthClass
    Dim clsHealthCheckUp As New HealthCheckUpClass
    Dim clsAttendence As New Attendence
    Dim clsFacility As New FacilityClass
    Dim clsPackage As New PackageMaster
    Dim ClsMembershipDtls As New MembershipClass
    Dim ClsMembershipRenewalDtls As New MembershipRenewalClass
    Dim ClsReservationRequest As New ReservationRequestClass
    Dim clsDbFun As New DBFunction
    Dim clsLogin As New LoginClass

#End Region
#Region "Login"

    Public Sub GenerateLoginID()
        clsLogin.GenerateLoginID()
    End Sub
    'Public Sub DisplayDataHealthCheckUp()
    '    clsHealthCheckUp.DisplayDataHealthCheckUp()
    'End Sub
    Public Sub CheckTextCreateAccount()
        clsLogin.CheckTextCreateAccount()
    End Sub
    Public Sub ClearTextCreateAccount()
        clsLogin.ClearTextCreateAccount()
    End Sub

    Public Sub AddAccount(ByVal LoginID As String, ByVal UserName As String, ByVal Password As String, ByVal Question As String, ByVal Answer As String)
        clsLogin.AddAccount(LoginID, UserName, Password, Question, Answer)
    End Sub
    'Public Sub UpdateHealthCheckUpDtls(ByVal HealthID As String, ByVal MemberID As String, ByVal Month As String, ByVal MonthCount As String, ByVal CheckUpDate As String)
    '    clsHealthCheckUp.UpdateHealthCheckUpDtls(HealthID, MemberID, Month, MonthCount, CheckUpDate)
    'End Sub
    'Public Sub navigationHealthCheckUp()
    '    clsHealthCheckUp.navigationHealthCheckUp()
    'End Sub
#End Region

#Region "Member"

    Public Sub GenerateMemberId()
        clsMember.GenerateMemberId()
    End Sub
    Public Sub DisplayDataMember()
        clsMember.DisplayDataMember()
    End Sub
    Public Sub CheckTextMember()
        clsMember.CheckTextMember()
    End Sub
    Public Sub ClearTextMember()
        clsMember.ClearTextMember()
    End Sub

    Public Sub AddMember(ByVal MemberID As String, ByVal MemberName As String, ByVal Address As String, ByVal ResidentNo As String, ByVal MobileNo As String, ByVal DOB As String, ByVal Gender As String)
        clsMember.AddMember(MemberID, MemberName, Address, ResidentNo, MobileNo, DOB, Gender)
    End Sub
    Public Sub CellClickMember(ByVal e As Object)
        clsMember.CellClickMember(e)
    End Sub
    Public Sub UpdateMember(ByVal MemberID As String, ByVal MemberName As String, ByVal Address As String, ByVal ResidentNo As String, ByVal MobileNo As String, ByVal DOB As String, ByVal Gender As String)
        clsMember.UpdateMember(MemberID, MemberName, Address, ResidentNo, MobileNo, DOB, Gender)
    End Sub
    Public Sub DeleteMember(ByVal MemberID As String)
        clsMember.DeleteMember(MemberID)
    End Sub

    Public Sub navigationMember()
        clsMember.navigationMember()
    End Sub

    Public Sub SearchMember(ByVal objMember As Object)
        clsMember.SearchMember(objMember)
    End Sub
#End Region

#Region "Membership Details"

    Public Sub GenerateMembershipID()
        ClsMembershipDtls.GenerateMembershipID()
    End Sub
    Public Sub DisplayDataMembership()
        ClsMembershipDtls.DisplayDataMembership()
    End Sub
    Public Sub CheckTextMembership()
        ClsMembershipDtls.CheckTextMembership()
    End Sub
    Public Sub ClearTextMembership()
        ClsMembershipDtls.ClearTextMembership()
    End Sub
    Public Sub AddMembershipDtls(ByVal MembershipID As String, ByVal MemberID As String, ByVal MembershipDate As String, ByVal Purpose As String, ByVal PackageID As String, ByVal ValidUpto As String, ByVal TotalFee As String, ByVal PaidFee As String, ByVal BalanceAmount As String, ByVal PaymentMode As String, ByVal BankName As String, ByVal ChecqueNo As String)
        ClsMembershipDtls.AddMembershipDtls(MembershipID, MemberID, MembershipDate, Purpose, PackageID, ValidUpto, TotalFee, PaidFee, BalanceAmount, PaymentMode, BankName, ChecqueNo)
    End Sub
    Public Sub CellClickMembership(ByVal e As Object)
        ClsMembershipDtls.CellClickMembership(e)
    End Sub
    Public Sub UpdateMembershipDtls(ByVal MembershipID As String, ByVal MemberID As String, ByVal MembershipDate As String, ByVal Purpose As String, ByVal PackageID As String, ByVal ValidUpto As String, ByVal TotalFee As String, ByVal PaidFee As String, ByVal BalanceAmount As String, ByVal PaymentMode As String, ByVal BankName As String, ByVal ChecqueNo As String)
        ClsMembershipDtls.UpdateMembershipDtls(MembershipID, MemberID, MembershipDate, Purpose, PackageID, ValidUpto, TotalFee, PaidFee, BalanceAmount, PaymentMode, BankName, ChecqueNo)
    End Sub
    Public Sub navigationMembership()
        ClsMembershipDtls.navigationMembership()
    End Sub
#End Region

#Region "Reservation Request Details"

    Public Sub GenerateRequestID()
        ClsReservationRequest.GenerateRequestID()
    End Sub
    Public Sub DisplayDataReservationRequest()
        ClsReservationRequest.DisplayDataReservationRequest()
    End Sub
    Public Sub CheckTextReservationRequest()
        ClsReservationRequest.CheckTextReservationRequest()
    End Sub
    Public Sub ClearTextReservationRequest()
        ClsReservationRequest.ClearTextReservationRequest()
    End Sub
    Public Sub AddReservationRequestDtls(ByVal RequestID As String, ByVal MemberID As String, ByVal RequestDate As String, ByVal UtilisationDate As String, ByVal FacilityID As String)
        ClsReservationRequest.AddReservationRequestDtls(RequestID, MemberID, RequestDate, UtilisationDate, FacilityID)
    End Sub
    Public Sub CellClickReservationRequest(ByVal e As Object)
        ClsReservationRequest.CellClickReservationRequest(e)
    End Sub
    Public Sub UpdateReservationRequestDtls(ByVal RequestID As String, ByVal MemberID As String, ByVal RequestDate As String, ByVal UtilisationDate As String, ByVal FacilityID As String)
        ClsReservationRequest.UpdateReservationRequestDtls(RequestID, MemberID, RequestDate, UtilisationDate, FacilityID)
    End Sub
    Public Sub navigationReservationRequest()
        ClsReservationRequest.navigationReservationRequest()
    End Sub
#End Region


#Region "MembershipRenewal Details"

    Public Sub DisplayDataMembershipRenewal()
        ClsMembershipRenewalDtls.DisplayDataMembershipRenewal()
    End Sub
    Public Sub CheckTextMembershipRenewal()
        ClsMembershipRenewalDtls.CheckTextMembershipRenewal()
    End Sub
    Public Sub ClearTextMembershipRenewal()
        ClsMembershipRenewalDtls.ClearTextMembershipRenewal()
    End Sub
    Public Sub AddMembershipRenewalDtls(ByVal MembershipID As String, ByVal RenewalDate As String, ByVal PackageID As String, ByVal ValidUpto As String, ByVal TotalFee As String, ByVal PaidFee As String, ByVal BalanceAmount As String, ByVal PaymentMode As String, ByVal BankName As String, ByVal ChecqueNo As String)
        ClsMembershipRenewalDtls.AddMembershipRenewalDtls(MembershipID, RenewalDate, PackageID, ValidUpto, TotalFee, PaidFee, BalanceAmount, PaymentMode, BankName, ChecqueNo)
    End Sub
    Public Sub CellClickMembershipRenewal(ByVal e As Object)
        ClsMembershipRenewalDtls.CellClickMembershipRenewal(e)
    End Sub
    Public Sub UpdateMembershipRenewalDtls(ByVal MembershipID As String, ByVal RenewalDate As String, ByVal PackageID As String, ByVal ValidUpto As String, ByVal TotalFee As String, ByVal PaidFee As String, ByVal BalanceAmount As String, ByVal PaymentMode As String, ByVal BankName As String, ByVal ChecqueNo As String)
        ClsMembershipRenewalDtls.UpdateMembershipRenewalDtls(MembershipID, RenewalDate, PackageID, ValidUpto, TotalFee, PaidFee, BalanceAmount, PaymentMode, BankName, ChecqueNo)
    End Sub
    Public Sub navigationMembershipRenewal()
        ClsMembershipRenewalDtls.navigationMembershipRenewal()
    End Sub
#End Region

#Region "Instructor"

    Public Sub GenerateInstructorId()
        clsInstructor.GenerateInstructorId()
    End Sub
    Public Sub ClearTextInstructor()
        clsInstructor.ClearTextInstructor()
    End Sub
    Public Sub CheckTextInstructor()
        clsInstructor.CheckTextInstructor()
    End Sub
    Public Sub DisplayDataInstructor()
        clsInstructor.DisplayDataInstructor()
    End Sub
    Public Sub AddInstructor(ByVal InstructorID As String, ByVal InstructorName As String, ByVal Address As String, ByVal MobileNo As String, ByVal Expert As String, ByVal DOJ As String, ByVal Gender As String)
        clsInstructor.AddInstructor(InstructorID, InstructorName, Address, MobileNo, Expert, DOJ, Gender)
    End Sub
    Public Sub UpdateInstructor(ByVal InstructorID As String, ByVal InstructorName As String, ByVal Address As String, ByVal MobileNo As String, ByVal Expert As String, ByVal DOJ As String, ByVal Gender As String)
        clsInstructor.UpdateInstructor(InstructorID, InstructorName, Address, MobileNo, Expert, DOJ, Gender)
    End Sub
    Public Sub DeleteInstructor(ByVal InstructorID As String)
        clsInstructor.DeleteInstructor(InstructorID)
    End Sub
    Public Sub CellClickInstructor(ByVal e As Object)
        clsInstructor.CellClickInstructor(e)
    End Sub
    Public Sub SearchInstructor(ByVal objInstructor As Object)
        clsInstructor.SearchInstructor(objInstructor)
    End Sub
    Public Sub navigationInstructor()
        clsInstructor.navigationInstructor()
    End Sub
#End Region

#Region "Health Details"

    Public Sub DisplayDataHealth()
        clsHealthDtls.DisplayDataHealth()
    End Sub
    Public Sub GenerateHealthId()
        clsHealthDtls.GenerateHealthId()
    End Sub
    Public Sub ClearTextHealth()
        clsHealthDtls.ClearTextHealth()
    End Sub
    Public Sub CheckTextHealth()
        clsHealthDtls.CheckTextHealth()
    End Sub
    Public Sub CellClickHealth(ByVal e As Object)
        clsHealthDtls.CellClickHealth(e)
    End Sub
    Public Sub AddHealthDtls(ByVal HealthID As String, ByVal Height As String, ByVal Weight As String, ByVal HeartBeat As String, ByVal BMI As String, ByVal Chest As String, ByVal Waist As String, ByVal Biceps As String)
        clsHealthDtls.AddHealthDtls(HealthID, Height, Weight, HeartBeat, BMI, Chest, Waist, Biceps)
    End Sub
    Public Sub UpdateHealthDtls(ByVal HealthID As String, ByVal Height As String, ByVal Weight As String, ByVal HeartBeat As String, ByVal BMI As String, ByVal Chest As String, ByVal Waist As String, ByVal Biceps As String)
        clsHealthDtls.UpdateHealthDtls(HealthID, Height, Weight, HeartBeat, BMI, Chest, Waist, Biceps)
    End Sub
    Public Sub navigationHealth()
        clsHealthDtls.navigationHealth()
    End Sub
#End Region

#Region "Health Check Up"

    Public Sub DisplayDataHealthCheckUp()
        clsHealthCheckUp.DisplayDataHealthCheckUp()
    End Sub
    Public Sub CheckTextHealthCheckUp()
        clsHealthCheckUp.CheckTextHealthCheckUp()
    End Sub
    Public Sub ClearTextHealthCheckUp()
        clsHealthCheckUp.ClearTextHealthCheckUp()
    End Sub
    Public Sub CellClickHealthCheckUp(ByVal e As Object)
        frmHealthCheckUp.btn_save.Enabled = False
        clsHealthCheckUp.CellClickHealthCheckUp(e)
    End Sub
    Public Sub AddHealthCheckUpDtls(ByVal HealthID As String, ByVal MemberID As String, ByVal Month As String, ByVal MonthCount As String, ByVal CheckUpDate As String)
        clsHealthCheckUp.AddHealthCheckUpDtls(HealthID, MemberID, Month, MonthCount, CheckUpDate)
    End Sub
    Public Sub UpdateHealthCheckUpDtls(ByVal HealthID As String, ByVal MemberID As String, ByVal Month As String, ByVal MonthCount As String, ByVal CheckUpDate As String)
        clsHealthCheckUp.UpdateHealthCheckUpDtls(HealthID, MemberID, Month, MonthCount, CheckUpDate)
    End Sub
    Public Sub navigationHealthCheckUp()
        clsHealthCheckUp.navigationHealthCheckUp()
    End Sub
#End Region

#Region "Attendence"

    Public Sub DisplayDataAttendence()
        clsAttendence.DisplayDataAttendence()
    End Sub
    Public Sub CheckTextAttendence()
        clsAttendence.CheckTextAttendence()
    End Sub

    Public Sub ClearTextAttendence()
        clsAttendence.ClearTextAttendence()
    End Sub

    Public Sub CellClickAttendence(ByVal e As Object)
        clsAttendence.CellClickAttendence(e)
    End Sub

    Public Sub AddAttendence(ByVal MemberID As String, ByVal MemDate As String, ByVal Status As String, ByVal Intime As String, ByVal OutTime As String)
        clsAttendence.AddAttendence(MemberID, MemDate, Status, Intime, OutTime)
    End Sub

    Public Sub UpdateAttendence(ByVal MemberID As String, ByVal MemDate As String, ByVal Status As String, ByVal Intime As String, ByVal OutTime As String)
        clsAttendence.UpdateAttendence(MemberID, MemDate, Status, Intime, OutTime)
    End Sub
    Public Sub navigationAttendence()
        clsAttendence.navigationAttendence()
    End Sub
#End Region

#Region "Facility"

    Public Sub DisplayDataFacility()
        clsFacility.DisplayDataFacility()
    End Sub

    Public Sub GenerateFacilityId()
        clsFacility.GenerateFacilityId()
    End Sub

    Public Sub CheckTextFacility()
        clsFacility.CheckTextFacility()
    End Sub

    Public Sub ClearTextFacility()
        clsFacility.ClearTextFacility()
    End Sub

    Public Sub CellClickFacility(ByVal e As Object)
        clsFacility.CellClickFacility(e)
    End Sub

    Public Sub AddFacility(ByVal FacilityID As String, ByVal FacilityName As String, ByVal Charges As String, ByVal Frequency As String, ByVal Status As String)
        clsFacility.AddFacility(FacilityID, FacilityName, Charges, Frequency, Status)
    End Sub
    Public Sub UpdateFacility(ByVal FacilityID As String, ByVal FacilityName As String, ByVal Charges As String, ByVal Frequency As String, ByVal Status As String)
        clsFacility.UpdateFacility(FacilityID, FacilityName, Charges, Frequency, Status)
    End Sub
    Public Sub navigationFacility()
        clsFacility.navigationFacility()
    End Sub
#End Region

#Region "Package"

    Public Sub DisplayDataPackage()
        clsPackage.DisplayDataPackage()
    End Sub
    Public Sub BindFacilityDtls()
        clsPackage.BindFacilityDtls()
    End Sub

    Public Sub GeneratePackageId()
        clsPackage.GeneratePackageId()
    End Sub
    Public Sub CheckTextPackage()
        clsPackage.CheckTextPackage()
    End Sub
    Public Sub ClearTextPackage()
        clsPackage.ClearTextPackage()
    End Sub
    Public Sub CellClickPackage(ByVal e As Object)
        clsPackage.CellClickPackage(e)
    End Sub
    Public Sub AddPackage(ByVal PackageID As String, ByVal PackageName As String, ByVal PackageAmount As String, ByVal PackageTerms As String, ByVal ActiveStatus As String, ByVal NoOfInstallments As String)
        clsPackage.AddPackage(PackageID, PackageName, PackageAmount, PackageTerms, ActiveStatus, NoOfInstallments)
    End Sub
    Public Sub UpdatePackage(ByVal PackageID As String, ByVal PackageName As String, ByVal PackageAmount As String, ByVal PackageTerms As String, ByVal ActiveStatus As String, ByVal NoOfInstallments As String)
        clsPackage.UpdatePackage(PackageID, PackageName, PackageAmount, PackageTerms, ActiveStatus, NoOfInstallments)
    End Sub
    Public Sub navigationPackage()
        clsPackage.navigationPackage()
    End Sub
    Public Sub addPackageMapping(ByVal PackageID As String, ByVal FacilityID As String)
        clsPackage.addPackageMapping(PackageID, FacilityID)
    End Sub
#End Region

End Class
