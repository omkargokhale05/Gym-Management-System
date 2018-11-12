Imports Gym_Management_System.DBConnection
Imports Gym_Management_System.DBFunction

Public Class frmCheckupRepot
    Dim clsDbFun As New DBFunction
    Private Sub frmCheckupRepot_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clsDbFun.BindCombo("exec BindMember  ",cmbMemId)
    End Sub

    Private Sub cmbMemId_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbMemId.SelectedIndexChanged
        Try
            Dim str As String
            str = String.Empty
            str = "select b.MemberName , b.MobileNo , a.CheckUpDate , a.Month , a.MonthCount , a.Height , a.Weight , a.HeartBeat , a.BMI , a.Chest , a.Waist , a.Biceps  from (select a.MemberID , a.Month , a.MonthCount , a.CheckUpDate , b.Height , b.Weight , b.HeartBeat ,b.BMI , b.Chest , b.Waist , b.Biceps  from HealthCheckUp a, HealthDetails b where a.MemberID = ' " & cmbMemId.SelectedValue & "' and a.HealthID = b.HealthID) a ,(select MemberID ,MemberName , MobileNo  from MemberDetails ) b where(a.MemberID = b.MemberID)"
            Dim ds_acc As New DataSet
            ds_acc = clsDbFun.SelectQuery(str)
            Dim obj_rptacc As New RptHealthCheckUp
            ds_acc.WriteXmlSchema("D:\HealthCheckup.xsd")
            obj_rptacc.SetDataSource(ds_acc.Tables(0))
            CrystalReportViewer1.ReportSource = obj_rptacc
            CrystalReportViewer1.Show()
        Catch ex As Exception

        End Try
    End Sub
End Class