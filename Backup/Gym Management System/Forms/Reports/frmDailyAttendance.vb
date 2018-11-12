Imports Gym_Management_System.DBConnection
Imports Gym_Management_System.DBFunction
Public Class frmDailyAttendance
#Region "Declaration"
    Dim clsDbFun As New DBFunction
#End Region

    Private Sub btn_ShowReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ShowReport.Click
        Try
            Dim str As String
            str = String.Empty
            str = "select A.Attdate ,B.MemberID , B.MemberName , B.Gender , A.status , A.Intime , A.OutTime  from AttendenceTable A , MemberDetails B where Attdate='" & dtp_FromDate.Text & "' and a.MemberID = B.MemberID "
            Dim ds_acc As New DataSet
            ds_acc = clsDbFun.SelectQuery(str)
            Dim obj_rptacc As New RptAttendance
            ds_acc.WriteXmlSchema("D:\Attendance.xsd")
            obj_rptacc.SetDataSource(ds_acc.Tables(0))
            CrystalReportViewer1.ReportSource = obj_rptacc
            CrystalReportViewer1.Show()
        Catch ex As Exception

        End Try
    End Sub
End Class